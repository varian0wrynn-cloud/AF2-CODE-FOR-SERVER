using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003E0 RID: 992
	public class CameraControllerFPS : MonoBehaviour
	{
		// Token: 0x0600D4F9 RID: 54521 RVA: 0x00610188 File Offset: 0x0060E388
		private float FEEHPLPBAKP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1372f)
			{
				NEPBPMGGPKM += 1515f;
			}
			if (NEPBPMGGPKM > 1868f)
			{
				NEPBPMGGPKM -= 676f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D4FA RID: 54522 RVA: 0x006101B4 File Offset: 0x0060E3B4
		public void JJMGNAMFJGJ()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("inner_craft_wpn") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.IKLLFHPEPPO(this.ADMFAEOOOHD - Input.GetAxis("Wrist") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D4FB RID: 54523 RVA: 0x00610248 File Offset: 0x0060E448
		private void PPNOJNBFHAP()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D4FC RID: 54524 RVA: 0x00610279 File Offset: 0x0060E479
		private float EGMOBKOPJLN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1036f)
			{
				NEPBPMGGPKM += 1285f;
			}
			if (NEPBPMGGPKM > 403f)
			{
				NEPBPMGGPKM -= 413f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x006102A8 File Offset: 0x0060E4A8
		private void CEBAOOAIADJ()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x006102DC File Offset: 0x0060E4DC
		private void OGKKCIOKGJE()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x0060FDB3 File Offset: 0x0060DFB3
		private float ILKJPHGKMEP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < -360f)
			{
				NEPBPMGGPKM += 360f;
			}
			if (NEPBPMGGPKM > 360f)
			{
				NEPBPMGGPKM -= 360f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D500 RID: 54528 RVA: 0x00610310 File Offset: 0x0060E510
		public void KIMKOEBBFKJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("Root Node bone is null, can not initiate the solver.") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.EGMOBKOPJLN(this.ADMFAEOOOHD - Input.GetAxis("Vertical") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x006103A4 File Offset: 0x0060E5A4
		private void HKLPGCKJEJK()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x006103D8 File Offset: 0x0060E5D8
		public void PMIFCKJAFEB()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("ObscuredInt vs int, ") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.ACBAJJFHBAO(this.ADMFAEOOOHD - Input.GetAxis(",") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D503 RID: 54531 RVA: 0x0061046C File Offset: 0x0060E66C
		public void OKFONGOBMCC()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("crft_cnt") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.NLJCCJHNFGP(this.ADMFAEOOOHD - Input.GetAxis("Root") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D504 RID: 54532 RVA: 0x006104FD File Offset: 0x0060E6FD
		private float MMCFGHDHKGO(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1414f)
			{
				NEPBPMGGPKM += 1983f;
			}
			if (NEPBPMGGPKM > 1345f)
			{
				NEPBPMGGPKM -= 1042f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D505 RID: 54533 RVA: 0x0061052C File Offset: 0x0060E72C
		private void CACBLLBNIJE()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D506 RID: 54534 RVA: 0x0061055D File Offset: 0x0060E75D
		private float KMPHGNNOALN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 356f)
			{
				NEPBPMGGPKM += 434f;
			}
			if (NEPBPMGGPKM > 241f)
			{
				NEPBPMGGPKM -= 1709f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D507 RID: 54535 RVA: 0x00610589 File Offset: 0x0060E789
		private float GAGCNGKHBIJ(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1308f)
			{
				NEPBPMGGPKM += 1232f;
			}
			if (NEPBPMGGPKM > 733f)
			{
				NEPBPMGGPKM -= 1894f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D508 RID: 54536 RVA: 0x006105B8 File Offset: 0x0060E7B8
		private void OLDFHDFAKDN()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D509 RID: 54537 RVA: 0x006105E9 File Offset: 0x0060E7E9
		private float BKABIAICJEP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 14f)
			{
				NEPBPMGGPKM += 418f;
			}
			if (NEPBPMGGPKM > 1078f)
			{
				NEPBPMGGPKM -= 1967f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D50A RID: 54538 RVA: 0x00610618 File Offset: 0x0060E818
		public void EIEKEPGNGPL()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("UIPCam_pos") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.GAGCNGKHBIJ(this.ADMFAEOOOHD - Input.GetAxis("Shader not found ({0})") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D50B RID: 54539 RVA: 0x006106AC File Offset: 0x0060E8AC
		private void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x006106DD File Offset: 0x0060E8DD
		private float IKLLFHPEPPO(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1707f)
			{
				NEPBPMGGPKM += 762f;
			}
			if (NEPBPMGGPKM > 1198f)
			{
				NEPBPMGGPKM -= 405f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x00610709 File Offset: 0x0060E909
		private float IADOIDBFBOH(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1752f)
			{
				NEPBPMGGPKM += 580f;
			}
			if (NEPBPMGGPKM > 362f)
			{
				NEPBPMGGPKM -= 1489f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D50E RID: 54542 RVA: 0x00610738 File Offset: 0x0060E938
		private void BLDELNFCEGB()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D50F RID: 54543 RVA: 0x00610769 File Offset: 0x0060E969
		private float KHMFPMNOINA(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1471f)
			{
				NEPBPMGGPKM += 939f;
			}
			if (NEPBPMGGPKM > 36f)
			{
				NEPBPMGGPKM -= 1148f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D510 RID: 54544 RVA: 0x00610798 File Offset: 0x0060E998
		private void BBEIKJGNAAA()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x006107CC File Offset: 0x0060E9CC
		private void NKHMBEDDFAJ()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x00610800 File Offset: 0x0060EA00
		public void DFNJNCCPKJF()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("_ColorBuffer") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.IANIMCPMIOJ(this.ADMFAEOOOHD - Input.GetAxis("iOS") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D513 RID: 54547 RVA: 0x00610891 File Offset: 0x0060EA91
		private float MBLBGFDJOME(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 124f)
			{
				NEPBPMGGPKM += 1828f;
			}
			if (NEPBPMGGPKM > 528f)
			{
				NEPBPMGGPKM -= 1357f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D514 RID: 54548 RVA: 0x006108BD File Offset: 0x0060EABD
		private float MDGEBLPFLBC(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1356f)
			{
				NEPBPMGGPKM += 1177f;
			}
			if (NEPBPMGGPKM > 660f)
			{
				NEPBPMGGPKM -= 1824f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x006108EC File Offset: 0x0060EAEC
		private void MBKLIKGAKJB()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D516 RID: 54550 RVA: 0x0061091D File Offset: 0x0060EB1D
		private float OEELNEDCKKB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 697f)
			{
				NEPBPMGGPKM += 1699f;
			}
			if (NEPBPMGGPKM > 1760f)
			{
				NEPBPMGGPKM -= 1670f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D517 RID: 54551 RVA: 0x00610949 File Offset: 0x0060EB49
		private float HFLECEDIELA(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 46f)
			{
				NEPBPMGGPKM += 1300f;
			}
			if (NEPBPMGGPKM > 1468f)
			{
				NEPBPMGGPKM -= 1394f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D518 RID: 54552 RVA: 0x00610978 File Offset: 0x0060EB78
		public void POCOKCJDCHK()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("Steam Overlay has been closed") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.AMDLNGBIGKB(this.ADMFAEOOOHD - Input.GetAxis("UNIQUE_SHADOW") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x00610A0C File Offset: 0x0060EC0C
		private void KHKDKMMHJBK()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x00610A40 File Offset: 0x0060EC40
		private void KOJNOPBGPAM()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x00610A74 File Offset: 0x0060EC74
		private void NPKEBODNBAI()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D51C RID: 54556 RVA: 0x00610AA8 File Offset: 0x0060ECA8
		private void CKPNKKFIINO()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x00610AD9 File Offset: 0x0060ECD9
		private float EMFLBNBKFJF(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 821f)
			{
				NEPBPMGGPKM += 1884f;
			}
			if (NEPBPMGGPKM > 782f)
			{
				NEPBPMGGPKM -= 1571f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x00610B05 File Offset: 0x0060ED05
		private float IELALGMNBGN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 555f)
			{
				NEPBPMGGPKM += 113f;
			}
			if (NEPBPMGGPKM > 1868f)
			{
				NEPBPMGGPKM -= 1302f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x00610B34 File Offset: 0x0060ED34
		private void ENJFBODNKHO()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D520 RID: 54560 RVA: 0x00610B65 File Offset: 0x0060ED65
		private float LNHHGPABLGI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 609f)
			{
				NEPBPMGGPKM += 456f;
			}
			if (NEPBPMGGPKM > 49f)
			{
				NEPBPMGGPKM -= 95f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x00610B94 File Offset: 0x0060ED94
		public void CODAMDJCPHK()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("GiantGrabIdle") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.LHEBAJLABMB(this.ADMFAEOOOHD - Input.GetAxis("CHROMATIC_ABERRATION") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D522 RID: 54562 RVA: 0x00610C25 File Offset: 0x0060EE25
		private float AMDLNGBIGKB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 119f)
			{
				NEPBPMGGPKM += 572f;
			}
			if (NEPBPMGGPKM > 1871f)
			{
				NEPBPMGGPKM -= 1231f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x00610C51 File Offset: 0x0060EE51
		private float CFJDNMHCGGJ(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1460f)
			{
				NEPBPMGGPKM += 210f;
			}
			if (NEPBPMGGPKM > 569f)
			{
				NEPBPMGGPKM -= 368f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x00610C7D File Offset: 0x0060EE7D
		private float HLMFFIFJDJI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 453f)
			{
				NEPBPMGGPKM += 693f;
			}
			if (NEPBPMGGPKM > 1343f)
			{
				NEPBPMGGPKM -= 710f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x00610CAC File Offset: 0x0060EEAC
		private void JMNLEBAPHNJ()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x00610CE0 File Offset: 0x0060EEE0
		private void AHILDBJHCKI()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x00610D14 File Offset: 0x0060EF14
		public void MKNDDFMIGDN()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("{0}KLIK_10.tif") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.IELALGMNBGN(this.ADMFAEOOOHD - Input.GetAxis("PrimaryCausticsProjector") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x00610DA8 File Offset: 0x0060EFA8
		public void BJILHFNDDKC()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("ForwardVelocity") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.ILKJPHGKMEP(this.ADMFAEOOOHD - Input.GetAxis("Water") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D529 RID: 54569 RVA: 0x00610E39 File Offset: 0x0060F039
		private float ACBAJJFHBAO(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1595f)
			{
				NEPBPMGGPKM += 749f;
			}
			if (NEPBPMGGPKM > 539f)
			{
				NEPBPMGGPKM -= 1408f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D52A RID: 54570 RVA: 0x00610E68 File Offset: 0x0060F068
		public void OIKMLNIPLIA()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("FrontKick") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.LHEBAJLABMB(this.ADMFAEOOOHD - Input.GetAxis("Office") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x00610EFC File Offset: 0x0060F0FC
		public void AEAPIKAENBD()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("Bip") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.LNHHGPABLGI(this.ADMFAEOOOHD - Input.GetAxis("1") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x00610F90 File Offset: 0x0060F190
		public void LateUpdate()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("Mouse X") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.ILKJPHGKMEP(this.ADMFAEOOOHD - Input.GetAxis("Mouse Y") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D52D RID: 54573 RVA: 0x00611021 File Offset: 0x0060F221
		private float HEMIDCDNFPD(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1737f)
			{
				NEPBPMGGPKM += 571f;
			}
			if (NEPBPMGGPKM > 1835f)
			{
				NEPBPMGGPKM -= 1586f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x00611050 File Offset: 0x0060F250
		private void GKJNOMMAAPO()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x00611084 File Offset: 0x0060F284
		private void OAKCEHBONIP()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D530 RID: 54576 RVA: 0x006110B8 File Offset: 0x0060F2B8
		public void CGNFLAOBEFN()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("gi_fs_itm") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.FEEHPLPBAKP(this.ADMFAEOOOHD - Input.GetAxis("_Color") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D531 RID: 54577 RVA: 0x0061114C File Offset: 0x0060F34C
		private void DKBGMIPBHNM()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D532 RID: 54578 RVA: 0x00611180 File Offset: 0x0060F380
		public void DBAELJBBKKF()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("wpn_ibsize_") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.HLMFFIFJDJI(this.ADMFAEOOOHD - Input.GetAxis("id") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D533 RID: 54579 RVA: 0x00611214 File Offset: 0x0060F414
		private void OGMACADJFIN()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D534 RID: 54580 RVA: 0x00611248 File Offset: 0x0060F448
		private void DJIFJMEEBKA()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D535 RID: 54581 RVA: 0x00611279 File Offset: 0x0060F479
		private float LHEBAJLABMB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1401f)
			{
				NEPBPMGGPKM += 676f;
			}
			if (NEPBPMGGPKM > 1266f)
			{
				NEPBPMGGPKM -= 809f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D536 RID: 54582 RVA: 0x006112A8 File Offset: 0x0060F4A8
		public void LOFKNDCJBMN()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("id") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.BKABIAICJEP(this.ADMFAEOOOHD - Input.GetAxis("FOVKick Increase curve is null, please define the curve for the field of view kicks") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x0061133C File Offset: 0x0060F53C
		public void OEKHPJAEAAE()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("knopje.wav") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.LHEBAJLABMB(this.ADMFAEOOOHD - Input.GetAxis(" ") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D538 RID: 54584 RVA: 0x006113CD File Offset: 0x0060F5CD
		private float NLJCCJHNFGP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 301f)
			{
				NEPBPMGGPKM += 1689f;
			}
			if (NEPBPMGGPKM > 1847f)
			{
				NEPBPMGGPKM -= 111f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D539 RID: 54585 RVA: 0x006113FC File Offset: 0x0060F5FC
		public void JIFIMFCJDHL()
		{
			Cursor.lockState = CursorLockMode.None;
			this.OCNGPCPMCPM += Input.GetAxis("quests/achivments_name/qd") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.NLJCCJHNFGP(this.ADMFAEOOOHD - Input.GetAxis("ragulaEventProc") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x0061148D File Offset: 0x0060F68D
		private float ALCEMOMGDAB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1899f)
			{
				NEPBPMGGPKM += 417f;
			}
			if (NEPBPMGGPKM > 479f)
			{
				NEPBPMGGPKM -= 1645f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x006114B9 File Offset: 0x0060F6B9
		private float BFMOFDLAMAK(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1771f)
			{
				NEPBPMGGPKM += 556f;
			}
			if (NEPBPMGGPKM > 1417f)
			{
				NEPBPMGGPKM -= 507f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D53D RID: 54589 RVA: 0x0061150E File Offset: 0x0060F70E
		private float IANIMCPMIOJ(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
		{
			if (NEPBPMGGPKM < 1133f)
			{
				NEPBPMGGPKM += 421f;
			}
			if (NEPBPMGGPKM > 1200f)
			{
				NEPBPMGGPKM -= 141f;
			}
			return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
		}

		// Token: 0x0600D53E RID: 54590 RVA: 0x0061153C File Offset: 0x0060F73C
		private void DPNNENHAGOE()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.OCNGPCPMCPM = eulerAngles.y;
			this.ADMFAEOOOHD = eulerAngles.x;
		}

		// Token: 0x0600D53F RID: 54591 RVA: 0x00611570 File Offset: 0x0060F770
		public void NGHOJBOHIBA()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.OCNGPCPMCPM += Input.GetAxis("move") * this.rotationSensitivity;
			this.ADMFAEOOOHD = this.NLJCCJHNFGP(this.ADMFAEOOOHD - Input.GetAxis("knopje.wav") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.OCNGPCPMCPM, Vector3.up) * Quaternion.AngleAxis(this.ADMFAEOOOHD, Vector3.right);
		}

		// Token: 0x04001C48 RID: 7240
		public float rotationSensitivity = 3f;

		// Token: 0x04001C49 RID: 7241
		public float yMinLimit = -89f;

		// Token: 0x04001C4A RID: 7242
		public float yMaxLimit = 89f;

		// Token: 0x04001C4B RID: 7243
		private float OCNGPCPMCPM;

		// Token: 0x04001C4C RID: 7244
		private float ADMFAEOOOHD;
	}
}
