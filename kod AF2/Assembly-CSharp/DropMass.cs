using System;
using UnityEngine;

// Token: 0x0200010A RID: 266
public class DropMass : MonoBehaviour
{
	// Token: 0x060032BC RID: 12988 RVA: 0x00178A70 File Offset: 0x00176C70
	private void IKHCCAANGOP()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 673f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1728f * num) * 1608f;
			vector.y += num2;
			base.transform.Rotate(736f * Time.deltaTime, 1093f * Time.deltaTime, 312f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1675f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP("ChannelCastOmni", base.transform.position, 1551f, 1796f, 1933f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1925f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 7);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 190f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(1698f, 359f * Time.deltaTime, 998f);
		}
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x00178BC8 File Offset: 0x00176DC8
	private void JPHLMNIMDHH()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1772f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(799f * num) * 692f;
			vector.y += num2;
			base.transform.Rotate(1436f * Time.deltaTime, 1634f * Time.deltaTime, 1950f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 372f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("Gesture Crowd Pump", base.transform.position, 1693f, 935f, 172f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1589f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1284f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(193f, 1427f * Time.deltaTime, 1255f);
		}
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x00178D20 File Offset: 0x00176F20
	public void CCKOCPLDHOJ()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 58f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x00178D84 File Offset: 0x00176F84
	private void IOGAKGCADBL()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1751f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1639f * num) * 435f;
			vector.y += num2;
			base.transform.Rotate(112f * Time.deltaTime, 1792f * Time.deltaTime, 214f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 20f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("SUNSHINE_FILTER_PCF_2x2", base.transform.position, 848f, 162f, 943f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 873f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 0);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 945f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(970f, 1732f * Time.deltaTime, 1961f);
		}
	}

	// Token: 0x060032C0 RID: 12992 RVA: 0x00178EDC File Offset: 0x001770DC
	private void OPDCJCFMIPE()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1237f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(524f * num) * 403f;
			vector.y += num2;
			base.transform.Rotate(1066f * Time.deltaTime, 1245f * Time.deltaTime, 586f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1932f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP("knee", base.transform.position, 1861f, 569f, 1918f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 742f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 0);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1797f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(1137f, 21f * Time.deltaTime, 1896f);
		}
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x00179034 File Offset: 0x00177234
	private void LACNPNKHCAA()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1008f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(510f * num) * 1781f;
			vector.y += num2;
			base.transform.Rotate(1282f * Time.deltaTime, 460f * Time.deltaTime, 906f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1637f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("CrouchWalk", base.transform.position, 1634f, 190f, 212f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 759f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 0);
				LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 709f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1903f, 1148f * Time.deltaTime, 1879f);
		}
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x0017918C File Offset: 0x0017738C
	public void INPKBGAAKKN()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 443f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032C3 RID: 12995 RVA: 0x001791F0 File Offset: 0x001773F0
	private void IGEICBNMPAD()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1869f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1407f * num) * 1618f;
			vector.y += num2;
			base.transform.Rotate(1084f * Time.deltaTime, 598f * Time.deltaTime, 1805f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 406f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP("", base.transform.position, 424f, 913f, 550f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 152f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 7);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 746f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1431f, 413f * Time.deltaTime, 803f);
		}
	}

	// Token: 0x060032C4 RID: 12996 RVA: 0x00179348 File Offset: 0x00177548
	private void CDLDCKAHLHC()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 71f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(822f * num) * 1641f;
			vector.y += num2;
			base.transform.Rotate(1789f * Time.deltaTime, 1762f * Time.deltaTime, 1657f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 301f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP("camouflage_id", base.transform.position, 990f, 1556f, 514f);
				LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, 1072f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 0);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 295f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(372f, 1474f * Time.deltaTime, 1654f);
		}
	}

	// Token: 0x060032C5 RID: 12997 RVA: 0x001794A0 File Offset: 0x001776A0
	private void BOAJJAKEMLH()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1300f * num) * 329f;
			vector.y += num2;
			base.transform.Rotate(1931f * Time.deltaTime, 1396f * Time.deltaTime, 1160f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1274f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP("effects", base.transform.position, 656f, 239f, 1420f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1741f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 7);
				LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1942f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(929f, 583f * Time.deltaTime, 1002f);
		}
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x001795F8 File Offset: 0x001777F8
	public void IHOIMKBBGJJ()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 307f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x0017965C File Offset: 0x0017785C
	private void Update()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 0.1f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(3.1415927f * num) * 0.5f;
			vector.y += num2;
			base.transform.Rotate(10f * Time.deltaTime, 3f * Time.deltaTime, 2f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 0.99f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("donk.ogg", base.transform.position, 0.5f, 3f, 50f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 3000f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 4);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 3f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(0f, -0.3f * Time.deltaTime, 0f);
		}
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x001797B4 File Offset: 0x001779B4
	private void HMLNMHOMMNO()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1149f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(143f * num) * 428f;
			vector.y += num2;
			base.transform.Rotate(1116f * Time.deltaTime, 921f * Time.deltaTime, 36f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 854f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP(" This is not possible to be called for standalone input. Please check your platform and code where this is called", base.transform.position, 1285f, 123f, 1808f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 1233f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 2);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 762f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1918f, 1205f * Time.deltaTime, 521f);
		}
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x0017990C File Offset: 0x00177B0C
	public void NFMJNMABKJH()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 680f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x00179970 File Offset: 0x00177B70
	private void DPGECEOMHNM()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 229f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1071f * num) * 372f;
			vector.y += num2;
			base.transform.Rotate(1741f * Time.deltaTime, 654f * Time.deltaTime, 311f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1301f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("vp", base.transform.position, 737f, 1750f, 320f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1484f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1962f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(619f, 343f * Time.deltaTime, 1089f);
		}
	}

	// Token: 0x060032CB RID: 13003 RVA: 0x00179AC8 File Offset: 0x00177CC8
	private void AMDMCKIFBPA()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1340f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1361f * num) * 1492f;
			vector.y += num2;
			base.transform.Rotate(1777f * Time.deltaTime, 1697f * Time.deltaTime, 1618f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 49f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("sonar_", base.transform.position, 1393f, 1710f, 799f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 274f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 5);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1142f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(268f, 183f * Time.deltaTime, 1369f);
		}
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x00179C20 File Offset: 0x00177E20
	private void PFNOEACNHON()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1964f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(386f * num) * 400f;
			vector.y += num2;
			base.transform.Rotate(229f * Time.deltaTime, 766f * Time.deltaTime, 671f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 536f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("\n<color='#{0}'>{1}</color> ", base.transform.position, 520f, 794f, 751f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1112f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 1);
				LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1613f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(373f, 1826f * Time.deltaTime, 26f);
		}
	}

	// Token: 0x060032CD RID: 13005 RVA: 0x00179D78 File Offset: 0x00177F78
	public void NLIOJDKLHJO()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 448f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x00179DDC File Offset: 0x00177FDC
	private void BJOICAKCPLI()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 597f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(932f * num) * 330f;
			vector.y += num2;
			base.transform.Rotate(975f * Time.deltaTime, 1811f * Time.deltaTime, 123f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 211f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("Mouse ScrollWheel", base.transform.position, 728f, 386f, 1609f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 275f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1153f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(371f, 128f * Time.deltaTime, 1132f);
		}
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x00179F34 File Offset: 0x00178134
	public void AMIBMDBFKBH()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1623f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x00179F98 File Offset: 0x00178198
	public void OBJGLAGOMJH()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 136f);
		this.mode = 0;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x0017A014 File Offset: 0x00178214
	private void PNBGJBMJLFM()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1646f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(765f * num) * 473f;
			vector.y += num2;
			base.transform.Rotate(1969f * Time.deltaTime, 585f * Time.deltaTime, 1734f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 121f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK(" ", base.transform.position, 1348f, 234f, 477f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1721f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 3);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1327f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(990f, 1954f * Time.deltaTime, 1350f);
		}
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x0017A16C File Offset: 0x0017836C
	private void LMMDHJJJNJO()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 503f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(451f * num) * 677f;
			vector.y += num2;
			base.transform.Rotate(442f * Time.deltaTime, 332f * Time.deltaTime, 399f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1803f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP("invn_rec2", base.transform.position, 1313f, 1628f, 1179f);
				LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, 1680f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 5);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 844f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1168f, 801f * Time.deltaTime, 581f);
		}
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x0017A2C4 File Offset: 0x001784C4
	public void NNFOONBOHOA()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1112f);
		this.mode = 0;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x0017A328 File Offset: 0x00178528
	public void CDKFGACJOCH()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1591f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x0017A38C File Offset: 0x0017858C
	public void CIBAGEGKAAG()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1388f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x0017A3F0 File Offset: 0x001785F0
	private void AAEFACEGJMB()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1450f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(453f * num) * 63f;
			vector.y += num2;
			base.transform.Rotate(1298f * Time.deltaTime, 1302f * Time.deltaTime, 1629f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1184f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", base.transform.position, 868f, 306f, 1667f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 326f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 2);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 638f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(1263f, 1735f * Time.deltaTime, 487f);
		}
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x0017A548 File Offset: 0x00178748
	public void OGDJLIPJPPF()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1485f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x0017A5AC File Offset: 0x001787AC
	public void LANEMNGKANO()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 346f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x0017A610 File Offset: 0x00178810
	public void DKCMDPOAEBK()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1835f);
		this.mode = 0;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032DB RID: 13019 RVA: 0x0017A674 File Offset: 0x00178874
	private void MEFOGCFJBNE()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 993f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1768f * num) * 881f;
			vector.y += num2;
			base.transform.Rotate(1356f * Time.deltaTime, 1585f * Time.deltaTime, 647f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 864f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP(" ", base.transform.position, 1068f, 265f, 1787f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 50f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 6);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1842f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1283f, 751f * Time.deltaTime, 729f);
		}
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x0017A7CC File Offset: 0x001789CC
	public void AGHKIPBGKCE()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 79f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032DD RID: 13021 RVA: 0x0017A830 File Offset: 0x00178A30
	public void dropAction()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 0.1f);
		this.mode = 0;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032DE RID: 13022 RVA: 0x0017A894 File Offset: 0x00178A94
	public void CPJLMLHJIHK()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 527f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x0017A8F8 File Offset: 0x00178AF8
	private void JIFOELPAEHG()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1231f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(801f * num) * 591f;
			vector.y += num2;
			base.transform.Rotate(575f * Time.deltaTime, 761f * Time.deltaTime, 690f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 834f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP(" №", base.transform.position, 576f, 1872f, 532f);
				LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, 1911f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 1);
				LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1392f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(985f, 1389f * Time.deltaTime, 76f);
		}
	}

	// Token: 0x060032E0 RID: 13024 RVA: 0x0017AA50 File Offset: 0x00178C50
	private void OFPGMNGFLNH()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1619f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1761f * num) * 390f;
			vector.y += num2;
			base.transform.Rotate(880f * Time.deltaTime, 774f * Time.deltaTime, 1194f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 377f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP("BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: ", base.transform.position, 434f, 380f, 1298f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 204f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1114f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1921f, 1362f * Time.deltaTime, 73f);
		}
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x0017ABA8 File Offset: 0x00178DA8
	private void PFPPDNHLCCA()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1028f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(815f * num) * 1667f;
			vector.y += num2;
			base.transform.Rotate(1856f * Time.deltaTime, 1675f * Time.deltaTime, 554f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 987f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("GiantGrabIdle", base.transform.position, 700f, 1610f, 1014f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 567f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 6);
				LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1918f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(796f, 477f * Time.deltaTime, 309f);
		}
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x0017AD00 File Offset: 0x00178F00
	private void AKLFCMNCPKL()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 565f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(700f * num) * 1735f;
			vector.y += num2;
			base.transform.Rotate(970f * Time.deltaTime, 1240f * Time.deltaTime, 1605f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1404f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("heavy", base.transform.position, 403f, 1383f, 1163f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 659f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 7);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 367f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(1840f, 1127f * Time.deltaTime, 760f);
		}
	}

	// Token: 0x060032E3 RID: 13027 RVA: 0x0017AE58 File Offset: 0x00179058
	private void PJHEGHHOJHJ()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 683f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(396f * num) * 1926f;
			vector.y += num2;
			base.transform.Rotate(1283f * Time.deltaTime, 1013f * Time.deltaTime, 366f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1486f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("turn_tminfo", base.transform.position, 86f, 1394f, 1370f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 735f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 4);
				LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1716f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(1260f, 938f * Time.deltaTime, 1336f);
		}
	}

	// Token: 0x060032E4 RID: 13028 RVA: 0x0017AFB0 File Offset: 0x001791B0
	public void ABEOLBNOIGK()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 585f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x0017B014 File Offset: 0x00179214
	public void HIMINHEDMHJ()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 1522f);
		this.mode = 0;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x0017B078 File Offset: 0x00179278
	public void DEFFBFDLLMA()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 209f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x0017B0DC File Offset: 0x001792DC
	private void FJEEADNCKAG()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1088f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(856f * num) * 1929f;
			vector.y += num2;
			base.transform.Rotate(1079f * Time.deltaTime, 974f * Time.deltaTime, 1207f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1175f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.AHBODLKJNJP(" (", base.transform.position, 674f, 941f, 1032f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 356f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 860f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(118f, 1237f * Time.deltaTime, 870f);
		}
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x0017B234 File Offset: 0x00179434
	private void LDDIGEMBDNF()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 375f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(1373f * num) * 1828f;
			vector.y += num2;
			base.transform.Rotate(959f * Time.deltaTime, 1474f * Time.deltaTime, 959f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 1643f)
			{
				this.mode = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("post_5", base.transform.position, 1440f, 1297f, 1009f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 889f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 2);
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1602f);
			}
		}
		if (this.mode == 1)
		{
			base.transform.Translate(240f, 893f * Time.deltaTime, 1340f);
		}
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x0017B38C File Offset: 0x0017958C
	private void JOHDLNOKCOK()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 468f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(492f * num) * 371f;
			vector.y += num2;
			base.transform.Rotate(153f * Time.deltaTime, 7f * Time.deltaTime, 783f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 241f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP("__WaterReflection", base.transform.position, 574f, 392f, 731f);
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, 1314f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 1);
				LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 432f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(1485f, 251f * Time.deltaTime, 1598f);
		}
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x0017B4E4 File Offset: 0x001796E4
	public void CNIOMBIDGCE()
	{
		this.startTime = Time.time;
		this.dist = Vector3.Distance(this.fropPos, this.toPos);
		this.allTime = this.dist / (this.speed + 322f);
		this.mode = 1;
		this.endTime = Time.time + this.allTime;
	}

	// Token: 0x060032EB RID: 13035 RVA: 0x0017B548 File Offset: 0x00179748
	private void AIAMIFEPALP()
	{
		if (this.mode == 0)
		{
			float num = (Time.time - this.startTime) / (this.allTime + 1202f);
			Vector3 vector = Vector3.Lerp(this.fropPos, this.toPos, num);
			float num2 = Mathf.Sin(827f * num) * 507f;
			vector.y += num2;
			base.transform.Rotate(932f * Time.deltaTime, 665f * Time.deltaTime, 1553f * Time.deltaTime);
			base.transform.position = vector;
			if (num > 242f)
			{
				this.mode = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.BJIPPOCFFOK("' that does not excist in the Node Chain.", base.transform.position, 1715f, 1866f, 931f);
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1007f);
				LocNewLogic.getI.createWaterCircle(base.transform.position, 8);
				LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
				UnityEngine.Object.Destroy(base.gameObject, 1108f);
			}
		}
		if (this.mode == 0)
		{
			base.transform.Translate(862f, 856f * Time.deltaTime, 1479f);
		}
	}

	// Token: 0x04000730 RID: 1840
	public float speed = 1f;

	// Token: 0x04000731 RID: 1841
	public Vector3 fropPos;

	// Token: 0x04000732 RID: 1842
	public Vector3 toPos;

	// Token: 0x04000733 RID: 1843
	public int mode = -1;

	// Token: 0x04000734 RID: 1844
	public float startTime;

	// Token: 0x04000735 RID: 1845
	public float endTime;

	// Token: 0x04000736 RID: 1846
	public float dist;

	// Token: 0x04000737 RID: 1847
	public float allTime;
}
