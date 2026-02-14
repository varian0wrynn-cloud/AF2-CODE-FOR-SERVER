using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000103 RID: 259
public class ActorFish : MonoBehaviour
{
	// Token: 0x0600309A RID: 12442 RVA: 0x00161C68 File Offset: 0x0015FE68
	private void IFINKBGCKML()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("Move");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 472f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1508f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 6f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 1964f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1961f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 162f;
				Quaternion b3 = Quaternion.Euler(1714f, 1334f + this.OPIAODBJFEC, 1984f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 605f, 1886f, 421f));
			}
		}
	}

	// Token: 0x0600309B RID: 12443 RVA: 0x00161EC4 File Offset: 0x001600C4
	public void MBBAGMHBMFC()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(base.transform.position, 1240f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 725f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().JNFGOGFFLKK(1974.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x00161F68 File Offset: 0x00160168
	public void KEKCLJGNOCD()
	{
		LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 414f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 738f;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.GCPGDOACKLG(710.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x0600309D RID: 12445 RVA: 0x0016200C File Offset: 0x0016020C
	private void CBLGFOFHNPJ()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 777f)
		{
			value = 916f - (1068f - this.wgt) * 1192f;
		}
		else
		{
			value = 1795f + (this.wgt - 356f) * 73f;
		}
		value = Mathf.Clamp(value, 1911f, 1774f);
		this.fishModelTemplate.transform.localScale = new Vector3(857f, 1766f, 1839f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "WizardNeoBlock")
			{
				OMDDGEDHHNH.DPBNHMCDIIK().DKPDBNNNDLK("<color='#100000'>{0} {1}</color>" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.FCFNGKFBDAP), "IdleStun");
			}
			else
			{
				Debug.LogError("titul_" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("OfficeSittingBack" + ex.StackTrace);
		}
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x00162134 File Offset: 0x00160334
	public void DBFEFCANIKL(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().FAJIJEIJJJH(base.gameObject, "wpn_wgt");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.LFHPJGAPPCC();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().BDLCEALCLLB(this.CJEFJNNHJHO, "ActorFish_", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, "_Bloom_DirtTex");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().NHEMIPPBIKN(this.CJEFJNNHJHO, -67);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x00162364 File Offset: 0x00160564
	public void DFGMHFOMBKH()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(base.transform.position, 1051f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1117f;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.GKDBPBFOINB(1390.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x00162408 File Offset: 0x00160608
	private void HNAKGHHGDPE()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("u_UniqueShadowTexture");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 1865f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 780f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 773f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 1000f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 758f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1787f;
				Quaternion b3 = Quaternion.Euler(145f, 1428f + this.OPIAODBJFEC, 530f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1085f, 82f, 1355f));
			}
		}
	}

	// Token: 0x060030A1 RID: 12449 RVA: 0x00162664 File Offset: 0x00160864
	public void JAJIPBNNBHK(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().FAJIJEIJJJH(base.gameObject, "__b");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().POJEMHCEPCL(this.CJEFJNNHJHO, "Blending ", LocNewLogic.getI.OGJHINOLHJJ);
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().FAJIJEIJJJH(base.gameObject, "PaperTurn.wav");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.LDLNEDOLAGM(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().NHHJOIJFDKC(this.CJEFJNNHJHO, 116);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x00162894 File Offset: 0x00160A94
	public void DJFDKNDJMIE()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 657f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1751f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().LLNEEEJIDGI(1916.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x00162938 File Offset: 0x00160B38
	private void HEMEEOGJDOE()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 1454f)
		{
			value = 971f - (1327f - this.wgt) * 1028f;
		}
		else
		{
			value = 688f + (this.wgt - 3f) * 331f;
		}
		value = Mathf.Clamp(value, 8f, 1213f);
		this.fishModelTemplate.transform.localScale = new Vector3(680f, 791f, 1230f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "_Intensity")
			{
				OMDDGEDHHNH.IKGFHGKKCPG.LGBJIEGHEOC("WeaponStrafeRunLeft" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.MPJNABEBKHC), "_TrStartYou.ogg");
			}
			else
			{
				Debug.LogError("End.tif" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("FactoryTempTexture" + ex.StackTrace);
		}
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x00162A60 File Offset: 0x00160C60
	public void NPHOFGHOGKJ(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "cntx_close");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCCMKOPELGK();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "LookUp", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "Idle 90 Deg Turns");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.MAMHGLDAKKL(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().NHHJOIJFDKC(this.CJEFJNNHJHO, -109);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x00162C90 File Offset: 0x00160E90
	private void CGOCFLOAOKC()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 830f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1709f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 350f;
				a.y = LocNewLogic.getI.IGHOGONIKLC() - 452f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1314f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1009f;
				Quaternion b3 = Quaternion.Euler(91f, 1267f + this.OPIAODBJFEC, 1635f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1917f, 1523f, 1575f));
			}
		}
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x00162EEC File Offset: 0x001610EC
	private void FAGCCPMNMED()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("   ");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 779f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1269f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1854f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 1426f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 582f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 555f;
				Quaternion b3 = Quaternion.Euler(1844f, 1079f + this.OPIAODBJFEC, 1660f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1772f, 1959f, 1147f));
			}
		}
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x00163148 File Offset: 0x00161348
	public void MHDDGKDDHDE()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 1249f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 889f;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().GKDBPBFOINB(1796.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x001631EC File Offset: 0x001613EC
	public void APNNLKGGEBO()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 1290f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1699f;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().JNFGOGFFLKK(1076.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x00163290 File Offset: 0x00161490
	public void PHBDJABBDHP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "move");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.LFHPJGAPPCC();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.POJEMHCEPCL(this.CJEFJNNHJHO, "_Histogram", LocNewLogic.getI.IGHOGONIKLC());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "fishSPEED=");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.setScaleSize(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().KHKCKGNDPJB(this.CJEFJNNHJHO, -3);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x001634C0 File Offset: 0x001616C0
	private void FixedUpdate()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("******* Actor fish destroy");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 0.2f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 2f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 0.2f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 4f;
				Quaternion b3 = Quaternion.Euler(270f, 90f + this.OPIAODBJFEC, 0f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 2f, 0f, 1f));
			}
		}
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x0016371C File Offset: 0x0016191C
	private void CKGPEFOKKNL()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 0f)
		{
			value = 1671f - (1939f - this.wgt) * 904f;
		}
		else
		{
			value = 632f + (this.wgt - 1575f) * 123f;
		}
		value = Mathf.Clamp(value, 475f, 348f);
		this.fishModelTemplate.transform.localScale = new Vector3(114f, 1816f, 372f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "H:mm:ss")
			{
				OMDDGEDHHNH.OGAOPAJFADH().NBKKJNFHOFE("Actor_" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DDMMOIMMPKB), "error.wav");
			}
			else
			{
				Debug.LogError("post_3" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Fist Pump" + ex.StackTrace);
		}
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x00163844 File Offset: 0x00161A44
	private void OLBDJCFPKFG()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 1802f)
		{
			value = 500f - (10f - this.wgt) * 908f;
		}
		else
		{
			value = 493f + (this.wgt - 19f) * 1867f;
		}
		value = Mathf.Clamp(value, 513f, 1282f);
		this.fishModelTemplate.transform.localScale = new Vector3(1513f, 1838f, 1812f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "invn_rec13")
			{
				OMDDGEDHHNH.FEJILBICKGG().GLEDIDEJKHO("IdleStand" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.PHBDJABBDHP), "wtype");
			}
			else
			{
				Debug.LogError("Yawn" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("OfficeSittingReadingCoffeeSip" + ex.StackTrace);
		}
	}

	// Token: 0x060030AD RID: 12461 RVA: 0x0016396C File Offset: 0x00161B6C
	private void HLKJKCKBELP()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("_MaxSteps");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 522f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 58f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 639f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 735f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 599f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1390f;
				Quaternion b3 = Quaternion.Euler(1121f, 1432f + this.OPIAODBJFEC, 1804f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1101f, 335f, 1363f));
			}
		}
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x00163BC8 File Offset: 0x00161DC8
	private void FBFLOJPKHIO()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("GiantGrabIdle2");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 1652f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 796f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1076f;
				a.y = LocNewLogic.getI.IGHOGONIKLC() - 797f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1176f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1701f;
				Quaternion b3 = Quaternion.Euler(1462f, 1653f + this.OPIAODBJFEC, 1835f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1168f, 1322f, 1471f));
			}
		}
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x00163E24 File Offset: 0x00162024
	private void JPPDLBFHPCG()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("Sonar_pos");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 652f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 950f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 639f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 82f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 757f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1978f;
				Quaternion b3 = Quaternion.Euler(433f, 469f + this.OPIAODBJFEC, 1571f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1938f, 1803f, 842f));
			}
		}
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x00164080 File Offset: 0x00162280
	public void CIFCEFPKMNB(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "_SecondTex");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().COKCKOCECOA(this.CJEFJNNHJHO, "sys", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "cht_msg25");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().NHEMIPPBIKN(this.CJEFJNNHJHO, 17);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x001642B0 File Offset: 0x001624B0
	private void EJGEDEGLOAN()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("ObscuredBool vs bool, ");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 912f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1756f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1868f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 529f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1853f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 747f;
				Quaternion b3 = Quaternion.Euler(1556f, 631f + this.OPIAODBJFEC, 190f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1741f, 722f, 700f));
			}
		}
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x0016450C File Offset: 0x0016270C
	private void FJGIBCHABIG()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 474f)
		{
			value = 1543f - (1399f - this.wgt) * 1153f;
		}
		else
		{
			value = 1428f + (this.wgt - 1460f) * 1897f;
		}
		value = Mathf.Clamp(value, 602f, 661f);
		this.fishModelTemplate.transform.localScale = new Vector3(1621f, 449f, 1539f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "")
			{
				OMDDGEDHHNH.NPCAKEGNBHD().DKPDBNNNDLK("_WrinkleNormalMap0" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.AMNLIDJEFOO), "noworkpoints");
			}
			else
			{
				Debug.LogError("_rcIn.ogg" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("subtype" + ex.StackTrace);
		}
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x00164634 File Offset: 0x00162834
	private void PHNCOOACJEA()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("refine");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 315f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1075f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1366f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 543f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1102f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 713f;
				Quaternion b3 = Quaternion.Euler(79f, 1286f + this.OPIAODBJFEC, 1756f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 279f, 1189f, 1073f));
			}
		}
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x00164890 File Offset: 0x00162A90
	public void NJIKEHGBHGC(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "_LogLut");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().POJEMHCEPCL(this.CJEFJNNHJHO, " x", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "wtype");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.GMJBFCPGGLC(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(this.CJEFJNNHJHO, -16);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x00164AC0 File Offset: 0x00162CC0
	private void LHJCHPFKGDB()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 66f)
		{
			value = 1921f - (1707f - this.wgt) * 726f;
		}
		else
		{
			value = 1425f + (this.wgt - 875f) * 176f;
		}
		value = Mathf.Clamp(value, 241f, 590f);
		this.fishModelTemplate.transform.localScale = new Vector3(1446f, 690f, 879f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "<color='#ff8040'>")
			{
				OMDDGEDHHNH.NPIEJELJPIM().LGBJIEGHEOC("RollerBladeFrontFlip" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ACAGKNLNMJO), "no_time_period");
			}
			else
			{
				Debug.LogError("sound" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("fishspincatch" + ex.StackTrace);
		}
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x00164BE8 File Offset: 0x00162DE8
	public void PDDMGOBACIE()
	{
		LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 532f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 425f;
		this.OPIAODBJFEC = OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC(813.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x00164C8C File Offset: 0x00162E8C
	public void BHIDIKGOIBK()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 1080f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 305f;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.LLNEEEJIDGI(1446.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x00164D30 File Offset: 0x00162F30
	public void ICKLAPEJMDD()
	{
		LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 1373f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 256f;
		this.OPIAODBJFEC = OLPINJLCKCI.ODDOIHEPICE().GCGEHNMEDIL(741.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x00164DD4 File Offset: 0x00162FD4
	private void EMOFBHIJHLL()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 533f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 604f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1373f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 388f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1838f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1687f;
				Quaternion b3 = Quaternion.Euler(1365f, 1220f + this.OPIAODBJFEC, 168f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 233f, 628f, 1771f));
			}
		}
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x00165030 File Offset: 0x00163230
	public void PAOGBEGCIGM()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(base.transform.position, 727f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 819f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().GKDBPBFOINB(1847.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x001650D4 File Offset: 0x001632D4
	public void modelLoadDone(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "FishModel");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.COKCKOCECOA(this.CJEFJNNHJHO, "_WaterLevel", LocNewLogic.getI.OGJHINOLHJJ);
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "HookPoint");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.setScaleSize(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.CJEFJNNHJHO, 22);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030BD RID: 12477 RVA: 0x00165304 File Offset: 0x00163504
	public void AFKCGOFHBNP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "teech_perk");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.CPHOPIMGFBI();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().COKCKOCECOA(this.CJEFJNNHJHO, "Проверка предмета", LocNewLogic.getI.OGJHINOLHJJ);
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "Breakdancing");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.HMJMBCFBPCO(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().FDCHPCBAMIL(this.CJEFJNNHJHO, -75);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030BE RID: 12478 RVA: 0x00165534 File Offset: 0x00163734
	public void EKEDNFOBJGO()
	{
		LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 339f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1896f;
		this.OPIAODBJFEC = OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC(1343.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x001655D8 File Offset: 0x001637D8
	private void NBMEALDCCMM()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("IdleSandCover");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 1740f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 408f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 694f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 17f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 530f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 197f;
				Quaternion b3 = Quaternion.Euler(1615f, 1956f + this.OPIAODBJFEC, 588f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1790f, 1799f, 53f));
			}
		}
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x00165834 File Offset: 0x00163A34
	public void LPBPPEAEPCH(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "DealerFan");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCCMKOPELGK();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().BDLCEALCLLB(this.CJEFJNNHJHO, "\n", LocNewLogic.getI.IGHOGONIKLC());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.OAELILPCHMH(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().KOHAPBIENMH(this.CJEFJNNHJHO, -110);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x00165A64 File Offset: 0x00163C64
	private void NNNJNKDGLDF()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("_SunColor");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 1937f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 645f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 226f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 335f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1961f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 613f;
				Quaternion b3 = Quaternion.Euler(1627f, 1643f + this.OPIAODBJFEC, 871f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1099f, 1402f, 1289f));
			}
		}
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x00165CC0 File Offset: 0x00163EC0
	public void OILAIKICICF()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 1020f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 492f;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().GCPGDOACKLG(123.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x00165D64 File Offset: 0x00163F64
	public void LIMDALMLMIE()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AJFODOCHBNH(base.transform.position, 1264f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 108f;
		this.OPIAODBJFEC = OLPINJLCKCI.ODDOIHEPICE().JJKCBOPPOHJ(1607.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x00165E08 File Offset: 0x00164008
	public void EFFGCIMIKJG()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(base.transform.position, 162f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1465f;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().JJPHLJNMPHC(784.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030C5 RID: 12485 RVA: 0x00165EAC File Offset: 0x001640AC
	public void AMNLIDJEFOO(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "[ACTk] <b>[ ObscuredVector3 test ]</b>");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.GNHNOEIALLK();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().POJEMHCEPCL(this.CJEFJNNHJHO, "holesAll", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.BDHJCHDFGLG(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().FJFAMAOEFEF(this.CJEFJNNHJHO, -84);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x001660DC File Offset: 0x001642DC
	private void EAOPJLPOALK()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("SwimFreestyle");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 1054f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1345f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 320f;
				a.y = LocNewLogic.getI.IGHOGONIKLC() - 1176f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 749f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 794f;
				Quaternion b3 = Quaternion.Euler(712f, 1586f + this.OPIAODBJFEC, 1678f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1354f, 1573f, 1301f));
			}
		}
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x00166338 File Offset: 0x00164538
	private void JFFPLABGMNF()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 724f)
		{
			value = 1512f - (678f - this.wgt) * 710f;
		}
		else
		{
			value = 1181f + (this.wgt - 332f) * 702f;
		}
		value = Mathf.Clamp(value, 1493f, 216f);
		this.fishModelTemplate.transform.localScale = new Vector3(379f, 714f, 1854f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "_ReflectionTexture2")
			{
				OMDDGEDHHNH.FCNIKNBOFOJ().CLKAOEILNJB("invn_rec21" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NPHOFGHOGKJ), "");
			}
			else
			{
				Debug.LogError("Crouch" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Lash" + ex.StackTrace);
		}
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x00166460 File Offset: 0x00164660
	public void PKLKHEGJPLP()
	{
		LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AJFODOCHBNH(base.transform.position, 687f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1652f;
		this.OPIAODBJFEC = OLPINJLCKCI.IFLFANPMLMM().KCHMDLAGEJF(1661.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x00166504 File Offset: 0x00164704
	public void MPJNABEBKHC(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "MotorbikeSuperman");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "Mouse X", LocNewLogic.getI.OGJHINOLHJJ);
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "ProneIdle");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.ONGMBCCEHKK(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().KOHAPBIENMH(this.CJEFJNNHJHO, -57);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x00166734 File Offset: 0x00164934
	private void MNEBLODGADC()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("_ReflectionTexture3");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 652f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1732f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 574f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 1251f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1705f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 267f;
				Quaternion b3 = Quaternion.Euler(81f, 998f + this.OPIAODBJFEC, 1449f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1501f, 268f, 280f));
			}
		}
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x00166990 File Offset: 0x00164B90
	private void GPNLIIOPFLI()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("usetime");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 1389f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1517f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1934f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 1832f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1185f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 716f;
				Quaternion b3 = Quaternion.Euler(1309f, 753f + this.OPIAODBJFEC, 1635f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 304f, 1026f, 1627f));
			}
		}
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x00166BEC File Offset: 0x00164DEC
	public void DLNKLEMNKDM()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 990f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 935f;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.JJKCBOPPOHJ(995.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x00166C90 File Offset: 0x00164E90
	public void CEKLHJMOPAM(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().FAJIJEIJJJH(base.gameObject, "_Refraction");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().POJEMHCEPCL(this.CJEFJNNHJHO, "Vertical", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "Flap_02.wav");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.NJDPPOFEIHD(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().FDCHPCBAMIL(this.CJEFJNNHJHO, 24);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x00166EC0 File Offset: 0x001650C0
	private void LOIPNCCDMLM()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("Variables protection");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 900f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 576f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1885f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 648f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1286f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 283f;
				Quaternion b3 = Quaternion.Euler(272f, 1626f + this.OPIAODBJFEC, 1958f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 468f, 717f, 1059f));
			}
		}
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x0016711C File Offset: 0x0016531C
	private void MODJFGGIAHD()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 222f)
		{
			value = 1687f - (389f - this.wgt) * 1933f;
		}
		else
		{
			value = 1020f + (this.wgt - 233f) * 258f;
		}
		value = Mathf.Clamp(value, 1237f, 1180f);
		this.fishModelTemplate.transform.localScale = new Vector3(1227f, 1282f, 1935f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != " ms")
			{
				OMDDGEDHHNH.NPIEJELJPIM().DKPDBNNNDLK("" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.AFKCGOFHBNP), "' that does not excist in the Node Chain.");
			}
			else
			{
				Debug.LogError("\n" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Head" + ex.StackTrace);
		}
	}

	// Token: 0x060030D0 RID: 12496 RVA: 0x00167244 File Offset: 0x00165444
	private void EJJCEIAGKNK()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("teech_perk");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 1743f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 581f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 12f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 1469f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 746f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 866f;
				Quaternion b3 = Quaternion.Euler(1229f, 1299f + this.OPIAODBJFEC, 1267f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1196f, 1947f, 1401f));
			}
		}
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x001674A0 File Offset: 0x001656A0
	private void ELFLOPJDAKK()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1720f)
		{
			value = 1642f - (722f - this.wgt) * 571f;
		}
		else
		{
			value = 1355f + (this.wgt - 17f) * 1272f;
		}
		value = Mathf.Clamp(value, 391f, 311f);
		this.fishModelTemplate.transform.localScale = new Vector3(424f, 1595f, 924f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "UI_MapWindow_b")
			{
				OMDDGEDHHNH.NLIONDPCKHJ().GLEDIDEJKHO("WoodSaw" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.modelLoadDone), "1HandSwordJabFootPush");
			}
			else
			{
				Debug.LogError("move" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError(" " + ex.StackTrace);
		}
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x001675C8 File Offset: 0x001657C8
	public void HAPBAOODODC(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().FAJIJEIJJJH(base.gameObject, " point=");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().BDLCEALCLLB(this.CJEFJNNHJHO, "_AdaptationMax", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "+");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.PMMHDMKEHIE(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.KHKCKGNDPJB(this.CJEFJNNHJHO, -22);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x001677F8 File Offset: 0x001659F8
	private void FIJKDFIMELM()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 1888f)
		{
			value = 1523f - (880f - this.wgt) * 1496f;
		}
		else
		{
			value = 284f + (this.wgt - 756f) * 1025f;
		}
		value = Mathf.Clamp(value, 1942f, 1269f);
		this.fishModelTemplate.transform.localScale = new Vector3(945f, 103f, 1657f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "Sound ")
			{
				OMDDGEDHHNH.GDDAGIILGGM().LGBJIEGHEOC("ALP=" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DBFEFCANIKL), "already_exist");
			}
			else
			{
				Debug.LogError("#004000" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("setCurrentRod sm (профиль)=" + ex.StackTrace);
		}
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x00167920 File Offset: 0x00165B20
	public void DKKOHJJNLLO()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AJFODOCHBNH(base.transform.position, 1441f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1764f;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().BCODBMGPBFJ(1832.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030D5 RID: 12501 RVA: 0x001679C4 File Offset: 0x00165BC4
	public void BNDNLCDCLNN()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(base.transform.position, 1308f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1626f;
		this.OPIAODBJFEC = OLPINJLCKCI.ODDOIHEPICE().GKDBPBFOINB(166.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030D6 RID: 12502 RVA: 0x00167A68 File Offset: 0x00165C68
	private void ENOHCEKJCBI()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("recept");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 925f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 567f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1771f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 456f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 535f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 638f;
				Quaternion b3 = Quaternion.Euler(767f, 1577f + this.OPIAODBJFEC, 1305f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 985f, 1548f, 488f));
			}
		}
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x00167CC4 File Offset: 0x00165EC4
	public void ACAGKNLNMJO(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "[curcnt]");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.CPHOPIMGFBI();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().BDLCEALCLLB(this.CJEFJNNHJHO, " ms", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "WallRunLeft");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.NHEMIPPBIKN(this.CJEFJNNHJHO, 92);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030D8 RID: 12504 RVA: 0x00167EF4 File Offset: 0x001660F4
	private void COMGGKGILHC()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("CrouchWalkBackward");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 140f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1906f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1660f;
				a.y = LocNewLogic.getI.IGHOGONIKLC() - 114f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1144f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1799f;
				Quaternion b3 = Quaternion.Euler(373f, 887f + this.OPIAODBJFEC, 140f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1115f, 1160f, 1651f));
			}
		}
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x00168150 File Offset: 0x00166350
	private void Start()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 100f)
		{
			value = 1f - (100f - this.wgt) * 0.005f;
		}
		else
		{
			value = 1f + (this.wgt - 100f) * 0.001f;
		}
		value = Mathf.Clamp(value, 0.5f, 3f);
		this.fishModelTemplate.transform.localScale = new Vector3(1f, 1f, 1f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "")
			{
				OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK("fish/" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.modelLoadDone), "");
			}
			else
			{
				Debug.LogError("fisht.modelName empty! fid=" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Exception e " + ex.StackTrace);
		}
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x00168278 File Offset: 0x00166478
	private void IAGDKFGKPGG()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("QTaskMgr is INIT");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.IGHOGONIKLC() - 796f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1458f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1680f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 152f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1779f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 305f;
				Quaternion b3 = Quaternion.Euler(347f, 1068f + this.OPIAODBJFEC, 710f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1507f, 36f, 867f));
			}
		}
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x001684D4 File Offset: 0x001666D4
	public void IKEBDCOINJI(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "Idle Sad Hips");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "BackPress", LocNewLogic.getI.OGJHINOLHJJ);
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, "<color='");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.MAMHGLDAKKL(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(this.CJEFJNNHJHO, -127);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030DC RID: 12508 RVA: 0x00168704 File Offset: 0x00166904
	private void IIKDDILLGLF()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1571f)
		{
			value = 1844f - (93f - this.wgt) * 1475f;
		}
		else
		{
			value = 124f + (this.wgt - 231f) * 1763f;
		}
		value = Mathf.Clamp(value, 120f, 1929f);
		this.fishModelTemplate.transform.localScale = new Vector3(238f, 157f, 1279f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "12")
			{
				OMDDGEDHHNH.JMHOODFAGAM().LGBJIEGHEOC("Point" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.JAJIPBNNBHK), "Hidden/Fast Approximate Anti-aliasing");
			}
			else
			{
				Debug.LogError("Enable SSAO" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Fly Up" + ex.StackTrace);
		}
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x0016882C File Offset: 0x00166A2C
	private void JHAPJJGJPMN()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("Idle180");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.CDBIEPGNONF() - 526f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 907f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 878f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 1317f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 894f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 763f;
				Quaternion b3 = Quaternion.Euler(1862f, 584f + this.OPIAODBJFEC, 1782f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1086f, 891f, 50f));
			}
		}
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x00168A88 File Offset: 0x00166C88
	public void CCAGPNENEHG()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 306f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1027f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().JNFGOGFFLKK(1733.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x00168B2C File Offset: 0x00166D2C
	private void IMOOAKOBJOG()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("repair.ogg");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 1435f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1822f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1835f;
				a.y = LocNewLogic.getI.CDBIEPGNONF() - 1561f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 923f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1490f;
				Quaternion b3 = Quaternion.Euler(874f, 1389f + this.OPIAODBJFEC, 1290f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 595f, 1837f, 1785f));
			}
		}
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x00168D88 File Offset: 0x00166F88
	public void OHKFAHOBNLF()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 1852f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 1821f;
		this.OPIAODBJFEC = OLPINJLCKCI.ODDOIHEPICE().GCGEHNMEDIL(1292.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x00168E2C File Offset: 0x0016702C
	public void KBLHIBJKNEO()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(base.transform.position, 1548f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1056f;
		this.OPIAODBJFEC = OLPINJLCKCI.OBDBAABBAKB().JJKCBOPPOHJ(1769.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x00168ED0 File Offset: 0x001670D0
	public void getEvent()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 0.3f);
		this.isGetFromWater = true;
		this.ELJLAHGONMF = 0f;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(120.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x00168F74 File Offset: 0x00167174
	private void FCCAIANLEFE()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 1716f)
		{
			value = 314f - (413f - this.wgt) * 1477f;
		}
		else
		{
			value = 723f + (this.wgt - 1426f) * 1252f;
		}
		value = Mathf.Clamp(value, 240f, 1804f);
		this.fishModelTemplate.transform.localScale = new Vector3(1944f, 1047f, 487f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != ".png")
			{
				OMDDGEDHHNH.JFJBLLJNHJO().GLEDIDEJKHO("[name]" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CEKLHJMOPAM), "str=");
			}
			else
			{
				Debug.LogError("basePar" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("error" + ex.StackTrace);
		}
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x0016909C File Offset: 0x0016729C
	public void PHJNIADKDKP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "crft_qlt");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.MKJJJBAJGPO();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.COKCKOCECOA(this.CJEFJNNHJHO, "cht_umsg10", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.IKGFHGKKCPG.FDCHPCBAMIL(this.CJEFJNNHJHO, -121);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x001692CC File Offset: 0x001674CC
	private void ELADFDNPOOI()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1292f)
		{
			value = 1194f - (1801f - this.wgt) * 1448f;
		}
		else
		{
			value = 360f + (this.wgt - 1445f) * 1679f;
		}
		value = Mathf.Clamp(value, 1981f, 1051f);
		this.fishModelTemplate.transform.localScale = new Vector3(1586f, 445f, 964f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "_ArScale")
			{
				OMDDGEDHHNH.FGHDAENJDHK().DCGIKMIBALD("_AccumulationTex" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CIFCEFPKMNB), "OneHandSwordBlock");
			}
			else
			{
				Debug.LogError("auc_wsbor" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("_Intensity" + ex.StackTrace);
		}
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x001693F4 File Offset: 0x001675F4
	private void GIADAJFBIOP()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 1114f)
		{
			value = 846f - (31f - this.wgt) * 36f;
		}
		else
		{
			value = 1507f + (this.wgt - 1195f) * 1497f;
		}
		value = Mathf.Clamp(value, 277f, 1223f);
		this.fishModelTemplate.transform.localScale = new Vector3(1870f, 1277f, 1754f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "KatanaReady")
			{
				OMDDGEDHHNH.IMLLGEMPHAP().DKPDBNNNDLK("Pistol Quick Stab" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.IKEBDCOINJI), "OneHandSwordRun");
			}
			else
			{
				Debug.LogError("BowReady" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("IdleStand" + ex.StackTrace);
		}
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x0016951C File Offset: 0x0016771C
	public void MIJEMIJFOGH()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AJFODOCHBNH(base.transform.position, 848f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1599f;
		this.OPIAODBJFEC = OLPINJLCKCI.ODDOIHEPICE().KCHMDLAGEJF(172.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x001695C0 File Offset: 0x001677C0
	public void MJIFPEPLJEH()
	{
		LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 306f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1479f;
		this.OPIAODBJFEC = OLPINJLCKCI.OBDBAABBAKB().GKDBPBFOINB(418.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x00169664 File Offset: 0x00167864
	private void LPNDCJKAKEA()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1518f)
		{
			value = 1296f - (1284f - this.wgt) * 1309f;
		}
		else
		{
			value = 1217f + (this.wgt - 460f) * 166f;
		}
		value = Mathf.Clamp(value, 718f, 1514f);
		this.fishModelTemplate.transform.localScale = new Vector3(710f, 1820f, 16f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "StaffAttack")
			{
				OMDDGEDHHNH.JFJBLLJNHJO().FNBJHBLNMKN("VaderChoke" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NPHOFGHOGKJ), "Start Interaction With ");
			}
			else
			{
				Debug.LogError("</color>" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("" + ex.StackTrace);
		}
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x0016978C File Offset: 0x0016798C
	private void NCALLFHEAGJ()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 499f)
		{
			value = 652f - (538f - this.wgt) * 1785f;
		}
		else
		{
			value = 1961f + (this.wgt - 352f) * 1194f;
		}
		value = Mathf.Clamp(value, 735f, 439f);
		this.fishModelTemplate.transform.localScale = new Vector3(1428f, 1418f, 873f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "buyVIP OK")
			{
				OMDDGEDHHNH.MNJNNDHCDGG().DKPDBNNNDLK("SoccerKeeperDiveStrafeFarLeft" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.PHJNIADKDKP), "");
			}
			else
			{
				Debug.LogError("_CurveTex" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("DeadmanFloat" + ex.StackTrace);
		}
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x001698B4 File Offset: 0x00167AB4
	public void IGHBJMAJJJN(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "_WaveOffset");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().COKCKOCECOA(this.CJEFJNNHJHO, "Move around with WASD keys. Press C to disable free look camera", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "Lasso");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().NHEMIPPBIKN(this.CJEFJNNHJHO, 29);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x00169AE4 File Offset: 0x00167CE4
	private void LMEJKAEIDCO()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1926f)
		{
			value = 795f - (708f - this.wgt) * 1958f;
		}
		else
		{
			value = 805f + (this.wgt - 1000f) * 1606f;
		}
		value = Mathf.Clamp(value, 495f, 1469f);
		this.fishModelTemplate.transform.localScale = new Vector3(388f, 61f, 582f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "shortCostumeId=")
			{
				OMDDGEDHHNH.JMHOODFAGAM().NBKKJNFHOFE("camouflage_scale" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LPBPPEAEPCH), "UnityEngine.Vector3");
			}
			else
			{
				Debug.LogError("{0}.{1}.{2}" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("Obscured type cheating detected!" + ex.StackTrace);
		}
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x00169C0C File Offset: 0x00167E0C
	private void INDGOHJGCFN()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 232f)
		{
			value = 419f - (1283f - this.wgt) * 465f;
		}
		else
		{
			value = 1255f + (this.wgt - 1860f) * 875f;
		}
		value = Mathf.Clamp(value, 652f, 694f);
		this.fishModelTemplate.transform.localScale = new Vector3(818f, 936f, 260f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "repair.ogg")
			{
				OMDDGEDHHNH.GDDAGIILGGM().DKPDBNNNDLK("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NJIKEHGBHGC), "Hidden/Post FX/FXAA");
			}
			else
			{
				Debug.LogError("repair.ogg" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("_mesh" + ex.StackTrace);
		}
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x00169D34 File Offset: 0x00167F34
	private void KFGKKLAKFGH()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 1845f)
		{
			value = 831f - (307f - this.wgt) * 154f;
		}
		else
		{
			value = 972f + (this.wgt - 1481f) * 900f;
		}
		value = Mathf.Clamp(value, 37f, 208f);
		this.fishModelTemplate.transform.localScale = new Vector3(1435f, 989f, 816f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "offsets")
			{
				OMDDGEDHHNH.GDDAGIILGGM().FNBJHBLNMKN("<color='#003000'>+{0} {1}</color>" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LPBPPEAEPCH), "SneakLeft");
			}
			else
			{
				Debug.LogError("http://j.mp/1iBK5pz" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("http://af-2.ru/?q=user/register" + ex.StackTrace);
		}
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x00169E5C File Offset: 0x0016805C
	private void KGICJDGIIJK()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.fid);
		float value;
		if (this.wgt < 1413f)
		{
			value = 727f - (1030f - this.wgt) * 10f;
		}
		else
		{
			value = 614f + (this.wgt - 1150f) * 1709f;
		}
		value = Mathf.Clamp(value, 957f, 1538f);
		this.fishModelTemplate.transform.localScale = new Vector3(1136f, 126f, 733f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "shop_t4")
			{
				OMDDGEDHHNH.JFJBLLJNHJO().DCGIKMIBALD("NadeThrow" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.FCFNGKFBDAP), "t_eye");
			}
			else
			{
				Debug.LogError("Downsamp" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("gi_um_nt" + ex.StackTrace);
		}
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x00169F84 File Offset: 0x00168184
	private void IOLJJOLFBIN()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("WorkerHammer");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 335f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1766f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 106f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 454f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 799f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 584f;
				Quaternion b3 = Quaternion.Euler(1398f, 1917f + this.OPIAODBJFEC, 251f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1332f, 1499f, 1129f));
			}
		}
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x0016A1E0 File Offset: 0x001683E0
	public void ACCBNBAADDM()
	{
		LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 1490f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 999f;
		this.OPIAODBJFEC = OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC(1457.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x0016A284 File Offset: 0x00168484
	private void JMPGFNNBIGO()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("System.Single");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 597f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 166f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1419f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 1318f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 83f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1538f;
				Quaternion b3 = Quaternion.Euler(1069f, 1059f + this.OPIAODBJFEC, 1616f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1463f, 13f, 39f));
			}
		}
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x0016A4E0 File Offset: 0x001686E0
	public void HMOBCBDCFLC()
	{
		LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(base.transform.position, 1880f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1372f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().FFDDAGJJOOM(246.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x0016A584 File Offset: 0x00168784
	private void BGLIJMGAHLP()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("ArmFlex3");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.OGJHINOLHJJ - 1349f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 1775f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1125f;
				a.y = LocNewLogic.getI.OGJHINOLHJJ - 907f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1805f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 1967f;
				Quaternion b3 = Quaternion.Euler(191f, 1143f + this.OPIAODBJFEC, 1182f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 1343f, 512f, 669f));
			}
		}
	}

	// Token: 0x060030F5 RID: 12533 RVA: 0x0016A7E0 File Offset: 0x001689E0
	private void ONIHHFLOJMN()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 154f)
		{
			value = 1145f - (320f - this.wgt) * 888f;
		}
		else
		{
			value = 1257f + (this.wgt - 796f) * 9f;
		}
		value = Mathf.Clamp(value, 74f, 505f);
		this.fishModelTemplate.transform.localScale = new Vector3(1441f, 1159f, 428f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "repair.ogg")
			{
				OMDDGEDHHNH.IMLLGEMPHAP().GLEDIDEJKHO("Low adminlevel!" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.modelLoadDone), "_Scale");
			}
			else
			{
				Debug.LogError("FaceHit" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("MotorbikeSuperman" + ex.StackTrace);
		}
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x0016A908 File Offset: 0x00168B08
	public void DDMMOIMMPKB(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCCMKOPELGK();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().BDLCEALCLLB(this.CJEFJNNHJHO, "sunshine_ShadowCoordDepthRayZ", LocNewLogic.getI.CDBIEPGNONF());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.PKGMBFEMKGP().FAJIJEIJJJH(base.gameObject, "wpn_add/base");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = true;
		}
		fishModelData.GMJBFCPGGLC(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.MHFDIJGJGBJ().KOHAPBIENMH(this.CJEFJNNHJHO, 10);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x0016AB38 File Offset: 0x00168D38
	private void MCNAPFOFHHA()
	{
		if (this.isGetFromWater)
		{
			if (this.leftHandRodPoint == null)
			{
				Debug.Log("wpn_eat6");
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.isBigFish)
			{
				if (this.podsakPoint != null)
				{
					Vector3 position = this.podsakPoint.transform.position;
					position.y = LocNewLogic.getI.HKBNODJBGEL() - 827f;
					Vector3 vector = position - base.transform.position;
					base.transform.position = base.transform.position + vector * Time.deltaTime * 752f;
					Quaternion b = Quaternion.LookRotation(vector);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime);
					return;
				}
				Vector3 a = this.actor.transform.position + this.actor.transform.forward * 1436f;
				a.y = LocNewLogic.getI.HKBNODJBGEL() - 112f;
				Vector3 vector2 = a - base.transform.position;
				base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1593f;
				Quaternion b2 = Quaternion.LookRotation(vector2);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
				return;
			}
			else
			{
				this.ELJLAHGONMF += Time.deltaTime;
				Vector3 a2 = this.leftHandRodPoint.transform.position - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 994f;
				Quaternion b3 = Quaternion.Euler(240f, 1568f + this.OPIAODBJFEC, 1712f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 676f, 1303f, 49f));
			}
		}
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x0016AD94 File Offset: 0x00168F94
	public void JCBNIMMALCG()
	{
		LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(base.transform.position, 1891f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1001f;
		this.OPIAODBJFEC = OLPINJLCKCI.NLOGJHEFMHM().GKDBPBFOINB(1644.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x0016AE38 File Offset: 0x00169038
	private void JCELICPHGEP()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 1593f)
		{
			value = 1303f - (1163f - this.wgt) * 418f;
		}
		else
		{
			value = 1253f + (this.wgt - 929f) * 60f;
		}
		value = Mathf.Clamp(value, 1550f, 296f);
		this.fishModelTemplate.transform.localScale = new Vector3(575f, 1479f, 671f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "def point foud")
			{
				OMDDGEDHHNH.IKGFHGKKCPG.FNBJHBLNMKN("Flashlight" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.IKEBDCOINJI), "Visit docs to see where PlayerPrefs are stored");
			}
			else
			{
				Debug.LogError(" " + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("\n" + ex.StackTrace);
		}
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x0016AF60 File Offset: 0x00169160
	private void JLKBMEBFHBI()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.fid);
		float value;
		if (this.wgt < 869f)
		{
			value = 1961f - (354f - this.wgt) * 1579f;
		}
		else
		{
			value = 1265f + (this.wgt - 1380f) * 622f;
		}
		value = Mathf.Clamp(value, 1385f, 474f);
		this.fishModelTemplate.transform.localScale = new Vector3(285f, 1926f, 366f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "reelspd")
			{
				OMDDGEDHHNH.DPBNHMCDIIK().FBKDPHEGOLP("wpn_line1" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.IGHBJMAJJJN), "===== ObscuredStringTest =====\n");
			}
			else
			{
				Debug.LogError("*** ActorMgr Scene is loaded:" + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("_OcclusionTexture1" + ex.StackTrace);
		}
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x0016B088 File Offset: 0x00169288
	public void FCFNGKFBDAP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (base.gameObject == null)
		{
			return;
		}
		if (IEPBGKCHDJO == null)
		{
			return;
		}
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.FAJIJEIJJJH(base.gameObject, "Giant 3 Hit Combo 2");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemplate.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.EFEDICJAKPA();
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		JLFJEGIPIMM.PKGMBFEMKGP().POJEMHCEPCL(this.CJEFJNNHJHO, "wpn_line3", LocNewLogic.getI.HKBNODJBGEL());
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.FPBGFBLLENH = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "SoccerKeeperStrafeLeft");
		float fkegbobjnfa = this.GAAPCLGDOGH.FKEGBOBJNFA;
		float num = this.wkf;
		float oajhjhgbfcf = this.GAAPCLGDOGH.OAJHJHGBFCF;
		float fkegbobjnfa2 = this.GAAPCLGDOGH.FKEGBOBJNFA;
		FishModelData fishModelData = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (fishModelData == null)
		{
			fishModelData = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			fishModelData.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			fishModelData.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			fishModelData.useGraf = false;
		}
		fishModelData.FKBNCNFMMCJ(this.wkf);
		if (this.FPBGFBLLENH != null)
		{
			Vector3 localPosition = base.transform.position - this.FPBGFBLLENH.transform.position;
			this.CJEFJNNHJHO.transform.localPosition = localPosition;
		}
		JLFJEGIPIMM.NNEAHAFBOHC().FJFAMAOEFEF(this.CJEFJNNHJHO, 81);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x0016B2B8 File Offset: 0x001694B8
	private void FPLHODJCJDO()
	{
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.fid);
		float value;
		if (this.wgt < 1639f)
		{
			value = 1110f - (1307f - this.wgt) * 856f;
		}
		else
		{
			value = 181f + (this.wgt - 1711f) * 50f;
		}
		value = Mathf.Clamp(value, 577f, 336f);
		this.fishModelTemplate.transform.localScale = new Vector3(968f, 599f, 880f);
		try
		{
			if (this.GAAPCLGDOGH.HAPFPGIINCM != "Load costume ")
			{
				OMDDGEDHHNH.OGAOPAJFADH().DCGIKMIBALD("IdleTurns" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.DBFEFCANIKL), "holes_min");
			}
			else
			{
				Debug.LogError(" " + this.fid);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("ENABLE_COLOR_GRADING" + ex.StackTrace);
		}
	}

	// Token: 0x060030FD RID: 12541 RVA: 0x0016B3E0 File Offset: 0x001695E0
	public void KMOMGIEMOHA()
	{
		LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(base.transform.position, 652f);
		this.isGetFromWater = false;
		this.ELJLAHGONMF = 1201f;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().LLNEEEJIDGI(435.0);
		this.HIPFBLDJEIB = base.transform.position;
	}

	// Token: 0x040006FE RID: 1790
	public int fid;

	// Token: 0x040006FF RID: 1791
	public float wkf;

	// Token: 0x04000700 RID: 1792
	public float wgt;

	// Token: 0x04000701 RID: 1793
	public Actor actor;

	// Token: 0x04000702 RID: 1794
	public GameObject podsakPoint;

	// Token: 0x04000703 RID: 1795
	public GameObject fishModelTemplate;

	// Token: 0x04000704 RID: 1796
	public Animation anm;

	// Token: 0x04000705 RID: 1797
	public bool isGetFromWater;

	// Token: 0x04000706 RID: 1798
	public bool isBigFish;

	// Token: 0x04000707 RID: 1799
	private float ELJLAHGONMF;

	// Token: 0x04000708 RID: 1800
	private IDCHHHEDHDC GAAPCLGDOGH;

	// Token: 0x04000709 RID: 1801
	private GameObject CJEFJNNHJHO;

	// Token: 0x0400070A RID: 1802
	private GameObject FPBGFBLLENH;

	// Token: 0x0400070B RID: 1803
	private float OPIAODBJFEC;

	// Token: 0x0400070C RID: 1804
	public Transform leftHandRodPoint;

	// Token: 0x0400070D RID: 1805
	private Vector3 HIPFBLDJEIB;
}
