using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002D2 RID: 722
	public class DynamicShadowSettings : MonoBehaviour
	{
		// Token: 0x0600A9CB RID: 43467 RVA: 0x004B8254 File Offset: 0x004B6454
		private void AAEFACEGJMB()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1016f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 941f - (970f - num2) * (1807f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1398f, num2);
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x004B8350 File Offset: 0x004B6550
		private void GPCKACGEILI()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 93f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1221f - (1944f - num2) * (1586f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1187f, num2);
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x004B844C File Offset: 0x004B664C
		private void DPGECEOMHNM()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 110f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 44f - (1289f - num2) * (1347f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1669f, num2);
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x004B8548 File Offset: 0x004B6748
		private void NMMGHFDLNOE()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1749f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1812f - (1388f - num2) * (1841f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1091f, num2);
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x004B8643 File Offset: 0x004B6843
		private void EHDPACPIBNF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x004B8658 File Offset: 0x004B6858
		private void MEIOHFKFEME()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1447f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 816f - (1396f - num2) * (1637f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 937f, num2);
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x004B8754 File Offset: 0x004B6954
		private void JIFOELPAEHG()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 176f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1920f - (1911f - num2) * (1381f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 640f, num2);
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x004B8643 File Offset: 0x004B6843
		private void AOCDDBNBADJ()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x004B8850 File Offset: 0x004B6A50
		private void FJEEADNCKAG()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1435f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 361f - (413f - num2) * (968f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 84f, num2);
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x004B8643 File Offset: 0x004B6843
		private void CGNGBFFGGBP()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x004B8643 File Offset: 0x004B6843
		private void JCELICPHGEP()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x004B894C File Offset: 0x004B6B4C
		private void KMPEBHIPKJH()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 733f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1597f - (1445f - num2) * (328f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1567f, num2);
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x004B8643 File Offset: 0x004B6843
		private void GIADAJFBIOP()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x004B8643 File Offset: 0x004B6843
		private void CKGPEFOKKNL()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x004B8643 File Offset: 0x004B6843
		private void PBMPJPIMJBF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x004B8643 File Offset: 0x004B6843
		private void Start()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x004B8A48 File Offset: 0x004B6C48
		private void LDDIGEMBDNF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 709f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1134f - (517f - num2) * (1326f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 881f, num2);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x004B8643 File Offset: 0x004B6843
		private void NOKJMMDMJNO()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x004B8B44 File Offset: 0x004B6D44
		private void OHKHOAKCENL()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 646f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1933f - (270f - num2) * (1343f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 919f, num2);
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x004B8643 File Offset: 0x004B6843
		private void JPHBPEAMNHB()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x004B8C40 File Offset: 0x004B6E40
		private void KEBDEJIAODF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 623f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1114f - (802f - num2) * (1358f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1801f, num2);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x004B8643 File Offset: 0x004B6843
		private void DGEIACONKCJ()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x004B8643 File Offset: 0x004B6843
		private void OLBDJCFPKFG()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x004B8643 File Offset: 0x004B6843
		private void EHFPLKEINFO()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x004B8D3C File Offset: 0x004B6F3C
		private void LBOONMDONCF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1318f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1547f - (455f - num2) * (17f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1387f, num2);
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x004B8E38 File Offset: 0x004B7038
		private void HFPPENPGGAI()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1838f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1942f - (1580f - num2) * (499f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1907f, num2);
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x004B8F34 File Offset: 0x004B7134
		private void PAKOHKKBKHD()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1687f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 574f - (383f - num2) * (768f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1368f, num2);
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FFIGGPHAIBP()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x004B8643 File Offset: 0x004B6843
		private void IIKDDILLGLF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x004B8643 File Offset: 0x004B6843
		private void CGMHGDEKDEP()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x004B9030 File Offset: 0x004B7230
		private void BOAJJAKEMLH()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 212f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 212f - (347f - num2) * (740f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1703f, num2);
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x004B912C File Offset: 0x004B732C
		private void OFPGMNGFLNH()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 549f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 357f - (1052f - num2) * (703f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 656f, num2);
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x004B8643 File Offset: 0x004B6843
		private void DNLFEOECBKI()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x004B9228 File Offset: 0x004B7428
		private void DFFOEGHGPGP()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1725f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1822f - (1542f - num2) * (538f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1243f, num2);
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x004B9390 File Offset: 0x004B7590
		private void BEDAJLJFAFO()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 561f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1311f - (119f - num2) * (1318f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 361f, num2);
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x004B8643 File Offset: 0x004B6843
		private void ADLHNBEDHMJ()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x004B948C File Offset: 0x004B768C
		private void IOGAKGCADBL()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 913f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 545f - (1555f - num2) * (990f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 140f, num2);
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x004B8643 File Offset: 0x004B6843
		private void BJHGPFGBFKF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x004B9588 File Offset: 0x004B7788
		private void JIKGIJEHGAP()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 514f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1630f - (1070f - num2) * (1619f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 552f, num2);
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x004B8643 File Offset: 0x004B6843
		private void CHDJGEOFHEE()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x004B8643 File Offset: 0x004B6843
		private void HEMEEOGJDOE()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x004B8643 File Offset: 0x004B6843
		private void KJJNMNKPNCH()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x004B9684 File Offset: 0x004B7884
		private void PMKOAHMNBBG()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1228f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1645f - (137f - num2) * (1188f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 894f, num2);
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x004B9780 File Offset: 0x004B7980
		private void CBBLGEDCJBF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1788f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1088f - (674f - num2) * (437f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1459f, num2);
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x004B987C File Offset: 0x004B7A7C
		private void LMGBKHCHPHO()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1172f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 457f - (1231f - num2) * (127f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1533f, num2);
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x004B9978 File Offset: 0x004B7B78
		private void OPDCJCFMIPE()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1767f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 689f - (1582f - num2) * (753f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 945f, num2);
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x004B9A74 File Offset: 0x004B7C74
		private void IGEICBNMPAD()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 960f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 925f - (1673f - num2) * (654f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1997f, num2);
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x004B9B70 File Offset: 0x004B7D70
		private void AMDMCKIFBPA()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1727f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1594f - (1301f - num2) * (336f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 72f, num2);
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x004B9C6C File Offset: 0x004B7E6C
		private void HAIMGCDKPDC()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 348f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 247f - (756f - num2) * (397f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1450f, num2);
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x004B9D68 File Offset: 0x004B7F68
		private void PBFKCKCHEAC()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 226f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 200f - (21f - num2) * (1919f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1788f, num2);
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FGJCIEDDFGN()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x004B9E64 File Offset: 0x004B8064
		private void KOLCEBEIHKP()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1575f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1831f - (1096f - num2) * (660f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 805f, num2);
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x004B9F60 File Offset: 0x004B8160
		private void DKOIOBMMAGN()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1446f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1081f - (132f - num2) * (531f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1017f, num2);
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x004B8643 File Offset: 0x004B6843
		private void DPPAAIJCFLC()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA02 RID: 43522 RVA: 0x004BA05C File Offset: 0x004B825C
		private void NFPFDOEENLA()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 810f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 683f - (860f - num2) * (1044f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 465f, num2);
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x004B8643 File Offset: 0x004B6843
		private void EDGALMCHPPH()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x004BA158 File Offset: 0x004B8358
		private void AKLFCMNCPKL()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1683f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 297f - (439f - num2) * (835f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1375f, num2);
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x004BA254 File Offset: 0x004B8454
		private void LIOCDEICIFD()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 602f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 391f - (990f - num2) * (1369f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 541f, num2);
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x004BA350 File Offset: 0x004B8550
		private void EMFOECIPBIP()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 326f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1289f - (1217f - num2) * (564f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1796f, num2);
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x004BA44C File Offset: 0x004B864C
		private void PGIHAIPCJLL()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 620f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1780f - (346f - num2) * (1686f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1976f, num2);
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x004B8643 File Offset: 0x004B6843
		private void DMAOHJDKMNN()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x004B8643 File Offset: 0x004B6843
		private void PMDPLLIBJAF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x004BA548 File Offset: 0x004B8748
		private void OIBIGDFPHGO()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1606f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1724f - (1149f - num2) * (613f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1490f, num2);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x004B8643 File Offset: 0x004B6843
		private void PNAAHEFHPCL()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x004BA644 File Offset: 0x004B8844
		private void FPLNDDMFFKG()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 680f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 989f - (1616f - num2) * (416f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1825f, num2);
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x004B8643 File Offset: 0x004B6843
		private void LPNDCJKAKEA()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x004BA740 File Offset: 0x004B8940
		private void MIFLHGMPLJD()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 440f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1376f - (1778f - num2) * (1189f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1882f, num2);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FJGIBCHABIG()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x004BA83C File Offset: 0x004B8A3C
		private void AIAMIFEPALP()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1576f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1842f - (410f - num2) * (1257f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1415f, num2);
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x004BA938 File Offset: 0x004B8B38
		private void MFHGOLNLAAF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 931f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 295f - (965f - num2) * (814f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1873f, num2);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x004BAA34 File Offset: 0x004B8C34
		private void JLFBDOPFDDJ()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 541f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1818f - (235f - num2) * (1181f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 643f, num2);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FPLHODJCJDO()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x004BAB30 File Offset: 0x004B8D30
		private void PFNOEACNHON()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 866f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1466f - (400f - num2) * (970f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 594f, num2);
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x004B8643 File Offset: 0x004B6843
		private void LBEFOABPMFG()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FECFLBMPAAL()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x004BAC2C File Offset: 0x004B8E2C
		private void EDANNBFJHIK()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1239f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 483f - (1585f - num2) * (71f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1214f, num2);
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x004BAD28 File Offset: 0x004B8F28
		private void PNBGJBMJLFM()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 235f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 21f - (901f - num2) * (754f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 564f, num2);
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x004B8643 File Offset: 0x004B6843
		private void HHGGCBLOJGB()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x004BAE24 File Offset: 0x004B9024
		private void JBFJPNKLLKI()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1106f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1400f - (258f - num2) * (1991f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1479f, num2);
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x004BAF20 File Offset: 0x004B9120
		private void INKGAFANFIB()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 376f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1928f - (768f - num2) * (1060f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 68f, num2);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x004B8643 File Offset: 0x004B6843
		private void IJOCHELLKJH()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x004BB01C File Offset: 0x004B921C
		private void GCNGEFBKMNC()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1326f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1259f - (316f - num2) * (319f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 575f, num2);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x004BB118 File Offset: 0x004B9318
		private void HCDJABMBDFF()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 551f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 691f - (1381f - num2) * (1363f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 25f, num2);
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x004B8643 File Offset: 0x004B6843
		private void KIEIPFFEDHC()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x004B8643 File Offset: 0x004B6843
		private void DHJDMKLBLEF()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x004BB214 File Offset: 0x004B9414
		private void HMLNMHOMMNO()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1705f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1249f - (547f - num2) * (891f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 1752f, num2);
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x004B8643 File Offset: 0x004B6843
		private void MCHAAIIHOKD()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x004B8643 File Offset: 0x004B6843
		private void MKNPFMEMOJO()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x004B8643 File Offset: 0x004B6843
		private void KFGKKLAKFGH()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x004B8643 File Offset: 0x004B6843
		private void FCCAIANLEFE()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x004BB310 File Offset: 0x004B9510
		private void Update()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1f - (1f - num2) * (1f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 0f, num2);
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x004B8643 File Offset: 0x004B6843
		private void ELADFDNPOOI()
		{
			this.CJJPGFBAOIF = this.sunLight.shadowStrength;
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x004BB40C File Offset: 0x004B960C
		private void FOHLAIIMNFB()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit))
			{
				num = raycastHit.distance;
			}
			if (Mathf.Abs(num - this.FOMHPCMABIE) > 1259f)
			{
				this.FOMHPCMABIE = Mathf.SmoothDamp(this.FOMHPCMABIE, num, ref this.PDPBDJHEIEA, this.adaptTime);
			}
			float num2 = Mathf.InverseLerp(this.minHeight, this.maxHeight, this.FOMHPCMABIE);
			QualitySettings.shadowDistance = Mathf.Lerp(this.minShadowDistance, this.maxShadowDistance, num2);
			this.sunLight.shadowBias = Mathf.Lerp(this.minShadowBias, this.maxShadowBias, 1050f - (111f - num2) * (389f - num2));
			this.sunLight.shadowStrength = Mathf.Lerp(this.CJJPGFBAOIF, 964f, num2);
		}

		// Token: 0x040015DC RID: 5596
		public Light sunLight;

		// Token: 0x040015DD RID: 5597
		public float minHeight = 10f;

		// Token: 0x040015DE RID: 5598
		public float minShadowDistance = 80f;

		// Token: 0x040015DF RID: 5599
		public float minShadowBias = 1f;

		// Token: 0x040015E0 RID: 5600
		public float maxHeight = 1000f;

		// Token: 0x040015E1 RID: 5601
		public float maxShadowDistance = 10000f;

		// Token: 0x040015E2 RID: 5602
		public float maxShadowBias = 0.1f;

		// Token: 0x040015E3 RID: 5603
		public float adaptTime = 1f;

		// Token: 0x040015E4 RID: 5604
		private float FOMHPCMABIE;

		// Token: 0x040015E5 RID: 5605
		private float PDPBDJHEIEA;

		// Token: 0x040015E6 RID: 5606
		private float CJJPGFBAOIF = 1f;
	}
}
