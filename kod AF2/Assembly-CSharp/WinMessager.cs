using System;
using UnityEngine;

// Token: 0x0200019A RID: 410
public class WinMessager : MonoBehaviour
{
	// Token: 0x06005B74 RID: 23412 RVA: 0x002AE6C0 File Offset: 0x002AC8C0
	private void KPMCNHHIEHA(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 36)
		{
			switch (itag)
			{
			case -36:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage(" ", OOLHBMBBABM);
					return;
				}
				break;
			case -35:
			case -33:
				break;
			case -34:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("", OOLHBMBBABM);
					return;
				}
				break;
			case -32:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("RenderTextureUtilityTempTexture", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("SoccerKeeperDiveStrafeCloseRight", OOLHBMBBABM);
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06005B75 RID: 23413 RVA: 0x002AE784 File Offset: 0x002AC984
	private void GEMEIAPLLHK(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -34)
		{
			switch (itag)
			{
			case 43:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("Mouse Y", OOLHBMBBABM);
					return;
				}
				break;
			case 44:
			case 46:
				break;
			case 45:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("PaperTurn.wav", OOLHBMBBABM);
					return;
				}
				break;
			case 47:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("SearchTex", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("OneHandSwordSwing", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B76 RID: 23414 RVA: 0x002AE848 File Offset: 0x002ACA48
	private void BMADFBAHOPF(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -20)
		{
			switch (itag)
			{
			case -46:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html", OOLHBMBBABM);
					return;
				}
				break;
			case -45:
			case -43:
				break;
			case -44:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("cht_msg11", OOLHBMBBABM);
					return;
				}
				break;
			case -42:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Reveling", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("error", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B77 RID: 23415 RVA: 0x002AE90C File Offset: 0x002ACB0C
	private void OLDGJBCOMGM(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -126)
		{
			switch (itag)
			{
			case 84:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("Hidden/Amplify Color/DepthMaskBlend", OOLHBMBBABM);
					return;
				}
				break;
			case 85:
			case 87:
				break;
			case 86:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("Invalid ObscuredVector3 index!", OOLHBMBBABM);
					return;
				}
				break;
			case 88:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Face Palm", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("stretchWidth", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B78 RID: 23416 RVA: 0x002AE9D0 File Offset: 0x002ACBD0
	private void FEPLPFNGGOC(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 9)
		{
			switch (itag)
			{
			case 127:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("WaveSpeed", OOLHBMBBABM);
					return;
				}
				break;
			case 128:
			case 130:
				break;
			case 129:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.", OOLHBMBBABM);
					return;
				}
				break;
			case 131:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Wall Sit", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("wpn_bait1", OOLHBMBBABM);
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06005B79 RID: 23417 RVA: 0x002AEA94 File Offset: 0x002ACC94
	private void HPPODJICHMA(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 81)
		{
			switch (itag)
			{
			case 45:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("MotorbikeBackwardSittingCheer", OOLHBMBBABM);
					return;
				}
				break;
			case 46:
			case 48:
				break;
			case 47:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("_BlurPass", OOLHBMBBABM);
					return;
				}
				break;
			case 49:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("colorB", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("SoccerKeeperDiveStrafeFarRight", OOLHBMBBABM);
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06005B7A RID: 23418 RVA: 0x002AEB58 File Offset: 0x002ACD58
	private void NLHCHIHEBBC(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 122)
		{
			switch (itag)
			{
			case 47:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("", OOLHBMBBABM);
					return;
				}
				break;
			case 48:
			case 50:
				break;
			case 49:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("MotorbikeTurnLeft", OOLHBMBBABM);
					return;
				}
				break;
			case 51:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Windmill", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("id", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x002AEC1C File Offset: 0x002ACE1C
	private void BOHEAGMGPGE(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 95)
		{
			switch (itag)
			{
			case -55:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("Crouching", OOLHBMBBABM);
					return;
				}
				break;
			case -54:
			case -52:
				break;
			case -53:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("http://www.root-motion.com/finalikdox/html/page12.html", OOLHBMBBABM);
					return;
				}
				break;
			case -51:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("MotorbikeHandlebarSit", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B7C RID: 23420 RVA: 0x002AECE0 File Offset: 0x002ACEE0
	private void OBGLMIOBBJP(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -117)
		{
			switch (itag)
			{
			case 39:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("cht_msg23", OOLHBMBBABM);
					return;
				}
				break;
			case 40:
			case 42:
				break;
			case 41:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("wpn_add/base/dropt", OOLHBMBBABM);
					return;
				}
				break;
			case 43:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Current fog preset: ", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("invn_rec8", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B7D RID: 23421 RVA: 0x002AEDA4 File Offset: 0x002ACFA4
	private void ABPGIMOMCKF(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -45)
		{
			switch (itag)
			{
			case 13:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("reflectQuality", OOLHBMBBABM);
					return;
				}
				break;
			case 14:
			case 16:
				break;
			case 15:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("Node transform is null in FBIK chain.", OOLHBMBBABM);
					return;
				}
				break;
			case 17:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("ComeHere", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("val", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B7E RID: 23422 RVA: 0x002AEE68 File Offset: 0x002AD068
	private void EPJHDALLCCH(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 4)
		{
			switch (itag)
			{
			case 29:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("emergencyMode", OOLHBMBBABM);
					return;
				}
				break;
			case 30:
			case 32:
				break;
			case 31:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("{0}Textures/Turnirs/{1}.png", OOLHBMBBABM);
					return;
				}
				break;
			case 33:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("DepthTolerance", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("=", OOLHBMBBABM);
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06005B7F RID: 23423 RVA: 0x002AEF2C File Offset: 0x002AD12C
	private void HCEHCIMNHNG(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != 116)
		{
			switch (itag)
			{
			case 105:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("#80ff00", OOLHBMBBABM);
					return;
				}
				break;
			case 106:
			case 108:
				break;
			case 107:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("______________________________", OOLHBMBBABM);
					return;
				}
				break;
			case 109:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("Toe", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("demoColor", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B80 RID: 23424 RVA: 0x002AEFF0 File Offset: 0x002AD1F0
	private void OKDIICDGJCK(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -68)
		{
			switch (itag)
			{
			case -98:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("FactoryTempTexture", OOLHBMBBABM);
					return;
				}
				break;
			case -97:
			case -95:
				break;
			case -96:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage(" ", OOLHBMBBABM);
					return;
				}
				break;
			case -94:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("FlyUp", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("x", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B81 RID: 23425 RVA: 0x002AF0B4 File Offset: 0x002AD2B4
	private void EGJBDBKDMJD(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -71)
		{
			switch (itag)
			{
			case 77:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("KatanaReadyHigh", OOLHBMBBABM);
					return;
				}
				break;
			case 78:
			case 80:
				break;
			case 79:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("Open Door", OOLHBMBBABM);
					return;
				}
				break;
			case 81:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("WATER_VERTEX_DISPLACEMENT_ON", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("Called GetNumberOfCurrentPlayers()", OOLHBMBBABM);
			}
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x06005B82 RID: 23426 RVA: 0x002AF178 File Offset: 0x002AD378
	private void KMAHNFFEIFM(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -97)
		{
			switch (itag)
			{
			case -28:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("error.wav", OOLHBMBBABM);
					return;
				}
				break;
			case -27:
			case -25:
				break;
			case -26:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("IdleStand", OOLHBMBBABM);
					return;
				}
				break;
			case -24:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("ignorelist", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("gi_letgohe", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B83 RID: 23427 RVA: 0x002AF23C File Offset: 0x002AD43C
	private void JBMAGCHMFPM(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -1)
		{
			switch (itag)
			{
			case 64:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("{0:0.} fps ping:{1} pck/sec: {2}", OOLHBMBBABM);
					return;
				}
				break;
			case 65:
			case 67:
				break;
			case 66:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("FS", OOLHBMBBABM);
					return;
				}
				break;
			case 68:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("<color='#{0}'>{1} {3} {2} </color>\n", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06005B84 RID: 23428 RVA: 0x002AF300 File Offset: 0x002AD500
	private void MJENGKAJDKP(ButtonClicker OOLHBMBBABM)
	{
		int itag = OOLHBMBBABM.itag;
		if (itag != -110)
		{
			switch (itag)
			{
			case -104:
				if (this.noMessageScript != null)
				{
					this.noMessageScript.SendMessage("msgNo", OOLHBMBBABM);
					return;
				}
				break;
			case -103:
			case -101:
				break;
			case -102:
				if (this.cancelMessageScript != null)
				{
					this.cancelMessageScript.SendMessage("msgCancel", OOLHBMBBABM);
					return;
				}
				break;
			case -100:
				if (this.okMessageScript != null)
				{
					this.okMessageScript.SendMessage("msgOk", OOLHBMBBABM);
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			if (this.cancelMessageScript != null)
			{
				this.cancelMessageScript.SendMessage("msgCancel", OOLHBMBBABM);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04000D95 RID: 3477
	public MonoBehaviour okMessageScript;

	// Token: 0x04000D96 RID: 3478
	public MonoBehaviour cancelMessageScript;

	// Token: 0x04000D97 RID: 3479
	public MonoBehaviour noMessageScript;
}
