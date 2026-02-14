using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004BB RID: 1211
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x060107F5 RID: 67573 RVA: 0x0075A788 File Offset: 0x00758988
		protected virtual void BGFNOICCAGO()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1176f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 821f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 879f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 736f, 399f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 313f;
			if (this.FIJIONLENPK < 1824f)
			{
				this.poseRight.MCLLJAHGJLP(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.LBCOFBOKHJP(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107F6 RID: 67574 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void LPNDCJKAKEA()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107F7 RID: 67575 RVA: 0x0075A894 File Offset: 0x00758A94
		protected virtual void GCPENONAGDG()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 975f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1766f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1768f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 542f, 166f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1934f;
			if (this.FIJIONLENPK < 738f)
			{
				this.poseRight.OBDOALFIIFJ(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.OLDHFHGIPFC(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107F8 RID: 67576 RVA: 0x0075A988 File Offset: 0x00758B88
		protected virtual void MOBMBODBBPH()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1633f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 400f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1271f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 401f, 1848f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 756f;
			if (this.FIJIONLENPK < 1882f)
			{
				this.poseRight.IOLCGFHGABE(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.BHFEEDKLLHN(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107F9 RID: 67577 RVA: 0x0075AA7C File Offset: 0x00758C7C
		protected virtual void HALPFPKCLAP()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 794f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1328f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1927f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 243f, 743f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 552f;
			if (this.FIJIONLENPK < 1113f)
			{
				this.poseRight.EAHKLHPBEGN(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.OBDOALFIIFJ(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FA RID: 67578 RVA: 0x0075AB70 File Offset: 0x00758D70
		protected virtual void GEAKAHAAGIC()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1314f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 938f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1477f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 829f, 262f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1770f;
			if (this.FIJIONLENPK < 261f)
			{
				this.poseRight.BFDBMDPBJML(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.BKHIGJJNHAE(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FB RID: 67579 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void FIJKDFIMELM()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FC RID: 67580 RVA: 0x0075AC64 File Offset: 0x00758E64
		protected virtual void HNKCDCDLNJE()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1852f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 845f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1468f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1269f, 864f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1858f;
			if (this.FIJIONLENPK < 342f)
			{
				this.poseRight.DDLKHEECNKP(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.GDMKIGLFFDN(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FD RID: 67581 RVA: 0x0075AD58 File Offset: 0x00758F58
		protected virtual void FNBKENOCJKD()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1522f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 856f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1907f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1461f, 1026f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 971f;
			if (this.FIJIONLENPK < 1696f)
			{
				this.poseRight.BGFHABPGLFL(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.LBCOFBOKHJP(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FE RID: 67582 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void BJHGPFGBFKF()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x060107FF RID: 67583 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void OFGMIEJKMGC()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010800 RID: 67584 RVA: 0x0075AE4C File Offset: 0x0075904C
		protected virtual void DCBCEDCNECB()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1534f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1162f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1344f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1240f, 921f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 44f;
			if (this.FIJIONLENPK < 1524f)
			{
				this.poseRight.EAHKLHPBEGN(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.NHLICKJMGAA(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010801 RID: 67585 RVA: 0x0075AF40 File Offset: 0x00759140
		protected virtual void GEJALLDIDKK()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 546f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1225f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1339f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 114f, 474f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1111f;
			if (this.FIJIONLENPK < 1230f)
			{
				this.poseRight.GICGCANLCEI(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.OLDHFHGIPFC(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010802 RID: 67586 RVA: 0x0075B034 File Offset: 0x00759234
		protected virtual void JIGFBMPOGPP()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 963f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1157f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 753f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1297f, 744f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1096f;
			if (this.FIJIONLENPK < 1401f)
			{
				this.poseRight.OBDOALFIIFJ(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.JCPAHFMIFOO(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010803 RID: 67587 RVA: 0x0075B128 File Offset: 0x00759328
		protected virtual void MHKIHJKOJCE()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 172f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 109f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1623f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 89f, 1757f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 504f;
			if (this.FIJIONLENPK < 1062f)
			{
				this.poseRight.GDMKIGLFFDN(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.Apply(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010804 RID: 67588 RVA: 0x0075B21C File Offset: 0x0075941C
		protected virtual void EJMFGGFABMH()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1687f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 501f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1679f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1085f, 581f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 290f;
			if (this.FIJIONLENPK < 572f)
			{
				this.poseRight.NHLICKJMGAA(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.IADJMAKELDO(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010805 RID: 67589 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void OBJCOJEHLBE()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010806 RID: 67590 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void INDGOHJGCFN()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010807 RID: 67591 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void IAAOGAPJDID()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010808 RID: 67592 RVA: 0x0075B310 File Offset: 0x00759510
		protected virtual void EKJCBOPLALL()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1229f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1681f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 258f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 339f, 1172f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1709f;
			if (this.FIJIONLENPK < 287f)
			{
				this.poseRight.BGFHABPGLFL(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.JCPAHFMIFOO(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010809 RID: 67593 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080A RID: 67594 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected override void Start()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080B RID: 67595 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void KGICJDGIIJK()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080C RID: 67596 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void HDFCIACDDEK()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080D RID: 67597 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void DHJDMKLBLEF()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080E RID: 67598 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void EHFPLKEINFO()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601080F RID: 67599 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void DGEIACONKCJ()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010810 RID: 67600 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void NCALLFHEAGJ()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010811 RID: 67601 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void PFNPOHMMJDN()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010812 RID: 67602 RVA: 0x0075B404 File Offset: 0x00759604
		protected virtual void EFMJHLFNCJK()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1233f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1623f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1086f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1937f, 1431f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 455f;
			if (this.FIJIONLENPK < 1837f)
			{
				this.poseRight.KOCIIEKMNAN(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.GPAMMKENIAH(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010813 RID: 67603 RVA: 0x0075B4F8 File Offset: 0x007596F8
		protected virtual void MMEDEBFOHPB()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1867f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1691f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 178f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1545f, 337f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 564f;
			if (this.FIJIONLENPK < 1589f)
			{
				this.poseRight.LBCOFBOKHJP(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.GMNNHFOIBKI(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010814 RID: 67604 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void EFJDBBDMPMC()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010815 RID: 67605 RVA: 0x0075B5EC File Offset: 0x007597EC
		protected virtual void IMKHFLLACDF()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 731f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 780f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1865f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 600f, 143f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1519f;
			if (this.FIJIONLENPK < 253f)
			{
				this.poseRight.BKPANOKBAMC(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.MCLLJAHGJLP(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010817 RID: 67607 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void KKCFKEDABLB()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010818 RID: 67608 RVA: 0x0075B700 File Offset: 0x00759900
		protected override void HEHOBGDMLOK()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 0f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 0f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 0.01f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, -1f, 1f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1f;
			if (this.FIJIONLENPK < 0f)
			{
				this.poseRight.Apply(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.Apply(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010819 RID: 67609 RVA: 0x0075B7F4 File Offset: 0x007599F4
		protected virtual void MEPOMFMNCDE()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1821f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 300f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1623f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1043f, 279f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 185f;
			if (this.FIJIONLENPK < 1514f)
			{
				this.poseRight.OOCJDDBPLDJ(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.MCLLJAHGJLP(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081A RID: 67610 RVA: 0x0075B8E8 File Offset: 0x00759AE8
		protected virtual void GNADPAFAPKB()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1882f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 429f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 929f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 214f, 1349f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1282f;
			if (this.FIJIONLENPK < 567f)
			{
				this.poseRight.BOIHIFCKEKB(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.GDMKIGLFFDN(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081B RID: 67611 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void KEMGOLACEHI()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081C RID: 67612 RVA: 0x0075B9DC File Offset: 0x00759BDC
		protected virtual void DKHACOFGDLP()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1015f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1095f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 100f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 153f, 176f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 1911f;
			if (this.FIJIONLENPK < 464f)
			{
				this.poseRight.BJANDLJOHKI(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.OLDHFHGIPFC(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081D RID: 67613 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void CPNOBMNKPNC()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081E RID: 67614 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void JLKBMEBFHBI()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0601081F RID: 67615 RVA: 0x0075BAD0 File Offset: 0x00759CD0
		protected virtual void GLNLBLLLBBC()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1502f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 456f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 745f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1025f, 1525f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 533f;
			if (this.FIJIONLENPK < 148f)
			{
				this.poseRight.BHFEEDKLLHN(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.PMKCLBCPIDA(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010820 RID: 67616 RVA: 0x0075BBC4 File Offset: 0x00759DC4
		protected virtual void MLOBABEJJML()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1864f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 1858f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 1105f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 466f, 1109f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 746f;
			if (this.FIJIONLENPK < 1583f)
			{
				this.poseRight.GMNNHFOIBKI(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.BFDBMDPBJML(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010821 RID: 67617 RVA: 0x0075BCB8 File Offset: 0x00759EB8
		protected virtual void GJBKMIFPBPB()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.FMIDMNFMGCM, base.transform.forward);
			float num = 1079f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 509f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 673f;
			num /= base.ENLHBNBNPJN;
			num = Mathf.Clamp(num, 1212f, 804f);
			this.FIJIONLENPK = Mathf.Lerp(this.FIJIONLENPK, num, base.ENLHBNBNPJN * this.tiltSpeed);
			float nkhbajkmagd = Mathf.Abs(this.FIJIONLENPK) / 693f;
			if (this.FIJIONLENPK < 872f)
			{
				this.poseRight.JBNOIPHEGDP(this.ik.solver, nkhbajkmagd);
			}
			else
			{
				this.poseLeft.GICGCANLCEI(this.ik.solver, nkhbajkmagd);
			}
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x06010822 RID: 67618 RVA: 0x0075A87B File Offset: 0x00758A7B
		protected virtual void ANHOOJFEJJE()
		{
			base.Start();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x04002279 RID: 8825
		[Tooltip("Speed of tilting")]
		public float tiltSpeed = 6f;

		// Token: 0x0400227A RID: 8826
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity = 0.07f;

		// Token: 0x0400227B RID: 8827
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		// Token: 0x0400227C RID: 8828
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		// Token: 0x0400227D RID: 8829
		private float FIJIONLENPK;

		// Token: 0x0400227E RID: 8830
		private Vector3 FMIDMNFMGCM;
	}
}
