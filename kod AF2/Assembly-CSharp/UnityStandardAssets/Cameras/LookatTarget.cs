using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003AE RID: 942
	public class LookatTarget : AbstractTargetFollower
	{
		// Token: 0x0600CBE9 RID: 52201 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FPLHODJCJDO()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void BGCLAKJHAFK()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void BHFMGBNIAMC()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FEBIICIMLHA()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void HDFCIACDDEK()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBEE RID: 52206 RVA: 0x005B9DC8 File Offset: 0x005B7FC8
		protected virtual void JFLDEFDICKI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 108f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 396f, this.m_RotationRange.y * 601f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1646f, num, 858f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1564f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 147f, this.m_RotationRange.x * 515f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1015f);
		}

		// Token: 0x0600CBEF RID: 52207 RVA: 0x005B9F54 File Offset: 0x005B8154
		protected virtual void LHGGPIEFKBM(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 264f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1209f, this.m_RotationRange.y * 1796f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(84f, num, 1845f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 989f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 797f, this.m_RotationRange.x * 1761f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1513f);
		}

		// Token: 0x0600CBF0 RID: 52208 RVA: 0x005BA0E0 File Offset: 0x005B82E0
		protected virtual void ALCOIPODLJI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 428f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 304f, this.m_RotationRange.y * 79f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1973f, num, 831f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1083f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 687f, this.m_RotationRange.x * 192f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1488f);
		}

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x005BA26C File Offset: 0x005B846C
		protected virtual void DPBADPOFKNN(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 742f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1588f, this.m_RotationRange.y * 1868f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(212f, num, 1568f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1701f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 922f, this.m_RotationRange.x * 883f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 441f);
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void EFCCCKGCOCB()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBF3 RID: 52211 RVA: 0x005BA3F8 File Offset: 0x005B85F8
		protected virtual void HPNFKKBPKOD(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 226f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1934f, this.m_RotationRange.y * 1739f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(425f, num, 1979f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1210f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1697f, this.m_RotationRange.x * 673f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1634f);
		}

		// Token: 0x0600CBF4 RID: 52212 RVA: 0x005BA584 File Offset: 0x005B8784
		protected virtual void FMPPCNAHCAD(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 780f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 454f, this.m_RotationRange.y * 747f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1704f, num, 435f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 266f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1162f, this.m_RotationRange.x * 744f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1514f);
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x005BA710 File Offset: 0x005B8910
		protected virtual void OEEDMGLAILI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1288f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1827f, this.m_RotationRange.y * 591f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(413f, num, 1526f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 584f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1019f, this.m_RotationRange.x * 1311f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 414f);
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void DGGMJCMLLED()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x005BA89C File Offset: 0x005B8A9C
		protected virtual void BGNACIJEBON(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1322f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1112f, this.m_RotationRange.y * 951f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1794f, num, 564f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1538f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1113f, this.m_RotationRange.x * 1540f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 668f);
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x005BAA28 File Offset: 0x005B8C28
		protected virtual void FAHJFCEIKBE(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 115f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1432f, this.m_RotationRange.y * 630f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1005f, num, 27f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1187f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 80f, this.m_RotationRange.x * 536f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 183f);
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void OLBDJCFPKFG()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x005BABB4 File Offset: 0x005B8DB4
		protected virtual void OFOPANHHLHB(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 983f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 393f, this.m_RotationRange.y * 1374f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(516f, num, 1877f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 719f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1345f, this.m_RotationRange.x * 606f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1744f);
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x005BAD40 File Offset: 0x005B8F40
		protected virtual void DJPBNKDDKEI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 219f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1381f, this.m_RotationRange.y * 811f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1987f, num, 473f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 517f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1228f, this.m_RotationRange.x * 361f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1263f);
		}

		// Token: 0x0600CBFC RID: 52220 RVA: 0x005BAECC File Offset: 0x005B90CC
		protected virtual void FDOCDLDMPFF(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 43f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1530f, this.m_RotationRange.y * 766f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1307f, num, 652f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1389f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 257f, this.m_RotationRange.x * 793f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 65f);
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x005BB058 File Offset: 0x005B9258
		protected virtual void DMJMKCKHIOL(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1999f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1694f, this.m_RotationRange.y * 247f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(664f, num, 1021f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 117f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 699f, this.m_RotationRange.x * 407f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1079f);
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x005BB1E4 File Offset: 0x005B93E4
		protected virtual void ACCJCLHAMAC(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1158f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 111f, this.m_RotationRange.y * 788f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1958f, num, 132f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 462f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 685f, this.m_RotationRange.x * 1341f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1625f);
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void ADLHNBEDHMJ()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC00 RID: 52224 RVA: 0x005BB370 File Offset: 0x005B9570
		protected virtual void HGGPGEJNEND(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 162f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1213f, this.m_RotationRange.y * 1478f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1695f, num, 673f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1153f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 786f, this.m_RotationRange.x * 1834f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 971f);
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x005BB4FC File Offset: 0x005B96FC
		protected virtual void ONOLDHGHAKJ(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1523f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 609f, this.m_RotationRange.y * 233f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1381f, num, 1356f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1306f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 60f, this.m_RotationRange.x * 145f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1757f);
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void ANHOOJFEJJE()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void LBEFOABPMFG()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC04 RID: 52228 RVA: 0x005BB688 File Offset: 0x005B9888
		protected virtual void NEADHKMLJPP(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1619f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1998f, this.m_RotationRange.y * 344f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(639f, num, 1629f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1977f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 839f, this.m_RotationRange.x * 1632f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 212f);
		}

		// Token: 0x0600CC05 RID: 52229 RVA: 0x005BB814 File Offset: 0x005B9A14
		protected virtual void AHMDIINPJKD(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1457f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 784f, this.m_RotationRange.y * 865f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(943f, num, 956f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 824f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 53f, this.m_RotationRange.x * 1797f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1241f);
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void MCHAAIIHOKD()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x005BB9A0 File Offset: 0x005B9BA0
		protected virtual void IEGBHBKFCOM(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 198f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 329f, this.m_RotationRange.y * 999f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1154f, num, 565f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1438f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1436f, this.m_RotationRange.x * 1282f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1198f);
		}

		// Token: 0x0600CC08 RID: 52232 RVA: 0x005BBB2C File Offset: 0x005B9D2C
		protected virtual void KJFIIAKNHOA(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1924f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 590f, this.m_RotationRange.y * 1441f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1740f, num, 1178f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1713f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 158f, this.m_RotationRange.x * 680f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 540f);
		}

		// Token: 0x0600CC09 RID: 52233 RVA: 0x005BBCB8 File Offset: 0x005B9EB8
		protected virtual void ABLDNOGBHCF(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1667f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 23f, this.m_RotationRange.y * 637f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1198f, num, 269f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 371f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1738f, this.m_RotationRange.x * 586f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1627f);
		}

		// Token: 0x0600CC0A RID: 52234 RVA: 0x005BBE44 File Offset: 0x005BA044
		protected virtual void FMADKNDMOGB(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1329f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1130f, this.m_RotationRange.y * 1858f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(912f, num, 1364f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1006f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 823f, this.m_RotationRange.x * 490f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 66f);
		}

		// Token: 0x0600CC0B RID: 52235 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void JPHBPEAMNHB()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC0C RID: 52236 RVA: 0x005BBFD0 File Offset: 0x005BA1D0
		protected virtual void BAPGGLLKGJL(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1013f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1557f, this.m_RotationRange.y * 1482f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1833f, num, 1767f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1975f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 457f, this.m_RotationRange.x * 259f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1315f);
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x005BC15C File Offset: 0x005BA35C
		protected virtual void CLHLNNJHLFB(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 207f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1330f, this.m_RotationRange.y * 786f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1219f, num, 1283f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1387f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 167f, this.m_RotationRange.x * 1190f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 277f);
		}

		// Token: 0x0600CC0E RID: 52238 RVA: 0x005BC2E8 File Offset: 0x005BA4E8
		protected virtual void IBKOHKFGLPK(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1387f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 770f, this.m_RotationRange.y * 599f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(230f, num, 1150f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1012f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1555f, this.m_RotationRange.x * 394f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1750f);
		}

		// Token: 0x0600CC0F RID: 52239 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected override void Start()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC10 RID: 52240 RVA: 0x005BC474 File Offset: 0x005BA674
		protected virtual void PCICJNFPLCJ(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 138f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1020f, this.m_RotationRange.y * 1296f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(415f, num, 888f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1211f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 614f, this.m_RotationRange.x * 1950f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 394f);
		}

		// Token: 0x0600CC11 RID: 52241 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void ELFALPCLKIE()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC12 RID: 52242 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FCCAIANLEFE()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x005BC600 File Offset: 0x005BA800
		protected virtual void ACPMCGPPFJA(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1405f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 571f, this.m_RotationRange.y * 843f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(538f, num, 601f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 500f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1233f, this.m_RotationRange.x * 1219f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 392f);
		}

		// Token: 0x0600CC14 RID: 52244 RVA: 0x005BC78C File Offset: 0x005BA98C
		protected virtual void CDKDEKGIIAH(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 820f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1964f, this.m_RotationRange.y * 563f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(287f, num, 825f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 832f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 171f, this.m_RotationRange.x * 464f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 988f);
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void KEMGOLACEHI()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC17 RID: 52247 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void KGICJDGIIJK()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC18 RID: 52248 RVA: 0x005BC92C File Offset: 0x005BAB2C
		protected virtual void PBKHHKKGIBK(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1712f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 223f, this.m_RotationRange.y * 866f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(286f, num, 1212f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 650f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 725f, this.m_RotationRange.x * 1751f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1142f);
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void CGFDDFHECLJ()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x005BCAB8 File Offset: 0x005BACB8
		protected virtual void MKJJKGGFIDP(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 320f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1730f, this.m_RotationRange.y * 786f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(302f, num, 771f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 92f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 662f, this.m_RotationRange.x * 180f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1257f);
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void CLHGHANANNL()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FIJKDFIMELM()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x005BCC44 File Offset: 0x005BAE44
		protected virtual void DHMEPNIKEBE(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1198f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 84f, this.m_RotationRange.y * 396f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1099f, num, 1262f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1902f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1277f, this.m_RotationRange.x * 1966f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1810f);
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void NCALLFHEAGJ()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x005BCDD0 File Offset: 0x005BAFD0
		protected override void IJLMPHHOJIH(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 0.5f, this.m_RotationRange.y * 0.5f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(0f, num, 0f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 57.29578f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 0.5f, this.m_RotationRange.x * 0.5f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 0f);
		}

		// Token: 0x0600CC20 RID: 52256 RVA: 0x005BCF5C File Offset: 0x005BB15C
		protected virtual void OLCAIBGBCAG(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 649f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1785f, this.m_RotationRange.y * 990f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1821f, num, 654f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 3f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1092f, this.m_RotationRange.x * 1189f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1506f);
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x005BD0E8 File Offset: 0x005BB2E8
		protected virtual void NIIJHOPGHAA(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1858f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1098f, this.m_RotationRange.y * 1137f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(517f, num, 1312f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1162f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1043f, this.m_RotationRange.x * 961f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 814f);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x005BD274 File Offset: 0x005BB474
		protected virtual void GKKMADIBBCI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1192f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 982f, this.m_RotationRange.y * 1868f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1164f, num, 1787f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 882f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1227f, this.m_RotationRange.x * 1074f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1191f);
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x005BD400 File Offset: 0x005BB600
		protected virtual void DBFHDGILJHI(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1833f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1505f, this.m_RotationRange.y * 1957f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(701f, num, 665f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1827f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 177f, this.m_RotationRange.x * 1000f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 885f);
		}

		// Token: 0x0600CC24 RID: 52260 RVA: 0x005BD58C File Offset: 0x005BB78C
		protected virtual void OINKPAKPKJH(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1816f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 303f, this.m_RotationRange.y * 120f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1609f, num, 1294f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1916f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 266f, this.m_RotationRange.x * 886f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 82f);
		}

		// Token: 0x0600CC25 RID: 52261 RVA: 0x005BD718 File Offset: 0x005BB918
		protected virtual void ONIKMOIOJOP(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 291f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 127f, this.m_RotationRange.y * 1144f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(324f, num, 969f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1584f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 513f, this.m_RotationRange.x * 250f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1786f);
		}

		// Token: 0x0600CC26 RID: 52262 RVA: 0x005BD8A4 File Offset: 0x005BBAA4
		protected virtual void PLGOJCGELOK(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 747f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1309f, this.m_RotationRange.y * 1340f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1301f, num, 1138f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1127f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1784f, this.m_RotationRange.x * 1711f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 377f);
		}

		// Token: 0x0600CC27 RID: 52263 RVA: 0x005BDA30 File Offset: 0x005BBC30
		protected virtual void CNKBLOGMGMO(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 624f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1560f, this.m_RotationRange.y * 1329f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(208f, num, 723f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 671f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 142f, this.m_RotationRange.x * 1032f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 767f);
		}

		// Token: 0x0600CC28 RID: 52264 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void IJOCHELLKJH()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void PMDPLLIBJAF()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC2A RID: 52266 RVA: 0x005BDBBC File Offset: 0x005BBDBC
		protected virtual void HBIPEHHBHJF(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1544f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1968f, this.m_RotationRange.y * 128f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(959f, num, 1971f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1231f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1506f, this.m_RotationRange.x * 1261f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 406f);
		}

		// Token: 0x0600CC2B RID: 52267 RVA: 0x005BDD48 File Offset: 0x005BBF48
		protected virtual void OOPNPDBDNLJ(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1947f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1163f, this.m_RotationRange.y * 911f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1337f, num, 463f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1921f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1511f, this.m_RotationRange.x * 21f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1417f);
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void KJJNMNKPNCH()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void CGNGBFFGGBP()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x005BDED4 File Offset: 0x005BC0D4
		protected virtual void BNFEAINEOON(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 311f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 1682f, this.m_RotationRange.y * 1953f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1115f, num, 1252f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 617f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 932f, this.m_RotationRange.x * 713f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 259f);
		}

		// Token: 0x0600CC2F RID: 52271 RVA: 0x005BE060 File Offset: 0x005BC260
		protected virtual void LMOGGCEDOJN(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1027f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 15f, this.m_RotationRange.y * 449f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(325f, num, 1823f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 653f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1495f, this.m_RotationRange.x * 832f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 712f);
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void AOCDDBNBADJ()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x005BE1EC File Offset: 0x005BC3EC
		protected virtual void HMGKGAKCHHJ(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 213f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 324f, this.m_RotationRange.y * 1130f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1235f, num, 1716f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1503f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 636f, this.m_RotationRange.x * 1960f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1453f);
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void LPNDCJKAKEA()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void HHGGCBLOJGB()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC34 RID: 52276 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FECFLBMPAAL()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void LHHKDNILMDI()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x005BE378 File Offset: 0x005BC578
		protected virtual void EAOBOPAHGMG(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 687f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 228f, this.m_RotationRange.y * 706f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(151f, num, 155f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1038f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 401f, this.m_RotationRange.x * 1872f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1386f);
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x005BE504 File Offset: 0x005BC704
		protected virtual void DKJPOHGFPLN(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 419f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 125f, this.m_RotationRange.y * 867f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(1321f, num, 263f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1340f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 444f, this.m_RotationRange.x * 1688f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 682f);
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void PNAAHEFHPCL()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x005BE690 File Offset: 0x005BC890
		protected virtual void DNNEGJKKHGJ(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 797f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 545f, this.m_RotationRange.y * 216f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(405f, num, 1088f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 760f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 1213f, this.m_RotationRange.x * 143f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1059f);
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x005BE81C File Offset: 0x005BCA1C
		protected virtual void CHHJLJEAFLL(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 144f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 432f, this.m_RotationRange.y * 1028f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(7f, num, 1807f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1657f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 421f, this.m_RotationRange.x * 1470f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 1289f);
		}

		// Token: 0x0600CC3C RID: 52284 RVA: 0x005BE9A8 File Offset: 0x005BCBA8
		protected virtual void HIPIBFHHFIH(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 304f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 481f, this.m_RotationRange.y * 45f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(377f, num, 1423f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 759f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 553f, this.m_RotationRange.x * 836f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 243f);
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void BJHGPFGBFKF()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC3E RID: 52286 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void IMABGALEMBI()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC3F RID: 52287 RVA: 0x005B9DAD File Offset: 0x005B7FAD
		protected virtual void FJGIBCHABIG()
		{
			base.Start();
			this.CKLNEPEIBOM = base.transform.localRotation;
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x005BEB34 File Offset: 0x005BCD34
		protected virtual void LDBCEIOJIOC(float ENLHBNBNPJN)
		{
			base.transform.localRotation = this.CKLNEPEIBOM;
			Vector3 vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num = Mathf.Atan2(vector.x, vector.z) * 1624f;
			num = Mathf.Clamp(num, -this.m_RotationRange.y * 11f, this.m_RotationRange.y * 1876f);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(972f, num, 1445f);
			vector = base.transform.InverseTransformPoint(this.m_Target.position);
			float num2 = Mathf.Atan2(vector.y, vector.z) * 1304f;
			num2 = Mathf.Clamp(num2, -this.m_RotationRange.x * 697f, this.m_RotationRange.x * 364f);
			Vector3 target = new Vector3(this.LHACEHCDIGA.x + Mathf.DeltaAngle(this.LHACEHCDIGA.x, num2), this.LHACEHCDIGA.y + Mathf.DeltaAngle(this.LHACEHCDIGA.y, num));
			this.LHACEHCDIGA = Vector3.SmoothDamp(this.LHACEHCDIGA, target, ref this.KBEGOJGCLOF, this.m_FollowSpeed);
			base.transform.localRotation = this.CKLNEPEIBOM * Quaternion.Euler(-this.LHACEHCDIGA.x, this.LHACEHCDIGA.y, 163f);
		}

		// Token: 0x04001B10 RID: 6928
		[SerializeField]
		private Vector2 m_RotationRange;

		// Token: 0x04001B11 RID: 6929
		[SerializeField]
		private float m_FollowSpeed = 1f;

		// Token: 0x04001B12 RID: 6930
		private Vector3 LHACEHCDIGA;

		// Token: 0x04001B13 RID: 6931
		private Quaternion CKLNEPEIBOM;

		// Token: 0x04001B14 RID: 6932
		protected Vector3 KBEGOJGCLOF;
	}
}
