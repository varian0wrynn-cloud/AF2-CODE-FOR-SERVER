using System;
using UnityEngine;

// Token: 0x02000073 RID: 115
public class IKScript : MonoBehaviour
{
	// Token: 0x06001BA2 RID: 7074 RVA: 0x000DA78C File Offset: 0x000D898C
	private void FBOGNADDHBJ(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_ChromaticAberration_Spectrum");
		this.animator.SetIKPosition((AvatarIKGoal)8, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.LHandWeight);
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void JLKBMEBFHBI()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void MCHAAIIHOKD()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void MKNPFMEMOJO()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x000DA7E8 File Offset: 0x000D89E8
	private void PNLFENLKACJ(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("bag");
		this.animator.SetIKPosition((AvatarIKGoal)6, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.LHandWeight);
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000DA834 File Offset: 0x000D8A34
	private void OnAnimatorIK(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("LHandWeight");
		this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.LHandWeight);
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void KEMGOLACEHI()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void INDGOHJGCFN()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void PNJHMJNFPLP()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void OBJCOJEHLBE()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void IIKDDILLGLF()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x000DA880 File Offset: 0x000D8A80
	private void BBLGOMFCCNG(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_FogAlpha");
		this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)4, this.LHandWeight);
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void ANHOOJFEJJE()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void FPLHODJCJDO()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x000DA8CC File Offset: 0x000D8ACC
	private void EEHECLICBPE(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("<color='#000000'>");
		this.animator.SetIKPosition((AvatarIKGoal)8, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.LHandWeight);
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void LPNDCJKAKEA()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x000DA918 File Offset: 0x000D8B18
	private void FBHMJIMPGGI(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("RollerBladeSkateFwd");
		this.animator.SetIKPosition((AvatarIKGoal)5, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)4, this.LHandWeight);
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x000DA964 File Offset: 0x000D8B64
	private void GCKMAEMNPCG(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_ColorDownsampled");
		this.animator.SetIKPosition((AvatarIKGoal)4, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)6, this.LHandWeight);
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x000DA9B0 File Offset: 0x000D8BB0
	private void PNEOMNDEEED(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("1HandSwordJabCombo");
		this.animator.SetIKPosition((AvatarIKGoal)7, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.LHandWeight);
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x000DA9FC File Offset: 0x000D8BFC
	private void LKCOLEONMMP(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		this.animator.SetIKPosition((AvatarIKGoal)7, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.LHandWeight);
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void HDFCIACDDEK()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void PBMPJPIMJBF()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void CGNGBFFGGBP()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000DAA48 File Offset: 0x000D8C48
	private void FAHNCDFAPPA(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("UIChat_fontSize");
		this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.LHandWeight);
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x000DAA94 File Offset: 0x000D8C94
	private void HFOINOEENIG(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("cht_msg20");
		this.animator.SetIKPosition((AvatarIKGoal)4, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void CAJLCEPLKJG()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void OLBDJCFPKFG()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000DAAE0 File Offset: 0x000D8CE0
	private void DFJOCDGKDIE(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("ShotgunReloadChamber");
		this.animator.SetIKPosition((AvatarIKGoal)6, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.LHandWeight);
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void MODJFGGIAHD()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x000DAB2C File Offset: 0x000D8D2C
	private void DBPBGCHOACA(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("foot");
		this.animator.SetIKPosition((AvatarIKGoal)8, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.LHandWeight);
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000DAB78 File Offset: 0x000D8D78
	private void OAOFMPBLGNO(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("wpn_hook2");
		this.animator.SetIKPosition((AvatarIKGoal)7, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.LHandWeight);
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void KIEIPFFEDHC()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000DABC4 File Offset: 0x000D8DC4
	private void ANLODFNBEON(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("x");
		this.animator.SetIKPosition((AvatarIKGoal)7, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)6, this.LHandWeight);
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000DAC10 File Offset: 0x000D8E10
	private void HGAPADCFANI(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("chnam3");
		this.animator.SetIKPosition((AvatarIKGoal)8, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x000DAC5C File Offset: 0x000D8E5C
	private void FPBFNMGLLJC(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("ActorFish");
		this.animator.SetIKPosition((AvatarIKGoal)8, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.LHandWeight);
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void EHFPLKEINFO()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000DACA8 File Offset: 0x000D8EA8
	private void DAPILEAJLPL(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("closePodsak");
		this.animator.SetIKPosition((AvatarIKGoal)6, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)4, this.LHandWeight);
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x000DACF4 File Offset: 0x000D8EF4
	private void BIMIILKLBNM(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("inv_wpers");
		this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void AFFAJKPPMHF()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void FGJCIEDDFGN()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x000DAD40 File Offset: 0x000D8F40
	private void EKKGEJFNANL(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("LOAD BASE");
		this.animator.SetIKPosition((AvatarIKGoal)5, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void CGFDDFHECLJ()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000DAD8C File Offset: 0x000D8F8C
	private void PDHNEAJCNEM(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("WizardOverhead");
		this.animator.SetIKPosition((AvatarIKGoal)5, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.LHandWeight);
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000DADD8 File Offset: 0x000D8FD8
	private void FPCJJGIBJCK(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_DeepTex");
		this.animator.SetIKPosition((AvatarIKGoal)4, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void JHFAHBIIJDC()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void JFFPLABGMNF()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x000DAE24 File Offset: 0x000D9024
	private void BHGMELKMOPP(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("Katana Ready");
		this.animator.SetIKPosition((AvatarIKGoal)6, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.LHandWeight);
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void Start()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void NOKJMMDMJNO()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x000DAE70 File Offset: 0x000D9070
	private void CKDNMLOFGDM(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_1.png");
		this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void LMEJKAEIDCO()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void OFGMIEJKMGC()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void ONIHHFLOJMN()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void ELFLOPJDAKK()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x000DAEBC File Offset: 0x000D90BC
	private void MBEMFIPLGMK(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("System.Boolean");
		this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.LHandWeight);
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000DAF08 File Offset: 0x000D9108
	private void LDMFLIMECFD(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("Mouse X");
		this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.LHandWeight);
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x000DAF54 File Offset: 0x000D9154
	private void BGPPBLJAADG(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("eat2.ogg");
		this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.LHandWeight);
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void EDGALMCHPPH()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void CBLGFOFHNPJ()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void BMNJGPIPKLL()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void IJOCHELLKJH()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void DGGMJCMLLED()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x000DAFA0 File Offset: 0x000D91A0
	private void OBOJBKMAKLA(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("_FilteredReflections");
		this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.LHandWeight);
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000DAFEC File Offset: 0x000D91EC
	private void PELJDJNAPAK(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("CardPlayerLook");
		this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.LHandPos1.position);
		this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.LHandWeight);
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000DB038 File Offset: 0x000D9238
	private void CFOMAPJDJOK(int IAGCLEPJOEC)
	{
		this.LHandWeight = this.animator.GetFloat("Idle Stun");
		this.animator.SetIKPosition((AvatarIKGoal)5, this.LHandPos1.position);
		this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.LHandWeight);
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void OPNPODKLOJK()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x000DA7D8 File Offset: 0x000D89D8
	private void DHJDMKLBLEF()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x040002DB RID: 731
	public Animator animator;

	// Token: 0x040002DC RID: 732
	public Transform LHandPos1;

	// Token: 0x040002DD RID: 733
	public float LHandWeight;
}
