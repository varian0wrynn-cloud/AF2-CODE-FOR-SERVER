using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000186 RID: 390
public class UISettingWin : MonoBehaviour
{
	// Token: 0x06005667 RID: 22119 RVA: 0x00281928 File Offset: 0x0027FB28
	public void HDPKGCHGAFJ()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, false);
			}
			Debug.Log("_FogData");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ABHIJHKJPCC();
		}
		else
		{
			Debug.Log("shop_t17");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.OAPNFDMFJLH();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.GJBLOODIBAJ();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF)
			{
				Debug.Log("IdleStrafeLeft");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("gi_um_nosel", JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF);
				JNBICAJIJMM.IMLLGEMPHAP().EMHNEMCMPAK();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].setAmbientVolume();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BHLPMMIMGCA(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.BLONDGFMDOO();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.OFDEDAMGDBB();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005668 RID: 22120 RVA: 0x00281D20 File Offset: 0x0027FF20
	private void NGMMNKHDOPG()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("DealerIdle" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("_LumTex" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("error.wav" + Screen.currentResolution);
		this.CCPFKECJIHE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.BMAGNENCBPF(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.JOIBLOCGKDH(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.IKGFHGKKCPG.KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x06005669 RID: 22121 RVA: 0x00282158 File Offset: 0x00280358
	public void GDPCDKMPJMM()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, false);
			}
			Debug.Log("<");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
		}
		else
		{
			Debug.Log("SwimDogPaddle");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.OKKCEPFAMJE();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.HBNBOPMMJPC();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF)
			{
				Debug.Log("---");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("WeaponRun", JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF);
				JNBICAJIJMM.EEOPOHEALPK().KKPOKAPAPBH();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j += 0)
				{
					array2[j].CPPIDOFDAFE();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GPMGFJIBIBP(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.FIGODKAFCHM();
			HPGKIJLKCIH.IKGFHGKKCPG.OPMELPECMEF();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600566A RID: 22122 RVA: 0x00282550 File Offset: 0x00280750
	public void KINBFFPADNE()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("uint:");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
		}
		else
		{
			Debug.Log("");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.OAPNFDMFJLH();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.AFAHMKKKHLF();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF)
			{
				Debug.Log("Dummy");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("", JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF);
				JNBICAJIJMM.EEOPOHEALPK().CFJDCIHPOCN();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].NNJMDFGKKDC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GPMGFJIBIBP(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.FIGODKAFCHM();
			HPGKIJLKCIH.IKGFHGKKCPG.CHALJKCDOOJ();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600566B RID: 22123 RVA: 0x00282948 File Offset: 0x00280B48
	private void OGMACADJFIN()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.FPPGDHJOPKH();
	}

	// Token: 0x0600566C RID: 22124 RVA: 0x00282954 File Offset: 0x00280B54
	private void KFLFNGGBAEB()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("Katana Upper Block" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("Windmill" + Screen.currentResolution);
		this.EPGEOPCPAPD();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.ODGOGPJGJNE(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.CLBPBJGLHEE = HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP;
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.CLIMNFDGOEG().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600566D RID: 22125 RVA: 0x00282D8C File Offset: 0x00280F8C
	public void EJDBAPGDCGC()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1207f + (this.poplpitch.value - 1343f) * 1808f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600566E RID: 22126 RVA: 0x00282E1C File Offset: 0x0028101C
	private void OPELLEGPAGB()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= 99)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format(",", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 59;
			string item4 = string.Format("", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x0600566F RID: 22127 RVA: 0x00282F9C File Offset: 0x0028119C
	private void CCPFKECJIHE()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= -3)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Window", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 18;
			string item4 = string.Format("error", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005670 RID: 22128 RVA: 0x0028311C File Offset: 0x0028131C
	private void PGINIFCIHKG()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip = array[i];
				list2.Add("IceHockeyGoalieReady" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("act_orderb_" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("_SoftZDistance" + Screen.currentResolution);
		this.HKIPNJMMNHF();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.PNAGIDKJJPG(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.OPNDBKDNILD(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.IMLLGEMPHAP().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x06005671 RID: 22129 RVA: 0x00283554 File Offset: 0x00281754
	public void GKLOIGFJJMA()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("ClimbUp");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		}
		else
		{
			Debug.Log("SkateboardKickPush");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.JOGKKPKIAIK();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.LHBENMOJFMD();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF)
			{
				Debug.Log("demoUint");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("error.wav", JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF);
				JNBICAJIJMM.APMJBBDBOJO().CFJDCIHPOCN();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j += 0)
				{
					array2[j].FACAPJFOAJC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GPMGFJIBIBP(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
			HPGKIJLKCIH.IKGFHGKKCPG.OPICFLAELDI();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.OFDEDAMGDBB();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005672 RID: 22130 RVA: 0x0028394C File Offset: 0x00281B4C
	private void GAOCGDLONBN()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.LMCJCGGBCBF();
	}

	// Token: 0x06005673 RID: 22131 RVA: 0x00283958 File Offset: 0x00281B58
	public void KCFPJNGFHLC()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, true);
			}
			Debug.Log("_Params");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.KBAMNGNODEM();
		}
		else
		{
			Debug.Log("The InteractionTrigger in the list 'inContact' has been destroyed");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.EFPCKGKGHKO();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.LAAGKLPICID();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF)
			{
				Debug.Log("");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("t_top", JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF);
				JNBICAJIJMM.CLIMNFDGOEG().KAIJNCFAPMG();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].setAmbientVolume();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GJLOGFIFCJE(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.OPMELPECMEF();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005674 RID: 22132 RVA: 0x00283D50 File Offset: 0x00281F50
	private void Awake()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.PINLMCCKKNA();
	}

	// Token: 0x06005675 RID: 22133 RVA: 0x00283D5C File Offset: 0x00281F5C
	public void CPGAAAKANDN()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("priceCr");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
		}
		else
		{
			Debug.Log("wpn_book2");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.EFPCKGKGHKO();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.LHBENMOJFMD();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF)
			{
				Debug.Log("");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("currentCount=", JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF);
				JNBICAJIJMM.APMJBBDBOJO().OAIOKDBPGOL();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].CPPIDOFDAFE();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GPMGFJIBIBP(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
			HPGKIJLKCIH.IKGFHGKKCPG.IPOJHOJDBGG();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.OFDEDAMGDBB();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005676 RID: 22134 RVA: 0x00284154 File Offset: 0x00282354
	private void PJHOJFBJAHG()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -7)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("_MainTex", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -107;
			string item4 = string.Format("<color='#100000'>{0} {1}</color>", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005677 RID: 22135 RVA: 0x002842D4 File Offset: 0x002824D4
	public void JOKJPEBMCEI()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.KBAMNGNODEM();
		}
		else
		{
			Debug.Log("ForwardVelocity");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.MEDKOLLJHJM();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.MFLOHEOEDPA();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.EKEBHIJMEML().LCHEIFBGJMF)
			{
				Debug.Log("32");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("_FogOfWarSize", JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF);
				JNBICAJIJMM.APMJBBDBOJO().OAIOKDBPGOL();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].CPPIDOFDAFE();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.NCEAPBFBCGC(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.IDNBEAMFKPD();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.OFDEDAMGDBB();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005678 RID: 22136 RVA: 0x002846CC File Offset: 0x002828CC
	private void MJMMOFELPBM()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.NACGALHGHJD();
	}

	// Token: 0x06005679 RID: 22137 RVA: 0x002846D8 File Offset: 0x002828D8
	private void DEGFGIDFFLD()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("gi_letgohe" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("FrontKick" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log(" for " + Screen.currentResolution);
		this.LEPNGLMIAJE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.DHHPDLNDKDO(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.OPNDBKDNILD(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.LPHMKPDBMPP().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600567A RID: 22138 RVA: 0x00284B10 File Offset: 0x00282D10
	public void EOHGPFIMBCB()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, false);
			}
			Debug.Log("RollerBladeSkateFwd");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
		}
		else
		{
			Debug.Log("RollerBladeStop");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.DEAKHMNAKDD();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.OECMNDMLGKO();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF)
			{
				Debug.Log("Palm");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("RunBackLeft", JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF);
				JNBICAJIJMM.LPHMKPDBMPP().CPJELOEFNIM();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].NNJMDFGKKDC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GJLOGFIFCJE(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
			HPGKIJLKCIH.IKGFHGKKCPG.AMHCEKEFEPB();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600567B RID: 22139 RVA: 0x00284F08 File Offset: 0x00283108
	private void HMNENPKHGLB()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= 1024)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("{0} x {1}", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 60;
			string item4 = string.Format("{0} x {1}", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x0600567C RID: 22140 RVA: 0x00285088 File Offset: 0x00283288
	private void FJBPGBMDBBF()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("_Saturation" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("isPaint" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("wpn_rod1" + Screen.currentResolution);
		this.CCPFKECJIHE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.IOOBCALMHIF(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.ODGOGPJGJNE(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600567D RID: 22141 RVA: 0x002854C0 File Offset: 0x002836C0
	public void ELGFMFBEEHM()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1786f + (this.rollpitch.value - 1104f) * 286f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x00285550 File Offset: 0x00283750
	private void EMMGGBELGMM()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -60)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Jump", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -8;
			string item4 = string.Format("</color>\n", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x002856D0 File Offset: 0x002838D0
	private void LEPNGLMIAJE()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= 18)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Press E to resume interaction", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 29;
			string item4 = string.Format("demoVector3", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005680 RID: 22144 RVA: 0x0028584F File Offset: 0x00283A4F
	private void PFONEFANOIJ()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.HGFCGPNEOHO();
	}

	// Token: 0x06005681 RID: 22145 RVA: 0x0028585C File Offset: 0x00283A5C
	public void BGEKLOJIMOP()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1850f + (this.rollpitch.value - 1216f) * 1080f;
			this.audsrc.Play();
		}
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x002858EC File Offset: 0x00283AEC
	public void BAKBDEACIOM()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 256f + (this.rollpitch.value - 92f) * 1600f;
			this.audsrc.Play();
		}
	}

	// Token: 0x06005683 RID: 22147 RVA: 0x0028597C File Offset: 0x00283B7C
	private void IGHKOEAFBBI()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= 84)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("wpn_iwgt", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 100;
			string item4 = string.Format("Level: ", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005684 RID: 22148 RVA: 0x00285AFC File Offset: 0x00283CFC
	public void LEBNJPGFJCA()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 116f + (this.rollpitch.value - 1211f) * 1607f;
			this.audsrc.Play();
		}
	}

	// Token: 0x06005685 RID: 22149 RVA: 0x002846CC File Offset: 0x002828CC
	private void IOIJGMFNBMC()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.NACGALHGHJD();
	}

	// Token: 0x06005686 RID: 22150 RVA: 0x00285B8C File Offset: 0x00283D8C
	private void AKPLEHHPKGC()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("Channel Cast Omni" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("toquality=" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("No fish in fishModelData modelid=" + Screen.currentResolution);
		this.BEELPOFBCGE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.LLCELDBGGHE(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.BBAAPKHGAME(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.LPHMKPDBMPP().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x06005687 RID: 22151 RVA: 0x00285FC4 File Offset: 0x002841C4
	public void ONIGJIOKGHP()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("Turn");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
		}
		else
		{
			Debug.Log("_Parameter");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.AFAHMKKKHLF();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.FBOPHFDGHFO();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF)
			{
				Debug.Log("*********read ");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("[Z]", JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF);
				JNBICAJIJMM.EEOPOHEALPK().JCIPCJBOFGJ();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].FACAPJFOAJC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BHLPMMIMGCA(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
			HPGKIJLKCIH.IKGFHGKKCPG.AMHCEKEFEPB();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005688 RID: 22152 RVA: 0x002863BC File Offset: 0x002845BC
	public void IDHBAFHJGKB()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("FacePalm");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HMILPFFOPHE();
		}
		else
		{
			Debug.Log("cntx_razb");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.JOGKKPKIAIK();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.KHMLJOKAMMM();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF)
			{
				Debug.Log("\n");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("wpnlang/wpntypes/type DUBLICATE ", JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF);
				JNBICAJIJMM.EEOPOHEALPK().OAIOKDBPGOL();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].NNJMDFGKKDC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.PHBAOHENJCM(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.CHALJKCDOOJ();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005689 RID: 22153 RVA: 0x002867B4 File Offset: 0x002849B4
	private void AOABMLPHMME()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("Bait VELO=" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("https://groups.google.com/forum/#!forum/final-ik" + Screen.currentResolution);
		this.HMNENPKHGLB();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.ODGOGPJGJNE(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.NDJLJNNFFKC(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.DBMJJPBOPEK().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600568A RID: 22154 RVA: 0x00286BEC File Offset: 0x00284DEC
	public void OOEJMBPNAMJ()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log(" iterations for read and write");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		}
		else
		{
			Debug.Log("_Offsets");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.FMOBOOGIFEB();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.HPIAIKAOBFE();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF)
			{
				Debug.Log("WoodSaw");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("Katana", JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF);
				JNBICAJIJMM.EDKGBBIIBBC().JCIPCJBOFGJ();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j += 0)
				{
					array2[j].setAmbientVolume();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GJLOGFIFCJE(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.EONAIFCDNBB();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600568B RID: 22155 RVA: 0x00286FE4 File Offset: 0x002851E4
	private void DJEKNFIFAEK()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("Hidden/Amplify Color/DepthMaskBlend" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("act_order" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("Elina" + Screen.currentResolution);
		this.NBHNACLAFKF();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.ODGOGPJGJNE(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.BMAGNENCBPF(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600568C RID: 22156 RVA: 0x0028741C File Offset: 0x0028561C
	public void GOMMKFCLGNK()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 663f + (this.rollpitch.value - 345f) * 894f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600568D RID: 22157 RVA: 0x0028584F File Offset: 0x00283A4F
	private void DPNNENHAGOE()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.HGFCGPNEOHO();
	}

	// Token: 0x0600568E RID: 22158 RVA: 0x002874AC File Offset: 0x002856AC
	public void CPFIGKOBPPD()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 608f + (this.rollpitch.value - 1531f) * 1304f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600568F RID: 22159 RVA: 0x0028753C File Offset: 0x0028573C
	private void HJGFBNMJOOM()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.PBDMAGJEBEJ();
	}

	// Token: 0x06005690 RID: 22160 RVA: 0x00287548 File Offset: 0x00285748
	private void HEBGFFJFEJJ()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.JGKKAKJIMEK();
	}

	// Token: 0x06005691 RID: 22161 RVA: 0x00287554 File Offset: 0x00285754
	public void AABNIOJKDMG()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
		}
		else
		{
			Debug.Log("toe");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.LKLEBPJMEJI();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.LKLEBPJMEJI();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF)
			{
				Debug.Log("Actor_");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("Inventory manager is init", JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF);
				JNBICAJIJMM.EKEBHIJMEML().KAIJNCFAPMG();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j += 0)
				{
					array2[j].setAmbientVolume();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.MPKJKBLJEOE(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
			HPGKIJLKCIH.IKGFHGKKCPG.IDNBEAMFKPD();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.OFDEDAMGDBB();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005692 RID: 22162 RVA: 0x0028794C File Offset: 0x00285B4C
	private void PMDCDECMOOE()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.JPOIFEGNBAA();
	}

	// Token: 0x06005693 RID: 22163 RVA: 0x00287958 File Offset: 0x00285B58
	public void FHIDDNNJBMC()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("Screen Space Reflection");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		}
		else
		{
			Debug.Log("_r_");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.FBOPHFDGHFO();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.OAPNFDMFJLH();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF)
			{
				Debug.Log("Cheer Jump");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("?", JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF);
				JNBICAJIJMM.EEOPOHEALPK().KAIJNCFAPMG();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j += 0)
				{
					array2[j].HOBEMDBDKCI();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.MPKJKBLJEOE(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
			HPGKIJLKCIH.IKGFHGKKCPG.CHALJKCDOOJ();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06005694 RID: 22164 RVA: 0x00287D50 File Offset: 0x00285F50
	public void FNLEANIAONH()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 987f + (this.rollpitch.value - 611f) * 479f;
			this.audsrc.Play();
		}
	}

	// Token: 0x06005695 RID: 22165 RVA: 0x00287DE0 File Offset: 0x00285FE0
	private void EPGEOPCPAPD()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -125)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Bases/1.base", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -61;
			string item4 = string.Format("cut.ogg", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005696 RID: 22166 RVA: 0x00287F60 File Offset: 0x00286160
	private void LCHNNLIOOJA()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -200)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("wpn_drop", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -24;
			string item4 = string.Format("Speed hack Detected!", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x06005698 RID: 22168 RVA: 0x00288100 File Offset: 0x00286300
	public void JJAMICDDBDA()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 675f + (this.poplpitch.value - 287f) * 1482f;
			this.audsrc.Play();
		}
	}

	// Token: 0x06005699 RID: 22169 RVA: 0x00288190 File Offset: 0x00286390
	private void OCIANPBJNND()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("move" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("Delete" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("_threshold" + Screen.currentResolution);
		this.HKIPNJMMNHF();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.MBEBCMMHMKG(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.CLBPBJGLHEE = HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP;
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.EEOPOHEALPK().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x0600569A RID: 22170 RVA: 0x002885C8 File Offset: 0x002867C8
	public void CEPCIHCEGEC()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 183f + (this.rollpitch.value - 489f) * 1347f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600569B RID: 22171 RVA: 0x00288658 File Offset: 0x00286858
	public void OPJEJJPDHEA()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, true);
			}
			Debug.Log("Cowboy1HandDraw");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
		}
		else
		{
			Debug.Log("Server is closed");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.KHMLJOKAMMM();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.FMOBOOGIFEB();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF)
			{
				Debug.Log("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("TOD_World2Sky", JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF);
				JNBICAJIJMM.APMJBBDBOJO().CPJELOEFNIM();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].FACAPJFOAJC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GPMGFJIBIBP(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
			HPGKIJLKCIH.IKGFHGKKCPG.GLOJPAHBIOH();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600569C RID: 22172 RVA: 0x00288A50 File Offset: 0x00286C50
	public void FINEKCBHKFE()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 26f + (this.poplpitch.value - 1561f) * 1935f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x00288AE0 File Offset: 0x00286CE0
	private void NBHNACLAFKF()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= 111)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("_BilateralUpsampling", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -121;
			string item4 = string.Format("Builtin Debug Views", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x0600569E RID: 22174 RVA: 0x00288C60 File Offset: 0x00286E60
	public void JKMBNKIMAKL()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 526f + (this.poplpitch.value - 973f) * 1314f;
			this.audsrc.Play();
		}
	}

	// Token: 0x0600569F RID: 22175 RVA: 0x00288CF0 File Offset: 0x00286EF0
	public void GPLLBIEGDKK()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 204f + (this.poplpitch.value - 1155f) * 1936f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A0 RID: 22176 RVA: 0x00288D80 File Offset: 0x00286F80
	private void DNCMJGPBNJG()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= -186)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Cheer Jump", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 11;
			string item4 = string.Format("SoccerKeeperReady", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056A1 RID: 22177 RVA: 0x00288F00 File Offset: 0x00287100
	public void PLDMMEPNAMM()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1637f + (this.poplpitch.value - 1531f) * 973f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A2 RID: 22178 RVA: 0x00288F90 File Offset: 0x00287190
	public void EMHELNPOCNO()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, false);
			}
			Debug.Log("Add random value");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.FIGODKAFCHM();
		}
		else
		{
			Debug.Log("<color='{1}'>{0}</color>");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.GJBLOODIBAJ();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.OKKCEPFAMJE();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF)
			{
				Debug.Log("id");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("Wizard Neo Block", JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF);
				JNBICAJIJMM.EDKGBBIIBBC().JCIPCJBOFGJ();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].NNJMDFGKKDC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.PHBAOHENJCM(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
			HPGKIJLKCIH.IKGFHGKKCPG.IPOJHOJDBGG();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x00289388 File Offset: 0x00287588
	public void IBMLECNHOFM()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 144f + (this.poplpitch.value - 741f) * 279f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x00289418 File Offset: 0x00287618
	public void poplPlay()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1f + (this.poplpitch.value - 0.5f) * 0.3f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x002894A8 File Offset: 0x002876A8
	public void KCAJAODFPEE()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1008f + (this.rollpitch.value - 1516f) * 592f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A6 RID: 22182 RVA: 0x00289538 File Offset: 0x00287738
	private void ALHFPHHGIHK()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 0; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("DISTORT" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("_SampleMip" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("_WaveScale" + Screen.currentResolution);
		this.OPELLEGPAGB();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.MLFDFMDCNEA(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.PNPCNACBFHP(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x00289970 File Offset: 0x00287B70
	public void CCDMFAIBJEL()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1235f + (this.poplpitch.value - 752f) * 1953f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x00289A00 File Offset: 0x00287C00
	private void OnEnable()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("Sound #" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("Sound #" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("***Setting OnEnable " + Screen.currentResolution);
		this.HMNENPKHGLB();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.CLBPBJGLHEE = HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH;
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.CLBPBJGLHEE = HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP;
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.IKGFHGKKCPG.KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x00289E38 File Offset: 0x00288038
	private void CABDFNIKOOI()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip = array[i];
				list2.Add(" " + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("hip" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!" + Screen.currentResolution);
		this.LCHNNLIOOJA();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.MLFDFMDCNEA(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.AOLPKBLGOJJ(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.EDKGBBIIBBC().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x0028A270 File Offset: 0x00288470
	private void FDMGAGCBBDP()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip = array[i];
				list2.Add("offsets" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("  locid=" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("IKSolverFABRIKRoot chain at index " + Screen.currentResolution);
		this.BOJONMMEGAL();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.PNAGIDKJJPG(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.APCHBAMKBML(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.IMLLGEMPHAP().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056AB RID: 22187 RVA: 0x0028A6A8 File Offset: 0x002888A8
	private void OBHJJBGKEOG()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= -42)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("click Refresh currentQcat=", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -34;
			string item4 = string.Format("_EMISSION", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x0028A827 File Offset: 0x00288A27
	private void JIIBCGJJLND()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.AFGPHPBPJJP();
	}

	// Token: 0x060056AD RID: 22189 RVA: 0x0028A834 File Offset: 0x00288A34
	public void DNJHNPIOEEE()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, true);
			}
			Debug.Log("/");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HNPKHFHOCHP();
		}
		else
		{
			Debug.Log("Player");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.FBOPHFDGHFO();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.DEAKHMNAKDD();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF)
			{
				Debug.Log("_ALPHATEST_ON");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("[AmplifyColor] ", JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF);
				JNBICAJIJMM.IMLLGEMPHAP().CFJDCIHPOCN();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].CPPIDOFDAFE();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.MDBKEPOGMBL(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.ABHIJHKJPCC();
			HPGKIJLKCIH.IKGFHGKKCPG.CHALJKCDOOJ();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056AE RID: 22190 RVA: 0x0028AC2C File Offset: 0x00288E2C
	public void CMOJEOHBFFI()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1639f + (this.rollpitch.value - 1655f) * 448f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056AF RID: 22191 RVA: 0x0028ACBC File Offset: 0x00288EBC
	private void JIECHHCLLEL()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= 186)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 87;
			string item4 = string.Format("UNDISTORT", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056B0 RID: 22192 RVA: 0x0028AE3C File Offset: 0x0028903C
	public void ADLFJJHFGNI()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 481f + (this.rollpitch.value - 954f) * 78f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056B1 RID: 22193 RVA: 0x0028AECC File Offset: 0x002890CC
	public void EOHOBKGIBKE()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 816f + (this.rollpitch.value - 87f) * 1450f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x0028AF5C File Offset: 0x0028915C
	public void OFJHFEGKOBM()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("Проверьте правильность логина и пароля!");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OJKPLHEAHGK();
		}
		else
		{
			Debug.Log(" ");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.HBNBOPMMJPC();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.MEDKOLLJHJM();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF)
			{
				Debug.Log("wpn_timed");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("_ColorBuffer", JNBICAJIJMM.CLIMNFDGOEG().LCHEIFBGJMF);
				JNBICAJIJMM.DBMJJPBOPEK().OAIOKDBPGOL();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].CPPIDOFDAFE();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.PHBAOHENJCM(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.HAINEMDDILG();
			HPGKIJLKCIH.IKGFHGKKCPG.OPICFLAELDI();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x0028B354 File Offset: 0x00289554
	private void KHGBGDAJOHG()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= -1)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("Arm Flex 3", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 97;
			string item4 = string.Format("HA", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x0028B4D4 File Offset: 0x002896D4
	public void JGMJLOJFJFH()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1097f + (this.poplpitch.value - 481f) * 37f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056B5 RID: 22197 RVA: 0x0028B564 File Offset: 0x00289764
	public void OIELJIPLAOP()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 714f + (this.rollpitch.value - 1321f) * 1480f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x0028B5F4 File Offset: 0x002897F4
	private void OHPHJCGMNGD()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 0; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("\n" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("wpn/" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("AssetLoaderCoroutine" + Screen.currentResolution);
		this.NBHNACLAFKF();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.KIEKFHBIIKA(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.PNAGIDKJJPG(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.EKEBHIJMEML().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056B7 RID: 22199 RVA: 0x0028BA2C File Offset: 0x00289C2C
	private void BEELPOFBCGE()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= 77)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("more", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -30;
			string item4 = string.Format("", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056B8 RID: 22200 RVA: 0x0028BBAC File Offset: 0x00289DAC
	private void KBNDKLLOLPF()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= 193)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("_FogOfWarCenter", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -54;
			string item4 = string.Format("gameComplete", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x0028BD2C File Offset: 0x00289F2C
	public void DJLCJPCGPAM()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("_Curve");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
		}
		else
		{
			Debug.Log("_BilateralUpsampling");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.MEDKOLLJHJM();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.EKICBEPMMFM();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IMLLGEMPHAP().LCHEIFBGJMF)
			{
				Debug.Log("Jump");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("WandStand", JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF);
				JNBICAJIJMM.APMJBBDBOJO().DIINOACMHKH();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].FACAPJFOAJC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.OMHJJHECJPC(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.KBAMNGNODEM();
			HPGKIJLKCIH.IKGFHGKKCPG.EGIJIAINEBP();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x00287548 File Offset: 0x00285748
	private void FMNCGCBFJKE()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.JGKKAKJIMEK();
	}

	// Token: 0x060056BB RID: 22203 RVA: 0x0028394C File Offset: 0x00281B4C
	private void CBBIADNKMLI()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.LMCJCGGBCBF();
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x0028C124 File Offset: 0x0028A324
	public void HIJGOOIFOJD()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 762f + (this.poplpitch.value - 1903f) * 202f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x0028C1B4 File Offset: 0x0028A3B4
	public void Confirm()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			Debug.Log("Apply in GAME 1");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		}
		else
		{
			Debug.Log("Apply out GAME 1");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.CLBPBJGLHEE;
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.CLBPBJGLHEE;
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i++)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF)
			{
				Debug.Log("Apply RELANG");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("languageid", JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF);
				JNBICAJIJMM.IKGFHGKKCPG.LDMKDIPEGMJ();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].setAmbientVolume();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BHLPMMIMGCA(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
			HPGKIJLKCIH.IKGFHGKKCPG.DFFOHPOKHAJ();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x0028C5AC File Offset: 0x0028A7AC
	private void NCEAHAPIPAP()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= 31)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 1)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -27;
			string item4 = string.Format("IdleSad", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x0028C72C File Offset: 0x0028A92C
	public void rollPlay()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1f + (this.rollpitch.value - 0.5f) * 0.3f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056C0 RID: 22208 RVA: 0x0028C7BC File Offset: 0x0028A9BC
	private void FJBLENKCADE()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -11)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("wpn_chair1", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -21;
			string item4 = string.Format("SpinReel.ogg", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x0028C93C File Offset: 0x0028AB3C
	private void NNMCJGHPNAE()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= -26)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("---", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 74;
			string item4 = string.Format("CM", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x002846CC File Offset: 0x002828CC
	private void AKGBDJDMOLC()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.NACGALHGHJD();
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x0028CABC File Offset: 0x0028ACBC
	private void MBGOKFGOGKM()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add(" " + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("{not_found}" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log(" - " + Screen.currentResolution);
		this.EPGEOPCPAPD();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.DDPDDCMAJED(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.JOIBLOCGKDH(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.IKGFHGKKCPG.KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056C4 RID: 22212 RVA: 0x0028CEF4 File Offset: 0x0028B0F4
	public void NHPKJKOCKEK()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 82f + (this.rollpitch.value - 674f) * 183f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056C5 RID: 22213 RVA: 0x0028CF84 File Offset: 0x0028B184
	private void HKIPNJMMNHF()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 0; i < array.Length; i += 0)
		{
			Resolution item = array[i];
			if (item.width >= 127)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j += 0)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("MotorbikeSuperman", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -76;
			string item4 = string.Format("", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = false;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056C6 RID: 22214 RVA: 0x0028D104 File Offset: 0x0028B304
	public void PJBKBLDIOBD()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, false);
			}
			Debug.Log("8 samples");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
		}
		else
		{
			Debug.Log("invn_rec3");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.FMOBOOGIFEB();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.LKLEBPJMEJI();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = true;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.EEOPOHEALPK().LCHEIFBGJMF)
			{
				Debug.Log("[HA ");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("\nу вас есть ", JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF);
				JNBICAJIJMM.DBMJJPBOPEK().CFJDCIHPOCN();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j += 0)
				{
					array2[j].FACAPJFOAJC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.EJJPNKHLEGJ(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
			HPGKIJLKCIH.IKGFHGKKCPG.EONAIFCDNBB();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056C7 RID: 22215 RVA: 0x0028D4FC File Offset: 0x0028B6FC
	public void BFNBFMPCJOB()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 5f + (this.rollpitch.value - 1185f) * 1513f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056C8 RID: 22216 RVA: 0x0028D58C File Offset: 0x0028B78C
	public void CJMLFCLJNNG()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 78f + (this.rollpitch.value - 310f) * 257f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056C9 RID: 22217 RVA: 0x0028D61C File Offset: 0x0028B81C
	private void OOJADBLBCAB()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		foreach (Resolution item in Screen.resolutions)
		{
			if (item.width >= -144)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 1; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("MotorbikeShootBack", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = -44;
			string item4 = string.Format("wpn_line2", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 0;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056CA RID: 22218 RVA: 0x0028D79C File Offset: 0x0028B99C
	private void OILHFNOFNPD()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip = array[i];
				list2.Add("1HandSwordStrafeRight" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("_SceneFogParams" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("chnam4" + Screen.currentResolution);
		this.IGHKOEAFBBI();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.OPNDBKDNILD(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.BMAGNENCBPF(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.EDKGBBIIBBC().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056CB RID: 22219 RVA: 0x0028DBD4 File Offset: 0x0028BDD4
	public void OCNLOIMBDNO()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 479f + (this.poplpitch.value - 1130f) * 931f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x0028DC64 File Offset: 0x0028BE64
	public void OLFHPGJMAIF()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(true, true);
			}
			Debug.Log("ObscuredDouble vs double, ");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
		}
		else
		{
			Debug.Log("UNDERLINE");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.JBFGJIMGFKB();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.JBFGJIMGFKB();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 0; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF)
			{
				Debug.Log("_Overlay");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("SoccerRun", JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF);
				JNBICAJIJMM.DBMJJPBOPEK().OAIOKDBPGOL();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].NNJMDFGKKDC();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BHLPMMIMGCA(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.HNPKHFHOCHP();
			HPGKIJLKCIH.IKGFHGKKCPG.EGIJIAINEBP();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x0028E05C File Offset: 0x0028C25C
	private void ONBJLCJMLJH()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.DDGIEKDAPOK();
	}

	// Token: 0x060056CE RID: 22222 RVA: 0x00287548 File Offset: 0x00285748
	private void AOLBGAGHJDO()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.JGKKAKJIMEK();
	}

	// Token: 0x060056CF RID: 22223 RVA: 0x0028E068 File Offset: 0x0028C268
	public void HNHMBFOFOCF()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 732f + (this.rollpitch.value - 464f) * 1395f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x0028E0F8 File Offset: 0x0028C2F8
	private void IGMGJGKICIE()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 0; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i++)
			{
				AudioClip audioClip = array[i];
				list2.Add("crft_to" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			array = SoundSamplesStorage.getI.poplSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip2 = array[i];
				list2.Add("Leg" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("BlackSmithHammer" + Screen.currentResolution);
		this.BEELPOFBCGE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.FKBLLIHDPAB(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.DOKBPILKOEM(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.LPHMKPDBMPP().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056D1 RID: 22225 RVA: 0x0028E530 File Offset: 0x0028C730
	private void EEHJEDIFHJI()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("SoccerKeeperDiveStrafeCloseLeft" + num);
				num += 0;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 1;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("minWgtBait" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("FS " + Screen.currentResolution);
		this.BEELPOFBCGE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.ODGOGPJGJNE(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.OCDPEINGMLG(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 0;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x0028E968 File Offset: 0x0028CB68
	public void JOCGCPGDOMK()
	{
		if (this.DDwnQuality != null)
		{
			QualitySettings.SetQualityLevel(this.DDwnQuality.value);
			HPGKIJLKCIH.IKGFHGKKCPG.LDONJEEONHH = this.DDwnQuality.value;
		}
		if (this.slBright != null)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI = this.slBright.value;
			HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD = this.slContrast.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF = this.slGamma.value;
		}
		if (this.inGame)
		{
			if (LocNewLogic.getI != null && Fisherman.getI != null && Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.fish != null)
			{
				LocNewLogic.getI.fishDown(false, true);
			}
			Debug.Log("_CameraWS");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG = this.rollList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK = this.rollvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH = this.rollpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF = this.noShopPoplWin.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN = this.poplList.value;
			HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ = this.poplvolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID = this.poplpitch.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
		}
		else
		{
			Debug.Log("KarateGreet");
			HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC = this.showMetrPlashka.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ = this.noDress.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF = this.isDef.isOn;
			HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK = this.volume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON = this.musicVolume.value;
			HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH = this.vsyncCount.OAPNFDMFJLH();
			HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP = this.reflect.DEAKHMNAKDD();
			HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = this.isLocalServer.isOn;
			if (!Application.isEditor)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD = false;
			}
			Resolution resolution = this.ILCEEONBONJ[this.resolutions.value];
			Screen.SetResolution(resolution.width, resolution.height, this.fullScreen.isOn);
			for (int i = 1; i < this.effects.Length; i += 0)
			{
				if (this.effects[i] != null)
				{
					HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[i] = this.effects[i].isOn;
				}
			}
			int value = this.langDB.value;
			if (value != JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF)
			{
				Debug.Log("");
				ItemBase itemBase = this.langDB.options[value] as ItemBase;
				JNBICAJIJMM.EDKGBBIIBBC().LCHEIFBGJMF = (int)itemBase.tag;
				PlayerPrefs.SetInt("CratePush", JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF);
				JNBICAJIJMM.EDKGBBIIBBC().KKPOKAPAPBH();
			}
		}
		try
		{
			SoundTheme[] array = UnityEngine.Object.FindObjectsOfType<SoundTheme>();
			if (array != null)
			{
				SoundTheme[] array2 = array;
				for (int j = 0; j < array2.Length; j += 0)
				{
					array2[j].HOBEMDBDKCI();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BHLPMMIMGCA(HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON);
			HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
			HPGKIJLKCIH.IKGFHGKKCPG.LPLOAKIAFIN();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.applySettingsForLevel();
			}
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x0028ED60 File Offset: 0x0028CF60
	public void HBAAJDMOFOI()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1204f + (this.poplpitch.value - 639f) * 1341f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x0028EDF0 File Offset: 0x0028CFF0
	public void AHIIIGCIFIL()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.poplSounds[this.poplList.value];
			this.audsrc.volume = this.poplvolume.value;
			this.audsrc.pitch = 1313f + (this.poplpitch.value - 1218f) * 1676f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056D5 RID: 22229 RVA: 0x0028EE80 File Offset: 0x0028D080
	private void BOJONMMEGAL()
	{
		this.fullScreen.isOn = Screen.fullScreen;
		Resolution[] array = Screen.resolutions;
		for (int i = 1; i < array.Length; i++)
		{
			Resolution item = array[i];
			if (item.width >= -24)
			{
				this.ILCEEONBONJ.Add(item);
			}
		}
		this.resolutions.ClearOptions();
		List<string> list = new List<string>();
		int num = -1;
		for (int j = 0; j < this.ILCEEONBONJ.Count; j++)
		{
			Resolution resolution = this.ILCEEONBONJ[j];
			if (Screen.width == resolution.width && Screen.height == resolution.height)
			{
				num = j;
			}
			string item2 = string.Format("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.", resolution.width, resolution.height);
			list.Add(item2);
		}
		if (num < 0)
		{
			Resolution item3 = default(Resolution);
			item3.width = Screen.width;
			item3.height = Screen.height;
			item3.refreshRate = 95;
			string item4 = string.Format("crft_crft", item3.width, item3.height);
			this.ILCEEONBONJ.Add(item3);
			list.Add(item4);
			num = this.ILCEEONBONJ.Count - 1;
			this.fullScreen.isOn = true;
		}
		this.resolutions.AddOptions(list);
		this.resolutions.value = num;
		this.resolutions.RefreshShownValue();
	}

	// Token: 0x060056D6 RID: 22230 RVA: 0x0028F000 File Offset: 0x0028D200
	private void AMGINIANPFJ()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i++)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			AudioClip[] array = SoundSamplesStorage.getI.rollSounds;
			for (int i = 1; i < array.Length; i += 0)
			{
				AudioClip audioClip = array[i];
				list2.Add("IdleWalk" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("The 'font size' command requires a font size parameter." + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("auk stavka result: " + Screen.currentResolution);
		this.OPELLEGPAGB();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.PNAGIDKJJPG(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.KBJLCLFNJGN(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 1;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.APMJBBDBOJO().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.DBMJJPBOPEK().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056D7 RID: 22231 RVA: 0x0028F438 File Offset: 0x0028D638
	private void LBKOIJKMCOL()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			foreach (string item in QualitySettings.names)
			{
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 1;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("RollerBladeStand" + num);
				num += 0;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("ElvisLegsLoop" + Screen.currentResolution);
		this.NBHNACLAFKF();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.IAKIFNEFBGL(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.KIEKFHBIIKA(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 1; j < this.effects.Length; j += 0)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.CLIMNFDGOEG().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.APMJBBDBOJO().LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2++;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056D8 RID: 22232 RVA: 0x0028F870 File Offset: 0x0028DA70
	public void IIFKFODDEMG()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 648f + (this.rollpitch.value - 386f) * 1427f;
			this.audsrc.Play();
		}
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x0028F900 File Offset: 0x0028DB00
	private void IDGIPDDGDFN()
	{
		if (this.DDwnQuality != null)
		{
			this.DDwnQuality.ClearOptions();
			List<string> list = new List<string>();
			string[] names = QualitySettings.names;
			for (int i = 1; i < names.Length; i += 0)
			{
				string item = names[i];
				list.Add(item);
			}
			this.DDwnQuality.AddOptions(list);
			this.DDwnQuality.value = QualitySettings.GetQualityLevel();
		}
		if (this.slBright != null)
		{
			this.slBright.value = HPGKIJLKCIH.IKGFHGKKCPG.NJFHKFJKMDI;
			this.slContrast.value = HPGKIJLKCIH.IKGFHGKKCPG.OINGHNLLMCD;
			this.slGamma.value = HPGKIJLKCIH.IKGFHGKKCPG.PKBAPFLIKGF;
		}
		if (this.inGame)
		{
			this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
			this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
			this.rollList.ClearOptions();
			int num = 0;
			List<string> list2 = new List<string>();
			foreach (AudioClip audioClip in SoundSamplesStorage.getI.rollSounds)
			{
				list2.Add("ZombieIdle2" + num);
				num++;
			}
			this.rollList.AddOptions(list2);
			this.rollList.value = HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG;
			this.rollvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
			this.rollpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH;
			this.noShopPoplWin.isOn = HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF;
			this.poplList.ClearOptions();
			num = 0;
			list2 = new List<string>();
			foreach (AudioClip audioClip2 in SoundSamplesStorage.getI.poplSounds)
			{
				list2.Add("WorkerShovel2" + num);
				num++;
			}
			this.poplList.AddOptions(list2);
			this.poplList.value = HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN;
			this.poplvolume.value = HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ;
			this.poplpitch.value = HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID;
			this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
			return;
		}
		Debug.Log("_FadeDistance" + Screen.currentResolution);
		this.NNMCJGHPNAE();
		this.showMetrPlashka.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC;
		this.noDress.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ;
		this.isDef.isOn = HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF;
		this.isLocalServer.isOn = HPGKIJLKCIH.IKGFHGKKCPG.MLGLKMNDICD;
		this.vsyncCount.PNPCNACBFHP(HPGKIJLKCIH.IKGFHGKKCPG.HPCBKBCHKFH);
		this.volume.value = HPGKIJLKCIH.IKGFHGKKCPG.LGOCHFHKJIK;
		this.musicVolume.value = HPGKIJLKCIH.IKGFHGKKCPG.MHCLECKNDON;
		this.reflect.KIEKFHBIIKA(HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP);
		this.isLocalServer.gameObject.SetActive(Application.isEditor);
		for (int j = 0; j < this.effects.Length; j++)
		{
			if (this.effects[j] != null)
			{
				this.effects[j].isOn = HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[j];
			}
		}
		List<Dropdown.OptionData> list3 = new List<Dropdown.OptionData>();
		int num2 = 1;
		int value = 0;
		foreach (JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn in JNBICAJIJMM.EEOPOHEALPK().KAEJBIHMFDF.Values)
		{
			list3.Add(new ItemBase(mgncagdefhn.MNGHILMCBCI)
			{
				tag = (long)mgncagdefhn.LPFKFNLHGBI
			});
			if (JNBICAJIJMM.IKGFHGKKCPG.LCHEIFBGJMF == mgncagdefhn.LPFKFNLHGBI)
			{
				value = num2;
			}
			num2 += 0;
		}
		this.langDB.options.Clear();
		this.langDB.AddOptions(list3);
		this.langDB.value = value;
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x0028FD38 File Offset: 0x0028DF38
	public void OHHFNEIPIDK()
	{
		if (this.audsrc != null)
		{
			this.audsrc.Stop();
			this.audsrc.clip = SoundSamplesStorage.getI.rollSounds[this.rollList.value];
			this.audsrc.volume = this.rollvolume.value;
			this.audsrc.pitch = 1536f + (this.rollpitch.value - 886f) * 565f;
			this.audsrc.Play();
		}
	}

	// Token: 0x04000D00 RID: 3328
	public Slider slBright;

	// Token: 0x04000D01 RID: 3329
	public Slider slContrast;

	// Token: 0x04000D02 RID: 3330
	public Slider slGamma;

	// Token: 0x04000D03 RID: 3331
	public Dropdown DDwnQuality;

	// Token: 0x04000D04 RID: 3332
	public Dropdown resolutions;

	// Token: 0x04000D05 RID: 3333
	public Toggle fullScreen;

	// Token: 0x04000D06 RID: 3334
	public bool inGame;

	// Token: 0x04000D07 RID: 3335
	public Toggle showMetrPlashka;

	// Token: 0x04000D08 RID: 3336
	public Toggle isRealistic;

	// Token: 0x04000D09 RID: 3337
	public Toggle isDef;

	// Token: 0x04000D0A RID: 3338
	public GroupBox vsyncCount;

	// Token: 0x04000D0B RID: 3339
	public Toggle noShopPoplWin;

	// Token: 0x04000D0C RID: 3340
	public Toggle noDress;

	// Token: 0x04000D0D RID: 3341
	public Slider volume;

	// Token: 0x04000D0E RID: 3342
	public Slider musicVolume;

	// Token: 0x04000D0F RID: 3343
	public Slider distance;

	// Token: 0x04000D10 RID: 3344
	public GroupBox reflect;

	// Token: 0x04000D11 RID: 3345
	public Dropdown langDB;

	// Token: 0x04000D12 RID: 3346
	public Toggle isLocalServer;

	// Token: 0x04000D13 RID: 3347
	public AudioSource audsrc;

	// Token: 0x04000D14 RID: 3348
	public Dropdown rollList;

	// Token: 0x04000D15 RID: 3349
	public Slider rollvolume;

	// Token: 0x04000D16 RID: 3350
	public Slider rollpitch;

	// Token: 0x04000D17 RID: 3351
	public Dropdown poplList;

	// Token: 0x04000D18 RID: 3352
	public Slider poplvolume;

	// Token: 0x04000D19 RID: 3353
	public Slider poplpitch;

	// Token: 0x04000D1A RID: 3354
	public Toggle[] effects = new Toggle[10];

	// Token: 0x04000D1B RID: 3355
	private List<Resolution> ILCEEONBONJ = new List<Resolution>();
}
