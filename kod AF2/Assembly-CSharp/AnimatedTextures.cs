using System;
using UnityEngine;

// Token: 0x020000B4 RID: 180
public class AnimatedTextures : MonoBehaviour
{
	// Token: 0x06002672 RID: 9842 RVA: 0x0010D268 File Offset: 0x0010B468
	private void KOKHFNKKDBI(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 61f / (float)EBBBHMGENON;
		float y = 864f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1476f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("---", value);
		base.GetComponent<Renderer>().material.SetTextureScale("Cloth_05_00.wav", vector);
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x0010D308 File Offset: 0x0010B508
	private void MDACHDNHAII(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1467f / (float)EBBBHMGENON;
		float y = 1383f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 870f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("ApplePick", value);
		base.GetComponent<Renderer>().material.SetTextureScale("IdleReady", vector);
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x0010D3A8 File Offset: 0x0010B5A8
	private void KNDBABGIIBH(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 477f / (float)EBBBHMGENON;
		float y = 1730f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1557f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("1", value);
		base.GetComponent<Renderer>().material.SetTextureScale("_ColorDownsampled", vector);
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x0010D448 File Offset: 0x0010B648
	private void HIAAJACHHKI(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 450f / (float)EBBBHMGENON;
		float y = 677f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1612f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("[Z]", value);
		base.GetComponent<Renderer>().material.SetTextureScale("", vector);
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x0010D4E6 File Offset: 0x0010B6E6
	private void CBBLGEDCJBF()
	{
		this.NJFHCHLHJJH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x0010D512 File Offset: 0x0010B712
	private void OPDCJCFMIPE()
	{
		this.PNBILJEPBFP(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x0010D53E File Offset: 0x0010B73E
	private void CJHBCHBOLBI()
	{
		this.EPFEPFPBLDN(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x0010D512 File Offset: 0x0010B712
	private void JPHLMNIMDHH()
	{
		this.PNBILJEPBFP(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x0010D56C File Offset: 0x0010B76C
	private void GCMFMBECFBL(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 686f / (float)EBBBHMGENON;
		float y = 1775f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1499f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("Office", value);
		base.GetComponent<Renderer>().material.SetTextureScale("IdleStand", vector);
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x0010D60C File Offset: 0x0010B80C
	private void EGAHENKFGAJ(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 775f / (float)EBBBHMGENON;
		float y = 720f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1852f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("isFishGet", value);
		base.GetComponent<Renderer>().material.SetTextureScale("The image effect ", vector);
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x0010D6AC File Offset: 0x0010B8AC
	private void NMCJHOKCIBH(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1226f / (float)EBBBHMGENON;
		float y = 1721f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 894f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("_Offsets", value);
		base.GetComponent<Renderer>().material.SetTextureScale("RunJump", vector);
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x0010D74C File Offset: 0x0010B94C
	private void GAHGCAJBCPJ(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1390f / (float)EBBBHMGENON;
		float y = 1276f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1634f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("SecondaryCausticsProjector", value);
		base.GetComponent<Renderer>().material.SetTextureScale("", vector);
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x0010D7EC File Offset: 0x0010B9EC
	private void MACKGLGMKGC(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 187f / (float)EBBBHMGENON;
		float y = 1118f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1212f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("1HandSwordStrafeLeft", value);
		base.GetComponent<Renderer>().material.SetTextureScale("Adjust", vector);
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x0010D88C File Offset: 0x0010BA8C
	private void DMIKEMNGHJO(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 811f / (float)EBBBHMGENON;
		float y = 613f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 855f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("0_", value);
		base.GetComponent<Renderer>().material.SetTextureScale("IceHockeyDekeMiddle", vector);
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x0010D4E6 File Offset: 0x0010B6E6
	private void FOHLAIIMNFB()
	{
		this.NJFHCHLHJJH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x0010D92A File Offset: 0x0010BB2A
	private void KBMKHLDOIKP()
	{
		this.HCIGEONAAEH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x0010D958 File Offset: 0x0010BB58
	private void DABHIDOFEFK(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 553f / (float)EBBBHMGENON;
		float y = 813f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1065f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("shop_t19", value);
		base.GetComponent<Renderer>().material.SetTextureScale("_EmissionColor", vector);
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x0010D9F8 File Offset: 0x0010BBF8
	private void DNJJIAOMIDD(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1889f / (float)EBBBHMGENON;
		float y = 28f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 937f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("MotorbikeTurnLeft", value);
		base.GetComponent<Renderer>().material.SetTextureScale("ProneLocomotion", vector);
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x0010DA98 File Offset: 0x0010BC98
	private void CCKEIJPCBHH(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 317f / (float)EBBBHMGENON;
		float y = 865f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1319f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("SoccerSprint", value);
		base.GetComponent<Renderer>().material.SetTextureScale("_Scale", vector);
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x0010DB38 File Offset: 0x0010BD38
	private void DOECAHALJAK(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 898f / (float)EBBBHMGENON;
		float y = 1648f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1561f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("_Texture", value);
		base.GetComponent<Renderer>().material.SetTextureScale("FacePalm", vector);
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x0010DBFC File Offset: 0x0010BDFC
	private void HCIGEONAAEH(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1f / (float)EBBBHMGENON;
		float y = 1f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", value);
		base.GetComponent<Renderer>().material.SetTextureScale("_MainTex", vector);
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x0010DC9A File Offset: 0x0010BE9A
	private void KMLNBHIIGKH()
	{
		this.ELOMGKBEJCM(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x0010DCC8 File Offset: 0x0010BEC8
	private void GGABFNKJOAO(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1696f / (float)EBBBHMGENON;
		float y = 874f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 449f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("Water", value);
		base.GetComponent<Renderer>().material.SetTextureScale("Hidden/Post FX/Screen Space Reflection", vector);
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x0010DD66 File Offset: 0x0010BF66
	private void OFPGMNGFLNH()
	{
		this.NFPOMHINBKP(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x0010DD94 File Offset: 0x0010BF94
	private void ELOMGKBEJCM(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 333f / (float)EBBBHMGENON;
		float y = 1541f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1606f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("Leg", value);
		base.GetComponent<Renderer>().material.SetTextureScale("repair.ogg", vector);
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x0010DE32 File Offset: 0x0010C032
	private void FJEEADNCKAG()
	{
		this.GGABFNKJOAO(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x0010DE5E File Offset: 0x0010C05E
	private void GCNGEFBKMNC()
	{
		this.EGAHENKFGAJ(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x0010DE8A File Offset: 0x0010C08A
	private void EMFOECIPBIP()
	{
		this.NMCJHOKCIBH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x0010DEB8 File Offset: 0x0010C0B8
	private void MFGLEGEBICF(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1337f / (float)EBBBHMGENON;
		float y = 1052f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 580f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("WandAttack2", value);
		base.GetComponent<Renderer>().material.SetTextureScale("No IK assigned in HitReaction", vector);
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x0010DF58 File Offset: 0x0010C158
	private void DOINIMLKPON(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 828f / (float)EBBBHMGENON;
		float y = 1099f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1555f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("RollerBladeTurnRight", value);
		base.GetComponent<Renderer>().material.SetTextureScale("FlyRight", vector);
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x0010DFF8 File Offset: 0x0010C1F8
	private void PMHCMLDMLNL(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1130f / (float)EBBBHMGENON;
		float y = 1814f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1601f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("human_move_2.wav", value);
		base.GetComponent<Renderer>().material.SetTextureScale("repair.ogg", vector);
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x0010E098 File Offset: 0x0010C298
	private void OAGHLEABMPM(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 559f / (float)EBBBHMGENON;
		float y = 1004f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1116f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("torso", value);
		base.GetComponent<Renderer>().material.SetTextureScale("minWgtBait", vector);
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x0010E136 File Offset: 0x0010C336
	private void JOHDLNOKCOK()
	{
		this.GAHGCAJBCPJ(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x0010E164 File Offset: 0x0010C364
	private void OJJGOPBIDBL(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1431f / (float)EBBBHMGENON;
		float y = 1695f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1260f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("_LumTex", value);
		base.GetComponent<Renderer>().material.SetTextureScale("invn_rec14", vector);
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x0010E204 File Offset: 0x0010C404
	private void EPFEPFPBLDN(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1426f / (float)EBBBHMGENON;
		float y = 1921f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1114f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("wpn_eat5", value);
		base.GetComponent<Renderer>().material.SetTextureScale("name", vector);
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x0010E2A4 File Offset: 0x0010C4A4
	private void NJFHCHLHJJH(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1511f / (float)EBBBHMGENON;
		float y = 1764f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 290f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("WizardOverhead", value);
		base.GetComponent<Renderer>().material.SetTextureScale("</i></color>", vector);
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x0010DD66 File Offset: 0x0010BF66
	private void BNKJNBIDPME()
	{
		this.NFPOMHINBKP(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x0010E344 File Offset: 0x0010C544
	private void DNAJJCFJOIN(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 848f / (float)EBBBHMGENON;
		float y = 565f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1268f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("", value);
		base.GetComponent<Renderer>().material.SetTextureScale("upRod", vector);
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x0010DC9A File Offset: 0x0010BE9A
	private void GDBBAMFMKII()
	{
		this.ELOMGKBEJCM(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x0010DE8A File Offset: 0x0010C08A
	private void JIFOELPAEHG()
	{
		this.NMCJHOKCIBH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x0010D92A File Offset: 0x0010BB2A
	private void Update()
	{
		this.HCIGEONAAEH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x0010E3E2 File Offset: 0x0010C5E2
	private void BEDAJLJFAFO()
	{
		this.MFGLEGEBICF(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x0010E410 File Offset: 0x0010C610
	private void PNBILJEPBFP(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1860f / (float)EBBBHMGENON;
		float y = 1328f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 26f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("U", value);
		base.GetComponent<Renderer>().material.SetTextureScale("rait_5", vector);
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x0010E4AE File Offset: 0x0010C6AE
	private void IKHCCAANGOP()
	{
		this.MACKGLGMKGC(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x0010D92A File Offset: 0x0010BB2A
	private void PJHEGHHOJHJ()
	{
		this.HCIGEONAAEH(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x0010E4DA File Offset: 0x0010C6DA
	private void LDDIGEMBDNF()
	{
		this.DABHIDOFEFK(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x0010E508 File Offset: 0x0010C708
	private void IKHJNCKDHCF(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 222f / (float)EBBBHMGENON;
		float y = 349f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 1211f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("droprodmsg1", value);
		base.GetComponent<Renderer>().material.SetTextureScale("_Exposure", vector);
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x0010E5A8 File Offset: 0x0010C7A8
	private void NFPOMHINBKP(int EBBBHMGENON, int MNKLMJAPIDL, int ICMEOLLBHII, int GEKJADHGNKI, int BCAFJOBBEOG, int DIJEMBAMEKH)
	{
		int num = (int)(Time.time * (float)DIJEMBAMEKH) % BCAFJOBBEOG;
		float x = 1308f / (float)EBBBHMGENON;
		float y = 115f / (float)MNKLMJAPIDL;
		Vector2 vector = new Vector2(x, y);
		int num2 = num % EBBBHMGENON;
		int num3 = num / EBBBHMGENON;
		float x2 = (float)(num2 + GEKJADHGNKI) * vector.x;
		float y2 = 242f - vector.y - (float)(num3 + ICMEOLLBHII) * vector.y;
		Vector2 value = new Vector2(x2, y2);
		base.GetComponent<Renderer>().material.SetTextureOffset("UV0", value);
		base.GetComponent<Renderer>().material.SetTextureScale("WallRunRight", vector);
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x0010E3E2 File Offset: 0x0010C5E2
	private void LBGKAMLLACN()
	{
		this.MFGLEGEBICF(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x0010E646 File Offset: 0x0010C846
	private void DFFOEGHGPGP()
	{
		this.DOECAHALJAK(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x0010D53E File Offset: 0x0010B73E
	private void PNBGJBMJLFM()
	{
		this.EPFEPFPBLDN(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x0010E4DA File Offset: 0x0010C6DA
	private void AIAMIFEPALP()
	{
		this.DABHIDOFEFK(this.colCount, this.rowCount, this.rowNumber, this.colNumber, this.totalCells, this.fps);
	}

	// Token: 0x04000453 RID: 1107
	public int colCount = 4;

	// Token: 0x04000454 RID: 1108
	public int rowCount = 4;

	// Token: 0x04000455 RID: 1109
	public int rowNumber;

	// Token: 0x04000456 RID: 1110
	public int colNumber;

	// Token: 0x04000457 RID: 1111
	public int totalCells = 4;

	// Token: 0x04000458 RID: 1112
	public int fps = 10;

	// Token: 0x04000459 RID: 1113
	private Vector2 IGFJOGKFADM;
}
