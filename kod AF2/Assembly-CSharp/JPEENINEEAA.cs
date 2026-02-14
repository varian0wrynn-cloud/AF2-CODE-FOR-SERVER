using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
public static class JPEENINEEAA
{
	// Token: 0x06010FD4 RID: 69588 RVA: 0x00795760 File Offset: 0x00793960
	public static string PNPOPOBHNJN(this Gradient PFHCDIIBLNG)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GradientColorKey gradientColorKey in PFHCDIIBLNG.colorKeys)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			Color color = gradientColorKey.color;
			stringBuilder2.Append(color.ToString("F3"));
			stringBuilder.Append("&");
			StringBuilder stringBuilder3 = stringBuilder;
			float num = gradientColorKey.time;
			stringBuilder3.Append(num.ToString("F3"));
			stringBuilder.Append("|");
		}
		stringBuilder.Append("\n");
		foreach (GradientAlphaKey gradientAlphaKey in PFHCDIIBLNG.alphaKeys)
		{
			StringBuilder stringBuilder4 = stringBuilder;
			float num = gradientAlphaKey.alpha;
			stringBuilder4.Append(num.ToString("F4"));
			stringBuilder.Append("&");
			StringBuilder stringBuilder5 = stringBuilder;
			num = gradientAlphaKey.time;
			stringBuilder5.Append(num.ToString("F3"));
			stringBuilder.Append("|");
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06010FD5 RID: 69589 RVA: 0x00795864 File Offset: 0x00793A64
	public static bool KEHIAPIFALH(string MNEICNPJGMC, out Gradient PFHCDIIBLNG)
	{
		PFHCDIIBLNG = null;
		string[] array = MNEICNPJGMC.Split(new char[]
		{
			'\n'
		});
		if (array.Length < 2)
		{
			return false;
		}
		string[] array2 = array[0].Split(new char[]
		{
			'|'
		});
		string[] array3 = array[1].Split(new char[]
		{
			'|'
		});
		if (array2.Length < 2 || array3.Length < 2)
		{
			return false;
		}
		List<GradientColorKey> list = new List<GradientColorKey>();
		List<GradientAlphaKey> list2 = new List<GradientAlphaKey>();
		string[] array4 = array2;
		for (int i = 0; i < array4.Length; i++)
		{
			string[] array5 = array4[i].Split(new char[]
			{
				'&'
			});
			Color col;
			float time;
			if (array5.Length >= 2 && JPEENINEEAA.OCPHKBECBLP(array5[0], out col) && float.TryParse(array5[1], out time))
			{
				list.Add(new GradientColorKey(col, time));
			}
		}
		array4 = array3;
		for (int i = 0; i < array4.Length; i++)
		{
			string[] array6 = array4[i].Split(new char[]
			{
				'&'
			});
			float alpha;
			float time2;
			if (array6.Length >= 2 && float.TryParse(array6[0], out alpha) && float.TryParse(array6[1], out time2))
			{
				list2.Add(new GradientAlphaKey(alpha, time2));
			}
		}
		PFHCDIIBLNG = new Gradient();
		PFHCDIIBLNG.SetKeys(list.ToArray(), list2.ToArray());
		return true;
	}

	// Token: 0x06010FD6 RID: 69590 RVA: 0x007959A8 File Offset: 0x00793BA8
	private static bool OCPHKBECBLP(string MNEICNPJGMC, out Color DCCPCBLODIG)
	{
		string[] array = MNEICNPJGMC.Replace("RGBA(", "").Replace(")", "").Split(new char[]
		{
			','
		});
		DCCPCBLODIG = Color.white;
		if (array.Length != 4)
		{
			return false;
		}
		float num = 1f;
		if (!float.TryParse(array[0], out DCCPCBLODIG.r))
		{
			return false;
		}
		if (!float.TryParse(array[1], out DCCPCBLODIG.g))
		{
			return false;
		}
		if (!float.TryParse(array[2], out DCCPCBLODIG.b))
		{
			return false;
		}
		if (!float.TryParse(array[3], out num))
		{
			return false;
		}
		DCCPCBLODIG.a = num / 255f;
		return true;
	}
}
