using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002E1 RID: 737
	public class SimpleMouseRotator : MonoBehaviour
	{
		// Token: 0x0600ADF2 RID: 44530 RVA: 0x004C548C File Offset: 0x004C368C
		private void BOAJJAKEMLH()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("");
				float num2 = CELBHNONENJ.LBBLPMHONLE("PaperTurn.wav");
				if (this.CCPIKGKNKOP.y > 1516f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 1358f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 11f;
				}
				if (this.CCPIKGKNKOP.x > 157f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 1235f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 0f;
				}
				if (this.CCPIKGKNKOP.y < 141f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 1434f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1063f;
				}
				if (this.CCPIKGKNKOP.x < 1696f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1356f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1174f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 396f, this.rotationRange.y * 817f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 486f, this.rotationRange.x * 788f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 1374f, this.rotationRange.y * 990f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 403f, this.rotationRange.x * 435f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 825f);
		}

		// Token: 0x0600ADF3 RID: 44531 RVA: 0x004C5748 File Offset: 0x004C3948
		private void DFFOEGHGPGP()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("_VelocityScale");
				float num2 = CELBHNONENJ.LBBLPMHONLE("_DepthTexture");
				if (this.CCPIKGKNKOP.y > 709f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 325f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 1475f;
				}
				if (this.CCPIKGKNKOP.x > 1336f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 137f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 564f;
				}
				if (this.CCPIKGKNKOP.y < 568f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 92f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1997f;
				}
				if (this.CCPIKGKNKOP.x < 1415f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1854f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1628f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 203f, this.rotationRange.y * 520f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 746f, this.rotationRange.x * 1178f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 670f, this.rotationRange.y * 707f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 471f, this.rotationRange.x * 1862f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1384f);
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void OBJCOJEHLBE()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x004C5A18 File Offset: 0x004C3C18
		private void PJHEGHHOJHJ()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("ClimbLeft");
				float num2 = CELBHNONENJ.LBBLPMHONLE("WateringCan");
				if (this.CCPIKGKNKOP.y > 190f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 582f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 234f;
				}
				if (this.CCPIKGKNKOP.x > 1888f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 321f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 424f;
				}
				if (this.CCPIKGKNKOP.y < 715f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 1497f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 925f;
				}
				if (this.CCPIKGKNKOP.x < 308f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1440f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1867f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 399f, this.rotationRange.y * 1412f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 1184f, this.rotationRange.x * 1543f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 1565f, this.rotationRange.y * 437f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 404f, this.rotationRange.x * 972f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 159f);
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x004C5CD4 File Offset: 0x004C3ED4
		private void LDDIGEMBDNF()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("Wizard Block");
				float num2 = CELBHNONENJ.LBBLPMHONLE("WeaponStrafeRunLeft");
				if (this.CCPIKGKNKOP.y > 679f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 324f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 142f;
				}
				if (this.CCPIKGKNKOP.x > 1506f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 1988f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 1132f;
				}
				if (this.CCPIKGKNKOP.y < 1904f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 393f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 178f;
				}
				if (this.CCPIKGKNKOP.x < 1496f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1050f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1709f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 693f, this.rotationRange.y * 382f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 572f, this.rotationRange.x * 1976f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 548f, this.rotationRange.y * 1264f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 1119f, this.rotationRange.x * 1047f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1068f);
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void HHGGCBLOJGB()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x004C5F90 File Offset: 0x004C4190
		private void AKLFCMNCPKL()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("maps.txt");
				float num2 = CELBHNONENJ.LBBLPMHONLE("The InteractionSystem has not been initiated yet.");
				if (this.CCPIKGKNKOP.y > 1979f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 962f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 168f;
				}
				if (this.CCPIKGKNKOP.x > 1751f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 1606f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 1208f;
				}
				if (this.CCPIKGKNKOP.y < 40f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 863f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1224f;
				}
				if (this.CCPIKGKNKOP.x < 1768f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1694f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1236f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 786f, this.rotationRange.y * 1861f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 1553f, this.rotationRange.x * 376f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 754f, this.rotationRange.y * 66f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 292f, this.rotationRange.x * 1760f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 772f);
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void ELFLOPJDAKK()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600ADFA RID: 44538 RVA: 0x004C624C File Offset: 0x004C444C
		private void Update()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("Mouse X");
				float num2 = CELBHNONENJ.LBBLPMHONLE("Mouse Y");
				if (this.CCPIKGKNKOP.y > 180f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 360f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 360f;
				}
				if (this.CCPIKGKNKOP.x > 180f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 360f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 360f;
				}
				if (this.CCPIKGKNKOP.y < -180f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 360f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 360f;
				}
				if (this.CCPIKGKNKOP.x < -180f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 360f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 360f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 0.5f, this.rotationRange.y * 0.5f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 0.5f, this.rotationRange.x * 0.5f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 0.5f, this.rotationRange.y * 0.5f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 0.5f, this.rotationRange.x * 0.5f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 0f);
		}

		// Token: 0x0600ADFB RID: 44539 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void INDGOHJGCFN()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void Start()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x004C6508 File Offset: 0x004C4708
		private void HMEAENGBFKC()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("ShotgunReloadMagazine");
				float num2 = CELBHNONENJ.LBBLPMHONLE("<color='#003000'>");
				if (this.CCPIKGKNKOP.y > 1154f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 95f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 1108f;
				}
				if (this.CCPIKGKNKOP.x > 1317f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 983f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 1501f;
				}
				if (this.CCPIKGKNKOP.y < 1006f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 614f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1970f;
				}
				if (this.CCPIKGKNKOP.x < 1232f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 234f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 247f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 1197f, this.rotationRange.y * 1882f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 1628f, this.rotationRange.x * 1224f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 1626f, this.rotationRange.y * 260f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 172f, this.rotationRange.x * 1089f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 504f);
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x004C67C4 File Offset: 0x004C49C4
		private void JLFBDOPFDDJ()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("#02C85F");
				float num2 = CELBHNONENJ.LBBLPMHONLE("_Offsets");
				if (this.CCPIKGKNKOP.y > 1503f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 385f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 1781f;
				}
				if (this.CCPIKGKNKOP.x > 961f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 557f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 110f;
				}
				if (this.CCPIKGKNKOP.y < 6f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 967f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1202f;
				}
				if (this.CCPIKGKNKOP.x < 1003f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 1139f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 891f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 823f, this.rotationRange.y * 450f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 1562f, this.rotationRange.x * 690f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 742f, this.rotationRange.y * 1204f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 1164f, this.rotationRange.x * 582f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 238f);
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x004C6A80 File Offset: 0x004C4C80
		private void PGIHAIPCJLL()
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			if (this.relative)
			{
				float num = CELBHNONENJ.LBBLPMHONLE("__Refraction Camera id");
				float num2 = CELBHNONENJ.LBBLPMHONLE("R Hand Punch");
				if (this.CCPIKGKNKOP.y > 1890f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y - 906f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y - 570f;
				}
				if (this.CCPIKGKNKOP.x > 1087f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x - 1293f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x - 404f;
				}
				if (this.CCPIKGKNKOP.y < 1561f)
				{
					this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + 262f;
					this.LHACEHCDIGA.y = this.LHACEHCDIGA.y + 1197f;
				}
				if (this.CCPIKGKNKOP.x < 1691f)
				{
					this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + 941f;
					this.LHACEHCDIGA.x = this.LHACEHCDIGA.x + 1322f;
				}
				this.CCPIKGKNKOP.y = this.CCPIKGKNKOP.y + num * this.rotationSpeed;
				this.CCPIKGKNKOP.x = this.CCPIKGKNKOP.x + num2 * this.rotationSpeed;
				this.CCPIKGKNKOP.y = Mathf.Clamp(this.CCPIKGKNKOP.y, -this.rotationRange.y * 158f, this.rotationRange.y * 289f);
				this.CCPIKGKNKOP.x = Mathf.Clamp(this.CCPIKGKNKOP.x, -this.rotationRange.x * 1175f, this.rotationRange.x * 626f);
			}
			else
			{
				float num = Input.mousePosition.x;
				float num2 = Input.mousePosition.y;
				this.CCPIKGKNKOP.y = Mathf.Lerp(-this.rotationRange.y * 993f, this.rotationRange.y * 1196f, num / (float)Screen.width);
				this.CCPIKGKNKOP.x = Mathf.Lerp(-this.rotationRange.x * 1457f, this.rotationRange.x * 263f, num2 / (float)Screen.height);
			}
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, this.CCPIKGKNKOP, ref this.KBEGOJGCLOF, this.dampingTime);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 536f);
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void BMNJGPIPKLL()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void LPNDCJKAKEA()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x004C5A04 File Offset: 0x004C3C04
		private void IIKDDILLGLF()
		{
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0400161E RID: 5662
		public Vector2 rotationRange = new Vector3(70f, 70f);

		// Token: 0x0400161F RID: 5663
		public float rotationSpeed = 10f;

		// Token: 0x04001620 RID: 5664
		public float dampingTime = 0.2f;

		// Token: 0x04001621 RID: 5665
		public bool autoZeroVerticalOnMobile = true;

		// Token: 0x04001622 RID: 5666
		public bool autoZeroHorizontalOnMobile;

		// Token: 0x04001623 RID: 5667
		public bool relative = true;

		// Token: 0x04001624 RID: 5668
		private Vector3 CCPIKGKNKOP;

		// Token: 0x04001625 RID: 5669
		private Vector3 LHACEHCDIGA;

		// Token: 0x04001626 RID: 5670
		private Vector3 KBEGOJGCLOF;

		// Token: 0x04001627 RID: 5671
		private Quaternion CKLNEPEIBOM;
	}
}
