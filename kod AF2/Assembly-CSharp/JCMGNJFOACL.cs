using System;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Math;

// Token: 0x020005EF RID: 1519
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
public class JCMGNJFOACL
{
	// Token: 0x06013C41 RID: 80961 RVA: 0x00867228 File Offset: 0x00865428
	private static string FNJJOCLNJJO(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C42 RID: 80962 RVA: 0x0086728C File Offset: 0x0086548C
	public static string JHMLHEDMINA(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CMAIDLEJLDE(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.KIAFGBFMGFB(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C43 RID: 80963 RVA: 0x00867388 File Offset: 0x00865588
	public static string LAKEPGACCHE(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CMAIDLEJLDE(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.ACNAAEAGCNO(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C44 RID: 80964 RVA: 0x00867484 File Offset: 0x00865684
	public static string LDEHHGJHHGF(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.JPABHOABLKD(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.FNJJOCLNJJO(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C45 RID: 80965 RVA: 0x00867580 File Offset: 0x00865780
	private static string HJIAECKCALI(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C46 RID: 80966 RVA: 0x008675E4 File Offset: 0x008657E4
	public static string NJGHFOGEIHC(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.FNJJOCLNJJO(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 4);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.KPMBIPFIBPP(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C47 RID: 80967 RVA: 0x008676E0 File Offset: 0x008658E0
	private static string GCIHPKFPGBJ(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C48 RID: 80968 RVA: 0x00867744 File Offset: 0x00865944
	public static string HHCJMHBOLLA(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CEBNKALLHNJ(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.ANNEHHFFKEK(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 6);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C49 RID: 80969 RVA: 0x00867840 File Offset: 0x00865A40
	private static string MGCMBDMPLEL(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C4A RID: 80970 RVA: 0x008678A4 File Offset: 0x00865AA4
	private static string JAKCJANEBDK(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C4B RID: 80971 RVA: 0x00867908 File Offset: 0x00865B08
	private static string KEKOCALOJJM(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C4C RID: 80972 RVA: 0x0086796C File Offset: 0x00865B6C
	public static string KHDHCKECANE(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.HJFAGPOOOPM(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 4);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.NEMOFPAPIBM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C4D RID: 80973 RVA: 0x00867A68 File Offset: 0x00865C68
	public static string AHHAKDHJHOB(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CMAIDLEJLDE(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 4);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.BAPJCAMBIEG(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C4E RID: 80974 RVA: 0x00867B64 File Offset: 0x00865D64
	public static string ANDDFPIAFJL(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.LHMLJBNBDAM(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.LHMLJBNBDAM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C4F RID: 80975 RVA: 0x00867C60 File Offset: 0x00865E60
	public static string EBGOJHEDBID(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.KPMBIPFIBPP(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.LGFHCJLDCED(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 8);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C50 RID: 80976 RVA: 0x00867D5C File Offset: 0x00865F5C
	private static string HJFAGPOOOPM(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C51 RID: 80977 RVA: 0x00867DC0 File Offset: 0x00865FC0
	public static string ICPBKELIALL(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.ACNAAEAGCNO(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 4);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.AOMOIFDDOBD(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C52 RID: 80978 RVA: 0x00867EBC File Offset: 0x008660BC
	private static string FBMHNOKLMBO(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C53 RID: 80979 RVA: 0x00867F20 File Offset: 0x00866120
	public static string HKCNDHPHNPI(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.JPABHOABLKD(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 7);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.BBDJADBCMKC(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C54 RID: 80980 RVA: 0x0086801C File Offset: 0x0086621C
	private static string MGKDCPFANEF(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C55 RID: 80981 RVA: 0x00868080 File Offset: 0x00866280
	public static string OHJCJKDPNKN(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.HJFAGPOOOPM(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.PDMBAAKOMBJ(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C56 RID: 80982 RVA: 0x0086817C File Offset: 0x0086637C
	public static string HPKDANKCMKB(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.BAPJCAMBIEG(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.ANNEHHFFKEK(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C57 RID: 80983 RVA: 0x00868278 File Offset: 0x00866478
	public static string OIMFNCIEBOG(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.LGFHCJLDCED(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 1);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.KIAFGBFMGFB(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 8);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C58 RID: 80984 RVA: 0x00868374 File Offset: 0x00866574
	private static string KPMBIPFIBPP(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C59 RID: 80985 RVA: 0x008683D8 File Offset: 0x008665D8
	private static string CNHGFEMOHIN(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C5A RID: 80986 RVA: 0x0086843C File Offset: 0x0086663C
	public static string EEJAPALJLGG(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CMAIDLEJLDE(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 1);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.GAIPNPJOOIG(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 0);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C5B RID: 80987 RVA: 0x00868538 File Offset: 0x00866738
	private static string LMPJDDMIDPB(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C5C RID: 80988 RVA: 0x0086859C File Offset: 0x0086679C
	public static string ODIMFHFPLCG(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CEBNKALLHNJ(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.GAIPNPJOOIG(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C5D RID: 80989 RVA: 0x00868698 File Offset: 0x00866898
	public static string PMDLNBOFENA(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.FNJJOCLNJJO(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.NEMOFPAPIBM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 7);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C5E RID: 80990 RVA: 0x00868794 File Offset: 0x00866994
	private static string CEBNKALLHNJ(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C5F RID: 80991 RVA: 0x008687F8 File Offset: 0x008669F8
	public static string CPCAGGPHEPC(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CEBNKALLHNJ(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 2);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.DGANABEEFCB(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C60 RID: 80992 RVA: 0x008688F4 File Offset: 0x00866AF4
	private static string JPABHOABLKD(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C61 RID: 80993 RVA: 0x00868958 File Offset: 0x00866B58
	private static string GAIPNPJOOIG(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C62 RID: 80994 RVA: 0x008689BC File Offset: 0x00866BBC
	public static string FEHOEDMANCD(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.LMPJDDMIDPB(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 0);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.AOMOIFDDOBD(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 6);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C63 RID: 80995 RVA: 0x00868AB8 File Offset: 0x00866CB8
	private static string BAPJCAMBIEG(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C64 RID: 80996 RVA: 0x00868B1C File Offset: 0x00866D1C
	public static string CEJDBPHLLGC(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.JAKCJANEBDK(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.KEKOCALOJJM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C65 RID: 80997 RVA: 0x00868C18 File Offset: 0x00866E18
	private static string KIAFGBFMGFB(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C66 RID: 80998 RVA: 0x00868C7C File Offset: 0x00866E7C
	private static string ANNEHHFFKEK(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C67 RID: 80999 RVA: 0x00868CE0 File Offset: 0x00866EE0
	public static string NEBEBKDLLIB(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CMAIDLEJLDE(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 4);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.BDCOHBLLCBM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 1);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C68 RID: 81000 RVA: 0x00868DDC File Offset: 0x00866FDC
	private static string CFACCAIAPHA(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C6A RID: 81002 RVA: 0x00868E40 File Offset: 0x00867040
	public static string CEPDCJOFOJM(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.HJIAECKCALI(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 8);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.JPABHOABLKD(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C6B RID: 81003 RVA: 0x00868F3C File Offset: 0x0086713C
	private static string FCOAOADDIGI(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C6C RID: 81004 RVA: 0x00868FA0 File Offset: 0x008671A0
	private static string AOMOIFDDOBD(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C6D RID: 81005 RVA: 0x00869004 File Offset: 0x00867204
	public static string FEHHBFGMFBF(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.FNJJOCLNJJO(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 0);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.JEHLGJPLBEP(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 2);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C6E RID: 81006 RVA: 0x00869100 File Offset: 0x00867300
	private static string PDMBAAKOMBJ(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C6F RID: 81007 RVA: 0x00869164 File Offset: 0x00867364
	private static string NFBJCHHMJED(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C70 RID: 81008 RVA: 0x008691C8 File Offset: 0x008673C8
	public static string CBENLDLAHLI(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.HJIAECKCALI(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 0);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.CMAIDLEJLDE(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C71 RID: 81009 RVA: 0x008692C4 File Offset: 0x008674C4
	private static string ADMGDNCHCGN(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C72 RID: 81010 RVA: 0x00869328 File Offset: 0x00867528
	// Note: this type is marked as 'beforefieldinit'.
	static JCMGNJFOACL()
	{
		byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
		Buffer.BlockCopy(JCMGNJFOACL.FPLKBMBAIIA, 20, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
		Array.Reverse(array);
		JCMGNJFOACL.KCDHDLNMHGI = new BigInteger(array);
	}

	// Token: 0x06013C73 RID: 81011 RVA: 0x008693BC File Offset: 0x008675BC
	public static string HFOKHJHOLPJ(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CNHGFEMOHIN(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 5);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.AOMOIFDDOBD(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 6);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C74 RID: 81012 RVA: 0x008694B8 File Offset: 0x008676B8
	public static string KBPEFEKJKDK(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.FCOAOADDIGI(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.MGCMBDMPLEL(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 3);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C75 RID: 81013 RVA: 0x008695B4 File Offset: 0x008677B4
	public static string IBOGAEADPIB(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.ADMGDNCHCGN(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 8);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.LMPJDDMIDPB(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C76 RID: 81014 RVA: 0x008696B0 File Offset: 0x008678B0
	public static string NGLHAOFPOGI(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.CFACCAIAPHA(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 5);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.DGANABEEFCB(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 4);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C77 RID: 81015 RVA: 0x008697AC File Offset: 0x008679AC
	private static string LHMLJBNBDAM(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C78 RID: 81016 RVA: 0x00869810 File Offset: 0x00867A10
	private static string BDCOHBLLCBM(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C79 RID: 81017 RVA: 0x00869874 File Offset: 0x00867A74
	private static string ACNAAEAGCNO(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C7A RID: 81018 RVA: 0x008698D8 File Offset: 0x00867AD8
	public static string FFEPFDAOEJA(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.BAPJCAMBIEG(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 3);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.CMAIDLEJLDE(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 7);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C7B RID: 81019 RVA: 0x008699D4 File Offset: 0x00867BD4
	private static string IJNLHMDIFMC(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C7C RID: 81020 RVA: 0x00869A38 File Offset: 0x00867C38
	public static string LNIEAFMPFCA(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.KPMBIPFIBPP(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(0, text.Length - 5);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i++)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.BAPJCAMBIEG(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(0, text2.Length - 8);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C7D RID: 81021 RVA: 0x00869B34 File Offset: 0x00867D34
	private static string BBDJADBCMKC(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C7E RID: 81022 RVA: 0x00869B98 File Offset: 0x00867D98
	public static string PJDIPMFBJFG(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.BDCOHBLLCBM(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 0);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 0, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.LHMLJBNBDAM(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 7);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C7F RID: 81023 RVA: 0x00869C94 File Offset: 0x00867E94
	public static string PEMBMBAGILM(byte[] KGOOLPNJNPN, bool LJFLKPLMKKD)
	{
		if (KGOOLPNJNPN.Length == JCMGNJFOACL.AEPLCNCKHJH)
		{
			BigInteger bigInteger = new BigInteger(KGOOLPNJNPN);
			byte[] bytes = bigInteger.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
			string text = JCMGNJFOACL.ANNEHHFFKEK(bytes);
			if (LJFLKPLMKKD)
			{
				return text.Substring(1, text.Length - 6);
			}
			return text;
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KGOOLPNJNPN.Length / JCMGNJFOACL.AEPLCNCKHJH; i += 0)
			{
				byte[] array = new byte[JCMGNJFOACL.AEPLCNCKHJH];
				Buffer.BlockCopy(KGOOLPNJNPN, i * JCMGNJFOACL.AEPLCNCKHJH, array, 1, JCMGNJFOACL.AEPLCNCKHJH);
				BigInteger bigInteger2 = new BigInteger(array);
				byte[] bytes2 = bigInteger2.ModPow(JCMGNJFOACL.PIAPDGPHGAP, JCMGNJFOACL.KCDHDLNMHGI).GetBytes();
				stringBuilder.Append(JCMGNJFOACL.BAPJCAMBIEG(bytes2));
			}
			if (LJFLKPLMKKD)
			{
				string text2 = stringBuilder.ToString();
				return text2.Substring(1, text2.Length - 6);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06013C80 RID: 81024 RVA: 0x00869D90 File Offset: 0x00867F90
	private static string DGANABEEFCB(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C81 RID: 81025 RVA: 0x00869DF4 File Offset: 0x00867FF4
	private static string LGFHCJLDCED(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C82 RID: 81026 RVA: 0x00869E58 File Offset: 0x00868058
	private static string NEMOFPAPIBM(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i += 0)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C83 RID: 81027 RVA: 0x00869EBC File Offset: 0x008680BC
	private static string JEHLGJPLBEP(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 0; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 0, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x06013C84 RID: 81028 RVA: 0x00869F20 File Offset: 0x00868120
	private static string CMAIDLEJLDE(byte[] HHAGIHEGFML)
	{
		int i;
		for (i = 1; i < HHAGIHEGFML.Length; i++)
		{
			if (HHAGIHEGFML[i] != 0)
			{
				break;
			}
		}
		if (i != HHAGIHEGFML.Length)
		{
			byte[] array = new byte[HHAGIHEGFML.Length - i];
			Buffer.BlockCopy(HHAGIHEGFML, i, array, 1, HHAGIHEGFML.Length - i);
			return Encoding.UTF8.GetString(array);
		}
		return string.Empty;
	}

	// Token: 0x04002838 RID: 10296
	private static byte[] FPLKBMBAIIA = new byte[]
	{
		6,
		2,
		0,
		0,
		0,
		164,
		0,
		0,
		82,
		83,
		65,
		49,
		0,
		4,
		0,
		0,
		1,
		0,
		1,
		0,
		89,
		176,
		129,
		76,
		200,
		136,
		9,
		168,
		165,
		8,
		44,
		130,
		247,
		41,
		4,
		149,
		50,
		196,
		226,
		227,
		212,
		178,
		122,
		144,
		206,
		148,
		138,
		232,
		73,
		118,
		198,
		67,
		63,
		188,
		153,
		34,
		202,
		73,
		97,
		222,
		29,
		240,
		55,
		96,
		201,
		7,
		178,
		145,
		74,
		215,
		51,
		229,
		164,
		6,
		134,
		217,
		11,
		9,
		59,
		186,
		27,
		236,
		166,
		179,
		231,
		215,
		204,
		25,
		87,
		175,
		0,
		51,
		76,
		31,
		54,
		54,
		190,
		134,
		97,
		82,
		131,
		152,
		105,
		223,
		160,
		193,
		173,
		248,
		58,
		251,
		9,
		230,
		20,
		42,
		237,
		123,
		226,
		6,
		72,
		156,
		197,
		34,
		247,
		152,
		85,
		133,
		207,
		31,
		173,
		251,
		181,
		35,
		29,
		251,
		128,
		243,
		221,
		51,
		65,
		128,
		48,
		42,
		103,
		81,
		89,
		195,
		101,
		200
	};

	// Token: 0x04002839 RID: 10297
	private static int AEPLCNCKHJH = 128;

	// Token: 0x0400283A RID: 10298
	private static int PIAPDGPHGAP = (int)JCMGNJFOACL.FPLKBMBAIIA[16] | (int)JCMGNJFOACL.FPLKBMBAIIA[17] << 8 | (int)JCMGNJFOACL.FPLKBMBAIIA[18] << 16;

	// Token: 0x0400283B RID: 10299
	private static BigInteger KCDHDLNMHGI;
}
