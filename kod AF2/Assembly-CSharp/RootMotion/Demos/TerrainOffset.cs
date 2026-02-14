using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E3 RID: 995
	public class TerrainOffset : MonoBehaviour
	{
		// Token: 0x0600D5AC RID: 54700 RVA: 0x00612C38 File Offset: 0x00610E38
		private Vector3 MBGEJAAFFLB(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 156f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 24f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x00612CD8 File Offset: 0x00610ED8
		private void GHIJFOALMHM()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.KHCBGHHOKOL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1605f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x00612D8C File Offset: 0x00610F8C
		private void KPHGGOCHKFA()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DIJPODNOKHC(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 181f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x00612E40 File Offset: 0x00611040
		private void OFJPMLKIDEH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.KEIKOCOEHGB(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1395f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x00612EF4 File Offset: 0x006110F4
		private void OEFDEEOHNJB()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DEACILCAPDJ(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1133f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x00612FA8 File Offset: 0x006111A8
		private void MJFJPFJICDH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DPPEDIBPFPL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1511f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x0061305C File Offset: 0x0061125C
		private void BLOLJBHKGOH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.CPJBIIDFBDK(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1085f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x00613110 File Offset: 0x00611310
		private Vector3 CBJBPGCDCKM(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1024f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1171f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x006131B0 File Offset: 0x006113B0
		private void KCJNJBEJHFA()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.KHCBGHHOKOL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1989f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x00613264 File Offset: 0x00611464
		private Vector3 IKEBCAFCDIG(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1920f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 751f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x00613304 File Offset: 0x00611504
		private Vector3 PPKGFLNPAHH(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 977f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 161f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x006133A4 File Offset: 0x006115A4
		private Vector3 JOJEGNLKNLA(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 953f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 630f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x00613444 File Offset: 0x00611644
		private Vector3 MLEFPLDOBII(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1521f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1213f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5B9 RID: 54713 RVA: 0x006134E4 File Offset: 0x006116E4
		private Vector3 FHCDMJJACIK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1125f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 291f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5BA RID: 54714 RVA: 0x00613584 File Offset: 0x00611784
		private void NAECDBKLBLI()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.BOFFKMMLDLO(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1489f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x00613638 File Offset: 0x00611838
		private Vector3 JPPOLJGEAGB(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1641f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1037f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x006136D8 File Offset: 0x006118D8
		private void GIKJMPHFJKH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.IILAIBPMIDF(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 696f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x0061378C File Offset: 0x0061198C
		private void BHDPDDHLPOI()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.BHNDHPGODLK(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 855f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5BE RID: 54718 RVA: 0x00613840 File Offset: 0x00611A40
		private Vector3 OIFHBMEGHLL(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 2f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 2f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5BF RID: 54719 RVA: 0x006138E0 File Offset: 0x00611AE0
		private Vector3 ILOCLEMOOBK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1235f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 192f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x00613980 File Offset: 0x00611B80
		private void DJODHDNKIJE()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.FHCDMJJACIK(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 840f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x00613A34 File Offset: 0x00611C34
		private void HBKAEIJLKPM()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.MBGEJAAFFLB(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1333f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x00613AE8 File Offset: 0x00611CE8
		private Vector3 BHNDHPGODLK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1594f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1154f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5C3 RID: 54723 RVA: 0x00613B88 File Offset: 0x00611D88
		private void JPGFHBACEGG()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DPMPKEAFBAA(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1565f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x00613C3C File Offset: 0x00611E3C
		private void LateUpdate()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.OIFHBMEGHLL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 0f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x00613CF0 File Offset: 0x00611EF0
		private void CMDJHGMGLCG()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.EONOGFODGLG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1658f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x00613DA4 File Offset: 0x00611FA4
		private void PIEDGJCBCBO()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.JPPOLJGEAGB(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 389f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x00613E58 File Offset: 0x00612058
		private Vector3 FHMEEEGNPDF(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 235f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1106f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x00613EF8 File Offset: 0x006120F8
		private Vector3 DPENENJHIKO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1996f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1188f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x00613F98 File Offset: 0x00612198
		private Vector3 BJCOAGAEGKI(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1302f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1521f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x00614038 File Offset: 0x00612238
		private Vector3 PPIKFBOGHDD(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 467f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1669f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5CB RID: 54731 RVA: 0x006140D8 File Offset: 0x006122D8
		private Vector3 DIJPODNOKHC(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1539f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 750f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5CC RID: 54732 RVA: 0x00614178 File Offset: 0x00612378
		private void MJBLHNGLFOE()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DIJPODNOKHC(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 743f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x0061422C File Offset: 0x0061242C
		private Vector3 CPJBIIDFBDK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 526f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1131f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x006142CC File Offset: 0x006124CC
		private void EMMMEIGNPCH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.HKCGMABDEGG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 603f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x00614380 File Offset: 0x00612580
		private Vector3 KHCBGHHOKOL(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1114f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 184f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D0 RID: 54736 RVA: 0x00614420 File Offset: 0x00612620
		private void BDALGHGNCPE()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.OIFHBMEGHLL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1117f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5D1 RID: 54737 RVA: 0x006144D4 File Offset: 0x006126D4
		private Vector3 DOKCJILBGCF(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 839f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 878f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D2 RID: 54738 RVA: 0x00614574 File Offset: 0x00612774
		private void DBAELJBBKKF()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.HKCGMABDEGG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 528f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x00614628 File Offset: 0x00612828
		private Vector3 LLBJFGIHIJE(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1145f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 635f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D4 RID: 54740 RVA: 0x006146C8 File Offset: 0x006128C8
		private Vector3 AABBDLNNMOD(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 227f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1209f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D6 RID: 54742 RVA: 0x006147B8 File Offset: 0x006129B8
		private Vector3 HIOLHJNEOGO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 202f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 693f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x00614858 File Offset: 0x00612A58
		private Vector3 DLICDNMKOMO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 124f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 968f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x006148F8 File Offset: 0x00612AF8
		private Vector3 DEACILCAPDJ(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 792f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 958f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5D9 RID: 54745 RVA: 0x00614998 File Offset: 0x00612B98
		private Vector3 MDCDAALMILJ(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1260f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1983f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5DA RID: 54746 RVA: 0x00614A38 File Offset: 0x00612C38
		private void PPIFFLGOMHA()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DPENENJHIKO(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 732f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x00614AEC File Offset: 0x00612CEC
		private void OOGNHIIPHBH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.EDJFGGDANLH(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1271f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x00614BA0 File Offset: 0x00612DA0
		private void CFMIMGKFLBJ()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.LLBJFGIHIJE(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1489f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x00614C54 File Offset: 0x00612E54
		private Vector3 KEIKOCOEHGB(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 981f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 461f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x00614CF4 File Offset: 0x00612EF4
		private Vector3 PCPGJGJGFHK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 980f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 821f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x00614D94 File Offset: 0x00612F94
		private void DFLBAKCDEPB()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.MDCDAALMILJ(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1507f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x00614E48 File Offset: 0x00613048
		private void KIMKOEBBFKJ()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.MBGEJAAFFLB(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1863f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x00614EFC File Offset: 0x006130FC
		private Vector3 GJGNCDKFOOE(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 82f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 800f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x00614F9C File Offset: 0x0061319C
		private Vector3 JLIKGMPHFJM(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 17f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1459f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x0061503C File Offset: 0x0061323C
		private Vector3 OBBLHDAHAHE(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 820f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1516f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x006150DC File Offset: 0x006132DC
		private void BFLFPNNPOMC()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.GJGNCDKFOOE(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1905f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x00615190 File Offset: 0x00613390
		private void LHFBEKCIKOI()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.EDJFGGDANLH(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1921f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x00615244 File Offset: 0x00613444
		private Vector3 BOFFKMMLDLO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 487f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1195f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x006152E4 File Offset: 0x006134E4
		private void IMEDKJNAHKK()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.MEHNLMNFFFC(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 615f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x00615398 File Offset: 0x00613598
		private void NPDBHEONIDA()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.CPJBIIDFBDK(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1417f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x0061544C File Offset: 0x0061364C
		private Vector3 CPNPHDJKEPA(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 963f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1511f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x006154EC File Offset: 0x006136EC
		private void OKFONGOBMCC()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.NKKGFIDLEKG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1623f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x006155A0 File Offset: 0x006137A0
		private Vector3 EDJFGGDANLH(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1404f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 324f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x00615640 File Offset: 0x00613840
		private Vector3 MFEJDLLDNFM(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1995f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1765f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5ED RID: 54765 RVA: 0x006156E0 File Offset: 0x006138E0
		private Vector3 IILAIBPMIDF(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1840f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1671f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x00615780 File Offset: 0x00613980
		private Vector3 HDCHIAILLKD(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1566f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1329f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x00615820 File Offset: 0x00613A20
		private Vector3 LHJOOBPAAKC(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1066f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 351f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5F0 RID: 54768 RVA: 0x006158C0 File Offset: 0x00613AC0
		private void GFELHLPHCDN()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.MDCDAALMILJ(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 868f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x00615974 File Offset: 0x00613B74
		private Vector3 EONOGFODGLG(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1541f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 477f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x00615A14 File Offset: 0x00613C14
		private void HJDEGPKFBNI()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.OBBLHDAHAHE(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 369f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x00615AC8 File Offset: 0x00613CC8
		private void PMIFCKJAFEB()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.BOFFKMMLDLO(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1464f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x00615B7C File Offset: 0x00613D7C
		private Vector3 LJBEIDBDECK(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 745f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 806f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x00615C1C File Offset: 0x00613E1C
		private void BENCPPPLDIC()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.BHNDHPGODLK(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1533f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x00615CD0 File Offset: 0x00613ED0
		private void MLKCOBKDPCK()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.OBBLHDAHAHE(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1149f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x00615D84 File Offset: 0x00613F84
		private void KBKONONANKH()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.BOFFKMMLDLO(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1722f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x00615E38 File Offset: 0x00614038
		private void AEAPIKAENBD()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.JLIKGMPHFJM(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 257f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x00615EEC File Offset: 0x006140EC
		private Vector3 JKHKFKFMOBO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 491f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1031f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x00615F8C File Offset: 0x0061418C
		private Vector3 BJMPPINDCHF(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 768f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1734f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5FB RID: 54779 RVA: 0x0061602C File Offset: 0x0061422C
		private void GKNGOOCGMED()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.OIFHBMEGHLL(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 647f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D5FC RID: 54780 RVA: 0x006160E0 File Offset: 0x006142E0
		private Vector3 HKCGMABDEGG(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1302f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 558f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x00616180 File Offset: 0x00614380
		private Vector3 APPADCLDPEO(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1956f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1290f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5FE RID: 54782 RVA: 0x00616220 File Offset: 0x00614420
		private Vector3 DPMPKEAFBAA(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1671f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1498f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D5FF RID: 54783 RVA: 0x006162C0 File Offset: 0x006144C0
		private void AGCPGBGIHOP()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DOKCJILBGCF(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1072f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x00616374 File Offset: 0x00614574
		private void HFHGBPFDMGJ()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.HKCGMABDEGG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 292f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x00616428 File Offset: 0x00614628
		private Vector3 NKKGFIDLEKG(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 376f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1584f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D602 RID: 54786 RVA: 0x006164C8 File Offset: 0x006146C8
		private Vector3 DPPEDIBPFPL(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 231f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 294f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D603 RID: 54787 RVA: 0x00616568 File Offset: 0x00614768
		private Vector3 MEHNLMNFFFC(Vector3 JNFPCCIKFPP)
		{
			Debug.DrawRay(JNFPCCIKFPP, Vector3.down * this.raycastOffset.y * 1137f, Color.green);
			if (Physics.Raycast(JNFPCCIKFPP, Vector3.down, out this.CGAFKGPDBAD, this.raycastOffset.y * 1640f))
			{
				return Mathf.Clamp(this.CGAFKGPDBAD.point.y - base.transform.position.y, this.min, this.max) * Vector3.up;
			}
			return Vector3.zero;
		}

		// Token: 0x0600D604 RID: 54788 RVA: 0x00616608 File Offset: 0x00614808
		private void GEOHKEPJFCJ()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.HKCGMABDEGG(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 1018f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x006166BC File Offset: 0x006148BC
		private void MHJBMBPKHLB()
		{
			Vector3 vector = base.transform.rotation * this.raycastOffset;
			Vector3 b = this.DPENENJHIKO(base.transform.position + vector);
			this.IGFJOGKFADM = Vector3.Lerp(this.IGFJOGKFADM, b, Time.deltaTime * this.lerpSpeed);
			Vector3 vector2 = base.transform.position + new Vector3(vector.x, 71f, vector.z);
			this.aimIK.solver.transform.LookAt(vector2);
			this.aimIK.solver.IKPosition = vector2 + this.IGFJOGKFADM;
		}

		// Token: 0x04001C57 RID: 7255
		public AimIK aimIK;

		// Token: 0x04001C58 RID: 7256
		public Vector3 raycastOffset = new Vector3(0f, 2f, 1.5f);

		// Token: 0x04001C59 RID: 7257
		public LayerMask raycastLayers;

		// Token: 0x04001C5A RID: 7258
		public float min = -2f;

		// Token: 0x04001C5B RID: 7259
		public float max = 2f;

		// Token: 0x04001C5C RID: 7260
		public float lerpSpeed = 10f;

		// Token: 0x04001C5D RID: 7261
		private RaycastHit CGAFKGPDBAD;

		// Token: 0x04001C5E RID: 7262
		private Vector3 IGFJOGKFADM;
	}
}
