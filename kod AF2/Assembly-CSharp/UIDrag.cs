using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000184 RID: 388
public class UIDrag : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
{
	// Token: 0x060055ED RID: 21997 RVA: 0x002801D4 File Offset: 0x0027E3D4
	private void NKNDJENDPDJ()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x002801D4 File Offset: 0x0027E3D4
	private void OnDestroy()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x002801DC File Offset: 0x0027E3DC
	private void PEGLBMGDMIP()
	{
		this.CLNHMFIOOPN();
	}

	// Token: 0x060055F0 RID: 22000 RVA: 0x002801E4 File Offset: 0x0027E3E4
	private void FBOEMKFLNOF()
	{
		if (!this.DKDILDPNDFI)
		{
			return;
		}
		Debug.Log("KatanaVerticalSwing");
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.dragTransform.position);
			PlayerPrefs.SetString(this.saveName, iibeekcaahk.ToString());
			PlayerPrefs.Save();
		}
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x00280233 File Offset: 0x0027E433
	private bool BPCPMFDINJM(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) >= 699f;
	}

	// Token: 0x060055F2 RID: 22002 RVA: 0x00280248 File Offset: 0x0027E448
	private void CLNHMFIOOPN()
	{
		if (!this.DKDILDPNDFI)
		{
			return;
		}
		Debug.Log("IdleCheer");
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.dragTransform.position);
			PlayerPrefs.SetString(this.saveName, iibeekcaahk.ToString());
			PlayerPrefs.Save();
		}
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x00280297 File Offset: 0x0027E497
	public void FDLOFMPGDPJ(PointerEventData CAKNKPPGGIK)
	{
		this.FBOEMKFLNOF();
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x002802A0 File Offset: 0x0027E4A0
	private void IDLOLEFJHNF()
	{
		if (!this.DKDILDPNDFI)
		{
			return;
		}
		Debug.Log("_HitTime");
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.dragTransform.position);
			PlayerPrefs.SetString(this.saveName, iibeekcaahk.ToString());
			PlayerPrefs.Save();
		}
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x002801D4 File Offset: 0x0027E3D4
	public void OnEndDrag(PointerEventData CAKNKPPGGIK)
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x002802EF File Offset: 0x0027E4EF
	private void FIJKDFIMELM()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.DHHDCJLIOPK();
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x00280311 File Offset: 0x0027E511
	public void OnDrag(PointerEventData CAKNKPPGGIK)
	{
		this.dragTransform.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x00280344 File Offset: 0x0027E544
	private void BKMJKLCMOHP()
	{
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(this.saveName));
			this.DKDILDPNDFI = false;
			if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
			{
				return;
			}
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				Vector3 position = this.dragTransform.position;
				this.dragTransform.position = iibeekcaahk.FPLDMBJEFEB();
				bool flag = true;
				if (this.MDPGOIPBAIO(this.dragXMinMax.x) && this.dragTransform.position.x < this.dragXMinMax.x)
				{
					flag = true;
				}
				if (this.KAPKMMJCOAP(this.dragXMinMax.y) && this.dragTransform.position.x > this.dragXMinMax.y)
				{
					flag = true;
				}
				if (this.KOPEEMLPGFF(this.dragYMinMax.x) && this.dragTransform.position.y < this.dragYMinMax.x)
				{
					flag = true;
				}
				if (this.DMOOLDFKHKF(this.dragYMinMax.y) && this.dragTransform.position.y > this.dragYMinMax.y)
				{
					flag = true;
				}
				if (flag)
				{
					this.dragTransform.position = position;
				}
			}
		}
		this.DKDILDPNDFI = false;
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x00280489 File Offset: 0x0027E689
	private void HHGGCBLOJGB()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.ELMABLCGAML();
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x002804AB File Offset: 0x0027E6AB
	private void NOOBBMALENG()
	{
		this.PFCGMEEHCAO();
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x002801DC File Offset: 0x0027E3DC
	private void HMDACKBGNJL()
	{
		this.CLNHMFIOOPN();
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x002804B3 File Offset: 0x0027E6B3
	private bool MDPGOIPBAIO(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) < 383f;
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BNKJNBIDPME()
	{
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x002804C8 File Offset: 0x0027E6C8
	private void DHHDCJLIOPK()
	{
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(this.saveName));
			this.DKDILDPNDFI = true;
			if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
			{
				return;
			}
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				Vector3 position = this.dragTransform.position;
				this.dragTransform.position = iibeekcaahk.GEJNEDNGJDD();
				bool flag = false;
				if (this.MDPGOIPBAIO(this.dragXMinMax.x) && this.dragTransform.position.x < this.dragXMinMax.x)
				{
					flag = false;
				}
				if (this.MDPGOIPBAIO(this.dragXMinMax.y) && this.dragTransform.position.x > this.dragXMinMax.y)
				{
					flag = true;
				}
				if (this.DMOOLDFKHKF(this.dragYMinMax.x) && this.dragTransform.position.y < this.dragYMinMax.x)
				{
					flag = true;
				}
				if (this.BPCPMFDINJM(this.dragYMinMax.y) && this.dragTransform.position.y > this.dragYMinMax.y)
				{
					flag = false;
				}
				if (flag)
				{
					this.dragTransform.position = position;
				}
			}
		}
		this.DKDILDPNDFI = false;
	}

	// Token: 0x06005600 RID: 22016 RVA: 0x00280640 File Offset: 0x0027E840
	private void JEEIKMDLICC()
	{
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(this.saveName));
			this.DKDILDPNDFI = true;
			if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
			{
				return;
			}
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				Vector3 position = this.dragTransform.position;
				this.dragTransform.position = iibeekcaahk.FPLDMBJEFEB();
				bool flag = false;
				if (this.KOPEEMLPGFF(this.dragXMinMax.x) && this.dragTransform.position.x < this.dragXMinMax.x)
				{
					flag = true;
				}
				if (this.KOPEEMLPGFF(this.dragXMinMax.y) && this.dragTransform.position.x > this.dragXMinMax.y)
				{
					flag = true;
				}
				if (this.KOPEEMLPGFF(this.dragYMinMax.x) && this.dragTransform.position.y < this.dragYMinMax.x)
				{
					flag = true;
				}
				if (this.KOPEEMLPGFF(this.dragYMinMax.y) && this.dragTransform.position.y > this.dragYMinMax.y)
				{
					flag = true;
				}
				if (flag)
				{
					this.dragTransform.position = position;
				}
			}
		}
		this.DKDILDPNDFI = true;
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x00280311 File Offset: 0x0027E511
	public void BLPDMAEDEJM(PointerEventData CAKNKPPGGIK)
	{
		this.dragTransform.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x00280297 File Offset: 0x0027E497
	public void POMDKHDACKI(PointerEventData CAKNKPPGGIK)
	{
		this.FBOEMKFLNOF();
	}

	// Token: 0x06005603 RID: 22019 RVA: 0x00280785 File Offset: 0x0027E985
	private void ENKAIDOAJAC()
	{
		this.ELMABLCGAML();
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x00280790 File Offset: 0x0027E990
	private void ELMABLCGAML()
	{
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(this.saveName));
			this.DKDILDPNDFI = false;
			if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
			{
				return;
			}
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				Vector3 position = this.dragTransform.position;
				this.dragTransform.position = iibeekcaahk.GEJNEDNGJDD();
				bool flag = true;
				if (this.DMOOLDFKHKF(this.dragXMinMax.x) && this.dragTransform.position.x < this.dragXMinMax.x)
				{
					flag = true;
				}
				if (this.MDPGOIPBAIO(this.dragXMinMax.y) && this.dragTransform.position.x > this.dragXMinMax.y)
				{
					flag = false;
				}
				if (this.DMOOLDFKHKF(this.dragYMinMax.x) && this.dragTransform.position.y < this.dragYMinMax.x)
				{
					flag = false;
				}
				if (this.KAPKMMJCOAP(this.dragYMinMax.y) && this.dragTransform.position.y > this.dragYMinMax.y)
				{
					flag = false;
				}
				if (flag)
				{
					this.dragTransform.position = position;
				}
			}
		}
		this.DKDILDPNDFI = false;
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMMDHJJJNJO()
	{
	}

	// Token: 0x06005606 RID: 22022 RVA: 0x002801DC File Offset: 0x0027E3DC
	public void JILGGBHBKBM(PointerEventData CAKNKPPGGIK)
	{
		this.CLNHMFIOOPN();
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x002808D5 File Offset: 0x0027EAD5
	private void Start()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.JEEIKMDLICC();
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x002808F7 File Offset: 0x0027EAF7
	private void BOPEGILEJKM()
	{
		this.JEEIKMDLICC();
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x002801D4 File Offset: 0x0027E3D4
	private void GNPJEGPCBOD()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x00280311 File Offset: 0x0027E511
	public void ACMFEPPMALI(PointerEventData CAKNKPPGGIK)
	{
		this.dragTransform.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x002808FF File Offset: 0x0027EAFF
	private void AFDMCGNBDCC()
	{
		this.OFCOENIDPPL();
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x00280908 File Offset: 0x0027EB08
	private void PFCGMEEHCAO()
	{
		if (!this.DKDILDPNDFI)
		{
			return;
		}
		Debug.Log("\n");
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.dragTransform.position);
			PlayerPrefs.SetString(this.saveName, iibeekcaahk.ToString());
			PlayerPrefs.Save();
		}
	}

	// Token: 0x0600560D RID: 22029 RVA: 0x002808FF File Offset: 0x0027EAFF
	private void KMHAJKNJHHO()
	{
		this.OFCOENIDPPL();
	}

	// Token: 0x0600560E RID: 22030 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IGEICBNMPAD()
	{
	}

	// Token: 0x0600560F RID: 22031 RVA: 0x00280957 File Offset: 0x0027EB57
	private void EDGALMCHPPH()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.BKMJKLCMOHP();
	}

	// Token: 0x06005610 RID: 22032 RVA: 0x0028097C File Offset: 0x0027EB7C
	private void NBAKJCDDBIP()
	{
		if (!this.DKDILDPNDFI)
		{
			return;
		}
		Debug.Log("** Panel save position");
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.dragTransform.position);
			PlayerPrefs.SetString(this.saveName, iibeekcaahk.ToString());
			PlayerPrefs.Save();
		}
	}

	// Token: 0x06005611 RID: 22033 RVA: 0x002802EF File Offset: 0x0027E4EF
	private void ANHOOJFEJJE()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.DHHDCJLIOPK();
	}

	// Token: 0x06005612 RID: 22034 RVA: 0x002809CB File Offset: 0x0027EBCB
	private bool KOPEEMLPGFF(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) >= 0.01f;
	}

	// Token: 0x06005613 RID: 22035 RVA: 0x00280489 File Offset: 0x0027E689
	private void ELFLOPJDAKK()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.ELMABLCGAML();
	}

	// Token: 0x06005614 RID: 22036 RVA: 0x002801D4 File Offset: 0x0027E3D4
	public void CKGAEOFFBHH(PointerEventData CAKNKPPGGIK)
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x06005615 RID: 22037 RVA: 0x002809DD File Offset: 0x0027EBDD
	private bool KAPKMMJCOAP(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) >= 477f;
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06005617 RID: 22039 RVA: 0x00280311 File Offset: 0x0027E511
	public void IMPHLLIMHDG(PointerEventData CAKNKPPGGIK)
	{
		this.dragTransform.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x002809F0 File Offset: 0x0027EBF0
	private void OFCOENIDPPL()
	{
		if (this.isSavePos)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(this.saveName));
			this.DKDILDPNDFI = true;
			if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
			{
				return;
			}
			if (!iibeekcaahk.CHOHHHOLIBJ())
			{
				Vector3 position = this.dragTransform.position;
				this.dragTransform.position = iibeekcaahk.FPLDMBJEFEB();
				bool flag = false;
				if (this.MDPGOIPBAIO(this.dragXMinMax.x) && this.dragTransform.position.x < this.dragXMinMax.x)
				{
					flag = false;
				}
				if (this.KAPKMMJCOAP(this.dragXMinMax.y) && this.dragTransform.position.x > this.dragXMinMax.y)
				{
					flag = true;
				}
				if (this.DMOOLDFKHKF(this.dragYMinMax.x) && this.dragTransform.position.y < this.dragYMinMax.x)
				{
					flag = true;
				}
				if (this.KAPKMMJCOAP(this.dragYMinMax.y) && this.dragTransform.position.y > this.dragYMinMax.y)
				{
					flag = true;
				}
				if (flag)
				{
					this.dragTransform.position = position;
				}
			}
		}
		this.DKDILDPNDFI = true;
	}

	// Token: 0x06005619 RID: 22041 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x002808D5 File Offset: 0x0027EAD5
	private void FPLHODJCJDO()
	{
		if (this.dragTransform == null)
		{
			this.dragTransform = base.GetComponent<RectTransform>();
		}
		this.JEEIKMDLICC();
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x00280B35 File Offset: 0x0027ED35
	private bool DMOOLDFKHKF(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) < 1545f && false;
	}

	// Token: 0x0600561C RID: 22044 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HAIMGCDKPDC()
	{
	}

	// Token: 0x0600561D RID: 22045 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IKHCCAANGOP()
	{
	}

	// Token: 0x0600561E RID: 22046 RVA: 0x00280B47 File Offset: 0x0027ED47
	private bool PACOCHIOIBE(float AHCGELCIDIH)
	{
		return Mathf.Abs(AHCGELCIDIH) < 511f && false;
	}

	// Token: 0x04000CF8 RID: 3320
	public RectTransform dragTransform;

	// Token: 0x04000CF9 RID: 3321
	public bool isSavePos;

	// Token: 0x04000CFA RID: 3322
	public string saveName;

	// Token: 0x04000CFB RID: 3323
	public Vector2 dragXMinMax = new Vector2(0f, 0f);

	// Token: 0x04000CFC RID: 3324
	public Vector2 dragYMinMax = new Vector2(0f, 0f);

	// Token: 0x04000CFD RID: 3325
	private bool DKDILDPNDFI;
}
