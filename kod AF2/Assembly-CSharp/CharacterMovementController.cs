using System;
using UnityEngine;

// Token: 0x02000068 RID: 104
public class CharacterMovementController : MonoBehaviour
{
	// Token: 0x06001749 RID: 5961 RVA: 0x000C6C4C File Offset: 0x000C4E4C
	private void EIKNJKFBDOB()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("IdleStrafeRight") == 1075f && this.KCLACNEILLB.GetFloat("INTERFACE") > 910f)
			{
				if (Input.GetButton("WoodCut"))
				{
					this.KCLACNEILLB.SetBool("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", false);
				}
				if (this.KCLACNEILLB.GetFloat("cntx_close") == 1070f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("PrimaryCausticsProjector", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("StaffStand") > 1443f)
		{
			this.KCLACNEILLB.SetBool("IdleRun", true);
		}
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x000C6D14 File Offset: 0x000C4F14
	private void NAONNJMHIPH()
	{
		if (Input.GetButtonDown("IdleSad"))
		{
			this.pistol = false;
		}
		else if (Input.GetButtonDown(""))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1506f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 692f, Time.deltaTime * 1871f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 94f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1980f, Time.deltaTime * 1165f));
		}
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x000C6DD4 File Offset: 0x000C4FD4
	private void HAENBDBAODC()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("") == 176f && this.KCLACNEILLB.GetFloat("cht_tofrendmsg") > 71f)
			{
				if (Input.GetButton("IdleSlide"))
				{
					this.KCLACNEILLB.SetBool("", true);
				}
				if (this.KCLACNEILLB.GetFloat("IdleButtonPress") == 379f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("[[", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("leg") > 1567f)
		{
			this.KCLACNEILLB.SetBool("</color>", true);
		}
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x000C6E9C File Offset: 0x000C509C
	private void IKEACKIMHLH()
	{
		if (Input.GetButtonDown("Criticals"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("CardPlayerLook"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 20f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 401f, Time.deltaTime * 695f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 407f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 567f, Time.deltaTime * 1373f));
		}
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void Start()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void CGNGBFFGGBP()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x000C6F74 File Offset: 0x000C5174
	private void EMFOECIPBIP()
	{
		base.transform.Rotate(803f, Input.GetAxis(" гр "), 706f);
		this.MFANMLMPGEH();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("---"), 872f, Input.GetAxis("Flares"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("focus :D"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1759f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1975f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("crft_selwpn", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("shop_t13", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.MEMCEGKDKMF();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x000C70F0 File Offset: 0x000C52F0
	private void OAGEFCIOGFD()
	{
		if (Input.GetButtonDown("{0}"))
		{
			this.pistol = false;
		}
		else if (Input.GetButtonDown("act_orderb_2"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 573f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1919f, Time.deltaTime * 1311f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 1534f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 385f, Time.deltaTime * 1511f));
		}
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x000C71B0 File Offset: 0x000C53B0
	private void IOGAKGCADBL()
	{
		base.transform.Rotate(524f, Input.GetAxis("ResetObject"), 1454f);
		this.AGPFFPADADI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("auk_wmax"), 653f, Input.GetAxis("</color>"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("IKSolverLookAt head transform is null. Can't initiate solver."))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 915f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1802f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("HDR", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("final ok: ", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.JLBHKKEAEPD();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x000C732C File Offset: 0x000C552C
	private void JAMGOEJHOFG()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("MotorbikeLasso") == 1328f && this.KCLACNEILLB.GetFloat("lifeBar") > 1950f)
			{
				if (Input.GetButton("WorkerShovel"))
				{
					this.KCLACNEILLB.SetBool("error.wav", true);
				}
				if (this.KCLACNEILLB.GetFloat("goSpiralCenter") == 713f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("WizardPowerUp", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("RunBackLeft") > 1331f)
		{
			this.KCLACNEILLB.SetBool("<color='#202020'>", true);
		}
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x000C73F4 File Offset: 0x000C55F4
	private void BDMAMEFNIEN()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("t_top") == 738f && this.KCLACNEILLB.GetFloat("_DayToNight") > 1709f)
			{
				if (Input.GetButton("demoByteArray"))
				{
					this.KCLACNEILLB.SetBool("Textures/Bases/", false);
				}
				if (this.KCLACNEILLB.GetFloat("_RgbTex") == 1210f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("low_root_level", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("Windows") > 1349f)
		{
			this.KCLACNEILLB.SetBool("http://www.root-motion.com/finalikdox/html/page2.html", false);
		}
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x000C74BC File Offset: 0x000C56BC
	private void PGNJCIKFGPI()
	{
		if (Input.GetButtonDown("-l-"))
		{
			this.pistol = false;
		}
		else if (Input.GetButtonDown("CrouchWalkBackward"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 400f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1825f, Time.deltaTime * 709f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 110f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1020f, Time.deltaTime * 31f));
		}
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x000C757C File Offset: 0x000C577C
	private void DFPFGJJDIJG()
	{
		if (Input.GetButtonDown(""))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("Positions"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1310f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1690f, Time.deltaTime * 708f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 1184f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1726f, Time.deltaTime * 1700f));
		}
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x000C763C File Offset: 0x000C583C
	private void LEKDIGBOKGD()
	{
		if (Input.GetButtonDown("\n"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("time_format2"))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 429f)
			{
				this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1830f, Time.deltaTime * 1594f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 1937f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 140f, Time.deltaTime * 1371f));
		}
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x000C76FC File Offset: 0x000C58FC
	private void FPHKDGBPLHI()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("\n") == 1181f && this.KCLACNEILLB.GetFloat("KatanaNinjaDraw") > 1107f)
			{
				if (Input.GetButton("silence"))
				{
					this.KCLACNEILLB.SetBool("_ToPrevViewProjCombined", false);
				}
				if (this.KCLACNEILLB.GetFloat("FistPump2") == 271f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("t_bottom", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("_Power") > 759f)
		{
			this.KCLACNEILLB.SetBool("", true);
		}
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x000C77C4 File Offset: 0x000C59C4
	private void EKCKBDKEAKO()
	{
		base.transform.Rotate(839f, Input.GetAxis("ECHO ON "), 1401f);
		this.DFPFGJJDIJG();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("MotorbikeLassoLeft"), 1327f, Input.GetAxis("SpinReel.ogg"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("WorkerPickaxe"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 248f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1787f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Grounding has 0 legs. Can't initiate Grounding.", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("_LerpRgbTex", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.BDMAMEFNIEN();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void AFFAJKPPMHF()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x000C7940 File Offset: 0x000C5B40
	private void JIFOELPAEHG()
	{
		base.transform.Rotate(1460f, Input.GetAxis("inv_useeff"), 1527f);
		this.DDOKIABCDNP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("IdleButtonPress"), 1311f, Input.GetAxis("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("wpn_line1"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1493f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 345f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("wpn_eat5", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("IceHockey Idle", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.GBENFBOBBKM();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x000C7ABC File Offset: 0x000C5CBC
	private void JBHCKCIBBBP()
	{
		if (Input.GetButtonDown("#c0c0c0"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("Cowboy1HandDraw"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 556f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 805f, Time.deltaTime * 1812f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 622f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1812f, Time.deltaTime * 106f));
		}
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x000C7B7C File Offset: 0x000C5D7C
	private void LDDIGEMBDNF()
	{
		base.transform.Rotate(434f, Input.GetAxis("Hair"), 1394f);
		this.CFOKAENANEI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("knopje.wav"), 1426f, Input.GetAxis("_ReflectionTexture1"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("\n"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1811f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 86f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("wpn_add/base", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("usrfrom_ignor", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.PEFCIDPBHDL();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x000C7CF8 File Offset: 0x000C5EF8
	private void DIBHPHPMLOB()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("spawnPet") == 1947f && this.KCLACNEILLB.GetFloat("wpn_add/base") > 211f)
			{
				if (Input.GetButton("invn_rec5"))
				{
					this.KCLACNEILLB.SetBool("_DepthScale", false);
				}
				if (this.KCLACNEILLB.GetFloat("float:") == 194f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("Anchore Left_", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("SixStep") > 1575f)
		{
			this.KCLACNEILLB.SetBool("start.ogg", false);
		}
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void JHFAHBIIJDC()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x000C7DC0 File Offset: 0x000C5FC0
	private void MMDLKPGKEMA()
	{
		if (Input.GetButtonDown("_SunColor"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("wpn_eat1"))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 115f)
			{
				this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1834f, Time.deltaTime * 1621f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 496f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 968f, Time.deltaTime * 1167f));
		}
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void CAJLCEPLKJG()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x000C7E80 File Offset: 0x000C6080
	private void FOKJLPBPLGP()
	{
		if (Input.GetButtonDown("_MaskTex"))
		{
			this.pistol = false;
		}
		else if (Input.GetButtonDown("SuicideHeadShot"))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 842f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1422f, Time.deltaTime * 359f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 1589f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 953f, Time.deltaTime * 47f));
		}
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x000C7F40 File Offset: 0x000C6140
	private void MFMLGHLEOBL()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("enable") == 119f && this.KCLACNEILLB.GetFloat("UI_MapWindow_b") > 1776f)
			{
				if (Input.GetButton("cntx_close"))
				{
					this.KCLACNEILLB.SetBool("Saves protection", false);
				}
				if (this.KCLACNEILLB.GetFloat("demoByteArray") == 545f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("<color='#000030'>+{0} {1}</color>") > 996f)
		{
			this.KCLACNEILLB.SetBool("Flap_02.wav", true);
		}
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void KGICJDGIIJK()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x000C8008 File Offset: 0x000C6208
	private void DEGCCLNOEKJ()
	{
		base.transform.Rotate(327f, Input.GetAxis("CraftProf.xml"), 1368f);
		this.DDOKIABCDNP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("<i><color='#202020'>"), 1111f, Input.GetAxis("cnt_energ"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton(""))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1998f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1007f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("1 Hand Sword Ready", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("Jump", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.DOECJBJNFMJ();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x000C8184 File Offset: 0x000C6384
	private void HAJBKJFNFBK()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("wpnlang/wpntypes/type DUBLICATE ") == 103f && this.KCLACNEILLB.GetFloat("ProneIdle") > 1227f)
			{
				if (Input.GetButton("1HandSmallWeaponCombo"))
				{
					this.KCLACNEILLB.SetBool("quests/tnames/turn", false);
				}
				if (this.KCLACNEILLB.GetFloat("SAMPLES_MEDIUM") == 1879f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("MotorbikeLassoFwd", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("Giant Eat") > 602f)
		{
			this.KCLACNEILLB.SetBool("lifeBar", false);
		}
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x000C824C File Offset: 0x000C644C
	private void JHOJCCONLGD()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("crft_btn1") == 1607f && this.KCLACNEILLB.GetFloat("OfficeSittingMouseMovement") > 1336f)
			{
				if (Input.GetButton("SoccerTackle"))
				{
					this.KCLACNEILLB.SetBool("\n", false);
				}
				if (this.KCLACNEILLB.GetFloat("shop_t4") == 1769f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("2", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("{0:00} m") > 1355f)
		{
			this.KCLACNEILLB.SetBool("fishSTOPTMR=", true);
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x000C8314 File Offset: 0x000C6514
	private void EMHGNEMIGII()
	{
		base.transform.Rotate(1700f, Input.GetAxis("Poplavok"), 563f);
		this.NJEBLNGOKCO();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("IdleBandage"), 1830f, Input.GetAxis("IdleReady"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("<color='#004000'>"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1599f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 84f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("1HandSwordJabFootPush", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("NadeThrow", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.DOECJBJNFMJ();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x000C8490 File Offset: 0x000C6690
	private void CJEPELOKLPN()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("IceHockeyPassLeft") == 1400f && this.KCLACNEILLB.GetFloat("WeaponStrafeRunLeft") > 1576f)
			{
				if (Input.GetButton("Quadruped"))
				{
					this.KCLACNEILLB.SetBool("x", false);
				}
				if (this.KCLACNEILLB.GetFloat("rait_4") == 1767f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("_Offsets", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("space") > 1842f)
		{
			this.KCLACNEILLB.SetBool("bs_lowlv", false);
		}
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x000C8558 File Offset: 0x000C6758
	private void JFGGBEGNAFP()
	{
		base.transform.Rotate(1322f, Input.GetAxis("IdleStand"), 1714f);
		this.PGNJCIKFGPI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("OK"), 628f, Input.GetAxis("_BlurCoe"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("cht_msg34"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 71f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1852f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("sunshine_ShadowCoordDepthRayU", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("* change", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.EIKNJKFBDOB();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x000C86D4 File Offset: 0x000C68D4
	private void FOHLAIIMNFB()
	{
		base.transform.Rotate(1727f, Input.GetAxis("cellicon"), 768f);
		this.OKEGJNCNJGA();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("FogAreaCullingManager missing script."), 294f, Input.GetAxis(" "));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("WallRunLeft"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1052f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1626f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("WATER_SIMPLE", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("wpn_fid1", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.CGCHPGIMDKE();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void ANHOOJFEJJE()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x000C8850 File Offset: 0x000C6A50
	private void PFNOEACNHON()
	{
		base.transform.Rotate(862f, Input.GetAxis("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module)."), 253f);
		this.PGNJCIKFGPI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("_Overlay"), 358f, Input.GetAxis("RollerBladeJump"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("Attached object"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 170f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1252f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat(">", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("-L-", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.JAMGOEJHOFG();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x000C89CC File Offset: 0x000C6BCC
	private void MEMCEGKDKMF()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("1") == 977f && this.KCLACNEILLB.GetFloat("wpn_book1") > 1644f)
			{
				if (Input.GetButton("isHarvest"))
				{
					this.KCLACNEILLB.SetBool("Hyperlink_", false);
				}
				if (this.KCLACNEILLB.GetFloat("IceHockeyGoalieSave2") == 1003f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("stat: ", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("Fist Pump") > 1273f)
		{
			this.KCLACNEILLB.SetBool("U", false);
		}
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x000C8A94 File Offset: 0x000C6C94
	private void BEDAJLJFAFO()
	{
		base.transform.Rotate(876f, Input.GetAxis("Scuba OK"), 930f);
		this.AGPFFPADADI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis(""), 1431f, Input.GetAxis("GiantGrabIdle2"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("MotorbikeShootRight"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 655f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1464f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("_MaxRayTraceDistance", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("Assets/Weapons/bootsBase.unity3d", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.BDMAMEFNIEN();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x000C8C10 File Offset: 0x000C6E10
	private void JLBHKKEAEPD()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("End") == 1631f && this.KCLACNEILLB.GetFloat("\n") > 966f)
			{
				if (Input.GetButton("contrast"))
				{
					this.KCLACNEILLB.SetBool("DISTORT", true);
				}
				if (this.KCLACNEILLB.GetFloat("*** Perks is init") == 1882f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("cht_msg10", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("{0:F2}, {1:F2}, {2:F2}, {3:F2}") > 1923f)
		{
			this.KCLACNEILLB.SetBool("{0} FPS", true);
		}
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x000C8CD8 File Offset: 0x000C6ED8
	private void LBGKAMLLACN()
	{
		base.transform.Rotate(737f, Input.GetAxis("Flashlight"), 1756f);
		this.FOKJLPBPLGP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("craft_data/categories/category"), 1496f, Input.GetAxis("OfficeSittingReadingLeanBack"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("Flap_00.wav"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1260f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 267f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("cht_msg1", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("level", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.JLBHKKEAEPD();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void CPNOBMNKPNC()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void BJHGPFGBFKF()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x000C8E54 File Offset: 0x000C7054
	private void DDOKIABCDNP()
	{
		if (Input.GetButtonDown("Pistol"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("Unarmed"))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 0.999999f)
			{
				this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1f, Time.deltaTime * 3f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 1E-06f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 0f, Time.deltaTime * 3f));
		}
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void HHGGCBLOJGB()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x000C8F30 File Offset: 0x000C7130
	private void DOECJBJNFMJ()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("ui_default_click.wav") == 1100f && this.KCLACNEILLB.GetFloat("") > 985f)
			{
				if (Input.GetButton(""))
				{
					this.KCLACNEILLB.SetBool("DISTORT", true);
				}
				if (this.KCLACNEILLB.GetFloat("ui_place_flag.wav") == 408f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("RollerBladeCrossoverLeft", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("ArmFlex4") > 171f)
		{
			this.KCLACNEILLB.SetBool("Cowboy1HandDraw", false);
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x000C8FF8 File Offset: 0x000C71F8
	private void EDANNBFJHIK()
	{
		base.transform.Rotate(335f, Input.GetAxis("SkateboardKickPush"), 1706f);
		this.PGNJCIKFGPI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("http://www.root-motion.com/finalikdox/html/page2.html"), 967f, Input.GetAxis("IdleBandage"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton(", second bone: "))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 799f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 8f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Swim Dog Paddle", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("distscale", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.MFMLGHLEOBL();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x000C9174 File Offset: 0x000C7374
	private void MBCGDNKKGHI()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("req_prof") == 790f && this.KCLACNEILLB.GetFloat("Модификация предмета") > 557f)
			{
				if (Input.GetButton("RollerBladeTurnLeft"))
				{
					this.KCLACNEILLB.SetBool("{0}", false);
				}
				if (this.KCLACNEILLB.GetFloat(".unity3d") == 181f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("demoVector2", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat(">") > 1335f)
		{
			this.KCLACNEILLB.SetBool("_UserLutParams", false);
		}
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x000C923C File Offset: 0x000C743C
	private void INKGAFANFIB()
	{
		base.transform.Rotate(812f, Input.GetAxis("id"), 1859f);
		this.IKEACKIMHLH();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis(")"), 310f, Input.GetAxis("INTERFACE"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("IKSolverFABRIKRoot chain at index "))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1148f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1881f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Active Process ", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("\n", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.FPHKDGBPLHI();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void JCELICPHGEP()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x000C93B8 File Offset: 0x000C75B8
	private void MFANMLMPGEH()
	{
		if (Input.GetButtonDown("wpn_add/base"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("no_move_sadok"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1390f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 299f, Time.deltaTime * 1901f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 1804f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1882f, Time.deltaTime * 1964f));
		}
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x000C9478 File Offset: 0x000C7678
	private void KOEPJFBBDNP()
	{
		if (Input.GetButtonDown("<color='#000000'>"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("Idle Standing Jump"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 1296f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1268f, Time.deltaTime * 692f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(0) > 792f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 641f, Time.deltaTime * 270f));
		}
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x000C9538 File Offset: 0x000C7738
	private void Update()
	{
		base.transform.Rotate(0f, Input.GetAxis("Mouse X"), 0f);
		this.DDOKIABCDNP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("Sprint"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 2f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 2f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("MovementX", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("MovementZ", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.CGCHPGIMDKE();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x000C96B4 File Offset: 0x000C78B4
	private void GPGCCIHIFLH()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("wpn_eat1") == 327f && this.KCLACNEILLB.GetFloat("wpn_line3") > 138f)
			{
				if (Input.GetButton("ClimbIdle"))
				{
					this.KCLACNEILLB.SetBool("wpn_eat8", true);
				}
				if (this.KCLACNEILLB.GetFloat("OfficeSittingEyesRub") == 424f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("1HandSwordChargeUp", true);
			}
		}
		if (this.KCLACNEILLB.GetFloat("WallRunRight") > 1076f)
		{
			this.KCLACNEILLB.SetBool("404040", true);
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x000C977C File Offset: 0x000C797C
	private void HONIFOPBBKC()
	{
		base.transform.Rotate(1509f, Input.GetAxis("_FogScatteringData"), 852f);
		this.IKEACKIMHLH();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("_NoiseTex"), 110f, Input.GetAxis("CrawlLocomotion"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("shop_t7"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1909f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 141f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("IdleSadHips", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("Radius", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.PEFCIDPBHDL();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void EDGALMCHPPH()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x000C98F8 File Offset: 0x000C7AF8
	private void PEFCIDPBHDL()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("#ffa0a0") == 1298f && this.KCLACNEILLB.GetFloat("SexyDance2") > 1164f)
			{
				if (Input.GetButton("btn_cancel"))
				{
					this.KCLACNEILLB.SetBool(" This is not possible to be called for standalone input. Please check your platform and code where this is called", true);
				}
				if (this.KCLACNEILLB.GetFloat("bag") == 199f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("Katana", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("isHarvest") > 1775f)
		{
			this.KCLACNEILLB.SetBool("demoVector3", true);
		}
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000C99C0 File Offset: 0x000C7BC0
	private void OKEGJNCNJGA()
	{
		if (Input.GetButtonDown("Reset"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("languageid"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1530f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 37f, Time.deltaTime * 711f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 832f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1333f, Time.deltaTime * 1659f));
		}
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000C9A80 File Offset: 0x000C7C80
	private void LLDPCDIOMJH()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("F3") == 584f && this.KCLACNEILLB.GetFloat("isUsedPersonal") > 1104f)
			{
				if (Input.GetButton("fishsplash{0}.ogg"))
				{
					this.KCLACNEILLB.SetBool("post_5", true);
				}
				if (this.KCLACNEILLB.GetFloat("gi_um_2") == 871f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("RollerBladeBackFlip", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("SUNSHINE_FILTER_PCF_3x3") > 460f)
		{
			this.KCLACNEILLB.SetBool("sunshine_CascadeFarRatiosSq", false);
		}
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x000C9B48 File Offset: 0x000C7D48
	private void AGPFFPADADI()
	{
		if (Input.GetButtonDown("</color>"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("_VignetteBlur"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1294f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 69f, Time.deltaTime * 1043f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 782f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 1889f, Time.deltaTime * 1356f));
		}
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x000C9C08 File Offset: 0x000C7E08
	private void IGEICBNMPAD()
	{
		base.transform.Rotate(93f, Input.GetAxis("GiantEat"), 1306f);
		this.PGNJCIKFGPI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("<color='#a060ff'>{0}</color>: {1}"), 352f, Input.GetAxis("OneHandSwordBackSwing"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("RollerBladeCrossoverRight"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 816f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 189f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Vertical", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("BowFire", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.CJEPELOKLPN();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x000C9D84 File Offset: 0x000C7F84
	private void GBENFBOBBKM()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("SoccerSprint") == 1107f && this.KCLACNEILLB.GetFloat("") > 1386f)
			{
				if (Input.GetButton("\n"))
				{
					this.KCLACNEILLB.SetBool("_TrStartYou.ogg", true);
				}
				if (this.KCLACNEILLB.GetFloat("gi_fridgice") == 395f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("MotorbikeWheely", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("<color='#100000'>{0} {1}</color>") > 1292f)
		{
			this.KCLACNEILLB.SetBool("_RcpMaxCoC", false);
		}
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x000C9E4C File Offset: 0x000C804C
	private void NJEBLNGOKCO()
	{
		if (Input.GetButtonDown("SelfBleedReduction"))
		{
			this.pistol = false;
		}
		else if (Input.GetButtonDown("1 Hand Sword Roll Attack"))
		{
			this.pistol = true;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(0) < 1601f)
			{
				this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1020f, Time.deltaTime * 1308f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 425f)
		{
			this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(1), 488f, Time.deltaTime * 797f));
		}
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x000C9F0C File Offset: 0x000C810C
	private void CFOKAENANEI()
	{
		if (Input.GetButtonDown("sunshine_CameraVToSunVP"))
		{
			this.pistol = true;
		}
		else if (Input.GetButtonDown("post_18"))
		{
			this.pistol = false;
		}
		if (this.pistol)
		{
			if (this.KCLACNEILLB.GetLayerWeight(1) < 816f)
			{
				this.KCLACNEILLB.SetLayerWeight(0, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1862f, Time.deltaTime * 1279f));
				return;
			}
		}
		else if (this.KCLACNEILLB.GetLayerWeight(1) > 907f)
		{
			this.KCLACNEILLB.SetLayerWeight(1, Mathf.Lerp(this.KCLACNEILLB.GetLayerWeight(0), 1741f, Time.deltaTime * 601f));
		}
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x000C9FCC File Offset: 0x000C81CC
	private void LMMDHJJJNJO()
	{
		base.transform.Rotate(580f, Input.GetAxis("100"), 265f);
		this.IKEACKIMHLH();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis(""), 329f, Input.GetAxis("{0} {1}\n{2}"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("Bow Idle"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 1302f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1801f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("wpn_timed", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("1HandSwordStrafeLeft", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.GBENFBOBBKM();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x000CA148 File Offset: 0x000C8348
	private void IEOICHPKEMD()
	{
		base.transform.Rotate(1045f, Input.GetAxis("IdleDrink"), 1894f);
		this.KOEPJFBBDNP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("FOG_AREA_BOX"), 373f, Input.GetAxis(" "));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("GetPoints() is not applicable to IKSolverVR."))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 907f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1550f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("MotorbikeHeadstand", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.MFMLGHLEOBL();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x000C6F5A File Offset: 0x000C515A
	private void PFNPOHMMJDN()
	{
		this.KCLACNEILLB = base.GetComponent<Animator>();
		this.PPMCJPHCOIA = base.GetComponent<CharacterController>();
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x000CA2C4 File Offset: 0x000C84C4
	private void CGCHPGIMDKE()
	{
		if (this.PPMCJPHCOIA.isGrounded)
		{
			if (Input.GetAxis("Horizontal") == 0f && this.KCLACNEILLB.GetFloat("MovementZ") > 1.3f)
			{
				if (Input.GetButton("Jump"))
				{
					this.KCLACNEILLB.SetBool("Jump", true);
				}
				if (this.KCLACNEILLB.GetFloat("JumpCurve") == 1f)
				{
					this.JDFLHKMFHBJ.y = this.jumpSpeed;
				}
			}
			else
			{
				this.KCLACNEILLB.SetBool("Jump", false);
			}
		}
		if (this.KCLACNEILLB.GetFloat("Curve") > 0.3f)
		{
			this.KCLACNEILLB.SetBool("Jump", false);
		}
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x000CA38C File Offset: 0x000C858C
	private void JOHDLNOKCOK()
	{
		base.transform.Rotate(286f, Input.GetAxis("RollerBladeFrontFlip"), 416f);
		this.FOKJLPBPLGP();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis(", "), 546f, Input.GetAxis("Image effects aren't supported on this device ({0})"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("no_wpn"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 728f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1537f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("bag", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("Sitting Reading Lean Back", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.DOECJBJNFMJ();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x000CA508 File Offset: 0x000C8708
	private void GDBBAMFMKII()
	{
		base.transform.Rotate(401f, Input.GetAxis(" шт"), 70f);
		this.CFOKAENANEI();
		if (this.PPMCJPHCOIA.isGrounded)
		{
			this.JDFLHKMFHBJ = new Vector3(Input.GetAxis("Visit docs to see where PlayerPrefs are stored"), 631f, Input.GetAxis("post_4"));
			this.movementSpeed = this.JDFLHKMFHBJ;
			if (Input.GetButton("************ Avatar is loaded"))
			{
				this.speed = Mathf.Lerp(this.speed, this.runSpeed, Time.deltaTime * 666f);
			}
			else
			{
				this.speed = Mathf.Lerp(this.speed, this.walkspeed, Time.deltaTime * 1791f);
			}
			this.movementSpeed *= this.speed;
			this.KCLACNEILLB.SetFloat("Breakdancing", this.movementSpeed.x);
			this.KCLACNEILLB.SetFloat("GAMMA", this.movementSpeed.z);
			this.JDFLHKMFHBJ = base.transform.TransformDirection(this.JDFLHKMFHBJ);
			this.JDFLHKMFHBJ *= this.speed;
		}
		this.GBENFBOBBKM();
		this.JDFLHKMFHBJ.y = this.JDFLHKMFHBJ.y - this.gravity * Time.deltaTime;
		this.PPMCJPHCOIA.Move(this.JDFLHKMFHBJ * Time.deltaTime);
	}

	// Token: 0x04000282 RID: 642
	public float speed;

	// Token: 0x04000283 RID: 643
	public float walkspeed;

	// Token: 0x04000284 RID: 644
	public float runSpeed;

	// Token: 0x04000285 RID: 645
	public float jumpSpeed;

	// Token: 0x04000286 RID: 646
	public float gravity;

	// Token: 0x04000287 RID: 647
	public bool pistol;

	// Token: 0x04000288 RID: 648
	private Vector3 JDFLHKMFHBJ = Vector3.zero;

	// Token: 0x04000289 RID: 649
	public Vector3 movementSpeed = Vector3.zero;

	// Token: 0x0400028A RID: 650
	private CharacterController PPMCJPHCOIA;

	// Token: 0x0400028B RID: 651
	private Animator KCLACNEILLB;
}
