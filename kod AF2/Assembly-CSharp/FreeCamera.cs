using System;
using UnityEngine;

// Token: 0x02000046 RID: 70
public class FreeCamera : MonoBehaviour
{
	// Token: 0x06001133 RID: 4403 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void PDAFMHBDONI()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void GFKOJHHNPOL()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x000A1EF7 File Offset: 0x000A00F7
	private void BDCKGFCOEGB(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.GFLLCHJOEDL();
		}
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x000A1F0C File Offset: 0x000A010C
	private void NOLKOIHEICD()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.BIDENDHHIKA();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.BIDENDHHIKA();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)1))
			{
				this.GFLLCHJOEDL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.PCGKBECFOAL();
			}
		}
		float axis = Input.GetAxis("WateringCan");
		float axis2 = Input.GetAxis("1");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 657f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1094f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey(KeyCode.Asterisk) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("GestureHandUp");
		float d2 = num * Input.GetAxis(" listed as it's child.");
		float d3 = num * ((Input.GetKey((KeyCode)(-63)) ? 1103f : 373f) - (Input.GetKey((KeyCode)(-96)) ? 1797f : 421f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x000A20C4 File Offset: 0x000A02C4
	private void CDLNEMPOHHH()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x000A2110 File Offset: 0x000A0310
	private void OLCEBAPPPFO()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x000A1EF7 File Offset: 0x000A00F7
	private void HGCKKMGJFPO(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.GFLLCHJOEDL();
		}
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x000A215C File Offset: 0x000A035C
	private void LIOCDEICIFD()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.OLCEBAPPPFO();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.CDLNEMPOHHH();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-76)))
			{
				this.NLEEELAOPHB();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.GFLLCHJOEDL();
			}
		}
		float axis = Input.GetAxis("The space size '");
		float axis2 = Input.GetAxis("invn_ver1");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1828f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1873f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-159)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("_ConsoleSettings");
		float d2 = num * Input.GetAxis("WizardPowerUp");
		float d3 = num * ((Input.GetKey((KeyCode)(-3)) ? 1634f : 1511f) - (Input.GetKey(KeyCode.Plus) ? 1241f : 1218f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x000A2311 File Offset: 0x000A0511
	private void DHIJGNHBMFJ()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x000A231F File Offset: 0x000A051F
	private void JLKEHFPFHBE(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.GOEGOFJGKGH();
		}
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void KDPMGODIKPB()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x000A2311 File Offset: 0x000A0511
	private void CBBIADNKMLI()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x000A2332 File Offset: 0x000A0532
	private void DGEJBBJMIMN()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x000A2348 File Offset: 0x000A0548
	private void PMEBIJGFHOM()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x000A2311 File Offset: 0x000A0511
	private void OJDLGCFKCEJ()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x000A2394 File Offset: 0x000A0594
	private void BIDENDHHIKA()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x000A23E0 File Offset: 0x000A05E0
	private void DJJJBBNEGJG()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void OnValidate()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x000A23F8 File Offset: 0x000A05F8
	private void PGHLCMILJMN()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x000A2311 File Offset: 0x000A0511
	private void DMCOCNPIHCG()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x000A2444 File Offset: 0x000A0644
	private void KLJIJLMPAOA()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void AFFPBOBBJOD()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void HLILFIGHHGD()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void HDEPOFLNFDM()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x000A2490 File Offset: 0x000A0690
	private void EGOJAOAEFCG()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void EPJMEFNMKCL()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x000A24DC File Offset: 0x000A06DC
	private void KCEIEOPAJIJ()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void EAPBMMLKDPA()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x000A2528 File Offset: 0x000A0728
	private void DHJDBEJOMEA(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.NLEEELAOPHB();
		}
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void IACPIBGPMHN()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x000A253B File Offset: 0x000A073B
	private void NNCFDPFDMDJ(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.MEKDNNIALOM();
		}
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void ODLOBLKPHEM()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void EEGCPJOHPAJ()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void EEJKIOCCODH()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x000A254E File Offset: 0x000A074E
	private void CCLNDJKBHKN()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x000A2564 File Offset: 0x000A0764
	private void FODHMJKFBJC()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void FBOGKBDHJLA()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000A25B0 File Offset: 0x000A07B0
	private void NMKAAMDOEKL()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x000A23E0 File Offset: 0x000A05E0
	private void LJCODOPHAFD()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x000A2332 File Offset: 0x000A0532
	private void GOEGOFJGKGH()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x000A2311 File Offset: 0x000A0511
	private void ALPLJPJHBML()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void AOPMINIAKBK()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x000A25FC File Offset: 0x000A07FC
	private void GDBBAMFMKII()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.CDLNEMPOHHH();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.PGHLCMILJMN();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Clear))
			{
				this.DJJJBBNEGJG();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.OFJPOHOCGOM();
			}
		}
		float axis = Input.GetAxis("1=");
		float axis2 = Input.GetAxis("Road Points Marker");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1251f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1361f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-173)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("<color='#103080'>");
		float d2 = num * Input.GetAxis("Giant2HandSlamIdle");
		float d3 = num * ((Input.GetKey((KeyCode)(-78)) ? 543f : 26f) - (Input.GetKey((KeyCode)(-99)) ? 1182f : 1035f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x000A27B4 File Offset: 0x000A09B4
	private void DKOIOBMMAGN()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.NHKHNABKFFE();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.KBNLLFNKCJK();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-53)))
			{
				this.GCEOOGGDPCN();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.GCEOOGGDPCN();
			}
		}
		float axis = Input.GetAxis("");
		float axis2 = Input.GetAxis("_RcpAspect");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 173f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1557f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)22) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("_FogScatteringData");
		float d2 = num * Input.GetAxis(" ms");
		float d3 = num * ((Input.GetKey((KeyCode)(-65)) ? 1344f : 596f) - (Input.GetKey(KeyCode.Period) ? 52f : 668f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void OFGLAHFLGPJ()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x000A2311 File Offset: 0x000A0511
	private void NKHMBEDDFAJ()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x000A296C File Offset: 0x000A0B6C
	private void EGHJLNGFKHB()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x000A29B8 File Offset: 0x000A0BB8
	private void KBNLLFNKCJK()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x000A2311 File Offset: 0x000A0511
	private void JIIBCGJJLND()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x000A2A34 File Offset: 0x000A0C34
	private void JEOFHKCBJBN(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.MCCMOBDABED();
		}
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x000A2A48 File Offset: 0x000A0C48
	private void ONNOGIOBGLC()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x000A2A94 File Offset: 0x000A0C94
	private void JIKGIJEHGAP()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.OLCEBAPPPFO();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.NHKHNABKFFE();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Ampersand))
			{
				this.FHGCILJGFMA();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.NLEEELAOPHB();
			}
		}
		float axis = Input.GetAxis("[ACTk] <b>[ ObscuredVector3 test ]</b>");
		float axis2 = Input.GetAxis("Vector2: ");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 273f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1612f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-151)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("uierror6.wav");
		float d2 = num * Input.GetAxis("foot");
		float d3 = num * ((Input.GetKey(KeyCode.Period) ? 1951f : 1302f) - (Input.GetKey((KeyCode)(-116)) ? 994f : 471f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void LFLMAIDAEDP()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x000A2C4C File Offset: 0x000A0E4C
	private void KMLNBHIIGKH()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.EPKKNLGGDGL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.PGHLCMILJMN();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)25))
			{
				this.GFLLCHJOEDL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.DGEJBBJMIMN();
			}
		}
		float axis = Input.GetAxis("StShopWindow");
		float axis2 = Input.GetAxis("error");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 149f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 128f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-15)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis(" length is zero.");
		float d2 = num * Input.GetAxis("SneakRight");
		float d3 = num * ((Input.GetKey((KeyCode)(-116)) ? 95f : 154f) - (Input.GetKey(KeyCode.RightParen) ? 1777f : 1858f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x000A2311 File Offset: 0x000A0511
	private void FJGEPEENLEJ()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x000A2E01 File Offset: 0x000A1001
	private void NCOFINDCLIL(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.LJCODOPHAFD();
		}
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void CMDHBHFPLBP()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x000A1EF7 File Offset: 0x000A00F7
	private void KDAIOKGBPKC(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.GFLLCHJOEDL();
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x000A23E0 File Offset: 0x000A05E0
	private void MCCMOBDABED()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x000A2311 File Offset: 0x000A0511
	private void Awake()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x000A2E14 File Offset: 0x000A1014
	private void CHJNKDEHONF(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.CCLNDJKBHKN();
		}
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void ANIGAKBPJOH()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x000A2E28 File Offset: 0x000A1028
	private void BOAJJAKEMLH()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.BIDENDHHIKA();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.AHPIOKFMCMM();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-24)))
			{
				this.LLIKFINCOKD();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.CCLNDJKBHKN();
			}
		}
		float axis = Input.GetAxis("Pick Up ");
		float axis2 = Input.GetAxis("80ff00");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1517f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 498f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-2)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("No Template! ID=");
		float d2 = num * Input.GetAxis("");
		float d3 = num * ((Input.GetKey((KeyCode)(-24)) ? 1287f : 1506f) - (Input.GetKey(KeyCode.RightParen) ? 381f : 845f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x000A2FDD File Offset: 0x000A11DD
	private void HLMALFEKPII(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.DJJJBBNEGJG();
		}
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x000A2FF0 File Offset: 0x000A11F0
	private void NENBJBAFGDG(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.DGEJBBJMIMN();
		}
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x000A3003 File Offset: 0x000A1203
	private void NLEEELAOPHB()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x000A3018 File Offset: 0x000A1218
	private void KJJBBLDJHPD()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.JLMJMJHMEKJ();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.OLCEBAPPPFO();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.H))
			{
				this.LLIKFINCOKD();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.PCGKBECFOAL();
			}
		}
		float axis = Input.GetAxis("2000");
		float axis2 = Input.GetAxis("SatNightFever");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 448f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1689f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)133) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("_QualitySettings");
		float d2 = num * Input.GetAxis("wpn_add/base");
		float d3 = num * ((Input.GetKey((KeyCode)(-67)) ? 1570f : 667f) - (Input.GetKey((KeyCode)16) ? 1170f : 1055f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000A31D0 File Offset: 0x000A13D0
	private void IANJLHIIGLN()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.LAJDBABODAJ();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.KBNLLFNKCJK();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-34)))
			{
				this.DJJJBBNEGJG();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.MCCMOBDABED();
			}
		}
		float axis = Input.GetAxis("gi_nach");
		float axis2 = Input.GetAxis("Pelvis");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 878f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 503f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey(KeyCode.Semicolon) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Vader Choke");
		float d2 = num * Input.GetAxis("The InteractionTrigger in the list 'inContact' has been destroyed");
		float d3 = num * ((Input.GetKey(KeyCode.Hash) ? 1105f : 1191f) - (Input.GetKey((KeyCode)(-29)) ? 700f : 1863f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x000A3385 File Offset: 0x000A1585
	private void FBFCAIJGCJG(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.GCEOOGGDPCN();
		}
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x000A3398 File Offset: 0x000A1598
	private void AIILFFCEKKM()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.EPKKNLGGDGL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.BIDENDHHIKA();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-48)))
			{
				this.GOEGOFJGKGH();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.KGIINNBMOMN();
			}
		}
		float axis = Input.GetAxis("userdeadmsg");
		float axis2 = Input.GetAxis("usrfrom_ignor");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 303f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1094f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-9)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Tangents");
		float d2 = num * Input.GetAxis("<color='#300030'>{0}</color>");
		float d3 = num * ((Input.GetKey(KeyCode.Period) ? 766f : 162f) - (Input.GetKey(KeyCode.X) ? 389f : 1872f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void NPJBPDAEEAA()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x000A3550 File Offset: 0x000A1750
	private void LAJDBABODAJ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x000A2FDD File Offset: 0x000A11DD
	private void NCMKDOKOHPD(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.DJJJBBNEGJG();
		}
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x000A253B File Offset: 0x000A073B
	private void FAGLBNMIONC(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.MEKDNNIALOM();
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x000A359C File Offset: 0x000A179C
	private void HACOKGBOIIF(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.KGIINNBMOMN();
		}
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x000A35AF File Offset: 0x000A17AF
	private void GFLLCHJOEDL()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void LJLAECACNDP()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void CJBNJPHGDFG()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x000A2311 File Offset: 0x000A0511
	private void HHOACKALPHC()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void KLPOGAHKCNH()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x000A2FF0 File Offset: 0x000A11F0
	private void MNPFPJLDEPL(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.DGEJBBJMIMN();
		}
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x000A2311 File Offset: 0x000A0511
	private void EBNINOBOAII()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x000A35C4 File Offset: 0x000A17C4
	private void GCEOOGGDPCN()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000A35DC File Offset: 0x000A17DC
	private void AHPIOKFMCMM()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x000A2311 File Offset: 0x000A0511
	private void KOJNOPBGPAM()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x000A3628 File Offset: 0x000A1828
	private void PMKOAHMNBBG()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.CDCJFJAAFGF();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.EPKKNLGGDGL();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Slash))
			{
				this.MCCMOBDABED();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.NLEEELAOPHB();
			}
		}
		float axis = Input.GetAxis("27");
		float axis2 = Input.GetAxis("Quest langfile not found!");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 820f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 570f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)31) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("no_money");
		float d2 = num * Input.GetAxis("Wait");
		float d3 = num * ((Input.GetKey((KeyCode)(-98)) ? 1284f : 54f) - (Input.GetKey(KeyCode.Quote) ? 531f : 255f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000A37E0 File Offset: 0x000A19E0
	private void JLMJMJHMEKJ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x000A23E0 File Offset: 0x000A05E0
	private void MEKDNNIALOM()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x000A2FF0 File Offset: 0x000A11F0
	private void AOBLPOILNGP(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.DGEJBBJMIMN();
		}
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x000A382C File Offset: 0x000A1A2C
	private void LFIOEGBGJJI()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void LFOEELGABIN()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void HKFAMOFHFMH()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x000A3878 File Offset: 0x000A1A78
	private void CDCJFJAAFGF()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x000A38C4 File Offset: 0x000A1AC4
	private void LMMDHJJJNJO()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.AHPIOKFMCMM();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.LAJDBABODAJ();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-127)))
			{
				this.CCLNDJKBHKN();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.AIDCMPMOONE();
			}
		}
		float axis = Input.GetAxis("private");
		float axis2 = Input.GetAxis("_History2Weight");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1352f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1981f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-80)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("<color='#606080'>+{0}</color>");
		float d2 = num * Input.GetAxis(" for ");
		float d3 = num * ((Input.GetKey((KeyCode)(-13)) ? 1888f : 1073f) - (Input.GetKey((KeyCode)(-40)) ? 1344f : 603f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x000A2311 File Offset: 0x000A0511
	private void HKLPGCKJEJK()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void AENGHGOPJJM()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void FCDIFKMHBIL()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x000A3A79 File Offset: 0x000A1C79
	private void LLIKFINCOKD()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x000A3A8E File Offset: 0x000A1C8E
	private void FHGCILJGFMA()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x000A3A79 File Offset: 0x000A1C79
	private void OFJPOHOCGOM()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x000A2311 File Offset: 0x000A0511
	private void DPNNENHAGOE()
	{
		base.enabled = this.enableInputCapture;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x000A35AF File Offset: 0x000A17AF
	private void PCGKBECFOAL()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x000A254E File Offset: 0x000A074E
	private void KGIINNBMOMN()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x000A3AA4 File Offset: 0x000A1CA4
	private void NHKHNABKFFE()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void BNOEENADKJF()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000A2E14 File Offset: 0x000A1014
	private void OnApplicationFocus(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.CCLNDJKBHKN();
		}
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x000A3AF0 File Offset: 0x000A1CF0
	private void LHIOJILMHGM()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x000A3B3C File Offset: 0x000A1D3C
	private void HABONMJNDAL()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.NHKHNABKFFE();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.BIDENDHHIKA();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)28))
			{
				this.AIDCMPMOONE();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.DJJJBBNEGJG();
			}
		}
		float axis = Input.GetAxis("Cowboy1HandDraw");
		float axis2 = Input.GetAxis("invn_rec14");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1268f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 323f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey(KeyCode.I) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("ZombieIdle");
		float d2 = num * Input.GetAxis("IdleDrink");
		float d3 = num * ((Input.GetKey((KeyCode)(-110)) ? 1134f : 232f) - (Input.GetKey(KeyCode.Caret) ? 647f : 577f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x000A23E0 File Offset: 0x000A05E0
	private void AIDCMPMOONE()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = false;
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void FLMGDJFCEGJ()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void OFDBLJDDEHE()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x000A3CF4 File Offset: 0x000A1EF4
	private void GCNGEFBKMNC()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.CDLNEMPOHHH();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.LFIOEGBGJJI();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Alpha9))
			{
				this.PCGKBECFOAL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.DGEJBBJMIMN();
			}
		}
		float axis = Input.GetAxis("HalfSampling");
		float axis2 = Input.GetAxis("Swim Idle");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 585f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1433f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)21) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("OfficeSittingReadingCoffeeSip");
		float d2 = num * Input.GetAxis("_isSelect");
		float d3 = num * ((Input.GetKey((KeyCode)(-1)) ? 779f : 82f) - (Input.GetKey((KeyCode)69) ? 1587f : 1085f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void HMBPLDHDLAP()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x000A2E01 File Offset: 0x000A1001
	private void IMNHIAMKNEF(bool FGGHEONKKMP)
	{
		if (this.IJHGGMIIIJK && !FGGHEONKKMP)
		{
			this.LJCODOPHAFD();
		}
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x000A3EAC File Offset: 0x000A20AC
	private void Update()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.NMKAAMDOEKL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.NMKAAMDOEKL();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Escape))
			{
				this.CCLNDJKBHKN();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.CCLNDJKBHKN();
			}
		}
		float axis = Input.GetAxis("Mouse X");
		float axis2 = Input.GetAxis("Mouse Y");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 360f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 360f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey(KeyCode.LeftShift) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Vertical");
		float d2 = num * Input.GetAxis("Horizontal");
		float d3 = num * ((Input.GetKey(KeyCode.E) ? 1f : 0f) - (Input.GetKey(KeyCode.Q) ? 1f : 0f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x000A4064 File Offset: 0x000A2264
	private void CJHBCHBOLBI()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.LAJDBABODAJ();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.LFIOEGBGJJI();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.Ampersand))
			{
				this.LJCODOPHAFD();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.FHGCILJGFMA();
			}
		}
		float axis = Input.GetAxis("<color='#003000'>+{0} {1}</color>");
		float axis2 = Input.GetAxis("RollerBladeGrindRoyale");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 897f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1928f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-64)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Roll");
		float d2 = num * Input.GetAxis("componentA=");
		float d3 = num * ((Input.GetKey(KeyCode.G) ? 863f : 851f) - (Input.GetKey((KeyCode)78) ? 177f : 1938f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x000A421C File Offset: 0x000A241C
	private void JIBKGOFOPHJ()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.AHPIOKFMCMM();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.EGHJLNGFKHB();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)17))
			{
				this.LJCODOPHAFD();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(0))
			{
				this.LJCODOPHAFD();
			}
		}
		float axis = Input.GetAxis("steamider");
		float axis2 = Input.GetAxis("ProcessOnlyMaterial");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 195f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1597f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-199)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Extrude Random Edge");
		float d2 = num * Input.GetAxis("IdleCheer");
		float d3 = num * ((Input.GetKey((KeyCode)2) ? 1311f : 1325f) - (Input.GetKey((KeyCode)(-87)) ? 1628f : 34f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x000A43D4 File Offset: 0x000A25D4
	private void EPKKNLGGDGL()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		this.IJHGGMIIIJK = true;
		this.MCEHEHHBAFJ = base.transform.eulerAngles.y;
		this.OMLBKEBOKAH = base.transform.eulerAngles.x;
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x000A4420 File Offset: 0x000A2620
	private void ECPECFPNLKP()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.JLMJMJHMEKJ();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.ONNOGIOBGLC();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown(KeyCode.B))
			{
				this.MCCMOBDABED();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.KGIINNBMOMN();
			}
		}
		float axis = Input.GetAxis("WATERMODE");
		float axis2 = Input.GetAxis("Original position:\n");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 372f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 1418f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey(KeyCode.DoubleQuote) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Pricorm count=");
		float d2 = num * Input.GetAxis("+{0}");
		float d3 = num * ((Input.GetKey(KeyCode.Alpha7) ? 570f : 981f) - (Input.GetKey(KeyCode.Alpha4) ? 1240f : 1598f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x000A1EE2 File Offset: 0x000A00E2
	private void KCJHGPIIHIA()
	{
		if (Application.isPlaying)
		{
			base.enabled = this.enableInputCapture;
		}
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x000A45D8 File Offset: 0x000A27D8
	private void LMGBKHCHPHO()
	{
		if (!this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetMouseButtonDown(1))
			{
				this.NMKAAMDOEKL();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonDown(0))
			{
				this.KBNLLFNKCJK();
			}
		}
		if (!this.IJHGGMIIIJK)
		{
			return;
		}
		if (this.IJHGGMIIIJK)
		{
			if (!this.holdRightMouseCapture && Input.GetKeyDown((KeyCode)(-105)))
			{
				this.MEKDNNIALOM();
			}
			else if (this.holdRightMouseCapture && Input.GetMouseButtonUp(1))
			{
				this.NLEEELAOPHB();
			}
		}
		float axis = Input.GetAxis("auk buy result: ");
		float axis2 = Input.GetAxis("\n");
		this.MCEHEHHBAFJ = (this.MCEHEHHBAFJ + this.lookSpeed * axis) % 1800f;
		this.OMLBKEBOKAH = (this.OMLBKEBOKAH - this.lookSpeed * axis2) % 256f;
		base.transform.rotation = Quaternion.AngleAxis(this.MCEHEHHBAFJ, Vector3.up) * Quaternion.AngleAxis(this.OMLBKEBOKAH, Vector3.right);
		float num = Time.deltaTime * (Input.GetKey((KeyCode)(-43)) ? this.sprintSpeed : this.moveSpeed);
		float d = num * Input.GetAxis("Keeper Strafe Dive Far Right");
		float d2 = num * Input.GetAxis("DropType");
		float d3 = num * ((Input.GetKey((KeyCode)21) ? 1441f : 308f) - (Input.GetKey((KeyCode)(-100)) ? 122f : 1922f));
		base.transform.position += base.transform.forward * d + base.transform.right * d2 + Vector3.up * d3;
	}

	// Token: 0x040001A0 RID: 416
	public bool enableInputCapture = true;

	// Token: 0x040001A1 RID: 417
	public bool holdRightMouseCapture;

	// Token: 0x040001A2 RID: 418
	public float lookSpeed = 5f;

	// Token: 0x040001A3 RID: 419
	public float moveSpeed = 5f;

	// Token: 0x040001A4 RID: 420
	public float sprintSpeed = 50f;

	// Token: 0x040001A5 RID: 421
	private bool IJHGGMIIIJK;

	// Token: 0x040001A6 RID: 422
	private float MCEHEHHBAFJ;

	// Token: 0x040001A7 RID: 423
	private float OMLBKEBOKAH;
}
