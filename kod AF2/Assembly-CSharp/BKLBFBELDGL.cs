using System;
using System.Globalization;
using UnityEngine;

// Token: 0x02000191 RID: 401
public static class BKLBFBELDGL
{
	// Token: 0x0600596D RID: 22893 RVA: 0x002AA4E4 File Offset: 0x002A86E4
	public static int JINEPMONCHF(string DCCPCBLODIG)
	{
		int result;
		try
		{
			result = int.Parse(DCCPCBLODIG, NumberStyles.HexNumber);
		}
		catch (Exception)
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600596E RID: 22894 RVA: 0x002AA518 File Offset: 0x002A8718
	public static string JFPJAAAAHEK(int DCCPCBLODIG)
	{
		string text = DCCPCBLODIG.ToString("X");
		if (text.Length == 1)
		{
			text = "0" + text;
		}
		return text;
	}

	// Token: 0x0600596F RID: 22895 RVA: 0x002AA548 File Offset: 0x002A8748
	public static string OBNBJCAOBOM(float DCCPCBLODIG)
	{
		return BKLBFBELDGL.JFPJAAAAHEK(int.Parse(DCCPCBLODIG.ToString()));
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x002AA55C File Offset: 0x002A875C
	public static bool JMGMHLCELLF(string DCCPCBLODIG, out Color LBCGACKJCJB)
	{
		if (DCCPCBLODIG.Length != 8)
		{
			LBCGACKJCJB = Color.white;
			return false;
		}
		string dccpcblodig = DCCPCBLODIG.Substring(0, 2);
		string dccpcblodig2 = DCCPCBLODIG.Substring(2, 2);
		string dccpcblodig3 = DCCPCBLODIG.Substring(4, 2);
		string dccpcblodig4 = DCCPCBLODIG.Substring(6, 2);
		float num = (float)BKLBFBELDGL.JINEPMONCHF(dccpcblodig) / 255f;
		float num2 = (float)BKLBFBELDGL.JINEPMONCHF(dccpcblodig2) / 255f;
		float num3 = (float)BKLBFBELDGL.JINEPMONCHF(dccpcblodig3) / 255f;
		float num4 = (float)BKLBFBELDGL.JINEPMONCHF(dccpcblodig4) / 255f;
		if (num < 0f || num2 < 0f || num3 < 0f || num4 < 0f)
		{
			LBCGACKJCJB = Color.white;
			return false;
		}
		LBCGACKJCJB = new Color(num, num2, num3, num4);
		return true;
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x002AA620 File Offset: 0x002A8820
	public static string LGLBALFHPIJ(Color LBCGACKJCJB)
	{
		return BKLBFBELDGL.OBNBJCAOBOM(LBCGACKJCJB.r * 255f) + BKLBFBELDGL.OBNBJCAOBOM(LBCGACKJCJB.g * 255f) + BKLBFBELDGL.OBNBJCAOBOM(LBCGACKJCJB.b * 255f) + BKLBFBELDGL.OBNBJCAOBOM(LBCGACKJCJB.a * 255f);
	}
}
