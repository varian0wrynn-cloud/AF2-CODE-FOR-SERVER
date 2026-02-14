using System;
using System.Collections.Generic;
using System.Text;
using Polybrush;
using UnityEngine;

// Token: 0x020004FA RID: 1274
public class GIDLAHBNLHB
{
	// Token: 0x060110E3 RID: 69859 RVA: 0x00799E44 File Offset: 0x00798044
	public MMMKJLOPEOM DOFFNNHPHNL()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.IMBMFCCJIKJ(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.JAHDHOFBNPE();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110E4 RID: 69860 RVA: 0x00799EA6 File Offset: 0x007980A6
	private static Color32 JKHBOIMPEEP(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(216f * BDGECGGHECB.x), (byte)(1477f * BDGECGGHECB.y), (byte)(3f * BDGECGGHECB.z), (byte)(35f * BDGECGGHECB.w));
	}

	// Token: 0x060110E5 RID: 69861 RVA: 0x00799EE4 File Offset: 0x007980E4
	public void AOKIOMBDNMP(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Null)
			{
				if (channel != BFGMBMMBHCH.Tangent)
				{
					if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
					{
						if (channel == BFGMBMMBHCH.Null)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.OGCDCJHGHHK));
				}
			}
			else if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3) || channel == ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.NALJLAPDNGK(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x060110E6 RID: 69862 RVA: 0x00799FD2 File Offset: 0x007981D2
	private static Vector4 JGHLAKLNNKL(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 255f, (float)LBCGACKJCJB.g / 255f, (float)LBCGACKJCJB.b / 255f, (float)LBCGACKJCJB.a / 255f);
	}

	// Token: 0x060110E7 RID: 69863 RVA: 0x0079A010 File Offset: 0x00798210
	public MMMKJLOPEOM DOKPGGEFGNJ()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.JBFPJOEPHGL();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110E8 RID: 69864 RVA: 0x0079A072 File Offset: 0x00798272
	private static Vector4 GKAPPJJDKCI(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 1116f, (float)LBCGACKJCJB.g / 1001f, (float)LBCGACKJCJB.b / 1859f, (float)LBCGACKJCJB.a / 271f);
	}

	// Token: 0x060110E9 RID: 69865 RVA: 0x0079A0AD File Offset: 0x007982AD
	private static Color32 NFNCAJCHDII(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(1267f * BDGECGGHECB.x), (byte)(822f * BDGECGGHECB.y), (byte)(1076f * BDGECGGHECB.z), (byte)(1277f * BDGECGGHECB.w));
	}

	// Token: 0x060110EA RID: 69866 RVA: 0x0079A0E8 File Offset: 0x007982E8
	public virtual string IJBMEKGBNEK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("OneHandSwordRun");
		for (int j = 1; j < this.MPCIOCMJDNB; j += 0)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060110EB RID: 69867 RVA: 0x0079A160 File Offset: 0x00798360
	public MMMKJLOPEOM DEIFGCFBGJA()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.max;
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110EC RID: 69868 RVA: 0x0079A1C4 File Offset: 0x007983C4
	public void LDAEFIHEFFE(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("Current fog preset: ");
			return;
		}
		for (int i = 1; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x060110ED RID: 69869 RVA: 0x0079A21C File Offset: 0x0079841C
	public void GFMGCFLKOKL(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("ProjectionMatrixInverse");
			return;
		}
		for (int i = 1; i < this.MLPLAIMMFNM.Count; i += 0)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x060110EE RID: 69870 RVA: 0x0079A274 File Offset: 0x00798474
	public void ELHKGEDMMCH(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Null)
			{
				if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
				{
					if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color))
					{
						if (channel == BFGMBMMBHCH.Normal)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Color]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.IIIINJNHIJG));
				}
			}
			else if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3) || channel == ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3) || channel == ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.CMMBNBJBOHD(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x060110EF RID: 69871 RVA: 0x0079A364 File Offset: 0x00798564
	public virtual string NKFOGFFPKFN()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("Leg");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060110F0 RID: 69872 RVA: 0x0079A3DC File Offset: 0x007985DC
	public MMMKJLOPEOM OFPEKIKLJAN()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.PKALNJOLKMG();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110F1 RID: 69873 RVA: 0x0079A440 File Offset: 0x00798640
	public void HIPOHLADEHI(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("");
			return;
		}
		for (int i = 0; i < this.MLPLAIMMFNM.Count; i += 0)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x060110F2 RID: 69874 RVA: 0x0079A498 File Offset: 0x00798698
	public MMMKJLOPEOM FHNBILHHFHN()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.IMBMFCCJIKJ(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.FBHKCIEOFCP();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110F3 RID: 69875 RVA: 0x0079A4FC File Offset: 0x007986FC
	public void PLMKMFIOJAB(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("Чат очищен");
			return;
		}
		for (int i = 1; i < this.MLPLAIMMFNM.Count; i += 0)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x060110F4 RID: 69876 RVA: 0x0079A554 File Offset: 0x00798754
	public void LOJALAIJHPD(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i += 0)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CFCNPCKFDLP(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x060110F5 RID: 69877 RVA: 0x0079A5EC File Offset: 0x007987EC
	public void MLLINKABCBB(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 0; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 1U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 1U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 5U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x060110F6 RID: 69878 RVA: 0x0079A810 File Offset: 0x00798A10
	public void DCJHHGLLMOB(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("LDR");
			return;
		}
		for (int i = 1; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x060110F7 RID: 69879 RVA: 0x0079A867 File Offset: 0x00798A67
	public int FIAELBJJLLD()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x060110F8 RID: 69880 RVA: 0x0079A874 File Offset: 0x00798A74
	public GIDLAHBNLHB(LFMCCNHNKCJ PDBOLEGLMEL, z_AttributeLayout[] CCOIAOCJDGH) : this(PDBOLEGLMEL.PAOKLFNDPAE, CCOIAOCJDGH, false)
	{
		foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
		{
			BFGMBMMBHCH key = keyValuePair.Key;
			if (key <= BFGMBMMBHCH.UV0)
			{
				if (key == BFGMBMMBHCH.Color)
				{
					Color32[] pajkbjilhpe = PDBOLEGLMEL.PAJKBJILHPE;
					Vector4[][] lgaihihflap = this.LGAIHIHFLAP;
					int value = keyValuePair.Value;
					Vector4[] array;
					if (pajkbjilhpe == null || pajkbjilhpe.Length != this.MPCIOCMJDNB)
					{
						array = new Vector4[this.MPCIOCMJDNB];
					}
					else
					{
						array = Array.ConvertAll<Color32, Vector4>(pajkbjilhpe, new Converter<Color32, Vector4>(GIDLAHBNLHB.<>c.<>9.IHBGGHPBIMJ));
					}
					lgaihihflap[value] = array;
					continue;
				}
				if (key == BFGMBMMBHCH.Tangent)
				{
					Vector4[] nfkpjcgjeak = PDBOLEGLMEL.NFKPJCGJEAK;
					this.LGAIHIHFLAP[keyValuePair.Value] = ((nfkpjcgjeak != null && nfkpjcgjeak.Length == this.MPCIOCMJDNB) ? nfkpjcgjeak : new Vector4[this.MPCIOCMJDNB]);
					continue;
				}
				if (key != BFGMBMMBHCH.UV0)
				{
					continue;
				}
			}
			else if (key != BFGMBMMBHCH.UV2 && key != BFGMBMMBHCH.UV3 && key != BFGMBMMBHCH.UV4)
			{
				continue;
			}
			List<Vector4> list = PDBOLEGLMEL.EECJIOMEFCL(PPMJKGJBDCB.JJPGHNFIFOG(keyValuePair.Key));
			this.LGAIHIHFLAP[keyValuePair.Value] = ((list.Count == this.MPCIOCMJDNB) ? list.ToArray() : new Vector4[this.MPCIOCMJDNB]);
		}
	}

	// Token: 0x060110F9 RID: 69881 RVA: 0x0079A9EC File Offset: 0x00798BEC
	private static Vector4 BEDMJBDMLGP(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 10f, (float)LBCGACKJCJB.g / 1536f, (float)LBCGACKJCJB.b / 82f, (float)LBCGACKJCJB.a / 1560f);
	}

	// Token: 0x060110FA RID: 69882 RVA: 0x0079A867 File Offset: 0x00798A67
	public int CLBHIOKKIPD()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x060110FB RID: 69883 RVA: 0x0079AA28 File Offset: 0x00798C28
	public void OOEENDHBLEB(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 0; j < this.MPCIOCMJDNB; j += 0)
			{
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 4U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 6U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x060110FC RID: 69884 RVA: 0x0079AC4C File Offset: 0x00798E4C
	public MMMKJLOPEOM JHDBBICCOAN()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.IGKGHFEAOCL();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110FD RID: 69885 RVA: 0x0079ACB0 File Offset: 0x00798EB0
	public MMMKJLOPEOM HOMJBBJOIME()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.IMJIDCJEPDA();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110FE RID: 69886 RVA: 0x0079AD14 File Offset: 0x00798F14
	public MMMKJLOPEOM CHHHBGHPMLP()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.IMBMFCCJIKJ(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.NLFEFKHNBMH();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x060110FF RID: 69887 RVA: 0x0079AD78 File Offset: 0x00798F78
	public void MKNEBAOBLNI(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				if (channel != BFGMBMMBHCH.Normal)
				{
					if (channel != BFGMBMMBHCH.UV0)
					{
						if (channel == (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.UV0]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.JMOONFNEDEH));
				}
			}
			else if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == BFGMBMMBHCH.Color || channel == ~(BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.KKGPPJHFAFA(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011100 RID: 69888 RVA: 0x0079AE68 File Offset: 0x00799068
	public MMMKJLOPEOM EIJLIEKOPOM()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.max;
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011101 RID: 69889 RVA: 0x0079A867 File Offset: 0x00798A67
	public int OHADOBJKKEB()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011102 RID: 69890 RVA: 0x0079AECA File Offset: 0x007990CA
	private static Vector4 EGGJMICGDIB(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 1001f, (float)LBCGACKJCJB.g / 1504f, (float)LBCGACKJCJB.b / 1657f, (float)LBCGACKJCJB.a / 599f);
	}

	// Token: 0x06011103 RID: 69891 RVA: 0x0079AF08 File Offset: 0x00799108
	public void BGOKAIGLKPG(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 1; i < this.MPCIOCMJDNB; i += 0)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.IMBMFCCJIKJ(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011104 RID: 69892 RVA: 0x0079AFA0 File Offset: 0x007991A0
	public MMMKJLOPEOM HAPGJAGBCEN()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.HKMLNFCEHJI();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011105 RID: 69893 RVA: 0x0079B004 File Offset: 0x00799204
	public void AGAKPKNBGGC(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("Copying splat set to mis-matched container length");
			return;
		}
		for (int i = 0; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x06011106 RID: 69894 RVA: 0x0079B05C File Offset: 0x0079925C
	public MMMKJLOPEOM LMOKILLPFLE()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.HKMLNFCEHJI();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011107 RID: 69895 RVA: 0x0079B0C0 File Offset: 0x007992C0
	public void ILPMKMENNLC(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011108 RID: 69896 RVA: 0x0079B158 File Offset: 0x00799358
	public void IFMKAAMBHFO(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i += 0)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011109 RID: 69897 RVA: 0x0079B1F0 File Offset: 0x007993F0
	private static Color32 PGNHODDDLJE(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(939f * BDGECGGHECB.x), (byte)(240f * BDGECGGHECB.y), (byte)(1289f * BDGECGGHECB.z), (byte)(1029f * BDGECGGHECB.w));
	}

	// Token: 0x0601110A RID: 69898 RVA: 0x0079B22C File Offset: 0x0079942C
	public MMMKJLOPEOM KHHGEPDCNIP()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.JBFPJOEPHGL();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x0601110B RID: 69899 RVA: 0x0079B28E File Offset: 0x0079948E
	private static Color32 KHGAAFNBPAH(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(1425f * BDGECGGHECB.x), (byte)(622f * BDGECGGHECB.y), (byte)(683f * BDGECGGHECB.z), (byte)(1295f * BDGECGGHECB.w));
	}

	// Token: 0x0601110C RID: 69900 RVA: 0x0079B2CC File Offset: 0x007994CC
	public void DLFJEFJNFLK(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.IMBMFCCJIKJ(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x0601110D RID: 69901 RVA: 0x0079B364 File Offset: 0x00799564
	public virtual string NMBKBGNBAEM()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("shop_t17");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601110E RID: 69902 RVA: 0x0079B3DC File Offset: 0x007995DC
	public GIDLAHBNLHB(GIDLAHBNLHB INDANOPGHCN)
	{
		int num = INDANOPGHCN.PNJJIGMNBKH;
		this.COPLPEIMJII = new z_AttributeLayout[num];
		Array.Copy(INDANOPGHCN.COPLPEIMJII, 0, this.COPLPEIMJII, 0, num);
		this.MLPLAIMMFNM = new Dictionary<BFGMBMMBHCH, int>();
		foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in INDANOPGHCN.MLPLAIMMFNM)
		{
			this.MLPLAIMMFNM.Add(keyValuePair.Key, keyValuePair.Value);
		}
		int count = INDANOPGHCN.MLPLAIMMFNM.Count;
		this.MPCIOCMJDNB = INDANOPGHCN.MPCIOCMJDNB;
		this.LGAIHIHFLAP = new Vector4[count][];
		for (int i = 0; i < count; i++)
		{
			this.LGAIHIHFLAP[i] = new Vector4[this.MPCIOCMJDNB];
			Array.Copy(INDANOPGHCN.LGAIHIHFLAP[i], this.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x0601110F RID: 69903 RVA: 0x0079B4E0 File Offset: 0x007996E0
	public void BKAPIBKJEBO(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
				{
					if (channel != BFGMBMMBHCH.UV0)
					{
						if (channel == BFGMBMMBHCH.Null)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.JMOONFNEDEH));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.OEKLJPDEEAH(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011110 RID: 69904 RVA: 0x0079B5CE File Offset: 0x007997CE
	private static Vector4 DHKCDOBBHLP(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 605f, (float)LBCGACKJCJB.g / 1161f, (float)LBCGACKJCJB.b / 1928f, (float)LBCGACKJCJB.a / 1652f);
	}

	// Token: 0x06011111 RID: 69905 RVA: 0x0079B60C File Offset: 0x0079980C
	public void OLKHAKEPDDN(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i += 0)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.IMBMFCCJIKJ(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011112 RID: 69906 RVA: 0x0079B6A4 File Offset: 0x007998A4
	private static Vector4 KAOKAEPKEBP(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 172f, (float)LBCGACKJCJB.g / 1954f, (float)LBCGACKJCJB.b / 1074f, (float)LBCGACKJCJB.a / 266f);
	}

	// Token: 0x06011113 RID: 69907 RVA: 0x0079B6E0 File Offset: 0x007998E0
	public MMMKJLOPEOM JCJHJFHHBKA()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.PKALNJOLKMG();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011114 RID: 69908 RVA: 0x0079A867 File Offset: 0x00798A67
	public int EMHDAGEONMF()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011115 RID: 69909 RVA: 0x0079A867 File Offset: 0x00798A67
	public int PKNMNFMCBHK()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011116 RID: 69910 RVA: 0x0079B744 File Offset: 0x00799944
	public void IMLMAAAEEGF(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color))
				{
					if (channel != BFGMBMMBHCH.Tangent)
					{
						if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.UV0]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.INGHCPDBAPD));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3) || channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.GBOHAFGDMJB(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011117 RID: 69911 RVA: 0x0079B832 File Offset: 0x00799A32
	private static Color32 CONILLEOLGK(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(578f * BDGECGGHECB.x), (byte)(815f * BDGECGGHECB.y), (byte)(215f * BDGECGGHECB.z), (byte)(1099f * BDGECGGHECB.w));
	}

	// Token: 0x06011118 RID: 69912 RVA: 0x0079B86D File Offset: 0x00799A6D
	private static Vector4 MOJJGCGMMDP(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 479f, (float)LBCGACKJCJB.g / 1085f, (float)LBCGACKJCJB.b / 1268f, (float)LBCGACKJCJB.a / 446f);
	}

	// Token: 0x06011119 RID: 69913 RVA: 0x0079B8A8 File Offset: 0x00799AA8
	public virtual string AMOJFPNDMBM()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("_CurTex");
		for (int j = 1; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601111A RID: 69914 RVA: 0x0079B920 File Offset: 0x00799B20
	public void PBFAPEECECL(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 1; j < this.MPCIOCMJDNB; j += 0)
			{
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 2U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 5U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 7U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x0601111B RID: 69915 RVA: 0x0079BB44 File Offset: 0x00799D44
	public void CLGNENKALMN(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 1; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x0601111C RID: 69916 RVA: 0x0079BBDC File Offset: 0x00799DDC
	public void IHGBJJLDHLC(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("3");
			return;
		}
		for (int i = 0; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x0601111D RID: 69917 RVA: 0x0079BC33 File Offset: 0x00799E33
	private static Vector4 EBHGCIMOEGG(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 1415f, (float)LBCGACKJCJB.g / 248f, (float)LBCGACKJCJB.b / 887f, (float)LBCGACKJCJB.a / 200f);
	}

	// Token: 0x0601111E RID: 69918 RVA: 0x0079BC70 File Offset: 0x00799E70
	public void CDLIJNHKFHI(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i += 0)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x0601111F RID: 69919 RVA: 0x0079BD08 File Offset: 0x00799F08
	public MMMKJLOPEOM OEBMKMJJADB()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.EPDIAPFAFAE();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011120 RID: 69920 RVA: 0x0079BD6A File Offset: 0x00799F6A
	private static Color32 IJFAMEOMDDH(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(1000f * BDGECGGHECB.x), (byte)(878f * BDGECGGHECB.y), (byte)(926f * BDGECGGHECB.z), (byte)(1841f * BDGECGGHECB.w));
	}

	// Token: 0x06011121 RID: 69921 RVA: 0x0079BDA8 File Offset: 0x00799FA8
	public void DNMOHMBENHJ(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("isWoman");
			return;
		}
		for (int i = 1; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x06011122 RID: 69922 RVA: 0x0079BE00 File Offset: 0x0079A000
	public void PNGLBMGELFO(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 1; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 8U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x06011123 RID: 69923 RVA: 0x0079C024 File Offset: 0x0079A224
	public MMMKJLOPEOM BOAEGIIIICK()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.BBJDEAIAAOI();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011124 RID: 69924 RVA: 0x0079C088 File Offset: 0x0079A288
	public MMMKJLOPEOM JPEFDGGOHCA()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.FBHKCIEOFCP();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011125 RID: 69925 RVA: 0x0079C0EC File Offset: 0x0079A2EC
	public MMMKJLOPEOM HCAPOFEDLHB()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.min;
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011126 RID: 69926 RVA: 0x0079A867 File Offset: 0x00798A67
	public int ONDHPMOICPO()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011127 RID: 69927 RVA: 0x0079C150 File Offset: 0x0079A350
	public void LLNOFLMOMNM(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011128 RID: 69928 RVA: 0x0079C1E8 File Offset: 0x0079A3E8
	private static Color32 HPIPLAPDNKK(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(1117f * BDGECGGHECB.x), (byte)(1472f * BDGECGGHECB.y), (byte)(1733f * BDGECGGHECB.z), (byte)(534f * BDGECGGHECB.w));
	}

	// Token: 0x06011129 RID: 69929 RVA: 0x0079C224 File Offset: 0x0079A424
	public void OKACBCPKPNF(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("");
			return;
		}
		for (int i = 0; i < this.MLPLAIMMFNM.Count; i += 0)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x0601112A RID: 69930 RVA: 0x0079C27C File Offset: 0x0079A47C
	public virtual string OBJBIEJJJFN()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("_CoCTex");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601112B RID: 69931 RVA: 0x0079C2F4 File Offset: 0x0079A4F4
	public virtual string FGNNJFJLENH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("Running Dance");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0601112C RID: 69932 RVA: 0x0079C36C File Offset: 0x0079A56C
	public void GPKLHAAEEBP(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.UV0)
			{
				if (channel != BFGMBMMBHCH.Tangent)
				{
					if (channel != BFGMBMMBHCH.Normal)
					{
						if (channel == BFGMBMMBHCH.Normal)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.JMOONFNEDEH));
				}
			}
			else if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3) || channel == ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.DMIDBIEABHL(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x0601112D RID: 69933 RVA: 0x0079C45C File Offset: 0x0079A65C
	public void OLJFICJHDCM(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.CEGNEGLOMAD(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x0601112E RID: 69934 RVA: 0x0079C4F4 File Offset: 0x0079A6F4
	public void MFIAPGKJDJA(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Null)
			{
				if (channel != BFGMBMMBHCH.Tangent)
				{
					if (channel != BFGMBMMBHCH.UV0)
					{
						if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.DABEHLCOFNK));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.KKGPPJHFAFA(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x0601112F RID: 69935 RVA: 0x0079C5E4 File Offset: 0x0079A7E4
	public void ILPMKMENNLC(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 0; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 1U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 2U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 4U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 8U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x06011130 RID: 69936 RVA: 0x0079A867 File Offset: 0x00798A67
	public int OJKCKOBNICL()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011131 RID: 69937 RVA: 0x0079C808 File Offset: 0x0079AA08
	public MMMKJLOPEOM LNKDPHEFMFO()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.IMBMFCCJIKJ(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.IKLHIBGECEH();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011132 RID: 69938 RVA: 0x0079C86C File Offset: 0x0079AA6C
	public void CGCCHDHADNC(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Color)
			{
				if (channel != BFGMBMMBHCH.Color)
				{
					if (channel != BFGMBMMBHCH.Color)
					{
						if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.HLBHAPCMEDI));
				}
			}
			else if (channel == (BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.DMIDBIEABHL(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011133 RID: 69939 RVA: 0x0079C95C File Offset: 0x0079AB5C
	public void OBDOALFIIFJ(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Tangent)
			{
				if (channel != BFGMBMMBHCH.UV0)
				{
					if (channel != BFGMBMMBHCH.Normal)
					{
						if (channel == BFGMBMMBHCH.Normal)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.HKLNPMIBGIA));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2) || channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.BAKNKMBEIDG(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011134 RID: 69940 RVA: 0x0079CA4C File Offset: 0x0079AC4C
	public virtual string OOLIOFBGDKC()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("PistolInstant");
		for (int j = 1; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06011135 RID: 69941 RVA: 0x0079A867 File Offset: 0x00798A67
	public int PNJJIGMNBKH
	{
		get
		{
			return this.COPLPEIMJII.Length;
		}
	}

	// Token: 0x06011136 RID: 69942 RVA: 0x0079CAC4 File Offset: 0x0079ACC4
	public void PDKABEPIFIO(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 0; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.IMBMFCCJIKJ(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x06011137 RID: 69943 RVA: 0x0079CB5C File Offset: 0x0079AD5C
	public void DBNLDNBDKHI(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 1; j < this.MPCIOCMJDNB; j += 0)
			{
				if ((keyValuePair.Value & 1U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 6U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 4U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x06011138 RID: 69944 RVA: 0x0079CD80 File Offset: 0x0079AF80
	public MMMKJLOPEOM PHIKMKIIHOC()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.FOEEBOPFFHF();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011139 RID: 69945 RVA: 0x0079CDE4 File Offset: 0x0079AFE4
	public void OJFMBAPLCAB(GIDLAHBNLHB HFKFJPLEAGK, MMMKJLOPEOM AJFADLOIJDK, float CGFLAIMHHOO)
	{
		for (int i = 1; i < this.MPCIOCMJDNB; i++)
		{
			foreach (KeyValuePair<BFGMBMMBHCH, int> keyValuePair in this.MLPLAIMMFNM)
			{
				this.LGAIHIHFLAP[keyValuePair.Value][i] = Vector4.LerpUnclamped(HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Value][i], AJFADLOIJDK.IMBMFCCJIKJ(keyValuePair.Key), CGFLAIMHHOO);
			}
		}
	}

	// Token: 0x0601113A RID: 69946 RVA: 0x0079CE7C File Offset: 0x0079B07C
	public void OGJJFCGNPFC(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 0; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 1U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 7U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 8U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x0601113B RID: 69947 RVA: 0x0079D0A0 File Offset: 0x0079B2A0
	public void FFGPELHNHOF(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				if (channel != BFGMBMMBHCH.Color)
				{
					if (channel != BFGMBMMBHCH.Tangent)
					{
						if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.OGCDCJHGHHK));
				}
			}
			else if (channel == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Color | BFGMBMMBHCH.UV2) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.OPOLOOAEJNB(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x0601113C RID: 69948 RVA: 0x0079D190 File Offset: 0x0079B390
	public void CDGIDIEOEFK(GIDLAHBNLHB INDANOPGHCN)
	{
		if (INDANOPGHCN.MPCIOCMJDNB != this.MPCIOCMJDNB)
		{
			Debug.LogError("BC");
			return;
		}
		for (int i = 0; i < this.MLPLAIMMFNM.Count; i++)
		{
			Array.Copy(this.LGAIHIHFLAP[i], INDANOPGHCN.LGAIHIHFLAP[i], this.MPCIOCMJDNB);
		}
	}

	// Token: 0x0601113D RID: 69949 RVA: 0x0079D1E8 File Offset: 0x0079B3E8
	public MMMKJLOPEOM DLBGPIMILCM()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.PFCFAEBMDOC();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x0601113E RID: 69950 RVA: 0x0079D24C File Offset: 0x0079B44C
	public void BLMNDKFDGNC(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Null)
			{
				if (channel != BFGMBMMBHCH.UV0)
				{
					if (channel != BFGMBMMBHCH.Color)
					{
						if (channel == BFGMBMMBHCH.Normal)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Null]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.JMOONFNEDEH));
				}
			}
			else if (channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.DMIDBIEABHL(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x0601113F RID: 69951 RVA: 0x0079D33C File Offset: 0x0079B53C
	public MMMKJLOPEOM OCJHIINJCJE()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.HFDEDOKHOLM();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011140 RID: 69952 RVA: 0x0079D3A0 File Offset: 0x0079B5A0
	public MMMKJLOPEOM CCIOCEBEMHF()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.EPDIAPFAFAE();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011141 RID: 69953 RVA: 0x0079D404 File Offset: 0x0079B604
	public virtual string JKGHGFFFGEH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("DepthMaskBlendMaterial");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011142 RID: 69954 RVA: 0x0079D47C File Offset: 0x0079B67C
	public GIDLAHBNLHB(int PAOKLFNDPAE, z_AttributeLayout[] CCOIAOCJDGH, bool IAILMAANOJB = true)
	{
		this.MLPLAIMMFNM = MMMKJLOPEOM.POPFNNBNCOH(CCOIAOCJDGH);
		int count = this.MLPLAIMMFNM.Count;
		this.COPLPEIMJII = CCOIAOCJDGH;
		this.LGAIHIHFLAP = new Vector4[count][];
		this.MPCIOCMJDNB = PAOKLFNDPAE;
		if (IAILMAANOJB)
		{
			for (int i = 0; i < count; i++)
			{
				this.LGAIHIHFLAP[i] = new Vector4[PAOKLFNDPAE];
			}
		}
	}

	// Token: 0x06011143 RID: 69955 RVA: 0x0079A867 File Offset: 0x00798A67
	public int AHMFHGEAPLJ()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x06011144 RID: 69956 RVA: 0x0079D4E0 File Offset: 0x0079B6E0
	public MMMKJLOPEOM FKKCNGPAJON()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.IKLHIBGECEH();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011145 RID: 69957 RVA: 0x0079D544 File Offset: 0x0079B744
	public void CBANMDBFGDI(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.Null)
			{
				if (channel != BFGMBMMBHCH.UV0)
				{
					if (channel != BFGMBMMBHCH.Normal)
					{
						if (channel == BFGMBMMBHCH.Null)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Null]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.CFIPEHCOEFI));
				}
			}
			else if (channel == (BFGMBMMBHCH.Color | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV4) || channel == ~(BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.KKGPPJHFAFA(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011146 RID: 69958 RVA: 0x0079D634 File Offset: 0x0079B834
	public virtual string CFPMCOPINOH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("");
		for (int j = 1; j < this.MPCIOCMJDNB; j += 0)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011147 RID: 69959 RVA: 0x0079D6AC File Offset: 0x0079B8AC
	public MMMKJLOPEOM KHCEAABJFLG()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.max;
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011148 RID: 69960 RVA: 0x0079D710 File Offset: 0x0079B910
	public virtual string HDPLEBMIHFA()
	{
		StringBuilder stringBuilder = new StringBuilder();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("");
		for (int j = 1; j < this.MPCIOCMJDNB; j += 0)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011149 RID: 69961 RVA: 0x0079D788 File Offset: 0x0079B988
	public MMMKJLOPEOM PMGBPMLEAMP()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.IMJIDCJEPDA();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x0601114A RID: 69962 RVA: 0x0079D7EC File Offset: 0x0079B9EC
	public void LMNPJGKEBPA(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 1; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 8U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 3U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x0601114B RID: 69963 RVA: 0x0079DA10 File Offset: 0x0079BC10
	private static Vector4 LIJNMPODJBM(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 1553f, (float)LBCGACKJCJB.g / 746f, (float)LBCGACKJCJB.b / 996f, (float)LBCGACKJCJB.a / 213f);
	}

	// Token: 0x0601114C RID: 69964 RVA: 0x0079A867 File Offset: 0x00798A67
	public int FEICIMKGMFN()
	{
		return this.COPLPEIMJII.Length;
	}

	// Token: 0x0601114D RID: 69965 RVA: 0x0079DA4B File Offset: 0x0079BC4B
	private static Color32 JDJOMMKEHHC(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(255f * BDGECGGHECB.x), (byte)(255f * BDGECGGHECB.y), (byte)(255f * BDGECGGHECB.z), (byte)(255f * BDGECGGHECB.w));
	}

	// Token: 0x0601114E RID: 69966 RVA: 0x0079DA88 File Offset: 0x0079BC88
	public void DONBHEMMIDC(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color))
			{
				if (channel != BFGMBMMBHCH.UV0)
				{
					if (channel != (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
					{
						if (channel == (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent))
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.UV0]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.CFIPEHCOEFI));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0) || channel == BFGMBMMBHCH.UV4 || channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.EFJCNHBEENO(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x0601114F RID: 69967 RVA: 0x0079DB76 File Offset: 0x0079BD76
	private static Vector4 LLKLBGLINIM(Color32 LBCGACKJCJB)
	{
		return new Vector4((float)LBCGACKJCJB.r / 225f, (float)LBCGACKJCJB.g / 590f, (float)LBCGACKJCJB.b / 753f, (float)LBCGACKJCJB.a / 1836f);
	}

	// Token: 0x06011150 RID: 69968 RVA: 0x0079DBB4 File Offset: 0x0079BDB4
	public MMMKJLOPEOM EKPFMDEHOBF()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.JAHDHOFBNPE();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011151 RID: 69969 RVA: 0x0079DC18 File Offset: 0x0079BE18
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine("--");
		for (int j = 0; j < this.MPCIOCMJDNB; j++)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011152 RID: 69970 RVA: 0x0079DC90 File Offset: 0x0079BE90
	public void LLLHCPHOMBM(GIDLAHBNLHB HFKFJPLEAGK, GIDLAHBNLHB AJFADLOIJDK, int CBFFOOKAIAK, float[] CGFLAIMHHOO)
	{
		Dictionary<int, uint> dictionary = new Dictionary<int, uint>();
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			int num = this.MLPLAIMMFNM[z_AttributeLayout.channel];
			if (z_AttributeLayout.mask == CBFFOOKAIAK)
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary.Add(num, z_AttributeLayout.index.MPPGKILCJEB());
				}
				else
				{
					Dictionary<int, uint> dictionary2 = dictionary;
					int key = num;
					dictionary2[key] |= z_AttributeLayout.index.MPPGKILCJEB();
				}
			}
		}
		foreach (KeyValuePair<int, uint> keyValuePair in dictionary)
		{
			Vector4[] array = HFKFJPLEAGK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array2 = AJFADLOIJDK.LGAIHIHFLAP[keyValuePair.Key];
			Vector4[] array3 = this.LGAIHIHFLAP[keyValuePair.Key];
			for (int j = 0; j < this.MPCIOCMJDNB; j++)
			{
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].x = Mathf.Lerp(array[j].x, array2[j].x, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 5U) != 0U)
				{
					array3[j].y = Mathf.Lerp(array[j].y, array2[j].y, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 2U) != 0U)
				{
					array3[j].z = Mathf.Lerp(array[j].z, array2[j].z, CGFLAIMHHOO[j]);
				}
				if ((keyValuePair.Value & 0U) != 0U)
				{
					array3[j].w = Mathf.Lerp(array[j].w, array2[j].w, CGFLAIMHHOO[j]);
				}
			}
		}
	}

	// Token: 0x06011153 RID: 69971 RVA: 0x0079DEB4 File Offset: 0x0079C0B4
	private static Color32 MCFFHKMDNJG(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(718f * BDGECGGHECB.x), (byte)(491f * BDGECGGHECB.y), (byte)(842f * BDGECGGHECB.z), (byte)(1775f * BDGECGGHECB.w));
	}

	// Token: 0x06011154 RID: 69972 RVA: 0x0079DEF0 File Offset: 0x0079C0F0
	public void DCLNJPIBFIA(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 0;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= BFGMBMMBHCH.UV0)
			{
				if (channel != BFGMBMMBHCH.Color)
				{
					if (channel != BFGMBMMBHCH.Tangent)
					{
						if (channel == BFGMBMMBHCH.UV0)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Tangent]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.JBHNCACLKEA));
				}
			}
			else if (channel == BFGMBMMBHCH.UV2 || channel == BFGMBMMBHCH.UV3 || channel == BFGMBMMBHCH.UV4)
			{
				goto IL_43;
			}
			IL_D4:
			i++;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.OEKLJPDEEAH(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011155 RID: 69973 RVA: 0x0079DFE0 File Offset: 0x0079C1E0
	public MMMKJLOPEOM DBAPBDJLLJB()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.CEDBKMDCAIN();
			mmmkjlopeom.IIDFAJKECGJ(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x06011156 RID: 69974 RVA: 0x0079E042 File Offset: 0x0079C242
	private static Color32 HGKPFEFGHIL(Vector4 BDGECGGHECB)
	{
		return new Color32((byte)(1433f * BDGECGGHECB.x), (byte)(1624f * BDGECGGHECB.y), (byte)(313f * BDGECGGHECB.z), (byte)(1856f * BDGECGGHECB.w));
	}

	// Token: 0x06011157 RID: 69975 RVA: 0x0079E080 File Offset: 0x0079C280
	public virtual string DFHAGGBIEIH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (z_AttributeLayout z_AttributeLayout in this.COPLPEIMJII)
		{
			stringBuilder.AppendLine(z_AttributeLayout.ToString());
		}
		stringBuilder.AppendLine(": ");
		for (int j = 0; j < this.MPCIOCMJDNB; j += 0)
		{
			stringBuilder.AppendLine(this.LGAIHIHFLAP[j].ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011158 RID: 69976 RVA: 0x0079E0F8 File Offset: 0x0079C2F8
	public void GICGCANLCEI(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		int i = 1;
		while (i < coplpeimjii.Length)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			BFGMBMMBHCH channel = z_AttributeLayout.channel;
			if (channel <= (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
			{
				if (channel != BFGMBMMBHCH.UV0)
				{
					if (channel != (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent))
					{
						if (channel == BFGMBMMBHCH.Tangent)
						{
							goto IL_43;
						}
					}
					else
					{
						PDBOLEGLMEL.NFKPJCGJEAK = this.LGAIHIHFLAP[this.MLPLAIMMFNM[BFGMBMMBHCH.Normal]];
					}
				}
				else
				{
					PDBOLEGLMEL.PAJKBJILHPE = Array.ConvertAll<Vector4, Color32>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]], new Converter<Vector4, Color32>(GIDLAHBNLHB.<>c.<>9.CFCMFGKGOHG));
				}
			}
			else if (channel == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4) || channel == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2))
			{
				goto IL_43;
			}
			IL_D4:
			i += 0;
			continue;
			IL_43:
			List<Vector4> ojneefiniee = new List<Vector4>(this.LGAIHIHFLAP[this.MLPLAIMMFNM[z_AttributeLayout.channel]]);
			PDBOLEGLMEL.GBOHAFGDMJB(PPMJKGJBDCB.JJPGHNFIFOG(z_AttributeLayout.channel), ojneefiniee);
			goto IL_D4;
		}
	}

	// Token: 0x06011159 RID: 69977 RVA: 0x0079E1E8 File Offset: 0x0079C3E8
	public MMMKJLOPEOM DIHGBMJNOCE()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 1; i < coplpeimjii.Length; i++)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CFCNPCKFDLP(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.FOEEBOPFFHF();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x0601115A RID: 69978 RVA: 0x0079E24C File Offset: 0x0079C44C
	public MMMKJLOPEOM EBLMJOKMCMD()
	{
		MMMKJLOPEOM mmmkjlopeom = new MMMKJLOPEOM(this.MLPLAIMMFNM);
		z_AttributeLayout[] coplpeimjii = this.COPLPEIMJII;
		for (int i = 0; i < coplpeimjii.Length; i += 0)
		{
			z_AttributeLayout z_AttributeLayout = coplpeimjii[i];
			Vector4 dccpcblodig = mmmkjlopeom.CEGNEGLOMAD(z_AttributeLayout.channel);
			dccpcblodig[(int)z_AttributeLayout.index] = z_AttributeLayout.EPDIAPFAFAE();
			mmmkjlopeom.IJHLMJKOJMH(z_AttributeLayout.channel, dccpcblodig);
		}
		return mmmkjlopeom;
	}

	// Token: 0x040023C0 RID: 9152
	private const float IBDCPKLBEGL = 0.0001f;

	// Token: 0x040023C1 RID: 9153
	private int MPCIOCMJDNB;

	// Token: 0x040023C2 RID: 9154
	private Dictionary<BFGMBMMBHCH, int> MLPLAIMMFNM;

	// Token: 0x040023C3 RID: 9155
	private Vector4[][] LGAIHIHFLAP;

	// Token: 0x040023C4 RID: 9156
	public z_AttributeLayout[] COPLPEIMJII;
}
