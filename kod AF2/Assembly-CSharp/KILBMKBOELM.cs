using System;
using UnityEngine;

// Token: 0x02000190 RID: 400
public static class KILBMKBOELM
{
	// Token: 0x06005968 RID: 22888 RVA: 0x002AA2E1 File Offset: 0x002A84E1
	public static void ODHIMGMMNPH(Vector2 FMOLJBNCLNL, Vector2 HGPPNJNFGIM, Color LBCGACKJCJB)
	{
		KILBMKBOELM.ODHIMGMMNPH(FMOLJBNCLNL, HGPPNJNFGIM, LBCGACKJCJB, 1);
	}

	// Token: 0x06005969 RID: 22889 RVA: 0x002AA2EC File Offset: 0x002A84EC
	public static void ODHIMGMMNPH(Vector2 FMOLJBNCLNL, Vector2 HGPPNJNFGIM, Color LBCGACKJCJB, int NPIHOLDPJNJ)
	{
		if (KILBMKBOELM.MLBDMDNIKCN == null || KILBMKBOELM.MAECCFEADEN != LBCGACKJCJB)
		{
			KILBMKBOELM.MAECCFEADEN = LBCGACKJCJB;
			KILBMKBOELM.MLBDMDNIKCN = new Texture2D(1, 1);
			KILBMKBOELM.MLBDMDNIKCN.SetPixel(0, 0, KILBMKBOELM.MAECCFEADEN);
			KILBMKBOELM.MLBDMDNIKCN.wrapMode = TextureWrapMode.Repeat;
			KILBMKBOELM.MLBDMDNIKCN.Apply();
		}
		KILBMKBOELM.NBBLDJKOEKK(FMOLJBNCLNL, HGPPNJNFGIM, KILBMKBOELM.MLBDMDNIKCN, NPIHOLDPJNJ);
	}

	// Token: 0x0600596A RID: 22890 RVA: 0x002AA358 File Offset: 0x002A8558
	public static void NBBLDJKOEKK(Vector2 FMOLJBNCLNL, Vector2 HGPPNJNFGIM, Texture2D KEDGAOBCNJG, int NPIHOLDPJNJ)
	{
		Vector2 vector = HGPPNJNFGIM - FMOLJBNCLNL;
		float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
		if (vector.x < 0f)
		{
			num += 180f;
		}
		if (NPIHOLDPJNJ < 1)
		{
			NPIHOLDPJNJ = 1;
		}
		int num2 = (int)Mathf.Ceil((float)(NPIHOLDPJNJ / 2));
		GUIUtility.RotateAroundPivot(num, FMOLJBNCLNL);
		GUI.DrawTexture(new Rect(FMOLJBNCLNL.x, FMOLJBNCLNL.y - (float)num2, vector.magnitude, (float)NPIHOLDPJNJ), KEDGAOBCNJG);
		GUIUtility.RotateAroundPivot(-num, FMOLJBNCLNL);
	}

	// Token: 0x0600596B RID: 22891 RVA: 0x002AA3DF File Offset: 0x002A85DF
	public static void ODHIMGMMNPH(Vector2 FMOLJBNCLNL, Vector2 HGPPNJNFGIM, Texture2D KEDGAOBCNJG)
	{
		KILBMKBOELM.ODHIMGMMNPH(FMOLJBNCLNL, HGPPNJNFGIM, KEDGAOBCNJG, 1);
	}

	// Token: 0x0600596C RID: 22892 RVA: 0x002AA3EC File Offset: 0x002A85EC
	public static void ODHIMGMMNPH(Vector2 FMOLJBNCLNL, Vector2 HGPPNJNFGIM, Texture2D KEDGAOBCNJG, int NPIHOLDPJNJ)
	{
		Vector2 vector = HGPPNJNFGIM - FMOLJBNCLNL;
		float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
		if (vector.x < 0f)
		{
			num += 180f;
		}
		if (NPIHOLDPJNJ < 1)
		{
			NPIHOLDPJNJ = 1;
		}
		int num2 = (int)Mathf.Ceil((float)(NPIHOLDPJNJ / 2));
		Rect position = new Rect(FMOLJBNCLNL.x, FMOLJBNCLNL.y - (float)num2, Vector2.Distance(FMOLJBNCLNL, HGPPNJNFGIM), (float)NPIHOLDPJNJ);
		GUIUtility.RotateAroundPivot(num, FMOLJBNCLNL);
		GUI.BeginGroup(position);
		int num3 = Mathf.RoundToInt(position.width);
		int num4 = Mathf.RoundToInt(position.height);
		for (int i = 0; i < num4; i += KEDGAOBCNJG.height)
		{
			for (int j = 0; j < num3; j += KEDGAOBCNJG.width)
			{
				GUI.DrawTexture(new Rect((float)j, (float)i, (float)KEDGAOBCNJG.width, (float)KEDGAOBCNJG.height), KEDGAOBCNJG);
			}
		}
		GUI.EndGroup();
		GUIUtility.RotateAroundPivot(-num, FMOLJBNCLNL);
	}

	// Token: 0x04000D52 RID: 3410
	private static Texture2D MLBDMDNIKCN;

	// Token: 0x04000D53 RID: 3411
	private static Color MAECCFEADEN;
}
