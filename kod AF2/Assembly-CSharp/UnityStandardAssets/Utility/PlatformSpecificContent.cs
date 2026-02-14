using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002DE RID: 734
	public class PlatformSpecificContent : MonoBehaviour
	{
		// Token: 0x0600AD3C RID: 44348 RVA: 0x004C1EF6 File Offset: 0x004C00F6
		private void JCJFFOLIONK()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.HLNMOKMIBLF(false);
				return;
			}
			this.ECKBMNPDLJD(true);
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x004C1F10 File Offset: 0x004C0110
		private void FLENJDPPMBK()
		{
			this.MKNPLOCGDJA();
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x004C1F18 File Offset: 0x004C0118
		private void HBBKFHNOBFE(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x004C1FDC File Offset: 0x004C01DC
		private void FLPMJFEGJLG()
		{
			this.MOKKOPGHAIL();
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x004C1FE4 File Offset: 0x004C01E4
		private void JFLJIDGAFIC()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.LFJOKHIJPEE(false);
				return;
			}
			this.HLNMOKMIBLF(true);
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x004C2000 File Offset: 0x004C0200
		private void KPHBAEOPKOK(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x004C20C4 File Offset: 0x004C02C4
		private void CAMFIPKKBBO(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x004C2188 File Offset: 0x004C0388
		private void NKFHOIOGBPL(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD44 RID: 44356 RVA: 0x004C224C File Offset: 0x004C044C
		private void GNGJAJIFMBO(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD45 RID: 44357 RVA: 0x004C2310 File Offset: 0x004C0510
		private void OnEnable()
		{
			this.OIOJMMAJGCI();
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x004C2318 File Offset: 0x004C0518
		private void PFFLFEMABGO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.JLCCGAOMOIC(false);
				return;
			}
			this.LCBOBBBKNPD(false);
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x004C2334 File Offset: 0x004C0534
		private void JPJINFDJICH(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x004C23F8 File Offset: 0x004C05F8
		private void FCNOHKBBPEI(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x004C24BC File Offset: 0x004C06BC
		private void DNPKJPPIHOO()
		{
			this.ECGHCLLBIPD();
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x004C24C4 File Offset: 0x004C06C4
		private void PMCOOOLDADA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x004C2588 File Offset: 0x004C0788
		private void LFJOKHIJPEE(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x004C264C File Offset: 0x004C084C
		private void IEHEAJJALNG()
		{
			this.KPDDLBFGIJL();
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x004C2654 File Offset: 0x004C0854
		private void IEFIMOKHOPL(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x004C2718 File Offset: 0x004C0918
		private void GDIJMKODCHB(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x004C27DC File Offset: 0x004C09DC
		private void FNHLKLJLDLL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.ICPJNNEEDHD(true);
				return;
			}
			this.FCNOHKBBPEI(false);
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x004C27F6 File Offset: 0x004C09F6
		private void LBKOIJKMCOL()
		{
			this.APJAFGBBNBO();
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x004C27FE File Offset: 0x004C09FE
		private void KFIBDJHDJJP()
		{
			this.IOPEMOBALPE();
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x004C2828 File Offset: 0x004C0A28
		private void IGGBPOCEDHP(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x004C28EC File Offset: 0x004C0AEC
		private void GBHLNKMMKKC()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.LCBDBIMIAEM(false);
				return;
			}
			this.LOHJEKBOAMI(false);
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x004C1F10 File Offset: 0x004C0110
		private void JOKAAEKICJK()
		{
			this.MKNPLOCGDJA();
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x004C2906 File Offset: 0x004C0B06
		private void MKJGDPHAHBG()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.LJJFOMAPDAA(true);
				return;
			}
			this.NEHHEEKMLJJ(true);
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x004C2920 File Offset: 0x004C0B20
		private void COPJDFAPIHE()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.PMCOOOLDADA(true);
				return;
			}
			this.FMMGPJEGCEP(false);
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x004C293C File Offset: 0x004C0B3C
		private void OEJFPGJKENA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x004C2A00 File Offset: 0x004C0C00
		private void KPLNKEJDFJF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.ABHAMDFDMEN(true);
				return;
			}
			this.FFNNHBANGBJ(false);
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x004C2A1A File Offset: 0x004C0C1A
		private void AKPLEHHPKGC()
		{
			this.CCEPAADFKJE();
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x004C2A24 File Offset: 0x004C0C24
		private void OHHKDHHIFHB(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x004C2AE8 File Offset: 0x004C0CE8
		private void KPDDLBFGIJL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.OJIPCNIGIKH(false);
				return;
			}
			this.IPMFGKDIIAI(false);
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x004C2B04 File Offset: 0x004C0D04
		private void ABHAMDFDMEN(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x004C2BC8 File Offset: 0x004C0DC8
		private void KINEKAAIGNF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.HLNMOKMIBLF(false);
				return;
			}
			this.IJOLECKMKJO(true);
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x004C2BE4 File Offset: 0x004C0DE4
		private void MKNJPEDNKAD(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x004C2CA8 File Offset: 0x004C0EA8
		private void CCEPAADFKJE()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.HCOMJFEAIDF(false);
				return;
			}
			this.ICPJNNEEDHD(false);
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x004C2CC4 File Offset: 0x004C0EC4
		private void JLCCGAOMOIC(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x004C2D88 File Offset: 0x004C0F88
		private void DGHJFBLKOAB(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x004C2E4C File Offset: 0x004C104C
		private void MEJAMIFNCGO()
		{
			this.DBPEAJADMLF();
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x004C2E54 File Offset: 0x004C1054
		private void LBHEKLAOOLJ()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.FMMGPJEGCEP(false);
				return;
			}
			this.NEHHEEKMLJJ(true);
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x004C2E6E File Offset: 0x004C106E
		private void FHFBFIKEPBL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.ECKBMNPDLJD(false);
				return;
			}
			this.LJJFOMAPDAA(true);
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x004C2E88 File Offset: 0x004C1088
		private void CFACLMMFEDN()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.IJOLECKMKJO(true);
				return;
			}
			this.OEJFPGJKENA(false);
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x004C2EA2 File Offset: 0x004C10A2
		private void MNACILNPKIO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.PMCOOOLDADA(false);
				return;
			}
			this.GDIJMKODCHB(true);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x004C2EBC File Offset: 0x004C10BC
		private void KJIJFBEALJH()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.LOHJEKBOAMI(true);
				return;
			}
			this.FCNOHKBBPEI(true);
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x004C2ED6 File Offset: 0x004C10D6
		private void IOPEMOBALPE()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.NMOFKFBJDEJ(false);
				return;
			}
			this.LFJOKHIJPEE(true);
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x004C2EF0 File Offset: 0x004C10F0
		private void OIOJMMAJGCI()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.HOGIDPMNHEG(false);
				return;
			}
			this.HOGIDPMNHEG(true);
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x004C2F0A File Offset: 0x004C110A
		private void PLLCHLCDKFA()
		{
			this.CFACLMMFEDN();
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x004C2F12 File Offset: 0x004C1112
		private void KCIGGANJGBP()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.JLCCGAOMOIC(false);
				return;
			}
			this.FLNMMPJIDPH(false);
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x004C2F2C File Offset: 0x004C112C
		private void JODENFCKOAF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.HOGIDPMNHEG(false);
				return;
			}
			this.ENONMIEHDPD(false);
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x004C2F46 File Offset: 0x004C1146
		private void BKFFDKDMDDN()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.DGHJFBLKOAB(true);
				return;
			}
			this.CGHDJPHLDCJ(true);
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x004C2F60 File Offset: 0x004C1160
		private void OLEJHMMLCNL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.JLCCGAOMOIC(false);
				return;
			}
			this.OJIPCNIGIKH(false);
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x004C2F7A File Offset: 0x004C117A
		private void APPOBIOMMPG()
		{
			this.DCPBCGFCBEM();
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x004C2F84 File Offset: 0x004C1184
		private void MLAPOGNOHGK(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x004C3048 File Offset: 0x004C1248
		private void ICHFBFJJAFL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.EMOODLFNGCA(false);
				return;
			}
			this.AEDLJNBDGBB(true);
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x004C3062 File Offset: 0x004C1262
		private void KHGOLBJDONH()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.NFPMAHJFCME(true);
				return;
			}
			this.BOHDEMGKOAA(false);
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x004C307C File Offset: 0x004C127C
		private void PCMLEOKHDLH()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.CGHDJPHLDCJ(false);
				return;
			}
			this.ECKBMNPDLJD(false);
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x004C3096 File Offset: 0x004C1296
		private void DBPEAJADMLF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.GNGJAJIFMBO(true);
				return;
			}
			this.HBBKFHNOBFE(true);
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x004C30B0 File Offset: 0x004C12B0
		private void EMOODLFNGCA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x004C3174 File Offset: 0x004C1374
		private void GNKOGKKONJI(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x004C3238 File Offset: 0x004C1438
		private void KLPHHNMKNGN()
		{
			this.PCMLEOKHDLH();
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x004C3240 File Offset: 0x004C1440
		private void LCBDBIMIAEM(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x004C3304 File Offset: 0x004C1504
		private void HBBAEDJNIFF()
		{
			this.EINJDPIJHGL();
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x004C330C File Offset: 0x004C150C
		private void APJAFGBBNBO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.FLNMMPJIDPH(true);
				return;
			}
			this.GDIJMKODCHB(true);
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x004C3326 File Offset: 0x004C1526
		private void BEGHNMJIHKN()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.CGHDJPHLDCJ(false);
				return;
			}
			this.IEFIMOKHOPL(true);
		}

		// Token: 0x0600AD7D RID: 44413 RVA: 0x004C3340 File Offset: 0x004C1540
		private void HOGIDPMNHEG(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD7E RID: 44414 RVA: 0x004C3404 File Offset: 0x004C1604
		private void FHPLPPPOPJF()
		{
			this.KHGOLBJDONH();
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x004C340C File Offset: 0x004C160C
		private void MPNHAGONKBG()
		{
			this.GGOHGGJFFGK();
		}

		// Token: 0x0600AD80 RID: 44416 RVA: 0x004C3414 File Offset: 0x004C1614
		private void LMKADIAIICK()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.CAMFIPKKBBO(true);
				return;
			}
			this.HBBKFHNOBFE(false);
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x004C3430 File Offset: 0x004C1630
		private void FLNMMPJIDPH(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x004C34F4 File Offset: 0x004C16F4
		private void LCBOBBBKNPD(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x004C35B8 File Offset: 0x004C17B8
		private void LJJFOMAPDAA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x004C3404 File Offset: 0x004C1604
		private void NFJKCBFCHBP()
		{
			this.KHGOLBJDONH();
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x004C367C File Offset: 0x004C187C
		private void GDCFOBBEBHF()
		{
			this.ADPCIGECKDM();
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x004C2E4C File Offset: 0x004C104C
		private void KEMDGOFKCOO()
		{
			this.DBPEAJADMLF();
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x004C3684 File Offset: 0x004C1884
		private void KBMDCCKCNIF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.HCOMJFEAIDF(true);
				return;
			}
			this.HLNMOKMIBLF(false);
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x004C369E File Offset: 0x004C189E
		private void ADPCIGECKDM()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.PMCOOOLDADA(true);
				return;
			}
			this.ANGBKLFMCDG(true);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x004C36B8 File Offset: 0x004C18B8
		private void NFPMAHJFCME(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x004C377C File Offset: 0x004C197C
		private void ECKBMNPDLJD(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x004C3840 File Offset: 0x004C1A40
		private void MAHIGHCDLHK(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x004C3904 File Offset: 0x004C1B04
		private void LIOBALIPHIE()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.BOHDEMGKOAA(true);
				return;
			}
			this.IEFIMOKHOPL(true);
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x004C391E File Offset: 0x004C1B1E
		private void KHBJLBOOBPL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.ENONMIEHDPD(false);
				return;
			}
			this.ENONMIEHDPD(false);
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x004C3938 File Offset: 0x004C1B38
		private void BIKPILOBGIE()
		{
			this.FHFBFIKEPBL();
		}

		// Token: 0x0600AD8F RID: 44431 RVA: 0x004C3940 File Offset: 0x004C1B40
		private void NEHHEEKMLJJ(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x004C3A04 File Offset: 0x004C1C04
		private void BOHDEMGKOAA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD91 RID: 44433 RVA: 0x004C3AC8 File Offset: 0x004C1CC8
		private void INEHANLJIEM()
		{
			this.KPLNKEJDFJF();
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x004C3AD0 File Offset: 0x004C1CD0
		private void EJPINHHNAFL(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x004C3B94 File Offset: 0x004C1D94
		private void ANGBKLFMCDG(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x004C3938 File Offset: 0x004C1B38
		private void MBGOKFGOGKM()
		{
			this.FHFBFIKEPBL();
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x004C3C58 File Offset: 0x004C1E58
		private void DKGAOLLKDPD()
		{
			this.MAAGEPKLHEO();
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x004C3C60 File Offset: 0x004C1E60
		private void DCPLMIMFNHG()
		{
			this.GBHLNKMMKKC();
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x004C3C68 File Offset: 0x004C1E68
		private void HHOJJINMMMA()
		{
			this.COPJDFAPIHE();
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x004C3C58 File Offset: 0x004C1E58
		private void KFLFNGGBAEB()
		{
			this.MAAGEPKLHEO();
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x004C3C70 File Offset: 0x004C1E70
		private void MAAGEPKLHEO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.ICPJNNEEDHD(true);
				return;
			}
			this.ICPJNNEEDHD(false);
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x004C3C8A File Offset: 0x004C1E8A
		private void ACCLHHPEHOD()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.LCBOBBBKNPD(false);
				return;
			}
			this.EJPINHHNAFL(true);
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x004C3CA4 File Offset: 0x004C1EA4
		private void BBDOHOKDBLO()
		{
			this.BAHJMMHCNNF();
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x004C3CAC File Offset: 0x004C1EAC
		private void MKNPLOCGDJA()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.HLNMOKMIBLF(false);
				return;
			}
			this.LOHJEKBOAMI(true);
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x004C1FDC File Offset: 0x004C01DC
		private void EKOENFCHNKL()
		{
			this.MOKKOPGHAIL();
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x004C3CC6 File Offset: 0x004C1EC6
		private void JFALIJPNCNL()
		{
			this.ICHFBFJJAFL();
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x004C3CD0 File Offset: 0x004C1ED0
		private void LPACDMGLJJN(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x004C3D94 File Offset: 0x004C1F94
		private void GICMHNKKECK()
		{
			this.OLEJHMMLCNL();
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x004C3D9C File Offset: 0x004C1F9C
		private void CLOCHMBGCAO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.ENONMIEHDPD(false);
				return;
			}
			this.FMMGPJEGCEP(true);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x004C3DB8 File Offset: 0x004C1FB8
		private void AEDLJNBDGBB(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x004C3E7C File Offset: 0x004C207C
		private void IJOLECKMKJO(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x004C3D94 File Offset: 0x004C1F94
		private void OLHGBCBHDBF()
		{
			this.OLEJHMMLCNL();
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x004C3F40 File Offset: 0x004C2140
		private void AAIPLMFBKIG()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.EJPINHHNAFL(true);
				return;
			}
			this.JKJHIKDNEJL(true);
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x004C3F5A File Offset: 0x004C215A
		private void KBNKFJPEFJB()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.EJPINHHNAFL(true);
				return;
			}
			this.LJJFOMAPDAA(true);
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x004C3F74 File Offset: 0x004C2174
		private void HKBPIIGLHGL()
		{
			this.LBHEKLAOOLJ();
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x004C3F7C File Offset: 0x004C217C
		private void GGOHGGJFFGK()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.PMCOOOLDADA(true);
				return;
			}
			this.OJIPCNIGIKH(true);
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x004C3F98 File Offset: 0x004C2198
		private void OJIPCNIGIKH(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x004C405C File Offset: 0x004C225C
		private void CGHDJPHLDCJ(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x004C4120 File Offset: 0x004C2320
		private void DCPBCGFCBEM()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.GDIJMKODCHB(false);
				return;
			}
			this.PMCOOOLDADA(true);
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x004C413C File Offset: 0x004C233C
		private void HCOMJFEAIDF(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x004C4200 File Offset: 0x004C2400
		private void ICPJNNEEDHD(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADAE RID: 44462 RVA: 0x004C42C4 File Offset: 0x004C24C4
		private void FFNNHBANGBJ(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADAF RID: 44463 RVA: 0x004C4388 File Offset: 0x004C2588
		private void BAHJMMHCNNF()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.GNGJAJIFMBO(true);
				return;
			}
			this.OHHKDHHIFHB(true);
		}

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x004C43A4 File Offset: 0x004C25A4
		private void HLNMOKMIBLF(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x004C4468 File Offset: 0x004C2668
		private void ENONMIEHDPD(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADB2 RID: 44466 RVA: 0x004C3304 File Offset: 0x004C1504
		private void OHPHJCGMNGD()
		{
			this.EINJDPIJHGL();
		}

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x004C452C File Offset: 0x004C272C
		private void MOKKOPGHAIL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.NEHHEEKMLJJ(true);
				return;
			}
			this.OJIPCNIGIKH(false);
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x004C4548 File Offset: 0x004C2748
		private void FMMGPJEGCEP(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x004C460C File Offset: 0x004C280C
		private void ACCPEPBNCKH()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.HOGIDPMNHEG(true);
				return;
			}
			this.LJJFOMAPDAA(true);
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x004C4628 File Offset: 0x004C2828
		private void JKJHIKDNEJL(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x004C3CC6 File Offset: 0x004C1EC6
		private void EHBCDGAIHND()
		{
			this.ICHFBFJJAFL();
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x004C46EC File Offset: 0x004C28EC
		private void HMHMGOKIIHO()
		{
			this.JFLJIDGAFIC();
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x004C46F4 File Offset: 0x004C28F4
		private void ECGHCLLBIPD()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.NMOFKFBJDEJ(false);
				return;
			}
			this.MGPIMEENKMA(false);
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x004C4710 File Offset: 0x004C2910
		private void FPNGPHANEAJ(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 0; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x004C47D4 File Offset: 0x004C29D4
		private void IPMFGKDIIAI(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				foreach (GameObject gameObject in this.m_Content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 1; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x004C4898 File Offset: 0x004C2A98
		private void ECCBAHMAECO()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.GDIJMKODCHB(false);
				return;
			}
			this.EMOODLFNGCA(true);
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x004C48B2 File Offset: 0x004C2AB2
		private void BMAODELKNPP()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Mobile)
			{
				this.HCOMJFEAIDF(true);
				return;
			}
			this.OJIPCNIGIKH(false);
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x004C48CC File Offset: 0x004C2ACC
		private void MGPIMEENKMA(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i++)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x004C4990 File Offset: 0x004C2B90
		private void LOHJEKBOAMI(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i += 0)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x004C2310 File Offset: 0x004C0510
		private void KGGJHGNEHGM()
		{
			this.OIOJMMAJGCI();
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x004C4A54 File Offset: 0x004C2C54
		private void NMOFKFBJDEJ(bool PMPMAALNEBO)
		{
			if (this.m_Content.Length != 0)
			{
				GameObject[] content = this.m_Content;
				for (int i = 1; i < content.Length; i += 0)
				{
					GameObject gameObject = content[i];
					if (gameObject != null)
					{
						gameObject.SetActive(PMPMAALNEBO);
					}
				}
			}
			if (this.m_ChildrenOfThisObject)
			{
				foreach (object obj in base.transform)
				{
					((Transform)obj).gameObject.SetActive(PMPMAALNEBO);
				}
			}
			if (this.m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = this.m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = PMPMAALNEBO;
				}
			}
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x004C4B18 File Offset: 0x004C2D18
		private void EINJDPIJHGL()
		{
			if (this.m_BuildTargetGroup == PlatformSpecificContent.IFJFPKKEHKC.Standalone)
			{
				this.ABHAMDFDMEN(false);
				return;
			}
			this.NEHHEEKMLJJ(false);
		}

		// Token: 0x04001615 RID: 5653
		[SerializeField]
		private PlatformSpecificContent.IFJFPKKEHKC m_BuildTargetGroup;

		// Token: 0x04001616 RID: 5654
		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		// Token: 0x04001617 RID: 5655
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		// Token: 0x04001618 RID: 5656
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		// Token: 0x020002DF RID: 735
		private enum IFJFPKKEHKC
		{
			// Token: 0x0400161A RID: 5658
			Standalone,
			// Token: 0x0400161B RID: 5659
			Mobile
		}
	}
}
