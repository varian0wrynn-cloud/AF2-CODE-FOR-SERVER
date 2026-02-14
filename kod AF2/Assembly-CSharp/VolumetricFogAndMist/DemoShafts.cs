using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002B9 RID: 697
	public class DemoShafts : MonoBehaviour
	{
		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0049B3FC File Offset: 0x004995FC
		private void JEJGFDBHABC()
		{
			GUI.Label(new Rect(282f, 403f, (float)(Screen.width - -119), 110f), "IdleButtonPress");
			GUI.Label(new Rect(199f, 1021f, (float)(Screen.width - -79), 1136f), "offsets" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x0049B468 File Offset: 0x00499668
		private void GCNGEFBKMNC()
		{
			if (Input.GetKeyDown(KeyCode.Colon))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)100)
				{
					if (preset <= (IBFDPDLGLBC)(-99))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)(-83))
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)23;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-85);
						}
					}
					else if (preset != (IBFDPDLGLBC)(-16))
					{
						if (preset == (IBFDPDLGLBC)45)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-65);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)59;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-116))
				{
					if (preset != (IBFDPDLGLBC)46)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-24):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-77);
							break;
						case (IBFDPDLGLBC)(-23):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)7;
							break;
						case (IBFDPDLGLBC)(-22):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)71;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
					}
				}
				else if (preset != (IBFDPDLGLBC)(-124))
				{
					if (preset != (IBFDPDLGLBC)(-111))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)35:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-34);
							break;
						case (IBFDPDLGLBC)36:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-88);
							break;
						case (IBFDPDLGLBC)37:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm1;
							break;
						case (IBFDPDLGLBC)38:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)17;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-115);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)64;
				}
			}
			else if (Input.GetKeyDown((KeyCode)83))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x0049B639 File Offset: 0x00499839
		private void LPNDCJKAKEA()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x0049B639 File Offset: 0x00499839
		private void JLKBMEBFHBI()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x0049B648 File Offset: 0x00499848
		private void JADGLEGEDGJ()
		{
			GUI.Label(new Rect(962f, 556f, (float)(Screen.width - -75), 1268f), ", ");
			GUI.Label(new Rect(923f, 177f, (float)(Screen.width - 64), 730f), "_SSRMultiplier" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x0049B639 File Offset: 0x00499839
		private void FFIGGPHAIBP()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x0049B639 File Offset: 0x00499839
		private void FEBIICIMLHA()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x0049B6B4 File Offset: 0x004998B4
		private void MPPMHCICKIP()
		{
			GUI.Label(new Rect(453f, 520f, (float)(Screen.width - -44), 1328f), "_ScreenSize");
			GUI.Label(new Rect(1565f, 858f, (float)(Screen.width - 38), 108f), "lineTENSIONKG=" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x0049B720 File Offset: 0x00499920
		private void LGKEFLBKIGN()
		{
			GUI.Label(new Rect(173f, 1989f, (float)(Screen.width - -40), 1084f), "error");
			GUI.Label(new Rect(1597f, 1578f, (float)(Screen.width - -127), 434f), "Hidden/Amplify Color/ProcessOnly" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x0049B78C File Offset: 0x0049998C
		private void IKHCCAANGOP()
		{
			if (Input.GetKeyDown((KeyCode)(-67)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)95)
				{
					if (preset <= (IBFDPDLGLBC)(-107))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)(-25))
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-74);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-84);
						}
					}
					else if (preset != (IBFDPDLGLBC)123)
					{
						if (preset == (IBFDPDLGLBC)39)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-27);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-55);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-53))
				{
					if (preset != (IBFDPDLGLBC)(-66))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)85:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-56);
							break;
						case (IBFDPDLGLBC)86:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-124);
							break;
						case (IBFDPDLGLBC)87:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)61;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)109;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-67))
				{
					if (preset != (IBFDPDLGLBC)86)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)100:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)98;
							break;
						case (IBFDPDLGLBC)101:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)97;
							break;
						case (IBFDPDLGLBC)102:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Smoke;
							break;
						case (IBFDPDLGLBC)103:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-1);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-67);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-29);
				}
			}
			else if (Input.GetKeyDown(KeyCode.N))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x0049B960 File Offset: 0x00499B60
		private void PJHEGHHOJHJ()
		{
			if (Input.GetKeyDown((KeyCode)(-75)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-19))
				{
					if (preset <= (IBFDPDLGLBC)(-119))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)48)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)5;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-57);
						}
					}
					else if (preset != (IBFDPDLGLBC)(-14))
					{
						if (preset == IBFDPDLGLBC.FoggyLake)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-48);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)24;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-92))
				{
					if (preset != (IBFDPDLGLBC)(-38))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)108:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-46);
							break;
						case (IBFDPDLGLBC)109:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)61;
							break;
						case (IBFDPDLGLBC)110:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)54;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-77);
					}
				}
				else if (preset != (IBFDPDLGLBC)101)
				{
					if (preset != (IBFDPDLGLBC)(-88))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-120):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)22;
							break;
						case (IBFDPDLGLBC)(-119):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-3);
							break;
						case (IBFDPDLGLBC)(-118):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)65;
							break;
						case (IBFDPDLGLBC)(-117):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-2);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-89);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-91);
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-83)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x0049BB34 File Offset: 0x00499D34
		private void EMHGNEMIGII()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-6))
				{
					if (preset <= (IBFDPDLGLBC)87)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)114)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)59;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-103);
						}
					}
					else if (preset != (IBFDPDLGLBC)75)
					{
						if (preset == (IBFDPDLGLBC)(-19))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)56;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)15;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-68))
				{
					if (preset != (IBFDPDLGLBC)71)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)101:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)88;
							break;
						case (IBFDPDLGLBC)102:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-23);
							break;
						case (IBFDPDLGLBC)103:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-34);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)43;
					}
				}
				else if (preset != (IBFDPDLGLBC)106)
				{
					if (preset != (IBFDPDLGLBC)(-101))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)14:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-87);
							break;
						case (IBFDPDLGLBC)15:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-121);
							break;
						case (IBFDPDLGLBC)16:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
							break;
						case (IBFDPDLGLBC)17:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)15;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)106;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-67);
				}
			}
			else if (Input.GetKeyDown((KeyCode)69))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x0049BD08 File Offset: 0x00499F08
		private void OnGUI()
		{
			GUI.Label(new Rect(10f, 10f, (float)(Screen.width - 20), 30f), "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.");
			GUI.Label(new Rect(10f, 30f, (float)(Screen.width - 20), 30f), "Current fog preset: " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x0049B639 File Offset: 0x00499839
		private void AIFIEAGFIMM()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x0049BD74 File Offset: 0x00499F74
		private void NOLGBPGPBKL()
		{
			GUI.Label(new Rect(1754f, 509f, (float)(Screen.width - 65), 1498f), "cellid");
			GUI.Label(new Rect(1200f, 1706f, (float)(Screen.width - -102), 1518f), "and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x0049BDE0 File Offset: 0x00499FE0
		private void OHKHOAKCENL()
		{
			if (Input.GetKeyDown((KeyCode)(-19)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-17))
				{
					if (preset <= (IBFDPDLGLBC)(-53))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)87)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)29;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)92;
						}
					}
					else if (preset != (IBFDPDLGLBC)(-97))
					{
						if (preset == (IBFDPDLGLBC)24)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-14);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-62);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-125))
				{
					if (preset != (IBFDPDLGLBC)102)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-82):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-127);
							break;
						case (IBFDPDLGLBC)(-81):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)112;
							break;
						case (IBFDPDLGLBC)(-80):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-57);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)64;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-39))
				{
					if (preset != (IBFDPDLGLBC)(-73))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-11):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)121;
							break;
						case (IBFDPDLGLBC)(-10):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-34);
							break;
						case (IBFDPDLGLBC)(-9):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)44;
							break;
						case (IBFDPDLGLBC)(-8):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)115;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-102);
				}
			}
			else if (Input.GetKeyDown(KeyCode.RightParen))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x0049B639 File Offset: 0x00499839
		private void DGDGMFDPEHO()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x0049B639 File Offset: 0x00499839
		private void HHGGCBLOJGB()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x0049BFB4 File Offset: 0x0049A1B4
		private void GGOKNBBPLHB()
		{
			GUI.Label(new Rect(500f, 1839f, (float)(Screen.width - 115), 739f), "UserIn");
			GUI.Label(new Rect(1659f, 1253f, (float)(Screen.width - -91), 820f), "Sexy Dance" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x0049C020 File Offset: 0x0049A220
		private void PNBGJBMJLFM()
		{
			if (Input.GetKeyDown((KeyCode)(-11)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)119)
				{
					if (preset <= (IBFDPDLGLBC)(-58))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)83)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-119);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)57;
						}
					}
					else if (preset != (IBFDPDLGLBC)(-99))
					{
						if (preset == (IBFDPDLGLBC)(-20))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)56;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-76);
					}
				}
				else if (preset <= (IBFDPDLGLBC)69)
				{
					if (preset != (IBFDPDLGLBC)(-118))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)108:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-48);
							break;
						case (IBFDPDLGLBC)109:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)126;
							break;
						case (IBFDPDLGLBC)110:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-30);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-62);
					}
				}
				else if (preset != (IBFDPDLGLBC)33)
				{
					if (preset != (IBFDPDLGLBC)101)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-3):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-110);
							break;
						case (IBFDPDLGLBC)(-2):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-17);
							break;
						case (IBFDPDLGLBC)(-1):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-1);
							break;
						case IBFDPDLGLBC.Clear:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-113);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-5);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)4;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-83)))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x0049C1F4 File Offset: 0x0049A3F4
		private void BOAJJAKEMLH()
		{
			if (Input.GetKeyDown((KeyCode)(-75)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-74))
				{
					if (preset <= (IBFDPDLGLBC)(-85))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)98)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-85);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-8);
						}
					}
					else if (preset != (IBFDPDLGLBC)79)
					{
						if (preset == (IBFDPDLGLBC)(-56))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-55);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.WindyMist;
					}
				}
				else if (preset <= (IBFDPDLGLBC)99)
				{
					if (preset != (IBFDPDLGLBC)(-31))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-102):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)60;
							break;
						case (IBFDPDLGLBC)(-101):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)36;
							break;
						case (IBFDPDLGLBC)(-100):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)3;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)94;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-54))
				{
					if (preset != (IBFDPDLGLBC)36)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-100):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-123);
							break;
						case (IBFDPDLGLBC)(-99):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-57);
							break;
						case (IBFDPDLGLBC)(-98):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-49);
							break;
						case (IBFDPDLGLBC)(-97):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)8;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)105;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-98);
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-11)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x0049B639 File Offset: 0x00499839
		private void DHJDMKLBLEF()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x0049C3C8 File Offset: 0x0049A5C8
		private void BEDAJLJFAFO()
		{
			if (Input.GetKeyDown((KeyCode)(-95)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)47)
				{
					if (preset <= (IBFDPDLGLBC)(-21))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)9)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-80);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-123);
						}
					}
					else if (preset != (IBFDPDLGLBC)83)
					{
						if (preset == (IBFDPDLGLBC)(-50))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-88);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-109);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-113))
				{
					if (preset != (IBFDPDLGLBC)19)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)126:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-68);
							break;
						case (IBFDPDLGLBC)127:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)124;
							break;
						case (IBFDPDLGLBC)128:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-36);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)77;
					}
				}
				else if (preset != (IBFDPDLGLBC)4)
				{
					if (preset != (IBFDPDLGLBC)(-6))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-110):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-68);
							break;
						case (IBFDPDLGLBC)(-109):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)35;
							break;
						case (IBFDPDLGLBC)(-108):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)123;
							break;
						case (IBFDPDLGLBC)(-107):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)78;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-70);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-112);
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-58)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0049B639 File Offset: 0x00499839
		private void GDIMBBBPIHI()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x0049C59C File Offset: 0x0049A79C
		private void EMNMOMGOBPI()
		{
			GUI.Label(new Rect(1730f, 617f, (float)(Screen.width - -99), 237f), "cht_msg13");
			GUI.Label(new Rect(130f, 1240f, (float)(Screen.width - 93), 1828f), "_ReflectionTexture0" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0049C608 File Offset: 0x0049A808
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= IBFDPDLGLBC.LowClouds)
				{
					if (preset <= IBFDPDLGLBC.Mist)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == IBFDPDLGLBC.Mist)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.WindyMist;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
						}
					}
					else if (preset != IBFDPDLGLBC.WindyMist)
					{
						if (preset == IBFDPDLGLBC.LowClouds)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.SeaClouds;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.GroundFog;
					}
				}
				else if (preset <= IBFDPDLGLBC.FoggyLake)
				{
					if (preset != IBFDPDLGLBC.SeaClouds)
					{
						switch (preset)
						{
						case IBFDPDLGLBC.GroundFog:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.FrostedGround;
							break;
						case IBFDPDLGLBC.FrostedGround:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.FoggyLake;
							break;
						case IBFDPDLGLBC.FoggyLake:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Fog;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Smoke;
					}
				}
				else if (preset != IBFDPDLGLBC.Fog)
				{
					if (preset != IBFDPDLGLBC.HeavyFog)
					{
						switch (preset)
						{
						case IBFDPDLGLBC.SandStorm1:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm2;
							break;
						case IBFDPDLGLBC.Smoke:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.ToxicSwamp;
							break;
						case IBFDPDLGLBC.ToxicSwamp:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.SandStorm1;
							break;
						case IBFDPDLGLBC.SandStorm2:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.Mist;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.LowClouds;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.HeavyFog;
				}
			}
			else if (Input.GetKeyDown(KeyCode.T))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x0049B639 File Offset: 0x00499839
		private void JPHBPEAMNHB()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x0049C7DC File Offset: 0x0049A9DC
		private void JGDDEOALNOG()
		{
			GUI.Label(new Rect(1877f, 1080f, (float)(Screen.width - -74), 1541f), "<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}");
			GUI.Label(new Rect(1000f, 394f, (float)(Screen.width - 80), 1228f), "CheerKnees" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x0049C848 File Offset: 0x0049AA48
		private void EILPBPNOMJI()
		{
			GUI.Label(new Rect(1766f, 1729f, (float)(Screen.width - -107), 964f), "_DstBlend");
			GUI.Label(new Rect(666f, 1053f, (float)(Screen.width - -27), 657f), "_LayerThickness" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x0049B639 File Offset: 0x00499839
		private void KGICJDGIIJK()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x0049B639 File Offset: 0x00499839
		private void CLHGHANANNL()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x0049C8B4 File Offset: 0x0049AAB4
		private void OLBPGOGCCMP()
		{
			GUI.Label(new Rect(994f, 1994f, (float)(Screen.width - 27), 76f), "Injection Detector");
			GUI.Label(new Rect(1307f, 409f, (float)(Screen.width - -16), 378f), "CratePush" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x0049C920 File Offset: 0x0049AB20
		private void MBADKFPCOEJ()
		{
			GUI.Label(new Rect(704f, 1591f, (float)(Screen.width - -122), 148f), "Water");
			GUI.Label(new Rect(1863f, 1720f, (float)(Screen.width - 92), 550f), "_FresnelFadePower" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x0049C98C File Offset: 0x0049AB8C
		private void EOCENEIDJKI()
		{
			GUI.Label(new Rect(514f, 1223f, (float)(Screen.width - -108), 286f), " ms");
			GUI.Label(new Rect(1331f, 215f, (float)(Screen.width - 5), 775f), "_MainTex" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x0049C9F8 File Offset: 0x0049ABF8
		private void HKGCKLBHNPJ()
		{
			GUI.Label(new Rect(423f, 221f, (float)(Screen.width - -111), 1904f), "<color='#80a0ff'>{0}</color>");
			GUI.Label(new Rect(1885f, 512f, (float)(Screen.width - -74), 1825f), "null" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x0049CA64 File Offset: 0x0049AC64
		private void BMCKJEBCEPA()
		{
			GUI.Label(new Rect(560f, 1261f, (float)(Screen.width - -54), 840f), "_Offsets");
			GUI.Label(new Rect(1341f, 1918f, (float)(Screen.width - -85), 14f), "_RefractionTex" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x0049B639 File Offset: 0x00499839
		private void INDGOHJGCFN()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x0049CAD0 File Offset: 0x0049ACD0
		private void NJKJJNBMKHB()
		{
			GUI.Label(new Rect(474f, 1310f, (float)(Screen.width - -44), 826f), "FOG_SCATTERING_ON");
			GUI.Label(new Rect(466f, 1376f, (float)(Screen.width - -123), 546f), "wpn_add/addoptions/klevprop" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x0049CB3C File Offset: 0x0049AD3C
		private void GCLIPIADIPD()
		{
			GUI.Label(new Rect(1023f, 1005f, (float)(Screen.width - -22), 1692f), "invn_rec21");
			GUI.Label(new Rect(1575f, 256f, (float)(Screen.width - 52), 282f), "noShowPopl" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x0049CBA8 File Offset: 0x0049ADA8
		private void KBMKHLDOIKP()
		{
			if (Input.GetKeyDown((KeyCode)(-59)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-21))
				{
					if (preset <= (IBFDPDLGLBC)90)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)66)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)45;
						}
					}
					else if (preset != (IBFDPDLGLBC)88)
					{
						if (preset == IBFDPDLGLBC.SandStorm1)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)28;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-45);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-6))
				{
					if (preset != (IBFDPDLGLBC)115)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-51):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-117);
							break;
						case (IBFDPDLGLBC)(-50):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-17);
							break;
						case (IBFDPDLGLBC)(-49):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-51);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-58);
					}
				}
				else if (preset != (IBFDPDLGLBC)(-83))
				{
					if (preset != (IBFDPDLGLBC)(-78))
					{
						switch (preset)
						{
						case IBFDPDLGLBC.ToxicSwamp:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)82;
							break;
						case IBFDPDLGLBC.SandStorm2:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-75);
							break;
						case (IBFDPDLGLBC)54:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-57);
							break;
						case (IBFDPDLGLBC)55:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)61;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-121);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-123);
				}
			}
			else if (Input.GetKeyDown(KeyCode.Escape))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x0049CD7C File Offset: 0x0049AF7C
		private void CBBLGEDCJBF()
		{
			if (Input.GetKeyDown((KeyCode)23))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)84)
				{
					if (preset <= (IBFDPDLGLBC)(-126))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)(-4))
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)95;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-22);
						}
					}
					else if (preset != (IBFDPDLGLBC)(-51))
					{
						if (preset == (IBFDPDLGLBC)34)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)122;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)74;
					}
				}
				else if (preset <= (IBFDPDLGLBC)97)
				{
					if (preset != IBFDPDLGLBC.HeavyFog)
					{
						switch (preset)
						{
						case IBFDPDLGLBC.SandStorm2:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-37);
							break;
						case (IBFDPDLGLBC)54:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)57;
							break;
						case (IBFDPDLGLBC)55:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-27);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-20);
					}
				}
				else if (preset != (IBFDPDLGLBC)(-63))
				{
					if (preset != (IBFDPDLGLBC)(-127))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)62:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-27);
							break;
						case (IBFDPDLGLBC)63:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-84);
							break;
						case (IBFDPDLGLBC)64:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)76;
							break;
						case (IBFDPDLGLBC)65:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-40);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)69;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)78;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-2)))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x0049B639 File Offset: 0x00499839
		private void EHFPLKEINFO()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x0049CF50 File Offset: 0x0049B150
		private void PBHKFPELDGF()
		{
			GUI.Label(new Rect(140f, 1492f, (float)(Screen.width - -34), 713f), "knopje.wav");
			GUI.Label(new Rect(1475f, 875f, (float)(Screen.width - -20), 252f), "SoccerStartKick" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x0049B639 File Offset: 0x00499839
		private void BJHGPFGBFKF()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x0049CFBC File Offset: 0x0049B1BC
		private void BGJFLKLBOPK()
		{
			GUI.Label(new Rect(1323f, 1878f, (float)(Screen.width - 76), 111f), "Ball");
			GUI.Label(new Rect(1659f, 288f, (float)(Screen.width - -62), 113f), "" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x0049B639 File Offset: 0x00499839
		private void MKNPFMEMOJO()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x0049D028 File Offset: 0x0049B228
		private void BCJFDHBDAHD()
		{
			GUI.Label(new Rect(1728f, 1969f, (float)(Screen.width - 55), 798f), "SixStep");
			GUI.Label(new Rect(394f, 1292f, (float)(Screen.width - 114), 257f), "Load costume " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x0049D094 File Offset: 0x0049B294
		private void IPFNFHPFAOE()
		{
			GUI.Label(new Rect(1876f, 1299f, (float)(Screen.width - -35), 190f), "IceHockeyGoalieSave2");
			GUI.Label(new Rect(1143f, 808f, (float)(Screen.width - 27), 1017f), "_Phase" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x0049D100 File Offset: 0x0049B300
		private void BIOKMDIGOIA()
		{
			GUI.Label(new Rect(74f, 288f, (float)(Screen.width - 22), 259f), "\npb_Face: ");
			GUI.Label(new Rect(481f, 1908f, (float)(Screen.width - -44), 1210f), "IceHockeyIdle" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x0049D16C File Offset: 0x0049B36C
		private void JIKGIJEHGAP()
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-82))
				{
					if (preset <= (IBFDPDLGLBC)(-70))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)68)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-70);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.LowClouds;
						}
					}
					else if (preset != (IBFDPDLGLBC)45)
					{
						if (preset == (IBFDPDLGLBC)(-51))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-19);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)85;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-62))
				{
					if (preset != (IBFDPDLGLBC)43)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)48:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)24;
							break;
						case (IBFDPDLGLBC)49:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)48;
							break;
						case IBFDPDLGLBC.SandStorm1:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-110);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)99;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-51))
				{
					if (preset != (IBFDPDLGLBC)(-71))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-71):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)107;
							break;
						case (IBFDPDLGLBC)(-70):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-20);
							break;
						case (IBFDPDLGLBC)(-69):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)106;
							break;
						case (IBFDPDLGLBC)(-68):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)61;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-46);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)28;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-86)))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x0049B639 File Offset: 0x00499839
		private void NCALLFHEAGJ()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x0049B639 File Offset: 0x00499839
		private void Start()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x0049D340 File Offset: 0x0049B540
		private void JCMGHHKALDM()
		{
			GUI.Label(new Rect(505f, 796f, (float)(Screen.width - 99), 1989f), "GiantGrabIdle");
			GUI.Label(new Rect(1146f, 1871f, (float)(Screen.width - -101), 181f), "Worker Hammer" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x0049D3AC File Offset: 0x0049B5AC
		private void AGBEEDOOOHA()
		{
			GUI.Label(new Rect(1096f, 1927f, (float)(Screen.width - -106), 1277f), "_EmissionColor");
			GUI.Label(new Rect(1778f, 766f, (float)(Screen.width - 73), 447f), "camouflage_scale" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x0049D418 File Offset: 0x0049B618
		private void BLCDCEHNNNC()
		{
			GUI.Label(new Rect(1936f, 354f, (float)(Screen.width - -44), 1297f), "UIChat_channel");
			GUI.Label(new Rect(1457f, 1760f, (float)(Screen.width - 103), 1297f), "base_{0}" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x0049D484 File Offset: 0x0049B684
		private void HABONMJNDAL()
		{
			if (Input.GetKeyDown((KeyCode)4))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)75)
				{
					if (preset <= (IBFDPDLGLBC)(-87))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)126)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-9);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-116);
						}
					}
					else if (preset != (IBFDPDLGLBC)66)
					{
						if (preset == (IBFDPDLGLBC)(-48))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-38);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-7);
					}
				}
				else if (preset <= (IBFDPDLGLBC)89)
				{
					if (preset != (IBFDPDLGLBC)111)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-93):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-106);
							break;
						case (IBFDPDLGLBC)(-92):
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.FoggyLake;
							break;
						case (IBFDPDLGLBC)(-91):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)122;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.SeaClouds;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-24))
				{
					if (preset != (IBFDPDLGLBC)112)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)79:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-30);
							break;
						case (IBFDPDLGLBC)80:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)36;
							break;
						case (IBFDPDLGLBC)81:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)106;
							break;
						case (IBFDPDLGLBC)82:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-126);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)110;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-2);
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-111)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x0049D658 File Offset: 0x0049B858
		private void KIEFPGLDOCD()
		{
			GUI.Label(new Rect(713f, 82f, (float)(Screen.width - 63), 104f), "sunshine_ShadowCoordDepthRayZ");
			GUI.Label(new Rect(1079f, 1494f, (float)(Screen.width - -23), 1510f), ": " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x0049D6C4 File Offset: 0x0049B8C4
		private void PNAEIDCONFP()
		{
			GUI.Label(new Rect(1821f, 1566f, (float)(Screen.width - 99), 539f), "");
			GUI.Label(new Rect(1382f, 734f, (float)(Screen.width - -31), 92f), "name" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x0049D730 File Offset: 0x0049B930
		private void EILPHLEBEJP()
		{
			GUI.Label(new Rect(566f, 1565f, (float)(Screen.width - 56), 111f), "Katana45DegSwing");
			GUI.Label(new Rect(140f, 1993f, (float)(Screen.width - -10), 293f), "saleToAuk" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x0049B639 File Offset: 0x00499839
		private void LHHKDNILMDI()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x0049B639 File Offset: 0x00499839
		private void EHDPACPIBNF()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x0049D79C File Offset: 0x0049B99C
		private void KMLNBHIIGKH()
		{
			if (Input.GetKeyDown((KeyCode)(-89)))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)93)
				{
					if (preset <= (IBFDPDLGLBC)(-88))
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == IBFDPDLGLBC.FrostedGround)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)5;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-74);
						}
					}
					else if (preset != (IBFDPDLGLBC)(-88))
					{
						if (preset == (IBFDPDLGLBC)(-110))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-19);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)59;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-76))
				{
					if (preset != IBFDPDLGLBC.LowClouds)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)102:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-22);
							break;
						case (IBFDPDLGLBC)103:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)78;
							break;
						case (IBFDPDLGLBC)104:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)94;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)33;
					}
				}
				else if (preset != (IBFDPDLGLBC)95)
				{
					if (preset != (IBFDPDLGLBC)(-52))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)8:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)86;
							break;
						case (IBFDPDLGLBC)9:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-37);
							break;
						case IBFDPDLGLBC.Mist:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-96);
							break;
						case IBFDPDLGLBC.WindyMist:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-99);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-61);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)89;
				}
			}
			else if (Input.GetKeyDown((KeyCode)86))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x0049D970 File Offset: 0x0049BB70
		private void KBAJMMCHDOC()
		{
			GUI.Label(new Rect(1751f, 1576f, (float)(Screen.width - 35), 532f), "chest");
			GUI.Label(new Rect(470f, 194f, (float)(Screen.width - 58), 910f), "IdleFly" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x0049D9DC File Offset: 0x0049BBDC
		private void PNJNNNJEBGA()
		{
			GUI.Label(new Rect(1595f, 1792f, (float)(Screen.width - 85), 288f), "");
			GUI.Label(new Rect(835f, 1619f, (float)(Screen.width - -36), 444f), " " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x0049DA48 File Offset: 0x0049BC48
		private void OFKLNHNPADP()
		{
			GUI.Label(new Rect(1284f, 1378f, (float)(Screen.width - -39), 503f), "PaperTurn.wav");
			GUI.Label(new Rect(835f, 1878f, (float)(Screen.width - -48), 1812f), " on effect " + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x0049DAB4 File Offset: 0x0049BCB4
		private void CJHBCHBOLBI()
		{
			if (Input.GetKeyDown(KeyCode.At))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-110))
				{
					if (preset <= (IBFDPDLGLBC)5)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)1)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-3);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)113;
						}
					}
					else if (preset != (IBFDPDLGLBC)(-121))
					{
						if (preset == (IBFDPDLGLBC)72)
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-104);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-9);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-117))
				{
					if (preset != (IBFDPDLGLBC)(-69))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-51):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-9);
							break;
						case (IBFDPDLGLBC)(-50):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-16);
							break;
						case (IBFDPDLGLBC)(-49):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)96;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)46;
					}
				}
				else if (preset != (IBFDPDLGLBC)6)
				{
					if (preset != IBFDPDLGLBC.FoggyLake)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-90):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)17;
							break;
						case (IBFDPDLGLBC)(-89):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)65;
							break;
						case (IBFDPDLGLBC)(-88):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)65;
							break;
						case (IBFDPDLGLBC)(-87):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-3);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-11);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-114);
				}
			}
			else if (Input.GetKeyDown((KeyCode)18))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x0049B639 File Offset: 0x00499839
		private void DDEBDCGNCPC()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x0049DC88 File Offset: 0x0049BE88
		private void MPLCAGFGEBO()
		{
			if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)38)
				{
					if (preset <= (IBFDPDLGLBC)81)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)127)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-61);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-103);
						}
					}
					else if (preset != (IBFDPDLGLBC)110)
					{
						if (preset == (IBFDPDLGLBC)(-89))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-123);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-38);
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-66))
				{
					if (preset != (IBFDPDLGLBC)28)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)63:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)46;
							break;
						case (IBFDPDLGLBC)64:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-91);
							break;
						case (IBFDPDLGLBC)65:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-71);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)98;
					}
				}
				else if (preset != (IBFDPDLGLBC)(-65))
				{
					if (preset != (IBFDPDLGLBC)(-13))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)124:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)18;
							break;
						case (IBFDPDLGLBC)125:
							this.ANCIMKLOHFH.EDBIMEMLHCP = IBFDPDLGLBC.ToxicSwamp;
							break;
						case (IBFDPDLGLBC)126:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-123);
							break;
						case (IBFDPDLGLBC)127:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)49;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)65;
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)5;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-33)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x0049DE5C File Offset: 0x0049C05C
		private void OPDCJCFMIPE()
		{
			if (Input.GetKeyDown(KeyCode.Quote))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-109))
				{
					if (preset <= (IBFDPDLGLBC)104)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)(-69))
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)38;
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)14;
						}
					}
					else if (preset != (IBFDPDLGLBC)(-72))
					{
						if (preset == (IBFDPDLGLBC)(-50))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-21);
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)1;
					}
				}
				else if (preset <= (IBFDPDLGLBC)(-127))
				{
					if (preset != (IBFDPDLGLBC)(-94))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)124:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)87;
							break;
						case (IBFDPDLGLBC)125:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-71);
							break;
						case (IBFDPDLGLBC)126:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-42);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-70);
					}
				}
				else if (preset != (IBFDPDLGLBC)(-99))
				{
					if (preset != (IBFDPDLGLBC)(-84))
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-5):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)73;
							break;
						case (IBFDPDLGLBC)(-4):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-119);
							break;
						case (IBFDPDLGLBC)(-3):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-73);
							break;
						case (IBFDPDLGLBC)(-2):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)24;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-102);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)56;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-86)))
			{
				this.ANCIMKLOHFH.enabled = this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.BNEPHLKMALH.transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x0049E030 File Offset: 0x0049C230
		private void LHOKCJCHLOM()
		{
			GUI.Label(new Rect(676f, 334f, (float)(Screen.width - 70), 1433f), "crft_wpnpr");
			GUI.Label(new Rect(664f, 122f, (float)(Screen.width - -123), 1375f), "Bow Instant" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x0049E09C File Offset: 0x0049C29C
		private void AHEAJPNHBBB()
		{
			GUI.Label(new Rect(1698f, 1938f, (float)(Screen.width - 64), 1194f), "Hit Point WeightCurve length is zero.");
			GUI.Label(new Rect(1553f, 1900f, (float)(Screen.width - -17), 46f), "111111111222\n33333333" + VolumetricFog.COIPKPKLDAH.GetCurrentPresetName());
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x0049E108 File Offset: 0x0049C308
		private void AMDMCKIFBPA()
		{
			if (Input.GetKeyDown((KeyCode)77))
			{
				IBFDPDLGLBC preset = this.ANCIMKLOHFH.EDBIMEMLHCP;
				if (preset <= (IBFDPDLGLBC)(-45))
				{
					if (preset <= (IBFDPDLGLBC)80)
					{
						if (preset != IBFDPDLGLBC.Clear)
						{
							if (preset == (IBFDPDLGLBC)9)
							{
								this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-58);
							}
						}
						else
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)5;
						}
					}
					else if (preset != (IBFDPDLGLBC)79)
					{
						if (preset == (IBFDPDLGLBC)(-54))
						{
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)68;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-91);
					}
				}
				else if (preset <= (IBFDPDLGLBC)45)
				{
					if (preset != (IBFDPDLGLBC)7)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)73:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-65);
							break;
						case (IBFDPDLGLBC)74:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)35;
							break;
						case (IBFDPDLGLBC)75:
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)49;
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)40;
					}
				}
				else if (preset != (IBFDPDLGLBC)2)
				{
					if (preset != (IBFDPDLGLBC)118)
					{
						switch (preset)
						{
						case (IBFDPDLGLBC)(-34):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)58;
							break;
						case (IBFDPDLGLBC)(-33):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)90;
							break;
						case (IBFDPDLGLBC)(-32):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-27);
							break;
						case (IBFDPDLGLBC)(-31):
							this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-13);
							break;
						}
					}
					else
					{
						this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)(-32);
					}
				}
				else
				{
					this.ANCIMKLOHFH.EDBIMEMLHCP = (IBFDPDLGLBC)70;
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-111)))
			{
				this.ANCIMKLOHFH.enabled = !this.ANCIMKLOHFH.enabled;
			}
			this.ANCIMKLOHFH.CKPBJAKMBNF().transform.Rotate(Vector3.left, Time.deltaTime);
		}

		// Token: 0x04001509 RID: 5385
		private VolumetricFog ANCIMKLOHFH;
	}
}
