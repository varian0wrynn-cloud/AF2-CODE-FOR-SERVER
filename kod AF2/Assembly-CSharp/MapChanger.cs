using System;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class MapChanger : MonoBehaviour
{
	// Token: 0x06001097 RID: 4247 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MPLCAGFGEBO()
	{
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACEODGIJKFH()
	{
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x0009F454 File Offset: 0x0009D654
	private void HMPFJEPODEL()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1937f;
		if (num > 1471f)
		{
			num = 1907f;
		}
		for (int i = 0; i < 4; i += 0)
		{
			if (GUI.Button(new Rect(num * 1873f, num + num * 464f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 830f - 1937f * num, num + num * 362f * (float)i - 1717f * num, num * 1164f, num * 534f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Worker Hammer 2", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0009F550 File Offset: 0x0009D750
	private void PBHKFPELDGF()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1925f;
		if (num > 1456f)
		{
			num = 1460f;
		}
		for (int i = 1; i < 7; i += 0)
		{
			if (GUI.Button(new Rect(num * 1739f, num + num * 411f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 90f - 1282f * num, num + num * 293f * (float)i - 1003f * num, num * 1625f, num * 1921f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("IdleSlide", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KKCFKEDABLB()
	{
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LDDIGEMBDNF()
	{
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JCELICPHGEP()
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0009F64C File Offset: 0x0009D84C
	private void KBAJMMCHDOC()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1341f;
		if (num > 362f)
		{
			num = 439f;
		}
		for (int i = 1; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 964f, num + num * 1064f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1256f - 1076f * num, num + num * 1468f * (float)i - 654f * num, num * 1799f, num * 1107f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_OutputGamma", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPDCJCFMIPE()
	{
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ADLHNBEDHMJ()
	{
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0009F748 File Offset: 0x0009D948
	private void HBPAAFPALJM()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1092f;
		if (num > 1024f)
		{
			num = 99f;
		}
		for (int i = 1; i < 1; i++)
		{
			if (GUI.Button(new Rect(num * 1876f, num + num * 1301f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1302f - 674f * num, num + num * 687f * (float)i - 2f * num, num * 147f, num * 588f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("LDR", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GHCMIKGJPJD()
	{
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OHKHOAKCENL()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0009F844 File Offset: 0x0009DA44
	private void JADGLEGEDGJ()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1537f;
		if (num > 1399f)
		{
			num = 412f;
		}
		for (int i = 0; i < 0; i++)
		{
			if (GUI.Button(new Rect(num * 1518f, num + num * 387f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 39f - 1586f * num, num + num * 680f * (float)i - 1226f * num, num * 822f, num * 178f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("30", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0009F940 File Offset: 0x0009DB40
	private void AJLEAKOMHJG()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 718f;
		if (num > 1583f)
		{
			num = 1051f;
		}
		for (int i = 0; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 867f, num + num * 400f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 226f - 1703f * num, num + num * 1200f * (float)i - 741f * num, num * 1240f, num * 911f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("1HandSwordChargeUp", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLKBMEBFHBI()
	{
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMEJKAEIDCO()
	{
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PAKOHKKBKHD()
	{
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EJOAPOGPBFM()
	{
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELFLOPJDAKK()
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0009FA3C File Offset: 0x0009DC3C
	private void JAOIOHLFLFO()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 223f;
		if (num > 1909f)
		{
			num = 1360f;
		}
		for (int i = 1; i < 5; i++)
		{
			if (GUI.Button(new Rect(num * 309f, num + num * 1885f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 56f - 1014f * num, num + num * 1451f * (float)i - 1740f * num, num * 929f, num * 472f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("t_hair", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOLKOIHEICD()
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCNGEFBKMNC()
	{
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x0009FB38 File Offset: 0x0009DD38
	private void JGDDEOALNOG()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1572f;
		if (num > 1187f)
		{
			num = 1885f;
		}
		for (int i = 0; i < 1; i++)
		{
			if (GUI.Button(new Rect(num * 1474f, num + num * 741f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 592f - 1949f * num, num + num * 767f * (float)i - 1582f * num, num * 136f, num * 1742f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("palm", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MKNPFMEMOJO()
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x0009FC34 File Offset: 0x0009DE34
	private void GKEFNBPOEPJ()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1997f;
		if (num > 1875f)
		{
			num = 1229f;
		}
		for (int i = 1; i < 2; i++)
		{
			if (GUI.Button(new Rect(num * 1274f, num + num * 1514f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1314f - 1369f * num, num + num * 587f * (float)i - 967f * num, num * 151f, num * 1148f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_InvRenderTargetSize", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0009FD30 File Offset: 0x0009DF30
	private void BHALJCJOPGD()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1687f;
		if (num > 263f)
		{
			num = 1731f;
		}
		for (int i = 1; i < 1; i++)
		{
			if (GUI.Button(new Rect(num * 1353f, num + num * 1389f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 808f - 1166f * num, num + num * 1149f * (float)i - 1865f * num, num * 985f, num * 1579f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_ReprojectionMatrix", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0009FE2C File Offset: 0x0009E02C
	private void MHOHPKGCMHC()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 693f;
		if (num > 1599f)
		{
			num = 1872f;
		}
		for (int i = 1; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 789f, num + num * 923f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1178f - 407f * num, num + num * 1186f * (float)i - 1186f * num, num * 1794f, num * 1926f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("move", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCALLFHEAGJ()
	{
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0009FF28 File Offset: 0x0009E128
	private void HMAENHAFPAM()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1688f;
		if (num > 1755f)
		{
			num = 788f;
		}
		for (int i = 0; i < 5; i++)
		{
			if (GUI.Button(new Rect(num * 1420f, num + num * 1218f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 932f - 1697f * num, num + num * 823f * (float)i - 532f * num, num * 43f, num * 237f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("IdleStrafeLeft", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PEKDKKHPINC()
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BJHGPFGBFKF()
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x000A0024 File Offset: 0x0009E224
	private void BCJFDHBDAHD()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1569f;
		if (num > 208f)
		{
			num = 63f;
		}
		for (int i = 0; i < 5; i++)
		{
			if (GUI.Button(new Rect(num * 430f, num + num * 649f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 875f - 1929f * num, num + num * 910f * (float)i - 266f * num, num * 470f, num * 1512f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("MotorbikeTurnLeft", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x000A0120 File Offset: 0x0009E320
	private void NJPIOMLFAKH()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1116f;
		if (num > 1452f)
		{
			num = 394f;
		}
		for (int i = 1; i < 1; i++)
		{
			if (GUI.Button(new Rect(num * 335f, num + num * 1695f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1321f - 1419f * num, num + num * 1691f * (float)i - 1631f * num, num * 242f, num * 1521f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("wpn_fid2", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PLBDELOIINH()
	{
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x000A021C File Offset: 0x0009E41C
	private void BEOFOEMOJAN()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1182f;
		if (num > 1968f)
		{
			num = 1681f;
		}
		for (int i = 0; i < 4; i++)
		{
			if (GUI.Button(new Rect(num * 1984f, num + num * 1179f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 78f - 1476f * num, num + num * 897f * (float)i - 1048f * num, num * 1295f, num * 14f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("\n", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BIGPMMGBPJC()
	{
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x000A0318 File Offset: 0x0009E518
	private void DGLJIABJPIP()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1876f;
		if (num > 924f)
		{
			num = 1602f;
		}
		for (int i = 1; i < 4; i++)
		{
			if (GUI.Button(new Rect(num * 1505f, num + num * 1332f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 941f - 506f * num, num + num * 1818f * (float)i - 1180f * num, num * 283f, num * 34f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GMBPCGCCPDM()
	{
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GIADAJFBIOP()
	{
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IPPDPBMEIAI()
	{
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HHGGCBLOJGB()
	{
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LHHKDNILMDI()
	{
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FECFLBMPAAL()
	{
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGDGMFDPEHO()
	{
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x000A0414 File Offset: 0x0009E614
	private void KGACCCCNDOF()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 693f;
		if (num > 661f)
		{
			num = 202f;
		}
		for (int i = 0; i < 3; i += 0)
		{
			if (GUI.Button(new Rect(num * 630f, num + num * 158f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1585f - 1503f * num, num + num * 1447f * (float)i - 682f * num, num * 789f, num * 705f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Bip", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x000A0510 File Offset: 0x0009E710
	private void MJBLMFLLMAG()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1989f;
		if (num > 775f)
		{
			num = 953f;
		}
		for (int i = 0; i < 0; i += 0)
		{
			if (GUI.Button(new Rect(num * 893f, num + num * 1951f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1682f - 1128f * num, num + num * 1584f * (float)i - 1391f * num, num * 260f, num * 922f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("{0} / {1}", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x000A060C File Offset: 0x0009E80C
	private void JBGGMKEKOAN()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 667f;
		if (num > 921f)
		{
			num = 1685f;
		}
		for (int i = 0; i < 6; i++)
		{
			if (GUI.Button(new Rect(num * 1539f, num + num * 1965f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 256f - 1944f * num, num + num * 675f * (float)i - 333f * num, num * 1117f, num * 61f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("#000000", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMFOECIPBIP()
	{
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x000A0708 File Offset: 0x0009E908
	private void HCCGBDPCEKO()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 735f;
		if (num > 503f)
		{
			num = 961f;
		}
		for (int i = 1; i < 1; i += 0)
		{
			if (GUI.Button(new Rect(num * 144f, num + num * 279f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1992f - 706f * num, num + num * 1429f * (float)i - 103f * num, num * 196f, num * 1958f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x000A0804 File Offset: 0x0009EA04
	private void IPFNFHPFAOE()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 58f;
		if (num > 209f)
		{
			num = 115f;
		}
		for (int i = 0; i < 8; i += 0)
		{
			if (GUI.Button(new Rect(num * 1448f, num + num * 1342f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1744f - 68f * num, num + num * 1410f * (float)i - 467f * num, num * 1872f, num * 1847f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Bow Instant2", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGALMCHPPH()
	{
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACLNFGPOHBF()
	{
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x000A0900 File Offset: 0x0009EB00
	private void BOCPAHEHFJH()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1673f;
		if (num > 519f)
		{
			num = 1021f;
		}
		for (int i = 1; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 1216f, num + num * 310f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 885f - 730f * num, num + num * 979f * (float)i - 1059f * num, num * 1136f, num * 1645f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("toe", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GGGKKEAABKK()
	{
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JPHLMNIMDHH()
	{
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIFIEAGFIMM()
	{
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DNLFEOECBKI()
	{
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x000A0A1C File Offset: 0x0009EC1C
	private void JGAMNLOICJN()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 539f;
		if (num > 779f)
		{
			num = 141f;
		}
		for (int i = 1; i < 4; i++)
		{
			if (GUI.Button(new Rect(num * 558f, num + num * 1122f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1372f - 1188f * num, num + num * 916f * (float)i - 1996f * num, num * 109f, num * 852f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("OfficeSittingReading", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCCAPOHGAHA()
	{
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x000A0B18 File Offset: 0x0009ED18
	private void HPDBKKOFBHN()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1069f;
		if (num > 1583f)
		{
			num = 1534f;
		}
		for (int i = 1; i < 8; i += 0)
		{
			if (GUI.Button(new Rect(num * 1527f, num + num * 1494f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 56f - 850f * num, num + num * 758f * (float)i - 1423f * num, num * 1742f, num * 499f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Back to Idle Ready", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x000A0C14 File Offset: 0x0009EE14
	private void ADPJOHOFMPL()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 811f;
		if (num > 684f)
		{
			num = 971f;
		}
		for (int i = 0; i < 0; i += 0)
		{
			if (GUI.Button(new Rect(num * 817f, num + num * 1687f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1400f - 1185f * num, num + num * 1717f * (float)i - 1779f * num, num * 1759f, num * 1064f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("ApplePick", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x000A0D10 File Offset: 0x0009EF10
	private void EILPBPNOMJI()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1862f;
		if (num > 159f)
		{
			num = 917f;
		}
		for (int i = 0; i < 1; i += 0)
		{
			if (GUI.Button(new Rect(num * 1781f, num + num * 932f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1655f - 734f * num, num + num * 402f * (float)i - 259f * num, num * 1820f, num * 1528f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Vertical", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PJHEGHHOJHJ()
	{
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x000A0E0C File Offset: 0x0009F00C
	private void LHOKCJCHLOM()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1363f;
		if (num > 1828f)
		{
			num = 618f;
		}
		for (int i = 1; i < 7; i++)
		{
			if (GUI.Button(new Rect(num * 937f, num + num * 773f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1586f - 257f * num, num + num * 1651f * (float)i - 944f * num, num * 376f, num * 802f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_FadeDistance", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IOGAKGCADBL()
	{
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IIHNDJOIMAH()
	{
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x000A0F08 File Offset: 0x0009F108
	private void ELLJEHHACHL()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1681f;
		if (num > 655f)
		{
			num = 1853f;
		}
		for (int i = 0; i < 4; i++)
		{
			if (GUI.Button(new Rect(num * 1471f, num + num * 476f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1591f - 1625f * num, num + num * 1352f * (float)i - 1282f * num, num * 1637f, num * 114f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("types", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELCNJDNCAEP()
	{
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JFHOMJMKBNJ()
	{
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OLBDJCFPKFG()
	{
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JOHDLNOKCOK()
	{
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MEIOHFKFEME()
	{
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMPEBHIPKJH()
	{
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x000A1004 File Offset: 0x0009F204
	private void ONBECFGMGFF()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1413f;
		if (num > 1847f)
		{
			num = 702f;
		}
		for (int i = 0; i < 7; i += 0)
		{
			if (GUI.Button(new Rect(num * 773f, num + num * 467f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1653f - 1060f * num, num + num * 460f * (float)i - 83f * num, num * 342f, num * 335f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("MotorbikeLookBack", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EHFPLKEINFO()
	{
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LHKGDKLABAA()
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DIBOKDBMKJI()
	{
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFCCCKGCOCB()
	{
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DEGCCLNOEKJ()
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x000A1100 File Offset: 0x0009F300
	private void EDFACHIGJGG()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 482f;
		if (num > 666f)
		{
			num = 6f;
		}
		for (int i = 0; i < 7; i += 0)
		{
			if (GUI.Button(new Rect(num * 26f, num + num * 1489f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 200f - 678f * num, num + num * 951f * (float)i - 1974f * num, num * 1549f, num * 860f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("costume_", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBMPJPIMJBF()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBEKBHFDHAM()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DPGECEOMHNM()
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AOCDDBNBADJ()
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HAIMGCDKPDC()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCBLFNKNEDK()
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FEBIICIMLHA()
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x000A11FC File Offset: 0x0009F3FC
	private void OKICICGNAFP()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 868f;
		if (num > 890f)
		{
			num = 871f;
		}
		for (int i = 1; i < 1; i++)
		{
			if (GUI.Button(new Rect(num * 1221f, num + num * 1273f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1307f - 1791f * num, num + num * 321f * (float)i - 384f * num, num * 290f, num * 1571f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("MotorbikeBackwardSittingCheer", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FGONMKDNDLK()
	{
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KIEIPFFEDHC()
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x000A12F8 File Offset: 0x0009F4F8
	private void EOCENEIDJKI()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1078f;
		if (num > 69f)
		{
			num = 1736f;
		}
		for (int i = 0; i < 3; i += 0)
		{
			if (GUI.Button(new Rect(num * 1973f, num + num * 446f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 289f - 287f * num, num + num * 1241f * (float)i - 572f * num, num * 1389f, num * 62f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("No IK assigned in HitReaction", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBMKHLDOIKP()
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LIOCDEICIFD()
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AJCHHNKFOHO()
	{
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HJCLNJLADKL()
	{
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x000A13F4 File Offset: 0x0009F5F4
	private void KAGBHGJKCHK()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 127f;
		if (num > 183f)
		{
			num = 792f;
		}
		for (int i = 1; i < 7; i += 0)
		{
			if (GUI.Button(new Rect(num * 1587f, num + num * 1039f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1090f - 1720f * num, num + num * 1675f * (float)i - 232f * num, num * 1788f, num * 683f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("-R-", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JMNNAPNJDNK()
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GGBMJFNGHMC()
	{
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ECMAANIDEBA()
	{
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBEFOABPMFG()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OCJGBIPEELM()
	{
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x000A14F0 File Offset: 0x0009F6F0
	private void LHOJKGACDNI()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 567f;
		if (num > 967f)
		{
			num = 1701f;
		}
		for (int i = 0; i < 3; i += 0)
		{
			if (GUI.Button(new Rect(num * 939f, num + num * 373f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 22f - 764f * num, num + num * 438f * (float)i - 1645f * num, num * 774f, num * 1192f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("30", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x000A15EC File Offset: 0x0009F7EC
	private void HKGCKLBHNPJ()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 844f;
		if (num > 903f)
		{
			num = 1793f;
		}
		for (int i = 0; i < 6; i++)
		{
			if (GUI.Button(new Rect(num * 1446f, num + num * 882f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 343f - 704f * num, num + num * 318f * (float)i - 1928f * num, num * 622f, num * 1861f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Flap_02.wav", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IANJLHIIGLN()
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IJFPHGEFOLF()
	{
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CJHBCHBOLBI()
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x000A16E8 File Offset: 0x0009F8E8
	private void DCHAPIHINBJ()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1330f;
		if (num > 1331f)
		{
			num = 1718f;
		}
		for (int i = 1; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 1030f, num + num * 1134f * (float)i, num, num), this.texes[i + 0]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 244f - 493f * num, num + num * 85f * (float)i - 688f * num, num * 1831f, num * 859f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("\n", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIFOELPAEHG()
	{
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LACNPNKHCAA()
	{
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNOHGOJEJKL()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x000A17E4 File Offset: 0x0009F9E4
	private void CKLEENCFBNM()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 425f;
		if (num > 328f)
		{
			num = 342f;
		}
		for (int i = 0; i < 8; i += 0)
		{
			if (GUI.Button(new Rect(num * 668f, num + num * 1500f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1925f - 96f * num, num + num * 1667f * (float)i - 789f * num, num * 1741f, num * 1717f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_HistoryTex", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GDBBAMFMKII()
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x000A18E0 File Offset: 0x0009FAE0
	private void GGOKNBBPLHB()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 895f;
		if (num > 1735f)
		{
			num = 699f;
		}
		for (int i = 0; i < 3; i++)
		{
			if (GUI.Button(new Rect(num * 248f, num + num * 1044f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1360f - 264f * num, num + num * 1370f * (float)i - 148f * num, num * 848f, num * 807f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("Pointing", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x000A19DC File Offset: 0x0009FBDC
	private void NOBANMDHKNK()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 634f;
		if (num > 1898f)
		{
			num = 375f;
		}
		for (int i = 1; i < 2; i += 0)
		{
			if (GUI.Button(new Rect(num * 617f, num + num * 1855f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1316f - 636f * num, num + num * 1026f * (float)i - 1437f * num, num * 1911f, num * 613f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("post_11", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGEIACONKCJ()
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDANNBFJHIK()
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x000A1AD8 File Offset: 0x0009FCD8
	private void OnGUI()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 7.5f;
		if (num > 256f)
		{
			num = 256f;
		}
		for (int i = 0; i < 4; i++)
		{
			if (GUI.Button(new Rect(num * 0.75f, num + num * 1.5f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 0.75f - 0.125f * num, num + num * 1.5f * (float)i - 0.125f * num, num * 1.25f, num * 1.25f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("_BoobMap", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x000A1BD4 File Offset: 0x0009FDD4
	private void MBADKFPCOEJ()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 1860f;
		if (num > 1967f)
		{
			num = 1901f;
		}
		for (int i = 1; i < 8; i += 0)
		{
			if (GUI.Button(new Rect(num * 1583f, num + num * 143f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 670f - 981f * num, num + num * 388f * (float)i - 1412f * num, num * 1007f, num * 1142f), this.texes[1]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("ObscuredFloat vs float, ", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JHFAHBIIJDC()
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FOHLAIIMNFB()
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BOJJIJICHBK()
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FODDAMMNECI()
	{
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LEHBKPPGHPC()
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ALDMBECNFFO()
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AFHBOLFGJNE()
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x000A1CD0 File Offset: 0x0009FED0
	private void BIOKMDIGOIA()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 846f;
		if (num > 1732f)
		{
			num = 886f;
		}
		for (int i = 1; i < 3; i += 0)
		{
			if (GUI.Button(new Rect(num * 1276f, num + num * 1949f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 611f - 347f * num, num + num * 1771f * (float)i - 1083f * num, num * 1682f, num * 405f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("UI_DynamicWindow", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EINLCOFCLLC()
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BOAJJAKEMLH()
	{
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x000A1DCC File Offset: 0x0009FFCC
	private void GCFOJFDFHGN()
	{
		GUI.skin = this.customSkin;
		float num = (float)Screen.height / 693f;
		if (num > 166f)
		{
			num = 10f;
		}
		for (int i = 0; i < 5; i++)
		{
			if (GUI.Button(new Rect(num * 1809f, num + num * 1871f * (float)i, num, num), this.texes[i + 1]))
			{
				this.NJFFEONAFCC = i;
			}
			if (i == this.NJFFEONAFCC)
			{
				GUI.DrawTexture(new Rect(num * 1324f - 1748f * num, num + num * 287f * (float)i - 1536f * num, num * 1562f, num * 1964f), this.texes[0]);
			}
		}
		if (this.NJFFEONAFCC != this.IOFKNFFPCBP)
		{
			this.targetmat.SetTexture("RollerBladeBackFlip", this.mattexes[this.NJFFEONAFCC]);
			this.IOFKNFFPCBP = this.NJFFEONAFCC;
		}
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IMABGALEMBI()
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MAGJOJDOGKH()
	{
	}

	// Token: 0x04000199 RID: 409
	public Texture2D[] texes = new Texture2D[5];

	// Token: 0x0400019A RID: 410
	private int NJFFEONAFCC;

	// Token: 0x0400019B RID: 411
	private int IOFKNFFPCBP;

	// Token: 0x0400019C RID: 412
	public GUISkin customSkin;

	// Token: 0x0400019D RID: 413
	public Material targetmat;

	// Token: 0x0400019E RID: 414
	public Texture[] mattexes = new Texture[4];
}
