using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002BA RID: 698
	public class FreeCameraMove : MonoBehaviour
	{
		// Token: 0x0600A440 RID: 42048 RVA: 0x0049E2DC File Offset: 0x0049C4DC
		private void Update()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 0f || vector.x > (float)Screen.width || vector.y < 0f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Mouse X") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Mouse Y") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, -90f, 90f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Vertical") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Horizontal") * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Vertical") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Horizontal") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Q))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.E))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x0049E648 File Offset: 0x0049C848
		private void GCNGEFBKMNC()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1904f || vector.x > (float)Screen.width || vector.y < 1290f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("DropType") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("No valid adaptive tonemapper type found!") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1539f, 883f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-200)) || Input.GetKey((KeyCode)(-60)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("BlackSmithHammer") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("gi_uinf_7") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-6)) || Input.GetKey((KeyCode)(-173)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("BAG") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("H:") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("checkPet 2") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("wpn_wgt") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)67))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)74))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x0049E9B4 File Offset: 0x0049CBB4
		private void AKLFCMNCPKL()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 710f || vector.x > (float)Screen.width || vector.y < 311f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("TOD_MoonMeshColor") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("WATER_REFLECTIVE") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1113f, 1203f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)132) || Input.GetKey((KeyCode)3))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("GiantGrabIdle") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_ChannelMixerRed") * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.Alpha3) || Input.GetKey((KeyCode)197))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Calf") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("Hidden/Post FX/Builtin Debug Views") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("_ChannelMixerBlue") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.K))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-124)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void BBFPILBIMKC()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x0049ED27 File Offset: 0x0049CF27
		private void FLDMAFHJLNB()
		{
			GUI.Label(new Rect(1864f, 128f, (float)(Screen.width - 122), 706f), "_NoisePerChannel");
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void ELADFDNPOOI()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x0049ED50 File Offset: 0x0049CF50
		private void EOCENEIDJKI()
		{
			GUI.Label(new Rect(1184f, 1124f, (float)(Screen.width - 21), 40f), "gameComplete");
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void CLHGHANANNL()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x0049ED84 File Offset: 0x0049CF84
		private void PAKOHKKBKHD()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 500f || vector.x > (float)Screen.width || vector.y < 133f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("UNDERLINE") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("OnRodChangeClck order_check=") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 970f, 543f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-71)) || Input.GetKey((KeyCode)(-21)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("BackPackGrab") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("msgCancel") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-108)) || Input.GetKey((KeyCode)(-116)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("1") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("error.wav") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis(" length is zero, can not solve.") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-25)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)66))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x0049F0EF File Offset: 0x0049D2EF
		private void MJDKGMEPMHK()
		{
			GUI.Label(new Rect(480f, 1503f, (float)(Screen.width - -37), 1688f), "wpn_eat4");
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0049F118 File Offset: 0x0049D318
		private void EILPBPNOMJI()
		{
			GUI.Label(new Rect(1936f, 686f, (float)(Screen.width - -66), 1463f), "id");
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x0049F144 File Offset: 0x0049D344
		private void LMMDHJJJNJO()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1097f || vector.x > (float)Screen.width || vector.y < 883f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("_TexelOffsetScale") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis(" B:") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1104f, 1255f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-43)) || Input.GetKey((KeyCode)(-81)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("error.wav") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("tintColor") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-34)) || Input.GetKey((KeyCode)132))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Thumb") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("{0}") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("MotorbikeTurnLeft") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("Eyes") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Alpha7))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-104)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x0049F4B0 File Offset: 0x0049D6B0
		private void CBBLGEDCJBF()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1817f || vector.x > (float)Screen.width || vector.y < 1655f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("WorkerShovel") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("rait_5") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1316f, 1671f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-165)) || Input.GetKey((KeyCode)143))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_Offsets") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("WizardOverhead") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-37)) || Input.GetKey(KeyCode.Alpha3))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("CrouchWalkBackward") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("_Newitem.wav") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("msgCancel") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.O))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-116)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x0049F81B File Offset: 0x0049DA1B
		private void AHEAJPNHBBB()
		{
			GUI.Label(new Rect(1377f, 1940f, (float)(Screen.width - -38), 1640f), "weapon");
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x0049F844 File Offset: 0x0049DA44
		private void LDDIGEMBDNF()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 384f || vector.x > (float)Screen.width || vector.y < 23f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("threshold") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("IdleKeepBack") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1592f, 1957f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)150) || Input.GetKey((KeyCode)(-67)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("MotorbikeLookBack") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("WeaponRunBackward") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-28)) || Input.GetKey(KeyCode.Percent))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("isRagulaSet") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis(",") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("VIGNETTE_MASKED") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("1HandSwordChargeHeavyBash") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)22))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-48)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void LHHKDNILMDI()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x0049FBAF File Offset: 0x0049DDAF
		private void KBAJMMCHDOC()
		{
			GUI.Label(new Rect(1586f, 1196f, (float)(Screen.width - 80), 54f), "to channel = ");
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void CGNGBFFGGBP()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void HDGNIHBIEDG()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0049FBD8 File Offset: 0x0049DDD8
		private void OPDCJCFMIPE()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1842f || vector.x > (float)Screen.width || vector.y < 597f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Heel Click") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Player") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 75f, 1381f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)146) || Input.GetKey(KeyCode.Delete))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("auk_wmax") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("BlurXY") * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey((KeyCode)(-123)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("spindrop") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("wpn_line3") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("Flap_04.wav") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)76))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-70)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x0049FF43 File Offset: 0x0049E143
		private void AGBEEDOOOHA()
		{
			GUI.Label(new Rect(875f, 619f, (float)(Screen.width - 86), 712f), "FASTEST");
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x0049FF6C File Offset: 0x0049E16C
		private void GGOKNBBPLHB()
		{
			GUI.Label(new Rect(1686f, 1641f, (float)(Screen.width - -21), 1899f), "IdleRun");
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void GDIMBBBPIHI()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x0049FF98 File Offset: 0x0049E198
		private void DFFOEGHGPGP()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1694f || vector.x > (float)Screen.width || vector.y < 448f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("\n") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Masks") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1649f, 321f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)148) || Input.GetKey((KeyCode)(-59)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("uint: ") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("non MonoBehaviour") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-141)) || Input.GetKey(KeyCode.Question))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("repair.ogg") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("CratePull") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("{0}/{1}") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("{0}KLIK_10.tif") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-68)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-29)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void EHDPACPIBNF()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x004A0304 File Offset: 0x0049E504
		private void IKHCCAANGOP()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 56f || vector.x > (float)Screen.width || vector.y < 910f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("repair.ogg") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("OfficeSittingReadingLeanBack") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1597f, 1667f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.Semicolon) || Input.GetKey(KeyCode.Caret))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("pempty=0") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("ProneLocomotion") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)66) || Input.GetKey((KeyCode)(-119)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("PaperTurn.wav") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("IK Effector is referencing to a bone '") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("musicVolume") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-115)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-33)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x004A0670 File Offset: 0x0049E870
		private void JIBKGOFOPHJ()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1381f || vector.x > (float)Screen.width || vector.y < 1600f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("_Intensity") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("pinky") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1178f, 547f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-87)) || Input.GetKey((KeyCode)187))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("TOD_LocalSunDirection") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("ChannelCastOmni") * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.DoubleQuote) || Input.GetKey((KeyCode)199))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("****************  playMusicBase ") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("SexyDance2") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("_ToPrevViewProjCombined") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("titul_data/tituls/titul") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)22))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)85))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x004A09DB File Offset: 0x0049EBDB
		private void GCLIPIADIPD()
		{
			GUI.Label(new Rect(1196f, 636f, (float)(Screen.width - -77), 215f), "OneHandSwordBlock");
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x004A0A04 File Offset: 0x0049EC04
		private void KMPEBHIPKJH()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1189f || vector.x > (float)Screen.width || vector.y < 359f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("FlyDown") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("_PlaneReflection") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1108f, 1858f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-86)) || Input.GetKey((KeyCode)(-164)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("isUsedPersonal") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("INTERFACE") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)179) || Input.GetKey((KeyCode)140))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("The polygon must have at least 3 Limit Points.") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("BowIdle") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("money") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Period))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Alpha0))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x004A0D6F File Offset: 0x0049EF6F
		private void HCCGBDPCEKO()
		{
			GUI.Label(new Rect(56f, 462f, (float)(Screen.width - 104), 937f), "Cloth_05_00.wav");
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x004A0D98 File Offset: 0x0049EF98
		private void HFPPENPGGAI()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 606f || vector.x > (float)Screen.width || vector.y < 1030f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("inv_money") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Shotgun Reload Chamber") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 679f, 117f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)157) || Input.GetKey((KeyCode)(-3)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("intensity") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("IdleReadyLook") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-13)) || Input.GetKey((KeyCode)(-75)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("craft_time") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("DeadmanFloat") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("1HandSwordStrafeRight") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("MotorbikeSuperman") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.BackQuote))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Dollar))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x004A1104 File Offset: 0x0049F304
		private void JPHLMNIMDHH()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1718f || vector.x > (float)Screen.width || vector.y < 201f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("S") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("achive_text") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 164f, 253f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-186)) || Input.GetKey((KeyCode)(-78)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("</color>") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("#003080") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-132)) || Input.GetKey((KeyCode)139))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis(" ") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("KarateGreet") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("collar") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("_Offsets") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-124)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Pause))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void JHFAHBIIJDC()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void MCHAAIIHOKD()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void PNJHMJNFPLP()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x004A1470 File Offset: 0x0049F670
		private void DPGECEOMHNM()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 107f || vector.x > (float)Screen.width || vector.y < 1408f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Far") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("demoByteArray") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1878f, 82f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)29) || Input.GetKey((KeyCode)81))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("WpnLang.xml") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("walk") * Time.deltaTime;
			}
			else if (Input.GetKey(KeyCode.Return) || Input.GetKey((KeyCode)(-93)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("No IK assigned in HitReaction") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("isMoving") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("rodDwDelta=") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("FaceHit") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-14)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-90)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void GHCMIKGJPJD()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x004A17DB File Offset: 0x0049F9DB
		private void ECLMFCKLJNM()
		{
			GUI.Label(new Rect(1501f, 297f, (float)(Screen.width - 119), 1318f), "<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x004A1804 File Offset: 0x0049FA04
		private void GCCAPOHGAHA()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1121f || vector.x > (float)Screen.width || vector.y < 1309f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Квест") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("DeadmanFloat") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1106f, 1938f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-189)) || Input.GetKey((KeyCode)129))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("?") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Left") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)186) || Input.GetKey((KeyCode)(-3)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("wpnlang/wpntypes/type") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("https://www.youtube.com/watch?v=eP9-zycoHLk") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("Sorry, VRIK Script reference is not finished yet.") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-85)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-4)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void CJNBMPCNKHP()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x004A1B6F File Offset: 0x0049FD6F
		private void BEOFOEMOJAN()
		{
			GUI.Label(new Rect(834f, 1258f, (float)(Screen.width - 5), 1236f), "<color='#000000'>--------------------------------------------------------</color>");
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void ADLHNBEDHMJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x004A1B98 File Offset: 0x0049FD98
		private void JGDDEOALNOG()
		{
			GUI.Label(new Rect(466f, 1018f, (float)(Screen.width - -90), 674f), "GestureChestPumpSalute");
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void JLKBMEBFHBI()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x004A1BC1 File Offset: 0x0049FDC1
		private void LPNFGGAKGID()
		{
			GUI.Label(new Rect(1700f, 864f, (float)(Screen.width - 127), 348f), "_MainTex");
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void PLBDELOIINH()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x004A1BEA File Offset: 0x0049FDEA
		private void BKPJAHOPBCP()
		{
			GUI.Label(new Rect(599f, 902f, (float)(Screen.width - 24), 494f), "BackPackOff");
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x004A1C13 File Offset: 0x0049FE13
		private void NECHJAHFOFF()
		{
			GUI.Label(new Rect(964f, 196f, (float)(Screen.width - -29), 538f), "Hidden/Amplify Color/ProcessOnly");
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x004A1C3C File Offset: 0x0049FE3C
		private void CLEONAEHLON()
		{
			GUI.Label(new Rect(1303f, 1199f, (float)(Screen.width - 60), 822f), "CraftProf.xml");
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x004A1C68 File Offset: 0x0049FE68
		private void KJJBBLDJHPD()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 688f || vector.x > (float)Screen.width || vector.y < 49f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Kernel") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("MotorbikeShootLeft") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1227f, 849f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)75) || Input.GetKey((KeyCode)199))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("IceHockey Shot Left") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-197)) || Input.GetKey(KeyCode.H))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("29") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("BlackSmithHammer") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("removed") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("wplabel") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-128)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-95)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void BJHGPFGBFKF()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x004A1FD4 File Offset: 0x004A01D4
		private void EMFOECIPBIP()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 150f || vector.x > (float)Screen.width || vector.y < 1349f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("TOD_MoonMeshContrast") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1497f, 538f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)84) || Input.GetKey(KeyCode.Minus))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("KatanaReadyHigh") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-133)) || Input.GetKey(KeyCode.Alpha0))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("true") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("sunshine_Lightmap") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)74))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-61)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void KIEIPFFEDHC()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x004A237E File Offset: 0x004A057E
		private void MGMMDKNGDCA()
		{
			GUI.Label(new Rect(1516f, 616f, (float)(Screen.width - -97), 1205f), "\n");
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void BHFMGBNIAMC()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x004A23A7 File Offset: 0x004A05A7
		private void AIGIILFGEPC()
		{
			GUI.Label(new Rect(146f, 607f, (float)(Screen.width - 33), 652f), "Horizontal");
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void Start()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x004A23D0 File Offset: 0x004A05D0
		private void HKGCKLBHNPJ()
		{
			GUI.Label(new Rect(97f, 111f, (float)(Screen.width - -66), 896f), "Ошибка: ");
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x004A23F9 File Offset: 0x004A05F9
		private void ELLJEHHACHL()
		{
			GUI.Label(new Rect(1292f, 1058f, (float)(Screen.width - -118), 750f), "DENSITY");
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x004A2422 File Offset: 0x004A0622
		private void OnGUI()
		{
			GUI.Label(new Rect(10f, 10f, (float)(Screen.width - 20), 30f), "Move camera around freely with WASD and mouse.");
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x004A244C File Offset: 0x004A064C
		private void IOGAKGCADBL()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 861f || vector.x > (float)Screen.width || vector.y < 339f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("fishDown SHANCE") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("does not exist.") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 350f, 1626f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-122)) || Input.GetKey(KeyCode.U))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("TYPES") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("GiantEat") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)165) || Input.GetKey((KeyCode)(-196)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("FactoryTempTexture") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("\n") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("L") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)3))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-110)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void FGJCIEDDFGN()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x004A27B7 File Offset: 0x004A09B7
		private void BBGAONKBIPJ()
		{
			GUI.Label(new Rect(1606f, 1884f, (float)(Screen.width - -45), 1942f), "Name: ");
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x004A27E0 File Offset: 0x004A09E0
		private void PNBGJBMJLFM()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 192f || vector.x > (float)Screen.width || vector.y < 430f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("\n") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("inv_auksum") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1443f, 360f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-77)) || Input.GetKey((KeyCode)85))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Используем ") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("wpn_eat1") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)83) || Input.GetKey((KeyCode)(-62)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Idle Keep Back") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Can't use reflection here, sorry :(") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("wpn_add/base") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("_Params") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-5)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-38)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void FFIGGPHAIBP()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void AIFIEAGFIMM()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void ELFLOPJDAKK()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x004A2B4B File Offset: 0x004A0D4B
		private void BIOKMDIGOIA()
		{
			GUI.Label(new Rect(641f, 1589f, (float)(Screen.width - -13), 158f), "IdleMouthWipe");
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x004A2B74 File Offset: 0x004A0D74
		private void FIPDKFFEKDD()
		{
			GUI.Label(new Rect(41f, 404f, (float)(Screen.width - 106), 546f), "id");
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x004A2BA0 File Offset: 0x004A0DA0
		private void LMGBKHCHPHO()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 536f || vector.x > (float)Screen.width || vector.y < 182f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("auc_wcswcp") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("BowFire2") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1456f, 739f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.W))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Staff Heal") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("\n") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)131) || Input.GetKey((KeyCode)84))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_AccumulationTex") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_BlurTex") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("1") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("Try Goscurry! Or better buy it!") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Pipe))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-45)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x004A2F0C File Offset: 0x004A110C
		private void KMLNBHIIGKH()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1159f || vector.x > (float)Screen.width || vector.y < 591f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("IdleMeditate") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("_w") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1260f, 1598f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-36)) || Input.GetKey((KeyCode)(-35)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("AppID:") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_Color") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-53)) || Input.GetKey(KeyCode.Equals))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("http://www.root-motion.com/finalikdox/html/page11.html") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("WeaponInstant") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("#ffffff") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("cntx_drop") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)70))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Comma))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x004A3278 File Offset: 0x004A1478
		private void HABONMJNDAL()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1963f || vector.x > (float)Screen.width || vector.y < 243f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("> ") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Fonts/") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1874f, 1438f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.BackQuote))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("OfficeSitting1LegStraight") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("BackPackGrab") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-133)) || Input.GetKey((KeyCode)(-97)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_ScratchTex") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("8192") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("Right") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("}") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-119)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-106)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void FIJKDFIMELM()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void KGICJDGIIJK()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void CKGPEFOKKNL()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x004A35E3 File Offset: 0x004A17E3
		private void BKFLIDKPDDI()
		{
			GUI.Label(new Rect(39f, 95f, (float)(Screen.width - 13), 110f), "wpn_rod1");
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x004A360C File Offset: 0x004A180C
		private void HMEAENGBFKC()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 171f || vector.x > (float)Screen.width || vector.y < 1202f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis(" \"{0}\"") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("PistolReady") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 464f, 1809f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)182) || Input.GetKey((KeyCode)(-186)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("1") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("wpn_tank1") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-40)) || Input.GetKey((KeyCode)14))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("post_3") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_BilateralUpsampling") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("Reveling") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis(" bundle") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Quote))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)69))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void DNLFEOECBKI()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x004A3978 File Offset: 0x004A1B78
		private void PFNOEACNHON()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1796f || vector.x > (float)Screen.width || vector.y < 1930f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("Vertical") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("active_obj_") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1800f, 1950f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)159) || Input.GetKey((KeyCode)(-140)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("********* connect to chat ") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_rcOut.ogg") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)67) || Input.GetKey((KeyCode)14))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("exitmsg_3") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_AutoExposure") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis(" remnabor=") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("__c") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.W))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.RightBracket))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void EHFPLKEINFO()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x004A3CE4 File Offset: 0x004A1EE4
		private void KBMKHLDOIKP()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 917f || vector.x > (float)Screen.width || vector.y < 1594f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("IceHockey") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Crouch180") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 383f, 1508f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-152)) || Input.GetKey((KeyCode)(-35)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("WoodSaw") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("ZombieWalk") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-19)) || Input.GetKey((KeyCode)(-53)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Face Palm") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("<color='#002060'>") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("wpn_rod4") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)28))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Delete))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x004A4050 File Offset: 0x004A2250
		private void HNMODJBBKBI()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1885f || vector.x > (float)Screen.width || vector.y < 1329f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis(" ") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("_ProjMatrix") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 827f, 1462f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.T) || Input.GetKey(KeyCode.Alpha9))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_History2Weight") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("ClimbLeft") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)157) || Input.GetKey(KeyCode.V))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("MENU.WAV") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("_Newitem.wav") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("MotorbikeHandstand") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("wpn_add") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)2))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-71)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x004A43BC File Offset: 0x004A25BC
		private void IDMCOLDDNCF()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1149f || vector.x > (float)Screen.width || vector.y < 1898f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("x") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("KatanaReadyLow") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1773f, 1589f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-9)) || Input.GetKey((KeyCode)143))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("Apply 3") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("AFCServer") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-14)) || Input.GetKey(KeyCode.Alpha3))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("<b>WallHack Detector</b>") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("FASTEST") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("1 Hand Sword Strafe Right") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("1 Hand Sword Jab Combo") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)76))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.DoubleQuote))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x004A4728 File Offset: 0x004A2928
		private void MEFOGCFJBNE()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1877f || vector.x > (float)Screen.width || vector.y < 1381f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("gi_fridgice") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("SneakRight") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 333f, 528f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-189)) || Input.GetKey((KeyCode)(-28)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("languageid") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("[ACTk] <b>[ ObscuredVector3 test ]</b>") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)129) || Input.GetKey((KeyCode)(-5)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("WallRunLeft") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("error") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("BackPackOff") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("_Axis") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-85)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Slash))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x004A4A94 File Offset: 0x004A2C94
		private void FPLNDDMFFKG()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1115f || vector.x > (float)Screen.width || vector.y < 170f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("cht_msg15") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("_Exposure") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1296f, 1044f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-3)) || Input.GetKey((KeyCode)142))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("PaperTurn.wav") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("{2:D2}:{0:D2}:{1:D2}") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-139)) || Input.GetKey((KeyCode)(-17)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("AC_DITHERING") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis(" ms") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("BowInstant") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.LeftCurlyBracket))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-20)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void FPLHODJCJDO()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x004A4E00 File Offset: 0x004A3000
		private void OHKHOAKCENL()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1347f || vector.x > (float)Screen.width || vector.y < 288f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("______________________________") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("#a0a0a0") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 248f, 1223f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-14)) || Input.GetKey(KeyCode.LeftParen))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("FlyBackward") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("signal_enable") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-106)) || Input.GetKey((KeyCode)(-97)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("RollerBladeRoll") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("cash.ogg") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("hips") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("_BaseTex") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-79)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-19)))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x004A516B File Offset: 0x004A336B
		private void JBGGMKEKOAN()
		{
			GUI.Label(new Rect(1837f, 486f, (float)(Screen.width - 95), 1169f), "IceHockeyDekeMiddle");
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void FJGIBCHABIG()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x004A5194 File Offset: 0x004A3394
		private void JOHDLNOKCOK()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 297f || vector.x > (float)Screen.width || vector.y < 952f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("subtype") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("{0}/{1}") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 380f, 292f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey(KeyCode.RightCurlyBracket) || Input.GetKey((KeyCode)(-193)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_rcIn.ogg") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("минут") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)(-170)) || Input.GetKey(KeyCode.Equals))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("No Mask") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("ObscuredInt vs int, ") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("") * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.E))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.Tab))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x004A5500 File Offset: 0x004A3700
		private void DAFJMNMFOON()
		{
			Vector2 vector = Input.mousePosition;
			if (vector.x < 1323f || vector.x > (float)Screen.width || vector.y < 690f || vector.y > (float)Screen.height)
			{
				return;
			}
			this.AEJEJGFFFCD += Input.GetAxis("maxWgtBait") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH += Input.GetAxis("Internal LUT") * this.cameraSensitivity * Time.deltaTime;
			this.PCBBHADFEFH = Mathf.Clamp(this.PCBBHADFEFH, 1876f, 885f);
			base.transform.localRotation = Quaternion.AngleAxis(this.AEJEJGFFFCD, Vector3.up);
			base.transform.localRotation *= Quaternion.AngleAxis(this.PCBBHADFEFH, Vector3.left);
			if (Input.GetKey((KeyCode)(-179)) || Input.GetKey((KeyCode)(-91)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("FA") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.fastMoveFactor) * Input.GetAxis("_LerpRgbTex") * Time.deltaTime;
			}
			else if (Input.GetKey((KeyCode)132) || Input.GetKey((KeyCode)(-102)))
			{
				base.transform.position += base.transform.forward * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("3") * Time.deltaTime;
				base.transform.position += base.transform.right * (this.normalMoveSpeed * this.slowMoveFactor) * Input.GetAxis("Отпущена рыба") * Time.deltaTime;
			}
			else
			{
				base.transform.position += base.transform.forward * this.normalMoveSpeed * Input.GetAxis("KneesIdle") * Time.deltaTime;
				base.transform.position += base.transform.right * this.normalMoveSpeed * Input.GetAxis("closePodsak") * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)(-31)))
			{
				base.transform.position -= base.transform.up * this.climbSpeed * Time.deltaTime;
			}
			if (Input.GetKey((KeyCode)81))
			{
				base.transform.position += base.transform.up * this.climbSpeed * Time.deltaTime;
			}
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x004A586B File Offset: 0x004A3A6B
		private void JCMGHHKALDM()
		{
			GUI.Label(new Rect(397f, 467f, (float)(Screen.width - 14), 435f), "_TintColor");
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x004A5894 File Offset: 0x004A3A94
		private void GHOJCADBKEK()
		{
			GUI.Label(new Rect(398f, 612f, (float)(Screen.width - -21), 1163f), "0_");
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x0049ED79 File Offset: 0x0049CF79
		private void CHDJGEOFHEE()
		{
			Cursor.lockState = CursorLockMode.None;
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void CGFDDFHECLJ()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x004A58BD File Offset: 0x004A3ABD
		private void BMCKJEBCEPA()
		{
			GUI.Label(new Rect(1512f, 992f, (float)(Screen.width - -76), 1584f), "Press E to resume interaction");
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x004A58E6 File Offset: 0x004A3AE6
		private void KIEFPGLDOCD()
		{
			GUI.Label(new Rect(542f, 121f, (float)(Screen.width - 37), 406f), "Grounded Directional");
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x0049ED1F File Offset: 0x0049CF1F
		private void FEBIICIMLHA()
		{
			Cursor.lockState = CursorLockMode.Locked;
		}

		// Token: 0x0400150A RID: 5386
		public float cameraSensitivity = 150f;

		// Token: 0x0400150B RID: 5387
		public float climbSpeed = 20f;

		// Token: 0x0400150C RID: 5388
		public float normalMoveSpeed = 20f;

		// Token: 0x0400150D RID: 5389
		public float slowMoveFactor = 0.25f;

		// Token: 0x0400150E RID: 5390
		public float fastMoveFactor = 3f;

		// Token: 0x0400150F RID: 5391
		private float AEJEJGFFFCD;

		// Token: 0x04001510 RID: 5392
		private float PCBBHADFEFH;
	}
}
