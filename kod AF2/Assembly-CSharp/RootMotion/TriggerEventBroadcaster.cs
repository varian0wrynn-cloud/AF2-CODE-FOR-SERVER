using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003DA RID: 986
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		// Token: 0x0600D45A RID: 54362 RVA: 0x0060E965 File Offset: 0x0060CB65
		private void MEAMLKCCNFE(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_BaseTex", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D45B RID: 54363 RVA: 0x0060E987 File Offset: 0x0060CB87
		private void KMAOCOANNAK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("<.*?>", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x0060E9A9 File Offset: 0x0060CBA9
		private void NPGNOOMGCKK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("wpn_rem3", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x0060E9CB File Offset: 0x0060CBCB
		private void FABEFBFJKJK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_TreatBackfaceHitAsMiss", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x0060E9ED File Offset: 0x0060CBED
		private void JCOMIMIEABJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Katana45DegSwing", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x0060EA0F File Offset: 0x0060CC0F
		private void MCBNLFGNEOL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("__a", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x0060EA31 File Offset: 0x0060CC31
		private void OBJNKEHFHHG(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_WrinkleInfluences0", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D461 RID: 54369 RVA: 0x0060EA53 File Offset: 0x0060CC53
		private void BFPHJEMHFDL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_FullResolutionFiltering", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x0060EA75 File Offset: 0x0060CC75
		private void CGNMIPHMCDJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("titul_change", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x0060EA97 File Offset: 0x0060CC97
		private void GHMLHNEJDKD(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("FactoryTempTexture", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D464 RID: 54372 RVA: 0x0060EAB9 File Offset: 0x0060CCB9
		private void BBCAOBNGEGL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("WateringCanWatering", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x0060EADB File Offset: 0x0060CCDB
		private void JOAIOKECJBA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x0060EAFD File Offset: 0x0060CCFD
		private void OnTriggerStay(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerStay", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x0060EB1F File Offset: 0x0060CD1F
		private void DIDFACDOKIP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Roar", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D468 RID: 54376 RVA: 0x0060EB41 File Offset: 0x0060CD41
		private void KDGNFCKDADK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("{not_found}", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x0060EB63 File Offset: 0x0060CD63
		private void FICLCMDIHGD(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("InteractionObject ", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D46A RID: 54378 RVA: 0x0060EB85 File Offset: 0x0060CD85
		private void BNMGJPGGIJC(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_rcIn.ogg", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D46B RID: 54379 RVA: 0x0060EBA7 File Offset: 0x0060CDA7
		private void OHPJHDICJCA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("demoLong", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D46C RID: 54380 RVA: 0x0060EBC9 File Offset: 0x0060CDC9
		private void EPNILFFNCDN(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Failed parsing organizational group.  Setting to group 0", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x0060EBEB File Offset: 0x0060CDEB
		private void DIDDFBDINCB(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("cht_ach2", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x0060EC0D File Offset: 0x0060CE0D
		private void KLABHFPNHOD(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("RenderTextureUtilityTempTexture", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x0060EC2F File Offset: 0x0060CE2F
		private void MBFNKFLLEAD(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("MotorbikeShootRight", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x0060EC51 File Offset: 0x0060CE51
		private void DOLEJGDBAJH(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("MotorbikeShootFwd", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x0060EC73 File Offset: 0x0060CE73
		private void CGGGOHIBHKN(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("русский", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x0060EC95 File Offset: 0x0060CE95
		private void MODJKNCDLDJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("/", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D473 RID: 54387 RVA: 0x0060ECB7 File Offset: 0x0060CEB7
		private void BICIPEPHLHP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_EmissionColor", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x0060ECD9 File Offset: 0x0060CED9
		private void EIFCBCCCLMI(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("CUSTOM_COLOR_OFF", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D475 RID: 54389 RVA: 0x0060ECFB File Offset: 0x0060CEFB
		private void JFIJONNMCCC(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Apply 10", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D476 RID: 54390 RVA: 0x0060ED1D File Offset: 0x0060CF1D
		private void OnTriggerEnter(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerEnter", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D477 RID: 54391 RVA: 0x0060ED3F File Offset: 0x0060CF3F
		private void OGOLFNGLBOK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_Jitter", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D478 RID: 54392 RVA: 0x0060ED61 File Offset: 0x0060CF61
		private void HHCEBOLJBPA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Seat Stand", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D479 RID: 54393 RVA: 0x0060ED83 File Offset: 0x0060CF83
		private void FDCGKGNEMFK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("auc_rescst", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D47A RID: 54394 RVA: 0x0060EDA5 File Offset: 0x0060CFA5
		private void NKFPFHFCLMD(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("PistolReady", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x0060EDC7 File Offset: 0x0060CFC7
		private void JIIDMENJPDJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Assets/Weapons/", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x0060EDE9 File Offset: 0x0060CFE9
		private void OKLKHBIJOPN(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("PistolInstant", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x0060EE0B File Offset: 0x0060D00B
		private void CCFMEJBBGOH(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_Threshhold", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x0060EE2D File Offset: 0x0060D02D
		private void IFEJFGGABEF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("droplinemsg1", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D47F RID: 54399 RVA: 0x0060EE4F File Offset: 0x0060D04F
		private void IHKKEGHNIPN(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OfficeSittingReadingLeanBack", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D480 RID: 54400 RVA: 0x0060EE71 File Offset: 0x0060D071
		private void JANIPBAEPIL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("DealerShuffle", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x0060EE93 File Offset: 0x0060D093
		private void KDGNFKNGJNO(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Hidden/Post FX/Depth Of Field", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x0060EEB5 File Offset: 0x0060D0B5
		private void KAIMCIDMEKL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("invn_win1", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D483 RID: 54403 RVA: 0x0060EED7 File Offset: 0x0060D0D7
		private void OFAEDLGNHKH(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_WaterLevel", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x0060EEF9 File Offset: 0x0060D0F9
		private void EANKCGAFOGA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("CATRigR", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x0060EF1B File Offset: 0x0060D11B
		private void FKBDJMCFCHL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("rollSoundIndex", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x0060EF3D File Offset: 0x0060D13D
		private void NNHLBGHIIJI(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("SwimDogPaddle", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D487 RID: 54407 RVA: 0x0060EF5F File Offset: 0x0060D15F
		private void BGJNLAPBFFF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("ObscuredBool:", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x0060EF81 File Offset: 0x0060D181
		private void HGAIDKCBAKE(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_info", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x0060EFA3 File Offset: 0x0060D1A3
		private void NILNDMONBLK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage(" ", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x0060EFC5 File Offset: 0x0060D1C5
		private void GDNIJFHEBLE(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Vertical", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D48B RID: 54411 RVA: 0x0060EFE7 File Offset: 0x0060D1E7
		private void OLDNLKMBAKA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("BowIdle", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D48C RID: 54412 RVA: 0x0060EADB File Offset: 0x0060CCDB
		private void MHNNAPGLHCP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x0060F009 File Offset: 0x0060D209
		private void KBHDEFHDGLJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Crouch 180", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D48E RID: 54414 RVA: 0x0060F02B File Offset: 0x0060D22B
		private void LMGHNAHOLLJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("crft_norec2", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D48F RID: 54415 RVA: 0x0060F04D File Offset: 0x0060D24D
		private void CDMBHKBIIID(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Missing shader for image effect {0}", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D490 RID: 54416 RVA: 0x0060F06F File Offset: 0x0060D26F
		private void FGPELPOKIPK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("FISHES", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D491 RID: 54417 RVA: 0x0060F091 File Offset: 0x0060D291
		private void MIDCDGCCFEL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("IdleReady", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D492 RID: 54418 RVA: 0x0060F0B3 File Offset: 0x0060D2B3
		private void CNGKCKIEFBM(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OfficeSittingReadingCoffeeSip", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x0060F0D5 File Offset: 0x0060D2D5
		private void IDPPCEJPMJM(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("act_order", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D494 RID: 54420 RVA: 0x0060F0F7 File Offset: 0x0060D2F7
		private void HKIINBPEDKH(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("knopje.wav", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D495 RID: 54421 RVA: 0x0060F119 File Offset: 0x0060D319
		private void ALDCJFAFLAL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Mouse X", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D496 RID: 54422 RVA: 0x0060F13B File Offset: 0x0060D33B
		private void OBKBOOGDBJF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Mutilate", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D497 RID: 54423 RVA: 0x0060F15D File Offset: 0x0060D35D
		private void AELBGHNFGHO(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_Intensity", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x0060F17F File Offset: 0x0060D37F
		private void HKILBAANHLO(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("autherror", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D499 RID: 54425 RVA: 0x0060F1A1 File Offset: 0x0060D3A1
		private void NBIELNANPMO(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("****softSpawn to ", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D49A RID: 54426 RVA: 0x0060F1C3 File Offset: 0x0060D3C3
		private void INIIAABDOAI(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("SoccerKeeperDiveStrafeCloseRight", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D49B RID: 54427 RVA: 0x0060F1E5 File Offset: 0x0060D3E5
		private void DHKDCBKDEDN(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("JFAKJEPJJIH", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x0060F207 File Offset: 0x0060D407
		private void LOMHCANAAIO(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("#ffffff", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D49D RID: 54429 RVA: 0x0060F229 File Offset: 0x0060D429
		private void FAKAEOJDOGL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x0060F24B File Offset: 0x0060D44B
		private void HIBCAEOONGK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("ClimbIdle", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x0060EB85 File Offset: 0x0060CD85
		private void KMGLEFKHJAP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_rcIn.ogg", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x0060F26D File Offset: 0x0060D46D
		private void CLEKFOMABKC(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("BowFire2", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x0060F28F File Offset: 0x0060D48F
		private void LBAFEPKDJEF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("#000000", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x0060F2B1 File Offset: 0x0060D4B1
		private void OLKPHEDBLPM(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Invalid source renderer type", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x0060F2D3 File Offset: 0x0060D4D3
		private void LGDLIMDGJDA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_AxialAberration", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x0060F2F5 File Offset: 0x0060D4F5
		private void GDEGHNONPNM(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_Slope", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x0060F317 File Offset: 0x0060D517
		private void KOLGOEDJIBB(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("DISTORT", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x0060F339 File Offset: 0x0060D539
		private void KOABECHGJGE(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("MotorbikeSeatStand", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x0060F35B File Offset: 0x0060D55B
		private void NOECPIBPBII(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_ReflectionTexture4", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x0060EADB File Offset: 0x0060CCDB
		private void LONAAOMCPHP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x0060F37D File Offset: 0x0060D57D
		private void PAICGKOFLNE(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("H:mm:ss", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x0060F39F File Offset: 0x0060D59F
		private void GHKFOEOAGNJ(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("btn_cancel", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x0060F229 File Offset: 0x0060D429
		private void MIJDNMGKOKP(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x0060F3C1 File Offset: 0x0060D5C1
		private void COCNMKJNDBC(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("NadeThrow", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x0060F3E3 File Offset: 0x0060D5E3
		private void AKLHBDLPNFI(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("WizardEyeBeam", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x0060F405 File Offset: 0x0060D605
		private void FHFPBGJDDKI(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("sunshine_ShadowCoordDepthRayV", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x0060F427 File Offset: 0x0060D627
		private void HDHNFHPPMLB(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("BowReady", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x0060F449 File Offset: 0x0060D649
		private void ACPIEHHAJEF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("IceHockeyIdle", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x0060F46B File Offset: 0x0060D66B
		private void LNNDNMAPAEA(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("http://af-2.ru/?q=store", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x0060F48D File Offset: 0x0060D68D
		private void HPILJDPOLFB(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("_Intensity", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x0060F4AF File Offset: 0x0060D6AF
		private void OnTriggerExit(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("OnTriggerExit", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x0060F229 File Offset: 0x0060D429
		private void LJCFMCGFLJB(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x0060F4D1 File Offset: 0x0060D6D1
		private void KIELEPFBGCF(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage(": ", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x0060EFE7 File Offset: 0x0060D1E7
		private void GLCOHIMAHPH(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("BowIdle", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x0060F4F3 File Offset: 0x0060D6F3
		private void LFCOHHFJIOL(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("System.Boolean", JNBDKOKIPEC, SendMessageOptions.RequireReceiver);
			}
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x0060F515 File Offset: 0x0060D715
		private void MAOGFOGABHK(Collider JNBDKOKIPEC)
		{
			if (this.target != null)
			{
				this.target.SendMessage("Sitting 45 Degress leg", JNBDKOKIPEC, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x04001C25 RID: 7205
		public GameObject target;
	}
}
