using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000422 RID: 1058
	[RequireComponent(typeof(Animator))]
	public class VRAnimatorController : MonoBehaviour
	{
		// Token: 0x0600E3E9 RID: 58345 RVA: 0x0067C2E0 File Offset: 0x0067A4E0
		private void NCLEJMJPGKN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("money", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "R to reset fog.";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E3EA RID: 58346 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void ILKLBLMIDGF(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3EB RID: 58347 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 IPNJAEHGPKF()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x0067C3C8 File Offset: 0x0067A5C8
		public void OOGPGICFCDA(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1134f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 723f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 976f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 849f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1004f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x0067C4B4 File Offset: 0x0067A6B4
		public void AJLBINOOOAE(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1931f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 789f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1730f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 19f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 991f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E3EE RID: 58350 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void GFDKEPBODFH(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3EF RID: 58351 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void CGNDBLBIMCC(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x0067C5A0 File Offset: 0x0067A7A0
		private Vector3 GCPKBCPFHBP()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 ABJAGGEBACI()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 MONAGAMABKJ()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x0067C614 File Offset: 0x0067A814
		public void IGPGPKHFGPF(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1939f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 1301f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 284f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 243f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1495f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x0067C700 File Offset: 0x0067A900
		private void BLLGOMHDFPL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("donk.ogg", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "IX";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void LGCJPJJJOCG(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x0067C7D8 File Offset: 0x0067A9D8
		private Vector3 FPOBANJCOLO()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void MABIBIHELAJ(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x0067C84C File Offset: 0x0067AA4C
		private void FGONMKDNDLK()
		{
			if (!this.oculusSetup.IHCLGIBCIPP())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 849f;
				}
				this.APOIOHJJDDC = Vector3.zero;
				this.KCLACNEILLB.SetFloat(" ", 635f);
				this.KCLACNEILLB.SetFloat("?", 1286f);
				return;
			}
			this.ACEFPBADMAE(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.EFJHKIHCCMB();
			this.HGKJNEDMLLI(Vector3.MoveTowards(this.ABJAGGEBACI(), target, Time.deltaTime * this.linearAcceleration));
			this.PMPEOKGBDCK(Vector3.SmoothDamp(this.MONAGAMABKJ(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.MIBIKPDJBJF() == Vector3.zero) ? 1247f : 1453f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1214f);
			}
			this.KCLACNEILLB.SetFloat("cht_msg19", this.IHGOLABKDHO().x);
			this.KCLACNEILLB.SetFloat("Open Door", this.IKJDBMBIBJP().z);
		}

		// Token: 0x0600E3F9 RID: 58361 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 DFGDMOOBMBH()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x0067C9E4 File Offset: 0x0067ABE4
		private void CPNOBMNKPNC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("CrouchWalkBackward", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "Weapon Fire";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void PMPEOKGBDCK(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x0067CABC File Offset: 0x0067ACBC
		public void NFMAPNLFPNJ(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 636f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 1418f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1613f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 105f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 326f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 IHGOLABKDHO()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x0067CBA8 File Offset: 0x0067ADA8
		private void KDCOHILDJJO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("SoccerRun", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "1 Hand Sword Jab ready strafe right";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E3FF RID: 58367 RVA: 0x0067CC80 File Offset: 0x0067AE80
		private void JFGGBEGNAFP()
		{
			if (!this.oculusSetup.JEEBLFAPPDL())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 636f;
				}
				this.EENFBKHNCOA(Vector3.zero);
				this.KCLACNEILLB.SetFloat("<b>Supported types:</b>\n", 1629f);
				this.KCLACNEILLB.SetFloat("linebreak.ogg", 1580f);
				return;
			}
			this.NFMAPNLFPNJ(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.NDHGMNLABCL();
			this.EHNLFNPEKNC(Vector3.MoveTowards(this.APOIOHJJDDC, target, Time.deltaTime * this.linearAcceleration));
			this.GFDKEPBODFH(Vector3.SmoothDamp(this.PEALGAOLPDF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.IKJDBMBIBJP() == Vector3.zero) ? 79f : 1032f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 103f);
			}
			this.KCLACNEILLB.SetFloat("_Angle", this.PFCIAJKLJOP().x);
			this.KCLACNEILLB.SetFloat("Femur", this.ABJAGGEBACI().z);
		}

		// Token: 0x0600E400 RID: 58368 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 DJEHKDMEAED()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E401 RID: 58369 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void CDKPBFCNLGO(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x0067CE18 File Offset: 0x0067B018
		private void NMGCNEELAFM()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("Assets/Heads/whead_", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "Mouse X";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void HMMPPDKPDMG(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void BGEENNJLEKH(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E405 RID: 58373 RVA: 0x0067CEF0 File Offset: 0x0067B0F0
		private void GMBPCGCCPDM()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("_ReflectionTex", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "_Params3";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E406 RID: 58374 RVA: 0x0067CFC8 File Offset: 0x0067B1C8
		private void BHFMGBNIAMC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("<color='#60a0ff'>{0}</color>\n<color='#ffff60'>Всего выловлено: <color='#ffffa0'>{1}</color> шт Общим весом <color='#ffffa0'>{2}</color>\nЛичный рекорд <color='#ffffa0'>{3}</color> </color>", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "IdleFight";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E407 RID: 58375 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 NMJJNKFIFFA()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E408 RID: 58376 RVA: 0x0067D0A0 File Offset: 0x0067B2A0
		private Vector3 BGAGKFCKJEL()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E409 RID: 58377 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 HCGDCNFODNE()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E40A RID: 58378 RVA: 0x0067D114 File Offset: 0x0067B314
		private Vector3 IAILGCGAOMP()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E40B RID: 58379 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void KOBOMCNFMDD(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E40C RID: 58380 RVA: 0x0067D188 File Offset: 0x0067B388
		private Vector3 HJJFOKDNMLO()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E40D RID: 58381 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void BMCAOEABFKN(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E40E RID: 58382 RVA: 0x0067D1FC File Offset: 0x0067B3FC
		private Vector3 FHJIABAAFLF()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E40F RID: 58383 RVA: 0x0067D270 File Offset: 0x0067B470
		private void LMMDHJJJNJO()
		{
			if (!this.oculusSetup.JMOJEGBLMJO())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 859f;
				}
				this.EENFBKHNCOA(Vector3.zero);
				this.KCLACNEILLB.SetFloat("ProneLocomotion", 1864f);
				this.KCLACNEILLB.SetFloat("Assets/Weapons/", 8f);
				return;
			}
			this.POLAMGDKIOL(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FPOBANJCOLO();
			this.APOIOHJJDDC = Vector3.MoveTowards(this.IHGOLABKDHO(), target, Time.deltaTime * this.linearAcceleration);
			this.NNHBHDNJPPE(Vector3.SmoothDamp(this.HCGDCNFODNE(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.IPNJAEHGPKF() == Vector3.zero) ? 1614f : 120f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 521f);
			}
			this.KCLACNEILLB.SetFloat("demoColor", this.MIBIKPDJBJF().x);
			this.KCLACNEILLB.SetFloat("fishdrop_1", this.DEGNEFEJBIN().z);
		}

		// Token: 0x0600E410 RID: 58384 RVA: 0x0067D408 File Offset: 0x0067B608
		private void ADLHNBEDHMJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("lastConfirmLic", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x0067D4E0 File Offset: 0x0067B6E0
		private Vector3 EIBFFLBJBHA()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E412 RID: 58386 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void EENFBKHNCOA(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x0067D554 File Offset: 0x0067B754
		private Vector3 IEEAHGIOFFO()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x0067D5C8 File Offset: 0x0067B7C8
		private void DOHJPDNKALP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("OpenRecords", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "SexyDance2";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E415 RID: 58389 RVA: 0x0067D6A0 File Offset: 0x0067B8A0
		public void CMPJGIMECIP(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 116f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 894f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1178f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1018f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1766f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E416 RID: 58390 RVA: 0x0067D78C File Offset: 0x0067B98C
		private void BNIBBPHLNKJ()
		{
			if (!this.oculusSetup.EAMGCODKKDD)
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 166f;
				}
				this.CDKPBFCNLGO(Vector3.zero);
				this.KCLACNEILLB.SetFloat("▮▯▯", 956f);
				this.KCLACNEILLB.SetFloat("Press E to start interaction", 315f);
				return;
			}
			this.DJCMHKFOAFG(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.GCPKBCPFHBP();
			this.KOBOMCNFMDD(Vector3.MoveTowards(this.NMJJNKFIFFA(), target, Time.deltaTime * this.linearAcceleration));
			this.GFDKEPBODFH(Vector3.SmoothDamp(this.AHCIEBDEKGJ(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.EHBLHMOGPIM() == Vector3.zero) ? 236f : 1281f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1822f);
			}
			this.KCLACNEILLB.SetFloat("UV0", this.AHCIEBDEKGJ().x);
			this.KCLACNEILLB.SetFloat("_Curve", this.HJEDDLJCJBJ().z);
		}

		// Token: 0x0600E417 RID: 58391 RVA: 0x0067D924 File Offset: 0x0067BB24
		private void KFNOEOIIBOI()
		{
			if (!this.oculusSetup.JEEBLFAPPDL())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1502f;
				}
				this.MKFLOAEJCFC(Vector3.zero);
				this.KCLACNEILLB.SetFloat("repair.ogg", 119f);
				this.KCLACNEILLB.SetFloat("FISHES", 1314f);
				return;
			}
			this.POLAMGDKIOL(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.EFABDIKBLLI();
			this.NNHBHDNJPPE(Vector3.MoveTowards(this.APOIOHJJDDC, target, Time.deltaTime * this.linearAcceleration));
			this.ILNGIGEJDGB(Vector3.SmoothDamp(this.CFLCPCFGEMN(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.MMDBEKLIOHF() == Vector3.zero) ? 473f : 300f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 459f);
			}
			this.KCLACNEILLB.SetFloat("reelspd", this.DFGDMOOBMBH().x);
			this.KCLACNEILLB.SetFloat("X", this.GMJEBBLDNDP().z);
		}

		// Token: 0x0600E418 RID: 58392 RVA: 0x0067DABC File Offset: 0x0067BCBC
		private void PBFKCKCHEAC()
		{
			if (!this.oculusSetup.BLAOADCPHAG())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1842f;
				}
				this.EHNLFNPEKNC(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Save", 1303f);
				this.KCLACNEILLB.SetFloat("_Saturation", 209f);
				return;
			}
			this.NAGKFHFCHEG(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.JMELONAKCGH();
			this.NCAEEIJECEH(Vector3.MoveTowards(this.GMJEBBLDNDP(), target, Time.deltaTime * this.linearAcceleration));
			this.ACFKEIOHPEE(Vector3.SmoothDamp(this.MIBIKPDJBJF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.CFLCPCFGEMN() == Vector3.zero) ? 1483f : 755f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1741f);
			}
			this.KCLACNEILLB.SetFloat("MotorbikeBackwardSitting", this.DJEHKDMEAED().x);
			this.KCLACNEILLB.SetFloat("OfficeSittingReadingLeanBack", this.IHGOLABKDHO().z);
		}

		// Token: 0x0600E419 RID: 58393 RVA: 0x0067DC54 File Offset: 0x0067BE54
		private void GDPMOMHBIFN()
		{
			if (!this.oculusSetup.CLDJANJPCJC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 384f;
				}
				this.MABIBIHELAJ(Vector3.zero);
				this.KCLACNEILLB.SetFloat("", 1521f);
				this.KCLACNEILLB.SetFloat("Z (B)", 1805f);
				return;
			}
			this.IMDOPCJOPDC(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.EFABDIKBLLI();
			this.IILLDHHMKPF(Vector3.MoveTowards(this.GMJEBBLDNDP(), target, Time.deltaTime * this.linearAcceleration));
			this.ILNGIGEJDGB(Vector3.SmoothDamp(this.CDNCDGHAIJO(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.CDNCDGHAIJO() == Vector3.zero) ? 530f : 1684f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1404f);
			}
			this.KCLACNEILLB.SetFloat("\n", this.NMJJNKFIFFA().x);
			this.KCLACNEILLB.SetFloat("Depth textures aren't supported on this device ({0})", this.GHEBFPNBAPA().z);
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void ACFKEIOHPEE(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E41B RID: 58395 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 DGPDEIODEBG()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void AHHLFHFMBCG(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x0067DDEC File Offset: 0x0067BFEC
		public void DAONFILMONH(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1360f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 475f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 7f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1171f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1778f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x0067DED8 File Offset: 0x0067C0D8
		private void FGJCIEDDFGN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("Roll", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "{0:0} д{1}, ";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 PFCIAJKLJOP()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x0067DFB0 File Offset: 0x0067C1B0
		private void IOGAKGCADBL()
		{
			if (!this.oculusSetup.JEEBLFAPPDL())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 218f;
				}
				this.APOIOHJJDDC = Vector3.zero;
				this.KCLACNEILLB.SetFloat("_RampTex", 936f);
				this.KCLACNEILLB.SetFloat("System.Single", 1440f);
				return;
			}
			this.DJACBMLJOJO(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.MOLBHBBEFKC();
			this.APOIOHJJDDC = Vector3.MoveTowards(this.NMJJNKFIFFA(), target, Time.deltaTime * this.linearAcceleration);
			this.APOIOHJJDDC = Vector3.SmoothDamp(this.MIBIKPDJBJF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime);
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.CFLCPCFGEMN() == Vector3.zero) ? 1498f : 1288f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 337f);
			}
			this.KCLACNEILLB.SetFloat("Brow", this.MMDBEKLIOHF().x);
			this.KCLACNEILLB.SetFloat(" ", this.MMDBEKLIOHF().z);
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x0067E148 File Offset: 0x0067C348
		public void ACEFPBADMAE(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 515f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 639f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 50f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1019f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 884f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 KECPAOCPNEP()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x0067E234 File Offset: 0x0067C434
		private Vector3 MOLBHBBEFKC()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void AMLALEBBMJL(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E425 RID: 58405 RVA: 0x0067E2A8 File Offset: 0x0067C4A8
		public void DHDEDNEBHFD(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 177f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 232f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1689f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1375f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1296f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E426 RID: 58406 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 EHBLHMOGPIM()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E427 RID: 58407 RVA: 0x0067E394 File Offset: 0x0067C594
		public void DEJCOKIGCIP(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 0f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 990f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 454f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 478f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1338f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void LAMMMPNDCKP(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x0067E480 File Offset: 0x0067C680
		private void HMGBHPPNEMP()
		{
			if (!this.oculusSetup.EAMGCODKKDD)
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 556f;
				}
				this.PMPEOKGBDCK(Vector3.zero);
				this.KCLACNEILLB.SetFloat("ambientVolume", 1341f);
				this.KCLACNEILLB.SetFloat("Mouse ScrollWheel", 1144f);
				return;
			}
			this.CMPJGIMECIP(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.EIBFFLBJBHA();
			this.AHHLFHFMBCG(Vector3.MoveTowards(this.AHCIEBDEKGJ(), target, Time.deltaTime * this.linearAcceleration));
			this.ILNGIGEJDGB(Vector3.SmoothDamp(this.ABJAGGEBACI(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.PFCIAJKLJOP() == Vector3.zero) ? 748f : 172f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 897f);
			}
			this.KCLACNEILLB.SetFloat("inv_inv", this.PFCIAJKLJOP().x);
			this.KCLACNEILLB.SetFloat(".unity3d", this.GMJEBBLDNDP().z);
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x0067E618 File Offset: 0x0067C818
		private void JIKGIJEHGAP()
		{
			if (!this.oculusSetup.LNHJINNIPGP())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1516f;
				}
				this.FHNEOJLDCOJ(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Cowboy1HandDraw", 162f);
				this.KCLACNEILLB.SetFloat("wpn_cat5", 221f);
				return;
			}
			this.DJCMHKFOAFG(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.GMPAMBBIGEP();
			this.AMLALEBBMJL(Vector3.MoveTowards(this.MMDBEKLIOHF(), target, Time.deltaTime * this.linearAcceleration));
			this.NCAEEIJECEH(Vector3.SmoothDamp(this.MMDBEKLIOHF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.DFGDMOOBMBH() == Vector3.zero) ? 1963f : 788f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1404f);
			}
			this.KCLACNEILLB.SetFloat("\n", this.GHEBFPNBAPA().x);
			this.KCLACNEILLB.SetFloat("_Grain_Params1", this.PEALGAOLPDF().z);
		}

		// Token: 0x0600E42B RID: 58411 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 PEALGAOLPDF()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E42C RID: 58412 RVA: 0x0067E7B0 File Offset: 0x0067C9B0
		private void PBMPJPIMJBF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("Flares", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "imageindex";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E42D RID: 58413 RVA: 0x0067E888 File Offset: 0x0067CA88
		public void PPHKAMOFEGL(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1409f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 137f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1316f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1065f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1694f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x0067E974 File Offset: 0x0067CB74
		private void LHMNFJBJBJM()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("1HSwordStrafeRunLeft", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = " ";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x0067EA4C File Offset: 0x0067CC4C
		private Vector3 MAKBFMCJOIB()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 DIMDOCOAMFJ()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x0067EAC0 File Offset: 0x0067CCC0
		private void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("IsStrafing", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "Camera Pivot";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x0067EB98 File Offset: 0x0067CD98
		private Vector3 JBBPLOMIKJB()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void EHNLFNPEKNC(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x0067EC0C File Offset: 0x0067CE0C
		public void POLAMGDKIOL(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1577f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 521f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 711f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1668f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1743f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x0067ECF8 File Offset: 0x0067CEF8
		private Vector3 EFJHKIHCCMB()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E436 RID: 58422 RVA: 0x0067ED6C File Offset: 0x0067CF6C
		private Vector3 FEMEOGNECMM()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x0067EDE0 File Offset: 0x0067CFE0
		private void DDEBDCGNCPC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("crft_konstr", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "HDR";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void ILNGIGEJDGB(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E439 RID: 58425 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void FHNEOJLDCOJ(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x0067EEB8 File Offset: 0x0067D0B8
		private void KCBECEFNGMO()
		{
			if (!this.oculusSetup.LNHJINNIPGP())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1652f;
				}
				this.NNHBHDNJPPE(Vector3.zero);
				this.KCLACNEILLB.SetFloat("wpn_izn", 571f);
				this.KCLACNEILLB.SetFloat("", 831f);
				return;
			}
			this.DJACBMLJOJO(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.IEEAHGIOFFO();
			this.ILNGIGEJDGB(Vector3.MoveTowards(this.PEALGAOLPDF(), target, Time.deltaTime * this.linearAcceleration));
			this.EENFBKHNCOA(Vector3.SmoothDamp(this.MIBIKPDJBJF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.GMJEBBLDNDP() == Vector3.zero) ? 1900f : 1117f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1644f);
			}
			this.KCLACNEILLB.SetFloat("WizardNeoBlock", this.NMJJNKFIFFA().x);
			this.KCLACNEILLB.SetFloat("t_eye", this.KECPAOCPNEP().z);
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x0067F050 File Offset: 0x0067D250
		private void JLFBDOPFDDJ()
		{
			if (!this.oculusSetup.GKKLNBGJMFC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 518f;
				}
				this.CGNDBLBIMCC(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Sewing", 729f);
				this.KCLACNEILLB.SetFloat("error.wav", 1844f);
				return;
			}
			this.DEJCOKIGCIP(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FEMEOGNECMM();
			this.BMCAOEABFKN(Vector3.MoveTowards(this.APOIOHJJDDC, target, Time.deltaTime * this.linearAcceleration));
			this.BMCAOEABFKN(Vector3.SmoothDamp(this.GHEBFPNBAPA(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.IPNJAEHGPKF() == Vector3.zero) ? 138f : 1470f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1760f);
			}
			this.KCLACNEILLB.SetFloat("System.Boolean", this.IKJDBMBIBJP().x);
			this.KCLACNEILLB.SetFloat("OneHandSwordJab", this.DFGDMOOBMBH().z);
		}

		// Token: 0x0600E43C RID: 58428 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void MKFLOAEJCFC(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E43D RID: 58429 RVA: 0x0067F1E8 File Offset: 0x0067D3E8
		private Vector3 NDHGMNLABCL()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E43E RID: 58430 RVA: 0x0067F25C File Offset: 0x0067D45C
		public void IOJDPHMIJNL(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 721f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 997f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 862f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1318f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1626f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x0067F348 File Offset: 0x0067D548
		private void GCCAPOHGAHA()
		{
			if (!this.oculusSetup.GKKLNBGJMFC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1239f;
				}
				this.PBCNCLOPLAH(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Ban action", 1281f);
				this.KCLACNEILLB.SetFloat("[F_EXP]", 1333f);
				return;
			}
			this.DHDEDNEBHFD(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FEMEOGNECMM();
			this.MABIBIHELAJ(Vector3.MoveTowards(this.NIMGHABNGFF(), target, Time.deltaTime * this.linearAcceleration));
			this.ILKLBLMIDGF(Vector3.SmoothDamp(this.GHEBFPNBAPA(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.DIMDOCOAMFJ() == Vector3.zero) ? 1828f : 1219f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1801f);
			}
			this.KCLACNEILLB.SetFloat("No saved PlayerPrefs!", this.MONAGAMABKJ().x);
			this.KCLACNEILLB.SetFloat("FOG_OFF", this.CDNCDGHAIJO().z);
		}

		// Token: 0x0600E440 RID: 58432 RVA: 0x0067F4E0 File Offset: 0x0067D6E0
		private Vector3 JMELONAKCGH()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x0067F554 File Offset: 0x0067D754
		private void NOKJMMDMJNO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("Platform", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "OfficeSittingReadingCoffeeSip";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 DEGNEFEJBIN()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x0067F62C File Offset: 0x0067D82C
		private void EMHGNEMIGII()
		{
			if (!this.oculusSetup.BLAOADCPHAG())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 534f;
				}
				this.GFDKEPBODFH(Vector3.zero);
				this.KCLACNEILLB.SetFloat("SampleDistributionCurve", 1076f);
				this.KCLACNEILLB.SetFloat("<color='#202020'>", 309f);
				return;
			}
			this.KALGFNEJJMD(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.IAILGCGAOMP();
			this.JHKINALKFAD(Vector3.MoveTowards(this.CDNCDGHAIJO(), target, Time.deltaTime * this.linearAcceleration));
			this.PBCNCLOPLAH(Vector3.SmoothDamp(this.CHIHODHIMCL(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.IPNJAEHGPKF() == Vector3.zero) ? 1005f : 1018f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1883f);
			}
			this.KCLACNEILLB.SetFloat("gi_um_9", this.MONAGAMABKJ().x);
			this.KCLACNEILLB.SetFloat("FlyBackward", this.DFGDMOOBMBH().z);
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x0067F7C4 File Offset: 0x0067D9C4
		public void NAGKFHFCHEG(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1297f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 1690f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 375f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1078f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1413f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 CHIHODHIMCL()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x0067F8B0 File Offset: 0x0067DAB0
		private void OJGOLGHBEPM()
		{
			if (!this.oculusSetup.EAMGCODKKDD)
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1340f;
				}
				this.ILKLBLMIDGF(Vector3.zero);
				this.KCLACNEILLB.SetFloat("_Distance", 1620f);
				this.KCLACNEILLB.SetFloat("_NoiseTex", 535f);
				return;
			}
			this.POLAMGDKIOL(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.DAHBPPHPMGK();
			this.AHHLFHFMBCG(Vector3.MoveTowards(this.CHIHODHIMCL(), target, Time.deltaTime * this.linearAcceleration));
			this.MABIBIHELAJ(Vector3.SmoothDamp(this.NIMGHABNGFF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.AHCIEBDEKGJ() == Vector3.zero) ? 1580f : 1201f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 283f);
			}
			this.KCLACNEILLB.SetFloat("act_order", this.DEGNEFEJBIN().x);
			this.KCLACNEILLB.SetFloat("FrontKick", this.CHIHODHIMCL().z);
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x0067FA48 File Offset: 0x0067DC48
		private void BJOICAKCPLI()
		{
			if (!this.oculusSetup.LNHJINNIPGP())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1533f;
				}
				this.NNHBHDNJPPE(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Swim", 1530f);
				this.KCLACNEILLB.SetFloat("ApplePick", 400f);
				return;
			}
			this.DEJCOKIGCIP(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.JMELONAKCGH();
			this.BGEENNJLEKH(Vector3.MoveTowards(this.NMJJNKFIFFA(), target, Time.deltaTime * this.linearAcceleration));
			this.AMLALEBBMJL(Vector3.SmoothDamp(this.GHEBFPNBAPA(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.GHEBFPNBAPA() == Vector3.zero) ? 1469f : 1344f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 721f);
			}
			this.KCLACNEILLB.SetFloat("_UnderwaterMode", this.AHCIEBDEKGJ().x);
			this.KCLACNEILLB.SetFloat("cntx_close", this.DGPDEIODEBG().z);
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x0067FBE0 File Offset: 0x0067DDE0
		private void DGGMJCMLLED()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "MotorbikeTurnRight";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600E449 RID: 58441 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		// (set) Token: 0x0600E454 RID: 58452 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		public Vector3 APOIOHJJDDC { get; private set; }

		// Token: 0x0600E44A RID: 58442 RVA: 0x0067FCB8 File Offset: 0x0067DEB8
		private Vector3 DAHBPPHPMGK()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x0067FD2C File Offset: 0x0067DF2C
		private void LBBPCGCMMKF()
		{
			if (!this.oculusSetup.CLDJANJPCJC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 236f;
				}
				this.LGCJPJJJOCG(Vector3.zero);
				this.KCLACNEILLB.SetFloat("reputaion/levels/replevels", 74f);
				this.KCLACNEILLB.SetFloat("_AxialAberration", 1871f);
				return;
			}
			this.POLAMGDKIOL(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.MAKBFMCJOIB();
			this.ILKLBLMIDGF(Vector3.MoveTowards(this.GMJEBBLDNDP(), target, Time.deltaTime * this.linearAcceleration));
			this.IILLDHHMKPF(Vector3.SmoothDamp(this.APOIOHJJDDC, target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.MIBIKPDJBJF() == Vector3.zero) ? 1682f : 695f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1701f);
			}
			this.KCLACNEILLB.SetFloat("TOD_SunSkyColor", this.NIMGHABNGFF().x);
			this.KCLACNEILLB.SetFloat("KatanaReadyLow", this.MIBIKPDJBJF().z);
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x0067FEC4 File Offset: 0x0067E0C4
		private void GHOBHBMFKHN()
		{
			if (!this.oculusSetup.IHCLGIBCIPP())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1699f;
				}
				this.LAMMMPNDCKP(Vector3.zero);
				this.KCLACNEILLB.SetFloat("WeaponFire", 1177f);
				this.KCLACNEILLB.SetFloat("StrafeRunLeft", 1654f);
				return;
			}
			this.ACEFPBADMAE(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.HJJFOKDNMLO();
			this.KOBOMCNFMDD(Vector3.MoveTowards(this.NIMGHABNGFF(), target, Time.deltaTime * this.linearAcceleration));
			this.PBCNCLOPLAH(Vector3.SmoothDamp(this.APOIOHJJDDC, target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.DFGDMOOBMBH() == Vector3.zero) ? 315f : 1223f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 477f);
			}
			this.KCLACNEILLB.SetFloat("DEPTH_OF_FIELD_COC_VIEW", this.PEALGAOLPDF().x);
			this.KCLACNEILLB.SetFloat("TOD_MoonHaloPower", this.CFLCPCFGEMN().z);
		}

		// Token: 0x0600E44D RID: 58445 RVA: 0x0068005C File Offset: 0x0067E25C
		private Vector3 HDNEGLMLOCM()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x006800D0 File Offset: 0x0067E2D0
		private Vector3 EFABDIKBLLI()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x00680144 File Offset: 0x0067E344
		private void BFBBJILCKAK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("_History4LumaTex", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "_SunPosition";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x0068021C File Offset: 0x0067E41C
		public void KALGFNEJJMD(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1247f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 50f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 678f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 958f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 547f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E451 RID: 58449 RVA: 0x00680308 File Offset: 0x0067E508
		private Vector3 GMPAMBBIGEP()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x0068037C File Offset: 0x0067E57C
		private void BOAJJAKEMLH()
		{
			if (!this.oculusSetup.CLDJANJPCJC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 581f;
				}
				this.ILKLBLMIDGF(Vector3.zero);
				this.KCLACNEILLB.SetFloat("Life bar: ", 1909f);
				this.KCLACNEILLB.SetFloat("StrafeRunRight", 421f);
				return;
			}
			this.BJKKHHPGFHO(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FPOBANJCOLO();
			this.AMLALEBBMJL(Vector3.MoveTowards(this.DIMDOCOAMFJ(), target, Time.deltaTime * this.linearAcceleration));
			this.NNHBHDNJPPE(Vector3.SmoothDamp(this.HJEDDLJCJBJ(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.DGPDEIODEBG() == Vector3.zero) ? 117f : 1828f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 395f);
			}
			this.KCLACNEILLB.SetFloat("_DistortParams", this.DGPDEIODEBG().x);
			this.KCLACNEILLB.SetFloat(" from ", this.MIBIKPDJBJF().z);
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 HJEDDLJCJBJ()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E455 RID: 58453 RVA: 0x00680514 File Offset: 0x0067E714
		private Vector3 DIJFHIFDMDN()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void OBJLABMMKCE(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x00680588 File Offset: 0x0067E788
		public void BJKKHHPGFHO(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 799f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 603f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 629f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 862f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1241f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 CDNCDGHAIJO()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x00680674 File Offset: 0x0067E874
		private void IMABGALEMBI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("B", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "Climb Left";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x0068074C File Offset: 0x0067E94C
		private void PBEKBHFDHAM()
		{
			if (!this.oculusSetup.CLDJANJPCJC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1016f;
				}
				this.BGEENNJLEKH(Vector3.zero);
				this.KCLACNEILLB.SetFloat("[Y]", 217f);
				this.KCLACNEILLB.SetFloat("ShotgunReloadMagazine", 271f);
				return;
			}
			this.ILJNCFMFKOE(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.BDEOJIKIKNN();
			this.APOIOHJJDDC = Vector3.MoveTowards(this.DIMDOCOAMFJ(), target, Time.deltaTime * this.linearAcceleration);
			this.HGKJNEDMLLI(Vector3.SmoothDamp(this.CHIHODHIMCL(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.HJEDDLJCJBJ() == Vector3.zero) ? 1454f : 146f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1478f);
			}
			this.KCLACNEILLB.SetFloat("_WaveScale", this.MONAGAMABKJ().x);
			this.KCLACNEILLB.SetFloat("man_death.ogg", this.DJEHKDMEAED().z);
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x006808E4 File Offset: 0x0067EAE4
		private void JPHLMNIMDHH()
		{
			if (!this.oculusSetup.GPHNOGHKFGH())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 460f;
				}
				this.CDKPBFCNLGO(Vector3.zero);
				this.KCLACNEILLB.SetFloat("demoVector3", 817f);
				this.KCLACNEILLB.SetFloat(": ", 648f);
				return;
			}
			this.CMPJGIMECIP(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FEMEOGNECMM();
			this.APOIOHJJDDC = Vector3.MoveTowards(this.IPNJAEHGPKF(), target, Time.deltaTime * this.linearAcceleration);
			this.MABIBIHELAJ(Vector3.SmoothDamp(this.CHIHODHIMCL(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.HJEDDLJCJBJ() == Vector3.zero) ? 1929f : 753f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1262f);
			}
			this.KCLACNEILLB.SetFloat("Head stand", this.IHGOLABKDHO().x);
			this.KCLACNEILLB.SetFloat("Ready Fight", this.NIMGHABNGFF().z);
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x00680A7C File Offset: 0x0067EC7C
		private Vector3 BDEOJIKIKNN()
		{
			Vector3 zero = Vector3.zero;
			this.BKGNDJKFGHE = (this.characterController.position - this.GLOIBIHKCDJ) / Time.deltaTime;
			this.GLOIBIHKCDJ = this.characterController.position;
			return zero + Quaternion.Inverse(base.transform.rotation) * this.BKGNDJKFGHE * this.locomotionSpeed;
		}

		// Token: 0x0600E45D RID: 58461 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 CFLCPCFGEMN()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E45E RID: 58462 RVA: 0x00680AF0 File Offset: 0x0067ECF0
		private void OALIDDIKLHK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("Crouch180", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "error baseid: ";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 GMJEBBLDNDP()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x00680BC8 File Offset: 0x0067EDC8
		private void ELFLOPJDAKK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("ClimbIdle", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "WeaponReady";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x00680CA0 File Offset: 0x0067EEA0
		public void IMDOPCJOPDC(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1926f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 762f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 474f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 271f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 917f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x00680D8C File Offset: 0x0067EF8C
		public void ILJNCFMFKOE(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1364f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 385f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1294f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 522f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 487f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x00680E78 File Offset: 0x0067F078
		private void HMEAENGBFKC()
		{
			if (!this.oculusSetup.BLAOADCPHAG())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 961f;
				}
				this.HMMPPDKPDMG(Vector3.zero);
				this.KCLACNEILLB.SetFloat("OK aukKeyMEditOk", 1312f);
				this.KCLACNEILLB.SetFloat("droplinemsg1", 1463f);
				return;
			}
			this.DEJCOKIGCIP(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.GCPKBCPFHBP();
			this.EHNLFNPEKNC(Vector3.MoveTowards(this.PEALGAOLPDF(), target, Time.deltaTime * this.linearAcceleration));
			this.AMLALEBBMJL(Vector3.SmoothDamp(this.HCGDCNFODNE(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.NMJJNKFIFFA() == Vector3.zero) ? 29f : 1347f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1433f);
			}
			this.KCLACNEILLB.SetFloat("WeaponRun", this.APOIOHJJDDC.x);
			this.KCLACNEILLB.SetFloat("StartPhysPoint", this.IHGOLABKDHO().z);
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x00681010 File Offset: 0x0067F210
		public void DJACBMLJOJO(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1497f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 1995f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 858f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 1001f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1879f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 GHEBFPNBAPA()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x006810FC File Offset: 0x0067F2FC
		private void JJFHPGDPHGB()
		{
			if (!this.oculusSetup.CLDJANJPCJC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 998f;
				}
				this.ILNGIGEJDGB(Vector3.zero);
				this.KCLACNEILLB.SetFloat("#000000", 156f);
				this.KCLACNEILLB.SetFloat("SkateboardIdle", 1752f);
				return;
			}
			this.OOGPGICFCDA(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.NDHGMNLABCL();
			this.CGNDBLBIMCC(Vector3.MoveTowards(this.IKJDBMBIBJP(), target, Time.deltaTime * this.linearAcceleration));
			this.GFDKEPBODFH(Vector3.SmoothDamp(this.IPNJAEHGPKF(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.DJEHKDMEAED() == Vector3.zero) ? 1318f : 876f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1126f);
			}
			this.KCLACNEILLB.SetFloat("", this.DGPDEIODEBG().x);
			this.KCLACNEILLB.SetFloat("<[^>]+>", this.DEGNEFEJBIN().z);
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void HGKJNEDMLLI(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void PBCNCLOPLAH(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void NCAEEIJECEH(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x00681294 File Offset: 0x0067F494
		public void DJCMHKFOAFG(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1112f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 516f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 815f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 182f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 1457f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x00681380 File Offset: 0x0067F580
		private void CBPPOJCGFKH()
		{
			if (!this.oculusSetup.GPHNOGHKFGH())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 42f;
				}
				this.PBCNCLOPLAH(Vector3.zero);
				this.KCLACNEILLB.SetFloat("ObscuredVector3 vs Vector3, ", 1260f);
				this.KCLACNEILLB.SetFloat("WoodSaw", 1551f);
				return;
			}
			this.ACEFPBADMAE(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FEMEOGNECMM();
			this.OBJLABMMKCE(Vector3.MoveTowards(this.NMJJNKFIFFA(), target, Time.deltaTime * this.linearAcceleration));
			this.HGKJNEDMLLI(Vector3.SmoothDamp(this.ABJAGGEBACI(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime));
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.MMDBEKLIOHF() == Vector3.zero) ? 1278f : 1389f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 1142f);
			}
			this.KCLACNEILLB.SetFloat("2", this.IPNJAEHGPKF().x);
			this.KCLACNEILLB.SetFloat("<<", this.DIMDOCOAMFJ().z);
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void NNHBHDNJPPE(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x00681518 File Offset: 0x0067F718
		private void FPLHODJCJDO()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("IceHockeyPassRight", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "B";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x006815F0 File Offset: 0x0067F7F0
		public void GOCHOPKFEJG(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 1789f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 538f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 1548f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 837f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 320f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E470 RID: 58480 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void EHEIOAAPHDG(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 NIMGHABNGFF()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void IILLDHHMKPF(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x00681710 File Offset: 0x0067F910
		private void Update()
		{
			if (!this.oculusSetup.EAMGCODKKDD)
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1f;
				}
				this.APOIOHJJDDC = Vector3.zero;
				this.KCLACNEILLB.SetFloat("Right", 0f);
				this.KCLACNEILLB.SetFloat("Forward", 0f);
				return;
			}
			this.RotateCharacter(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.FEMEOGNECMM();
			this.APOIOHJJDDC = Vector3.MoveTowards(this.APOIOHJJDDC, target, Time.deltaTime * this.linearAcceleration);
			this.APOIOHJJDDC = Vector3.SmoothDamp(this.APOIOHJJDDC, target, ref this.EOALGBLPDCI, this.smoothAccelerationTime);
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.APOIOHJJDDC == Vector3.zero) ? 1f : 0f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 3f);
			}
			this.KCLACNEILLB.SetFloat("Right", this.APOIOHJJDDC.x);
			this.KCLACNEILLB.SetFloat("Forward", this.APOIOHJJDDC.z);
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x006818A8 File Offset: 0x0067FAA8
		private void BIGPMMGBPJC()
		{
			if (!this.oculusSetup.GKKLNBGJMFC())
			{
				if (this.MALCFBPCNJK != null)
				{
					this.MALCFBPCNJK.weight = 1641f;
				}
				this.GFDKEPBODFH(Vector3.zero);
				this.KCLACNEILLB.SetFloat("enable", 391f);
				this.KCLACNEILLB.SetFloat("Player", 1773f);
				return;
			}
			this.NAGKFHFCHEG(this.cam.forward, this.maxViewAngle, this.MFAFEGIHAPA);
			Vector3 target = this.MOLBHBBEFKC();
			this.ACFKEIOHPEE(Vector3.MoveTowards(this.IKJDBMBIBJP(), target, Time.deltaTime * this.linearAcceleration));
			this.APOIOHJJDDC = Vector3.SmoothDamp(this.CDNCDGHAIJO(), target, ref this.EOALGBLPDCI, this.smoothAccelerationTime);
			base.transform.position = new Vector3(this.characterController.position.x, base.transform.position.y, this.characterController.position.z);
			if (this.MALCFBPCNJK != null)
			{
				float target2 = (this.PEALGAOLPDF() == Vector3.zero) ? 1574f : 1198f;
				this.MALCFBPCNJK.weight = Mathf.MoveTowards(this.MALCFBPCNJK.weight, target2, Time.deltaTime * 356f);
			}
			this.KCLACNEILLB.SetFloat("wpn_add/req/reqPerk", this.CFLCPCFGEMN().x);
			this.KCLACNEILLB.SetFloat("gi_frac_i", this.AHCIEBDEKGJ().z);
		}

		// Token: 0x0600E475 RID: 58485 RVA: 0x0067C3B5 File Offset: 0x0067A5B5
		private void JHKINALKFAD(Vector3 DCCPCBLODIG)
		{
			this.<DPBDBCLGIOC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x00681A40 File Offset: 0x0067FC40
		private void CKGPEFOKKNL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("No valid adaptive tonemapper type found!", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "_FrustumCornersWS";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x00681B18 File Offset: 0x0067FD18
		private void KJJNMNKPNCH()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("OneHandSwordRun", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "#000000";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 AHCIEBDEKGJ()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 MMDBEKLIOHF()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00681BF0 File Offset: 0x0067FDF0
		private void LHHKDNILMDI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("fishDown SHANCE", false);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "buykey";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x00681CC8 File Offset: 0x0067FEC8
		private void JLKBMEBFHBI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.MALCFBPCNJK = base.gameObject.AddComponent<FixFeet>();
			this.KCLACNEILLB.SetBool("MotorbikeBackwardSitting", true);
			this.GLOIBIHKCDJ = this.characterController.position;
			this.MFAFEGIHAPA = new GameObject().transform;
			this.MFAFEGIHAPA.name = "OneHandSwordRun";
			this.MFAFEGIHAPA.position = this.characterController.position + this.characterController.rotation * this.cameraOffset;
			this.MFAFEGIHAPA.rotation = this.characterController.rotation;
			this.MFAFEGIHAPA.parent = this.characterController;
			this.cam.parent = this.MFAFEGIHAPA;
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x00681DA0 File Offset: 0x0067FFA0
		public void RotateCharacter(Vector3 MMJEOLDMMIA, float OKOFBNECLBI, Transform JKLMDCHCFPG = null)
		{
			if (OKOFBNECLBI >= 180f)
			{
				return;
			}
			Quaternion rotation = (JKLMDCHCFPG != null) ? JKLMDCHCFPG.rotation : Quaternion.identity;
			if (OKOFBNECLBI <= 0f)
			{
				this.characterController.rotation = Quaternion.LookRotation(new Vector3(MMJEOLDMMIA.x, 0f, MMJEOLDMMIA.z));
				if (JKLMDCHCFPG != null)
				{
					JKLMDCHCFPG.rotation = rotation;
				}
				return;
			}
			Vector3 vector = this.characterController.InverseTransformDirection(MMJEOLDMMIA);
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			if (Mathf.Abs(num) > Mathf.Abs(OKOFBNECLBI))
			{
				float angle = num - OKOFBNECLBI;
				if (num < 0f)
				{
					angle = num + OKOFBNECLBI;
				}
				this.characterController.rotation = Quaternion.AngleAxis(angle, this.characterController.up) * this.characterController.rotation;
			}
			if (JKLMDCHCFPG != null)
			{
				JKLMDCHCFPG.rotation = rotation;
			}
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 MIBIKPDJBJF()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x0067C3BE File Offset: 0x0067A5BE
		public Vector3 IKJDBMBIBJP()
		{
			return this.<DPBDBCLGIOC>k__BackingField;
		}

		// Token: 0x04001DDB RID: 7643
		[Header("Component References")]
		public VRSetup oculusSetup;

		// Token: 0x04001DDC RID: 7644
		public Transform characterController;

		// Token: 0x04001DDD RID: 7645
		public Transform cam;

		// Token: 0x04001DDE RID: 7646
		[Header("Main Properties")]
		[Tooltip("Offset of the VR camera")]
		public Vector3 cameraOffset;

		// Token: 0x04001DDF RID: 7647
		[Tooltip("How long to accelerate to target velocity using SmoothDamp?")]
		public float smoothAccelerationTime = 0.2f;

		// Token: 0x04001DE0 RID: 7648
		[Tooltip("How fast to accelerate liearily? If this is zero, will only use smooth acceleration.")]
		public float linearAcceleration = 2f;

		// Token: 0x04001DE1 RID: 7649
		[Tooltip("Rotate the character along if camera is looking too far left/right.")]
		public float maxViewAngle = 60f;

		// Token: 0x04001DE2 RID: 7650
		[Tooltip("The master speed of locomotion animations.")]
		public float locomotionSpeed = 1f;

		// Token: 0x04001DE4 RID: 7652
		private Animator KCLACNEILLB;

		// Token: 0x04001DE5 RID: 7653
		private Vector3 EOALGBLPDCI;

		// Token: 0x04001DE6 RID: 7654
		private bool CLBCGLAHGKP;

		// Token: 0x04001DE7 RID: 7655
		private Vector3 BKGNDJKFGHE;

		// Token: 0x04001DE8 RID: 7656
		private Vector3 GLOIBIHKCDJ;

		// Token: 0x04001DE9 RID: 7657
		private FixFeet MALCFBPCNJK;

		// Token: 0x04001DEA RID: 7658
		private Transform MFAFEGIHAPA;
	}
}
