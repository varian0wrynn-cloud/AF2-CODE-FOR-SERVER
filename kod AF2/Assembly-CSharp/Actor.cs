using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000FF RID: 255
public class Actor : MonoBehaviour
{
	// Token: 0x06002FC8 RID: 12232 RVA: 0x0015CCD8 File Offset: 0x0015AED8
	public void CHFKALOHKOA(string GMNLJGNOKPD)
	{
		if (!this.MFENINHGBHM)
		{
			if (this.rodObject != null)
			{
				UnityEngine.Object.Destroy(this.rodObject);
			}
			this.rodObject = null;
			return;
		}
		this.rodid = this.currentNetWeapons[1].PJPOJNNJOCD;
		if (this.rodid == 0)
		{
			return;
		}
		if (this.rodcntr != null)
		{
			return;
		}
		object[] array = new object[]
		{
			"Giant2HandSlamIdle"
		};
		array[0] = this.actorName;
		array[3] = "KatanaReady";
		array[8] = GMNLJGNOKPD;
		array[2] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html";
		array[5] = this.currentNetWeapons[0].PJPOJNNJOCD;
		Debug.Log(string.Concat(array));
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			this.rodcntr = OMDDGEDHHNH.DAANHKAOCKP().DKPDBNNNDLK(IFPIMPMKJIB.DLLPPIMEOBP(this.currentNetWeapons[0].PJPOJNNJOCD), 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod), "\n");
			return;
		}
		this.rodcntr = OMDDGEDHHNH.IMLLGEMPHAP().GMEONEFHOEJ(ActorMgr.getI.defaultRod, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod));
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x0015CDF0 File Offset: 0x0015AFF0
	public void DLPLGAEAGPC(bool DCCPCBLODIG)
	{
		bool hdlhcmopikm = this.HDLHCMOPIKM;
		this.HDLHCMOPIKM = DCCPCBLODIG;
		if (hdlhcmopikm & !this.HDLHCMOPIKM)
		{
			if (this.rodObject != null)
			{
				UnityEngine.Object.Destroy(this.rodObject);
			}
			if (this.poplObject != null)
			{
				UnityEngine.Object.Destroy(this.poplObject);
			}
			this.rodObject = null;
			this.reelObject = null;
			this.rodcntr = null;
			this.rodforce = 1766f;
			this.blendRodDirection = 1215f;
		}
		if (this.HDLHCMOPIKM & hdlhcmopikm)
		{
			base.transform.position = this.toPosition;
			base.transform.rotation = Quaternion.Euler(this.toRotation);
			this.isFishGet = false;
			if (this.actorFish != null)
			{
				UnityEngine.Object.Destroy(this.actorFish.gameObject);
			}
			if (this.rodObject == null && this.currentNetWeapons[0].PJPOJNNJOCD > 0)
			{
				this.HOJNONBIPDG("Bias");
			}
		}
		if (this.HDLHCMOPIKM)
		{
			this.legsCntrl.BMJGJJCEBBN(false);
			return;
		}
		this.legsCntrl.BDFCAIDEMAN();
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x0015CF1C File Offset: 0x0015B11C
	public void DNOPCGEPAKE(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject == null)
		{
			return;
		}
		this.reelObject = null;
		if (this.currendRodParams == null)
		{
			return;
		}
		if (this.currendRodParams.reelPoint == null)
		{
			return;
		}
		this.reelObject = UnityEngine.Object.Instantiate<GameObject>(IEPBGKCHDJO.NIGADFIHLHM(), this.currendRodParams.reelPoint.transform.position, this.currendRodParams.reelPoint.transform.rotation);
		if (this.reelObject == null)
		{
			return;
		}
		this.reelObject.transform.parent = this.rodObject.transform;
		this.currendRollParams = this.reelObject.GetComponent<RollParams>();
		if (this.currendRollParams == null)
		{
			this.currendRollParams = this.reelObject.AddComponent<RollParams>();
		}
		this.currendRodParams.rollParams = this.currendRollParams;
		JLFJEGIPIMM.IKGFHGKKCPG.MLNKLINJKBO(this.reelObject, this.actorChar.instanceLayer);
		Debug.Log("IdleSadHips" + this.actorName);
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x0015D038 File Offset: 0x0015B238
	private IEnumerator ONKLNKKNFCB()
	{
		yield return new WaitForSeconds(0.8f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			float num = (OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0) - 0.5f) * 0.3f;
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[2], base.transform.position + base.transform.up * 2f, 0.2f, 1f, 10f, 1f + num);
			yield return new WaitForSeconds(1.8f);
			FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("donk.ogg", this.toDropPoint, 0.5f, 3f, 50f);
			LocNewLogic.getI.createWaterJampSplash(this.toDropPoint, 3000f);
			LocNewLogic.getI.createWaterCircle(this.toDropPoint, 4);
			LocNewLogic.getI.createBigWaterCircle(this.toDropPoint);
		}
		yield break;
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x0015D048 File Offset: 0x0015B248
	public void DLIJELLCOBI(HBPNMNGOFMA KADBECGIMPD)
	{
		try
		{
			this.actorName = KADBECGIMPD.JJJJAGJCOGD();
			this.titulID = KADBECGIMPD.AGNKAFLKCAG();
			int pjpojnnjocd = this.currentNetWeapons[0].PJPOJNNJOCD;
			int num = KADBECGIMPD.KDNDJNEGBDI();
			for (int i = 1; i < num; i++)
			{
				this.currentNetWeapons[i].PJPOJNNJOCD = KADBECGIMPD.HHLDBAEFNMJ();
				this.currentNetWeapons[i].HANEKMFJLDB = KADBECGIMPD.DCLBHAMJEIO(-64);
			}
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			byte[] dnhbpgoklkd = KADBECGIMPD.ANGDIBBCJDA(ilfhhdnjhnm);
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.BOOCBLKDAPP(dnhbpgoklkd);
			}
			if (!KADBECGIMPD.LILLHFLDMBH())
			{
				long num2 = KADBECGIMPD.DMABDIGCLKA();
				this.artData = ELCMHGJLFOL.IKGFHGKKCPG.DJIJHNLKAPC(num2);
				this.artData.HLJFBOLPOMG(KADBECGIMPD);
				if (num2 > 1L)
				{
					this.artelText.gameObject.SetActive(true);
					this.artelText.text = this.artData.MNGHILMCBCI;
					this.artelImage.gameObject.SetActive(false);
				}
				else
				{
					this.artelText.gameObject.SetActive(true);
				}
			}
			if (!KADBECGIMPD.KFKIFJDHCHB())
			{
				this.level = KADBECGIMPD.CLPEKGGAMAI();
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.IEDMEFKAJNO(this.currentNetWeapons[4].PJPOJNNJOCD);
				this.actorChar.ILNJODHOEGC(this.currentNetWeapons[7].PJPOJNNJOCD);
			}
			if (pjpojnnjocd != this.currentNetWeapons[1].PJPOJNNJOCD && this.MFENINHGBHM)
			{
				this.rodcntr = null;
				this.CHFKALOHKOA("Wrist");
			}
			UnityEngine.Object gameObject = base.gameObject;
			object[] array = new object[8];
			array[1] = "{0} {1}";
			array[0] = this.shid;
			array[5] = "SexyDance2";
			array[2] = this.actorName;
			gameObject.name = string.Concat(array);
			this.nameText.text = this.actorName;
			if (this.levelText != null)
			{
				this.levelText.text = string.Concat(this.level);
			}
			this.titulText.text = ((this.titulID > 1) ? NHCAOFIKNFE.IKGFHGKKCPG.HBMGCEMAPOK(this.titulID, this.actorName, false, true) : "K-");
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		this.isInit = true;
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x0015D2CC File Offset: 0x0015B4CC
	private void FKLDKPEDDDM()
	{
		this.actorChar = base.GetComponent<Character>();
		if (this.actorChar != null)
		{
			this.actorChar.isUpdateMaterial = false;
		}
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x0015D2F4 File Offset: 0x0015B4F4
	public void BEJAPCFKFMK(HBPNMNGOFMA KADBECGIMPD)
	{
		try
		{
			this.actorName = KADBECGIMPD.NCODBGMGNFD();
			this.titulID = KADBECGIMPD.AGNKAFLKCAG();
			int pjpojnnjocd = this.currentNetWeapons[0].PJPOJNNJOCD;
			int num = KADBECGIMPD.KKOKFLMMAAK();
			for (int i = 0; i < num; i += 0)
			{
				this.currentNetWeapons[i].PJPOJNNJOCD = KADBECGIMPD.KDNDJNEGBDI();
				this.currentNetWeapons[i].HANEKMFJLDB = KADBECGIMPD.FNKIGGHFHEN(-10);
			}
			int ilfhhdnjhnm = KADBECGIMPD.DOJKJHMJJNK();
			byte[] dnhbpgoklkd = KADBECGIMPD.HKDGKCPGLHE(ilfhhdnjhnm);
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.HCBMGCJMCBG(dnhbpgoklkd);
			}
			if (!KADBECGIMPD.PPAHBNGECGH())
			{
				long num2 = KADBECGIMPD.HHMGLDMFCPF();
				this.artData = ELCMHGJLFOL.IKGFHGKKCPG.MCBGCEFDIJP(num2);
				this.artData.OCPAHLAGCAI(KADBECGIMPD);
				if (num2 > 1L)
				{
					this.artelText.gameObject.SetActive(false);
					this.artelText.text = this.artData.MNGHILMCBCI;
					this.artelImage.gameObject.SetActive(false);
				}
				else
				{
					this.artelText.gameObject.SetActive(false);
				}
			}
			if (!KADBECGIMPD.NGIGCKBKLGK())
			{
				this.level = KADBECGIMPD.HDBGOLAFOBK();
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.GLBOAFGFDII(this.currentNetWeapons[2].PJPOJNNJOCD);
				this.actorChar.ALIHOMHJDKN(this.currentNetWeapons[7].PJPOJNNJOCD);
			}
			if (pjpojnnjocd != this.currentNetWeapons[0].PJPOJNNJOCD && this.IDGLBENDHEM())
			{
				this.rodcntr = null;
				this.loadRodObject("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html");
			}
			UnityEngine.Object gameObject = base.gameObject;
			object[] array = new object[7];
			array[1] = "_ClutTex";
			array[0] = this.shid;
			array[6] = "Sprint";
			array[5] = this.actorName;
			gameObject.name = string.Concat(array);
			this.nameText.text = this.actorName;
			if (this.levelText != null)
			{
				this.levelText.text = string.Concat(this.level);
			}
			this.titulText.text = ((this.titulID > 1) ? NHCAOFIKNFE.IKGFHGKKCPG.PKOFLNMMADN(this.titulID, this.actorName, false, false) : "_NeighbourMaxTex");
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		this.isInit = false;
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x0015D578 File Offset: 0x0015B778
	public void BHOFFBCAGOF(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		this.isBrag = false;
		this.bragCntrl.ABHCPCLFEIG(false);
		if (this.ALDJNFLGKNJ == null)
		{
			this.ALDJNFLGKNJ = JLFJEGIPIMM.MHFDIJGJGBJ().LMFEHHFPAAA("_OcclusionTexture", Vector3.zero, this.leftHandRodPoint);
			this.ALDJNFLGKNJ.GetComponent<BragFish>().JGPKEKJCNOO(OLKMHFNLBJB, NBLJCEHNKAK, true);
		}
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x0015D5DC File Offset: 0x0015B7DC
	public void userBragFish(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		this.isBrag = true;
		this.bragCntrl.LJIEPIPIAJC(false);
		if (this.ALDJNFLGKNJ == null)
		{
			this.ALDJNFLGKNJ = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("FishbragContainer", Vector3.zero, this.leftHandRodPoint);
			this.ALDJNFLGKNJ.GetComponent<BragFish>().fishInstance(OLKMHFNLBJB, NBLJCEHNKAK, true);
		}
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x0015D640 File Offset: 0x0015B840
	public void ALLEPOHEJLG(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			this.leftHandCntrl.ALGAEEMMAOI();
			Transform transform = this.leftHandRodPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4Actor, Vector3.zero, Quaternion.identity);
			this.podsakObject.transform.parent = this.leftHandRodPoint;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakPoint = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(this.podsakObject, "wpn_iwgt");
			this.podsakInWater = false;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = this.podsakPoint;
			}
		}
		if (CLBPBJGLHEE < 0)
		{
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 1348f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = false;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = null;
			}
		}
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x0015D757 File Offset: 0x0015B957
	public void DMOMJLEDDPB()
	{
		this.podsakInWater = true;
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x0015D038 File Offset: 0x0015B238
	private IEnumerator KDBMNEBJIOL()
	{
		yield return new WaitForSeconds(0.8f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			float num = (OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0) - 0.5f) * 0.3f;
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[2], base.transform.position + base.transform.up * 2f, 0.2f, 1f, 10f, 1f + num);
			yield return new WaitForSeconds(1.8f);
			FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("donk.ogg", this.toDropPoint, 0.5f, 3f, 50f);
			LocNewLogic.getI.createWaterJampSplash(this.toDropPoint, 3000f);
			LocNewLogic.getI.createWaterCircle(this.toDropPoint, 4);
			LocNewLogic.getI.createBigWaterCircle(this.toDropPoint);
		}
		yield break;
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x0015D760 File Offset: 0x0015B960
	public void instaniateReel(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject == null)
		{
			return;
		}
		this.reelObject = null;
		if (this.currendRodParams == null)
		{
			return;
		}
		if (this.currendRodParams.reelPoint == null)
		{
			return;
		}
		this.reelObject = UnityEngine.Object.Instantiate<GameObject>(IEPBGKCHDJO.GIFGIFAHPIA, this.currendRodParams.reelPoint.transform.position, this.currendRodParams.reelPoint.transform.rotation);
		if (this.reelObject == null)
		{
			return;
		}
		this.reelObject.transform.parent = this.rodObject.transform;
		this.currendRollParams = this.reelObject.GetComponent<RollParams>();
		if (this.currendRollParams == null)
		{
			this.currendRollParams = this.reelObject.AddComponent<RollParams>();
		}
		this.currendRodParams.rollParams = this.currendRollParams;
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.reelObject, this.actorChar.instanceLayer);
		Debug.Log("actor instaniateReel 4 " + this.actorName);
	}

	// Token: 0x06002FD5 RID: 12245 RVA: 0x0015D87C File Offset: 0x0015BA7C
	public void LELCMGAFFBI(bool DCCPCBLODIG)
	{
		this.ADFNLBBFLKK = DCCPCBLODIG;
		if (this.ADFNLBBFLKK)
		{
			this.isMoving = true;
			if (this.fchair == null)
			{
				this.OGEFMPOIPEL();
			}
			this.sitCntrl.IKBJNNMIGBC(false);
		}
		if (!this.ADFNLBBFLKK)
		{
			this.sitCntrl.OFLCJDPLHHD();
			if (this.fchair != null)
			{
				this.fchair.transform.parent = null;
				DitherShower component = this.fchair.GetComponent<DitherShower>();
				if (component != null)
				{
					component.dirVector = -1;
					component.scaleAlfaKF = 951f;
				}
				UnityEngine.Object.Destroy(this.fchair, 690f);
			}
			this.fchair = null;
		}
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x0015D92F File Offset: 0x0015BB2F
	public void KJGAMLOMNNI()
	{
		this.actorFish != null;
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x0015D940 File Offset: 0x0015BB40
	public void instaniateRod(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		if (this.rodObject != null)
		{
			this.reelObject = null;
			UnityEngine.Object.Destroy(this.rodObject);
		}
		Debug.Log("actor instaniateRod " + this.actorName + " rod file=" + IEPBGKCHDJO.ALBOCLBFNNI);
		this.rodObject = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.rodObject == null)
		{
			return;
		}
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
		this.rodObject.transform.rotation = this.rightHandRodPoint.transform.rotation;
		this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
		this.rodObject.transform.parent = this.rightHandRodPoint;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localPosition = Vector3.zero;
		this.currendRodParams = this.rodObject.GetComponent<RodParams>();
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.rodObject, this.actorChar.instanceLayer);
		Vector3 b = Vector3.zero;
		if (this.currendRodParams != null)
		{
			b = this.rodObject.transform.position - this.currendRodParams.handPoint.transform.position;
		}
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b;
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(this.currentNetWeapons[1].PJPOJNNJOCD), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateReel), "");
			return;
		}
		OMDDGEDHHNH.IKGFHGKKCPG.CCFAHNDIBIE(ActorMgr.getI.defaulReel, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateReel));
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x0015DB47 File Offset: 0x0015BD47
	public bool ACLKIDEDENO()
	{
		return this.ADFNLBBFLKK;
	}

	// Token: 0x06002FD9 RID: 12249 RVA: 0x0015DB4F File Offset: 0x0015BD4F
	private IEnumerator AIGCNBBKMJD()
	{
		Actor.HPPFMNBAPPF hppfmnbappf = new Actor.HPPFMNBAPPF(1);
		hppfmnbappf.AENJLLPLILM = this;
		return hppfmnbappf;
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x0015DB5E File Offset: 0x0015BD5E
	public void BJCKNPPNENF()
	{
		this.isBrag = false;
		this.bragCntrl.PGJOCPPOGAI();
		if (this.ALDJNFLGKNJ != null)
		{
			UnityEngine.Object.Destroy(this.ALDJNFLGKNJ);
		}
		this.ALDJNFLGKNJ = null;
	}

	// Token: 0x06002FDB RID: 12251 RVA: 0x0015D2CC File Offset: 0x0015B4CC
	private void KOJNOPBGPAM()
	{
		this.actorChar = base.GetComponent<Character>();
		if (this.actorChar != null)
		{
			this.actorChar.isUpdateMaterial = false;
		}
	}

	// Token: 0x06002FDC RID: 12252 RVA: 0x0015DB94 File Offset: 0x0015BD94
	private void FOHLAIIMNFB()
	{
		if (!this.isInit && Time.time - this.createTime > 748f && base.gameObject != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (this.rollPenPointObject != null)
		{
			if (this.currendRollParams != null)
			{
				this.rollPenPointObject.SetActive(false);
				this.rollPenPointObject.transform.position = this.currendRollParams.handPoint.transform.position;
			}
			else
			{
				this.rollPenPointObject.SetActive(true);
			}
		}
		if (this.isRagulaSet)
		{
			if (this.ragulaObject != null)
			{
				this.ragulaObject.transform.position = this.ragulaPosition;
				this.ragulaObject.transform.rotation = Quaternion.Euler(this.ragulaRotation);
			}
			if (this.currendRodParams != null)
			{
				this.FDFPGIEPDDJ = Mathf.Clamp(this.FDFPGIEPDDJ, 1557f, 1924f);
			}
		}
		this.PPOFFIDHBKF += Vector3.Distance(base.transform.position, this.PEGLEGPLPCP);
		this.DLDMKCIFFPP += Time.deltaTime;
		if (this.DLDMKCIFFPP > 1699f)
		{
			this.DLDMKCIFFPP = 145f;
			this.PEGLEGPLPCP = base.transform.position;
			if (this.PPOFFIDHBKF < 433f)
			{
				this.isMoving = false;
			}
		}
		if ((base.transform.position - this.toPosition).magnitude > 227f)
		{
			base.transform.position = this.toPosition;
		}
		if (this.nameCanvas != null)
		{
			this.nameCanvas.transform.LookAt(Camera.main.transform);
			this.nameCanvas.transform.Rotate(1696f, 1895f, 586f);
		}
		if (this.IDGLBENDHEM())
		{
			this.isMoving = true;
		}
		if (this.isMoving)
		{
			Vector3 a = this.toMovePoint;
			a.y = base.transform.position.y;
			float num = Vector3.Distance(a, base.transform.position);
			this.isMoving = (num < 1726f);
			Vector3 a2 = this.toMovePoint;
			a2.y = base.transform.position.y;
			Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1937f);
			if (a.magnitude > 359f && Vector3.Distance(a, base.transform.position) > 931f)
			{
				this.action.HMMOJFKGPCH();
				this.cc.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		else
		{
			Vector3 position = Vector3.Lerp(base.transform.position, this.toPosition, Time.deltaTime * 665f);
			position.y = base.transform.position.y;
			base.transform.position = position;
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, Quaternion.Euler(this.toRotation), Time.deltaTime * 713f);
		}
		if (!this.IHBAFHCHNAA())
		{
			this.isKeyPress = true;
		}
		if (this.IHBAFHCHNAA())
		{
			bool flag = true;
			if (this.dropType == -2)
			{
				flag = false;
			}
			if (this.dropType == 1)
			{
				flag = false;
			}
			if (this.isFishOnRod)
			{
				flag = true;
			}
			if (this.isFishGet)
			{
				flag = true;
			}
			this.LHKJOMLGLCB.EMOBAMKCPBG();
			if (flag)
			{
				this.leftHandCntrl.ABKLNCIJDCG();
			}
			else
			{
				this.leftHandCntrl.OPEKLHFIDCK();
			}
		}
		else
		{
			this.LHKJOMLGLCB.MGLPLMKMPCK();
			this.leftHandCntrl.CGDHJAOEBIK();
		}
		if (!this.IHBAFHCHNAA())
		{
			this.rodforce = 1604f;
		}
		if ((this.IHBAFHCHNAA() & this.isFishOnRod) && !this.isRagulaSet)
		{
			this.rodforce = 87f;
		}
		this.cDropPoint = Vector3.Lerp(this.cDropPoint, this.toDropPoint, Time.deltaTime * 1509f);
		this.FEJPPCFGDCF = Mathf.Lerp(this.FEJPPCFGDCF, this.blendRodDirection, Time.deltaTime * 852f);
		this.c_upRodState = Mathf.Lerp(this.c_upRodState, this.upRodState, Time.deltaTime * 1632f);
		this.FDFPGIEPDDJ = Mathf.Lerp(this.FDFPGIEPDDJ, this.rodforce, Time.deltaTime * 576f);
		if (this.isRagulaSet)
		{
			this.FDFPGIEPDDJ = Mathf.Clamp(this.FDFPGIEPDDJ, 150f, 1219f);
		}
		if (this.currendRodParams != null)
		{
			this.currendRodParams.MJLMLHPAOBM(this.FDFPGIEPDDJ);
			this.currendRodParams.target = this.cDropPoint;
		}
		this.LHKJOMLGLCB.NFPFDOEENLA();
		this.leftHandCntrl.MEIOHFKFEME();
		this.action.NEOMPPJCELE(this.anm);
		if (this.anm != null)
		{
			this.legsCntrl.HPCHIABBKIP(this.anm);
			this.bragCntrl.NOLNCGNGNGI(this.anm);
			this.sitCntrl.OGOEJFODPMO(this.anm);
			this.anm.SetBool(" x", this.isBigFish);
			this.anm.SetBool("wpn_med1", this.isMoving);
			this.anm.SetBool("Current fog preset: ", this.isWoman);
			this.anm.SetBool("CheckResources () for ", this.IDGLBENDHEM());
			this.anm.SetBool("", this.CIHILMCEJND);
			this.anm.SetBool(" ", this.isFishOnRod);
			this.anm.SetInteger("1 Hand Heavy Swing", this.dropType);
			this.anm.SetBool("sunshine_Lightmap", this.isKeyPress);
			this.anm.SetFloat("t_beard", this.FEJPPCFGDCF);
			this.anm.SetBool("270", this.isFishGet);
			this.anm.SetBool("cht_msg20", this.isRagulaSet);
			this.anm.SetFloat("_CenterRadius", this.c_upRodState);
			this.anm.SetBool("", this.isBrag);
			this.anm.SetBool("wpn_dress1", this.isHarvest);
			this.anm.SetBool("", this.isRun);
		}
	}

	// Token: 0x06002FDD RID: 12253 RVA: 0x0015D2CC File Offset: 0x0015B4CC
	private void Awake()
	{
		this.actorChar = base.GetComponent<Character>();
		if (this.actorChar != null)
		{
			this.actorChar.isUpdateMaterial = false;
		}
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x0015E27C File Offset: 0x0015C47C
	private void EHFPLKEINFO()
	{
		this.cc = base.GetComponent<CharacterController>();
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.createTime = Time.time;
		this.isInit = false;
		base.gameObject.name = "BowFire" + this.shid + "codepage";
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-112, this.shid);
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		base.StartCoroutine(this.AIGCNBBKMJD());
		this.PEGLEGPLPCP = base.transform.position;
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x0015E35C File Offset: 0x0015C55C
	public void DENJCGAAPGO(bool DCCPCBLODIG)
	{
		this.ADFNLBBFLKK = DCCPCBLODIG;
		if (this.ADFNLBBFLKK)
		{
			this.isMoving = true;
			if (this.fchair == null)
			{
				this.PDBIFHPINDA();
			}
			this.sitCntrl.ABHCPCLFEIG(true);
		}
		if (!this.ADFNLBBFLKK)
		{
			this.sitCntrl.MHOAGBHDOFJ();
			if (this.fchair != null)
			{
				this.fchair.transform.parent = null;
				DitherShower component = this.fchair.GetComponent<DitherShower>();
				if (component != null)
				{
					component.dirVector = -1;
					component.scaleAlfaKF = 14f;
				}
				UnityEngine.Object.Destroy(this.fchair, 144f);
			}
			this.fchair = null;
		}
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x0015E40F File Offset: 0x0015C60F
	private IEnumerator PMHBOPMIFIC()
	{
		Actor.EGMIFJEKOFD egmifjekofd = new Actor.EGMIFJEKOFD(1);
		egmifjekofd.AENJLLPLILM = this;
		return egmifjekofd;
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x0015E420 File Offset: 0x0015C620
	public void EGJDNMMFLFC()
	{
		string hojhbmnihba = "codepage";
		Actor.HAGIDCGGJBI hagidcggjbi = this.currentNetWeapons[115];
		if (hagidcggjbi.PJPOJNNJOCD > 1)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(hagidcggjbi.PJPOJNNJOCD);
			hojhbmnihba = "OfficeSittingHandRestFingerTap" + befchfngomi.MIMANMPNLPE.IBEIBAHKIAH;
		}
		this.fchair = JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII(hojhbmnihba, base.transform.position, null);
		JLFJEGIPIMM.MHFDIJGJGBJ().NHEMIPPBIKN(this.fchair, this.actorChar.instanceLayer);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x0015E4EC File Offset: 0x0015C6EC
	public void HOJNONBIPDG(string GMNLJGNOKPD)
	{
		if (!this.MFENINHGBHM)
		{
			if (this.rodObject != null)
			{
				UnityEngine.Object.Destroy(this.rodObject);
			}
			this.rodObject = null;
			return;
		}
		this.rodid = this.currentNetWeapons[0].PJPOJNNJOCD;
		if (this.rodid == 0)
		{
			return;
		}
		if (this.rodcntr != null)
		{
			return;
		}
		object[] array = new object[8];
		array[1] = "id";
		array[1] = this.actorName;
		array[8] = "auc_wcstc";
		array[4] = GMNLJGNOKPD;
		array[4] = "ZombieWalk";
		array[1] = this.currentNetWeapons[1].PJPOJNNJOCD;
		Debug.Log(string.Concat(array));
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			this.rodcntr = OMDDGEDHHNH.IMLLGEMPHAP().NBKKJNFHOFE(IFPIMPMKJIB.JEGBDCMFKAG(this.currentNetWeapons[0].PJPOJNNJOCD), 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod), "_Transparency");
			return;
		}
		this.rodcntr = OMDDGEDHHNH.DAANHKAOCKP().PKIMLJPPNIJ(ActorMgr.getI.defaultRod, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod));
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x0015DB47 File Offset: 0x0015BD47
	public bool PKIJJNHMCED()
	{
		return this.ADFNLBBFLKK;
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x0015E604 File Offset: 0x0015C804
	public void onChatMessage(int LBCGACKJCJB, string EDAPHMJENPK)
	{
		if (this.cloudMsg == null)
		{
			return;
		}
		this.cloudMsg.showMessage(EDAPHMJENPK, LBCGACKJCJB, 5f);
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x0015D92F File Offset: 0x0015BB2F
	public void StandEvent()
	{
		this.actorFish != null;
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x0015E628 File Offset: 0x0015C828
	private void Start()
	{
		this.cc = base.GetComponent<CharacterController>();
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.createTime = Time.time;
		this.isInit = false;
		base.gameObject.name = "Actor_" + this.shid + "_noinfo";
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1010, this.shid);
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		base.StartCoroutine(this.OAIOJJNGPHG());
		this.PEGLEGPLPCP = base.transform.position;
	}

	// Token: 0x06002FE7 RID: 12263 RVA: 0x0015E708 File Offset: 0x0015C908
	public void instFChair()
	{
		string hojhbmnihba = "fchair";
		Actor.HAGIDCGGJBI hagidcggjbi = this.currentNetWeapons[9];
		if (hagidcggjbi.PJPOJNNJOCD > 0)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hagidcggjbi.PJPOJNNJOCD);
			hojhbmnihba = "fchair_" + befchfngomi.MIMANMPNLPE.IBEIBAHKIAH;
		}
		this.fchair = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, base.transform.position, null);
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.fchair, this.actorChar.instanceLayer);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x06002FE8 RID: 12264 RVA: 0x0015E7D2 File Offset: 0x0015C9D2
	public void MBPLKKLHNIK(int LBCGACKJCJB, string EDAPHMJENPK)
	{
		if (this.cloudMsg == null)
		{
			return;
		}
		this.cloudMsg.AGINDNAPGDD(EDAPHMJENPK, LBCGACKJCJB, 1015f);
	}

	// Token: 0x06002FE9 RID: 12265 RVA: 0x00022FCC File Offset: 0x000211CC
	public void RollClapEvnt()
	{
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06002FEA RID: 12266 RVA: 0x0015E7F5 File Offset: 0x0015C9F5
	// (set) Token: 0x0600300A RID: 12298 RVA: 0x0015FBB8 File Offset: 0x0015DDB8
	public bool CIHILMCEJND
	{
		get
		{
			return this.POFONDFAJLK;
		}
		set
		{
			bool pofondfajlk = this.POFONDFAJLK;
			this.POFONDFAJLK = value;
			if (pofondfajlk & !this.POFONDFAJLK)
			{
				this.rodforce = 0f;
				this.blendRodDirection = 0.5f;
				this.loadRodObject("isRodInWater");
			}
			if (this.POFONDFAJLK & !pofondfajlk)
			{
				this.action.FBFAJEGEIKM();
				this.rodforce = 0f;
				this.blendRodDirection = 0.5f;
				this.isFishGet = false;
				if (this.actorFish != null)
				{
					UnityEngine.Object.Destroy(this.actorFish.gameObject);
				}
				if (this.currentNetWeapons[0].PJPOJNNJOCD > 0)
				{
					this.loadRodObject("isRodInWater");
				}
				if (this.rodType == 101 && Vector3.Distance(base.transform.position, Camera.main.transform.position) < 30f)
				{
					base.StartCoroutine(this.KDBMNEBJIOL());
				}
			}
		}
	}

	// Token: 0x06002FEB RID: 12267 RVA: 0x0015E7FD File Offset: 0x0015C9FD
	private IEnumerator OAIOJJNGPHG()
	{
		for (;;)
		{
			this.isKeyPress = OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(70f);
			if (!this.leftHandCntrl.HKPAEGGJNGG)
			{
				this.isKeyPress = false;
			}
			float seconds = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0);
			yield return new WaitForSeconds(seconds);
		}
		yield break;
	}

	// Token: 0x06002FEC RID: 12268 RVA: 0x0015E80C File Offset: 0x0015CA0C
	public void endBrag()
	{
		this.isBrag = false;
		this.bragCntrl.HEJDOBFKEHG();
		if (this.ALDJNFLGKNJ != null)
		{
			UnityEngine.Object.Destroy(this.ALDJNFLGKNJ);
		}
		this.ALDJNFLGKNJ = null;
	}

	// Token: 0x06002FED RID: 12269 RVA: 0x0015D2CC File Offset: 0x0015B4CC
	private void NKHMBEDDFAJ()
	{
		this.actorChar = base.GetComponent<Character>();
		if (this.actorChar != null)
		{
			this.actorChar.isUpdateMaterial = false;
		}
	}

	// Token: 0x06002FEE RID: 12270 RVA: 0x0015E840 File Offset: 0x0015CA40
	public void getFifhEvent()
	{
		this.isFishOnRod = false;
		this.isFishGet = false;
		this.CIHILMCEJND = false;
		if (this.actorFish != null)
		{
			ActorMgr.getI.getFishEffectOn(this.actorFish.transform.position);
			UnityEngine.Object.Destroy(this.actorFish.gameObject);
			this.actorFish = null;
		}
		if (this.podsakObject != null)
		{
			DitherShower component = this.podsakObject.GetComponent<DitherShower>();
			if (component != null)
			{
				component.dirVector = -1;
				component.scaleAlfaKF = 1f;
			}
		}
	}

	// Token: 0x06002FEF RID: 12271 RVA: 0x0015D757 File Offset: 0x0015B957
	public void HCCPFHLIICL()
	{
		this.podsakInWater = true;
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x0015E8D8 File Offset: 0x0015CAD8
	private void FixedUpdate()
	{
		if (this.isKeyPress)
		{
			this.KPKANMFPIKG += Time.fixedDeltaTime * 5f;
		}
		Vector3 vector = this.cDropPoint;
		vector.y = Mathf.Clamp(vector.y, base.transform.position.y + 1f, base.transform.position.y + 3f);
		this.lookIK.solver.IKPositionWeight = this.LHKJOMLGLCB.NKHBAJKMAGD;
		this.lookIK.solver.IKPosition = vector;
		this.bipIK.solver.leftHandEffector.positionWeight = this.leftHandCntrl.NKHBAJKMAGD * 1f;
		if (this.currendRodParams != null)
		{
			if (this.currendRodParams.reelPoint != null)
			{
				Transform transform = this.currendRodParams.reelPoint.transform;
				Vector3 vector2 = new Vector3(0.05f, 0.01f, 0f);
				vector2.y += Mathf.Sin(this.KPKANMFPIKG) * 0.03f;
				vector2.z += Mathf.Cos(this.KPKANMFPIKG) * 0.03f;
				this.currendRodParams.rotTime = this.KPKANMFPIKG;
				Vector3 position = transform.position + transform.right * vector2.x + transform.up * vector2.y + transform.forward * vector2.z;
				if (this.rollPenPointObject != null)
				{
					this.bipIK.solver.leftHandEffector.target = this.rollPenPointHandObject.transform;
				}
				else
				{
					this.bipIK.solver.leftHandEffector.position = position;
				}
			}
		}
		else
		{
			this.leftHandCntrl.NKHBAJKMAGD = 0f;
			this.bipIK.solver.leftHandEffector.target = null;
		}
		if (this.CMCPFNJIIHK && this.fchair != null)
		{
			float num = this.bipIK.solver.rootNode.transform.position.y - 0.1f;
			if (Time.time - this.instChairTime < 3f)
			{
				Vector3 position2 = this.fchair.transform.position;
				position2.y = num - 0.5f;
				this.fchair.transform.position = position2;
			}
		}
	}

	// Token: 0x06002FF1 RID: 12273 RVA: 0x0015EB74 File Offset: 0x0015CD74
	public void KKGJEBEBDCI(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject == null)
		{
			return;
		}
		this.reelObject = null;
		if (this.currendRodParams == null)
		{
			return;
		}
		if (this.currendRodParams.reelPoint == null)
		{
			return;
		}
		this.reelObject = UnityEngine.Object.Instantiate<GameObject>(IEPBGKCHDJO.EALFLNDMOKG(), this.currendRodParams.reelPoint.transform.position, this.currendRodParams.reelPoint.transform.rotation);
		if (this.reelObject == null)
		{
			return;
		}
		this.reelObject.transform.parent = this.rodObject.transform;
		this.currendRollParams = this.reelObject.GetComponent<RollParams>();
		if (this.currendRollParams == null)
		{
			this.currendRollParams = this.reelObject.AddComponent<RollParams>();
		}
		this.currendRodParams.rollParams = this.currendRollParams;
		JLFJEGIPIMM.IKGFHGKKCPG.MLNKLINJKBO(this.reelObject, this.actorChar.instanceLayer);
		Debug.Log("" + this.actorName);
	}

	// Token: 0x06002FF2 RID: 12274 RVA: 0x0015D2CC File Offset: 0x0015B4CC
	private void JIIBCGJJLND()
	{
		this.actorChar = base.GetComponent<Character>();
		if (this.actorChar != null)
		{
			this.actorChar.isUpdateMaterial = false;
		}
	}

	// Token: 0x06002FF3 RID: 12275 RVA: 0x00022FCC File Offset: 0x000211CC
	public void DropPointerEvnt()
	{
	}

	// Token: 0x06002FF4 RID: 12276 RVA: 0x0015EC90 File Offset: 0x0015CE90
	private void EJJCEIAGKNK()
	{
		if (this.isKeyPress)
		{
			this.KPKANMFPIKG += Time.fixedDeltaTime * 35f;
		}
		Vector3 vector = this.cDropPoint;
		vector.y = Mathf.Clamp(vector.y, base.transform.position.y + 286f, base.transform.position.y + 876f);
		this.lookIK.solver.IKPositionWeight = this.LHKJOMLGLCB.NKHBAJKMAGD;
		this.lookIK.solver.IKPosition = vector;
		this.bipIK.solver.DBCIMCKLHIM().positionWeight = this.leftHandCntrl.NKHBAJKMAGD * 1847f;
		if (this.currendRodParams != null)
		{
			if (this.currendRodParams.reelPoint != null)
			{
				Transform transform = this.currendRodParams.reelPoint.transform;
				Vector3 vector2 = new Vector3(481f, 1444f, 685f);
				vector2.y += Mathf.Sin(this.KPKANMFPIKG) * 1077f;
				vector2.z += Mathf.Cos(this.KPKANMFPIKG) * 1318f;
				this.currendRodParams.rotTime = this.KPKANMFPIKG;
				Vector3 position = transform.position + transform.right * vector2.x + transform.up * vector2.y + transform.forward * vector2.z;
				if (this.rollPenPointObject != null)
				{
					this.bipIK.solver.CMKJIGNKIMG().target = this.rollPenPointHandObject.transform;
				}
				else
				{
					this.bipIK.solver.EMPOFCMIGLD().position = position;
				}
			}
		}
		else
		{
			this.leftHandCntrl.NKHBAJKMAGD = 1024f;
			this.bipIK.solver.EMPOFCMIGLD().target = null;
		}
		if (this.CMCPFNJIIHK && this.fchair != null)
		{
			float num = this.bipIK.solver.rootNode.transform.position.y - 1112f;
			if (Time.time - this.instChairTime < 181f)
			{
				Vector3 position2 = this.fchair.transform.position;
				position2.y = num - 1927f;
				this.fchair.transform.position = position2;
			}
		}
	}

	// Token: 0x06002FF5 RID: 12277 RVA: 0x0015EF2C File Offset: 0x0015D12C
	private void ONIHHFLOJMN()
	{
		this.cc = base.GetComponent<CharacterController>();
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.createTime = Time.time;
		this.isInit = false;
		base.gameObject.name = "KatanaUpperBlock" + this.shid + "_Offsets";
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-104, this.shid);
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		base.StartCoroutine(this.AIGCNBBKMJD());
		this.PEGLEGPLPCP = base.transform.position;
	}

	// Token: 0x06002FF6 RID: 12278 RVA: 0x0015F00C File Offset: 0x0015D20C
	public void readActorData(HBPNMNGOFMA KADBECGIMPD)
	{
		try
		{
			this.actorName = KADBECGIMPD.BFPHBMDMODH();
			this.titulID = KADBECGIMPD.HDBGOLAFOBK();
			int pjpojnnjocd = this.currentNetWeapons[0].PJPOJNNJOCD;
			int num = KADBECGIMPD.HDBGOLAFOBK();
			for (int i = 0; i < num; i++)
			{
				this.currentNetWeapons[i].PJPOJNNJOCD = KADBECGIMPD.HDBGOLAFOBK();
				this.currentNetWeapons[i].HANEKMFJLDB = KADBECGIMPD.ANGDIBBCJDA(16);
			}
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			byte[] dnhbpgoklkd = KADBECGIMPD.ANGDIBBCJDA(ilfhhdnjhnm);
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.initShadowsParams(dnhbpgoklkd);
			}
			if (!KADBECGIMPD.JCEGOADAOOI)
			{
				long num2 = KADBECGIMPD.DNIIFBAIPBE();
				this.artData = ELCMHGJLFOL.IKGFHGKKCPG.GMPNBBLOHGF(num2);
				this.artData.OCPAHLAGCAI(KADBECGIMPD);
				if (num2 > 0L)
				{
					this.artelText.gameObject.SetActive(true);
					this.artelText.text = this.artData.MNGHILMCBCI;
					this.artelImage.gameObject.SetActive(true);
				}
				else
				{
					this.artelText.gameObject.SetActive(false);
				}
			}
			if (!KADBECGIMPD.JCEGOADAOOI)
			{
				this.level = KADBECGIMPD.HDBGOLAFOBK();
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
			{
				this.actorChar.changeCostume(this.currentNetWeapons[6].PJPOJNNJOCD);
				this.actorChar.changeCap(this.currentNetWeapons[5].PJPOJNNJOCD);
			}
			if (pjpojnnjocd != this.currentNetWeapons[0].PJPOJNNJOCD && this.MFENINHGBHM)
			{
				this.rodcntr = null;
				this.loadRodObject("readActorData");
			}
			base.gameObject.name = string.Concat(new object[]
			{
				"Actor_",
				this.shid,
				"_",
				this.actorName
			});
			this.nameText.text = this.actorName;
			if (this.levelText != null)
			{
				this.levelText.text = string.Concat(this.level);
			}
			this.titulText.text = ((this.titulID > 0) ? NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.titulID, this.actorName, false, false) : "");
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		this.isInit = true;
	}

	// Token: 0x06002FF7 RID: 12279 RVA: 0x0015F290 File Offset: 0x0015D490
	public void FOJKFGFANOO()
	{
		this.isBrag = false;
		this.bragCntrl.NKPLBPKLIKK();
		if (this.ALDJNFLGKNJ != null)
		{
			UnityEngine.Object.Destroy(this.ALDJNFLGKNJ);
		}
		this.ALDJNFLGKNJ = null;
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x0015F2C4 File Offset: 0x0015D4C4
	// (set) Token: 0x06002FFB RID: 12283 RVA: 0x0015F460 File Offset: 0x0015D660
	public bool MFENINHGBHM
	{
		get
		{
			return this.HDLHCMOPIKM;
		}
		set
		{
			bool hdlhcmopikm = this.HDLHCMOPIKM;
			this.HDLHCMOPIKM = value;
			if (hdlhcmopikm & !this.HDLHCMOPIKM)
			{
				if (this.rodObject != null)
				{
					UnityEngine.Object.Destroy(this.rodObject);
				}
				if (this.poplObject != null)
				{
					UnityEngine.Object.Destroy(this.poplObject);
				}
				this.rodObject = null;
				this.reelObject = null;
				this.rodcntr = null;
				this.rodforce = 0f;
				this.blendRodDirection = 0.5f;
			}
			if (this.HDLHCMOPIKM & !hdlhcmopikm)
			{
				base.transform.position = this.toPosition;
				base.transform.rotation = Quaternion.Euler(this.toRotation);
				this.isFishGet = false;
				if (this.actorFish != null)
				{
					UnityEngine.Object.Destroy(this.actorFish.gameObject);
				}
				if (this.rodObject == null && this.currentNetWeapons[0].PJPOJNNJOCD > 0)
				{
					this.loadRodObject("isRodOpen");
				}
			}
			if (this.HDLHCMOPIKM)
			{
				this.legsCntrl.LJIEPIPIAJC(false);
				return;
			}
			this.legsCntrl.HEJDOBFKEHG();
		}
	}

	// Token: 0x06002FF9 RID: 12281 RVA: 0x0015F2CC File Offset: 0x0015D4CC
	private void LPNDCJKAKEA()
	{
		this.cc = base.GetComponent<CharacterController>();
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.createTime = Time.time;
		this.isInit = false;
		base.gameObject.name = "change channek close" + this.shid + "SoccerSprint";
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-92, this.shid);
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		base.StartCoroutine(this.OAIOJJNGPHG());
		this.PEGLEGPLPCP = base.transform.position;
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x0015F3AC File Offset: 0x0015D5AC
	public void LDEIBLFJFFC(bool DCCPCBLODIG)
	{
		this.ADFNLBBFLKK = DCCPCBLODIG;
		if (this.ADFNLBBFLKK)
		{
			this.isMoving = false;
			if (this.fchair == null)
			{
				this.PDBIFHPINDA();
			}
			this.sitCntrl.GLEFDGHDECI(false);
		}
		if (!this.ADFNLBBFLKK)
		{
			this.sitCntrl.LKLIOCDJNLO();
			if (this.fchair != null)
			{
				this.fchair.transform.parent = null;
				DitherShower component = this.fchair.GetComponent<DitherShower>();
				if (component != null)
				{
					component.dirVector = -1;
					component.scaleAlfaKF = 1122f;
				}
				UnityEngine.Object.Destroy(this.fchair, 1639f);
			}
			this.fchair = null;
		}
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x0015F58C File Offset: 0x0015D78C
	public void COGCPHKGFCC()
	{
		string hojhbmnihba = "GestureWonderful";
		Actor.HAGIDCGGJBI hagidcggjbi = this.currentNetWeapons[-70];
		if (hagidcggjbi.PJPOJNNJOCD > 0)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(hagidcggjbi.PJPOJNNJOCD);
			hojhbmnihba = "Identity LUT" + befchfngomi.MIMANMPNLPE.KEHIFGILLJA();
		}
		this.fchair = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, base.transform.position, null);
		JLFJEGIPIMM.PKGMBFEMKGP().KOHAPBIENMH(this.fchair, this.actorChar.instanceLayer);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x06002FFD RID: 12285 RVA: 0x0015D757 File Offset: 0x0015B957
	public void podsakInWaterEvnt()
	{
		this.podsakInWater = true;
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x0015F658 File Offset: 0x0015D858
	private void HHGGCBLOJGB()
	{
		this.cc = base.GetComponent<CharacterController>();
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.createTime = Time.time;
		this.isInit = false;
		base.gameObject.name = "Tried to Initialize the SteamAPI twice in one session!" + this.shid + "_FogData";
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-112, this.shid);
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		base.StartCoroutine(this.AIGCNBBKMJD());
		this.PEGLEGPLPCP = base.transform.position;
	}

	// Token: 0x06003000 RID: 12288 RVA: 0x0015F7B8 File Offset: 0x0015D9B8
	public void CKJKIJFPLLH(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		this.isBrag = false;
		this.bragCntrl.PDFCLBGDGMP(false);
		if (this.ALDJNFLGKNJ == null)
		{
			this.ALDJNFLGKNJ = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("demoByteArray", Vector3.zero, this.leftHandRodPoint);
			this.ALDJNFLGKNJ.GetComponent<BragFish>().HBEFANEMBON(OLKMHFNLBJB, NBLJCEHNKAK, true);
		}
	}

	// Token: 0x06003001 RID: 12289 RVA: 0x0015F81C File Offset: 0x0015DA1C
	public void loadRodObject(string GMNLJGNOKPD)
	{
		if (!this.MFENINHGBHM)
		{
			if (this.rodObject != null)
			{
				UnityEngine.Object.Destroy(this.rodObject);
			}
			this.rodObject = null;
			return;
		}
		this.rodid = this.currentNetWeapons[0].PJPOJNNJOCD;
		if (this.rodid == 0)
		{
			return;
		}
		if (this.rodcntr != null)
		{
			return;
		}
		Debug.Log(string.Concat(new object[]
		{
			"loadRodObject ",
			this.actorName,
			" ",
			GMNLJGNOKPD,
			" ",
			this.currentNetWeapons[0].PJPOJNNJOCD
		}));
		if (HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			this.rodcntr = OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(this.currentNetWeapons[0].PJPOJNNJOCD), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod), "");
			return;
		}
		this.rodcntr = OMDDGEDHHNH.IKGFHGKKCPG.CCFAHNDIBIE(ActorMgr.getI.defaultRod, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod));
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06003002 RID: 12290 RVA: 0x0015DB47 File Offset: 0x0015BD47
	// (set) Token: 0x06003010 RID: 12304 RVA: 0x00160118 File Offset: 0x0015E318
	public bool CMCPFNJIIHK
	{
		get
		{
			return this.ADFNLBBFLKK;
		}
		set
		{
			this.ADFNLBBFLKK = value;
			if (this.ADFNLBBFLKK)
			{
				this.isMoving = false;
				if (this.fchair == null)
				{
					this.instFChair();
				}
				this.sitCntrl.LJIEPIPIAJC(true);
			}
			if (!this.ADFNLBBFLKK)
			{
				this.sitCntrl.HEJDOBFKEHG();
				if (this.fchair != null)
				{
					this.fchair.transform.parent = null;
					DitherShower component = this.fchair.GetComponent<DitherShower>();
					if (component != null)
					{
						component.dirVector = -1;
						component.scaleAlfaKF = 1f;
					}
					UnityEngine.Object.Destroy(this.fchair, 1f);
				}
				this.fchair = null;
			}
		}
	}

	// Token: 0x06003003 RID: 12291 RVA: 0x00022FCC File Offset: 0x000211CC
	public void IBAGCHOGOCI()
	{
	}

	// Token: 0x06003004 RID: 12292 RVA: 0x0015D757 File Offset: 0x0015B957
	public void GJMAOPELLFK()
	{
		this.podsakInWater = true;
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x0015F2C4 File Offset: 0x0015D4C4
	public bool IDGLBENDHEM()
	{
		return this.HDLHCMOPIKM;
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x0015F934 File Offset: 0x0015DB34
	public void OGEFMPOIPEL()
	{
		string hojhbmnihba = "_InvGamma";
		Actor.HAGIDCGGJBI hagidcggjbi = this.currentNetWeapons[117];
		if (hagidcggjbi.PJPOJNNJOCD > 1)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hagidcggjbi.PJPOJNNJOCD);
			hojhbmnihba = "How your position is stored in memory when obscured:\n(" + befchfngomi.MIMANMPNLPE.KEHIFGILLJA();
		}
		this.fchair = JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII(hojhbmnihba, base.transform.position, null);
		JLFJEGIPIMM.PKGMBFEMKGP().FDCHPCBAMIL(this.fchair, this.actorChar.instanceLayer);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x0015FA00 File Offset: 0x0015DC00
	public void MHHLMCLLIGG(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			this.leftHandCntrl.COLDOMMLODD();
			Transform transform = this.leftHandRodPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4Actor, Vector3.zero, Quaternion.identity);
			this.podsakObject.transform.parent = this.leftHandRodPoint;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakPoint = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(this.podsakObject, "_ExposureAdjustment");
			this.podsakInWater = true;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = this.podsakPoint;
			}
		}
		if (CLBPBJGLHEE < 0)
		{
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 357f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = true;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = null;
			}
		}
	}

	// Token: 0x06003008 RID: 12296 RVA: 0x0015FB17 File Offset: 0x0015DD17
	public void LCHHFBNFOHL()
	{
		this.podsakInWater = false;
	}

	// Token: 0x06003009 RID: 12297 RVA: 0x0015FB20 File Offset: 0x0015DD20
	public void HEAIAKFJPKN()
	{
		this.isFishOnRod = true;
		this.isFishGet = false;
		this.CIHILMCEJND = false;
		if (this.actorFish != null)
		{
			ActorMgr.getI.HBACCPIPPIO(this.actorFish.transform.position);
			UnityEngine.Object.Destroy(this.actorFish.gameObject);
			this.actorFish = null;
		}
		if (this.podsakObject != null)
		{
			DitherShower component = this.podsakObject.GetComponent<DitherShower>();
			if (component != null)
			{
				component.dirVector = -1;
				component.scaleAlfaKF = 22f;
			}
		}
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x0015FCB4 File Offset: 0x0015DEB4
	public void ragulaEventProc(int KDMGMLJJALK)
	{
		Debug.Log("ragulaEventProc");
		if (this.ragulaObject != null)
		{
			if (this.rodObject != null)
			{
				this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
				this.rodObject.transform.parent = this.rightHandRodPoint.transform;
				this.rodObject.transform.localPosition = Vector3.zero;
				this.rodObject.transform.localRotation = Quaternion.identity;
				this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
				Vector3 b = this.rodObject.transform.position - this.currendRodParams.handPoint.transform.position;
				this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b;
			}
			UnityEngine.Object.Destroy(this.ragulaObject.gameObject, 0.5f);
			this.ragulaObject = null;
			return;
		}
		this.ragulaObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("ragulaFider", base.transform.position + base.transform.forward * 0.8f, null);
		this.ragulaObject.name = string.Format("Actor_{0}_{1}_ragula", this.actorName, this.shid);
		this.ragulaObject.transform.rotation = base.transform.rotation;
		this.ragulaObject.transform.parent = base.gameObject.transform;
		Ragula component = this.ragulaObject.GetComponent<Ragula>();
		if (this.ragulaObject != null && this.rodObject != null)
		{
			this.rodObject.transform.position = component.rodPoint.transform.position;
			this.rodObject.transform.parent = component.rodPoint.transform;
			this.rodObject.transform.localPosition = Vector3.zero;
			this.rodObject.transform.localRotation = Quaternion.identity;
			this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x00022FCC File Offset: 0x000211CC
	public void BNNMJJACHPD()
	{
	}

	// Token: 0x0600300D RID: 12301 RVA: 0x0015FF34 File Offset: 0x0015E134
	public void JNKBKIKOAHC(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 1)
		{
			this.leftHandCntrl.FBFAJEGEIKM();
			Transform transform = this.leftHandRodPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4Actor, Vector3.zero, Quaternion.identity);
			this.podsakObject.transform.parent = this.leftHandRodPoint;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakPoint = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(this.podsakObject, "Sexy Dance 3");
			this.podsakInWater = false;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = this.podsakPoint;
			}
		}
		if (CLBPBJGLHEE < 0)
		{
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 1760f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = true;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = null;
			}
		}
	}

	// Token: 0x0600300E RID: 12302 RVA: 0x0016004C File Offset: 0x0015E24C
	public void PDBIFHPINDA()
	{
		string hojhbmnihba = "";
		Actor.HAGIDCGGJBI hagidcggjbi = this.currentNetWeapons[98];
		if (hagidcggjbi.PJPOJNNJOCD > 0)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(hagidcggjbi.PJPOJNNJOCD);
			hojhbmnihba = "_BlurVector" + befchfngomi.MIMANMPNLPE.IBEIBAHKIAH;
		}
		this.fchair = JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII(hojhbmnihba, base.transform.position, null);
		JLFJEGIPIMM.MHFDIJGJGBJ().MLNKLINJKBO(this.fchair, this.actorChar.instanceLayer);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x0015E7F5 File Offset: 0x0015C9F5
	public bool IHBAFHCHNAA()
	{
		return this.POFONDFAJLK;
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x001601CC File Offset: 0x0015E3CC
	public void fishTrapEvent(Vector3 MGALEAJOGPL, Vector3 PHKIOHIBNPA, int OLKMHFNLBJB, float NBLJCEHNKAK, float BPJCIKFGOMM)
	{
		this.isBigFish = (BPJCIKFGOMM > 800f);
		this.isFishGet = true;
		this.leftHandCntrl.FBFAJEGEIKM();
		if (!HPGKIJLKCIH.IKGFHGKKCPG.ECCFPLMGJCB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("ActorFish");
		gameObject.name = "ActorFish_" + this.shid;
		gameObject.transform.position = MGALEAJOGPL;
		gameObject.transform.rotation = Quaternion.Euler(PHKIOHIBNPA);
		this.actorFish = gameObject.GetComponent<ActorFish>();
		this.actorFish.fid = OLKMHFNLBJB;
		this.actorFish.wkf = NBLJCEHNKAK;
		this.actorFish.wgt = BPJCIKFGOMM;
		this.actorFish.leftHandRodPoint = this.leftHandRodPoint;
		this.actorFish.getEvent();
		this.actorFish.isBigFish = this.isBigFish;
		this.actorFish.actor = this;
	}

	// Token: 0x06003012 RID: 12306 RVA: 0x001602BC File Offset: 0x0015E4BC
	public void podsakEvnt(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			this.leftHandCntrl.FBFAJEGEIKM();
			Transform transform = this.leftHandRodPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4Actor, Vector3.zero, Quaternion.identity);
			this.podsakObject.transform.parent = this.leftHandRodPoint;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakPoint = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(this.podsakObject, "toFishPoint");
			this.podsakInWater = false;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = this.podsakPoint;
			}
		}
		if (CLBPBJGLHEE < 0)
		{
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 1f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = false;
			if (this.actorFish != null)
			{
				this.actorFish.podsakPoint = null;
			}
		}
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x001603D4 File Offset: 0x0015E5D4
	private void Update()
	{
		if (!this.isInit && Time.time - this.createTime > 5f && base.gameObject != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (this.rollPenPointObject != null)
		{
			if (this.currendRollParams != null)
			{
				this.rollPenPointObject.SetActive(true);
				this.rollPenPointObject.transform.position = this.currendRollParams.handPoint.transform.position;
			}
			else
			{
				this.rollPenPointObject.SetActive(false);
			}
		}
		if (this.isRagulaSet)
		{
			if (this.ragulaObject != null)
			{
				this.ragulaObject.transform.position = this.ragulaPosition;
				this.ragulaObject.transform.rotation = Quaternion.Euler(this.ragulaRotation);
			}
			if (this.currendRodParams != null)
			{
				this.FDFPGIEPDDJ = Mathf.Clamp(this.FDFPGIEPDDJ, 5f, 40f);
			}
		}
		this.PPOFFIDHBKF += Vector3.Distance(base.transform.position, this.PEGLEGPLPCP);
		this.DLDMKCIFFPP += Time.deltaTime;
		if (this.DLDMKCIFFPP > 1f)
		{
			this.DLDMKCIFFPP = 0f;
			this.PEGLEGPLPCP = base.transform.position;
			if (this.PPOFFIDHBKF < 0.3f)
			{
				this.isMoving = false;
			}
		}
		if ((base.transform.position - this.toPosition).magnitude > 5f)
		{
			base.transform.position = this.toPosition;
		}
		if (this.nameCanvas != null)
		{
			this.nameCanvas.transform.LookAt(Camera.main.transform);
			this.nameCanvas.transform.Rotate(0f, 180f, 0f);
		}
		if (this.MFENINHGBHM)
		{
			this.isMoving = false;
		}
		if (this.isMoving)
		{
			Vector3 a = this.toMovePoint;
			a.y = base.transform.position.y;
			float num = Vector3.Distance(a, base.transform.position);
			this.isMoving = (num >= 0.2f);
			Vector3 a2 = this.toMovePoint;
			a2.y = base.transform.position.y;
			Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 10f);
			if (a.magnitude > 0.1f && Vector3.Distance(a, base.transform.position) > 0.1f)
			{
				this.action.FBFAJEGEIKM();
				this.cc.Move(base.transform.TransformDirection(Vector3.forward) * this.moveSpeed * Time.deltaTime);
			}
		}
		else
		{
			Vector3 position = Vector3.Lerp(base.transform.position, this.toPosition, Time.deltaTime * 5f);
			position.y = base.transform.position.y;
			base.transform.position = position;
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, Quaternion.Euler(this.toRotation), Time.deltaTime * 5f);
		}
		if (!this.CIHILMCEJND)
		{
			this.isKeyPress = false;
		}
		if (this.CIHILMCEJND)
		{
			bool flag = false;
			if (this.dropType == 102)
			{
				flag = true;
			}
			if (this.dropType == 1)
			{
				flag = true;
			}
			if (this.isFishOnRod)
			{
				flag = true;
			}
			if (this.isFishGet)
			{
				flag = false;
			}
			this.LHKJOMLGLCB.FPIDHIOGEAM();
			if (flag)
			{
				this.leftHandCntrl.FPIDHIOGEAM();
			}
			else
			{
				this.leftHandCntrl.FBFAJEGEIKM();
			}
		}
		else
		{
			this.LHKJOMLGLCB.FBFAJEGEIKM();
			this.leftHandCntrl.FBFAJEGEIKM();
		}
		if (!this.CIHILMCEJND)
		{
			this.rodforce = 0f;
		}
		if ((this.CIHILMCEJND & !this.isFishOnRod) && !this.isRagulaSet)
		{
			this.rodforce = 0f;
		}
		this.cDropPoint = Vector3.Lerp(this.cDropPoint, this.toDropPoint, Time.deltaTime * 0.3f);
		this.FEJPPCFGDCF = Mathf.Lerp(this.FEJPPCFGDCF, this.blendRodDirection, Time.deltaTime * 0.3f);
		this.c_upRodState = Mathf.Lerp(this.c_upRodState, this.upRodState, Time.deltaTime * 0.3f);
		this.FDFPGIEPDDJ = Mathf.Lerp(this.FDFPGIEPDDJ, this.rodforce, Time.deltaTime * 0.5f);
		if (this.isRagulaSet)
		{
			this.FDFPGIEPDDJ = Mathf.Clamp(this.FDFPGIEPDDJ, 5f, 40f);
		}
		if (this.currendRodParams != null)
		{
			this.currendRodParams.PGEDLDMLBBE = this.FDFPGIEPDDJ;
			this.currendRodParams.target = this.cDropPoint;
		}
		this.LHKJOMLGLCB.FANPFKHEDPA();
		this.leftHandCntrl.FANPFKHEDPA();
		this.action.ACJNDCKOMME(this.anm);
		if (this.anm != null)
		{
			this.legsCntrl.FIDCELLHJIH(this.anm);
			this.bragCntrl.FIDCELLHJIH(this.anm);
			this.sitCntrl.FIDCELLHJIH(this.anm);
			this.anm.SetBool("isBigFish", this.isBigFish);
			this.anm.SetBool("isMoving", this.isMoving);
			this.anm.SetBool("isWoman", this.isWoman);
			this.anm.SetBool("isRodOpen", this.MFENINHGBHM);
			this.anm.SetBool("isRodInWater", this.CIHILMCEJND);
			this.anm.SetBool("isFishOnRod", this.isFishOnRod);
			this.anm.SetInteger("DropType", this.dropType);
			this.anm.SetBool("isKeyPress", this.isKeyPress);
			this.anm.SetFloat("BlendDirection", this.FEJPPCFGDCF);
			this.anm.SetBool("isFishGet", this.isFishGet);
			this.anm.SetBool("isRagulaSet", this.isRagulaSet);
			this.anm.SetFloat("upRodState", this.c_upRodState);
			this.anm.SetBool("isBrag", this.isBrag);
			this.anm.SetBool("isHarvest", this.isHarvest);
			this.anm.SetBool("isRun", this.isRun);
		}
	}

	// Token: 0x0400068A RID: 1674
	public Transform rightHandRodPoint;

	// Token: 0x0400068B RID: 1675
	public Transform leftHandRodPoint;

	// Token: 0x0400068C RID: 1676
	public GameObject rollPenPointObject;

	// Token: 0x0400068D RID: 1677
	public GameObject rollPenPointHandObject;

	// Token: 0x0400068E RID: 1678
	public Transform camPoint;

	// Token: 0x0400068F RID: 1679
	public Canvas nameCanvas;

	// Token: 0x04000690 RID: 1680
	public Text nameText;

	// Token: 0x04000691 RID: 1681
	public Text levelText;

	// Token: 0x04000692 RID: 1682
	public Text titulText;

	// Token: 0x04000693 RID: 1683
	public Text artelText;

	// Token: 0x04000694 RID: 1684
	public Image artelImage;

	// Token: 0x04000695 RID: 1685
	public MessageCloud cloudMsg;

	// Token: 0x04000696 RID: 1686
	public long shid;

	// Token: 0x04000697 RID: 1687
	public string actorName;

	// Token: 0x04000698 RID: 1688
	public int titulID;

	// Token: 0x04000699 RID: 1689
	public int rodid = -1;

	// Token: 0x0400069A RID: 1690
	public int level;

	// Token: 0x0400069B RID: 1691
	public bool isMoving;

	// Token: 0x0400069C RID: 1692
	public bool isWoman;

	// Token: 0x0400069D RID: 1693
	public bool isBigFish;

	// Token: 0x0400069E RID: 1694
	public bool isKeyPress;

	// Token: 0x0400069F RID: 1695
	public int dropType;

	// Token: 0x040006A0 RID: 1696
	public bool isFishOnRod;

	// Token: 0x040006A1 RID: 1697
	public bool isFishGet;

	// Token: 0x040006A2 RID: 1698
	public bool isBrag;

	// Token: 0x040006A3 RID: 1699
	public bool isHarvest;

	// Token: 0x040006A4 RID: 1700
	public Vector3 toPosition;

	// Token: 0x040006A5 RID: 1701
	public Vector3 toRotation;

	// Token: 0x040006A6 RID: 1702
	public Vector3 toMovePoint;

	// Token: 0x040006A7 RID: 1703
	public Vector3 toDropPoint;

	// Token: 0x040006A8 RID: 1704
	public int rodType;

	// Token: 0x040006A9 RID: 1705
	public Vector3 cDropPoint;

	// Token: 0x040006AA RID: 1706
	public float moveSpeed;

	// Token: 0x040006AB RID: 1707
	public bool isRun;

	// Token: 0x040006AC RID: 1708
	public CharacterController cc;

	// Token: 0x040006AD RID: 1709
	public Animator anm;

	// Token: 0x040006AE RID: 1710
	public FullBodyBipedIK bipIK;

	// Token: 0x040006AF RID: 1711
	public LookAtIK lookIK;

	// Token: 0x040006B0 RID: 1712
	public Character actorChar;

	// Token: 0x040006B1 RID: 1713
	private bool BMAAHBJEDII;

	// Token: 0x040006B2 RID: 1714
	private Collider BIDCLDDLKGI;

	// Token: 0x040006B3 RID: 1715
	public GameObject ragulaObject;

	// Token: 0x040006B4 RID: 1716
	public GameObject rodObject;

	// Token: 0x040006B5 RID: 1717
	public GameObject reelObject;

	// Token: 0x040006B6 RID: 1718
	public GameObject poplObject;

	// Token: 0x040006B7 RID: 1719
	public RodParams currendRodParams;

	// Token: 0x040006B8 RID: 1720
	public RollParams currendRollParams;

	// Token: 0x040006B9 RID: 1721
	public INHGGGPJEAL.PLCPMBBKHAI legsCntrl = new INHGGGPJEAL.PLCPMBBKHAI(1, 0.2f);

	// Token: 0x040006BA RID: 1722
	public INHGGGPJEAL.PLCPMBBKHAI bragCntrl = new INHGGGPJEAL.PLCPMBBKHAI(2, 1f);

	// Token: 0x040006BB RID: 1723
	private readonly INHGGGPJEAL.MDLFOFLAIJK LHKJOMLGLCB = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040006BC RID: 1724
	public readonly INHGGGPJEAL.MDLFOFLAIJK leftHandCntrl = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040006BD RID: 1725
	public INHGGGPJEAL.FMOJFAJDDEH action = new INHGGGPJEAL.FMOJFAJDDEH("action");

	// Token: 0x040006BE RID: 1726
	public INHGGGPJEAL.PLCPMBBKHAI sitCntrl = new INHGGGPJEAL.PLCPMBBKHAI(3, 1f);

	// Token: 0x040006BF RID: 1727
	public OMDDGEDHHNH.BCDNKAGAFBM rodcntr;

	// Token: 0x040006C0 RID: 1728
	public float blendRodDirection;

	// Token: 0x040006C1 RID: 1729
	public float upRodState;

	// Token: 0x040006C2 RID: 1730
	public float rodforce;

	// Token: 0x040006C3 RID: 1731
	public bool isRagulaSet;

	// Token: 0x040006C4 RID: 1732
	public Vector3 ragulaPosition;

	// Token: 0x040006C5 RID: 1733
	public Vector3 ragulaRotation;

	// Token: 0x040006C6 RID: 1734
	public float c_upRodState;

	// Token: 0x040006C7 RID: 1735
	private float FEJPPCFGDCF;

	// Token: 0x040006C8 RID: 1736
	private float FDFPGIEPDDJ;

	// Token: 0x040006C9 RID: 1737
	public ActorFish actorFish;

	// Token: 0x040006CA RID: 1738
	public const int _currRod = 0;

	// Token: 0x040006CB RID: 1739
	public const int _currCat = 1;

	// Token: 0x040006CC RID: 1740
	public const int _currTop = 2;

	// Token: 0x040006CD RID: 1741
	public const int _currBottom = 3;

	// Token: 0x040006CE RID: 1742
	public const int _currBoots = 4;

	// Token: 0x040006CF RID: 1743
	public const int _currCap = 5;

	// Token: 0x040006D0 RID: 1744
	public const int _currCostume = 6;

	// Token: 0x040006D1 RID: 1745
	public const int _currPopl = 7;

	// Token: 0x040006D2 RID: 1746
	public const int _currPet = 8;

	// Token: 0x040006D3 RID: 1747
	public const int _currChair = 9;

	// Token: 0x040006D4 RID: 1748
	public ELCMHGJLFOL.FDEPADNCGIF artData;

	// Token: 0x040006D5 RID: 1749
	public GameObject fchair;

	// Token: 0x040006D6 RID: 1750
	private bool ADFNLBBFLKK;

	// Token: 0x040006D7 RID: 1751
	public float instChairTime;

	// Token: 0x040006D8 RID: 1752
	private int HCBDBHPMPIL;

	// Token: 0x040006D9 RID: 1753
	private bool POFONDFAJLK;

	// Token: 0x040006DA RID: 1754
	private bool HDLHCMOPIKM;

	// Token: 0x040006DB RID: 1755
	public readonly Actor.HAGIDCGGJBI[] currentNetWeapons = new Actor.HAGIDCGGJBI[12];

	// Token: 0x040006DC RID: 1756
	public float createTime;

	// Token: 0x040006DD RID: 1757
	public bool isInit;

	// Token: 0x040006DE RID: 1758
	private GameObject ALDJNFLGKNJ;

	// Token: 0x040006DF RID: 1759
	public GameObject podsakObject;

	// Token: 0x040006E0 RID: 1760
	public GameObject podsakPoint;

	// Token: 0x040006E1 RID: 1761
	public bool podsakInWater;

	// Token: 0x040006E2 RID: 1762
	private Vector3 PEGLEGPLPCP;

	// Token: 0x040006E3 RID: 1763
	private float PPOFFIDHBKF;

	// Token: 0x040006E4 RID: 1764
	private float DLDMKCIFFPP;

	// Token: 0x040006E5 RID: 1765
	private float KPKANMFPIKG;

	// Token: 0x02000100 RID: 256
	public struct HAGIDCGGJBI
	{
		// Token: 0x06003014 RID: 12308 RVA: 0x00160ABC File Offset: 0x0015ECBC
		public int JBIBCDEMOHN()
		{
			long num = (long)(-32 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i++)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00160B00 File Offset: 0x0015ED00
		public int KPLLFDMNCHB()
		{
			long num = (long)(-58 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 0; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00160B44 File Offset: 0x0015ED44
		public int HFNNAMGMABF()
		{
			long num = (long)(-16 * this.PJPOJNNJOCD);
			int num2 = 1;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00160B88 File Offset: 0x0015ED88
		public int ADOKEMNFAFN()
		{
			long num = (long)(50 * this.PJPOJNNJOCD);
			int num2 = 1;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00160BCC File Offset: 0x0015EDCC
		public int ILOLAMNNBAD()
		{
			long num = (long)(104 * this.PJPOJNNJOCD);
			int num2 = 0;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00160C10 File Offset: 0x0015EE10
		public int ODLIHHOIDDD()
		{
			long num = (long)(111 * this.PJPOJNNJOCD);
			int num2 = 1;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00160C54 File Offset: 0x0015EE54
		public int GDOHAJAGGMB()
		{
			long num = (long)(93 * this.PJPOJNNJOCD);
			int num2 = 1;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00160C98 File Offset: 0x0015EE98
		public int ECMOPELFJOL()
		{
			long num = (long)(10 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i++)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00160CDC File Offset: 0x0015EEDC
		public int CNGGPMFMOOG()
		{
			long num = (long)(-30 * this.PJPOJNNJOCD);
			int num2 = 1;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00160D20 File Offset: 0x0015EF20
		public int AJBGJHMCJBN()
		{
			long num = (long)(-113 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i++)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00160D64 File Offset: 0x0015EF64
		public int NJMLFNNFHEJ()
		{
			long num = (long)(-107 * this.PJPOJNNJOCD);
			int num2 = 1;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00160DA8 File Offset: 0x0015EFA8
		public int NBCNGKGMPIK()
		{
			long num = (long)(-21 * this.PJPOJNNJOCD);
			int num2 = 0;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00160DEC File Offset: 0x0015EFEC
		public int DABPODMNGMN()
		{
			long num = (long)(-83 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00160E30 File Offset: 0x0015F030
		public int PPJPECBLBAP()
		{
			long num = (long)(-57 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00160E74 File Offset: 0x0015F074
		public int NKEPJLPPNBM()
		{
			long num = (long)(5 * this.PJPOJNNJOCD);
			int num2 = 1;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 0; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00160EB8 File Offset: 0x0015F0B8
		public int CLPAGDPPNKJ()
		{
			long num = (long)(40 * this.PJPOJNNJOCD);
			int num2 = 1;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 0; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x00160EFC File Offset: 0x0015F0FC
		public int HALPKJBNBJF
		{
			get
			{
				long num = (long)(16 * this.PJPOJNNJOCD);
				int num2 = 1;
				foreach (byte b in this.HANEKMFJLDB)
				{
					num += (long)((int)b * num2);
					num2++;
				}
				return (int)num;
			}
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00160F40 File Offset: 0x0015F140
		public int CAFGNDNHAMN()
		{
			long num = (long)(126 * this.PJPOJNNJOCD);
			int num2 = 1;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 0; i < hanekmfjldb.Length; i += 0)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00160F84 File Offset: 0x0015F184
		public int JGEHLJPKDBN()
		{
			long num = (long)(-55 * this.PJPOJNNJOCD);
			int num2 = 0;
			byte[] hanekmfjldb = this.HANEKMFJLDB;
			for (int i = 1; i < hanekmfjldb.Length; i++)
			{
				byte b = hanekmfjldb[i];
				num += (long)((int)b * num2);
				num2 += 0;
			}
			return (int)num;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00160FC8 File Offset: 0x0015F1C8
		public int DOLGOLHANAB()
		{
			long num = (long)(127 * this.PJPOJNNJOCD);
			int num2 = 1;
			foreach (byte b in this.HANEKMFJLDB)
			{
				num += (long)((int)b * num2);
				num2++;
			}
			return (int)num;
		}

		// Token: 0x040006E6 RID: 1766
		public const byte NGPIGJAOEIP = 0;

		// Token: 0x040006E7 RID: 1767
		public const byte MDBMEJHOIOM = 1;

		// Token: 0x040006E8 RID: 1768
		public const byte ACKOCDCCIGN = 2;

		// Token: 0x040006E9 RID: 1769
		public const byte LKLLHCGGFDB = 3;

		// Token: 0x040006EA RID: 1770
		public const byte EKDPAFFPKGB = 4;

		// Token: 0x040006EB RID: 1771
		public const byte ILKDIPAJFMM = 5;

		// Token: 0x040006EC RID: 1772
		public const byte BFODMLMOCOO = 6;

		// Token: 0x040006ED RID: 1773
		public const byte HHEEKCJKHJD = 7;

		// Token: 0x040006EE RID: 1774
		public const byte BJMPBFAKIHB = 8;

		// Token: 0x040006EF RID: 1775
		public const byte KEEKKMKGGBH = 9;

		// Token: 0x040006F0 RID: 1776
		public const byte AKFNEBDCFKN = 10;

		// Token: 0x040006F1 RID: 1777
		public const byte BKOIODOGIGD = 11;

		// Token: 0x040006F2 RID: 1778
		public const byte DIKCAPOHMAB = 12;

		// Token: 0x040006F3 RID: 1779
		public const byte PBOMMOMGLDH = 13;

		// Token: 0x040006F4 RID: 1780
		public const byte FKIDKHPODAI = 14;

		// Token: 0x040006F5 RID: 1781
		public const byte DBADPGLDDBF = 15;

		// Token: 0x040006F6 RID: 1782
		public int PJPOJNNJOCD;

		// Token: 0x040006F7 RID: 1783
		public byte[] HANEKMFJLDB;
	}
}
