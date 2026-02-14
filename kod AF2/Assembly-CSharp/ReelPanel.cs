using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000180 RID: 384
public class ReelPanel : MonoBehaviour
{
	// Token: 0x06005471 RID: 21617 RVA: 0x00277E66 File Offset: 0x00276066
	public void FDDDBOKOLKG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("turn_tminfo", 139f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.KBAMNGNODEM();
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool PFFNDGDIFHP()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005473 RID: 21619 RVA: 0x00277EB0 File Offset: 0x002760B0
	public void LKMDKHEBKFH(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1436f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 2)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1667f;
			if (nhclmboinfg.magnitude > 906f)
			{
				num2 = LocNewLogic.getI.OBOMCIOILIB(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(1760f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(num2 / 921f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("wpn_eat8", 1079f);
		}
	}

	// Token: 0x06005474 RID: 21620 RVA: 0x00277FCC File Offset: 0x002761CC
	private void Update()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.openHelp();
		}
		this.mainPanel.gameObject.SetActive(!this.LHKKONIDPLP && flag);
		this.secondPanel.gameObject.SetActive(this.LHKKONIDPLP && flag);
		if (Input.GetKeyDown(KeyCode.F1) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.1f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(0f, 0f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1E-05f)
		{
			euler = new Vector3(0f, 0f, 1f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x06005475 RID: 21621 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool DGPBEMJIJCD()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005476 RID: 21622 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool BGOJDOFEGCO()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005477 RID: 21623 RVA: 0x00278173 File Offset: 0x00276373
	public void ILGIOKIAFJA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_NoiseScale", 643f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x06005478 RID: 21624 RVA: 0x0027819A File Offset: 0x0027639A
	public void PNCAECHEPKI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_Opacity", 768f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.OJKPLHEAHGK();
	}

	// Token: 0x06005479 RID: 21625 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool KLNDFBPBIPH()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x0600547A RID: 21626 RVA: 0x002781D6 File Offset: 0x002763D6
	public void AHLIPJMKJOA()
	{
		this.KNGBKMLLGND(!this.EIKHJKJBDMH());
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 330f);
	}

	// Token: 0x0600547B RID: 21627 RVA: 0x002781FC File Offset: 0x002763FC
	private void CDLDCKAHLHC()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.LDCGJNHNALJ();
		}
		this.mainPanel.gameObject.SetActive(this.MNFGJHBFKJG() && flag);
		this.secondPanel.gameObject.SetActive(this.HHHJCGMBHKH() && flag);
		if (Input.GetKeyDown((KeyCode)(-116)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("from prefab", 728f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1045f, 1218f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1546f)
		{
			euler = new Vector3(305f, 887f, 1899f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x0600547C RID: 21628 RVA: 0x002783A3 File Offset: 0x002765A3
	public void ADPOIGKPPMB(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x0600547D RID: 21629 RVA: 0x002783B0 File Offset: 0x002765B0
	private void MNAHGMDDHCA()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.openHelp();
		}
		this.mainPanel.gameObject.SetActive(this.POHGBLJCINE() && flag);
		this.secondPanel.gameObject.SetActive(this.GNBPEBKIIGN() && flag);
		if (Input.GetKeyDown((KeyCode)(-1)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("_DepthOfFieldParams", 1802f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(148f, 1734f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 803f)
		{
			euler = new Vector3(1314f, 1403f, 260f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x0600547E RID: 21630 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EHFPLKEINFO()
	{
	}

	// Token: 0x0600547F RID: 21631 RVA: 0x002783A3 File Offset: 0x002765A3
	public void KJOIILJIDEK(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x06005480 RID: 21632 RVA: 0x00278557 File Offset: 0x00276757
	public void GMBFPHDMBMI()
	{
		this.LHKKONIDPLP = this.BGOJDOFEGCO();
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("MotorbikeAirWalk", 1354f);
	}

	// Token: 0x06005481 RID: 21633 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool POHGBLJCINE()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005482 RID: 21634 RVA: 0x0027857C File Offset: 0x0027677C
	private void EDANNBFJHIK()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.ILGIOKIAFJA();
		}
		this.mainPanel.gameObject.SetActive(this.EPFBLCJHGGF() && flag);
		this.secondPanel.gameObject.SetActive(this.BBGLPOPEAKG() && flag);
		if (Input.GetKeyDown((KeyCode)(-67)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PistolLeftHandStab", 1729f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(242f, 1321f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1206f)
		{
			euler = new Vector3(834f, 599f, 589f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x06005483 RID: 21635 RVA: 0x002783A3 File Offset: 0x002765A3
	public void NLCINAAFLLB(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x06005484 RID: 21636 RVA: 0x00278723 File Offset: 0x00276923
	public void PALMHGCBFFN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("<color=\"#0287C8\"><b>Anti-Cheat Toolkit Sandbox</b></color>", 668f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
	}

	// Token: 0x06005485 RID: 21637 RVA: 0x002783A3 File Offset: 0x002765A3
	public void OGGPEIALJMD(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x06005486 RID: 21638 RVA: 0x00278760 File Offset: 0x00276960
	public void DLONAMFPBDJ(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1200f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 6)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1989f;
			if (nhclmboinfg.magnitude > 1200f)
			{
				num2 = LocNewLogic.getI.NEPOFBNILML(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(1641f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 1098f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("PistolInstant", 616f);
		}
	}

	// Token: 0x06005487 RID: 21639 RVA: 0x0027887C File Offset: 0x00276A7C
	private void CJHBCHBOLBI()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NOMCAKGCJPF();
		}
		this.mainPanel.gameObject.SetActive(!this.JBAENKCJJDE() && flag);
		this.secondPanel.gameObject.SetActive(this.JBAENKCJJDE() && flag);
		if (Input.GetKeyDown((KeyCode)(-83)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("L", 472f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1473f, 971f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 206f)
		{
			euler = new Vector3(1062f, 1653f, 711f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x06005488 RID: 21640 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool BBGLPOPEAKG()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005489 RID: 21641 RVA: 0x00278A23 File Offset: 0x00276C23
	public void KMHOOBJEFBJ()
	{
		this.LHKKONIDPLP = !this.PMNKDKGOJPO();
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("GiantGrabIdle", 1140f);
	}

	// Token: 0x0600548A RID: 21642 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool KDHOPPANFAN()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x0600548B RID: 21643 RVA: 0x00278A48 File Offset: 0x00276C48
	public void IDMBALEDINE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("HDR", 1047f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.ABHIJHKJPCC();
	}

	// Token: 0x0600548C RID: 21644 RVA: 0x002783A3 File Offset: 0x002765A3
	public void EHOKEHNGLMN(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x00278A84 File Offset: 0x00276C84
	public void EMBMJELKEAI()
	{
		this.NHMKMFMKHHO(this.JBAENKCJJDE());
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_FullResolutionFiltering", 311f);
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x00278AA9 File Offset: 0x00276CA9
	public void NOMECEGPDON()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("isFishOnRod", 1880f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.NHIFGPDIIAG();
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x00278AE5 File Offset: 0x00276CE5
	public void OCJEHJGDGCK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("error", 509f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HDGNIHBIEDG()
	{
	}

	// Token: 0x06005491 RID: 21649 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFNPOHMMJDN()
	{
	}

	// Token: 0x06005492 RID: 21650 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GMBPCGCCPDM()
	{
	}

	// Token: 0x06005493 RID: 21651 RVA: 0x00278B24 File Offset: 0x00276D24
	private void HMEAENGBFKC()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NOMCAKGCJPF();
		}
		this.mainPanel.gameObject.SetActive(this.EPFBLCJHGGF() && flag);
		this.secondPanel.gameObject.SetActive(this.MNFGJHBFKJG() && flag);
		if (Input.GetKeyDown((KeyCode)22) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("finger", 1413f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(599f, 662f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 454f)
		{
			euler = new Vector3(890f, 366f, 1421f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x00278CCB File Offset: 0x00276ECB
	public void ANNEHGIIAPL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_CameraWS", 1282f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x002783A3 File Offset: 0x002765A3
	public void LDMAPJECDLM(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x00278D07 File Offset: 0x00276F07
	public void EOLLBMNKIIP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Gloves", 637f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.MCKINAGLCFA();
	}

	// Token: 0x06005497 RID: 21655 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool INDAFHMODPE()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x06005498 RID: 21656 RVA: 0x00278D43 File Offset: 0x00276F43
	public void EPOKFPMEEEP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("languageid", 1501f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool EIKHJKJBDMH()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x00278D6A File Offset: 0x00276F6A
	public void KDIIDICADFE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("EventSystem", 576f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x00278D91 File Offset: 0x00276F91
	public void AHBCNNFHPMN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("defDur", 140f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x0600549C RID: 21660 RVA: 0x002783A3 File Offset: 0x002765A3
	public void COKFMGAICIO(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x0600549D RID: 21661 RVA: 0x00278DB8 File Offset: 0x00276FB8
	private void IEOICHPKEMD()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.PAHDBMHNNGB();
		}
		this.mainPanel.gameObject.SetActive(!this.ILLOPIOFKGH() && flag);
		this.secondPanel.gameObject.SetActive(this.GNBPEBKIIGN() && flag);
		if (Input.GetKeyDown((KeyCode)(-18)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("fishToSPEED=", 987f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(695f, 1144f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1264f)
		{
			euler = new Vector3(1376f, 235f, 99f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x0600549E RID: 21662 RVA: 0x00278F5F File Offset: 0x0027715F
	public void FNBPHDCEDGK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("FlyRight", 1349f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.MCKINAGLCFA();
	}

	// Token: 0x0600549F RID: 21663 RVA: 0x00278F9B File Offset: 0x0027719B
	public void DICPLFFCBPO()
	{
		this.AJCKGBLANFP(!this.KDHOPPANFAN());
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("name", 75f);
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNAAHEFHPCL()
	{
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x00278FC0 File Offset: 0x002771C0
	public void BJJPPBNMIBM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Up Hill Walk", 1707f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x00278FFC File Offset: 0x002771FC
	public void setPplDeep(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 9999f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 2)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 100f;
			if (nhclmboinfg.magnitude > 0.1f)
			{
				num2 = LocNewLogic.getI.getDeepInPointSM(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(30f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(num2 / 2f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("dianema.ogg", 0.5f);
		}
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x002783A3 File Offset: 0x002765A3
	public void GJINBBCNOIJ(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x00279118 File Offset: 0x00277318
	private void LBGKAMLLACN()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.openHelp();
		}
		this.mainPanel.gameObject.SetActive(this.BBGLPOPEAKG() && flag);
		this.secondPanel.gameObject.SetActive(this.KLNDFBPBIPH() && flag);
		if (Input.GetKeyDown((KeyCode)(-55)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("#02C85F", 996f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1189f, 384f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1661f)
		{
			euler = new Vector3(1850f, 255f, 144f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054A5 RID: 21669 RVA: 0x002792C0 File Offset: 0x002774C0
	private void LEHBKPPGHPC()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.LGBOMDNOALL();
		}
		this.mainPanel.gameObject.SetActive(!this.GNBPEBKIIGN() && flag);
		this.secondPanel.gameObject.SetActive(this.PFFNDGDIFHP() && flag);
		if (Input.GetKeyDown((KeyCode)84) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("droplinemsg1", 1925f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(286f, 1323f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 308f)
		{
			euler = new Vector3(1531f, 1626f, 1619f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x00279467 File Offset: 0x00277667
	public void closeHelp()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.7f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
	}

	// Token: 0x060054A7 RID: 21671 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool GNBPEBKIIGN()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054A8 RID: 21672 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLKBMEBFHBI()
	{
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x002794A3 File Offset: 0x002776A3
	public void ONBJBIKBBON()
	{
		this.MGFFKNOGHLI(this.ILLOPIOFKGH());
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Grain Lookup Texture", 545f);
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x002783A3 File Offset: 0x002765A3
	public void KDLNFHBPNFO(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x002794C8 File Offset: 0x002776C8
	public void NGHGOGLDBAK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("auc_wsbor", 1344f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054AC RID: 21676 RVA: 0x002794EF File Offset: 0x002776EF
	public void MJIEHKKGCPB()
	{
		this.KJOIILJIDEK(!this.GNBPEBKIIGN());
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("_HitTime", 1308f);
	}

	// Token: 0x060054AD RID: 21677 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOKJMMDMJNO()
	{
	}

	// Token: 0x060054AE RID: 21678 RVA: 0x00279514 File Offset: 0x00277714
	public void INPOLNDEKAP(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.FBLACLHFLGE();
			float num = 876f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 3)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 282f;
			if (nhclmboinfg.magnitude > 1838f)
			{
				num2 = LocNewLogic.getI.ODOLMAKHPAL(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(851f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 927f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("__b", 65f);
		}
	}

	// Token: 0x060054AF RID: 21679 RVA: 0x0027962D File Offset: 0x0027782D
	public void NOMCAKGCJPF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 845f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054B0 RID: 21680 RVA: 0x00279654 File Offset: 0x00277854
	public void GEKCLDOCPMP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("KatanaReady", 1239f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.GBHBPNDLCHJ();
	}

	// Token: 0x060054B1 RID: 21681 RVA: 0x00279690 File Offset: 0x00277890
	public void FEHOJHAEHIC()
	{
		this.COKFMGAICIO(!this.KEONAOPABHL());
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("MotorbikeTurnLeft", 56f);
	}

	// Token: 0x060054B2 RID: 21682 RVA: 0x002783A3 File Offset: 0x002765A3
	public void BIADBPJCJAD(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054B3 RID: 21683 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool KEONAOPABHL()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054B4 RID: 21684 RVA: 0x002796B5 File Offset: 0x002778B5
	public void ODHDLFMOFPI()
	{
		this.JADEDMBHGAC(!this.EPFBLCJHGGF());
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE(" ", 1083f);
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x002796DA File Offset: 0x002778DA
	public void PCEOENKDNBI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("val=", 817f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool HHHJCGMBHKH()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x00279718 File Offset: 0x00277918
	private void BOAJJAKEMLH()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.PAHDBMHNNGB();
		}
		this.mainPanel.gameObject.SetActive(!this.JBAENKCJJDE() && flag);
		this.secondPanel.gameObject.SetActive(this.EIKHJKJBDMH() && flag);
		if (Input.GetKeyDown(KeyCode.T) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("The space size '", 47f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(884f, 656f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 762f)
		{
			euler = new Vector3(1329f, 1188f, 1507f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BMNJGPIPKLL()
	{
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x002783A3 File Offset: 0x002765A3
	public void IECBBCFBHDA(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x002798BF File Offset: 0x00277ABF
	public void JBLPAGELCJP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("gi_tit_sel", 1829f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.HNPKHFHOCHP();
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x002798FB File Offset: 0x00277AFB
	public void NKIPOLOFBPM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("WeaponInstant", 999f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x00279924 File Offset: 0x00277B24
	public void BIIIICHIODF(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.FBLACLHFLGE();
			float num = 298f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 2)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1421f;
			if (nhclmboinfg.magnitude > 1924f)
			{
				num2 = LocNewLogic.getI.DNEOIPONBDH(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(413f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 1415f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("remWpn=", 729f);
		}
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x00279A3D File Offset: 0x00277C3D
	public void EFMFDKNNKDA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("crft_ingr", 1451f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x060054BF RID: 21695 RVA: 0x00279A64 File Offset: 0x00277C64
	public void PNAKBAIFDLI(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1914f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 4)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 216f;
			if (nhclmboinfg.magnitude > 830f)
			{
				num2 = LocNewLogic.getI.getDeepInPointSM(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(114f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(num2 / 1675f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("UIChat_pos", 1325f);
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x060054FE RID: 21758 RVA: 0x00277EA2 File Offset: 0x002760A2
	// (set) Token: 0x060054C0 RID: 21696 RVA: 0x002783A3 File Offset: 0x002765A3
	public bool LHKKONIDPLP
	{
		get
		{
			return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
		}
		set
		{
			HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = value;
		}
	}

	// Token: 0x060054C1 RID: 21697 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool JECIAPHOGCF()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x00279B7D File Offset: 0x00277D7D
	public void FLDNDFJJCHK()
	{
		this.KJOIILJIDEK(!this.BBGLPOPEAKG());
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("wpn_add/base", 1006f);
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x00279BA4 File Offset: 0x00277DA4
	public void BIKLBGGEBLG(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KKLEBEEGGDG();
			float num = 1589f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 6)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1223f;
			if (nhclmboinfg.magnitude > 1904f)
			{
				num2 = LocNewLogic.getI.ODOLMAKHPAL(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(1977f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 1318f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("SoccerKeeperReady", 1313f);
		}
	}

	// Token: 0x060054C4 RID: 21700 RVA: 0x00279CBD File Offset: 0x00277EBD
	public void openHelp()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.7f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LPNDCJKAKEA()
	{
	}

	// Token: 0x060054C7 RID: 21703 RVA: 0x00279CF7 File Offset: 0x00277EF7
	public void OGDBMHAMEND()
	{
		this.GJINBBCNOIJ(!this.HHHJCGMBHKH());
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("shop_t2", 458f);
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x00279D1C File Offset: 0x00277F1C
	public void EPBIMOHAKHF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("condAnchor", 478f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x00279D44 File Offset: 0x00277F44
	private void PGIHAIPCJLL()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NOMCAKGCJPF();
		}
		this.mainPanel.gameObject.SetActive(this.INDAFHMODPE() && flag);
		this.secondPanel.gameObject.SetActive(this.PFFNDGDIFHP() && flag);
		if (Input.GetKeyDown(KeyCode.S) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("post_13", 1557f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1660f, 1850f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1713f)
		{
			euler = new Vector3(81f, 575f, 114f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x002783A3 File Offset: 0x002765A3
	public void HMEDPPENKCJ(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x00279EEC File Offset: 0x002780EC
	private void GPCKACGEILI()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.ILGIOKIAFJA();
		}
		this.mainPanel.gameObject.SetActive(this.PFFNDGDIFHP() && flag);
		this.secondPanel.gameObject.SetActive(this.POHGBLJCINE() && flag);
		if (Input.GetKeyDown((KeyCode)160) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Idle Come Here", 1578f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(717f, 224f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 938f)
		{
			euler = new Vector3(465f, 470f, 211f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x0027A094 File Offset: 0x00278294
	public void NAAOAFGKCPI(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1073f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 6)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 357f;
			if (nhclmboinfg.magnitude > 804f)
			{
				num2 = LocNewLogic.getI.CFGNHLDNAAJ(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(1667f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 47f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("knopje.wav", 1202f);
		}
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MAGJOJDOGKH()
	{
	}

	// Token: 0x060054CE RID: 21710 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool PMNKDKGOJPO()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054CF RID: 21711 RVA: 0x0027A1B0 File Offset: 0x002783B0
	private void KMLNBHIIGKH()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NGHGOGLDBAK();
		}
		this.mainPanel.gameObject.SetActive(this.JECIAPHOGCF() && flag);
		this.secondPanel.gameObject.SetActive(this.ILLOPIOFKGH() && flag);
		if (Input.GetKeyDown((KeyCode)(-85)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("12", 1223f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1629f, 269f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 657f)
		{
			euler = new Vector3(601f, 1456f, 697f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x0027A358 File Offset: 0x00278558
	public void JOBGBNCIMDC(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.FBLACLHFLGE();
			float num = 1144f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 6)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1545f;
			if (nhclmboinfg.magnitude > 1319f)
			{
				num2 = LocNewLogic.getI.getDeepInPointSM(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(1037f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 370f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("Ring", 524f);
		}
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x002783A3 File Offset: 0x002765A3
	public void JADEDMBHGAC(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x0027A471 File Offset: 0x00278671
	public void FGONMNKHOPI()
	{
		this.OJFCFANJMPL(this.ILLOPIOFKGH());
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("isMove", 1736f);
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool JBAENKCJJDE()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x002783A3 File Offset: 0x002765A3
	public void NHMKMFMKHHO(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054D5 RID: 21717 RVA: 0x0027A496 File Offset: 0x00278696
	public void JLEOIPLIPBG()
	{
		this.KDLNFHBPNFO(this.EIKHJKJBDMH());
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("change me!", 149f);
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x002783A3 File Offset: 0x002765A3
	public void MGFFKNOGHLI(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054D7 RID: 21719 RVA: 0x0027A4BB File Offset: 0x002786BB
	public void HKJPELKMLJA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA(" ms", 878f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x060054D8 RID: 21720 RVA: 0x0027A4E4 File Offset: 0x002786E4
	public void EGPFPFHKIPG(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KKLEBEEGGDG();
			float num = 1589f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 1)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1283f;
			if (nhclmboinfg.magnitude > 421f)
			{
				num2 = LocNewLogic.getI.CFGNHLDNAAJ(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(1812f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(num2 / 1121f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("post_4", 936f);
		}
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x0027A600 File Offset: 0x00278800
	public void DFEGGADLCHI(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 972f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 7)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 290f;
			if (nhclmboinfg.magnitude > 752f)
			{
				num2 = LocNewLogic.getI.DNEOIPONBDH(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(15f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 1652f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("OneHandSwordIdle", 749f);
		}
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x0027A71C File Offset: 0x0027891C
	private void HCDJABMBDFF()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.MPDHMBKIIOO();
		}
		this.mainPanel.gameObject.SetActive(this.GNBPEBKIIGN() && flag);
		this.secondPanel.gameObject.SetActive(this.BGOJDOFEGCO() && flag);
		if (Input.GetKeyDown((KeyCode)(-90)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("wpn_add/base", 1712f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(654f, 806f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 81f)
		{
			euler = new Vector3(1939f, 1065f, 1628f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool ILLOPIOFKGH()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x0027A8C3 File Offset: 0x00278AC3
	public void flipPanel()
	{
		this.LHKKONIDPLP = !this.LHKKONIDPLP;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x0027A8E8 File Offset: 0x00278AE8
	public void GBOIIPGDHOF(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1420f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 6)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 825f;
			if (nhclmboinfg.magnitude > 915f)
			{
				num2 = LocNewLogic.getI.getDeepInPointSM(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(277f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(num2 / 1019f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("2000", 1511f);
		}
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x0027AA01 File Offset: 0x00278C01
	public void LGBOMDNOALL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("_ReflectionTex", 1415f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x0027AA28 File Offset: 0x00278C28
	private void GDPMOMHBIFN()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NGHGOGLDBAK();
		}
		this.mainPanel.gameObject.SetActive(this.INDAFHMODPE() && flag);
		this.secondPanel.gameObject.SetActive(this.EPFBLCJHGGF() && flag);
		if (Input.GetKeyDown((KeyCode)153) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", 1448f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(820f, 795f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 446f)
		{
			euler = new Vector3(886f, 979f, 1401f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054E0 RID: 21728 RVA: 0x0027ABCF File Offset: 0x00278DCF
	public void EGCMBAJEFKK()
	{
		this.IECBBCFBHDA(this.EIKHJKJBDMH());
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Hidden/TonemappingColorGrading", 1132f);
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x0027ABF4 File Offset: 0x00278DF4
	private void KCBECEFNGMO()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.EPOKFPMEEEP();
		}
		this.mainPanel.gameObject.SetActive(!this.HHHJCGMBHKH() && flag);
		this.secondPanel.gameObject.SetActive(this.BGOJDOFEGCO() && flag);
		if (Input.GetKeyDown((KeyCode)(-132)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("post_5", 47f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1449f, 153f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 569f)
		{
			euler = new Vector3(1537f, 692f, 478f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GGBMJFNGHMC()
	{
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x002783A3 File Offset: 0x002765A3
	public void JCFNGPMFOGB(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x0027AD9B File Offset: 0x00278F9B
	public void IFMOGFCCGDD()
	{
		this.EHOKEHNGLMN(!this.POHGBLJCINE());
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("{0} {1}\n{2}", 56f);
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FGJCIEDDFGN()
	{
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x0027ADC0 File Offset: 0x00278FC0
	public void LFEDGGOFJGF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("TYPES", 1906f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x0027ADFC File Offset: 0x00278FFC
	public void JPFOAIGGNMC(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 1084f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 5)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 567f;
			if (nhclmboinfg.magnitude > 882f)
			{
				num2 = LocNewLogic.getI.CFGNHLDNAAJ(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(1080f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 273f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_BlurFilterDistance", 442f);
		}
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x0027AF18 File Offset: 0x00279118
	private void EMHGNEMIGII()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NGHGOGLDBAK();
		}
		this.mainPanel.gameObject.SetActive(this.PFFNDGDIFHP() && flag);
		this.secondPanel.gameObject.SetActive(this.DGPBEMJIJCD() && flag);
		if (Input.GetKeyDown((KeyCode)(-167)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("En", 1126f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(45f, 164f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 824f)
		{
			euler = new Vector3(523f, 554f, 109f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x0027B0C0 File Offset: 0x002792C0
	public void PFJOCLAGIAP(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 580f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 4)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 211f;
			if (nhclmboinfg.magnitude > 1737f)
			{
				num2 = LocNewLogic.getI.CFGNHLDNAAJ(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(1724f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 1531f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("MotorbikeHeadstand", 1653f);
		}
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool MNFGJHBFKJG()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x0027B1D9 File Offset: 0x002793D9
	public void PAHDBMHNNGB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("<b>Injection Detector</b>", 87f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x0027B200 File Offset: 0x00279400
	public void LDCGJNHNALJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("[LH &]", 104f);
		this.helpPanel.gameObject.SetActive(true);
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x0027B228 File Offset: 0x00279428
	public void OCKBMHOADIC(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KFEPCNBDMIH;
			float num = 689f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 0)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 268f;
			if (nhclmboinfg.magnitude > 1610f)
			{
				num2 = LocNewLogic.getI.NEPOFBNILML(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(576f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(num2 / 1872f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("WaypointHeading.tif", 415f);
		}
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGEIACONKCJ()
	{
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x0027B341 File Offset: 0x00279541
	public void LPDMFLJMHLK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("WorkerHammer", 916f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x0027B380 File Offset: 0x00279580
	public void GLBAPABFBHF(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.FBLACLHFLGE();
			float num = 620f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 1)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 766f;
			if (nhclmboinfg.magnitude > 1301f)
			{
				num2 = LocNewLogic.getI.NEPOFBNILML(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(1003f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 427f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Vertical", 381f);
		}
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x0027B49C File Offset: 0x0027969C
	public void EACFNCNBOBD(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.KKLEBEEGGDG();
			float num = 1412f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 8)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 801f;
			if (nhclmboinfg.magnitude > 477f)
			{
				num2 = LocNewLogic.getI.DNEOIPONBDH(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(1317f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 1643f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("double: ", 848f);
		}
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x0027B5B5 File Offset: 0x002797B5
	public void MPDHMBKIIOO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("MotorbikeSeatStandWheely", 1826f);
		this.helpPanel.gameObject.SetActive(false);
	}

	// Token: 0x060054F3 RID: 21747 RVA: 0x0027B5DC File Offset: 0x002797DC
	public void AGHNOBGIFIO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Horizontal", 1964f);
		this.helpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = false;
		HPGKIJLKCIH.IKGFHGKKCPG.LGAMLOJJNHJ();
	}

	// Token: 0x060054F4 RID: 21748 RVA: 0x0027B618 File Offset: 0x00279818
	public void ANJMCNMADLA(int CLBPBJGLHEE)
	{
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			float a = bgjkmcbhnak.FBLACLHFLGE();
			float num = 171f;
			Vector3 nhclmboinfg = LocNewLogic.getI.lastPosition;
			if (Fisherman.getI.dropScrpt != null && Fisherman.getI.dropScrpt.mode >= 4)
			{
				nhclmboinfg = Fisherman.getI.dropScrpt.transform.position;
			}
			float num2 = 1074f;
			if (nhclmboinfg.magnitude > 1542f)
			{
				num2 = LocNewLogic.getI.getDeepInPointSM(nhclmboinfg);
			}
			num = Mathf.Min(num, num2);
			float dccpcblodig = Mathf.Min(a, num);
			if (CLBPBJGLHEE == -1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(142f);
			}
			if (CLBPBJGLHEE == 0)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.AJMPAOCEPCA(num2 / 1625f);
			}
			if (CLBPBJGLHEE == 1)
			{
				bgjkmcbhnak.JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(dccpcblodig);
			}
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("DeadmanFloat", 953f);
		}
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x0027B734 File Offset: 0x00279934
	private void KJJEEMEHGBF()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.ILGIOKIAFJA();
		}
		this.mainPanel.gameObject.SetActive(this.GNBPEBKIIGN() && flag);
		this.secondPanel.gameObject.SetActive(this.PMNKDKGOJPO() && flag);
		if (Input.GetKeyDown((KeyCode)(-188)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Cloth_01.wav", 1157f);
			this.helpPanel.gameObject.SetActive(false);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(2f, 414f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1891f)
		{
			euler = new Vector3(1275f, 609f, 1675f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x0027B8DB File Offset: 0x00279ADB
	public void LEJFNGOFGND()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("act_orderb_", 422f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.MAEMFLMFDDL();
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x0027B917 File Offset: 0x00279B17
	public void OAIHOJANALL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("error.wav", 1787f);
		this.helpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP = true;
		HPGKIJLKCIH.IKGFHGKKCPG.NHIFGPDIIAG();
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x002783A3 File Offset: 0x002765A3
	public void OJFCFANJMPL(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x00277EA2 File Offset: 0x002760A2
	public bool EPFBLCJHGGF()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG;
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ILCOPJPEKEC()
	{
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x0027B954 File Offset: 0x00279B54
	private void OHMDFPHPFMB()
	{
		this.mainPB2.max = this.mainPB1.max;
		this.stamPB2.max = this.stamPB1.max;
		this.mainPB2.position = this.mainPB1.position;
		this.stamPB2.position = this.stamPB1.position;
		bool flag = this.isShow;
		if (this.PKCPKMLNMKJ != flag && flag && HPGKIJLKCIH.IKGFHGKKCPG.MEOEGHAAGIP && !this.helpPanel.gameObject.activeSelf)
		{
			this.NGHGOGLDBAK();
		}
		this.mainPanel.gameObject.SetActive(!this.HHHJCGMBHKH() && flag);
		this.secondPanel.gameObject.SetActive(this.EIKHJKJBDMH() && flag);
		if (Input.GetKeyDown((KeyCode)(-172)) && !this.helpPanel.gameObject.activeSelf)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Wood Cut", 1056f);
			this.helpPanel.gameObject.SetActive(true);
		}
		this.PKCPKMLNMKJ = this.isShow;
		if (BOIKJDICEMF.IKGFHGKKCPG == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		Vector3 euler = new Vector3(1970f, 611f, -BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime * this.rotSpeedKF);
		if (euler.magnitude < 1052f)
		{
			euler = new Vector3(1782f, 1247f, 808f);
		}
		this.reelImage.rotation = Quaternion.Euler(euler);
		this.reelImage2.rotation = Quaternion.Euler(euler);
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x002783A3 File Offset: 0x002765A3
	public void AJCKGBLANFP(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x060054FD RID: 21757 RVA: 0x002783A3 File Offset: 0x002765A3
	public void KNGBKMLLGND(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MDILFKBMADG = DCCPCBLODIG;
	}

	// Token: 0x04000CC0 RID: 3264
	public RectTransform helpPanel;

	// Token: 0x04000CC1 RID: 3265
	public RectTransform mainPanel;

	// Token: 0x04000CC2 RID: 3266
	public RectTransform secondPanel;

	// Token: 0x04000CC3 RID: 3267
	public RectTransform reelImage;

	// Token: 0x04000CC4 RID: 3268
	public RectTransform reelImage2;

	// Token: 0x04000CC5 RID: 3269
	public float rotSpeedKF = 1f;

	// Token: 0x04000CC6 RID: 3270
	public ProgressBar mainPB1;

	// Token: 0x04000CC7 RID: 3271
	public ProgressBar mainPB2;

	// Token: 0x04000CC8 RID: 3272
	public ProgressBar stamPB1;

	// Token: 0x04000CC9 RID: 3273
	public ProgressBar stamPB2;

	// Token: 0x04000CCA RID: 3274
	public bool isShow;

	// Token: 0x04000CCB RID: 3275
	private bool PKCPKMLNMKJ;
}
