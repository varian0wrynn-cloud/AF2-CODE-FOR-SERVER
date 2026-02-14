using System;
using UnityEngine;
using UnityStandardAssets.Cameras;

namespace VolumetricFogAndMist
{
	// Token: 0x020002BD RID: 701
	public class DemoSurroundingFog : MonoBehaviour
	{
		// Token: 0x0600A505 RID: 42245 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void MCHAAIIHOKD()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x004A70D1 File Offset: 0x004A52D1
		private void HAIMGCDKPDC()
		{
			if (Input.GetKeyDown((KeyCode)18))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void AFFAJKPPMHF()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x004A70F8 File Offset: 0x004A52F8
		private void AHEAJPNHBBB()
		{
			Rect position = new Rect(244f, 495f, (float)(Screen.width - 113), 516f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "</color>");
				return;
			}
			GUI.Label(position, "TOD_LocalSunDirection");
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void HHGGCBLOJGB()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x004A7148 File Offset: 0x004A5348
		private void FJEEADNCKAG()
		{
			if (Input.GetKeyDown((KeyCode)(-1)))
			{
				this.PMMEFNKFJIA.enabled = this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x004A716C File Offset: 0x004A536C
		private void AIAMIFEPALP()
		{
			if (Input.GetKeyDown((KeyCode)82))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x004A7190 File Offset: 0x004A5390
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x004A71B4 File Offset: 0x004A53B4
		private void OnGUI()
		{
			Rect position = new Rect(10f, 10f, (float)(Screen.width - 20), 30f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "Move around with WASD keys. Press C to disable free look camera");
				return;
			}
			GUI.Label(position, "Move around with WASD keys. Press C to enable free look camera");
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x004A7204 File Offset: 0x004A5404
		private void OPDCJCFMIPE()
		{
			if (Input.GetKeyDown(KeyCode.Hash))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x004A7228 File Offset: 0x004A5428
		private void LPNFGGAKGID()
		{
			Rect position = new Rect(1081f, 928f, (float)(Screen.width - -7), 1008f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "ANTI_FLICKER");
				return;
			}
			GUI.Label(position, "</color>");
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x004A7278 File Offset: 0x004A5478
		private void LDDIGEMBDNF()
		{
			if (Input.GetKeyDown((KeyCode)71))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x004A729C File Offset: 0x004A549C
		private void JADGLEGEDGJ()
		{
			Rect position = new Rect(1926f, 1731f, (float)(Screen.width - 12), 1378f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "12");
				return;
			}
			GUI.Label(position, "ru-RU");
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void LMEJKAEIDCO()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x004A72EC File Offset: 0x004A54EC
		private void LBGKAMLLACN()
		{
			if (Input.GetKeyDown((KeyCode)(-8)))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x004A7310 File Offset: 0x004A5510
		private void BCJFDHBDAHD()
		{
			Rect position = new Rect(1722f, 1949f, (float)(Screen.width - 50), 1947f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "</color>");
				return;
			}
			GUI.Label(position, "root is null");
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x004A7360 File Offset: 0x004A5560
		private void LMMDHJJJNJO()
		{
			if (Input.GetKeyDown((KeyCode)83))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x004A7384 File Offset: 0x004A5584
		private void KMLNBHIIGKH()
		{
			if (Input.GetKeyDown((KeyCode)(-119)))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void Start()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x004A73A8 File Offset: 0x004A55A8
		private void HMEAENGBFKC()
		{
			if (Input.GetKeyDown((KeyCode)2))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x004A73CC File Offset: 0x004A55CC
		private void IGEICBNMPAD()
		{
			if (Input.GetKeyDown((KeyCode)1))
			{
				this.PMMEFNKFJIA.enabled = this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x004A73F0 File Offset: 0x004A55F0
		private void JPHLMNIMDHH()
		{
			if (Input.GetKeyDown(KeyCode.T))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x004A7414 File Offset: 0x004A5614
		private void CJHBCHBOLBI()
		{
			if (Input.GetKeyDown((KeyCode)(-124)))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x004A7438 File Offset: 0x004A5638
		private void CGBKGPPNMNM()
		{
			Rect position = new Rect(436f, 206f, (float)(Screen.width - 24), 412f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "}");
				return;
			}
			GUI.Label(position, "OneHandSwordReady");
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x004A7488 File Offset: 0x004A5688
		private void OBDAPPLCPMD()
		{
			Rect position = new Rect(1481f, 328f, (float)(Screen.width - 21), 399f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "Error");
				return;
			}
			GUI.Label(position, "Assets/Heads/whead_");
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x004A74D8 File Offset: 0x004A56D8
		private void BOAJJAKEMLH()
		{
			if (Input.GetKeyDown((KeyCode)72))
			{
				this.PMMEFNKFJIA.enabled = this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x004A74FC File Offset: 0x004A56FC
		private void PFPPDNHLCCA()
		{
			if (Input.GetKeyDown((KeyCode)5))
			{
				this.PMMEFNKFJIA.enabled = this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void CBLGFOFHNPJ()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x004A70C3 File Offset: 0x004A52C3
		private void BMNJGPIPKLL()
		{
			this.PMMEFNKFJIA = base.GetComponent<FreeLookCam>();
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x004A7520 File Offset: 0x004A5720
		private void GGOKNBBPLHB()
		{
			Rect position = new Rect(260f, 99f, (float)(Screen.width - 41), 1155f);
			if (this.PMMEFNKFJIA.enabled)
			{
				GUI.Label(position, "MotorbikeLassoRight");
				return;
			}
			GUI.Label(position, "");
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x004A7570 File Offset: 0x004A5770
		private void JLFBDOPFDDJ()
		{
			if (Input.GetKeyDown((KeyCode)(-51)))
			{
				this.PMMEFNKFJIA.enabled = this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x004A7594 File Offset: 0x004A5794
		private void AKLFCMNCPKL()
		{
			if (Input.GetKeyDown((KeyCode)(-77)))
			{
				this.PMMEFNKFJIA.enabled = !this.PMMEFNKFJIA.enabled;
			}
		}

		// Token: 0x04001511 RID: 5393
		private FreeLookCam PMMEFNKFJIA;
	}
}
