using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042D RID: 1069
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		// Token: 0x0600E6C1 RID: 59073 RVA: 0x0068B9FC File Offset: 0x00689BFC
		public virtual bool GDAGHNLGHLH()
		{
			return !this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("MotorbikeBackwardSittingCheer") && this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("popl.ogg");
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 JNPOBIHFNJO()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 MHMFDKCJANP()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6C4 RID: 59076 RVA: 0x0068BA4C File Offset: 0x00689C4C
		public virtual bool IDLLCOFNHOM()
		{
			return !this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName(",") && this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("RussianDance");
		}

		// Token: 0x0600E6C5 RID: 59077 RVA: 0x0068BA90 File Offset: 0x00689C90
		protected virtual void INKGAFANFIB()
		{
			if (Time.deltaTime == 270f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 1438f) < 88f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("AUTO_KEY_VALUE", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 634f;
			num = Mathf.Clamp(num / Time.deltaTime, 596f, 1936f);
			this.KCLACNEILLB.SetFloat("ncht_ach2", Mathf.Lerp(this.KCLACNEILLB.GetFloat("VA"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("1HSwordStrafeRunLeft", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("PersonManFisher", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("No hit from ", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("cancel", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("{0:0} ч{1}, ", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("rodUpDelta=", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 253f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 649f;
		}

		// Token: 0x0600E6C6 RID: 59078 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void HDCNCMBAAEI()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6C7 RID: 59079 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void JOHIAJFJBGD()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x0068BCDC File Offset: 0x00689EDC
		protected virtual void CDLDCKAHLHC()
		{
			if (Time.deltaTime == 844f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 1810f) < 108f) ? 0 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("RollerBladeCrossoverLeft", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 1412f;
			num = Mathf.Clamp(num / Time.deltaTime, 923f, 415f);
			this.KCLACNEILLB.SetFloat("ClimbRight", Mathf.Lerp(this.KCLACNEILLB.GetFloat("WalkInjured"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("cht_msg16", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("SneakBackward", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("LHandPunch", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("Cloth_07.wav", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("Assets/Heads/whead_", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("invn_win1", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 160f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 742f;
		}

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 MBEJIFPAIEP()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x0068BF04 File Offset: 0x0068A104
		protected virtual void FOHLAIIMNFB()
		{
			if (Time.deltaTime == 1991f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 845f) < 330f) ? 0 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 1121f;
			num = Mathf.Clamp(num / Time.deltaTime, 1544f, 870f);
			this.KCLACNEILLB.SetFloat("gi_um_2", Mathf.Lerp(this.KCLACNEILLB.GetFloat("_NeighbourMaxTex"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("_History3Weight", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("WorkerShovel2", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("<color='#80ffff'>", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("_Saturation", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("****** FlyIcon tmpl is null id=", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("002000", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 622f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 1804f;
		}

		// Token: 0x0600E6CB RID: 59083 RVA: 0x0068C12C File Offset: 0x0068A32C
		public virtual bool NAHFJBFCPOI()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("Button") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("IdleDie");
		}

		// Token: 0x0600E6CC RID: 59084 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void NHANPLDNPKO()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6CD RID: 59085 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void CGIDEFEOIGE()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6CE RID: 59086 RVA: 0x0068C170 File Offset: 0x0068A370
		protected virtual void JPHLMNIMDHH()
		{
			if (Time.deltaTime == 1296f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 62f) < 1951f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("One of the bones in the Finger Rig is null, can not initiate solvers.", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 595f;
			num = Mathf.Clamp(num / Time.deltaTime, 415f, 380f);
			this.KCLACNEILLB.SetFloat("_DelItem.wav", Mathf.Lerp(this.KCLACNEILLB.GetFloat(", "), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("invn_rec33", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("_Tile2RT", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("Soccer Walk", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("\n", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("WireframeCamera", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("MotorbikeWheelyNoHands", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 1545f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 586f;
		}

		// Token: 0x0600E6CF RID: 59087 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 LKKEHIHGJCP()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 IHDBDAJFCNO()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void NOKJMMDMJNO()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6D2 RID: 59090 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void FGJCIEDDFGN()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void DGDGMFDPEHO()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x0068C398 File Offset: 0x0068A598
		protected override void Start()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 MLMNJPFMEKG()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x0068C3C0 File Offset: 0x0068A5C0
		public virtual bool KDCEHOJGAGI()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("WoodCut") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("H");
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 AMOBHHDLHLN()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x0068C404 File Offset: 0x0068A604
		public virtual bool BNGGOKKENLD()
		{
			return !this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("CrouchWalk") && this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("ChannelCastDirected");
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x0068C448 File Offset: 0x0068A648
		protected virtual void FJEEADNCKAG()
		{
			if (Time.deltaTime == 703f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 1851f) < 1249f) ? 0 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("error.wav", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 470f;
			num = Mathf.Clamp(num / Time.deltaTime, 884f, 1452f);
			this.KCLACNEILLB.SetFloat("", Mathf.Lerp(this.KCLACNEILLB.GetFloat(" "), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("_FogAreaData", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat(" for ", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("Soccer Throw", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("_UnderwaterMode", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("дня", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("gi_fs_itm", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 537f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 464f;
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 JJCGHOCFCCA()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 MLABKMCABII()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x0068C670 File Offset: 0x0068A870
		public virtual bool DIHBIFMKFLD()
		{
			return !this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("spinKvok activate") && this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("H");
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void FEDBMMIJFDC()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 MOEPHENGMAJ()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x0068C6E8 File Offset: 0x0068A8E8
		protected virtual void DFFOEGHGPGP()
		{
			if (Time.deltaTime == 1117f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 1684f) < 834f) ? 0 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("Katana Horizontal Swing", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 664f;
			num = Mathf.Clamp(num / Time.deltaTime, 93f, 1424f);
			this.KCLACNEILLB.SetFloat("MotorbikeShootLeft", Mathf.Lerp(this.KCLACNEILLB.GetFloat("OneHandSwordJab"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("addpar", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("crft_norec2", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("Foot", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("cntx_teachexp", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("IdleDodgeLeft", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("wpn_bait_inf_{0}", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 1629f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 1311f;
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x0068C910 File Offset: 0x0068AB10
		public virtual bool IPCLOMAGMJB()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("UI_ArtWindow") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("crft_treb");
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void GGHBPBLKMCE()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x0068C954 File Offset: 0x0068AB54
		protected virtual void LMMDHJJJNJO()
		{
			if (Time.deltaTime == 1933f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 834f) < 136f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("jamp", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 1821f;
			num = Mathf.Clamp(num / Time.deltaTime, 1588f, 1709f);
			this.KCLACNEILLB.SetFloat(" ", Mathf.Lerp(this.KCLACNEILLB.GetFloat("SearchTex"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("#000000", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("Quad ", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("<size=14><color='#00d0ff'>{0}</color></size>", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("file", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("_FullItem.wav", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("WeaponReload", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 36f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 1895f;
		}

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void MJJCMPODAKG()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x0068CB7C File Offset: 0x0068AD7C
		public virtual bool APNIFFLOCFC()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("The image effect ") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("Error");
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 GBJFKEEMMEL()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void DGEIACONKCJ()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x0068CBC0 File Offset: 0x0068ADC0
		protected virtual void JIKGIJEHGAP()
		{
			if (Time.deltaTime == 455f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 195f) < 638f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("_TempRT2", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 1223f;
			num = Mathf.Clamp(num / Time.deltaTime, 1627f, 1641f);
			this.KCLACNEILLB.SetFloat("Idle 180", Mathf.Lerp(this.KCLACNEILLB.GetFloat("80ff00"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("****************** CamEffector APPLY 0", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("csadok", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("1HandSwordStrafeLeft", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("Item ", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("0_", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 691f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 948f;
		}

		// Token: 0x0600E6E9 RID: 59113 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 PJAOLLOEAHH()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6EA RID: 59114 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void GGCIDHAEDFB()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x0068CDE8 File Offset: 0x0068AFE8
		public virtual bool BONDPBAPHEI()
		{
			return !this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("Sewing") && this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("");
		}

		// Token: 0x0600E6EC RID: 59116 RVA: 0x0068CE2C File Offset: 0x0068B02C
		public virtual bool OCLGMBMEHBL()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("INTERFACE") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("code=");
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void OIDMFKFKGMJ()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void IIKDDILLGLF()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6EF RID: 59119 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void KIEIPFFEDHC()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void IOFKNPAKOPI()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x0068CE70 File Offset: 0x0068B070
		public virtual bool KGOPOLOOFNA()
		{
			return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).IsName("PersonManFisher") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("LMB to shoot the Dummy, RMB to rotate the camera.");
		}

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void FIJKDFIMELM()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void MJDAPFCFGOL()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x0068CEB4 File Offset: 0x0068B0B4
		public override bool DEJEBGPIADO
		{
			get
			{
				return this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("Grounded Directional") || this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).IsName("Grounded Strafe");
			}
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x0068CEF8 File Offset: 0x0068B0F8
		protected virtual void Update()
		{
			if (Time.deltaTime == 0f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 1f) < 0f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("JumpLeg", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 0.01f;
			num = Mathf.Clamp(num / Time.deltaTime, -1f, 1f);
			this.KCLACNEILLB.SetFloat("Turn", Mathf.Lerp(this.KCLACNEILLB.GetFloat("Turn"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("Forward", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("Right", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("Crouch", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("OnGround", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("IsStrafing", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("Jump", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 0f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 1f;
		}

		// Token: 0x0600E6F6 RID: 59126 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 IONFNDEFMME()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6F7 RID: 59127 RVA: 0x0068D120 File Offset: 0x0068B320
		protected virtual void PFPPDNHLCCA()
		{
			if (Time.deltaTime == 1652f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(1).normalizedTime + this.runCycleLegOffset, 630f) < 1332f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("shop_t20", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 578f;
			num = Mathf.Clamp(num / Time.deltaTime, 1069f, 1090f);
			this.KCLACNEILLB.SetFloat("CrouchWalk", Mathf.Lerp(this.KCLACNEILLB.GetFloat("Cloth_07.wav"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("CHROMATIC_ABERRATION", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("TOD_MoonMeshContrast", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("_LerpAmount", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("isRodOpen", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("Mouse Y", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("No Template! ID=", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 1140f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 74f;
		}

		// Token: 0x0600E6F8 RID: 59128 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void CBLGFOFHNPJ()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 IAIBJCKAKKK()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void KMABAMCOMOD()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void LMEJKAEIDCO()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void PKCICJKLHNI()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6FD RID: 59133 RVA: 0x0068D348 File Offset: 0x0068B548
		protected virtual void BNKJNBIDPME()
		{
			if (Time.deltaTime == 1436f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 646f) < 152f) ? 0 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("\n", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 582f;
			num = Mathf.Clamp(num / Time.deltaTime, 1595f, 1891f);
			this.KCLACNEILLB.SetFloat("DealerFan", Mathf.Lerp(this.KCLACNEILLB.GetFloat("SneakBackward"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("wpn_fid1", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("drag_onmousedown.wav", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("_WrinkleOcclusionMap2", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("{not_found}", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("MotorbikeLassoBack", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 1585f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 226f;
		}

		// Token: 0x0600E6FE RID: 59134 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void HGLOFEPFKBN()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E6FF RID: 59135 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 KCOOMLOPFMO()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E700 RID: 59136 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void PBMPJPIMJBF()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E701 RID: 59137 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 GCMLGIFMMCF()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E702 RID: 59138 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public override Vector3 GetPivotPoint()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void CBEMFPOFEMJ()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x0068C398 File Offset: 0x0068A598
		protected virtual void ONIHHFLOJMN()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.FMIDMNFMGCM = base.transform.forward;
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		private void OnAnimatorMove()
		{
			this.characterController.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x0068D570 File Offset: 0x0068B770
		protected virtual void MEFOGCFJBNE()
		{
			if (Time.deltaTime == 1429f)
			{
				return;
			}
			if (this.characterController.animState.IELMDLPINAH)
			{
				float value = (float)((Mathf.Repeat(this.KCLACNEILLB.GetCurrentAnimatorStateInfo(0).normalizedTime + this.runCycleLegOffset, 947f) < 177f) ? 1 : -1) * this.characterController.animState.JDFLHKMFHBJ.z;
				this.KCLACNEILLB.SetFloat("button", value);
			}
			float num = -base.GetAngleFromForward(this.FMIDMNFMGCM);
			this.FMIDMNFMGCM = base.transform.forward;
			num *= this.turnSensitivity * 662f;
			num = Mathf.Clamp(num / Time.deltaTime, 1552f, 1607f);
			this.KCLACNEILLB.SetFloat("_Threshhold", Mathf.Lerp(this.KCLACNEILLB.GetFloat("Forward"), num, Time.deltaTime * this.turnSpeed));
			this.KCLACNEILLB.SetFloat("gi_uinf_8", this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("Textures/Fish/", this.characterController.animState.JDFLHKMFHBJ.x);
			this.KCLACNEILLB.SetBool("Wizard1HandThrow", this.characterController.animState.MGCOIPEBMIF);
			this.KCLACNEILLB.SetBool("full", this.characterController.animState.BJHMHPJDJIB);
			this.KCLACNEILLB.SetBool("/", this.characterController.animState.NFOBHHKGILA);
			if (!this.characterController.animState.BJHMHPJDJIB)
			{
				this.KCLACNEILLB.SetFloat("FactoryTempTexture", this.characterController.animState.FBDMDIOLLFA);
			}
			if (this.characterController.animState.BJHMHPJDJIB && this.characterController.animState.JDFLHKMFHBJ.z > 461f)
			{
				this.KCLACNEILLB.speed = this.animSpeedMultiplier;
				return;
			}
			this.KCLACNEILLB.speed = 1809f;
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 AKAJNJAFNJI()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x0068BA3F File Offset: 0x00689C3F
		public virtual Vector3 KBEOHBLADFN()
		{
			return this.KCLACNEILLB.pivotPosition;
		}

		// Token: 0x04001E21 RID: 7713
		public CharacterThirdPerson characterController;

		// Token: 0x04001E22 RID: 7714
		[SerializeField]
		private float turnSensitivity = 0.2f;

		// Token: 0x04001E23 RID: 7715
		[SerializeField]
		private float turnSpeed = 5f;

		// Token: 0x04001E24 RID: 7716
		[SerializeField]
		private float runCycleLegOffset = 0.2f;

		// Token: 0x04001E25 RID: 7717
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier = 1f;

		// Token: 0x04001E26 RID: 7718
		protected Animator KCLACNEILLB;

		// Token: 0x04001E27 RID: 7719
		private Vector3 FMIDMNFMGCM;

		// Token: 0x04001E28 RID: 7720
		private static string DBLPMINNEDK = "Grounded Directional";

		// Token: 0x04001E29 RID: 7721
		private static string NKHIOGDJHPH = "Grounded Strafe";
	}
}
