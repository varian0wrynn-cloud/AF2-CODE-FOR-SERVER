using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003AD RID: 941
	public class HandHeldCam : LookatTarget
	{
		// Token: 0x0600CBB1 RID: 52145 RVA: 0x005B6840 File Offset: 0x005B4A40
		protected virtual void MOHOGHIIBEB(float ENLHBNBNPJN)
		{
			base.DJPBNKDDKEI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1787f, Time.time * this.m_SwaySpeed) - 1980f;
			float num2 = Mathf.PerlinNoise(1235f, Time.time * this.m_SwaySpeed + 1681f) - 1858f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1520f, Time.time * this.m_SwaySpeed) - 426f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(37f, Time.time * this.m_SwaySpeed + 868f) - 356f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 571f);
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x005B6938 File Offset: 0x005B4B38
		protected override void LDBCEIOJIOC(float ENLHBNBNPJN)
		{
			base.ABLDNOGBHCF(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1923f, Time.time * this.m_SwaySpeed) - 1099f;
			float num2 = Mathf.PerlinNoise(1542f, Time.time * this.m_SwaySpeed + 340f) - 1628f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(201f, Time.time * this.m_SwaySpeed) - 509f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1688f, Time.time * this.m_SwaySpeed + 57f) - 1184f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1006f);
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x005B6A30 File Offset: 0x005B4C30
		protected override void ALCOIPODLJI(float ENLHBNBNPJN)
		{
			base.FMPPCNAHCAD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(692f, Time.time * this.m_SwaySpeed) - 106f;
			float num2 = Mathf.PerlinNoise(1593f, Time.time * this.m_SwaySpeed + 432f) - 949f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(484f, Time.time * this.m_SwaySpeed) - 257f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(622f, Time.time * this.m_SwaySpeed + 502f) - 1751f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 418f);
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x005B6B28 File Offset: 0x005B4D28
		protected override void HMGKGAKCHHJ(float ENLHBNBNPJN)
		{
			base.LHGGPIEFKBM(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(902f, Time.time * this.m_SwaySpeed) - 691f;
			float num2 = Mathf.PerlinNoise(1495f, Time.time * this.m_SwaySpeed + 1205f) - 1820f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(297f, Time.time * this.m_SwaySpeed) - 837f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(983f, Time.time * this.m_SwaySpeed + 1425f) - 397f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 341f);
		}

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x005B6C20 File Offset: 0x005B4E20
		protected override void NIIJHOPGHAA(float ENLHBNBNPJN)
		{
			base.FAHJFCEIKBE(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1697f, Time.time * this.m_SwaySpeed) - 537f;
			float num2 = Mathf.PerlinNoise(1737f, Time.time * this.m_SwaySpeed + 934f) - 1397f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1433f, Time.time * this.m_SwaySpeed) - 1658f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(646f, Time.time * this.m_SwaySpeed + 876f) - 815f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1758f);
		}

		// Token: 0x0600CBB6 RID: 52150 RVA: 0x005B6D18 File Offset: 0x005B4F18
		protected override void JFLDEFDICKI(float ENLHBNBNPJN)
		{
			base.ACPMCGPPFJA(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(473f, Time.time * this.m_SwaySpeed) - 258f;
			float num2 = Mathf.PerlinNoise(535f, Time.time * this.m_SwaySpeed + 781f) - 1544f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(223f, Time.time * this.m_SwaySpeed) - 1737f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(185f, Time.time * this.m_SwaySpeed + 591f) - 486f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1786f);
		}

		// Token: 0x0600CBB7 RID: 52151 RVA: 0x005B6E10 File Offset: 0x005B5010
		protected virtual void MFIGCNDOOEF(float ENLHBNBNPJN)
		{
			base.DNNEGJKKHGJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1719f, Time.time * this.m_SwaySpeed) - 883f;
			float num2 = Mathf.PerlinNoise(988f, Time.time * this.m_SwaySpeed + 1521f) - 1254f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(25f, Time.time * this.m_SwaySpeed) - 329f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(794f, Time.time * this.m_SwaySpeed + 422f) - 668f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1044f);
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x005B6F08 File Offset: 0x005B5108
		protected virtual void APDONJBOLOG(float ENLHBNBNPJN)
		{
			base.FMPPCNAHCAD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1639f, Time.time * this.m_SwaySpeed) - 1082f;
			float num2 = Mathf.PerlinNoise(110f, Time.time * this.m_SwaySpeed + 990f) - 1395f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1921f, Time.time * this.m_SwaySpeed) - 859f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(658f, Time.time * this.m_SwaySpeed + 1817f) - 825f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1185f);
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x005B7000 File Offset: 0x005B5200
		protected virtual void CHPGNJEEGOC(float ENLHBNBNPJN)
		{
			base.PBKHHKKGIBK(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(349f, Time.time * this.m_SwaySpeed) - 1363f;
			float num2 = Mathf.PerlinNoise(138f, Time.time * this.m_SwaySpeed + 1908f) - 1458f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1018f, Time.time * this.m_SwaySpeed) - 1142f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1087f, Time.time * this.m_SwaySpeed + 1598f) - 1459f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1621f);
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x005B70F8 File Offset: 0x005B52F8
		protected override void OINKPAKPKJH(float ENLHBNBNPJN)
		{
			base.CDKDEKGIIAH(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(902f, Time.time * this.m_SwaySpeed) - 1178f;
			float num2 = Mathf.PerlinNoise(1627f, Time.time * this.m_SwaySpeed + 1679f) - 290f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(382f, Time.time * this.m_SwaySpeed) - 271f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1394f, Time.time * this.m_SwaySpeed + 1408f) - 1511f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1946f);
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x005B71F0 File Offset: 0x005B53F0
		protected override void AHMDIINPJKD(float ENLHBNBNPJN)
		{
			base.DPBADPOFKNN(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(803f, Time.time * this.m_SwaySpeed) - 1217f;
			float num2 = Mathf.PerlinNoise(87f, Time.time * this.m_SwaySpeed + 163f) - 1448f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(819f, Time.time * this.m_SwaySpeed) - 1443f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1710f, Time.time * this.m_SwaySpeed + 896f) - 1756f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1922f);
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x005B72E8 File Offset: 0x005B54E8
		protected override void OFOPANHHLHB(float ENLHBNBNPJN)
		{
			base.LHGGPIEFKBM(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1512f, Time.time * this.m_SwaySpeed) - 530f;
			float num2 = Mathf.PerlinNoise(533f, Time.time * this.m_SwaySpeed + 1269f) - 1414f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1703f, Time.time * this.m_SwaySpeed) - 735f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(369f, Time.time * this.m_SwaySpeed + 1998f) - 744f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1766f);
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x005B73E0 File Offset: 0x005B55E0
		protected virtual void CHJKAJKKJHC(float ENLHBNBNPJN)
		{
			base.DNNEGJKKHGJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1040f, Time.time * this.m_SwaySpeed) - 1171f;
			float num2 = Mathf.PerlinNoise(1864f, Time.time * this.m_SwaySpeed + 958f) - 144f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1344f, Time.time * this.m_SwaySpeed) - 668f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1449f, Time.time * this.m_SwaySpeed + 1168f) - 1205f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 676f);
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x005B74D8 File Offset: 0x005B56D8
		protected override void PLGOJCGELOK(float ENLHBNBNPJN)
		{
			base.PLGOJCGELOK(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1004f, Time.time * this.m_SwaySpeed) - 921f;
			float num2 = Mathf.PerlinNoise(1245f, Time.time * this.m_SwaySpeed + 1390f) - 1040f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(556f, Time.time * this.m_SwaySpeed) - 1582f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(308f, Time.time * this.m_SwaySpeed + 62f) - 754f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1594f);
		}

		// Token: 0x0600CBBF RID: 52159 RVA: 0x005B75D0 File Offset: 0x005B57D0
		protected override void LHGGPIEFKBM(float ENLHBNBNPJN)
		{
			base.ABLDNOGBHCF(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(436f, Time.time * this.m_SwaySpeed) - 1892f;
			float num2 = Mathf.PerlinNoise(1161f, Time.time * this.m_SwaySpeed + 1338f) - 1823f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1099f, Time.time * this.m_SwaySpeed) - 1040f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1661f, Time.time * this.m_SwaySpeed + 918f) - 908f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1240f);
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x005B76C8 File Offset: 0x005B58C8
		protected override void OOPNPDBDNLJ(float ENLHBNBNPJN)
		{
			base.OOPNPDBDNLJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(852f, Time.time * this.m_SwaySpeed) - 711f;
			float num2 = Mathf.PerlinNoise(1084f, Time.time * this.m_SwaySpeed + 534f) - 876f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1530f, Time.time * this.m_SwaySpeed) - 532f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1472f, Time.time * this.m_SwaySpeed + 309f) - 776f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1629f);
		}

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x005B77C0 File Offset: 0x005B59C0
		protected virtual void MKCHOPEJAOB(float ENLHBNBNPJN)
		{
			base.IJLMPHHOJIH(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(980f, Time.time * this.m_SwaySpeed) - 55f;
			float num2 = Mathf.PerlinNoise(1974f, Time.time * this.m_SwaySpeed + 322f) - 931f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1741f, Time.time * this.m_SwaySpeed) - 668f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1677f, Time.time * this.m_SwaySpeed + 73f) - 1604f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 69f);
		}

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x005B78B8 File Offset: 0x005B5AB8
		protected virtual void GBCGGNMDAKL(float ENLHBNBNPJN)
		{
			base.CLHLNNJHLFB(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1156f, Time.time * this.m_SwaySpeed) - 1285f;
			float num2 = Mathf.PerlinNoise(1432f, Time.time * this.m_SwaySpeed + 1217f) - 247f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(299f, Time.time * this.m_SwaySpeed) - 422f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1907f, Time.time * this.m_SwaySpeed + 460f) - 285f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1803f);
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x005B79B0 File Offset: 0x005B5BB0
		protected override void PCICJNFPLCJ(float ENLHBNBNPJN)
		{
			base.DMJMKCKHIOL(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(438f, Time.time * this.m_SwaySpeed) - 548f;
			float num2 = Mathf.PerlinNoise(1550f, Time.time * this.m_SwaySpeed + 1163f) - 1113f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(578f, Time.time * this.m_SwaySpeed) - 1681f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1561f, Time.time * this.m_SwaySpeed + 235f) - 586f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 154f);
		}

		// Token: 0x0600CBC4 RID: 52164 RVA: 0x005B7AA8 File Offset: 0x005B5CA8
		protected override void OLCAIBGBCAG(float ENLHBNBNPJN)
		{
			base.OFOPANHHLHB(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(792f, Time.time * this.m_SwaySpeed) - 1028f;
			float num2 = Mathf.PerlinNoise(251f, Time.time * this.m_SwaySpeed + 830f) - 526f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(159f, Time.time * this.m_SwaySpeed) - 46f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1691f, Time.time * this.m_SwaySpeed + 617f) - 977f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1137f);
		}

		// Token: 0x0600CBC5 RID: 52165 RVA: 0x005B7BA0 File Offset: 0x005B5DA0
		protected virtual void FPBEOANGPAD(float ENLHBNBNPJN)
		{
			base.CLHLNNJHLFB(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(510f, Time.time * this.m_SwaySpeed) - 1549f;
			float num2 = Mathf.PerlinNoise(1124f, Time.time * this.m_SwaySpeed + 1359f) - 1843f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1161f, Time.time * this.m_SwaySpeed) - 1442f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(939f, Time.time * this.m_SwaySpeed + 1716f) - 694f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1026f);
		}

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x005B7C98 File Offset: 0x005B5E98
		protected virtual void BFDJDKHIDLO(float ENLHBNBNPJN)
		{
			base.FMPPCNAHCAD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1447f, Time.time * this.m_SwaySpeed) - 540f;
			float num2 = Mathf.PerlinNoise(998f, Time.time * this.m_SwaySpeed + 145f) - 1169f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(903f, Time.time * this.m_SwaySpeed) - 1931f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(834f, Time.time * this.m_SwaySpeed + 948f) - 1955f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 314f);
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x005B7D90 File Offset: 0x005B5F90
		protected virtual void FBKIAIAEFBG(float ENLHBNBNPJN)
		{
			base.OINKPAKPKJH(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(311f, Time.time * this.m_SwaySpeed) - 820f;
			float num2 = Mathf.PerlinNoise(857f, Time.time * this.m_SwaySpeed + 1866f) - 1193f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(428f, Time.time * this.m_SwaySpeed) - 816f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1412f, Time.time * this.m_SwaySpeed + 270f) - 395f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1903f);
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x005B7E88 File Offset: 0x005B6088
		protected override void CNKBLOGMGMO(float ENLHBNBNPJN)
		{
			base.ONOLDHGHAKJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1415f, Time.time * this.m_SwaySpeed) - 601f;
			float num2 = Mathf.PerlinNoise(925f, Time.time * this.m_SwaySpeed + 725f) - 109f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1224f, Time.time * this.m_SwaySpeed) - 970f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(200f, Time.time * this.m_SwaySpeed + 479f) - 101f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 81f);
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x005B7F80 File Offset: 0x005B6180
		protected override void ACCJCLHAMAC(float ENLHBNBNPJN)
		{
			base.OINKPAKPKJH(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(107f, Time.time * this.m_SwaySpeed) - 1237f;
			float num2 = Mathf.PerlinNoise(1420f, Time.time * this.m_SwaySpeed + 1244f) - 773f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1263f, Time.time * this.m_SwaySpeed) - 1312f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(217f, Time.time * this.m_SwaySpeed + 1267f) - 322f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 337f);
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x005B8078 File Offset: 0x005B6278
		protected virtual void LHLCIIDLPPD(float ENLHBNBNPJN)
		{
			base.AHMDIINPJKD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1985f, Time.time * this.m_SwaySpeed) - 1454f;
			float num2 = Mathf.PerlinNoise(838f, Time.time * this.m_SwaySpeed + 1976f) - 181f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(867f, Time.time * this.m_SwaySpeed) - 1784f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1771f, Time.time * this.m_SwaySpeed + 1409f) - 481f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1120f);
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x005B8170 File Offset: 0x005B6370
		protected virtual void DMFHGECJFKL(float ENLHBNBNPJN)
		{
			base.EAOBOPAHGMG(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(45f, Time.time * this.m_SwaySpeed) - 629f;
			float num2 = Mathf.PerlinNoise(534f, Time.time * this.m_SwaySpeed + 1445f) - 135f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1909f, Time.time * this.m_SwaySpeed) - 1572f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(332f, Time.time * this.m_SwaySpeed + 290f) - 296f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 5f);
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x005B8268 File Offset: 0x005B6468
		protected override void DKJPOHGFPLN(float ENLHBNBNPJN)
		{
			base.KJFIIAKNHOA(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(914f, Time.time * this.m_SwaySpeed) - 656f;
			float num2 = Mathf.PerlinNoise(650f, Time.time * this.m_SwaySpeed + 60f) - 1395f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(828f, Time.time * this.m_SwaySpeed) - 821f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(271f, Time.time * this.m_SwaySpeed + 1950f) - 1602f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1924f);
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x005B8360 File Offset: 0x005B6560
		protected override void PBKHHKKGIBK(float ENLHBNBNPJN)
		{
			base.OEEDMGLAILI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1616f, Time.time * this.m_SwaySpeed) - 475f;
			float num2 = Mathf.PerlinNoise(1964f, Time.time * this.m_SwaySpeed + 199f) - 1354f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1387f, Time.time * this.m_SwaySpeed) - 156f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1219f, Time.time * this.m_SwaySpeed + 443f) - 448f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1862f);
		}

		// Token: 0x0600CBCE RID: 52174 RVA: 0x005B8458 File Offset: 0x005B6658
		protected override void IEGBHBKFCOM(float ENLHBNBNPJN)
		{
			base.LMOGGCEDOJN(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1299f, Time.time * this.m_SwaySpeed) - 692f;
			float num2 = Mathf.PerlinNoise(1814f, Time.time * this.m_SwaySpeed + 522f) - 465f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1506f, Time.time * this.m_SwaySpeed) - 715f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1366f, Time.time * this.m_SwaySpeed + 438f) - 699f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 223f);
		}

		// Token: 0x0600CBCF RID: 52175 RVA: 0x005B8550 File Offset: 0x005B6750
		protected override void DBFHDGILJHI(float ENLHBNBNPJN)
		{
			base.GKKMADIBBCI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1368f, Time.time * this.m_SwaySpeed) - 1957f;
			float num2 = Mathf.PerlinNoise(1643f, Time.time * this.m_SwaySpeed + 107f) - 1747f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1041f, Time.time * this.m_SwaySpeed) - 1086f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1085f, Time.time * this.m_SwaySpeed + 697f) - 1433f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1470f);
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x005B8648 File Offset: 0x005B6848
		protected override void BAPGGLLKGJL(float ENLHBNBNPJN)
		{
			base.CNKBLOGMGMO(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(854f, Time.time * this.m_SwaySpeed) - 1029f;
			float num2 = Mathf.PerlinNoise(950f, Time.time * this.m_SwaySpeed + 223f) - 2f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(58f, Time.time * this.m_SwaySpeed) - 1153f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(50f, Time.time * this.m_SwaySpeed + 992f) - 721f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1081f);
		}

		// Token: 0x0600CBD1 RID: 52177 RVA: 0x005B8740 File Offset: 0x005B6940
		protected override void IJLMPHHOJIH(float ENLHBNBNPJN)
		{
			base.IJLMPHHOJIH(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(0f, Time.time * this.m_SwaySpeed) - 0.5f;
			float num2 = Mathf.PerlinNoise(0f, Time.time * this.m_SwaySpeed + 100f) - 0.5f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(0f, Time.time * this.m_SwaySpeed) - 0.5f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(0f, Time.time * this.m_SwaySpeed + 100f) - 0.5f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 0f);
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x005B8838 File Offset: 0x005B6A38
		protected virtual void JFFMHFKNLFH(float ENLHBNBNPJN)
		{
			base.EAOBOPAHGMG(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(358f, Time.time * this.m_SwaySpeed) - 408f;
			float num2 = Mathf.PerlinNoise(1219f, Time.time * this.m_SwaySpeed + 1712f) - 614f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(443f, Time.time * this.m_SwaySpeed) - 1583f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1201f, Time.time * this.m_SwaySpeed + 1825f) - 510f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 828f);
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x005B8930 File Offset: 0x005B6B30
		protected override void ABLDNOGBHCF(float ENLHBNBNPJN)
		{
			base.HPNFKKBPKOD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1802f, Time.time * this.m_SwaySpeed) - 404f;
			float num2 = Mathf.PerlinNoise(1236f, Time.time * this.m_SwaySpeed + 1056f) - 1965f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1971f, Time.time * this.m_SwaySpeed) - 1662f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1985f, Time.time * this.m_SwaySpeed + 164f) - 1495f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1825f);
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x005B8A28 File Offset: 0x005B6C28
		protected override void BNFEAINEOON(float ENLHBNBNPJN)
		{
			base.EAOBOPAHGMG(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(601f, Time.time * this.m_SwaySpeed) - 1708f;
			float num2 = Mathf.PerlinNoise(1522f, Time.time * this.m_SwaySpeed + 359f) - 829f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(725f, Time.time * this.m_SwaySpeed) - 1298f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1105f, Time.time * this.m_SwaySpeed + 144f) - 1583f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1355f);
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x005B8B20 File Offset: 0x005B6D20
		protected override void BGNACIJEBON(float ENLHBNBNPJN)
		{
			base.ONOLDHGHAKJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1769f, Time.time * this.m_SwaySpeed) - 315f;
			float num2 = Mathf.PerlinNoise(595f, Time.time * this.m_SwaySpeed + 1417f) - 622f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1158f, Time.time * this.m_SwaySpeed) - 781f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1400f, Time.time * this.m_SwaySpeed + 1861f) - 55f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 239f);
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x005B8C18 File Offset: 0x005B6E18
		protected override void HGGPGEJNEND(float ENLHBNBNPJN)
		{
			base.DBFHDGILJHI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1465f, Time.time * this.m_SwaySpeed) - 545f;
			float num2 = Mathf.PerlinNoise(1596f, Time.time * this.m_SwaySpeed + 1497f) - 949f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(753f, Time.time * this.m_SwaySpeed) - 1970f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(503f, Time.time * this.m_SwaySpeed + 1326f) - 763f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 787f);
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x005B8D10 File Offset: 0x005B6F10
		protected override void IBKOHKFGLPK(float ENLHBNBNPJN)
		{
			base.PBKHHKKGIBK(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(386f, Time.time * this.m_SwaySpeed) - 994f;
			float num2 = Mathf.PerlinNoise(406f, Time.time * this.m_SwaySpeed + 662f) - 506f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(66f, Time.time * this.m_SwaySpeed) - 662f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(321f, Time.time * this.m_SwaySpeed + 1554f) - 931f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1496f);
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x005B8E08 File Offset: 0x005B7008
		protected override void DHMEPNIKEBE(float ENLHBNBNPJN)
		{
			base.HBIPEHHBHJF(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(227f, Time.time * this.m_SwaySpeed) - 268f;
			float num2 = Mathf.PerlinNoise(1840f, Time.time * this.m_SwaySpeed + 1622f) - 294f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1751f, Time.time * this.m_SwaySpeed) - 180f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(589f, Time.time * this.m_SwaySpeed + 1068f) - 14f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 740f);
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x005B8F00 File Offset: 0x005B7100
		protected override void DJPBNKDDKEI(float ENLHBNBNPJN)
		{
			base.JFLDEFDICKI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(974f, Time.time * this.m_SwaySpeed) - 71f;
			float num2 = Mathf.PerlinNoise(1744f, Time.time * this.m_SwaySpeed + 1393f) - 145f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(542f, Time.time * this.m_SwaySpeed) - 1201f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(73f, Time.time * this.m_SwaySpeed + 1424f) - 324f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1587f);
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x005B8FF8 File Offset: 0x005B71F8
		protected virtual void MCOBJEOFFMI(float ENLHBNBNPJN)
		{
			base.BNFEAINEOON(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1321f, Time.time * this.m_SwaySpeed) - 753f;
			float num2 = Mathf.PerlinNoise(255f, Time.time * this.m_SwaySpeed + 1026f) - 340f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(880f, Time.time * this.m_SwaySpeed) - 1191f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1699f, Time.time * this.m_SwaySpeed + 1650f) - 1969f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1869f);
		}

		// Token: 0x0600CBDB RID: 52187 RVA: 0x005B90F0 File Offset: 0x005B72F0
		protected virtual void KMFDNAODMPO(float ENLHBNBNPJN)
		{
			base.EAOBOPAHGMG(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(486f, Time.time * this.m_SwaySpeed) - 731f;
			float num2 = Mathf.PerlinNoise(1179f, Time.time * this.m_SwaySpeed + 340f) - 1665f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1034f, Time.time * this.m_SwaySpeed) - 1965f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(172f, Time.time * this.m_SwaySpeed + 322f) - 1894f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1978f);
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x005B91E8 File Offset: 0x005B73E8
		protected override void GKKMADIBBCI(float ENLHBNBNPJN)
		{
			base.BNFEAINEOON(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1035f, Time.time * this.m_SwaySpeed) - 1341f;
			float num2 = Mathf.PerlinNoise(1932f, Time.time * this.m_SwaySpeed + 33f) - 76f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(465f, Time.time * this.m_SwaySpeed) - 666f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1667f, Time.time * this.m_SwaySpeed + 1704f) - 1497f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 175f);
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x005B92E0 File Offset: 0x005B74E0
		protected virtual void JOENPDNEMKD(float ENLHBNBNPJN)
		{
			base.FMADKNDMOGB(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(259f, Time.time * this.m_SwaySpeed) - 633f;
			float num2 = Mathf.PerlinNoise(1686f, Time.time * this.m_SwaySpeed + 472f) - 176f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(647f, Time.time * this.m_SwaySpeed) - 760f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1739f, Time.time * this.m_SwaySpeed + 992f) - 551f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1483f);
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x005B93D8 File Offset: 0x005B75D8
		protected override void ONIKMOIOJOP(float ENLHBNBNPJN)
		{
			base.HPNFKKBPKOD(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(241f, Time.time * this.m_SwaySpeed) - 1173f;
			float num2 = Mathf.PerlinNoise(468f, Time.time * this.m_SwaySpeed + 489f) - 92f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1827f, Time.time * this.m_SwaySpeed) - 1743f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(640f, Time.time * this.m_SwaySpeed + 1437f) - 196f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 993f);
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x005B94D0 File Offset: 0x005B76D0
		protected virtual void FKBNPCMMFBH(float ENLHBNBNPJN)
		{
			base.PBKHHKKGIBK(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1148f, Time.time * this.m_SwaySpeed) - 376f;
			float num2 = Mathf.PerlinNoise(312f, Time.time * this.m_SwaySpeed + 891f) - 784f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(255f, Time.time * this.m_SwaySpeed) - 1664f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(532f, Time.time * this.m_SwaySpeed + 1744f) - 992f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 211f);
		}

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x005B95C8 File Offset: 0x005B77C8
		protected override void CHHJLJEAFLL(float ENLHBNBNPJN)
		{
			base.CLHLNNJHLFB(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1304f, Time.time * this.m_SwaySpeed) - 1456f;
			float num2 = Mathf.PerlinNoise(1568f, Time.time * this.m_SwaySpeed + 1109f) - 953f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(964f, Time.time * this.m_SwaySpeed) - 20f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(345f, Time.time * this.m_SwaySpeed + 144f) - 861f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 716f);
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x005B96C0 File Offset: 0x005B78C0
		protected override void KJFIIAKNHOA(float ENLHBNBNPJN)
		{
			base.CHHJLJEAFLL(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1121f, Time.time * this.m_SwaySpeed) - 766f;
			float num2 = Mathf.PerlinNoise(1862f, Time.time * this.m_SwaySpeed + 620f) - 1150f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1225f, Time.time * this.m_SwaySpeed) - 640f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1910f, Time.time * this.m_SwaySpeed + 966f) - 706f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 397f);
		}

		// Token: 0x0600CBE2 RID: 52194 RVA: 0x005B97B8 File Offset: 0x005B79B8
		protected override void OEEDMGLAILI(float ENLHBNBNPJN)
		{
			base.OOPNPDBDNLJ(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1025f, Time.time * this.m_SwaySpeed) - 1544f;
			float num2 = Mathf.PerlinNoise(1704f, Time.time * this.m_SwaySpeed + 310f) - 129f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1381f, Time.time * this.m_SwaySpeed) - 733f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(251f, Time.time * this.m_SwaySpeed + 1459f) - 807f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 863f);
		}

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x005B98D8 File Offset: 0x005B7AD8
		protected virtual void AEFOKEPNGJH(float ENLHBNBNPJN)
		{
			base.DHMEPNIKEBE(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1320f, Time.time * this.m_SwaySpeed) - 525f;
			float num2 = Mathf.PerlinNoise(342f, Time.time * this.m_SwaySpeed + 90f) - 1091f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(1609f, Time.time * this.m_SwaySpeed) - 1937f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(890f, Time.time * this.m_SwaySpeed + 1169f) - 802f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1748f);
		}

		// Token: 0x0600CBE5 RID: 52197 RVA: 0x005B99D0 File Offset: 0x005B7BD0
		protected virtual void PKOFOAMBJCH(float ENLHBNBNPJN)
		{
			base.ACCJCLHAMAC(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(277f, Time.time * this.m_SwaySpeed) - 751f;
			float num2 = Mathf.PerlinNoise(910f, Time.time * this.m_SwaySpeed + 776f) - 1738f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(100f, Time.time * this.m_SwaySpeed) - 1937f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(826f, Time.time * this.m_SwaySpeed + 1163f) - 1816f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1618f);
		}

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x005B9AC8 File Offset: 0x005B7CC8
		protected override void DNNEGJKKHGJ(float ENLHBNBNPJN)
		{
			base.ALCOIPODLJI(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1008f, Time.time * this.m_SwaySpeed) - 285f;
			float num2 = Mathf.PerlinNoise(1877f, Time.time * this.m_SwaySpeed + 387f) - 1130f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(637f, Time.time * this.m_SwaySpeed) - 1825f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(933f, Time.time * this.m_SwaySpeed + 822f) - 552f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1757f);
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x005B9BC0 File Offset: 0x005B7DC0
		protected override void LMOGGCEDOJN(float ENLHBNBNPJN)
		{
			base.IBKOHKFGLPK(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(1281f, Time.time * this.m_SwaySpeed) - 208f;
			float num2 = Mathf.PerlinNoise(1690f, Time.time * this.m_SwaySpeed + 165f) - 1801f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(975f, Time.time * this.m_SwaySpeed) - 561f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(1461f, Time.time * this.m_SwaySpeed + 993f) - 525f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 1873f);
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x005B9CB8 File Offset: 0x005B7EB8
		protected virtual void EMBFHJFCOAF(float ENLHBNBNPJN)
		{
			base.CNKBLOGMGMO(ENLHBNBNPJN);
			float num = Mathf.PerlinNoise(875f, Time.time * this.m_SwaySpeed) - 178f;
			float num2 = Mathf.PerlinNoise(1357f, Time.time * this.m_SwaySpeed + 1340f) - 1462f;
			num *= this.m_BaseSwayAmount;
			num2 *= this.m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(36f, Time.time * this.m_SwaySpeed) - 1836f + this.m_TrackingBias;
			float num4 = Mathf.PerlinNoise(314f, Time.time * this.m_SwaySpeed + 556f) - 219f + this.m_TrackingBias;
			num3 *= -this.m_TrackingSwayAmount * this.KBEGOJGCLOF.x;
			num4 *= this.m_TrackingSwayAmount * this.KBEGOJGCLOF.y;
			base.transform.Rotate(num + num3, num2 + num4, 758f);
		}

		// Token: 0x04001B0C RID: 6924
		[SerializeField]
		private float m_SwaySpeed = 0.5f;

		// Token: 0x04001B0D RID: 6925
		[SerializeField]
		private float m_BaseSwayAmount = 0.5f;

		// Token: 0x04001B0E RID: 6926
		[SerializeField]
		private float m_TrackingSwayAmount = 0.5f;

		// Token: 0x04001B0F RID: 6927
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_TrackingBias;
	}
}
