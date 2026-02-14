using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
public class RollerBladeScript : MonoBehaviour
{
	// Token: 0x06001C14 RID: 7188 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void OBJCOJEHLBE()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void CPNOBMNKPNC()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void OFGMIEJKMGC()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x000DBD64 File Offset: 0x000D9F64
	private void Update()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("Turn", Input.GetAxis("Horizontal"));
			this.KCLACNEILLB.SetFloat("SkateForward", Input.GetAxis("Vertical"));
			this.KCLACNEILLB.SetFloat("ForwardVelocity", this.forwardVelocity);
			if (Input.GetAxis("Vertical") < 0f && Input.GetButton("Vertical"))
			{
				this.KCLACNEILLB.SetBool("Brake", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("Brake", false);
			}
			if (Input.GetButtonDown("Vertical") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("Vertical") > 0f)
				{
					this.forwardVelocity += Input.GetAxis("Vertical");
				}
				else if (Input.GetAxis("Vertical") < 0f)
				{
					this.forwardVelocity += Input.GetAxis("Vertical") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 0f)
				{
					this.forwardVelocity = 0f;
				}
			}
			if (!Input.GetButtonDown("Vertical"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 0f)
				{
					this.forwardVelocity = 0f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(0f, 0f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(0f, Input.GetAxis("Horizontal"), 0f);
			if (Input.GetButton("Jump"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000DBF98 File Offset: 0x000DA198
	private void JLFBDOPFDDJ()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("Apply out GAME 1", Input.GetAxis("SUNSHINE_FILTER_HARD"));
			this.KCLACNEILLB.SetFloat("One of the Bones is null.", Input.GetAxis("name"));
			this.KCLACNEILLB.SetFloat("cut.ogg", this.forwardVelocity);
			if (Input.GetAxis("crft_selwpn") < 1872f && Input.GetButton("_FogNoiseData"))
			{
				this.KCLACNEILLB.SetBool("8", false);
			}
			else
			{
				this.KCLACNEILLB.SetBool("FBIK chain is null, can't initiate solver.", true);
			}
			if (Input.GetButtonDown("Katana") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("-S") > 1220f)
				{
					this.forwardVelocity += Input.GetAxis("_AddCountitem.wav");
				}
				else if (Input.GetAxis("[userfish]") < 1035f)
				{
					this.forwardVelocity += Input.GetAxis("Mouse X") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1393f)
				{
					this.forwardVelocity = 718f;
				}
			}
			if (!Input.GetButtonDown("1HandSwordChargeUp"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1656f)
				{
					this.forwardVelocity = 167f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(1025f, 394f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(876f, Input.GetAxis("-none-"), 1713f);
			if (Input.GetButton("Invalid ObscuredVector2 index!"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x000DC1CC File Offset: 0x000DA3CC
	private void PGIHAIPCJLL()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("MotorbikeLassoRight", Input.GetAxis("refine"));
			this.KCLACNEILLB.SetFloat(" ms", Input.GetAxis("maxdeep"));
			this.KCLACNEILLB.SetFloat("qname_", this.forwardVelocity);
			if (Input.GetAxis("USER") < 66f && Input.GetButton("_CustomUVS"))
			{
				this.KCLACNEILLB.SetBool("_SunPosition", false);
			}
			else
			{
				this.KCLACNEILLB.SetBool("_Cutoff", false);
			}
			if (Input.GetButtonDown("USE_DEPTH") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("") > 1389f)
				{
					this.forwardVelocity += Input.GetAxis("<color='#206000'>");
				}
				else if (Input.GetAxis("{not_found}") < 483f)
				{
					this.forwardVelocity += Input.GetAxis("MotorbikeLassoRight") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1423f)
				{
					this.forwardVelocity = 954f;
				}
			}
			if (!Input.GetButtonDown("Water"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1195f)
				{
					this.forwardVelocity = 150f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(1316f, 220f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(699f, Input.GetAxis("2048"), 843f);
			if (Input.GetButton(" x"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000DC400 File Offset: 0x000DA600
	private void OFPGMNGFLNH()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("Ankle", Input.GetAxis(" / "));
			this.KCLACNEILLB.SetFloat("ClimbRight", Input.GetAxis(""));
			this.KCLACNEILLB.SetFloat("RollerBladeSkateFwd", this.forwardVelocity);
			if (Input.GetAxis("_UserLutTex") < 1427f && Input.GetButton("SoccerSprint"))
			{
				this.KCLACNEILLB.SetBool("USE_MASK", false);
			}
			else
			{
				this.KCLACNEILLB.SetBool(".", false);
			}
			if (Input.GetButtonDown("#004000") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("Running Dance") > 332f)
				{
					this.forwardVelocity += Input.GetAxis("TOD_World2Sky");
				}
				else if (Input.GetAxis("VIGNETTE_BLUR") < 958f)
				{
					this.forwardVelocity += Input.GetAxis("wpn_bait_inf_{0}") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 103f)
				{
					this.forwardVelocity = 1640f;
				}
			}
			if (!Input.GetButtonDown("post_2"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 205f)
				{
					this.forwardVelocity = 1840f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(204f, 723f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(1121f, Input.GetAxis("IdleMonster"), 248f);
			if (Input.GetButton("Speed hack detected!"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void IIKDDILLGLF()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void EDGALMCHPPH()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x000DC68C File Offset: 0x000DA88C
	private void LBGKAMLLACN()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("MotorbikeLassoRight", Input.GetAxis(""));
			this.KCLACNEILLB.SetFloat("Anchore Left_", Input.GetAxis("Mouse X"));
			this.KCLACNEILLB.SetFloat("[quote]", this.forwardVelocity);
			if (Input.GetAxis("Hand") < 1129f && Input.GetButton("WalkBackward"))
			{
				this.KCLACNEILLB.SetBool("wpn_lv", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("", false);
			}
			if (Input.GetButtonDown("time") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("☰☰☰") > 1240f)
				{
					this.forwardVelocity += Input.GetAxis("Deadman Float");
				}
				else if (Input.GetAxis("") < 1615f)
				{
					this.forwardVelocity += Input.GetAxis("Katana45DegSwing") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 457f)
				{
					this.forwardVelocity = 1782f;
				}
			}
			if (!Input.GetButtonDown("IdleStrafeLeft"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1048f)
				{
					this.forwardVelocity = 1309f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(605f, 402f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(1435f, Input.GetAxis(""), 91f);
			if (Input.GetButton("ushort:"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x000DC8C0 File Offset: 0x000DAAC0
	private void DFFOEGHGPGP()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat(" Collider", Input.GetAxis("Right"));
			this.KCLACNEILLB.SetFloat("RunBackLeft", Input.GetAxis(" (hair back)"));
			this.KCLACNEILLB.SetFloat("SoccerStartKick", this.forwardVelocity);
			if (Input.GetAxis("crft_cost") < 1347f && Input.GetButton("ShootWireframeModule"))
			{
				this.KCLACNEILLB.SetBool("NadeThrow", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("WorkerPickaxe", false);
			}
			if (Input.GetButtonDown("Please assign all Bones to the IK solver.") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("languageid") > 1215f)
				{
					this.forwardVelocity += Input.GetAxis("CardPlayerIdle");
				}
				else if (Input.GetAxis("offsets") < 1751f)
				{
					this.forwardVelocity += Input.GetAxis("_FresnelFade") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1636f)
				{
					this.forwardVelocity = 1349f;
				}
			}
			if (!Input.GetButtonDown("OfficeSitting45DegLeg"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1864f)
				{
					this.forwardVelocity = 117f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(1262f, 1706f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(1288f, Input.GetAxis("Visit docs to see where PlayerPrefs are stored"), 1039f);
			if (Input.GetButton("Forward"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void INDGOHJGCFN()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x000DCAF4 File Offset: 0x000DACF4
	private void AIAMIFEPALP()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("IceHockeyGoalieSave1", Input.GetAxis("_Lift"));
			this.KCLACNEILLB.SetFloat("SwimFreestyle", Input.GetAxis("Obscured type cheating detected!"));
			this.KCLACNEILLB.SetFloat("t_top", this.forwardVelocity);
			if (Input.GetAxis("reflectQuality") < 1133f && Input.GetButton("Try to change this Vector3 in memory:\n"))
			{
				this.KCLACNEILLB.SetBool("1HandSwordChargeHeavyBash", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("Here you can overview common ACTk features and try to cheat something yourself.", true);
			}
			if (Input.GetButtonDown("palm") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("Initiating IKSolver with null root Transform.") > 468f)
				{
					this.forwardVelocity += Input.GetAxis("");
				}
				else if (Input.GetAxis("Wand Attack 2") < 1494f)
				{
					this.forwardVelocity += Input.GetAxis("") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 783f)
				{
					this.forwardVelocity = 1487f;
				}
			}
			if (!Input.GetButtonDown("error"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 139f)
				{
					this.forwardVelocity = 1162f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(111f, 1818f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(1830f, Input.GetAxis("***Setting OnEnable "), 676f);
			if (Input.GetButton("FistPump"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void Start()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void AOCDDBNBADJ()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x000DCD28 File Offset: 0x000DAF28
	private void LIOCDEICIFD()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("http://j.mp/1FRAL5L", Input.GetAxis("UIChat_channel"));
			this.KCLACNEILLB.SetFloat("", Input.GetAxis("file"));
			this.KCLACNEILLB.SetFloat("no_inventory", this.forwardVelocity);
			if (Input.GetAxis("S") < 1611f && Input.GetButton("[ACTk] <b>[ ObscuredVector3 test ]</b>"))
			{
				this.KCLACNEILLB.SetBool("_Offsets", false);
			}
			else
			{
				this.KCLACNEILLB.SetBool("knopje.wav", false);
			}
			if (Input.GetButtonDown("error") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("wpn_tank2") > 643f)
				{
					this.forwardVelocity += Input.GetAxis("RunningDance");
				}
				else if (Input.GetAxis("drag_onmousedown.wav") < 612f)
				{
					this.forwardVelocity += Input.GetAxis("crft_crft") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1527f)
				{
					this.forwardVelocity = 353f;
				}
			}
			if (!Input.GetButtonDown("InteractionSystem can not find a FullBodyBipedIK component"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 14f)
				{
					this.forwardVelocity = 546f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(730f, 1557f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(261f, Input.GetAxis("Bilateral Blur"), 1267f);
			if (Input.GetButton("lut-volume.png"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void HDFCIACDDEK()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void MCHAAIIHOKD()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void HHGGCBLOJGB()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x000DBD48 File Offset: 0x000D9F48
	private void CBLGFOFHNPJ()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000DCF5C File Offset: 0x000DB15C
	private void IGEICBNMPAD()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat(" x", Input.GetAxis("RenderType"));
			this.KCLACNEILLB.SetFloat("", Input.GetAxis("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()"));
			this.KCLACNEILLB.SetFloat("crft_ingr", this.forwardVelocity);
			if (Input.GetAxis("gamma") < 112f && Input.GetButton(")"))
			{
				this.KCLACNEILLB.SetBool("error.wav", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("", false);
			}
			if (Input.GetButtonDown("MotorbikeHandstand") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("") > 338f)
				{
					this.forwardVelocity += Input.GetAxis("[ACTk] <b>[ ObscuredFloat test ]</b>");
				}
				else if (Input.GetAxis("Citates.xml") < 957f)
				{
					this.forwardVelocity += Input.GetAxis("Dealer Shuffle") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1229f)
				{
					this.forwardVelocity = 245f;
				}
			}
			if (!Input.GetButtonDown("Kernel"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1122f)
				{
					this.forwardVelocity = 136f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(898f, 1129f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(1531f, Input.GetAxis("Interrupt"), 1880f);
			if (Input.GetButton("error"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x000DD190 File Offset: 0x000DB390
	private void BOAJJAKEMLH()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat("IdleSandCover", Input.GetAxis("_Texture"));
			this.KCLACNEILLB.SetFloat("allrec.ogg", Input.GetAxis("Roar"));
			this.KCLACNEILLB.SetFloat("componentA", this.forwardVelocity);
			if (Input.GetAxis("Leg") < 237f && Input.GetButton("0_"))
			{
				this.KCLACNEILLB.SetBool("wpn_wgt", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("RollerBladeSkateFwd", true);
			}
			if (Input.GetButtonDown("cntx_close") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("How your health bar is stored in memory when obscured:\n") > 372f)
				{
					this.forwardVelocity += Input.GetAxis("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!");
				}
				else if (Input.GetAxis(" ") < 1370f)
				{
					this.forwardVelocity += Input.GetAxis("IdleDie2") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 1331f)
				{
					this.forwardVelocity = 1031f;
				}
			}
			if (!Input.GetButtonDown("TOD_SpaceTiling"))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1835f)
				{
					this.forwardVelocity = 294f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(1860f, 354f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(809f, Input.GetAxis("Yawn"), 1935f);
			if (Input.GetButton("\n"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x000DD3C4 File Offset: 0x000DB5C4
	private void JPHLMNIMDHH()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.KCLACNEILLB.SetFloat(" ", Input.GetAxis("_PrevViewProj"));
			this.KCLACNEILLB.SetFloat("u_email", Input.GetAxis("WateringCan"));
			this.KCLACNEILLB.SetFloat("_DitheringCoords", this.forwardVelocity);
			if (Input.GetAxis("WSRButton error") < 187f && Input.GetButton("SecondaryCausticsProjector"))
			{
				this.KCLACNEILLB.SetBool("BowFire", true);
			}
			else
			{
				this.KCLACNEILLB.SetBool("Cloth_05_00.wav", false);
			}
			if (Input.GetButtonDown("Anti-Cheat Toolkit Detectors") || this.forwardVelocity < this.speed)
			{
				if (Input.GetAxis("MotorbikeWheelyNoHands") > 70f)
				{
					this.forwardVelocity += Input.GetAxis("wpn_rod2");
				}
				else if (Input.GetAxis("Sound ") < 1132f)
				{
					this.forwardVelocity += Input.GetAxis("crft_cnt") * this.brakeSpeed;
				}
				if (this.forwardVelocity > this.speed)
				{
					this.forwardVelocity = this.speed;
				}
				if (this.forwardVelocity < 289f)
				{
					this.forwardVelocity = 1707f;
				}
			}
			if (!Input.GetButtonDown(""))
			{
				this.forwardVelocity -= this.slowdownSpeed;
				if (this.forwardVelocity < 1018f)
				{
					this.forwardVelocity = 468f;
				}
			}
			this.JDFLHKMFHBJ = new Vector3(738f, 1593f, this.forwardVelocity);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.PPMCJPHCOIA.transform.Rotate(532f, Input.GetAxis("error"), 1982f);
			if (Input.GetButton("Start.tif"))
			{
				this.JDFLHKMFHBJ.y = this.jumpSpeed;
			}
		}
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x040002EC RID: 748
	private Animator KCLACNEILLB;

	// Token: 0x040002ED RID: 749
	private CharacterController PPMCJPHCOIA;

	// Token: 0x040002EE RID: 750
	public float speed = 6f;

	// Token: 0x040002EF RID: 751
	public float jumpSpeed = 8f;

	// Token: 0x040002F0 RID: 752
	public float gravity = 20f;

	// Token: 0x040002F1 RID: 753
	public float slowdownSpeed = 0.05f;

	// Token: 0x040002F2 RID: 754
	public float brakeSpeed = 0.005f;

	// Token: 0x040002F3 RID: 755
	public float forwardVelocity;

	// Token: 0x040002F4 RID: 756
	private Vector3 JDFLHKMFHBJ = Vector3.zero;
}
