using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001D8 RID: 472
public class ActorMgr : MonoBehaviour
{
	// Token: 0x06006C9E RID: 27806 RVA: 0x00334248 File Offset: 0x00332448
	public void AELJCLIIFEA()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x003342B0 File Offset: 0x003324B0
	public Actor EJAJIJICIGD(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x0033430A File Offset: 0x0033250A
	private void INFMFACEMJE(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("fishFACTROR=" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x00334330 File Offset: 0x00332530
	public void DKLHDKINMDF(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.KKOKFLMMAAK();
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			bool flag = KADBECGIMPD.MJAHKNLFNCE() == 0;
			KADBECGIMPD.GCOIAONEBME();
			bool isMoving = KADBECGIMPD.KJIOFDCKIKO();
			Vector3 nhclmboinfg = KADBECGIMPD.FCLPDDODOJP().OHIPPMOMNDB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.JEHOEBJMMOI().OHIPPMOMNDB();
			Vector3 toMovePoint = KADBECGIMPD.IBKINJMMFFI().FBLEDBJGDBD();
			if (num != JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.BANHHNFNNGC(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "Mesh" + this.chanellId;
		}
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x00334484 File Offset: 0x00332684
	public void KMLBFNIKAGJ(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.ENNFDOAEBFB(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CA3 RID: 27811 RVA: 0x003344BC File Offset: 0x003326BC
	public void BOAKABGLBFB(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.ENNFDOAEBFB(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CA4 RID: 27812 RVA: 0x003344F4 File Offset: 0x003326F4
	public void DACILCBDKMK(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("", idchhhedhdc.EMDPDLPDLOJ(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.ENFLCHGAJKK(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(1, edaphmjenpk);
		}
		Actor actor = this.BFEFOAKHHIF(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(0, edaphmjenpk);
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor EFAIOHNMPGM(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x0033459C File Offset: 0x0033279C
	public float FOKDOIDPKEI(Vector3 NHCLMBOINFG)
	{
		float num = 802f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x00334620 File Offset: 0x00332820
	public Actor BANHHNFNNGC(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CA8 RID: 27816 RVA: 0x0033467A File Offset: 0x0033287A
	public void getFishEffectOn(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 1f);
	}

	// Token: 0x06006CA9 RID: 27817 RVA: 0x003346A8 File Offset: 0x003328A8
	public void CGNBAMEFOEJ(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.AOMGDMELKAF();
		Vector3 vector = KADBECGIMPD.JEHOEBJMMOI().OHIPPMOMNDB();
		Vector3 vector2 = KADBECGIMPD.DAKECHGPCFI().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.KJIOFDCKIKO();
		Vector3 toMovePoint = KADBECGIMPD.JIFFKNJHLCM().FBLEDBJGDBD();
		bool isRun = KADBECGIMPD.DADCGPGEHFK();
		float moveSpeed = KADBECGIMPD.DNGDPHIHLBG();
		bool dccpcblodig = KADBECGIMPD.ELDBJFLCMAJ();
		KADBECGIMPD.AOMGDMELKAF();
		KADBECGIMPD.GCOIAONEBME();
		KADBECGIMPD.CANHAOJOLPO();
		byte b = KADBECGIMPD.IGKNGPBJFEA();
		if (num == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1837f;
			return;
		}
		Actor actor = this.EFAIOHNMPGM(num);
		if ((int)b == -53)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.LAECLJFMGPE();
				actor = this.BANHHNFNNGC(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 105:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 106:
			if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 306f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(false);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 107:
		case 108:
		case 109:
		case 110:
		case 111:
		case 114:
		case 116:
			break;
		case 112:
			actor.dropType = (int)KADBECGIMPD.CANHAOJOLPO();
			actor.rodType = KADBECGIMPD.LDLKLPJBIJN();
			actor.DLPLGAEAGPC(KADBECGIMPD.KJIOFDCKIKO());
			actor.CIHILMCEJND = KADBECGIMPD.BLNIHNKJJPJ();
			actor.isFishOnRod = KADBECGIMPD.AJECAOJPOKA();
			actor.toDropPoint = KADBECGIMPD.JIFFKNJHLCM().FPLDMBJEFEB();
			actor.blendRodDirection = KADBECGIMPD.AILCEJFAMGN();
			actor.rodforce = KADBECGIMPD.MOBPFEEAMKD();
			actor.upRodState = KADBECGIMPD.FFDPCEAFGNF();
			actor.isRagulaSet = KADBECGIMPD.IJJDHHFAIPE();
			actor.ragulaPosition = KADBECGIMPD.ANALPOIJPHJ().FPLDMBJEFEB();
			actor.ragulaRotation = KADBECGIMPD.JPHHGPIDDOA().FPLDMBJEFEB();
			return;
		case 113:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.HMCONBPNFJH().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.NMMCKDBOJDO().FPLDMBJEFEB();
			int olkmhfnlbjb = KADBECGIMPD.HDBGOLAFOBK();
			float nbljcehnkak = KADBECGIMPD.FFDPCEAFGNF();
			float bpjcikfgomm = KADBECGIMPD.FFDPCEAFGNF();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 115:
			actor.isHarvest = KADBECGIMPD.KJIOFDCKIKO();
			return;
		case 117:
		{
			int num2 = KADBECGIMPD.AGNKAFLKCAG();
			float gkencbiopgo = KADBECGIMPD.MOBPFEEAMKD();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.IBKINJMMFFI();
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				actor.toRotation = iibeekcaahk.MCPNAMDKJOH();
			}
			if (num2 == 0)
			{
				actor.action.FHOIBLBFMGB();
				return;
			}
			actor.action.FPIDHIOGEAM(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CAA RID: 27818 RVA: 0x003349F8 File Offset: 0x00332BF8
	public void DGMNBADMIMC(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NENOBDLCFHO);
		string edaphmjenpk = string.Format("_OcclusionTexture", idchhhedhdc.IGFJGAGBDJM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.JOOIFNDAKBI(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.GAFDPAJBACL(1, edaphmjenpk);
		}
		Actor actor = this.getActor(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.BHOFFBCAGOF(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(0, edaphmjenpk);
	}

	// Token: 0x06006CAB RID: 27819 RVA: 0x00334A84 File Offset: 0x00332C84
	public Actor GLBDNCFBJDN(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x00334AE0 File Offset: 0x00332CE0
	public void CKOJAEOJFDP(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.IBKCNEICPEL();
		Actor actor = this.ENNFDOAEBFB(gdmojdpammn);
		if (actor != null)
		{
			actor.BEJAPCFKFMK(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006CAD RID: 27821 RVA: 0x00334B54 File Offset: 0x00332D54
	public void GMIJKIHBPNF(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.ENNFDOAEBFB(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CAE RID: 27822 RVA: 0x00334B8C File Offset: 0x00332D8C
	public void BAMEKJOMOKE()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CAF RID: 27823 RVA: 0x00334BF4 File Offset: 0x00332DF4
	public void COOFIMOOGFH(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.NEBIOFHEDJL(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(7, DOACMCPELGJ);
	}

	// Token: 0x06006CB0 RID: 27824 RVA: 0x00334C1B File Offset: 0x00332E1B
	private void DJJGIGKAHCI(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("_camHue" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CB1 RID: 27825 RVA: 0x00334C3E File Offset: 0x00332E3E
	private void PKHBGOPCNIL(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("wpn_book1" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CB2 RID: 27826 RVA: 0x00334C64 File Offset: 0x00332E64
	public float AOLPKHLEJFP(Vector3 NHCLMBOINFG)
	{
		float num = 1765f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CB3 RID: 27827 RVA: 0x00334CE8 File Offset: 0x00332EE8
	public void ALJIFBNBHOF(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 1900f);
	}

	// Token: 0x06006CB4 RID: 27828 RVA: 0x00334D18 File Offset: 0x00332F18
	public float HCFNLGLNCFH(Vector3 NHCLMBOINFG)
	{
		float num = 1462f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CB5 RID: 27829 RVA: 0x00334D9C File Offset: 0x00332F9C
	public void OJFJJNNJMAD(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.LBNJNLAIDLL(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(0, DOACMCPELGJ);
	}

	// Token: 0x06006CB6 RID: 27830 RVA: 0x00334DC3 File Offset: 0x00332FC3
	private void JKFMBDPNDKM(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("MotorbikeIdle" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CB7 RID: 27831 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor NEBIOFHEDJL(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006CB8 RID: 27832 RVA: 0x00334DE8 File Offset: 0x00332FE8
	public void fishMsg(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.getActor(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(3, DOACMCPELGJ);
	}

	// Token: 0x06006CB9 RID: 27833 RVA: 0x00334E10 File Offset: 0x00333010
	public void GCGJCJOBDDC(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NENOBDLCFHO);
		string edaphmjenpk = string.Format("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", idchhhedhdc.LEFACDMODLM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.ENFLCHGAJKK(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.GAFDPAJBACL(1, edaphmjenpk);
		}
		Actor actor = this.KLBJCCEOEDJ(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(0, edaphmjenpk);
	}

	// Token: 0x06006CBA RID: 27834 RVA: 0x00334E99 File Offset: 0x00333099
	public void GPOLDFDLJJK(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 781f);
	}

	// Token: 0x06006CBB RID: 27835 RVA: 0x00334EC8 File Offset: 0x003330C8
	public Actor FJPIBBEBGEE(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CBC RID: 27836 RVA: 0x00334F24 File Offset: 0x00333124
	public void DGABGBLDOLK(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.KKOKFLMMAAK();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			bool flag = KADBECGIMPD.AOMGDMELKAF() == 1;
			KADBECGIMPD.CANHAOJOLPO();
			bool isMoving = KADBECGIMPD.DADCGPGEHFK();
			Vector3 nhclmboinfg = KADBECGIMPD.JEHOEBJMMOI().GEJNEDNGJDD();
			Vector3 lnhaojnpgdl = KADBECGIMPD.DAKECHGPCFI().GEJNEDNGJDD();
			Vector3 toMovePoint = KADBECGIMPD.OFGFAEJNKEH().GEJNEDNGJDD();
			if (num != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.instaniateActor(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "auk_data/categories/category" + this.chanellId;
		}
	}

	// Token: 0x06006CBD RID: 27837 RVA: 0x00335078 File Offset: 0x00333278
	private void HJHINLHHMNB()
	{
		SceneManager.sceneLoaded += this.LAGEBOAGEEL;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CBE RID: 27838 RVA: 0x003350B8 File Offset: 0x003332B8
	public void CNNKDBGDBNF(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.HFOPFEJDJFG();
		Actor actor = this.BFEFOAKHHIF(gdmojdpammn);
		if (actor != null)
		{
			actor.DLIJELLCOBI(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006CBF RID: 27839 RVA: 0x0033512C File Offset: 0x0033332C
	public void KCBLMOKBDMC(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.CANHAOJOLPO();
		Vector3 vector = KADBECGIMPD.IBKINJMMFFI().OHIPPMOMNDB();
		Vector3 vector2 = KADBECGIMPD.ANALPOIJPHJ().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.DADCGPGEHFK();
		Vector3 toMovePoint = KADBECGIMPD.ANALPOIJPHJ().GEJNEDNGJDD();
		bool isRun = KADBECGIMPD.IJJDHHFAIPE();
		float moveSpeed = KADBECGIMPD.AILCEJFAMGN();
		bool isSit = KADBECGIMPD.BLNIHNKJJPJ();
		KADBECGIMPD.DHBEGKENIPN();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.AOMGDMELKAF();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1347f;
			return;
		}
		Actor actor = this.BFEFOAKHHIF(num);
		if (b == 110)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.LAECLJFMGPE();
				actor = this.FJPIBBEBGEE(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.CMCPFNJIIHK = isSit;
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.ACLKIDEDENO())
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 120:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 121:
			if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1668f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(false);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 122:
		case 123:
		case 124:
		case 125:
		case 126:
		case 129:
		case 131:
			break;
		case 127:
			actor.dropType = (int)KADBECGIMPD.CMLECABALBC();
			actor.rodType = KADBECGIMPD.IFDFHJLCHAE();
			actor.DLPLGAEAGPC(KADBECGIMPD.IOEEPNCKLJD());
			actor.CIHILMCEJND = KADBECGIMPD.JNOKJCDAPPA();
			actor.isFishOnRod = KADBECGIMPD.BEMFIFGOJBL();
			actor.toDropPoint = KADBECGIMPD.ANALPOIJPHJ().MCPNAMDKJOH();
			actor.blendRodDirection = KADBECGIMPD.DNGDPHIHLBG();
			actor.rodforce = KADBECGIMPD.DNGDPHIHLBG();
			actor.upRodState = KADBECGIMPD.BNDHIBEOKML();
			actor.isRagulaSet = KADBECGIMPD.JALHMJEKMHF();
			actor.ragulaPosition = KADBECGIMPD.LIPFLAGOOML().GEJNEDNGJDD();
			actor.ragulaRotation = KADBECGIMPD.DAKECHGPCFI().OHIPPMOMNDB();
			return;
		case 128:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.LIPFLAGOOML().GEJNEDNGJDD();
			Vector3 phkiohibnpa = KADBECGIMPD.ANALPOIJPHJ().FBLEDBJGDBD();
			int olkmhfnlbjb = KADBECGIMPD.AGNKAFLKCAG();
			float nbljcehnkak = KADBECGIMPD.AIDAGFNHNHE();
			float bpjcikfgomm = KADBECGIMPD.AILCEJFAMGN();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 130:
			actor.isHarvest = KADBECGIMPD.JALHMJEKMHF();
			return;
		case 132:
		{
			int num2 = KADBECGIMPD.KDNDJNEGBDI();
			float gkencbiopgo = KADBECGIMPD.ECJLJGDNFMN();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.OFGFAEJNKEH();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.OHIPPMOMNDB();
			}
			if (num2 == 0)
			{
				actor.action.MJKMNBLFEGP();
				return;
			}
			actor.action.JBCGPOPIICO(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CC0 RID: 27840 RVA: 0x0033547C File Offset: 0x0033367C
	public float PIFKJPHIGKG(Vector3 NHCLMBOINFG)
	{
		float num = 1506f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CC1 RID: 27841 RVA: 0x00335500 File Offset: 0x00333700
	public void EKDIDIGNCHD(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.KLBJCCEOEDJ(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x00335536 File Offset: 0x00333736
	private void Awake()
	{
		SceneManager.sceneLoaded += this.EAJDJFDJNAF;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x00335574 File Offset: 0x00333774
	public void AFJHKLJMKHA(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.HFOPFEJDJFG();
		KADBECGIMPD.KDELAFDDGJH();
		int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
		int num = KADBECGIMPD.HHLDBAEFNMJ();
		int nkhbajkmagd = KADBECGIMPD.KDNDJNEGBDI();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg2 = "OpenSadok";
		if (num == 0)
		{
			arg2 = "WallRunLeft";
		}
		if (num == 1)
		{
			arg2 = "";
		}
		if (num == 8)
		{
			arg2 = "-STRIKETHROUGH";
		}
		string edaphmjenpk = string.Format("_ReflectionTexture0", arg, arg2);
		Actor actor = this.KKEKHADMNMC(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(2, edaphmjenpk);
	}

	// Token: 0x06006CC4 RID: 27844 RVA: 0x0033560E File Offset: 0x0033380E
	public void MIKOGLFHFAK(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 194f);
	}

	// Token: 0x06006CC5 RID: 27845 RVA: 0x0033563C File Offset: 0x0033383C
	public void GNMFLCCJOJH(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format(" x", idchhhedhdc.PIFLJJBAEOA(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(0, edaphmjenpk);
		}
		Actor actor = this.EFAIOHNMPGM(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.BHOFFBCAGOF(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(1, edaphmjenpk);
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x003356C5 File Offset: 0x003338C5
	public void EEAGFBIPGIH(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 159f);
	}

	// Token: 0x06006CC7 RID: 27847 RVA: 0x003356F4 File Offset: 0x003338F4
	public void actorBrag(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NENOBDLCFHO);
		string edaphmjenpk = string.Format("{0}", idchhhedhdc.KGBHELBLPMF(BPJCIKFGOMM, DBEIGNDALDC, true));
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.onChatMessage(1, edaphmjenpk);
		}
		Actor actor = this.getActor(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(1, edaphmjenpk);
	}

	// Token: 0x06006CC8 RID: 27848 RVA: 0x0033577D File Offset: 0x0033397D
	private void JMNLEBAPHNJ()
	{
		SceneManager.sceneLoaded += this.MAOLDPPNIKE;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CC9 RID: 27849 RVA: 0x003357BC File Offset: 0x003339BC
	public void AOADNIIKAAD(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("WindZone", idchhhedhdc.FFAFKPDHOIN(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.JOOIFNDAKBI(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.GAFDPAJBACL(0, edaphmjenpk);
		}
		Actor actor = this.EFAIOHNMPGM(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(1, edaphmjenpk);
	}

	// Token: 0x06006CCA RID: 27850 RVA: 0x00335848 File Offset: 0x00333A48
	public float JGCGOLONDFK(Vector3 NHCLMBOINFG)
	{
		float num = 1764f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.IDGLBENDHEM())
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CCB RID: 27851 RVA: 0x003358CC File Offset: 0x00333ACC
	private void MBDOEDLGJGF()
	{
		SceneManager.sceneLoaded += this.DEABLAPHPLP;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x0033590C File Offset: 0x00333B0C
	public void DJJLKPKMEED(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.KLHDFFHONON();
		Actor actor = this.ENNFDOAEBFB(gdmojdpammn);
		if (actor != null)
		{
			actor.DLIJELLCOBI(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006CCE RID: 27854 RVA: 0x00335993 File Offset: 0x00333B93
	private void MAOLDPPNIKE(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("Loot" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CCF RID: 27855 RVA: 0x003359B8 File Offset: 0x00333BB8
	public void actionProcessor(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.CMLECABALBC();
		Vector3 vector = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
		Vector3 vector2 = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
		bool isMoving = KADBECGIMPD.FIFNOBGEKFF();
		Vector3 toMovePoint = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
		bool isRun = KADBECGIMPD.FIFNOBGEKFF();
		float moveSpeed = KADBECGIMPD.FFDPCEAFGNF();
		bool isSit = KADBECGIMPD.FIFNOBGEKFF();
		KADBECGIMPD.CMLECABALBC();
		KADBECGIMPD.CMLECABALBC();
		KADBECGIMPD.CMLECABALBC();
		byte b = KADBECGIMPD.CMLECABALBC();
		if (num == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 2f;
			return;
		}
		Actor actor = this.getActor(num);
		if (b == 101)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.FIFNOBGEKFF();
				actor = this.instaniateActor(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.CMCPFNJIIHK = isSit;
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 102:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 103:
			if (num == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 2f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = false;
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 104:
		case 105:
		case 106:
		case 107:
		case 108:
		case 111:
		case 113:
			break;
		case 109:
			actor.dropType = (int)KADBECGIMPD.CMLECABALBC();
			actor.rodType = KADBECGIMPD.HDBGOLAFOBK();
			actor.MFENINHGBHM = KADBECGIMPD.FIFNOBGEKFF();
			actor.CIHILMCEJND = KADBECGIMPD.FIFNOBGEKFF();
			actor.isFishOnRod = KADBECGIMPD.FIFNOBGEKFF();
			actor.toDropPoint = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			actor.blendRodDirection = KADBECGIMPD.FFDPCEAFGNF();
			actor.rodforce = KADBECGIMPD.FFDPCEAFGNF();
			actor.upRodState = KADBECGIMPD.FFDPCEAFGNF();
			actor.isRagulaSet = KADBECGIMPD.FIFNOBGEKFF();
			actor.ragulaPosition = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			actor.ragulaRotation = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			return;
		case 110:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			int olkmhfnlbjb = KADBECGIMPD.HDBGOLAFOBK();
			float nbljcehnkak = KADBECGIMPD.FFDPCEAFGNF();
			float bpjcikfgomm = KADBECGIMPD.FFDPCEAFGNF();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 112:
			actor.isHarvest = KADBECGIMPD.FIFNOBGEKFF();
			return;
		case 114:
		{
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			float gkencbiopgo = KADBECGIMPD.FFDPCEAFGNF();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.EIMAIEJKHKF();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.FBFAJEGEIKM();
				return;
			}
			actor.action.FPIDHIOGEAM(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CD0 RID: 27856 RVA: 0x00335D08 File Offset: 0x00333F08
	public void OHDDAGJOCMN(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.KKEKHADMNMC(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CD1 RID: 27857 RVA: 0x00335D40 File Offset: 0x00333F40
	public void INHNIDLKLEK()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CD2 RID: 27858 RVA: 0x00335DA8 File Offset: 0x00333FA8
	private void BEDINIEBBIL(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("<color='{0}'>{1}</color>" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CD3 RID: 27859 RVA: 0x00335DCC File Offset: 0x00333FCC
	public void LBANMCMBPNJ(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.DOJKJHMJJNK();
		while (!KADBECGIMPD.BKIBKLFCCGP())
		{
			long num = KADBECGIMPD.ANPEIKGEDHJ();
			bool flag = KADBECGIMPD.IGKNGPBJFEA() == 1;
			KADBECGIMPD.CANHAOJOLPO();
			bool isMoving = KADBECGIMPD.IOEEPNCKLJD();
			Vector3 nhclmboinfg = KADBECGIMPD.EIMAIEJKHKF().GEJNEDNGJDD();
			Vector3 lnhaojnpgdl = KADBECGIMPD.EIMAIEJKHKF().MCPNAMDKJOH();
			Vector3 toMovePoint = KADBECGIMPD.LICHMNLLOAB().GEJNEDNGJDD();
			if (num != JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.DIGGPBLLPGH(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "RenderTextures are not supported on this platform." + this.chanellId;
		}
	}

	// Token: 0x06006CD4 RID: 27860 RVA: 0x00335F20 File Offset: 0x00334120
	public void GPKIBAPGNEJ()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CD5 RID: 27861 RVA: 0x00335F88 File Offset: 0x00334188
	public void MMDEGKPFGKG(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.DOJKJHMJJNK();
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			bool flag = KADBECGIMPD.GGHNGCKMHEN() == 0;
			KADBECGIMPD.MJAHKNLFNCE();
			bool isMoving = KADBECGIMPD.IOEEPNCKLJD();
			Vector3 nhclmboinfg = KADBECGIMPD.DAKECHGPCFI().OHIPPMOMNDB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.LIPFLAGOOML().MCPNAMDKJOH();
			Vector3 toMovePoint = KADBECGIMPD.JIFFKNJHLCM().FBLEDBJGDBD();
			if (num != JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.DIGGPBLLPGH(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "post_7" + this.chanellId;
		}
	}

	// Token: 0x06006CD6 RID: 27862 RVA: 0x003360DC File Offset: 0x003342DC
	private void NOKBLBJFPBC()
	{
		SceneManager.sceneLoaded += this.DLEEPEJAACA;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CD7 RID: 27863 RVA: 0x0033611C File Offset: 0x0033431C
	public Actor instaniateActor(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CD8 RID: 27864 RVA: 0x00336178 File Offset: 0x00334378
	public Actor NPFHMIAAAIC(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CD9 RID: 27865 RVA: 0x003361D2 File Offset: 0x003343D2
	private void OIBFLAPOEFL(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("UserChange" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CDA RID: 27866 RVA: 0x003361F8 File Offset: 0x003343F8
	public void OCIHDGNNGMF(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.BFEFOAKHHIF(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(2, DOACMCPELGJ);
	}

	// Token: 0x06006CDB RID: 27867 RVA: 0x00336220 File Offset: 0x00334420
	public float DKHNHGHLFIO(Vector3 NHCLMBOINFG)
	{
		float num = 456f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006CDC RID: 27868 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor KLBJCCEOEDJ(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006CDD RID: 27869 RVA: 0x003362A4 File Offset: 0x003344A4
	public void BAKKGCEOJIA(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
		int num = KADBECGIMPD.LDLKLPJBIJN();
		int nkhbajkmagd = KADBECGIMPD.HHLDBAEFNMJ();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).IGFJGAGBDJM(nkhbajkmagd, num, false);
		string arg2 = "IdleStand";
		if (num == 0)
		{
			arg2 = "Attempting to set limb orientation to Vector3.zero axis";
		}
		if (num == 1)
		{
			arg2 = "Decal";
		}
		if (num == 8)
		{
			arg2 = "wpn_wgt";
		}
		string edaphmjenpk = string.Format("WorkerShovel2", arg, arg2);
		Actor actor = this.ENNFDOAEBFB(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(8, edaphmjenpk);
	}

	// Token: 0x06006CDE RID: 27870 RVA: 0x00336340 File Offset: 0x00334540
	public void BKCKAGFJIMC()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CDF RID: 27871 RVA: 0x003363A8 File Offset: 0x003345A8
	public void JIDPDJHDHJM(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.ENNFDOAEBFB(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006CE0 RID: 27872 RVA: 0x003363DE File Offset: 0x003345DE
	public void HBACCPIPPIO(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 542f);
	}

	// Token: 0x06006CE1 RID: 27873 RVA: 0x0033640C File Offset: 0x0033460C
	public void CIJBAAFNNCG(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NENOBDLCFHO);
		string edaphmjenpk = string.Format("System.Boolean", idchhhedhdc.IGFJGAGBDJM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.onChatMessage(0, edaphmjenpk);
		}
		Actor actor = this.BFEFOAKHHIF(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(1, edaphmjenpk);
	}

	// Token: 0x06006CE2 RID: 27874 RVA: 0x00336498 File Offset: 0x00334698
	public void LIJEINCMHFG(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.DOJKJHMJJNK();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			bool flag = KADBECGIMPD.CANHAOJOLPO() == 0;
			KADBECGIMPD.IGKNGPBJFEA();
			bool isMoving = KADBECGIMPD.AJECAOJPOKA();
			Vector3 nhclmboinfg = KADBECGIMPD.DAKECHGPCFI().OHIPPMOMNDB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.CMIFMMMBBNO().GEJNEDNGJDD();
			Vector3 toMovePoint = KADBECGIMPD.NMMCKDBOJDO().OHIPPMOMNDB();
			if (num != JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.NPFHMIAAAIC(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):" + this.chanellId;
		}
	}

	// Token: 0x06006CE3 RID: 27875 RVA: 0x003365EC File Offset: 0x003347EC
	public void JDEMAIEJPNA(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("---", idchhhedhdc.IKKHJGAPHAE(BPJCIKFGOMM, DBEIGNDALDC, true));
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.JOOIFNDAKBI(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(0, edaphmjenpk);
		}
		Actor actor = this.KKEKHADMNMC(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.BHOFFBCAGOF(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(0, edaphmjenpk);
	}

	// Token: 0x06006CE4 RID: 27876 RVA: 0x00336678 File Offset: 0x00334878
	public void LAMCMFPFADF()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CE5 RID: 27877 RVA: 0x003366E0 File Offset: 0x003348E0
	public void DKALHNGBCAL(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NENOBDLCFHO);
		string edaphmjenpk = string.Format("Apply RELANG", idchhhedhdc.LEFACDMODLM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.ENFLCHGAJKK(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.onChatMessage(0, edaphmjenpk);
		}
		Actor actor = this.EFAIOHNMPGM(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(1, edaphmjenpk);
	}

	// Token: 0x06006CE6 RID: 27878 RVA: 0x0033676C File Offset: 0x0033496C
	public void AOMBHPDHHEK(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.CLPEKGGAMAI();
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			bool flag = KADBECGIMPD.CMLECABALBC() == 0;
			KADBECGIMPD.NFGIGGIDMFL();
			bool isMoving = KADBECGIMPD.IJJDHHFAIPE();
			Vector3 nhclmboinfg = KADBECGIMPD.HMCONBPNFJH().FPLDMBJEFEB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.JIFFKNJHLCM().GEJNEDNGJDD();
			Vector3 toMovePoint = KADBECGIMPD.BAPGFMDPGKM().GEJNEDNGJDD();
			if (num != JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.DIGGPBLLPGH(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "error.wav" + this.chanellId;
		}
	}

	// Token: 0x06006CE7 RID: 27879 RVA: 0x003368C0 File Offset: 0x00334AC0
	private void PIMDDCCOPIL(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("wpn_add/base" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CE8 RID: 27880 RVA: 0x003368E4 File Offset: 0x00334AE4
	public void DNGIJIDEPLN(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.IJDIMHAEAIE();
		KADBECGIMPD.MJAHKNLFNCE();
		Vector3 vector = KADBECGIMPD.BAPGFMDPGKM().GEJNEDNGJDD();
		Vector3 vector2 = KADBECGIMPD.JIFFKNJHLCM().FBLEDBJGDBD();
		bool isMoving = KADBECGIMPD.JALHMJEKMHF();
		Vector3 toMovePoint = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
		bool isRun = KADBECGIMPD.AJECAOJPOKA();
		float moveSpeed = KADBECGIMPD.BNDHIBEOKML();
		bool dccpcblodig = KADBECGIMPD.LAECLJFMGPE();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.CMLECABALBC();
		KADBECGIMPD.AOMGDMELKAF();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1370f;
			return;
		}
		Actor actor = this.EFAIOHNMPGM(num);
		if ((int)b == -111)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.BEMFIFGOJBL();
				actor = this.GLBDNCFBJDN(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 29:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 30:
			if (num == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 24f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(false);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 38:
		case 40:
			break;
		case 36:
			actor.dropType = (int)KADBECGIMPD.AOMGDMELKAF();
			actor.rodType = KADBECGIMPD.AGNKAFLKCAG();
			actor.DLPLGAEAGPC(KADBECGIMPD.BLNIHNKJJPJ());
			actor.CIHILMCEJND = KADBECGIMPD.JNOKJCDAPPA();
			actor.isFishOnRod = KADBECGIMPD.KJIOFDCKIKO();
			actor.toDropPoint = KADBECGIMPD.ANALPOIJPHJ().MCPNAMDKJOH();
			actor.blendRodDirection = KADBECGIMPD.AIDAGFNHNHE();
			actor.rodforce = KADBECGIMPD.BNDHIBEOKML();
			actor.upRodState = KADBECGIMPD.CGJIINADKNH();
			actor.isRagulaSet = KADBECGIMPD.BEMFIFGOJBL();
			actor.ragulaPosition = KADBECGIMPD.DAKECHGPCFI().FBLEDBJGDBD();
			actor.ragulaRotation = KADBECGIMPD.LICHMNLLOAB().GEJNEDNGJDD();
			return;
		case 37:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.DAKECHGPCFI().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.DAKECHGPCFI().OHIPPMOMNDB();
			int olkmhfnlbjb = KADBECGIMPD.CLPEKGGAMAI();
			float nbljcehnkak = KADBECGIMPD.AILCEJFAMGN();
			float bpjcikfgomm = KADBECGIMPD.CNNEPCOAMJK();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 39:
			actor.isHarvest = KADBECGIMPD.JALHMJEKMHF();
			return;
		case 41:
		{
			int num2 = KADBECGIMPD.KDNDJNEGBDI();
			float gkencbiopgo = KADBECGIMPD.FFDPCEAFGNF();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.NMMCKDBOJDO();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.FBLEDBJGDBD();
			}
			if (num2 == 0)
			{
				actor.action.DFACJCLCHJN();
				return;
			}
			actor.action.DLEGNPOODDC(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CE9 RID: 27881 RVA: 0x00336C34 File Offset: 0x00334E34
	public void BDFMNICJIEG(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DCGEOFHNBCN();
		KADBECGIMPD.CMLECABALBC();
		Vector3 vector = KADBECGIMPD.LIPFLAGOOML().FPLDMBJEFEB();
		Vector3 vector2 = KADBECGIMPD.JEHOEBJMMOI().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.FIFNOBGEKFF();
		Vector3 toMovePoint = KADBECGIMPD.HMCONBPNFJH().OHIPPMOMNDB();
		bool isRun = KADBECGIMPD.DADCGPGEHFK();
		float moveSpeed = KADBECGIMPD.CGJIINADKNH();
		bool isSit = KADBECGIMPD.BEMFIFGOJBL();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.GCOIAONEBME();
		KADBECGIMPD.IGKNGPBJFEA();
		byte b = KADBECGIMPD.GCOIAONEBME();
		if (num == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 957f;
			return;
		}
		Actor actor = this.EFAIOHNMPGM(num);
		if (b == 95)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.IOEEPNCKLJD();
				actor = this.DIGGPBLLPGH(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.CMCPFNJIIHK = isSit;
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 134:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 135:
			if (num == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 684f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = true;
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 136:
		case 137:
		case 138:
		case 139:
		case 140:
		case 143:
		case 145:
			break;
		case 141:
			actor.dropType = (int)KADBECGIMPD.CMLECABALBC();
			actor.rodType = KADBECGIMPD.IFDFHJLCHAE();
			actor.DLPLGAEAGPC(KADBECGIMPD.OMCMPDMJFOJ());
			actor.CIHILMCEJND = KADBECGIMPD.JNOKJCDAPPA();
			actor.isFishOnRod = KADBECGIMPD.DADCGPGEHFK();
			actor.toDropPoint = KADBECGIMPD.OFGFAEJNKEH().OHIPPMOMNDB();
			actor.blendRodDirection = KADBECGIMPD.DNGDPHIHLBG();
			actor.rodforce = KADBECGIMPD.MOBPFEEAMKD();
			actor.upRodState = KADBECGIMPD.FFDPCEAFGNF();
			actor.isRagulaSet = KADBECGIMPD.OMCMPDMJFOJ();
			actor.ragulaPosition = KADBECGIMPD.FCLPDDODOJP().OHIPPMOMNDB();
			actor.ragulaRotation = KADBECGIMPD.OEHCLGOFDPN().OHIPPMOMNDB();
			return;
		case 142:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.IBKINJMMFFI().FBLEDBJGDBD();
			Vector3 phkiohibnpa = KADBECGIMPD.OEHCLGOFDPN().FBLEDBJGDBD();
			int olkmhfnlbjb = KADBECGIMPD.DOJKJHMJJNK();
			float nbljcehnkak = KADBECGIMPD.BNDHIBEOKML();
			float bpjcikfgomm = KADBECGIMPD.BNDHIBEOKML();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 144:
			actor.isHarvest = KADBECGIMPD.OMCMPDMJFOJ();
			return;
		case 146:
		{
			int num2 = KADBECGIMPD.HHLDBAEFNMJ();
			float gkencbiopgo = KADBECGIMPD.BNDHIBEOKML();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.LIPFLAGOOML();
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.FBFAJEGEIKM();
				return;
			}
			actor.action.AFCBDBLDBEJ(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CEA RID: 27882 RVA: 0x00335536 File Offset: 0x00333736
	private void ENJFBODNKHO()
	{
		SceneManager.sceneLoaded += this.EAJDJFDJNAF;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CEB RID: 27883 RVA: 0x00336F84 File Offset: 0x00335184
	public void clearAllActors()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CEC RID: 27884 RVA: 0x00336FEC File Offset: 0x003351EC
	public void MFNKBMBPPBP(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 987f);
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x0033701C File Offset: 0x0033521C
	public void LNPBIODHGKP()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x00337084 File Offset: 0x00335284
	public void IGJKGMHELOJ()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x003370EC File Offset: 0x003352EC
	public Actor DIGGPBLLPGH(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006CF0 RID: 27888 RVA: 0x00337148 File Offset: 0x00335348
	public void PIEFCNOABCE()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006CF1 RID: 27889 RVA: 0x003371B0 File Offset: 0x003353B0
	private void LAGEBOAGEEL(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log(")?" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006CF2 RID: 27890 RVA: 0x003371D4 File Offset: 0x003353D4
	public void FBNAPIKLPED(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.KKEKHADMNMC(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(7, DOACMCPELGJ);
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x003371FC File Offset: 0x003353FC
	public void HNABHKKHJGJ(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.DHBEGKENIPN();
		Vector3 vector = KADBECGIMPD.LIPFLAGOOML().MCPNAMDKJOH();
		Vector3 vector2 = KADBECGIMPD.CMIFMMMBBNO().FBLEDBJGDBD();
		bool isMoving = KADBECGIMPD.IOEEPNCKLJD();
		Vector3 toMovePoint = KADBECGIMPD.CMIFMMMBBNO().OHIPPMOMNDB();
		bool isRun = KADBECGIMPD.AJECAOJPOKA();
		float moveSpeed = KADBECGIMPD.DNGDPHIHLBG();
		bool dccpcblodig = KADBECGIMPD.DADCGPGEHFK();
		KADBECGIMPD.GCOIAONEBME();
		KADBECGIMPD.AOMGDMELKAF();
		KADBECGIMPD.IGKNGPBJFEA();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 590f;
			return;
		}
		Actor actor = this.KKEKHADMNMC(num);
		if (b == 23)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.AJECAOJPOKA();
				actor = this.GLBDNCFBJDN(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.DENJCGAAPGO(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.ACLKIDEDENO())
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 98:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 99:
			if (num == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1114f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(true);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 100:
		case 101:
		case 102:
		case 103:
		case 104:
		case 107:
		case 109:
			break;
		case 105:
			actor.dropType = (int)KADBECGIMPD.GCOIAONEBME();
			actor.rodType = KADBECGIMPD.KDNDJNEGBDI();
			actor.DLPLGAEAGPC(KADBECGIMPD.JALHMJEKMHF());
			actor.CIHILMCEJND = KADBECGIMPD.IJJDHHFAIPE();
			actor.isFishOnRod = KADBECGIMPD.JALHMJEKMHF();
			actor.toDropPoint = KADBECGIMPD.JPHHGPIDDOA().OHIPPMOMNDB();
			actor.blendRodDirection = KADBECGIMPD.MOBPFEEAMKD();
			actor.rodforce = KADBECGIMPD.CGJIINADKNH();
			actor.upRodState = KADBECGIMPD.AILCEJFAMGN();
			actor.isRagulaSet = KADBECGIMPD.FIFNOBGEKFF();
			actor.ragulaPosition = KADBECGIMPD.OFGFAEJNKEH().FBLEDBJGDBD();
			actor.ragulaRotation = KADBECGIMPD.CMIFMMMBBNO().GEJNEDNGJDD();
			return;
		case 106:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.CMIFMMMBBNO().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.CMIFMMMBBNO().GEJNEDNGJDD();
			int olkmhfnlbjb = KADBECGIMPD.KKOKFLMMAAK();
			float nbljcehnkak = KADBECGIMPD.DNGDPHIHLBG();
			float bpjcikfgomm = KADBECGIMPD.AIDAGFNHNHE();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 108:
			actor.isHarvest = KADBECGIMPD.ELDBJFLCMAJ();
			return;
		case 110:
		{
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			float gkencbiopgo = KADBECGIMPD.CNNEPCOAMJK();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.HMCONBPNFJH();
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.FIAKMIFCCLG();
				return;
			}
			actor.action.LKJEBLFDCHG(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor getActor(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006CF5 RID: 27893 RVA: 0x0033754C File Offset: 0x0033574C
	public void IJBJGBBFMAG(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NENOBDLCFHO);
		string edaphmjenpk = string.Format("SoccerKeeperDiveStrafeFarRight", idchhhedhdc.MNMIOMIDKHH(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.ENFLCHGAJKK(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(1, edaphmjenpk);
		}
		Actor actor = this.LBNJNLAIDLL(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(1, edaphmjenpk);
	}

	// Token: 0x06006CF6 RID: 27894 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor ENNFDOAEBFB(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x003375D8 File Offset: 0x003357D8
	public void actorData(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DNIIFBAIPBE();
		Actor actor = this.getActor(gdmojdpammn);
		if (actor != null)
		{
			actor.readActorData(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x0033764C File Offset: 0x0033584C
	public void NMKKGFJJOKG(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.GCOIAONEBME();
		Vector3 vector = KADBECGIMPD.JPHHGPIDDOA().FPLDMBJEFEB();
		Vector3 vector2 = KADBECGIMPD.OFGFAEJNKEH().OHIPPMOMNDB();
		bool isMoving = KADBECGIMPD.AJECAOJPOKA();
		Vector3 toMovePoint = KADBECGIMPD.FCLPDDODOJP().FPLDMBJEFEB();
		bool isRun = KADBECGIMPD.DADCGPGEHFK();
		float moveSpeed = KADBECGIMPD.AIDAGFNHNHE();
		bool dccpcblodig = KADBECGIMPD.IJJDHHFAIPE();
		KADBECGIMPD.CANHAOJOLPO();
		KADBECGIMPD.AOMGDMELKAF();
		KADBECGIMPD.GGHNGCKMHEN();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 246f;
			return;
		}
		Actor actor = this.EFAIOHNMPGM(num);
		if (b == 62)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.OMCMPDMJFOJ();
				actor = this.KIDHCEFGMGM(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LDEIBLFJFFC(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.PKIJJNHMCED())
		{
			actor.isMoving = true;
		}
		switch (b)
		{
		case 225:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 226:
			if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1324f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(true);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 227:
		case 228:
		case 229:
		case 230:
		case 231:
		case 234:
		case 236:
			break;
		case 232:
			actor.dropType = (int)KADBECGIMPD.GGHNGCKMHEN();
			actor.rodType = KADBECGIMPD.IFDFHJLCHAE();
			actor.DLPLGAEAGPC(KADBECGIMPD.IOEEPNCKLJD());
			actor.CIHILMCEJND = KADBECGIMPD.OMCMPDMJFOJ();
			actor.isFishOnRod = KADBECGIMPD.OMCMPDMJFOJ();
			actor.toDropPoint = KADBECGIMPD.CMIFMMMBBNO().MCPNAMDKJOH();
			actor.blendRodDirection = KADBECGIMPD.AILCEJFAMGN();
			actor.rodforce = KADBECGIMPD.DNGDPHIHLBG();
			actor.upRodState = KADBECGIMPD.BIMMPENHGMD();
			actor.isRagulaSet = KADBECGIMPD.DADCGPGEHFK();
			actor.ragulaPosition = KADBECGIMPD.LICHMNLLOAB().FPLDMBJEFEB();
			actor.ragulaRotation = KADBECGIMPD.LICHMNLLOAB().FPLDMBJEFEB();
			return;
		case 233:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.LICHMNLLOAB().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.LIPFLAGOOML().OHIPPMOMNDB();
			int olkmhfnlbjb = KADBECGIMPD.IFDFHJLCHAE();
			float nbljcehnkak = KADBECGIMPD.FFDPCEAFGNF();
			float bpjcikfgomm = KADBECGIMPD.DNGDPHIHLBG();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 235:
			actor.isHarvest = KADBECGIMPD.JNOKJCDAPPA();
			return;
		case 237:
		{
			int num2 = KADBECGIMPD.CLPEKGGAMAI();
			float gkencbiopgo = KADBECGIMPD.ECJLJGDNFMN();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.CMIFMMMBBNO();
			if (!iibeekcaahk.CHOHHHOLIBJ())
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.HMMOJFKGPCH();
				return;
			}
			actor.action.KGNIDNAOOGB(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CF9 RID: 27897 RVA: 0x0033799C File Offset: 0x00335B9C
	public void fishMsgDin(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		int nkhbajkmagd = KADBECGIMPD.HDBGOLAFOBK();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg2 = "#a0a0a0";
		if (num == 0)
		{
			arg2 = "#c0c0c0";
		}
		if (num == 1)
		{
			arg2 = "#b0ffa0";
		}
		if (num == 2)
		{
			arg2 = "#2080ff";
		}
		string edaphmjenpk = string.Format("<color='{1}'>{0}</color>", arg, arg2);
		Actor actor = this.getActor(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(3, edaphmjenpk);
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x00337A38 File Offset: 0x00335C38
	public void FKGLJJJIKFA(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", idchhhedhdc.MNMIOMIDKHH(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.JOOIFNDAKBI(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(0, edaphmjenpk);
		}
		Actor actor = this.getActor(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(1, edaphmjenpk);
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x00337AC4 File Offset: 0x00335CC4
	public void CDGBOEFCJNO(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(NENOBDLCFHO);
		string edaphmjenpk = string.Format("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.", idchhhedhdc.FFAFKPDHOIN(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.ENFLCHGAJKK(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(1, edaphmjenpk);
		}
		Actor actor = this.NEBIOFHEDJL(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(0, edaphmjenpk);
	}

	// Token: 0x06006CFC RID: 27900 RVA: 0x00337B50 File Offset: 0x00335D50
	public void DIINMPELGAB(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.CMLECABALBC();
		Vector3 vector = KADBECGIMPD.OFGFAEJNKEH().GEJNEDNGJDD();
		Vector3 vector2 = KADBECGIMPD.LICHMNLLOAB().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.BEMFIFGOJBL();
		Vector3 toMovePoint = KADBECGIMPD.HMCONBPNFJH().MCPNAMDKJOH();
		bool isRun = KADBECGIMPD.KJIOFDCKIKO();
		float moveSpeed = KADBECGIMPD.DNGDPHIHLBG();
		bool isSit = KADBECGIMPD.JNOKJCDAPPA();
		KADBECGIMPD.DHBEGKENIPN();
		KADBECGIMPD.NFGIGGIDMFL();
		KADBECGIMPD.GGHNGCKMHEN();
		byte b = KADBECGIMPD.GGHNGCKMHEN();
		if (num == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 488f;
			return;
		}
		Actor actor = this.LBNJNLAIDLL(num);
		if ((int)b == -113)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.LAECLJFMGPE();
				actor = this.NPFHMIAAAIC(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.CMCPFNJIIHK = isSit;
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.PKIJJNHMCED())
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 228:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 229:
			if (num == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1600f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = false;
				actor.CIHILMCEJND = true;
				return;
			}
			break;
		case 230:
		case 231:
		case 232:
		case 233:
		case 234:
		case 237:
		case 239:
			break;
		case 235:
			actor.dropType = (int)KADBECGIMPD.GGHNGCKMHEN();
			actor.rodType = KADBECGIMPD.CLPEKGGAMAI();
			actor.DLPLGAEAGPC(KADBECGIMPD.IJJDHHFAIPE());
			actor.CIHILMCEJND = KADBECGIMPD.ELDBJFLCMAJ();
			actor.isFishOnRod = KADBECGIMPD.ELDBJFLCMAJ();
			actor.toDropPoint = KADBECGIMPD.OEHCLGOFDPN().OHIPPMOMNDB();
			actor.blendRodDirection = KADBECGIMPD.MOBPFEEAMKD();
			actor.rodforce = KADBECGIMPD.CGJIINADKNH();
			actor.upRodState = KADBECGIMPD.BIMMPENHGMD();
			actor.isRagulaSet = KADBECGIMPD.ELDBJFLCMAJ();
			actor.ragulaPosition = KADBECGIMPD.CMIFMMMBBNO().FPLDMBJEFEB();
			actor.ragulaRotation = KADBECGIMPD.JPHHGPIDDOA().OHIPPMOMNDB();
			return;
		case 236:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.FCLPDDODOJP().MCPNAMDKJOH();
			Vector3 phkiohibnpa = KADBECGIMPD.NMMCKDBOJDO().FPLDMBJEFEB();
			int olkmhfnlbjb = KADBECGIMPD.HHLDBAEFNMJ();
			float nbljcehnkak = KADBECGIMPD.CGJIINADKNH();
			float bpjcikfgomm = KADBECGIMPD.BNDHIBEOKML();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 238:
			actor.isHarvest = KADBECGIMPD.IJJDHHFAIPE();
			return;
		case 240:
		{
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			float gkencbiopgo = KADBECGIMPD.AIDAGFNHNHE();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.ANALPOIJPHJ();
			if (!iibeekcaahk.CHOHHHOLIBJ())
			{
				actor.toRotation = iibeekcaahk.OHIPPMOMNDB();
			}
			if (num2 == 0)
			{
				actor.action.IHOEEDGGJOC();
				return;
			}
			actor.action.EEFEIGABJLN(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CFD RID: 27901 RVA: 0x0033577D File Offset: 0x0033397D
	private void LNMBLLMCBAB()
	{
		SceneManager.sceneLoaded += this.MAOLDPPNIKE;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x00337EA0 File Offset: 0x003360A0
	public void GDMKHHGPHNC(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.ANPEIKGEDHJ();
		KADBECGIMPD.NFGIGGIDMFL();
		Vector3 vector = KADBECGIMPD.LIPFLAGOOML().FPLDMBJEFEB();
		Vector3 vector2 = KADBECGIMPD.LICHMNLLOAB().FBLEDBJGDBD();
		bool isMoving = KADBECGIMPD.JNOKJCDAPPA();
		Vector3 toMovePoint = KADBECGIMPD.FCLPDDODOJP().GEJNEDNGJDD();
		bool isRun = KADBECGIMPD.KJIOFDCKIKO();
		float moveSpeed = KADBECGIMPD.AIDAGFNHNHE();
		bool dccpcblodig = KADBECGIMPD.OMCMPDMJFOJ();
		KADBECGIMPD.CANHAOJOLPO();
		KADBECGIMPD.GCOIAONEBME();
		KADBECGIMPD.DHBEGKENIPN();
		byte b = KADBECGIMPD.AOMGDMELKAF();
		if (num == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1346f;
			return;
		}
		Actor actor = this.getActor(num);
		if ((int)b == -113)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.BEMFIFGOJBL();
				actor = this.KIDHCEFGMGM(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.DENJCGAAPGO(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = true;
		}
		switch (b)
		{
		case 225:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 226:
			if (num == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 253f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(true);
				actor.CIHILMCEJND = true;
				return;
			}
			break;
		case 227:
		case 228:
		case 229:
		case 230:
		case 231:
		case 234:
		case 236:
			break;
		case 232:
			actor.dropType = (int)KADBECGIMPD.NFGIGGIDMFL();
			actor.rodType = KADBECGIMPD.DOJKJHMJJNK();
			actor.MFENINHGBHM = KADBECGIMPD.AJECAOJPOKA();
			actor.CIHILMCEJND = KADBECGIMPD.JNOKJCDAPPA();
			actor.isFishOnRod = KADBECGIMPD.LAECLJFMGPE();
			actor.toDropPoint = KADBECGIMPD.LIPFLAGOOML().FPLDMBJEFEB();
			actor.blendRodDirection = KADBECGIMPD.ECJLJGDNFMN();
			actor.rodforce = KADBECGIMPD.ECJLJGDNFMN();
			actor.upRodState = KADBECGIMPD.ECJLJGDNFMN();
			actor.isRagulaSet = KADBECGIMPD.DADCGPGEHFK();
			actor.ragulaPosition = KADBECGIMPD.JIFFKNJHLCM().GEJNEDNGJDD();
			actor.ragulaRotation = KADBECGIMPD.EIMAIEJKHKF().MCPNAMDKJOH();
			return;
		case 233:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.DAKECHGPCFI().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.JPHHGPIDDOA().MCPNAMDKJOH();
			int olkmhfnlbjb = KADBECGIMPD.KKOKFLMMAAK();
			float nbljcehnkak = KADBECGIMPD.AIDAGFNHNHE();
			float bpjcikfgomm = KADBECGIMPD.CNNEPCOAMJK();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 235:
			actor.isHarvest = KADBECGIMPD.FIFNOBGEKFF();
			return;
		case 237:
		{
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			float gkencbiopgo = KADBECGIMPD.DNGDPHIHLBG();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.OFGFAEJNKEH();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.GEJNEDNGJDD();
			}
			if (num2 == 0)
			{
				actor.action.NOPKKAOFMJP();
				return;
			}
			actor.action.KGNIDNAOOGB(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006CFF RID: 27903 RVA: 0x003381F0 File Offset: 0x003363F0
	public void JOBKIICOBDJ(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("Can't use reflection here, sorry :(", idchhhedhdc.IGFJGAGBDJM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.GAFDPAJBACL(1, edaphmjenpk);
		}
		Actor actor = this.EFAIOHNMPGM(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.BHOFFBCAGOF(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(1, edaphmjenpk);
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x0033827C File Offset: 0x0033647C
	public void KCHPIOLNNPC(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.EFAIOHNMPGM(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(7, DOACMCPELGJ);
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x003382A4 File Offset: 0x003364A4
	public void chatMsg(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.getActor(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x003382DC File Offset: 0x003364DC
	public void HODLPFHPNAN(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DCGEOFHNBCN();
		Actor actor = this.EFAIOHNMPGM(gdmojdpammn);
		if (actor != null)
		{
			actor.DLIJELLCOBI(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006D03 RID: 27907 RVA: 0x00338350 File Offset: 0x00336550
	public void ILGKHDCPLBC(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.IJDIMHAEAIE();
		KADBECGIMPD.LPKJHMGLCKA();
		int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
		int num = KADBECGIMPD.LDLKLPJBIJN();
		int nkhbajkmagd = KADBECGIMPD.KKOKFLMMAAK();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg2 = "<.*?>";
		if (num == 0)
		{
			arg2 = "perks/perk";
		}
		if (num == 1)
		{
			arg2 = "Water";
		}
		if (num == 2)
		{
			arg2 = "Roar";
		}
		string edaphmjenpk = string.Format("spinKvok activate", arg, arg2);
		Actor actor = this.ENNFDOAEBFB(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(0, edaphmjenpk);
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x003383EC File Offset: 0x003365EC
	public void HDCKENMEOAG(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.getActor(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x00338422 File Offset: 0x00336622
	private void DLEEPEJAACA(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D06 RID: 27910 RVA: 0x00338448 File Offset: 0x00336648
	public void KBDFAIOPEEL(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.PNBECHOLCJM();
		int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
		int num = KADBECGIMPD.IFDFHJLCHAE();
		int nkhbajkmagd = KADBECGIMPD.KDNDJNEGBDI();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).PIFLJJBAEOA(nkhbajkmagd, num, true);
		string arg2 = " ";
		if (num == 0)
		{
			arg2 = "";
		}
		if (num == 0)
		{
			arg2 = "KneesIdle";
		}
		if (num == 4)
		{
			arg2 = "_SrcBlend";
		}
		string edaphmjenpk = string.Format("_WaveScale4", arg, arg2);
		Actor actor = this.KLBJCCEOEDJ(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(5, edaphmjenpk);
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x003384E4 File Offset: 0x003366E4
	public void BAOHBEFHMHC(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DCGEOFHNBCN();
		KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
		int num = KADBECGIMPD.KKOKFLMMAAK();
		int nkhbajkmagd = KADBECGIMPD.CLPEKGGAMAI();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).EMDPDLPDLOJ(nkhbajkmagd, num, false);
		string arg2 = "offsets";
		if (num == 0)
		{
			arg2 = "repair.ogg";
		}
		if (num == 1)
		{
			arg2 = "name";
		}
		if (num == 3)
		{
			arg2 = "fishDown SHANCE";
		}
		string edaphmjenpk = string.Format("_Cutoff", arg, arg2);
		Actor actor = this.BFEFOAKHHIF(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(5, edaphmjenpk);
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x00338580 File Offset: 0x00336780
	public void BJODFJPAELC(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.HFOPFEJDJFG();
		KADBECGIMPD.LLDDACBAGHF();
		Vector3 vector = KADBECGIMPD.DAKECHGPCFI().GEJNEDNGJDD();
		Vector3 vector2 = KADBECGIMPD.JPHHGPIDDOA().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.JNOKJCDAPPA();
		Vector3 toMovePoint = KADBECGIMPD.DAKECHGPCFI().MCPNAMDKJOH();
		bool isRun = KADBECGIMPD.OMCMPDMJFOJ();
		float moveSpeed = KADBECGIMPD.AIDAGFNHNHE();
		bool dccpcblodig = KADBECGIMPD.KJIOFDCKIKO();
		KADBECGIMPD.MJAHKNLFNCE();
		KADBECGIMPD.MJAHKNLFNCE();
		KADBECGIMPD.CANHAOJOLPO();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1773f;
			return;
		}
		Actor actor = this.BFEFOAKHHIF(num);
		if ((int)b == -121)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.IOEEPNCKLJD();
				actor = this.FJPIBBEBGEE(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.PKIJJNHMCED())
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 202:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 203:
			if (num == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 603f;
			}
			if (actor.isMoving)
			{
				actor.DLPLGAEAGPC(false);
				actor.CIHILMCEJND = false;
				return;
			}
			break;
		case 204:
		case 205:
		case 206:
		case 207:
		case 208:
		case 211:
		case 213:
			break;
		case 209:
			actor.dropType = (int)KADBECGIMPD.NFGIGGIDMFL();
			actor.rodType = KADBECGIMPD.IFDFHJLCHAE();
			actor.MFENINHGBHM = KADBECGIMPD.ELDBJFLCMAJ();
			actor.CIHILMCEJND = KADBECGIMPD.IJJDHHFAIPE();
			actor.isFishOnRod = KADBECGIMPD.FIFNOBGEKFF();
			actor.toDropPoint = KADBECGIMPD.CMIFMMMBBNO().GEJNEDNGJDD();
			actor.blendRodDirection = KADBECGIMPD.MOBPFEEAMKD();
			actor.rodforce = KADBECGIMPD.FFDPCEAFGNF();
			actor.upRodState = KADBECGIMPD.MOBPFEEAMKD();
			actor.isRagulaSet = KADBECGIMPD.LAECLJFMGPE();
			actor.ragulaPosition = KADBECGIMPD.OFGFAEJNKEH().MCPNAMDKJOH();
			actor.ragulaRotation = KADBECGIMPD.EIMAIEJKHKF().OHIPPMOMNDB();
			return;
		case 210:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.LICHMNLLOAB().OHIPPMOMNDB();
			Vector3 phkiohibnpa = KADBECGIMPD.BAPGFMDPGKM().FBLEDBJGDBD();
			int olkmhfnlbjb = KADBECGIMPD.LDLKLPJBIJN();
			float nbljcehnkak = KADBECGIMPD.MOBPFEEAMKD();
			float bpjcikfgomm = KADBECGIMPD.MOBPFEEAMKD();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 212:
			actor.isHarvest = KADBECGIMPD.BEMFIFGOJBL();
			return;
		case 214:
		{
			int num2 = KADBECGIMPD.KKOKFLMMAAK();
			float gkencbiopgo = KADBECGIMPD.FFDPCEAFGNF();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.LICHMNLLOAB();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.MCPNAMDKJOH();
			}
			if (num2 == 0)
			{
				actor.action.IHOEEDGGJOC();
				return;
			}
			actor.action.JBCGPOPIICO(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006D09 RID: 27913 RVA: 0x003388D0 File Offset: 0x00336AD0
	public void FKCAILDLGLC(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("MotorbikeShootLeft", idchhhedhdc.EMDPDLPDLOJ(BPJCIKFGOMM, DBEIGNDALDC, true));
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.onChatMessage(0, edaphmjenpk);
		}
		Actor actor = this.BFEFOAKHHIF(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.MBPLKKLHNIK(0, edaphmjenpk);
	}

	// Token: 0x06006D0A RID: 27914 RVA: 0x00338959 File Offset: 0x00336B59
	private void BDKMJMKOIJB(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("/ n" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D0B RID: 27915 RVA: 0x0033897C File Offset: 0x00336B7C
	public void MAGJAKEJBFD(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.HHMGLDMFCPF();
		KADBECGIMPD.PNBECHOLCJM();
		int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
		int num = KADBECGIMPD.KKOKFLMMAAK();
		int nkhbajkmagd = KADBECGIMPD.KDNDJNEGBDI();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).IGFJGAGBDJM(nkhbajkmagd, num, true);
		string arg2 = "id";
		if (num == 0)
		{
			arg2 = "10";
		}
		if (num == 1)
		{
			arg2 = "This script need an Image with a readbale Texture2D to work.";
		}
		if (num == 5)
		{
			arg2 = "Zone ";
		}
		string edaphmjenpk = string.Format("ShowCursor", arg, arg2);
		Actor actor = this.EFAIOHNMPGM(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(2, edaphmjenpk);
	}

	// Token: 0x06006D0C RID: 27916 RVA: 0x00338A18 File Offset: 0x00336C18
	public void DBAGMEMAJFB(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.HFOPFEJDJFG();
		KADBECGIMPD.CANHAOJOLPO();
		Vector3 vector = KADBECGIMPD.CMIFMMMBBNO().OHIPPMOMNDB();
		Vector3 vector2 = KADBECGIMPD.LICHMNLLOAB().FBLEDBJGDBD();
		bool isMoving = KADBECGIMPD.KJIOFDCKIKO();
		Vector3 toMovePoint = KADBECGIMPD.LIPFLAGOOML().FBLEDBJGDBD();
		bool isRun = KADBECGIMPD.OMCMPDMJFOJ();
		float moveSpeed = KADBECGIMPD.DNGDPHIHLBG();
		bool dccpcblodig = KADBECGIMPD.BLNIHNKJJPJ();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.DHBEGKENIPN();
		KADBECGIMPD.GCOIAONEBME();
		byte b = KADBECGIMPD.LLDDACBAGHF();
		if (num == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 236f;
			return;
		}
		Actor actor = this.EFAIOHNMPGM(num);
		if ((int)b == -122)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.OMCMPDMJFOJ();
				actor = this.KIDHCEFGMGM(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = true;
		}
		switch (b)
		{
		case 0:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 1:
			if (num == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 980f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = false;
				actor.CIHILMCEJND = true;
				return;
			}
			break;
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 9:
		case 11:
			break;
		case 7:
			actor.dropType = (int)KADBECGIMPD.CANHAOJOLPO();
			actor.rodType = KADBECGIMPD.KDNDJNEGBDI();
			actor.MFENINHGBHM = KADBECGIMPD.IOEEPNCKLJD();
			actor.CIHILMCEJND = KADBECGIMPD.IOEEPNCKLJD();
			actor.isFishOnRod = KADBECGIMPD.ELDBJFLCMAJ();
			actor.toDropPoint = KADBECGIMPD.ANALPOIJPHJ().FPLDMBJEFEB();
			actor.blendRodDirection = KADBECGIMPD.CNNEPCOAMJK();
			actor.rodforce = KADBECGIMPD.MOBPFEEAMKD();
			actor.upRodState = KADBECGIMPD.MOBPFEEAMKD();
			actor.isRagulaSet = KADBECGIMPD.IJJDHHFAIPE();
			actor.ragulaPosition = KADBECGIMPD.ANALPOIJPHJ().MCPNAMDKJOH();
			actor.ragulaRotation = KADBECGIMPD.ANALPOIJPHJ().GEJNEDNGJDD();
			return;
		case 8:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.HMCONBPNFJH().OHIPPMOMNDB();
			Vector3 phkiohibnpa = KADBECGIMPD.JPHHGPIDDOA().GEJNEDNGJDD();
			int olkmhfnlbjb = KADBECGIMPD.KDNDJNEGBDI();
			float nbljcehnkak = KADBECGIMPD.BIMMPENHGMD();
			float bpjcikfgomm = KADBECGIMPD.CNNEPCOAMJK();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 10:
			actor.isHarvest = KADBECGIMPD.FIFNOBGEKFF();
			return;
		case 12:
		{
			int num2 = KADBECGIMPD.HDBGOLAFOBK();
			float gkencbiopgo = KADBECGIMPD.MOBPFEEAMKD();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.LIPFLAGOOML();
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.FHOIBLBFMGB();
				return;
			}
			actor.action.AKAECHLONDL(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006D0D RID: 27917 RVA: 0x00338D68 File Offset: 0x00336F68
	public void CPCKPALLOBK(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NENOBDLCFHO);
		string edaphmjenpk = string.Format("{z}", idchhhedhdc.IGFJGAGBDJM(BPJCIKFGOMM, DBEIGNDALDC, false));
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.onChatMessage(0, edaphmjenpk);
		}
		Actor actor = this.NEBIOFHEDJL(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.CKJKIJFPLLH(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(0, edaphmjenpk);
	}

	// Token: 0x06006D0E RID: 27918 RVA: 0x00338DF4 File Offset: 0x00336FF4
	public float OHGIHDMPEKN(Vector3 NHCLMBOINFG)
	{
		float num = 1577f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor KKEKHADMNMC(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x00338E78 File Offset: 0x00337078
	private void JPNHNOFBBMB(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("_InvGamma" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D11 RID: 27921 RVA: 0x00338E9C File Offset: 0x0033709C
	public Actor KIDHCEFGMGM(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006D12 RID: 27922 RVA: 0x00338EF8 File Offset: 0x003370F8
	public void KIHODJOLFNK(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DCGEOFHNBCN();
		Actor actor = this.EFAIOHNMPGM(gdmojdpammn);
		if (actor != null)
		{
			actor.DLIJELLCOBI(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006D13 RID: 27923 RVA: 0x00338F6C File Offset: 0x0033716C
	public float minActorDistance(Vector3 NHCLMBOINFG)
	{
		float num = 99999f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x00338FF0 File Offset: 0x003371F0
	public void CCIBOHBPMAK(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.KKEKHADMNMC(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(5, DOACMCPELGJ);
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x00339018 File Offset: 0x00337218
	public void HAEGGBHDGGO(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.EFAIOHNMPGM(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(6, DOACMCPELGJ);
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x0033903F File Offset: 0x0033723F
	private void DKBGMIPBHNM()
	{
		SceneManager.sceneLoaded += this.NPAGJCBFOKE;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006D17 RID: 27927 RVA: 0x0033907C File Offset: 0x0033727C
	public void ABFHDGEMKCP(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.ANPEIKGEDHJ();
		KADBECGIMPD.MJAHKNLFNCE();
		Vector3 vector = KADBECGIMPD.IBKINJMMFFI().OHIPPMOMNDB();
		Vector3 vector2 = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
		bool isMoving = KADBECGIMPD.JNOKJCDAPPA();
		Vector3 toMovePoint = KADBECGIMPD.OFGFAEJNKEH().FBLEDBJGDBD();
		bool isRun = KADBECGIMPD.FIFNOBGEKFF();
		float moveSpeed = KADBECGIMPD.ECJLJGDNFMN();
		bool dccpcblodig = KADBECGIMPD.LAECLJFMGPE();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.CMLECABALBC();
		KADBECGIMPD.CMLECABALBC();
		byte b = KADBECGIMPD.CANHAOJOLPO();
		if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1494f;
			return;
		}
		Actor actor = this.LBNJNLAIDLL(num);
		if ((int)b == -78)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.BLNIHNKJJPJ();
				actor = this.GLBDNCFBJDN(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = false;
		}
		switch (b)
		{
		case 85:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 86:
			if (num == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1712f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = true;
				actor.CIHILMCEJND = true;
				return;
			}
			break;
		case 87:
		case 88:
		case 89:
		case 90:
		case 91:
		case 94:
		case 96:
			break;
		case 92:
			actor.dropType = (int)KADBECGIMPD.GCOIAONEBME();
			actor.rodType = KADBECGIMPD.CLPEKGGAMAI();
			actor.MFENINHGBHM = KADBECGIMPD.AJECAOJPOKA();
			actor.CIHILMCEJND = KADBECGIMPD.BEMFIFGOJBL();
			actor.isFishOnRod = KADBECGIMPD.OMCMPDMJFOJ();
			actor.toDropPoint = KADBECGIMPD.JEHOEBJMMOI().FPLDMBJEFEB();
			actor.blendRodDirection = KADBECGIMPD.CNNEPCOAMJK();
			actor.rodforce = KADBECGIMPD.AILCEJFAMGN();
			actor.upRodState = KADBECGIMPD.ECJLJGDNFMN();
			actor.isRagulaSet = KADBECGIMPD.KJIOFDCKIKO();
			actor.ragulaPosition = KADBECGIMPD.BAPGFMDPGKM().MCPNAMDKJOH();
			actor.ragulaRotation = KADBECGIMPD.JIFFKNJHLCM().OHIPPMOMNDB();
			return;
		case 93:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.OFGFAEJNKEH().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.JPHHGPIDDOA().GEJNEDNGJDD();
			int olkmhfnlbjb = KADBECGIMPD.AGNKAFLKCAG();
			float nbljcehnkak = KADBECGIMPD.AILCEJFAMGN();
			float bpjcikfgomm = KADBECGIMPD.AILCEJFAMGN();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 95:
			actor.isHarvest = KADBECGIMPD.KJIOFDCKIKO();
			return;
		case 97:
		{
			int num2 = KADBECGIMPD.KKOKFLMMAAK();
			float gkencbiopgo = KADBECGIMPD.MOBPFEEAMKD();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.CMIFMMMBBNO();
			if (!iibeekcaahk.DMPPOEAOIIC())
			{
				actor.toRotation = iibeekcaahk.FPLDMBJEFEB();
			}
			if (num2 == 0)
			{
				actor.action.BDJMANBIIEG();
				return;
			}
			actor.action.DNOPEGOHICA(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006D18 RID: 27928 RVA: 0x003358CC File Offset: 0x00333ACC
	private void CKGJEIDEJCH()
	{
		SceneManager.sceneLoaded += this.DEABLAPHPLP;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006D19 RID: 27929 RVA: 0x003393CC File Offset: 0x003375CC
	public void KNEHOHLHBFP(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.IFDFHJLCHAE();
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			bool flag = KADBECGIMPD.MJAHKNLFNCE() == 0;
			KADBECGIMPD.CANHAOJOLPO();
			bool isMoving = KADBECGIMPD.KJIOFDCKIKO();
			Vector3 nhclmboinfg = KADBECGIMPD.OEHCLGOFDPN().OHIPPMOMNDB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.CMIFMMMBBNO().GEJNEDNGJDD();
			Vector3 toMovePoint = KADBECGIMPD.JEHOEBJMMOI().OHIPPMOMNDB();
			if (num != JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.FJPIBBEBGEE(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "isRagulaSet" + this.chanellId;
		}
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x00339520 File Offset: 0x00337720
	public void HOANGFCCLLI()
	{
		foreach (Actor actor in this.actors.Values)
		{
			UnityEngine.Object.Destroy(actor.gameObject);
		}
		this.actors.Clear();
	}

	// Token: 0x06006D1B RID: 27931 RVA: 0x00339588 File Offset: 0x00337788
	public void OPGOGKCKNPA(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.getActor(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x003395C0 File Offset: 0x003377C0
	public float NFPJFMNKJBA(Vector3 NHCLMBOINFG)
	{
		float num = 1103f;
		foreach (Actor actor in this.actors.Values)
		{
			if (!(actor == null) && actor.MFENINHGBHM)
			{
				float num2 = Vector3.Distance(NHCLMBOINFG, actor.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x00339644 File Offset: 0x00337844
	public void EHFCJOGECHD(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.IBKCNEICPEL();
		KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
		int num = KADBECGIMPD.AGNKAFLKCAG();
		int nkhbajkmagd = KADBECGIMPD.LDLKLPJBIJN();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).PIFLJJBAEOA(nkhbajkmagd, num, true);
		string arg2 = "Load";
		if (num == 0)
		{
			arg2 = "CP2";
		}
		if (num == 1)
		{
			arg2 = "_isSelect";
		}
		if (num == 4)
		{
			arg2 = "1";
		}
		string edaphmjenpk = string.Format("gameexist", arg, arg2);
		Actor actor = this.ENNFDOAEBFB(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(7, edaphmjenpk);
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x003396E0 File Offset: 0x003378E0
	public void MAICLMJKDMF(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		Actor actor = this.LBNJNLAIDLL(IABKGMNJLJO.OELGGLIHFIH);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(IABKGMNJLJO.PPICJOPPOLK, IABKGMNJLJO.IABKGMNJLJO);
	}

	// Token: 0x06006D1F RID: 27935 RVA: 0x00339716 File Offset: 0x00337916
	public void HBJBODKPLEJ(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 613f);
	}

	// Token: 0x06006D20 RID: 27936 RVA: 0x00339744 File Offset: 0x00337944
	public void DGBNFALLLGC(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.LDLKLPJBIJN();
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			long num = KADBECGIMPD.KLHDFFHONON();
			bool flag = KADBECGIMPD.GGHNGCKMHEN() == 1;
			KADBECGIMPD.CANHAOJOLPO();
			bool isMoving = KADBECGIMPD.KJIOFDCKIKO();
			Vector3 nhclmboinfg = KADBECGIMPD.ANALPOIJPHJ().GEJNEDNGJDD();
			Vector3 lnhaojnpgdl = KADBECGIMPD.HMCONBPNFJH().FPLDMBJEFEB();
			Vector3 toMovePoint = KADBECGIMPD.FCLPDDODOJP().OHIPPMOMNDB();
			if (num != JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.DIGGPBLLPGH(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "long:" + this.chanellId;
		}
	}

	// Token: 0x06006D21 RID: 27937 RVA: 0x00339898 File Offset: 0x00337A98
	public void initialUsersInLoc(HBPNMNGOFMA KADBECGIMPD)
	{
		foreach (Actor actor in this.actors.Values)
		{
			if (actor != null)
			{
				UnityEngine.Object.Destroy(actor.gameObject);
			}
		}
		this.actors.Clear();
		this.chanellId = KADBECGIMPD.HDBGOLAFOBK();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			bool flag = KADBECGIMPD.CMLECABALBC() == 0;
			KADBECGIMPD.CMLECABALBC();
			bool isMoving = KADBECGIMPD.FIFNOBGEKFF();
			Vector3 nhclmboinfg = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			Vector3 lnhaojnpgdl = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			Vector3 toMovePoint = KADBECGIMPD.EIMAIEJKHKF().FPLDMBJEFEB();
			if (num != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				Actor actor2 = this.instaniateActor(flag, nhclmboinfg, lnhaojnpgdl);
				actor2.shid = num;
				actor2.isMoving = isMoving;
				actor2.isWoman = flag;
				actor2.toMovePoint = toMovePoint;
				this.actors.Add(num, actor2);
			}
		}
		if (DownPanelLogic.getI != null)
		{
			DownPanelLogic.getI.chanellText.text = "K-" + this.chanellId;
		}
	}

	// Token: 0x06006D22 RID: 27938 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor BFEFOAKHHIF(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006D23 RID: 27939 RVA: 0x00338422 File Offset: 0x00336622
	private void NOKHNBMCBKC(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D24 RID: 27940 RVA: 0x003399EC File Offset: 0x00337BEC
	private void DEABLAPHPLP(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("_OcclusionColor" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D25 RID: 27941 RVA: 0x00339A10 File Offset: 0x00337C10
	public void BBAGCOKCBPM(HBPNMNGOFMA KADBECGIMPD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		long num = KADBECGIMPD.IBKCNEICPEL();
		KADBECGIMPD.NFGIGGIDMFL();
		Vector3 vector = KADBECGIMPD.BAPGFMDPGKM().FPLDMBJEFEB();
		Vector3 vector2 = KADBECGIMPD.FCLPDDODOJP().GEJNEDNGJDD();
		bool isMoving = KADBECGIMPD.LAECLJFMGPE();
		Vector3 toMovePoint = KADBECGIMPD.CMIFMMMBBNO().FPLDMBJEFEB();
		bool isRun = KADBECGIMPD.ELDBJFLCMAJ();
		float moveSpeed = KADBECGIMPD.BNDHIBEOKML();
		bool dccpcblodig = KADBECGIMPD.JNOKJCDAPPA();
		KADBECGIMPD.AOMGDMELKAF();
		KADBECGIMPD.GGHNGCKMHEN();
		KADBECGIMPD.NFGIGGIDMFL();
		byte b = KADBECGIMPD.MJAHKNLFNCE();
		if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
		{
			vector.x += 1737f;
			return;
		}
		Actor actor = this.KKEKHADMNMC(num);
		if ((int)b == -81)
		{
			if (actor == null)
			{
				bool abifbpcmpkk = KADBECGIMPD.KJIOFDCKIKO();
				actor = this.instaniateActor(abifbpcmpkk, vector, vector2);
				actor.shid = num;
				this.actors.Add(num, actor);
			}
			actor.toPosition = vector;
			actor.toRotation = vector2;
		}
		if (actor == null)
		{
			return;
		}
		actor.LELCMGAFFBI(dccpcblodig);
		actor.toPosition = vector;
		actor.toRotation = vector2;
		actor.toMovePoint = toMovePoint;
		actor.moveSpeed = moveSpeed;
		actor.isRun = isRun;
		actor.isMoving = isMoving;
		if (actor.CMCPFNJIIHK)
		{
			actor.isMoving = true;
		}
		switch (b)
		{
		case 127:
			this.actors.Remove(num);
			UnityEngine.Object.Destroy(actor.gameObject);
			return;
		case 128:
			if (num == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI)
			{
				actor.toMovePoint.z = actor.toMovePoint.z + 1247f;
			}
			if (actor.isMoving)
			{
				actor.MFENINHGBHM = false;
				actor.CIHILMCEJND = true;
				return;
			}
			break;
		case 129:
		case 130:
		case 131:
		case 132:
		case 133:
		case 136:
		case 138:
			break;
		case 134:
			actor.dropType = (int)KADBECGIMPD.AOMGDMELKAF();
			actor.rodType = KADBECGIMPD.HHLDBAEFNMJ();
			actor.DLPLGAEAGPC(KADBECGIMPD.JALHMJEKMHF());
			actor.CIHILMCEJND = KADBECGIMPD.FIFNOBGEKFF();
			actor.isFishOnRod = KADBECGIMPD.DADCGPGEHFK();
			actor.toDropPoint = KADBECGIMPD.CMIFMMMBBNO().FBLEDBJGDBD();
			actor.blendRodDirection = KADBECGIMPD.CGJIINADKNH();
			actor.rodforce = KADBECGIMPD.BNDHIBEOKML();
			actor.upRodState = KADBECGIMPD.MOBPFEEAMKD();
			actor.isRagulaSet = KADBECGIMPD.IJJDHHFAIPE();
			actor.ragulaPosition = KADBECGIMPD.OFGFAEJNKEH().MCPNAMDKJOH();
			actor.ragulaRotation = KADBECGIMPD.IBKINJMMFFI().FBLEDBJGDBD();
			return;
		case 135:
		{
			Vector3 mgaleajogpl = KADBECGIMPD.OFGFAEJNKEH().FPLDMBJEFEB();
			Vector3 phkiohibnpa = KADBECGIMPD.DAKECHGPCFI().MCPNAMDKJOH();
			int olkmhfnlbjb = KADBECGIMPD.HDBGOLAFOBK();
			float nbljcehnkak = KADBECGIMPD.CNNEPCOAMJK();
			float bpjcikfgomm = KADBECGIMPD.AILCEJFAMGN();
			actor.fishTrapEvent(mgaleajogpl, phkiohibnpa, olkmhfnlbjb, nbljcehnkak, bpjcikfgomm);
			return;
		}
		case 137:
			actor.isHarvest = KADBECGIMPD.JNOKJCDAPPA();
			return;
		case 139:
		{
			int num2 = KADBECGIMPD.HHLDBAEFNMJ();
			float gkencbiopgo = KADBECGIMPD.DNGDPHIHLBG();
			IIBEEKCAAHK iibeekcaahk = KADBECGIMPD.OEHCLGOFDPN();
			if (!iibeekcaahk.DIFFCNOPHBJ)
			{
				actor.toRotation = iibeekcaahk.FBLEDBJGDBD();
			}
			if (num2 == 0)
			{
				actor.action.FIAKMIFCCLG();
				return;
			}
			actor.action.HLCLNDOBBLL(num2, gkencbiopgo);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06006D26 RID: 27942 RVA: 0x00339D5F File Offset: 0x00337F5F
	public void HCCLELDLHOK(Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ActorMgr.getI.getFishEffect, NHCLMBOINFG, Quaternion.identity);
		gameObject.transform.position = NHCLMBOINFG;
		UnityEngine.Object.Destroy(gameObject, 1399f);
	}

	// Token: 0x06006D27 RID: 27943 RVA: 0x00339D8C File Offset: 0x00337F8C
	public void MNGJJLNHNDL(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.HHMGLDMFCPF();
		Actor actor = this.KKEKHADMNMC(gdmojdpammn);
		if (actor != null)
		{
			actor.DLIJELLCOBI(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006D28 RID: 27944 RVA: 0x00339E00 File Offset: 0x00338000
	public void KEFEJDOKHBO(long IEHIJALHONE, int NENOBDLCFHO, int DBEIGNDALDC, int BPJCIKFGOMM, float ONADLMBJFCC)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(NENOBDLCFHO);
		string edaphmjenpk = string.Format("SoundMgr is init part 1", idchhhedhdc.FFAFKPDHOIN(BPJCIKFGOMM, DBEIGNDALDC, true));
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI == IEHIJALHONE && Fisherman.getI != null)
		{
			Fisherman.getI.JHBCOOFFLIC(NENOBDLCFHO, ONADLMBJFCC);
			Fisherman.getI.HIEKCPABOMG(1, edaphmjenpk);
		}
		Actor actor = this.EFAIOHNMPGM(IEHIJALHONE);
		if (actor == null)
		{
			return;
		}
		actor.userBragFish(NENOBDLCFHO, ONADLMBJFCC);
		actor.onChatMessage(0, edaphmjenpk);
	}

	// Token: 0x06006D29 RID: 27945 RVA: 0x00339E89 File Offset: 0x00338089
	private void NPAGJCBFOKE(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("WorkerPickaxe" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D2A RID: 27946 RVA: 0x00339EAC File Offset: 0x003380AC
	public void FLMCOENDGAF(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.PNBECHOLCJM();
		int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
		int num = KADBECGIMPD.CLPEKGGAMAI();
		int nkhbajkmagd = KADBECGIMPD.IFDFHJLCHAE();
		string arg = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).PIFLJJBAEOA(nkhbajkmagd, num, false);
		string arg2 = "Explosions";
		if (num == 0)
		{
			arg2 = "type";
		}
		if (num == 1)
		{
			arg2 = "_Offsets";
		}
		if (num == 7)
		{
			arg2 = "Titul.xml";
		}
		string edaphmjenpk = string.Format("category", arg, arg2);
		Actor actor = this.KKEKHADMNMC(gdmojdpammn);
		if (actor == null)
		{
			return;
		}
		actor.onChatMessage(8, edaphmjenpk);
	}

	// Token: 0x06006D2B RID: 27947 RVA: 0x00339F48 File Offset: 0x00338148
	public void OHANBECGECL(HBPNMNGOFMA KADBECGIMPD)
	{
		long gdmojdpammn = KADBECGIMPD.HHMGLDMFCPF();
		Actor actor = this.BFEFOAKHHIF(gdmojdpammn);
		if (actor != null)
		{
			actor.readActorData(KADBECGIMPD);
			return;
		}
		foreach (Actor actor2 in this.actors.Values)
		{
		}
	}

	// Token: 0x06006D2C RID: 27948 RVA: 0x00339FBC File Offset: 0x003381BC
	private void GKJNOMMAAPO()
	{
		SceneManager.sceneLoaded += this.JPNHNOFBBMB;
		if (ActorMgr.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		ActorMgr.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06006D2D RID: 27949 RVA: 0x0033457D File Offset: 0x0033277D
	public Actor LBNJNLAIDLL(long GDMOJDPAMMN)
	{
		if (!this.actors.ContainsKey(GDMOJDPAMMN))
		{
			return null;
		}
		return this.actors[GDMOJDPAMMN];
	}

	// Token: 0x06006D2E RID: 27950 RVA: 0x00339FFC File Offset: 0x003381FC
	public Actor COFMHMHALII(bool ABIFBPCMPKK, Vector3 NHCLMBOINFG, Vector3 LNHAOJNPGDL)
	{
		GameObject gameObject;
		if (ABIFBPCMPKK)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorWomanPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.actorManPrefab, NHCLMBOINFG, Quaternion.Euler(LNHAOJNPGDL));
		}
		Actor component = gameObject.GetComponent<Actor>();
		component.isWoman = ABIFBPCMPKK;
		component.toPosition = NHCLMBOINFG;
		component.toRotation = LNHAOJNPGDL;
		component.toMovePoint = NHCLMBOINFG;
		return component;
	}

	// Token: 0x06006D2F RID: 27951 RVA: 0x0033A058 File Offset: 0x00338258
	public void BPJOJOLHPKD(long JCGDLKIHBJG, int OLKMHFNLBJB, string DOACMCPELGJ)
	{
		Actor actor = this.getActor(JCGDLKIHBJG);
		if (actor == null)
		{
			return;
		}
		actor.MBPLKKLHNIK(1, DOACMCPELGJ);
	}

	// Token: 0x06006D30 RID: 27952 RVA: 0x0033A07F File Offset: 0x0033827F
	private void KFCPIGLIBJK(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("IceHockeyGoalieSave2" + JBPBBBAOKFH.name);
	}

	// Token: 0x06006D31 RID: 27953 RVA: 0x0033A0A2 File Offset: 0x003382A2
	private void EAJDJFDJNAF(Scene JBPBBBAOKFH, LoadSceneMode PLDLMKDDANP)
	{
		this.actors.Clear();
		Debug.Log("*** ActorMgr Scene is loaded:" + JBPBBBAOKFH.name);
	}

	// Token: 0x04001002 RID: 4098
	public static ActorMgr getI;

	// Token: 0x04001003 RID: 4099
	public GameObject defaultRod;

	// Token: 0x04001004 RID: 4100
	public GameObject defaulReel;

	// Token: 0x04001005 RID: 4101
	public GameObject defaulChair;

	// Token: 0x04001006 RID: 4102
	public GameObject podsak4User;

	// Token: 0x04001007 RID: 4103
	public GameObject podsak4Actor;

	// Token: 0x04001008 RID: 4104
	public GameObject getFishEffect;

	// Token: 0x04001009 RID: 4105
	public int chanellId;

	// Token: 0x0400100A RID: 4106
	public GameObject actorManPrefab;

	// Token: 0x0400100B RID: 4107
	public GameObject actorWomanPrefab;

	// Token: 0x0400100C RID: 4108
	public Dictionary<long, Actor> actors = new Dictionary<long, Actor>();
}
