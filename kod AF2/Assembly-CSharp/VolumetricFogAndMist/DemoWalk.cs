using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace VolumetricFogAndMist
{
	// Token: 0x020002B6 RID: 694
	public class DemoWalk : MonoBehaviour
	{
		// Token: 0x0600A323 RID: 41763 RVA: 0x0048FC67 File Offset: 0x0048DE67
		private void EHDPACPIBNF()
		{
			GameObject.Find(" ").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0048FC80 File Offset: 0x0048DE80
		private void LHOKCJCHLOM()
		{
			GUI.Label(new Rect(1808f, 1813f, (float)(Screen.width - -27), 1076f), "OfficeSittingReadingCoffeeSip");
			GUI.Label(new Rect(1746f, 1936f, (float)(Screen.width - 124), 531f), "TextureLoaderCoroutine" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x0048FCEC File Offset: 0x0048DEEC
		private void BFOPAJGPJLK()
		{
			GUI.Label(new Rect(1718f, 562f, (float)(Screen.width - 21), 460f), "crft_konstr");
			GUI.Label(new Rect(1013f, 1684f, (float)(Screen.width - -91), 207f), "auc_toauk" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x0048FD56 File Offset: 0x0048DF56
		private void EDGALMCHPPH()
		{
			GameObject.Find("Приватный").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x0048FD6D File Offset: 0x0048DF6D
		private void OFGMIEJKMGC()
		{
			GameObject.Find("_SunPosition").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x0048FD84 File Offset: 0x0048DF84
		private void MJDKGMEPMHK()
		{
			GUI.Label(new Rect(895f, 1240f, (float)(Screen.width - 117), 744f), "name");
			GUI.Label(new Rect(632f, 443f, (float)(Screen.width - -55), 316f), "BlendCacheMaterial" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0048FDF0 File Offset: 0x0048DFF0
		private void MEFOGCFJBNE()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.Question))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)64)
				{
					if (preset <= (IBFDPDLGLBC)(-108))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)(-3))
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)48;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)95)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)111;
							return;
						}
						if (preset == (IBFDPDLGLBC)(-117))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)95;
							return;
						}
						if (preset != (IBFDPDLGLBC)(-26))
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-9);
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)85)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)(-104):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)127;
						return;
					case (IBFDPDLGLBC)(-103):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-115);
						return;
					case (IBFDPDLGLBC)(-102):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-80);
						return;
					default:
						if (preset != IBFDPDLGLBC.Mist)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-52);
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-30))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-54);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)65:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-40);
						return;
					case (IBFDPDLGLBC)66:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-19);
						return;
					case (IBFDPDLGLBC)67:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)93;
						return;
					case (IBFDPDLGLBC)68:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)27;
						return;
					default:
						if (preset != (IBFDPDLGLBC)118)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-18);
				return;
			}
			if (Input.GetKeyDown(KeyCode.Backslash))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x0048FF20 File Offset: 0x0048E120
		private void JGDDEOALNOG()
		{
			GUI.Label(new Rect(235f, 1056f, (float)(Screen.width - 23), 1000f), "Wheely");
			GUI.Label(new Rect(578f, 1784f, (float)(Screen.width - 104), 650f), "fshop_msg1" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0048FF8C File Offset: 0x0048E18C
		private void PNJNNNJEBGA()
		{
			GUI.Label(new Rect(336f, 548f, (float)(Screen.width - -119), 1602f), " < ");
			GUI.Label(new Rect(103f, 864f, (float)(Screen.width - -81), 1958f), "-?-" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0048FFF8 File Offset: 0x0048E1F8
		private void OnGUI()
		{
			GUI.Label(new Rect(10f, 10f, (float)(Screen.width - 20), 30f), "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.");
			GUI.Label(new Rect(10f, 30f, (float)(Screen.width - 20), 30f), "Current fog preset: " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x00490064 File Offset: 0x0048E264
		private void JADGLEGEDGJ()
		{
			GUI.Label(new Rect(906f, 396f, (float)(Screen.width - 25), 1264f), "Number of children does not match with the pose");
			GUI.Label(new Rect(566f, 1178f, (float)(Screen.width - 8), 1434f), "D" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x004900CE File Offset: 0x0048E2CE
		private void HDFCIACDDEK()
		{
			GameObject.Find(" Packed: ").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x004900E8 File Offset: 0x0048E2E8
		private void IGEICBNMPAD()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)(-5)))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)118)
				{
					if (preset <= (IBFDPDLGLBC)97)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)37)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)100;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)(-65))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-49);
							return;
						}
						if (preset == (IBFDPDLGLBC)64)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-122);
							return;
						}
						if (preset != (IBFDPDLGLBC)(-83))
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)97;
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)6)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)86:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-80);
						return;
					case (IBFDPDLGLBC)87:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-81);
						return;
					case (IBFDPDLGLBC)88:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
						return;
					default:
						if (preset != (IBFDPDLGLBC)37)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)7;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-47))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-1);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)(-5):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)114;
						return;
					case (IBFDPDLGLBC)(-4):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-17);
						return;
					case (IBFDPDLGLBC)(-3):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-36);
						return;
					case (IBFDPDLGLBC)(-2):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-113);
						return;
					default:
						if (preset != (IBFDPDLGLBC)16)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-111);
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-11)))
			{
				instance.enabled = instance.enabled;
			}
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x00490218 File Offset: 0x0048E418
		private void BBGAONKBIPJ()
		{
			GUI.Label(new Rect(1693f, 1270f, (float)(Screen.width - -48), 1790f), "H:mm:ss");
			GUI.Label(new Rect(547f, 1499f, (float)(Screen.width - -82), 1635f), "{0} / {1}" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x00490282 File Offset: 0x0048E482
		private void BMNJGPIPKLL()
		{
			GameObject.Find("ClimbLeft").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x00490299 File Offset: 0x0048E499
		private void LPNDCJKAKEA()
		{
			GameObject.Find("RigidPlayer").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x004902B0 File Offset: 0x0048E4B0
		private void CGBKGPPNMNM()
		{
			GUI.Label(new Rect(1906f, 1568f, (float)(Screen.width - 75), 300f), "[sysname]");
			GUI.Label(new Rect(538f, 626f, (float)(Screen.width - 115), 1064f), "_History3ChromaTex" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x0049031A File Offset: 0x0048E51A
		private void JLKBMEBFHBI()
		{
			GameObject.Find("Katana Ready High").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x00490334 File Offset: 0x0048E534
		private void Update()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.F))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= IBFDPDLGLBC.SeaClouds)
				{
					if (preset <= IBFDPDLGLBC.Mist)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != IBFDPDLGLBC.Mist)
							{
								return;
							}
							instance.EDBIMEMLHCP = IBFDPDLGLBC.WindyMist;
							return;
						}
					}
					else
					{
						if (preset == IBFDPDLGLBC.WindyMist)
						{
							instance.EDBIMEMLHCP = IBFDPDLGLBC.GroundFog;
							return;
						}
						if (preset == IBFDPDLGLBC.LowClouds)
						{
							instance.EDBIMEMLHCP = IBFDPDLGLBC.SeaClouds;
							return;
						}
						if (preset != IBFDPDLGLBC.SeaClouds)
						{
							return;
						}
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Smoke;
						return;
					}
				}
				else if (preset <= IBFDPDLGLBC.Fog)
				{
					switch (preset)
					{
					case IBFDPDLGLBC.GroundFog:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.FrostedGround;
						return;
					case IBFDPDLGLBC.FrostedGround:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.FoggyLake;
						return;
					case IBFDPDLGLBC.FoggyLake:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Fog;
						return;
					default:
						if (preset != IBFDPDLGLBC.Fog)
						{
							return;
						}
						instance.EDBIMEMLHCP = IBFDPDLGLBC.HeavyFog;
						return;
					}
				}
				else
				{
					if (preset == IBFDPDLGLBC.HeavyFog)
					{
						instance.EDBIMEMLHCP = IBFDPDLGLBC.LowClouds;
						return;
					}
					switch (preset)
					{
					case IBFDPDLGLBC.SandStorm1:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm2;
						return;
					case IBFDPDLGLBC.Smoke:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.ToxicSwamp;
						return;
					case IBFDPDLGLBC.ToxicSwamp:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm1;
						return;
					case IBFDPDLGLBC.SandStorm2:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
						return;
					default:
						if (preset != IBFDPDLGLBC.Custom)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
				return;
			}
			if (Input.GetKeyDown(KeyCode.T))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x00490464 File Offset: 0x0048E664
		private void PGIHAIPCJLL()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.U))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-17))
				{
					if (preset <= (IBFDPDLGLBC)107)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)91)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-125);
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)(-16))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-118);
							return;
						}
						if (preset == (IBFDPDLGLBC)(-8))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-45);
							return;
						}
						if (preset != (IBFDPDLGLBC)(-105))
						{
							return;
						}
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
						return;
					}
				}
				else if (preset <= IBFDPDLGLBC.FrostedGround)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)61:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-106);
						return;
					case (IBFDPDLGLBC)62:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-31);
						return;
					case (IBFDPDLGLBC)63:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
						return;
					default:
						if (preset != (IBFDPDLGLBC)(-122))
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)2;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-34))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)70;
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)(-127):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)103;
						return;
					case (IBFDPDLGLBC)(-126):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)34;
						return;
					case (IBFDPDLGLBC)(-125):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-60);
						return;
					case (IBFDPDLGLBC)(-124):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)64;
						return;
					default:
						if (preset != (IBFDPDLGLBC)68)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-45);
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-37)))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x00490594 File Offset: 0x0048E794
		private void ELFMPDIGDLJ()
		{
			GUI.Label(new Rect(1117f, 1804f, (float)(Screen.width - 117), 542f), "RollerBladeJump");
			GUI.Label(new Rect(736f, 546f, (float)(Screen.width - 59), 1338f), "MotorbikeSeatStandWheely" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x00490600 File Offset: 0x0048E800
		private void GCNGEFBKMNC()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)(-86)))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-39))
				{
					if (preset <= (IBFDPDLGLBC)(-6))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)123)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)108;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)(-102))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-45);
							return;
						}
						if (preset == (IBFDPDLGLBC)102)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)45;
							return;
						}
						if (preset != (IBFDPDLGLBC)(-80))
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)47;
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)29)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)(-119):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-103);
						return;
					case (IBFDPDLGLBC)(-118):
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Smoke;
						return;
					case (IBFDPDLGLBC)(-117):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-69);
						return;
					default:
						if (preset != (IBFDPDLGLBC)22)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)16;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-95))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-118);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)86:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)68;
						return;
					case (IBFDPDLGLBC)87:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-119);
						return;
					case (IBFDPDLGLBC)88:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)67;
						return;
					case (IBFDPDLGLBC)89:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)99;
						return;
					default:
						if (preset != (IBFDPDLGLBC)116)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-92);
				return;
			}
			if (Input.GetKeyDown((KeyCode)5))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x0049072E File Offset: 0x0048E92E
		private void BJHGPFGBFKF()
		{
			GameObject.Find("Vertical").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x00490745 File Offset: 0x0048E945
		private void LMEJKAEIDCO()
		{
			GameObject.Find("IK Effector is referencing to a bone '").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x0049075C File Offset: 0x0048E95C
		private void NCFLINGBFJG()
		{
			GUI.Label(new Rect(1889f, 643f, (float)(Screen.width - 83), 475f), ",");
			GUI.Label(new Rect(1556f, 109f, (float)(Screen.width - 120), 1014f), "ChannelCastDirected" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x004907C6 File Offset: 0x0048E9C6
		private void EFJDBBDMPMC()
		{
			GameObject.Find("white").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x004907E0 File Offset: 0x0048E9E0
		private void JLFBDOPFDDJ()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)28))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-104))
				{
					if (preset <= (IBFDPDLGLBC)17)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)84)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-35);
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)109)
						{
							instance.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm1;
							return;
						}
						if (preset == (IBFDPDLGLBC)(-49))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)4;
							return;
						}
						if (preset != IBFDPDLGLBC.Mist)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-98);
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-110))
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)91:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)69;
						return;
					case (IBFDPDLGLBC)92:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)89;
						return;
					case (IBFDPDLGLBC)93:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-113);
						return;
					default:
						if (preset != (IBFDPDLGLBC)112)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-50);
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-63))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-32);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)28:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)83;
						return;
					case (IBFDPDLGLBC)29:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-30);
						return;
					case IBFDPDLGLBC.GroundFog:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-11);
						return;
					case IBFDPDLGLBC.FrostedGround:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)54;
						return;
					default:
						if (preset != (IBFDPDLGLBC)188)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)28;
				return;
			}
			if (Input.GetKeyDown((KeyCode)69))
			{
				instance.enabled = instance.enabled;
			}
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x00490910 File Offset: 0x0048EB10
		private void JGAMNLOICJN()
		{
			GUI.Label(new Rect(1649f, 1679f, (float)(Screen.width - -92), 1403f), "inv_dur");
			GUI.Label(new Rect(491f, 42f, (float)(Screen.width - -58), 1687f), "AFCServer" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x0049097C File Offset: 0x0048EB7C
		private void IPFNFHPFAOE()
		{
			GUI.Label(new Rect(1078f, 589f, (float)(Screen.width - -48), 1829f), "MotorbikeLasso");
			GUI.Label(new Rect(708f, 680f, (float)(Screen.width - 35), 1824f), "OfficeSittingHandRestFingerTap" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x004909E8 File Offset: 0x0048EBE8
		private void JOHDLNOKCOK()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.K))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-104))
				{
					if (preset <= (IBFDPDLGLBC)6)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)(-3))
							{
								return;
							}
							instance.EDBIMEMLHCP = IBFDPDLGLBC.Smoke;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)(-128))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-71);
							return;
						}
						if (preset == (IBFDPDLGLBC)(-87))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)19;
							return;
						}
						if (preset != (IBFDPDLGLBC)89)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-4);
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)78)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)(-66):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)71;
						return;
					case (IBFDPDLGLBC)(-65):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-22);
						return;
					case (IBFDPDLGLBC)(-64):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-34);
						return;
					default:
						if (preset != (IBFDPDLGLBC)(-66))
						{
							return;
						}
						instance.EDBIMEMLHCP = IBFDPDLGLBC.FrostedGround;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)127)
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-5);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)(-103):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-72);
						return;
					case (IBFDPDLGLBC)(-102):
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Fog;
						return;
					case (IBFDPDLGLBC)(-101):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-15);
						return;
					case (IBFDPDLGLBC)(-100):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-42);
						return;
					default:
						if (preset != (IBFDPDLGLBC)106)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)55;
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-126)))
			{
				instance.enabled = instance.enabled;
			}
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x00490B18 File Offset: 0x0048ED18
		private void IOGAKGCADBL()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)18))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-73))
				{
					if (preset <= (IBFDPDLGLBC)(-33))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)(-47))
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)6;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)109)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)33;
							return;
						}
						if (preset == (IBFDPDLGLBC)71)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-113);
							return;
						}
						if (preset != (IBFDPDLGLBC)96)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-15);
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-20))
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)9:
						instance.EDBIMEMLHCP = IBFDPDLGLBC.ToxicSwamp;
						return;
					case IBFDPDLGLBC.Mist:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-69);
						return;
					case IBFDPDLGLBC.WindyMist:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)79;
						return;
					default:
						if (preset != (IBFDPDLGLBC)38)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)120;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-126))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-25);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)(-89):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-54);
						return;
					case (IBFDPDLGLBC)(-88):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-117);
						return;
					case (IBFDPDLGLBC)(-87):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)70;
						return;
					case (IBFDPDLGLBC)(-86):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)3;
						return;
					default:
						if (preset != (IBFDPDLGLBC)(-22))
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)1;
				return;
			}
			if (Input.GetKeyDown(KeyCode.X))
			{
				instance.enabled = instance.enabled;
			}
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x00490C48 File Offset: 0x0048EE48
		private void BLCDCEHNNNC()
		{
			GUI.Label(new Rect(1636f, 612f, (float)(Screen.width - 63), 1839f), "cntx_close");
			GUI.Label(new Rect(600f, 693f, (float)(Screen.width - -86), 442f), " iterations for read and write" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x00490CB2 File Offset: 0x0048EEB2
		private void CAJLCEPLKJG()
		{
			GameObject.Find("[fish]").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x00490CC9 File Offset: 0x0048EEC9
		private void MCHAAIIHOKD()
		{
			GameObject.Find("_TrStartYou.ogg").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x00490CE0 File Offset: 0x0048EEE0
		private void BOAJJAKEMLH()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)(-75)))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)5)
				{
					if (preset <= (IBFDPDLGLBC)39)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)62)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)27;
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)58)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-25);
							return;
						}
						if (preset == (IBFDPDLGLBC)(-94))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)25;
							return;
						}
						if (preset != (IBFDPDLGLBC)89)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)13;
						return;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-58))
				{
					switch (preset)
					{
					case IBFDPDLGLBC.Mist:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-79);
						return;
					case IBFDPDLGLBC.WindyMist:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-86);
						return;
					case (IBFDPDLGLBC)12:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)114;
						return;
					default:
						if (preset != (IBFDPDLGLBC)117)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-94);
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)(-124))
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-44);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)75:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-121);
						return;
					case (IBFDPDLGLBC)76:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-118);
						return;
					case (IBFDPDLGLBC)77:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-32);
						return;
					case (IBFDPDLGLBC)78:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-35);
						return;
					default:
						if (preset != (IBFDPDLGLBC)86)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)66;
				return;
			}
			if (Input.GetKeyDown(KeyCode.Delete))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x00490E0E File Offset: 0x0048F00E
		private void Start()
		{
			GameObject.Find("Elephant").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x00490E25 File Offset: 0x0048F025
		private void CPNOBMNKPNC()
		{
			GameObject.Find("Podsek action 3").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x00490E3C File Offset: 0x0048F03C
		private void EHFPLKEINFO()
		{
			GameObject.Find("_PixelsPerMeterAtOneMeter").GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.Off;
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x00490E54 File Offset: 0x0048F054
		private void PMKOAHMNBBG()
		{
			VolumetricFog instance = VolumetricFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)31))
			{
				IBFDPDLGLBC preset = instance.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)7)
				{
					if (preset <= (IBFDPDLGLBC)(-17))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset != (IBFDPDLGLBC)9)
							{
								return;
							}
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
							return;
						}
					}
					else
					{
						if (preset == (IBFDPDLGLBC)73)
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)8;
							return;
						}
						if (preset == (IBFDPDLGLBC)(-49))
						{
							instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-93);
							return;
						}
						if (preset != (IBFDPDLGLBC)55)
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)16;
						return;
					}
				}
				else if (preset <= IBFDPDLGLBC.WindyMist)
				{
					switch (preset)
					{
					case (IBFDPDLGLBC)29:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-7);
						return;
					case IBFDPDLGLBC.GroundFog:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-40);
						return;
					case IBFDPDLGLBC.FrostedGround:
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)12;
						return;
					default:
						if (preset != (IBFDPDLGLBC)(-104))
						{
							return;
						}
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)35;
						return;
					}
				}
				else
				{
					if (preset == (IBFDPDLGLBC)111)
					{
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)(-79);
						return;
					}
					switch (preset)
					{
					case (IBFDPDLGLBC)(-15):
						instance.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
						return;
					case (IBFDPDLGLBC)(-14):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)13;
						return;
					case (IBFDPDLGLBC)(-13):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)99;
						return;
					case (IBFDPDLGLBC)(-12):
						instance.EDBIMEMLHCP = (IBFDPDLGLBC)15;
						return;
					default:
						if (preset != (IBFDPDLGLBC)165)
						{
							return;
						}
						break;
					}
				}
				instance.EDBIMEMLHCP = (IBFDPDLGLBC)56;
				return;
			}
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				instance.enabled = !instance.enabled;
			}
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x00490F84 File Offset: 0x0048F184
		private void AHEAJPNHBBB()
		{
			GUI.Label(new Rect(1570f, 236f, (float)(Screen.width - 117), 911f), "Special Flip");
			GUI.Label(new Rect(889f, 573f, (float)(Screen.width - -52), 1378f), "Couldn't get avatar." + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x00490FF0 File Offset: 0x0048F1F0
		private void JAOIOHLFLFO()
		{
			GUI.Label(new Rect(1911f, 216f, (float)(Screen.width - -123), 336f), "loc");
			GUI.Label(new Rect(1790f, 1074f, (float)(Screen.width - 120), 1101f), "IdleDodgeLeft" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0049105C File Offset: 0x0048F25C
		private void BCJFDHBDAHD()
		{
			GUI.Label(new Rect(666f, 597f, (float)(Screen.width - 71), 1388f), "<color='");
			GUI.Label(new Rect(985f, 1707f, (float)(Screen.width - 120), 356f), "OnEvent: Unknow Event" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}
	}
}
