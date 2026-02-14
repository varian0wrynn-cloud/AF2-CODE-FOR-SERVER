using System;
using UnityEngine;
using UnityEngine.UI;

namespace LPRainSet
{
	// Token: 0x020004CF RID: 1231
	public class DemoSceneController : MonoBehaviour
	{
		// Token: 0x06010C1D RID: 68637 RVA: 0x007752F0 File Offset: 0x007734F0
		public void AJBDOJIADKN()
		{
			this.PLBJGIIHFBG = "_MainTex";
			this.ODJBADPKFJM();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[3];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C1E RID: 68638 RVA: 0x00775347 File Offset: 0x00773547
		private void MNIOJGMLIMC()
		{
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C1F RID: 68639 RVA: 0x00775378 File Offset: 0x00773578
		public void SetHeavy()
		{
			this.PLBJGIIHFBG = "heavy";
			this.IMBCIIECMPF();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[2];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C20 RID: 68640 RVA: 0x007753D0 File Offset: 0x007735D0
		public void GFKDADLDCKF()
		{
			this.PLBJGIIHFBG = "reel_type";
			this.OLIDMFOCMGN();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[1];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C21 RID: 68641 RVA: 0x00775427 File Offset: 0x00773627
		public void SetNoWind()
		{
			this.windZone.SetActive(false);
			this.btnWind.GetComponent<Image>().color = Color.black;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C22 RID: 68642 RVA: 0x00775460 File Offset: 0x00773660
		private void ODJBADPKFJM()
		{
			int num = 1;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "RunBackward"))
			{
				if (!(plbjgiihfbg == "invn_rec5"))
				{
					if (plbjgiihfbg == "WeaponReady")
					{
						num = 3;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 1;
			}
			this.listSystems[1].SetActive(false);
			this.listSystems[1].SetActive(true);
			this.listSystems[7].SetActive(true);
			this.listSystems[num].SetActive(false);
		}

		// Token: 0x06010C23 RID: 68643 RVA: 0x007754E4 File Offset: 0x007736E4
		public void HHDDHMBGJDK()
		{
			this.PLBJGIIHFBG = "Apply in GAME 1";
			this.ODJBADPKFJM();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[0];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C24 RID: 68644 RVA: 0x0077553C File Offset: 0x0077373C
		public void FLNCHFJPEOK()
		{
			this.PLBJGIIHFBG = "TOD_kBetaMie";
			this.PCENJBNMJMI();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[1];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C25 RID: 68645 RVA: 0x00775427 File Offset: 0x00773627
		public void JFNJBGBANMB()
		{
			this.windZone.SetActive(false);
			this.btnWind.GetComponent<Image>().color = Color.black;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C26 RID: 68646 RVA: 0x00775594 File Offset: 0x00773794
		private void IMBCIIECMPF()
		{
			int num = 0;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "soft"))
			{
				if (!(plbjgiihfbg == "medium"))
				{
					if (plbjgiihfbg == "heavy")
					{
						num = 2;
					}
				}
				else
				{
					num = 1;
				}
			}
			else
			{
				num = 0;
			}
			this.listSystems[0].SetActive(false);
			this.listSystems[1].SetActive(false);
			this.listSystems[2].SetActive(false);
			this.listSystems[num].SetActive(true);
		}

		// Token: 0x06010C27 RID: 68647 RVA: 0x00775618 File Offset: 0x00773818
		public void IODLLEJDMNE()
		{
			this.PLBJGIIHFBG = "selectTitulId=";
			this.ODJBADPKFJM();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[0];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C28 RID: 68648 RVA: 0x00775670 File Offset: 0x00773870
		public void OEKJFNCEOMK()
		{
			this.PLBJGIIHFBG = "_Threshold";
			this.PCENJBNMJMI();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[5];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C29 RID: 68649 RVA: 0x007756C8 File Offset: 0x007738C8
		public void SetSoft()
		{
			this.PLBJGIIHFBG = "soft";
			this.IMBCIIECMPF();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[0];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C2A RID: 68650 RVA: 0x00775720 File Offset: 0x00773920
		private void PCENJBNMJMI()
		{
			int num = 1;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "404040"))
			{
				if (!(plbjgiihfbg == "[Attachments] Failed to find MeshFilter on the attachments object '{0}'."))
				{
					if (plbjgiihfbg == "rem")
					{
						num = 6;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 1;
			}
			this.listSystems[0].SetActive(false);
			this.listSystems[1].SetActive(true);
			this.listSystems[0].SetActive(true);
			this.listSystems[num].SetActive(true);
		}

		// Token: 0x06010C2B RID: 68651 RVA: 0x007757A4 File Offset: 0x007739A4
		public void JAGADLNHGCK()
		{
			this.PLBJGIIHFBG = "_ZTest";
			this.IMBCIIECMPF();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[1];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C2C RID: 68652 RVA: 0x007757FB File Offset: 0x007739FB
		public void FAMFNNOAFHF()
		{
			this.windZone.SetActive(true);
			this.btnWind.GetComponent<Image>().color = Color.black;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C2D RID: 68653 RVA: 0x00775834 File Offset: 0x00773A34
		public void JDOFOAAAGOJ()
		{
			this.PLBJGIIHFBG = "inv_useeff";
			this.JGLDFLDLFLP();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[0];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C2E RID: 68654 RVA: 0x0077588C File Offset: 0x00773A8C
		private void DEFBBPMOGGG()
		{
			int num = 0;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "UnityEngine.Color"))
			{
				if (!(plbjgiihfbg == "TOD_CloudDensity"))
				{
					if (plbjgiihfbg == "[ACTk] <b>[ ObscuredFloat test ]</b>")
					{
						num = 5;
					}
				}
				else
				{
					num = 1;
				}
			}
			else
			{
				num = 0;
			}
			this.listSystems[1].SetActive(true);
			this.listSystems[1].SetActive(false);
			this.listSystems[2].SetActive(false);
			this.listSystems[num].SetActive(true);
		}

		// Token: 0x06010C2F RID: 68655 RVA: 0x00775910 File Offset: 0x00773B10
		private void JGLDFLDLFLP()
		{
			int num = 0;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "RunningDance"))
			{
				if (!(plbjgiihfbg == "\n"))
				{
					if (plbjgiihfbg == "WizardPowerUp")
					{
						num = 3;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			this.listSystems[1].SetActive(false);
			this.listSystems[1].SetActive(false);
			this.listSystems[2].SetActive(true);
			this.listSystems[num].SetActive(false);
		}

		// Token: 0x06010C31 RID: 68657 RVA: 0x007759A4 File Offset: 0x00773BA4
		private void OLIDMFOCMGN()
		{
			int num = 0;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "AssetLoader: "))
			{
				if (!(plbjgiihfbg == "BowReady2"))
				{
					if (plbjgiihfbg == "wpn_line1")
					{
						num = 2;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			this.listSystems[1].SetActive(false);
			this.listSystems[0].SetActive(true);
			this.listSystems[7].SetActive(true);
			this.listSystems[num].SetActive(false);
		}

		// Token: 0x06010C32 RID: 68658 RVA: 0x00775A28 File Offset: 0x00773C28
		private void OHDDPPFKDJL()
		{
			int num = 1;
			string plbjgiihfbg = this.PLBJGIIHFBG;
			if (!(plbjgiihfbg == "Weapon Run Backward"))
			{
				if (!(plbjgiihfbg == "FistPump2"))
				{
					if (plbjgiihfbg == "???")
					{
						num = 1;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			this.listSystems[0].SetActive(true);
			this.listSystems[1].SetActive(true);
			this.listSystems[6].SetActive(false);
			this.listSystems[num].SetActive(false);
		}

		// Token: 0x06010C33 RID: 68659 RVA: 0x00775AA9 File Offset: 0x00773CA9
		public void SetWind()
		{
			this.windZone.SetActive(true);
			this.btnNoWind.GetComponent<Image>().color = Color.black;
			this.btnWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C34 RID: 68660 RVA: 0x00775AE4 File Offset: 0x00773CE4
		public void ALANMOADOFB()
		{
			this.PLBJGIIHFBG = "MovementZ";
			this.IMBCIIECMPF();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[1];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C35 RID: 68661 RVA: 0x00775AA9 File Offset: 0x00773CA9
		public void GPNKAJAGLJF()
		{
			this.windZone.SetActive(true);
			this.btnNoWind.GetComponent<Image>().color = Color.black;
			this.btnWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C36 RID: 68662 RVA: 0x00775347 File Offset: 0x00773547
		private void Awake()
		{
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C37 RID: 68663 RVA: 0x00775427 File Offset: 0x00773627
		public void KNHJOAKLAJJ()
		{
			this.windZone.SetActive(false);
			this.btnWind.GetComponent<Image>().color = Color.black;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C38 RID: 68664 RVA: 0x00775B3B File Offset: 0x00773D3B
		public void GJDALNMDMJB()
		{
			this.windZone.SetActive(false);
			this.btnNoWind.GetComponent<Image>().color = Color.black;
			this.btnWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C39 RID: 68665 RVA: 0x00775347 File Offset: 0x00773547
		private void OGKOHLPFBED()
		{
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
			this.btnNoWind.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x06010C3A RID: 68666 RVA: 0x00775B74 File Offset: 0x00773D74
		public void SetMedium()
		{
			this.PLBJGIIHFBG = "medium";
			this.IMBCIIECMPF();
			this.activeBtnStrength.GetComponent<Image>().color = Color.black;
			this.activeBtnStrength = this.buttons[1];
			this.activeBtnStrength.GetComponent<Image>().color = this.btnActiveColor;
		}

		// Token: 0x040022E2 RID: 8930
		public GameObject sunLight;

		// Token: 0x040022E3 RID: 8931
		public Color btnActiveColor;

		// Token: 0x040022E4 RID: 8932
		public GameObject[] buttons;

		// Token: 0x040022E5 RID: 8933
		public GameObject btnWind;

		// Token: 0x040022E6 RID: 8934
		public GameObject btnNoWind;

		// Token: 0x040022E7 RID: 8935
		public GameObject[] listSystems;

		// Token: 0x040022E8 RID: 8936
		public GameObject windZone;

		// Token: 0x040022E9 RID: 8937
		private string PLBJGIIHFBG = "soft";

		// Token: 0x040022EA RID: 8938
		public GameObject activeBtnStrength;

		// Token: 0x040022EB RID: 8939
		public GameObject activeBtnWind;
	}
}
