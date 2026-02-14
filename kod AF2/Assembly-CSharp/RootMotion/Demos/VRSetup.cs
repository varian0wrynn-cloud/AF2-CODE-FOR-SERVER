using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

namespace RootMotion.Demos
{
	// Token: 0x02000426 RID: 1062
	public class VRSetup : MonoBehaviour
	{
		// Token: 0x0600E57A RID: 58746 RVA: 0x00687654 File Offset: 0x00685854
		private void Awake()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
			Cursor.lockState = CursorLockMode.Locked;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 0f;
			}
		}

		// Token: 0x0600E57B RID: 58747 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool BLAOADCPHAG()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x006876BC File Offset: 0x006858BC
		private void MNIOJGMLIMC()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].SetActive(false);
			}
			Cursor.lockState = CursorLockMode.None;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 1867f;
			}
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool GPHNOGHKFGH()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x0068771C File Offset: 0x0068591C
		private void CMDJHGMGLCG()
		{
			if (Input.GetKeyDown((KeyCode)(-72)))
			{
				Application.Quit();
			}
			if (!this.EAMGCODKKDD && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown((KeyCode)(-96)))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].SetActive(true);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(false);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 149f;
				}
				this.IBENJNMABJF(true);
			}
		}

		// Token: 0x0600E580 RID: 58752 RVA: 0x006877FA File Offset: 0x006859FA
		private void GKGNCAIKIIK(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x006876B4 File Offset: 0x006858B4
		// (set) Token: 0x0600E599 RID: 58777 RVA: 0x006877FA File Offset: 0x006859FA
		public bool EAMGCODKKDD { get; private set; }

		// Token: 0x0600E582 RID: 58754 RVA: 0x006877FA File Offset: 0x006859FA
		private void LMDKDAIHFMD(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x006877FA File Offset: 0x006859FA
		private void GHALBCJPLCO(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E584 RID: 58756 RVA: 0x006877FA File Offset: 0x006859FA
		private void OHDCNGCKLMG(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E585 RID: 58757 RVA: 0x00687804 File Offset: 0x00685A04
		private void COOHBKKNOLG()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].SetActive(true);
			}
			Cursor.lockState = CursorLockMode.Locked;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 1190f;
			}
		}

		// Token: 0x0600E586 RID: 58758 RVA: 0x00687864 File Offset: 0x00685A64
		private void GPEFDPEAMNE()
		{
			if (Input.GetKeyDown((KeyCode)(-85)))
			{
				Application.Quit();
			}
			if (!this.JMOJEGBLMJO() && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown(KeyCode.Backslash))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].SetActive(false);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(false);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 1235f;
				}
				this.EAMGCODKKDD = true;
			}
		}

		// Token: 0x0600E587 RID: 58759 RVA: 0x00687944 File Offset: 0x00685B44
		private void CNKLGMCHEBM()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].SetActive(true);
			}
			Cursor.lockState = CursorLockMode.None;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 637f;
			}
		}

		// Token: 0x0600E588 RID: 58760 RVA: 0x006877FA File Offset: 0x006859FA
		private void IBENJNMABJF(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x006879A4 File Offset: 0x00685BA4
		private void OIKMLNIPLIA()
		{
			if (Input.GetKeyDown((KeyCode)86))
			{
				Application.Quit();
			}
			if (!this.GPHNOGHKFGH() && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown(KeyCode.None))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActive(false);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(true);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 818f;
				}
				this.FIBEFGKAFKB(true);
			}
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x006877FA File Offset: 0x006859FA
		private void MOBDBMBGGBJ(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool JEEBLFAPPDL()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E58C RID: 58764 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool JMOJEGBLMJO()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E58D RID: 58765 RVA: 0x006877FA File Offset: 0x006859FA
		private void CCDMFBOPLOD(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E58E RID: 58766 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool CLDJANJPCJC()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E58F RID: 58767 RVA: 0x00687A84 File Offset: 0x00685C84
		private void KCJNJBEJHFA()
		{
			if (Input.GetKeyDown((KeyCode)(-109)))
			{
				Application.Quit();
			}
			if (!this.GPHNOGHKFGH() && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown((KeyCode)17))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActive(true);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(true);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 325f;
				}
				this.LMDKDAIHFMD(true);
			}
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool LNHJINNIPGP()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x00687B64 File Offset: 0x00685D64
		private void LPDIHACCGKK()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
			Cursor.lockState = CursorLockMode.Locked;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 1460f;
			}
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x00687BC4 File Offset: 0x00685DC4
		private void AEAPIKAENBD()
		{
			if (Input.GetKeyDown((KeyCode)(-32)))
			{
				Application.Quit();
			}
			if (!this.EAMGCODKKDD && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown((KeyCode)26))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActive(false);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(false);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 1350f;
				}
				this.FIBEFGKAFKB(false);
			}
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x006877FA File Offset: 0x006859FA
		private void FIBEFGKAFKB(bool DCCPCBLODIG)
		{
			this.<INCPKFNJAJD>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool IHCLGIBCIPP()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x00687CA4 File Offset: 0x00685EA4
		private void CFHDJOKLHDB()
		{
			if (Input.GetKeyDown(KeyCode.H))
			{
				Application.Quit();
			}
			if (!this.IHCLGIBCIPP() && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown(KeyCode.DoubleQuote))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].SetActive(true);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(true);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 667f;
				}
				this.EAMGCODKKDD = true;
			}
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x00687D84 File Offset: 0x00685F84
		private void CFNLKNOKAGC()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].SetActive(true);
			}
			Cursor.lockState = CursorLockMode.Locked;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 369f;
			}
		}

		// Token: 0x0600E597 RID: 58775 RVA: 0x00687DE4 File Offset: 0x00685FE4
		private void DFNJNCCPKJF()
		{
			if (Input.GetKeyDown(KeyCode.Slash))
			{
				Application.Quit();
			}
			if (!this.EAMGCODKKDD && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown((KeyCode)(-107)))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].SetActive(false);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(true);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 1104f;
				}
				this.OHDCNGCKLMG(true);
			}
		}

		// Token: 0x0600E598 RID: 58776 RVA: 0x00687EC4 File Offset: 0x006860C4
		private void MBKLIKGAKJB()
		{
			GameObject[] array = this.enableOnR;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].SetActive(false);
			}
			Cursor.lockState = CursorLockMode.None;
			if (this.characterController != null)
			{
				this.ICFIMJIABFN = this.characterController.moveSpeed;
				this.characterController.moveSpeed = 1702f;
			}
		}

		// Token: 0x0600E59A RID: 58778 RVA: 0x00687F24 File Offset: 0x00686124
		private void LateUpdate()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
			if (!this.EAMGCODKKDD && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown(KeyCode.R))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActive(true);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(false);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 0.001f;
				}
				this.EAMGCODKKDD = true;
			}
		}

		// Token: 0x0600E59B RID: 58779 RVA: 0x00688004 File Offset: 0x00686204
		private void BLOLJBHKGOH()
		{
			if (Input.GetKeyDown((KeyCode)71))
			{
				Application.Quit();
			}
			if (!this.GPHNOGHKFGH() && this.characterController != null)
			{
				this.characterController.transform.rotation = Quaternion.identity;
			}
			if (Input.GetKeyDown((KeyCode)(-62)))
			{
				GameObject[] array = this.enableOnR;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].SetActive(true);
				}
				InputTracking.Recenter();
				this.text.gameObject.SetActive(false);
				if (this.characterController != null)
				{
					if (!this.disableMovement)
					{
						this.characterController.moveSpeed = this.ICFIMJIABFN;
					}
					this.characterController.transform.position += Vector3.up * 1671f;
				}
				this.MOBDBMBGGBJ(false);
			}
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x006876B4 File Offset: 0x006858B4
		public bool GKKLNBGJMFC()
		{
			return this.<INCPKFNJAJD>k__BackingField;
		}

		// Token: 0x04001DFC RID: 7676
		public Text text;

		// Token: 0x04001DFD RID: 7677
		public GameObject model;

		// Token: 0x04001DFE RID: 7678
		public GameObject[] enableOnR;

		// Token: 0x04001DFF RID: 7679
		public VRCharacterController characterController;

		// Token: 0x04001E00 RID: 7680
		public bool disableMovement;

		// Token: 0x04001E02 RID: 7682
		private float ICFIMJIABFN;
	}
}
