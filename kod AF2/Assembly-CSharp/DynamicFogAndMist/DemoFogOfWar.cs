using System;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002A9 RID: 681
	public class DemoFogOfWar : MonoBehaviour
	{
		// Token: 0x0600A001 RID: 40961 RVA: 0x0047514C File Offset: 0x0047334C
		private void EMFOECIPBIP()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-34)))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-4)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.EGLLPAIFLEA();
			}
			else if (Input.GetKeyDown((KeyCode)82))
			{
				dynamicFog.AKJNOJDAGHL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 402f, 370f);
			}
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x0047525C File Offset: 0x0047345C
		private void GCNGEFBKMNC()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown(KeyCode.Alpha8))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)69))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.GDCDAAFHBKP();
			}
			else if (Input.GetKeyDown((KeyCode)(-82)))
			{
				dynamicFog.PMHLFGJHGHA();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.LCLPAEEMICO(Camera.main.transform.position, 1144f, 1816f);
			}
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x0047536C File Offset: 0x0047356C
		private void KMLNBHIIGKH()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown(KeyCode.N))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Backspace))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-112)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.DMKKDGDHKPH();
			}
			else if (Input.GetKeyDown((KeyCode)79))
			{
				dynamicFog.GDCDAAFHBKP();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.HFNNKEMIHGA(Camera.main.transform.position, 1268f, 1377f);
			}
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x0047547C File Offset: 0x0047367C
		private void OBDAPPLCPMD()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1868f, 1759f, (float)(Screen.width - -103), 1542f), "\n", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1801f, 957f, (float)(Screen.width - -127), 1140f), "End" + DynamicFog.COIPKPKLDAH.JBEBDBPEOEI(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(650f, 190f, (float)(Screen.width - -2), 659f), "https://groups.google.com/forum/#!forum/final-ik", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x00475554 File Offset: 0x00473754
		private void NJKJJNBMKHB()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(138f, 230f, (float)(Screen.width - -41), 1852f), "MotorbikeHeadstand", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1933f, 1374f, (float)(Screen.width - 11), 1069f), "PreserveDetails" + DynamicFog.JDEFOBNPMON().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1533f, 1686f, (float)(Screen.width - -23), 158f), "FBIK chain contains no nodes.", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x0047562C File Offset: 0x0047382C
		private void NCFLINGBFJG()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(554f, 596f, (float)(Screen.width - 52), 406f), "ENABLE_EYE_ADAPTATION", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1123f, 1790f, (float)(Screen.width - 33), 120f), "post_5" + DynamicFog.DHJNHDFOODE().JBEBDBPEOEI(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(739f, 1089f, (float)(Screen.width - 0), 1334f), "OK aukKeyMEditOk", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x00475704 File Offset: 0x00473904
		private void MPPMHCICKIP()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(191f, 824f, (float)(Screen.width - 40), 1579f), "Saves protection", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1507f, 1759f, (float)(Screen.width - 126), 1738f), "Mouse ScrollWheel" + DynamicFog.COIPKPKLDAH.PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(229f, 236f, (float)(Screen.width - -97), 58f), "demoUint", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x004757DC File Offset: 0x004739DC
		private void BOAJJAKEMLH()
		{
			DynamicFog dynamicFog = DynamicFog.JDEFOBNPMON();
			if (Input.GetKeyDown(KeyCode.Alpha8))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-28)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-48)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.ResetFogOfWar();
			}
			else if (Input.GetKeyDown((KeyCode)(-31)))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.GKJNDCLNDFM(Camera.main.transform.position, 746f, 1194f);
			}
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x004758EC File Offset: 0x00473AEC
		private void PNBGJBMJLFM()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown((KeyCode)(-8)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)66))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.RightBracket))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.DMKKDGDHKPH();
			}
			else if (Input.GetKeyDown((KeyCode)(-19)))
			{
				dynamicFog.AKJNOJDAGHL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 1668f, 265f);
			}
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x004759FC File Offset: 0x00473BFC
		private void EMNMOMGOBPI()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(993f, 939f, (float)(Screen.width - -61), 579f), "", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1350f, 1010f, (float)(Screen.width - 115), 1542f), "_TrEndAll.ogg" + DynamicFog.COIPKPKLDAH.GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1907f, 628f, (float)(Screen.width - 15), 1868f), "Kernel", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x00475AD4 File Offset: 0x00473CD4
		private void KMLAENJBADF()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1266f, 395f, (float)(Screen.width - 117), 426f), "error.wav", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(237f, 1218f, (float)(Screen.width - -126), 146f), "BAG" + DynamicFog.DHJNHDFOODE().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1526f, 1412f, (float)(Screen.width - -50), 1931f), "post_14", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x00475BAC File Offset: 0x00473DAC
		private void OFPGMNGFLNH()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown((KeyCode)75))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Y))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-88)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.LCKKBNGOBOM();
			}
			else if (Input.GetKeyDown((KeyCode)65))
			{
				dynamicFog.LJIOGCPIOMH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.IHFDPBCCKOK(Camera.main.transform.position, 89f, 410f);
			}
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x00475CBC File Offset: 0x00473EBC
		private void MGOJFCOBDPI()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1877f, 1013f, (float)(Screen.width - -36), 1386f), "Flap_04.wav", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1027f, 952f, (float)(Screen.width - -46), 990f), "" + DynamicFog.NBNCIFDAOAM().PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1880f, 592f, (float)(Screen.width - -15), 1711f), "MotorbikeLookBack", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x00475D94 File Offset: 0x00473F94
		private void HMLNMHOMMNO()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-71)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-26)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)18))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.OGNIDONEDDM();
			}
			else if (Input.GetKeyDown(KeyCode.Greater))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.HFNNKEMIHGA(Camera.main.transform.position, 361f, 413f);
			}
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x00475EA4 File Offset: 0x004740A4
		private void MGMMDKNGDCA()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1922f, 1350f, (float)(Screen.width - 44), 1262f), "Q", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1469f, 1958f, (float)(Screen.width - -43), 488f), "msg_other" + DynamicFog.LLGJHCCPEOI().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1553f, 1331f, (float)(Screen.width - -71), 249f), "_camouflage", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x00475F7C File Offset: 0x0047417C
		private void HCDJABMBDFF()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown(KeyCode.Alpha5))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-53)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-94)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.EGLLPAIFLEA();
			}
			else if (Input.GetKeyDown((KeyCode)85))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.BJLJDMAFPAB(Camera.main.transform.position, 504f, 85f);
			}
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x0047608C File Offset: 0x0047428C
		private void JIKGIJEHGAP()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown((KeyCode)(-105)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-116)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)73))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.DMKKDGDHKPH();
			}
			else if (Input.GetKeyDown(KeyCode.T))
			{
				dynamicFog.LCKKBNGOBOM();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 1693f, 1615f);
			}
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x0047619C File Offset: 0x0047439C
		private void OnGUI()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(10f, 10f, (float)(Screen.width - 20), 30f), "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off, C to toggle fog cutting, R to reset fog.", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(10f, 30f, (float)(Screen.width - 20), 30f), "Current fog preset: " + DynamicFog.COIPKPKLDAH.GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(10f, 50f, (float)(Screen.width - 20), 30f), "FOG CUTTING ON", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x00476274 File Offset: 0x00474474
		private void KBEOAOKBHEK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1876f, 812f, (float)(Screen.width - -46), 402f), "donk.ogg", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1140f, 1117f, (float)(Screen.width - 40), 40f), "SteamManager.Initialized failed" + DynamicFog.LLGJHCCPEOI().IGBPIANKJCA(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1392f, 505f, (float)(Screen.width - 39), 1051f), "", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x0047634C File Offset: 0x0047454C
		private void KBAJMMCHDOC()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1339f, 1841f, (float)(Screen.width - -127), 1765f), "gameComplete", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1300f, 1254f, (float)(Screen.width - 92), 447f), "1=" + DynamicFog.NBNCIFDAOAM().JBEBDBPEOEI(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1817f, 130f, (float)(Screen.width - -77), 486f), "_DeepTex", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x00476424 File Offset: 0x00474624
		private void HCCGBDPCEKO()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(693f, 811f, (float)(Screen.width - 124), 200f), "demoQuaternion", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(471f, 1515f, (float)(Screen.width - 79), 9f), "MotorbikeLasso" + DynamicFog.JDEFOBNPMON().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(592f, 824f, (float)(Screen.width - -50), 145f), "u_email", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x004764FC File Offset: 0x004746FC
		private void LGKEFLBKIGN()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1971f, 912f, (float)(Screen.width - 1), 1016f), "Assets/Heads/head_", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(641f, 985f, (float)(Screen.width - -27), 1608f), "DISTORT" + DynamicFog.NBNCIFDAOAM().IGBPIANKJCA(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1043f, 1406f, (float)(Screen.width - -10), 348f), "left", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x004765D4 File Offset: 0x004747D4
		private void PGIHAIPCJLL()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown((KeyCode)(-93)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-104)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.LeftBracket))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.LCKKBNGOBOM();
			}
			else if (Input.GetKeyDown(KeyCode.T))
			{
				dynamicFog.ResetFogOfWar();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 797f, 1238f);
			}
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x004766E4 File Offset: 0x004748E4
		private void NCLNNJIGFOO()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(867f, 56f, (float)(Screen.width - -32), 62f), "{0:F2}, {1:F2}", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1463f, 1025f, (float)(Screen.width - -120), 854f), "wpn_add/base" + DynamicFog.NBNCIFDAOAM().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1545f, 986f, (float)(Screen.width - 76), 431f), "WalkInjured", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x004767BC File Offset: 0x004749BC
		private void MEFOGCFJBNE()
		{
			DynamicFog instance = DynamicFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)(-26)))
			{
				switch (instance.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					instance.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.WindyMist:
					instance.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					instance.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.Fog:
					instance.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.HeavyFog:
					instance.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.SandStorm:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-22)))
			{
				instance.enabled = instance.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.Plus))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				instance.fogOfWarEnabled = this.ILLCKMNLIFH;
				instance.GAECANOKHNL();
			}
			else if (Input.GetKeyDown((KeyCode)(-2)))
			{
				instance.DMKKDGDHKPH();
			}
			if (this.ILLCKMNLIFH)
			{
				instance.HFNNKEMIHGA(Camera.main.transform.position, 167f, 324f);
			}
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x004768CC File Offset: 0x00474ACC
		private void Update()
		{
			DynamicFog instance = DynamicFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.F))
			{
				switch (instance.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					instance.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					instance.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					instance.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.Fog:
					instance.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					instance.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.SandStorm:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.T))
			{
				instance.enabled = !instance.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.C))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				instance.fogOfWarEnabled = this.ILLCKMNLIFH;
				instance.ResetFogOfWar();
			}
			else if (Input.GetKeyDown(KeyCode.R))
			{
				instance.ResetFogOfWar();
			}
			if (this.ILLCKMNLIFH)
			{
				instance.SetFogOfWarAlpha(Camera.main.transform.position, 4f, 0f);
			}
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x004769DC File Offset: 0x00474BDC
		private void PFNOEACNHON()
		{
			DynamicFog dynamicFog = DynamicFog.JDEFOBNPMON();
			if (Input.GetKeyDown((KeyCode)21))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)79))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.ResetFogOfWar();
			}
			else if (Input.GetKeyDown((KeyCode)26))
			{
				dynamicFog.AKJNOJDAGHL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.SetFogOfWarAlpha(Camera.main.transform.position, 1666f, 1213f);
			}
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x00476AEC File Offset: 0x00474CEC
		private void MPLCAGFGEBO()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown(KeyCode.Plus))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-116)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-3)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.PMHLFGJHGHA();
			}
			else if (Input.GetKeyDown((KeyCode)(-22)))
			{
				dynamicFog.LCKKBNGOBOM();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 1354f, 601f);
			}
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x00476BFC File Offset: 0x00474DFC
		private void LACNPNKHCAA()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-109)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)74))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha7))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.LCKKBNGOBOM();
			}
			else if (Input.GetKeyDown((KeyCode)(-33)))
			{
				dynamicFog.DMKKDGDHKPH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.BJLJDMAFPAB(Camera.main.transform.position, 229f, 735f);
			}
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x00476D0C File Offset: 0x00474F0C
		private void NOBANMDHKNK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1673f, 1250f, (float)(Screen.width - 42), 1967f), "WATERMODE", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1164f, 870f, (float)(Screen.width - 32), 315f), "_FogVoidPosition" + DynamicFog.COIPKPKLDAH.NCIDCMLDAFE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1012f, 1566f, (float)(Screen.width - 57), 1734f), "</color>", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x00476DE4 File Offset: 0x00474FE4
		private void JFGGBEGNAFP()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-82)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-33)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)81))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.LCKKBNGOBOM();
			}
			else if (Input.GetKeyDown(KeyCode.BackQuote))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.IHFDPBCCKOK(Camera.main.transform.position, 1118f, 924f);
			}
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x00476EF4 File Offset: 0x004750F4
		private void JADGLEGEDGJ()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(198f, 1329f, (float)(Screen.width - 14), 96f), "\n", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(688f, 548f, (float)(Screen.width - -8), 1261f), "Loading Asset Bundle " + DynamicFog.COIPKPKLDAH.GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(734f, 922f, (float)(Screen.width - 105), 906f), "money", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x00476FCC File Offset: 0x004751CC
		private void PBHKFPELDGF()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(483f, 704f, (float)(Screen.width - 122), 554f), "[maxwgt]", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1136f, 1583f, (float)(Screen.width - -79), 282f), "__c" + DynamicFog.NBNCIFDAOAM().PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(995f, 607f, (float)(Screen.width - -67), 1335f), "Mouse Y", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x004770A4 File Offset: 0x004752A4
		private void KAGBHGJKCHK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1137f, 113f, (float)(Screen.width - 5), 1899f), " x", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(2f, 1594f, (float)(Screen.width - -119), 1208f), "_FogOfWarCenterAdjusted" + DynamicFog.NBNCIFDAOAM().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(281f, 581f, (float)(Screen.width - -100), 1768f), "_Offsets", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x0047717C File Offset: 0x0047537C
		private void AAEFACEGJMB()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown(KeyCode.Greater))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-127)))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-126)))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.AKJNOJDAGHL();
			}
			else if (Input.GetKeyDown((KeyCode)(-37)))
			{
				dynamicFog.AKJNOJDAGHL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.LCLPAEEMICO(Camera.main.transform.position, 1903f, 477f);
			}
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x0047728C File Offset: 0x0047548C
		private void CDLDCKAHLHC()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-29)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Ampersand))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.BackQuote))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.GAECANOKHNL();
			}
			else if (Input.GetKeyDown((KeyCode)16))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.SetFogOfWarAlpha(Camera.main.transform.position, 1500f, 1984f);
			}
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x0047739C File Offset: 0x0047559C
		private void LMMDHJJJNJO()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-100)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)28))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-31)))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.PMHLFGJHGHA();
			}
			else if (Input.GetKeyDown((KeyCode)(-50)))
			{
				dynamicFog.LJIOGCPIOMH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.HFNNKEMIHGA(Camera.main.transform.position, 1841f, 0f);
			}
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x004774AC File Offset: 0x004756AC
		private void EILPBPNOMJI()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1852f, 1307f, (float)(Screen.width - -123), 1850f), "FULLNAME", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(24f, 322f, (float)(Screen.width - -29), 647f), " is not supported on this platform!" + DynamicFog.COIPKPKLDAH.JJHIINLJCHO(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(20f, 1266f, (float)(Screen.width - -32), 901f), "UnityEngine.Vector2", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x00477584 File Offset: 0x00475784
		private void HABONMJNDAL()
		{
			DynamicFog instance = DynamicFog.COIPKPKLDAH;
			if (Input.GetKeyDown(KeyCode.R))
			{
				switch (instance.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					instance.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					instance.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.GroundFog:
					instance.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					instance.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					instance.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-16)))
			{
				instance.enabled = !instance.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-39)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				instance.fogOfWarEnabled = this.ILLCKMNLIFH;
				instance.GDCDAAFHBKP();
			}
			else if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				instance.GDCDAAFHBKP();
			}
			if (this.ILLCKMNLIFH)
			{
				instance.GKJNDCLNDFM(Camera.main.transform.position, 639f, 1222f);
			}
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x00477694 File Offset: 0x00475894
		private void BBGAONKBIPJ()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1996f, 1419f, (float)(Screen.width - 125), 22f), "_Specular", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1419f, 1175f, (float)(Screen.width - 115), 1217f), "Motion Blur" + DynamicFog.NBNCIFDAOAM().JJHIINLJCHO(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(247f, 1284f, (float)(Screen.width - -119), 525f), " шт.", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x0047776C File Offset: 0x0047596C
		private void ELFMPDIGDLJ()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(85f, 1025f, (float)(Screen.width - 36), 1047f), "waitRefineOk!", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(324f, 635f, (float)(Screen.width - 45), 157f), "" + DynamicFog.NBNCIFDAOAM().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1686f, 1951f, (float)(Screen.width - -94), 394f), "S", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A02A RID: 41002 RVA: 0x00477844 File Offset: 0x00475A44
		private void DCHAPIHINBJ()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(891f, 1182f, (float)(Screen.width - -50), 1716f), "TOD_Contrast", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1755f, 990f, (float)(Screen.width - -117), 202f), "crft_cnt" + DynamicFog.COIPKPKLDAH.NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1326f, 61f, (float)(Screen.width - 7), 1292f), "IdleDrink", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x0047791C File Offset: 0x00475B1C
		private void OKICICGNAFP()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(964f, 1903f, (float)(Screen.width - 84), 1498f), "PistolInstant", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1515f, 104f, (float)(Screen.width - -56), 1306f), "IceHockeyGoalieReady" + DynamicFog.COIPKPKLDAH.GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1391f, 1448f, (float)(Screen.width - -17), 1797f), " This is not possible to be called for standalone input. Please check your platform and code where this is called", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x004779F4 File Offset: 0x00475BF4
		private void NMMGHFDLNOE()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown((KeyCode)(-60)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Equals))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-31)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.ResetFogOfWar();
			}
			else if (Input.GetKeyDown((KeyCode)(-56)))
			{
				dynamicFog.GDCDAAFHBKP();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MGEMMJOPJNN(Camera.main.transform.position, 1418f, 1319f);
			}
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x00477B04 File Offset: 0x00475D04
		private void JAOIOHLFLFO()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(524f, 590f, (float)(Screen.width - 106), 580f), "Move camera around freely with WASD and mouse.", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1688f, 307f, (float)(Screen.width - 37), 992f), "_parent" + DynamicFog.NBNCIFDAOAM().JBEBDBPEOEI(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(128f, 1446f, (float)(Screen.width - 121), 178f), "3", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x00477BDC File Offset: 0x00475DDC
		private void ELLJEHHACHL()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(842f, 59f, (float)(Screen.width - -40), 1736f), "post_9", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(152f, 219f, (float)(Screen.width - -25), 41f), "IK Effector contains a null reference." + DynamicFog.DHJNHDFOODE().IGBPIANKJCA(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(700f, 1335f, (float)(Screen.width - 80), 1419f), "nowpn", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x00477CB4 File Offset: 0x00475EB4
		private void KIEFPGLDOCD()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(194f, 1566f, (float)(Screen.width - 63), 389f), "", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1917f, 534f, (float)(Screen.width - -33), 192f), "invn_rec7" + DynamicFog.DHJNHDFOODE().IGBPIANKJCA(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(667f, 1526f, (float)(Screen.width - 64), 1400f), "fishDown SHANCE", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x00477D8C File Offset: 0x00475F8C
		private void JEJGFDBHABC()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1119f, 997f, (float)(Screen.width - 57), 533f), "GiantEat", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1959f, 1242f, (float)(Screen.width - 108), 1220f), "_RefractTex" + DynamicFog.COIPKPKLDAH.CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1209f, 1202f, (float)(Screen.width - 126), 1933f), "string: ", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x00477E64 File Offset: 0x00476064
		private void PFPPDNHLCCA()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown((KeyCode)22))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-53)))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-36)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.DMKKDGDHKPH();
			}
			else if (Input.GetKeyDown(KeyCode.Space))
			{
				dynamicFog.DMKKDGDHKPH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.IHFDPBCCKOK(Camera.main.transform.position, 268f, 160f);
			}
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x00477F74 File Offset: 0x00476174
		private void OFKLNHNPADP()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(750f, 1626f, (float)(Screen.width - -93), 1712f), "#c0c0c0", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(78f, 499f, (float)(Screen.width - -55), 347f), "OfficeSittingEyesRub" + DynamicFog.NBNCIFDAOAM().PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1394f, 368f, (float)(Screen.width - -2), 239f), "Channel Cast Directed", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x0047804C File Offset: 0x0047624C
		private void LPNFGGAKGID()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(337f, 989f, (float)(Screen.width - 123), 1410f), "KarateGreet", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(395f, 1608f, (float)(Screen.width - -14), 311f), "FBBIK is null. Will not update the InteractionSystem" + DynamicFog.COIPKPKLDAH.CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1942f, 1904f, (float)(Screen.width - -116), 403f), "MotorbikeLassoLeft", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x00478124 File Offset: 0x00476324
		private void FOHLAIIMNFB()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown((KeyCode)(-34)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)81))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-88)))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.HJJAEAPONKL();
			}
			else if (Input.GetKeyDown(KeyCode.Question))
			{
				dynamicFog.DMKKDGDHKPH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MMFHLHJNENA(Camera.main.transform.position, 1265f, 1815f);
			}
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00478234 File Offset: 0x00476434
		private void LIOCDEICIFD()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown((KeyCode)22))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.I))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown(KeyCode.R))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.GAECANOKHNL();
			}
			else if (Input.GetKeyDown((KeyCode)(-29)))
			{
				dynamicFog.HJJAEAPONKL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.GKJNDCLNDFM(Camera.main.transform.position, 1076f, 296f);
			}
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00478344 File Offset: 0x00476544
		private void JGDDEOALNOG()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1023f, 816f, (float)(Screen.width - -30), 330f), "IdleReady", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1741f, 1898f, (float)(Screen.width - -39), 317f), "wpn_rec4" + DynamicFog.LLGJHCCPEOI().NCIDCMLDAFE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(443f, 1385f, (float)(Screen.width - 53), 1774f), "_ColorBuffer", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x0047841C File Offset: 0x0047661C
		private void OHKHOAKCENL()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-120)))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)4))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.IACBIHKOKIL();
			}
			else if (Input.GetKeyDown(KeyCode.Escape))
			{
				dynamicFog.HJJAEAPONKL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.SetFogOfWarAlpha(Camera.main.transform.position, 1062f, 1947f);
			}
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x0047852C File Offset: 0x0047672C
		private void EDANNBFJHIK()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown(KeyCode.S))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.B))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-3)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.IACBIHKOKIL();
			}
			else if (Input.GetKeyDown((KeyCode)(-68)))
			{
				dynamicFog.GDCDAAFHBKP();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.LCLPAEEMICO(Camera.main.transform.position, 1351f, 189f);
			}
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x0047863C File Offset: 0x0047683C
		private void GHOJCADBKEK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1807f, 628f, (float)(Screen.width - 101), 1410f), "OfficeSittingHandRestFingerTap", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(601f, 1595f, (float)(Screen.width - -82), 1566f), "_Specular" + DynamicFog.NBNCIFDAOAM().GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1127f, 56f, (float)(Screen.width - -39), 1619f), "Приватный", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x00478714 File Offset: 0x00476914
		private void EKCKBDKEAKO()
		{
			DynamicFog instance = DynamicFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)26))
			{
				switch (instance.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					instance.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					instance.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.Fog:
					instance.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.HeavyFog:
					instance.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-89)))
			{
				instance.enabled = instance.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)83))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				instance.fogOfWarEnabled = this.ILLCKMNLIFH;
				instance.IACBIHKOKIL();
			}
			else if (Input.GetKeyDown(KeyCode.Z))
			{
				instance.PMHLFGJHGHA();
			}
			if (this.ILLCKMNLIFH)
			{
				instance.HFNNKEMIHGA(Camera.main.transform.position, 103f, 763f);
			}
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x00478824 File Offset: 0x00476A24
		private void PNAEIDCONFP()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1634f, 1711f, (float)(Screen.width - 51), 1143f), "RollerBladeJump", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1905f, 44f, (float)(Screen.width - -63), 689f), "DeadmanFloat" + DynamicFog.COIPKPKLDAH.PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1161f, 81f, (float)(Screen.width - 76), 1827f), "_info", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x004788FC File Offset: 0x00476AFC
		private void ENCHIIJEJDL()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(422f, 1646f, (float)(Screen.width - 3), 452f), "RollerBladeJump", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1095f, 596f, (float)(Screen.width - -97), 986f), "[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method." + DynamicFog.NBNCIFDAOAM().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(667f, 737f, (float)(Screen.width - -15), 1465f), "MotorbikeTurnRight", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x004789D4 File Offset: 0x00476BD4
		private void HONIFOPBBKC()
		{
			DynamicFog instance = DynamicFog.COIPKPKLDAH;
			if (Input.GetKeyDown((KeyCode)(-67)))
			{
				switch (instance.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					instance.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.WindyMist:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					instance.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.Fog:
					instance.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.HeavyFog:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.SandStorm:
					instance.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)76))
			{
				instance.enabled = !instance.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)2))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				instance.fogOfWarEnabled = this.ILLCKMNLIFH;
				instance.IACBIHKOKIL();
			}
			else if (Input.GetKeyDown(KeyCode.J))
			{
				instance.HJJAEAPONKL();
			}
			if (this.ILLCKMNLIFH)
			{
				instance.MMFHLHJNENA(Camera.main.transform.position, 968f, 0f);
			}
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x00478AE4 File Offset: 0x00476CE4
		private void KBMKHLDOIKP()
		{
			DynamicFog dynamicFog = DynamicFog.NBNCIFDAOAM();
			if (Input.GetKeyDown((KeyCode)67))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-99)))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-36)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.HJJAEAPONKL();
			}
			else if (Input.GetKeyDown(KeyCode.O))
			{
				dynamicFog.LCKKBNGOBOM();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.IHFDPBCCKOK(Camera.main.transform.position, 397f, 1203f);
			}
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x00478BF4 File Offset: 0x00476DF4
		private void MJDKGMEPMHK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(757f, 1174f, (float)(Screen.width - -14), 1439f), "_MainTex", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(640f, 1524f, (float)(Screen.width - 33), 1321f), "NadeThrow" + DynamicFog.DHJNHDFOODE().NMKDCNPNHJN(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1883f, 1479f, (float)(Screen.width - -107), 622f), "Flap_04.wav", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x00478CCC File Offset: 0x00476ECC
		private void CKFIKGNJCKB()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(793f, 1210f, (float)(Screen.width - 92), 1921f), "MotorbikeWheelyNoHands", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1585f, 1047f, (float)(Screen.width - -115), 640f), "firsStartInfoPanel" + DynamicFog.DHJNHDFOODE().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(104f, 1578f, (float)(Screen.width - 4), 1093f), "_NeutralTonemapperParams1", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x00478DA4 File Offset: 0x00476FA4
		private void AIAMIFEPALP()
		{
			DynamicFog dynamicFog = DynamicFog.JDEFOBNPMON();
			if (Input.GetKeyDown(KeyCode.Hash))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Custom;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-94)))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-101)))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.PMHLFGJHGHA();
			}
			else if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				dynamicFog.LJIOGCPIOMH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.LCLPAEEMICO(Camera.main.transform.position, 1313f, 1408f);
			}
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x00478EB4 File Offset: 0x004770B4
		private void BCJFDHBDAHD()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1373f, 1979f, (float)(Screen.width - 62), 26f), "time_format2", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(168f, 1174f, (float)(Screen.width - 18), 901f), "#FF4040" + DynamicFog.DHJNHDFOODE().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1796f, 1963f, (float)(Screen.width - -36), 1943f), "", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x00478F8C File Offset: 0x0047718C
		private void LBGKAMLLACN()
		{
			DynamicFog dynamicFog = DynamicFog.DHJNHDFOODE();
			if (Input.GetKeyDown((KeyCode)(-99)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.WindyMist;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.SandStorm;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown((KeyCode)11))
			{
				dynamicFog.enabled = dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)11))
			{
				this.ILLCKMNLIFH = this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.IACBIHKOKIL();
			}
			else if (Input.GetKeyDown(KeyCode.Y))
			{
				dynamicFog.EGLLPAIFLEA();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.IHFDPBCCKOK(Camera.main.transform.position, 222f, 1476f);
			}
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x0047909C File Offset: 0x0047729C
		private void LHOKCJCHLOM()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1525f, 1132f, (float)(Screen.width - 120), 970f), "_ReflectionTex", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(97f, 1287f, (float)(Screen.width - -43), 818f), "" + DynamicFog.JDEFOBNPMON().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(75f, 576f, (float)(Screen.width - 51), 6f), "\\n", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x00479184 File Offset: 0x00477384
		private void EILPHLEBEJP()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1332f, 1084f, (float)(Screen.width - -31), 486f), "inv_useeff", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(829f, 331f, (float)(Screen.width - -20), 319f), "citates/citate" + DynamicFog.NBNCIFDAOAM().PGONCNJCHHB(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(553f, 1440f, (float)(Screen.width - -29), 1919f), "11", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x0047925C File Offset: 0x0047745C
		private void LKAMGOGAMCH()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(7f, 1337f, (float)(Screen.width - 19), 1762f), "index", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1466f, 1557f, (float)(Screen.width - 96), 190f), "IdleReadyLook" + DynamicFog.NBNCIFDAOAM().NCIDCMLDAFE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(457f, 1303f, (float)(Screen.width - 72), 947f), "MotorbikeWheely", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x00479334 File Offset: 0x00477534
		private void HNMODJBBKBI()
		{
			DynamicFog dynamicFog = DynamicFog.LLGJHCCPEOI();
			if (Input.GetKeyDown((KeyCode)6))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.GroundFog;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Mist;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Return))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)(-52)))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.OGNIDONEDDM();
			}
			else if (Input.GetKeyDown((KeyCode)(-115)))
			{
				dynamicFog.DMKKDGDHKPH();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.BJLJDMAFPAB(Camera.main.transform.position, 1612f, 1969f);
			}
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x00479444 File Offset: 0x00477644
		private void JLFBDOPFDDJ()
		{
			DynamicFog dynamicFog = DynamicFog.JDEFOBNPMON();
			if (Input.GetKeyDown((KeyCode)(-115)))
			{
				switch (dynamicFog.preset)
				{
				case DGNMDDLNIKA.Clear:
				case DGNMDDLNIKA.Custom:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.Mist:
					dynamicFog.preset = DGNMDDLNIKA.HeavyFog;
					break;
				case DGNMDDLNIKA.WindyMist:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.GroundFog:
					dynamicFog.preset = DGNMDDLNIKA.Fog;
					break;
				case DGNMDDLNIKA.Fog:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				case DGNMDDLNIKA.HeavyFog:
					dynamicFog.preset = (DGNMDDLNIKA)8;
					break;
				case DGNMDDLNIKA.SandStorm:
					dynamicFog.preset = DGNMDDLNIKA.Clear;
					break;
				}
			}
			else if (Input.GetKeyDown(KeyCode.Semicolon))
			{
				dynamicFog.enabled = !dynamicFog.enabled;
			}
			else if (Input.GetKeyDown((KeyCode)72))
			{
				this.ILLCKMNLIFH = !this.ILLCKMNLIFH;
				dynamicFog.fogOfWarEnabled = this.ILLCKMNLIFH;
				dynamicFog.HJJAEAPONKL();
			}
			else if (Input.GetKeyDown(KeyCode.Ampersand))
			{
				dynamicFog.IACBIHKOKIL();
			}
			if (this.ILLCKMNLIFH)
			{
				dynamicFog.MMFHLHJNENA(Camera.main.transform.position, 596f, 1809f);
			}
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x00479554 File Offset: 0x00477754
		private void JLMDLHCNGBE()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(530f, 457f, (float)(Screen.width - -79), 577f), "---", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1661f, 447f, (float)(Screen.width - 55), 586f), "Soccer Sprint" + DynamicFog.DHJNHDFOODE().GetCurrentPresetName(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(1190f, 205f, (float)(Screen.width - 62), 1356f), "", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x0047962C File Offset: 0x0047782C
		private void BGJFLKLBOPK()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(642f, 1578f, (float)(Screen.width - -39), 1572f), "HookPoint", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(342f, 1388f, (float)(Screen.width - -126), 451f), "_TintColor" + DynamicFog.NBNCIFDAOAM().CCKHEGHPDHE(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(39f, 1178f, (float)(Screen.width - -121), 816f), "_PrefilterOffs", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x00479704 File Offset: 0x00477904
		private void LFCIINOHNLB()
		{
			if (DemoFogOfWar.BEJMAMEPLHN == null)
			{
				DemoFogOfWar.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				DemoFogOfWar.BEJMAMEPLHN.normal.textColor = Color.black;
			}
			GUI.Label(new Rect(1215f, 1069f, (float)(Screen.width - 126), 1112f), "Keeper Jump", DemoFogOfWar.BEJMAMEPLHN);
			GUI.Label(new Rect(1983f, 279f, (float)(Screen.width - -92), 1372f), "26" + DynamicFog.JDEFOBNPMON().IGBPIANKJCA(), DemoFogOfWar.BEJMAMEPLHN);
			if (this.ILLCKMNLIFH)
			{
				GUI.Label(new Rect(433f, 515f, (float)(Screen.width - -108), 894f), "ragulaEventProc", DemoFogOfWar.BEJMAMEPLHN);
			}
		}

		// Token: 0x0400149F RID: 5279
		private bool ILLCKMNLIFH = true;

		// Token: 0x040014A0 RID: 5280
		private static GUIStyle BEJMAMEPLHN;
	}
}
