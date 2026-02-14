using System;
using UnityEngine;

// Token: 0x0200005C RID: 92
public class BoxTurtleUserController : MonoBehaviour
{
	// Token: 0x06001591 RID: 5521 RVA: 0x000BD600 File Offset: 0x000BB800
	private void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			this.EBOBEBADLBD.Attack();
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			this.EBOBEBADLBD.Hit();
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			this.EBOBEBADLBD.Eat();
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			this.EBOBEBADLBD.Close();
		}
		if (Input.GetKeyUp(KeyCode.B))
		{
			this.EBOBEBADLBD.Open();
		}
		if (Input.GetKeyUp(KeyCode.K))
		{
			this.EBOBEBADLBD.Death();
		}
		if (Input.GetKeyUp(KeyCode.R))
		{
			this.EBOBEBADLBD.Rebirth();
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			this.EBOBEBADLBD.CrouchStart();
		}
		if (Input.GetKeyUp(KeyCode.C))
		{
			this.EBOBEBADLBD.CrouchEnd();
		}
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void BMNJGPIPKLL()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void Start()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x000BD6D4 File Offset: 0x000BB8D4
	private void OMJKCHLIOOK()
	{
		float axis = Input.GetAxis("ZombieIdle2");
		float axis2 = Input.GetAxis("");
		this.EBOBEBADLBD.CGHECDAJCCP(axis2, axis);
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x000BD704 File Offset: 0x000BB904
	private void FJEEADNCKAG()
	{
		if (Input.GetButtonDown("Left"))
		{
			this.EBOBEBADLBD.FPHBGEBFJMO();
		}
		if (Input.GetKeyDown((KeyCode)(-104)))
		{
			this.EBOBEBADLBD.KIJIPFNFCBM();
		}
		if (Input.GetKeyDown((KeyCode)29))
		{
			this.EBOBEBADLBD.OGKHNCCHJAF();
		}
		if (Input.GetKeyDown((KeyCode)72))
		{
			this.EBOBEBADLBD.NCEJPHJOIDD();
		}
		if (Input.GetKeyUp((KeyCode)(-34)))
		{
			this.EBOBEBADLBD.JGNCBCFLKLD();
		}
		if (Input.GetKeyUp(KeyCode.Y))
		{
			this.EBOBEBADLBD.DHEKGDCJEPN();
		}
		if (Input.GetKeyUp((KeyCode)88))
		{
			this.EBOBEBADLBD.BLBJNAIDNNO();
		}
		if (Input.GetKeyDown((KeyCode)23))
		{
			this.EBOBEBADLBD.EBPPFCAAKHG();
		}
		if (Input.GetKeyUp((KeyCode)(-26)))
		{
			this.EBOBEBADLBD.CFNCBJENDJA();
		}
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void HHGGCBLOJGB()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x000BD7C8 File Offset: 0x000BB9C8
	private void LDDIGEMBDNF()
	{
		if (Input.GetButtonDown("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off)."))
		{
			this.EBOBEBADLBD.AJMDHFOGNDB();
		}
		if (Input.GetKeyDown((KeyCode)(-82)))
		{
			this.EBOBEBADLBD.IKMHIDPLNGG();
		}
		if (Input.GetKeyDown((KeyCode)(-44)))
		{
			this.EBOBEBADLBD.MNDAPFBDNJH();
		}
		if (Input.GetKeyDown((KeyCode)(-74)))
		{
			this.EBOBEBADLBD.NCEJPHJOIDD();
		}
		if (Input.GetKeyUp((KeyCode)29))
		{
			this.EBOBEBADLBD.AEBAHFOHFBA();
		}
		if (Input.GetKeyUp((KeyCode)(-96)))
		{
			this.EBOBEBADLBD.JMFNAPLJPAE();
		}
		if (Input.GetKeyUp((KeyCode)(-108)))
		{
			this.EBOBEBADLBD.OPGHKIIDPIJ();
		}
		if (Input.GetKeyDown((KeyCode)7))
		{
			this.EBOBEBADLBD.ELDMOLMNKIF();
		}
		if (Input.GetKeyUp(KeyCode.Alpha5))
		{
			this.EBOBEBADLBD.MHJNIKHPJLI();
		}
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x000BD88C File Offset: 0x000BBA8C
	private void PJHEGHHOJHJ()
	{
		if (Input.GetButtonDown("__b"))
		{
			this.EBOBEBADLBD.PPBBADHKBLK();
		}
		if (Input.GetKeyDown((KeyCode)(-75)))
		{
			this.EBOBEBADLBD.KIJIPFNFCBM();
		}
		if (Input.GetKeyDown((KeyCode)(-99)))
		{
			this.EBOBEBADLBD.Eat();
		}
		if (Input.GetKeyDown((KeyCode)15))
		{
			this.EBOBEBADLBD.FAJFNNJJKBK();
		}
		if (Input.GetKeyUp((KeyCode)(-23)))
		{
			this.EBOBEBADLBD.KOEGOIDKGCK();
		}
		if (Input.GetKeyUp((KeyCode)(-76)))
		{
			this.EBOBEBADLBD.MIJBMHCBNMA();
		}
		if (Input.GetKeyUp((KeyCode)(-60)))
		{
			this.EBOBEBADLBD.Rebirth();
		}
		if (Input.GetKeyDown((KeyCode)(-116)))
		{
			this.EBOBEBADLBD.FDALCOMOKJH();
		}
		if (Input.GetKeyUp((KeyCode)77))
		{
			this.EBOBEBADLBD.GNNELHABOOI();
		}
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x000BD950 File Offset: 0x000BBB50
	private void LJDGIHMLNLL()
	{
		float axis = Input.GetAxis("+ EXP for FISH=");
		float axis2 = Input.GetAxis("setCurrentRod sm (профиль)=");
		this.EBOBEBADLBD.CGHECDAJCCP(axis2, axis);
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void LPNDCJKAKEA()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x000BD980 File Offset: 0x000BBB80
	private void JGCOLIFLHLP()
	{
		float axis = Input.GetAxis("teech_perk");
		float axis2 = Input.GetAxis("RHandPunch");
		this.EBOBEBADLBD.MIMPEACCEDB(axis2, axis);
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x000BD9B0 File Offset: 0x000BBBB0
	private void PNBGJBMJLFM()
	{
		if (Input.GetButtonDown("_MaxSteps"))
		{
			this.EBOBEBADLBD.PPBBADHKBLK();
		}
		if (Input.GetKeyDown((KeyCode)(-80)))
		{
			this.EBOBEBADLBD.AJPCHHOCIOL();
		}
		if (Input.GetKeyDown((KeyCode)(-5)))
		{
			this.EBOBEBADLBD.Eat();
		}
		if (Input.GetKeyDown((KeyCode)(-119)))
		{
			this.EBOBEBADLBD.LGNLHEJONFL();
		}
		if (Input.GetKeyUp(KeyCode.H))
		{
			this.EBOBEBADLBD.JCPJCGKOPCH();
		}
		if (Input.GetKeyUp((KeyCode)(-65)))
		{
			this.EBOBEBADLBD.OCIDJGCHKBC();
		}
		if (Input.GetKeyUp((KeyCode)(-54)))
		{
			this.EBOBEBADLBD.HFOFALGKKCD();
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			this.EBOBEBADLBD.DAGIJBGGFMD();
		}
		if (Input.GetKeyUp((KeyCode)(-102)))
		{
			this.EBOBEBADLBD.NPCNDPIHLHN();
		}
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x000BDA74 File Offset: 0x000BBC74
	private void BOAJJAKEMLH()
	{
		if (Input.GetButtonDown("Shoot Right"))
		{
			this.EBOBEBADLBD.PPBBADHKBLK();
		}
		if (Input.GetKeyDown((KeyCode)79))
		{
			this.EBOBEBADLBD.PANNIFBDMCG();
		}
		if (Input.GetKeyDown(KeyCode.Tilde))
		{
			this.EBOBEBADLBD.OKBIKHCHPIF();
		}
		if (Input.GetKeyDown((KeyCode)(-119)))
		{
			this.EBOBEBADLBD.JNMGNJGNIAI();
		}
		if (Input.GetKeyUp((KeyCode)16))
		{
			this.EBOBEBADLBD.LCENJBKKMHD();
		}
		if (Input.GetKeyUp(KeyCode.Y))
		{
			this.EBOBEBADLBD.OCIDJGCHKBC();
		}
		if (Input.GetKeyUp((KeyCode)(-73)))
		{
			this.EBOBEBADLBD.NFBHEDEHECG();
		}
		if (Input.GetKeyDown(KeyCode.Ampersand))
		{
			this.EBOBEBADLBD.EBPPFCAAKHG();
		}
		if (Input.GetKeyUp((KeyCode)(-76)))
		{
			this.EBOBEBADLBD.CFKMNPIAHKA();
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x000BDB38 File Offset: 0x000BBD38
	private void NBCLNFLJMHP()
	{
		float axis = Input.GetAxis("wpn_rod2");
		float axis2 = Input.GetAxis("FrontKick");
		this.EBOBEBADLBD.AEHOCIMNHLI(axis2, axis);
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x000BDB68 File Offset: 0x000BBD68
	private void JOHDLNOKCOK()
	{
		if (Input.GetButtonDown("offsets"))
		{
			this.EBOBEBADLBD.OFJEEFEHAKL();
		}
		if (Input.GetKeyDown((KeyCode)(-96)))
		{
			this.EBOBEBADLBD.APIAFGHBLHD();
		}
		if (Input.GetKeyDown((KeyCode)84))
		{
			this.EBOBEBADLBD.OGKHNCCHJAF();
		}
		if (Input.GetKeyDown((KeyCode)23))
		{
			this.EBOBEBADLBD.JNMGNJGNIAI();
		}
		if (Input.GetKeyUp((KeyCode)(-95)))
		{
			this.EBOBEBADLBD.GJFGBOGOMIM();
		}
		if (Input.GetKeyUp((KeyCode)(-21)))
		{
			this.EBOBEBADLBD.OCIDJGCHKBC();
		}
		if (Input.GetKeyUp((KeyCode)70))
		{
			this.EBOBEBADLBD.LDLLLGPKAIA();
		}
		if (Input.GetKeyDown((KeyCode)(-5)))
		{
			this.EBOBEBADLBD.HGBANDLBGKH();
		}
		if (Input.GetKeyUp((KeyCode)(-109)))
		{
			this.EBOBEBADLBD.OOGGDMKGNDH();
		}
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x000BDC2C File Offset: 0x000BBE2C
	private void NEHOCLNFDHP()
	{
		float axis = Input.GetAxis("L");
		float axis2 = Input.GetAxis("err: rect is null");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x000BDC5C File Offset: 0x000BBE5C
	private void GCNGEFBKMNC()
	{
		if (Input.GetButtonDown("_Offsets"))
		{
			this.EBOBEBADLBD.IFLPEPBKNNF();
		}
		if (Input.GetKeyDown((KeyCode)(-125)))
		{
			this.EBOBEBADLBD.FEJGPBHBDMD();
		}
		if (Input.GetKeyDown((KeyCode)3))
		{
			this.EBOBEBADLBD.OGKHNCCHJAF();
		}
		if (Input.GetKeyDown((KeyCode)(-115)))
		{
			this.EBOBEBADLBD.CDNHFNDDNEP();
		}
		if (Input.GetKeyUp((KeyCode)(-104)))
		{
			this.EBOBEBADLBD.GIIPCPDBHJK();
		}
		if (Input.GetKeyUp((KeyCode)(-119)))
		{
			this.EBOBEBADLBD.JMFNAPLJPAE();
		}
		if (Input.GetKeyUp((KeyCode)79))
		{
			this.EBOBEBADLBD.LDLLLGPKAIA();
		}
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			this.EBOBEBADLBD.NOGCICDAMHB();
		}
		if (Input.GetKeyUp((KeyCode)(-27)))
		{
			this.EBOBEBADLBD.EBKNPABGLBK();
		}
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x000BDD20 File Offset: 0x000BBF20
	private void JKDBDEGLIJN()
	{
		float axis = Input.GetAxis("_BlurVector");
		float axis2 = Input.GetAxis("gi_um_4");
		this.EBOBEBADLBD.MIMPEACCEDB(axis2, axis);
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x000BDD50 File Offset: 0x000BBF50
	private void JLFBDOPFDDJ()
	{
		if (Input.GetButtonDown("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: "))
		{
			this.EBOBEBADLBD.JGOKLENIGOK();
		}
		if (Input.GetKeyDown((KeyCode)2))
		{
			this.EBOBEBADLBD.IGEMEOBDHNC();
		}
		if (Input.GetKeyDown(KeyCode.Minus))
		{
			this.EBOBEBADLBD.GCMEHHNCNAI();
		}
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			this.EBOBEBADLBD.FAJFNNJJKBK();
		}
		if (Input.GetKeyUp(KeyCode.RightBracket))
		{
			this.EBOBEBADLBD.Open();
		}
		if (Input.GetKeyUp(KeyCode.BackQuote))
		{
			this.EBOBEBADLBD.OCIDJGCHKBC();
		}
		if (Input.GetKeyUp((KeyCode)(-2)))
		{
			this.EBOBEBADLBD.HMOOBCEGBIK();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			this.EBOBEBADLBD.FAPPFIHLODC();
		}
		if (Input.GetKeyUp(KeyCode.D))
		{
			this.EBOBEBADLBD.PLIONLFFLKH();
		}
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void CBLGFOFHNPJ()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void MODJFGGIAHD()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x000BDE14 File Offset: 0x000BC014
	private void IOGAKGCADBL()
	{
		if (Input.GetButtonDown(" "))
		{
			this.EBOBEBADLBD.OFJEEFEHAKL();
		}
		if (Input.GetKeyDown((KeyCode)20))
		{
			this.EBOBEBADLBD.PANNIFBDMCG();
		}
		if (Input.GetKeyDown((KeyCode)68))
		{
			this.EBOBEBADLBD.BPKCHLNPHFD();
		}
		if (Input.GetKeyDown(KeyCode.Caret))
		{
			this.EBOBEBADLBD.HEJLHDBDCJI();
		}
		if (Input.GetKeyUp(KeyCode.T))
		{
			this.EBOBEBADLBD.KOEGOIDKGCK();
		}
		if (Input.GetKeyUp((KeyCode)(-118)))
		{
			this.EBOBEBADLBD.IEFGGFJBOHE();
		}
		if (Input.GetKeyUp(KeyCode.Less))
		{
			this.EBOBEBADLBD.OIKIHLKNEMN();
		}
		if (Input.GetKeyDown(KeyCode.Y))
		{
			this.EBOBEBADLBD.NOGCICDAMHB();
		}
		if (Input.GetKeyUp((KeyCode)(-27)))
		{
			this.EBOBEBADLBD.NHDOGMKJBEH();
		}
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void EFJDBBDMPMC()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x000BDED8 File Offset: 0x000BC0D8
	private void MNEBLODGADC()
	{
		float axis = Input.GetAxis("ObscuredBool:");
		float axis2 = Input.GetAxis("OfficeSittingReadingPageFlip");
		this.EBOBEBADLBD.FJILBBHGIIK(axis2, axis);
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x000BDF08 File Offset: 0x000BC108
	private void NMLBOIJFMMB()
	{
		float axis = Input.GetAxis("Assembly-CSharp-firstpass");
		float axis2 = Input.GetAxis("WandAttack");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x000BDF38 File Offset: 0x000BC138
	private void FixedUpdate()
	{
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x000BDF68 File Offset: 0x000BC168
	private void AKLFCMNCPKL()
	{
		if (Input.GetButtonDown("Flap_04.wav"))
		{
			this.EBOBEBADLBD.BPNCOHLNKNF();
		}
		if (Input.GetKeyDown(KeyCode.V))
		{
			this.EBOBEBADLBD.AJPCHHOCIOL();
		}
		if (Input.GetKeyDown((KeyCode)(-8)))
		{
			this.EBOBEBADLBD.IJFEHGKHKFA();
		}
		if (Input.GetKeyDown((KeyCode)(-101)))
		{
			this.EBOBEBADLBD.Close();
		}
		if (Input.GetKeyUp(KeyCode.Alpha2))
		{
			this.EBOBEBADLBD.OPJCLDLNPFM();
		}
		if (Input.GetKeyUp(KeyCode.I))
		{
			this.EBOBEBADLBD.GAIMAOJHCOF();
		}
		if (Input.GetKeyUp((KeyCode)10))
		{
			this.EBOBEBADLBD.KAJFINIPBML();
		}
		if (Input.GetKeyDown((KeyCode)14))
		{
			this.EBOBEBADLBD.NONPAHJNHEJ();
		}
		if (Input.GetKeyUp((KeyCode)(-56)))
		{
			this.EBOBEBADLBD.JPNCHOAMDCP();
		}
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x000BE02C File Offset: 0x000BC22C
	private void DLKJAKIAFMN()
	{
		float axis = Input.GetAxis("\n");
		float axis2 = Input.GetAxis("auk_wset");
		this.EBOBEBADLBD.OIKMIGNCGFA(axis2, axis);
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x000BE05C File Offset: 0x000BC25C
	private void IGEICBNMPAD()
	{
		if (Input.GetButtonDown(": "))
		{
			this.EBOBEBADLBD.PPBBADHKBLK();
		}
		if (Input.GetKeyDown((KeyCode)(-10)))
		{
			this.EBOBEBADLBD.IGEMEOBDHNC();
		}
		if (Input.GetKeyDown(KeyCode.RightParen))
		{
			this.EBOBEBADLBD.Eat();
		}
		if (Input.GetKeyDown((KeyCode)(-108)))
		{
			this.EBOBEBADLBD.NCEJPHJOIDD();
		}
		if (Input.GetKeyUp(KeyCode.Alpha6))
		{
			this.EBOBEBADLBD.DGKBOPBKOOB();
		}
		if (Input.GetKeyUp((KeyCode)(-121)))
		{
			this.EBOBEBADLBD.IKICMBODCIA();
		}
		if (Input.GetKeyUp((KeyCode)31))
		{
			this.EBOBEBADLBD.NFBHEDEHECG();
		}
		if (Input.GetKeyDown((KeyCode)(-84)))
		{
			this.EBOBEBADLBD.OOJDNOBEFLF();
		}
		if (Input.GetKeyUp(KeyCode.Comma))
		{
			this.EBOBEBADLBD.NHDOGMKJBEH();
		}
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x000BE120 File Offset: 0x000BC320
	private void KMLNBHIIGKH()
	{
		if (Input.GetButtonDown("GiantGrabThrow2"))
		{
			this.EBOBEBADLBD.AJOKKKDJADA();
		}
		if (Input.GetKeyDown((KeyCode)(-55)))
		{
			this.EBOBEBADLBD.KIJIPFNFCBM();
		}
		if (Input.GetKeyDown((KeyCode)(-74)))
		{
			this.EBOBEBADLBD.EPOLPMGFGKA();
		}
		if (Input.GetKeyDown((KeyCode)(-34)))
		{
			this.EBOBEBADLBD.LGNLHEJONFL();
		}
		if (Input.GetKeyUp(KeyCode.M))
		{
			this.EBOBEBADLBD.JGNCBCFLKLD();
		}
		if (Input.GetKeyUp((KeyCode)(-116)))
		{
			this.EBOBEBADLBD.JMFNAPLJPAE();
		}
		if (Input.GetKeyUp(KeyCode.Alpha5))
		{
			this.EBOBEBADLBD.CJAGKMKEJCE();
		}
		if (Input.GetKeyDown(KeyCode.Greater))
		{
			this.EBOBEBADLBD.HGBANDLBGKH();
		}
		if (Input.GetKeyUp(KeyCode.Backslash))
		{
			this.EBOBEBADLBD.CFNCBJENDJA();
		}
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x000BE1E4 File Offset: 0x000BC3E4
	private void IAGDKFGKPGG()
	{
		float axis = Input.GetAxis("Unknow CMD:");
		float axis2 = Input.GetAxis("isImproved");
		this.EBOBEBADLBD.IBPOOBCIHMG(axis2, axis);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x000BE214 File Offset: 0x000BC414
	private void KHAEPCKACBD()
	{
		float axis = Input.GetAxis("inv_impr");
		float axis2 = Input.GetAxis("#ffffff");
		this.EBOBEBADLBD.CGHECDAJCCP(axis2, axis);
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x000BE244 File Offset: 0x000BC444
	private void MEFOGCFJBNE()
	{
		if (Input.GetButtonDown("DropType"))
		{
			this.EBOBEBADLBD.PPBBADHKBLK();
		}
		if (Input.GetKeyDown((KeyCode)(-12)))
		{
			this.EBOBEBADLBD.PANNIFBDMCG();
		}
		if (Input.GetKeyDown((KeyCode)(-62)))
		{
			this.EBOBEBADLBD.OKBIKHCHPIF();
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			this.EBOBEBADLBD.JNMGNJGNIAI();
		}
		if (Input.GetKeyUp((KeyCode)(-79)))
		{
			this.EBOBEBADLBD.OJFHOBKADKE();
		}
		if (Input.GetKeyUp(KeyCode.N))
		{
			this.EBOBEBADLBD.HOLDGICIILF();
		}
		if (Input.GetKeyUp((KeyCode)(-122)))
		{
			this.EBOBEBADLBD.HMOOBCEGBIK();
		}
		if (Input.GetKeyDown(KeyCode.Pipe))
		{
			this.EBOBEBADLBD.FAPPFIHLODC();
		}
		if (Input.GetKeyUp(KeyCode.Less))
		{
			this.EBOBEBADLBD.NPCNDPIHLHN();
		}
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void CPNOBMNKPNC()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x000BE308 File Offset: 0x000BC508
	private void BGLIJMGAHLP()
	{
		float axis = Input.GetAxis("SoundMgr is init part 2");
		float axis2 = Input.GetAxis("");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void CAJLCEPLKJG()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void ELFLOPJDAKK()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x000BE338 File Offset: 0x000BC538
	private void FBFLOJPKHIO()
	{
		float axis = Input.GetAxis("wpn_add/base/dropt");
		float axis2 = Input.GetAxis("WorkerPickaxe");
		this.EBOBEBADLBD.FJILBBHGIIK(axis2, axis);
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x000BE368 File Offset: 0x000BC568
	private void FAGCCPMNMED()
	{
		float axis = Input.GetAxis("[^а-яА-Я\\d_]");
		float axis2 = Input.GetAxis("DeadmanFloat");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void KKCFKEDABLB()
	{
		this.EBOBEBADLBD = base.GetComponent<BoxTurtleCharacter>();
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x000BE398 File Offset: 0x000BC598
	private void KMHBOLLCJHO()
	{
		float axis = Input.GetAxis("PaperTurn.wav");
		float axis2 = Input.GetAxis(" ms");
		this.EBOBEBADLBD.Move(axis2, axis);
	}

	// Token: 0x0400025A RID: 602
	private BoxTurtleCharacter EBOBEBADLBD;
}
