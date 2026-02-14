using System;
using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200010F RID: 271
public class Fisherman : MonoBehaviour
{
	// Token: 0x0600344A RID: 13386 RVA: 0x0018BB60 File Offset: 0x00189D60
	public void NHMCKNHHGLE(bool DCCPCBLODIG)
	{
		if (FlyMessageManager.getI.MMIMPMPGHPN(29))
		{
			DCCPCBLODIG = true;
		}
		bool mfmjcajkkjk = this.MFMJCAJKKJK;
		this.MFMJCAJKKJK = DCCPCBLODIG;
		if (this.MFMJCAJKKJK != mfmjcajkkjk)
		{
			this.sendMoveAction();
		}
		if (this.MFMJCAJKKJK)
		{
			this.toLookCntrl.KCMDIKFODAH();
		}
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x0018BBAE File Offset: 0x00189DAE
	public bool JIBGPKCOLML()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM;
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x0018BBC0 File Offset: 0x00189DC0
	public void MJALNEKMFIC()
	{
		LocNewLogic.getI.frikcionSound.Stop();
		LocNewLogic.getI.stopRollSound();
		this.usermode = Fisherman.NHOCKOJNFFJ.FishOnRod;
		this.isFishGet = true;
		this.isKeyPress = false;
		this.CIHILMCEJND = false;
		this.sendGetFishAction();
		if (this.dropScrpt != null && this.dropScrpt.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.dropScrpt.fishPointer);
			this.dropScrpt.fishPointer = null;
		}
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x0018BC45 File Offset: 0x00189E45
	public void LNFIJPICHPG(bool DCCPCBLODIG)
	{
		bool cdnabihplhm = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = DCCPCBLODIG;
		if (cdnabihplhm != BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM)
		{
			this.DIABHIBCKIA();
		}
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x0018BC7D File Offset: 0x00189E7D
	public void NOAOMDOFEBD()
	{
		base.StartCoroutine(this.MFDEGBDIFCD());
	}

	// Token: 0x0600344F RID: 13391 RVA: 0x0018BC8C File Offset: 0x00189E8C
	public void INHDHFFCFOM(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 1)
		{
			Debug.Log("_Threshold");
			Transform transform = this.leftHandPodsakPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4User, transform.position, transform.rotation);
			this.podsakObject.transform.parent = transform;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakObject.transform.localScale = new Vector3(1617f, 967f, 531f);
			this.podsakPoint = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(this.podsakObject, "1HandSwordChargeUp");
			this.podsakInWater = true;
		}
		if (CLBPBJGLHEE < 1)
		{
			Debug.Log("id");
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 747f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = true;
		}
	}

	// Token: 0x06003450 RID: 13392 RVA: 0x0018BD94 File Offset: 0x00189F94
	public void UserLookAtOff()
	{
		this.toLookCntrl.FBFAJEGEIKM();
	}

	// Token: 0x06003451 RID: 13393 RVA: 0x0018BDA1 File Offset: 0x00189FA1
	private IEnumerator IKNBAFLKELI(float FGNPJLIPNFM)
	{
		this.getBragCntrl.LJIEPIPIAJC(true);
		yield return new WaitForSeconds(FGNPJLIPNFM);
		this.getBragCntrl.HEJDOBFKEHG();
		if (this.bragfish != null)
		{
			UnityEngine.Object.Destroy(this.bragfish.gameObject, 0.2f);
		}
		this.bragfish = null;
		yield break;
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x0018BDB8 File Offset: 0x00189FB8
	public void IFMPADKADHO()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			byte bjppebpndnj = 0;
			switch (this.usermode)
			{
			case Fisherman.NHOCKOJNFFJ.Stay:
				bjppebpndnj = 1;
				break;
			case Fisherman.NHOCKOJNFFJ.Fishing:
				bjppebpndnj = 7;
				break;
			case Fisherman.NHOCKOJNFFJ.FishOnRod:
				bjppebpndnj = 3;
				break;
			case Fisherman.NHOCKOJNFFJ.FishGet:
				bjppebpndnj = 4;
				break;
			}
			this.IKFAJMDKABN(epmphjgalbe, 1);
			epmphjgalbe.BLCJKEJDGBI(bjppebpndnj);
			epmphjgalbe.JDOLCNDNFGP(ObscuredInt.GOOIABGKMHK(this.keyCount));
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(142, epmphjgalbe.ALLANCHILCM());
			this.HLCIJLIJECO = Time.time;
		}
		finally
		{
			epmphjgalbe.OGPGOEJFIBO();
		}
		this.keyCount = ObscuredInt.KHJPCCFDJPA(0);
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x0018BE60 File Offset: 0x0018A060
	private void AKGBDJDMOLC()
	{
		this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		Fisherman.getI = this;
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x0018BE74 File Offset: 0x0018A074
	public void ragulaEventProc(int KDMGMLJJALK)
	{
		Debug.Log("ragulaEventProc");
		if (this.ragula != null)
		{
			this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
			this.rodObject.transform.parent = this.rightHandRodPoint.transform;
			this.rodObject.transform.localPosition = Vector3.zero;
			this.rodObject.transform.localRotation = Quaternion.identity;
			this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
			Vector3 b = this.rodObject.transform.position - this.AOEGNGOGNBI.handPoint.transform.position;
			this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b;
			if (this.bubenec != null)
			{
				UnityEngine.Object.Destroy(this.bubenec.gameObject);
			}
			UnityEngine.Object.Destroy(this.ragula.gameObject, 0.5f);
			this.ragula = null;
			this.bubenec = null;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP = false;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
			if (this.CDNABIHPLHM)
			{
				this.podsek();
			}
		}
		else
		{
			GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("ragulaFider", base.transform.position + base.transform.forward * 0.8f, null);
			gameObject.transform.rotation = base.transform.rotation;
			this.ragula = gameObject.GetComponent<Ragula>();
			if (this.ragula != null)
			{
				this.rodObject.transform.position = this.ragula.rodPoint.transform.position;
				this.rodObject.transform.parent = this.ragula.rodPoint.transform;
				this.rodObject.transform.localPosition = Vector3.zero;
				this.rodObject.transform.localRotation = Quaternion.identity;
				this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
				if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.bellPoint != null)
				{
					this.bubenec = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("Bubenec", BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.bellPoint.transform.position, null);
				}
			}
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP = true;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
		}
		this.sendFishingAction();
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060034FB RID: 13563 RVA: 0x0018C23C File Offset: 0x0018A43C
	// (set) Token: 0x06003455 RID: 13397 RVA: 0x0018C19C File Offset: 0x0018A39C
	public bool IHCKLDNAPDF
	{
		get
		{
			return this.KIMMNMDIBLF;
		}
		set
		{
			if (this.KIMMNMDIBLF != value)
			{
				Vector3 position = base.transform.position;
				if (this.selectedMIO != null)
				{
					position = this.selectedMIO.transform.position;
				}
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					this.NFKHEGEDAMG(epmphjgalbe, 1);
					epmphjgalbe.JFBJCKCHMBC(112);
					epmphjgalbe.KJDIGAKNOAI(value);
					epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(position));
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			this.KIMMNMDIBLF = value;
		}
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x0018C23C File Offset: 0x0018A43C
	public bool PBOOMCDCLNG()
	{
		return this.KIMMNMDIBLF;
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x0018C244 File Offset: 0x0018A444
	public void breakAction()
	{
		this.MFENINHGBHM = false;
		this.isBreak = true;
		this.UserLookAtOff();
		this.leftHandCntrl.FBFAJEGEIKM();
		this.rightHandCntrl.FBFAJEGEIKM();
		this.aimCntrl.FBFAJEGEIKM();
		this.toLookCntrl.FBFAJEGEIKM();
		if (this.dropScrpt != null)
		{
			this.dropScrpt.kill();
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		if (this.BHMHJBPGOPH != null)
		{
			UnityEngine.Object.Destroy(this.BHMHJBPGOPH);
		}
		if (this.rodObject != null)
		{
			UnityEngine.Object.Destroy(this.rodObject);
		}
		if (this.bubenec != null)
		{
			UnityEngine.Object.Destroy(this.bubenec.gameObject);
		}
		if (this.ragula != null)
		{
			UnityEngine.Object.Destroy(this.ragula.gameObject);
		}
		LocNewLogic.getI.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x0018C336 File Offset: 0x0018A536
	private void LEHADJGICJB(ONKDCGNBALK ONPHLHKAGFP)
	{
		this.IHCKLDNAPDF = false;
		if (this.selectedMIO != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1510, this.selectedMIO.pointId);
		}
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x0018C367 File Offset: 0x0018A567
	public void NBHBIELHMEM(RodParams DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI = DCCPCBLODIG;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x0018C380 File Offset: 0x0018A580
	public void EDNIPCLGMCF(HBPNMNGOFMA KADBECGIMPD)
	{
		BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(KADBECGIMPD.LPKJHMGLCKA());
		if (diggohpgcnn.OKEBIHBDEOO(""))
		{
			FlyMessageManager.getI.KICLBJKBFNO(JNBICAJIJMM.PPNKMDJBMLP("ClimbIdle"), Color.red, 0, 1);
		}
		if (diggohpgcnn.CPGPEHEHCPI(""))
		{
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.OOOKJHOHPNN("id"), Color.red, 0, 1);
		}
		if (diggohpgcnn.LOMKLMPKJEC("[wtemplid]"))
		{
			FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.DCEBAJIILPC("</color>"), Color.red, 0, 0);
		}
		if (diggohpgcnn.JKHEMJCFJGJ("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.") && this.selectedMIO != null)
		{
			this.BFJPLGICCNA(false);
			JDCEFOFMGHB.JFIDAGABKID().DKJMCKOJOPF(diggohpgcnn.GCMMMODHDBL(), 0, JNBICAJIJMM.DCEBAJIILPC("KatanaNinjaDraw"), new ONKDCGNBALK.CMMHGMILOIM(this.HJKKPOBKEKC), true);
		}
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x0018C45E File Offset: 0x0018A65E
	public Vector3 MHPCDONGDFM()
	{
		return this.toLookPoint;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x0018C466 File Offset: 0x0018A666
	public void GAFDPAJBACL(int LBCGACKJCJB, string EDAPHMJENPK)
	{
		if (this.msgCloud == null)
		{
			return;
		}
		this.msgCloud.HPCJBBJLAKL(EDAPHMJENPK, LBCGACKJCJB, 1016f);
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x0018C48C File Offset: 0x0018A68C
	public void sendMoveAction()
	{
		if (Time.time - this.BFOIGHICKNN < 1f)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			byte bjppebpndnj = 104;
			if (this.MIBOJMFKFGI)
			{
				bjppebpndnj = 103;
			}
			epmphjgalbe.JFBJCKCHMBC(bjppebpndnj);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.sendToServerUserStates();
		this.BFOIGHICKNN = Time.time;
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x0018C510 File Offset: 0x0018A710
	public void forceControl(Transform NCADHGFGICO)
	{
		if (this.AOEGNGOGNBI == null)
		{
			return;
		}
		if (NCADHGFGICO == null)
		{
			this.AOEGNGOGNBI.PGEDLDMLBBE = 0f;
			this.AOEGNGOGNBI.target = Vector3.zero;
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.AOEGNGOGNBI != null)
		{
			ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ);
			this.rodforce = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL) / 1f;
			this.AOEGNGOGNBI.target = NCADHGFGICO.position;
			Vector3 from = this.AOEGNGOGNBI.transform.forward * this.AOEGNGOGNBI.actualRodLength;
			Vector3 to = this.AOEGNGOGNBI.ILCJJKCPBKC - NCADHGFGICO.position;
			float num = Mathf.Abs(Mathf.Sin(Vector3.Angle(from, to) * 3.1415927f / 180f));
			this.rodforce *= num;
			float num2 = 1f;
			if (this.CDNABIHPLHM & this.isPodsek)
			{
				num2 = 2f;
			}
			this.AOEGNGOGNBI.PGEDLDMLBBE = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL) * num2 + LocNewLogic.getI.getAnimForceState();
		}
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x0018C65C File Offset: 0x0018A85C
	public void PJIGPFAPIKD()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		this.KANMIKKAPDI = base.transform.forward * 116f;
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.aimCntrl.OPEKLHFIDCK();
			return;
		}
		Transform transform = Camera.main.transform;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			transform = base.transform;
		}
		float d = this.upRodState;
		this.KANMIKKAPDI = transform.forward * 1601f + transform.up * 1135f * this.aimConst.z;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			float num = 1374f * (Input.mousePosition.y - (float)Screen.height / 308f) / (float)Screen.height;
			this.KANMIKKAPDI.y = this.KANMIKKAPDI.y + num * 1338f;
			this.KANMIKKAPDI += this.blendRodDirection * transform.right * 137f * 403f * this.aimConst.x;
		}
		if (this.rodObject != null && this.dropScrpt != null)
		{
			Vector3 vector = (this.IJMGCKIOBPP().ILCJJKCPBKC - this.dropScrpt.transform.position).normalized;
			float t = Mathf.Abs(this.blendRodDirection);
			vector = Vector3.Lerp(Vector3.up, vector, t);
			this.KANMIKKAPDI += vector * d * 432f * this.aimConst.y;
			return;
		}
		this.KANMIKKAPDI += transform.up * this.upRodState * 1420f * this.aimConst.y;
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060034CC RID: 13516 RVA: 0x00194365 File Offset: 0x00192565
	// (set) Token: 0x06003460 RID: 13408 RVA: 0x0018C870 File Offset: 0x0018AA70
	public bool EPMDDMKLDGC
	{
		get
		{
			return HPGKIJLKCIH.IKGFHGKKCPG.EPMDDMKLDGC;
		}
		set
		{
			HPGKIJLKCIH.IKGFHGKKCPG.EPMDDMKLDGC = value;
		}
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x0018C87D File Offset: 0x0018AA7D
	public void onChatMessage(int LBCGACKJCJB, string EDAPHMJENPK)
	{
		if (this.msgCloud == null)
		{
			return;
		}
		this.msgCloud.showMessage(EDAPHMJENPK, LBCGACKJCJB, 5f);
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x0018C8A0 File Offset: 0x0018AAA0
	public void sendFishingAction()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC(109);
			epmphjgalbe.JFBJCKCHMBC((byte)this.DropType);
			epmphjgalbe.GOMLLPFFPNP(BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
			epmphjgalbe.KJDIGAKNOAI(this.MFENINHGBHM);
			epmphjgalbe.KJDIGAKNOAI(this.CIHILMCEJND);
			epmphjgalbe.KJDIGAKNOAI(this.isPodsek & this.CDNABIHPLHM);
			Vector3 bdgecgghecb = base.transform.position + base.transform.forward * 5f;
			if (this.dropScrpt != null)
			{
				bdgecgghecb = this.dropScrpt.toPos;
				if (this.dropScrpt.mode >= 2)
				{
					bdgecgghecb = this.dropScrpt.transform.position;
				}
				if (this.CDNABIHPLHM)
				{
					bdgecgghecb = this.dropScrpt.fish.transform.position;
				}
			}
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(bdgecgghecb));
			epmphjgalbe.DLAIEEJAFDG(this.blendRodDirection);
			epmphjgalbe.DLAIEEJAFDG(this.rodforce);
			epmphjgalbe.DLAIEEJAFDG(this.upRodState);
			epmphjgalbe.KJDIGAKNOAI(this.ragula != null);
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.position : Vector3.zero));
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.rotation.eulerAngles : Vector3.zero));
			if (this.CDNABIHPLHM)
			{
				epmphjgalbe.GOMLLPFFPNP(ObscuredInt.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NENOBDLCFHO));
				epmphjgalbe.DLAIEEJAFDG(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
				epmphjgalbe.BJANIMFDENK((this.dropScrpt == null) ? IIBEEKCAAHK.ECOFBCMPIDO : new IIBEEKCAAHK(this.dropScrpt.fish.toMove));
				epmphjgalbe.DLAIEEJAFDG(ObscuredFloat.GOOIABGKMHK(this.dropScrpt.fish.toSpeed));
			}
			else
			{
				epmphjgalbe.GOMLLPFFPNP(0);
				epmphjgalbe.DLAIEEJAFDG(0f);
				epmphjgalbe.BJANIMFDENK(IIBEEKCAAHK.ECOFBCMPIDO);
				epmphjgalbe.DLAIEEJAFDG(0f);
			}
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06003463 RID: 13411 RVA: 0x0018CB20 File Offset: 0x0018AD20
	// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0018C367 File Offset: 0x0018A567
	public RodParams AOEGNGOGNBI
	{
		get
		{
			return BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI;
		}
		set
		{
			BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI = value;
		}
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x0018CB2C File Offset: 0x0018AD2C
	public bool AEMBDHALFNG()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM;
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x0018CB3D File Offset: 0x0018AD3D
	public bool HNBHANLDOMO()
	{
		return this.AEEPMBEPGIK;
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06003466 RID: 13414 RVA: 0x0018CB45 File Offset: 0x0018AD45
	// (set) Token: 0x0600346D RID: 13421 RVA: 0x0018D13C File Offset: 0x0018B33C
	public Vector3 PAGFNACCBON
	{
		get
		{
			return this.LALPBFALKFL;
		}
		set
		{
			Vector3 lalpbfalkfl = this.LALPBFALKFL;
			this.LALPBFALKFL = value;
			if ((lalpbfalkfl - this.LALPBFALKFL).magnitude > 0.1f)
			{
				this.sendMoveAction();
			}
		}
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x0018CB50 File Offset: 0x0018AD50
	public void OEABGNPEIDH(Transform NCADHGFGICO)
	{
		if (this.AOEGNGOGNBI == null)
		{
			return;
		}
		if (NCADHGFGICO == null)
		{
			this.IJMGCKIOBPP().PGEDLDMLBBE = 980f;
			this.EACGPPOMFLH().target = Vector3.zero;
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.IJMGCKIOBPP() != null)
		{
			ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ);
			this.rodforce = ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMFIFECPGL) / 1555f;
			this.IJMGCKIOBPP().target = NCADHGFGICO.position;
			Vector3 from = this.AOEGNGOGNBI.transform.forward * this.EACGPPOMFLH().actualRodLength;
			Vector3 to = this.AOEGNGOGNBI.CNDKCPLCGAB() - NCADHGFGICO.position;
			float num = Mathf.Abs(Mathf.Sin(Vector3.Angle(from, to) * 1590f / 1844f));
			this.rodforce *= num;
			float num2 = 151f;
			if (this.JIBGPKCOLML() & this.isPodsek)
			{
				num2 = 1721f;
			}
			this.IJMGCKIOBPP().MJLMLHPAOBM(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GIMFIFECPGL) * num2 + LocNewLogic.getI.ICDLJOAIOHG());
		}
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x0018CC9C File Offset: 0x0018AE9C
	public void CDIDCIBEDKP(bool DCCPCBLODIG)
	{
		bool pofondfajlk = this.POFONDFAJLK;
		this.POFONDFAJLK = DCCPCBLODIG;
		if (pofondfajlk != this.POFONDFAJLK)
		{
			if (!this.POFONDFAJLK)
			{
				base.StartCoroutine(this.CMCKAKDADNH());
			}
			this.DIABHIBCKIA();
			if (this.POFONDFAJLK)
			{
				this.toOldLookForward = base.transform.forward;
				this.toOldLookCamFrwd = Camera.main.transform.forward;
				if (this.podsakObject != null)
				{
					this.MDLMIDEFPHI(-1);
				}
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.MEHLPDJPNAD(IIBEEKCAAHK.HLOLNGEKIIH());
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(183, epmphjgalbe.JDPHBLHOLAD());
					goto IL_B8;
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			if (!this.isFishGet)
			{
				this.rotTimeToOldNpr = 836f;
			}
		}
		IL_B8:
		if (!this.POFONDFAJLK)
		{
			this.isPodsek = false;
			this.PodsekType = 0;
			LocNewLogic.getI.stopRollSound();
			if (LocNewLogic.getI != null)
			{
				LocNewLogic.getI.frikcionSound.Stop();
			}
			this.CDNABIHPLHM = false;
			this.blendRodDirection = 150f;
			this.usermode = Fisherman.NHOCKOJNFFJ.Stay;
			return;
		}
		this.usermode = Fisherman.NHOCKOJNFFJ.Fishing;
		GameInterface.getI.endShowFish();
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x0018CDD8 File Offset: 0x0018AFD8
	public void OLKOOBFAPHE(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		this.IEKIGMBAGIL = IEPBGKCHDJO.GIFGIFAHPIA;
		if (this.IEKIGMBAGIL == null)
		{
			return;
		}
		if (this.IJMGCKIOBPP() == null)
		{
			return;
		}
		this.BHMHJBPGOPH = UnityEngine.Object.Instantiate<GameObject>(this.IEKIGMBAGIL, this.AOEGNGOGNBI.reelPoint.transform.position, this.EACGPPOMFLH().reelPoint.transform.rotation);
		this.BHMHJBPGOPH.transform.position = this.AOEGNGOGNBI.reelPoint.transform.position;
		this.BHMHJBPGOPH.transform.parent = this.rodObject.transform;
		this.APJCDDIDKID(this.BHMHJBPGOPH.GetComponent<RollParams>());
		if (this.NKFFPKCLFEI() == null)
		{
			this.NJGBAFIHICN = this.BHMHJBPGOPH.AddComponent<RollParams>();
		}
		this.AOEGNGOGNBI.rollParams = this.NKFFPKCLFEI();
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		if (this.rollPenPointObject != null)
		{
			this.rollPenPointObject.SetActive(true);
		}
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x0018CEF0 File Offset: 0x0018B0F0
	public void MDLMIDEFPHI(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			Debug.Log("");
			Transform transform = this.leftHandPodsakPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4User, transform.position, transform.rotation);
			this.podsakObject.transform.parent = transform;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakObject.transform.localScale = new Vector3(1138f, 7f, 563f);
			this.podsakPoint = JLFJEGIPIMM.PKGMBFEMKGP().FAJIJEIJJJH(this.podsakObject, "Breakdancing");
			this.podsakInWater = false;
		}
		if (CLBPBJGLHEE < 0)
		{
			Debug.Log("Button");
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 225f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = true;
		}
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x0018CFF8 File Offset: 0x0018B1F8
	public void CNGKCDLJEDG(int CMBMMEEBHFA, float GKENCBIOPGO, Vector3 LBGHKIDGKCO)
	{
		if (CMBMMEEBHFA == 0)
		{
			this.action.FIAKMIFCCLG();
		}
		else
		{
			this.action.DLEGNPOODDC(CMBMMEEBHFA, GKENCBIOPGO);
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 0);
			epmphjgalbe.HMHLPBLANND(73);
			epmphjgalbe.FLLJONHPLNA(CMBMMEEBHFA);
			epmphjgalbe.NDHJGGKPLGB(GKENCBIOPGO);
			epmphjgalbe.MEHLPDJPNAD(new IIBEEKCAAHK(LBGHKIDGKCO));
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-68, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x0018D080 File Offset: 0x0018B280
	public void OKDAILHCEOH(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.BEGMLDJEIHB())
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 1168f + base.transform.up * 1726f;
		}
		this.toLookCntrl.LGLMNBGMCCH();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 476f, base.transform.position.y + 1422f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06003518 RID: 13592 RVA: 0x0018E8B2 File Offset: 0x0018CAB2
	// (set) Token: 0x0600346E RID: 13422 RVA: 0x0018D178 File Offset: 0x0018B378
	public bool IBOLGKDFBNL
	{
		get
		{
			return this.MFMJCAJKKJK;
		}
		set
		{
			if (FlyMessageManager.getI.checkFlyIcon(30))
			{
				value = false;
			}
			bool mfmjcajkkjk = this.MFMJCAJKKJK;
			this.MFMJCAJKKJK = value;
			if (this.MFMJCAJKKJK != mfmjcajkkjk)
			{
				this.sendMoveAction();
			}
			if (this.MFMJCAJKKJK)
			{
				this.toLookCntrl.FBFAJEGEIKM();
			}
		}
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x0018D1C8 File Offset: 0x0018B3C8
	public Vector3 MOCNPMIACDL()
	{
		Vector3 position = base.transform.position;
		Vector3 vector = base.transform.position + BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL * 1926f * base.transform.forward;
		position.y = LocNewLogic.getI.OGJHINOLHJJ;
		vector.y = LocNewLogic.getI.HKBNODJBGEL();
		Vector3 b = vector;
		if (this.AOEGNGOGNBI != null)
		{
			Vector3 normalized = (this.EACGPPOMFLH().CNDKCPLCGAB() - this.AOEGNGOGNBI.startPoint.transform.position).normalized;
			b = this.EACGPPOMFLH().CNDKCPLCGAB() + normalized * 1815f;
		}
		b.y = LocNewLogic.getI.CDBIEPGNONF();
		return Vector3.LerpUnclamped(position, b, 1550f);
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06003470 RID: 13424 RVA: 0x0018D2B0 File Offset: 0x0018B4B0
	public float ICFIMJIABFN
	{
		get
		{
			float result = 1.5f * (1f + (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(111) * 2f / 100f);
			if (this.IBOLGKDFBNL)
			{
				result = 3.1f * (1f + (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(112) * 2f / 100f);
			}
			return result;
		}
	}

	// Token: 0x06003471 RID: 13425 RVA: 0x0018D31C File Offset: 0x0018B51C
	private IEnumerator DAENPDFLKLA()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x06003472 RID: 13426 RVA: 0x0018BBAE File Offset: 0x00189DAE
	public bool LPENNEOLCCP()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM;
	}

	// Token: 0x06003473 RID: 13427 RVA: 0x0018D324 File Offset: 0x0018B524
	public void ENPOHHDAIGO()
	{
		LocNewLogic.getI.frikcionSound.Stop();
		LocNewLogic.getI.stopRollSound();
		this.usermode = Fisherman.NHOCKOJNFFJ.Fishing;
		this.isFishGet = false;
		this.isKeyPress = false;
		this.CDIDCIBEDKP(false);
		this.sendGetFishAction();
		if (this.dropScrpt != null && this.dropScrpt.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.dropScrpt.fishPointer);
			this.dropScrpt.fishPointer = null;
		}
	}

	// Token: 0x06003474 RID: 13428 RVA: 0x0018D3AC File Offset: 0x0018B5AC
	public void ELCFBKFCKEH()
	{
		if (this.dropScrpt == null)
		{
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-3, BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
		if (this.dropScrpt != null)
		{
			ActorMgr.getI.MFNKBMBPPBP(this.dropScrpt.fish.transform.position);
			this.dropScrpt.HOIKDKEJJBP();
			this.dropScrpt = null;
		}
		this.CDNABIHPLHM = false;
		this.isPodsek = false;
		this.isFishGet = false;
		this.rotTimeToOldNpr = 131f;
		if (this.podsakObject != null)
		{
			DitherShower component = this.podsakObject.GetComponent<DitherShower>();
			if (component != null)
			{
				component.dirVector = -1;
				component.scaleAlfaKF = 1695f;
			}
		}
	}

	// Token: 0x06003475 RID: 13429 RVA: 0x0018D478 File Offset: 0x0018B678
	public void JCNOKFBLLIE()
	{
		this.NEFHFADILLJ(false);
		this.isBreak = true;
		this.NLLFPLBFFAE();
		this.leftHandCntrl.DGLKJBLMLHF();
		this.rightHandCntrl.FBFAJEGEIKM();
		this.aimCntrl.HLCDBEBAODP();
		this.toLookCntrl.BAOPAIOMEKB();
		if (this.dropScrpt != null)
		{
			this.dropScrpt.kill();
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		if (this.BHMHJBPGOPH != null)
		{
			UnityEngine.Object.Destroy(this.BHMHJBPGOPH);
		}
		if (this.rodObject != null)
		{
			UnityEngine.Object.Destroy(this.rodObject);
		}
		if (this.bubenec != null)
		{
			UnityEngine.Object.Destroy(this.bubenec.gameObject);
		}
		if (this.ragula != null)
		{
			UnityEngine.Object.Destroy(this.ragula.gameObject);
		}
		LocNewLogic.getI.AGDBNHCPFHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
	}

	// Token: 0x06003476 RID: 13430 RVA: 0x0018D56C File Offset: 0x0018B76C
	public void dropPrikormEvnt()
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		Vector3 vector = Vector3.zero;
		if (this.dropScrpt != null)
		{
			vector = this.dropScrpt.transform.position;
			vector.y = LocNewLogic.getI.OGJHINOLHJJ;
		}
		Debug.Log("**********  dropPrikormEvnt");
		DropMass component = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("dropMass").GetComponent<DropMass>();
		if (component != null)
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			float num = BOIKJDICEMF.IKGFHGKKCPG.ADCJDAPEOOH(Vector3.Distance(this.leftHandPointFxd, vector));
			float num2 = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num);
			float f = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(6.2831854820251465);
			vector.x += Mathf.Cos(f) * num2;
			vector.z += Mathf.Sin(f) * num2;
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak.CKBGHMMOAEM == null) ? 0L : bgjkmcbhnak.CKBGHMMOAEM.LPFKFNLHGBI);
				epmphjgalbe.OBCCLNMPGEJ(0L);
				epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(vector));
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1112, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			component.fropPos = this.leftHandPointFxd;
			component.transform.position = component.fropPos;
			component.toPos = vector;
			component.speed = 7f;
			component.dropAction();
		}
	}

	// Token: 0x06003477 RID: 13431 RVA: 0x0018D6F4 File Offset: 0x0018B8F4
	public void MGANDMKLMMM(Vector3 DCCPCBLODIG)
	{
		Vector3 lalpbfalkfl = this.LALPBFALKFL;
		this.LALPBFALKFL = DCCPCBLODIG;
		if ((lalpbfalkfl - this.LALPBFALKFL).magnitude > 673f)
		{
			this.FCMIGOFMGCE();
		}
	}

	// Token: 0x06003478 RID: 13432 RVA: 0x0018D730 File Offset: 0x0018B930
	private void PGBAKHHHFIL(EPMPHJGALBE CPFJMLFLKFI, byte JNFEAFBIMAL)
	{
		CPFJMLFLKFI.OACBICLGENB(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI);
		CPFJMLFLKFI.OJLAPHDEGFH(JNFEAFBIMAL);
		CPFJMLFLKFI.MEHLPDJPNAD(new IIBEEKCAAHK(base.transform.position));
		CPFJMLFLKFI.PAKIPBGFNKN(new IIBEEKCAAHK(base.transform.rotation.eulerAngles));
		CPFJMLFLKFI.CFIKDLDBNHI(this.HNBHANLDOMO() | this.isRodMoveState);
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(this.PAGFNACCBON));
		CPFJMLFLKFI.PBBCKDDLNLE(this.IBOLGKDFBNL);
		CPFJMLFLKFI.LKAAANGOEIJ(this.HFOJKPOICLM());
		CPFJMLFLKFI.LNFLEDCCKKF(this.ADFNLBBFLKK);
		CPFJMLFLKFI.OJLAPHDEGFH(0);
		CPFJMLFLKFI.PPNGIKFFNFP(0);
		CPFJMLFLKFI.OJLAPHDEGFH(1);
	}

	// Token: 0x06003479 RID: 13433 RVA: 0x0018D7EC File Offset: 0x0018B9EC
	public void IDCCDMPHCNI()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 0);
			epmphjgalbe.BLCJKEJDGBI((byte)-99);
			epmphjgalbe.DMKPONFMCGH((byte)this.DropType);
			epmphjgalbe.KPCGLGHDILI(BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
			epmphjgalbe.PBBCKDDLNLE(this.MFENINHGBHM);
			epmphjgalbe.PBBCKDDLNLE(this.GECLKEEGJGA());
			epmphjgalbe.IECHKLACNFM(this.isPodsek & this.LPENNEOLCCP());
			Vector3 bdgecgghecb = base.transform.position + base.transform.forward * 259f;
			if (this.dropScrpt != null)
			{
				bdgecgghecb = this.dropScrpt.toPos;
				if (this.dropScrpt.mode >= 6)
				{
					bdgecgghecb = this.dropScrpt.transform.position;
				}
				if (this.JIBGPKCOLML())
				{
					bdgecgghecb = this.dropScrpt.fish.transform.position;
				}
			}
			epmphjgalbe.LEHGHFJMCPI(new IIBEEKCAAHK(bdgecgghecb));
			epmphjgalbe.KCMKJKENAFA(this.blendRodDirection);
			epmphjgalbe.BCOMDIELFDL(this.rodforce);
			epmphjgalbe.BCOMDIELFDL(this.upRodState);
			epmphjgalbe.APLCAMNONBD(this.ragula != null);
			epmphjgalbe.IEIPGFCMJGE(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.position : Vector3.zero));
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.rotation.eulerAngles : Vector3.zero));
			if (this.AEMBDHALFNG())
			{
				epmphjgalbe.AEMAHNDEBKJ(ObscuredInt.DGOCFCFPKPI(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NENOBDLCFHO));
				epmphjgalbe.NDHJGGKPLGB(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NBLJCEHNKAK));
				epmphjgalbe.HJHOGGPGPEL((this.dropScrpt == null) ? IIBEEKCAAHK.HLOLNGEKIIH() : new IIBEEKCAAHK(this.dropScrpt.fish.toMove));
				epmphjgalbe.KCMKJKENAFA(ObscuredFloat.OBJFODGFMAM(this.dropScrpt.fish.toSpeed));
			}
			else
			{
				epmphjgalbe.AEMAHNDEBKJ(0);
				epmphjgalbe.KCMKJKENAFA(746f);
				epmphjgalbe.MEHLPDJPNAD(IIBEEKCAAHK.HLOLNGEKIIH());
				epmphjgalbe.KCMKJKENAFA(1401f);
			}
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(130, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600347A RID: 13434 RVA: 0x0018DA6C File Offset: 0x0018BC6C
	public void FCMIGOFMGCE()
	{
		if (Time.time - this.BFOIGHICKNN < 904f)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 1);
			byte bjppebpndnj = (byte)-66;
			if (this.MIBOJMFKFGI)
			{
				bjppebpndnj = 108;
			}
			epmphjgalbe.NDNLBOCBCLJ(bjppebpndnj);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-32, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
		this.IFMPADKADHO();
		this.BFOIGHICKNN = Time.time;
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060034F2 RID: 13554 RVA: 0x00195981 File Offset: 0x00193B81
	// (set) Token: 0x0600347B RID: 13435 RVA: 0x0018DAF0 File Offset: 0x0018BCF0
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
			this.DropType = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
			if (hdlhcmopikm != this.HDLHCMOPIKM)
			{
				this.sendFishingAction();
				if (this.HDLHCMOPIKM)
				{
					this.toOldLookForward = base.transform.forward;
					this.toOldLookCamFrwd = Camera.main.transform.forward;
				}
			}
			if (!this.HDLHCMOPIKM)
			{
				GameInterface.getI.endShowFish();
				this.CIHILMCEJND = false;
				this.CDNABIHPLHM = false;
				this.isPodsek = false;
				this.isFishGet = false;
				this.isBigFish = false;
				this.UserLookAtOff();
				this.leftHandCntrl.FBFAJEGEIKM();
				this.rightHandCntrl.FBFAJEGEIKM();
				this.toLookCntrl.FBFAJEGEIKM();
				this.aimCntrl.FBFAJEGEIKM();
				this.PodsekType = 0;
				if (this.dropScrpt != null)
				{
					this.dropScrpt.kill();
					this.dropScrpt = null;
					return;
				}
			}
			else
			{
				this.isBreak = false;
				this.bipIK.enabled = true;
				BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
				if (bgjkmcbhnak != null)
				{
					EKBAPCMPANI ljclffinehj = bgjkmcbhnak.LJCLFFINEHJ;
				}
			}
		}
	}

	// Token: 0x0600347C RID: 13436 RVA: 0x0018DC18 File Offset: 0x0018BE18
	public void sendSpawnAction()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1007, 0);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC(101);
			epmphjgalbe.KJDIGAKNOAI(this.isWoman);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600347D RID: 13437 RVA: 0x0018DC88 File Offset: 0x0018BE88
	public void ONGJOLOBGBK(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		this.IEKIGMBAGIL = IEPBGKCHDJO.NIGADFIHLHM();
		if (this.IEKIGMBAGIL == null)
		{
			return;
		}
		if (this.EACGPPOMFLH() == null)
		{
			return;
		}
		this.BHMHJBPGOPH = UnityEngine.Object.Instantiate<GameObject>(this.IEKIGMBAGIL, this.AOEGNGOGNBI.reelPoint.transform.position, this.IJMGCKIOBPP().reelPoint.transform.rotation);
		this.BHMHJBPGOPH.transform.position = this.AOEGNGOGNBI.reelPoint.transform.position;
		this.BHMHJBPGOPH.transform.parent = this.rodObject.transform;
		this.FECACBJADCD(this.BHMHJBPGOPH.GetComponent<RollParams>());
		if (this.ILAOBMPAEJN() == null)
		{
			this.FCOADHOOLKK(this.BHMHJBPGOPH.AddComponent<RollParams>());
		}
		this.AOEGNGOGNBI.rollParams = this.ILAOBMPAEJN();
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		if (this.rollPenPointObject != null)
		{
			this.rollPenPointObject.SetActive(true);
		}
	}

	// Token: 0x0600347E RID: 13438 RVA: 0x0018DDA0 File Offset: 0x0018BFA0
	private void Start()
	{
		this.standFlag = true;
		this.KANMIKKAPDI = base.transform.forward * 10f;
		if (this.rollPenPointObject != null)
		{
			this.rollPenPointObject.SetActive(false);
		}
		this.grndFBIK = base.GetComponent<GrounderFBBIK>();
		if (this.nameCanvas != null)
		{
			this.nameCanvas.worldCamera = Camera.main;
		}
		this.bipIK = base.GetComponent<FullBodyBipedIK>();
		this.lookIK = base.GetComponent<LookAtIK>();
		this.anm = base.GetComponent<Animator>();
		if (this.anm == null)
		{
			this.anm = base.GetComponentInChildren<Animator>();
		}
		this.FMEPCINEDCP = new GameObject("LookAT Point");
		this.FMEPCINEDCP.transform.position = base.transform.position + Vector3.up * 2f + base.transform.forward * 5f;
		this.toLookPoint = this.FMEPCINEDCP.transform.position;
		if (this.lookIK != null)
		{
			this.lookIK.solver.target = this.FMEPCINEDCP.transform;
		}
		base.StartCoroutine(this.EAIBONCGLFJ());
		base.StartCoroutine(this.OLAINLAJIBE());
		this.cc = base.GetComponent<CharacterController>();
		this.PAGFNACCBON = base.transform.position;
		this.character = base.GetComponent<Character>();
		this.sendSpawnAction();
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 7);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MAFHCKOECAN = ((ekbapcmpani != null) ? ekbapcmpani.HHOLFABGDJA : 0);
		this.character.changeCostume(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MAFHCKOECAN);
		ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 1);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM = ((ekbapcmpani != null) ? ekbapcmpani.HHOLFABGDJA : 0);
		this.character.changeCap(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM);
		this.recalculateWeapons();
		if (this.rightHandPrfb != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.rightHandPrfb);
			List<GameObject> list = MJCPLMMIGHK.DDOGNNEOFIL(gameObject, this.character.rootBone, true);
			if (list.Count > 0)
			{
				foreach (GameObject gameObject2 in list)
				{
					if (!(gameObject2 == null))
					{
						gameObject2.transform.parent = this.rightHandObj.transform;
						SkinnedMeshRenderer component = gameObject2.GetComponent<SkinnedMeshRenderer>();
						if (!(component == null))
						{
							component.rootBone = this.character.rootBone;
							component.updateWhenOffscreen = true;
						}
					}
				}
			}
			UnityEngine.Object.Destroy(gameObject, 0.2f);
		}
	}

	// Token: 0x0600347F RID: 13439 RVA: 0x0018E08C File Offset: 0x0018C28C
	public RollParams ILAOBMPAEJN()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB;
	}

	// Token: 0x06003480 RID: 13440 RVA: 0x0018E098 File Offset: 0x0018C298
	public void EMPDJHKPIFJ()
	{
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-136, 0);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 0);
			epmphjgalbe.BLCJKEJDGBI(56);
			epmphjgalbe.LNFLEDCCKKF(this.isWoman);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(157, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06003481 RID: 13441 RVA: 0x0018E108 File Offset: 0x0018C308
	public void ONDOHGBIDHO(EKBAPCMPANI HHAHKJPGOLK)
	{
		Debug.Log("wpn_rod4");
		if (HHAHKJPGOLK != null)
		{
			Debug.Log("Move around with WASD or cursor keys, space to jump, T to toggle fog on/off." + HHAHKJPGOLK.LPFKFNLHGBI);
			if (HHAHKJPGOLK.LPFKFNLHGBI != this.petWpnId && this.petObject != null)
			{
				UnityEngine.Object.Destroy(this.petObject.gameObject);
			}
			Vector3 vector = base.transform.position;
			vector += base.transform.right * 1358f;
			GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().OMPJLOEGMII("russian", vector, null);
			this.petObject = gameObject.GetComponent<PetPlayer>();
			this.petWpnId = HHAHKJPGOLK.LPFKFNLHGBI;
			return;
		}
		if (this.petObject != null)
		{
			UnityEngine.Object.Destroy(this.petObject.gameObject);
		}
		this.petObject = null;
		this.petWpnId = 1L;
	}

	// Token: 0x06003482 RID: 13442 RVA: 0x0018E1EC File Offset: 0x0018C3EC
	public void CNPLMPJJDEI()
	{
		LocNewLogic.getI.frikcionSound.Stop();
		LocNewLogic.getI.stopRollSound();
		this.usermode = Fisherman.NHOCKOJNFFJ.FishGet;
		this.isFishGet = false;
		this.isKeyPress = false;
		this.CDIDCIBEDKP(false);
		this.sendGetFishAction();
		if (this.dropScrpt != null && this.dropScrpt.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.dropScrpt.fishPointer);
			this.dropScrpt.fishPointer = null;
		}
	}

	// Token: 0x06003483 RID: 13443 RVA: 0x0018E271 File Offset: 0x0018C471
	public void ODEAJONEDGM()
	{
		this.podsakInWater = false;
	}

	// Token: 0x06003484 RID: 13444 RVA: 0x0018E27C File Offset: 0x0018C47C
	public void CMNELOCJPOD(Transform NCADHGFGICO)
	{
		if (this.AOEGNGOGNBI == null)
		{
			return;
		}
		if (NCADHGFGICO == null)
		{
			this.EACGPPOMFLH().PGEDLDMLBBE = 458f;
			this.EACGPPOMFLH().target = Vector3.zero;
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.IJMGCKIOBPP() != null)
		{
			ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ);
			this.rodforce = ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.GIMFIFECPGL) / 794f;
			this.IJMGCKIOBPP().target = NCADHGFGICO.position;
			Vector3 from = this.IJMGCKIOBPP().transform.forward * this.EACGPPOMFLH().actualRodLength;
			Vector3 to = this.AOEGNGOGNBI.ILCJJKCPBKC - NCADHGFGICO.position;
			float num = Mathf.Abs(Mathf.Sin(Vector3.Angle(from, to) * 1063f / 1502f));
			this.rodforce *= num;
			float num2 = 207f;
			if (this.JIBGPKCOLML() & this.isPodsek)
			{
				num2 = 1911f;
			}
			this.EACGPPOMFLH().FDLCJBFDIEM(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GIMFIFECPGL) * num2 + LocNewLogic.getI.HACGLNGIMPG());
		}
	}

	// Token: 0x06003485 RID: 13445 RVA: 0x0018E3C8 File Offset: 0x0018C5C8
	public void JONIILIECGN(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.HKPAEGGJNGG)
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 1957f + base.transform.up * 162f;
		}
		this.toLookCntrl.KDCOOGIPHBL();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 314f, base.transform.position.y + 1724f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x06003486 RID: 13446 RVA: 0x0018E484 File Offset: 0x0018C684
	public void MIPMNJNPJFG(HBPNMNGOFMA KADBECGIMPD)
	{
		if (!this.KNMMOLKNLNL())
		{
			return;
		}
		KADBECGIMPD.DOJKJHMJJNK();
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak != null)
		{
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.AJMPAOCEPCA((float)KADBECGIMPD.KDNDJNEGBDI());
			bgjkmcbhnak.CFOFDKKFJMJ = KADBECGIMPD.DPLAJNEDGBL();
			bgjkmcbhnak.FLHJLFHELPE = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.ECJLJGDNFMN());
			bgjkmcbhnak.JDIBHEGKALB = ObscuredFloat.HLEMAJBAAEO(KADBECGIMPD.DNGDPHIHLBG());
			bgjkmcbhnak.EFLIAAIOPPI = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.CGJIINADKNH());
			float num = KADBECGIMPD.CGJIINADKNH();
			num *= OLPINJLCKCI.BMALMDIBLDP().BHCCMPBCHEF(290f);
			bgjkmcbhnak.PGEDLDMLBBE = ObscuredFloat.AJMPAOCEPCA(num);
			bgjkmcbhnak.HFPNHGGIKHP = ObscuredFloat.AJMPAOCEPCA(KADBECGIMPD.MOBPFEEAMKD());
			bgjkmcbhnak.NENOBDLCFHO = ObscuredInt.JNKANIEBCMD(KADBECGIMPD.HDBGOLAFOBK());
			bgjkmcbhnak.NBLJCEHNKAK = ObscuredFloat.HLEMAJBAAEO(KADBECGIMPD.MOBPFEEAMKD());
			bgjkmcbhnak.HPMPDNLHCKM = KADBECGIMPD.HFOPFEJDJFG();
			bgjkmcbhnak.BCKECOENDLB = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(bgjkmcbhnak.HPMPDNLHCKM);
			bgjkmcbhnak.PLIPAKGHPBE = bgjkmcbhnak.EFLIAAIOPPI;
			float lknfodkoped = 1342f;
			if (bgjkmcbhnak.BCKECOENDLB != null)
			{
				IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.PKGMBFEMKGP().JFPAICGJAAJ(bgjkmcbhnak.BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
				if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) < iibeekcaahk.JLLJFKOGLHJ)
				{
					lknfodkoped = (iibeekcaahk.EIHMJDCOOCC() - ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKHBAJKMAGD)) * (937f + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.FLHJLFHELPE) / 119f) / (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) + 1670f) * 1201f;
				}
			}
			bool flag = OLPINJLCKCI.IFLFANPMLMM().KLJKPEMPHEM(lknfodkoped);
			if (flag)
			{
				Debug.Log("CrouchStrafeLeft");
			}
			switch (bgjkmcbhnak.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (bgjkmcbhnak.PFNCHEEEBKD != null)
				{
					if (!flag)
					{
						if (bgjkmcbhnak.PFNCHEEEBKD.BBLEPPMMPIL("LocationGui.getI.backLockImage is null", "MotorbikeShootFwd").KGFNAIIPHKL() && this.KNMMOLKNLNL())
						{
							base.StartCoroutine(this.HHHANGAKMLD());
						}
					}
					else if (this.dropScrpt != null)
					{
						this.dropScrpt.poplavokDown(544f);
					}
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				flag = true;
				this.dropScrpt.NKGMDLPIFIA();
				if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) > 788f)
				{
					bgjkmcbhnak.OCFHDKPNJDA(ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.OGLIEFLNLLE), 436f, 1838f)));
					bgjkmcbhnak.LCKEJCDPBIO(ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.MPKJDFOMBLI()), 302f, 1079f)));
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.HLEMAJBAAEO(1117f * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.EIHMJDCOOCC() * 743f));
					bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(1299f * ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.PHLLHDNNOMB() * 676f));
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				float num2 = 1080f * (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.CLAEAFMCDMP() + bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.PHLLHDNNOMB()) / 320f;
				if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) > 260f)
				{
					bgjkmcbhnak.AAINFMALAEN(ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) / (num2 + 988f)));
					bgjkmcbhnak.EALPPCJHPKG = bgjkmcbhnak.GIMGAKKKHLF;
					if (this.dropScrpt != null)
					{
						this.dropScrpt.MDAENCJKIBI(1, 31f, !flag);
						FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN(" ", BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB(), 1906f, 657f, 1439f);
					}
				}
				break;
			}
			}
			if (this.dropScrpt != null && !flag)
			{
				this.dropScrpt.klevActivate();
			}
		}
	}

	// Token: 0x06003487 RID: 13447 RVA: 0x0018E873 File Offset: 0x0018CA73
	public bool GECLKEEGJGA()
	{
		return this.POFONDFAJLK;
	}

	// Token: 0x06003488 RID: 13448 RVA: 0x0018E87B File Offset: 0x0018CA7B
	public void recalculateWeapons()
	{
		this.isSitEnable = false;
		if (MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 10) != null)
		{
			this.isSitEnable = true;
		}
		if (!this.isSitEnable && this.CMCPFNJIIHK)
		{
			this.CMCPFNJIIHK = false;
		}
	}

	// Token: 0x06003489 RID: 13449 RVA: 0x0018E8B2 File Offset: 0x0018CAB2
	public bool DJALOEEDPNA()
	{
		return this.MFMJCAJKKJK;
	}

	// Token: 0x0600348A RID: 13450 RVA: 0x0018E8BC File Offset: 0x0018CABC
	private void IKFAJMDKABN(EPMPHJGALBE CPFJMLFLKFI, byte JNFEAFBIMAL)
	{
		CPFJMLFLKFI.MFPECHIKBCO(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI);
		CPFJMLFLKFI.DILDCOFOGHJ(JNFEAFBIMAL);
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(base.transform.position));
		CPFJMLFLKFI.PAKIPBGFNKN(new IIBEEKCAAHK(base.transform.rotation.eulerAngles));
		CPFJMLFLKFI.LNFLEDCCKKF(this.MIBOJMFKFGI | this.isRodMoveState);
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(this.EGHPOBMBIBC()));
		CPFJMLFLKFI.APLCAMNONBD(this.DJALOEEDPNA());
		CPFJMLFLKFI.DLAIEEJAFDG(this.ICFIMJIABFN);
		CPFJMLFLKFI.KJDIGAKNOAI(this.ADFNLBBFLKK);
		CPFJMLFLKFI.HMHLPBLANND(0);
		CPFJMLFLKFI.DLPJFOPBFHN(1);
		CPFJMLFLKFI.DMKPONFMCGH(1);
	}

	// Token: 0x0600348B RID: 13451 RVA: 0x0018E978 File Offset: 0x0018CB78
	public float HFOJKPOICLM()
	{
		float result = 1260f * (1600f + (float)JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FOACIAGMAPD(100) * 587f / 1638f);
		if (this.IBOLGKDFBNL)
		{
			result = 679f * (327f + (float)JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FOACIAGMAPD(-75) * 1282f / 1290f);
		}
		return result;
	}

	// Token: 0x0600348C RID: 13452 RVA: 0x0018E9E4 File Offset: 0x0018CBE4
	private void NKPIFBHMHEL()
	{
		if (LocNewLogic.getI != null && !LocNewLogic.getI.isMovingEnable)
		{
			this.MIBOJMFKFGI = false;
			this.PAGFNACCBON = base.transform.position;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.CIHILMCEJND)
		{
			this.rotateToNpr(Camera.main.transform.forward);
		}
		bool isMoveState = this.MIBOJMFKFGI;
		bool flag = this.MIBOJMFKFGI;
		bool isRunState = Input.GetKey(KeyCode.LeftShift) || Input.GetMouseButton(3);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PMOJDCHIAHE < 5f)
		{
			isRunState = false;
		}
		this.IBOLGKDFBNL = isRunState;
		if (this.MFENINHGBHM)
		{
			this.IBOLGKDFBNL = false;
		}
		if (this.CIHILMCEJND)
		{
			this.MIBOJMFKFGI = false;
			this.PAGFNACCBON = base.transform.position;
			return;
		}
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && Input.GetMouseButton(0) && EventSystem.current != null && !EventSystem.current.IsPointerOverGameObject() && Time.time - this.LDAJPLCGEHC > 0.5f)
		{
			this.LDAJPLCGEHC = Time.time;
			Vector2 v = Input.mousePosition;
			if (!HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
			{
				v = new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 100f, this.clickLayerCollision))
			{
				this.toAObject = raycastHit.collider.gameObject.GetComponent<ActiveObject>();
				if (this.toAObject != null)
				{
					if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
					{
						Collider component = this.toAObject.GetComponent<Collider>();
						if (component != null)
						{
							Vector3 vector = component.ClosestPoint(base.transform.position);
							this.PAGFNACCBON = new Vector3(vector.x, base.transform.position.y, vector.z);
						}
						else
						{
							this.PAGFNACCBON = new Vector3(raycastHit.point.x, base.transform.position.y, raycastHit.point.z);
						}
					}
					else
					{
						this.MIBOJMFKFGI = false;
					}
				}
				else if (!this.MFENINHGBHM)
				{
					this.PAGFNACCBON = new Vector3(raycastHit.point.x, base.transform.position.y, raycastHit.point.z);
				}
			}
		}
		Vector3 toMovePoint = this.PAGFNACCBON;
		toMovePoint.y = base.transform.position.y;
		float num = Vector3.Distance(toMovePoint, base.transform.position);
		flag = (num >= 0.2f);
		if (this.CMCPFNJIIHK)
		{
			flag = false;
		}
		if (this.fchair != null)
		{
			flag = false;
		}
		if (toMovePoint.magnitude > 0.1f && Vector3.Distance(toMovePoint, base.transform.position) > 0.1f)
		{
			Vector3 toMovePoint2 = this.PAGFNACCBON;
			toMovePoint2.y = base.transform.position.y;
			Quaternion b = Quaternion.LookRotation(toMovePoint2 - base.transform.position);
			if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 10f);
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
			}
		}
		else
		{
			this.PAGFNACCBON = base.transform.position;
		}
		if (this.IHCKLDNAPDF && this.selectedMIO != null)
		{
			Vector3 position = this.selectedMIO.transform.position;
			position.y = base.transform.position.y;
			Quaternion b2 = Quaternion.LookRotation(position - base.transform.position);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime * 10f);
		}
		if (num <= 0.2f)
		{
			flag = false;
			this.PAGFNACCBON = base.transform.position;
		}
		if (this.toAObject != null)
		{
			Vector3 b3 = this.toAObject.transform.position;
			Collider component2 = this.toAObject.GetComponent<Collider>();
			if (component2 != null)
			{
				b3 = component2.ClosestPoint(base.transform.position);
			}
			b3.y = base.transform.position.y;
			if (Vector3.Distance(base.transform.position, b3) < this.toAObject.dsta)
			{
				flag = false;
				this.PAGFNACCBON = base.transform.position;
				Vector3 position2 = this.toAObject.transform.position;
				position2.y = base.transform.position.y;
				Quaternion rotation = Quaternion.LookRotation(position2 - base.transform.position);
				if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
				{
					base.transform.rotation = rotation;
				}
				else if (!LocNewLogic.getI.mouseLook.enabled && !this.CMCPFNJIIHK)
				{
					base.transform.rotation = rotation;
				}
				MMOItemObject component3 = this.toAObject.gameObject.GetComponent<MMOItemObject>();
				if (component3 != null)
				{
					Debug.Log("**MMOItem");
					this.selectedMIO = component3;
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1500, component3.pointId);
				}
				else
				{
					this.toAObject.processAction();
				}
				Debug.Log("Active Process " + this.toAObject.iName);
				this.toAObject = null;
			}
		}
		if (flag)
		{
			Vector3 vector2 = base.transform.forward;
			Ray ray = new Ray(base.transform.position + Vector3.up, vector2 + Vector3.down * 2f);
			Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 5f);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray, out raycastHit2, 5f, this.clickLayerCollision))
			{
				if (raycastHit2.collider.gameObject.tag == "Water")
				{
					flag = false;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit2.point.y) > 1.5f)
				{
					flag = false;
				}
			}
			if (flag)
			{
				vector2 = this.PAGFNACCBON - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(0f, 0.5f, 0f), vector2);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 0.7f);
				if (Physics.Raycast(ray2, out raycastHit2, 0.7f, this.moveLayerCollision))
				{
					flag = false;
				}
			}
			if (flag && !HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				this.cc.Move(base.transform.TransformDirection(Vector3.forward) * this.ICFIMJIABFN * Time.deltaTime);
			}
		}
		this.MIBOJMFKFGI = flag;
		if (Time.time - this.BFOIGHICKNN > 1f)
		{
			this.BFOIGHICKNN = Time.time;
			this.sendMoveAction();
		}
		bool isMoveState2 = this.MIBOJMFKFGI;
	}

	// Token: 0x0600348D RID: 13453 RVA: 0x0018F178 File Offset: 0x0018D378
	public void KOPJONLKEJB()
	{
		string text = JNBICAJIJMM.DIOJFJMOPJO("Unarmed");
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(text);
		FlyMessageManager.getI.SendMessage(text, Color.red);
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI(" ", 455f);
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Flares", 332f);
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		base.StartCoroutine(this.HBOCPMFNDGD());
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x0018F1F0 File Offset: 0x0018D3F0
	public void AFLBAGIJLFH(int CMBMMEEBHFA, float GKENCBIOPGO, Vector3 LBGHKIDGKCO)
	{
		if (CMBMMEEBHFA == 0)
		{
			this.action.DGLKJBLMLHF();
		}
		else
		{
			this.action.AKAECHLONDL(CMBMMEEBHFA, GKENCBIOPGO);
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC(26);
			epmphjgalbe.PDEFLCIEMFF(CMBMMEEBHFA);
			epmphjgalbe.HLHFALIIDHA(GKENCBIOPGO);
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(LBGHKIDGKCO));
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(93, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600348F RID: 13455 RVA: 0x0018F278 File Offset: 0x0018D478
	public void UserLookAtOn(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.HKPAEGGJNGG)
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 3f + base.transform.up * 1.5f;
		}
		this.toLookCntrl.FPIDHIOGEAM();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 0.5f, base.transform.position.y + 2.5f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x0018F334 File Offset: 0x0018D534
	private void BAIKCLKJPAA()
	{
		if (this.generator != null)
		{
			this.generator.isWork = this.MFENINHGBHM;
		}
		if (this.rotTimeToOldNpr > 1320f)
		{
			Quaternion a = Quaternion.LookRotation(this.toOldLookForward);
			base.transform.rotation = Quaternion.Lerp(a, base.transform.rotation, this.rotTimeToOldNpr);
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				a = Quaternion.LookRotation(this.toOldLookCamFrwd);
				Camera.main.transform.rotation = Quaternion.Lerp(a, Camera.main.transform.rotation, this.rotTimeToOldNpr);
			}
		}
		this.rotTimeToOldNpr -= Time.deltaTime;
		this.rightHandObj.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
		this.bipIK.solver.iterations = (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC ? 1 : 94);
		bool afeckmfdaea = this.getBragCntrl.AFECKMFDAEA;
		if (this.EACGPPOMFLH() != null && this.ragula != null)
		{
			this.EACGPPOMFLH().EIANPDPMNKJ(Mathf.Clamp(this.AOEGNGOGNBI.CBKKMCMCAFN(), 1615f, 1795f));
			this.forceControl((this.dropScrpt == null) ? null : this.dropScrpt.transform);
		}
		if (this.isRodMoveState)
		{
			this.moveCntrl.NAPOILNNPOJ(true);
		}
		else
		{
			this.moveCntrl.CIIHLINGEGP();
		}
		if (this.wCircler != null)
		{
			if (LocNewLogic.getI != null)
			{
				this.wCircler.SetActive(false);
				Vector3 position = this.wCircler.transform.position;
				position.y = LocNewLogic.getI.OGJHINOLHJJ + 921f;
				this.wCircler.transform.position = position;
			}
			else
			{
				this.wCircler.SetActive(false);
			}
		}
		this.fonar.gameObject.SetActive(this.EPMDDMKLDGC);
		if (this.MFENINHGBHM)
		{
			this.CMNELOCJPOD((this.dropScrpt != null) ? this.dropScrpt.transform : null);
		}
		if (!ChatPanelLogic.getI.isChatEnter())
		{
			if (Input.GetKeyDown((KeyCode)24))
			{
				this.EPMDDMKLDGC = !this.EPMDDMKLDGC;
				FBFJFAKAGJG.IKGFHGKKCPG.JHJHHBLGMPJ(LocNewLogic.getI.fonaricOnClip, base.transform.position + Vector3.up, 1186f, 861f, 1354f, 118f);
			}
			if (Input.GetKeyDown((KeyCode)(-128)))
			{
				BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
				if (bgjkmcbhnak != null && bgjkmcbhnak.CKBGHMMOAEM != null)
				{
					this.JOBKCNGCBAN.IBKPMMGIIHB();
				}
			}
		}
		if (Application.isEditor)
		{
			Input.GetKeyDown((KeyCode)143);
		}
		if (this.nameCanvas != null)
		{
			this.nameCanvas.transform.LookAt(Camera.main.transform);
			this.nameCanvas.transform.Rotate(140f, 74f, 828f);
		}
		this.MJDPMBFEFPA();
		this.rightVectorMove = Vector3.zero;
		this.frwrdVectorMove = Vector3.zero;
		if (this.isBreak || !this.MFENINHGBHM)
		{
			if (this.toAObject == null)
			{
				this.leftHandCntrl.EDNJADECBOE();
				this.rightHandCntrl.COLDOMMLODD();
				this.aimCntrl.EHMIJPJFJLO();
			}
			this.isKeyPress = true;
		}
		if (!this.CIHILMCEJND && this.toAObject == null)
		{
			this.leftHandCntrl.HLCDBEBAODP();
			this.rightHandCntrl.BAOPAIOMEKB();
			this.aimCntrl.BBDBAFHBDCJ();
		}
		if (this.LPENNEOLCCP())
		{
			if (Time.time - this.BFOIGHICKNN > 573f)
			{
				this.BFOIGHICKNN = Time.time;
				this.DIABHIBCKIA();
			}
		}
		else if (this.MFENINHGBHM && Time.time - this.BFOIGHICKNN > 1939f)
		{
			this.BFOIGHICKNN = Time.time;
			this.DIABHIBCKIA();
		}
		this.isRodMoveState = true;
		if (!this.CIHILMCEJND && this.standFlag && !this.isFishGet && !ChatPanelLogic.getI.DJEPDONBBIM())
		{
			bool flag = false;
			Vector3 vector = base.transform.position - Camera.main.transform.position;
			Vector3 a2 = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			vector.y = 224f;
			vector.Normalize();
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				vector = Camera.main.transform.forward;
				vector.y = 845f;
				vector.Normalize();
			}
			bool flag2 = true;
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				if (!this.OHKDFALEMNL())
				{
					if (Input.GetKey((KeyCode)180) || Input.GetKey((KeyCode)89))
					{
						this.rightVectorMove = -base.transform.right;
					}
					if (Input.GetKey((KeyCode)(-194)) || Input.GetKey((KeyCode)(-92)))
					{
						this.rightVectorMove = base.transform.right;
					}
					if (Input.GetKey(KeyCode.U) || Input.GetKey((KeyCode)(-27)))
					{
						this.frwrdVectorMove = base.transform.forward;
					}
					if (Input.GetMouseButton(1) && Input.GetMouseButton(1))
					{
						this.frwrdVectorMove = base.transform.forward;
					}
					if (Input.GetKey(KeyCode.Period) || Input.GetKey((KeyCode)(-22)))
					{
						this.frwrdVectorMove = -base.transform.forward;
					}
					Vector3 vector3 = base.transform.position + (this.rightVectorMove + this.frwrdVectorMove).normalized * 1305f;
					if ((vector3 - base.transform.position).magnitude > 262f)
					{
						vector = this.frwrdVectorMove + this.rightVectorMove;
						if (this.CGAMHMNLHCL(vector))
						{
							this.APNAPCPDCFP(Camera.main.transform.forward);
							this.LALPBFALKFL = vector3;
							this.cc.Move(vector.normalized * this.HFOJKPOICLM() * Time.deltaTime);
							this.AEEPMBEPGIK = true;
							this.DOOBKPGJNEN(false);
							if (this.MFENINHGBHM)
							{
								this.isRodMoveState = true;
							}
						}
						else
						{
							this.AEEPMBEPGIK = false;
						}
						if (Time.time - this.BFOIGHICKNN > 507f)
						{
							this.LALPBFALKFL = vector3;
							this.sendMoveAction();
							this.LALPBFALKFL = base.transform.position;
						}
						flag = false;
					}
					else
					{
						this.AEEPMBEPGIK = false;
					}
				}
			}
			else
			{
				if (this.MFENINHGBHM)
				{
					if (!this.CMCPFNJIIHK)
					{
						if (this.CIHILMCEJND)
						{
							if (Input.GetKey((KeyCode)4) || Input.GetKey((KeyCode)(-27)))
							{
								base.transform.Rotate(589f, 1898f * Time.deltaTime, 924f);
							}
							if (Input.GetKey((KeyCode)(-96)) || Input.GetKey((KeyCode)28))
							{
								base.transform.Rotate(105f, 747f * Time.deltaTime, 1795f);
							}
						}
						else
						{
							if (Input.GetKey((KeyCode)154) || Input.GetKey((KeyCode)31))
							{
								base.transform.Rotate(1571f, 884f * Time.deltaTime * 501f, 1016f);
							}
							if (Input.GetKey(KeyCode.Backspace) || Input.GetKey((KeyCode)20))
							{
								base.transform.Rotate(595f, 1600f * Time.deltaTime * 71f, 1788f);
							}
						}
					}
				}
				else
				{
					if (Input.GetKey((KeyCode)(-130)) || Input.GetKey((KeyCode)(-30)))
					{
						a2 += new Vector3(-vector.z, vector.y, vector.x);
					}
					if (Input.GetKey((KeyCode)(-23)) || Input.GetKey((KeyCode)(-22)))
					{
						a2 += new Vector3(vector.z, vector.y, -vector.x);
					}
				}
				if (Input.GetKey((KeyCode)162) || Input.GetKey((KeyCode)(-18)))
				{
					vector2 += vector;
				}
				if (Input.GetKey(KeyCode.Caret) || Input.GetKey((KeyCode)(-37)))
				{
					vector2 -= vector;
				}
				if (this.KPIPJGKANCD())
				{
					vector2 = Vector3.zero;
					a2 = Vector3.zero;
				}
				Vector3 vector4 = base.transform.position + (a2 + vector2).normalized * 960f;
				if ((vector4 - base.transform.position).magnitude > 1331f)
				{
					this.LALPBFALKFL = vector4;
					if (Time.time - this.BFOIGHICKNN > 1615f)
					{
						this.KNMCGDPNEME();
					}
					if (this.MFENINHGBHM)
					{
						this.isRodMoveState = true;
					}
					flag = true;
				}
			}
			if ((((!flag2 && !Input.GetKeyUp((KeyCode)(-48)) && !Input.GetKeyUp((KeyCode)159) && Input.GetKeyUp(KeyCode.A)) || !Input.GetKeyUp((KeyCode)(-41))) && !Input.GetKeyUp((KeyCode)193) && !Input.GetKeyUp(KeyCode.U) && !Input.GetKeyUp(KeyCode.Alpha0) && Input.GetKeyUp((KeyCode)(-2))) & flag)
			{
				this.MIBOJMFKFGI = true;
				this.MGANDMKLMMM(base.transform.position);
			}
		}
		if (this.CIHILMCEJND && HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI)
		{
			Quaternion rotation = base.transform.rotation;
			Vector3 from = base.transform.forward;
			if (this.dropScrpt != null)
			{
				Vector3 position2 = this.dropScrpt.transform.position;
				position2.y = base.transform.position.y;
				from = position2 - base.transform.position;
			}
			if (!ChatPanelLogic.getI.DGGGOGNMEJL() && !this.CMCPFNJIIHK)
			{
				if (Input.GetKey((KeyCode)30) || Input.GetKey((KeyCode)(-109)))
				{
					base.transform.Rotate(1235f, 441f * Time.deltaTime, 1818f);
				}
				if (Vector3.Angle(from, base.transform.forward) > 1011f)
				{
					base.transform.rotation = rotation;
				}
				rotation = base.transform.rotation;
				if (Input.GetKey((KeyCode)(-183)) || Input.GetKey((KeyCode)(-38)))
				{
					base.transform.Rotate(363f, 631f * Time.deltaTime, 30f);
				}
				if (Vector3.Angle(from, base.transform.forward) > 835f)
				{
					base.transform.rotation = rotation;
				}
			}
			if (BOIKJDICEMF.IKGFHGKKCPG != null && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && LocNewLogic.getI.checkKeyRod() && this.dropScrpt != null)
			{
				int mode = this.dropScrpt.mode;
			}
		}
		this.toLookCntrl.IDMCOLDDNCF();
		this.leftHandCntrl.KJJBBLDJHPD();
		this.rightHandCntrl.HMLNMHOMMNO();
		this.aimCntrl.EDANNBFJHIK();
		this.sitCntrl.IOOMOHGIHEL(this.anm);
		this.moveCntrl.BPJNAEMLBLF(this.anm);
		this.getBragCntrl.AEKCPGHEBDD(this.anm);
		this.JOBKCNGCBAN.EDFNEALNMAJ(this.anm);
		this.action.PJMCNDGLNCJ(this.anm);
		if (this.GECLKEEGJGA())
		{
			float num = 1572f;
			bool flag3 = true;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (this.dropScrpt)
			{
				if (this.dropScrpt.transform.position.y > num + 1741f)
				{
					flag3 = true;
				}
			}
			else
			{
				flag3 = true;
			}
			switch (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ())
			{
			case 0:
				if (this.AEMBDHALFNG())
				{
					if (!this.DJPEBFMNLIC)
					{
						flag3 = false;
					}
				}
				else
				{
					flag3 = false;
				}
				if (this.isFishGet)
				{
					flag3 = true;
				}
				break;
			case 1:
				flag3 = true;
				if (this.isFishGet)
				{
					flag3 = false;
				}
				break;
			case 2:
				if (!this.LPENNEOLCCP())
				{
					flag3 = false;
				}
				if (this.isFishGet)
				{
					flag3 = true;
				}
				if (this.ragula)
				{
					flag3 = true;
				}
				break;
			}
			if (flag3)
			{
				this.leftHandCntrl.MKHDIHFCOBI();
			}
			else
			{
				this.leftHandCntrl.IHIFALBJLAK();
			}
		}
		else
		{
			this.leftHandCntrl.MGLPLMKMPCK();
		}
		bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		this.PJIGPFAPIKD();
		if (this.bipIK != null && this.toAObject != null)
		{
			this.bipIK.solver.MJOPIBNHGIK().target = this.toAObject.transform;
		}
		if (this.aimIK != null)
		{
			this.aimIK.solver.IKPositionWeight = this.aimCntrl.NKHBAJKMAGD;
		}
		if (!this.useAIM)
		{
			this.aimIK.solver.IKPositionWeight = 1100f;
		}
		if (this.lookIK != null)
		{
			this.lookIK.solver.IKPositionWeight = this.toLookCntrl.NKHBAJKMAGD;
			if (!this.toLookCntrl.HKPAEGGJNGG && this.toLookCntrl.NKHBAJKMAGD <= 434f)
			{
				this.FMEPCINEDCP.transform.position = this.LFCLAFABKKE();
				this.toLookPoint = this.LFCLAFABKKE();
			}
			if (this.bragfish != null)
			{
				this.toLookPoint = this.bragfish.transform.position;
			}
			this.FMEPCINEDCP.transform.position = Vector3.Lerp(this.FMEPCINEDCP.transform.position, this.toLookPoint, Time.deltaTime);
		}
		if (this.anm != null)
		{
			this.anm.SetBool("; ", this.PBOOMCDCLNG());
			this.anm.SetBool("IdleStun", this.isWoman);
			this.anm.SetBool("no assemblies", this.isBigFish);
			this.anm.SetBool("", this.MFENINHGBHM);
			this.anm.SetBool("---", this.CIHILMCEJND);
			this.anm.SetInteger("RollerBladeCrossoverLeft", this.DropType);
			this.anm.SetInteger("_HueShift", JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GMLFCKNNOPJ());
			this.anm.SetInteger("Sunshine Lightmap", this.PodsekType);
			this.anm.SetBool("RollerBladeGrindRoyale", this.LPENNEOLCCP());
			this.anm.SetBool("ambientVolume", this.isKeyPress);
			this.anm.SetBool("\n<color='#{0}'>{1}</color> ", this.isFishGet);
			this.anm.SetBool("auk_pstinf", this.isBreak);
			this.anm.SetBool(" remnabor=", this.HNBHANLDOMO() | this.isRodMoveState);
			this.anm.SetFloat("UnityEngine.Color", this.blendRodDirection);
			this.anm.SetBool("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!", this.DJALOEEDPNA());
			this.anm.SetFloat("", this.upRodState);
			this.anm.SetBool("", HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
		}
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x001902E0 File Offset: 0x0018E4E0
	public void sendGetFishAction()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC(110);
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(this.dropScrpt.fish.transform.position));
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(this.dropScrpt.fish.transform.rotation.eulerAngles));
			epmphjgalbe.GOMLLPFFPNP(ObscuredInt.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NENOBDLCFHO));
			epmphjgalbe.DLAIEEJAFDG(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
			epmphjgalbe.DLAIEEJAFDG(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06003492 RID: 13458 RVA: 0x001903C8 File Offset: 0x0018E5C8
	public bool OHKDFALEMNL()
	{
		return this.ADFNLBBFLKK;
	}

	// Token: 0x06003493 RID: 13459 RVA: 0x001903D0 File Offset: 0x0018E5D0
	public void DIABHIBCKIA()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 0);
			epmphjgalbe.DADJIBEOMAF((byte)-84);
			epmphjgalbe.PPNGIKFFNFP((byte)this.DropType);
			epmphjgalbe.AEMAHNDEBKJ(BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
			epmphjgalbe.PJIABBIPPNH(this.MFENINHGBHM);
			epmphjgalbe.APLCAMNONBD(this.GECLKEEGJGA());
			epmphjgalbe.PBBCKDDLNLE(this.isPodsek & this.CDNABIHPLHM);
			Vector3 bdgecgghecb = base.transform.position + base.transform.forward * 624f;
			if (this.dropScrpt != null)
			{
				bdgecgghecb = this.dropScrpt.toPos;
				if (this.dropScrpt.mode >= 0)
				{
					bdgecgghecb = this.dropScrpt.transform.position;
				}
				if (this.AEMBDHALFNG())
				{
					bdgecgghecb = this.dropScrpt.fish.transform.position;
				}
			}
			epmphjgalbe.MEHLPDJPNAD(new IIBEEKCAAHK(bdgecgghecb));
			epmphjgalbe.BCOMDIELFDL(this.blendRodDirection);
			epmphjgalbe.KCMKJKENAFA(this.rodforce);
			epmphjgalbe.DLAIEEJAFDG(this.upRodState);
			epmphjgalbe.PJIABBIPPNH(this.ragula != null);
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.position : Vector3.zero));
			epmphjgalbe.EAGCEBABJBO(new IIBEEKCAAHK((this.ragula != null) ? this.ragula.transform.rotation.eulerAngles : Vector3.zero));
			if (this.AEMBDHALFNG())
			{
				epmphjgalbe.EIMEKHOFIEA(ObscuredInt.DGOCFCFPKPI(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NENOBDLCFHO));
				epmphjgalbe.LKAAANGOEIJ(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
				epmphjgalbe.BJANIMFDENK((this.dropScrpt == null) ? IIBEEKCAAHK.HLOLNGEKIIH() : new IIBEEKCAAHK(this.dropScrpt.fish.toMove));
				epmphjgalbe.KHMBNICGPKC(ObscuredFloat.PFCANBAOMCB(this.dropScrpt.fish.toSpeed));
			}
			else
			{
				epmphjgalbe.PDEFLCIEMFF(0);
				epmphjgalbe.BCOMDIELFDL(1355f);
				epmphjgalbe.JGINHHABOGM(IIBEEKCAAHK.ECOFBCMPIDO);
				epmphjgalbe.KHMBNICGPKC(1747f);
			}
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(34, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06003494 RID: 13460 RVA: 0x00190650 File Offset: 0x0018E850
	public void HIEKCPABOMG(int LBCGACKJCJB, string EDAPHMJENPK)
	{
		if (this.msgCloud == null)
		{
			return;
		}
		this.msgCloud.LLJNLBAHJOI(EDAPHMJENPK, LBCGACKJCJB, 971f);
	}

	// Token: 0x06003495 RID: 13461 RVA: 0x00190674 File Offset: 0x0018E874
	public void JFFOFGNIEEP(HBPNMNGOFMA KADBECGIMPD)
	{
		if (!this.CIHILMCEJND)
		{
			return;
		}
		KADBECGIMPD.CLPEKGGAMAI();
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak != null)
		{
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.GOOIABGKMHK((float)KADBECGIMPD.DOJKJHMJJNK());
			bgjkmcbhnak.CFOFDKKFJMJ = KADBECGIMPD.LPKJHMGLCKA();
			bgjkmcbhnak.FLHJLFHELPE = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.AIDAGFNHNHE());
			bgjkmcbhnak.JDIBHEGKALB = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.DNGDPHIHLBG());
			bgjkmcbhnak.EFLIAAIOPPI = ObscuredFloat.AJMPAOCEPCA(KADBECGIMPD.AILCEJFAMGN());
			float num = KADBECGIMPD.AILCEJFAMGN();
			num *= OLPINJLCKCI.NLOGJHEFMHM().CEPHJCEPHIJ(68f);
			bgjkmcbhnak.PGEDLDMLBBE = ObscuredFloat.GOOIABGKMHK(num);
			bgjkmcbhnak.HFPNHGGIKHP = ObscuredFloat.HLEMAJBAAEO(KADBECGIMPD.BNDHIBEOKML());
			bgjkmcbhnak.NENOBDLCFHO = ObscuredInt.KHJPCCFDJPA(KADBECGIMPD.IFDFHJLCHAE());
			bgjkmcbhnak.NBLJCEHNKAK = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.ECJLJGDNFMN());
			bgjkmcbhnak.HPMPDNLHCKM = KADBECGIMPD.ANPEIKGEDHJ();
			bgjkmcbhnak.BCKECOENDLB = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BGPCJLDDCDN(bgjkmcbhnak.HPMPDNLHCKM);
			bgjkmcbhnak.PLIPAKGHPBE = bgjkmcbhnak.EFLIAAIOPPI;
			float lknfodkoped = 851f;
			if (bgjkmcbhnak.BCKECOENDLB != null)
			{
				IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.PKGMBFEMKGP().PCOELKDPPAG(bgjkmcbhnak.BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.KMGAHCANELI());
				if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) < iibeekcaahk.NAHLEJDLCNF())
				{
					lknfodkoped = (iibeekcaahk.FDCKJDDOJPB() - ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NKHBAJKMAGD)) * (403f + ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.FLHJLFHELPE) / 1167f) / (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) + 112f) * 1229f;
				}
			}
			bool flag = OLPINJLCKCI.NLOGJHEFMHM().HMAEKHKNNMP(lknfodkoped);
			if (flag)
			{
				Debug.Log("IdleStandingJump");
			}
			switch (bgjkmcbhnak.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (bgjkmcbhnak.PFNCHEEEBKD != null)
				{
					if (!flag)
					{
						if (bgjkmcbhnak.PFNCHEEEBKD.LOLCPOPODKE("OnOperationResponse: Unknow Response", "active_obj_").LOLBCAIEFMN() && this.GECLKEEGJGA())
						{
							base.StartCoroutine(this.HHHANGAKMLD());
						}
					}
					else if (this.dropScrpt != null)
					{
						this.dropScrpt.poplavokDown(467f);
					}
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				flag = true;
				this.dropScrpt.NNNOMNMLKFB();
				if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) > 23f)
				{
					bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.OGLIEFLNLLE), 925f, 594f));
					bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.GIMFIFECPGL), 172f, 1390f));
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.AJMPAOCEPCA(1941f * ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.CLAEAFMCDMP() * 1086f));
					bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(379f * ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.NAHLEJDLCNF() * 912f));
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				float num2 = 498f * (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PHLLHDNNOMB() + bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ) / 1314f;
				if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) > 1099f)
				{
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / (num2 + 884f));
					bgjkmcbhnak.EALPPCJHPKG = bgjkmcbhnak.GIMGAKKKHLF;
					if (this.dropScrpt != null)
					{
						this.dropScrpt.MDAENCJKIBI(1, 372f, !flag);
						FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("_n", BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, 843f, 448f, 1101f);
					}
				}
				break;
			}
			}
			if (this.dropScrpt != null && !flag)
			{
				this.dropScrpt.klevActivate();
			}
		}
	}

	// Token: 0x06003496 RID: 13462 RVA: 0x00190A63 File Offset: 0x0018EC63
	private IEnumerator DAJDHAEJFKH()
	{
		Debug.Log("***DropPointerEvnt");
		this.dropper = (UnityEngine.Object.Instantiate(Resources.Load("PoplDrop"), Vector3.zero, Quaternion.identity) as GameObject);
		this.dropScrpt = this.dropper.GetComponent<PoplDrop>();
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		float pointerDistance = LocNewLogic.getI.getPointerDistance();
		float num = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(pointerDistance) * 0.8f;
		float x = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num * 2f)) - num;
		float z = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num * 2f)) - num;
		new Vector3(x, 0f, z);
		this.dropScrpt.toPos = LocNewLogic.getI.toDropPoint;
		this.standFlag = false;
		this.isFishGet = false;
		this.CDNABIHPLHM = false;
		yield return new WaitForFixedUpdate();
		float num2 = (OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0) - 0.5f) * 0.5f;
		switch (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ())
		{
		case 100:
			this.dropper.transform.position = this.leftHandRodPoint.transform.position;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Poplavok;
			this.dropScrpt.drop();
			break;
		case 101:
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			Vector3 position = this.AOEGNGOGNBI.endPoint.transform.position + 0.5f * base.transform.up;
			this.dropper.transform.position = position;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Fider;
			this.dropScrpt.drop();
			bool flag = true;
			if (bgjkmcbhnak.PFNCHEEEBKD != null && bgjkmcbhnak.PFNCHEEEBKD.LODGJCMEGAI.IBEIBAHKIAH == 0)
			{
				flag = false;
			}
			if (flag)
			{
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak.CKBGHMMOAEM == null) ? 0L : bgjkmcbhnak.CKBGHMMOAEM.LPFKFNLHGBI);
					epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak.PFNCHEEEBKD == null) ? 0L : bgjkmcbhnak.PFNCHEEEBKD.LPFKFNLHGBI);
					epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(this.dropScrpt.toPos));
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1112, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[2], this.AOEGNGOGNBI.endPoint.transform.position, 0.3f, 3f, 15f, 1f + num2);
			break;
		}
		case 102:
		{
			Vector3 position2 = this.AOEGNGOGNBI.endPoint.transform.position + 0.5f * base.transform.up;
			this.dropper.transform.position = position2;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Spin;
			this.dropScrpt.drop();
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[1], this.AOEGNGOGNBI.endPoint.transform.position, 0.2f, 3f, 15f, 1f + num2);
			break;
		}
		}
		yield break;
	}

	// Token: 0x06003497 RID: 13463 RVA: 0x00190A74 File Offset: 0x0018EC74
	public void processHarvestEvnt(HBPNMNGOFMA KADBECGIMPD)
	{
		BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(KADBECGIMPD.BFPHBMDMODH());
		if (diggohpgcnn.OKEBIHBDEOO("none"))
		{
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("harvestmsg1"), Color.red, 0, 0);
		}
		if (diggohpgcnn.OKEBIHBDEOO("nowp"))
		{
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("harvestmsg2"), Color.red, 0, 0);
		}
		if (diggohpgcnn.OKEBIHBDEOO("noproff"))
		{
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("harvestmsg3"), Color.red, 0, 0);
		}
		if (diggohpgcnn.OKEBIHBDEOO("ok") && this.selectedMIO != null)
		{
			this.IHCKLDNAPDF = true;
			JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(diggohpgcnn.PPAAACJOOGA, 0, JNBICAJIJMM.LEBHCLDODNI("harvestmsg4"), new ONKDCGNBALK.CMMHGMILOIM(this.LEHADJGICJB), false);
		}
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x00190B52 File Offset: 0x0018ED52
	private IEnumerator CMCKAKDADNH()
	{
		yield return new WaitForSeconds(3f);
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().LGALGHAPJND = 100f;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().MENEMPKEBDI = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DHHLCNCMCDN = ObscuredFloat.GOOIABGKMHK(0f);
		}
		yield break;
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x00190B5C File Offset: 0x0018ED5C
	public void MNJPJMMJMFP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject != null)
		{
			this.BHMHJBPGOPH = null;
			UnityEngine.Object.Destroy(this.rodObject);
		}
		this.rodObject = IEPBGKCHDJO.PGPNBDMKIGO();
		if (this.rodObject == null)
		{
			return;
		}
		SkinnedMeshRenderer[] componentsInChildren = this.rodObject.GetComponentsInChildren<SkinnedMeshRenderer>();
		if (componentsInChildren != null)
		{
			SkinnedMeshRenderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].updateWhenOffscreen = true;
			}
		}
		this.rodObject.transform.position = Vector3.zero;
		this.rodObject.transform.rotation = Quaternion.identity;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localScale = new Vector3(1407f, 1550f, 543f);
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
		this.rodObject.transform.rotation = this.rightHandRodPoint.transform.rotation;
		this.rodObject.transform.localScale = new Vector3(359f, 1375f, 1348f);
		this.rodObject.transform.parent = this.rightHandRodPoint;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localPosition = Vector3.zero;
		this.NBHBIELHMEM(this.rodObject.GetComponent<RodParams>());
		this.IBPICCOBEFN = this.rodObject.GetComponent<RodPhysic>();
		if (this.HMGNDPIAIHC() != null)
		{
			this.HMGNDPIAIHC().CCGABEICHMJ(true, JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BNIHFBMEPAB);
		}
		Vector3 b = this.IJMGCKIOBPP().reelPoint.transform.position - this.AOEGNGOGNBI.transform.forward * 376f;
		Vector3 b2 = this.rodObject.transform.position - b;
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b2;
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		OMDDGEDHHNH.OGAOPAJFADH().ANDMFEGKNIC(IFPIMPMKJIB.CJNJNMEDIMB(this.currentRod.LJCLFFINEHJ.HHOLFABGDJA), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OLKOOBFAPHE), "gi_fridgice");
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x00190DD1 File Offset: 0x0018EFD1
	private IEnumerator EAIBONCGLFJ()
	{
		for (;;)
		{
			if (LocNewLogic.getI != null && base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ - 0.05f)
			{
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = true;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			this.sendToServerUserStates();
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600349B RID: 13467 RVA: 0x0018E873 File Offset: 0x0018CA73
	// (set) Token: 0x060034F9 RID: 13561 RVA: 0x00195A44 File Offset: 0x00193C44
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
			if (pofondfajlk != this.POFONDFAJLK)
			{
				if (!this.POFONDFAJLK)
				{
					base.StartCoroutine(this.PHDAHCBADLC());
				}
				this.sendFishingAction();
				if (this.POFONDFAJLK)
				{
					this.toOldLookForward = base.transform.forward;
					this.toOldLookCamFrwd = Camera.main.transform.forward;
					if (this.podsakObject != null)
					{
						this.podsakEvnt(-1);
					}
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						epmphjgalbe.BJANIMFDENK(IIBEEKCAAHK.ECOFBCMPIDO);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1110, epmphjgalbe.JDPHBLHOLAD());
						goto IL_B8;
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
				if (!this.isFishGet)
				{
					this.rotTimeToOldNpr = 1f;
				}
			}
			IL_B8:
			if (!this.POFONDFAJLK)
			{
				this.isPodsek = false;
				this.PodsekType = 0;
				LocNewLogic.getI.stopRollSound();
				if (LocNewLogic.getI != null)
				{
					LocNewLogic.getI.frikcionSound.Stop();
				}
				this.CDNABIHPLHM = false;
				this.blendRodDirection = 0f;
				this.usermode = Fisherman.NHOCKOJNFFJ.Stay;
				return;
			}
			this.usermode = Fisherman.NHOCKOJNFFJ.Fishing;
			GameInterface.getI.endShowFish();
		}
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x00190DE0 File Offset: 0x0018EFE0
	private void MJDPMBFEFPA()
	{
		if (LocNewLogic.getI != null && !LocNewLogic.getI.isMovingEnable)
		{
			this.MIBOJMFKFGI = false;
			this.PAGFNACCBON = base.transform.position;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.CIHILMCEJND)
		{
			this.rotateToNpr(Camera.main.transform.forward);
		}
		bool flag = this.HNBHANLDOMO();
		bool flag2 = this.HNBHANLDOMO();
		bool dccpcblodig = !Input.GetKey((KeyCode)187) && Input.GetMouseButton(1);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PMOJDCHIAHE < 708f)
		{
			dccpcblodig = false;
		}
		this.DOOBKPGJNEN(dccpcblodig);
		if (this.MFENINHGBHM)
		{
			this.DOOBKPGJNEN(false);
		}
		if (this.CIHILMCEJND)
		{
			this.APAPJMNFCPP(false);
			this.KJEMMGMPBBF(base.transform.position);
			return;
		}
		if (!JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA() && Input.GetMouseButton(0) && EventSystem.current != null && !EventSystem.current.IsPointerOverGameObject() && Time.time - this.LDAJPLCGEHC > 1659f)
		{
			this.LDAJPLCGEHC = Time.time;
			Vector2 v = Input.mousePosition;
			if (!HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
			{
				v = new Vector2((float)Screen.width / 1275f, (float)Screen.height / 1143f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 499f, this.clickLayerCollision))
			{
				this.toAObject = raycastHit.collider.gameObject.GetComponent<ActiveObject>();
				if (this.toAObject != null)
				{
					if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
					{
						Collider component = this.toAObject.GetComponent<Collider>();
						if (component != null)
						{
							Vector3 vector = component.ClosestPoint(base.transform.position);
							this.MGANDMKLMMM(new Vector3(vector.x, base.transform.position.y, vector.z));
						}
						else
						{
							this.MGANDMKLMMM(new Vector3(raycastHit.point.x, base.transform.position.y, raycastHit.point.z));
						}
					}
					else
					{
						this.APAPJMNFCPP(false);
					}
				}
				else if (!this.MFENINHGBHM)
				{
					this.KJEMMGMPBBF(new Vector3(raycastHit.point.x, base.transform.position.y, raycastHit.point.z));
				}
			}
		}
		Vector3 a = this.LFCLAFABKKE();
		a.y = base.transform.position.y;
		float num = Vector3.Distance(a, base.transform.position);
		flag2 = (num < 648f);
		if (this.OHKDFALEMNL())
		{
			flag2 = false;
		}
		if (this.fchair != null)
		{
			flag2 = false;
		}
		if (a.magnitude > 544f && Vector3.Distance(a, base.transform.position) > 1532f)
		{
			Vector3 a2 = this.LFCLAFABKKE();
			a2.y = base.transform.position.y;
			Quaternion b = Quaternion.LookRotation(a2 - base.transform.position);
			if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1026f);
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
			}
		}
		else
		{
			this.PAGFNACCBON = base.transform.position;
		}
		if (this.IHCKLDNAPDF && this.selectedMIO != null)
		{
			Vector3 position = this.selectedMIO.transform.position;
			position.y = base.transform.position.y;
			Quaternion b2 = Quaternion.LookRotation(position - base.transform.position);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime * 1127f);
		}
		if (num <= 274f)
		{
			flag2 = true;
			this.PAGFNACCBON = base.transform.position;
		}
		if (this.toAObject != null)
		{
			Vector3 b3 = this.toAObject.transform.position;
			Collider component2 = this.toAObject.GetComponent<Collider>();
			if (component2 != null)
			{
				b3 = component2.ClosestPoint(base.transform.position);
			}
			b3.y = base.transform.position.y;
			if (Vector3.Distance(base.transform.position, b3) < this.toAObject.dsta)
			{
				flag2 = false;
				this.PAGFNACCBON = base.transform.position;
				Vector3 position2 = this.toAObject.transform.position;
				position2.y = base.transform.position.y;
				Quaternion rotation = Quaternion.LookRotation(position2 - base.transform.position);
				if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE == 0)
				{
					base.transform.rotation = rotation;
				}
				else if (!LocNewLogic.getI.mouseLook.enabled && !this.CMCPFNJIIHK)
				{
					base.transform.rotation = rotation;
				}
				MMOItemObject component3 = this.toAObject.gameObject.GetComponent<MMOItemObject>();
				if (component3 != null)
				{
					Debug.Log("ArmFlex");
					this.selectedMIO = component3;
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-110, component3.pointId);
				}
				else
				{
					this.toAObject.DKGDHBLDLAO();
				}
				Debug.Log("PistolFire" + this.toAObject.iName);
				this.toAObject = null;
			}
		}
		if (flag2)
		{
			Vector3 vector2 = base.transform.forward;
			Ray ray = new Ray(base.transform.position + Vector3.up, vector2 + Vector3.down * 445f);
			Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 1315f);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray, out raycastHit2, 872f, this.clickLayerCollision))
			{
				if (raycastHit2.collider.gameObject.tag == "WeaponStab")
				{
					flag2 = true;
				}
				if (Mathf.Abs(base.transform.position.y - raycastHit2.point.y) > 382f)
				{
					flag2 = true;
				}
			}
			if (flag2)
			{
				vector2 = this.PAGFNACCBON - base.transform.position;
				Ray ray2 = new Ray(base.transform.position + new Vector3(1513f, 479f, 493f), vector2);
				Debug.DrawRay(ray2.origin, ray2.direction, Color.red, 850f);
				if (Physics.Raycast(ray2, out raycastHit2, 407f, this.moveLayerCollision))
				{
					flag2 = true;
				}
			}
			if (flag2 && !HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				this.cc.Move(base.transform.TransformDirection(Vector3.forward) * this.ICFIMJIABFN * Time.deltaTime);
			}
		}
		this.APAPJMNFCPP(flag2);
		if (Time.time - this.BFOIGHICKNN > 593f)
		{
			this.BFOIGHICKNN = Time.time;
			this.FCMIGOFMGCE();
		}
		this.HNBHANLDOMO();
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x0018C870 File Offset: 0x0018AA70
	public void CEMIMHBBBPL(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.EPMDDMKLDGC = DCCPCBLODIG;
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x0018C870 File Offset: 0x0018AA70
	public void CJIJPKLOFKN(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.EPMDDMKLDGC = DCCPCBLODIG;
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060034F4 RID: 13556 RVA: 0x0018CB3D File Offset: 0x0018AD3D
	// (set) Token: 0x0600349F RID: 13471 RVA: 0x00191574 File Offset: 0x0018F774
	public bool MIBOJMFKFGI
	{
		get
		{
			return this.AEEPMBEPGIK;
		}
		set
		{
			bool aeepmbepgik = this.AEEPMBEPGIK;
			if (value && this.CMCPFNJIIHK)
			{
				value = false;
			}
			this.AEEPMBEPGIK = value;
			if (this.AEEPMBEPGIK != aeepmbepgik)
			{
				this.sendMoveAction();
			}
			if (this.AEEPMBEPGIK)
			{
				this.action.FBFAJEGEIKM();
				if (this.toAObject != null)
				{
					this.UserLookAtOn(this.toAObject.transform.position);
					return;
				}
				this.UserLookAtOff();
			}
		}
	}

	// Token: 0x060034A1 RID: 13473 RVA: 0x001916CA File Offset: 0x0018F8CA
	public void podsakInWaterEvnt()
	{
		this.podsakInWater = true;
	}

	// Token: 0x060034A2 RID: 13474 RVA: 0x001916D4 File Offset: 0x0018F8D4
	private bool CGAMHMNLHCL(Vector3 ANHPFIEFBEP)
	{
		bool result = true;
		Ray ray = new Ray(base.transform.position + Vector3.up, ANHPFIEFBEP + Vector3.down * 2f);
		Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 5f);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit, 5f, this.clickLayerCollision))
		{
			if (raycastHit.collider.gameObject.tag == "Water")
			{
				result = false;
			}
			if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1.5f)
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060034A3 RID: 13475 RVA: 0x0018E08C File Offset: 0x0018C28C
	// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0019199F File Offset: 0x0018FB9F
	public RollParams NJGBAFIHICN
	{
		get
		{
			return BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB;
		}
		set
		{
			BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB = value;
		}
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x00191798 File Offset: 0x0018F998
	public void ICGBDCDDADA()
	{
		if (this.bragfish != null)
		{
			UnityEngine.Object.Destroy(this.bragfish.gameObject);
		}
		this.bragfish = null;
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x0018CB20 File Offset: 0x0018AD20
	public RodParams IJMGCKIOBPP()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI;
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x0018E08C File Offset: 0x0018C28C
	public RollParams NKFFPKCLFEI()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB;
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x001917C0 File Offset: 0x0018F9C0
	public void sendToServerUserStates()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			byte bjppebpndnj = 1;
			switch (this.usermode)
			{
			case Fisherman.NHOCKOJNFFJ.Stay:
				bjppebpndnj = 1;
				break;
			case Fisherman.NHOCKOJNFFJ.Fishing:
				bjppebpndnj = 2;
				break;
			case Fisherman.NHOCKOJNFFJ.FishOnRod:
				bjppebpndnj = 3;
				break;
			case Fisherman.NHOCKOJNFFJ.FishGet:
				bjppebpndnj = 4;
				break;
			}
			this.NFKHEGEDAMG(epmphjgalbe, 0);
			epmphjgalbe.JFBJCKCHMBC(bjppebpndnj);
			epmphjgalbe.GOMLLPFFPNP(ObscuredInt.GOOIABGKMHK(this.keyCount));
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1005, epmphjgalbe.JDPHBLHOLAD());
			this.HLCIJLIJECO = Time.time;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.keyCount = ObscuredInt.GOOIABGKMHK(0);
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00191868 File Offset: 0x0018FA68
	private IEnumerator EPPCDCANFGD()
	{
		Fisherman.OPHFPHOHKAL ophfphohkal = new Fisherman.OPHFPHOHKAL(1);
		ophfphohkal.AENJLLPLILM = this;
		return ophfphohkal;
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x001903C8 File Offset: 0x0018E5C8
	public bool KPIPJGKANCD()
	{
		return this.ADFNLBBFLKK;
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x00191878 File Offset: 0x0018FA78
	public void AHKJFHALEGH()
	{
		if (this.aimIK != null && this.aimIK.solver.target != null)
		{
			Vector3 b = Vector3.zero;
			if (this.rodObject != null && this.dropScrpt != null)
			{
				b = (this.EACGPPOMFLH().ILCJJKCPBKC - this.dropScrpt.transform.position).normalized * LocNewLogic.getI.getAnimRUpState() * 749f * this.aimConst.y;
			}
			Vector3 vector = this.aimIK.solver.target.position;
			vector = Vector3.Lerp(vector, base.transform.position + this.KANMIKKAPDI + base.transform.up * this.aimConst.w, Time.deltaTime * 999f) + b;
			this.aimIK.solver.target.position = vector;
		}
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x0019199F File Offset: 0x0018FB9F
	public void FECACBJADCD(RollParams DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB = DCCPCBLODIG;
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x001919AC File Offset: 0x0018FBAC
	public void JHBCOOFFLIC(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		if (this.bragfish == null)
		{
			this.bragfish = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("X", Vector3.zero, this.leftHandRodPoint);
			if (this.bragfish == null)
			{
				return;
			}
			this.bragfish.transform.parent = this.leftHandRodPoint;
			this.bragfish.transform.localRotation = Quaternion.identity;
			this.bragfish.transform.localScale = new Vector3(1861f, 1736f, 1746f);
			this.bragfish.transform.localPosition = Vector3.zero;
			this.bragfish.GetComponent<BragFish>().MDJMECDLEGB(OLKMHFNLBJB, NBLJCEHNKAK, false);
			base.StartCoroutine(this.BABKHEEOLDD(466f));
		}
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x00191A84 File Offset: 0x0018FC84
	public void rodEventProc(int KDMGMLJJALK)
	{
		Debug.Log("rodEventProc act=" + KDMGMLJJALK);
		if (KDMGMLJJALK > 0 && !this.CIHILMCEJND)
		{
			this.currentRod = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(this.currentRod.NKNCNHGDMLF.HHOLFABGDJA), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateRod), "");
		}
		if (KDMGMLJJALK < 0)
		{
			if (this.BHMHJBPGOPH != null)
			{
				UnityEngine.Object.Destroy(this.BHMHJBPGOPH);
			}
			if (this.rodObject != null)
			{
				UnityEngine.Object.Destroy(this.rodObject);
			}
			if (this.ragula != null)
			{
				UnityEngine.Object.Destroy(this.ragula.gameObject);
			}
			if (this.bubenec != null)
			{
				UnityEngine.Object.Destroy(this.bubenec.gameObject);
			}
			this.currentRod = null;
			this.IEKIGMBAGIL = null;
			this.ragula = null;
		}
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x00190B52 File Offset: 0x0018ED52
	private IEnumerator PHDAHCBADLC()
	{
		yield return new WaitForSeconds(3f);
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().LGALGHAPJND = 100f;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().MENEMPKEBDI = ObscuredFloat.GOOIABGKMHK(0f);
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DHHLCNCMCDN = ObscuredFloat.GOOIABGKMHK(0f);
		}
		yield break;
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x00191B80 File Offset: 0x0018FD80
	public void OCPBNAMAHGE()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		this.KANMIKKAPDI = base.transform.forward * 594f;
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.aimCntrl.FEBHIKMMNLF();
			return;
		}
		Transform transform = Camera.main.transform;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			transform = base.transform;
		}
		float d = this.upRodState;
		this.KANMIKKAPDI = transform.forward * 1712f + transform.up * 665f * this.aimConst.z;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			float num = 1426f * (Input.mousePosition.y - (float)Screen.height / 1108f) / (float)Screen.height;
			this.KANMIKKAPDI.y = this.KANMIKKAPDI.y + num * 1851f;
			this.KANMIKKAPDI += this.blendRodDirection * transform.right * 1914f * 1451f * this.aimConst.x;
		}
		if (this.rodObject != null && this.dropScrpt != null)
		{
			Vector3 vector = (this.AOEGNGOGNBI.CNDKCPLCGAB() - this.dropScrpt.transform.position).normalized;
			float t = Mathf.Abs(this.blendRodDirection);
			vector = Vector3.Lerp(Vector3.up, vector, t);
			this.KANMIKKAPDI += vector * d * 844f * this.aimConst.y;
			return;
		}
		this.KANMIKKAPDI += transform.up * this.upRodState * 553f * this.aimConst.y;
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x00191D94 File Offset: 0x0018FF94
	private IEnumerator ENCNPGBKMGP()
	{
		yield return new WaitForSeconds(2f);
		if (this.CDNABIHPLHM && this.DJPEBFMNLIC && BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI < ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD))
		{
			LocNewLogic.getI.fishDown(false, true);
		}
		yield break;
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x00191DA4 File Offset: 0x0018FFA4
	public void EBENCIAHHGO(bool DCCPCBLODIG)
	{
		if (this.KIMMNMDIBLF != DCCPCBLODIG)
		{
			Vector3 position = base.transform.position;
			if (this.selectedMIO != null)
			{
				position = this.selectedMIO.transform.position;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				this.PGBAKHHHFIL(epmphjgalbe, 1);
				epmphjgalbe.JFBJCKCHMBC((byte)-30);
				epmphjgalbe.IECHKLACNFM(DCCPCBLODIG);
				epmphjgalbe.JGINHHABOGM(new IIBEEKCAAHK(position));
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-59, epmphjgalbe.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
		}
		this.KIMMNMDIBLF = DCCPCBLODIG;
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x0018CB45 File Offset: 0x0018AD45
	public Vector3 EGHPOBMBIBC()
	{
		return this.LALPBFALKFL;
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x0018BE60 File Offset: 0x0018A060
	private void Awake()
	{
		this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		Fisherman.getI = this;
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x00191E44 File Offset: 0x00190044
	private void FixedUpdate()
	{
		if (this.leftHandRodPoint)
		{
			this.leftHandPointFxd = this.leftHandRodPoint.transform.position;
		}
		if (this.dropScrpt != null)
		{
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.dropScrpt.mode >= 2)
			{
				this.aimCntrl.FPIDHIOGEAM();
			}
		}
		else
		{
			this.aimCntrl.FBFAJEGEIKM();
		}
		if (LocNewLogic.getI != null)
		{
			if (LocNewLogic.getI.checkKeyRoll())
			{
				float num = 14f;
				if (Input.GetKey(KeyCode.LeftShift))
				{
					num = 32f;
				}
				this.KPKANMFPIKG += Time.fixedDeltaTime * num;
			}
			if (this.CIHILMCEJND)
			{
				this.GNAOLNLJEHH = (100f - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().LGALGHAPJND) / 100f;
			}
		}
		if (this.AOEGNGOGNBI != null)
		{
			if (this.AOEGNGOGNBI.reelPoint != null && this.NJGBAFIHICN != null)
			{
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 0f;
				}
				if (this.podsakObject != null)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 0f;
				}
				if (this.isFishGet)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 0f;
				}
				if (!this.CIHILMCEJND)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 0f;
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
			float num2 = this.bipIK.solver.rootNode.transform.position.y - 0.1f;
			if (Time.time - this.instChairTime < 3f && this.fchair.transform.position.y + 0.5f > num2)
			{
				Vector3 position = this.fchair.transform.position;
				position.y = num2 - 0.5f;
				this.fchair.transform.position = position;
			}
		}
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x00192094 File Offset: 0x00190294
	public void NADDOPFKIAC(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.JLLELCEFEPP())
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 449f + base.transform.up * 1851f;
		}
		this.toLookCntrl.ABKLNCIJDCG();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 1977f, base.transform.position.y + 1190f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x0018C870 File Offset: 0x0018AA70
	public void EBEFJOIOLMP(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.EPMDDMKLDGC = DCCPCBLODIG;
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x0019214D File Offset: 0x0019034D
	private IEnumerator MDDDAOOPOME()
	{
		return new Fisherman.GJLHFCDBPMP(1);
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x00192158 File Offset: 0x00190358
	public void BKMNOEIGDGP()
	{
		if (this.dropScrpt == null)
		{
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-8, BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
		if (this.dropScrpt != null)
		{
			ActorMgr.getI.MIKOGLFHFAK(this.dropScrpt.fish.transform.position);
			this.dropScrpt.HOIKDKEJJBP();
			this.dropScrpt = null;
		}
		this.NHINOHIFABB(false);
		this.isPodsek = true;
		this.isFishGet = true;
		this.rotTimeToOldNpr = 164f;
		if (this.podsakObject != null)
		{
			DitherShower component = this.podsakObject.GetComponent<DitherShower>();
			if (component != null)
			{
				component.dirVector = -1;
				component.scaleAlfaKF = 1790f;
			}
		}
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x00192221 File Offset: 0x00190421
	private IEnumerator KDOKCEOELMK()
	{
		return new Fisherman.NJCJFEDMODA(1);
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x0019222C File Offset: 0x0019042C
	private void Update()
	{
		if (this.generator != null)
		{
			this.generator.isWork = this.MFENINHGBHM;
		}
		if (this.rotTimeToOldNpr > 0f)
		{
			Quaternion a = Quaternion.LookRotation(this.toOldLookForward);
			base.transform.rotation = Quaternion.Lerp(a, base.transform.rotation, this.rotTimeToOldNpr);
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				a = Quaternion.LookRotation(this.toOldLookCamFrwd);
				Camera.main.transform.rotation = Quaternion.Lerp(a, Camera.main.transform.rotation, this.rotTimeToOldNpr);
			}
		}
		this.rotTimeToOldNpr -= Time.deltaTime;
		this.rightHandObj.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
		this.bipIK.solver.iterations = (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC ? 0 : 10);
		bool afeckmfdaea = this.getBragCntrl.AFECKMFDAEA;
		if (this.AOEGNGOGNBI != null && this.ragula != null)
		{
			this.AOEGNGOGNBI.PGEDLDMLBBE = Mathf.Clamp(this.AOEGNGOGNBI.PGEDLDMLBBE, 5f, 40f);
			this.forceControl((this.dropScrpt == null) ? null : this.dropScrpt.transform);
		}
		if (this.isRodMoveState)
		{
			this.moveCntrl.LJIEPIPIAJC(true);
		}
		else
		{
			this.moveCntrl.HEJDOBFKEHG();
		}
		if (this.wCircler != null)
		{
			if (LocNewLogic.getI != null)
			{
				this.wCircler.SetActive(true);
				Vector3 position = this.wCircler.transform.position;
				position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.005f;
				this.wCircler.transform.position = position;
			}
			else
			{
				this.wCircler.SetActive(false);
			}
		}
		this.fonar.gameObject.SetActive(this.EPMDDMKLDGC);
		if (this.MFENINHGBHM)
		{
			this.forceControl((this.dropScrpt != null) ? this.dropScrpt.transform : null);
		}
		if (!ChatPanelLogic.getI.isChatEnter())
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				this.EPMDDMKLDGC = !this.EPMDDMKLDGC;
				FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(LocNewLogic.getI.fonaricOnClip, base.transform.position + Vector3.up, 0.3f, 1f, 20f, 1f);
			}
			if (Input.GetKeyDown(KeyCode.O))
			{
				BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
				if (bgjkmcbhnak != null && bgjkmcbhnak.CKBGHMMOAEM != null)
				{
					this.JOBKCNGCBAN.FPIDHIOGEAM();
				}
			}
		}
		if (Application.isEditor)
		{
			Input.GetKeyDown(KeyCode.F2);
		}
		if (this.nameCanvas != null)
		{
			this.nameCanvas.transform.LookAt(Camera.main.transform);
			this.nameCanvas.transform.Rotate(0f, 180f, 0f);
		}
		this.NKPIFBHMHEL();
		this.rightVectorMove = Vector3.zero;
		this.frwrdVectorMove = Vector3.zero;
		if (this.isBreak || !this.MFENINHGBHM)
		{
			if (this.toAObject == null)
			{
				this.leftHandCntrl.FBFAJEGEIKM();
				this.rightHandCntrl.FBFAJEGEIKM();
				this.aimCntrl.FBFAJEGEIKM();
			}
			this.isKeyPress = false;
		}
		if (!this.CIHILMCEJND && this.toAObject == null)
		{
			this.leftHandCntrl.FBFAJEGEIKM();
			this.rightHandCntrl.FBFAJEGEIKM();
			this.aimCntrl.FBFAJEGEIKM();
		}
		if (this.CDNABIHPLHM)
		{
			if (Time.time - this.BFOIGHICKNN > 1f)
			{
				this.BFOIGHICKNN = Time.time;
				this.sendFishingAction();
			}
		}
		else if (this.MFENINHGBHM && Time.time - this.BFOIGHICKNN > 1f)
		{
			this.BFOIGHICKNN = Time.time;
			this.sendFishingAction();
		}
		this.isRodMoveState = false;
		if (!this.CIHILMCEJND && this.standFlag && !this.isFishGet && !ChatPanelLogic.getI.isChatEnter())
		{
			bool flag = false;
			Vector3 vector = base.transform.position - Camera.main.transform.position;
			Vector3 a2 = Vector3.zero;
			Vector3 vector2 = Vector3.zero;
			vector.y = 0f;
			vector.Normalize();
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				vector = Camera.main.transform.forward;
				vector.y = 0f;
				vector.Normalize();
			}
			bool flag2 = false;
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				if (!this.CMCPFNJIIHK)
				{
					if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
					{
						this.rightVectorMove = -base.transform.right;
					}
					if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
					{
						this.rightVectorMove = base.transform.right;
					}
					if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
					{
						this.frwrdVectorMove = base.transform.forward;
					}
					if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
					{
						this.frwrdVectorMove = base.transform.forward;
					}
					if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
					{
						this.frwrdVectorMove = -base.transform.forward;
					}
					Vector3 vector3 = base.transform.position + (this.rightVectorMove + this.frwrdVectorMove).normalized * 10f;
					if ((vector3 - base.transform.position).magnitude > 0.1f)
					{
						vector = this.frwrdVectorMove + this.rightVectorMove;
						if (this.CGAMHMNLHCL(vector))
						{
							this.rotateToNpr(Camera.main.transform.forward);
							this.LALPBFALKFL = vector3;
							this.cc.Move(vector.normalized * this.ICFIMJIABFN * Time.deltaTime);
							this.AEEPMBEPGIK = true;
							this.IBOLGKDFBNL = false;
							if (this.MFENINHGBHM)
							{
								this.isRodMoveState = true;
							}
						}
						else
						{
							this.AEEPMBEPGIK = false;
						}
						if (Time.time - this.BFOIGHICKNN > 1f)
						{
							this.LALPBFALKFL = vector3;
							this.sendMoveAction();
							this.LALPBFALKFL = base.transform.position;
						}
						flag = false;
					}
					else
					{
						this.AEEPMBEPGIK = false;
					}
				}
			}
			else
			{
				if (this.MFENINHGBHM)
				{
					if (!this.CMCPFNJIIHK)
					{
						if (this.CIHILMCEJND)
						{
							if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
							{
								base.transform.Rotate(0f, -70f * Time.deltaTime, 0f);
							}
							if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
							{
								base.transform.Rotate(0f, 70f * Time.deltaTime, 0f);
							}
						}
						else
						{
							if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
							{
								base.transform.Rotate(0f, -70f * Time.deltaTime * 2f, 0f);
							}
							if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
							{
								base.transform.Rotate(0f, 70f * Time.deltaTime * 2f, 0f);
							}
						}
					}
				}
				else
				{
					if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
					{
						a2 += new Vector3(-vector.z, vector.y, vector.x);
					}
					if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
					{
						a2 += new Vector3(vector.z, vector.y, -vector.x);
					}
				}
				if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
				{
					vector2 += vector;
				}
				if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
				{
					vector2 -= vector;
				}
				if (this.CMCPFNJIIHK)
				{
					vector2 = Vector3.zero;
					a2 = Vector3.zero;
				}
				Vector3 vector4 = base.transform.position + (a2 + vector2).normalized * 10f;
				if ((vector4 - base.transform.position).magnitude > 0.1f)
				{
					this.LALPBFALKFL = vector4;
					if (Time.time - this.BFOIGHICKNN > 1f)
					{
						this.sendMoveAction();
					}
					if (this.MFENINHGBHM)
					{
						this.isRodMoveState = true;
					}
					flag = true;
				}
			}
			if ((flag2 || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) & !flag)
			{
				this.MIBOJMFKFGI = false;
				this.PAGFNACCBON = base.transform.position;
			}
		}
		if (this.CIHILMCEJND && HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI)
		{
			Quaternion rotation = base.transform.rotation;
			Vector3 from = base.transform.forward;
			if (this.dropScrpt != null)
			{
				Vector3 position2 = this.dropScrpt.transform.position;
				position2.y = base.transform.position.y;
				from = position2 - base.transform.position;
			}
			if (!ChatPanelLogic.getI.isChatEnter() && !this.CMCPFNJIIHK)
			{
				if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
				{
					base.transform.Rotate(0f, -25f * Time.deltaTime, 0f);
				}
				if (Vector3.Angle(from, base.transform.forward) > 120f)
				{
					base.transform.rotation = rotation;
				}
				rotation = base.transform.rotation;
				if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
				{
					base.transform.Rotate(0f, 25f * Time.deltaTime, 0f);
				}
				if (Vector3.Angle(from, base.transform.forward) > 120f)
				{
					base.transform.rotation = rotation;
				}
			}
			if (BOIKJDICEMF.IKGFHGKKCPG != null && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning && LocNewLogic.getI.checkKeyRod() && this.dropScrpt != null)
			{
				int mode = this.dropScrpt.mode;
			}
		}
		this.toLookCntrl.FANPFKHEDPA();
		this.leftHandCntrl.FANPFKHEDPA();
		this.rightHandCntrl.FANPFKHEDPA();
		this.aimCntrl.FANPFKHEDPA();
		this.sitCntrl.FIDCELLHJIH(this.anm);
		this.moveCntrl.FIDCELLHJIH(this.anm);
		this.getBragCntrl.FIDCELLHJIH(this.anm);
		this.JOBKCNGCBAN.ACJNDCKOMME(this.anm);
		this.action.ACJNDCKOMME(this.anm);
		if (this.CIHILMCEJND)
		{
			float num = -99999f;
			bool flag3 = true;
			if (LocNewLogic.getI != null)
			{
				num = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (this.dropScrpt)
			{
				if (this.dropScrpt.transform.position.y > num + 0.01f)
				{
					flag3 = false;
				}
			}
			else
			{
				flag3 = false;
			}
			switch (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ())
			{
			case 0:
				if (this.CDNABIHPLHM)
				{
					if (!this.DJPEBFMNLIC)
					{
						flag3 = false;
					}
				}
				else
				{
					flag3 = false;
				}
				if (this.isFishGet)
				{
					flag3 = false;
				}
				break;
			case 1:
				flag3 = true;
				if (this.isFishGet)
				{
					flag3 = false;
				}
				break;
			case 2:
				if (!this.CDNABIHPLHM)
				{
					flag3 = false;
				}
				if (this.isFishGet)
				{
					flag3 = false;
				}
				if (this.ragula)
				{
					flag3 = false;
				}
				break;
			}
			if (flag3)
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
			this.leftHandCntrl.FBFAJEGEIKM();
		}
		bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		this.aimingLogic();
		if (this.bipIK != null && this.toAObject != null)
		{
			this.bipIK.solver.rightHandEffector.target = this.toAObject.transform;
		}
		if (this.aimIK != null)
		{
			this.aimIK.solver.IKPositionWeight = this.aimCntrl.NKHBAJKMAGD;
		}
		if (!this.useAIM)
		{
			this.aimIK.solver.IKPositionWeight = 0f;
		}
		if (this.lookIK != null)
		{
			this.lookIK.solver.IKPositionWeight = this.toLookCntrl.NKHBAJKMAGD;
			if (!this.toLookCntrl.HKPAEGGJNGG && this.toLookCntrl.NKHBAJKMAGD <= 0.01f)
			{
				this.FMEPCINEDCP.transform.position = this.PAGFNACCBON;
				this.toLookPoint = this.PAGFNACCBON;
			}
			if (this.bragfish != null)
			{
				this.toLookPoint = this.bragfish.transform.position;
			}
			this.FMEPCINEDCP.transform.position = Vector3.Lerp(this.FMEPCINEDCP.transform.position, this.toLookPoint, Time.deltaTime);
		}
		if (this.anm != null)
		{
			this.anm.SetBool("isHarvest", this.IHCKLDNAPDF);
			this.anm.SetBool("isWoman", this.isWoman);
			this.anm.SetBool("isBigFish", this.isBigFish);
			this.anm.SetBool("isRodOpen", this.MFENINHGBHM);
			this.anm.SetBool("isRodInWater", this.CIHILMCEJND);
			this.anm.SetInteger("DropType", this.DropType);
			this.anm.SetInteger("rodorder", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ());
			this.anm.SetInteger("PodsekType", this.PodsekType);
			this.anm.SetBool("isFishOnRod", this.CDNABIHPLHM);
			this.anm.SetBool("isKeyPress", this.isKeyPress);
			this.anm.SetBool("isFishGet", this.isFishGet);
			this.anm.SetBool("isBreak", this.isBreak);
			this.anm.SetBool("isMoving", this.MIBOJMFKFGI | this.isRodMoveState);
			this.anm.SetFloat("BlendDirection", this.blendRodDirection);
			this.anm.SetBool("isRun", this.IBOLGKDFBNL);
			this.anm.SetFloat("upRod", this.upRodState);
			this.anm.SetBool("isRealView", HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
		}
	}

	// Token: 0x060034BC RID: 13500 RVA: 0x001931D8 File Offset: 0x001913D8
	public void RollClapEvnt()
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[3], this.leftHandRodPoint.transform.position, 0.2f, 2f, 15f, 1f);
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x0019322C File Offset: 0x0019142C
	public void instaniateReel(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		this.IEKIGMBAGIL = IEPBGKCHDJO.GIFGIFAHPIA;
		if (this.IEKIGMBAGIL == null)
		{
			return;
		}
		if (this.AOEGNGOGNBI == null)
		{
			return;
		}
		this.BHMHJBPGOPH = UnityEngine.Object.Instantiate<GameObject>(this.IEKIGMBAGIL, this.AOEGNGOGNBI.reelPoint.transform.position, this.AOEGNGOGNBI.reelPoint.transform.rotation);
		this.BHMHJBPGOPH.transform.position = this.AOEGNGOGNBI.reelPoint.transform.position;
		this.BHMHJBPGOPH.transform.parent = this.rodObject.transform;
		this.NJGBAFIHICN = this.BHMHJBPGOPH.GetComponent<RollParams>();
		if (this.NJGBAFIHICN == null)
		{
			this.NJGBAFIHICN = this.BHMHJBPGOPH.AddComponent<RollParams>();
		}
		this.AOEGNGOGNBI.rollParams = this.NJGBAFIHICN;
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		if (this.rollPenPointObject != null)
		{
			this.rollPenPointObject.SetActive(true);
		}
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x00193344 File Offset: 0x00191544
	public void APNAPCPDCFP(Vector3 EDGHDMMAJGD)
	{
		if (this.rotTimeToOldNpr > 459f)
		{
			return;
		}
		Vector3 forward = EDGHDMMAJGD;
		forward.y = 1121f;
		forward.Normalize();
		Quaternion rotation = Quaternion.LookRotation(forward, Vector3.up);
		base.transform.rotation = rotation;
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x0019338C File Offset: 0x0019158C
	public void lineControl(bool IFOPGMDDLDC, bool CFFCOLLJEBL, Transform PLGBOPJNLGD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.dropScrpt == null)
		{
			bgjkmcbhnak.FBNCAHONHIP();
		}
		if (!this.MFENINHGBHM)
		{
			return;
		}
		if (this.isFishGet)
		{
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(5f);
			bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(5f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0.001f);
		}
		if (((this.CDNABIHPLHM && this.DJPEBFMNLIC) || this.isFishGet) && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) < 1000f)
		{
			float num = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) * 5f;
			float min = 0f;
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 0f)
			{
				min = 10f;
			}
			float num2 = num / bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ;
			float num3 = num / bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ;
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 0f, num2 * 100f));
			bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF), min, num3 * 100f));
		}
		float num4 = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 100f;
		float num5 = 1f;
		if (bgjkmcbhnak != null && bgjkmcbhnak.NKNCNHGDMLF != null)
		{
			num5 = bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 1000f;
			if (bgjkmcbhnak.AANHBNICFDL == 1 && bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				num5 *= 1f + ((float)kfhelhglnmh.FOACIAGMAPD(100) * 1f + (float)kfhelhglnmh.FOACIAGMAPD(101) * 5f) / 100f;
			}
		}
		bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL), ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), Time.deltaTime * bgjkmcbhnak.EFEJJFGGMOF));
		float num6 = bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1000f;
		if (bgjkmcbhnak.AANHBNICFDL == 1 && bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			num6 = num5 * (1f + ((float)kfhelhglnmh.FOACIAGMAPD(100) * 1f + (float)kfhelhglnmh.FOACIAGMAPD(102) * 5f) / 100f);
		}
		float num7 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / num6;
		bgjkmcbhnak.BMJKLAAKEIC = bgjkmcbhnak.OGLIEFLNLLE;
		bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE), ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF), Time.deltaTime * bgjkmcbhnak.EFEJJFGGMOF));
		bgjkmcbhnak.OLCJIJGPOHN = bgjkmcbhnak.GIMFIFECPGL;
		bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL), 0f, 100f));
		bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE), 0f, 100f));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 0f, 130f));
		bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF), 0f, 130f));
		if (this.dropScrpt != null && this.dropScrpt.fish != null && ObscuredBool.GOOIABGKMHK(this.dropScrpt.fish.isPodsek) && BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI < ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD))
		{
			bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(75f);
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(75f);
		}
		LocNewLogic.getI.frikcionWorkProcess();
		if (this.CDNABIHPLHM && this.DJPEBFMNLIC)
		{
			bool flag = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) > 165f;
			if (this.isFishGet)
			{
				flag = false;
			}
			if (flag)
			{
				LocNewLogic.getI.fishDown(false, false);
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL) >= 99f)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, bgjkmcbhnak.NKNCNHGDMLF.LPFKFNLHGBI);
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(0f);
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.OBCCLNMPGEJ(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI);
					epmphjgalbe.NEHCMOODKIN(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
					epmphjgalbe.GOMLLPFFPNP(1);
					epmphjgalbe.GOMLLPFFPNP(bgjkmcbhnak.NKNCNHGDMLF.HHOLFABGDJA);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(910, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
				bgjkmcbhnak.NKNCNHGDMLF.JGNIDDBNGGP = 500;
				bgjkmcbhnak.NKNCNHGDMLF = null;
				BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
				if (this.dropScrpt != null)
				{
					this.dropScrpt.kill();
				}
				OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("droprodmsg1"));
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("spinbreak.ogg", 0.5f);
				this.breakAction();
				return;
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE) >= 99f)
			{
				Debug.Log("leskaProc");
				if (bgjkmcbhnak.IIOHPBENEFI != null)
				{
					float num8 = Vector3.Distance(this.AOEGNGOGNBI.ILCJJKCPBKC, (PLGBOPJNLGD != null) ? PLGBOPJNLGD.position : this.AOEGNGOGNBI.ILCJJKCPBKC);
					num8 = Mathf.Clamp(num8, 1f, 3f);
					float num9 = Mathf.Round(1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num8));
					bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
					bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF -= (double)num9;
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("linebreak.ogg", 1f);
					EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
					try
					{
						epmphjgalbe2.OBCCLNMPGEJ(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI);
						epmphjgalbe2.NEHCMOODKIN(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
						epmphjgalbe2.GOMLLPFFPNP(2);
						epmphjgalbe2.GOMLLPFFPNP(bgjkmcbhnak.IIOHPBENEFI.HHOLFABGDJA);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(910, epmphjgalbe2.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe2.LMBPNFHKNGA();
					}
					try
					{
						if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
						{
							if (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF <= 10.0)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg1"), bgjkmcbhnak.IIOHPBENEFI.JPBOPFNPNHC(false)));
								bgjkmcbhnak.IIOHPBENEFI.JGNIDDBNGGP = 500;
								bgjkmcbhnak.IIOHPBENEFI = null;
							}
							else
							{
								EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe3.OBCCLNMPGEJ(bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
									epmphjgalbe3.DLAIEEJAFDG(num9);
									NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1306, epmphjgalbe3.JDPHBLHOLAD());
								}
								finally
								{
									epmphjgalbe3.LMBPNFHKNGA();
								}
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg2"), Mathf.Round(num9)));
							}
							if (bgjkmcbhnak.CBLCFLENIJL[0] != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.CBLCFLENIJL[0].LPFKFNLHGBI);
							}
							if (bgjkmcbhnak.AMLEOGHNNPG[0] != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.AMLEOGHNNPG[0].LPFKFNLHGBI);
							}
							if (bgjkmcbhnak.PFNCHEEEBKD != null && num9 > bgjkmcbhnak.IFNNBJDJBNA)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.PFNCHEEEBKD.LPFKFNLHGBI);
								bgjkmcbhnak.PFNCHEEEBKD.JGNIDDBNGGP = 500;
								bgjkmcbhnak.PFNCHEEEBKD = null;
							}
						}
						if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
						{
							if (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF <= 10.0)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg1"), bgjkmcbhnak.IIOHPBENEFI.JPBOPFNPNHC(false)));
								bgjkmcbhnak.IIOHPBENEFI.JGNIDDBNGGP = 500;
								bgjkmcbhnak.IIOHPBENEFI = null;
							}
							else
							{
								EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe4.OBCCLNMPGEJ(bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
									epmphjgalbe4.DLAIEEJAFDG(num9);
									NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1306, epmphjgalbe4.JDPHBLHOLAD());
								}
								finally
								{
									epmphjgalbe4.LMBPNFHKNGA();
								}
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg2"), Mathf.Round(num9)));
							}
							if (bgjkmcbhnak.PFNCHEEEBKD != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.PFNCHEEEBKD.LPFKFNLHGBI);
							}
							if (bgjkmcbhnak.AMLEOGHNNPG[0] != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.AMLEOGHNNPG[0].LPFKFNLHGBI);
								bgjkmcbhnak.AMLEOGHNNPG[0].JGNIDDBNGGP = 500;
								bgjkmcbhnak.AMLEOGHNNPG[0] = null;
							}
						}
						if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
						{
							if (bgjkmcbhnak.BCKECOENDLB != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.BCKECOENDLB.LPFKFNLHGBI);
							}
							if (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NKGGAFLBFDF <= 10.0)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1305, bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg1"), bgjkmcbhnak.IIOHPBENEFI.JPBOPFNPNHC(false)));
								bgjkmcbhnak.IIOHPBENEFI.JGNIDDBNGGP = 500;
								bgjkmcbhnak.IIOHPBENEFI = null;
							}
							else
							{
								EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe5.OBCCLNMPGEJ(bgjkmcbhnak.IIOHPBENEFI.LPFKFNLHGBI);
									epmphjgalbe5.DLAIEEJAFDG(num9);
									NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1306, epmphjgalbe5.JDPHBLHOLAD());
								}
								finally
								{
									epmphjgalbe5.LMBPNFHKNGA();
								}
								OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("droplinemsg2"), Mathf.Round(num9)));
							}
							if (bgjkmcbhnak.PFNCHEEEBKD != null)
							{
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1307, bgjkmcbhnak.PFNCHEEEBKD.LPFKFNLHGBI);
							}
						}
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("linebreak.ogg", 1f);
					this.breakAction();
				}
			}
		}
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00190DD1 File Offset: 0x0018EFD1
	private IEnumerator LNCAMILAPPM()
	{
		for (;;)
		{
			if (LocNewLogic.getI != null && base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ - 0.05f)
			{
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = true;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			this.sendToServerUserStates();
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x00193E90 File Offset: 0x00192090
	public void IHFGBPOPAEF()
	{
		if (this.rollPenPointObject != null)
		{
			if (this.ILAOBMPAEJN() != null)
			{
				this.rollPenPointObject.SetActive(false);
				this.rollPenPointObject.transform.position = this.NKFFPKCLFEI().handPoint.transform.position;
				return;
			}
			this.rollPenPointObject.SetActive(true);
		}
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x0018D31C File Offset: 0x0018B51C
	private IEnumerator FMPGDNHBEEC()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060034F6 RID: 13558 RVA: 0x001903C8 File Offset: 0x0018E5C8
	// (set) Token: 0x060034C3 RID: 13507 RVA: 0x00193EF8 File Offset: 0x001920F8
	public bool CMCPFNJIIHK
	{
		get
		{
			return this.ADFNLBBFLKK;
		}
		set
		{
			bool adfnlbbflkk = this.ADFNLBBFLKK;
			this.ADFNLBBFLKK = value;
			if (this.ADFNLBBFLKK)
			{
				if (ActorMgr.getI.minActorDistance(base.transform.position) < 1.5f)
				{
					FlyMessageManager.getI.clearMessages();
					FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("msg_other"), Color.red, 0, 0);
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
					return;
				}
				this.AEEPMBEPGIK = false;
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
					UnityEngine.Object.Destroy(this.fchair, 0.5f);
				}
				this.fchair = null;
			}
			this.PAGFNACCBON = base.transform.position;
			if (this.ADFNLBBFLKK != adfnlbbflkk)
			{
				this.sendMoveAction();
				this.sendToServerUserStates();
			}
		}
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x0018C367 File Offset: 0x0018A567
	public void GCFOFHOCLOK(RodParams DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI = DCCPCBLODIG;
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x00194030 File Offset: 0x00192230
	public void BFJPLGICCNA(bool DCCPCBLODIG)
	{
		if (this.KIMMNMDIBLF != DCCPCBLODIG)
		{
			Vector3 position = base.transform.position;
			if (this.selectedMIO != null)
			{
				position = this.selectedMIO.transform.position;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				this.NFKHEGEDAMG(epmphjgalbe, 0);
				epmphjgalbe.DILDCOFOGHJ((byte)-122);
				epmphjgalbe.PJIABBIPPNH(DCCPCBLODIG);
				epmphjgalbe.JGINHHABOGM(new IIBEEKCAAHK(position));
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-169, epmphjgalbe.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
		}
		this.KIMMNMDIBLF = DCCPCBLODIG;
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x001940D0 File Offset: 0x001922D0
	public void sendAction(int CMBMMEEBHFA, float GKENCBIOPGO, Vector3 LBGHKIDGKCO)
	{
		if (CMBMMEEBHFA == 0)
		{
			this.action.FBFAJEGEIKM();
		}
		else
		{
			this.action.FPIDHIOGEAM(CMBMMEEBHFA, GKENCBIOPGO);
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.NFKHEGEDAMG(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC(114);
			epmphjgalbe.GOMLLPFFPNP(CMBMMEEBHFA);
			epmphjgalbe.DLAIEEJAFDG(GKENCBIOPGO);
			epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(LBGHKIDGKCO));
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1006, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00194158 File Offset: 0x00192358
	public void LatePhysic()
	{
		if (this.rollPenPointObject != null)
		{
			if (this.NJGBAFIHICN != null)
			{
				this.rollPenPointObject.SetActive(true);
				this.rollPenPointObject.transform.position = this.NJGBAFIHICN.handPoint.transform.position;
				return;
			}
			this.rollPenPointObject.SetActive(false);
		}
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x001941C0 File Offset: 0x001923C0
	public void rotateToNpr(Vector3 EDGHDMMAJGD)
	{
		if (this.rotTimeToOldNpr > 0f)
		{
			return;
		}
		Vector3 forward = EDGHDMMAJGD;
		forward.y = 0f;
		forward.Normalize();
		Quaternion rotation = Quaternion.LookRotation(forward, Vector3.up);
		base.transform.rotation = rotation;
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x00194208 File Offset: 0x00192408
	public void HHJPOMOGJEF()
	{
		this.standFlag = true;
		this.LNFIJPICHPG(false);
		this.isPodsek = false;
		this.PodsekType = 1;
		if (this.dropScrpt != null)
		{
			this.dropScrpt.kill();
		}
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00194240 File Offset: 0x00192440
	public void NEFHFADILLJ(bool DCCPCBLODIG)
	{
		bool hdlhcmopikm = this.HDLHCMOPIKM;
		this.HDLHCMOPIKM = DCCPCBLODIG;
		this.DropType = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GMLFCKNNOPJ();
		if (hdlhcmopikm != this.HDLHCMOPIKM)
		{
			this.sendFishingAction();
			if (this.HDLHCMOPIKM)
			{
				this.toOldLookForward = base.transform.forward;
				this.toOldLookCamFrwd = Camera.main.transform.forward;
			}
		}
		if (!this.HDLHCMOPIKM)
		{
			GameInterface.getI.endShowFish();
			this.CDIDCIBEDKP(true);
			this.NHINOHIFABB(false);
			this.isPodsek = false;
			this.isFishGet = false;
			this.isBigFish = true;
			this.UserLookAtOff();
			this.leftHandCntrl.IHBKHMKBGAK();
			this.rightHandCntrl.FBFAJEGEIKM();
			this.toLookCntrl.PKHHNGLGJKA();
			this.aimCntrl.PKHHNGLGJKA();
			this.PodsekType = 1;
			if (this.dropScrpt != null)
			{
				this.dropScrpt.kill();
				this.dropScrpt = null;
				return;
			}
		}
		else
		{
			this.isBreak = false;
			this.bipIK.enabled = true;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			if (bgjkmcbhnak != null)
			{
				EKBAPCMPANI ljclffinehj = bgjkmcbhnak.LJCLFFINEHJ;
			}
		}
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00190DD1 File Offset: 0x0018EFD1
	private IEnumerator EHJDMLIFHHB()
	{
		for (;;)
		{
			if (LocNewLogic.getI != null && base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ - 0.05f)
			{
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = true;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			this.sendToServerUserStates();
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x001916CA File Offset: 0x0018F8CA
	public void HHELJKPLCMB()
	{
		this.podsakInWater = true;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00194374 File Offset: 0x00192574
	public void AimIKUpdateProcess()
	{
		if (this.aimIK != null && this.aimIK.solver.target != null)
		{
			Vector3 b = Vector3.zero;
			if (this.rodObject != null && this.dropScrpt != null)
			{
				b = (this.AOEGNGOGNBI.ILCJJKCPBKC - this.dropScrpt.transform.position).normalized * LocNewLogic.getI.getAnimRUpState() * 5f * this.aimConst.y;
			}
			Vector3 vector = this.aimIK.solver.target.position;
			vector = Vector3.Lerp(vector, base.transform.position + this.KANMIKKAPDI + base.transform.up * this.aimConst.w, Time.deltaTime * 2f) + b;
			this.aimIK.solver.target.position = vector;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060034CF RID: 13519 RVA: 0x0019449B File Offset: 0x0019269B
	// (set) Token: 0x060034D0 RID: 13520 RVA: 0x001944A7 File Offset: 0x001926A7
	public RodPhysic IBPICCOBEFN
	{
		get
		{
			return BOIKJDICEMF.IKGFHGKKCPG.IBPICCOBEFN;
		}
		set
		{
			BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
			BOIKJDICEMF.IKGFHGKKCPG.IBPICCOBEFN = value;
		}
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x001944C0 File Offset: 0x001926C0
	public void HKPGHCBHAPB()
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		FBFJFAKAGJG.IKGFHGKKCPG.KCBPPLKKCNP(SoundSamplesStorage.getI.dropSounds[8], this.leftHandRodPoint.transform.position, 1574f, 1008f, 786f, 1083f);
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00194511 File Offset: 0x00192711
	private IEnumerator HHHANGAKMLD()
	{
		if (this.dropScrpt != null)
		{
			yield return new WaitForSeconds(1f);
			Vector3 position = this.dropScrpt.transform.position;
			position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.1f;
			AudioClip dnibjblmpgf = SoundSamplesStorage.getI.poplSounds[HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN];
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(dnibjblmpgf, position, HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ, 5f, 50f, 1f + (HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID - 0.5f) * 0.3f);
		}
		yield break;
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x00194520 File Offset: 0x00192720
	public void ENFLCHGAJKK(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		if (this.bragfish == null)
		{
			this.bragfish = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("[fish]", Vector3.zero, this.leftHandRodPoint);
			if (this.bragfish == null)
			{
				return;
			}
			this.bragfish.transform.parent = this.leftHandRodPoint;
			this.bragfish.transform.localRotation = Quaternion.identity;
			this.bragfish.transform.localScale = new Vector3(795f, 1762f, 1429f);
			this.bragfish.transform.localPosition = Vector3.zero;
			this.bragfish.GetComponent<BragFish>().JGPKEKJCNOO(OLKMHFNLBJB, NBLJCEHNKAK, true);
			base.StartCoroutine(this.IKNBAFLKELI(1059f));
		}
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x001945F8 File Offset: 0x001927F8
	public void getFishAction()
	{
		LocNewLogic.getI.frikcionSound.Stop();
		LocNewLogic.getI.stopRollSound();
		this.usermode = Fisherman.NHOCKOJNFFJ.FishGet;
		this.isFishGet = true;
		this.isKeyPress = false;
		this.CIHILMCEJND = false;
		this.sendGetFishAction();
		if (this.dropScrpt != null && this.dropScrpt.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.dropScrpt.fishPointer);
			this.dropScrpt.fishPointer = null;
		}
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x0019449B File Offset: 0x0019269B
	public RodPhysic HMGNDPIAIHC()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.IBPICCOBEFN;
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x00194680 File Offset: 0x00192880
	public void IOCBLNCLJNI(HBPNMNGOFMA KADBECGIMPD)
	{
		BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(KADBECGIMPD.LPKJHMGLCKA());
		if (diggohpgcnn.LOMKLMPKJEC("Original lives count:\n"))
		{
			FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.DIOJFJMOPJO("<color='#206060'>"), Color.red, 0, 1);
		}
		if (diggohpgcnn.OKEBIHBDEOO(" B:"))
		{
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.PGJCPFNJNPM("wpn_rod4"), Color.red, 1, 1);
		}
		if (diggohpgcnn.OKEBIHBDEOO("RoundHouse"))
		{
			FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.CDDCIKKDFMP("id"), Color.red, 1, 1);
		}
		if (diggohpgcnn.OKEBIHBDEOO("SexyDance2") && this.selectedMIO != null)
		{
			this.EBENCIAHHGO(true);
			JDCEFOFMGHB.JFIDAGABKID().DKJMCKOJOPF(diggohpgcnn.OEIAFJHKMIJ(), 0, JNBICAJIJMM.DIOJFJMOPJO("gi_letgohe"), new ONKDCGNBALK.CMMHGMILOIM(this.LEHADJGICJB), true);
		}
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x0019475E File Offset: 0x0019295E
	public void EAEPMOKEBFJ()
	{
		this.standFlag = true;
		this.CDNABIHPLHM = false;
		this.isPodsek = false;
		this.PodsekType = 0;
		if (this.dropScrpt != null)
		{
			this.dropScrpt.HOIKDKEJJBP();
		}
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x00194798 File Offset: 0x00192998
	public void aimingLogic()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		this.KANMIKKAPDI = base.transform.forward * 5f;
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.aimCntrl.FBFAJEGEIKM();
			return;
		}
		Transform transform = Camera.main.transform;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			transform = base.transform;
		}
		float d = this.upRodState;
		this.KANMIKKAPDI = transform.forward * 5f + transform.up * 5f * this.aimConst.z;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			float num = 1.5f * (Input.mousePosition.y - (float)Screen.height / 2f) / (float)Screen.height;
			this.KANMIKKAPDI.y = this.KANMIKKAPDI.y + num * 2f;
			this.KANMIKKAPDI += this.blendRodDirection * transform.right * 5f * 0.8f * this.aimConst.x;
		}
		if (this.rodObject != null && this.dropScrpt != null)
		{
			Vector3 vector = (this.AOEGNGOGNBI.ILCJJKCPBKC - this.dropScrpt.transform.position).normalized;
			float t = Mathf.Abs(this.blendRodDirection);
			vector = Vector3.Lerp(Vector3.up, vector, t);
			this.KANMIKKAPDI += vector * d * 5f * this.aimConst.y;
			return;
		}
		this.KANMIKKAPDI += transform.up * this.upRodState * 5f * this.aimConst.y;
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060034DA RID: 13530 RVA: 0x0018C45E File Offset: 0x0018A65E
	public Vector3 CLCGHNOHDGL
	{
		get
		{
			return this.toLookPoint;
		}
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x001949AC File Offset: 0x00192BAC
	public void KJEMMGMPBBF(Vector3 DCCPCBLODIG)
	{
		Vector3 lalpbfalkfl = this.LALPBFALKFL;
		this.LALPBFALKFL = DCCPCBLODIG;
		if ((lalpbfalkfl - this.LALPBFALKFL).magnitude > 1157f)
		{
			this.sendMoveAction();
		}
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x001949E8 File Offset: 0x00192BE8
	public void JOOIFNDAKBI(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		if (this.bragfish == null)
		{
			this.bragfish = JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("SwimDogPaddle", Vector3.zero, this.leftHandRodPoint);
			if (this.bragfish == null)
			{
				return;
			}
			this.bragfish.transform.parent = this.leftHandRodPoint;
			this.bragfish.transform.localRotation = Quaternion.identity;
			this.bragfish.transform.localScale = new Vector3(845f, 889f, 429f);
			this.bragfish.transform.localPosition = Vector3.zero;
			this.bragfish.GetComponent<BragFish>().GIPBNGINEKP(OLKMHFNLBJB, NBLJCEHNKAK, false);
			base.StartCoroutine(this.BABKHEEOLDD(1800f));
		}
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x001944A7 File Offset: 0x001926A7
	public void NEJCFEOKGKO(RodPhysic DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		BOIKJDICEMF.IKGFHGKKCPG.IBPICCOBEFN = DCCPCBLODIG;
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x00194AC0 File Offset: 0x00192CC0
	private void NFKHEGEDAMG(EPMPHJGALBE CPFJMLFLKFI, byte JNFEAFBIMAL)
	{
		CPFJMLFLKFI.OBCCLNMPGEJ(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI);
		CPFJMLFLKFI.JFBJCKCHMBC(JNFEAFBIMAL);
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(base.transform.position));
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(base.transform.rotation.eulerAngles));
		CPFJMLFLKFI.KJDIGAKNOAI(this.MIBOJMFKFGI | this.isRodMoveState);
		CPFJMLFLKFI.BJANIMFDENK(new IIBEEKCAAHK(this.PAGFNACCBON));
		CPFJMLFLKFI.KJDIGAKNOAI(this.IBOLGKDFBNL);
		CPFJMLFLKFI.DLAIEEJAFDG(this.ICFIMJIABFN);
		CPFJMLFLKFI.KJDIGAKNOAI(this.ADFNLBBFLKK);
		CPFJMLFLKFI.JFBJCKCHMBC(0);
		CPFJMLFLKFI.JFBJCKCHMBC(0);
		CPFJMLFLKFI.JFBJCKCHMBC(0);
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00194B7C File Offset: 0x00192D7C
	public void KNMCGDPNEME()
	{
		if (Time.time - this.BFOIGHICKNN < 1032f)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.PGBAKHHHFIL(epmphjgalbe, 1);
			byte bjppebpndnj = 109;
			if (this.HNBHANLDOMO())
			{
				bjppebpndnj = (byte)-76;
			}
			epmphjgalbe.HMHLPBLANND(bjppebpndnj);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(184, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		this.LNBFBHABIAC();
		this.BFOIGHICKNN = Time.time;
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x00194C00 File Offset: 0x00192E00
	public void IKGNPINGLFA(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject != null)
		{
			this.BHMHJBPGOPH = null;
			UnityEngine.Object.Destroy(this.rodObject);
		}
		this.rodObject = IEPBGKCHDJO.OCCMKOPELGK();
		if (this.rodObject == null)
		{
			return;
		}
		SkinnedMeshRenderer[] componentsInChildren = this.rodObject.GetComponentsInChildren<SkinnedMeshRenderer>();
		if (componentsInChildren != null)
		{
			SkinnedMeshRenderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].updateWhenOffscreen = true;
			}
		}
		this.rodObject.transform.position = Vector3.zero;
		this.rodObject.transform.rotation = Quaternion.identity;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localScale = new Vector3(1841f, 1228f, 67f);
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
		this.rodObject.transform.rotation = this.rightHandRodPoint.transform.rotation;
		this.rodObject.transform.localScale = new Vector3(860f, 167f, 1905f);
		this.rodObject.transform.parent = this.rightHandRodPoint;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localPosition = Vector3.zero;
		this.AOEGNGOGNBI = this.rodObject.GetComponent<RodParams>();
		this.IBPICCOBEFN = this.rodObject.GetComponent<RodPhysic>();
		if (this.HMGNDPIAIHC() != null)
		{
			this.HMGNDPIAIHC().EJGOHNDFIKD(true, JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
		}
		Vector3 b = this.EACGPPOMFLH().reelPoint.transform.position - this.EACGPPOMFLH().transform.forward * 196f;
		Vector3 b2 = this.rodObject.transform.position - b;
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b2;
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		OMDDGEDHHNH.DAANHKAOCKP().HBBIEEBNJGF(IFPIMPMKJIB.IGAAHFOINKI(this.currentRod.LJCLFFINEHJ.HHOLFABGDJA), 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateReel), "baraban");
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x00194E75 File Offset: 0x00193075
	private IEnumerator OLAINLAJIBE()
	{
		for (;;)
		{
			if (JBEHMPDDMME.IKGFHGKKCPG != null)
			{
				NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
				if (kfhelhglnmh != null)
				{
					int num = 0;
					int num2 = 0;
					EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 6);
					int num3 = 0;
					foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
					{
						num3 += oijegjlcfcf.NKHBAJKMAGD;
					}
					if (ekbapcmpani != null)
					{
						num = ekbapcmpani.LODGJCMEGAI.ICJDPPOJINN;
						num2 = ekbapcmpani.LODGJCMEGAI.IBEIBAHKIAH;
					}
					if (kfhelhglnmh.NAFGMKJPLPC.Count >= num - 1)
					{
						FlyMessageManager.getI.addFlyIcon(11, 3f, IIBEEKCAAHK.ECOFBCMPIDO, false, false);
					}
					if (num3 >= num2)
					{
						string iabkgmnjljo = JNBICAJIJMM.LEBHCLDODNI("tankfullmsg1");
						FlyMessageManager.getI.clearMessages();
						FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.red, 0, 0);
						FlyMessageManager.getI.addFlyIcon(11, 3f, IIBEEKCAAHK.ECOFBCMPIDO, false, false);
					}
					if (!BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
					{
						FlyMessageManager.getI.addFlyIcon(8, 3f, IIBEEKCAAHK.ECOFBCMPIDO, false, false);
					}
					using (Dictionary<long, EKBAPCMPANI>.ValueCollection.Enumerator enumerator2 = kfhelhglnmh.PLLHGAFIAFD.Values.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.JGNIDDBNGGP == 55)
							{
								FlyMessageManager.getI.clearMessages();
								FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("rewgt_msg"), Color.red, 0, 0);
								break;
							}
						}
					}
				}
			}
			yield return new WaitForSeconds(2f);
		}
		yield break;
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060034E2 RID: 13538 RVA: 0x0018CB2C File Offset: 0x0018AD2C
	// (set) Token: 0x060034F5 RID: 13557 RVA: 0x001959D4 File Offset: 0x00193BD4
	public bool CDNABIHPLHM
	{
		get
		{
			return BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM;
		}
		set
		{
			bool cdnabihplhm = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = value;
			if (cdnabihplhm != BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM)
			{
				this.sendFishingAction();
			}
		}
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00194E80 File Offset: 0x00193080
	public void userDead()
	{
		string text = JNBICAJIJMM.LEBHCLDODNI("userdeadmsg");
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(text);
		FlyMessageManager.getI.SendMessage(text, Color.red);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("man_death.ogg", 1f);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("geiger.ogg", 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		base.StartCoroutine(this.HBOCPMFNDGD());
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x00194EF8 File Offset: 0x001930F8
	public void GNIBHEFGIGD()
	{
		LocNewLogic.getI.frikcionSound.Stop();
		LocNewLogic.getI.stopRollSound();
		this.usermode = (Fisherman.NHOCKOJNFFJ)8;
		this.isFishGet = false;
		this.isKeyPress = false;
		this.CDIDCIBEDKP(false);
		this.sendGetFishAction();
		if (this.dropScrpt != null && this.dropScrpt.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.dropScrpt.fishPointer);
			this.dropScrpt.fishPointer = null;
		}
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x00190A63 File Offset: 0x0018EC63
	private IEnumerator MFDEGBDIFCD()
	{
		Debug.Log("***DropPointerEvnt");
		this.dropper = (UnityEngine.Object.Instantiate(Resources.Load("PoplDrop"), Vector3.zero, Quaternion.identity) as GameObject);
		this.dropScrpt = this.dropper.GetComponent<PoplDrop>();
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		float pointerDistance = LocNewLogic.getI.getPointerDistance();
		float num = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(pointerDistance) * 0.8f;
		float x = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num * 2f)) - num;
		float z = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num * 2f)) - num;
		new Vector3(x, 0f, z);
		this.dropScrpt.toPos = LocNewLogic.getI.toDropPoint;
		this.standFlag = false;
		this.isFishGet = false;
		this.CDNABIHPLHM = false;
		yield return new WaitForFixedUpdate();
		float num2 = (OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0) - 0.5f) * 0.5f;
		switch (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ())
		{
		case 100:
			this.dropper.transform.position = this.leftHandRodPoint.transform.position;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Poplavok;
			this.dropScrpt.drop();
			break;
		case 101:
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			Vector3 position = this.AOEGNGOGNBI.endPoint.transform.position + 0.5f * base.transform.up;
			this.dropper.transform.position = position;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Fider;
			this.dropScrpt.drop();
			bool flag = true;
			if (bgjkmcbhnak.PFNCHEEEBKD != null && bgjkmcbhnak.PFNCHEEEBKD.LODGJCMEGAI.IBEIBAHKIAH == 0)
			{
				flag = false;
			}
			if (flag)
			{
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak.CKBGHMMOAEM == null) ? 0L : bgjkmcbhnak.CKBGHMMOAEM.LPFKFNLHGBI);
					epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak.PFNCHEEEBKD == null) ? 0L : bgjkmcbhnak.PFNCHEEEBKD.LPFKFNLHGBI);
					epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(this.dropScrpt.toPos));
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1112, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[2], this.AOEGNGOGNBI.endPoint.transform.position, 0.3f, 3f, 15f, 1f + num2);
			break;
		}
		case 102:
		{
			Vector3 position2 = this.AOEGNGOGNBI.endPoint.transform.position + 0.5f * base.transform.up;
			this.dropper.transform.position = position2;
			this.dropScrpt.fromPos = this.dropper.transform.position;
			this.dropScrpt.KODFBJFCPAJ = PoplDrop.DGLFOLICLDL.Spin;
			this.dropScrpt.drop();
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(SoundSamplesStorage.getI.dropSounds[1], this.AOEGNGOGNBI.endPoint.transform.position, 0.2f, 3f, 15f, 1f + num2);
			break;
		}
		}
		yield break;
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x00194F7D File Offset: 0x0019317D
	private void HJKKPOBKEKC(ONKDCGNBALK ONPHLHKAGFP)
	{
		this.BFJPLGICCNA(false);
		if (this.selectedMIO != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(163, this.selectedMIO.pointId);
		}
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x00194FB0 File Offset: 0x001931B0
	public void instaniateRod(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (this.rodObject != null)
		{
			this.BHMHJBPGOPH = null;
			UnityEngine.Object.Destroy(this.rodObject);
		}
		this.rodObject = IEPBGKCHDJO.OCNGPIEBEIG();
		if (this.rodObject == null)
		{
			return;
		}
		SkinnedMeshRenderer[] componentsInChildren = this.rodObject.GetComponentsInChildren<SkinnedMeshRenderer>();
		if (componentsInChildren != null)
		{
			SkinnedMeshRenderer[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].updateWhenOffscreen = true;
			}
		}
		this.rodObject.transform.position = Vector3.zero;
		this.rodObject.transform.rotation = Quaternion.identity;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
		this.rodObject.transform.rotation = this.rightHandRodPoint.transform.rotation;
		this.rodObject.transform.localScale = new Vector3(1f, 1f, 1f);
		this.rodObject.transform.parent = this.rightHandRodPoint;
		this.rodObject.transform.localRotation = Quaternion.identity;
		this.rodObject.transform.localPosition = Vector3.zero;
		this.AOEGNGOGNBI = this.rodObject.GetComponent<RodParams>();
		this.IBPICCOBEFN = this.rodObject.GetComponent<RodPhysic>();
		if (this.IBPICCOBEFN != null)
		{
			this.IBPICCOBEFN.afterInstanceInit(true, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
		}
		Vector3 b = this.AOEGNGOGNBI.reelPoint.transform.position - this.AOEGNGOGNBI.transform.forward * 0.03f;
		Vector3 b2 = this.rodObject.transform.position - b;
		this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b2;
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(this.currentRod.LJCLFFINEHJ.HHOLFABGDJA), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.instaniateReel), "");
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x00195228 File Offset: 0x00193428
	public Vector3 getFishGettingPosition()
	{
		Vector3 position = base.transform.position;
		Vector3 vector = base.transform.position + BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL * 0.7f * base.transform.forward;
		position.y = LocNewLogic.getI.OGJHINOLHJJ;
		vector.y = LocNewLogic.getI.OGJHINOLHJJ;
		Vector3 b = vector;
		if (this.AOEGNGOGNBI != null)
		{
			Vector3 normalized = (this.AOEGNGOGNBI.ILCJJKCPBKC - this.AOEGNGOGNBI.startPoint.transform.position).normalized;
			b = this.AOEGNGOGNBI.ILCJJKCPBKC + normalized * 1f;
		}
		b.y = LocNewLogic.getI.OGJHINOLHJJ;
		return Vector3.LerpUnclamped(position, b, 1f);
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x00195310 File Offset: 0x00193510
	public void GMBEHOGPEDI(int CMBMMEEBHFA, float GKENCBIOPGO, Vector3 LBGHKIDGKCO)
	{
		if (CMBMMEEBHFA == 0)
		{
			this.action.KGGLGPBAMLN();
		}
		else
		{
			this.action.POABDGOHELO(CMBMMEEBHFA, GKENCBIOPGO);
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 1);
			epmphjgalbe.JFBJCKCHMBC((byte)-113);
			epmphjgalbe.JDOLCNDNFGP(CMBMMEEBHFA);
			epmphjgalbe.HHPABLOHFKL(GKENCBIOPGO);
			epmphjgalbe.PAKIPBGFNKN(new IIBEEKCAAHK(LBGHKIDGKCO));
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(41, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x0018E873 File Offset: 0x0018CA73
	public bool KNMMOLKNLNL()
	{
		return this.POFONDFAJLK;
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00195398 File Offset: 0x00193598
	public void userBragFish(int OLKMHFNLBJB, float NBLJCEHNKAK)
	{
		if (this.bragfish == null)
		{
			this.bragfish = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("FishbragContainer", Vector3.zero, this.leftHandRodPoint);
			if (this.bragfish == null)
			{
				return;
			}
			this.bragfish.transform.parent = this.leftHandRodPoint;
			this.bragfish.transform.localRotation = Quaternion.identity;
			this.bragfish.transform.localScale = new Vector3(1f, 1f, 1f);
			this.bragfish.transform.localPosition = Vector3.zero;
			this.bragfish.GetComponent<BragFish>().fishInstance(OLKMHFNLBJB, NBLJCEHNKAK, true);
			base.StartCoroutine(this.IKNBAFLKELI(4f));
		}
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x00195470 File Offset: 0x00193670
	public void FHFBFHGCNCK(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.JLLELCEFEPP())
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 1780f + base.transform.up * 1239f;
		}
		this.toLookCntrl.CLKBNFFJCOC();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 1336f, base.transform.position.y + 181f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0019552C File Offset: 0x0019372C
	public void CECOEMEOIPD()
	{
		if (this.dropScrpt == null)
		{
			return;
		}
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-189, BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
		if (this.dropScrpt != null)
		{
			ActorMgr.getI.ALJIFBNBHOF(this.dropScrpt.fish.transform.position);
			this.dropScrpt.HOIKDKEJJBP();
			this.dropScrpt = null;
		}
		this.NHINOHIFABB(true);
		this.isPodsek = false;
		this.isFishGet = false;
		this.rotTimeToOldNpr = 317f;
		if (this.podsakObject != null)
		{
			DitherShower component = this.podsakObject.GetComponent<DitherShower>();
			if (component != null)
			{
				component.dirVector = -1;
				component.scaleAlfaKF = 1311f;
			}
		}
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x0018BD94 File Offset: 0x00189F94
	public void NLLFPLBFFAE()
	{
		this.toLookCntrl.FBFAJEGEIKM();
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x0018CB20 File Offset: 0x0018AD20
	public RodParams EACGPPOMFLH()
	{
		return BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI;
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x001955F8 File Offset: 0x001937F8
	public void podsakEvnt(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			Debug.Log("openPodsak");
			Transform transform = this.leftHandPodsakPoint;
			this.podsakObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.podsak4User, transform.position, transform.rotation);
			this.podsakObject.transform.parent = transform;
			this.podsakObject.transform.localPosition = Vector3.zero;
			this.podsakObject.transform.localRotation = Quaternion.identity;
			this.podsakObject.transform.localScale = new Vector3(1f, 1f, 1f);
			this.podsakPoint = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(this.podsakObject, "toFishPoint");
			this.podsakInWater = false;
		}
		if (CLBPBJGLHEE < 0)
		{
			Debug.Log("closePodsak");
			if (this.podsakObject != null)
			{
				UnityEngine.Object.Destroy(this.podsakObject, 1f);
			}
			this.podsakObject = null;
			this.podsakPoint = null;
			this.podsakInWater = false;
		}
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x00195700 File Offset: 0x00193900
	private void PPIJKKNAJAC()
	{
		bool flag = true;
		if (this.dropScrpt != null && this.dropScrpt.IEHNDPMDMOI)
		{
			flag = false;
		}
		if (flag)
		{
			this.upRodState = Mathf.Lerp(this.upRodState, this.GNAOLNLJEHH, Time.deltaTime * 1890f);
		}
		this.AHKJFHALEGH();
		if (this.aimIK)
		{
			this.aimIK.solver.FANPFKHEDPA();
		}
		if (this.rightHandObj)
		{
			this.rightHandObj.SetActive(this.MFENINHGBHM & HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			if (this.ragula != null)
			{
				this.rightHandObj.SetActive(true);
			}
			if (!this.EACGPPOMFLH())
			{
				this.rightHandObj.SetActive(true);
			}
		}
		bool flag2 = true;
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.GECLKEEGJGA() && this.dropScrpt != null && this.dropScrpt.mode >= 0)
		{
			flag2 = true;
		}
		if (this.bipIK.solver.MJOPIBNHGIK().target == null)
		{
			flag2 = true;
		}
		if (flag2)
		{
			this.rightHandCntrl.KOGNBODACLD();
			this.bipIK.solver.MJOPIBNHGIK().positionWeight = this.rightHandCntrl.NKHBAJKMAGD;
			this.bipIK.solver.rightHandEffector.rotationWeight = this.rightHandCntrl.NKHBAJKMAGD;
		}
		else
		{
			this.rightHandCntrl.ELIADAIGHGB();
			this.bipIK.solver.MJOPIBNHGIK().target = null;
			this.bipIK.solver.MJOPIBNHGIK().positionWeight = 594f;
			this.bipIK.solver.rightHandEffector.rotationWeight = 788f;
		}
		if (this.rollPenPointObject != null)
		{
			this.bipIK.solver.leftHandEffector.target = this.rollPenPointHandObject.transform;
			this.bipIK.solver.KIGACGJAJKO().positionWeight = this.leftHandCntrl.NKHBAJKMAGD;
			this.bipIK.solver.leftHandEffector.rotationWeight = this.leftHandCntrl.NKHBAJKMAGD;
			return;
		}
		this.bipIK.solver.KIGACGJAJKO().target = null;
		this.bipIK.solver.KIGACGJAJKO().positionWeight = 52f;
		this.bipIK.solver.CMKJIGNKIMG().rotationWeight = 1452f;
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x0019598C File Offset: 0x00193B8C
	public void HPHLCLODPHN(Vector3 EDGHDMMAJGD)
	{
		if (this.rotTimeToOldNpr > 1973f)
		{
			return;
		}
		Vector3 forward = EDGHDMMAJGD;
		forward.y = 330f;
		forward.Normalize();
		Quaternion rotation = Quaternion.LookRotation(forward, Vector3.up);
		base.transform.rotation = rotation;
	}

	// Token: 0x060034F7 RID: 13559 RVA: 0x00195A0C File Offset: 0x00193C0C
	public void NHINOHIFABB(bool DCCPCBLODIG)
	{
		bool cdnabihplhm = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = DCCPCBLODIG;
		if (cdnabihplhm != BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM)
		{
			this.DIABHIBCKIA();
		}
	}

	// Token: 0x060034F8 RID: 13560 RVA: 0x001916CA File Offset: 0x0018F8CA
	public void BPNKFEBFOBC()
	{
		this.podsakInWater = true;
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x00195B80 File Offset: 0x00193D80
	public void JHOKIGHFGKK()
	{
		this.toLookCntrl.IHIFALBJLAK();
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x00195B90 File Offset: 0x00193D90
	public void DEDKPAIPGAC()
	{
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		FBFJFAKAGJG.IKGFHGKKCPG.JHJHHBLGMPJ(SoundSamplesStorage.getI.dropSounds[4], this.leftHandRodPoint.transform.position, 1916f, 765f, 265f, 58f);
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x0019199F File Offset: 0x0018FB9F
	public void APJCDDIDKID(RollParams DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB = DCCPCBLODIG;
	}

	// Token: 0x060034FE RID: 13566 RVA: 0x0018BE60 File Offset: 0x0018A060
	private void FCMABFFDJLC()
	{
		this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		Fisherman.getI = this;
	}

	// Token: 0x060034FF RID: 13567 RVA: 0x00195BE4 File Offset: 0x00193DE4
	public void LNBFBHABIAC()
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			byte bjppebpndnj = 1;
			switch (this.usermode)
			{
			case Fisherman.NHOCKOJNFFJ.Stay:
				bjppebpndnj = 1;
				break;
			case Fisherman.NHOCKOJNFFJ.Fishing:
				bjppebpndnj = 1;
				break;
			case Fisherman.NHOCKOJNFFJ.FishOnRod:
				bjppebpndnj = 8;
				break;
			case Fisherman.NHOCKOJNFFJ.FishGet:
				bjppebpndnj = 4;
				break;
			}
			this.PGBAKHHHFIL(epmphjgalbe, 1);
			epmphjgalbe.BLCJKEJDGBI(bjppebpndnj);
			epmphjgalbe.EAOGDKDBENC(ObscuredInt.DGOCFCFPKPI(this.keyCount));
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-76, epmphjgalbe.IEJLLFECFHF());
			this.HLCIJLIJECO = Time.time;
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		this.keyCount = ObscuredInt.JNKANIEBCMD(1);
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x00195C8C File Offset: 0x00193E8C
	public void EDCNMAAMCAB(EKBAPCMPANI HHAHKJPGOLK)
	{
		Debug.Log("Idle 180");
		if (HHAHKJPGOLK != null)
		{
			Debug.Log("SneakIdle" + HHAHKJPGOLK.LPFKFNLHGBI);
			if (HHAHKJPGOLK.LPFKFNLHGBI != this.petWpnId && this.petObject != null)
			{
				UnityEngine.Object.Destroy(this.petObject.gameObject);
			}
			Vector3 vector = base.transform.position;
			vector += base.transform.right * 1067f;
			GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().LMFEHHFPAAA("cntx_rem", vector, null);
			this.petObject = gameObject.GetComponent<PetPlayer>();
			this.petWpnId = HHAHKJPGOLK.LPFKFNLHGBI;
			return;
		}
		if (this.petObject != null)
		{
			UnityEngine.Object.Destroy(this.petObject.gameObject);
		}
		this.petObject = null;
		this.petWpnId = 0L;
	}

	// Token: 0x06003501 RID: 13569 RVA: 0x00195D70 File Offset: 0x00193F70
	private bool JLLLDCBHKOB(Vector3 ANHPFIEFBEP)
	{
		bool result = true;
		Ray ray = new Ray(base.transform.position + Vector3.up, ANHPFIEFBEP + Vector3.down * 689f);
		Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 373f);
		RaycastHit raycastHit;
		if (Physics.Raycast(ray, out raycastHit, 442f, this.clickLayerCollision))
		{
			if (raycastHit.collider.gameObject.tag == "CATRigR")
			{
				result = true;
			}
			if (Mathf.Abs(base.transform.position.y - raycastHit.point.y) > 1195f)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06003502 RID: 13570 RVA: 0x00195E34 File Offset: 0x00194034
	public void instFChair()
	{
		string hojhbmnihba = "fchair";
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 10);
		if (ekbapcmpani != null)
		{
			hojhbmnihba = "fchair_" + ekbapcmpani.BDHHPAEHFHG.MIMANMPNLPE.IBEIBAHKIAH;
		}
		Vector3 position = base.transform.position;
		this.fchair = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, position, null);
		this.fchair.transform.rotation = base.transform.rotation;
		this.fchair.transform.parent = base.transform;
		this.instChairTime = Time.time;
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x00195ED4 File Offset: 0x001940D4
	public void CMPGNJMNFJF(Transform NCADHGFGICO)
	{
		if (this.AOEGNGOGNBI == null)
		{
			return;
		}
		if (NCADHGFGICO == null)
		{
			this.EACGPPOMFLH().EIANPDPMNKJ(700f);
			this.AOEGNGOGNBI.target = Vector3.zero;
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.AOEGNGOGNBI != null)
		{
			ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ);
			this.rodforce = ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.GIMFIFECPGL) / 872f;
			this.EACGPPOMFLH().target = NCADHGFGICO.position;
			Vector3 from = this.AOEGNGOGNBI.transform.forward * this.EACGPPOMFLH().actualRodLength;
			Vector3 to = this.AOEGNGOGNBI.ILCJJKCPBKC - NCADHGFGICO.position;
			float num = Mathf.Abs(Mathf.Sin(Vector3.Angle(from, to) * 699f / 1768f));
			this.rodforce *= num;
			float num2 = 1389f;
			if (this.CDNABIHPLHM & this.isPodsek)
			{
				num2 = 1799f;
			}
			this.EACGPPOMFLH().FDLCJBFDIEM(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GIMFIFECPGL) * num2 + LocNewLogic.getI.ICDLJOAIOHG());
		}
	}

	// Token: 0x06003504 RID: 13572 RVA: 0x00191798 File Offset: 0x0018F998
	public void ILOALJHMKND()
	{
		if (this.bragfish != null)
		{
			UnityEngine.Object.Destroy(this.bragfish.gameObject);
		}
		this.bragfish = null;
	}

	// Token: 0x06003505 RID: 13573 RVA: 0x00196020 File Offset: 0x00194220
	public void klevAction(HBPNMNGOFMA KADBECGIMPD)
	{
		if (!this.CIHILMCEJND)
		{
			return;
		}
		KADBECGIMPD.HDBGOLAFOBK();
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak != null)
		{
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.GOOIABGKMHK((float)KADBECGIMPD.HDBGOLAFOBK());
			bgjkmcbhnak.CFOFDKKFJMJ = KADBECGIMPD.BFPHBMDMODH();
			bgjkmcbhnak.FLHJLFHELPE = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.FFDPCEAFGNF());
			bgjkmcbhnak.JDIBHEGKALB = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.FFDPCEAFGNF());
			bgjkmcbhnak.EFLIAAIOPPI = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.FFDPCEAFGNF());
			float num = KADBECGIMPD.FFDPCEAFGNF();
			num *= OLPINJLCKCI.IKGFHGKKCPG.ANBMFGAFDNP(15f);
			bgjkmcbhnak.PGEDLDMLBBE = ObscuredFloat.GOOIABGKMHK(num);
			bgjkmcbhnak.HFPNHGGIKHP = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.FFDPCEAFGNF());
			bgjkmcbhnak.NENOBDLCFHO = ObscuredInt.GOOIABGKMHK(KADBECGIMPD.HDBGOLAFOBK());
			bgjkmcbhnak.NBLJCEHNKAK = ObscuredFloat.GOOIABGKMHK(KADBECGIMPD.FFDPCEAFGNF());
			bgjkmcbhnak.HPMPDNLHCKM = KADBECGIMPD.DNIIFBAIPBE();
			bgjkmcbhnak.BCKECOENDLB = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(bgjkmcbhnak.HPMPDNLHCKM);
			bgjkmcbhnak.PLIPAKGHPBE = bgjkmcbhnak.EFLIAAIOPPI;
			float lknfodkoped = -1f;
			if (bgjkmcbhnak.BCKECOENDLB != null)
			{
				IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.BLJKHILCCDL(bgjkmcbhnak.BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
				if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) < iibeekcaahk.JLLJFKOGLHJ)
				{
					lknfodkoped = (iibeekcaahk.JLLJFKOGLHJ - ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD)) * (1f + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.FLHJLFHELPE) / 100f) / (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) + 0.1f) * 20f;
				}
			}
			bool flag = OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(lknfodkoped);
			if (flag)
			{
				Debug.Log("isDrop action");
			}
			switch (bgjkmcbhnak.DFBHMIIPLCA)
			{
			case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
				if (bgjkmcbhnak.PFNCHEEEBKD != null)
				{
					if (!flag)
					{
						if (bgjkmcbhnak.PFNCHEEEBKD.BBLEPPMMPIL("wpn_add/addoptions", "signal_enable").KPAFFJNBLHK && this.CIHILMCEJND)
						{
							base.StartCoroutine(this.HHHANGAKMLD());
						}
					}
					else if (this.dropScrpt != null)
					{
						this.dropScrpt.poplavokDown(0.15f);
					}
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Spinning:
				flag = true;
				this.dropScrpt.klevActivate();
				if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) > 0f)
				{
					bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE), 0f, 30f));
					bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL), 0f, 30f));
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(50f * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1000f));
					bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(50f * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 1000f));
				}
				break;
			case BOIKJDICEMF.JGHABIPEEEO.Fider:
			{
				float num2 = 1000f * (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ + bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ) / 2f;
				if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) > 0f)
				{
					bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / (num2 + 0.1f));
					bgjkmcbhnak.EALPPCJHPKG = bgjkmcbhnak.GIMGAKKKHLF;
					if (this.dropScrpt != null)
					{
						this.dropScrpt.fiderDerg(0, 0f, !flag);
						FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("fider_Empty.ogg", BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, 0.7f, 3f, 50f);
					}
				}
				break;
			}
			}
			if (this.dropScrpt != null && !flag)
			{
				this.dropScrpt.klevActivate();
			}
		}
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x00196410 File Offset: 0x00194610
	public void LGAHCAIKGHN(Vector3 NHCLMBOINFG)
	{
		if (!this.toLookCntrl.DEJEHLBBLKM())
		{
			this.FMEPCINEDCP.transform.position = base.transform.position + base.transform.forward * 1664f + base.transform.up * 444f;
		}
		this.toLookCntrl.GKOMLFLLOMI();
		NHCLMBOINFG.y = Mathf.Clamp(NHCLMBOINFG.y, base.transform.position.y + 923f, base.transform.position.y + 437f);
		this.toLookPoint = NHCLMBOINFG;
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x001964CC File Offset: 0x001946CC
	public void KIKOECFMIAE()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(59, 0);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			this.IKFAJMDKABN(epmphjgalbe, 0);
			epmphjgalbe.MKCKDEDCMOB((byte)-10);
			epmphjgalbe.PJIABBIPPNH(this.isWoman);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-108, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06003508 RID: 13576 RVA: 0x0019653C File Offset: 0x0019473C
	public void getFifhEvent()
	{
		if (this.dropScrpt == null)
		{
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1130, BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
		if (this.dropScrpt != null)
		{
			ActorMgr.getI.getFishEffectOn(this.dropScrpt.fish.transform.position);
			this.dropScrpt.kill();
			this.dropScrpt = null;
		}
		this.CDNABIHPLHM = false;
		this.isPodsek = false;
		this.isFishGet = false;
		this.rotTimeToOldNpr = 1f;
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

	// Token: 0x06003509 RID: 13577 RVA: 0x00196608 File Offset: 0x00194808
	public void DBLCKAODMMH()
	{
		if (this.rollPenPointObject != null)
		{
			if (this.NKFFPKCLFEI() != null)
			{
				this.rollPenPointObject.SetActive(false);
				this.rollPenPointObject.transform.position = this.ILAOBMPAEJN().handPoint.transform.position;
				return;
			}
			this.rollPenPointObject.SetActive(false);
		}
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x00190DD1 File Offset: 0x0018EFD1
	private IEnumerator HOAIOHIALKB()
	{
		for (;;)
		{
			if (LocNewLogic.getI != null && base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ - 0.05f)
			{
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CFHNNNLDBBE = true;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
					epmphjgalbe.GOMLLPFFPNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
			this.sendToServerUserStates();
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x0600350B RID: 13579 RVA: 0x00196670 File Offset: 0x00194870
	public void APAPJMNFCPP(bool DCCPCBLODIG)
	{
		bool aeepmbepgik = this.AEEPMBEPGIK;
		if (DCCPCBLODIG && this.CMCPFNJIIHK)
		{
			DCCPCBLODIG = false;
		}
		this.AEEPMBEPGIK = DCCPCBLODIG;
		if (this.AEEPMBEPGIK != aeepmbepgik)
		{
			this.sendMoveAction();
		}
		if (this.AEEPMBEPGIK)
		{
			this.action.BDJMANBIIEG();
			if (this.toAObject != null)
			{
				this.OKDAILHCEOH(this.toAObject.transform.position);
				return;
			}
			this.NLLFPLBFFAE();
		}
	}

	// Token: 0x0600350C RID: 13580 RVA: 0x001966E6 File Offset: 0x001948E6
	private IEnumerator HBOCPMFNDGD()
	{
		yield return new WaitForSeconds(3f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(905, 0);
		yield break;
	}

	// Token: 0x0600350D RID: 13581 RVA: 0x001966F0 File Offset: 0x001948F0
	public void OGCMDKDPPDE(int KDMGMLJJALK)
	{
		Debug.Log("CrouchWalkBackward");
		if (this.ragula != null)
		{
			this.rodObject.transform.position = this.rightHandRodPoint.transform.position;
			this.rodObject.transform.parent = this.rightHandRodPoint.transform;
			this.rodObject.transform.localPosition = Vector3.zero;
			this.rodObject.transform.localRotation = Quaternion.identity;
			this.rodObject.transform.localScale = new Vector3(680f, 624f, 646f);
			Vector3 b = this.rodObject.transform.position - this.IJMGCKIOBPP().handPoint.transform.position;
			this.rodObject.transform.position = this.rightHandRodPoint.transform.position + b;
			if (this.bubenec != null)
			{
				UnityEngine.Object.Destroy(this.bubenec.gameObject);
			}
			UnityEngine.Object.Destroy(this.ragula.gameObject, 155f);
			this.ragula = null;
			this.bubenec = null;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP = true;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(1217f);
			BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().AAINFMALAEN(ObscuredFloat.GOOIABGKMHK(1381f));
			if (this.AEMBDHALFNG())
			{
				this.podsek();
			}
		}
		else
		{
			GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().LMFEHHFPAAA("inv_useeff", base.transform.position + base.transform.forward * 1004f, null);
			gameObject.transform.rotation = base.transform.rotation;
			this.ragula = gameObject.GetComponent<Ragula>();
			if (this.ragula != null)
			{
				this.rodObject.transform.position = this.ragula.rodPoint.transform.position;
				this.rodObject.transform.parent = this.ragula.rodPoint.transform;
				this.rodObject.transform.localPosition = Vector3.zero;
				this.rodObject.transform.localRotation = Quaternion.identity;
				this.rodObject.transform.localScale = new Vector3(210f, 1429f, 1524f);
				if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.bellPoint != null)
				{
					this.bubenec = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("X (R)", BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.bellPoint.transform.position, null);
				}
			}
			BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NHNHBLLLGDP = false;
			BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(553f);
			BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GIMGAKKKHLF = ObscuredFloat.HLEMAJBAAEO(501f);
		}
		this.DIABHIBCKIA();
	}

	// Token: 0x0600350E RID: 13582 RVA: 0x00196A18 File Offset: 0x00194C18
	public void IHBGNKLLAHM()
	{
		this.NEFHFADILLJ(false);
		this.isBreak = false;
		this.NLLFPLBFFAE();
		this.leftHandCntrl.HLCDBEBAODP();
		this.rightHandCntrl.BBDBAFHBDCJ();
		this.aimCntrl.PKHHNGLGJKA();
		this.toLookCntrl.IEOOGCCBEEO();
		if (this.dropScrpt != null)
		{
			this.dropScrpt.kill();
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		if (this.BHMHJBPGOPH != null)
		{
			UnityEngine.Object.Destroy(this.BHMHJBPGOPH);
		}
		if (this.rodObject != null)
		{
			UnityEngine.Object.Destroy(this.rodObject);
		}
		if (this.bubenec != null)
		{
			UnityEngine.Object.Destroy(this.bubenec.gameObject);
		}
		if (this.ragula != null)
		{
			UnityEngine.Object.Destroy(this.ragula.gameObject);
		}
		LocNewLogic.getI.AHNFPBKGDPA(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
	}

	// Token: 0x0600350F RID: 13583 RVA: 0x0018CB45 File Offset: 0x0018AD45
	public Vector3 LFCLAFABKKE()
	{
		return this.LALPBFALKFL;
	}

	// Token: 0x06003510 RID: 13584 RVA: 0x0018E8B2 File Offset: 0x0018CAB2
	public bool EAIHPIBLAAL()
	{
		return this.MFMJCAJKKJK;
	}

	// Token: 0x06003511 RID: 13585 RVA: 0x00196B0C File Offset: 0x00194D0C
	public void GACMMMGCLNC(EKBAPCMPANI HHAHKJPGOLK)
	{
		Debug.Log("Speed hack Detected!");
		if (HHAHKJPGOLK != null)
		{
			Debug.Log("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()" + HHAHKJPGOLK.LPFKFNLHGBI);
			if (HHAHKJPGOLK.LPFKFNLHGBI != this.petWpnId && this.petObject != null)
			{
				UnityEngine.Object.Destroy(this.petObject.gameObject);
			}
			Vector3 vector = base.transform.position;
			vector += base.transform.right * 1532f;
			GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().JOFAKNGHIAD("{not_found}", vector, null);
			this.petObject = gameObject.GetComponent<PetPlayer>();
			this.petWpnId = HHAHKJPGOLK.LPFKFNLHGBI;
			return;
		}
		if (this.petObject != null)
		{
			UnityEngine.Object.Destroy(this.petObject.gameObject);
		}
		this.petObject = null;
		this.petWpnId = 0L;
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x00196BF0 File Offset: 0x00194DF0
	public void spawnPet(EKBAPCMPANI HHAHKJPGOLK)
	{
		Debug.Log("spawnPet");
		if (HHAHKJPGOLK != null)
		{
			Debug.Log("spawnPet id=" + HHAHKJPGOLK.LPFKFNLHGBI);
			if (HHAHKJPGOLK.LPFKFNLHGBI != this.petWpnId && this.petObject != null)
			{
				UnityEngine.Object.Destroy(this.petObject.gameObject);
			}
			Vector3 vector = base.transform.position;
			vector += base.transform.right * 0.5f;
			GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("PlayerPet", vector, null);
			this.petObject = gameObject.GetComponent<PetPlayer>();
			this.petWpnId = HHAHKJPGOLK.LPFKFNLHGBI;
			return;
		}
		if (this.petObject != null)
		{
			UnityEngine.Object.Destroy(this.petObject.gameObject);
		}
		this.petObject = null;
		this.petWpnId = 0L;
	}

	// Token: 0x06003513 RID: 13587 RVA: 0x00196CD4 File Offset: 0x00194ED4
	private void GMKGLKKHGED()
	{
		if (this.leftHandRodPoint)
		{
			this.leftHandPointFxd = this.leftHandRodPoint.transform.position;
		}
		if (this.dropScrpt != null)
		{
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.dropScrpt.mode >= 2)
			{
				this.aimCntrl.GOODCGGGNGN();
			}
		}
		else
		{
			this.aimCntrl.PKHHNGLGJKA();
		}
		if (LocNewLogic.getI != null)
		{
			if (LocNewLogic.getI.FGGGOAHFNCD())
			{
				float num = 1519f;
				if (Input.GetKey((KeyCode)(-78)))
				{
					num = 31f;
				}
				this.KPKANMFPIKG += Time.fixedDeltaTime * num;
			}
			if (this.GECLKEEGJGA())
			{
				this.GNAOLNLJEHH = (536f - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().LGALGHAPJND) / 1465f;
			}
		}
		if (this.EACGPPOMFLH() != null)
		{
			if (this.AOEGNGOGNBI.reelPoint != null && this.NKFFPKCLFEI() != null)
			{
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NHNHBLLLGDP)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 1653f;
				}
				if (this.podsakObject != null)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 1210f;
				}
				if (this.isFishGet)
				{
					this.leftHandCntrl.NKHBAJKMAGD = 1572f;
				}
				if (!this.GECLKEEGJGA())
				{
					this.leftHandCntrl.NKHBAJKMAGD = 1367f;
				}
			}
		}
		else
		{
			this.leftHandCntrl.NKHBAJKMAGD = 148f;
			this.bipIK.solver.EMPOFCMIGLD().target = null;
		}
		if (this.KPIPJGKANCD() && this.fchair != null)
		{
			float num2 = this.bipIK.solver.rootNode.transform.position.y - 396f;
			if (Time.time - this.instChairTime < 1793f && this.fchair.transform.position.y + 1234f > num2)
			{
				Vector3 position = this.fchair.transform.position;
				position.y = num2 - 1906f;
				this.fchair.transform.position = position;
			}
		}
	}

	// Token: 0x06003514 RID: 13588 RVA: 0x00196F24 File Offset: 0x00195124
	public void StandEvent()
	{
		this.standFlag = true;
		this.CDNABIHPLHM = false;
		this.isPodsek = false;
		this.PodsekType = 0;
		if (this.dropScrpt != null)
		{
			this.dropScrpt.kill();
		}
	}

	// Token: 0x06003515 RID: 13589 RVA: 0x00196F5C File Offset: 0x0019515C
	public void DOOBKPGJNEN(bool DCCPCBLODIG)
	{
		if (FlyMessageManager.getI.checkFlyIcon(102))
		{
			DCCPCBLODIG = false;
		}
		bool mfmjcajkkjk = this.MFMJCAJKKJK;
		this.MFMJCAJKKJK = DCCPCBLODIG;
		if (this.MFMJCAJKKJK != mfmjcajkkjk)
		{
			this.FCMIGOFMGCE();
		}
		if (this.MFMJCAJKKJK)
		{
			this.toLookCntrl.KCMDIKFODAH();
		}
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x0019199F File Offset: 0x0018FB9F
	public void FCOADHOOLKK(RollParams DCCPCBLODIG)
	{
		BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB = DCCPCBLODIG;
	}

	// Token: 0x06003517 RID: 13591 RVA: 0x00194511 File Offset: 0x00192711
	private IEnumerator GAHOEFFNDJM()
	{
		if (this.dropScrpt != null)
		{
			yield return new WaitForSeconds(1f);
			Vector3 position = this.dropScrpt.transform.position;
			position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.1f;
			AudioClip dnibjblmpgf = SoundSamplesStorage.getI.poplSounds[HPGKIJLKCIH.IKGFHGKKCPG.AKMFIGPGLAN];
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(dnibjblmpgf, position, HPGKIJLKCIH.IKGFHGKKCPG.IIOAIIDINJJ, 5f, 50f, 1f + (HPGKIJLKCIH.IKGFHGKKCPG.JEPEGBFGPID - 0.5f) * 0.3f);
		}
		yield break;
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06003519 RID: 13593 RVA: 0x00196FAC File Offset: 0x001951AC
	public bool DJPEBFMNLIC
	{
		get
		{
			return !(this.dropScrpt == null) && !(this.dropScrpt.fish == null) && !ObscuredBool.GOOIABGKMHK(this.dropScrpt.fish.isGetFromWater) && ObscuredBool.GOOIABGKMHK(this.dropScrpt.fish.isPodsek);
		}
	}

	// Token: 0x0600351A RID: 13594 RVA: 0x0018BC7D File Offset: 0x00189E7D
	public void DropPointerEvnt()
	{
		base.StartCoroutine(this.MFDEGBDIFCD());
	}

	// Token: 0x0600351B RID: 13595 RVA: 0x0019700C File Offset: 0x0019520C
	public void podsek()
	{
		this.blendRodDirection = 0f;
		this.usermode = Fisherman.NHOCKOJNFFJ.FishOnRod;
		if (this.dropScrpt != null)
		{
			this.dropScrpt.podsekAction();
		}
		this.isBigFish = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PIJNKIOJEJF;
		this.sendFishingAction();
		base.StartCoroutine(this.ENCNPGBKMGP());
		Debug.Log("podsek action!");
	}

	// Token: 0x0600351C RID: 13596 RVA: 0x0018C23C File Offset: 0x0018A43C
	public bool LGKJDDPLOKE()
	{
		return this.KIMMNMDIBLF;
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x00197078 File Offset: 0x00195278
	public void DMNHLPJIPLK()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		this.KANMIKKAPDI = base.transform.forward * 1107f;
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.aimCntrl.PKHHNGLGJKA();
			return;
		}
		Transform transform = Camera.main.transform;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			transform = base.transform;
		}
		float d = this.upRodState;
		this.KANMIKKAPDI = transform.forward * 955f + transform.up * 523f * this.aimConst.z;
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			float num = 1419f * (Input.mousePosition.y - (float)Screen.height / 51f) / (float)Screen.height;
			this.KANMIKKAPDI.y = this.KANMIKKAPDI.y + num * 293f;
			this.KANMIKKAPDI += this.blendRodDirection * transform.right * 1767f * 825f * this.aimConst.x;
		}
		if (this.rodObject != null && this.dropScrpt != null)
		{
			Vector3 vector = (this.EACGPPOMFLH().ILCJJKCPBKC - this.dropScrpt.transform.position).normalized;
			float t = Mathf.Abs(this.blendRodDirection);
			vector = Vector3.Lerp(Vector3.up, vector, t);
			this.KANMIKKAPDI += vector * d * 1233f * this.aimConst.y;
			return;
		}
		this.KANMIKKAPDI += transform.up * this.upRodState * 242f * this.aimConst.y;
	}

	// Token: 0x0600351E RID: 13598 RVA: 0x0019728C File Offset: 0x0019548C
	private IEnumerator BABKHEEOLDD(float FGNPJLIPNFM)
	{
		Fisherman.ODNAFLFNJHG odnaflfnjhg = new Fisherman.ODNAFLFNJHG(1);
		odnaflfnjhg.AENJLLPLILM = this;
		odnaflfnjhg.FGNPJLIPNFM = FGNPJLIPNFM;
		return odnaflfnjhg;
	}

	// Token: 0x0600351F RID: 13599 RVA: 0x00191798 File Offset: 0x0018F998
	public void DHGPCNGEHKI()
	{
		if (this.bragfish != null)
		{
			UnityEngine.Object.Destroy(this.bragfish.gameObject);
		}
		this.bragfish = null;
	}

	// Token: 0x06003520 RID: 13600 RVA: 0x001972A4 File Offset: 0x001954A4
	private void LateUpdate()
	{
		bool flag = true;
		if (this.dropScrpt != null && this.dropScrpt.IEHNDPMDMOI)
		{
			flag = false;
		}
		if (flag)
		{
			this.upRodState = Mathf.Lerp(this.upRodState, this.GNAOLNLJEHH, Time.deltaTime * 5f);
		}
		this.AimIKUpdateProcess();
		if (this.aimIK)
		{
			this.aimIK.solver.FANPFKHEDPA();
		}
		if (this.rightHandObj)
		{
			this.rightHandObj.SetActive(this.MFENINHGBHM & HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			if (this.ragula != null)
			{
				this.rightHandObj.SetActive(false);
			}
			if (!this.AOEGNGOGNBI)
			{
				this.rightHandObj.SetActive(false);
			}
		}
		bool flag2 = false;
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.CIHILMCEJND && this.dropScrpt != null && this.dropScrpt.mode >= 2)
		{
			flag2 = true;
		}
		if (this.bipIK.solver.rightHandEffector.target == null)
		{
			flag2 = false;
		}
		if (flag2)
		{
			this.rightHandCntrl.FPIDHIOGEAM();
			this.bipIK.solver.rightHandEffector.positionWeight = this.rightHandCntrl.NKHBAJKMAGD;
			this.bipIK.solver.rightHandEffector.rotationWeight = this.rightHandCntrl.NKHBAJKMAGD;
		}
		else
		{
			this.rightHandCntrl.FBFAJEGEIKM();
			this.bipIK.solver.rightHandEffector.target = null;
			this.bipIK.solver.rightHandEffector.positionWeight = 0f;
			this.bipIK.solver.rightHandEffector.rotationWeight = 0f;
		}
		if (this.rollPenPointObject != null)
		{
			this.bipIK.solver.leftHandEffector.target = this.rollPenPointHandObject.transform;
			this.bipIK.solver.leftHandEffector.positionWeight = this.leftHandCntrl.NKHBAJKMAGD;
			this.bipIK.solver.leftHandEffector.rotationWeight = this.leftHandCntrl.NKHBAJKMAGD;
			return;
		}
		this.bipIK.solver.leftHandEffector.target = null;
		this.bipIK.solver.leftHandEffector.positionWeight = 0f;
		this.bipIK.solver.leftHandEffector.rotationWeight = 0f;
	}

	// Token: 0x06003521 RID: 13601 RVA: 0x0018BC7D File Offset: 0x00189E7D
	public void MJJGABENDAB()
	{
		base.StartCoroutine(this.MFDEGBDIFCD());
	}

	// Token: 0x06003522 RID: 13602 RVA: 0x00191798 File Offset: 0x0018F998
	public void endBrag()
	{
		if (this.bragfish != null)
		{
			UnityEngine.Object.Destroy(this.bragfish.gameObject);
		}
		this.bragfish = null;
	}

	// Token: 0x0400078D RID: 1933
	public static Fisherman getI;

	// Token: 0x0400078E RID: 1934
	public Transform rightHandFishingPoint;

	// Token: 0x0400078F RID: 1935
	public bool isRodMoveState;

	// Token: 0x04000790 RID: 1936
	public AimIK aimIK;

	// Token: 0x04000791 RID: 1937
	public Vector4 aimConst;

	// Token: 0x04000792 RID: 1938
	public bool useAIM = true;

	// Token: 0x04000793 RID: 1939
	public WCGenerator generator;

	// Token: 0x04000794 RID: 1940
	public GameObject rollPenPointObject;

	// Token: 0x04000795 RID: 1941
	public GameObject rollPenPointHandObject;

	// Token: 0x04000796 RID: 1942
	public Vector3 rollHandSm = Vector3.zero;

	// Token: 0x04000797 RID: 1943
	public GameObject wCircler;

	// Token: 0x04000798 RID: 1944
	public Transform chairPoint;

	// Token: 0x04000799 RID: 1945
	public Ragula ragula;

	// Token: 0x0400079A RID: 1946
	public GameObject bubenec;

	// Token: 0x0400079B RID: 1947
	private InteractionSystem NKKKJBOMCID;

	// Token: 0x0400079C RID: 1948
	public GameObject rightHandPrfb;

	// Token: 0x0400079D RID: 1949
	public GameObject rightHandObj;

	// Token: 0x0400079E RID: 1950
	public GameObject fonar;

	// Token: 0x0400079F RID: 1951
	public MessageCloud msgCloud;

	// Token: 0x040007A0 RID: 1952
	public Canvas nameCanvas;

	// Token: 0x040007A1 RID: 1953
	public const byte _NET_State_StayMove = 1;

	// Token: 0x040007A2 RID: 1954
	public const byte _NET_State_Fishing = 2;

	// Token: 0x040007A3 RID: 1955
	public const byte _NET_State_FishOnRod = 3;

	// Token: 0x040007A4 RID: 1956
	public const byte _NET_State_FishGet = 4;

	// Token: 0x040007A5 RID: 1957
	public const byte _NET_Action_UserSpawn = 101;

	// Token: 0x040007A6 RID: 1958
	public const byte _NET_Action_UserOut = 102;

	// Token: 0x040007A7 RID: 1959
	public const byte _NET_Action_UserMove = 103;

	// Token: 0x040007A8 RID: 1960
	public const byte _NET_Action_StopMove = 104;

	// Token: 0x040007A9 RID: 1961
	public const byte _NET_Action_BreakRod = 107;

	// Token: 0x040007AA RID: 1962
	public const byte _NET_Action_BreakLine = 108;

	// Token: 0x040007AB RID: 1963
	public const byte _NET_Action_Fishing = 109;

	// Token: 0x040007AC RID: 1964
	public const byte _NET_Action_getFish = 110;

	// Token: 0x040007AD RID: 1965
	public const byte _NET_Action_getFishBig = 111;

	// Token: 0x040007AE RID: 1966
	public const byte _NET_Action_harvest = 112;

	// Token: 0x040007AF RID: 1967
	public const byte _NET_Action_Other = 114;

	// Token: 0x040007B0 RID: 1968
	public LayerMask clickLayerCollision;

	// Token: 0x040007B1 RID: 1969
	public LayerMask moveLayerCollision;

	// Token: 0x040007B2 RID: 1970
	public const float mrotSmoothing = 10f;

	// Token: 0x040007B3 RID: 1971
	public const float minDistance = 0.2f;

	// Token: 0x040007B4 RID: 1972
	public GameObject fchair;

	// Token: 0x040007B5 RID: 1973
	public float blendRodDirection;

	// Token: 0x040007B6 RID: 1974
	public float upRodState;

	// Token: 0x040007B7 RID: 1975
	public float rodforce;

	// Token: 0x040007B8 RID: 1976
	public Fisherman.NHOCKOJNFFJ usermode;

	// Token: 0x040007B9 RID: 1977
	public bool standFlag = true;

	// Token: 0x040007BA RID: 1978
	public ObscuredInt keyCount = ObscuredInt.GOOIABGKMHK(0);

	// Token: 0x040007BB RID: 1979
	public bool isSitEnable;

	// Token: 0x040007BC RID: 1980
	private bool ADFNLBBFLKK;

	// Token: 0x040007BD RID: 1981
	public bool isWoman;

	// Token: 0x040007BE RID: 1982
	public bool isBigFish;

	// Token: 0x040007BF RID: 1983
	public int DropType;

	// Token: 0x040007C0 RID: 1984
	public int PodsekType;

	// Token: 0x040007C1 RID: 1985
	public bool isPodsek;

	// Token: 0x040007C2 RID: 1986
	public bool isKeyPress;

	// Token: 0x040007C3 RID: 1987
	public bool isFishGet;

	// Token: 0x040007C4 RID: 1988
	public bool isBreak;

	// Token: 0x040007C5 RID: 1989
	public Vector3 leftHandPointFxd;

	// Token: 0x040007C6 RID: 1990
	public Transform rightHandRodPoint;

	// Token: 0x040007C7 RID: 1991
	public Transform leftHandRodPoint;

	// Token: 0x040007C8 RID: 1992
	public Transform leftHandPodsakPoint;

	// Token: 0x040007C9 RID: 1993
	public Transform leftHandRollPoint;

	// Token: 0x040007CA RID: 1994
	public Transform camPoint;

	// Token: 0x040007CB RID: 1995
	public Transform eyeCamPoint;

	// Token: 0x040007CC RID: 1996
	public GameObject dropper;

	// Token: 0x040007CD RID: 1997
	public PoplDrop dropScrpt;

	// Token: 0x040007CE RID: 1998
	public Animator anm;

	// Token: 0x040007CF RID: 1999
	public InteractionObject leftHandInteractionObject;

	// Token: 0x040007D0 RID: 2000
	public FullBodyBipedEffector leftHandEffector;

	// Token: 0x040007D1 RID: 2001
	public FullBodyBipedIK bipIK;

	// Token: 0x040007D2 RID: 2002
	public LookAtIK lookIK;

	// Token: 0x040007D3 RID: 2003
	public BOIKJDICEMF.BGJKMCBHNAK currentRod;

	// Token: 0x040007D4 RID: 2004
	public GameObject fishRod;

	// Token: 0x040007D5 RID: 2005
	public Character character;

	// Token: 0x040007D6 RID: 2006
	public Vector3 cursorPoint = Vector3.zero;

	// Token: 0x040007D7 RID: 2007
	public GameObject rodObject;

	// Token: 0x040007D8 RID: 2008
	private GameObject BHMHJBPGOPH;

	// Token: 0x040007D9 RID: 2009
	private GameObject IEKIGMBAGIL;

	// Token: 0x040007DA RID: 2010
	public readonly INHGGGPJEAL.MDLFOFLAIJK aimCntrl = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040007DB RID: 2011
	public readonly INHGGGPJEAL.MDLFOFLAIJK toLookCntrl = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040007DC RID: 2012
	public readonly INHGGGPJEAL.MDLFOFLAIJK leftHandCntrl = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040007DD RID: 2013
	public readonly INHGGGPJEAL.MDLFOFLAIJK rightHandCntrl = new INHGGGPJEAL.MDLFOFLAIJK();

	// Token: 0x040007DE RID: 2014
	public INHGGGPJEAL.PLCPMBBKHAI sitCntrl = new INHGGGPJEAL.PLCPMBBKHAI(3, 1f);

	// Token: 0x040007DF RID: 2015
	public INHGGGPJEAL.PLCPMBBKHAI getBragCntrl = new INHGGGPJEAL.PLCPMBBKHAI(5, 1f);

	// Token: 0x040007E0 RID: 2016
	public INHGGGPJEAL.PLCPMBBKHAI moveCntrl = new INHGGGPJEAL.PLCPMBBKHAI(4, 3f);

	// Token: 0x040007E1 RID: 2017
	public INHGGGPJEAL.FMOJFAJDDEH action = new INHGGGPJEAL.FMOJFAJDDEH("action");

	// Token: 0x040007E2 RID: 2018
	private INHGGGPJEAL.DKEIJBMMKCG JOBKCNGCBAN = new INHGGGPJEAL.DKEIJBMMKCG("isDropPrikorm", 300L);

	// Token: 0x040007E3 RID: 2019
	private GameObject FMEPCINEDCP;

	// Token: 0x040007E4 RID: 2020
	public Vector3 toLookPoint;

	// Token: 0x040007E5 RID: 2021
	public Vector3 rightVectorMove;

	// Token: 0x040007E6 RID: 2022
	public Vector3 frwrdVectorMove;

	// Token: 0x040007E7 RID: 2023
	public ActiveObject toAObject;

	// Token: 0x040007E8 RID: 2024
	public CharacterController cc;

	// Token: 0x040007E9 RID: 2025
	public GrounderFBBIK grndFBIK;

	// Token: 0x040007EA RID: 2026
	public PetPlayer petObject;

	// Token: 0x040007EB RID: 2027
	public long petWpnId;

	// Token: 0x040007EC RID: 2028
	private const float HLPIPOHCLME = 1.5f;

	// Token: 0x040007ED RID: 2029
	private bool KIMMNMDIBLF;

	// Token: 0x040007EE RID: 2030
	private Vector3 KANMIKKAPDI = Vector3.zero;

	// Token: 0x040007EF RID: 2031
	public float instChairTime;

	// Token: 0x040007F0 RID: 2032
	private bool AEEPMBEPGIK;

	// Token: 0x040007F1 RID: 2033
	private bool MFMJCAJKKJK;

	// Token: 0x040007F2 RID: 2034
	private Vector3 LALPBFALKFL;

	// Token: 0x040007F3 RID: 2035
	private const float KGCLBOELKIL = 1f;

	// Token: 0x040007F4 RID: 2036
	private float BFOIGHICKNN;

	// Token: 0x040007F5 RID: 2037
	private float CDNBMOANJCH;

	// Token: 0x040007F6 RID: 2038
	private float HLCIJLIJECO;

	// Token: 0x040007F7 RID: 2039
	private bool HDLHCMOPIKM;

	// Token: 0x040007F8 RID: 2040
	public Vector3 toOldLookForward;

	// Token: 0x040007F9 RID: 2041
	public Vector3 toOldLookCamFrwd;

	// Token: 0x040007FA RID: 2042
	public float rotTimeToOldNpr = -1f;

	// Token: 0x040007FB RID: 2043
	private bool POFONDFAJLK;

	// Token: 0x040007FC RID: 2044
	public GameObject podsakObject;

	// Token: 0x040007FD RID: 2045
	public GameObject podsakPoint;

	// Token: 0x040007FE RID: 2046
	public bool podsakInWater;

	// Token: 0x040007FF RID: 2047
	private const float MIANFJMKFDD = 100f;

	// Token: 0x04000800 RID: 2048
	private const float FFKIDBLJHKA = 350f;

	// Token: 0x04000801 RID: 2049
	private float LDAJPLCGEHC;

	// Token: 0x04000802 RID: 2050
	public MMOItemObject selectedMIO;

	// Token: 0x04000803 RID: 2051
	private float KPKANMFPIKG;

	// Token: 0x04000804 RID: 2052
	private float GNAOLNLJEHH;

	// Token: 0x04000805 RID: 2053
	public GameObject bragfish;

	// Token: 0x04000806 RID: 2054
	private const float AOJHMEIGBPD = 5f;

	// Token: 0x02000110 RID: 272
	public enum NHOCKOJNFFJ
	{
		// Token: 0x04000808 RID: 2056
		Stay,
		// Token: 0x04000809 RID: 2057
		Fishing,
		// Token: 0x0400080A RID: 2058
		FishOnRod,
		// Token: 0x0400080B RID: 2059
		FishGet
	}
}
