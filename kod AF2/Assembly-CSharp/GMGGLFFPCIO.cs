using System;
using UnityEngine;

// Token: 0x020004E3 RID: 1251
public static class GMGGLFFPCIO
{
	// Token: 0x06010ECE RID: 69326 RVA: 0x007932AA File Offset: 0x007914AA
	public static float GHFHPPNPLGE(this Vector3 DCCPCBLODIG, HHFDJOLDAPO CLBPBJGLHEE)
	{
		switch (CLBPBJGLHEE)
		{
		case HHFDJOLDAPO.R:
			return DCCPCBLODIG.x;
		case HHFDJOLDAPO.G:
			return DCCPCBLODIG.y;
		case HHFDJOLDAPO.B:
			return DCCPCBLODIG.z;
		default:
			return 0f;
		}
	}

	// Token: 0x06010ECF RID: 69327 RVA: 0x007932DA File Offset: 0x007914DA
	public static float GHFHPPNPLGE(this Vector4 DCCPCBLODIG, HHFDJOLDAPO CLBPBJGLHEE)
	{
		switch (CLBPBJGLHEE)
		{
		case HHFDJOLDAPO.R:
			return DCCPCBLODIG.x;
		case HHFDJOLDAPO.G:
			return DCCPCBLODIG.y;
		case HHFDJOLDAPO.B:
			return DCCPCBLODIG.z;
		case HHFDJOLDAPO.A:
			return DCCPCBLODIG.w;
		default:
			return 0f;
		}
	}

	// Token: 0x06010ED0 RID: 69328 RVA: 0x00793315 File Offset: 0x00791515
	public static float GHFHPPNPLGE(this Color DCCPCBLODIG, HHFDJOLDAPO CLBPBJGLHEE)
	{
		switch (CLBPBJGLHEE)
		{
		case HHFDJOLDAPO.R:
			return DCCPCBLODIG.r;
		case HHFDJOLDAPO.G:
			return DCCPCBLODIG.g;
		case HHFDJOLDAPO.B:
			return DCCPCBLODIG.b;
		case HHFDJOLDAPO.A:
			return DCCPCBLODIG.a;
		default:
			return 0f;
		}
	}

	// Token: 0x06010ED1 RID: 69329 RVA: 0x00793350 File Offset: 0x00791550
	public static uint MPPGKILCJEB(this HHFDJOLDAPO PBDMCLPNCBJ)
	{
		int num = (int)(PBDMCLPNCBJ + 1);
		if (num < 3)
		{
			return (uint)num;
		}
		if (num != 3)
		{
			return 8U;
		}
		return 4U;
	}

	// Token: 0x06010ED2 RID: 69330 RVA: 0x00793370 File Offset: 0x00791570
	public static string HPADJPKKDOG(this HHFDJOLDAPO JHCDAMFNILE, LKDKDMIBAJN DFBHMIIPLCA = LKDKDMIBAJN.Vector)
	{
		int num = (int)JHCDAMFNILE;
		if (DFBHMIIPLCA == LKDKDMIBAJN.Vector)
		{
			if (num == 0)
			{
				return "X";
			}
			if (num == 1)
			{
				return "Y";
			}
			if (num != 2)
			{
				return "W";
			}
			return "Z";
		}
		else
		{
			if (DFBHMIIPLCA != LKDKDMIBAJN.Color)
			{
				return num.ToString();
			}
			if (num == 0)
			{
				return "R";
			}
			if (num == 1)
			{
				return "G";
			}
			if (num != 2)
			{
				return "A";
			}
			return "B";
		}
	}

	// Token: 0x04002367 RID: 9063
	public static readonly GUIContent[] LNLADOGOJMO = new GUIContent[]
	{
		new GUIContent("X (R)"),
		new GUIContent("Y (G)"),
		new GUIContent("Z (B)"),
		new GUIContent("W (A)")
	};

	// Token: 0x04002368 RID: 9064
	public static readonly int[] APKFJNKMNPA = new int[]
	{
		0,
		1,
		2,
		3
	};
}
