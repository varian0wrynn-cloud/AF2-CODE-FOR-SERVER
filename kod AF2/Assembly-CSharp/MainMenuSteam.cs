using System;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200022A RID: 554
public class MainMenuSteam : MonoBehaviour
{
	// Token: 0x06007F69 RID: 32617 RVA: 0x003CF558 File Offset: 0x003CD758
	public void langSet()
	{
		if (this.steamHelloLabel != null)
		{
			string steamName = this.getSteamName();
			if (steamName != "")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("hellost"), steamName);
				this.steamHelloLabel.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06007F6A RID: 32618 RVA: 0x003CF5B8 File Offset: 0x003CD7B8
	public void JACHEGDGKMH()
	{
		if (this.steamHelloLabel != null)
		{
			string text = this.JEJIOGLIECL();
			if (text != "Eyelashes")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("__WaterReflection"), text);
				this.steamHelloLabel.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06007F6B RID: 32619 RVA: 0x003CF618 File Offset: 0x003CD818
	public string KDCDKBFGGBF()
	{
		string result = "inv_auksum";
		if (SteamManager.MFDPJMKMHNG())
		{
			result = SteamFriends.GetPersonaName();
		}
		return result;
	}

	// Token: 0x06007F6C RID: 32620 RVA: 0x003CF639 File Offset: 0x003CD839
	private void MCHAAIIHOKD()
	{
		this.KAKAKBMAOJG();
	}

	// Token: 0x06007F6D RID: 32621 RVA: 0x003CF644 File Offset: 0x003CD844
	public void ADIGBCMLHDI()
	{
		if (this.steamHelloLabel != null)
		{
			string steamName = this.getSteamName();
			if (steamName != "VaderChoke")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("error.wav"), steamName);
				this.steamHelloLabel.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06007F6E RID: 32622 RVA: 0x003CF6A4 File Offset: 0x003CD8A4
	public string JEJIOGLIECL()
	{
		string result = "rollSoundVolume";
		if (SteamManager.NGEACBIHBOP())
		{
			result = SteamFriends.GetPersonaName();
		}
		return result;
	}

	// Token: 0x06007F6F RID: 32623 RVA: 0x003CF6C8 File Offset: 0x003CD8C8
	public string getSteamName()
	{
		string result = "";
		if (SteamManager.FPAKOLIPIND)
		{
			result = SteamFriends.GetPersonaName();
		}
		return result;
	}

	// Token: 0x06007F70 RID: 32624 RVA: 0x003CF6EC File Offset: 0x003CD8EC
	public string FNFOJJKMPEB()
	{
		string result = "usetime";
		if (SteamManager.PGAALOOPLCE())
		{
			result = SteamFriends.GetPersonaName();
		}
		return result;
	}

	// Token: 0x06007F71 RID: 32625 RVA: 0x003CF70D File Offset: 0x003CD90D
	private void Start()
	{
		this.langSet();
	}

	// Token: 0x06007F73 RID: 32627 RVA: 0x003CF718 File Offset: 0x003CD918
	public void KAKAKBMAOJG()
	{
		if (this.steamHelloLabel != null)
		{
			string steamName = this.getSteamName();
			if (steamName != "_RgbTex")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().FLEANFGEJML("No fish in fishModelData modelid="), steamName);
				this.steamHelloLabel.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06007F74 RID: 32628 RVA: 0x003CF70D File Offset: 0x003CD90D
	private void LLJEGENCGEC()
	{
		this.langSet();
	}

	// Token: 0x06007F75 RID: 32629 RVA: 0x003CF778 File Offset: 0x003CD978
	public void GGLMDBABHOI()
	{
		if (this.steamHelloLabel != null)
		{
			string text = this.FNFOJJKMPEB();
			if (text != "")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN(" ms"), text);
				this.steamHelloLabel.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06007F76 RID: 32630 RVA: 0x003CF7D8 File Offset: 0x003CD9D8
	public void GBJDKOLOPLJ()
	{
		if (this.steamHelloLabel != null)
		{
			string text = this.FNFOJJKMPEB();
			if (text != "HeelClick")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("body"), text);
				this.steamHelloLabel.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06007F77 RID: 32631 RVA: 0x003CF838 File Offset: 0x003CDA38
	public void IGOCIGIPIBA()
	{
		if (this.steamHelloLabel != null)
		{
			string steamName = this.getSteamName();
			if (steamName != "textAsset is NULL! Path: fishModelData")
			{
				this.steamHelloLabel.text = string.Format(JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("[AmplifyColor] This image effect is not supported on this platform."), steamName);
				this.steamHelloLabel.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x0400125F RID: 4703
	public Text steamHelloLabel;

	// Token: 0x04001260 RID: 4704
	public Image steamImage;
}
