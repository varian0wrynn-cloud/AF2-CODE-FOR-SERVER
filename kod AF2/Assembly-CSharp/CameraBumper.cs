using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200006C RID: 108
[Serializable]
internal class CameraBumper
{
	// Token: 0x0600197A RID: 6522 RVA: 0x000D8AD0 File Offset: 0x000D6CD0
	public Vector3 KGDMDCGMMLF(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.AKJFJCNNOKA(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void NKIMJKJODKL(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x000D8B4A File Offset: 0x000D6D4A
	// (set) Token: 0x060019D5 RID: 6613 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public Vector3 Offset
	{
		get
		{
			return this.offset;
		}
		set
		{
			this.offset = value;
		}
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> KKBBMEBELPA()
	{
		return this.ourIgnores;
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> OACAHNHBDKE()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x000D8B62 File Offset: 0x000D6D62
	private GameObject BPDLGFAGNIC()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("FactoryTempTexture");
		}
		return this.ourBumper;
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void PGFEECONJBJ(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void PGJIPBOAGPG(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG APLADHAPGKC()
	{
		return this.collisionType;
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float NHJDIOEJKGN()
	{
		return this.distanceCheck;
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void FCDPGBJIGEA(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void JCDICGPHDOK(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void PJMMENKHBAJ(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void CMCEOACLDIA(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x000D8BBC File Offset: 0x000D6DBC
	private GameObject OEFDDIIAFOI()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order.");
		}
		return this.ourBumper;
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void FEHJELJPPNF(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float DKKODGGCNIF()
	{
		return this.distanceCheck;
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> GCINPBIPOCH()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> DBBBCPPCLJN()
	{
		return this.ourIgnores;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void JIFNDFEAJCI(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG LLGJGNFCEBC()
	{
		return this.collisionType;
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x000D8BE2 File Offset: 0x000D6DE2
	private GameObject NLAAGGIBJBO()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("fshop_btn1");
		}
		return this.ourBumper;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG MDIGEOHPIEN()
	{
		return this.collisionType;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG JAJGMIIBCOJ()
	{
		return this.collisionType;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float LIKACOFIIKA()
	{
		return this.newCameraHeight;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x000D8C10 File Offset: 0x000D6E10
	private GameObject GHNDEKJLCEA()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("Tip");
		}
		return this.ourBumper;
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private void CNILEAIAJFP(GameObject DCCPCBLODIG)
	{
		this.ourBumper = DCCPCBLODIG;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void FPBFFAOLFLJ(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG GNIPIBNIKDC()
	{
		return this.collisionType;
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600199D RID: 6557 RVA: 0x000D8C08 File Offset: 0x000D6E08
	// (set) Token: 0x06001997 RID: 6551 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public float NewCameraHeight
	{
		get
		{
			return this.newCameraHeight;
		}
		set
		{
			this.newCameraHeight = value;
		}
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x000D8C40 File Offset: 0x000D6E40
	private bool BMEGPPLIBEA(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ)
	{
		CameraBumper.LDPNMDMNJGG ldpnmdmnjgg = this.collisionType;
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.Raycast)
		{
			Vector3 direction = GKJPGJAOHAC.transform.TransformDirection(887f * Vector3.forward);
			return Physics.Raycast(GKJPGJAOHAC.TransformPoint(this.offset), direction, out this.hit, this.distanceCheck) && this.hit.transform != GKJPGJAOHAC;
		}
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.None)
		{
			this.GHNDEKJLCEA().transform.position = GKJPGJAOHAC.position + this.offset + 1117f * GKJPGJAOHAC.forward;
			this.GFIEAMCBGOG().HCFCLOHIEJJ(this.DBBBCPPCLJN());
			this.IBNLKHJPILC().IDMHKDLCCLI = this.OACAHNHBDKE();
			return this.IDOHJGFMHPG().FALCEBHNNHP;
		}
		return false;
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void HHANOPAMDHG(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private void BMKIPCHLAHL(GameObject DCCPCBLODIG)
	{
		this.ourBumper = DCCPCBLODIG;
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void KEHIDHEHDNH(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> PHIOCMLMBHA()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float HHIMOKCPIOD()
	{
		return this.newCameraHeight;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000D8D1C File Offset: 0x000D6F1C
	public Vector3 KCBIHHHMNGG(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.AKJFJCNNOKA(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	// (set) Token: 0x060019BD RID: 6589 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public CameraBumper.LDPNMDMNJGG Collision
	{
		get
		{
			return this.collisionType;
		}
		set
		{
			this.collisionType = value;
		}
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> ADHIPBPJFEG()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void KDLPOPAJLCC(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void MBDLGKBNJKD(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float AAEMNCPMLAO()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float EBCBAKOKPBC()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float KALINFCGKPH()
	{
		return this.newCameraHeight;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float FJNCEFDKILI()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void KMKHKBGJJKN(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x000D8B4A File Offset: 0x000D6D4A
	public Vector3 DMCIIBKLJHC()
	{
		return this.offset;
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void NKHALDOCKAN(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> LNGPFIHMABG()
	{
		return this.ourIgnores;
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void LPIAEBKMBHO(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060019B4 RID: 6580 RVA: 0x000D8B52 File Offset: 0x000D6D52
	// (set) Token: 0x060019AD RID: 6573 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public List<Transform> Ignores
	{
		get
		{
			return this.ourIgnores;
		}
		set
		{
			this.ourIgnores = value;
		}
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void LJKLNJFADJK(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x000D8D8D File Offset: 0x000D6F8D
	private GameObject CHKKLMAPJLO()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("\"{0}\"");
		}
		return this.ourBumper;
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void NJCJIELFLFE(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void OJAFPPGFDEG(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void GMMKFMFEFID(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> BPEDGDMPMEI()
	{
		return this.ourIgnores;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void FGCMDFADLLK(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x000D8DB3 File Offset: 0x000D6FB3
	private DetectionTrigger GFIEAMCBGOG()
	{
		if (this.ourDetectionTrigger == null)
		{
			this.ourDetectionTrigger = (this.NLAAGGIBJBO().AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
		}
		return this.ourDetectionTrigger;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float DJJKJFJKIBP()
	{
		return this.newCameraHeight;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void CKCOONEICJF(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void APNGBOKMECA(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060019EE RID: 6638 RVA: 0x000D9289 File Offset: 0x000D7489
	// (set) Token: 0x060019BA RID: 6586 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private GameObject Bumper
	{
		get
		{
			if (this.ourBumper == null)
			{
				this.ourBumper = new GameObject("Bumper");
			}
			return this.ourBumper;
		}
		set
		{
			this.ourBumper = value;
		}
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private void FOMKJPFKNIJ(GameObject DCCPCBLODIG)
	{
		this.ourBumper = DCCPCBLODIG;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void IIFOCNJCCIL(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060019BE RID: 6590 RVA: 0x000D8DE9 File Offset: 0x000D6FE9
	private DetectionTrigger DetectionTrigger
	{
		get
		{
			if (this.ourDetectionTrigger == null)
			{
				this.ourDetectionTrigger = (this.Bumper.AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
			}
			return this.ourDetectionTrigger;
		}
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> NJKHLNNLJPO()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float EMKLFEKJEAI()
	{
		return this.newCameraHeight;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x000D8E1F File Offset: 0x000D701F
	private DetectionTrigger IBNLKHJPILC()
	{
		if (this.ourDetectionTrigger == null)
		{
			this.ourDetectionTrigger = (this.BPDLGFAGNIC().AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
		}
		return this.ourDetectionTrigger;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void HPMOKPAMMEH(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x000D8B4A File Offset: 0x000D6D4A
	public Vector3 BGKNCPICABK()
	{
		return this.offset;
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> OLMOMCJKEHK()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060019ED RID: 6637 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	// (set) Token: 0x060019C5 RID: 6597 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public float DistanceCheck
	{
		get
		{
			return this.distanceCheck;
		}
		set
		{
			this.distanceCheck = value;
		}
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void GECLEGDMMOE(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float EAMBCFJNKHF()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> EMLGEADCFOC()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG NDHGCBMFBCC()
	{
		return this.collisionType;
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x000D8E55 File Offset: 0x000D7055
	private DetectionTrigger OEBNDJHNPDB()
	{
		if (this.ourDetectionTrigger == null)
		{
			this.ourDetectionTrigger = (this.INCMDOAKIGL().AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
		}
		return this.ourDetectionTrigger;
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void HFPOGDEKJAG(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x000D8DE9 File Offset: 0x000D6FE9
	private DetectionTrigger IDOHJGFMHPG()
	{
		if (this.ourDetectionTrigger == null)
		{
			this.ourDetectionTrigger = (this.Bumper.AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
		}
		return this.ourDetectionTrigger;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void DHCGHBPLPCA(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void EDGJHFKCJGJ(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x000D8E8C File Offset: 0x000D708C
	public Vector3 FKNOHDLGPJM(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.MJMHOLPFCHM(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> DKIPAAFNOLC()
	{
		return this.ourIgnores;
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x000D8F00 File Offset: 0x000D7100
	public Vector3 NAKEKHPHNHB(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.AKJFJCNNOKA(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	// (set) Token: 0x060019D8 RID: 6616 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public List<Type> IgnoreTypes
	{
		get
		{
			return this.ourIgnoreTypes;
		}
		set
		{
			this.ourIgnoreTypes = value;
		}
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x000D8F74 File Offset: 0x000D7174
	public Vector3 JEKBKNGHFDP(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.ECHEEJGGFNL(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void PLCIEGOIFFA(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> AJGGNMKKMGK()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x000D8FE8 File Offset: 0x000D71E8
	private bool MJMHOLPFCHM(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ)
	{
		CameraBumper.LDPNMDMNJGG ldpnmdmnjgg = this.collisionType;
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.Raycast)
		{
			Vector3 direction = GKJPGJAOHAC.transform.TransformDirection(-1f * Vector3.forward);
			return Physics.Raycast(GKJPGJAOHAC.TransformPoint(this.offset), direction, out this.hit, this.distanceCheck) && this.hit.transform != GKJPGJAOHAC;
		}
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.Collider)
		{
			this.Bumper.transform.position = GKJPGJAOHAC.position + this.offset + -1f * GKJPGJAOHAC.forward;
			this.DetectionTrigger.DGHPEOHOELO = this.Ignores;
			this.DetectionTrigger.IDMHKDLCCLI = this.IgnoreTypes;
			return this.DetectionTrigger.FALCEBHNNHP;
		}
		return false;
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> MCFKPDDFHJE()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x000D90BC File Offset: 0x000D72BC
	private bool AKJFJCNNOKA(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ)
	{
		CameraBumper.LDPNMDMNJGG ldpnmdmnjgg = this.collisionType;
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.Raycast)
		{
			Vector3 direction = GKJPGJAOHAC.transform.TransformDirection(1116f * Vector3.forward);
			return Physics.Raycast(GKJPGJAOHAC.TransformPoint(this.offset), direction, out this.hit, this.distanceCheck) && this.hit.transform != GKJPGJAOHAC;
		}
		if (ldpnmdmnjgg == (CameraBumper.LDPNMDMNJGG)5)
		{
			this.OEFDDIIAFOI().transform.position = GKJPGJAOHAC.position + this.offset + 1673f * GKJPGJAOHAC.forward;
			this.IBNLKHJPILC().DGHPEOHOELO = this.FNEPOMLGAFO();
			this.DetectionTrigger.IDMHKDLCCLI = this.IgnoreTypes;
			return this.IBNLKHJPILC().FALCEBHNNHP;
		}
		return true;
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x000D8B4A File Offset: 0x000D6D4A
	public Vector3 CHPEKBCIHMM()
	{
		return this.offset;
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG EGGCFMMDAIL()
	{
		return this.collisionType;
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x000D8E1F File Offset: 0x000D701F
	private DetectionTrigger FOMGEHLHPMI()
	{
		if (this.ourDetectionTrigger == null)
		{
			this.ourDetectionTrigger = (this.BPDLGFAGNIC().AddComponent(typeof(DetectionTrigger)) as DetectionTrigger);
		}
		return this.ourDetectionTrigger;
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void HCNJHJIPODK(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private void GDAAEEPMHCH(GameObject DCCPCBLODIG)
	{
		this.ourBumper = DCCPCBLODIG;
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x000D9190 File Offset: 0x000D7390
	private bool ECHEEJGGFNL(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ)
	{
		CameraBumper.LDPNMDMNJGG ldpnmdmnjgg = this.collisionType;
		if (ldpnmdmnjgg == CameraBumper.LDPNMDMNJGG.None)
		{
			Vector3 direction = GKJPGJAOHAC.transform.TransformDirection(171f * Vector3.forward);
			return Physics.Raycast(GKJPGJAOHAC.TransformPoint(this.offset), direction, out this.hit, this.distanceCheck) && this.hit.transform != GKJPGJAOHAC;
		}
		if (ldpnmdmnjgg == (CameraBumper.LDPNMDMNJGG)8)
		{
			this.INCMDOAKIGL().transform.position = GKJPGJAOHAC.position + this.offset + 1470f * GKJPGJAOHAC.forward;
			this.OEBNDJHNPDB().PFFNACJDGHF(this.Ignores);
			this.IBNLKHJPILC().IDMHKDLCCLI = this.DMGFPCAANKN();
			return this.DetectionTrigger.FALCEBHNNHP;
		}
		return true;
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float PMBOPMMAKIO()
	{
		return this.newCameraHeight;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> GCAJJKIMCPJ()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG ICJPOKGKDML()
	{
		return this.collisionType;
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void BMOFGKANIEH(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG BJFIGFPJICP()
	{
		return this.collisionType;
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float FOCDOIBKIBG()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> DMGFPCAANKN()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void CMOIIKPOBMM(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> ENEDKKNFJKA()
	{
		return this.ourIgnores;
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x000D9263 File Offset: 0x000D7463
	private GameObject GJCCPAGCBLD()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("GestureNoFear");
		}
		return this.ourBumper;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float PLIHIHDHIEI()
	{
		return this.newCameraHeight;
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x000D8BAA File Offset: 0x000D6DAA
	public void PDBEMGNGMPC(CameraBumper.LDPNMDMNJGG DCCPCBLODIG)
	{
		this.collisionType = DCCPCBLODIG;
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void OHIMNCLJMFH(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x000D8B52 File Offset: 0x000D6D52
	public List<Transform> FNEPOMLGAFO()
	{
		return this.ourIgnores;
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void EOGLMEJHKGH(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x000D9304 File Offset: 0x000D7504
	public Vector3 NEDNAPLHEOF(Transform GKJPGJAOHAC, Transform BPPFKBHFHBJ, Vector3 NACLLIFPBIM, float HPGFMGNHIHG)
	{
		if (this.ECHEEJGGFNL(GKJPGJAOHAC, BPPFKBHFHBJ))
		{
			NACLLIFPBIM.x = this.hit.point.x;
			NACLLIFPBIM.z = this.hit.point.z;
			NACLLIFPBIM.y = Mathf.Lerp(this.hit.point.y + this.newCameraHeight, NACLLIFPBIM.y, HPGFMGNHIHG);
		}
		return NACLLIFPBIM;
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x000D8BA2 File Offset: 0x000D6DA2
	public float EEIHJFKDBOI()
	{
		return this.distanceCheck;
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x000D8BB3 File Offset: 0x000D6DB3
	public void GOMFEOJFKOD(List<Type> DCCPCBLODIG)
	{
		this.ourIgnoreTypes = DCCPCBLODIG;
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void IEKHLKMPCND(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG FKFPBEOGOGD()
	{
		return this.collisionType;
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void BBEBBOHNODL(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG OBBBJAMKCHF()
	{
		return this.collisionType;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG MJACJGFAJBL()
	{
		return this.collisionType;
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x000D8B9A File Offset: 0x000D6D9A
	public CameraBumper.LDPNMDMNJGG ANHGCHPCGJA()
	{
		return this.collisionType;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x000D8B91 File Offset: 0x000D6D91
	public void DKGPNACKLLB(Vector3 DCCPCBLODIG)
	{
		this.offset = DCCPCBLODIG;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x000D8B88 File Offset: 0x000D6D88
	public void IAIFMDIKMKB(float DCCPCBLODIG)
	{
		this.distanceCheck = DCCPCBLODIG;
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void GALMKIBMJHN(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x000D8C08 File Offset: 0x000D6E08
	public float ADCEOPNHLOA()
	{
		return this.newCameraHeight;
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x000D8D13 File Offset: 0x000D6F13
	public void PEELOMHCGFI(List<Transform> DCCPCBLODIG)
	{
		this.ourIgnores = DCCPCBLODIG;
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x000D8C36 File Offset: 0x000D6E36
	private void MIKHEEHGFPH(GameObject DCCPCBLODIG)
	{
		this.ourBumper = DCCPCBLODIG;
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x000D8B41 File Offset: 0x000D6D41
	public void JBELMDONFGJ(float DCCPCBLODIG)
	{
		this.newCameraHeight = DCCPCBLODIG;
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x000D9375 File Offset: 0x000D7575
	private GameObject INCMDOAKIGL()
	{
		if (this.ourBumper == null)
		{
			this.ourBumper = new GameObject("craft_data/stanok/category");
		}
		return this.ourBumper;
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x000D8B5A File Offset: 0x000D6D5A
	public List<Type> PDKMDBJHIGF()
	{
		return this.ourIgnoreTypes;
	}

	// Token: 0x040002B8 RID: 696
	private RaycastHit hit;

	// Token: 0x040002B9 RID: 697
	private bool isColliderHit;

	// Token: 0x040002BA RID: 698
	private GameObject ourBumper;

	// Token: 0x040002BB RID: 699
	private DetectionTrigger ourDetectionTrigger;

	// Token: 0x040002BC RID: 700
	[SerializeField]
	private CameraBumper.LDPNMDMNJGG collisionType = CameraBumper.LDPNMDMNJGG.Raycast;

	// Token: 0x040002BD RID: 701
	[SerializeField]
	private float distanceCheck = 2.5f;

	// Token: 0x040002BE RID: 702
	[SerializeField]
	private float newCameraHeight = 1f;

	// Token: 0x040002BF RID: 703
	[SerializeField]
	private Vector3 offset = Vector3.zero;

	// Token: 0x040002C0 RID: 704
	private List<Transform> ourIgnores = new List<Transform>();

	// Token: 0x040002C1 RID: 705
	private List<Type> ourIgnoreTypes = new List<Type>();

	// Token: 0x0200006D RID: 109
	public enum LDPNMDMNJGG
	{
		// Token: 0x040002C3 RID: 707
		None,
		// Token: 0x040002C4 RID: 708
		Raycast,
		// Token: 0x040002C5 RID: 709
		Collider
	}
}
