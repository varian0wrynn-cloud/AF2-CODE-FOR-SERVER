using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000253 RID: 595
public class WpnImageObj : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06008888 RID: 34952 RVA: 0x003F6EBC File Offset: 0x003F50BC
	private void CCMOKEDKMNJ()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "_Screen";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "IceHockeyPassLeft";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x06008889 RID: 34953 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBMKHLDOIKP()
	{
	}

	// Token: 0x0600888A RID: 34954 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMGBKHCHPHO()
	{
	}

	// Token: 0x0600888B RID: 34955 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ECDGOPAINIG()
	{
	}

	// Token: 0x0600888C RID: 34956 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OnPointerExit(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600888D RID: 34957 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EKCKBDKEAKO()
	{
	}

	// Token: 0x0600888E RID: 34958 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NEHOCLNFDHP()
	{
	}

	// Token: 0x0600888F RID: 34959 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void ELADFDNPOOI()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void FECFLBMPAAL()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008891 RID: 34961 RVA: 0x003F6F40 File Offset: 0x003F5140
	private void IKFFGPLEECL()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "_InternalLutParams";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "gi_um_4";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x003F6FB4 File Offset: 0x003F51B4
	private void PDEEOGAAMBB()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.HMFKMPGCBJH(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 1430f;
				return;
			}
			if ((JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1290f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 153f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 1689f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 1004f;
		}
	}

	// Token: 0x06008893 RID: 34963 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HNAKGHHGDPE()
	{
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x003F710C File Offset: 0x003F530C
	private void OBIPAJDKIHF()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "SkateboardIdle";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "Allows to detect foreign managed assemblies in your application.";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x06008895 RID: 34965 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EFHJCCBOPEF(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008896 RID: 34966 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OnPointerEnter(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JBFJPNKLLKI()
	{
	}

	// Token: 0x06008898 RID: 34968 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBOONMDONCF()
	{
	}

	// Token: 0x06008899 RID: 34969 RVA: 0x00022FCC File Offset: 0x000211CC
	public void HFBGKGJOGBJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x0600889A RID: 34970 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IFINKBGCKML()
	{
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x003F7180 File Offset: 0x003F5380
	private void CABDFNIKOOI()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "AppID:";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "IdleSpew";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void MMACLBBMDLA()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void CGFDDFHECLJ()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600889E RID: 34974 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FixedUpdate()
	{
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DIAIKCBANBK()
	{
	}

	// Token: 0x060088A0 RID: 34976 RVA: 0x003F71F4 File Offset: 0x003F53F4
	private void EIGBKJAEIKO()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "_ReflectionTexture4";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x060088A1 RID: 34977 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JGIJIPNENLI()
	{
	}

	// Token: 0x060088A2 RID: 34978 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIBKGOFOPHJ()
	{
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void BGCLAKJHAFK()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088A4 RID: 34980 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void MCHAAIIHOKD()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088A5 RID: 34981 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OKBCBGJNPOF()
	{
	}

	// Token: 0x060088A6 RID: 34982 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void NCALLFHEAGJ()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088A7 RID: 34983 RVA: 0x003F7268 File Offset: 0x003F5468
	private void PJOENCIPFMN()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 1271f;
				return;
			}
			if ((JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1062f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1514f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 1443f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.LPACNNDMOCN(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 522f;
		}
	}

	// Token: 0x060088A8 RID: 34984 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BOAJJAKEMLH()
	{
	}

	// Token: 0x060088A9 RID: 34985 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void DGDGMFDPEHO()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088AA RID: 34986 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MCHJCHLKPLJ()
	{
	}

	// Token: 0x060088AB RID: 34987 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void OPNPODKLOJK()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088AC RID: 34988 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IDMEHDCMFNJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088AD RID: 34989 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KHAEPCKACBD()
	{
	}

	// Token: 0x060088AE RID: 34990 RVA: 0x003F73C0 File Offset: 0x003F55C0
	private void CGBKGPPNMNM()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.PKOIFEBEOCP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 1670f;
				return;
			}
			if ((JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1909f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 260f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 420f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 119f;
		}
	}

	// Token: 0x060088AF RID: 34991 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LIFKNIODHIN(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088B0 RID: 34992 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MFGKBHNECJH()
	{
	}

	// Token: 0x060088B1 RID: 34993 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void LHHKDNILMDI()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x00022FCC File Offset: 0x000211CC
	public void DFFJHDHHLDJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void AOCDDBNBADJ()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088B4 RID: 34996 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OFNFOFELJEE(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088B5 RID: 34997 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JHPFENJCEKP()
	{
	}

	// Token: 0x060088B6 RID: 34998 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IANJLHIIGLN()
	{
	}

	// Token: 0x060088B7 RID: 34999 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DKOIOBMMAGN()
	{
	}

	// Token: 0x060088B8 RID: 35000 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void DGGMJCMLLED()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void NOKJMMDMJNO()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088BA RID: 35002 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JCNOFKABMCM()
	{
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BNKJNBIDPME()
	{
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x003F7518 File Offset: 0x003F5718
	private void OnGUI()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 0f;
				return;
			}
			if ((JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 0.01f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 0f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 0.9f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 0f;
		}
	}

	// Token: 0x060088BD RID: 35005 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void JCELICPHGEP()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x003F7670 File Offset: 0x003F5870
	private void OFKLNHNPADP()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 180f;
				return;
			}
			if ((JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 175f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1987f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 1733f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 1996f;
		}
	}

	// Token: 0x060088BF RID: 35007 RVA: 0x00022FCC File Offset: 0x000211CC
	public void GIEPDBPKCFJ(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088C0 RID: 35008 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FPLNDDMFFKG()
	{
	}

	// Token: 0x060088C1 RID: 35009 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KLFPOILLKDF()
	{
	}

	// Token: 0x060088C2 RID: 35010 RVA: 0x003F77C8 File Offset: 0x003F59C8
	private void BBGAONKBIPJ()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 1174f;
				return;
			}
			if ((JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1634f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 38f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 49f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.LPACNNDMOCN(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 860f;
		}
	}

	// Token: 0x060088C3 RID: 35011 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMHGNEMIGII()
	{
	}

	// Token: 0x060088C4 RID: 35012 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CBNCGPJBEAD(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x003F7920 File Offset: 0x003F5B20
	private void BGJFLKLBOPK()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 1278f;
				return;
			}
			if ((JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 990f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1697f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 1189f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.LPACNNDMOCN(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 610f;
		}
	}

	// Token: 0x060088C6 RID: 35014 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BGLIJMGAHLP()
	{
	}

	// Token: 0x060088C7 RID: 35015 RVA: 0x00022FCC File Offset: 0x000211CC
	public void INEPPFMGIKD(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JKDBDEGLIJN()
	{
	}

	// Token: 0x060088CA RID: 35018 RVA: 0x003F7A8C File Offset: 0x003F5C8C
	private void GGIAHHFENMK()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "_AddCountitem.wav";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "Wizard1HandThrow";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x060088CB RID: 35019 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DFFOEGHGPGP()
	{
	}

	// Token: 0x060088CC RID: 35020 RVA: 0x003F7B00 File Offset: 0x003F5D00
	private void NCLNNJIGFOO()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.HMFKMPGCBJH(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 550f;
				return;
			}
			if ((JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1702f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 398f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 532f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 973f;
		}
	}

	// Token: 0x060088CD RID: 35021 RVA: 0x003F7C58 File Offset: 0x003F5E58
	private void PIMGCFGNCJH()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "Second bone's position equals first bone's position in the biped's limb.";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "no_time_period";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x060088CE RID: 35022 RVA: 0x003F7CCC File Offset: 0x003F5ECC
	private void DNPKJPPIHOO()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "_ScreenSize";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "knopje.wav";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x060088CF RID: 35023 RVA: 0x003F7D40 File Offset: 0x003F5F40
	private void KMLAENJBADF()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 981f;
				return;
			}
			if ((JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 699f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1189f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 188f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 1372f;
		}
	}

	// Token: 0x060088D0 RID: 35024 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void EHFPLKEINFO()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088D1 RID: 35025 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void PFNPOHMMJDN()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088D2 RID: 35026 RVA: 0x00022FCC File Offset: 0x000211CC
	public void GJNLLJDJIIE(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088D3 RID: 35027 RVA: 0x003F7E98 File Offset: 0x003F6098
	private void BCJFDHBDAHD()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 579f;
				return;
			}
			if ((JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1129f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1777f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 187f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.LPACNNDMOCN(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 1420f;
		}
	}

	// Token: 0x060088D4 RID: 35028 RVA: 0x00022FCC File Offset: 0x000211CC
	public void NCBCDFCPMGE(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088D5 RID: 35029 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IDMCOLDDNCF()
	{
	}

	// Token: 0x060088D6 RID: 35030 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void Start()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088D7 RID: 35031 RVA: 0x00022FCC File Offset: 0x000211CC
	public void AIHOKLILMJD(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088D8 RID: 35032 RVA: 0x00022FCC File Offset: 0x000211CC
	public void HEKHGPMOBAB(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088D9 RID: 35033 RVA: 0x003F7FF0 File Offset: 0x003F61F0
	private void BKFLIDKPDDI()
	{
		Vector2 vector = new Vector2(this.rect.position.x, (float)Screen.height - this.rect.position.y);
		Rect rect = new Rect(vector.x, vector.y, this.rect.rect.width, this.rect.rect.height);
		this.isMouseOver = rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
		if (this.weapon != null)
		{
			this.weapon.JCIIPCEDICP(vector, this.rect.rect.width);
			bool isEditor = Application.isEditor;
			if (!this.isMouseOver)
			{
				this.NDAAMOJNKMP = 271f;
				return;
			}
			if ((JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF - this.GOOBPOIIFJK).SqrMagnitude() < 1323f)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1903f;
			}
			this.GOOBPOIIFJK = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
			if (this.NDAAMOJNKMP > 37f && MDEKJCCIDIA.IKGFHGKKCPG.KKLEEIBNIBC == null)
			{
				MDEKJCCIDIA.IKGFHGKKCPG.OIMDOKBCEJE(this.weapon);
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 1123f;
		}
	}

	// Token: 0x060088DA RID: 35034 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BJHFBBGPDME(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088DB RID: 35035 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LOIIMFGDANC(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088DC RID: 35036 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACPCJLEKCPM()
	{
	}

	// Token: 0x060088DD RID: 35037 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CCMCEPIBNNI(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088DE RID: 35038 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060088DF RID: 35039 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCNGEFBKMNC()
	{
	}

	// Token: 0x060088E0 RID: 35040 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGFFIEPGPD()
	{
	}

	// Token: 0x060088E1 RID: 35041 RVA: 0x003F6F2F File Offset: 0x003F512F
	private void CKGPEFOKKNL()
	{
		this.rect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060088E2 RID: 35042 RVA: 0x003F8148 File Offset: 0x003F6348
	private void OnEnable()
	{
		if (this.txtCount != null)
		{
			this.txtCount.text = "";
		}
		if (this.weapon == null)
		{
			if (this.txtCount != null)
			{
				this.txtCount.text = "";
			}
			if (GameInterface.getI != null)
			{
				this.wpnImage.texture = GameInterface.getI.EmptyTexture;
			}
		}
	}

	// Token: 0x060088E3 RID: 35043 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LOIPNCCDMLM()
	{
	}

	// Token: 0x060088E4 RID: 35044 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LIOCDEICIFD()
	{
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FHMINEENEIL(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088E6 RID: 35046 RVA: 0x00022FCC File Offset: 0x000211CC
	public void NOHHBNHKKIN(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x00022FCC File Offset: 0x000211CC
	public void LLDCBKPILDH(PointerEventData CAKNKPPGGIK)
	{
	}

	// Token: 0x040012F5 RID: 4853
	public EKBAPCMPANI weapon;

	// Token: 0x040012F6 RID: 4854
	public RawImage wpnImage;

	// Token: 0x040012F7 RID: 4855
	public RectTransform rect;

	// Token: 0x040012F8 RID: 4856
	public Text txtCount;

	// Token: 0x040012F9 RID: 4857
	private float NDAAMOJNKMP;

	// Token: 0x040012FA RID: 4858
	private Vector2 GOOBPOIIFJK = Vector2.zero;

	// Token: 0x040012FB RID: 4859
	public bool isMouseOver;
}
