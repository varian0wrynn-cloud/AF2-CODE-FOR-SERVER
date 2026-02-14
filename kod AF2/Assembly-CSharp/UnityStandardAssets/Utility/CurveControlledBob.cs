using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002CF RID: 719
	[Serializable]
	public class CurveControlledBob
	{
		// Token: 0x0600A8BB RID: 43195 RVA: 0x004B1ED0 File Offset: 0x004B00D0
		public Vector3 FKNMNOKJCEN(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1416f);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x004B1FB0 File Offset: 0x004B01B0
		public void GPJNKMPELEF(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8BD RID: 43197 RVA: 0x004B1FFC File Offset: 0x004B01FC
		public Vector3 HMHGHNBEGNC(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 616f);
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x004B20DC File Offset: 0x004B02DC
		public Vector3 CPMBPCCKDDI(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 766f);
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x004B21BC File Offset: 0x004B03BC
		public void BPOMBPLNIBD(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x004B2208 File Offset: 0x004B0408
		public void JAACHGMDGPI(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x004B2254 File Offset: 0x004B0454
		public void JPMIPIAFAIA(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x004B22A0 File Offset: 0x004B04A0
		public Vector3 PCFFEELPMND(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1247f);
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x004B2380 File Offset: 0x004B0580
		public void EFJJOGCGNAM(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x004B23CC File Offset: 0x004B05CC
		public void BNKHIEFMPEH(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x004B24CC File Offset: 0x004B06CC
		public void MDNHIOEIBKO(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x004B2518 File Offset: 0x004B0718
		public void MNPJDDMFKNK(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x004B2564 File Offset: 0x004B0764
		public void LBADAIEMHGF(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x004B25B0 File Offset: 0x004B07B0
		public Vector3 KBCHCKLLFCC(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 725f);
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x004B2690 File Offset: 0x004B0890
		public Vector3 IMIIKHFCCIE(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1486f);
		}

		// Token: 0x0600A8CB RID: 43211 RVA: 0x004B2770 File Offset: 0x004B0970
		public void KGLONDNGAHE(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x004B27BC File Offset: 0x004B09BC
		public Vector3 PEJBDDGKGMO(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1870f);
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x004B289C File Offset: 0x004B0A9C
		public void EJCDJLGPIDI(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x004B28E8 File Offset: 0x004B0AE8
		public Vector3 IMFOEDDDIMK(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 972f);
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x004B29C8 File Offset: 0x004B0BC8
		public Vector3 JHGPBFKHIIJ(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 236f);
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x004B2AA8 File Offset: 0x004B0CA8
		public Vector3 MNEKJCKJNDL(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1269f);
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x004B2B88 File Offset: 0x004B0D88
		public void IHINGJEEHID(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x004B2BD4 File Offset: 0x004B0DD4
		public void BGKLIGMBHFO(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x004B2C20 File Offset: 0x004B0E20
		public Vector3 MKLOILLONGN(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1498f);
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x004B2D00 File Offset: 0x004B0F00
		public Vector3 ANAGPOEAGIM(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1637f);
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x004B2DE0 File Offset: 0x004B0FE0
		public void OJOLMKNNFOB(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x004B2E2C File Offset: 0x004B102C
		public void NDPBPPGLILN(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x004B2E78 File Offset: 0x004B1078
		public void LLGMFFDPIHI(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x004B2EC4 File Offset: 0x004B10C4
		public Vector3 CMCKNLNPEFA(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 0f);
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x004B2FA4 File Offset: 0x004B11A4
		public void MCOFACCIGPN(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x004B2FF0 File Offset: 0x004B11F0
		public Vector3 NFNFKKJNPHD(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 208f);
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x004B30D0 File Offset: 0x004B12D0
		public Vector3 FJEBCJGEBHE(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 362f);
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x004B31B0 File Offset: 0x004B13B0
		public Vector3 ODJEKBLNNMG(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1946f);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x004B3290 File Offset: 0x004B1490
		public Vector3 ANEEAONDHCF(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1804f);
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x004B3370 File Offset: 0x004B1570
		public Vector3 DNABFBLCGBB(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 593f);
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x004B3450 File Offset: 0x004B1650
		public void NBDIALKKHOE(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x004B349C File Offset: 0x004B169C
		public Vector3 MFEJNAMNELL(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1379f);
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x004B357C File Offset: 0x004B177C
		public void OLEOIIBMIBK(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 0].time;
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x004B35C8 File Offset: 0x004B17C8
		public void ECHPNEIALGB(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x004B3614 File Offset: 0x004B1814
		public Vector3 KMPEPHLMLAH(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 1366f);
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x004B36F4 File Offset: 0x004B18F4
		public void NDCNMINBNJO(Camera LBCHLCGOCOD, float EGLNCBDPFED)
		{
			this.m_BobBaseInterval = EGLNCBDPFED;
			this.m_OriginalCameraPosition = LBCHLCGOCOD.transform.localPosition;
			this.m_Time = this.Bobcurve[this.Bobcurve.length - 1].time;
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x004B3740 File Offset: 0x004B1940
		public Vector3 FHLOCJHCAKJ(float AIFIJJADKHN)
		{
			float x = this.m_OriginalCameraPosition.x + this.Bobcurve.Evaluate(this.m_CyclePositionX) * this.HorizontalBobRange;
			float y = this.m_OriginalCameraPosition.y + this.Bobcurve.Evaluate(this.m_CyclePositionY) * this.VerticalBobRange;
			this.m_CyclePositionX += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval;
			this.m_CyclePositionY += AIFIJJADKHN * Time.deltaTime / this.m_BobBaseInterval * this.VerticaltoHorizontalRatio;
			if (this.m_CyclePositionX > this.m_Time)
			{
				this.m_CyclePositionX -= this.m_Time;
			}
			if (this.m_CyclePositionY > this.m_Time)
			{
				this.m_CyclePositionY -= this.m_Time;
			}
			return new Vector3(x, y, 839f);
		}

		// Token: 0x040015C5 RID: 5573
		public float HorizontalBobRange = 0.33f;

		// Token: 0x040015C6 RID: 5574
		public float VerticalBobRange = 0.33f;

		// Token: 0x040015C7 RID: 5575
		public AnimationCurve Bobcurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(0.5f, 1f),
			new Keyframe(1f, 0f),
			new Keyframe(1.5f, -1f),
			new Keyframe(2f, 0f)
		});

		// Token: 0x040015C8 RID: 5576
		public float VerticaltoHorizontalRatio = 1f;

		// Token: 0x040015C9 RID: 5577
		private float m_CyclePositionX;

		// Token: 0x040015CA RID: 5578
		private float m_CyclePositionY;

		// Token: 0x040015CB RID: 5579
		private float m_BobBaseInterval;

		// Token: 0x040015CC RID: 5580
		private Vector3 m_OriginalCameraPosition;

		// Token: 0x040015CD RID: 5581
		private float m_Time;
	}
}
