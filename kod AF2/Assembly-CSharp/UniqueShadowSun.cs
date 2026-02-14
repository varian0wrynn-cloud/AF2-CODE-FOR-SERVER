using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
public class UniqueShadowSun : MonoBehaviour
{
	// Token: 0x060012EF RID: 4847 RVA: 0x000B4EF6 File Offset: 0x000B30F6
	private void KOJNOPBGPAM()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "MotorbikeBackwardStand";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x000B4F2A File Offset: 0x000B312A
	private void ECOOMJKPKCC()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "bag";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x000B4F60 File Offset: 0x000B3160
	private void NJFOOJIADNH()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "Knee";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format2 = "SoccerSprint";
			object[] array2 = new object[0];
			array2[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format2, array2);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x000B4FCA File Offset: 0x000B31CA
	private void Awake()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("No light component found in UniqueShadowSun '{0}!", new object[]
			{
				base.name
			});
		}
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x000B5000 File Offset: 0x000B3200
	private void LNEJPGDHJOJ()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "Adjust";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format2 = "ObscuredPrefs vs PlayerPrefs, ";
			object[] array2 = new object[0];
			array2[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format2, array2);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x000B506A File Offset: 0x000B326A
	private void BOIFJMFAOGK()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "Move around with WASD keys. Press C to enable free look camera";
			object[] array = new object[0];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x000B50A1 File Offset: 0x000B32A1
	private void FJBPGBMDBBF()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "BowInstant";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x000B50D8 File Offset: 0x000B32D8
	private void IICFAPMJLCN()
	{
		if (UniqueShadowSun.instance == null)
		{
			Debug.LogErrorFormat("crft_to", new object[]
			{
				base.name
			});
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format = "ZombieIdle";
			object[] array = new object[0];
			array[0] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x000B5142 File Offset: 0x000B3342
	private void OnEnable()
	{
		if (UniqueShadowSun.instance)
		{
			Debug.LogErrorFormat("Not setting 'UniqueShadowSun.instance' because '{0}' is already active!", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x000B5179 File Offset: 0x000B3379
	private void EKOHIDBILAI()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "IceHockeyIdle";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x000B51B0 File Offset: 0x000B33B0
	private void LCJGCMFMMFG()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "knopje.wav";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x000B51E8 File Offset: 0x000B33E8
	private void JGHJOBDKDKM()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "[X]";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format2 = "ENABLE_DITHERING";
			object[] array2 = new object[1];
			array2[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format2, array2);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x000B5252 File Offset: 0x000B3452
	private void OJJKNBMONMD()
	{
		if (UniqueShadowSun.instance)
		{
			string format = " on effect ";
			object[] array = new object[0];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x000B5289 File Offset: 0x000B3489
	private void JAFCKIKCHGM()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "bone";
			object[] array = new object[0];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x000B52C0 File Offset: 0x000B34C0
	private void JMNLEBAPHNJ()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "Bone ";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x000B52F4 File Offset: 0x000B34F4
	private void LAFIABNCFPD()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "Assembly-CSharp-firstpass";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("Квест", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x000B535E File Offset: 0x000B355E
	private void GDMEEIBDKLP()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "pempty";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x000B5394 File Offset: 0x000B3594
	private void BABMAHFKPMO()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "</color>";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format2 = "Weapon Stand";
			object[] array2 = new object[1];
			array2[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format2, array2);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x000B53FE File Offset: 0x000B35FE
	private void IEHEAJJALNG()
	{
		if (UniqueShadowSun.instance)
		{
			Debug.LogErrorFormat("_TintColor", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x000B5435 File Offset: 0x000B3635
	private void OLHGBCBHDBF()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x000B546C File Offset: 0x000B366C
	private void HCMHMFHMPHN()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "CratePull";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x000B54A0 File Offset: 0x000B36A0
	private void IIONABJOCBN()
	{
		if (UniqueShadowSun.instance)
		{
			Debug.LogErrorFormat("Front Kick", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x000B54D8 File Offset: 0x000B36D8
	private void OnDisable()
	{
		if (UniqueShadowSun.instance == null)
		{
			Debug.LogErrorFormat("'UniqueShadowSun.instance' is already null when disabling '{0}'!", new object[]
			{
				base.name
			});
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x000B5542 File Offset: 0x000B3742
	private void BKGHBKPDMDH()
	{
		if (UniqueShadowSun.instance)
		{
			Debug.LogErrorFormat("IdleStrafeRight", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x000B5579 File Offset: 0x000B3779
	private void DJIFJMEEBKA()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "The image effect ";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x000B55AD File Offset: 0x000B37AD
	private void EBNINOBOAII()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("knopje.wav", new object[]
			{
				base.name
			});
		}
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x000B55E4 File Offset: 0x000B37E4
	private void DFLLLNDKNBB()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = " locid=";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("Cowboy1HandDraw", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x000B5650 File Offset: 0x000B3850
	private void AHMFIGNLJOB()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "{not_found}";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("_VignetteBlur", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x000B56BA File Offset: 0x000B38BA
	private void NPKEBODNBAI()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "F3";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x000B56F0 File Offset: 0x000B38F0
	private void CCCAOGJKJOD()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "IdleStand";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("IdleMouthWipe", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x000B575C File Offset: 0x000B395C
	private void DNBMNPKDPHC()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format2 = "str=";
			object[] array2 = new object[0];
			array2[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format2, array2);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x000B57C8 File Offset: 0x000B39C8
	private void EIDIHAJDMCI()
	{
		if (UniqueShadowSun.instance == null)
		{
			Debug.LogErrorFormat("auk_wavg", new object[]
			{
				base.name
			});
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			string format = "<color='#003000'>+{0} {1}</color>";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x000B5832 File Offset: 0x000B3A32
	private void CNKLGMCHEBM()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "innerPerk";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x000B5868 File Offset: 0x000B3A68
	private void NJBEKBHCLIO()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "_Tile8RT";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("Hidden/Post FX/Lut Generator", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x000B58D2 File Offset: 0x000B3AD2
	private void BHPGDKJHKKG()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "G";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x000B5908 File Offset: 0x000B3B08
	private void HMILPFNLLJM()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "IdleCheer";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("<color='#000000'>{0}</color><color='#002000'>$</color>", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x000B5972 File Offset: 0x000B3B72
	private void FHPLPPPOPJF()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "invn_rec7";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x000B59AC File Offset: 0x000B3BAC
	private void IABPIBODNNG()
	{
		if (UniqueShadowSun.instance == null)
		{
			string format = "Smoking2";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		if (UniqueShadowSun.instance != this.KBJEODMPIGA)
		{
			Debug.LogErrorFormat("OfficeSittingLegCross", new object[]
			{
				UniqueShadowSun.instance.name
			});
			return;
		}
		UniqueShadowSun.instance = null;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x000B5A16 File Offset: 0x000B3C16
	private void CIDFLCGOBKO()
	{
		if (UniqueShadowSun.instance)
		{
			string format = "MotorbikeLookBack";
			object[] array = new object[1];
			array[1] = UniqueShadowSun.instance.name;
			Debug.LogErrorFormat(format, array);
			return;
		}
		UniqueShadowSun.instance = this.KBJEODMPIGA;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x000B5A4D File Offset: 0x000B3C4D
	private void MBNCGMLPNLD()
	{
		this.KBJEODMPIGA = base.GetComponent<Light>();
		if (!this.KBJEODMPIGA)
		{
			string format = "_BlurRadius4";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
		}
	}

	// Token: 0x04000221 RID: 545
	public static Light instance;

	// Token: 0x04000222 RID: 546
	private Light KBJEODMPIGA;
}
