using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003AC RID: 940
	public class FreeLookCam : PivotBasedCameraRig
	{
		// Token: 0x0600CB48 RID: 52040 RVA: 0x005B3940 File Offset: 0x005B1B40
		protected virtual void LBKPJAJJLBH()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB49 RID: 52041 RVA: 0x005B39B4 File Offset: 0x005B1BB4
		protected virtual void FDKGOFHFOLH()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB4A RID: 52042 RVA: 0x005B3A28 File Offset: 0x005B1C28
		private void AHICILHBFOP()
		{
			if (Time.timeScale < 920f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("RenderType");
			float num2 = CELBHNONENJ.LBBLPMHONLE("<b>Vector3:</b> ");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(645f, this.GCAEIBKGGBD, 1237f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1730f) ? Mathf.Lerp(647f, -this.m_TiltMin, num2) : Mathf.Lerp(408f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1203f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x005B3BAA File Offset: 0x005B1DAA
		protected void AAEFACEGJMB()
		{
			this.KBHAPCPDNOB();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x005B3BE1 File Offset: 0x005B1DE1
		protected void BOAJJAKEMLH()
		{
			this.FAKCOJFPMPI();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void GEBKKBCMIOM(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB4E RID: 52046 RVA: 0x005B3C58 File Offset: 0x005B1E58
		protected virtual void DJIFJMEEBKA()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB4F RID: 52047 RVA: 0x005B3CCC File Offset: 0x005B1ECC
		protected virtual void MBNCGMLPNLD()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB50 RID: 52048 RVA: 0x005B3D3E File Offset: 0x005B1F3E
		protected void LIOCDEICIFD()
		{
			this.HPEFCGNNKDP();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void PEKNHINKHCK()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void OOPNPDBDNLJ(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x005B3D84 File Offset: 0x005B1F84
		private void AKMOKJPAOHC()
		{
			if (Time.timeScale < 1232f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("#000000");
			float num2 = CELBHNONENJ.LBBLPMHONLE("repair.ogg");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(418f, this.GCAEIBKGGBD, 569f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1613f) ? Mathf.Lerp(1996f, -this.m_TiltMin, num2) : Mathf.Lerp(1372f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 777f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB54 RID: 52052 RVA: 0x005B3F06 File Offset: 0x005B2106
		protected void HMLNMHOMMNO()
		{
			this.DNCLCMPGOIJ();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void KMCACLNKBFP()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x005B3F4C File Offset: 0x005B214C
		protected virtual void ONPEGHFNMLK()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB57 RID: 52055 RVA: 0x005B3FBE File Offset: 0x005B21BE
		private void FPACOBGMBLM()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		// Token: 0x0600CB58 RID: 52056 RVA: 0x005B3FCC File Offset: 0x005B21CC
		protected virtual void DIENOIPCCDE()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB59 RID: 52057 RVA: 0x005B403E File Offset: 0x005B223E
		protected void MEFOGCFJBNE()
		{
			this.CNBGMGPEMLG();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x005B4075 File Offset: 0x005B2275
		protected void EGAEDOHFAJE()
		{
			this.FGLIEPMHDDC();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void FAHJFCEIKBE(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void JOENPDNEMKD(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x005B40AC File Offset: 0x005B22AC
		protected void LMMDHJJJNJO()
		{
			this.JFLMIJCIKON();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x005B40E4 File Offset: 0x005B22E4
		protected virtual void OGMACADJFIN()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB5F RID: 52063 RVA: 0x005B4156 File Offset: 0x005B2356
		protected void MIFLHGMPLJD()
		{
			this.FGLIEPMHDDC();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB60 RID: 52064 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void PHIACAJNNIG()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB61 RID: 52065 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void DCPLDAKDDBG()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB62 RID: 52066 RVA: 0x005B418D File Offset: 0x005B238D
		protected void GDBBAMFMKII()
		{
			this.AKMOKJPAOHC();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB63 RID: 52067 RVA: 0x005B41C4 File Offset: 0x005B23C4
		protected virtual void CCPOIOJPKIF()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB64 RID: 52068 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void IGEAHELKNOI(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB65 RID: 52069 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void PKOFOAMBJCH(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x005B4236 File Offset: 0x005B2436
		protected void IEOICHPKEMD()
		{
			this.EJCPOCNOFMP();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x005B4270 File Offset: 0x005B2470
		private void DNCLCMPGOIJ()
		{
			if (Time.timeScale < 1451f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("val=");
			float num2 = CELBHNONENJ.LBBLPMHONLE("id");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(731f, this.GCAEIBKGGBD, 81f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1021f) ? Mathf.Lerp(1265f, -this.m_TiltMin, num2) : Mathf.Lerp(390f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1190f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void OLCAIBGBCAG(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x005B43F4 File Offset: 0x005B25F4
		private void AKPICNLKAAP()
		{
			if (Time.timeScale < 315f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("wpn_rod2");
			float num2 = CELBHNONENJ.LBBLPMHONLE("WalkInjured");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1527f, this.GCAEIBKGGBD, 1780f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 930f) ? Mathf.Lerp(808f, -this.m_TiltMin, num2) : Mathf.Lerp(1950f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 4f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void LAOBJGDOJDH()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CB6B RID: 52075 RVA: 0x005B4578 File Offset: 0x005B2778
		private void JFLMIJCIKON()
		{
			if (Time.timeScale < 1914f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("Walk Injured");
			float num2 = CELBHNONENJ.LBBLPMHONLE("<color='#000030'>");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(39f, this.GCAEIBKGGBD, 1058f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1221f) ? Mathf.Lerp(859f, -this.m_TiltMin, num2) : Mathf.Lerp(1668f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 581f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x005B46FC File Offset: 0x005B28FC
		protected virtual void OBBMOJMEIEO()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x005B4770 File Offset: 0x005B2970
		private void ODHIPFODMKA()
		{
			if (Time.timeScale < 1086f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("signal_enable");
			float num2 = CELBHNONENJ.LBBLPMHONLE("KatanaReadyLow");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(416f, this.GCAEIBKGGBD, 1360f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 136f) ? Mathf.Lerp(1137f, -this.m_TiltMin, num2) : Mathf.Lerp(1878f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1507f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x005B4934 File Offset: 0x005B2B34
		private void CNBGMGPEMLG()
		{
			if (Time.timeScale < 940f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("BowInstant2");
			float num2 = CELBHNONENJ.LBBLPMHONLE("1HandHeavySwing2");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1111f, this.GCAEIBKGGBD, 1442f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1335f) ? Mathf.Lerp(188f, -this.m_TiltMin, num2) : Mathf.Lerp(1636f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1731f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void BIDOGNIGPED()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x005B4AB6 File Offset: 0x005B2CB6
		private void DJCLHHNFHHG()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void HMGKGAKCHHJ(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB73 RID: 52083 RVA: 0x005B4AC4 File Offset: 0x005B2CC4
		private void KBHAPCPDNOB()
		{
			if (Time.timeScale < 1298f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("https://groups.google.com/forum/#!forum/final-ik");
			float num2 = CELBHNONENJ.LBBLPMHONLE("Actor_{0}_{1}_ragula");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1096f, this.GCAEIBKGGBD, 1253f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1053f) ? Mathf.Lerp(1109f, -this.m_TiltMin, num2) : Mathf.Lerp(1262f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1416f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB74 RID: 52084 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void CHJKAJKKJHC(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB75 RID: 52085 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void DJPBNKDDKEI(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB76 RID: 52086 RVA: 0x005B4C48 File Offset: 0x005B2E48
		protected virtual void PFONEFANOIJ()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB77 RID: 52087 RVA: 0x005B4CBC File Offset: 0x005B2EBC
		protected override void Awake()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB78 RID: 52088 RVA: 0x005B4D30 File Offset: 0x005B2F30
		private void OOBBGEJBGCD()
		{
			if (Time.timeScale < 1735f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("===== ObscuredVector3Test =====\n");
			float num2 = CELBHNONENJ.LBBLPMHONLE("loc");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1804f, this.GCAEIBKGGBD, 335f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1283f) ? Mathf.Lerp(1280f, -this.m_TiltMin, num2) : Mathf.Lerp(1530f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 249f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x005B4EB4 File Offset: 0x005B30B4
		protected virtual void PJMCFJBFLIH()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x005B4F28 File Offset: 0x005B3128
		private void CFJGHCNACOA()
		{
			if (Time.timeScale < 541f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("Player");
			float num2 = CELBHNONENJ.LBBLPMHONLE("Hyperlink_");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1593f, this.GCAEIBKGGBD, 1244f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 303f) ? Mathf.Lerp(1011f, -this.m_TiltMin, num2) : Mathf.Lerp(144f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 985f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void DBFHDGILJHI(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x005B50AC File Offset: 0x005B32AC
		private void FGLIEPMHDDC()
		{
			if (Time.timeScale < 1058f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("PaperTurn.wav");
			float num2 = CELBHNONENJ.LBBLPMHONLE("StartTests");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1914f, this.GCAEIBKGGBD, 582f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1481f) ? Mathf.Lerp(331f, -this.m_TiltMin, num2) : Mathf.Lerp(995f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1506f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x005B5230 File Offset: 0x005B3430
		private void PKKKNFNNGAN()
		{
			if (Time.timeScale < 330f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE(",");
			float num2 = CELBHNONENJ.LBBLPMHONLE("BipedReferences contains one or more missing Transforms.");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(160f, this.GCAEIBKGGBD, 1703f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1664f) ? Mathf.Lerp(525f, -this.m_TiltMin, num2) : Mathf.Lerp(517f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 238f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void ALCOIPODLJI(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB7F RID: 52095 RVA: 0x005B53B2 File Offset: 0x005B35B2
		protected void PJHEGHHOJHJ()
		{
			this.HPEFCGNNKDP();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB80 RID: 52096 RVA: 0x005B3FBE File Offset: 0x005B21BE
		private void OnDisable()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x005B53EC File Offset: 0x005B35EC
		protected virtual void EEININLNBKJ()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void PBKHHKKGIBK(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void PLBMFJMPMKL()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void AHMDIINPJKD(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x005B545E File Offset: 0x005B365E
		protected void OFPGMNGFLNH()
		{
			this.FAKCOJFPMPI();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void IEGBHBKFCOM(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void KJFIIAKNHOA(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x005B5495 File Offset: 0x005B3695
		protected void LEHBKPPGHPC()
		{
			this.CNBGMGPEMLG();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x005B54CC File Offset: 0x005B36CC
		private void PBPJDKCAKFL()
		{
			if (Time.timeScale < 570f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("</color>");
			float num2 = CELBHNONENJ.LBBLPMHONLE("IdleBandage");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1107f, this.GCAEIBKGGBD, 1361f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 397f) ? Mathf.Lerp(257f, -this.m_TiltMin, num2) : Mathf.Lerp(513f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 951f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x005B5650 File Offset: 0x005B3850
		private void HPEFCGNNKDP()
		{
			if (Time.timeScale < 1244f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("SoccerSprint");
			float num2 = CELBHNONENJ.LBBLPMHONLE("inv_pcs1");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1524f, this.GCAEIBKGGBD, 1124f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 343f) ? Mathf.Lerp(1857f, -this.m_TiltMin, num2) : Mathf.Lerp(1774f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 99f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x005B57D4 File Offset: 0x005B39D4
		protected virtual void CJCGPPJADJL()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB8C RID: 52108 RVA: 0x005B5846 File Offset: 0x005B3A46
		protected void IGEICBNMPAD()
		{
			this.PKKKNFNNGAN();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = this.m_LockCursor;
			}
		}

		// Token: 0x0600CB8D RID: 52109 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void JKDCKHECHEJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB8E RID: 52110 RVA: 0x005B587D File Offset: 0x005B3A7D
		protected void HJCLNJLADKL()
		{
			this.BFIHHLLACKJ();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB8F RID: 52111 RVA: 0x005B58B4 File Offset: 0x005B3AB4
		protected virtual void HIBOODJBCIE()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB90 RID: 52112 RVA: 0x005B5928 File Offset: 0x005B3B28
		protected virtual void CKPNKKFIINO()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB91 RID: 52113 RVA: 0x005B599C File Offset: 0x005B3B9C
		protected virtual void MGNGNBMMAAD()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB92 RID: 52114 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void PBEIPLDPKOO(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB93 RID: 52115 RVA: 0x005B5A10 File Offset: 0x005B3C10
		private void ELLLGFGLJIJ()
		{
			if (Time.timeScale < 1941f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("RunJump");
			float num2 = CELBHNONENJ.LBBLPMHONLE("RoundHouse");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(983f, this.GCAEIBKGGBD, 656f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 541f) ? Mathf.Lerp(732f, -this.m_TiltMin, num2) : Mathf.Lerp(1932f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 54f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB94 RID: 52116 RVA: 0x005B5B94 File Offset: 0x005B3D94
		protected virtual void AOLBGAGHJDO()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void NOLGMGLINIJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x005B5C08 File Offset: 0x005B3E08
		protected virtual void GKJNOMMAAPO()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x005B3FBE File Offset: 0x005B21BE
		private void ACEEIODKKBE()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x005B4AB6 File Offset: 0x005B2CB6
		private void GDCAKFIINFI()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x005B5C7A File Offset: 0x005B3E7A
		protected void EKCKBDKEAKO()
		{
			this.OOBBGEJBGCD();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void HGGPGEJNEND(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void EHKCHPFDNCA()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void LLLBNNNNFPJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x005B5CB4 File Offset: 0x005B3EB4
		private void BFIHHLLACKJ()
		{
			if (Time.timeScale < 1023f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("SatNightFever");
			float num2 = CELBHNONENJ.LBBLPMHONLE("FactoryTempTexture");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1014f, this.GCAEIBKGGBD, 399f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 677f) ? Mathf.Lerp(1262f, -this.m_TiltMin, num2) : Mathf.Lerp(655f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 1501f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x005B5E38 File Offset: 0x005B4038
		private void EJCPOCNOFMP()
		{
			if (Time.timeScale < 1E-45f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("Mouse X");
			float num2 = CELBHNONENJ.LBBLPMHONLE("Mouse Y");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(0f, this.GCAEIBKGGBD, 0f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 0f) ? Mathf.Lerp(0f, -this.m_TiltMin, num2) : Mathf.Lerp(0f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 0f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected override void IJLMPHHOJIH(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x005B5FBC File Offset: 0x005B41BC
		protected virtual void AFALNDHNIKH()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void GPCIBDPEAAE()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x005B6030 File Offset: 0x005B4230
		protected virtual void EIOCCLJPLHN()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.None : CursorLockMode.None);
			Cursor.visible = this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void EMBFHJFCOAF(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x005B60A4 File Offset: 0x005B42A4
		private void CCMIGGPIMAP()
		{
			if (Time.timeScale < 632f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("_BlurVector");
			float num2 = CELBHNONENJ.LBBLPMHONLE("inv_auklotinf");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(755f, this.GCAEIBKGGBD, 10f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 288f) ? Mathf.Lerp(1284f, -this.m_TiltMin, num2) : Mathf.Lerp(1626f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 649f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void NJBEKBHCLIO()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x005B6228 File Offset: 0x005B4428
		protected virtual void HKLPGCKJEJK()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x005B629C File Offset: 0x005B449C
		private void ODBEGOHOMOI()
		{
			if (Time.timeScale < 1723f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("SecondaryCausticsProjector");
			float num2 = CELBHNONENJ.LBBLPMHONLE("WeaponRun");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1158f, this.GCAEIBKGGBD, 198f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 483f) ? Mathf.Lerp(1234f, -this.m_TiltMin, num2) : Mathf.Lerp(161f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 104f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x005B3C18 File Offset: 0x005B1E18
		protected virtual void LDBCEIOJIOC(float ENLHBNBNPJN)
		{
			if (this.m_Target == null)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, this.m_Target.position, ENLHBNBNPJN * this.m_MoveSpeed);
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x005B3D75 File Offset: 0x005B1F75
		private void HPGMKBPAFGM()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = true;
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x005B641E File Offset: 0x005B461E
		protected void Update()
		{
			this.EJCPOCNOFMP();
			if (this.m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x005B6455 File Offset: 0x005B4655
		protected void CBBLGEDCJBF()
		{
			this.JFLMIJCIKON();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x005B648C File Offset: 0x005B468C
		private void CEPCOHGAGLJ()
		{
			if (Time.timeScale < 1227f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("WATER_VERTEX_DISPLACEMENT_OFF");
			float num2 = CELBHNONENJ.LBBLPMHONLE("IdleSlide");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(418f, this.GCAEIBKGGBD, 1054f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 1743f) ? Mathf.Lerp(372f, -this.m_TiltMin, num2) : Mathf.Lerp(1358f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 938f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x005B6610 File Offset: 0x005B4810
		protected virtual void IOIJGMFNBMC()
		{
			base.Awake();
			Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
			Cursor.visible = !this.m_LockCursor;
			this.LGLLIEAIPAK = this.JBJCNGPGNHG.rotation.eulerAngles;
			this.LKIPPKJCIPN = this.JBJCNGPGNHG.transform.localRotation;
			this.OPFDLPACFIJ = base.transform.localRotation;
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x005B6684 File Offset: 0x005B4884
		private void FAKCOJFPMPI()
		{
			if (Time.timeScale < 37f)
			{
				return;
			}
			float num = CELBHNONENJ.LBBLPMHONLE("_MainTex");
			float num2 = CELBHNONENJ.LBBLPMHONLE("FOG_VOID_SPHERE");
			this.GCAEIBKGGBD += num * this.m_TurnSpeed;
			this.OPFDLPACFIJ = Quaternion.Euler(1440f, this.GCAEIBKGGBD, 738f);
			if (this.m_VerticalAutoReturn)
			{
				this.DDDOPACDBLM = ((num2 > 909f) ? Mathf.Lerp(409f, -this.m_TiltMin, num2) : Mathf.Lerp(1773f, this.m_TiltMax, -num2));
			}
			else
			{
				this.DDDOPACDBLM -= num2 * this.m_TurnSpeed;
				this.DDDOPACDBLM = Mathf.Clamp(this.DDDOPACDBLM, -this.m_TiltMin, this.m_TiltMax);
			}
			this.LKIPPKJCIPN = Quaternion.Euler(this.DDDOPACDBLM, this.LGLLIEAIPAK.y, this.LGLLIEAIPAK.z);
			if (this.m_TurnSmoothing > 721f)
			{
				this.JBJCNGPGNHG.localRotation = Quaternion.Slerp(this.JBJCNGPGNHG.localRotation, this.LKIPPKJCIPN, this.m_TurnSmoothing * Time.deltaTime);
				base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, this.OPFDLPACFIJ, this.m_TurnSmoothing * Time.deltaTime);
				return;
			}
			this.JBJCNGPGNHG.localRotation = this.LKIPPKJCIPN;
			base.transform.localRotation = this.OPFDLPACFIJ;
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x005B3F3D File Offset: 0x005B213D
		private void AOILKGIIKDF()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = false;
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x005B6806 File Offset: 0x005B4A06
		protected void OPDCJCFMIPE()
		{
			this.DNCLCMPGOIJ();
			if (this.m_LockCursor && Input.GetMouseButtonUp(1))
			{
				Cursor.lockState = (this.m_LockCursor ? CursorLockMode.Locked : CursorLockMode.Locked);
				Cursor.visible = !this.m_LockCursor;
			}
		}

		// Token: 0x04001AFF RID: 6911
		[SerializeField]
		private float m_MoveSpeed = 1f;

		// Token: 0x04001B00 RID: 6912
		[SerializeField]
		[Range(0f, 10f)]
		private float m_TurnSpeed = 1.5f;

		// Token: 0x04001B01 RID: 6913
		[SerializeField]
		private float m_TurnSmoothing = 0.1f;

		// Token: 0x04001B02 RID: 6914
		[SerializeField]
		private float m_TiltMax = 75f;

		// Token: 0x04001B03 RID: 6915
		[SerializeField]
		private float m_TiltMin = 45f;

		// Token: 0x04001B04 RID: 6916
		[SerializeField]
		private bool m_LockCursor;

		// Token: 0x04001B05 RID: 6917
		[SerializeField]
		private bool m_VerticalAutoReturn;

		// Token: 0x04001B06 RID: 6918
		private float GCAEIBKGGBD;

		// Token: 0x04001B07 RID: 6919
		private float DDDOPACDBLM;

		// Token: 0x04001B08 RID: 6920
		private const float OCBHMGCLJGN = 100f;

		// Token: 0x04001B09 RID: 6921
		private Vector3 LGLLIEAIPAK;

		// Token: 0x04001B0A RID: 6922
		private Quaternion LKIPPKJCIPN;

		// Token: 0x04001B0B RID: 6923
		private Quaternion OPFDLPACFIJ;
	}
}
