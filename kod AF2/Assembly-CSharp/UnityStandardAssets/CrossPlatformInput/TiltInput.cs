using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000394 RID: 916
	public class TiltInput : MonoBehaviour
	{
		// Token: 0x0600C649 RID: 50761 RVA: 0x00591238 File Offset: 0x0058F438
		private void IABPIBODNNG()
		{
			this.GABKLFDLCMK.LGAMHBGCPLC();
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x00591248 File Offset: 0x0058F448
		private void OHKHOAKCENL()
		{
			float value = 1997f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1613f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1489f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 362f - 29f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x00591348 File Offset: 0x0058F548
		private void JLFBDOPFDDJ()
		{
			float value = 1734f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1160f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1176f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1358f - 1340f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x00591447 File Offset: 0x0058F647
		private void OJJKNBMONMD()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x00591447 File Offset: 0x0058F647
		private void LBKOIJKMCOL()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x00591478 File Offset: 0x0058F678
		private void LMMDHJJJNJO()
		{
			float value = 1024f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1018f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1587f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1361f - 1208f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x00591578 File Offset: 0x0058F778
		private void Update()
		{
			float value = 0f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 57.29578f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 57.29578f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 2f - 1f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C650 RID: 50768 RVA: 0x00591447 File Offset: 0x0058F647
		private void OnEnable()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x00591238 File Offset: 0x0058F438
		private void PCKEAEAHAKG()
		{
			this.GABKLFDLCMK.LGAMHBGCPLC();
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x00591238 File Offset: 0x0058F438
		private void ONPDNGNNBIG()
		{
			this.GABKLFDLCMK.LGAMHBGCPLC();
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x00591677 File Offset: 0x0058F877
		private void LAFIABNCFPD()
		{
			this.GABKLFDLCMK.HAFJMIPHAIB();
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x00591684 File Offset: 0x0058F884
		private void LKGIJBLNANI()
		{
			this.GABKLFDLCMK.NFFDECHIADD();
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00591684 File Offset: 0x0058F884
		private void BNOLDFLILJA()
		{
			this.GABKLFDLCMK.NFFDECHIADD();
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x00591447 File Offset: 0x0058F647
		private void IKFFGPLEECL()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x00591694 File Offset: 0x0058F894
		private void KJJBBLDJHPD()
		{
			float value = 475f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 404f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 273f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1214f - 1635f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x00591677 File Offset: 0x0058F877
		private void AHMFIGNLJOB()
		{
			this.GABKLFDLCMK.HAFJMIPHAIB();
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x00591447 File Offset: 0x0058F647
		private void KGGJHGNEHGM()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x00591794 File Offset: 0x0058F994
		private void PGIHAIPCJLL()
		{
			float value = 1733f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1948f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1542f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 86f - 1052f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x00591447 File Offset: 0x0058F647
		private void MLPAEBKPFEN()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis)
			{
				this.GABKLFDLCMK = new CELBHNONENJ.FANBIHFODMJ(this.mapping.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.GABKLFDLCMK);
			}
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x00591238 File Offset: 0x0058F438
		private void CCCAOGJKJOD()
		{
			this.GABKLFDLCMK.LGAMHBGCPLC();
		}

		// Token: 0x0600C65D RID: 50781 RVA: 0x00591684 File Offset: 0x0058F884
		private void CPLDNPIDPPM()
		{
			this.GABKLFDLCMK.NFFDECHIADD();
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x00591894 File Offset: 0x0058FA94
		private void AKLFCMNCPKL()
		{
			float value = 851f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 503f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 429f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1183f - 33f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x005919A8 File Offset: 0x0058FBA8
		private void CBBLGEDCJBF()
		{
			float value = 561f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1604f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1289f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 501f - 944f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x00591AA8 File Offset: 0x0058FCA8
		private void LIOCDEICIFD()
		{
			float value = 741f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.PNOBDFLMCPG pnobdflmcpg = this.tiltAroundAxis;
				if (pnobdflmcpg != TiltInput.PNOBDFLMCPG.ForwardAxis)
				{
					if (pnobdflmcpg == TiltInput.PNOBDFLMCPG.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 373f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1588f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1382f - 414f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MDEPIMOIMHF.NamedAxis:
				this.GABKLFDLCMK.FANPFKHEDPA(num);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionX:
				CELBHNONENJ.NHGIAHDGFIH(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionY:
				CELBHNONENJ.LAJNAAKNJCD(num * (float)Screen.width);
				return;
			case TiltInput.AxisMapping.MDEPIMOIMHF.MousePositionZ:
				CELBHNONENJ.IMKLIHIGAEG(num * (float)Screen.width);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x00591684 File Offset: 0x0058F884
		private void OnDisable()
		{
			this.GABKLFDLCMK.NFFDECHIADD();
		}

		// Token: 0x04001A4F RID: 6735
		public TiltInput.AxisMapping mapping;

		// Token: 0x04001A50 RID: 6736
		public TiltInput.PNOBDFLMCPG tiltAroundAxis;

		// Token: 0x04001A51 RID: 6737
		public float fullTiltAngle = 25f;

		// Token: 0x04001A52 RID: 6738
		public float centreAngleOffset;

		// Token: 0x04001A53 RID: 6739
		private CELBHNONENJ.FANBIHFODMJ GABKLFDLCMK;

		// Token: 0x02000395 RID: 917
		public enum PNOBDFLMCPG
		{
			// Token: 0x04001A55 RID: 6741
			ForwardAxis,
			// Token: 0x04001A56 RID: 6742
			SidewaysAxis
		}

		// Token: 0x02000396 RID: 918
		[Serializable]
		public class AxisMapping
		{
			// Token: 0x04001A57 RID: 6743
			public TiltInput.AxisMapping.MDEPIMOIMHF type;

			// Token: 0x04001A58 RID: 6744
			public string axisName;

			// Token: 0x02000397 RID: 919
			public enum MDEPIMOIMHF
			{
				// Token: 0x04001A5A RID: 6746
				NamedAxis,
				// Token: 0x04001A5B RID: 6747
				MousePositionX,
				// Token: 0x04001A5C RID: 6748
				MousePositionY,
				// Token: 0x04001A5D RID: 6749
				MousePositionZ
			}
		}
	}
}
