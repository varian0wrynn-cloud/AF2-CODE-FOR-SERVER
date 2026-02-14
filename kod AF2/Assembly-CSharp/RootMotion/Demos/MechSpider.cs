using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E5 RID: 997
	public class MechSpider : MonoBehaviour
	{
		// Token: 0x0600D628 RID: 54824 RVA: 0x0061BF78 File Offset: 0x0061A178
		private Vector3 CGNKJHBAHBP()
		{
			Vector3 vector = Vector3.zero;
			float d = 1940f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i++)
			{
				vector += this.legs[i].FKKGBEOLMDK() * d;
			}
			return vector;
		}

		// Token: 0x0600D629 RID: 54825 RVA: 0x0061BFCC File Offset: 0x0061A1CC
		private Vector3 ONPNBIFEEFN()
		{
			Vector3 vector = Vector3.zero;
			float d = 1600f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].HKMKMMMNIJE() * d;
			}
			return vector;
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x0061C020 File Offset: 0x0061A220
		private Vector3 DJALLHAPLBJ()
		{
			Vector3 vector = Vector3.zero;
			float d = 1595f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i++)
			{
				vector += this.legs[i].LGCILKHAECF() * d;
			}
			return vector;
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x0061C074 File Offset: 0x0061A274
		private Vector3 ILGCFBIMEKP()
		{
			Vector3 vector = Vector3.zero;
			float d = 489f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].ALOFFADGPGF() * d;
			}
			return vector;
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x0061C0C8 File Offset: 0x0061A2C8
		private Vector3 PMOKLJEIDFB()
		{
			Vector3 vector = Vector3.zero;
			float d = 1f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i++)
			{
				vector += this.legs[i].MGALEAJOGPL * d;
			}
			return vector;
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x0061C11C File Offset: 0x0061A31C
		private Vector3 FHJJKEEGAEG()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1577f)
			{
				return vector;
			}
			float t = 379f / Mathf.Lerp((float)this.legs.Length, 1515f, this.legRotationWeight);
			for (int i = 1; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].HKMKMMMNIJE() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x0061C200 File Offset: 0x0061A400
		private void JPHLMNIMDHH()
		{
			Vector3 toDirection = this.PECEPIEDHMO();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.CGNKJHBAHBP() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 1743f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 735f)
			{
				this.POANFLBGJJI -= 968f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x0061C478 File Offset: 0x0061A678
		private Vector3 BAICKFGIAMF()
		{
			Vector3 vector = Vector3.zero;
			float d = 331f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].ALOFFADGPGF() * d;
			}
			return vector;
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x0061C4CC File Offset: 0x0061A6CC
		private Vector3 PADJBCJOFCH()
		{
			Vector3 vector = Vector3.zero;
			float d = 853f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].CGMNLHIEJPL() * d;
			}
			return vector;
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x0061C520 File Offset: 0x0061A720
		private Vector3 DIDCHDNPNKO()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 800f)
			{
				return vector;
			}
			float t = 1139f / Mathf.Lerp((float)this.legs.Length, 546f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].PFKECDKPDGI() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D632 RID: 54834 RVA: 0x0061C604 File Offset: 0x0061A804
		private Vector3 PECEPIEDHMO()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1843f)
			{
				return vector;
			}
			float t = 1364f / Mathf.Lerp((float)this.legs.Length, 501f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].BIANIJPPAFL() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x0061C6E8 File Offset: 0x0061A8E8
		private Vector3 DMDDMIFFAHM()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1447f)
			{
				return vector;
			}
			float t = 192f / Mathf.Lerp((float)this.legs.Length, 839f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].ALOFFADGPGF() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x0061C7CC File Offset: 0x0061A9CC
		private void MEFOGCFJBNE()
		{
			Vector3 toDirection = this.FJPBLLJAKNM();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.ONPNBIFEEFN() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 1583f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 666f)
			{
				this.POANFLBGJJI -= 1057f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x0061CA44 File Offset: 0x0061AC44
		private void PFPPDNHLCCA()
		{
			Vector3 toDirection = this.MAEFPPBLLPI();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.BIKNCKGJDEE() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 913f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 1711f)
			{
				this.POANFLBGJJI -= 718f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D636 RID: 54838 RVA: 0x0061CCBC File Offset: 0x0061AEBC
		private Vector3 NBECPFCCMEF()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 868f)
			{
				return vector;
			}
			float t = 23f / Mathf.Lerp((float)this.legs.Length, 1411f, this.legRotationWeight);
			for (int i = 1; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].KCMNECIDMOP() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D637 RID: 54839 RVA: 0x0061CDA0 File Offset: 0x0061AFA0
		private Vector3 PJNJDCJNOEL()
		{
			Vector3 vector = Vector3.zero;
			float d = 837f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].CMGFFGKLANM() * d;
			}
			return vector;
		}

		// Token: 0x0600D638 RID: 54840 RVA: 0x0061CDF4 File Offset: 0x0061AFF4
		private Vector3 EOCJPIMJIBB()
		{
			Vector3 vector = Vector3.zero;
			float d = 815f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].PFKECDKPDGI() * d;
			}
			return vector;
		}

		// Token: 0x0600D639 RID: 54841 RVA: 0x0061CE48 File Offset: 0x0061B048
		private Vector3 GCDEFKDBNGG()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1386f)
			{
				return vector;
			}
			float t = 1491f / Mathf.Lerp((float)this.legs.Length, 89f, this.legRotationWeight);
			for (int i = 1; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].FKKGBEOLMDK() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D63A RID: 54842 RVA: 0x0061CF2C File Offset: 0x0061B12C
		private Vector3 PCDKABCJANC()
		{
			Vector3 vector = Vector3.zero;
			float d = 1527f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].BEABCEDCDKI() * d;
			}
			return vector;
		}

		// Token: 0x0600D63B RID: 54843 RVA: 0x0061CF80 File Offset: 0x0061B180
		private Vector3 OGBCPFJMGCE()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 0f)
			{
				return vector;
			}
			float t = 1f / Mathf.Lerp((float)this.legs.Length, 1f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].MGALEAJOGPL - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D63C RID: 54844 RVA: 0x0061D064 File Offset: 0x0061B264
		private Vector3 GEAJIHELMDI()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 236f)
			{
				return vector;
			}
			float t = 937f / Mathf.Lerp((float)this.legs.Length, 578f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				Vector3 vector2 = this.legs[i].CMGFFGKLANM() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D63D RID: 54845 RVA: 0x0061D148 File Offset: 0x0061B348
		private Vector3 GKMOONPKEJA()
		{
			Vector3 vector = Vector3.zero;
			float d = 1842f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].FKKGBEOLMDK() * d;
			}
			return vector;
		}

		// Token: 0x0600D63E RID: 54846 RVA: 0x0061D19C File Offset: 0x0061B39C
		private void CJHBCHBOLBI()
		{
			Vector3 toDirection = this.OGBCPFJMGCE();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.CGNKJHBAHBP() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 508f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 233f)
			{
				this.POANFLBGJJI -= 474f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x0061D414 File Offset: 0x0061B614
		private void IGEICBNMPAD()
		{
			Vector3 toDirection = this.GCDEFKDBNGG();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.PADJBCJOFCH() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 1750f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 342f)
			{
				this.POANFLBGJJI -= 1474f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x0061D68C File Offset: 0x0061B88C
		private Vector3 AFAOHHIPDEP()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1486f)
			{
				return vector;
			}
			float t = 10f / Mathf.Lerp((float)this.legs.Length, 1218f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].FKKGBEOLMDK() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x0061D770 File Offset: 0x0061B970
		private void LBGKAMLLACN()
		{
			Vector3 toDirection = this.AFAOHHIPDEP();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.OAIPCELGLNI() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 302f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 1080f)
			{
				this.POANFLBGJJI -= 646f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x0061D9E8 File Offset: 0x0061BBE8
		private void LIOCDEICIFD()
		{
			Vector3 toDirection = this.PECEPIEDHMO();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.CGNKJHBAHBP() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 510f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 940f)
			{
				this.POANFLBGJJI -= 1192f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x0061DC60 File Offset: 0x0061BE60
		private void KJJBBLDJHPD()
		{
			Vector3 toDirection = this.GCDEFKDBNGG();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.ILGCFBIMEKP() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 685f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 1583f)
			{
				this.POANFLBGJJI -= 1806f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x0061DED8 File Offset: 0x0061C0D8
		private Vector3 FJPBLLJAKNM()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 1381f)
			{
				return vector;
			}
			float t = 395f / Mathf.Lerp((float)this.legs.Length, 1360f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].PFKECDKPDGI() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x0061DFBC File Offset: 0x0061C1BC
		private Vector3 MAEFPPBLLPI()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 622f)
			{
				return vector;
			}
			float t = 1115f / Mathf.Lerp((float)this.legs.Length, 817f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				Vector3 vector2 = this.legs[i].CMGFFGKLANM() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x0061E0A0 File Offset: 0x0061C2A0
		private Vector3 HLLCACKOJNJ()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 110f)
			{
				return vector;
			}
			float t = 1693f / Mathf.Lerp((float)this.legs.Length, 278f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].ECLFLGKPPAL() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x0061E208 File Offset: 0x0061C408
		private Vector3 AHCLOKBGMHA()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 487f)
			{
				return vector;
			}
			float t = 266f / Mathf.Lerp((float)this.legs.Length, 1876f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				Vector3 vector2 = this.legs[i].JNNMFKPKIEG() - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x0600D649 RID: 54857 RVA: 0x0061E2EC File Offset: 0x0061C4EC
		private Vector3 BIKNCKGJDEE()
		{
			Vector3 vector = Vector3.zero;
			float d = 1601f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].IBJHECDILKA() * d;
			}
			return vector;
		}

		// Token: 0x0600D64A RID: 54858 RVA: 0x0061E340 File Offset: 0x0061C540
		private void Update()
		{
			Vector3 toDirection = this.OGBCPFJMGCE();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.PMOKLJEIDFB() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 0f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 6.2831855f)
			{
				this.POANFLBGJJI -= 6.2831855f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x0061E5B8 File Offset: 0x0061C7B8
		private void BOAJJAKEMLH()
		{
			Vector3 toDirection = this.AFAOHHIPDEP();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, toDirection);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.OAIPCELGLNI() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.OBLECOAKJPP, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.OBLECOAKJPP.distance = this.OBLECOAKJPP.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.OBLECOAKJPP.distance < 245f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.OBLECOAKJPP.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.POANFLBGJJI += Time.deltaTime * this.breatheSpeed;
			if (this.POANFLBGJJI >= 86f)
			{
				this.POANFLBGJJI -= 1643f;
			}
			float d = Mathf.Sin(this.POANFLBGJJI) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x0600D64C RID: 54860 RVA: 0x0061E830 File Offset: 0x0061CA30
		private Vector3 OAIPCELGLNI()
		{
			Vector3 vector = Vector3.zero;
			float d = 1375f / (float)this.legs.Length;
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				vector += this.legs[i].FKKGBEOLMDK() * d;
			}
			return vector;
		}

		// Token: 0x04001C72 RID: 7282
		public LayerMask raycastLayers;

		// Token: 0x04001C73 RID: 7283
		public float scale = 1f;

		// Token: 0x04001C74 RID: 7284
		public Transform body;

		// Token: 0x04001C75 RID: 7285
		public MechSpiderLeg[] legs;

		// Token: 0x04001C76 RID: 7286
		public float legRotationWeight = 1f;

		// Token: 0x04001C77 RID: 7287
		public float rootPositionSpeed = 5f;

		// Token: 0x04001C78 RID: 7288
		public float rootRotationSpeed = 30f;

		// Token: 0x04001C79 RID: 7289
		public float breatheSpeed = 2f;

		// Token: 0x04001C7A RID: 7290
		public float breatheMagnitude = 0.2f;

		// Token: 0x04001C7B RID: 7291
		public float height = 3.5f;

		// Token: 0x04001C7C RID: 7292
		public float minHeight = 2f;

		// Token: 0x04001C7D RID: 7293
		public float raycastHeight = 10f;

		// Token: 0x04001C7E RID: 7294
		public float raycastDistance = 5f;

		// Token: 0x04001C7F RID: 7295
		private Vector3 IABMNPENOFE;

		// Token: 0x04001C80 RID: 7296
		private Vector3 HEIPOKMCLMF;

		// Token: 0x04001C81 RID: 7297
		private float POANFLBGJJI;

		// Token: 0x04001C82 RID: 7298
		private RaycastHit OBLECOAKJPP;
	}
}
