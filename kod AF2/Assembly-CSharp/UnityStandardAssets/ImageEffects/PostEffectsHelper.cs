using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200032A RID: 810
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		// Token: 0x0600B9C6 RID: 47558 RVA: 0x0052BB50 File Offset: 0x00529D50
		private static void FDNFGDLAFFF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1966f;
					y2 = 1045f;
				}
				else
				{
					y = 809f;
					y2 = 619f;
				}
				float x = 815f;
				float x2 = 973f + 1582f / ((float)OLFKAHHACBC.width * 1771f);
				float y3 = 648f;
				float y4 = 1082f;
				GL.Begin(1);
				GL.TexCoord2(340f, y);
				GL.Vertex3(x, y3, 881f);
				GL.TexCoord2(314f, y);
				GL.Vertex3(x2, y3, 289f);
				GL.TexCoord2(754f, y2);
				GL.Vertex3(x2, y4, 1305f);
				GL.TexCoord2(1302f, y2);
				GL.Vertex3(x, y4, 371f);
				float x3 = 1339f - 78f / ((float)OLFKAHHACBC.width * 1780f);
				x2 = 1568f;
				y3 = 917f;
				y4 = 1983f;
				GL.TexCoord2(109f, y);
				GL.Vertex3(x3, y3, 1350f);
				GL.TexCoord2(818f, y);
				GL.Vertex3(x2, y3, 393f);
				GL.TexCoord2(1629f, y2);
				GL.Vertex3(x2, y4, 131f);
				GL.TexCoord2(632f, y2);
				GL.Vertex3(x3, y4, 1732f);
				float x4 = 648f;
				x2 = 1409f;
				y3 = 399f;
				y4 = 575f + 1350f / ((float)OLFKAHHACBC.height * 1112f);
				GL.TexCoord2(665f, y);
				GL.Vertex3(x4, y3, 185f);
				GL.TexCoord2(1648f, y);
				GL.Vertex3(x2, y3, 1860f);
				GL.TexCoord2(1612f, y2);
				GL.Vertex3(x2, y4, 1102f);
				GL.TexCoord2(796f, y2);
				GL.Vertex3(x4, y4, 920f);
				float x5 = 1752f;
				x2 = 350f;
				y3 = 607f - 1198f / ((float)OLFKAHHACBC.height * 662f);
				y4 = 1045f;
				GL.TexCoord2(390f, y);
				GL.Vertex3(x5, y3, 1439f);
				GL.TexCoord2(185f, y);
				GL.Vertex3(x2, y3, 1476f);
				GL.TexCoord2(1891f, y2);
				GL.Vertex3(x2, y4, 635f);
				GL.TexCoord2(706f, y2);
				GL.Vertex3(x5, y4, 1623f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x0052BDEC File Offset: 0x00529FEC
		private static void FBCKCOLFGLL(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 690f;
					y2 = 1518f;
				}
				else
				{
					y = 1425f;
					y2 = 762f;
				}
				float x = 1094f;
				float x2 = 1519f + 397f / ((float)OLFKAHHACBC.width * 752f);
				float y3 = 181f;
				float y4 = 606f;
				GL.Begin(0);
				GL.TexCoord2(1199f, y);
				GL.Vertex3(x, y3, 1788f);
				GL.TexCoord2(335f, y);
				GL.Vertex3(x2, y3, 1615f);
				GL.TexCoord2(1784f, y2);
				GL.Vertex3(x2, y4, 213f);
				GL.TexCoord2(1112f, y2);
				GL.Vertex3(x, y4, 1939f);
				float x3 = 1827f - 546f / ((float)OLFKAHHACBC.width * 1324f);
				x2 = 326f;
				y3 = 884f;
				y4 = 560f;
				GL.TexCoord2(1147f, y);
				GL.Vertex3(x3, y3, 1654f);
				GL.TexCoord2(837f, y);
				GL.Vertex3(x2, y3, 1906f);
				GL.TexCoord2(915f, y2);
				GL.Vertex3(x2, y4, 1497f);
				GL.TexCoord2(1062f, y2);
				GL.Vertex3(x3, y4, 849f);
				float x4 = 151f;
				x2 = 933f;
				y3 = 1678f;
				y4 = 469f + 1307f / ((float)OLFKAHHACBC.height * 1785f);
				GL.TexCoord2(118f, y);
				GL.Vertex3(x4, y3, 257f);
				GL.TexCoord2(303f, y);
				GL.Vertex3(x2, y3, 1946f);
				GL.TexCoord2(1481f, y2);
				GL.Vertex3(x2, y4, 62f);
				GL.TexCoord2(1403f, y2);
				GL.Vertex3(x4, y4, 278f);
				float x5 = 868f;
				x2 = 142f;
				y3 = 1261f - 417f / ((float)OLFKAHHACBC.height * 1469f);
				y4 = 1420f;
				GL.TexCoord2(1252f, y);
				GL.Vertex3(x5, y3, 1974f);
				GL.TexCoord2(1365f, y);
				GL.Vertex3(x2, y3, 1191f);
				GL.TexCoord2(540f, y2);
				GL.Vertex3(x2, y4, 201f);
				GL.TexCoord2(1946f, y2);
				GL.Vertex3(x5, y4, 1864f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x0052C088 File Offset: 0x0052A288
		private static void ANJDCHINMKC(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 940f;
					y2 = 849f;
				}
				else
				{
					y = 1757f;
					y2 = 374f;
				}
				float x = 1501f;
				float x2 = 1780f + 1195f / ((float)OLFKAHHACBC.width * 1428f);
				float y3 = 837f;
				float y4 = 1015f;
				GL.Begin(1);
				GL.TexCoord2(1310f, y);
				GL.Vertex3(x, y3, 1175f);
				GL.TexCoord2(1740f, y);
				GL.Vertex3(x2, y3, 726f);
				GL.TexCoord2(392f, y2);
				GL.Vertex3(x2, y4, 1040f);
				GL.TexCoord2(1527f, y2);
				GL.Vertex3(x, y4, 782f);
				float x3 = 1179f - 395f / ((float)OLFKAHHACBC.width * 1803f);
				x2 = 1047f;
				y3 = 1690f;
				y4 = 1734f;
				GL.TexCoord2(139f, y);
				GL.Vertex3(x3, y3, 1276f);
				GL.TexCoord2(1230f, y);
				GL.Vertex3(x2, y3, 11f);
				GL.TexCoord2(1107f, y2);
				GL.Vertex3(x2, y4, 1498f);
				GL.TexCoord2(289f, y2);
				GL.Vertex3(x3, y4, 264f);
				float x4 = 366f;
				x2 = 1120f;
				y3 = 1911f;
				y4 = 1418f + 1458f / ((float)OLFKAHHACBC.height * 1755f);
				GL.TexCoord2(133f, y);
				GL.Vertex3(x4, y3, 96f);
				GL.TexCoord2(49f, y);
				GL.Vertex3(x2, y3, 1463f);
				GL.TexCoord2(165f, y2);
				GL.Vertex3(x2, y4, 1375f);
				GL.TexCoord2(1445f, y2);
				GL.Vertex3(x4, y4, 1384f);
				float x5 = 1970f;
				x2 = 1927f;
				y3 = 1639f - 1767f / ((float)OLFKAHHACBC.height * 1420f);
				y4 = 508f;
				GL.TexCoord2(695f, y);
				GL.Vertex3(x5, y3, 1448f);
				GL.TexCoord2(1136f, y);
				GL.Vertex3(x2, y3, 1802f);
				GL.TexCoord2(67f, y2);
				GL.Vertex3(x2, y4, 640f);
				GL.TexCoord2(1362f, y2);
				GL.Vertex3(x5, y4, 504f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x0052C324 File Offset: 0x0052A524
		private static void IKHMNGJCPIH(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("crft_to", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 645f * 1654f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1026f / -num;
			float num5 = 261f / num;
			float num6 = 284f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 592f;
					y2 = 1641f;
				}
				else
				{
					y = 1016f;
					y2 = 382f;
				}
				GL.TexCoord2(1783f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(381f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1521f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1509f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9CA RID: 47562 RVA: 0x0052C47C File Offset: 0x0052A67C
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("OfficeSittingReadingLeanBack");
		}

		// Token: 0x0600B9CB RID: 47563 RVA: 0x0052C488 File Offset: 0x0052A688
		private static void LMKKAHKGOMA(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("IdleFight", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1936f;
					y2 = 899f;
				}
				else
				{
					y = 1885f;
					y2 = 979f;
				}
				GL.TexCoord2(343f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 987f);
				GL.TexCoord2(1041f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1350f);
				GL.TexCoord2(1147f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 1958f);
				GL.TexCoord2(1419f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 601f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9CC RID: 47564 RVA: 0x0052C560 File Offset: 0x0052A760
		private static void HBFGKCKFIPF(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("7", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1224f * 1187f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 923f / -num;
			float num5 = 1154f / num;
			float num6 = 487f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 284f;
					y2 = 1500f;
				}
				else
				{
					y = 596f;
					y2 = 301f;
				}
				GL.TexCoord2(650f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1189f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(699f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(999f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x0052C6B8 File Offset: 0x0052A8B8
		private static void FPNANFIDOGC(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("_InternalLutTex", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1891f * 1187f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1282f / -num;
			float num5 = 1217f / num;
			float num6 = 252f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 1242f;
					y2 = 416f;
				}
				else
				{
					y = 1806f;
					y2 = 144f;
				}
				GL.TexCoord2(46f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(114f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(794f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(354f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x0052C810 File Offset: 0x0052AA10
		private static void AFOEBLCLPLI(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("PER_PIXEL", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 1882f;
					y2 = 814f;
				}
				else
				{
					y = 1724f;
					y2 = 1099f;
				}
				GL.TexCoord2(199f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 1523f);
				GL.TexCoord2(1820f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1358f);
				GL.TexCoord2(767f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 1757f);
				GL.TexCoord2(51f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 1280f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x0052C8E8 File Offset: 0x0052AAE8
		private static void OHDHEENHAAF(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 541f;
					y2 = 1631f;
				}
				else
				{
					y = 996f;
					y2 = 806f;
				}
				GL.TexCoord2(424f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 1262f);
				GL.TexCoord2(71f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1577f);
				GL.TexCoord2(1309f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 1837f);
				GL.TexCoord2(1911f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 1844f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x0052C9C0 File Offset: 0x0052ABC0
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("_Phase");
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x003D2B00 File Offset: 0x003D0D00
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("LHandPunch");
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x0052C9CC File Offset: 0x0052ABCC
		private static void GLPABLNLBHK(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("UpHillWalkHandGrab", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 739f * 752f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1877f / -num;
			float num5 = 1782f / num;
			float num6 = 570f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 530f;
					y2 = 1456f;
				}
				else
				{
					y = 1385f;
					y2 = 820f;
				}
				GL.TexCoord2(1967f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(419f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1472f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(212f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x0052CB24 File Offset: 0x0052AD24
		private static void EMIHIJBJENG(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 985f;
					y2 = 919f;
				}
				else
				{
					y = 1392f;
					y2 = 324f;
				}
				float x = 208f;
				float x2 = 979f + 1536f / ((float)OLFKAHHACBC.width * 1970f);
				float y3 = 1669f;
				float y4 = 203f;
				GL.Begin(0);
				GL.TexCoord2(711f, y);
				GL.Vertex3(x, y3, 30f);
				GL.TexCoord2(1839f, y);
				GL.Vertex3(x2, y3, 76f);
				GL.TexCoord2(273f, y2);
				GL.Vertex3(x2, y4, 875f);
				GL.TexCoord2(372f, y2);
				GL.Vertex3(x, y4, 241f);
				float x3 = 1774f - 1869f / ((float)OLFKAHHACBC.width * 420f);
				x2 = 1673f;
				y3 = 220f;
				y4 = 926f;
				GL.TexCoord2(793f, y);
				GL.Vertex3(x3, y3, 1134f);
				GL.TexCoord2(796f, y);
				GL.Vertex3(x2, y3, 1581f);
				GL.TexCoord2(1216f, y2);
				GL.Vertex3(x2, y4, 264f);
				GL.TexCoord2(1427f, y2);
				GL.Vertex3(x3, y4, 277f);
				float x4 = 1211f;
				x2 = 1561f;
				y3 = 52f;
				y4 = 1596f + 660f / ((float)OLFKAHHACBC.height * 1486f);
				GL.TexCoord2(1421f, y);
				GL.Vertex3(x4, y3, 49f);
				GL.TexCoord2(225f, y);
				GL.Vertex3(x2, y3, 364f);
				GL.TexCoord2(1783f, y2);
				GL.Vertex3(x2, y4, 351f);
				GL.TexCoord2(282f, y2);
				GL.Vertex3(x4, y4, 628f);
				float x5 = 815f;
				x2 = 966f;
				y3 = 872f - 1290f / ((float)OLFKAHHACBC.height * 1979f);
				y4 = 1244f;
				GL.TexCoord2(1735f, y);
				GL.Vertex3(x5, y3, 1580f);
				GL.TexCoord2(565f, y);
				GL.Vertex3(x2, y3, 1245f);
				GL.TexCoord2(1171f, y2);
				GL.Vertex3(x2, y4, 1397f);
				GL.TexCoord2(1415f, y2);
				GL.Vertex3(x5, y4, 1844f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x0052CDC0 File Offset: 0x0052AFC0
		private static void CEDCHOKDJDM(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("UI_MapWindow_b", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1703f;
					y2 = 552f;
				}
				else
				{
					y = 218f;
					y2 = 737f;
				}
				GL.TexCoord2(1184f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 1385f);
				GL.TexCoord2(1576f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 644f);
				GL.TexCoord2(1637f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 230f);
				GL.TexCoord2(49f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 147f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x0052CE98 File Offset: 0x0052B098
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("FOG_EXP2");
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x0052CEA4 File Offset: 0x0052B0A4
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("MotorbikeBackwardSitting");
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x0052CEB0 File Offset: 0x0052B0B0
		private static void CLNKNPJGKJO(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("_MainTex", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 0.5f * 0.017453292f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1f / -num;
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x0052D008 File Offset: 0x0052B208
		private static void EMGMDBENCMF(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("kill", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 498f * 27f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1642f / -num;
			float num5 = 1597f / num;
			float num6 = 176f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 1928f;
					y2 = 1105f;
				}
				else
				{
					y = 1838f;
					y2 = 253f;
				}
				GL.TexCoord2(697f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1458f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(681f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(373f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x0052D160 File Offset: 0x0052B360
		private static void ANCNEEJEPGJ(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("RussianDance", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1235f * 1705f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 768f / -num;
			float num5 = 1247f / num;
			float num6 = 1819f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1773f;
					y2 = 767f;
				}
				else
				{
					y = 1003f;
					y2 = 1524f;
				}
				GL.TexCoord2(1447f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(767f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(731f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1592f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x0052D2B8 File Offset: 0x0052B4B8
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("_EdgeThreshold");
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x0052D2C4 File Offset: 0x0052B4C4
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("OnRenderImage in Helper called ...");
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x0052D2D0 File Offset: 0x0052B4D0
		private static void ENLFIEKFBMD(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("name", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1113f * 350f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1637f / -num;
			float num5 = 1402f / num;
			float num6 = 1936f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(4);
				float y;
				float y2;
				if (flag)
				{
					y = 1327f;
					y2 = 1821f;
				}
				else
				{
					y = 1570f;
					y2 = 242f;
				}
				GL.TexCoord2(1378f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(844f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(822f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1157f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x0052D428 File Offset: 0x0052B628
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("PoplDrop");
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x0052D434 File Offset: 0x0052B634
		private static void NNNPPBJODDO(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1020f;
					y2 = 278f;
				}
				else
				{
					y = 473f;
					y2 = 359f;
				}
				float x = 449f;
				float x2 = 1385f + 9f / ((float)OLFKAHHACBC.width * 362f);
				float y3 = 1226f;
				float y4 = 1754f;
				GL.Begin(0);
				GL.TexCoord2(664f, y);
				GL.Vertex3(x, y3, 1626f);
				GL.TexCoord2(1019f, y);
				GL.Vertex3(x2, y3, 1063f);
				GL.TexCoord2(1912f, y2);
				GL.Vertex3(x2, y4, 345f);
				GL.TexCoord2(1240f, y2);
				GL.Vertex3(x, y4, 1575f);
				float x3 = 310f - 1821f / ((float)OLFKAHHACBC.width * 340f);
				x2 = 1044f;
				y3 = 334f;
				y4 = 374f;
				GL.TexCoord2(55f, y);
				GL.Vertex3(x3, y3, 1891f);
				GL.TexCoord2(1894f, y);
				GL.Vertex3(x2, y3, 1823f);
				GL.TexCoord2(973f, y2);
				GL.Vertex3(x2, y4, 1574f);
				GL.TexCoord2(793f, y2);
				GL.Vertex3(x3, y4, 959f);
				float x4 = 857f;
				x2 = 1771f;
				y3 = 1243f;
				y4 = 1154f + 1153f / ((float)OLFKAHHACBC.height * 1467f);
				GL.TexCoord2(808f, y);
				GL.Vertex3(x4, y3, 1307f);
				GL.TexCoord2(297f, y);
				GL.Vertex3(x2, y3, 892f);
				GL.TexCoord2(276f, y2);
				GL.Vertex3(x2, y4, 1602f);
				GL.TexCoord2(781f, y2);
				GL.Vertex3(x4, y4, 1428f);
				float x5 = 1471f;
				x2 = 1087f;
				y3 = 1637f - 1903f / ((float)OLFKAHHACBC.height * 621f);
				y4 = 1858f;
				GL.TexCoord2(1332f, y);
				GL.Vertex3(x5, y3, 842f);
				GL.TexCoord2(680f, y);
				GL.Vertex3(x2, y3, 1234f);
				GL.TexCoord2(138f, y2);
				GL.Vertex3(x2, y4, 1984f);
				GL.TexCoord2(394f, y2);
				GL.Vertex3(x5, y4, 1493f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x0052D6D0 File Offset: 0x0052B8D0
		private static void PCGIGMELJKM(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 394f;
					y2 = 568f;
				}
				else
				{
					y = 1221f;
					y2 = 1888f;
				}
				float x = 712f;
				float x2 = 202f + 302f / ((float)OLFKAHHACBC.width * 737f);
				float y3 = 1089f;
				float y4 = 107f;
				GL.Begin(4);
				GL.TexCoord2(1203f, y);
				GL.Vertex3(x, y3, 1269f);
				GL.TexCoord2(1144f, y);
				GL.Vertex3(x2, y3, 1479f);
				GL.TexCoord2(1353f, y2);
				GL.Vertex3(x2, y4, 439f);
				GL.TexCoord2(180f, y2);
				GL.Vertex3(x, y4, 1559f);
				float x3 = 1767f - 55f / ((float)OLFKAHHACBC.width * 1734f);
				x2 = 449f;
				y3 = 1190f;
				y4 = 256f;
				GL.TexCoord2(1266f, y);
				GL.Vertex3(x3, y3, 1147f);
				GL.TexCoord2(1811f, y);
				GL.Vertex3(x2, y3, 586f);
				GL.TexCoord2(1540f, y2);
				GL.Vertex3(x2, y4, 1858f);
				GL.TexCoord2(1157f, y2);
				GL.Vertex3(x3, y4, 1768f);
				float x4 = 1627f;
				x2 = 480f;
				y3 = 459f;
				y4 = 1074f + 1966f / ((float)OLFKAHHACBC.height * 1820f);
				GL.TexCoord2(1109f, y);
				GL.Vertex3(x4, y3, 382f);
				GL.TexCoord2(45f, y);
				GL.Vertex3(x2, y3, 1372f);
				GL.TexCoord2(1222f, y2);
				GL.Vertex3(x2, y4, 1436f);
				GL.TexCoord2(227f, y2);
				GL.Vertex3(x4, y4, 602f);
				float x5 = 1521f;
				x2 = 792f;
				y3 = 1522f - 1628f / ((float)OLFKAHHACBC.height * 1512f);
				y4 = 1916f;
				GL.TexCoord2(193f, y);
				GL.Vertex3(x5, y3, 1316f);
				GL.TexCoord2(659f, y);
				GL.Vertex3(x2, y3, 119f);
				GL.TexCoord2(30f, y2);
				GL.Vertex3(x2, y4, 1631f);
				GL.TexCoord2(1446f, y2);
				GL.Vertex3(x5, y4, 1054f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E1 RID: 47585 RVA: 0x0052D96C File Offset: 0x0052BB6C
		private static void IGAPPMKPPKI(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 205f;
					y2 = 1946f;
				}
				else
				{
					y = 1511f;
					y2 = 142f;
				}
				float x = 1599f;
				float x2 = 1681f + 1731f / ((float)OLFKAHHACBC.width * 1987f);
				float y3 = 346f;
				float y4 = 1718f;
				GL.Begin(4);
				GL.TexCoord2(1077f, y);
				GL.Vertex3(x, y3, 1078f);
				GL.TexCoord2(864f, y);
				GL.Vertex3(x2, y3, 200f);
				GL.TexCoord2(767f, y2);
				GL.Vertex3(x2, y4, 1080f);
				GL.TexCoord2(1471f, y2);
				GL.Vertex3(x, y4, 752f);
				float x3 = 1460f - 1835f / ((float)OLFKAHHACBC.width * 1449f);
				x2 = 1386f;
				y3 = 1800f;
				y4 = 1488f;
				GL.TexCoord2(1567f, y);
				GL.Vertex3(x3, y3, 873f);
				GL.TexCoord2(784f, y);
				GL.Vertex3(x2, y3, 696f);
				GL.TexCoord2(471f, y2);
				GL.Vertex3(x2, y4, 1873f);
				GL.TexCoord2(104f, y2);
				GL.Vertex3(x3, y4, 227f);
				float x4 = 1320f;
				x2 = 490f;
				y3 = 698f;
				y4 = 986f + 1885f / ((float)OLFKAHHACBC.height * 42f);
				GL.TexCoord2(1915f, y);
				GL.Vertex3(x4, y3, 445f);
				GL.TexCoord2(1579f, y);
				GL.Vertex3(x2, y3, 139f);
				GL.TexCoord2(210f, y2);
				GL.Vertex3(x2, y4, 60f);
				GL.TexCoord2(761f, y2);
				GL.Vertex3(x4, y4, 1175f);
				float x5 = 1832f;
				x2 = 1257f;
				y3 = 1914f - 1292f / ((float)OLFKAHHACBC.height * 1477f);
				y4 = 300f;
				GL.TexCoord2(1180f, y);
				GL.Vertex3(x5, y3, 1630f);
				GL.TexCoord2(755f, y);
				GL.Vertex3(x2, y3, 559f);
				GL.TexCoord2(1710f, y2);
				GL.Vertex3(x2, y4, 654f);
				GL.TexCoord2(31f, y2);
				GL.Vertex3(x5, y4, 808f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x0052DC08 File Offset: 0x0052BE08
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("<color=\"");
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x0052DC14 File Offset: 0x0052BE14
		private static void GCDOIIGABCP(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("IdleRun", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1192f * 1758f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 531f / -num;
			float num5 = 1694f / num;
			float num6 = 487f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 508f;
					y2 = 820f;
				}
				else
				{
					y = 52f;
					y2 = 399f;
				}
				GL.TexCoord2(158f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1383f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(190f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1340f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x0052DD6C File Offset: 0x0052BF6C
		private static void GGBBDEFKJBP(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("PaperTurn.wav", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 937f * 1563f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 123f / -num;
			float num5 = 142f / num;
			float num6 = 1933f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 309f;
					y2 = 378f;
				}
				else
				{
					y = 992f;
					y2 = 1705f;
				}
				GL.TexCoord2(1728f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(685f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(598f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1129f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x0052DEC4 File Offset: 0x0052C0C4
		private static void AODMDOPCNKA(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("****softSpawn from ", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 15f * 1091f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 9f / -num;
			float num5 = 1016f / num;
			float num6 = 1168f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1192f;
					y2 = 1757f;
				}
				else
				{
					y = 639f;
					y2 = 97f;
				}
				GL.TexCoord2(367f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1076f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(659f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(224f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x0052E01C File Offset: 0x0052C21C
		private static void EIMIACJIIEK(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("Hit Point WeightCurve length is zero.", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 546f * 972f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 988f / -num;
			float num5 = 984f / num;
			float num6 = 1694f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 195f;
					y2 = 33f;
				}
				else
				{
					y = 1987f;
					y2 = 375f;
				}
				GL.TexCoord2(993f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(659f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(654f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1042f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x0052E174 File Offset: 0x0052C374
		private static void HOBEJMAJENM(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("ClimbLeft", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 407f * 347f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 413f / -num;
			float num5 = 210f / num;
			float num6 = 591f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 1575f;
					y2 = 1851f;
				}
				else
				{
					y = 15f;
					y2 = 385f;
				}
				GL.TexCoord2(199f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(698f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1658f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1653f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x0052E2CC File Offset: 0x0052C4CC
		private static void LMBMJIHCJPO(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("H:mm:ss", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1255f * 1434f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 275f / -num;
			float num5 = 447f / num;
			float num6 = 170f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 60f;
					y2 = 1843f;
				}
				else
				{
					y = 844f;
					y2 = 969f;
				}
				GL.TexCoord2(1140f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(915f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1829f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1221f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x0052E424 File Offset: 0x0052C624
		private static void MCHKLEEEDND(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture(" cname=", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1943f * 123f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 277f / -num;
			float num5 = 1182f / num;
			float num6 = 1594f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 1308f;
					y2 = 1188f;
				}
				else
				{
					y = 1959f;
					y2 = 895f;
				}
				GL.TexCoord2(1742f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(21f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1165f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1678f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x0052E57C File Offset: 0x0052C77C
		private static void ILCGMMPGKAE(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("_MainTex", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x0052E654 File Offset: 0x0052C854
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log(" гр ");
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x0052E660 File Offset: 0x0052C860
		private static void OEMENCKIGLJ(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1296f;
					y2 = 362f;
				}
				else
				{
					y = 1853f;
					y2 = 1947f;
				}
				float x = 230f;
				float x2 = 665f + 158f / ((float)OLFKAHHACBC.width * 1446f);
				float y3 = 1280f;
				float y4 = 389f;
				GL.Begin(8);
				GL.TexCoord2(1068f, y);
				GL.Vertex3(x, y3, 1772f);
				GL.TexCoord2(1974f, y);
				GL.Vertex3(x2, y3, 958f);
				GL.TexCoord2(1528f, y2);
				GL.Vertex3(x2, y4, 890f);
				GL.TexCoord2(181f, y2);
				GL.Vertex3(x, y4, 1172f);
				float x3 = 771f - 1929f / ((float)OLFKAHHACBC.width * 361f);
				x2 = 252f;
				y3 = 1862f;
				y4 = 525f;
				GL.TexCoord2(935f, y);
				GL.Vertex3(x3, y3, 1667f);
				GL.TexCoord2(332f, y);
				GL.Vertex3(x2, y3, 1805f);
				GL.TexCoord2(338f, y2);
				GL.Vertex3(x2, y4, 885f);
				GL.TexCoord2(1211f, y2);
				GL.Vertex3(x3, y4, 1738f);
				float x4 = 69f;
				x2 = 1422f;
				y3 = 740f;
				y4 = 791f + 1706f / ((float)OLFKAHHACBC.height * 795f);
				GL.TexCoord2(1595f, y);
				GL.Vertex3(x4, y3, 126f);
				GL.TexCoord2(291f, y);
				GL.Vertex3(x2, y3, 130f);
				GL.TexCoord2(203f, y2);
				GL.Vertex3(x2, y4, 1714f);
				GL.TexCoord2(1948f, y2);
				GL.Vertex3(x4, y4, 609f);
				float x5 = 1808f;
				x2 = 1422f;
				y3 = 1992f - 618f / ((float)OLFKAHHACBC.height * 1660f);
				y4 = 24f;
				GL.TexCoord2(815f, y);
				GL.Vertex3(x5, y3, 914f);
				GL.TexCoord2(935f, y);
				GL.Vertex3(x2, y3, 109f);
				GL.TexCoord2(1991f, y2);
				GL.Vertex3(x2, y4, 1421f);
				GL.TexCoord2(1295f, y2);
				GL.Vertex3(x5, y4, 998f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x0052E8FC File Offset: 0x0052CAFC
		private static void EBLGFLIINDH(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1714f;
					y2 = 607f;
				}
				else
				{
					y = 233f;
					y2 = 905f;
				}
				float x = 1889f;
				float x2 = 179f + 1955f / ((float)OLFKAHHACBC.width * 190f);
				float y3 = 1705f;
				float y4 = 1154f;
				GL.Begin(1);
				GL.TexCoord2(1920f, y);
				GL.Vertex3(x, y3, 1956f);
				GL.TexCoord2(1815f, y);
				GL.Vertex3(x2, y3, 1187f);
				GL.TexCoord2(1188f, y2);
				GL.Vertex3(x2, y4, 1598f);
				GL.TexCoord2(467f, y2);
				GL.Vertex3(x, y4, 1785f);
				float x3 = 431f - 1468f / ((float)OLFKAHHACBC.width * 1586f);
				x2 = 1342f;
				y3 = 1208f;
				y4 = 1223f;
				GL.TexCoord2(923f, y);
				GL.Vertex3(x3, y3, 683f);
				GL.TexCoord2(714f, y);
				GL.Vertex3(x2, y3, 406f);
				GL.TexCoord2(1042f, y2);
				GL.Vertex3(x2, y4, 1421f);
				GL.TexCoord2(270f, y2);
				GL.Vertex3(x3, y4, 841f);
				float x4 = 661f;
				x2 = 1388f;
				y3 = 188f;
				y4 = 687f + 847f / ((float)OLFKAHHACBC.height * 461f);
				GL.TexCoord2(428f, y);
				GL.Vertex3(x4, y3, 1243f);
				GL.TexCoord2(472f, y);
				GL.Vertex3(x2, y3, 1339f);
				GL.TexCoord2(1236f, y2);
				GL.Vertex3(x2, y4, 1010f);
				GL.TexCoord2(265f, y2);
				GL.Vertex3(x4, y4, 1520f);
				float x5 = 76f;
				x2 = 1448f;
				y3 = 1517f - 25f / ((float)OLFKAHHACBC.height * 296f);
				y4 = 1592f;
				GL.TexCoord2(587f, y);
				GL.Vertex3(x5, y3, 1482f);
				GL.TexCoord2(127f, y);
				GL.Vertex3(x2, y3, 1265f);
				GL.TexCoord2(1024f, y2);
				GL.Vertex3(x2, y4, 1681f);
				GL.TexCoord2(965f, y2);
				GL.Vertex3(x5, y4, 1495f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x0052EB98 File Offset: 0x0052CD98
		private static void DNLNCFEGFJE(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("BEREG!", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 296f * 1854f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 533f / -num;
			float num5 = 1312f / num;
			float num6 = 685f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 1329f;
					y2 = 456f;
				}
				else
				{
					y = 1430f;
					y2 = 1872f;
				}
				GL.TexCoord2(665f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(271f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(876f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(68f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x0052ECF0 File Offset: 0x0052CEF0
		private static void KOOJNCLPKHC(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("Failed downloading bundle {0} from {1}: {2}", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1958f * 981f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 143f / -num;
			float num5 = 1209f / num;
			float num6 = 1467f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1430f;
					y2 = 385f;
				}
				else
				{
					y = 1327f;
					y2 = 1070f;
				}
				GL.TexCoord2(982f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1160f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(988f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(109f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x0052EE48 File Offset: 0x0052D048
		private static void DCMPJFKOEJP(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1127f;
					y2 = 1119f;
				}
				else
				{
					y = 32f;
					y2 = 1187f;
				}
				float x = 771f;
				float x2 = 1515f + 727f / ((float)OLFKAHHACBC.width * 1082f);
				float y3 = 163f;
				float y4 = 1157f;
				GL.Begin(3);
				GL.TexCoord2(903f, y);
				GL.Vertex3(x, y3, 374f);
				GL.TexCoord2(604f, y);
				GL.Vertex3(x2, y3, 781f);
				GL.TexCoord2(616f, y2);
				GL.Vertex3(x2, y4, 42f);
				GL.TexCoord2(1841f, y2);
				GL.Vertex3(x, y4, 990f);
				float x3 = 1188f - 1373f / ((float)OLFKAHHACBC.width * 501f);
				x2 = 1491f;
				y3 = 900f;
				y4 = 672f;
				GL.TexCoord2(1523f, y);
				GL.Vertex3(x3, y3, 1327f);
				GL.TexCoord2(57f, y);
				GL.Vertex3(x2, y3, 1465f);
				GL.TexCoord2(1528f, y2);
				GL.Vertex3(x2, y4, 81f);
				GL.TexCoord2(1240f, y2);
				GL.Vertex3(x3, y4, 1416f);
				float x4 = 491f;
				x2 = 1790f;
				y3 = 1057f;
				y4 = 1517f + 1843f / ((float)OLFKAHHACBC.height * 318f);
				GL.TexCoord2(1169f, y);
				GL.Vertex3(x4, y3, 1830f);
				GL.TexCoord2(605f, y);
				GL.Vertex3(x2, y3, 744f);
				GL.TexCoord2(1440f, y2);
				GL.Vertex3(x2, y4, 1620f);
				GL.TexCoord2(172f, y2);
				GL.Vertex3(x4, y4, 661f);
				float x5 = 1339f;
				x2 = 86f;
				y3 = 1506f - 547f / ((float)OLFKAHHACBC.height * 1937f);
				y4 = 30f;
				GL.TexCoord2(1949f, y);
				GL.Vertex3(x5, y3, 1115f);
				GL.TexCoord2(625f, y);
				GL.Vertex3(x2, y3, 1627f);
				GL.TexCoord2(1131f, y2);
				GL.Vertex3(x2, y4, 515f);
				GL.TexCoord2(1247f, y2);
				GL.Vertex3(x5, y4, 187f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x0052F0E4 File Offset: 0x0052D2E4
		private static void OKOBODJKCKM(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("Hidden/Subpixel Morphological Anti-aliasing", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 1895f * 69f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 880f / -num;
			float num5 = 1638f / num;
			float num6 = 655f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 87f;
					y2 = 238f;
				}
				else
				{
					y = 602f;
					y2 = 67f;
				}
				GL.TexCoord2(1203f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1757f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1046f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(631f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x0052F23C File Offset: 0x0052D43C
		private static void EAIOEMIFLHN(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1928f;
					y2 = 1157f;
				}
				else
				{
					y = 1021f;
					y2 = 1902f;
				}
				float x = 1776f;
				float x2 = 1037f + 1968f / ((float)OLFKAHHACBC.width * 1424f);
				float y3 = 1787f;
				float y4 = 311f;
				GL.Begin(0);
				GL.TexCoord2(1143f, y);
				GL.Vertex3(x, y3, 575f);
				GL.TexCoord2(378f, y);
				GL.Vertex3(x2, y3, 1156f);
				GL.TexCoord2(511f, y2);
				GL.Vertex3(x2, y4, 539f);
				GL.TexCoord2(1709f, y2);
				GL.Vertex3(x, y4, 1975f);
				float x3 = 1409f - 1067f / ((float)OLFKAHHACBC.width * 477f);
				x2 = 443f;
				y3 = 1695f;
				y4 = 54f;
				GL.TexCoord2(1049f, y);
				GL.Vertex3(x3, y3, 630f);
				GL.TexCoord2(643f, y);
				GL.Vertex3(x2, y3, 511f);
				GL.TexCoord2(1068f, y2);
				GL.Vertex3(x2, y4, 1208f);
				GL.TexCoord2(1357f, y2);
				GL.Vertex3(x3, y4, 1489f);
				float x4 = 1548f;
				x2 = 116f;
				y3 = 871f;
				y4 = 773f + 1128f / ((float)OLFKAHHACBC.height * 1116f);
				GL.TexCoord2(334f, y);
				GL.Vertex3(x4, y3, 393f);
				GL.TexCoord2(685f, y);
				GL.Vertex3(x2, y3, 693f);
				GL.TexCoord2(61f, y2);
				GL.Vertex3(x2, y4, 174f);
				GL.TexCoord2(544f, y2);
				GL.Vertex3(x4, y4, 1207f);
				float x5 = 1433f;
				x2 = 1056f;
				y3 = 1668f - 1771f / ((float)OLFKAHHACBC.height * 845f);
				y4 = 1503f;
				GL.TexCoord2(1542f, y);
				GL.Vertex3(x5, y3, 1317f);
				GL.TexCoord2(1450f, y);
				GL.Vertex3(x2, y3, 713f);
				GL.TexCoord2(1326f, y2);
				GL.Vertex3(x2, y4, 1848f);
				GL.TexCoord2(727f, y2);
				GL.Vertex3(x5, y4, 407f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x0052F4D8 File Offset: 0x0052D6D8
		private static void FGDKJIJFKLI(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 23f;
					y2 = 676f;
				}
				else
				{
					y = 214f;
					y2 = 886f;
				}
				GL.TexCoord2(819f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 1725f);
				GL.TexCoord2(1643f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 56f);
				GL.TexCoord2(1890f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 1869f);
				GL.TexCoord2(643f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 164f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x001B4551 File Offset: 0x001B2751
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("");
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x0052F5B0 File Offset: 0x0052D7B0
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log("IceHockey Idle");
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x0052F5BC File Offset: 0x0052D7BC
		private static void CJPMDOODMNA(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 535f;
					y2 = 390f;
				}
				else
				{
					y = 1467f;
					y2 = 1826f;
				}
				float x = 289f;
				float x2 = 1663f + 709f / ((float)OLFKAHHACBC.width * 695f);
				float y3 = 885f;
				float y4 = 1550f;
				GL.Begin(2);
				GL.TexCoord2(1209f, y);
				GL.Vertex3(x, y3, 1271f);
				GL.TexCoord2(936f, y);
				GL.Vertex3(x2, y3, 1330f);
				GL.TexCoord2(787f, y2);
				GL.Vertex3(x2, y4, 1653f);
				GL.TexCoord2(670f, y2);
				GL.Vertex3(x, y4, 282f);
				float x3 = 1017f - 979f / ((float)OLFKAHHACBC.width * 1458f);
				x2 = 1354f;
				y3 = 1523f;
				y4 = 958f;
				GL.TexCoord2(166f, y);
				GL.Vertex3(x3, y3, 1073f);
				GL.TexCoord2(930f, y);
				GL.Vertex3(x2, y3, 1675f);
				GL.TexCoord2(1746f, y2);
				GL.Vertex3(x2, y4, 1061f);
				GL.TexCoord2(1410f, y2);
				GL.Vertex3(x3, y4, 90f);
				float x4 = 1239f;
				x2 = 1749f;
				y3 = 559f;
				y4 = 1272f + 926f / ((float)OLFKAHHACBC.height * 1588f);
				GL.TexCoord2(118f, y);
				GL.Vertex3(x4, y3, 1860f);
				GL.TexCoord2(260f, y);
				GL.Vertex3(x2, y3, 555f);
				GL.TexCoord2(980f, y2);
				GL.Vertex3(x2, y4, 918f);
				GL.TexCoord2(176f, y2);
				GL.Vertex3(x4, y4, 1549f);
				float x5 = 1030f;
				x2 = 1089f;
				y3 = 684f - 558f / ((float)OLFKAHHACBC.height * 1687f);
				y4 = 908f;
				GL.TexCoord2(598f, y);
				GL.Vertex3(x5, y3, 338f);
				GL.TexCoord2(1076f, y);
				GL.Vertex3(x2, y3, 1035f);
				GL.TexCoord2(1944f, y2);
				GL.Vertex3(x2, y4, 868f);
				GL.TexCoord2(123f, y2);
				GL.Vertex3(x5, y4, 589f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x0052F858 File Offset: 0x0052DA58
		private static void GLOMHEKCMPP(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("\n", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 1577f;
					y2 = 482f;
				}
				else
				{
					y = 1602f;
					y2 = 1452f;
				}
				GL.TexCoord2(414f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 1123f);
				GL.TexCoord2(1163f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1215f);
				GL.TexCoord2(858f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 595f);
				GL.TexCoord2(952f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 1547f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x0052F930 File Offset: 0x0052DB30
		private static void AMLGEFKEOKF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)OLFKAHHACBC.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				float x3 = 1f - 1f / ((float)OLFKAHHACBC.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x3, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x3, y4, 0.1f);
				float x4 = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)OLFKAHHACBC.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x4, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x4, y4, 0.1f);
				float x5 = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)OLFKAHHACBC.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x5, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x5, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x0052FBCC File Offset: 0x0052DDCC
		private static void MIJLDCGBAFM(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 888f;
					y2 = 1017f;
				}
				else
				{
					y = 1124f;
					y2 = 678f;
				}
				float x = 254f;
				float x2 = 1178f + 1260f / ((float)OLFKAHHACBC.width * 923f);
				float y3 = 1662f;
				float y4 = 1165f;
				GL.Begin(6);
				GL.TexCoord2(933f, y);
				GL.Vertex3(x, y3, 2f);
				GL.TexCoord2(689f, y);
				GL.Vertex3(x2, y3, 676f);
				GL.TexCoord2(1502f, y2);
				GL.Vertex3(x2, y4, 851f);
				GL.TexCoord2(1186f, y2);
				GL.Vertex3(x, y4, 225f);
				float x3 = 1648f - 449f / ((float)OLFKAHHACBC.width * 1016f);
				x2 = 1274f;
				y3 = 291f;
				y4 = 235f;
				GL.TexCoord2(1398f, y);
				GL.Vertex3(x3, y3, 486f);
				GL.TexCoord2(1880f, y);
				GL.Vertex3(x2, y3, 1158f);
				GL.TexCoord2(825f, y2);
				GL.Vertex3(x2, y4, 723f);
				GL.TexCoord2(1562f, y2);
				GL.Vertex3(x3, y4, 887f);
				float x4 = 1973f;
				x2 = 894f;
				y3 = 1645f;
				y4 = 609f + 1480f / ((float)OLFKAHHACBC.height * 824f);
				GL.TexCoord2(116f, y);
				GL.Vertex3(x4, y3, 1167f);
				GL.TexCoord2(75f, y);
				GL.Vertex3(x2, y3, 839f);
				GL.TexCoord2(1585f, y2);
				GL.Vertex3(x2, y4, 508f);
				GL.TexCoord2(423f, y2);
				GL.Vertex3(x4, y4, 1185f);
				float x5 = 306f;
				x2 = 1569f;
				y3 = 603f - 1347f / ((float)OLFKAHHACBC.height * 1771f);
				y4 = 1177f;
				GL.TexCoord2(959f, y);
				GL.Vertex3(x5, y3, 816f);
				GL.TexCoord2(1872f, y);
				GL.Vertex3(x2, y3, 1743f);
				GL.TexCoord2(832f, y2);
				GL.Vertex3(x2, y4, 442f);
				GL.TexCoord2(855f, y2);
				GL.Vertex3(x5, y4, 691f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x0052FE68 File Offset: 0x0052E068
		private static void PBLDODIJEDA(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("_LumTex", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 714f * 871f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 452f / -num;
			float num5 = 838f / num;
			float num6 = 197f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1687f;
					y2 = 1138f;
				}
				else
				{
					y = 1813f;
					y2 = 82f;
				}
				GL.TexCoord2(1462f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1608f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1551f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(633f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x0052FFC0 File Offset: 0x0052E1C0
		private static void OCAEGAEOLIP(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("Y (G)", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 1075f;
					y2 = 1093f;
				}
				else
				{
					y = 425f;
					y2 = 10f;
				}
				GL.TexCoord2(1937f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 508f);
				GL.TexCoord2(1355f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1302f);
				GL.TexCoord2(754f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 1250f);
				GL.TexCoord2(1524f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 909f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x00530098 File Offset: 0x0052E298
		private static void MFEICODIMMI(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("wpn_chair2", JONJODLFAEN);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 28f;
					y2 = 1794f;
				}
				else
				{
					y = 1030f;
					y2 = 893f;
				}
				GL.TexCoord2(1371f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 361f);
				GL.TexCoord2(109f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 481f);
				GL.TexCoord2(373f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 177f);
				GL.TexCoord2(1688f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 1782f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x00530170 File Offset: 0x0052E370
		private static void PHNIHNNAKFN(float LMCJCFBKIBD, float LNDEPGKLLPP, float EGDDLLHDIMA, float PNPMCNOFMMH, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("-------------- capId=", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(4);
				float y;
				float y2;
				if (flag)
				{
					y = 1294f;
					y2 = 427f;
				}
				else
				{
					y = 999f;
					y2 = 501f;
				}
				GL.TexCoord2(750f, y);
				GL.Vertex3(LMCJCFBKIBD, EGDDLLHDIMA, 5f);
				GL.TexCoord2(1356f, y);
				GL.Vertex3(LNDEPGKLLPP, EGDDLLHDIMA, 1188f);
				GL.TexCoord2(996f, y2);
				GL.Vertex3(LNDEPGKLLPP, PNPMCNOFMMH, 246f);
				GL.TexCoord2(106f, y2);
				GL.Vertex3(LMCJCFBKIBD, PNPMCNOFMMH, 198f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x00530248 File Offset: 0x0052E448
		private static void PLNEMMBPFFI(float DPIDNFHGCEP, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ, Camera NELBNCIABGD)
		{
			RenderTexture.active = OLFKAHHACBC;
			MHNAJNGGDFJ.SetTexture("fishspincatch", JONJODLFAEN);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(NELBNCIABGD.projectionMatrix);
			float f = NELBNCIABGD.fieldOfView * 794f * 1766f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = NELBNCIABGD.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1130f / -num;
			float num5 = 443f / num;
			float num6 = 1994f;
			num2 *= DPIDNFHGCEP * num6;
			num3 *= DPIDNFHGCEP * num6;
			num4 *= DPIDNFHGCEP * num6;
			num5 *= DPIDNFHGCEP * num6;
			float z = -DPIDNFHGCEP;
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 1647f;
					y2 = 761f;
				}
				else
				{
					y = 1856f;
					y2 = 773f;
				}
				GL.TexCoord2(836f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1732f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(527f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1162f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x005303A0 File Offset: 0x0052E5A0
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			Debug.Log(" shader not supported on this platform. Effect disabled.");
		}
	}
}
