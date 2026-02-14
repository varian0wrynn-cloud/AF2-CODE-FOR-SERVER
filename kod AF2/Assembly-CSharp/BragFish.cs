using System;
using UnityEngine;

// Token: 0x02000106 RID: 262
public class BragFish : MonoBehaviour
{
	// Token: 0x0600314B RID: 12619 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FKHAKIKPFFO()
	{
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x0016CA54 File Offset: 0x0016AC54
	public void ICELMKAIOGA(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 172f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.IKGFHGKKCPG.POJEMHCEPCL(this.CJEFJNNHJHO, "Body", num - 1781f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(450f, 1850f, 1424f);
			this.fmd.NJDPPOFEIHD(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.PKGMBFEMKGP().FAJIJEIJJJH(base.gameObject, "IdleStand").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 1320f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.MHFDIJGJGBJ().NHEMIPPBIKN(this.CJEFJNNHJHO, -79);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600314D RID: 12621 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DAFJMNMFOON()
	{
	}

	// Token: 0x0600314E RID: 12622 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void PKPGIGEEEJI()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x0600314F RID: 12623 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void NKNDJENDPDJ()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003150 RID: 12624 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JGCOLIFLHLP()
	{
	}

	// Token: 0x06003151 RID: 12625 RVA: 0x0016CE00 File Offset: 0x0016B000
	public void OMPMGAGBPII(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 712f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.PKGMBFEMKGP().BDLCEALCLLB(this.CJEFJNNHJHO, "Smoking 2", num - 610f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = true;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(527f, 89f, 1349f);
			this.fmd.PMMHDMKEHIE(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "1,2,3,4,5").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 600f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.PKGMBFEMKGP().KOHAPBIENMH(this.CJEFJNNHJHO, -12);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("KEyeHistogram");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x0016D19C File Offset: 0x0016B39C
	private void EFFFHHCHPIN()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(5, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 499f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(4, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NMMGHFDLNOE()
	{
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x0016D350 File Offset: 0x0016B550
	public void OPCFCKHPBAP(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.OGAOPAJFADH().DKPDBNNNDLK("IdleButtonPress" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.KBEKOPMOBPG), "");
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCNGEFBKMNC()
	{
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x0016D3B8 File Offset: 0x0016B5B8
	public void GBEEDOELOJM(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.PGPNBDMKIGO();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 436f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.IGHOGONIKLC();
			}
			JLFJEGIPIMM.NNEAHAFBOHC().COKCKOCECOA(this.CJEFJNNHJHO, " ", num - 1165f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1689f, 819f, 1069f);
			this.fmd.PMMHDMKEHIE(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "Z").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 143f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.NNEAHAFBOHC().KHKCKGNDPJB(this.CJEFJNNHJHO, -18);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("CP1");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003157 RID: 12631 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JDKKDAKIPHO()
	{
	}

	// Token: 0x06003158 RID: 12632 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MGKEEPMDANL()
	{
	}

	// Token: 0x06003159 RID: 12633 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EKCKBDKEAKO()
	{
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x0016D754 File Offset: 0x0016B954
	private void CFHDJOKLHDB()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(5, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 34f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(1, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x0600315B RID: 12635 RVA: 0x0016D908 File Offset: 0x0016BB08
	public void AEHALLANBPF(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.ENNAAFEOFAH().FNBJHBLNMKN("OfficeSittingMouseMovement" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HPJMFCKAPEA), "craft_data/categories/category");
	}

	// Token: 0x0600315C RID: 12636 RVA: 0x0016D970 File Offset: 0x0016BB70
	public void MDJMECDLEGB(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.BCLPDGODGKF().FBKDPHEGOLP("Mouse X" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.AMNLIDJEFOO), "_Params1");
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x0016D9D8 File Offset: 0x0016BBD8
	public void DHBCOHCNBOB(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.PALDDOGILLH().GLEDIDEJKHO("Sound " + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DIJNIGFFEAA), "_alfavis");
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void MGCCMKOJCCF()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x0016DA40 File Offset: 0x0016BC40
	public void HBIKIJMHIHO(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.GNHNOEIALLK();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 1709f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.HKBNODJBGEL();
			}
			JLFJEGIPIMM.NNEAHAFBOHC().BDLCEALCLLB(this.CJEFJNNHJHO, "IdleTurns", num - 587f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(661f, 282f, 226f);
			this.fmd.NJDPPOFEIHD(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "OneHandSwordJab").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 590f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.NNEAHAFBOHC().NHHJOIJFDKC(this.CJEFJNNHJHO, 117);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("RollerBladeTurnRight");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003160 RID: 12640 RVA: 0x0016DDDC File Offset: 0x0016BFDC
	private void DJODHDNKIJE()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(2, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 467f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(5, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(8, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x00022FCC File Offset: 0x000211CC
	private void INFDDDBIPAB()
	{
	}

	// Token: 0x06003162 RID: 12642 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void NLHMPJAIJKD()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x0016DF90 File Offset: 0x0016C190
	public void AMNLIDJEFOO(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.FOMMNNJLMAI(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 81f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.MHFDIJGJGBJ().POJEMHCEPCL(this.CJEFJNNHJHO, "_OcclusionColor", num - 1030f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1784f, 1271f, 1345f);
			this.fmd.FKBNCNFMMCJ(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "{0} {1}").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 544f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.MHFDIJGJGBJ().FJFAMAOEFEF(this.CJEFJNNHJHO, -85);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("Mouse ScrollWheel");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x0016E32C File Offset: 0x0016C52C
	private void AOGONMIBGJK()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(8, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 976f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(7, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(2, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003165 RID: 12645 RVA: 0x0016E4E0 File Offset: 0x0016C6E0
	public void CKHBMLJIDJA(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 981f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.NNEAHAFBOHC().BDLCEALCLLB(this.CJEFJNNHJHO, "SoccerKeeperReady", num - 319f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = true;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(79f, 1139f, 657f);
			this.fmd.GMJBFCPGGLC(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "WalkBackward").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 1635f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.NNEAHAFBOHC().NHHJOIJFDKC(this.CJEFJNNHJHO, 62);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("inv_icost");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003166 RID: 12646 RVA: 0x0016E87C File Offset: 0x0016CA7C
	private void IEEPECJPCFD()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(6, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 863f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(3, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003167 RID: 12647 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BBFCMCAFOMH()
	{
	}

	// Token: 0x06003168 RID: 12648 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BNKJNBIDPME()
	{
	}

	// Token: 0x06003169 RID: 12649 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x0600316A RID: 12650 RVA: 0x0016EA30 File Offset: 0x0016CC30
	private void DFNJNCCPKJF()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1678f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(4, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(5, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x0600316B RID: 12651 RVA: 0x0016EBE4 File Offset: 0x0016CDE4
	public void PKIAJIDLNDK(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.FGHDAENJDHK().NBKKJNFHOFE("Cowboy1HandDraw" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LAFPOODBMEG), "IdleSad");
	}

	// Token: 0x0600316C RID: 12652 RVA: 0x0016EC4C File Offset: 0x0016CE4C
	private void BOEFHGKGJMN()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(4, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1819f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(8, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(5, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BALKMKNCLOH()
	{
	}

	// Token: 0x0600316E RID: 12654 RVA: 0x0016EE00 File Offset: 0x0016D000
	private void EIEKEPGNGPL()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 504f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(4, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(5, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x0016EFB4 File Offset: 0x0016D1B4
	public void GHIOMBHKAMB(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.MNJNNDHCDGG().CLKAOEILNJB("id" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HPJMFCKAPEA), "Sitting Reading");
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DCKNNIMDPMP()
	{
	}

	// Token: 0x06003171 RID: 12657 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void OIICPEBHHKA()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DLKJAKIAFMN()
	{
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x0016F01C File Offset: 0x0016D21C
	private void LateUpdate()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(2, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 0.001f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(2, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(2, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x00022FCC File Offset: 0x000211CC
	private void INDPPKACFGC()
	{
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x0016F1D0 File Offset: 0x0016D3D0
	private void CODAMDJCPHK()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(3, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 263f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(2, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x0016F384 File Offset: 0x0016D584
	public void GIIOIACEEBI(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.DAANHKAOCKP().ANDMFEGKNIC("ECHO ON " + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HPJMFCKAPEA), "BowFire");
	}

	// Token: 0x06003177 RID: 12663 RVA: 0x0016F3EC File Offset: 0x0016D5EC
	private void IKEBNJAMNDB()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(8, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 392f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(2, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(4, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003178 RID: 12664 RVA: 0x0016F5A0 File Offset: 0x0016D7A0
	private void KPHGGOCHKFA()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(3, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1897f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(3, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LJDGIHMLNLL()
	{
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFPGMNGFLNH()
	{
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x0016F754 File Offset: 0x0016D954
	public void LAFPOODBMEG(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 763f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.HKBNODJBGEL();
			}
			JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "isRodInWater", num - 1006f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = true;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1913f, 352f, 1626f);
			this.fmd.NJDPPOFEIHD(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, "collar").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(true);
			if (this.fmd.currWgt > 258f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.PKGMBFEMKGP().FDCHPCBAMIL(this.CJEFJNNHJHO, -95);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("auk_wavg");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x0016FAF0 File Offset: 0x0016DCF0
	private void POMLHOHFIGA()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(5, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 242f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(3, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(8, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x0016FCA4 File Offset: 0x0016DEA4
	public void DJHKOCCNFIK(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.NKKDGPINOAJ().FBKDPHEGOLP("Mouse X" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DIJNIGFFEAA), "+ACVolumeProxy");
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BGLIJMGAHLP()
	{
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x0016FD0C File Offset: 0x0016DF0C
	private void JNBBPFALNFB()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1518f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(5, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(6, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void DBBGHOPCOKE()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x0016FEC0 File Offset: 0x0016E0C0
	public void EPJAFHNLEEP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.FOMMNNJLMAI(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 48f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.IKGFHGKKCPG.BDLCEALCLLB(this.CJEFJNNHJHO, " ", num - 1509f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1413f, 882f, 1575f);
			this.fmd.GMJBFCPGGLC(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "MidBlendLut").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(true);
			if (this.fmd.currWgt > 1287f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.PKGMBFEMKGP().KOHAPBIENMH(this.CJEFJNNHJHO, -79);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("FaceHit");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x0017025C File Offset: 0x0016E45C
	private void MJFJPFJICDH()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(5, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 763f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(5, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(2, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x00170410 File Offset: 0x0016E610
	public void OEDJGGEHBPO(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.DPBNHMCDIIK().HBBIEEBNJGF("[ACTk] <b>[ ObscuredString test ]</b>" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LAFPOODBMEG), "\n");
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00170478 File Offset: 0x0016E678
	public void GIPBNGINEKP(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.NPIEJELJPIM().LGBJIEGHEOC("_NoiseScale" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LAFPOODBMEG), "WATER_EDGEBLEND_ON");
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void JEILIILHBEI()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void NBENFONBILP()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void EEEELHMAIAB()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x001704E0 File Offset: 0x0016E6E0
	public void HNMDMECEPKJ(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.FOMMNNJLMAI(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.PGPNBDMKIGO();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 1868f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "i grew because the inputfield was only this big", num - 218f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(138f, 880f, 1458f);
			this.fmd.GMJBFCPGGLC(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, "qd_taskcount").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(true);
			if (this.fmd.currWgt > 494f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.PKGMBFEMKGP().KOHAPBIENMH(this.CJEFJNNHJHO, -113);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("Giant3HitCombo2");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBMKHLDOIKP()
	{
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void KCFKCLCADGM()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIFOELPAEHG()
	{
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FixedUpdate()
	{
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x0017087C File Offset: 0x0016EA7C
	public void HPJMFCKAPEA(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 1476f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.IKGFHGKKCPG.POJEMHCEPCL(this.CJEFJNNHJHO, "MotorbikeHeadstand", num - 837f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = true;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(390f, 84f, 1464f);
			this.fmd.OAELILPCHMH(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, "SUNSHINE_FILTER_PCF_3x3").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(true);
			if (this.fmd.currWgt > 1552f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.PKGMBFEMKGP().FJFAMAOEFEF(this.CJEFJNNHJHO, 25);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("IdleDie2");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00170C18 File Offset: 0x0016EE18
	private void CKCBGFMFNFK()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(4, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1465f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(1, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(7, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00170DCC File Offset: 0x0016EFCC
	public void KDMIJOFDBCO(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.BCLPDGODGKF().HBBIEEBNJGF(" " + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HPJMFCKAPEA), "RollerBladeTurnLeft");
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x00170E34 File Offset: 0x0016F034
	public void CEHPNHNGNLG(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.DPBNHMCDIIK().FBKDPHEGOLP("_FgOverlap" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HPJMFCKAPEA), "<color='#000030'>+{0} {1}</color>");
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMHBOLLCJHO()
	{
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void OnDestroy()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x00170E9C File Offset: 0x0016F09C
	public void DBOKDFIODOP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.FOMMNNJLMAI(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 1573f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.HKBNODJBGEL();
			}
			JLFJEGIPIMM.NNEAHAFBOHC().POJEMHCEPCL(this.CJEFJNNHJHO, "WallSit", num - 1374f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1478f, 1973f, 29f);
			this.fmd.LDLNEDOLAGM(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "CardPlayerLook").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 1000f)
			{
				this.KRUK.SetActive(false);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.MHFDIJGJGBJ().FJFAMAOEFEF(this.CJEFJNNHJHO, -24);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("****************** CamEffector APPLY 1");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void IDADGNCMLID()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x06003196 RID: 12694 RVA: 0x00171238 File Offset: 0x0016F438
	private void HDPICLGBICL()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(7, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1587f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(4, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(3, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x001713EC File Offset: 0x0016F5EC
	private void OGFGENJAMAM()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.KRUK.SetActive(false);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 93f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(4, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(7, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LOIPNCCDMLM()
	{
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x001715A0 File Offset: 0x0016F7A0
	public void AKCEEOAIBEP(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.OGAOPAJFADH().HBBIEEBNJGF("_RcpMaxCoC" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ICELMKAIOGA), "IceHockeyGoalieReady");
	}

	// Token: 0x0600319A RID: 12698 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MFHGOLNLAAF()
	{
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NDLLDNIOLPK()
	{
	}

	// Token: 0x0600319C RID: 12700 RVA: 0x00171608 File Offset: 0x0016F808
	public void modelLoadDone(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.CJEFJNNHJHO != null)
		{
			float num = -9999f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.IKGFHGKKCPG.COKCKOCECOA(this.CJEFJNNHJHO, "_WaterLevel", num - 100f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1f, 1f, 1f);
			this.fmd.setScaleSize(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "HookPoint").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 2000f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.CJEFJNNHJHO, 22);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("move");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	private void PJHKHDFADBK()
	{
		UnityEngine.Object.Destroy(this.gruzzPoint);
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x001719A4 File Offset: 0x0016FBA4
	public void KDHLDBOKIAO(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.IKGFHGKKCPG.FBKDPHEGOLP("_CurTex" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.GBEEDOELOJM), "dragWeapon = null 3");
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x00171A0C File Offset: 0x0016FC0C
	public void DIJNIGFFEAA(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 715f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.CDBIEPGNONF();
			}
			JLFJEGIPIMM.PKGMBFEMKGP().POJEMHCEPCL(this.CJEFJNNHJHO, "WATER_SIMPLE", num - 1505f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = true;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(1290f, 923f, 21f);
			this.fmd.setScaleSize(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "paramsup=").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(false);
			if (this.fmd.currWgt > 1228f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.MHFDIJGJGBJ().NHEMIPPBIKN(this.CJEFJNNHJHO, -109);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("https://groups.google.com/forum/#!forum/final-ik");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NPBADBGCMML()
	{
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x00171DA8 File Offset: 0x0016FFA8
	private void FHOKOPGOBIP()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(7, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1177f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(5, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(5, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x00171F5C File Offset: 0x0017015C
	private void PPIJKKNAJAC()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(7, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 990f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(2, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(5, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x00172110 File Offset: 0x00170310
	public void LKLOKKNHOPG(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.DPBNHMCDIIK().ANDMFEGKNIC("icon_data/icon" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CKHBMLJIDJA), "_NeighbourMaxTex");
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x00172178 File Offset: 0x00170378
	public void HBEFANEMBON(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.EEOPOHEALPK().CLKAOEILNJB("_MidGrey" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CKHBMLJIDJA), "_Intensity");
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x001721E0 File Offset: 0x001703E0
	public void PINGLPBONMG(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.NPCAKEGNBHD().HBBIEEBNJGF("heavy" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LAFPOODBMEG), "_Params3");
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x00172248 File Offset: 0x00170448
	public void JPOEJJHOEFJ(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.JFJBLLJNHJO().FBKDPHEGOLP("Extinguish" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DIJNIGFFEAA), "");
	}

	// Token: 0x060031A7 RID: 12711 RVA: 0x001722B0 File Offset: 0x001704B0
	public void FLNDGDIDIKF(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.CGNMLGDPGMF().ANDMFEGKNIC("wpn_add/req/reqPerk" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LAFPOODBMEG), "Get post");
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x00172318 File Offset: 0x00170518
	public void fishInstance(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK("fish/" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.modelLoadDone), "");
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x00172380 File Offset: 0x00170580
	public void DDCMPHHDMDM(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.CGNMLGDPGMF().DKPDBNNNDLK("" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ICELMKAIOGA), "Cells");
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x001723E8 File Offset: 0x001705E8
	private void GFELHLPHCDN()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = true;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(6, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1305f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(5, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(4, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x0017259C File Offset: 0x0017079C
	private void KBKONONANKH()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(4, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 813f;
		this.LR.SetPosition(0, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(0, (Fisherman.getI.IJMGCKIOBPP() != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMFOECIPBIP()
	{
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x00172750 File Offset: 0x00170950
	private void IPDFGIOPHAD()
	{
		bool flag = false;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			flag = false;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = true;
		}
		if (!flag)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(0, this.fixPoint.transform.position);
			this.LR.SetPosition(5, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 351f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(0, this.fixPoint.transform.position);
		this.LR.SetPosition(1, (Fisherman.getI.AOEGNGOGNBI != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(0, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x00172904 File Offset: 0x00170B04
	public void LKOMIACFPGI(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.FGHDAENJDHK().LGBJIEGHEOC("cntx_wpnauk" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OMPMGAGBPII), "☣ ");
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x0017296C File Offset: 0x00170B6C
	private void KCMJALIDEHB()
	{
		bool flag = true;
		if (this.FPBGFBLLENH == null)
		{
			flag = false;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			flag = true;
		}
		if (this.LIDOONPJNHJ)
		{
			flag = false;
		}
		if (!flag)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(1, this.fixPoint.transform.position);
			this.LR.SetPosition(8, this.fixPoint.transform.position);
			this.KRUK.SetActive(true);
			return;
		}
		this.lendPoint.transform.position = this.FPBGFBLLENH.transform.position - Vector3.up * 1086f;
		this.LR.SetPosition(1, this.lendPoint.transform.position);
		this.LR.SetPosition(1, this.fixPoint.transform.position);
		this.LR.SetPosition(8, (Fisherman.getI.EACGPPOMFLH() != null) ? Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() : this.fixPoint.transform.position);
		if (this.LIDOONPJNHJ)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.KRUK.activeSelf)
		{
			this.LR.SetPosition(1, this.fixPoint.transform.position);
		}
		if (this.FPBGFBLLENH != null)
		{
			this.CJEFJNNHJHO != null;
		}
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x00172B20 File Offset: 0x00170D20
	public void JGPKEKJCNOO(int OLKMHFNLBJB, float NBLJCEHNKAK, bool LLKFIPJKFOC)
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		this.ONADLMBJFCC = NBLJCEHNKAK;
		if (this.GAAPCLGDOGH == null)
		{
			return;
		}
		this.LIDOONPJNHJ = LLKFIPJKFOC;
		OMDDGEDHHNH.PALDDOGILLH().HBBIEEBNJGF("" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ICELMKAIOGA), "MotorbikeLookBack");
	}

	// Token: 0x060031B1 RID: 12721 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBOONMDONCF()
	{
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x00172B88 File Offset: 0x00170D88
	public void KBEKOPMOBPG(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.DECHOHGOAHF(this.LR);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.CJEFJNNHJHO != null)
		{
			float num = 827f;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			JLFJEGIPIMM.MHFDIJGJGBJ().POJEMHCEPCL(this.CJEFJNNHJHO, "{0:F2}, {1:F2}, {2:F2}", num - 1124f);
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.eulerAngles = this.modelContainer.transform.eulerAngles;
			this.CJEFJNNHJHO.transform.localScale = this.modelContainer.transform.localScale;
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
			if (this.fmd == null)
			{
				this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
				this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
				this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
				this.fmd.useGraf = false;
			}
			this.CJEFJNNHJHO.transform.parent = this.modelContainer.transform;
			this.CJEFJNNHJHO.transform.localRotation = Quaternion.identity;
			this.CJEFJNNHJHO.transform.localPosition = Vector3.zero;
			this.CJEFJNNHJHO.transform.localScale = new Vector3(64f, 1886f, 1511f);
			this.fmd.BDHJCHDFGLG(this.ONADLMBJFCC);
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "HookPoint").transform;
			}
			if (this.fmd.hookPoint == null)
			{
				this.fmd.hookPoint = base.gameObject.transform;
			}
			this.FPBGFBLLENH = this.fmd.hookPoint;
			this.KRUK.SetActive(true);
			if (this.fmd.currWgt > 545f)
			{
				this.KRUK.SetActive(true);
			}
			if (this.FPBGFBLLENH != null)
			{
				this.CJEFJNNHJHO != null;
			}
			Vector3 b = this.FPBGFBLLENH.position - this.modelContainer.transform.position;
			this.CJEFJNNHJHO.transform.position = this.modelContainer.transform.position - b;
			JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(this.CJEFJNNHJHO, -109);
			this.gruzzPoint.transform.parent = null;
			Rigidbody component = this.gruzzPoint.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			Animation animation = base.gameObject.GetComponent<Animation>();
			if (animation == null)
			{
				animation = base.gameObject.GetComponentInChildren<Animation>();
			}
			try
			{
				if (animation != null)
				{
					animation.Play("");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0400071B RID: 1819
	public LineRenderer LR;

	// Token: 0x0400071C RID: 1820
	public GameObject modelContainer;

	// Token: 0x0400071D RID: 1821
	public GameObject fixPoint;

	// Token: 0x0400071E RID: 1822
	public GameObject KRUK;

	// Token: 0x0400071F RID: 1823
	public GameObject lendPoint;

	// Token: 0x04000720 RID: 1824
	public GameObject gruzzPoint;

	// Token: 0x04000721 RID: 1825
	private Transform FPBGFBLLENH;

	// Token: 0x04000722 RID: 1826
	private GameObject CJEFJNNHJHO;

	// Token: 0x04000723 RID: 1827
	private IDCHHHEDHDC GAAPCLGDOGH;

	// Token: 0x04000724 RID: 1828
	private float ONADLMBJFCC;

	// Token: 0x04000725 RID: 1829
	private bool LIDOONPJNHJ;

	// Token: 0x04000726 RID: 1830
	public FishModelData fmd;
}
