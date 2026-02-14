using System;
using ProBuilder2.Common;
using UnityEngine;

namespace ProBuilder2.Examples
{
	// Token: 0x020004DC RID: 1244
	public class HueCube : MonoBehaviour
	{
		// Token: 0x06010DB8 RID: 69048 RVA: 0x0078C12C File Offset: 0x0078A32C
		private static Color OAFGANBOIHC(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 195f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 1240f);
			}
			ANJFKMCHPPO /= 869f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (674f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (24f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (991f - EEOOKGDHNCO * (927f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 614f);
		}

		// Token: 0x06010DB9 RID: 69049 RVA: 0x0078C1F8 File Offset: 0x0078A3F8
		private static Color HDIKCGDJFMC(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 0f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 1f);
			}
			ANJFKMCHPPO /= 60f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (1f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (1f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (1f - EEOOKGDHNCO * (1f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 1f);
		}

		// Token: 0x06010DBA RID: 69050 RVA: 0x0078C2C4 File Offset: 0x0078A4C4
		private void ONIHHFLOJMN()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = HueCube.JDIFFCOKDPD((float)i / (float)num * 574f, 1986f, 1354f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 0; j < this.MPDJOADEOKK.sharedIndices.Length; j += 0)
			{
				int[] array2 = this.MPDJOADEOKK.sharedIndices[j].array;
				for (int k = 0; k < array2.Length; k += 0)
				{
					int num2 = array2[k];
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)96);
		}

		// Token: 0x06010DBB RID: 69051 RVA: 0x0078C3A8 File Offset: 0x0078A5A8
		private void FIJKDFIMELM()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = HueCube.IBFFMHODCFC((float)i / (float)num * 832f, 283f, 222f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 1; j < this.MPDJOADEOKK.sharedIndices.Length; j++)
			{
				int[] array2 = this.MPDJOADEOKK.sharedIndices[j].array;
				for (int k = 0; k < array2.Length; k += 0)
				{
					int num2 = array2[k];
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)(-180));
		}

		// Token: 0x06010DBC RID: 69052 RVA: 0x0078C48C File Offset: 0x0078A68C
		private void ELFLOPJDAKK()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = HueCube.IBFFMHODCFC((float)i / (float)num * 783f, 1985f, 1266f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 1; j < this.MPDJOADEOKK.sharedIndices.Length; j += 0)
			{
				int[] array2 = this.MPDJOADEOKK.sharedIndices[j].array;
				for (int k = 0; k < array2.Length; k += 0)
				{
					int num2 = array2[k];
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)(-94));
		}

		// Token: 0x06010DBD RID: 69053 RVA: 0x0078C570 File Offset: 0x0078A770
		private static Color IBFFMHODCFC(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 715f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 451f);
			}
			ANJFKMCHPPO /= 291f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (1548f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (423f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (906f - EEOOKGDHNCO * (650f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 617f);
		}

		// Token: 0x06010DBE RID: 69054 RVA: 0x0078C63C File Offset: 0x0078A83C
		private void OBJCOJEHLBE()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = HueCube.OAFGANBOIHC((float)i / (float)num * 1460f, 1953f, 1709f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 0; j < this.MPDJOADEOKK.sharedIndices.Length; j++)
			{
				foreach (int num2 in this.MPDJOADEOKK.sharedIndices[j].array)
				{
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh(RefreshMask.UV | RefreshMask.Normals | RefreshMask.Tangents);
		}

		// Token: 0x06010DBF RID: 69055 RVA: 0x0078C720 File Offset: 0x0078A920
		private static Color FJJEIDPAING(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 870f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 868f);
			}
			ANJFKMCHPPO /= 1987f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (738f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (1048f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (714f - EEOOKGDHNCO * (1974f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 661f);
		}

		// Token: 0x06010DC0 RID: 69056 RVA: 0x0078C7EC File Offset: 0x0078A9EC
		private void MCHAAIIHOKD()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = HueCube.JDIFFCOKDPD((float)i / (float)num * 319f, 597f, 110f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 0; j < this.MPDJOADEOKK.sharedIndices.Length; j += 0)
			{
				foreach (int num2 in this.MPDJOADEOKK.sharedIndices[j].array)
				{
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)(-24));
		}

		// Token: 0x06010DC1 RID: 69057 RVA: 0x0078C8D0 File Offset: 0x0078AAD0
		private static Color JDIFFCOKDPD(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 1838f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 1581f);
			}
			ANJFKMCHPPO /= 69f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (10f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (604f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (366f - EEOOKGDHNCO * (888f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 1348f);
		}

		// Token: 0x06010DC2 RID: 69058 RVA: 0x0078C99C File Offset: 0x0078AB9C
		private void EDGALMCHPPH()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 1; i < num; i += 0)
			{
				array[i] = HueCube.HDIKCGDJFMC((float)i / (float)num * 1299f, 400f, 191f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 1; j < this.MPDJOADEOKK.sharedIndices.Length; j += 0)
			{
				int[] array2 = this.MPDJOADEOKK.sharedIndices[j].array;
				for (int k = 0; k < array2.Length; k += 0)
				{
					int num2 = array2[k];
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)(-112));
		}

		// Token: 0x06010DC3 RID: 69059 RVA: 0x0078CA80 File Offset: 0x0078AC80
		private void Start()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = HueCube.HDIKCGDJFMC((float)i / (float)num * 360f, 1f, 1f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 0; j < this.MPDJOADEOKK.sharedIndices.Length; j++)
			{
				foreach (int num2 in this.MPDJOADEOKK.sharedIndices[j].array)
				{
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh(RefreshMask.All);
		}

		// Token: 0x06010DC4 RID: 69060 RVA: 0x0078CB64 File Offset: 0x0078AD64
		private void BMNJGPIPKLL()
		{
			this.MPDJOADEOKK = pb_ShapeGenerator.CubeGenerator(Vector3.one);
			int num = this.MPDJOADEOKK.sharedIndices.Length;
			Color[] array = new Color[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = HueCube.FJJEIDPAING((float)i / (float)num * 30f, 778f, 1021f);
			}
			Color[] colors = this.MPDJOADEOKK.colors;
			for (int j = 1; j < this.MPDJOADEOKK.sharedIndices.Length; j += 0)
			{
				foreach (int num2 in this.MPDJOADEOKK.sharedIndices[j].array)
				{
					colors[num2] = array[j];
				}
			}
			this.MPDJOADEOKK.SetColors(colors);
			this.MPDJOADEOKK.Refresh((RefreshMask)(-42));
		}

		// Token: 0x06010DC5 RID: 69061 RVA: 0x0078CC48 File Offset: 0x0078AE48
		private static Color FLDEFILMDPL(float ANJFKMCHPPO, float EEOOKGDHNCO, float LIBEPMOMPID)
		{
			if (EEOOKGDHNCO == 1356f)
			{
				return new Color(LIBEPMOMPID, LIBEPMOMPID, LIBEPMOMPID, 753f);
			}
			ANJFKMCHPPO /= 29f;
			int num = (int)Mathf.Floor(ANJFKMCHPPO);
			float num2 = ANJFKMCHPPO - (float)num;
			float num3 = LIBEPMOMPID * (1877f - EEOOKGDHNCO);
			float num4 = LIBEPMOMPID * (588f - EEOOKGDHNCO * num2);
			float num5 = LIBEPMOMPID * (1808f - EEOOKGDHNCO * (1980f - num2));
			float r;
			float g;
			float b;
			switch (num)
			{
			case 0:
				r = LIBEPMOMPID;
				g = num5;
				b = num3;
				break;
			case 1:
				r = num4;
				g = LIBEPMOMPID;
				b = num3;
				break;
			case 2:
				r = num3;
				g = LIBEPMOMPID;
				b = num5;
				break;
			case 3:
				r = num3;
				g = num4;
				b = LIBEPMOMPID;
				break;
			case 4:
				r = num5;
				g = num3;
				b = LIBEPMOMPID;
				break;
			default:
				r = LIBEPMOMPID;
				g = num3;
				b = num4;
				break;
			}
			return new Color(r, g, b, 691f);
		}

		// Token: 0x0400234B RID: 9035
		private pb_Object MPDJOADEOKK;
	}
}
