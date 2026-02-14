using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x02000503 RID: 1283
public static class KMAJFAMPPMG
{
	// Token: 0x06011296 RID: 70294 RVA: 0x007A263C File Offset: 0x007A083C
	public static T[] DBBLNCMBENK<T>(T DCCPCBLODIG, int ILFHHDNJHNM)
	{
		T[] array = new T[ILFHHDNJHNM];
		for (int i = 0; i < ILFHHDNJHNM; i++)
		{
			array[i] = DCCPCBLODIG;
		}
		return array;
	}

	// Token: 0x06011297 RID: 70295 RVA: 0x007A2668 File Offset: 0x007A0868
	public static T[] DBBLNCMBENK<T>(Func<int, T> LFNIPPNICJA, int ILFHHDNJHNM)
	{
		T[] array = new T[ILFHHDNJHNM];
		for (int i = 0; i < ILFHHDNJHNM; i++)
		{
			array[i] = LFNIPPNICJA(i);
		}
		return array;
	}

	// Token: 0x06011298 RID: 70296 RVA: 0x007A2698 File Offset: 0x007A0898
	public static T[] AHJIOKOKHBF<T>(T[] INFEGEBCAAF)
	{
		if (INFEGEBCAAF == null)
		{
			return null;
		}
		T[] array = new T[INFEGEBCAAF.Length];
		Array.Copy(INFEGEBCAAF, 0, array, 0, INFEGEBCAAF.Length);
		return array;
	}

	// Token: 0x06011299 RID: 70297 RVA: 0x007A26C0 File Offset: 0x007A08C0
	public static Dictionary<K, V> MHOILMLNODN<K, V>(Func<int, K> OPFEONGHELJ, Func<int, V> MIAAKPGIKIP, int ILFHHDNJHNM)
	{
		Dictionary<K, V> dictionary = new Dictionary<K, V>(ILFHHDNJHNM);
		for (int i = 0; i < ILFHHDNJHNM; i++)
		{
			dictionary.Add(OPFEONGHELJ(i), MIAAKPGIKIP(i));
		}
		return dictionary;
	}

	// Token: 0x0601129A RID: 70298 RVA: 0x007A26F8 File Offset: 0x007A08F8
	public static string LHNOBJDFOOJ<T>(this IEnumerable<T> LALNMIIJJKH, string MBKNGFELHAG)
	{
		if (LALNMIIJJKH == null)
		{
			return "";
		}
		return string.Join(MBKNGFELHAG ?? "", LALNMIIJJKH.Select(new Func<T, string>(KMAJFAMPPMG.<>c__4<T>.<>9.LGCJDACMMLK)).ToArray<string>());
	}

	// Token: 0x0601129B RID: 70299 RVA: 0x007A2748 File Offset: 0x007A0948
	public static string LHNOBJDFOOJ<K, V>(this Dictionary<K, V> BNBKCCPMNEO, string MBKNGFELHAG)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<K, V> keyValuePair in BNBKCCPMNEO)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			K key = keyValuePair.Key;
			string str = key.ToString();
			string str2 = ": ";
			V value = keyValuePair.Value;
			stringBuilder2.AppendLine(str + str2 + value.ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601129C RID: 70300 RVA: 0x007A27D8 File Offset: 0x007A09D8
	public static void MIGHFGEBMPE<T>(ref T[] INFEGEBCAAF, int GEOOOEKMLMA)
	{
		T[] array = new T[GEOOOEKMLMA];
		Array.Copy(INFEGEBCAAF, array, Math.Min(INFEGEBCAAF.Length, GEOOOEKMLMA));
		INFEGEBCAAF = array;
	}

	// Token: 0x0601129D RID: 70301 RVA: 0x007A2804 File Offset: 0x007A0A04
	public static Dictionary<K, T> GKINLLHOLAJ<T, K>(this Dictionary<T, IEnumerable<K>> IOCLPMBFPLH)
	{
		Dictionary<K, T> dictionary = new Dictionary<K, T>();
		foreach (KeyValuePair<T, IEnumerable<K>> keyValuePair in IOCLPMBFPLH)
		{
			foreach (K key in keyValuePair.Value)
			{
				dictionary.Add(key, keyValuePair.Key);
			}
		}
		return dictionary;
	}

	// Token: 0x0601129E RID: 70302 RVA: 0x007A2898 File Offset: 0x007A0A98
	public static Dictionary<T, int> DKHCBIDDGJE<T>(this List<List<T>> PGAMJCCHLLP)
	{
		Dictionary<T, int> dictionary = new Dictionary<T, int>();
		int num = 0;
		foreach (List<T> list in PGAMJCCHLLP)
		{
			foreach (T key in list)
			{
				dictionary.Add(key, num);
			}
			num++;
		}
		return dictionary;
	}

	// Token: 0x0601129F RID: 70303 RVA: 0x007A292C File Offset: 0x007A0B2C
	public static Color32 IIAFGICFLIF(Color32 HFKFJPLEAGK, Color32 AJFADLOIJDK, ENMJPLEGNCI CBFFOOKAIAK, float CGFLAIMHHOO)
	{
		return new Color32(CBFFOOKAIAK.AJMNDCHJPNK ? ((byte)((float)HFKFJPLEAGK.r * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.r * CGFLAIMHHOO)) : HFKFJPLEAGK.r, CBFFOOKAIAK.BHJFHCHMOGL ? ((byte)((float)HFKFJPLEAGK.g * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.g * CGFLAIMHHOO)) : HFKFJPLEAGK.g, CBFFOOKAIAK.HHAGIHEGFML ? ((byte)((float)HFKFJPLEAGK.b * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.b * CGFLAIMHHOO)) : HFKFJPLEAGK.b, CBFFOOKAIAK.EGABJKIFAON ? ((byte)((float)HFKFJPLEAGK.a * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.a * CGFLAIMHHOO)) : HFKFJPLEAGK.a);
	}

	// Token: 0x060112A0 RID: 70304 RVA: 0x007A29E8 File Offset: 0x007A0BE8
	public static Color32 IIAFGICFLIF(Color32 HFKFJPLEAGK, Color32 AJFADLOIJDK, float CGFLAIMHHOO)
	{
		return new Color32((byte)((float)HFKFJPLEAGK.r * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.r * CGFLAIMHHOO), (byte)((float)HFKFJPLEAGK.g * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.g * CGFLAIMHHOO), (byte)((float)HFKFJPLEAGK.b * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.b * CGFLAIMHHOO), (byte)((float)HFKFJPLEAGK.a * (1f - CGFLAIMHHOO) + (float)AJFADLOIJDK.a * CGFLAIMHHOO));
	}

	// Token: 0x060112A1 RID: 70305 RVA: 0x007A2A64 File Offset: 0x007A0C64
	public static AnimationCurve AIHENPDOKAO(AnimationCurve HAPKPCKIPJK, float GJIBJNDFLNL, float LOIJBDGKOCI, float OIIJOEGJDIA, float MDPEOMPCCDO)
	{
		Keyframe[] keys = HAPKPCKIPJK.keys;
		int num = HAPKPCKIPJK.length - 1;
		keys[0].time = GJIBJNDFLNL;
		keys[0].value = LOIJBDGKOCI;
		keys[num].time = OIIJOEGJDIA;
		keys[num].value = MDPEOMPCCDO;
		HAPKPCKIPJK.keys = keys;
		return new AnimationCurve(keys);
	}

	// Token: 0x060112A2 RID: 70306 RVA: 0x007A2AC4 File Offset: 0x007A0CC4
	public static Enum INFLFKIJBGB(this Enum DCCPCBLODIG)
	{
		int num = Enum.GetNames(DCCPCBLODIG.GetType()).Length;
		return (Enum)Enum.ToObject(DCCPCBLODIG.GetType(), (Convert.ToInt32(DCCPCBLODIG) + 1) % num);
	}

	// Token: 0x060112A3 RID: 70307 RVA: 0x007A2AF9 File Offset: 0x007A0CF9
	public static bool CHFHJDFDIGB<T>(this T FFGIAHPIPEK) where T : PHINMIABECJ
	{
		return FFGIAHPIPEK != null && FFGIAHPIPEK.CHFHJDFDIGB;
	}

	// Token: 0x060112A4 RID: 70308 RVA: 0x007A2B14 File Offset: 0x007A0D14
	internal static string HEBLJJLBDJM(string GKAAHHCHIGI, string BNIHFBMEPAB)
	{
		Match match = new Regex("^(" + GKAAHHCHIGI + "[0-9]*_)").Match(BNIHFBMEPAB);
		string result;
		if (match.Success)
		{
			string s = match.Value.Replace(GKAAHHCHIGI, "").Replace("_", "");
			int num = 0;
			if (int.TryParse(s, out num))
			{
				result = BNIHFBMEPAB.Replace(match.Value, GKAAHHCHIGI + (num + 1) + "_");
			}
			else
			{
				result = GKAAHHCHIGI + "0_" + BNIHFBMEPAB;
			}
		}
		else
		{
			result = GKAAHHCHIGI + "0_" + BNIHFBMEPAB;
		}
		return result;
	}

	// Token: 0x060112A5 RID: 70309 RVA: 0x007A2BB4 File Offset: 0x007A0DB4
	public static Mesh DNJJECEDGLD(this GameObject BNKBOICOODI)
	{
		MeshFilter component = BNKBOICOODI.GetComponent<MeshFilter>();
		if (component != null && component.sharedMesh != null)
		{
			return component.sharedMesh;
		}
		SkinnedMeshRenderer component2 = BNKBOICOODI.GetComponent<SkinnedMeshRenderer>();
		if (component2 != null && component2.sharedMesh != null)
		{
			return component2.sharedMesh;
		}
		return null;
	}

	// Token: 0x060112A6 RID: 70310 RVA: 0x007A2C0C File Offset: 0x007A0E0C
	public static List<Material> DNHBMNNMIEI(this GameObject BNKBOICOODI)
	{
		List<Material> list = new List<Material>();
		foreach (Renderer renderer in BNKBOICOODI.GetComponents<Renderer>())
		{
			list.AddRange(renderer.sharedMaterials);
		}
		return list;
	}

	// Token: 0x060112A7 RID: 70311 RVA: 0x007A2C48 File Offset: 0x007A0E48
	public static Dictionary<T, List<K>> HCACHJLLCMO<T, K>(this IEnumerable<IGrouping<T, K>> HOKEPJMCEEC)
	{
		Dictionary<T, List<K>> dictionary = new Dictionary<T, List<K>>();
		foreach (IGrouping<T, K> grouping in HOKEPJMCEEC)
		{
			dictionary.Add(grouping.Key, grouping.ToList<K>());
		}
		return dictionary;
	}
}
