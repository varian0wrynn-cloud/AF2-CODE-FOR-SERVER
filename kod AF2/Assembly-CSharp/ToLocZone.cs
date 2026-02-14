using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000169 RID: 361
public class ToLocZone : MonoBehaviour
{
	// Token: 0x06004D39 RID: 19769 RVA: 0x00235534 File Offset: 0x00233734
	private void NKFPFHFCLMD(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "; ")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("3" + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("BowIdle" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JDOLCNDNFGP(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JDOLCNDNFGP(this.toLocId);
					epmphjgalbe.KPCGLGHDILI(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-10, epmphjgalbe.JOCJNOBBELJ());
					return;
				}
				finally
				{
					epmphjgalbe.NCKMEIBFNGL();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
			base.StartCoroutine(this.OFPHGLABMEH());
		}
	}

	// Token: 0x06004D3A RID: 19770 RVA: 0x0023563C File Offset: 0x0023383C
	private void CANBPOPCGPI(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "shop_header")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("__c" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("16" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ALNEALEKFNB(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-12, epmphjgalbe.LAFILAEOPAJ());
					return;
				}
				finally
				{
					epmphjgalbe.PMIGGJHLIDO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
			base.StartCoroutine(this.BHPAOJCHAHC());
		}
	}

	// Token: 0x06004D3B RID: 19771 RVA: 0x00235744 File Offset: 0x00233944
	private void GHMLHNEJDKD(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "__a")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("knopje.wav" + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("\n" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JIIKLOKAGIC(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ENDMKPCFKND(this.toLocId);
					epmphjgalbe.LHLOOIDHGMA(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-182, epmphjgalbe.NNEAJJNCGMK());
					return;
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			base.StartCoroutine(this.PNPNCEKMMIJ());
		}
	}

	// Token: 0x06004D3C RID: 19772 RVA: 0x0023584C File Offset: 0x00233A4C
	private void MIDCDGCCFEL(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "_SelectColor")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("RollerBladeTurnLeft" + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("implevel" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.LHLOOIDHGMA(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JIIKLOKAGIC(this.toLocId);
					epmphjgalbe.LHLOOIDHGMA(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(81, epmphjgalbe.HDEKHFOKCKI());
					return;
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
			base.StartCoroutine(this.IGFJHDLJOHP());
		}
	}

	// Token: 0x06004D3D RID: 19773 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator PKFEMCLKJAL()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D3E RID: 19774 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator CEHILDDPMIO()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D3F RID: 19775 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator GPKNOHJOHMH()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D40 RID: 19776 RVA: 0x00235964 File Offset: 0x00233B64
	private void FKOLJDCBFGI(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("float: " + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("settitul" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(this.toLocId);
					epmphjgalbe.KPCGLGHDILI(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-19, epmphjgalbe.NNEAJJNCGMK());
					return;
				}
				finally
				{
					epmphjgalbe.PMIGGJHLIDO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			base.StartCoroutine(this.MINJFEIGBMM());
		}
	}

	// Token: 0x06004D41 RID: 19777 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator LMLMACBJOBO()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D42 RID: 19778 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator NNGACOBPIFE()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D43 RID: 19779 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator HHMIBFCBFID()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D44 RID: 19780 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator HHJCFKIOOEJ()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D45 RID: 19781 RVA: 0x00235A7C File Offset: 0x00233C7C
	private void PCMNKLGCGMK(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "money")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("1 Hand Sword Jab Combo" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("MotorbikeLasso" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.FLLJONHPLNA(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ENDMKPCFKND(this.toLocId);
					epmphjgalbe.GOMLLPFFPNP(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(155, epmphjgalbe.LAFILAEOPAJ());
					return;
				}
				finally
				{
					epmphjgalbe.NCKMEIBFNGL();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			base.StartCoroutine(this.CEHILDDPMIO());
		}
	}

	// Token: 0x06004D46 RID: 19782 RVA: 0x00235B84 File Offset: 0x00233D84
	private void GOFJHMAOPBN(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "demoLong")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("StaffPowerUp" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log(" \n" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ENDMKPCFKND(this.toLocId);
					epmphjgalbe.ALNEALEKFNB(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(121, epmphjgalbe.JDPHBLHOLAD());
					return;
				}
				finally
				{
					epmphjgalbe.PGLFHABMJPO();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			base.StartCoroutine(this.HHMIBFCBFID());
		}
	}

	// Token: 0x06004D47 RID: 19783 RVA: 0x00235C8C File Offset: 0x00233E8C
	private void MMIIFMNJBED(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "Horizontal")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("RollerBladeFrontFlip" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Select" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.FLLJONHPLNA(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(this.toLocId);
					epmphjgalbe.AEMAHNDEBKJ(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(151, epmphjgalbe.ALLANCHILCM());
					return;
				}
				finally
				{
					epmphjgalbe.HDKBMLOJLLC();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
			base.StartCoroutine(this.IGFJHDLJOHP());
		}
	}

	// Token: 0x06004D48 RID: 19784 RVA: 0x00235D94 File Offset: 0x00233F94
	private void HHCEBOLJBPA(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "Swim")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("MotorbikeSuperman" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Hidden/Post FX/Builtin Debug Views" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.FLLJONHPLNA(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ALNEALEKFNB(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(95, epmphjgalbe.HDEKHFOKCKI());
					return;
				}
				finally
				{
					epmphjgalbe.KNPHNLLMJKJ();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			base.StartCoroutine(this.PNPNCEKMMIJ());
		}
	}

	// Token: 0x06004D49 RID: 19785 RVA: 0x00235E9C File Offset: 0x0023409C
	private void HMFKAJACFGF(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "OneHandSwordBackSwing")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("_NoiseAmount" + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("FOG CUTTING ON" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.LHLOOIDHGMA(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.FLLJONHPLNA(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-35, epmphjgalbe.IEJLLFECFHF());
					return;
				}
				finally
				{
					epmphjgalbe.KNPHNLLMJKJ();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			base.StartCoroutine(this.BFJNOIABMOL());
		}
	}

	// Token: 0x06004D4A RID: 19786 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator PDMGNJMJNIF()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D4B RID: 19787 RVA: 0x00235FA4 File Offset: 0x002341A4
	private void LNNDNMAPAEA(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "<color='{0}'> {1} ур {2}</color>\n")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("wpn_eat8" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("BowReady2" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JIIKLOKAGIC(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ENDMKPCFKND(this.toLocId);
					epmphjgalbe.KPCGLGHDILI(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(181, epmphjgalbe.JDPHBLHOLAD());
					return;
				}
				finally
				{
					epmphjgalbe.OGPGOEJFIBO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			base.StartCoroutine(this.NOIGLMGMBGP());
		}
	}

	// Token: 0x06004D4C RID: 19788 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator PNPNCEKMMIJ()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D4D RID: 19789 RVA: 0x002360AC File Offset: 0x002342AC
	private void OnTriggerEnter(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "Player")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("****softSpawn from " + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("****softSpawn to " + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(this.toLocId);
					epmphjgalbe.GOMLLPFFPNP(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(139, epmphjgalbe.JDPHBLHOLAD());
					return;
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			base.StartCoroutine(this.NNGACOBPIFE());
		}
	}

	// Token: 0x06004D4E RID: 19790 RVA: 0x002361B4 File Offset: 0x002343B4
	private void JPEDCGMCGOO(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("_ScatterTexture" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Clear reference not set." + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.EIMEKHOFIEA(this.toLocId);
					epmphjgalbe.GOMLLPFFPNP(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(140, epmphjgalbe.HDEKHFOKCKI());
					return;
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = true;
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			base.StartCoroutine(this.GPKNOHJOHMH());
		}
	}

	// Token: 0x06004D4F RID: 19791 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator OFADGAMDFEP()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D50 RID: 19792 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator GDIMCPBJDOD()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D52 RID: 19794 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator MINJFEIGBMM()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D53 RID: 19795 RVA: 0x002362BC File Offset: 0x002344BC
	private void LELKOMPOCEL(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "- none -")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("wpn_eat1" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Screen Space Reflections" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.AEMAHNDEBKJ(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.PDEFLCIEMFF(this.toLocId);
					epmphjgalbe.JIIKLOKAGIC(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(9, epmphjgalbe.IEJLLFECFHF());
					return;
				}
				finally
				{
					epmphjgalbe.OGPGOEJFIBO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
			base.StartCoroutine(this.OFPHGLABMEH());
		}
	}

	// Token: 0x06004D54 RID: 19796 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator ONMDIDKIFPN()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D55 RID: 19797 RVA: 0x002363C4 File Offset: 0x002345C4
	private void HJEAMBIEAEA(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("{0}" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("InterfaceLang.txt" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.ALNEALEKFNB(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JIIKLOKAGIC(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-88, epmphjgalbe.JOCJNOBBELJ());
					return;
				}
				finally
				{
					epmphjgalbe.OGPGOEJFIBO();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = true;
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
			base.StartCoroutine(this.HHMIBFCBFID());
		}
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x002364CC File Offset: 0x002346CC
	private void DHIAKKIOEAN(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "Warp index out of range.")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log(" <b>®</b></color> " + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("gi_fs_itm" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.ALNEALEKFNB(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-160, epmphjgalbe.NNEAJJNCGMK());
					return;
				}
				finally
				{
					epmphjgalbe.OGPGOEJFIBO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			base.StartCoroutine(this.GDIMCPBJDOD());
		}
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x002365D4 File Offset: 0x002347D4
	private void PEHLHFDILHN(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log(" " + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Roll" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.FLLJONHPLNA(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.EIMEKHOFIEA(this.toLocId);
					epmphjgalbe.ENDMKPCFKND(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-144, epmphjgalbe.PBOPEDMCKDD());
					return;
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			base.StartCoroutine(this.PNPNCEKMMIJ());
		}
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x002366DC File Offset: 0x002348DC
	private void PFNDBONPCMK(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "signatures")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("Crouch180" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("IdleCheer" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(this.toLocId);
					epmphjgalbe.JIIKLOKAGIC(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(187, epmphjgalbe.PBOPEDMCKDD());
					return;
				}
				finally
				{
					epmphjgalbe.NCKMEIBFNGL();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
			base.StartCoroutine(this.CEHILDDPMIO());
		}
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x002367E4 File Offset: 0x002349E4
	private void JPAEKAMADCD(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "*** get repa id=")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html" + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("gi_cachshe" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.DEHJNGMHGAJ(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.LHLOOIDHGMA(this.toLocId);
					epmphjgalbe.EAOGDKDBENC(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-42, epmphjgalbe.JDPHBLHOLAD());
					return;
				}
				finally
				{
					epmphjgalbe.HDKBMLOJLLC();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = false;
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			base.StartCoroutine(this.PKFEMCLKJAL());
		}
	}

	// Token: 0x06004D5A RID: 19802 RVA: 0x002368EC File Offset: 0x00234AEC
	private void GLBECKMNECL(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "isRagulaSet")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("<color='{0}'> Очков работы: {1}</color>" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("WateringCan" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.DEHJNGMHGAJ(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JIIKLOKAGIC(this.toLocId);
					epmphjgalbe.ENDMKPCFKND(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-44, epmphjgalbe.PBOPEDMCKDD());
					return;
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			base.StartCoroutine(this.PNPNCEKMMIJ());
		}
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x002369F4 File Offset: 0x00234BF4
	private void DHFHPMAHMGP(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "INTERFACE")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("Index out of range." + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("WinVIP" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.LHLOOIDHGMA(this.toLocId);
					epmphjgalbe.PDEFLCIEMFF(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-77, epmphjgalbe.IEJLLFECFHF());
					return;
				}
				finally
				{
					epmphjgalbe.PMIGGJHLIDO();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = true;
			JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
			base.StartCoroutine(this.OFADGAMDFEP());
		}
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x00236AFC File Offset: 0x00234CFC
	private void EJFHPBJPBNB(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "MotorbikeIdle")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("click Refresh currentQcat=" + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("RollerBladeRoll" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.AEMAHNDEBKJ(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JIIKLOKAGIC(this.toLocId);
					epmphjgalbe.LHLOOIDHGMA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-161, epmphjgalbe.NNEAJJNCGMK());
					return;
				}
				finally
				{
					epmphjgalbe.PGLFHABMJPO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
			base.StartCoroutine(this.BHPAOJCHAHC());
		}
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x00236C04 File Offset: 0x00234E04
	private void KBHDEFHDGLJ(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("Hyperlink_" + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("_SampleCount" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.KPCGLGHDILI(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.KPCGLGHDILI(this.toLocId);
					epmphjgalbe.KPCGLGHDILI(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-167, epmphjgalbe.LAFILAEOPAJ());
					return;
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
			base.StartCoroutine(this.ONMDIDKIFPN());
		}
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator IGFJHDLJOHP()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x00236D0C File Offset: 0x00234F0C
	private void FCFFANBLEBO(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "Yawn")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log(" Atlas: " + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("IceHockeyShotLeft" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.PDEFLCIEMFF(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.JDOLCNDNFGP(this.toLocId);
					epmphjgalbe.EIMEKHOFIEA(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(113, epmphjgalbe.HDEKHFOKCKI());
					return;
				}
				finally
				{
					epmphjgalbe.HDKBMLOJLLC();
				}
			}
			Fisherman.getI.MIBOJMFKFGI = true;
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
			base.StartCoroutine(this.CEHILDDPMIO());
		}
	}

	// Token: 0x06004D60 RID: 19808 RVA: 0x00236E14 File Offset: 0x00235014
	private void AEIMGEFCGID(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "[maxweight]")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("Roller Blade Turn Right" + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("post_13" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.PDEFLCIEMFF(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.PDEFLCIEMFF(this.toLocId);
					epmphjgalbe.DEHJNGMHGAJ(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-153, epmphjgalbe.IEJLLFECFHF());
					return;
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
			base.StartCoroutine(this.GPKNOHJOHMH());
		}
	}

	// Token: 0x06004D61 RID: 19809 RVA: 0x00236F1C File Offset: 0x0023511C
	private void GPOJMKLGNMP(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "' is not a valid integer")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("IceHockey Pass Left" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Null" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JDOLCNDNFGP(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.LHLOOIDHGMA(this.toLocId);
					epmphjgalbe.AEMAHNDEBKJ(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-81, epmphjgalbe.IEJLLFECFHF());
					return;
				}
				finally
				{
					epmphjgalbe.KNPHNLLMJKJ();
				}
			}
			Fisherman.getI.APAPJMNFCPP(true);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			base.StartCoroutine(this.HHJCFKIOOEJ());
		}
	}

	// Token: 0x06004D62 RID: 19810 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator BFJNOIABMOL()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D63 RID: 19811 RVA: 0x00237024 File Offset: 0x00235224
	private void MIJDNMGKOKP(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "gi_uinf_3i")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("no_get" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("name" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.DEHJNGMHGAJ(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.EAOGDKDBENC(this.toLocId);
					epmphjgalbe.EAOGDKDBENC(this.toPointId);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(141, epmphjgalbe.ALLANCHILCM());
					return;
				}
				finally
				{
					epmphjgalbe.HDKBMLOJLLC();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			base.StartCoroutine(this.GDIMCPBJDOD());
		}
	}

	// Token: 0x06004D64 RID: 19812 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator ALLABAOOKNN()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D65 RID: 19813 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator HIOCJHFKNAE()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D66 RID: 19814 RVA: 0x0023712C File Offset: 0x0023532C
	private void PDEJKMAKHBK(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "_Offsets")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("WeaponStrafeRunRight" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JIIKLOKAGIC(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.DEHJNGMHGAJ(this.toLocId);
					epmphjgalbe.GOMLLPFFPNP(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-32, epmphjgalbe.JDPHBLHOLAD());
					return;
				}
				finally
				{
					epmphjgalbe.HDKBMLOJLLC();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			base.StartCoroutine(this.GDIMCPBJDOD());
		}
	}

	// Token: 0x06004D67 RID: 19815 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator BHPAOJCHAHC()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x06004D68 RID: 19816 RVA: 0x00235A6C File Offset: 0x00233C6C
	private IEnumerator NOIGLMGMBGP()
	{
		yield return new WaitForSeconds(2f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
			epmphjgalbe.GOMLLPFFPNP(this.toLocId);
			epmphjgalbe.GOMLLPFFPNP(this.toPointId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
			yield break;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		yield break;
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x00237234 File Offset: 0x00235434
	private void BHDPBMPLAJB(Collider INDANOPGHCN)
	{
		if (INDANOPGHCN.tag == "IdleSad")
		{
			if (this.softSpawn)
			{
				if (this.toLocId == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE)
				{
					return;
				}
				Debug.Log("WoodCut" + JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE);
				Debug.Log("Flap_04.wav" + this.toLocId);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EAOGDKDBENC(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.FLLJONHPLNA(this.toLocId);
					epmphjgalbe.FLLJONHPLNA(this.toPointId);
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(106, epmphjgalbe.JOCJNOBBELJ());
					return;
				}
				finally
				{
					epmphjgalbe.PGLFHABMJPO();
				}
			}
			Fisherman.getI.APAPJMNFCPP(false);
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			base.StartCoroutine(this.GDIMCPBJDOD());
		}
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x00235954 File Offset: 0x00233B54
	private IEnumerator OFPHGLABMEH()
	{
		ToLocZone.DIOAEDCNOPF dioaedcnopf = new ToLocZone.DIOAEDCNOPF(1);
		dioaedcnopf.AENJLLPLILM = this;
		return dioaedcnopf;
	}

	// Token: 0x04000BAB RID: 2987
	public int toLocId;

	// Token: 0x04000BAC RID: 2988
	public int toPointId;

	// Token: 0x04000BAD RID: 2989
	public bool softSpawn;

	// Token: 0x04000BAE RID: 2990
	public int fromLocId;
}
