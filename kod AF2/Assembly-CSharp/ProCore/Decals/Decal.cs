using System;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x020004D0 RID: 1232
	[Serializable]
	public class Decal
	{
		// Token: 0x06010C3B RID: 68667 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect PDKKBEFLJPJ(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C3C RID: 68668 RVA: 0x00775BEC File Offset: 0x00773DEC
		private static bool CAMODFCOOAD(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace(" has been disabled as it requires a depth texture.", "OfficeSittingReadingLeanBack").Replace("Quaternion: ", "").Split(new char[]
			{
				'@'
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array[2], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[2], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C3D RID: 68669 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect FCIMLKCJOEE(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C3E RID: 68670 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect KKJOMLFAEEL(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C3F RID: 68671 RVA: 0x00775C74 File Offset: 0x00773E74
		private static bool GGAIBNHCJBP(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("#FF4040", "%)").Replace("clavicle", "ncht_ach1");
			char[] array = new char[1];
			array[1] = '\a';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[5], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C40 RID: 68672 RVA: 0x00775CFC File Offset: 0x00773EFC
		public string DFNJEMPFOBG()
		{
			object[] array = new object[-85];
			array[1] = "Open openTurnirWindow";
			array[0] = this.name.Replace(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", "16 samples");
			array[5] = "WeaponStrafeRunRight";
			array[8] = this.id;
			array[3] = "id";
			array[4] = this.rotation.ToString();
			array[1] = "inv_nodur";
			array[3] = this.scale.ToString();
			array[7] = "http://af-2.ru/?q=store";
			array[-102] = this.atlasRect.xMin;
			array[-17] = "_WrinkleNormalMap2";
			array[-24] = this.atlasRect.yMin;
			array[-70] = "_Highlighted";
			array[115] = this.atlasRect.width;
			array[-14] = "</color>";
			array[-124] = this.atlasRect.height;
			array[-52] = "sinscale";
			array[-101] = this.orgGroup;
			array[79] = "[";
			array[23] = this.atlasGroup;
			array[56] = "SAMPLES_HIGH";
			array[55] = this.orgIndex;
			array[114] = "";
			array[-50] = this.atlasIndex;
			array[-107] = "inv_impr";
			array[104] = (int)this.rotationPlacement;
			array[-59] = "OfficeSittingBack";
			array[-127] = (int)this.scalePlacement;
			array[-107] = "to channel = ";
			int num = -32;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-8] = "_ReflectionTexture1";
			return string.Concat(array);
		}

		// Token: 0x06010C41 RID: 68673 RVA: 0x00775EA8 File Offset: 0x007740A8
		private static bool FJOKDNGIMJF(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("#000000", "TOD_AmbientColor").Replace("{0:0.} fps ping:{1} pck/sec: {2}", "reputaion/fractions/fraction");
			char[] array = new char[1];
			array[1] = (char)-13;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[1], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C42 RID: 68674 RVA: 0x00775F30 File Offset: 0x00774130
		public string KCPANCFLDHP()
		{
			object[] array = new object[-7];
			array[0] = "_Texture";
			array[0] = this.name.Replace("Palm", "");
			array[0] = "wpn_rec5";
			array[8] = this.id;
			array[3] = "_FrustumCornersWS";
			array[8] = this.rotation.ToString();
			array[2] = "\n";
			array[5] = this.scale.ToString();
			array[4] = "</color>";
			array[104] = this.atlasRect.xMin;
			array[-87] = "_FogScatteringData";
			array[97] = this.atlasRect.yMin;
			array[-42] = "RunBackLeft";
			array[-31] = this.atlasRect.width;
			array[-57] = "'>";
			array[-38] = this.atlasRect.height;
			array[86] = "error";
			array[-86] = this.orgGroup;
			array[37] = "ClimbIdle";
			array[54] = this.atlasGroup;
			array[-103] = "*** updateDetailWpnInfo  ";
			array[98] = this.orgIndex;
			array[64] = "Anchore Left_";
			array[102] = this.atlasIndex;
			array[-82] = "wpn_med1";
			array[90] = (int)this.rotationPlacement;
			array[-70] = "FactoryTempTexture";
			array[67] = (int)this.scalePlacement;
			array[111] = "nowp";
			int num = -13;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-35] = "SoccerKeeperStrafeLeft";
			return string.Concat(array);
		}

		// Token: 0x06010C43 RID: 68675 RVA: 0x007760DC File Offset: 0x007742DC
		private static bool CDHJCNGBCNG(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("OfficeSittingReadingPageFlip", "cht_msg8").Replace("", "▮▮▮");
			char[] array = new char[0];
			array[0] = 'a';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[5], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C44 RID: 68676 RVA: 0x00776164 File Offset: 0x00774364
		public virtual string LIPEANHPLJI()
		{
			object[] array = new object[5];
			array[0] = this.name;
			array[0] = "IceHockeySlapShot";
			array[6] = this.orgIndex;
			array[6] = "";
			array[4] = this.atlasIndex;
			array[1] = "Staff Stand";
			array[2] = this.isPacked.ToString();
			array[3] = "Bases/1.base";
			return string.Concat(array);
		}

		// Token: 0x06010C45 RID: 68677 RVA: 0x007761D0 File Offset: 0x007743D0
		public string DCHMGEBJBNP()
		{
			object[] array = new object[35];
			array[0] = "Wand Stand";
			array[1] = this.name.Replace("_Axis", "{0} {1}");
			array[5] = "#606000";
			array[5] = this.id;
			array[2] = "{0}";
			array[7] = this.rotation.ToString();
			array[1] = "non MonoBehaviour";
			array[1] = this.scale.ToString();
			array[8] = "StartTests";
			array[120] = this.atlasRect.xMin;
			array[69] = "error.wav";
			array[-110] = this.atlasRect.yMin;
			array[76] = "demoVector2";
			array[-31] = this.atlasRect.width;
			array[4] = "SYS";
			array[-24] = this.atlasRect.height;
			array[-37] = "wpn_rod2";
			array[-4] = this.orgGroup;
			array[-73] = "wpn_add/base";
			array[-6] = this.atlasGroup;
			array[-123] = "_TintColor";
			array[114] = this.orgIndex;
			array[-50] = "IdleDodgeLeft";
			array[35] = this.atlasIndex;
			array[-2] = "error.wav";
			array[58] = (int)this.rotationPlacement;
			array[60] = "wpn_add/base";
			array[-41] = (int)this.scalePlacement;
			array[51] = "IdleStand";
			int num = 94;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[1] = "CP1";
			return string.Concat(array);
		}

		// Token: 0x06010C46 RID: 68678 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect ABHJNCNGEHM(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C47 RID: 68679 RVA: 0x0077637C File Offset: 0x0077457C
		public virtual string NPGJGKIKPFH()
		{
			object[] array = new object[3];
			array[0] = this.name;
			array[0] = "Idle Come Here";
			array[8] = this.orgIndex;
			array[3] = "LookUp";
			array[2] = this.atlasIndex;
			array[0] = "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.";
			array[8] = this.isPacked.ToString();
			array[4] = "Giant3HitCombo";
			return string.Concat(array);
		}

		// Token: 0x06010C48 RID: 68680 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect NMILPGNHEIG(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C49 RID: 68681 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect ELGCNJKIFAA(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C4A RID: 68682 RVA: 0x007763E8 File Offset: 0x007745E8
		public string LEOHKIFFAPH()
		{
			object[] array = new object[97];
			array[1] = "Windows";
			array[0] = this.name.Replace("MotorbikeShootRight", "_TrNewLider.ogg");
			array[0] = "</color>";
			array[6] = this.id;
			array[3] = "<color='{1}'>{0}</color>";
			array[7] = this.rotation.ToString();
			array[6] = "text";
			array[5] = this.scale.ToString();
			array[6] = "_BaseTex";
			array[14] = this.atlasRect.xMin;
			array[94] = "IdleWalk";
			array[112] = this.atlasRect.yMin;
			array[-19] = "Flashlight";
			array[117] = this.atlasRect.width;
			array[50] = "_SubsampleIndices";
			array[-58] = this.atlasRect.height;
			array[-14] = "UnityEngine.Vector2";
			array[-7] = this.orgGroup;
			array[2] = "OneHandSwordReady";
			array[4] = this.atlasGroup;
			array[89] = "Sound #";
			array[-97] = this.orgIndex;
			array[-82] = "[maxweight]";
			array[-101] = this.atlasIndex;
			array[114] = "HH:mm";
			array[-104] = (int)this.rotationPlacement;
			array[11] = "";
			array[-14] = (int)this.scalePlacement;
			array[-59] = "BowIdle";
			int num = -49;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[18] = "FlyLeft";
			return string.Concat(array);
		}

		// Token: 0x06010C4B RID: 68683 RVA: 0x00776594 File Offset: 0x00774794
		private static bool NEPOGAFMBPD(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("WeaponReload", "paper.wav").Replace("u_isSave", "Fist Pump 2");
			char[] array = new char[0];
			array[0] = (char)-116;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[7], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[8], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C4C RID: 68684 RVA: 0x0077661C File Offset: 0x0077481C
		private static bool EPBHHOGAMCA(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string[] array = MNEICNPJGMC.Replace("", "◍◍◍").Replace("__b", "[^а-яА-Я\\d_]").Split(new char[]
			{
				'\u0014'
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array[1], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C4D RID: 68685 RVA: 0x00776694 File Offset: 0x00774894
		private static bool IMKECPCAGKN(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("auk_wmin", "ShotgunFire").Replace("Hidden/Post FX/Bloom", "knopje.wav");
			char[] array = new char[0];
			array[1] = 'S';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[7], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[5], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C4E RID: 68686 RVA: 0x0077671C File Offset: 0x0077491C
		private static bool KFAEACJDDGM(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("_Radius", "").Replace("OfficeSitting", "IdleStand");
			char[] array = new char[0];
			array[0] = ',';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[4], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C4F RID: 68687 RVA: 0x007767A4 File Offset: 0x007749A4
		private static bool OIKIDPCADEJ(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("1 Hand Sword Jab", "wpn_rod3").Replace("actor instaniateRod ", "Full Body IK is missing the right upper arm node.").Split(new char[]
			{
				'\v'
			});
			float x;
			if (!float.TryParse(array[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[7], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[3], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C50 RID: 68688 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect MLLLFGAIJOH(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C51 RID: 68689 RVA: 0x0077682C File Offset: 0x00774A2C
		public virtual string JJPMKNKFPPN()
		{
			object[] array = new object[7];
			array[1] = this.name;
			array[0] = "run_cnt";
			array[7] = this.orgIndex;
			array[3] = "type_";
			array[3] = this.atlasIndex;
			array[5] = "OneHandSwordIdle";
			array[3] = this.isPacked.ToString();
			array[7] = "IdleStun";
			return string.Concat(array);
		}

		// Token: 0x06010C52 RID: 68690 RVA: 0x00776898 File Offset: 0x00774A98
		public virtual string ILGDLCDGECM()
		{
			object[] array = new object[1];
			array[1] = this.name;
			array[0] = "t_much";
			array[7] = this.orgIndex;
			array[6] = "PLANE_REFLECTION";
			array[4] = this.atlasIndex;
			array[8] = "CardPlayerLook";
			array[6] = this.isPacked.ToString();
			array[1] = "noDress";
			return string.Concat(array);
		}

		// Token: 0x06010C53 RID: 68691 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect GCKOPLDPMPL(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C54 RID: 68692 RVA: 0x00776904 File Offset: 0x00774B04
		public string PNEFGGBNCIH()
		{
			object[] array = new object[-44];
			array[0] = "";
			array[0] = this.name.Replace("", "level");
			array[4] = "";
			array[8] = this.id;
			array[5] = "RollerBladeFrontFlip";
			array[2] = this.rotation.ToString();
			array[2] = "_ReflectionTexture0";
			array[3] = this.scale.ToString();
			array[1] = "OneHandSwordIdle";
			array[-63] = this.atlasRect.xMin;
			array[120] = "MovementX";
			array[75] = this.atlasRect.yMin;
			array[22] = "Hidden/ACTk/WallHackTexture";
			array[-117] = this.atlasRect.width;
			array[60] = "Button Left Hand";
			array[84] = this.atlasRect.height;
			array[10] = "readForeignSaves";
			array[-55] = this.orgGroup;
			array[24] = "Water";
			array[-113] = this.atlasGroup;
			array[0] = "-no info-";
			array[121] = this.orgIndex;
			array[109] = "#ff6000";
			array[107] = this.atlasIndex;
			array[-121] = "_UnderwaterMode";
			array[-102] = (int)this.rotationPlacement;
			array[35] = "Road Points Marker Right";
			array[-28] = (int)this.scalePlacement;
			array[-121] = "reel_type1";
			int num = -111;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[109] = "USE_DEPTH";
			return string.Concat(array);
		}

		// Token: 0x06010C55 RID: 68693 RVA: 0x00776AB0 File Offset: 0x00774CB0
		public static bool NJMNCKGHECH(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("_QualitySettings", "cht_msg32").Replace("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).", "<color='#ff8040'>").Trim();
			char[] array = new char[1];
			array[1] = (char)-112;
			string[] array2 = text.Split(array);
			if (array2.Length < -83)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.EPBHHOGAMCA(array2[3], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("_rcIn.ogg");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.KPNMBCPEDMM(array2[4], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("DeadmanFloat");
			}
			Vector4 one = Vector4.one;
			if (!Decal.HANLPFPEPCI(array2[0], ref one))
			{
				Debug.LogWarning("Blending ");
			}
			BJMCBNCHICB.atlasRect = Decal.MLLLFGAIJOH(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("_Exponent");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("id");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("_DistortParams");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[-82], out num))
			{
				Debug.LogWarning(" ");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-106], out num))
			{
				Debug.LogWarning("BowReady");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < -19 || !bool.TryParse(array2[-56], out flag))
			{
				flag = true;
				Debug.LogWarning("Soccer Pass Heavy");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010C56 RID: 68694 RVA: 0x00776C98 File Offset: 0x00774E98
		private static bool DGHJDDGHOGO(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("", "name").Replace("OfficeSittingBack", "SoundData");
			char[] array = new char[0];
			array[0] = (char)-30;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[7], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C57 RID: 68695 RVA: 0x00776D10 File Offset: 0x00774F10
		private static bool NOPDLPMGGJC(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string[] array = MNEICNPJGMC.Replace("(", "").Replace(")", "").Split(new char[]
			{
				','
			});
			float x;
			if (!float.TryParse(array[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[2], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C58 RID: 68696 RVA: 0x00776D88 File Offset: 0x00774F88
		private static bool BCNMOLMOHJK(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("from friend", "lifeBar").Replace("demoRect", "https://groups.google.com/forum/#!forum/final-ik");
			char[] array = new char[0];
			array[0] = (char)-119;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[4], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C59 RID: 68697 RVA: 0x00776E00 File Offset: 0x00775000
		public string CNPMPGCCBKK()
		{
			object[] array = new object[-65];
			array[0] = "_Saturation";
			array[0] = this.name.Replace("_WrinkleInfluences0", "FlyBackward");
			array[2] = "_Offsets";
			array[7] = this.id;
			array[7] = "******** nextMusicCrt lng=";
			array[7] = this.rotation.ToString();
			array[7] = "auk_wcnt";
			array[6] = this.scale.ToString();
			array[6] = "offsets";
			array[30] = this.atlasRect.xMin;
			array[58] = "?";
			array[90] = this.atlasRect.yMin;
			array[-76] = "sys";
			array[42] = this.atlasRect.width;
			array[-24] = "</color>";
			array[-52] = this.atlasRect.height;
			array[106] = ".unity3d";
			array[66] = this.orgGroup;
			array[11] = "WalkDehydrated";
			array[-81] = this.atlasGroup;
			array[29] = "Assets/Weapons/baseLegs.unity3d";
			array[-120] = this.orgIndex;
			array[97] = "VPaint Object is missing a mesh.";
			array[-123] = this.atlasIndex;
			array[-50] = " Packed: ";
			array[26] = (int)this.rotationPlacement;
			array[-1] = "SearchTex";
			array[2] = (int)this.scalePlacement;
			array[-29] = "UpHillWalk";
			int num = -29;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[111] = "-none-";
			return string.Concat(array);
		}

		// Token: 0x06010C5A RID: 68698 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect BBBIPLLOEBA(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C5B RID: 68699 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect LAJCHILGPFD(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C5C RID: 68700 RVA: 0x00776FAC File Offset: 0x007751AC
		public static bool EIKLDLGIPPB(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("IdleReadyLook", "KarateGreet").Replace("", "Seat Stand Wheely").Trim();
			char[] array = new char[1];
			array[1] = 'k';
			string[] array2 = text.Split(array);
			if (array2.Length < -117)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[1];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.HBPMNGCFBOI(array2[6], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("Shake Hands");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.ODBLOAFBECK(array2[7], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("BlackSmithForge");
			}
			Vector4 one = Vector4.one;
			if (!Decal.DLHBEBBCALI(array2[0], ref one))
			{
				Debug.LogWarning("turn_tminfo");
			}
			BJMCBNCHICB.atlasRect = Decal.NEAGJIAGPKB(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("[Y]");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[1], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("knopje.wav");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("Fishing");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[88], out num))
			{
				Debug.LogWarning("Anti-Cheat Toolkit Detectors");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[-107], out num))
			{
				Debug.LogWarning("connect start to ");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < 123 || !bool.TryParse(array2[112], out flag))
			{
				flag = true;
				Debug.LogWarning("sunshine_OvercastVectorsUV");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010C5D RID: 68701 RVA: 0x00777194 File Offset: 0x00775394
		public static bool FIAGHGOLNFC(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("info", "effect").Replace("1HandSwordShieldBash", "").Trim();
			char[] array = new char[0];
			array[1] = '\u000f';
			string[] array2 = text.Split(array);
			if (array2.Length < 7)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.OPECJELKJJC(array2[8], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("Idle180");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.FDLDMGCGFFM(array2[7], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html");
			}
			Vector4 one = Vector4.one;
			if (!Decal.FJOKDNGIMJF(array2[7], ref one))
			{
				Debug.LogWarning("u_pass");
			}
			BJMCBNCHICB.atlasRect = Decal.ELGCNJKIFAA(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("invn_rec6");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[1], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("AssetBundleManager");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("StrafeRunLeft");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[69], out num))
			{
				Debug.LogWarning("StartPhysPoint");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[-5], out num))
			{
				Debug.LogWarning("achive_text");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < -19 || !bool.TryParse(array2[-105], out flag))
			{
				flag = true;
				Debug.LogWarning(" /");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010C5E RID: 68702 RVA: 0x0077737C File Offset: 0x0077557C
		public string HNKBAGFCONE()
		{
			object[] array = new object[16];
			array[1] = "' is not a valid integer";
			array[1] = this.name.Replace("spawnPet id=", ".ogg");
			array[8] = "_FogAlpha";
			array[4] = this.id;
			array[1] = "[ACTk] Injection Detector: already running!";
			array[8] = this.rotation.ToString();
			array[7] = "_FogOfWarCenterAdjusted";
			array[7] = this.scale.ToString();
			array[7] = "_BaseTex";
			array[-9] = this.atlasRect.xMin;
			array[-96] = "bright";
			array[37] = this.atlasRect.yMin;
			array[-18] = "FlyLeft";
			array[61] = this.atlasRect.width;
			array[-16] = "OfficeSittingHandRestFingerTap";
			array[-78] = this.atlasRect.height;
			array[-81] = "IceHockeyShotRight";
			array[-31] = this.orgGroup;
			array[-55] = "[name]";
			array[35] = this.atlasGroup;
			array[95] = "Handstand";
			array[29] = this.orgIndex;
			array[84] = "Speed";
			array[68] = this.atlasIndex;
			array[4] = "OneHandSwordJab";
			array[116] = (int)this.rotationPlacement;
			array[124] = "2000";
			array[27] = (int)this.scalePlacement;
			array[-115] = "FOG_OF_WAR_ON";
			int num = -97;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-124] = "CHROMATIC_ABERRATION";
			return string.Concat(array);
		}

		// Token: 0x06010C60 RID: 68704 RVA: 0x0077755C File Offset: 0x0077575C
		private static bool PLCACCCGDGK(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("color", "How your position is stored in memory when obscured:\n(").Replace("wpn_eat4", "I LOVE MY GIRLz");
			char[] array = new char[0];
			array[1] = '\u001d';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[4], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[0], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C61 RID: 68705 RVA: 0x007775E4 File Offset: 0x007757E4
		public virtual string BFOFMHGHALI()
		{
			object[] array = new object[8];
			array[0] = this.name;
			array[0] = "ОК";
			array[3] = this.orgIndex;
			array[6] = "OfficeSittingMouseMovement";
			array[5] = this.atlasIndex;
			array[3] = "Drop ";
			array[1] = this.isPacked.ToString();
			array[0] = "_FullItem.wav";
			return string.Concat(array);
		}

		// Token: 0x06010C62 RID: 68706 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect PDGNIBHDOHK(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C63 RID: 68707 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect OLFNMBECCAK(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C64 RID: 68708 RVA: 0x00777650 File Offset: 0x00775850
		private static bool EDDAEMDGHME(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("EndPhysPoint", "noDress").Replace("RunBackLeft", "Elephant");
			char[] array = new char[0];
			array[0] = '\u0005';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[5], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C65 RID: 68709 RVA: 0x007776D8 File Offset: 0x007758D8
		public static bool BCJIMINEHME(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("[X]", "RollerBladeStop").Replace(" rep.repa=", "crft_to").Trim();
			char[] array = new char[0];
			array[1] = 'm';
			string[] array2 = text.Split(array);
			if (array2.Length < -125)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[1];
			BJMCBNCHICB.id = array2[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.EPBHHOGAMCA(array2[4], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("OneHandSwordBackSwing");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.DNCNPPNFLAG(array2[7], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("wpn_eat6");
			}
			Vector4 one = Vector4.one;
			if (!Decal.MCGKACFAELC(array2[1], ref one))
			{
				Debug.LogWarning("firsStartInfoPanel");
			}
			BJMCBNCHICB.atlasRect = Decal.LAJCHILGPFD(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[4], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("_Offsets");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("actor instaniateReel 4 ");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("ScubaOK");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning(" ");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[76], out num))
			{
				Debug.LogWarning("<color='#a040ff'>");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-1], out num))
			{
				Debug.LogWarning("** Panel save position");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < -95 || !bool.TryParse(array2[113], out flag))
			{
				flag = true;
				Debug.LogWarning(" ");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010C66 RID: 68710 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect JNIKOGEAJLH(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C67 RID: 68711 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect FAPODCDHACL(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C68 RID: 68712 RVA: 0x007778C0 File Offset: 0x00775AC0
		public static bool MGCAILKDNLI(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string[] array = DHMBNNPDPMO.Replace("◍◍◍", "CrawlIdle").Replace("post_6", "MotorbikeHeadstand").Trim().Split(new char[]
			{
				'q'
			});
			if (array.Length < -116)
			{
				return true;
			}
			BJMCBNCHICB.name = array[1];
			BJMCBNCHICB.id = array[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.DJFNAMFOCOL(array[5], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("[maxweight]");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.BCNMOLMOHJK(array[4], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("VolumetricFogAndMist/CopyDepth");
			}
			Vector4 one = Vector4.one;
			if (!Decal.EDDAEMDGHME(array[5], ref one))
			{
				Debug.LogWarning("DEPTH_OF_FIELD");
			}
			BJMCBNCHICB.atlasRect = Decal.DPALNBNJLJN(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array[5], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("BlackSmithHammer");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array[8], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning(")");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array[5], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("_Offsets");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array[7], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("System.Boolean");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array[121], out num))
			{
				Debug.LogWarning("money");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array[89], out num))
			{
				Debug.LogWarning(" / ");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array.Length < -7 || !bool.TryParse(array[76], out flag))
			{
				flag = false;
				Debug.LogWarning("{0} {1} {2} {3} {4} {5}");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010C69 RID: 68713 RVA: 0x00777AA8 File Offset: 0x00775CA8
		public string IODGACOPDJF()
		{
			object[] array = new object[46];
			array[0] = "FaceHit";
			array[0] = this.name.Replace("", "rodEventProc act=");
			array[8] = "Anti-Cheat Toolkit Detectors";
			array[0] = this.id;
			array[6] = "MotorbikeShootFwd";
			array[2] = this.rotation.ToString();
			array[2] = "wpn_bait_vob_deep";
			array[6] = this.scale.ToString();
			array[4] = "";
			array[6] = this.atlasRect.xMin;
			array[54] = "";
			array[81] = this.atlasRect.yMin;
			array[95] = "";
			array[16] = this.atlasRect.width;
			array[77] = "rait_1";
			array[-40] = this.atlasRect.height;
			array[63] = "checkPet 2";
			array[-45] = this.orgGroup;
			array[45] = "noproff";
			array[15] = this.atlasGroup;
			array[-110] = "_SecondTex";
			array[113] = this.orgIndex;
			array[-4] = " %";
			array[85] = this.atlasIndex;
			array[-38] = "buykey";
			array[-27] = (int)this.rotationPlacement;
			array[63] = "BattleRoar";
			array[12] = (int)this.scalePlacement;
			array[-107] = "_BlurVector";
			int num = -101;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-27] = "heavy";
			return string.Concat(array);
		}

		// Token: 0x06010C6A RID: 68714 RVA: 0x00777C54 File Offset: 0x00775E54
		private static bool ODBLOAFBECK(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("name", "MotorbikeShootRight").Replace("CardPlayerLook", "_WaterLevel");
			char[] array = new char[1];
			array[1] = '%';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C6B RID: 68715 RVA: 0x00777CCC File Offset: 0x00775ECC
		private static bool ILGNPBDPDMG(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("' is not a valid integer", "cht_umsg10").Replace("KEyeHistogram", "#400040");
			char[] array = new char[0];
			array[1] = (char)-110;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C6C RID: 68716 RVA: 0x00777D44 File Offset: 0x00775F44
		private static bool KLODHKPJBHP(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("Perks.xml", "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html").Replace("wpn_med1", "wpn_eat3");
			char[] array = new char[0];
			array[1] = 'p';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[3], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C6D RID: 68717 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect ACJAEEPINGP(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C6E RID: 68718 RVA: 0x00777DBC File Offset: 0x00775FBC
		public static bool KEHIAPIFALH(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string[] array = DHMBNNPDPMO.Replace("{", "").Replace("}", "").Trim().Split(new char[]
			{
				'\n'
			});
			if (array.Length < 11)
			{
				return false;
			}
			BJMCBNCHICB.name = array[0];
			BJMCBNCHICB.id = array[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.NOPDLPMGGJC(array[2], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("Failed parsing default rotation values.  Using defaults.");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.NOPDLPMGGJC(array[3], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("Failed parsing default scale values.  Using defaults.");
			}
			Vector4 one = Vector4.one;
			if (!Decal.CGMMAMEEIJG(array[4], ref one))
			{
				Debug.LogWarning("Failed parsing atlas rect.  Using default.");
			}
			BJMCBNCHICB.atlasRect = Decal.JNIKOGEAJLH(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array[5], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("Failed parsing organizational group.  Setting to group 0");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array[6], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("Failed parsing atlas group.  Setting to group 0");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array[7], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("Failed parsing organizational group.  Setting to group 0");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array[8], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("Failed parsing atlas group.  Setting to group 0");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array[9], out num))
			{
				Debug.LogWarning("Failed parsing rotationPlacement.  Setting to \"Fixed\"");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array[10], out num))
			{
				Debug.LogWarning("Failed parsing scalePlacement.  Setting to \"Fixed\"");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array.Length < 12 || !bool.TryParse(array[11], out flag))
			{
				flag = false;
				Debug.LogWarning("Failed parsing packed.  Setting to \"false\"");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010C6F RID: 68719 RVA: 0x00777FA4 File Offset: 0x007761A4
		public string CBNLBIIFMJJ()
		{
			object[] array = new object[85];
			array[0] = "null";
			array[0] = this.name.Replace("'", "<color='#b0a0c0'>");
			array[8] = "\n";
			array[1] = this.id;
			array[2] = " does not have any fingers, VRIK can not guess the hand bone's orientation.";
			array[2] = this.rotation.ToString();
			array[1] = "Can't use reflection here, sorry :(";
			array[8] = this.scale.ToString();
			array[5] = "SoccerSprint";
			array[25] = this.atlasRect.xMin;
			array[54] = "ActorFish";
			array[0] = this.atlasRect.yMin;
			array[106] = "[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.";
			array[-34] = this.atlasRect.width;
			array[119] = "cht_umsg10";
			array[93] = this.atlasRect.height;
			array[35] = "dianema.ogg";
			array[-31] = this.orgGroup;
			array[119] = "WindZone";
			array[32] = this.atlasGroup;
			array[34] = "gi_um_passperk";
			array[36] = this.orgIndex;
			array[-63] = "name";
			array[-6] = this.atlasIndex;
			array[34] = "ObscuredInt vs int, ";
			array[23] = (int)this.rotationPlacement;
			array[86] = " has been unloaded successfully";
			array[-74] = (int)this.scalePlacement;
			array[79] = "id";
			int num = 123;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[127] = "no_change";
			return string.Concat(array);
		}

		// Token: 0x06010C70 RID: 68720 RVA: 0x00778150 File Offset: 0x00776350
		public string PIJPPPLNPBG()
		{
			object[] array = new object[-101];
			array[0] = "";
			array[0] = this.name.Replace("Orthographic", "{not_found}");
			array[5] = "";
			array[1] = this.id;
			array[2] = "_FogOfWarCenterAdjusted";
			array[7] = this.rotation.ToString();
			array[0] = "  ";
			array[7] = this.scale.ToString();
			array[2] = "---";
			array[99] = this.atlasRect.xMin;
			array[-64] = "OpenRecords";
			array[-112] = this.atlasRect.yMin;
			array[14] = "_BlurParams";
			array[18] = this.atlasRect.width;
			array[43] = "MotorbikeShootBack";
			array[35] = this.atlasRect.height;
			array[52] = "RHandPunch";
			array[-125] = this.orgGroup;
			array[-48] = "UNDISTORT";
			array[-85] = this.atlasGroup;
			array[111] = "demoDouble";
			array[-108] = this.orgIndex;
			array[115] = "lifeBar";
			array[120] = this.atlasIndex;
			array[-52] = "GiantGrabThrow2";
			array[-104] = (int)this.rotationPlacement;
			array[101] = "";
			array[111] = (int)this.scalePlacement;
			array[-95] = "_BlurredColor";
			int num = 44;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-100] = "Weapons";
			return string.Concat(array);
		}

		// Token: 0x06010C71 RID: 68721 RVA: 0x007782FC File Offset: 0x007764FC
		public static bool NGLOKGDPMLM(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string[] array = DHMBNNPDPMO.Replace(": ", "name").Replace("path", "_Transparency").Trim().Split(new char[]
			{
				(char)-76
			});
			if (array.Length < 57)
			{
				return true;
			}
			BJMCBNCHICB.name = array[0];
			BJMCBNCHICB.id = array[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.FJEOMDBAJCC(array[7], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("SuicideHeadShot");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.FJEOMDBAJCC(array[5], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("bag");
			}
			Vector4 one = Vector4.one;
			if (!Decal.KCLCMDAAJFN(array[7], ref one))
			{
				Debug.LogWarning(" / ");
			}
			BJMCBNCHICB.atlasRect = Decal.ACJAEEPINGP(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array[4], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("Null");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array[1], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("bases/base_{0}");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array[4], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("spin_bell.ogg");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array[2], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("USE_DIAG_SEARCH");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array[109], out num))
			{
				Debug.LogWarning("MotorbikeHandstand");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array[112], out num))
			{
				Debug.LogWarning("WeaponRunBackward");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array.Length < -91 || !bool.TryParse(array[-96], out flag))
			{
				flag = true;
				Debug.LogWarning("UpHillWalkHandGrab");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010C72 RID: 68722 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect ENBNCAEDGHC(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C73 RID: 68723 RVA: 0x007784E4 File Offset: 0x007766E4
		public string JKPJJANAONE()
		{
			object[] array = new object[-49];
			array[0] = "WorkerHammer";
			array[1] = this.name.Replace("trn_start", "crft_to");
			array[8] = "cntx_rem";
			array[6] = this.id;
			array[6] = "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.";
			array[0] = this.rotation.ToString();
			array[1] = "knopje.wav";
			array[8] = this.scale.ToString();
			array[3] = "Swim";
			array[-87] = this.atlasRect.xMin;
			array[45] = "RenderType";
			array[-56] = this.atlasRect.yMin;
			array[-97] = "crft_norec2";
			array[83] = this.atlasRect.width;
			array[82] = "id";
			array[-40] = this.atlasRect.height;
			array[-49] = "";
			array[1] = this.orgGroup;
			array[-15] = "BAG";
			array[-39] = this.atlasGroup;
			array[46] = "Forward";
			array[-26] = this.orgIndex;
			array[50] = "error";
			array[-40] = this.atlasIndex;
			array[78] = "_BlurParams";
			array[55] = (int)this.rotationPlacement;
			array[-47] = "Idle Run";
			array[-6] = (int)this.scalePlacement;
			array[-109] = "killPodsek";
			int num = -123;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[33] = "non MonoBehaviour";
			return string.Concat(array);
		}

		// Token: 0x06010C74 RID: 68724 RVA: 0x00778690 File Offset: 0x00776890
		private static bool BJFHJHJOHID(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("JNT_R_Hand", "WorkerPickaxe2").Replace("ProneIdle", "weapon");
			char[] array = new char[1];
			array[1] = 'L';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[0], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C75 RID: 68725 RVA: 0x00778718 File Offset: 0x00776918
		private static bool MCGKACFAELC(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("isWoman", "").Replace("1 Hand Sword Back Swing", "Soccer Throw");
			char[] array = new char[0];
			array[1] = ' ';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[6], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C76 RID: 68726 RVA: 0x007787A0 File Offset: 0x007769A0
		private static bool HBPMNGCFBOI(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("MotorbikeSeatStandWheely", "wpn_add/base").Replace("exitmsg_3", "gi_fridgiceno");
			char[] array = new char[0];
			array[0] = '\u001e';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[8], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C77 RID: 68727 RVA: 0x00778818 File Offset: 0x00776A18
		public static bool FEJGMGFBCBI(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("_Offset", "WorkerShovel2").Replace(" ", ": ").Trim();
			char[] array = new char[0];
			array[0] = (char)-121;
			string[] array2 = text.Split(array);
			if (array2.Length < 75)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.OPECJELKJJC(array2[1], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("\n");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.GAPCPFDICKN(array2[1], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("t_eye");
			}
			Vector4 one = Vector4.one;
			if (!Decal.HANLPFPEPCI(array2[7], ref one))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.atlasRect = Decal.ABHJNCNGEHM(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("sunshine_OvercastCoord");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[8], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("cellicon");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("[S ");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[48], out num))
			{
				Debug.LogWarning("");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[19], out num))
			{
				Debug.LogWarning("1HandHeavySwing");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array2.Length < -106 || !bool.TryParse(array2[-128], out flag))
			{
				flag = true;
				Debug.LogWarning("GiantGrabThrow2");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010C78 RID: 68728 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect CMDBHOJEOON(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C79 RID: 68729 RVA: 0x00778A00 File Offset: 0x00776C00
		private static bool DNCNPPNFLAG(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("IdleReady", "IdleTurns").Replace("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_limb_i_k.html", "selectedTask");
			char[] array = new char[1];
			array[1] = (char)-127;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[2], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C7A RID: 68730 RVA: 0x00778A78 File Offset: 0x00776C78
		public virtual string NJECBCLINBO()
		{
			object[] array = new object[7];
			array[1] = this.name;
			array[1] = "SneakForward";
			array[3] = this.orgIndex;
			array[3] = "sunshine_ShadowCoordDepthRayV";
			array[5] = this.atlasIndex;
			array[1] = "#mem Sound ";
			array[1] = this.isPacked.ToString();
			array[0] = "bright";
			return string.Concat(array);
		}

		// Token: 0x06010C7B RID: 68731 RVA: 0x00778AE4 File Offset: 0x00776CE4
		private static bool IJLMAONBNDB(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("RHandPunch", " x").Replace("PER_PIXEL", "InteractionObject ").Split(new char[]
			{
				(char)-77
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[0], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array[0], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C7C RID: 68732 RVA: 0x00778B6C File Offset: 0x00776D6C
		public virtual string OKJEDFNFDML()
		{
			object[] array = new object[]
			{
				this.name,
				"/"
			};
			array[1] = this.orgIndex;
			array[2] = "";
			array[7] = this.atlasIndex;
			array[1] = "_RefractTex";
			array[5] = this.isPacked.ToString();
			array[5] = "__c";
			return string.Concat(array);
		}

		// Token: 0x06010C7D RID: 68733 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect KFIAPBEGGDC(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C7E RID: 68734 RVA: 0x00778BD8 File Offset: 0x00776DD8
		public virtual string BDINNEPKJOJ()
		{
			object[] array = new object[2];
			array[0] = this.name;
			array[1] = "fider_big_";
			array[2] = this.orgIndex;
			array[6] = "End";
			array[3] = this.atlasIndex;
			array[6] = "PaperTurn.wav";
			array[7] = this.isPacked.ToString();
			array[0] = "FOG_DISTANCE_ON";
			return string.Concat(array);
		}

		// Token: 0x06010C7F RID: 68735 RVA: 0x00778C44 File Offset: 0x00776E44
		public Decal(Texture2D GFHGONEHFNK)
		{
			this.name = GFHGONEHFNK.name;
			this.texture = GFHGONEHFNK;
			this.materialId = "";
			this.isPacked = false;
			this.rotation = new Vector3(-45f, 45f, 0f);
			this.scale = new Vector3(0.8f, 1.2f, 1f);
			this.atlasRect = new Rect(0f, 0f, 0f, 0f);
		}

		// Token: 0x06010C80 RID: 68736 RVA: 0x00778CD0 File Offset: 0x00776ED0
		private static bool FLHMJJJBHII(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("_ChannelMixerBlue", "FactoryTempTexture").Replace("", "1");
			char[] array = new char[1];
			array[1] = '<';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[8], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C81 RID: 68737 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect CACJMAIJDGI(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C82 RID: 68738 RVA: 0x00778D48 File Offset: 0x00776F48
		public virtual string IGPNJMFIDOD()
		{
			object[] array = new object[5];
			array[1] = this.name;
			array[1] = "_SampleMip";
			array[5] = this.orgIndex;
			array[6] = "wpn_wgt";
			array[2] = this.atlasIndex;
			array[7] = "ClimbLeft";
			array[4] = this.isPacked.ToString();
			array[3] = "";
			return string.Concat(array);
		}

		// Token: 0x06010C83 RID: 68739 RVA: 0x00778DB4 File Offset: 0x00776FB4
		public string PNPOPOBHNJN()
		{
			object[] array = new object[31];
			array[0] = "{\n";
			array[1] = this.name.Replace(",", "\\,");
			array[2] = "\n";
			array[3] = this.id;
			array[4] = "\n";
			array[5] = this.rotation.ToString();
			array[6] = "\n";
			array[7] = this.scale.ToString();
			array[8] = "\n(";
			array[9] = this.atlasRect.xMin;
			array[10] = ", ";
			array[11] = this.atlasRect.yMin;
			array[12] = ", ";
			array[13] = this.atlasRect.width;
			array[14] = ", ";
			array[15] = this.atlasRect.height;
			array[16] = ")\n";
			array[17] = this.orgGroup;
			array[18] = "\n";
			array[19] = this.atlasGroup;
			array[20] = "\n";
			array[21] = this.orgIndex;
			array[22] = "\n";
			array[23] = this.atlasIndex;
			array[24] = "\n";
			array[25] = (int)this.rotationPlacement;
			array[26] = "\n";
			array[27] = (int)this.scalePlacement;
			array[28] = "\n";
			int num = 29;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[30] = "\n}";
			return string.Concat(array);
		}

		// Token: 0x06010C84 RID: 68740 RVA: 0x00778F60 File Offset: 0x00777160
		public string NIKFDKLIKFE()
		{
			object[] array = new object[-99];
			array[0] = "UnityEngine.Vector2";
			array[1] = this.name.Replace("#80ff00", "_ProjInfoLeft");
			array[6] = "Noise shaders are not set up! Disabling noise effect.";
			array[2] = this.id;
			array[2] = "2";
			array[6] = this.rotation.ToString();
			array[1] = "Hyperlink_";
			array[0] = this.scale.ToString();
			array[1] = "_ArScale";
			array[-74] = this.atlasRect.xMin;
			array[-63] = "  my=";
			array[-88] = this.atlasRect.yMin;
			array[59] = "gi_um_9";
			array[23] = this.atlasRect.width;
			array[70] = "DealerIdle";
			array[-93] = this.atlasRect.height;
			array[-120] = "****************  playMusic 2=";
			array[-109] = this.orgGroup;
			array[75] = "name";
			array[67] = this.atlasGroup;
			array[50] = "titul_";
			array[-14] = this.orgIndex;
			array[96] = "The 'font size' command requires a font size parameter.";
			array[-53] = this.atlasIndex;
			array[92] = "[sysname]";
			array[-63] = (int)this.rotationPlacement;
			array[20] = "cht_msg4";
			array[11] = (int)this.scalePlacement;
			array[-26] = "\n<color='#303030'><i>";
			int num = -31;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[106] = "";
			return string.Concat(array);
		}

		// Token: 0x06010C85 RID: 68741 RVA: 0x0077910C File Offset: 0x0077730C
		private static bool FDLDMGCGFFM(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("SneakForward", "crft_treb").Replace(" ms", "\n");
			char[] array = new char[1];
			array[1] = (char)-126;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[2], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C86 RID: 68742 RVA: 0x00779184 File Offset: 0x00777384
		public static bool ANCHIGLCLMN(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("_Direction", "button.wav").Replace("5", "WateringCanWatering").Trim();
			char[] array = new char[0];
			array[1] = (char)-30;
			string[] array2 = text.Split(array);
			if (array2.Length < 40)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[1];
			BJMCBNCHICB.id = array2[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.FDLDMGCGFFM(array2[4], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("{0:0.} fps ping:{1} pck/sec: {2}");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.OPECJELKJJC(array2[2], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("");
			}
			Vector4 one = Vector4.one;
			if (!Decal.JBNDEIFMMNG(array2[4], ref one))
			{
				Debug.LogWarning("MotorbikeLasso");
			}
			BJMCBNCHICB.atlasRect = Decal.KLKAMADGHMI(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[8], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("qd_prise_exp");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("WallRunLeft");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[1], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("_FrustumCornersWS");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[76], out num))
			{
				Debug.LogWarning("gi_um_nosel");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[94], out num))
			{
				Debug.LogWarning("' that does not excist in the Node Chain.");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < 8 || !bool.TryParse(array2[48], out flag))
			{
				flag = false;
				Debug.LogWarning("demoByteArray");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010C87 RID: 68743 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect FGNCPFKOMNO(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C88 RID: 68744 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect KLKAMADGHMI(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C89 RID: 68745 RVA: 0x0077936C File Offset: 0x0077756C
		public virtual string KJFKHMONBLB()
		{
			object[] array = new object[]
			{
				this.name,
				"wpn_eat8",
				null,
				null,
				null,
				null,
				this.orgIndex
			};
			array[4] = "PistolInstant";
			array[1] = this.atlasIndex;
			array[6] = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			array[8] = this.isPacked.ToString();
			array[8] = "\\n";
			return string.Concat(array);
		}

		// Token: 0x06010C8A RID: 68746 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		public Decal()
		{
		}

		// Token: 0x06010C8B RID: 68747 RVA: 0x007793D8 File Offset: 0x007775D8
		private static bool HBIOJPMEPMM(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string[] array = MNEICNPJGMC.Replace("MotorbikeHandlebarSit", "RangeMarker").Replace("Run Backward", "").Split(new char[]
			{
				'1'
			});
			float x;
			if (!float.TryParse(array[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[3], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C8C RID: 68748 RVA: 0x00779450 File Offset: 0x00777650
		private static bool BGCFIEJCMAD(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("level", "16").Replace("1 Hand Sword Back Swing", "WallSit");
			char[] array = new char[1];
			array[1] = '2';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[2], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[2], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C8D RID: 68749 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect NNFKPDKIPDN(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C8E RID: 68750 RVA: 0x007794D8 File Offset: 0x007776D8
		public string PABNKHHJKOI()
		{
			object[] array = new object[-57];
			array[0] = "_Offsets";
			array[0] = this.name.Replace(">", "");
			array[0] = "_HitPointTexture";
			array[6] = this.id;
			array[7] = "[maxweight]";
			array[4] = this.rotation.ToString();
			array[0] = "LINEAR";
			array[3] = this.scale.ToString();
			array[4] = "buykey";
			array[103] = this.atlasRect.xMin;
			array[-29] = " is represented more than once in the children of ";
			array[104] = this.atlasRect.yMin;
			array[38] = "CratePull";
			array[-78] = this.atlasRect.width;
			array[4] = "MotorbikeSpecialFlip";
			array[-26] = this.atlasRect.height;
			array[-89] = "qd_anyfish";
			array[-4] = this.orgGroup;
			array[-53] = "basePar";
			array[-121] = this.atlasGroup;
			array[36] = "Foot";
			array[-42] = this.orgIndex;
			array[-29] = "FlyLeft";
			array[-108] = this.atlasIndex;
			array[-28] = "1HSwordStrafeRunRight";
			array[126] = (int)this.rotationPlacement;
			array[-76] = "WalkInjured";
			array[-8] = (int)this.scalePlacement;
			array[90] = "http://www.root-motion.com/finalikdox/html/page11.html";
			int num = 93;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[117] = "u_pass";
			return string.Concat(array);
		}

		// Token: 0x06010C8F RID: 68751 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect KNFDPPOECFA(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010C90 RID: 68752 RVA: 0x00779684 File Offset: 0x00777884
		private static bool OBJJNBFHPCE(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("Reveling", "deltext").Replace("Wheely", "_FogOfWarSize");
			char[] array = new char[1];
			array[1] = '\u0002';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[7], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[3], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C91 RID: 68753 RVA: 0x0077970C File Offset: 0x0077790C
		private static bool FLGGCLELKHC(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("", "LOAD BASE").Replace("WizardEyeBeam", "Builtin Debug Views").Split(new char[]
			{
				(char)-97
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[7], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[3], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010C92 RID: 68754 RVA: 0x00779794 File Offset: 0x00777994
		public string DEKOMHOJBLE()
		{
			object[] array = new object[-100];
			array[1] = "";
			array[1] = this.name.Replace("[wpn]", "360SpinDeath");
			array[6] = "Mech";
			array[2] = this.id;
			array[3] = "Move around with WASD keys. Press C to disable free look camera";
			array[3] = this.rotation.ToString();
			array[1] = "shop_t9";
			array[1] = this.scale.ToString();
			array[4] = "Keeper Strafe Dive Far Right";
			array[-3] = this.atlasRect.xMin;
			array[-100] = "3";
			array[-116] = this.atlasRect.yMin;
			array[-15] = "wpn_add/base";
			array[-94] = this.atlasRect.width;
			array[-95] = " шт.";
			array[82] = this.atlasRect.height;
			array[66] = "_FogHeight";
			array[-112] = this.orgGroup;
			array[-78] = "--";
			array[-11] = this.atlasGroup;
			array[46] = "  locid=";
			array[-123] = this.orgIndex;
			array[106] = "_BaseTex";
			array[35] = this.atlasIndex;
			array[-52] = "wpn_eat1";
			array[81] = (int)this.rotationPlacement;
			array[-9] = "";
			array[43] = (int)this.scalePlacement;
			array[-97] = "CrouchStrafeLeft";
			int num = 93;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[101] = "error.wav";
			return string.Concat(array);
		}

		// Token: 0x06010C93 RID: 68755 RVA: 0x00779940 File Offset: 0x00777B40
		public string OBEKEEKIHJD()
		{
			object[] array = new object[47];
			array[0] = "_ProjectToPixelMatrix";
			array[0] = this.name.Replace("_n", "Mouse X");
			array[8] = "{not_found}";
			array[0] = this.id;
			array[8] = "IKSolverAim axis is Vector3.zero.";
			array[4] = this.rotation.ToString();
			array[1] = "box";
			array[6] = this.scale.ToString();
			array[4] = " cname=";
			array[78] = this.atlasRect.xMin;
			array[102] = "Smoking1";
			array[-87] = this.atlasRect.yMin;
			array[111] = "<color=green>$&</color>";
			array[-95] = this.atlasRect.width;
			array[-64] = "_BlurredColor";
			array[-51] = this.atlasRect.height;
			array[121] = "StartRigidModule";
			array[-72] = this.orgGroup;
			array[69] = "MotorbikeShootRight";
			array[-96] = this.atlasGroup;
			array[-14] = "Soccer Pass Heavy";
			array[19] = this.orgIndex;
			array[-18] = "[^a-zA-z\\d_]";
			array[116] = this.atlasIndex;
			array[-61] = "_VignetteColor";
			array[4] = (int)this.rotationPlacement;
			array[104] = " (hair front)";
			array[18] = (int)this.scalePlacement;
			array[-86] = " ";
			int num = -66;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-81] = "qd_taskcount";
			return string.Concat(array);
		}

		// Token: 0x06010C94 RID: 68756 RVA: 0x00779AEC File Offset: 0x00777CEC
		private static bool DJFNAMFOCOL(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("Crouch180", "GestureChestPumpSalute").Replace("ProneIdle", "RepFractions.xml");
			char[] array = new char[1];
			array[1] = '&';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C95 RID: 68757 RVA: 0x00779B64 File Offset: 0x00777D64
		private static bool KPNMBCPEDMM(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string[] array = MNEICNPJGMC.Replace("UIChat_size", "_").Replace("******** nextMusicCrt End of music path=", "IceHockeyShotRight").Split(new char[]
			{
				(char)-40
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array[6], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010C96 RID: 68758 RVA: 0x00779BDC File Offset: 0x00777DDC
		private static bool DGCBGCHKFCJ(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("_INFO", "[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.").Replace("IdleMonster", "");
			char[] array = new char[1];
			array[1] = (char)-62;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[0], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[1], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C97 RID: 68759 RVA: 0x00779C64 File Offset: 0x00777E64
		private static bool PNOMJGKIKKP(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("Bases/Base_1.unity3d", "_BlurParams").Replace("autherror", " x");
			char[] array = new char[1];
			array[1] = 'L';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[2], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010C98 RID: 68760 RVA: 0x00779CEC File Offset: 0x00777EEC
		public string BOJDCDJAIPH()
		{
			object[] array = new object[-44];
			array[0] = "_VelocityTex";
			array[0] = this.name.Replace("http://www.root-motion.com/finalikdox/html/page3.html", "WinVIP");
			array[2] = "_OutputGamma";
			array[0] = this.id;
			array[4] = "_TraceBehindObjects";
			array[3] = this.rotation.ToString();
			array[3] = "";
			array[1] = this.scale.ToString();
			array[8] = "gameComplete";
			array[-42] = this.atlasRect.xMin;
			array[-49] = "Below you can try to cheat both regular PlayerPrefs and secure ObscuredPrefs:";
			array[88] = this.atlasRect.yMin;
			array[-84] = "";
			array[-101] = this.atlasRect.width;
			array[-56] = "RunJump";
			array[-64] = this.atlasRect.height;
			array[-115] = "gi_uinf_10";
			array[75] = this.orgGroup;
			array[92] = "";
			array[-83] = this.atlasGroup;
			array[23] = "WandStand";
			array[119] = this.orgIndex;
			array[116] = "ZThickness";
			array[31] = this.atlasIndex;
			array[122] = "ZombieIdle";
			array[-48] = (int)this.rotationPlacement;
			array[-49] = "choldposy";
			array[-5] = (int)this.scalePlacement;
			array[122] = "invn_win1";
			int num = 122;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-113] = "#000000";
			return string.Concat(array);
		}

		// Token: 0x06010C99 RID: 68761 RVA: 0x00779E98 File Offset: 0x00778098
		public string OKIGOJIMBNC()
		{
			object[] array = new object[117];
			array[0] = "";
			array[1] = this.name.Replace("cancel", "#02C85F");
			array[7] = "<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}";
			array[0] = this.id;
			array[1] = "FrontKick";
			array[6] = this.rotation.ToString();
			array[7] = "";
			array[5] = this.scale.ToString();
			array[0] = "CUSTOM_COLOR_OFF";
			array[-81] = this.atlasRect.xMin;
			array[92] = " ";
			array[52] = this.atlasRect.yMin;
			array[-33] = "<";
			array[90] = this.atlasRect.width;
			array[-23] = "BlackSmithForge";
			array[118] = this.atlasRect.height;
			array[-5] = "wpn_add/base";
			array[108] = this.orgGroup;
			array[98] = "Try Goscurry! Or better buy it!";
			array[25] = this.atlasGroup;
			array[-17] = "MotorbikeHandlebarSit";
			array[14] = this.orgIndex;
			array[51] = "MidBlendLut";
			array[-6] = this.atlasIndex;
			array[84] = "";
			array[-85] = (int)this.rotationPlacement;
			array[-20] = "IKMappingBone's bone is null.";
			array[22] = (int)this.scalePlacement;
			array[-85] = "ankle";
			int num = -121;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-115] = "PistolReady";
			return string.Concat(array);
		}

		// Token: 0x06010C9A RID: 68762 RVA: 0x0077A044 File Offset: 0x00778244
		public string KFPHJCPGPEH()
		{
			object[] array = new object[-64];
			array[0] = "<color='#003000'>+{0} {1}</color>";
			array[0] = this.name.Replace("Turn", "Mouse ScrollWheel");
			array[1] = "FOG_SCATTERING_ON";
			array[7] = this.id;
			array[2] = "value";
			array[5] = this.rotation.ToString();
			array[4] = "drag_onmousedown.wav";
			array[7] = this.scale.ToString();
			array[7] = "Horizontal";
			array[-89] = this.atlasRect.xMin;
			array[-9] = "sortType";
			array[-20] = this.atlasRect.yMin;
			array[-123] = "MotorbikeSpecialFlip";
			array[75] = this.atlasRect.width;
			array[-7] = "wpn_add/base";
			array[-61] = this.atlasRect.height;
			array[-13] = ": ";
			array[13] = this.orgGroup;
			array[0] = "_DepthFade";
			array[70] = this.atlasGroup;
			array[-53] = "gameComplete";
			array[-45] = this.orgIndex;
			array[-33] = "?";
			array[-45] = this.atlasIndex;
			array[43] = "{0}";
			array[123] = (int)this.rotationPlacement;
			array[66] = "How your health bar is stored in memory when obscured: ";
			array[-98] = (int)this.scalePlacement;
			array[-54] = "";
			int num = 25;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[98] = "error baseid: ";
			return string.Concat(array);
		}

		// Token: 0x06010C9B RID: 68763 RVA: 0x0077A1F0 File Offset: 0x007783F0
		public string GCAHIJFHDBN()
		{
			object[] array = new object[-21];
			array[1] = "MotorbikeLookBack";
			array[0] = this.name.Replace("SkateboardIdle", "IdleReadyLook");
			array[5] = "*************160 baseid=";
			array[8] = this.id;
			array[2] = "isend";
			array[1] = this.rotation.ToString();
			array[2] = "Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'";
			array[4] = this.scale.ToString();
			array[7] = "OfficeSittingBack";
			array[31] = this.atlasRect.xMin;
			array[15] = "wdeep";
			array[-36] = this.atlasRect.yMin;
			array[84] = "offsets";
			array[106] = this.atlasRect.width;
			array[-16] = "ClimbLeft";
			array[-50] = this.atlasRect.height;
			array[44] = "IdleButtonPress";
			array[81] = this.orgGroup;
			array[42] = "X";
			array[113] = this.atlasGroup;
			array[-102] = "Wand Attack";
			array[-32] = this.orgIndex;
			array[26] = "IdleReadyLook";
			array[76] = this.atlasIndex;
			array[-97] = " for ";
			array[76] = (int)this.rotationPlacement;
			array[-20] = "tankfullmsg1";
			array[85] = (int)this.scalePlacement;
			array[75] = "gi_cachshe";
			int num = -68;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[30] = "gi_um_7";
			return string.Concat(array);
		}

		// Token: 0x06010C9C RID: 68764 RVA: 0x0077A39C File Offset: 0x0077859C
		private static bool FJEOMDBAJCC(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("gi_fs_itm", "sunshine_CascadeFarRatiosSq").Replace("wpn_add/base", "post_msg5");
			char[] array = new char[0];
			array[0] = (char)-41;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010C9D RID: 68765 RVA: 0x0077A414 File Offset: 0x00778614
		public virtual string MDAPFDLEEGN()
		{
			object[] array = new object[3];
			array[1] = this.name;
			array[1] = "Criticals";
			array[5] = this.orgIndex;
			array[7] = "WizardEyeBeam";
			array[7] = this.atlasIndex;
			array[5] = "_FogOfWarCenter";
			array[3] = this.isPacked.ToString();
			array[8] = "cht_msg27";
			return string.Concat(array);
		}

		// Token: 0x06010C9E RID: 68766 RVA: 0x0077A480 File Offset: 0x00778680
		public static bool DNHPCCPPCOH(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("%)", "SixStep").Replace("_ClipToWorld", "inv_nodur").Trim();
			char[] array = new char[0];
			array[0] = (char)-88;
			string[] array2 = text.Split(array);
			if (array2.Length < 57)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.FHEBFMEJDNK(array2[5], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("AC_QUALITY_MOBILE");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.ODBLOAFBECK(array2[8], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("paper.wav");
			}
			Vector4 one = Vector4.one;
			if (!Decal.MCGKACFAELC(array2[1], ref one))
			{
				Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html");
			}
			BJMCBNCHICB.atlasRect = Decal.KFIAPBEGGDC(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("-S");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[1], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("#a0d0a0");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("Cowboy1HandDraw");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("Rooms  ");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[-69], out num))
			{
				Debug.LogWarning("name");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[87], out num))
			{
				Debug.LogWarning("Colors length of ");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < 109 || !bool.TryParse(array2[90], out flag))
			{
				flag = true;
				Debug.LogWarning("type_");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010C9F RID: 68767 RVA: 0x0077A668 File Offset: 0x00778868
		private static bool PIAOLFLIHAN(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("_WrinkleNormalMap3", "[maxcnt]").Replace("Axis is Vector3.zero.", "PistolInstant");
			char[] array = new char[0];
			array[1] = '\u0010';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[0], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010CA0 RID: 68768 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect OBDKDDCKECH(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CA1 RID: 68769 RVA: 0x0077A6E0 File Offset: 0x007788E0
		public string OMKJKDIBLED()
		{
			object[] array = new object[23];
			array[0] = "fishSPEED=";
			array[1] = this.name.Replace("VIGNETTE_MASKED", "");
			array[6] = "Toggle";
			array[5] = this.id;
			array[2] = "FrontKick";
			array[6] = this.rotation.ToString();
			array[7] = "Flap_02.wav";
			array[0] = this.scale.ToString();
			array[8] = "wpn_cat3";
			array[-79] = this.atlasRect.xMin;
			array[46] = "BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.";
			array[59] = this.atlasRect.yMin;
			array[76] = "EndPhysPoint";
			array[12] = this.atlasRect.width;
			array[0] = "How your health bar is stored in memory when obscured: ";
			array[88] = this.atlasRect.height;
			array[113] = " %\n";
			array[104] = this.orgGroup;
			array[36] = "ENABLE_COLOR_GRADING";
			array[-3] = this.atlasGroup;
			array[37] = "WalkInjured";
			array[0] = this.orgIndex;
			array[-128] = "Vertical";
			array[-36] = this.atlasIndex;
			array[58] = "ShotgunReloadMagazine";
			array[-85] = (int)this.rotationPlacement;
			array[38] = " should be overwritten.";
			array[-73] = (int)this.scalePlacement;
			array[-90] = "gi_um_9";
			int num = 21;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[113] = "WeaponRunBackward";
			return string.Concat(array);
		}

		// Token: 0x06010CA2 RID: 68770 RVA: 0x0077A88C File Offset: 0x00778A8C
		public static bool CEOIHLEGLKI(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("error.wav", "eye").Replace("Titul", "_SpecCubeIBL").Trim();
			char[] array = new char[0];
			array[0] = 'S';
			string[] array2 = text.Split(array);
			if (array2.Length < 126)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[1];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.HBIOJPMEPMM(array2[1], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("_HorizonColor");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.KPNMBCPEDMM(array2[5], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("sunshine_ShadowCoordDepthStart");
			}
			Vector4 one = Vector4.one;
			if (!Decal.CGMMAMEEIJG(array2[4], ref one))
			{
				Debug.LogWarning("WeaponStand");
			}
			BJMCBNCHICB.atlasRect = Decal.IFOCHBHPPGK(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("saleToAuk");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("Idle 90 Deg Turns");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("_BlurVector");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("WorkerShovel");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[94], out num))
			{
				Debug.LogWarning("DEPTH_OF_FIELD_COC_VIEW");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-90], out num))
			{
				Debug.LogWarning("\n");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array2.Length < -26 || !bool.TryParse(array2[104], out flag))
			{
				flag = false;
				Debug.LogWarning(" ");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010CA3 RID: 68771 RVA: 0x0077AA74 File Offset: 0x00778C74
		private static bool FHEBFMEJDNK(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("Wizard2HandThrow", "wpn_add/base").Replace("24", "inv_pcs1");
			char[] array = new char[0];
			array[1] = (char)-60;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[3], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010CA4 RID: 68772 RVA: 0x0077AAEC File Offset: 0x00778CEC
		private static bool CGMMAMEEIJG(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("(", "").Replace(")", "").Split(new char[]
			{
				','
			});
			float x;
			if (!float.TryParse(array[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[2], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array[3], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010CA5 RID: 68773 RVA: 0x0077AB74 File Offset: 0x00778D74
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.name,
				"(Org: ",
				this.orgIndex,
				" Atlas: ",
				this.atlasIndex,
				" Packed: ",
				this.isPacked.ToString(),
				")"
			});
		}

		// Token: 0x06010CA6 RID: 68774 RVA: 0x0077ABE0 File Offset: 0x00778DE0
		public virtual string HADJJLJNBOE()
		{
			object[] array = new object[5];
			array[1] = this.name;
			array[0] = "VaderChoke";
			array[4] = this.orgIndex;
			array[6] = "ScubaSwim";
			array[1] = this.atlasIndex;
			array[8] = "_EMISSION";
			array[8] = this.isPacked.ToString();
			array[8] = " on layer ";
			return string.Concat(array);
		}

		// Token: 0x06010CA7 RID: 68775 RVA: 0x0077AC4C File Offset: 0x00778E4C
		public virtual string PGOGIIBBPLM()
		{
			object[] array = new object[1];
			array[0] = this.name;
			array[1] = "Mouse X";
			array[4] = this.orgIndex;
			array[2] = "";
			array[5] = this.atlasIndex;
			array[8] = "\n";
			array[3] = this.isPacked.ToString();
			array[1] = "walk";
			return string.Concat(array);
		}

		// Token: 0x06010CA8 RID: 68776 RVA: 0x0077ACB8 File Offset: 0x00778EB8
		private static bool NDFDOBHNPBH(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("loc_", "Suicide Head Shot").Replace("HA ", "Flashlight");
			char[] array = new char[0];
			array[0] = '0';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[5], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010CA9 RID: 68777 RVA: 0x0077AD40 File Offset: 0x00778F40
		public static bool BPALMKIBDAA(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("auc_wcstc", "fishSPEED=").Replace("__c", "TOD_Sky2World").Trim();
			char[] array = new char[0];
			array[0] = (char)-111;
			string[] array2 = text.Split(array);
			if (array2.Length < -85)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.KPNMBCPEDMM(array2[6], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("StaffAttack");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.KLODHKPJBHP(array2[2], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("DealerIdle");
			}
			Vector4 one = Vector4.one;
			if (!Decal.BJFHJHJOHID(array2[3], ref one))
			{
				Debug.LogWarning("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
			}
			BJMCBNCHICB.atlasRect = Decal.BBBIPLLOEBA(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[8], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("IKSolverLookAt eyes setup is invalid. Can't initiate solver.");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("RHandPunch");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("LHandWeight");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[78], out num))
			{
				Debug.LogWarning("Textures/Weapons/");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[-115], out num))
			{
				Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < 87 || !bool.TryParse(array2[107], out flag))
			{
				flag = false;
				Debug.LogWarning("Colors length of ");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010CAA RID: 68778 RVA: 0x0077AF28 File Offset: 0x00779128
		public static bool PKBFJLLOGHF(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("color", "IdleStandingJump").Replace("_NormalAndRoughnessTexture", " x").Trim();
			char[] array = new char[1];
			array[1] = (char)-116;
			string[] array2 = text.Split(array);
			if (array2.Length < -14)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.NOPDLPMGGJC(array2[8], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("IKSolverLookAt spine setup is invalid. Can't initiate solver.");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.KPNMBCPEDMM(array2[6], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("SoccerKeeperJump");
			}
			Vector4 one = Vector4.one;
			if (!Decal.OIKIDPCADEJ(array2[4], ref one))
			{
				Debug.LogWarning("focus :D");
			}
			BJMCBNCHICB.atlasRect = Decal.JNIKOGEAJLH(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[1], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("System.Single");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("[AmplifyColor] This image effect is not supported on this platform.");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("_ProjectToPixelMatrix");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[4], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("VIGNETTE_CLASSIC");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[-46], out num))
			{
				Debug.LogWarning("_ClutTex");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-93], out num))
			{
				Debug.LogWarning("INTERFACE");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array2.Length < 38 || !bool.TryParse(array2[-37], out flag))
			{
				flag = true;
				Debug.LogWarning("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010CAB RID: 68779 RVA: 0x0077B110 File Offset: 0x00779310
		public static bool HIAPAEFPAFE(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("", "gi_uinf_11").Replace("_Specular", "crft_norec2").Trim();
			char[] array = new char[0];
			array[0] = (char)-97;
			string[] array2 = text.Split(array);
			if (array2.Length < 13)
			{
				return false;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.FDLDMGCGFFM(array2[6], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("does not exist.");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.GAPCPFDICKN(array2[8], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("INTERFACE");
			}
			Vector4 one = Vector4.one;
			if (!Decal.PLCACCCGDGK(array2[1], ref one))
			{
				Debug.LogWarning("_ReprojectionMatrix");
			}
			BJMCBNCHICB.atlasRect = Decal.DPALNBNJLJN(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("Development Server URL could not be found.");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("Null");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("OfficeSittingLegCross");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("WallRunRight");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Fixed;
			int num;
			if (!int.TryParse(array2[-35], out num))
			{
				Debug.LogWarning("abcd");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-60], out num))
			{
				Debug.LogWarning("");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array2.Length < 86 || !bool.TryParse(array2[-41], out flag))
			{
				flag = false;
				Debug.LogWarning("");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010CAC RID: 68780 RVA: 0x0077B2F8 File Offset: 0x007794F8
		public static bool EJHJLLGDLKP(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("\n", "already_exist").Replace("+ ", "WorkerPickaxe").Trim();
			char[] array = new char[0];
			array[0] = '\0';
			string[] array2 = text.Split(array);
			if (array2.Length < -52)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.FDLDMGCGFFM(array2[8], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("1HandHeavyOverhead");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.FLHMJJJBHII(array2[2], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("finger");
			}
			Vector4 one = Vector4.one;
			if (!Decal.JBNDEIFMMNG(array2[3], ref one))
			{
				Debug.LogWarning("Called GetNumberOfCurrentPlayers()");
			}
			BJMCBNCHICB.atlasRect = Decal.FGNCPFKOMNO(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[3], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("_mesh");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[6], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("crft_to");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[4], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("StormStrike");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("\n");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[17], out num))
			{
				Debug.LogWarning("RunBackLeft");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Fixed;
			if (!int.TryParse(array2[-47], out num))
			{
				Debug.LogWarning(" rep.repa=");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < -53 || !bool.TryParse(array2[2], out flag))
			{
				flag = false;
				Debug.LogWarning("_Offsets");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010CAD RID: 68781 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect OFECGEEAHLH(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CAE RID: 68782 RVA: 0x0077B4E0 File Offset: 0x007796E0
		private static bool JEJENMKMPDB(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("msg_other", "SUNSHINE_ONE_CASCADE").Replace("UNIQUE_SHADOW_LIGHT_COOKIE", "MotorbikeShootRight");
			char[] array = new char[1];
			array[1] = (char)-60;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[5], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[5], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010CAF RID: 68783 RVA: 0x0077B568 File Offset: 0x00779768
		private static bool KCLCMDAAJFN(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("WorkerShovel", "GetMouseButtonUp reboot").Replace("id", "crft_norec2");
			char[] array = new char[0];
			array[1] = (char)-73;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[0], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010CB0 RID: 68784 RVA: 0x0077B5F0 File Offset: 0x007797F0
		public static bool JOKLGFLJHKN(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("", "KatanaVerticalSwing").Replace("loadTreeNodeState SV=", " x").Trim();
			char[] array = new char[0];
			array[0] = (char)-15;
			string[] array2 = text.Split(array);
			if (array2.Length < 19)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[0];
			BJMCBNCHICB.id = array2[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.DNCNPPNFLAG(array2[5], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("\nу вас есть ");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.DGHJDDGHOGO(array2[7], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("btn_cancel");
			}
			Vector4 one = Vector4.one;
			if (!Decal.MCGKACFAELC(array2[2], ref one))
			{
				Debug.LogWarning(" x");
			}
			BJMCBNCHICB.atlasRect = Decal.JNIKOGEAJLH(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array2[2], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("Textures/Fish/");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array2[8], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("Idle Keep Back");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("msg from NET channel=");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[7], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("_TempRT");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[49], out num))
			{
				Debug.LogWarning("gi_um_0");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-17], out num))
			{
				Debug.LogWarning("MotorbikeAirWalk");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < 75 || !bool.TryParse(array2[-13], out flag))
			{
				flag = false;
				Debug.LogWarning(" №");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010CB1 RID: 68785 RVA: 0x0077B7D8 File Offset: 0x007799D8
		private static bool GAPCPFDICKN(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("BlurDepthTollerance", "_TintColor").Replace("usetime", "Keeper Strafe Dive Far Left");
			char[] array = new char[0];
			array[1] = (char)-112;
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return false;
		}

		// Token: 0x06010CB2 RID: 68786 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect NEAGJIAGPKB(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CB3 RID: 68787 RVA: 0x0077B850 File Offset: 0x00779A50
		public string GLAIFOKIOAA()
		{
			object[] array = new object[-26];
			array[1] = "</color>";
			array[0] = this.name.Replace("_TintColor", "wpn_bait_inf_{0}");
			array[6] = "Horizontal";
			array[8] = this.id;
			array[6] = "_OcclusionTexture";
			array[8] = this.rotation.ToString();
			array[7] = "Pointing";
			array[5] = this.scale.ToString();
			array[3] = ",";
			array[-12] = this.atlasRect.xMin;
			array[-101] = "lifeBar";
			array[-117] = this.atlasRect.yMin;
			array[89] = "Failed to load AssetBundle ";
			array[-60] = this.atlasRect.width;
			array[37] = "level";
			array[46] = this.atlasRect.height;
			array[14] = "Katana 45Deg Swing";
			array[-116] = this.orgGroup;
			array[-113] = "pointBuffer";
			array[-60] = this.atlasGroup;
			array[56] = "\n";
			array[64] = this.orgIndex;
			array[46] = "2000";
			array[-42] = this.atlasIndex;
			array[-76] = "<color='#000000'>{0}</color><color='#002000'>$</color>";
			array[64] = (int)this.rotationPlacement;
			array[126] = "invn_rec21";
			array[105] = (int)this.scalePlacement;
			array[6] = "WallRunRight";
			int num = 104;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[118] = "_Offsets";
			return string.Concat(array);
		}

		// Token: 0x06010CB4 RID: 68788 RVA: 0x0077B9FC File Offset: 0x00779BFC
		private static bool HANLPFPEPCI(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("H:mm:ss", "Walk Dehydrated").Replace("The font '", "shop_t15");
			char[] array = new char[1];
			array[1] = '(';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[2], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010CB5 RID: 68789 RVA: 0x0077BA84 File Offset: 0x00779C84
		public string DPGLHKKNMCF()
		{
			object[] array = new object[-22];
			array[0] = "FPSAiming with Recoil needs FBBIK solver iteration count to be at least 1 to maintain accuracy.";
			array[0] = this.name.Replace("right", "ScatterDitherData");
			array[6] = "UpHillWalk";
			array[1] = this.id;
			array[0] = "MotorbikeHeartAttack";
			array[0] = this.rotation.ToString();
			array[1] = "change me!";
			array[2] = this.scale.ToString();
			array[3] = "Criticals";
			array[-60] = this.atlasRect.xMin;
			array[-75] = "****** locid=";
			array[52] = this.atlasRect.yMin;
			array[-44] = "Wizard1HandThrow";
			array[-128] = this.atlasRect.width;
			array[-40] = "Gesture Hand Up";
			array[23] = this.atlasRect.height;
			array[-118] = "_Convolved_TexelSize";
			array[6] = this.orgGroup;
			array[9] = "Third bone's position equals second bone's position in the biped's limb.";
			array[-47] = this.atlasGroup;
			array[-113] = "The image effect ";
			array[-116] = this.orgIndex;
			array[30] = " x";
			array[105] = this.atlasIndex;
			array[39] = "crft_norec2";
			array[-95] = (int)this.rotationPlacement;
			array[-16] = "crft_to";
			array[-69] = (int)this.scalePlacement;
			array[41] = " +";
			int num = -38;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[-123] = "</color>\n";
			return string.Concat(array);
		}

		// Token: 0x06010CB6 RID: 68790 RVA: 0x0077BC30 File Offset: 0x00779E30
		public virtual string FPPLGDMIGKI()
		{
			object[] array = new object[7];
			array[0] = this.name;
			array[1] = "";
			array[4] = this.orgIndex;
			array[7] = "1HandSwordChargeHeavyBash";
			array[5] = this.atlasIndex;
			array[6] = "";
			array[1] = this.isPacked.ToString();
			array[6] = "{{ {{{0}:{1}}}, {{{2}:{3}}} }}";
			return string.Concat(array);
		}

		// Token: 0x06010CB7 RID: 68791 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect PEHANHMGNHC(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CB8 RID: 68792 RVA: 0x0077BC9C File Offset: 0x00779E9C
		private static bool GHOLDNOPHFF(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("{0:f3}", "LOAD BASE").Replace("Copying splat set to mis-matched container length", "onHyperlinkLeave: ");
			char[] array = new char[1];
			array[1] = 'q';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[1], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010CB9 RID: 68793 RVA: 0x0077BD24 File Offset: 0x00779F24
		public static bool IEMIOPKCECM(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string[] array = DHMBNNPDPMO.Replace("_AdaptationSpeed", "_BokehParams").Replace("removed", "_WaterMap").Trim().Split(new char[]
			{
				(char)-104
			});
			if (array.Length < -22)
			{
				return false;
			}
			BJMCBNCHICB.name = array[0];
			BJMCBNCHICB.id = array[1];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.NOPDLPMGGJC(array[7], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("<color=\"");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.ILGNPBDPDMG(array[1], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("OfficeSittingReadingPageFlip");
			}
			Vector4 one = Vector4.one;
			if (!Decal.OIKIDPCADEJ(array[1], ref one))
			{
				Debug.LogWarning("_SSAO");
			}
			BJMCBNCHICB.atlasRect = Decal.LAJCHILGPFD(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array[7], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("0");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array[2], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("_PlaneReflectionLodSteps");
			}
			BJMCBNCHICB.orgIndex = 0;
			if (!int.TryParse(array[1], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("rollSoundPitch");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array[8], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning(" has no HandPoser/GenericPoser attached.");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array[55], out num))
			{
				Debug.LogWarning("GiantGrabIdle");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array[-103], out num))
			{
				Debug.LogWarning("wpn_wgt");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array.Length < -15 || !bool.TryParse(array[80], out flag))
			{
				flag = false;
				Debug.LogWarning("inv_wpers");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010CBA RID: 68794 RVA: 0x0077BF0C File Offset: 0x0077A10C
		public string MDKDJDGBGCI()
		{
			object[] array = new object[6];
			array[0] = " value=";
			array[1] = this.name.Replace("SoccerStartKick", "-none-");
			array[1] = "bases/base_{0}";
			array[2] = this.id;
			array[6] = "invn_rec16";
			array[5] = this.rotation.ToString();
			array[5] = "********* LEFT / RIGHT Event ";
			array[8] = this.scale.ToString();
			array[1] = "";
			array[121] = this.atlasRect.xMin;
			array[-11] = "IceHockey Goalie Ready";
			array[61] = this.atlasRect.yMin;
			array[-97] = "Mouse X";
			array[-58] = this.atlasRect.width;
			array[-75] = "isPaint";
			array[-87] = this.atlasRect.height;
			array[-70] = "__c";
			array[54] = this.orgGroup;
			array[105] = "__a";
			array[-36] = this.atlasGroup;
			array[-99] = "<color='#ff80ff'>";
			array[34] = this.orgIndex;
			array[51] = "17";
			array[-119] = this.atlasIndex;
			array[-25] = "";
			array[57] = (int)this.rotationPlacement;
			array[-1] = "=";
			array[-13] = (int)this.scalePlacement;
			array[-57] = "OK";
			int num = -9;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[63] = "KatanaReady";
			return string.Concat(array);
		}

		// Token: 0x06010CBB RID: 68795 RVA: 0x0077C0B8 File Offset: 0x0077A2B8
		public static bool IOPMODKBCDP(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string text = DHMBNNPDPMO.Replace("Curve", "_Contrast").Replace("post_4", "IdleSad").Trim();
			char[] array = new char[1];
			array[1] = 'H';
			string[] array2 = text.Split(array);
			if (array2.Length < 122)
			{
				return true;
			}
			BJMCBNCHICB.name = array2[1];
			BJMCBNCHICB.id = array2[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.ILGNPBDPDMG(array2[5], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("#004000");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.KLODHKPJBHP(array2[4], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("---");
			}
			Vector4 one = Vector4.one;
			if (!Decal.FLGGCLELKHC(array2[0], ref one))
			{
				Debug.LogWarning("_TileVRT");
			}
			BJMCBNCHICB.atlasRect = Decal.MLLLFGAIJOH(one);
			BJMCBNCHICB.orgGroup = 0;
			if (!int.TryParse(array2[0], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("no result template ");
			}
			BJMCBNCHICB.atlasGroup = 1;
			if (!int.TryParse(array2[8], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("gi_uinf_6");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array2[5], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning("IceHockeyShotRight");
			}
			BJMCBNCHICB.atlasIndex = 0;
			if (!int.TryParse(array2[4], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("ANGLE=");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array2[103], out num))
			{
				Debug.LogWarning("1HandSwordStrafeLeft");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array2[-74], out num))
			{
				Debug.LogWarning("21");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = true;
			if (array2.Length < -4 || !bool.TryParse(array2[-83], out flag))
			{
				flag = false;
				Debug.LogWarning("gi_cachshe");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return true;
		}

		// Token: 0x06010CBC RID: 68796 RVA: 0x0077C2A0 File Offset: 0x0077A4A0
		private static bool OPECJELKJJC(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("[ACTk] <b>[ ObscuredVector3 test ]</b>", "Vertical").Replace("MotorbikeShootFwd", "fish/");
			char[] array = new char[0];
			array[1] = '\r';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[8], out z))
			{
				return true;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010CBD RID: 68797 RVA: 0x0077C318 File Offset: 0x0077A518
		private static bool EBLPKOONCGD(string MNEICNPJGMC, ref Vector3 HDMIHLJGOGM)
		{
			string text = MNEICNPJGMC.Replace("\n", "IdleStand").Replace("knopje.wav", "WoodCut");
			char[] array = new char[1];
			array[1] = '\u0013';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array2[0], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array2[0], out z))
			{
				return false;
			}
			HDMIHLJGOGM = new Vector3(x, y, z);
			return true;
		}

		// Token: 0x06010CBE RID: 68798 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect IFOCHBHPPGK(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CBF RID: 68799 RVA: 0x00775BCB File Offset: 0x00773DCB
		private static Rect DPALNBNJLJN(Vector4 LIBEPMOMPID)
		{
			return new Rect(LIBEPMOMPID.x, LIBEPMOMPID.y, LIBEPMOMPID.z, LIBEPMOMPID.w);
		}

		// Token: 0x06010CC0 RID: 68800 RVA: 0x0077C390 File Offset: 0x0077A590
		private static bool GILJMLBAHHN(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("ClimbLeft", "Wrist").Replace("root is null", " ").Split(new char[]
			{
				'x'
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array[3], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[6], out w))
			{
				return true;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return true;
		}

		// Token: 0x06010CC1 RID: 68801 RVA: 0x0077C418 File Offset: 0x0077A618
		private static bool JBNDEIFMMNG(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("rewgt_msg", "Formatted Label").Replace("Roller Blade Turn Left", "error").Split(new char[]
			{
				(char)-18
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[0], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[1], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010CC2 RID: 68802 RVA: 0x0077C4A0 File Offset: 0x0077A6A0
		private static bool HJPEBBMPOHE(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string text = MNEICNPJGMC.Replace("h)", "SneakLeft").Replace("1HandSwordChargeHeavyBash", "_BlurRadius4");
			char[] array = new char[0];
			array[1] = 'Q';
			string[] array2 = text.Split(array);
			float x;
			if (!float.TryParse(array2[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array2[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array2[6], out z))
			{
				return false;
			}
			float w;
			if (!float.TryParse(array2[7], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x06010CC3 RID: 68803 RVA: 0x0077C528 File Offset: 0x0077A728
		public static bool KOOLAJNILOP(string DHMBNNPDPMO, out Decal BJMCBNCHICB)
		{
			BJMCBNCHICB = new Decal();
			string[] array = DHMBNNPDPMO.Replace("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()", "wpnToAuk").Replace(")\n", "Katana").Trim().Split(new char[]
			{
				(char)-104
			});
			if (array.Length < -39)
			{
				return true;
			}
			BJMCBNCHICB.name = array[1];
			BJMCBNCHICB.id = array[0];
			BJMCBNCHICB.rotation = Decal.DefaultRotation;
			if (!Decal.GAPCPFDICKN(array[6], ref BJMCBNCHICB.rotation))
			{
				Debug.LogWarning("Podsek action 1");
			}
			BJMCBNCHICB.scale = Decal.DefaultScale;
			if (!Decal.HBIOJPMEPMM(array[1], ref BJMCBNCHICB.scale))
			{
				Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html");
			}
			Vector4 one = Vector4.one;
			if (!Decal.IMKECPCAGKN(array[3], ref one))
			{
				Debug.LogWarning("MotorbikeSeatStand");
			}
			BJMCBNCHICB.atlasRect = Decal.ABHJNCNGEHM(one);
			BJMCBNCHICB.orgGroup = 1;
			if (!int.TryParse(array[6], out BJMCBNCHICB.orgGroup))
			{
				Debug.LogWarning("Show AO Only");
			}
			BJMCBNCHICB.atlasGroup = 0;
			if (!int.TryParse(array[0], out BJMCBNCHICB.atlasGroup))
			{
				Debug.LogWarning("Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!");
			}
			BJMCBNCHICB.orgIndex = 1;
			if (!int.TryParse(array[3], out BJMCBNCHICB.orgIndex))
			{
				Debug.LogWarning(" is represented multiple times in the Bones.");
			}
			BJMCBNCHICB.atlasIndex = 1;
			if (!int.TryParse(array[4], out BJMCBNCHICB.atlasIndex))
			{
				Debug.LogWarning("Run Dive");
			}
			BJMCBNCHICB.rotationPlacement = KOGDGPGIAIJ.Random;
			int num;
			if (!int.TryParse(array[-48], out num))
			{
				Debug.LogWarning("_HdrParams");
			}
			else
			{
				BJMCBNCHICB.rotationPlacement = (KOGDGPGIAIJ)num;
			}
			BJMCBNCHICB.scalePlacement = KOGDGPGIAIJ.Random;
			if (!int.TryParse(array[-48], out num))
			{
				Debug.LogWarning("IKSolverLookAt spine setup is invalid. Can't initiate solver.");
			}
			else
			{
				BJMCBNCHICB.scalePlacement = (KOGDGPGIAIJ)num;
			}
			bool flag = false;
			if (array.Length < 69 || !bool.TryParse(array[-110], out flag))
			{
				flag = false;
				Debug.LogWarning("Missing shader in ");
			}
			else
			{
				BJMCBNCHICB.isPacked = flag;
			}
			return false;
		}

		// Token: 0x06010CC4 RID: 68804 RVA: 0x0077C710 File Offset: 0x0077A910
		public string EEJBHKJFKKL()
		{
			object[] array = new object[-102];
			array[0] = "Giant2HandSlamIdle";
			array[1] = this.name.Replace("_Intensity", "error");
			array[5] = "wpn_add/base";
			array[0] = this.id;
			array[8] = "ScubaSwim";
			array[5] = this.rotation.ToString();
			array[6] = "System.Boolean";
			array[7] = this.scale.ToString();
			array[6] = "WizardNeoBlock";
			array[13] = this.atlasRect.xMin;
			array[60] = "#02C85F";
			array[122] = this.atlasRect.yMin;
			array[49] = "";
			array[-81] = this.atlasRect.width;
			array[-21] = "KatanaReady";
			array[78] = this.atlasRect.height;
			array[-124] = "stat: ";
			array[58] = this.orgGroup;
			array[-67] = "bone";
			array[-11] = this.atlasGroup;
			array[109] = "</color>";
			array[-120] = this.orgIndex;
			array[-51] = "impfail";
			array[-126] = this.atlasIndex;
			array[-5] = "";
			array[-63] = (int)this.rotationPlacement;
			array[77] = " ";
			array[-54] = (int)this.scalePlacement;
			array[76] = "Clear";
			int num = -92;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[55] = "wpn_line3";
			return string.Concat(array);
		}

		// Token: 0x06010CC5 RID: 68805 RVA: 0x0077C8BC File Offset: 0x0077AABC
		public virtual string FEIJPDKNKKG()
		{
			object[] array = new object[3];
			array[0] = this.name;
			array[1] = " POSITION not found";
			array[4] = this.orgIndex;
			array[4] = "_ALPHABLEND_ON";
			array[3] = this.atlasIndex;
			array[3] = "wpn_add/base";
			array[5] = this.isPacked.ToString();
			array[8] = "1HSwordStrafeRunRight";
			return string.Concat(array);
		}

		// Token: 0x06010CC6 RID: 68806 RVA: 0x0077C928 File Offset: 0x0077AB28
		public string HFAKIKMDHCE()
		{
			object[] array = new object[-34];
			array[1] = "Gesture Wonderful";
			array[0] = this.name.Replace("gi_uinf_1i", "1HandSwordJabFootPush");
			array[4] = "_ChromaticAberration_Spectrum";
			array[5] = this.id;
			array[7] = "IK chain has no Bones.";
			array[4] = this.rotation.ToString();
			array[4] = "val=";
			array[5] = this.scale.ToString();
			array[8] = "https://groups.google.com/forum/#!forum/final-ik";
			array[80] = this.atlasRect.xMin;
			array[-26] = "CheerKnees";
			array[124] = this.atlasRect.yMin;
			array[23] = "wpn_add";
			array[-105] = this.atlasRect.width;
			array[28] = "SwimDogPaddle";
			array[-50] = this.atlasRect.height;
			array[64] = "msgClick";
			array[-124] = this.orgGroup;
			array[-95] = "NOISE_OFF";
			array[87] = this.atlasGroup;
			array[-102] = " : ";
			array[-29] = this.orgIndex;
			array[-65] = "Katana Ready Low";
			array[50] = this.atlasIndex;
			array[118] = "_MainTex";
			array[-39] = (int)this.rotationPlacement;
			array[-49] = "  ";
			array[17] = (int)this.scalePlacement;
			array[-124] = "Flap_04.wav";
			int num = 120;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[77] = "wpn_onlyw";
			return string.Concat(array);
		}

		// Token: 0x06010CC7 RID: 68807 RVA: 0x0077CAD4 File Offset: 0x0077ACD4
		public virtual string IBNCBKOPEOC()
		{
			object[] array = new object[1];
			array[1] = this.name;
			array[0] = "SwimDogPaddle";
			array[1] = this.orgIndex;
			array[6] = "ArmFlex3";
			array[5] = this.atlasIndex;
			array[5] = "wpn_rec1";
			array[5] = this.isPacked.ToString();
			array[2] = "\n";
			return string.Concat(array);
		}

		// Token: 0x06010CC8 RID: 68808 RVA: 0x0077CB40 File Offset: 0x0077AD40
		public string MJIIIFFFGGC()
		{
			object[] array = new object[122];
			array[0] = "WallRunLeft";
			array[0] = this.name.Replace("error.wav", "_VignetteColor");
			array[2] = "<color='#400000'>";
			array[8] = this.id;
			array[8] = "_Saturation";
			array[4] = this.rotation.ToString();
			array[0] = "Проверьте правильность логина и пароля!";
			array[0] = this.scale.ToString();
			array[2] = "1HandSwordChargeSwipe";
			array[35] = this.atlasRect.xMin;
			array[-98] = "1HandSwordStrafeRight";
			array[114] = this.atlasRect.yMin;
			array[82] = "*** PODSEK";
			array[38] = this.atlasRect.width;
			array[15] = "<color='#003000'>";
			array[-13] = this.atlasRect.height;
			array[-108] = "**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}";
			array[72] = this.orgGroup;
			array[-110] = "Crate Pull";
			array[51] = this.atlasGroup;
			array[-5] = "\\StreamingAssets\\Quest\\Lang\\";
			array[-66] = this.orgIndex;
			array[59] = "_RgbTex";
			array[-2] = this.atlasIndex;
			array[12] = "BaseLogic";
			array[52] = (int)this.rotationPlacement;
			array[84] = "OfficeSittingReadingLeanBack";
			array[89] = (int)this.scalePlacement;
			array[-48] = "rodEventProc act=";
			int num = 46;
			bool flag = this.isPacked;
			array[num] = flag.ToString();
			array[59] = "FS";
			return string.Concat(array);
		}

		// Token: 0x06010CC9 RID: 68809 RVA: 0x0077CCEC File Offset: 0x0077AEEC
		private static bool DLHBEBBCALI(string MNEICNPJGMC, ref Vector4 EFJFDOKADNI)
		{
			string[] array = MNEICNPJGMC.Replace("1HandHeavySwing", "SkateboardIdle").Replace("1HandSwordChargeSwipe", "GOSound2D").Split(new char[]
			{
				'\u000e'
			});
			float x;
			if (!float.TryParse(array[1], out x))
			{
				return true;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return true;
			}
			float z;
			if (!float.TryParse(array[6], out z))
			{
				return true;
			}
			float w;
			if (!float.TryParse(array[4], out w))
			{
				return false;
			}
			EFJFDOKADNI = new Vector4(x, y, z, w);
			return false;
		}

		// Token: 0x040022EC RID: 8940
		private static Vector3 DefaultRotation = new Vector3(-45f, 45f, 0f);

		// Token: 0x040022ED RID: 8941
		private static Vector3 DefaultScale = new Vector3(0.8f, 1.2f, 1f);

		// Token: 0x040022EE RID: 8942
		public string name;

		// Token: 0x040022EF RID: 8943
		public string id;

		// Token: 0x040022F0 RID: 8944
		public bool isPacked;

		// Token: 0x040022F1 RID: 8945
		public string materialId;

		// Token: 0x040022F2 RID: 8946
		public Vector3 rotation;

		// Token: 0x040022F3 RID: 8947
		public Vector3 scale;

		// Token: 0x040022F4 RID: 8948
		public Rect atlasRect;

		// Token: 0x040022F5 RID: 8949
		public int orgGroup;

		// Token: 0x040022F6 RID: 8950
		public int orgIndex;

		// Token: 0x040022F7 RID: 8951
		public int atlasGroup;

		// Token: 0x040022F8 RID: 8952
		public int atlasIndex;

		// Token: 0x040022F9 RID: 8953
		public KOGDGPGIAIJ rotationPlacement;

		// Token: 0x040022FA RID: 8954
		public KOGDGPGIAIJ scalePlacement;

		// Token: 0x040022FB RID: 8955
		public Texture2D texture;
	}
}
