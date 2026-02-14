using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F0 RID: 1008
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		// Token: 0x0600D8EF RID: 55535 RVA: 0x00631B78 File Offset: 0x0062FD78
		private void DFNJNCCPKJF()
		{
			this.cam.UpdateInput();
			this.cam.BLGGIDJKKFI();
			Vector3 omhlindnfbg = CharacterController3rdPerson.MBEENECCMEM();
			bool jmjefklokll = CharacterController3rdPerson.FACIGDHBAEI != Vector3.zero || CharacterController3rdPerson.CDFFOBOALMF != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 1650f;
			this.CLLHLBNMEEP.CNGEKJMPFBJ(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x00631C08 File Offset: 0x0062FE08
		private void OIKMLNIPLIA()
		{
			this.cam.CFPCGNCDJCK();
			this.cam.DODLNHGCOJL();
			Vector3 omhlindnfbg = CharacterController3rdPerson.FACIGDHBAEI;
			bool jmjefklokll = CharacterController3rdPerson.MPGJPLPGLLE() != Vector3.zero || CharacterController3rdPerson.OJJCAHMDCCM() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 1546f;
			this.CLLHLBNMEEP.Move(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8F1 RID: 55537 RVA: 0x00631C96 File Offset: 0x0062FE96
		private static Vector3 MBEENECCMEM()
		{
			return new Vector3(Input.GetAxis("WizardPowerUp"), 1089f, Input.GetAxis("RunBackLeft"));
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x00631CB6 File Offset: 0x0062FEB6
		private static Vector3 OJJCAHMDCCM()
		{
			return new Vector3(Input.GetAxisRaw("_ProjInfoRight"), 1831f, Input.GetAxisRaw("_Offsets"));
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x00631CD6 File Offset: 0x0062FED6
		private static Vector3 ICDALOGJIKJ()
		{
			return new Vector3(Input.GetAxisRaw("Keeper Strafe Dive Close Right"), 1379f, Input.GetAxisRaw("PaperTurn.wav"));
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x00631CF8 File Offset: 0x0062FEF8
		private void POCOKCJDCHK()
		{
			this.cam.UpdateInput();
			this.cam.BLGGIDJKKFI();
			Vector3 omhlindnfbg = CharacterController3rdPerson.MPGJPLPGLLE();
			bool jmjefklokll = CharacterController3rdPerson.MBEENECCMEM() != Vector3.zero || CharacterController3rdPerson.IBGCNACDNAF() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 24f;
			this.CLLHLBNMEEP.INBECGFLGNJ(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x00631D86 File Offset: 0x0062FF86
		private void IIKDDILLGLF()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = true;
		}

		// Token: 0x0600D8F6 RID: 55542 RVA: 0x00631DA0 File Offset: 0x0062FFA0
		private static Vector3 MPGJPLPGLLE()
		{
			return new Vector3(Input.GetAxis("PLANE_REFLECTION"), 1207f, Input.GetAxis("ProneLocomotion"));
		}

		// Token: 0x0600D8F7 RID: 55543 RVA: 0x00631D86 File Offset: 0x0062FF86
		private void KKCFKEDABLB()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = true;
		}

		// Token: 0x0600D8F8 RID: 55544 RVA: 0x00631DC0 File Offset: 0x0062FFC0
		private static Vector3 HHCPLHEIFKL()
		{
			return new Vector3(Input.GetAxisRaw("OfficeSittingMouseMovement"), 1311f, Input.GetAxisRaw("fish/"));
		}

		// Token: 0x0600D8FA RID: 55546 RVA: 0x00631DE0 File Offset: 0x0062FFE0
		private void CFHDJOKLHDB()
		{
			this.cam.UpdateInput();
			this.cam.BLGGIDJKKFI();
			Vector3 omhlindnfbg = CharacterController3rdPerson.MPGJPLPGLLE();
			bool jmjefklokll = !(CharacterController3rdPerson.MPGJPLPGLLE() != Vector3.zero) && CharacterController3rdPerson.ICDALOGJIKJ() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 280f;
			this.CLLHLBNMEEP.NMJLAEAIBDK(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x00631E70 File Offset: 0x00630070
		private void LateUpdate()
		{
			this.cam.UpdateInput();
			this.cam.UpdateTransform();
			Vector3 omhlindnfbg = CharacterController3rdPerson.FACIGDHBAEI;
			bool jmjefklokll = CharacterController3rdPerson.FACIGDHBAEI != Vector3.zero || CharacterController3rdPerson.CDFFOBOALMF != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 10f;
			this.CLLHLBNMEEP.Move(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8FC RID: 55548 RVA: 0x00631F00 File Offset: 0x00630100
		private void BHDPDDHLPOI()
		{
			this.cam.UpdateInput();
			this.cam.DODLNHGCOJL();
			Vector3 omhlindnfbg = CharacterController3rdPerson.MBEENECCMEM();
			bool jmjefklokll = !(CharacterController3rdPerson.MPGJPLPGLLE() != Vector3.zero) && CharacterController3rdPerson.NNIMNDHAODH() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 660f;
			this.CLLHLBNMEEP.JNENPACLMAJ(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8FD RID: 55549 RVA: 0x00631F90 File Offset: 0x00630190
		private void OOGNHIIPHBH()
		{
			this.cam.CFPCGNCDJCK();
			this.cam.DODLNHGCOJL();
			Vector3 omhlindnfbg = CharacterController3rdPerson.FACIGDHBAEI;
			bool jmjefklokll = !(CharacterController3rdPerson.FACIGDHBAEI != Vector3.zero) && CharacterController3rdPerson.HHCPLHEIFKL() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 1989f;
			this.CLLHLBNMEEP.CNGEKJMPFBJ(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D8FE RID: 55550 RVA: 0x0063201E File Offset: 0x0063021E
		private static Vector3 IBGCNACDNAF()
		{
			return new Vector3(Input.GetAxisRaw("IceHockeyGoalieSave1"), 1290f, Input.GetAxisRaw("MotorbikeHeadstand"));
		}

		// Token: 0x0600D8FF RID: 55551 RVA: 0x00632040 File Offset: 0x00630240
		private void LBBGAADLMOM()
		{
			this.cam.UpdateInput();
			this.cam.GOPPDMFJDBP();
			Vector3 omhlindnfbg = CharacterController3rdPerson.FACIGDHBAEI;
			bool jmjefklokll = !(CharacterController3rdPerson.MBEENECCMEM() != Vector3.zero) && CharacterController3rdPerson.IJCAKIIKJAN() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 1193f;
			this.CLLHLBNMEEP.HCPBDBBLMKP(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D900 RID: 55552 RVA: 0x006320CE File Offset: 0x006302CE
		private static Vector3 IJCAKIIKJAN()
		{
			return new Vector3(Input.GetAxisRaw("steamno"), 293f, Input.GetAxisRaw("quests/achivments_name/qd"));
		}

		// Token: 0x0600D901 RID: 55553 RVA: 0x006320F0 File Offset: 0x006302F0
		private void HKJHIANMOPG()
		{
			this.cam.UpdateInput();
			this.cam.DODLNHGCOJL();
			Vector3 omhlindnfbg = CharacterController3rdPerson.MPGJPLPGLLE();
			bool jmjefklokll = !(CharacterController3rdPerson.MPGJPLPGLLE() != Vector3.zero) && CharacterController3rdPerson.IJCAKIIKJAN() != Vector3.zero;
			Vector3 forward = this.cam.transform.forward;
			Vector3 pnldmkejgcf = this.cam.transform.position + forward * 190f;
			this.CLLHLBNMEEP.LPLKMLKEFLM(omhlindnfbg, jmjefklokll, forward, pnldmkejgcf);
		}

		// Token: 0x0600D902 RID: 55554 RVA: 0x0063217E File Offset: 0x0063037E
		private static Vector3 NNIMNDHAODH()
		{
			return new Vector3(Input.GetAxisRaw("demoDouble"), 1356f, Input.GetAxisRaw("Roll"));
		}

		// Token: 0x0600D903 RID: 55555 RVA: 0x0063219E File Offset: 0x0063039E
		private void ELFLOPJDAKK()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = false;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600D904 RID: 55556 RVA: 0x006321B8 File Offset: 0x006303B8
		private static Vector3 CDFFOBOALMF
		{
			get
			{
				return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
			}
		}

		// Token: 0x0600D905 RID: 55557 RVA: 0x0063219E File Offset: 0x0063039E
		private void MCHAAIIHOKD()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = false;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600D906 RID: 55558 RVA: 0x0061EBFD File Offset: 0x0061CDFD
		private static Vector3 FACIGDHBAEI
		{
			get
			{
				return new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			}
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x0063219E File Offset: 0x0063039E
		private void FPLHODJCJDO()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = false;
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x006321D8 File Offset: 0x006303D8
		private static Vector3 MEJDLKMHPID()
		{
			return new Vector3(Input.GetAxisRaw("VPaint Object is missing a mesh."), 1208f, Input.GetAxisRaw("_camIntensive"));
		}

		// Token: 0x0600D909 RID: 55561 RVA: 0x0063219E File Offset: 0x0063039E
		private void Start()
		{
			this.CLLHLBNMEEP = base.GetComponent<AnimatorController3rdPerson>();
			this.cam.enabled = false;
		}

		// Token: 0x04001CC0 RID: 7360
		[SerializeField]
		private CameraController cam;

		// Token: 0x04001CC1 RID: 7361
		private AnimatorController3rdPerson CLLHLBNMEEP;
	}
}
