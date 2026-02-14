using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000DE RID: 222
public class TOD_Resources : MonoBehaviour
{
	// Token: 0x060028EB RID: 10475 RVA: 0x00122CD8 File Offset: 0x00120ED8
	public static Mesh NFDOHCKAPDB(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[0] = "_CosPower";
		array[1] = GDCMKLMHFLI;
		array[8] = "Roller Blade Turn Left";
		array[1] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[1];
		array2[1] = new Vector3(1176f, 1197f, 1554f);
		array2[0] = new Vector3(1454f, 1416f, 1766f);
		array2[0] = new Vector3(75f, 1176f, 1317f);
		array2[8] = new Vector3(1771f, 1993f, 582f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[1];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[]
		{
			new Vector3(595f, 1053f, 1273f),
			new Vector3(213f, 1291f, 1974f)
		};
		array4[1] = new Vector3(447f, 1333f, 1527f);
		array4[2] = new Vector3(1662f, 1479f, 1405f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[2];
		array5[0] = new Vector4(1300f, 1721f, 472f, 379f);
		array5[1] = new Vector4(1272f, 1629f, 504f, 1498f);
		array5[3] = new Vector4(1211f, 715f, 636f, 942f);
		array5[3] = new Vector4(711f, 1143f, 959f, 1531f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x00122F20 File Offset: 0x00121120
	public static Mesh HBCINDALCEL(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[7];
		array[1] = "file";
		array[0] = GDCMKLMHFLI;
		array[2] = "byte[]: {";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[2];
		array2[0] = new Vector3(1660f, 1055f, 1844f);
		array2[1] = new Vector3(1609f, 1911f, 1064f);
		array2[6] = new Vector3(640f, 1936f, 882f);
		array2[7] = new Vector3(1503f, 1429f, 1093f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[8];
		array4[0] = new Vector3(523f, 876f, 112f);
		array4[0] = new Vector3(1911f, 994f, 1944f);
		array4[7] = new Vector3(1654f, 1631f, 383f);
		array4[0] = new Vector3(764f, 632f, 1526f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[5];
		array5[0] = new Vector4(1539f, 782f, 63f, 1532f);
		array5[1] = new Vector4(80f, 134f, 391f, 336f);
		array5[6] = new Vector4(741f, 875f, 1018f, 191f);
		array5[8] = new Vector4(1830f, 717f, 1320f, 929f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x00123168 File Offset: 0x00121368
	public void BICICLGCMFD()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("1HandHeavySwing");
		this.PBDNAONCCBD = Shader.PropertyToID("donk.ogg");
		this.ICEFEJNFPNB = Shader.PropertyToID("!");
		this.DNCCNIPJJFP = Shader.PropertyToID("crft_cnt2");
		this.EPACGLABCFJ = Shader.PropertyToID("_EMISSION");
		this.CGMKIBNPFFI = Shader.PropertyToID("inv_post");
		this.CMGHEMIEACC = Shader.PropertyToID("Flap_08.wav");
		this.MIKPHLGJFKC = Shader.PropertyToID("name");
		this.PMDMDAEHDFE = Shader.PropertyToID("IdleDodgeLeft");
		this.LAOIHBNKNDC = Shader.PropertyToID("SoccerKeeperDiveStrafeFarRight");
		this.DKIOGOAGEMJ = Shader.PropertyToID("Vector3: ");
		this.LNJEDJHGDBA = Shader.PropertyToID("progress=");
		this.PCGJBGMPMPJ = Shader.PropertyToID("");
		this.LCFIPCLBNCP = Shader.PropertyToID("RunBackRight");
		this.GHENKAHBNGH = Shader.PropertyToID("OneHandSwordRun");
		this.DIMGPCEBEGE = Shader.PropertyToID("BlurXY");
		this.AHNEKMDHFKC = Shader.PropertyToID("position");
		this.IGOEANOOFFF = Shader.PropertyToID("Server is closed");
		this.OFHAIPIBDBC = Shader.PropertyToID(" ");
		this.NJIOJANKEDD = Shader.PropertyToID(" ");
		this.OEIDCFLBDAL = Shader.PropertyToID("Wizard2HandThrow");
		this.FNCBANADCBJ = Shader.PropertyToID("_Intensity");
		this.MAMMKBMCDED = Shader.PropertyToID("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
		this.ALMNFJFCEKI = Shader.PropertyToID("wpn_wgt");
		this.IHHIGFMOPHG = Shader.PropertyToID("GestureCrowdPump");
		this.CHGMOFGHPND = Shader.PropertyToID("SOURCE_GBUFFER");
		this.MNHEGFNBGBP = Shader.PropertyToID("wpn_hook1");
		this.OFNKEJPFHPM = Shader.PropertyToID("http://af-2.ru/?q=store");
		this.JHGLFOIFPNA = Shader.PropertyToID("{y}");
		this.BEAGFOMBNIE = Shader.PropertyToID("");
		this.HAOPEKACGKJ = Shader.PropertyToID("GetPoints() is not applicable to IKSolverVR.");
		this.JKPIIPGJCGL = Shader.PropertyToID("gi_cachfish");
		this.OLDFANLEEPP = Shader.PropertyToID("S");
		this.JEBEODKPNBD = Shader.PropertyToID("Failed parsing rotationPlacement.  Setting to \"Fixed\"");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_ReflectionTexture3");
		this.BIBGFHMDCOC = Shader.PropertyToID("paper.wav");
		this.PFENCNMEJGE = Shader.PropertyToID("MotorbikeLasso");
		this.NIBOHKNFDPB = Shader.PropertyToID("Idle Button Press");
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x001233D8 File Offset: 0x001215D8
	public static Mesh PFNGMGENKNH(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "";
		array[0] = GDCMKLMHFLI;
		array[7] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[8];
		array2[1] = new Vector3(3f, 836f, 1495f);
		array2[1] = new Vector3(839f, 1299f, 548f);
		array2[4] = new Vector3(1249f, 1301f, 926f);
		array2[5] = new Vector3(439f, 1520f, 1752f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[8];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[3];
		array5[0] = new Vector3(201f, 1714f, 1146f);
		array5[0] = new Vector3(1613f, 967f, 79f);
		array5[8] = new Vector3(1484f, 38f, 470f);
		array5[5] = new Vector3(1767f, 1059f, 864f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[0];
		array6[0] = new Vector4(577f, 958f, 1825f, 1228f);
		array6[0] = new Vector4(474f, 1552f, 238f, 1405f);
		array6[6] = new Vector4(525f, 844f, 1533f, 597f);
		array6[5] = new Vector4(1181f, 588f, 1293f, 1779f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x00123620 File Offset: 0x00121820
	public void AMABCOGOOPF()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("isRodInWater");
		this.PBDNAONCCBD = Shader.PropertyToID("Bottoms");
		this.ICEFEJNFPNB = Shader.PropertyToID("wpn_fid1");
		this.DNCCNIPJJFP = Shader.PropertyToID("TAA History");
		this.EPACGLABCFJ = Shader.PropertyToID("u_UniqueShadowBlockerDistanceScale");
		this.CGMKIBNPFFI = Shader.PropertyToID("fishLang.txt");
		this.CMGHEMIEACC = Shader.PropertyToID("offsets");
		this.MIKPHLGJFKC = Shader.PropertyToID("wpn_wgt");
		this.PMDMDAEHDFE = Shader.PropertyToID("wpn_bait1");
		this.LAOIHBNKNDC = Shader.PropertyToID("Katana Ninja Draw");
		this.DKIOGOAGEMJ = Shader.PropertyToID("offsets");
		this.LNJEDJHGDBA = Shader.PropertyToID("");
		this.PCGJBGMPMPJ = Shader.PropertyToID("Space reference not set.");
		this.LCFIPCLBNCP = Shader.PropertyToID("Roll");
		this.GHENKAHBNGH = Shader.PropertyToID("Mouse ScrollWheel");
		this.DIMGPCEBEGE = Shader.PropertyToID("KatanaReadyLow");
		this.AHNEKMDHFKC = Shader.PropertyToID("Circular parenting. ");
		this.IGOEANOOFFF = Shader.PropertyToID("SUNSHINE_FILTER_HARD");
		this.OFHAIPIBDBC = Shader.PropertyToID("<i><color='#202020'>");
		this.NJIOJANKEDD = Shader.PropertyToID("https://groups.google.com/forum/#!forum/final-ik");
		this.OEIDCFLBDAL = Shader.PropertyToID("1HandSwordChargeUp");
		this.FNCBANADCBJ = Shader.PropertyToID("-U");
		this.MAMMKBMCDED = Shader.PropertyToID("obscured focus oO");
		this.ALMNFJFCEKI = Shader.PropertyToID("invn_rec15");
		this.IHHIGFMOPHG = Shader.PropertyToID("Open tinfo");
		this.CHGMOFGHPND = Shader.PropertyToID("knopje.wav");
		this.MNHEGFNBGBP = Shader.PropertyToID("");
		this.OFNKEJPFHPM = Shader.PropertyToID("SneakLeft");
		this.JHGLFOIFPNA = Shader.PropertyToID("Elephant");
		this.BEAGFOMBNIE = Shader.PropertyToID("reel_type1");
		this.HAOPEKACGKJ = Shader.PropertyToID("IdleStandingJump");
		this.JKPIIPGJCGL = Shader.PropertyToID("inv_bonus");
		this.OLDFANLEEPP = Shader.PropertyToID("Here you can overview common ACTk features and try to cheat something yourself.");
		this.JEBEODKPNBD = Shader.PropertyToID("StartRigidModule");
		this.FPFCLGAHHPJ = Shader.PropertyToID("{0}-{1}={2}");
		this.BIBGFHMDCOC = Shader.PropertyToID("wpn_med2");
		this.PFENCNMEJGE = Shader.PropertyToID("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.");
		this.NIBOHKNFDPB = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/page3.html");
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x00123890 File Offset: 0x00121A90
	public void PJHMGLGBCLD()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("SpinReel.ogg");
		this.PBDNAONCCBD = Shader.PropertyToID("wpn_lvf");
		this.ICEFEJNFPNB = Shader.PropertyToID("MotorbikeSeatStandWheely");
		this.DNCCNIPJJFP = Shader.PropertyToID("Button Right Hand");
		this.EPACGLABCFJ = Shader.PropertyToID("aptek.ogg");
		this.CGMKIBNPFFI = Shader.PropertyToID("");
		this.CMGHEMIEACC = Shader.PropertyToID("WeaponRunBackward");
		this.MIKPHLGJFKC = Shader.PropertyToID("tankfullmsg1");
		this.PMDMDAEHDFE = Shader.PropertyToID("OfficeSittingEyesRub");
		this.LAOIHBNKNDC = Shader.PropertyToID("Motion Blur");
		this.DKIOGOAGEMJ = Shader.PropertyToID("");
		this.LNJEDJHGDBA = Shader.PropertyToID("name");
		this.PCGJBGMPMPJ = Shader.PropertyToID("auk_wcnt");
		this.LCFIPCLBNCP = Shader.PropertyToID(" ");
		this.GHENKAHBNGH = Shader.PropertyToID("[HA Center][C FA8C8CFF][FS 24]Fireball[FS 16][color FFFFFFFF]\n\nHurls a ball of fire that [F ArialBold]explodes[F Arial] on [FA U]contact[FA -U] and damages all nearby [FA S]foes [FA -S]enemies.\n\n[VA B][C FF6666FF][F ArialBold 18]8[FS 16][C FFFFFFFF][F Arial] to [C FF6666FF][F ArialBold 18]12[F Arial 16][C FFFFFFFF][F ArialItalic] fire[F Arial] damage[VA ?]");
		this.DIMGPCEBEGE = Shader.PropertyToID("");
		this.AHNEKMDHFKC = Shader.PropertyToID("Ring");
		this.IGOEANOOFFF = Shader.PropertyToID("_rcpFrame");
		this.OFHAIPIBDBC = Shader.PropertyToID("IdleDodgeRight");
		this.NJIOJANKEDD = Shader.PropertyToID("readTurnir STATUS");
		this.OEIDCFLBDAL = Shader.PropertyToID("WallRunLeft");
		this.FNCBANADCBJ = Shader.PropertyToID("cntx_wpnauk");
		this.MAMMKBMCDED = Shader.PropertyToID("");
		this.ALMNFJFCEKI = Shader.PropertyToID("lastConfirmLic");
		this.IHHIGFMOPHG = Shader.PropertyToID("Giant2HandSlamIdle");
		this.CHGMOFGHPND = Shader.PropertyToID("-- <color='#002000'>$</color>");
		this.MNHEGFNBGBP = Shader.PropertyToID("_BlurredColor");
		this.OFNKEJPFHPM = Shader.PropertyToID("FlyLeft");
		this.JHGLFOIFPNA = Shader.PropertyToID("drag_onmousedown.wav");
		this.BEAGFOMBNIE = Shader.PropertyToID("FlyUp");
		this.HAOPEKACGKJ = Shader.PropertyToID("startB");
		this.JKPIIPGJCGL = Shader.PropertyToID("crft_selwpn");
		this.OLDFANLEEPP = Shader.PropertyToID("cntx_teach");
		this.JEBEODKPNBD = Shader.PropertyToID("RunBackRight");
		this.FPFCLGAHHPJ = Shader.PropertyToID("error.wav");
		this.BIBGFHMDCOC = Shader.PropertyToID("Water Refl Camera id");
		this.PFENCNMEJGE = Shader.PropertyToID(" ");
		this.NIBOHKNFDPB = Shader.PropertyToID("_AxialAberration");
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x00123B00 File Offset: 0x00121D00
	public static Mesh CJEFIPMKBIB(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "MotorbikeWheelyNoHands";
		array[0] = GDCMKLMHFLI;
		array[0] = "category";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[1] = new Vector3(328f, 346f, 261f);
		array2[1] = new Vector3(428f, 863f, 185f);
		array2[7] = new Vector3(805f, 621f, 795f);
		array2[8] = new Vector3(1685f, 1574f, 1508f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[0];
		array4[1] = new Vector3(596f, 1756f, 349f);
		array4[0] = new Vector3(438f, 1367f, 1328f);
		array4[3] = new Vector3(1946f, 1014f, 1178f);
		array4[0] = new Vector3(1138f, 479f, 1053f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			default(Vector4),
			new Vector4(1794f, 64f, 1911f, 699f)
		};
		array5[0] = new Vector4(1518f, 149f, 1579f, 835f);
		array5[6] = new Vector4(1347f, 593f, 694f, 715f);
		array5[3] = new Vector4(281f, 1035f, 1665f, 65f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x00123D48 File Offset: 0x00121F48
	public static Mesh AOBFEBDIBKL(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[]
		{
			null,
			"WeaponReload"
		};
		array[0] = GDCMKLMHFLI;
		array[4] = "IdleDie";
		array[5] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[6];
		array2[0] = new Vector3(1728f, 250f, 817f);
		array2[0] = new Vector3(970f, 801f, 1039f);
		array2[4] = new Vector3(604f, 1602f, 1953f);
		array2[0] = new Vector3(1770f, 1375f, 1468f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[7];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[4];
		array4[0] = new Vector3(931f, 818f, 85f);
		array4[1] = new Vector3(1128f, 1330f, 1581f);
		array4[8] = new Vector3(1057f, 1643f, 677f);
		array4[0] = new Vector3(1817f, 129f, 1327f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[0];
		array5[0] = new Vector4(701f, 462f, 188f, 1314f);
		array5[0] = new Vector4(1365f, 877f, 466f, 919f);
		array5[5] = new Vector4(558f, 685f, 409f, 1229f);
		array5[0] = new Vector4(751f, 1555f, 1885f, 1805f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x00123F90 File Offset: 0x00122190
	public void MBGIJOIBJEH()
	{
		this.FJIHFMOALEP = Shader.PropertyToID(".png");
		this.PBDNAONCCBD = Shader.PropertyToID("SteamManager");
		this.ICEFEJNFPNB = Shader.PropertyToID("sonar_");
		this.DNCCNIPJJFP = Shader.PropertyToID("_ScreenSize");
		this.EPACGLABCFJ = Shader.PropertyToID("WeaponStrafeRunLeft");
		this.CGMKIBNPFFI = Shader.PropertyToID("_NormalAndOcclusion");
		this.CMGHEMIEACC = Shader.PropertyToID("KneesIdle");
		this.MIKPHLGJFKC = Shader.PropertyToID("rait_3");
		this.PMDMDAEHDFE = Shader.PropertyToID("Swim Dog Paddle");
		this.LAOIHBNKNDC = Shader.PropertyToID("Flares");
		this.DKIOGOAGEMJ = Shader.PropertyToID("Player");
		this.LNJEDJHGDBA = Shader.PropertyToID("stretchWidth");
		this.PCGJBGMPMPJ = Shader.PropertyToID("_BlurArea");
		this.LCFIPCLBNCP = Shader.PropertyToID("BattleRoar");
		this.GHENKAHBNGH = Shader.PropertyToID("_Offsets");
		this.DIMGPCEBEGE = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/page10.html");
		this.AHNEKMDHFKC = Shader.PropertyToID("action");
		this.IGOEANOOFFF = Shader.PropertyToID("inv_useeff");
		this.OFHAIPIBDBC = Shader.PropertyToID("Idle180");
		this.NJIOJANKEDD = Shader.PropertyToID("gi_cachhe");
		this.OEIDCFLBDAL = Shader.PropertyToID("_BlurRadius4");
		this.FNCBANADCBJ = Shader.PropertyToID("IceHockeyGoalieSave2");
		this.MAMMKBMCDED = Shader.PropertyToID("_Intensity");
		this.ALMNFJFCEKI = Shader.PropertyToID("\">Detected: ");
		this.IHHIGFMOPHG = Shader.PropertyToID("Hold RMB to aim down the sight");
		this.CHGMOFGHPND = Shader.PropertyToID("ProneIdle");
		this.MNHEGFNBGBP = Shader.PropertyToID("The 'color' command requires a color parameter of RRGGBBAA or '?'.");
		this.OFNKEJPFHPM = Shader.PropertyToID("Katana");
		this.JHGLFOIFPNA = Shader.PropertyToID("http://af-2.ru/?q=user/register");
		this.BEAGFOMBNIE = Shader.PropertyToID("RollerBladeCrossoverLeft");
		this.HAOPEKACGKJ = Shader.PropertyToID("HH:mm");
		this.JKPIIPGJCGL = Shader.PropertyToID("KatanaReadyLow");
		this.OLDFANLEEPP = Shader.PropertyToID("wpn_add/addoptions");
		this.JEBEODKPNBD = Shader.PropertyToID("error baseid: ");
		this.FPFCLGAHHPJ = Shader.PropertyToID("RollerBladeStop");
		this.BIBGFHMDCOC = Shader.PropertyToID("#000040");
		this.PFENCNMEJGE = Shader.PropertyToID(" ");
		this.NIBOHKNFDPB = Shader.PropertyToID("ShootRaycastModule");
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x00124200 File Offset: 0x00122400
	public static Mesh LNODBDOOPGC(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[0];
		array[0] = "WeaponReady";
		array[0] = GDCMKLMHFLI;
		array[1] = "";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[2];
		array2[0] = new Vector3(9f, 1019f, 529f);
		array2[1] = new Vector3(1080f, 1048f, 1517f);
		array2[5] = new Vector3(1576f, 480f, 741f);
		array2[8] = new Vector3(142f, 41f, 1120f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[6];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[]
		{
			default(Vector3),
			new Vector3(1756f, 677f, 521f)
		};
		array4[1] = new Vector3(708f, 244f, 527f);
		array4[5] = new Vector3(1014f, 969f, 1528f);
		array4[5] = new Vector3(874f, 206f, 1066f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[8];
		array5[1] = new Vector4(778f, 246f, 1444f, 254f);
		array5[1] = new Vector4(1615f, 14f, 26f, 1274f);
		array5[2] = new Vector4(1763f, 804f, 657f, 1742f);
		array5[1] = new Vector4(1437f, 1709f, 772f, 1084f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x00124448 File Offset: 0x00122648
	public static Mesh FILBKFNCDPJ(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[1] = "isRun";
		array[0] = GDCMKLMHFLI;
		array[2] = "StartTests";
		array[1] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[3];
		array2[1] = new Vector3(980f, 1230f, 1553f);
		array2[0] = new Vector3(1250f, 215f, 1658f);
		array2[4] = new Vector3(1135f, 480f, 955f);
		array2[4] = new Vector3(1516f, 86f, 1281f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[0];
		array4[1] = new Vector3(809f, 240f, 467f);
		array4[1] = new Vector3(123f, 128f, 1339f);
		array4[8] = new Vector3(133f, 1529f, 1024f);
		array4[1] = new Vector3(1513f, 1649f, 432f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[4];
		array5[0] = new Vector4(1441f, 408f, 280f, 1710f);
		array5[1] = new Vector4(242f, 1456f, 1557f, 1400f);
		array5[3] = new Vector4(1011f, 1720f, 777f, 1897f);
		array5[5] = new Vector4(902f, 1420f, 743f, 208f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x00124690 File Offset: 0x00122890
	public void MOHBAGDCFHB()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("t_obves");
		this.PBDNAONCCBD = Shader.PropertyToID("0");
		this.ICEFEJNFPNB = Shader.PropertyToID("RunBackLeft");
		this.DNCCNIPJJFP = Shader.PropertyToID("[AmplifyColor] Please disable \"Generate Mip Maps\" import settings on all LUT textures to avoid visual glitches. Change Texture Type to \"Advanced\" to access Mip settings.");
		this.EPACGLABCFJ = Shader.PropertyToID("_Offsets");
		this.CGMKIBNPFFI = Shader.PropertyToID("auk_wcnt");
		this.CMGHEMIEACC = Shader.PropertyToID("SoccerRun");
		this.MIKPHLGJFKC = Shader.PropertyToID("RunJump");
		this.PMDMDAEHDFE = Shader.PropertyToID(" msg=");
		this.LAOIHBNKNDC = Shader.PropertyToID("");
		this.DKIOGOAGEMJ = Shader.PropertyToID("wpn_rem1");
		this.LNJEDJHGDBA = Shader.PropertyToID("Lasso Left");
		this.PCGJBGMPMPJ = Shader.PropertyToID("level");
		this.LCFIPCLBNCP = Shader.PropertyToID("FishOnRod");
		this.GHENKAHBNGH = Shader.PropertyToID("OfficeSitting1LegStraight");
		this.DIMGPCEBEGE = Shader.PropertyToID("Проверка предмета");
		this.AHNEKMDHFKC = Shader.PropertyToID("medium");
		this.IGOEANOOFFF = Shader.PropertyToID("<color='#80ff00'>+ </color>");
		this.OFHAIPIBDBC = Shader.PropertyToID("__b");
		this.NJIOJANKEDD = Shader.PropertyToID("wpn_rec3");
		this.OEIDCFLBDAL = Shader.PropertyToID("bs_nomoney");
		this.FNCBANADCBJ = Shader.PropertyToID("#a0d0a0");
		this.MAMMKBMCDED = Shader.PropertyToID("CratePull");
		this.ALMNFJFCEKI = Shader.PropertyToID("WizardEyeBeam");
		this.IHHIGFMOPHG = Shader.PropertyToID("_Threshhold");
		this.CHGMOFGHPND = Shader.PropertyToID("obscured focus oO");
		this.MNHEGFNBGBP = Shader.PropertyToID("");
		this.OFNKEJPFHPM = Shader.PropertyToID(" ");
		this.JHGLFOIFPNA = Shader.PropertyToID("CratePush");
		this.BEAGFOMBNIE = Shader.PropertyToID("1HSwordStrafeRunLeft");
		this.HAOPEKACGKJ = Shader.PropertyToID("IdleTyping");
		this.JKPIIPGJCGL = Shader.PropertyToID("WeaponInstant");
		this.OLDFANLEEPP = Shader.PropertyToID("********* connect to chat ");
		this.JEBEODKPNBD = Shader.PropertyToID("wpn_add/base");
		this.FPFCLGAHHPJ = Shader.PropertyToID("SuicideHeadShot");
		this.BIBGFHMDCOC = Shader.PropertyToID("\"{0}\"");
		this.PFENCNMEJGE = Shader.PropertyToID("<color='#000000'>");
		this.NIBOHKNFDPB = Shader.PropertyToID("Root Node bone is null, can not initiate the solver.");
	}

	// Token: 0x060028F7 RID: 10487 RVA: 0x00124900 File Offset: 0x00122B00
	public void KAKMEAIGAOA()
	{
		this.FJIHFMOALEP = Shader.PropertyToID(" ");
		this.PBDNAONCCBD = Shader.PropertyToID("Data loaded done");
		this.ICEFEJNFPNB = Shader.PropertyToID("HA ");
		this.DNCCNIPJJFP = Shader.PropertyToID("ondestroy");
		this.EPACGLABCFJ = Shader.PropertyToID("CrouchWalkBackward");
		this.CGMKIBNPFFI = Shader.PropertyToID("RandomizeObscuredVars");
		this.CMGHEMIEACC = Shader.PropertyToID("_");
		this.MIKPHLGJFKC = Shader.PropertyToID("MotorbikeHeartAttack");
		this.PMDMDAEHDFE = Shader.PropertyToID("Idle Sand Cover");
		this.LAOIHBNKNDC = Shader.PropertyToID("-------------- capId=");
		this.DKIOGOAGEMJ = Shader.PropertyToID("wpn_eat8");
		this.LNJEDJHGDBA = Shader.PropertyToID("Ban OK. Object:");
		this.PCGJBGMPMPJ = Shader.PropertyToID("SwimFreestyle");
		this.LCFIPCLBNCP = Shader.PropertyToID("effect");
		this.GHENKAHBNGH = Shader.PropertyToID("_ProjInfo");
		this.DIMGPCEBEGE = Shader.PropertyToID("Neck");
		this.AHNEKMDHFKC = Shader.PropertyToID("demoVector3");
		this.IGOEANOOFFF = Shader.PropertyToID("_");
		this.OFHAIPIBDBC = Shader.PropertyToID("");
		this.NJIOJANKEDD = Shader.PropertyToID("OfficeSitting");
		this.OEIDCFLBDAL = Shader.PropertyToID("ignorelist");
		this.FNCBANADCBJ = Shader.PropertyToID("[maxcnt]");
		this.MAMMKBMCDED = Shader.PropertyToID("UpHillWalk");
		this.ALMNFJFCEKI = Shader.PropertyToID("mx=");
		this.IHHIGFMOPHG = Shader.PropertyToID("exp");
		this.CHGMOFGHPND = Shader.PropertyToID("...");
		this.MNHEGFNBGBP = Shader.PropertyToID("chnam2");
		this.OFNKEJPFHPM = Shader.PropertyToID("_History1LumaTex");
		this.JHGLFOIFPNA = Shader.PropertyToID("_Texture");
		this.BEAGFOMBNIE = Shader.PropertyToID("Idle Sand Cover");
		this.HAOPEKACGKJ = Shader.PropertyToID("refine");
		this.JKPIIPGJCGL = Shader.PropertyToID("bright");
		this.OLDFANLEEPP = Shader.PropertyToID("cht_msg23");
		this.JEBEODKPNBD = Shader.PropertyToID("****** locid=");
		this.FPFCLGAHHPJ = Shader.PropertyToID("man_death.ogg");
		this.BIBGFHMDCOC = Shader.PropertyToID(". Check the Maintenance window for your VPaint Group for more info.");
		this.PFENCNMEJGE = Shader.PropertyToID("Node transform is null in FBIK chain.");
		this.NIBOHKNFDPB = Shader.PropertyToID("_BilateralUpsampling");
	}

	// Token: 0x060028F8 RID: 10488 RVA: 0x00124B70 File Offset: 0x00122D70
	public static Mesh NFCJFCDBOCP(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "IKSolverFABRIKRoot chain at index ";
		array[0] = GDCMKLMHFLI;
		array[0] = "nowpn";
		array[3] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[]
		{
			default(Vector3),
			new Vector3(854f, 1126f, 558f)
		};
		array2[1] = new Vector3(1776f, 1813f, 1894f);
		array2[5] = new Vector3(1438f, 1027f, 1849f);
		array2[3] = new Vector3(1675f, 831f, 276f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[6];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[8] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[4];
		array4[0] = new Vector3(1507f, 1873f, 1577f);
		array4[0] = new Vector3(1650f, 335f, 749f);
		array4[2] = new Vector3(241f, 387f, 922f);
		array4[4] = new Vector3(1857f, 465f, 497f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[0];
		array5[1] = new Vector4(1904f, 1806f, 681f, 736f);
		array5[0] = new Vector4(314f, 206f, 980f, 1483f);
		array5[3] = new Vector4(1525f, 122f, 1824f, 533f);
		array5[4] = new Vector4(1957f, 198f, 1051f, 1961f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028F9 RID: 10489 RVA: 0x00124DB8 File Offset: 0x00122FB8
	public static Mesh MOBHNDOMDIJ(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[0] = "";
		array[0] = GDCMKLMHFLI;
		array[6] = "ClimbRight";
		array[3] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[6];
		array2[1] = new Vector3(1411f, 644f, 1302f);
		array2[0] = new Vector3(317f, 507f, 1327f);
		array2[7] = new Vector3(243f, 458f, 977f);
		array2[3] = new Vector3(1732f, 90f, 1110f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[4];
		array5[1] = new Vector3(1764f, 1180f, 1381f);
		array5[1] = new Vector3(654f, 322f, 1923f);
		array5[2] = new Vector3(174f, 114f, 1444f);
		array5[8] = new Vector3(516f, 576f, 1756f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[7];
		array6[0] = new Vector4(1372f, 1421f, 1814f, 1881f);
		array6[1] = new Vector4(626f, 56f, 161f, 94f);
		array6[7] = new Vector4(1682f, 1113f, 1758f, 1424f);
		array6[7] = new Vector4(430f, 1633f, 1538f, 1567f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x00125000 File Offset: 0x00123200
	public static Mesh EJBDNOHPBPH(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[1] = "ShotgunReadyFire";
		array[1] = GDCMKLMHFLI;
		array[1] = "offsets";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[0] = new Vector3(962f, 1891f, 459f);
		array2[1] = new Vector3(1999f, 1170f, 745f);
		array2[6] = new Vector3(1405f, 1604f, 170f);
		array2[2] = new Vector3(1469f, 5f, 1168f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[8];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[]
		{
			new Vector3(756f, 750f, 1442f),
			new Vector3(1663f, 1563f, 1218f)
		};
		array4[1] = new Vector3(795f, 1291f, 1931f);
		array4[6] = new Vector3(878f, 895f, 1584f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			new Vector4(1875f, 750f, 885f, 665f)
		};
		array5[0] = new Vector4(1012f, 1925f, 1608f, 1186f);
		array5[6] = new Vector4(985f, 1356f, 1190f, 1497f);
		array5[8] = new Vector4(447f, 925f, 1703f, 540f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x00125248 File Offset: 0x00123448
	public static Mesh JHJCHKOOCFK(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "ClimbUp";
		array[0] = GDCMKLMHFLI;
		array[8] = "WATER_SIMPLE";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[6];
		array2[1] = new Vector3(1644f, 1647f, 272f);
		array2[1] = new Vector3(1803f, 583f, 1664f);
		array2[5] = new Vector3(1721f, 1977f, 1168f);
		array2[0] = new Vector3(1727f, 513f, 951f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[]
		{
			new Vector3(1862f, 935f, 1681f)
		};
		array4[0] = new Vector3(854f, 104f, 638f);
		array4[6] = new Vector3(1595f, 1662f, 763f);
		array4[3] = new Vector3(1044f, 907f, 1078f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[7];
		array5[0] = new Vector4(1735f, 716f, 141f, 684f);
		array5[1] = new Vector4(1060f, 150f, 930f, 1357f);
		array5[1] = new Vector4(978f, 1399f, 1575f, 932f);
		array5[2] = new Vector4(1351f, 977f, 409f, 256f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x00125490 File Offset: 0x00123690
	public void LFCLNDHCBFD()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("");
		this.PBDNAONCCBD = Shader.PropertyToID("KatanaReadyLow");
		this.ICEFEJNFPNB = Shader.PropertyToID("UI_ArtWindow");
		this.DNCCNIPJJFP = Shader.PropertyToID("error: assetBundle is null");
		this.EPACGLABCFJ = Shader.PropertyToID("MotorbikeHandlebarSit");
		this.CGMKIBNPFFI = Shader.PropertyToID("_TexelOffsetScale");
		this.CMGHEMIEACC = Shader.PropertyToID("ClimbIdle");
		this.MIKPHLGJFKC = Shader.PropertyToID(" ");
		this.PMDMDAEHDFE = Shader.PropertyToID("28");
		this.LAOIHBNKNDC = Shader.PropertyToID("WoodSaw");
		this.DKIOGOAGEMJ = Shader.PropertyToID(" {0}");
		this.LNJEDJHGDBA = Shader.PropertyToID("RollerBlade");
		this.PCGJBGMPMPJ = Shader.PropertyToID(": ");
		this.LCFIPCLBNCP = Shader.PropertyToID("_Offsets");
		this.GHENKAHBNGH = Shader.PropertyToID("Vertical");
		this.DIMGPCEBEGE = Shader.PropertyToID("OfficeSittingReading");
		this.AHNEKMDHFKC = Shader.PropertyToID("ArmFlex5");
		this.IGOEANOOFFF = Shader.PropertyToID("WeaponStab");
		this.OFHAIPIBDBC = Shader.PropertyToID("gi_um_lim");
		this.NJIOJANKEDD = Shader.PropertyToID("colorA");
		this.OEIDCFLBDAL = Shader.PropertyToID("qd_taskcount");
		this.FNCBANADCBJ = Shader.PropertyToID("Failed parsing atlas group.  Setting to group 0");
		this.MAMMKBMCDED = Shader.PropertyToID("Swim Freestyle");
		this.ALMNFJFCEKI = Shader.PropertyToID("offsets");
		this.IHHIGFMOPHG = Shader.PropertyToID("crft_recnt");
		this.CHGMOFGHPND = Shader.PropertyToID("WallSit");
		this.MNHEGFNBGBP = Shader.PropertyToID("1HandSwordStrafeRight");
		this.OFNKEJPFHPM = Shader.PropertyToID("_DepthOfFieldParams");
		this.JHGLFOIFPNA = Shader.PropertyToID("_RgbTex");
		this.BEAGFOMBNIE = Shader.PropertyToID("cntx_use");
		this.HAOPEKACGKJ = Shader.PropertyToID("VIGNETTE_BLUR");
		this.JKPIIPGJCGL = Shader.PropertyToID("PaperTurn.wav");
		this.OLDFANLEEPP = Shader.PropertyToID("MotorbikeTurnRight");
		this.JEBEODKPNBD = Shader.PropertyToID("_MaxBlurRadius");
		this.FPFCLGAHHPJ = Shader.PropertyToID("IdleStand");
		this.BIBGFHMDCOC = Shader.PropertyToID("VIGNETTE_CLASSIC");
		this.PFENCNMEJGE = Shader.PropertyToID("\n");
		this.NIBOHKNFDPB = Shader.PropertyToID("");
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x00125700 File Offset: 0x00123900
	public static Mesh FMMLBHFHOLC(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[2];
		array[0] = "dianema.ogg";
		array[0] = GDCMKLMHFLI;
		array[3] = "CratePush";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		mesh.vertices = new Vector3[]
		{
			new Vector3(1978f, 1205f, 1075f),
			new Vector3(465f, 1150f, 1838f),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			new Vector3(92f, 215f, 876f),
			new Vector3(1484f, 481f, 63f)
		};
		Mesh mesh2 = mesh;
		Vector2[] array2 = new Vector2[]
		{
			default(Vector2),
			new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y)
		};
		array2[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array2[5] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array2[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh2.uv = array2;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2,
			1
		};
		Mesh mesh3 = mesh;
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1254f, 1916f, 1510f);
		array3[0] = new Vector3(1026f, 145f, 1544f);
		array3[1] = new Vector3(1717f, 739f, 157f);
		array3[5] = new Vector3(534f, 1755f, 1103f);
		mesh3.normals = array3;
		Mesh mesh4 = mesh;
		Vector4[] array4 = new Vector4[0];
		array4[1] = new Vector4(211f, 1152f, 850f, 1446f);
		array4[0] = new Vector4(1548f, 1067f, 1f, 1012f);
		array4[0] = new Vector4(1407f, 943f, 840f, 336f);
		array4[3] = new Vector4(1906f, 1464f, 1820f, 5f);
		mesh4.tangents = array4;
		return mesh;
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x00125948 File Offset: 0x00123B48
	public void IDIGIKOIPNG()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("");
		this.PBDNAONCCBD = Shader.PropertyToID(" ");
		this.ICEFEJNFPNB = Shader.PropertyToID("****** locid=");
		this.DNCCNIPJJFP = Shader.PropertyToID("WizardNeoBlock");
		this.EPACGLABCFJ = Shader.PropertyToID("#FF4040");
		this.CGMKIBNPFFI = Shader.PropertyToID("");
		this.CMGHEMIEACC = Shader.PropertyToID(": ");
		this.MIKPHLGJFKC = Shader.PropertyToID("gameban");
		this.PMDMDAEHDFE = Shader.PropertyToID("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774");
		this.LAOIHBNKNDC = Shader.PropertyToID("_FogWindDir");
		this.DKIOGOAGEMJ = Shader.PropertyToID("crft_to");
		this.LNJEDJHGDBA = Shader.PropertyToID("WorkerPickaxe2");
		this.PCGJBGMPMPJ = Shader.PropertyToID("_TintColor");
		this.LCFIPCLBNCP = Shader.PropertyToID("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
		this.GHENKAHBNGH = Shader.PropertyToID("wpnlang/wpntypes/type DUBLICATE ");
		this.DIMGPCEBEGE = Shader.PropertyToID("FacePalm");
		this.AHNEKMDHFKC = Shader.PropertyToID("crft_cnt");
		this.IGOEANOOFFF = Shader.PropertyToID("SwimDogPaddle");
		this.OFHAIPIBDBC = Shader.PropertyToID("post_msg1");
		this.NJIOJANKEDD = Shader.PropertyToID("FlyDown");
		this.OEIDCFLBDAL = Shader.PropertyToID("DeadmanFloat");
		this.FNCBANADCBJ = Shader.PropertyToID("Try to change this string in memory:\n");
		this.MAMMKBMCDED = Shader.PropertyToID(" for ");
		this.ALMNFJFCEKI = Shader.PropertyToID("Fly Down");
		this.IHHIGFMOPHG = Shader.PropertyToID("Run Jump");
		this.CHGMOFGHPND = Shader.PropertyToID("ok");
		this.MNHEGFNBGBP = Shader.PropertyToID("_info");
		this.OFNKEJPFHPM = Shader.PropertyToID("CratePull");
		this.JHGLFOIFPNA = Shader.PropertyToID("t_body");
		this.BEAGFOMBNIE = Shader.PropertyToID("a");
		this.HAOPEKACGKJ = Shader.PropertyToID("#606060");
		this.JKPIIPGJCGL = Shader.PropertyToID("<color=\"");
		this.OLDFANLEEPP = Shader.PropertyToID("BACKCOLOR");
		this.JEBEODKPNBD = Shader.PropertyToID("The font size '");
		this.FPFCLGAHHPJ = Shader.PropertyToID("SoccerKeeperReady");
		this.BIBGFHMDCOC = Shader.PropertyToID("QTask.xml");
		this.PFENCNMEJGE = Shader.PropertyToID("\n");
		this.NIBOHKNFDPB = Shader.PropertyToID("OfficeSitting1LegStraight");
	}

	// Token: 0x06002900 RID: 10496 RVA: 0x00125BB8 File Offset: 0x00123DB8
	public static Mesh HECMPIKDHGM(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[1] = "_InternalLutTex";
		array[1] = GDCMKLMHFLI;
		array[5] = "hand";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[1];
		array2[1] = new Vector3(1714f, 874f, 969f);
		array2[0] = new Vector3(1925f, 1393f, 222f);
		array2[8] = new Vector3(1787f, 1149f, 1515f);
		array2[7] = new Vector3(222f, 118f, 1388f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[6];
		array4[0] = new Vector3(79f, 620f, 1483f);
		array4[1] = new Vector3(768f, 1640f, 1772f);
		array4[6] = new Vector3(489f, 1146f, 1845f);
		array4[2] = new Vector3(423f, 1398f, 777f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[5];
		array5[1] = new Vector4(248f, 1093f, 1758f, 1499f);
		array5[0] = new Vector4(1870f, 843f, 1244f, 265f);
		array5[5] = new Vector4(220f, 1463f, 1355f, 1777f);
		array5[6] = new Vector4(165f, 58f, 890f, 1528f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002901 RID: 10497 RVA: 0x00125E00 File Offset: 0x00124000
	public void IMLCJFEALHB()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("FULLNAME");
		this.PBDNAONCCBD = Shader.PropertyToID(" assetbundle(s) in memory after unloading ");
		this.ICEFEJNFPNB = Shader.PropertyToID(" ");
		this.DNCCNIPJJFP = Shader.PropertyToID("cntx_improve");
		this.EPACGLABCFJ = Shader.PropertyToID("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
		this.CGMKIBNPFFI = Shader.PropertyToID("{0}\n{1}");
		this.CMGHEMIEACC = Shader.PropertyToID("Knees Idle");
		this.MIKPHLGJFKC = Shader.PropertyToID("_TileTexDebug");
		this.PMDMDAEHDFE = Shader.PropertyToID("Assets/Weapons/");
		this.LAOIHBNKNDC = Shader.PropertyToID("IdleTyping");
		this.DKIOGOAGEMJ = Shader.PropertyToID("\n");
		this.LNJEDJHGDBA = Shader.PropertyToID("' that does not excist in the Node Chain.");
		this.PCGJBGMPMPJ = Shader.PropertyToID("demoVector3");
		this.LCFIPCLBNCP = Shader.PropertyToID("RollerBladeStop");
		this.GHENKAHBNGH = Shader.PropertyToID("name");
		this.DIMGPCEBEGE = Shader.PropertyToID("_TempRT");
		this.AHNEKMDHFKC = Shader.PropertyToID("_QualitySettings");
		this.IGOEANOOFFF = Shader.PropertyToID("MotorbikeHandlebarSit");
		this.OFHAIPIBDBC = Shader.PropertyToID("\n");
		this.NJIOJANKEDD = Shader.PropertyToID("IdleStand");
		this.OEIDCFLBDAL = Shader.PropertyToID("MotorbikeTurnRight");
		this.FNCBANADCBJ = Shader.PropertyToID("_BlurVector");
		this.MAMMKBMCDED = Shader.PropertyToID("repfrac");
		this.ALMNFJFCEKI = Shader.PropertyToID("MotorbikeSuperman");
		this.IHHIGFMOPHG = Shader.PropertyToID("wpnlang/wpntypes/type");
		this.CHGMOFGHPND = Shader.PropertyToID("Start.tif");
		this.MNHEGFNBGBP = Shader.PropertyToID("error.wav");
		this.OFNKEJPFHPM = Shader.PropertyToID("PLANE_REFLECTION");
		this.JHGLFOIFPNA = Shader.PropertyToID("Yawn");
		this.BEAGFOMBNIE = Shader.PropertyToID("Tail");
		this.HAOPEKACGKJ = Shader.PropertyToID("mainmenu");
		this.JKPIIPGJCGL = Shader.PropertyToID("Running Dance");
		this.OLDFANLEEPP = Shader.PropertyToID("autherror");
		this.JEBEODKPNBD = Shader.PropertyToID("WalkInjured");
		this.FPFCLGAHHPJ = Shader.PropertyToID("HitWeight");
		this.BIBGFHMDCOC = Shader.PropertyToID("]");
		this.PFENCNMEJGE = Shader.PropertyToID("The font size '");
		this.NIBOHKNFDPB = Shader.PropertyToID(", ");
	}

	// Token: 0x06002902 RID: 10498 RVA: 0x00126070 File Offset: 0x00124270
	public void PPAPDGACKGE()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("Sunshine Lightmap");
		this.PBDNAONCCBD = Shader.PropertyToID("[maxweight]");
		this.ICEFEJNFPNB = Shader.PropertyToID("Gloves");
		this.DNCCNIPJJFP = Shader.PropertyToID("Loot");
		this.EPACGLABCFJ = Shader.PropertyToID("OfficeSittingReadingPageFlip");
		this.CGMKIBNPFFI = Shader.PropertyToID("CENTER");
		this.CMGHEMIEACC = Shader.PropertyToID("wpn_eat5");
		this.MIKPHLGJFKC = Shader.PropertyToID("_ChannelMixerRed");
		this.PMDMDAEHDFE = Shader.PropertyToID("error.wav");
		this.LAOIHBNKNDC = Shader.PropertyToID("Hyperlink_");
		this.DKIOGOAGEMJ = Shader.PropertyToID("X");
		this.LNJEDJHGDBA = Shader.PropertyToID("knopje.wav");
		this.PCGJBGMPMPJ = Shader.PropertyToID("OfficeSittingEyesRub");
		this.LCFIPCLBNCP = Shader.PropertyToID("PistolReady");
		this.GHENKAHBNGH = Shader.PropertyToID("_HitTime");
		this.DIMGPCEBEGE = Shader.PropertyToID("");
		this.AHNEKMDHFKC = Shader.PropertyToID("SkateForward");
		this.IGOEANOOFFF = Shader.PropertyToID("[AmplifyColor] Please disable \"Generate Mip Maps\" import settings on all LUT textures to avoid visual glitches. Change Texture Type to \"Advanced\" to access Mip settings.");
		this.OFHAIPIBDBC = Shader.PropertyToID("VaderChoke");
		this.NJIOJANKEDD = Shader.PropertyToID("wpn_eat6");
		this.OEIDCFLBDAL = Shader.PropertyToID("");
		this.FNCBANADCBJ = Shader.PropertyToID("ObscuredUShort vs ushort, ");
		this.MAMMKBMCDED = Shader.PropertyToID("OnRodChangeClck order_check=");
		this.ALMNFJFCEKI = Shader.PropertyToID("WoodSaw");
		this.IHHIGFMOPHG = Shader.PropertyToID("already_exist");
		this.CHGMOFGHPND = Shader.PropertyToID("1HSwordStrafeRunLeft");
		this.MNHEGFNBGBP = Shader.PropertyToID("FlyBackward");
		this.OFNKEJPFHPM = Shader.PropertyToID("Forward");
		this.JHGLFOIFPNA = Shader.PropertyToID("IdleCheer");
		this.BEAGFOMBNIE = Shader.PropertyToID("TenkokuModule");
		this.HAOPEKACGKJ = Shader.PropertyToID("wpn_cat4");
		this.JKPIIPGJCGL = Shader.PropertyToID("IdleMeditate");
		this.OLDFANLEEPP = Shader.PropertyToID("shop_t7");
		this.JEBEODKPNBD = Shader.PropertyToID("_SampleScale");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_FoamContrast");
		this.BIBGFHMDCOC = Shader.PropertyToID("level");
		this.PFENCNMEJGE = Shader.PropertyToID("Fist Pump");
		this.NIBOHKNFDPB = Shader.PropertyToID("\n");
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x001262E0 File Offset: 0x001244E0
	public void LIHHNBKPKCB()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("<[^>]+>");
		this.PBDNAONCCBD = Shader.PropertyToID("PaperTurn.wav");
		this.ICEFEJNFPNB = Shader.PropertyToID("FOG_EXP2");
		this.DNCCNIPJJFP = Shader.PropertyToID("IceHockeyDekeMiddle");
		this.EPACGLABCFJ = Shader.PropertyToID("Mouse X");
		this.CGMKIBNPFFI = Shader.PropertyToID("- none -");
		this.CMGHEMIEACC = Shader.PropertyToID("Open turnir info window");
		this.MIKPHLGJFKC = Shader.PropertyToID("FOVKick camera is null, please supply the camera to the constructor");
		this.PMDMDAEHDFE = Shader.PropertyToID("Far");
		this.LAOIHBNKNDC = Shader.PropertyToID("StaffHeal");
		this.DKIOGOAGEMJ = Shader.PropertyToID("error");
		this.LNJEDJHGDBA = Shader.PropertyToID("Y (G)");
		this.PCGJBGMPMPJ = Shader.PropertyToID("<color=\"");
		this.LCFIPCLBNCP = Shader.PropertyToID("Fishing");
		this.GHENKAHBNGH = Shader.PropertyToID("Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.");
		this.DIMGPCEBEGE = Shader.PropertyToID("_RangeScale");
		this.AHNEKMDHFKC = Shader.PropertyToID("Hidden/DepthOfField/BokehSplatting");
		this.IGOEANOOFFF = Shader.PropertyToID("OfficeSittingHandRestFingerTap");
		this.OFHAIPIBDBC = Shader.PropertyToID("wpn_line3");
		this.NJIOJANKEDD = Shader.PropertyToID("https://www.youtube.com/watch?v=wT8fViZpLmQ");
		this.OEIDCFLBDAL = Shader.PropertyToID("_FogColor2");
		this.FNCBANADCBJ = Shader.PropertyToID("ProneLocomotion");
		this.MAMMKBMCDED = Shader.PropertyToID("MotorbikeWheelyNoHands");
		this.ALMNFJFCEKI = Shader.PropertyToID("SoccerSprint");
		this.IHHIGFMOPHG = Shader.PropertyToID("SoccerThrow");
		this.CHGMOFGHPND = Shader.PropertyToID("error.wav");
		this.MNHEGFNBGBP = Shader.PropertyToID("_Overlay");
		this.OFNKEJPFHPM = Shader.PropertyToID("Failed parsing organizational group.  Setting to group 0");
		this.JHGLFOIFPNA = Shader.PropertyToID("CheckResources () for ");
		this.BEAGFOMBNIE = Shader.PropertyToID("error.wav");
		this.HAOPEKACGKJ = Shader.PropertyToID("name");
		this.JKPIIPGJCGL = Shader.PropertyToID("error.wav");
		this.OLDFANLEEPP = Shader.PropertyToID("invn_win1");
		this.JEBEODKPNBD = Shader.PropertyToID("https://groups.google.com/forum/#!forum/final-ik");
		this.FPFCLGAHHPJ = Shader.PropertyToID("{2:D2}:{0:D2}:{1:D2}");
		this.BIBGFHMDCOC = Shader.PropertyToID("");
		this.PFENCNMEJGE = Shader.PropertyToID("post_21");
		this.NIBOHKNFDPB = Shader.PropertyToID("_Color");
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x00126550 File Offset: 0x00124750
	public void LIENFFAPLAB()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("80ff00");
		this.PBDNAONCCBD = Shader.PropertyToID("ChannelCastDirected");
		this.ICEFEJNFPNB = Shader.PropertyToID("quality");
		this.DNCCNIPJJFP = Shader.PropertyToID("checkPet 2");
		this.EPACGLABCFJ = Shader.PropertyToID("WireframeBack");
		this.CGMKIBNPFFI = Shader.PropertyToID("UpHillWalk");
		this.CMGHEMIEACC = Shader.PropertyToID("INTERFACE");
		this.MIKPHLGJFKC = Shader.PropertyToID("WizardEyeBeam");
		this.PMDMDAEHDFE = Shader.PropertyToID("MotorbikeHeartAttack");
		this.LAOIHBNKNDC = Shader.PropertyToID("Thumb");
		this.DKIOGOAGEMJ = Shader.PropertyToID("1HandSwordStrafeLeft");
		this.LNJEDJHGDBA = Shader.PropertyToID("error");
		this.PCGJBGMPMPJ = Shader.PropertyToID("_rcpFrame");
		this.LCFIPCLBNCP = Shader.PropertyToID("no_adm");
		this.GHENKAHBNGH = Shader.PropertyToID("WalkDehydrated");
		this.DIMGPCEBEGE = Shader.PropertyToID("run_cnt");
		this.AHNEKMDHFKC = Shader.PropertyToID("wgt_gr");
		this.IGOEANOOFFF = Shader.PropertyToID("Smoking2");
		this.OFHAIPIBDBC = Shader.PropertyToID("sunshine_CascadeFarRatiosSq");
		this.NJIOJANKEDD = Shader.PropertyToID("stat: ");
		this.OEIDCFLBDAL = Shader.PropertyToID("_MainTex");
		this.FNCBANADCBJ = Shader.PropertyToID("1HandHeavySwing2");
		this.MAMMKBMCDED = Shader.PropertyToID("FacePalm");
		this.ALMNFJFCEKI = Shader.PropertyToID("RollerBladeGrindRoyale");
		this.IHHIGFMOPHG = Shader.PropertyToID("name");
		this.CHGMOFGHPND = Shader.PropertyToID("____________________________________");
		this.MNHEGFNBGBP = Shader.PropertyToID("MotorbikeHandstand");
		this.OFNKEJPFHPM = Shader.PropertyToID("Criticals");
		this.JHGLFOIFPNA = Shader.PropertyToID("Loser");
		this.BEAGFOMBNIE = Shader.PropertyToID("");
		this.HAOPEKACGKJ = Shader.PropertyToID("****** locscount=");
		this.JKPIIPGJCGL = Shader.PropertyToID("Try to change this int in memory:\n");
		this.OLDFANLEEPP = Shader.PropertyToID("Hidden/Subpixel Morphological Anti-aliasing");
		this.JEBEODKPNBD = Shader.PropertyToID("Current fog preset: ");
		this.FPFCLGAHHPJ = Shader.PropertyToID("*************157 baseid=");
		this.BIBGFHMDCOC = Shader.PropertyToID("_SecondTex");
		this.PFENCNMEJGE = Shader.PropertyToID("fwgt_uniq_m");
		this.NIBOHKNFDPB = Shader.PropertyToID("Giant2HandSlamSwing");
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x001267C0 File Offset: 0x001249C0
	public void CGEDGEFKEAJ()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("def point foud");
		this.PBDNAONCCBD = Shader.PropertyToID("_ScaleOffsetRes");
		this.ICEFEJNFPNB = Shader.PropertyToID("pempty");
		this.DNCCNIPJJFP = Shader.PropertyToID("_DelItem.wav");
		this.EPACGLABCFJ = Shader.PropertyToID("error.wav");
		this.CGMKIBNPFFI = Shader.PropertyToID("LMB to shoot the Dummy, RMB to rotate the camera.");
		this.CMGHEMIEACC = Shader.PropertyToID("iPoint");
		this.MIKPHLGJFKC = Shader.PropertyToID("_FullItem.wav");
		this.PMDMDAEHDFE = Shader.PropertyToID("IceHockeyIdle");
		this.LAOIHBNKNDC = Shader.PropertyToID("RollerBladeCrossoverRight");
		this.DKIOGOAGEMJ = Shader.PropertyToID("DeadmanFloat");
		this.LNJEDJHGDBA = Shader.PropertyToID("https://groups.google.com/forum/#!forum/final-ik");
		this.PCGJBGMPMPJ = Shader.PropertyToID("_FoamContrast");
		this.LCFIPCLBNCP = Shader.PropertyToID("No light component found in UniqueShadowSun '{0}!");
		this.GHENKAHBNGH = Shader.PropertyToID("CratePull");
		this.DIMGPCEBEGE = Shader.PropertyToID("wpn_eat1");
		this.AHNEKMDHFKC = Shader.PropertyToID("ignorelist");
		this.IGOEANOOFFF = Shader.PropertyToID("_DepthExponent");
		this.OFHAIPIBDBC = Shader.PropertyToID("-no info-");
		this.NJIOJANKEDD = Shader.PropertyToID("{0:### ##0.#0}");
		this.OEIDCFLBDAL = Shader.PropertyToID("lifeBar");
		this.FNCBANADCBJ = Shader.PropertyToID("Close rod");
		this.MAMMKBMCDED = Shader.PropertyToID("SAMPLES_LOW");
		this.ALMNFJFCEKI = Shader.PropertyToID("wpn_rod4");
		this.IHHIGFMOPHG = Shader.PropertyToID("");
		this.CHGMOFGHPND = Shader.PropertyToID("inner_craft_wpn");
		this.MNHEGFNBGBP = Shader.PropertyToID("USE_DIAG_SEARCH");
		this.OFNKEJPFHPM = Shader.PropertyToID("_RgbTex");
		this.JHGLFOIFPNA = Shader.PropertyToID("qd_week");
		this.BEAGFOMBNIE = Shader.PropertyToID("No load asset ");
		this.HAOPEKACGKJ = Shader.PropertyToID("Wizard2HandThrow");
		this.JKPIIPGJCGL = Shader.PropertyToID("_BaseTex");
		this.OLDFANLEEPP = Shader.PropertyToID("IdleBandage");
		this.JEBEODKPNBD = Shader.PropertyToID("</color>");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_mesh");
		this.BIBGFHMDCOC = Shader.PropertyToID("");
		this.PFENCNMEJGE = Shader.PropertyToID("Here you can overview common ACTk features and try to cheat something yourself.");
		this.NIBOHKNFDPB = Shader.PropertyToID("LINEAR");
	}

	// Token: 0x06002906 RID: 10502 RVA: 0x00126A30 File Offset: 0x00124C30
	public static Mesh BJEKHFNCDGD(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[0] = "name";
		array[1] = GDCMKLMHFLI;
		array[4] = "loc_";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[0];
		array2[1] = new Vector3(1695f, 256f, 310f);
		array2[0] = new Vector3(193f, 22f, 52f);
		array2[2] = new Vector3(1373f, 1276f, 286f);
		array2[3] = new Vector3(1368f, 1712f, 1401f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[8];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[0];
		array5[0] = new Vector3(732f, 29f, 1127f);
		array5[0] = new Vector3(1107f, 1946f, 406f);
		array5[2] = new Vector3(570f, 239f, 971f);
		array5[6] = new Vector3(956f, 1503f, 510f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[5];
		array6[1] = new Vector4(1230f, 654f, 596f, 1959f);
		array6[0] = new Vector4(243f, 82f, 963f, 1998f);
		array6[1] = new Vector4(1946f, 1307f, 602f, 894f);
		array6[6] = new Vector4(1617f, 1433f, 1577f, 624f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002907 RID: 10503 RVA: 0x00126C78 File Offset: 0x00124E78
	public void OJOJHACIPLB()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.");
		this.PBDNAONCCBD = Shader.PropertyToID("spinKvok activate");
		this.ICEFEJNFPNB = Shader.PropertyToID("sunshine_CameraVToSunVP");
		this.DNCCNIPJJFP = Shader.PropertyToID("\n");
		this.EPACGLABCFJ = Shader.PropertyToID("Sampling AO on ");
		this.CGMKIBNPFFI = Shader.PropertyToID("WateringCanWatering");
		this.CMGHEMIEACC = Shader.PropertyToID("");
		this.MIKPHLGJFKC = Shader.PropertyToID(" Message: ");
		this.PMDMDAEHDFE = Shader.PropertyToID("Sewing");
		this.LAOIHBNKNDC = Shader.PropertyToID(" ms");
		this.DKIOGOAGEMJ = Shader.PropertyToID("");
		this.LNJEDJHGDBA = Shader.PropertyToID(" on effect ");
		this.PCGJBGMPMPJ = Shader.PropertyToID("ArmFlex3");
		this.LCFIPCLBNCP = Shader.PropertyToID("wpn_rem2");
		this.GHENKAHBNGH = Shader.PropertyToID("wpn_eat4");
		this.DIMGPCEBEGE = Shader.PropertyToID("HH:mm");
		this.AHNEKMDHFKC = Shader.PropertyToID("IsMoving");
		this.IGOEANOOFFF = Shader.PropertyToID("");
		this.OFHAIPIBDBC = Shader.PropertyToID("</color>");
		this.NJIOJANKEDD = Shader.PropertyToID("Button");
		this.OEIDCFLBDAL = Shader.PropertyToID("Smoking1");
		this.FNCBANADCBJ = Shader.PropertyToID(" с");
		this.MAMMKBMCDED = Shader.PropertyToID("path");
		this.ALMNFJFCEKI = Shader.PropertyToID("wpn_add/base");
		this.IHHIGFMOPHG = Shader.PropertyToID("SceneCamera");
		this.CHGMOFGHPND = Shader.PropertyToID("Tenkoku DynamicSky");
		this.MNHEGFNBGBP = Shader.PropertyToID("_Refraction");
		this.OFNKEJPFHPM = Shader.PropertyToID(" has invalid dimensions.");
		this.JHGLFOIFPNA = Shader.PropertyToID("Clear Screen");
		this.BEAGFOMBNIE = Shader.PropertyToID("BowReady2");
		this.HAOPEKACGKJ = Shader.PropertyToID("_ReflectionBlur");
		this.JKPIIPGJCGL = Shader.PropertyToID("-none-");
		this.OLDFANLEEPP = Shader.PropertyToID("Cowboy1HandDraw");
		this.JEBEODKPNBD = Shader.PropertyToID("FOG_LINEAR");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_RgbTex");
		this.BIBGFHMDCOC = Shader.PropertyToID("Mouse ScrollWheel");
		this.PFENCNMEJGE = Shader.PropertyToID("");
		this.NIBOHKNFDPB = Shader.PropertyToID("_Cull");
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x00126EE8 File Offset: 0x001250E8
	public void CAGHJAJMPKM()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("_WrinkleInfluences3");
		this.PBDNAONCCBD = Shader.PropertyToID("CCDIK not found!");
		this.ICEFEJNFPNB = Shader.PropertyToID("Idle Dodge Right");
		this.DNCCNIPJJFP = Shader.PropertyToID("Clear reference not set.");
		this.EPACGLABCFJ = Shader.PropertyToID("/");
		this.CGMKIBNPFFI = Shader.PropertyToID("error.wav");
		this.CMGHEMIEACC = Shader.PropertyToID("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774");
		this.MIKPHLGJFKC = Shader.PropertyToID("ObscuredUInt vs uint, ");
		this.PMDMDAEHDFE = Shader.PropertyToID("_AutoExposure");
		this.LAOIHBNKNDC = Shader.PropertyToID("</color>");
		this.DKIOGOAGEMJ = Shader.PropertyToID("noproff");
		this.LNJEDJHGDBA = Shader.PropertyToID("shop_t8");
		this.PCGJBGMPMPJ = Shader.PropertyToID("25");
		this.LCFIPCLBNCP = Shader.PropertyToID(" has been disabled as it's not supported on the current platform.");
		this.GHENKAHBNGH = Shader.PropertyToID("offsets");
		this.DIMGPCEBEGE = Shader.PropertyToID("PistolLeftHandStab");
		this.AHNEKMDHFKC = Shader.PropertyToID("GiantGrabThrow");
		this.IGOEANOOFFF = Shader.PropertyToID("WeaponReload");
		this.OFHAIPIBDBC = Shader.PropertyToID("");
		this.NJIOJANKEDD = Shader.PropertyToID("wpn_add/base");
		this.OEIDCFLBDAL = Shader.PropertyToID("demoQuaternion");
		this.FNCBANADCBJ = Shader.PropertyToID("Brake");
		this.MAMMKBMCDED = Shader.PropertyToID("\n");
		this.ALMNFJFCEKI = Shader.PropertyToID("");
		this.IHHIGFMOPHG = Shader.PropertyToID("gi_fridge");
		this.CHGMOFGHPND = Shader.PropertyToID("threshold");
		this.MNHEGFNBGBP = Shader.PropertyToID("x");
		this.OFNKEJPFHPM = Shader.PropertyToID("Money: ");
		this.JHGLFOIFPNA = Shader.PropertyToID("_SrcBlend");
		this.BEAGFOMBNIE = Shader.PropertyToID("IdleBandage");
		this.HAOPEKACGKJ = Shader.PropertyToID("PistolReady");
		this.JKPIIPGJCGL = Shader.PropertyToID("_BlurTexture");
		this.OLDFANLEEPP = Shader.PropertyToID("qd_week");
		this.JEBEODKPNBD = Shader.PropertyToID("MotorbikeSpecialFlip");
		this.FPFCLGAHHPJ = Shader.PropertyToID("WalkDehydrated");
		this.BIBGFHMDCOC = Shader.PropertyToID("BuY");
		this.PFENCNMEJGE = Shader.PropertyToID("crft_recnt");
		this.NIBOHKNFDPB = Shader.PropertyToID("BuY");
	}

	// Token: 0x06002909 RID: 10505 RVA: 0x00127158 File Offset: 0x00125358
	public static Mesh OBDJOEEDFJL(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[0];
		array[0] = "USE_PREDICATION";
		array[0] = GDCMKLMHFLI;
		array[0] = "RHandPunch";
		array[8] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[3];
		array2[1] = new Vector3(832f, 1465f, 372f);
		array2[1] = new Vector3(351f, 1853f, 1875f);
		array2[7] = new Vector3(232f, 106f, 883f);
		array2[5] = new Vector3(810f, 1287f, 436f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[8];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[]
		{
			default(Vector3),
			new Vector3(440f, 1878f, 388f)
		};
		array5[0] = new Vector3(1154f, 355f, 1015f);
		array5[3] = new Vector3(1640f, 179f, 593f);
		array5[4] = new Vector3(1028f, 1085f, 655f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[]
		{
			default(Vector4),
			new Vector4(23f, 527f, 991f, 603f)
		};
		array6[1] = new Vector4(537f, 1291f, 1671f, 1189f);
		array6[3] = new Vector4(157f, 284f, 1193f, 1783f);
		array6[6] = new Vector4(328f, 1717f, 1931f, 1731f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x001273A0 File Offset: 0x001255A0
	public void CMMKNLOCJHD()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("reqperk");
		this.PBDNAONCCBD = Shader.PropertyToID("RandomizeObscuredVars");
		this.ICEFEJNFPNB = Shader.PropertyToID("_FgCocMask");
		this.DNCCNIPJJFP = Shader.PropertyToID("auk_wavg");
		this.EPACGLABCFJ = Shader.PropertyToID("The polygon must have at least 3 Limit Points.");
		this.CGMKIBNPFFI = Shader.PropertyToID("Установлен <b>");
		this.CMGHEMIEACC = Shader.PropertyToID("WorkerPickaxe");
		this.MIKPHLGJFKC = Shader.PropertyToID("B");
		this.PMDMDAEHDFE = Shader.PropertyToID(" ");
		this.LAOIHBNKNDC = Shader.PropertyToID("_Gamma");
		this.DKIOGOAGEMJ = Shader.PropertyToID("_FogSkyColor");
		this.LNJEDJHGDBA = Shader.PropertyToID("");
		this.PCGJBGMPMPJ = Shader.PropertyToID("Water");
		this.LCFIPCLBNCP = Shader.PropertyToID("HeelClick");
		this.GHENKAHBNGH = Shader.PropertyToID("poplSoundIndex");
		this.DIMGPCEBEGE = Shader.PropertyToID("SoccerWalk");
		this.AHNEKMDHFKC = Shader.PropertyToID("\n<color='#{0}'>+{2} '{1}'</color> ");
		this.IGOEANOOFFF = Shader.PropertyToID("часов");
		this.OFHAIPIBDBC = Shader.PropertyToID("IceHockeyGoalieReady");
		this.NJIOJANKEDD = Shader.PropertyToID("=");
		this.OEIDCFLBDAL = Shader.PropertyToID("CraftProf.xml");
		this.FNCBANADCBJ = Shader.PropertyToID("fishsplash{0}.ogg");
		this.MAMMKBMCDED = Shader.PropertyToID("IceHockeySlapShot");
		this.ALMNFJFCEKI = Shader.PropertyToID("UnityEngine.Vector4");
		this.IHHIGFMOPHG = Shader.PropertyToID("auk_wmin");
		this.CHGMOFGHPND = Shader.PropertyToID("rbon");
		this.MNHEGFNBGBP = Shader.PropertyToID("isRodOpen");
		this.OFNKEJPFHPM = Shader.PropertyToID("IdleDie");
		this.JHGLFOIFPNA = Shader.PropertyToID("<color='#004000'>{0}</color>");
		this.BEAGFOMBNIE = Shader.PropertyToID(" ");
		this.HAOPEKACGKJ = Shader.PropertyToID("GestureCrowdPump");
		this.JKPIIPGJCGL = Shader.PropertyToID("KatanaReady");
		this.OLDFANLEEPP = Shader.PropertyToID("Move camera around freely with WASD and mouse.");
		this.JEBEODKPNBD = Shader.PropertyToID("*************157 baseid=");
		this.FPFCLGAHHPJ = Shader.PropertyToID("cht_ach3");
		this.BIBGFHMDCOC = Shader.PropertyToID("id");
		this.PFENCNMEJGE = Shader.PropertyToID("");
		this.NIBOHKNFDPB = Shader.PropertyToID("cht_tofrendno");
	}

	// Token: 0x0600290B RID: 10507 RVA: 0x00127610 File Offset: 0x00125810
	public static Mesh EOJGDJLIPJO(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[0] = "\n<color='";
		array[1] = GDCMKLMHFLI;
		array[2] = "NextFrame";
		array[8] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[8];
		array2[1] = new Vector3(807f, 1154f, 718f);
		array2[1] = new Vector3(301f, 1750f, 537f);
		array2[3] = new Vector3(839f, 382f, 1337f);
		array2[4] = new Vector3(1059f, 64f, 1392f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[7];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[]
		{
			new Vector3(1621f, 40f, 1590f)
		};
		array4[0] = new Vector3(257f, 1990f, 134f);
		array4[2] = new Vector3(890f, 1814f, 510f);
		array4[7] = new Vector3(1696f, 1142f, 1051f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[0];
		array5[0] = new Vector4(1914f, 1657f, 907f, 474f);
		array5[1] = new Vector4(604f, 7f, 753f, 1993f);
		array5[6] = new Vector4(179f, 1719f, 407f, 1540f);
		array5[1] = new Vector4(419f, 490f, 1097f, 1427f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x00127858 File Offset: 0x00125A58
	public void IANOPLMBIPO()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("FactoryTempTexture");
		this.PBDNAONCCBD = Shader.PropertyToID("_ColorBuffer");
		this.ICEFEJNFPNB = Shader.PropertyToID("Assets/Heads/head_");
		this.DNCCNIPJJFP = Shader.PropertyToID("Vertical");
		this.EPACGLABCFJ = Shader.PropertyToID("\n");
		this.CGMKIBNPFFI = Shader.PropertyToID("_camRotate");
		this.CMGHEMIEACC = Shader.PropertyToID("OfficeSittingLegCross");
		this.MIKPHLGJFKC = Shader.PropertyToID("KatanaReadyLow");
		this.PMDMDAEHDFE = Shader.PropertyToID("Music: ");
		this.LAOIHBNKNDC = Shader.PropertyToID("post_msg3");
		this.DKIOGOAGEMJ = Shader.PropertyToID("cnt_energ");
		this.LNJEDJHGDBA = Shader.PropertyToID("  locid=");
		this.PCGJBGMPMPJ = Shader.PropertyToID("reel_type2");
		this.LCFIPCLBNCP = Shader.PropertyToID("cht_ach3");
		this.GHENKAHBNGH = Shader.PropertyToID("Wizard Overhead");
		this.DIMGPCEBEGE = Shader.PropertyToID("Horizontal");
		this.AHNEKMDHFKC = Shader.PropertyToID("");
		this.IGOEANOOFFF = Shader.PropertyToID("R");
		this.OFHAIPIBDBC = Shader.PropertyToID("_WaterLevel");
		this.NJIOJANKEDD = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html");
		this.OEIDCFLBDAL = Shader.PropertyToID("_FadeDistance");
		this.FNCBANADCBJ = Shader.PropertyToID("lastRatingIndex");
		this.MAMMKBMCDED = Shader.PropertyToID("800000");
		this.ALMNFJFCEKI = Shader.PropertyToID("MotorbikeLookBack");
		this.IHHIGFMOPHG = Shader.PropertyToID("{0}/{1}");
		this.CHGMOFGHPND = Shader.PropertyToID("Horizontal");
		this.MNHEGFNBGBP = Shader.PropertyToID("{0} {1}.{2} ({3:f2}, {4:f2})  {5}");
		this.OFNKEJPFHPM = Shader.PropertyToID("ShotgunFire");
		this.JHGLFOIFPNA = Shader.PropertyToID("wpn_add/base");
		this.BEAGFOMBNIE = Shader.PropertyToID("_Grain_Params2");
		this.HAOPEKACGKJ = Shader.PropertyToID("OfficeSittingReadingPageFlip");
		this.JKPIIPGJCGL = Shader.PropertyToID("OfficeSittingEyesRub");
		this.OLDFANLEEPP = Shader.PropertyToID("_LayerThickness");
		this.JEBEODKPNBD = Shader.PropertyToID("Swim");
		this.FPFCLGAHHPJ = Shader.PropertyToID("ZombieIdle");
		this.BIBGFHMDCOC = Shader.PropertyToID("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
		this.PFENCNMEJGE = Shader.PropertyToID("t_much");
		this.NIBOHKNFDPB = Shader.PropertyToID("FlyForward");
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x00127AC8 File Offset: 0x00125CC8
	public static Mesh HHGPBGDOFBF(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[1] = "-S";
		array[1] = GDCMKLMHFLI;
		array[5] = "inventoryOpen";
		array[1] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[4];
		array2[1] = new Vector3(1631f, 381f, 762f);
		array2[1] = new Vector3(579f, 1454f, 1416f);
		array2[2] = new Vector3(447f, 1039f, 954f);
		array2[8] = new Vector3(740f, 1105f, 1094f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[8];
		array4[1] = new Vector3(635f, 47f, 953f);
		array4[1] = new Vector3(46f, 548f, 1762f);
		array4[6] = new Vector3(1092f, 1585f, 835f);
		array4[0] = new Vector3(175f, 1241f, 1192f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[8];
		array5[1] = new Vector4(205f, 1379f, 1599f, 1083f);
		array5[0] = new Vector4(159f, 613f, 20f, 9f);
		array5[1] = new Vector4(897f, 260f, 562f, 225f);
		array5[4] = new Vector4(1686f, 1378f, 126f, 1571f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x00127D10 File Offset: 0x00125F10
	public static Mesh CJFACLAADNP(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[3];
		array[0] = "AccID:{0} PlayID:{1} StN:{2}";
		array[1] = GDCMKLMHFLI;
		array[0] = "IceHockeySlapShot";
		array[6] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[0] = new Vector3(1763f, 276f, 1193f);
		array2[1] = new Vector3(748f, 1794f, 1978f);
		array2[0] = new Vector3(1405f, 1299f, 1810f);
		array2[2] = new Vector3(88f, 1183f, 195f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[3];
		array4[0] = new Vector3(1260f, 1205f, 1850f);
		array4[0] = new Vector3(1337f, 975f, 507f);
		array4[3] = new Vector3(1899f, 1911f, 1607f);
		array4[4] = new Vector3(1531f, 1422f, 1674f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[0];
		array5[0] = new Vector4(1238f, 859f, 768f, 546f);
		array5[0] = new Vector4(900f, 606f, 905f, 890f);
		array5[7] = new Vector4(1114f, 1653f, 567f, 45f);
		array5[7] = new Vector4(944f, 225f, 1932f, 320f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600290F RID: 10511 RVA: 0x00127F58 File Offset: 0x00126158
	public void NOFNCDHHGKL()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("Katana Ninja Draw");
		this.PBDNAONCCBD = Shader.PropertyToID("GestureWonderful");
		this.ICEFEJNFPNB = Shader.PropertyToID("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}");
		this.DNCCNIPJJFP = Shader.PropertyToID("Run Back Left");
		this.EPACGLABCFJ = Shader.PropertyToID("[");
		this.CGMKIBNPFFI = Shader.PropertyToID("LHandWeight");
		this.CMGHEMIEACC = Shader.PropertyToID("Attempting to RefreshSceneDecals without a packed material");
		this.MIKPHLGJFKC = Shader.PropertyToID("Roller Crossover Left");
		this.PMDMDAEHDFE = Shader.PropertyToID("ShotgunReloadChamber");
		this.LAOIHBNKNDC = Shader.PropertyToID("ScubaSwim");
		this.DKIOGOAGEMJ = Shader.PropertyToID(" is represented multiple times in a single IK chain. Can't initiate solver.");
		this.LNJEDJHGDBA = Shader.PropertyToID("KatanaReady");
		this.PCGJBGMPMPJ = Shader.PropertyToID("H:");
		this.LCFIPCLBNCP = Shader.PropertyToID("ArmFlex2");
		this.GHENKAHBNGH = Shader.PropertyToID("Textures/alphaDemo");
		this.DIMGPCEBEGE = Shader.PropertyToID("line_type");
		this.AHNEKMDHFKC = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
		this.IGOEANOOFFF = Shader.PropertyToID("SoccerPassLight");
		this.OFHAIPIBDBC = Shader.PropertyToID("(Org: ");
		this.NJIOJANKEDD = Shader.PropertyToID("Giant 2 Hand Grab/Throw");
		this.OEIDCFLBDAL = Shader.PropertyToID(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		this.FNCBANADCBJ = Shader.PropertyToID("error");
		this.MAMMKBMCDED = Shader.PropertyToID("Giant2HandSlamSwing");
		this.ALMNFJFCEKI = Shader.PropertyToID("CheerJump");
		this.IHHIGFMOPHG = Shader.PropertyToID("IdleStrafeLeft");
		this.CHGMOFGHPND = Shader.PropertyToID("demoUint");
		this.MNHEGFNBGBP = Shader.PropertyToID("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).");
		this.OFNKEJPFHPM = Shader.PropertyToID("* read base id=");
		this.JHGLFOIFPNA = Shader.PropertyToID("");
		this.BEAGFOMBNIE = Shader.PropertyToID("knopje.wav");
		this.HAOPEKACGKJ = Shader.PropertyToID("Проверка предмета");
		this.JKPIIPGJCGL = Shader.PropertyToID("-H");
		this.OLDFANLEEPP = Shader.PropertyToID("(");
		this.JEBEODKPNBD = Shader.PropertyToID("gi_uinf_4");
		this.FPFCLGAHHPJ = Shader.PropertyToID("");
		this.BIBGFHMDCOC = Shader.PropertyToID("private");
		this.PFENCNMEJGE = Shader.PropertyToID("get 1401 cmd");
		this.NIBOHKNFDPB = Shader.PropertyToID("StaffStand");
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x001281C8 File Offset: 0x001263C8
	public static Mesh PCNGIHMLJKN(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[7];
		array[1] = "Grounding layers are set to nothing. Please add a ground layer.";
		array[1] = GDCMKLMHFLI;
		array[0] = "CHROMATIC_ABERRATION";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[0] = new Vector3(1744f, 82f, 1583f);
		array2[0] = new Vector3(1605f, 723f, 1780f);
		array2[3] = new Vector3(1852f, 532f, 1807f);
		array2[4] = new Vector3(546f, 1705f, 1415f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[8] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[0];
		array5[0] = new Vector3(4f, 1106f, 1100f);
		array5[0] = new Vector3(1078f, 600f, 1237f);
		array5[2] = new Vector3(841f, 1773f, 572f);
		array5[8] = new Vector3(276f, 1455f, 493f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[4];
		array6[0] = new Vector4(1986f, 1360f, 1899f, 1926f);
		array6[0] = new Vector4(68f, 1143f, 56f, 322f);
		array6[8] = new Vector4(292f, 988f, 46f, 1720f);
		array6[2] = new Vector4(1645f, 1766f, 1578f, 1195f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002911 RID: 10513 RVA: 0x00128410 File Offset: 0x00126610
	public static Mesh LMEIPAJHBJF(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "";
		array[0] = GDCMKLMHFLI;
		array[6] = "_Offsets";
		array[5] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[7];
		array2[1] = new Vector3(133f, 1034f, 943f);
		array2[1] = new Vector3(1433f, 527f, 192f);
		array2[7] = new Vector3(1249f, 726f, 403f);
		array2[1] = new Vector3(91f, 1848f, 1660f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[3];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[3];
		array5[0] = new Vector3(612f, 975f, 1541f);
		array5[1] = new Vector3(599f, 963f, 1216f);
		array5[5] = new Vector3(1443f, 1109f, 298f);
		array5[6] = new Vector3(265f, 505f, 828f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[0];
		array6[1] = new Vector4(1745f, 287f, 453f, 1191f);
		array6[0] = new Vector4(798f, 1766f, 1955f, 1801f);
		array6[6] = new Vector4(1336f, 764f, 1797f, 1582f);
		array6[5] = new Vector4(1434f, 123f, 330f, 607f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x00128658 File Offset: 0x00126858
	public void JINDMFBKGKH()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("MotorbikeLasso");
		this.PBDNAONCCBD = Shader.PropertyToID("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
		this.ICEFEJNFPNB = Shader.PropertyToID("IdleStand");
		this.DNCCNIPJJFP = Shader.PropertyToID("wgt_kg");
		this.EPACGLABCFJ = Shader.PropertyToID("\n");
		this.CGMKIBNPFFI = Shader.PropertyToID("category");
		this.CMGHEMIEACC = Shader.PropertyToID("");
		this.MIKPHLGJFKC = Shader.PropertyToID("IdleReady");
		this.PMDMDAEHDFE = Shader.PropertyToID("_DisplayVelocityScale");
		this.LAOIHBNKNDC = Shader.PropertyToID("FlyBackward");
		this.DKIOGOAGEMJ = Shader.PropertyToID(" ");
		this.LNJEDJHGDBA = Shader.PropertyToID("128");
		this.PCGJBGMPMPJ = Shader.PropertyToID(" (");
		this.LCFIPCLBNCP = Shader.PropertyToID("Run Back Left");
		this.GHENKAHBNGH = Shader.PropertyToID("Orthographic");
		this.DIMGPCEBEGE = Shader.PropertyToID("MotorbikeSpecialFlip");
		this.AHNEKMDHFKC = Shader.PropertyToID("Idle Dodge Left");
		this.IGOEANOOFFF = Shader.PropertyToID("Kernel");
		this.OFHAIPIBDBC = Shader.PropertyToID("RollerBladeSkateFwd");
		this.NJIOJANKEDD = Shader.PropertyToID("SoccerKeeperDiveStrafeCloseLeft");
		this.OEIDCFLBDAL = Shader.PropertyToID("GiantGrabThrow");
		this.FNCBANADCBJ = Shader.PropertyToID(" ");
		this.MAMMKBMCDED = Shader.PropertyToID(" has been disabled as it's not supported on the current platform.");
		this.ALMNFJFCEKI = Shader.PropertyToID("_FresnelFade");
		this.IHHIGFMOPHG = Shader.PropertyToID("3");
		this.CHGMOFGHPND = Shader.PropertyToID("PLANE_REFLECTION");
		this.MNHEGFNBGBP = Shader.PropertyToID("OnChatMessage");
		this.OFNKEJPFHPM = Shader.PropertyToID("OfficeSittingReading");
		this.JHGLFOIFPNA = Shader.PropertyToID("MotorbikeIdle");
		this.BEAGFOMBNIE = Shader.PropertyToID("Animation controllers should be parented to character controllers!");
		this.HAOPEKACGKJ = Shader.PropertyToID("Pistol");
		this.JKPIIPGJCGL = Shader.PropertyToID("line_type");
		this.OLDFANLEEPP = Shader.PropertyToID("no_change");
		this.JEBEODKPNBD = Shader.PropertyToID("OneHandSwordReady");
		this.FPFCLGAHHPJ = Shader.PropertyToID("defDur");
		this.BIBGFHMDCOC = Shader.PropertyToID("money");
		this.PFENCNMEJGE = Shader.PropertyToID("Jump");
		this.NIBOHKNFDPB = Shader.PropertyToID("KatanaReady");
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x001288C8 File Offset: 0x00126AC8
	public static Mesh FECBJDCIAMA(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[0];
		array[0] = "";
		array[0] = GDCMKLMHFLI;
		array[5] = "knopje.wav";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[0] = new Vector3(163f, 175f, 1444f);
		array2[1] = new Vector3(570f, 158f, 547f);
		array2[6] = new Vector3(1945f, 1373f, 1669f);
		array2[1] = new Vector3(171f, 1144f, 1901f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[7];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[8] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[1];
		array4[1] = new Vector3(915f, 445f, 977f);
		array4[0] = new Vector3(788f, 356f, 1573f);
		array4[7] = new Vector3(1930f, 388f, 350f);
		array4[8] = new Vector3(1897f, 777f, 1133f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[5];
		array5[1] = new Vector4(1984f, 770f, 1339f, 1850f);
		array5[1] = new Vector4(1519f, 1859f, 1726f, 1267f);
		array5[2] = new Vector4(554f, 358f, 1035f, 1887f);
		array5[5] = new Vector4(1891f, 1075f, 529f, 931f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002914 RID: 10516 RVA: 0x00128B10 File Offset: 0x00126D10
	public static Mesh GOAOBAKNOPM(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[1] = "CrouchStrafeRight";
		array[1] = GDCMKLMHFLI;
		array[5] = "IdleReadyCrouch";
		array[0] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[2];
		array2[0] = new Vector3(1475f, 249f, 374f);
		array2[0] = new Vector3(911f, 778f, 1801f);
		array2[3] = new Vector3(950f, 1958f, 463f);
		array2[7] = new Vector3(1891f, 1059f, 1975f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[4];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[6];
		array4[0] = new Vector3(46f, 1452f, 904f);
		array4[1] = new Vector3(172f, 908f, 1202f);
		array4[8] = new Vector3(1488f, 1513f, 474f);
		array4[8] = new Vector3(152f, 115f, 1621f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[7];
		array5[0] = new Vector4(1048f, 1436f, 1844f, 803f);
		array5[1] = new Vector4(274f, 1182f, 381f, 491f);
		array5[3] = new Vector4(700f, 271f, 1154f, 457f);
		array5[0] = new Vector4(1968f, 1816f, 327f, 1290f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x00128D58 File Offset: 0x00126F58
	public static Mesh MLIOGHHLJLF(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[0] = "Gesture No Fear";
		array[1] = GDCMKLMHFLI;
		array[3] = "ShotgunFire";
		array[5] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[]
		{
			default(Vector3),
			new Vector3(256f, 1294f, 1884f)
		};
		array2[1] = new Vector3(368f, 1022f, 1974f);
		array2[1] = new Vector3(321f, 649f, 117f);
		array2[3] = new Vector3(1408f, 736f, 1768f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[0];
		array4[1] = new Vector3(1614f, 1026f, 895f);
		array4[1] = new Vector3(361f, 1938f, 1171f);
		array4[1] = new Vector3(529f, 647f, 265f);
		array4[2] = new Vector3(806f, 1236f, 949f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			new Vector4(1548f, 18f, 712f, 1598f)
		};
		array5[0] = new Vector4(856f, 434f, 158f, 356f);
		array5[3] = new Vector4(1355f, 875f, 297f, 1777f);
		array5[2] = new Vector4(146f, 290f, 269f, 193f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002916 RID: 10518 RVA: 0x00128FA0 File Offset: 0x001271A0
	public void DECDNDMLEMN()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("1HandHeavySwing");
		this.PBDNAONCCBD = Shader.PropertyToID("offsets");
		this.ICEFEJNFPNB = Shader.PropertyToID("SteamPay error via request");
		this.DNCCNIPJJFP = Shader.PropertyToID("craft_data/categories/category");
		this.EPACGLABCFJ = Shader.PropertyToID("cht_ach3");
		this.CGMKIBNPFFI = Shader.PropertyToID("name");
		this.CMGHEMIEACC = Shader.PropertyToID("Transforms[");
		this.MIKPHLGJFKC = Shader.PropertyToID("OneHandSwordBackSwing");
		this.PMDMDAEHDFE = Shader.PropertyToID("isLocalServer");
		this.LAOIHBNKNDC = Shader.PropertyToID("<color='#ffa000'>неизвестная профессия");
		this.DKIOGOAGEMJ = Shader.PropertyToID("ClimbUp");
		this.LNJEDJHGDBA = Shader.PropertyToID("RollerBladeBackFlip");
		this.PCGJBGMPMPJ = Shader.PropertyToID("ZombieCrawl");
		this.LCFIPCLBNCP = Shader.PropertyToID("error.wav");
		this.GHENKAHBNGH = Shader.PropertyToID("Ball");
		this.DIMGPCEBEGE = Shader.PropertyToID("");
		this.AHNEKMDHFKC = Shader.PropertyToID("IdleStandingJump");
		this.IGOEANOOFFF = Shader.PropertyToID("WeaponFire");
		this.OFHAIPIBDBC = Shader.PropertyToID("{0}/{1}");
		this.NJIOJANKEDD = Shader.PropertyToID("fish/");
		this.OEIDCFLBDAL = Shader.PropertyToID("");
		this.FNCBANADCBJ = Shader.PropertyToID("knopje.wav");
		this.MAMMKBMCDED = Shader.PropertyToID("demoRect");
		this.ALMNFJFCEKI = Shader.PropertyToID("sunshine_ShadowFadeParams");
		this.IHHIGFMOPHG = Shader.PropertyToID("NextFrame");
		this.CHGMOFGHPND = Shader.PropertyToID("FaceHit");
		this.MNHEGFNBGBP = Shader.PropertyToID("Giant3HitCombo2");
		this.OFNKEJPFHPM = Shader.PropertyToID("ShotgunReloadMagazine");
		this.JHGLFOIFPNA = Shader.PropertyToID("noDress");
		this.BEAGFOMBNIE = Shader.PropertyToID("_Highlighted");
		this.HAOPEKACGKJ = Shader.PropertyToID("Horizontal");
		this.JKPIIPGJCGL = Shader.PropertyToID("");
		this.OLDFANLEEPP = Shader.PropertyToID("IdleSad");
		this.JEBEODKPNBD = Shader.PropertyToID("Add random value");
		this.FPFCLGAHHPJ = Shader.PropertyToID("Shader \"GUI/BackImage\" {Properties {_MainTex (\"Base (RGB) Trans (A)\", 2D) = \"white\" {}_Color (\" color\", color) = (1,1,1,1)}SubShader {\t\tTags { \"Queue\"=\"Background\" \"IgnoreProjector\"=\"True\" \"RenderType\"=\"Background\" }\tLighting Off Cull Off ZTest Always ZWrite Off Fog { Mode Off }\tZWrite Off\tBlend SrcAlpha OneMinusSrcAlpha\tPass {\t\tLighting Off\t\tcolor [_Color]   \t\tSetTexture [_MainTex] {combine texture * primary }\t\t\t}}}");
		this.BIBGFHMDCOC = Shader.PropertyToID("");
		this.PFENCNMEJGE = Shader.PropertyToID("#000000");
		this.NIBOHKNFDPB = Shader.PropertyToID("cntx_use");
	}

	// Token: 0x06002917 RID: 10519 RVA: 0x00129210 File Offset: 0x00127410
	public static Mesh LJKFELNNGAB(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[5];
		array[0] = "http://www.root-motion.com/finalikdox/html/page5.html";
		array[0] = GDCMKLMHFLI;
		array[6] = "delacc";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[6];
		array2[1] = new Vector3(1026f, 437f, 684f);
		array2[1] = new Vector3(901f, 1637f, 513f);
		array2[4] = new Vector3(797f, 1067f, 410f);
		array2[2] = new Vector3(281f, 533f, 1871f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[8];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[8];
		array4[0] = new Vector3(919f, 777f, 1741f);
		array4[1] = new Vector3(701f, 1260f, 531f);
		array4[4] = new Vector3(1063f, 1901f, 1773f);
		array4[6] = new Vector3(1017f, 693f, 1900f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[4];
		array5[1] = new Vector4(587f, 1410f, 601f, 879f);
		array5[1] = new Vector4(928f, 895f, 79f, 1869f);
		array5[4] = new Vector4(1024f, 332f, 1838f, 1039f);
		array5[8] = new Vector4(1115f, 119f, 1764f, 392f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x00129458 File Offset: 0x00127658
	public static Mesh CreateQuad(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		return new Mesh
		{
			name = string.Concat(new object[]
			{
				"Quad ",
				GDCMKLMHFLI,
				" ",
				PCHICFGNFGF
			}),
			vertices = new Vector3[]
			{
				new Vector3(-1f, -1f, 0f),
				new Vector3(-1f, 1f, 0f),
				new Vector3(1f, 1f, 0f),
				new Vector3(1f, -1f, 0f)
			},
			uv = new Vector2[]
			{
				new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y),
				new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y),
				new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y),
				new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y)
			},
			triangles = new int[]
			{
				0,
				3,
				2,
				0,
				2,
				1
			},
			normals = new Vector3[]
			{
				new Vector3(0f, 0f, 1f),
				new Vector3(0f, 0f, 1f),
				new Vector3(0f, 0f, 1f),
				new Vector3(0f, 0f, 1f)
			},
			tangents = new Vector4[]
			{
				new Vector4(1f, 0f, 0f, 1f),
				new Vector4(1f, 0f, 0f, 1f),
				new Vector4(1f, 0f, 0f, 1f),
				new Vector4(1f, 0f, 0f, 1f)
			}
		};
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x001296A0 File Offset: 0x001278A0
	public void PMIKFFHCKPO()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
		this.PBDNAONCCBD = Shader.PropertyToID("openPodsak");
		this.ICEFEJNFPNB = Shader.PropertyToID("Textures/NoImage.png");
		this.DNCCNIPJJFP = Shader.PropertyToID("RollerBladeGrindRoyale");
		this.EPACGLABCFJ = Shader.PropertyToID("&");
		this.CGMKIBNPFFI = Shader.PropertyToID("wpn_rod2");
		this.CMGHEMIEACC = Shader.PropertyToID("_ColorBuffer");
		this.MIKPHLGJFKC = Shader.PropertyToID("DealerShuffle");
		this.PMDMDAEHDFE = Shader.PropertyToID("Staff Stand");
		this.LAOIHBNKNDC = Shader.PropertyToID("SUNSHINE_FILTER_PCF_2x2");
		this.DKIOGOAGEMJ = Shader.PropertyToID("MotorbikeBackwardSitting");
		this.LNJEDJHGDBA = Shader.PropertyToID("lifeBar");
		this.PCGJBGMPMPJ = Shader.PropertyToID("Horizontal");
		this.LCFIPCLBNCP = Shader.PropertyToID("Flashlight");
		this.GHENKAHBNGH = Shader.PropertyToID("_isSelect");
		this.DIMGPCEBEGE = Shader.PropertyToID("ArmFlex5");
		this.AHNEKMDHFKC = Shader.PropertyToID("******** ChatPanelPos ");
		this.IGOEANOOFFF = Shader.PropertyToID("");
		this.OFHAIPIBDBC = Shader.PropertyToID("ZombieIdle");
		this.NJIOJANKEDD = Shader.PropertyToID("WeaponFire");
		this.OEIDCFLBDAL = Shader.PropertyToID("steamno");
		this.FNCBANADCBJ = Shader.PropertyToID("SYS");
		this.MAMMKBMCDED = Shader.PropertyToID("IdleReadyLook");
		this.ALMNFJFCEKI = Shader.PropertyToID("_BlurRadius4");
		this.IHHIGFMOPHG = Shader.PropertyToID("KatanaUpperBlock");
		this.CHGMOFGHPND = Shader.PropertyToID("RenderType");
		this.MNHEGFNBGBP = Shader.PropertyToID("IceHockeyIdle");
		this.OFNKEJPFHPM = Shader.PropertyToID("<color='{0}'> Очков работы: {1}</color>");
		this.JHGLFOIFPNA = Shader.PropertyToID("pinky");
		this.BEAGFOMBNIE = Shader.PropertyToID("1/");
		this.HAOPEKACGKJ = Shader.PropertyToID("Textures/Fish/");
		this.JKPIIPGJCGL = Shader.PropertyToID("");
		this.OLDFANLEEPP = Shader.PropertyToID("Smoking1");
		this.JEBEODKPNBD = Shader.PropertyToID(" гр ");
		this.FPFCLGAHHPJ = Shader.PropertyToID("repair.ogg");
		this.BIBGFHMDCOC = Shader.PropertyToID("rotTime is NaN");
		this.PFENCNMEJGE = Shader.PropertyToID("Idle Eat");
		this.NIBOHKNFDPB = Shader.PropertyToID("isNoShowChat");
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x00129910 File Offset: 0x00127B10
	public static Mesh KILPBAFIIDA(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[0] = "Swim Freestyle";
		array[0] = GDCMKLMHFLI;
		array[3] = " ms";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[6];
		array2[1] = new Vector3(440f, 1292f, 1556f);
		array2[1] = new Vector3(1419f, 902f, 398f);
		array2[8] = new Vector3(146f, 345f, 498f);
		array2[8] = new Vector3(739f, 462f, 1400f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[]
		{
			default(Vector2),
			new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y)
		};
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[0];
		array4[0] = new Vector3(1309f, 1779f, 1853f);
		array4[1] = new Vector3(1503f, 1869f, 248f);
		array4[7] = new Vector3(108f, 696f, 242f);
		array4[4] = new Vector3(1143f, 1251f, 1741f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[2];
		array5[0] = new Vector4(523f, 485f, 1836f, 1937f);
		array5[0] = new Vector4(1662f, 1144f, 1651f, 766f);
		array5[0] = new Vector4(1120f, 170f, 592f, 1859f);
		array5[6] = new Vector4(311f, 1034f, 247f, 127f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x00129B58 File Offset: 0x00127D58
	public void HPNAMJJHDIN()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("OfficeSittingBack");
		this.PBDNAONCCBD = Shader.PropertyToID("GiantGrabThrow");
		this.ICEFEJNFPNB = Shader.PropertyToID("Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order.");
		this.DNCCNIPJJFP = Shader.PropertyToID("Ошибка создания предмета");
		this.EPACGLABCFJ = Shader.PropertyToID("jamp");
		this.CGMKIBNPFFI = Shader.PropertyToID("\n");
		this.CMGHEMIEACC = Shader.PropertyToID("Press R or LMB for procedural recoil.");
		this.MIKPHLGJFKC = Shader.PropertyToID("_Metrics");
		this.PMDMDAEHDFE = Shader.PropertyToID("wpn_cmp");
		this.LAOIHBNKNDC = Shader.PropertyToID("val=");
		this.DKIOGOAGEMJ = Shader.PropertyToID("]");
		this.LNJEDJHGDBA = Shader.PropertyToID("Yawn");
		this.PCGJBGMPMPJ = Shader.PropertyToID("IceHockeyDekeMiddle");
		this.LCFIPCLBNCP = Shader.PropertyToID("useSrcAlphaAsMask");
		this.GHENKAHBNGH = Shader.PropertyToID("Run Back Right");
		this.DIMGPCEBEGE = Shader.PropertyToID("UpHillWalk");
		this.AHNEKMDHFKC = Shader.PropertyToID("MotorbikeBackwardSittingCheer");
		this.IGOEANOOFFF = Shader.PropertyToID("\n");
		this.OFHAIPIBDBC = Shader.PropertyToID("IKSolverFABRIKRoot contains no chains.");
		this.NJIOJANKEDD = Shader.PropertyToID("help");
		this.OEIDCFLBDAL = Shader.PropertyToID("OneHandSwordRun");
		this.FNCBANADCBJ = Shader.PropertyToID("");
		this.MAMMKBMCDED = Shader.PropertyToID("{0} / {1}");
		this.ALMNFJFCEKI = Shader.PropertyToID("B");
		this.IHHIGFMOPHG = Shader.PropertyToID("****** FlyIcon tmpl is null id=");
		this.CHGMOFGHPND = Shader.PropertyToID("isNoShowChat");
		this.MNHEGFNBGBP = Shader.PropertyToID("<color='{0}'>{1}</color>");
		this.OFNKEJPFHPM = Shader.PropertyToID("active_obj_");
		this.JHGLFOIFPNA = Shader.PropertyToID("cntx_use");
		this.BEAGFOMBNIE = Shader.PropertyToID("Error via final request");
		this.HAOPEKACGKJ = Shader.PropertyToID("_BlurRadius4");
		this.JKPIIPGJCGL = Shader.PropertyToID(" ");
		this.OLDFANLEEPP = Shader.PropertyToID("_DisplayVelocityScale");
		this.JEBEODKPNBD = Shader.PropertyToID("id");
		this.FPFCLGAHHPJ = Shader.PropertyToID("RollerBladeGrindRoyale");
		this.BIBGFHMDCOC = Shader.PropertyToID("gi_uinf_4i");
		this.PFENCNMEJGE = Shader.PropertyToID("demoQuaternion");
		this.NIBOHKNFDPB = Shader.PropertyToID("white");
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x00129DC8 File Offset: 0x00127FC8
	public void FNLBOCLPFHL()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("OneHandSwordReady");
		this.PBDNAONCCBD = Shader.PropertyToID("_ReflectionTexture3");
		this.ICEFEJNFPNB = Shader.PropertyToID("BUMPED");
		this.DNCCNIPJJFP = Shader.PropertyToID("No IK assigned in HitReaction");
		this.EPACGLABCFJ = Shader.PropertyToID("");
		this.CGMKIBNPFFI = Shader.PropertyToID("IdleStun");
		this.CMGHEMIEACC = Shader.PropertyToID("_ChromaticAberration_Amount");
		this.MIKPHLGJFKC = Shader.PropertyToID("End.tif");
		this.PMDMDAEHDFE = Shader.PropertyToID("loadRodObject ");
		this.LAOIHBNKNDC = Shader.PropertyToID("reel_type");
		this.DKIOGOAGEMJ = Shader.PropertyToID("OfficeSittingReadingCoffeeSip");
		this.LNJEDJHGDBA = Shader.PropertyToID("root");
		this.PCGJBGMPMPJ = Shader.PropertyToID(" ms");
		this.LCFIPCLBNCP = Shader.PropertyToID("AC_DITHERING");
		this.GHENKAHBNGH = Shader.PropertyToID("HeelClick");
		this.DIMGPCEBEGE = Shader.PropertyToID("SwimDogPaddle");
		this.AHNEKMDHFKC = Shader.PropertyToID("get_lut");
		this.IGOEANOOFFF = Shader.PropertyToID("<<");
		this.OFHAIPIBDBC = Shader.PropertyToID("'");
		this.NJIOJANKEDD = Shader.PropertyToID("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).");
		this.OEIDCFLBDAL = Shader.PropertyToID("MotorbikeShootFwd");
		this.FNCBANADCBJ = Shader.PropertyToID("wpn_sost");
		this.MAMMKBMCDED = Shader.PropertyToID("USER ID=");
		this.ALMNFJFCEKI = Shader.PropertyToID("Bases/Base_1.unity3d");
		this.IHHIGFMOPHG = Shader.PropertyToID("_LowRez");
		this.CHGMOFGHPND = Shader.PropertyToID("OneHandSwordReady");
		this.MNHEGFNBGBP = Shader.PropertyToID("wpn_fid3");
		this.OFNKEJPFHPM = Shader.PropertyToID("WandStand");
		this.JHGLFOIFPNA = Shader.PropertyToID("AimIK and LookAtIK need to have their 'Target' value assigned.");
		this.BEAGFOMBNIE = Shader.PropertyToID("cht_msg10");
		this.HAOPEKACGKJ = Shader.PropertyToID("wpn_add/use_effect");
		this.JKPIIPGJCGL = Shader.PropertyToID("no_wpn");
		this.OLDFANLEEPP = Shader.PropertyToID(" should be overwritten.");
		this.JEBEODKPNBD = Shader.PropertyToID("t_body");
		this.FPFCLGAHHPJ = Shader.PropertyToID("WorkerShovel");
		this.BIBGFHMDCOC = Shader.PropertyToID("BC ");
		this.PFENCNMEJGE = Shader.PropertyToID("Scuba Swim");
		this.NIBOHKNFDPB = Shader.PropertyToID("SecondaryCausticsProjector");
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x0012A038 File Offset: 0x00128238
	public void DDJAICDOGAC()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("UV3");
		this.PBDNAONCCBD = Shader.PropertyToID("SYS");
		this.ICEFEJNFPNB = Shader.PropertyToID("_FullResolutionFiltering");
		this.DNCCNIPJJFP = Shader.PropertyToID("crft_to");
		this.EPACGLABCFJ = Shader.PropertyToID("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.");
		this.CGMKIBNPFFI = Shader.PropertyToID("IK Effector bone is null.");
		this.CMGHEMIEACC = Shader.PropertyToID("isPaint");
		this.MIKPHLGJFKC = Shader.PropertyToID("Smoking2");
		this.PMDMDAEHDFE = Shader.PropertyToID("_RangeScale");
		this.LAOIHBNKNDC = Shader.PropertyToID("Cloth_01.wav");
		this.DKIOGOAGEMJ = Shader.PropertyToID("_WrinkleNormalMap3");
		this.LNJEDJHGDBA = Shader.PropertyToID("TenkokuModule");
		this.PCGJBGMPMPJ = Shader.PropertyToID("gameComplete");
		this.LCFIPCLBNCP = Shader.PropertyToID("_ReflectionTex");
		this.GHENKAHBNGH = Shader.PropertyToID("Click to instantiate the selected object.");
		this.DIMGPCEBEGE = Shader.PropertyToID("wpn_eat1");
		this.AHNEKMDHFKC = Shader.PropertyToID("BowInstant2");
		this.IGOEANOOFFF = Shader.PropertyToID("IceHockeyPassLeft");
		this.OFHAIPIBDBC = Shader.PropertyToID("");
		this.NJIOJANKEDD = Shader.PropertyToID("_WrinkleInfluences1");
		this.OEIDCFLBDAL = Shader.PropertyToID("reputaion/fractions/fraction");
		this.FNCBANADCBJ = Shader.PropertyToID("Bend Constraint is referencing to a bone '");
		this.MAMMKBMCDED = Shader.PropertyToID("TOD_CloudDensity");
		this.ALMNFJFCEKI = Shader.PropertyToID("gi_um_2");
		this.IHHIGFMOPHG = Shader.PropertyToID("_ExposureEV");
		this.CHGMOFGHPND = Shader.PropertyToID("offsets");
		this.MNHEGFNBGBP = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_system.html");
		this.OFNKEJPFHPM = Shader.PropertyToID("_Offsets");
		this.JHGLFOIFPNA = Shader.PropertyToID("\">Foreign saves detected: ");
		this.BEAGFOMBNIE = Shader.PropertyToID("_SoftZDistance");
		this.HAOPEKACGKJ = Shader.PropertyToID("bright");
		this.JKPIIPGJCGL = Shader.PropertyToID("money");
		this.OLDFANLEEPP = Shader.PropertyToID("");
		this.JEBEODKPNBD = Shader.PropertyToID("");
		this.FPFCLGAHHPJ = Shader.PropertyToID("Reach Cone {point ");
		this.BIBGFHMDCOC = Shader.PropertyToID("<color='#405000'>");
		this.PFENCNMEJGE = Shader.PropertyToID("_CurveTex");
		this.NIBOHKNFDPB = Shader.PropertyToID("cht_umsg10");
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x0012A2A8 File Offset: 0x001284A8
	public void LNNHAAKPBJL()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("signal_enable");
		this.PBDNAONCCBD = Shader.PropertyToID(" %");
		this.ICEFEJNFPNB = Shader.PropertyToID("Water");
		this.DNCCNIPJJFP = Shader.PropertyToID("OneHandSwordBlock");
		this.EPACGLABCFJ = Shader.PropertyToID("WoodSaw");
		this.CGMKIBNPFFI = Shader.PropertyToID("IdleStun");
		this.CMGHEMIEACC = Shader.PropertyToID("invn_ver4");
		this.MIKPHLGJFKC = Shader.PropertyToID("name");
		this.PMDMDAEHDFE = Shader.PropertyToID("_alfavis");
		this.LAOIHBNKNDC = Shader.PropertyToID("OfficeSitting45DegLeg");
		this.DKIOGOAGEMJ = Shader.PropertyToID("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
		this.LNJEDJHGDBA = Shader.PropertyToID("Crouch Strafe Left");
		this.PCGJBGMPMPJ = Shader.PropertyToID("post_15");
		this.LCFIPCLBNCP = Shader.PropertyToID("Pelvis");
		this.GHENKAHBNGH = Shader.PropertyToID("Grounded Directional");
		this.DIMGPCEBEGE = Shader.PropertyToID("OfficeSitting");
		this.AHNEKMDHFKC = Shader.PropertyToID("error.wav");
		this.IGOEANOOFFF = Shader.PropertyToID("_Screen");
		this.OFHAIPIBDBC = Shader.PropertyToID("WeaponStrafeRunRight");
		this.NJIOJANKEDD = Shader.PropertyToID("#2080ff");
		this.OEIDCFLBDAL = Shader.PropertyToID("");
		this.FNCBANADCBJ = Shader.PropertyToID("' is not a valid integer");
		this.MAMMKBMCDED = Shader.PropertyToID("close");
		this.ALMNFJFCEKI = Shader.PropertyToID("");
		this.IHHIGFMOPHG = Shader.PropertyToID("rollSoundIndex");
		this.CHGMOFGHPND = Shader.PropertyToID("gi_uinf_4");
		this.MNHEGFNBGBP = Shader.PropertyToID("_L_");
		this.OFNKEJPFHPM = Shader.PropertyToID("Full Body IK is missing the right upper arm node.");
		this.JHGLFOIFPNA = Shader.PropertyToID("FlyDown");
		this.BEAGFOMBNIE = Shader.PropertyToID("t_top");
		this.HAOPEKACGKJ = Shader.PropertyToID("ElvisLegsLoop");
		this.JKPIIPGJCGL = Shader.PropertyToID("cellicon");
		this.OLDFANLEEPP = Shader.PropertyToID("{0:0} д{1}, ");
		this.JEBEODKPNBD = Shader.PropertyToID("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!");
		this.FPFCLGAHHPJ = Shader.PropertyToID("LeftSplashPause");
		this.BIBGFHMDCOC = Shader.PropertyToID("crft_unl");
		this.PFENCNMEJGE = Shader.PropertyToID("");
		this.NIBOHKNFDPB = Shader.PropertyToID("isMove");
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x0012A518 File Offset: 0x00128718
	public static Mesh AKMPDICHEHL(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[1] = "Sat Night Fever";
		array[0] = GDCMKLMHFLI;
		array[3] = "Vertical";
		array[5] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[3];
		array2[0] = new Vector3(635f, 1138f, 885f);
		array2[0] = new Vector3(1132f, 122f, 1304f);
		array2[0] = new Vector3(622f, 679f, 869f);
		array2[0] = new Vector3(1971f, 1204f, 258f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[1];
		array5[1] = new Vector3(1126f, 648f, 511f);
		array5[0] = new Vector3(798f, 1099f, 1788f);
		array5[5] = new Vector3(577f, 864f, 958f);
		array5[4] = new Vector3(791f, 682f, 523f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[4];
		array6[1] = new Vector4(1527f, 1710f, 753f, 973f);
		array6[0] = new Vector4(1370f, 1408f, 301f, 1869f);
		array6[2] = new Vector4(1695f, 1691f, 427f, 1603f);
		array6[4] = new Vector4(205f, 1963f, 1758f, 325f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002920 RID: 10528 RVA: 0x0012A760 File Offset: 0x00128960
	public void Initialize()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("TOD_SunSkyColor");
		this.PBDNAONCCBD = Shader.PropertyToID("TOD_MoonSkyColor");
		this.ICEFEJNFPNB = Shader.PropertyToID("TOD_SunCloudColor");
		this.DNCCNIPJJFP = Shader.PropertyToID("TOD_MoonCloudColor");
		this.EPACGLABCFJ = Shader.PropertyToID("TOD_SunMeshColor");
		this.CGMKIBNPFFI = Shader.PropertyToID("TOD_MoonMeshColor");
		this.CMGHEMIEACC = Shader.PropertyToID("TOD_CloudColor");
		this.MIKPHLGJFKC = Shader.PropertyToID("TOD_AmbientColor");
		this.PMDMDAEHDFE = Shader.PropertyToID("TOD_MoonHaloColor");
		this.LAOIHBNKNDC = Shader.PropertyToID("TOD_SunDirection");
		this.DKIOGOAGEMJ = Shader.PropertyToID("TOD_MoonDirection");
		this.LNJEDJHGDBA = Shader.PropertyToID("TOD_LightDirection");
		this.PCGJBGMPMPJ = Shader.PropertyToID("TOD_LocalSunDirection");
		this.LCFIPCLBNCP = Shader.PropertyToID("TOD_LocalMoonDirection");
		this.GHENKAHBNGH = Shader.PropertyToID("TOD_LocalLightDirection");
		this.DIMGPCEBEGE = Shader.PropertyToID("TOD_Contrast");
		this.AHNEKMDHFKC = Shader.PropertyToID("TOD_Brightness");
		this.IGOEANOOFFF = Shader.PropertyToID("TOD_Fogginess");
		this.OFHAIPIBDBC = Shader.PropertyToID("TOD_Directionality");
		this.NJIOJANKEDD = Shader.PropertyToID("TOD_MoonHaloPower");
		this.OEIDCFLBDAL = Shader.PropertyToID("TOD_CloudDensity");
		this.FNCBANADCBJ = Shader.PropertyToID("TOD_CloudSharpness");
		this.MAMMKBMCDED = Shader.PropertyToID("TOD_CloudShadow");
		this.ALMNFJFCEKI = Shader.PropertyToID("TOD_CloudScale");
		this.IHHIGFMOPHG = Shader.PropertyToID("TOD_CloudUV");
		this.CHGMOFGHPND = Shader.PropertyToID("TOD_SpaceTiling");
		this.MNHEGFNBGBP = Shader.PropertyToID("TOD_SpaceBrightness");
		this.OFNKEJPFHPM = Shader.PropertyToID("TOD_SunMeshContrast");
		this.JHGLFOIFPNA = Shader.PropertyToID("TOD_SunMeshBrightness");
		this.BEAGFOMBNIE = Shader.PropertyToID("TOD_MoonMeshContrast");
		this.HAOPEKACGKJ = Shader.PropertyToID("TOD_MoonMeshBrightness");
		this.JKPIIPGJCGL = Shader.PropertyToID("TOD_kBetaMie");
		this.OLDFANLEEPP = Shader.PropertyToID("TOD_kSun");
		this.JEBEODKPNBD = Shader.PropertyToID("TOD_k4PI");
		this.FPFCLGAHHPJ = Shader.PropertyToID("TOD_kRadius");
		this.BIBGFHMDCOC = Shader.PropertyToID("TOD_kScale");
		this.PFENCNMEJGE = Shader.PropertyToID("TOD_World2Sky");
		this.NIBOHKNFDPB = Shader.PropertyToID("TOD_Sky2World");
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x0012A9D0 File Offset: 0x00128BD0
	public void OHEAHAKMGNG()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("BAG");
		this.PBDNAONCCBD = Shader.PropertyToID("money");
		this.ICEFEJNFPNB = Shader.PropertyToID("MotorbikeShootFwd");
		this.DNCCNIPJJFP = Shader.PropertyToID("");
		this.EPACGLABCFJ = Shader.PropertyToID("_SecondTex");
		this.CGMKIBNPFFI = Shader.PropertyToID("COLOR_GRADING_LOG_VIEW");
		this.CMGHEMIEACC = Shader.PropertyToID("SecondaryCausticsProjector");
		this.MIKPHLGJFKC = Shader.PropertyToID("_FoamContrast");
		this.PMDMDAEHDFE = Shader.PropertyToID("inv_bonus");
		this.LAOIHBNKNDC = Shader.PropertyToID("WallRunLeft");
		this.DKIOGOAGEMJ = Shader.PropertyToID("[fish]");
		this.LNJEDJHGDBA = Shader.PropertyToID("");
		this.PCGJBGMPMPJ = Shader.PropertyToID("RunBackLeft");
		this.LCFIPCLBNCP = Shader.PropertyToID("contrast");
		this.GHENKAHBNGH = Shader.PropertyToID("");
		this.DIMGPCEBEGE = Shader.PropertyToID("[ACTk] ");
		this.AHNEKMDHFKC = Shader.PropertyToID("_BlurRadius4");
		this.IGOEANOOFFF = Shader.PropertyToID("move");
		this.OFHAIPIBDBC = Shader.PropertyToID("1HandSwordChargeHeavyBash");
		this.NJIOJANKEDD = Shader.PropertyToID("IdleStrafeRight");
		this.OEIDCFLBDAL = Shader.PropertyToID("WallRunRight");
		this.FNCBANADCBJ = Shader.PropertyToID("post_19");
		this.MAMMKBMCDED = Shader.PropertyToID("Bases/1.base");
		this.ALMNFJFCEKI = Shader.PropertyToID("Flap_04.wav");
		this.IHHIGFMOPHG = Shader.PropertyToID("[wtemplid]");
		this.CHGMOFGHPND = Shader.PropertyToID("Add inventory Click!");
		this.MNHEGFNBGBP = Shader.PropertyToID("Spine bones contains a null reference.");
		this.OFNKEJPFHPM = Shader.PropertyToID("wpn_eat1");
		this.JHGLFOIFPNA = Shader.PropertyToID("X");
		this.BEAGFOMBNIE = Shader.PropertyToID("Sun reference not set.");
		this.HAOPEKACGKJ = Shader.PropertyToID("u_pin");
		this.JKPIIPGJCGL = Shader.PropertyToID("sortType");
		this.OLDFANLEEPP = Shader.PropertyToID("long: ");
		this.JEBEODKPNBD = Shader.PropertyToID("{0}");
		this.FPFCLGAHHPJ = Shader.PropertyToID("error.wav");
		this.BIBGFHMDCOC = Shader.PropertyToID("Keeper Strafe Left");
		this.PFENCNMEJGE = Shader.PropertyToID("_HueShift");
		this.NIBOHKNFDPB = Shader.PropertyToID("MotorbikeHandlebarSit");
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x0012AC40 File Offset: 0x00128E40
	public void JIGBKMIFIJK()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("RollerBladeJump");
		this.PBDNAONCCBD = Shader.PropertyToID(" ");
		this.ICEFEJNFPNB = Shader.PropertyToID("VA");
		this.DNCCNIPJJFP = Shader.PropertyToID("{0} x {1}");
		this.EPACGLABCFJ = Shader.PropertyToID("FlyRight");
		this.CGMKIBNPFFI = Shader.PropertyToID("_RampTex");
		this.CMGHEMIEACC = Shader.PropertyToID("LHandPunch");
		this.MIKPHLGJFKC = Shader.PropertyToID("");
		this.PMDMDAEHDFE = Shader.PropertyToID("error: already initialized");
		this.LAOIHBNKNDC = Shader.PropertyToID("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!");
		this.DKIOGOAGEMJ = Shader.PropertyToID("AFCServer");
		this.LNJEDJHGDBA = Shader.PropertyToID("[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
		this.PCGJBGMPMPJ = Shader.PropertyToID("FlyDown");
		this.LCFIPCLBNCP = Shader.PropertyToID("MENU.WAV");
		this.GHENKAHBNGH = Shader.PropertyToID("FishOnRod");
		this.DIMGPCEBEGE = Shader.PropertyToID("Wizard1HandThrow");
		this.AHNEKMDHFKC = Shader.PropertyToID("1 Hand Small Weapon Combo");
		this.IGOEANOOFFF = Shader.PropertyToID("Development Server URL could not be found.");
		this.OFHAIPIBDBC = Shader.PropertyToID("_PlaneReflection");
		this.NJIOJANKEDD = Shader.PropertyToID("_CameraClipInfo");
		this.OEIDCFLBDAL = Shader.PropertyToID("FOG_DISTANCE_ON");
		this.FNCBANADCBJ = Shader.PropertyToID("Ошибка!");
		this.MAMMKBMCDED = Shader.PropertyToID("musicVolume");
		this.ALMNFJFCEKI = Shader.PropertyToID("(Org: ");
		this.IHHIGFMOPHG = Shader.PropertyToID("_VignetteCenter");
		this.CHGMOFGHPND = Shader.PropertyToID("UNIQUE_SHADOW");
		this.MNHEGFNBGBP = Shader.PropertyToID(" material. Effect disabled.");
		this.OFNKEJPFHPM = Shader.PropertyToID(" %\n");
		this.JHGLFOIFPNA = Shader.PropertyToID("Shotgun Reload Chamber");
		this.BEAGFOMBNIE = Shader.PropertyToID("****************** CamEffector APPLY 1");
		this.HAOPEKACGKJ = Shader.PropertyToID("_rcpFrameOpt");
		this.JKPIIPGJCGL = Shader.PropertyToID("IdleFly");
		this.OLDFANLEEPP = Shader.PropertyToID("wpn_ibsize_");
		this.JEBEODKPNBD = Shader.PropertyToID("_FogPointLightColor");
		this.FPFCLGAHHPJ = Shader.PropertyToID("1HandSwordChargeUp");
		this.BIBGFHMDCOC = Shader.PropertyToID("reputaion/levels/replevels");
		this.PFENCNMEJGE = Shader.PropertyToID(" on effect ");
		this.NIBOHKNFDPB = Shader.PropertyToID("");
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x0012AEB0 File Offset: 0x001290B0
	public static Mesh PPGOOGFMOHD(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[3];
		array[0] = "</color>";
		array[0] = GDCMKLMHFLI;
		array[2] = "Anchor Target";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(1455f, 15f, 1213f);
		array2[0] = new Vector3(1978f, 1156f, 434f);
		array2[2] = new Vector3(576f, 1240f, 1927f);
		array2[0] = new Vector3(988f, 141f, 1875f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[7];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[3];
		array5[0] = new Vector3(747f, 1820f, 1632f);
		array5[0] = new Vector3(844f, 1531f, 1367f);
		array5[8] = new Vector3(618f, 311f, 421f);
		array5[2] = new Vector3(1182f, 1247f, 954f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[1];
		array6[1] = new Vector4(833f, 1920f, 266f, 1992f);
		array6[1] = new Vector4(1153f, 1744f, 1870f, 890f);
		array6[4] = new Vector4(1363f, 1347f, 416f, 1813f);
		array6[4] = new Vector4(661f, 1468f, 465f, 394f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x0012B0F8 File Offset: 0x001292F8
	public void GFEMENKJMAP()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("TOD_MoonMeshContrast");
		this.PBDNAONCCBD = Shader.PropertyToID("KneesIdle");
		this.ICEFEJNFPNB = Shader.PropertyToID("Idle Sad Hips");
		this.DNCCNIPJJFP = Shader.PropertyToID("80ff00");
		this.EPACGLABCFJ = Shader.PropertyToID("SneakForward");
		this.CGMKIBNPFFI = Shader.PropertyToID("auk_pstinf");
		this.CMGHEMIEACC = Shader.PropertyToID("Trying to initiate IKSolverVR with invalid bone references.");
		this.MIKPHLGJFKC = Shader.PropertyToID("delaccconfirm");
		this.PMDMDAEHDFE = Shader.PropertyToID("InteractionSystem can not find a FullBodyBipedIK component");
		this.LAOIHBNKNDC = Shader.PropertyToID("Deadman Float");
		this.DKIOGOAGEMJ = Shader.PropertyToID("Add random value");
		this.LNJEDJHGDBA = Shader.PropertyToID("</color>");
		this.PCGJBGMPMPJ = Shader.PropertyToID("");
		this.LCFIPCLBNCP = Shader.PropertyToID("paper.wav");
		this.GHENKAHBNGH = Shader.PropertyToID("_LerpAmount");
		this.DIMGPCEBEGE = Shader.PropertyToID("_InternalLutParams");
		this.AHNEKMDHFKC = Shader.PropertyToID("Horizontal");
		this.IGOEANOOFFF = Shader.PropertyToID("ZombieWalk");
		this.OFHAIPIBDBC = Shader.PropertyToID("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
		this.NJIOJANKEDD = Shader.PropertyToID("_");
		this.OEIDCFLBDAL = Shader.PropertyToID("fshop_header");
		this.FNCBANADCBJ = Shader.PropertyToID("SteamManager");
		this.MAMMKBMCDED = Shader.PropertyToID("inv_minreq");
		this.ALMNFJFCEKI = Shader.PropertyToID("MotorbikeLookBack");
		this.IHHIGFMOPHG = Shader.PropertyToID("UnityEngine.");
		this.CHGMOFGHPND = Shader.PropertyToID("no_time_period");
		this.MNHEGFNBGBP = Shader.PropertyToID("");
		this.OFNKEJPFHPM = Shader.PropertyToID("_Highlighted");
		this.JHGLFOIFPNA = Shader.PropertyToID("");
		this.BEAGFOMBNIE = Shader.PropertyToID("Heel Click");
		this.HAOPEKACGKJ = Shader.PropertyToID("2");
		this.JKPIIPGJCGL = Shader.PropertyToID("\">Detected: ");
		this.OLDFANLEEPP = Shader.PropertyToID("Zombie Crawl");
		this.JEBEODKPNBD = Shader.PropertyToID("");
		this.FPFCLGAHHPJ = Shader.PropertyToID("Mouse Y");
		this.BIBGFHMDCOC = Shader.PropertyToID("lifeBar");
		this.PFENCNMEJGE = Shader.PropertyToID(" ");
		this.NIBOHKNFDPB = Shader.PropertyToID("TOD_SunDirection");
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x0012B368 File Offset: 0x00129568
	public static Mesh CMJMLHHGJJK(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "_RcpMaxCoC";
		array[1] = GDCMKLMHFLI;
		array[1] = "Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!";
		array[6] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[]
		{
			default(Vector3),
			new Vector3(900f, 1083f, 568f)
		};
		array2[0] = new Vector3(533f, 1424f, 1777f);
		array2[4] = new Vector3(973f, 1049f, 152f);
		array2[0] = new Vector3(449f, 922f, 1120f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[7];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[5];
		array4[0] = new Vector3(194f, 1664f, 1015f);
		array4[0] = new Vector3(285f, 929f, 719f);
		array4[3] = new Vector3(662f, 1573f, 281f);
		array4[0] = new Vector3(1423f, 937f, 750f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			default(Vector4),
			new Vector4(488f, 1969f, 573f, 1635f)
		};
		array5[0] = new Vector4(1199f, 1347f, 437f, 731f);
		array5[8] = new Vector4(1587f, 1584f, 524f, 123f);
		array5[4] = new Vector4(1661f, 392f, 373f, 1332f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x0012B5B0 File Offset: 0x001297B0
	public static Mesh CLDCJEGJFPB(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[0] = "http://www.root-motion.com/finalikdox/html/page12.html";
		array[1] = GDCMKLMHFLI;
		array[5] = "\n(";
		array[6] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[5];
		array2[1] = new Vector3(1738f, 1604f, 1963f);
		array2[0] = new Vector3(1699f, 351f, 1676f);
		array2[6] = new Vector3(1703f, 1580f, 0f);
		array2[2] = new Vector3(247f, 60f, 450f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[8];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[0] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0,
			2
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[3];
		array4[1] = new Vector3(1623f, 1852f, 337f);
		array4[0] = new Vector3(1424f, 271f, 939f);
		array4[0] = new Vector3(1474f, 1952f, 761f);
		array4[3] = new Vector3(1038f, 1351f, 87f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			default(Vector4),
			new Vector4(1661f, 1859f, 1085f, 1303f)
		};
		array5[1] = new Vector4(875f, 1601f, 830f, 1333f);
		array5[5] = new Vector4(1878f, 504f, 60f, 1010f);
		array5[3] = new Vector4(1037f, 57f, 340f, 322f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x0012B7F8 File Offset: 0x001299F8
	public static Mesh KJABAIFJOOE(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[]
		{
			"priceCr"
		};
		array[0] = GDCMKLMHFLI;
		array[2] = "Collar";
		array[6] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[3];
		array2[0] = new Vector3(1814f, 637f, 45f);
		array2[0] = new Vector3(1472f, 1836f, 1349f);
		array2[1] = new Vector3(1844f, 19f, 1894f);
		array2[3] = new Vector3(87f, 511f, 1294f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[]
		{
			default(Vector3),
			new Vector3(1022f, 376f, 1242f)
		};
		array5[0] = new Vector3(101f, 782f, 1125f);
		array5[1] = new Vector3(143f, 20f, 1898f);
		array5[4] = new Vector3(655f, 1072f, 1372f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[4];
		array6[1] = new Vector4(624f, 1295f, 37f, 1292f);
		array6[1] = new Vector4(287f, 316f, 262f, 1475f);
		array6[8] = new Vector4(1276f, 676f, 363f, 442f);
		array6[8] = new Vector4(1331f, 1159f, 1023f, 212f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x0012BA40 File Offset: 0x00129C40
	public static Mesh CIKALMGMJDD(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[0] = " ms";
		array[1] = GDCMKLMHFLI;
		array[6] = "drag_onmousedown.wav";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[8];
		array2[0] = new Vector3(1984f, 1959f, 379f);
		array2[0] = new Vector3(1914f, 646f, 1038f);
		array2[4] = new Vector3(1020f, 196f, 1239f);
		array2[7] = new Vector3(1986f, 208f, 1613f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[6];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[5];
		array5[1] = new Vector3(1085f, 502f, 1512f);
		array5[1] = new Vector3(993f, 656f, 1802f);
		array5[2] = new Vector3(1394f, 1583f, 1982f);
		array5[6] = new Vector3(1394f, 146f, 143f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[7];
		array6[1] = new Vector4(219f, 185f, 1568f, 1096f);
		array6[0] = new Vector4(98f, 1089f, 727f, 352f);
		array6[7] = new Vector4(395f, 1491f, 1638f, 756f);
		array6[0] = new Vector4(804f, 194f, 1293f, 197f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x0012BC88 File Offset: 0x00129E88
	public void LMLJNFFOLPN()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("WallSit");
		this.PBDNAONCCBD = Shader.PropertyToID("FOG_SCATTERING_ON");
		this.ICEFEJNFPNB = Shader.PropertyToID("Assets/Hairs/whair_");
		this.DNCCNIPJJFP = Shader.PropertyToID("\n");
		this.EPACGLABCFJ = Shader.PropertyToID("MotorbikeLassoLeft");
		this.CGMKIBNPFFI = Shader.PropertyToID("\n");
		this.CMGHEMIEACC = Shader.PropertyToID("****************  stopMusic ");
		this.MIKPHLGJFKC = Shader.PropertyToID("StrafeRunLeft");
		this.PMDMDAEHDFE = Shader.PropertyToID("_ChannelMixerGreen");
		this.LAOIHBNKNDC = Shader.PropertyToID("second bone position is the same as third bone position.");
		this.DKIOGOAGEMJ = Shader.PropertyToID("BowReady");
		this.LNJEDJHGDBA = Shader.PropertyToID(">");
		this.PCGJBGMPMPJ = Shader.PropertyToID("fshop_hd4");
		this.LCFIPCLBNCP = Shader.PropertyToID("Eyes");
		this.GHENKAHBNGH = Shader.PropertyToID("дней");
		this.DIMGPCEBEGE = Shader.PropertyToID("Soccer Start Kick");
		this.AHNEKMDHFKC = Shader.PropertyToID(")\n");
		this.IGOEANOOFFF = Shader.PropertyToID("_DiffCubeIBL");
		this.OFHAIPIBDBC = Shader.PropertyToID("wpn_chair1");
		this.NJIOJANKEDD = Shader.PropertyToID("UnityEngine.Vector3");
		this.OEIDCFLBDAL = Shader.PropertyToID(" x");
		this.FNCBANADCBJ = Shader.PropertyToID("SoccerKeeperStrafeLeft");
		this.MAMMKBMCDED = Shader.PropertyToID(" гр ");
		this.ALMNFJFCEKI = Shader.PropertyToID("<color=blue>$&</color>");
		this.IHHIGFMOPHG = Shader.PropertyToID("CrawlLocomotion");
		this.CHGMOFGHPND = Shader.PropertyToID("ScubaOK");
		this.MNHEGFNBGBP = Shader.PropertyToID("big_count");
		this.OFNKEJPFHPM = Shader.PropertyToID("_BlurredColor");
		this.JHGLFOIFPNA = Shader.PropertyToID("{0} {1}.{2} ({3:f2}, {4:f2})  {5}");
		this.BEAGFOMBNIE = Shader.PropertyToID("_FogVoidData");
		this.HAOPEKACGKJ = Shader.PropertyToID("SceneCamera");
		this.JKPIIPGJCGL = Shader.PropertyToID("enable");
		this.OLDFANLEEPP = Shader.PropertyToID("BackPackOff");
		this.JEBEODKPNBD = Shader.PropertyToID("Sitting Mouse Movement");
		this.FPFCLGAHHPJ = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html");
		this.BIBGFHMDCOC = Shader.PropertyToID("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.");
		this.PFENCNMEJGE = Shader.PropertyToID("_WaveOffset");
		this.NIBOHKNFDPB = Shader.PropertyToID("MotorbikeBackwardSitting");
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x0012BEF8 File Offset: 0x0012A0F8
	public void LECGEEMCOLC()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("error.wav");
		this.PBDNAONCCBD = Shader.PropertyToID("WeaponFire");
		this.ICEFEJNFPNB = Shader.PropertyToID("_MaxRayTraceDistance");
		this.DNCCNIPJJFP = Shader.PropertyToID("__MirrorReflection");
		this.EPACGLABCFJ = Shader.PropertyToID("RollerBladeStand");
		this.CGMKIBNPFFI = Shader.PropertyToID("basePar");
		this.CMGHEMIEACC = Shader.PropertyToID("WATER_REFLECTIVE");
		this.MIKPHLGJFKC = Shader.PropertyToID("ShotgunFire");
		this.PMDMDAEHDFE = Shader.PropertyToID("Flames");
		this.LAOIHBNKNDC = Shader.PropertyToID("Weapon Stand");
		this.DKIOGOAGEMJ = Shader.PropertyToID("IdleStrafeRight");
		this.LNJEDJHGDBA = Shader.PropertyToID("Shotgun Reload Chamber");
		this.PCGJBGMPMPJ = Shader.PropertyToID("WallRunLeft");
		this.LCFIPCLBNCP = Shader.PropertyToID("");
		this.GHENKAHBNGH = Shader.PropertyToID("{0:F2}, {1:F2}");
		this.DIMGPCEBEGE = Shader.PropertyToID("Hidden/Post FX/Temporal Anti-aliasing");
		this.AHNEKMDHFKC = Shader.PropertyToID("Mouse Y");
		this.IGOEANOOFFF = Shader.PropertyToID("Shotgun Reload Chamber");
		this.OFHAIPIBDBC = Shader.PropertyToID("360SpinDeath");
		this.NJIOJANKEDD = Shader.PropertyToID("ambientVolume");
		this.OEIDCFLBDAL = Shader.PropertyToID("_ReflectionTexture4");
		this.FNCBANADCBJ = Shader.PropertyToID("_NoiseAmount");
		this.MAMMKBMCDED = Shader.PropertyToID("move");
		this.ALMNFJFCEKI = Shader.PropertyToID("Bow Idle");
		this.IHHIGFMOPHG = Shader.PropertyToID("Builtin Debug Views");
		this.CHGMOFGHPND = Shader.PropertyToID("ArmFlex");
		this.MNHEGFNBGBP = Shader.PropertyToID("StartControllerModule");
		this.OFNKEJPFHPM = Shader.PropertyToID("\n");
		this.JHGLFOIFPNA = Shader.PropertyToID("FOG_OF_WAR_ON");
		this.BEAGFOMBNIE = Shader.PropertyToID("run_cnt");
		this.HAOPEKACGKJ = Shader.PropertyToID("WizardPowerUp");
		this.JKPIIPGJCGL = Shader.PropertyToID("Exception e ");
		this.OLDFANLEEPP = Shader.PropertyToID("Foot");
		this.JEBEODKPNBD = Shader.PropertyToID("_GrainTex");
		this.FPFCLGAHHPJ = Shader.PropertyToID("Water");
		this.BIBGFHMDCOC = Shader.PropertyToID("Hand");
		this.PFENCNMEJGE = Shader.PropertyToID("FrontKick");
		this.NIBOHKNFDPB = Shader.PropertyToID("#400000");
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x0012C168 File Offset: 0x0012A368
	public static Mesh KHNEKNJGNLF(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[3];
		array[1] = "1=";
		array[0] = GDCMKLMHFLI;
		array[7] = "_FullItem.wav";
		array[5] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[8];
		array2[0] = new Vector3(1394f, 234f, 1224f);
		array2[0] = new Vector3(1823f, 323f, 1767f);
		array2[1] = new Vector3(1719f, 385f, 177f);
		array2[7] = new Vector3(1704f, 797f, 1474f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[8];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[0];
		array5[0] = new Vector3(221f, 296f, 827f);
		array5[0] = new Vector3(1508f, 419f, 1608f);
		array5[5] = new Vector3(1603f, 1973f, 1544f);
		array5[1] = new Vector3(1254f, 112f, 133f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[8];
		array6[1] = new Vector4(1506f, 1188f, 403f, 1945f);
		array6[0] = new Vector4(117f, 1162f, 795f, 1304f);
		array6[0] = new Vector4(1204f, 1314f, 1668f, 767f);
		array6[1] = new Vector4(1252f, 59f, 1003f, 334f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x0012C3B0 File Offset: 0x0012A5B0
	public void FDBOBGIBLLO()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("_Params");
		this.PBDNAONCCBD = Shader.PropertyToID("RollerBladeSkateFwd");
		this.ICEFEJNFPNB = Shader.PropertyToID(" ");
		this.DNCCNIPJJFP = Shader.PropertyToID("IdleRun");
		this.EPACGLABCFJ = Shader.PropertyToID("OFF");
		this.CGMKIBNPFFI = Shader.PropertyToID("PistolFire");
		this.CMGHEMIEACC = Shader.PropertyToID("getfish");
		this.MIKPHLGJFKC = Shader.PropertyToID("_FadeDistance");
		this.PMDMDAEHDFE = Shader.PropertyToID("name");
		this.LAOIHBNKNDC = Shader.PropertyToID("SYS");
		this.DKIOGOAGEMJ = Shader.PropertyToID("_DistanceParams");
		this.LNJEDJHGDBA = Shader.PropertyToID("Materials/DFGDesktopPlus");
		this.PCGJBGMPMPJ = Shader.PropertyToID("_");
		this.LCFIPCLBNCP = Shader.PropertyToID("craft_data/categories/category");
		this.GHENKAHBNGH = Shader.PropertyToID("Head stand");
		this.DIMGPCEBEGE = Shader.PropertyToID("chatconnecthelp");
		this.AHNEKMDHFKC = Shader.PropertyToID("\n");
		this.IGOEANOOFFF = Shader.PropertyToID("bool: ");
		this.OFHAIPIBDBC = Shader.PropertyToID("colorD");
		this.NJIOJANKEDD = Shader.PropertyToID("BipedReferences eye bone at index ");
		this.OEIDCFLBDAL = Shader.PropertyToID("");
		this.FNCBANADCBJ = Shader.PropertyToID("bs_cost");
		this.MAMMKBMCDED = Shader.PropertyToID("SUNSHINE_FILTER_HARD");
		this.ALMNFJFCEKI = Shader.PropertyToID("auc_wsbor");
		this.IHHIGFMOPHG = Shader.PropertyToID("<[^>]+>");
		this.CHGMOFGHPND = Shader.PropertyToID("auc_reshdr");
		this.MNHEGFNBGBP = Shader.PropertyToID("");
		this.OFNKEJPFHPM = Shader.PropertyToID("BowReady2");
		this.JHGLFOIFPNA = Shader.PropertyToID("#20a000");
		this.BEAGFOMBNIE = Shader.PropertyToID("_DayToNight");
		this.HAOPEKACGKJ = Shader.PropertyToID("WalkBackward");
		this.JKPIIPGJCGL = Shader.PropertyToID("_EmissionColor");
		this.OLDFANLEEPP = Shader.PropertyToID("");
		this.JEBEODKPNBD = Shader.PropertyToID("imgid");
		this.FPFCLGAHHPJ = Shader.PropertyToID("<b>WallHack Detector</b>");
		this.BIBGFHMDCOC = Shader.PropertyToID("Hidden/Post FX/Blit");
		this.PFENCNMEJGE = Shader.PropertyToID("wpn/");
		this.NIBOHKNFDPB = Shader.PropertyToID("gi_nl3");
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x0012C620 File Offset: 0x0012A820
	public static Mesh MKEKHPHDBBN(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[6];
		array[1] = "Error receptID=";
		array[0] = GDCMKLMHFLI;
		array[8] = "Player";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[3];
		array2[1] = new Vector3(1519f, 187f, 1955f);
		array2[0] = new Vector3(196f, 1958f, 30f);
		array2[6] = new Vector3(1407f, 1778f, 708f);
		array2[5] = new Vector3(168f, 1161f, 1305f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[4];
		array4[0] = new Vector3(22f, 1286f, 1465f);
		array4[0] = new Vector3(1332f, 966f, 141f);
		array4[0] = new Vector3(189f, 127f, 799f);
		array4[4] = new Vector3(1330f, 857f, 1789f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[]
		{
			default(Vector4),
			new Vector4(1877f, 1746f, 1341f, 1740f)
		};
		array5[1] = new Vector4(161f, 1276f, 559f, 1907f);
		array5[0] = new Vector4(48f, 103f, 188f, 104f);
		array5[4] = new Vector4(462f, 1457f, 1933f, 1236f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x0012C868 File Offset: 0x0012AA68
	public static Mesh IBLJNCLNOBG(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[7];
		array[0] = "";
		array[0] = GDCMKLMHFLI;
		array[3] = "Horizontal";
		array[2] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[]
		{
			new Vector3(445f, 1473f, 570f)
		};
		array2[0] = new Vector3(1630f, 82f, 1305f);
		array2[6] = new Vector3(863f, 624f, 1786f);
		array2[4] = new Vector3(1422f, 1108f, 1686f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[]
		{
			default(Vector2),
			new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y)
		};
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[8];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[6];
		array5[1] = new Vector3(1886f, 174f, 322f);
		array5[0] = new Vector3(1945f, 1628f, 1222f);
		array5[1] = new Vector3(1700f, 1685f, 782f);
		array5[6] = new Vector3(786f, 1375f, 663f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[4];
		array6[0] = new Vector4(120f, 137f, 570f, 952f);
		array6[0] = new Vector4(21f, 213f, 1836f, 1022f);
		array6[2] = new Vector4(1505f, 1747f, 1198f, 851f);
		array6[1] = new Vector4(922f, 1547f, 684f, 469f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x0012CAB0 File Offset: 0x0012ACB0
	public static Mesh OHAGHMCJCFH(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[0];
		array[0] = "Roar";
		array[0] = GDCMKLMHFLI;
		array[1] = "_WrinkleMapBumpScales";
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[1];
		array2[1] = new Vector3(567f, 1423f, 666f);
		array2[1] = new Vector3(1494f, 314f, 225f);
		array2[3] = new Vector3(1958f, 1305f, 586f);
		array2[0] = new Vector3(1428f, 41f, 993f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[]
		{
			default(Vector2),
			new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y)
		};
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[7] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[8];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[0];
		array5[0] = new Vector3(1003f, 686f, 271f);
		array5[1] = new Vector3(1743f, 1803f, 1391f);
		array5[2] = new Vector3(82f, 1919f, 1571f);
		array5[8] = new Vector3(1014f, 1403f, 467f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[5];
		array6[0] = new Vector4(548f, 102f, 711f, 388f);
		array6[0] = new Vector4(1810f, 596f, 277f, 1261f);
		array6[7] = new Vector4(831f, 1025f, 523f, 666f);
		array6[0] = new Vector4(504f, 942f, 1662f, 1212f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x0012CCF8 File Offset: 0x0012AEF8
	public void PCCIBGFAENG()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("Reset");
		this.PBDNAONCCBD = Shader.PropertyToID("IdleReady");
		this.ICEFEJNFPNB = Shader.PropertyToID("+{0}");
		this.DNCCNIPJJFP = Shader.PropertyToID("rem");
		this.EPACGLABCFJ = Shader.PropertyToID("Windows/");
		this.CGMKIBNPFFI = Shader.PropertyToID("WandAttack");
		this.CMGHEMIEACC = Shader.PropertyToID("turn_levels");
		this.MIKPHLGJFKC = Shader.PropertyToID("inv_auklotn");
		this.PMDMDAEHDFE = Shader.PropertyToID("FistPump2");
		this.LAOIHBNKNDC = Shader.PropertyToID("");
		this.DKIOGOAGEMJ = Shader.PropertyToID("error");
		this.LNJEDJHGDBA = Shader.PropertyToID(" has been disabled as it requires a depth texture.");
		this.PCGJBGMPMPJ = Shader.PropertyToID("exitmsg_2");
		this.LCFIPCLBNCP = Shader.PropertyToID("Mouse ScrollWheel");
		this.GHENKAHBNGH = Shader.PropertyToID("_FrustumCornersWS");
		this.DIMGPCEBEGE = Shader.PropertyToID("name");
		this.AHNEKMDHFKC = Shader.PropertyToID("_l_");
		this.IGOEANOOFFF = Shader.PropertyToID("Giant3HitCombo2");
		this.OFHAIPIBDBC = Shader.PropertyToID("harvestmsg2");
		this.NJIOJANKEDD = Shader.PropertyToID("2");
		this.OEIDCFLBDAL = Shader.PropertyToID("S");
		this.FNCBANADCBJ = Shader.PropertyToID("IdleSandCover");
		this.MAMMKBMCDED = Shader.PropertyToID("titul_data/tituls/titul");
		this.ALMNFJFCEKI = Shader.PropertyToID("FlyRight");
		this.IHHIGFMOPHG = Shader.PropertyToID("WRINKLE_MAPS");
		this.CHGMOFGHPND = Shader.PropertyToID(" Waypoint Target");
		this.MNHEGFNBGBP = Shader.PropertyToID("1 Hand Sword Strafe Right");
		this.OFNKEJPFHPM = Shader.PropertyToID("languageid");
		this.JHGLFOIFPNA = Shader.PropertyToID(")?");
		this.BEAGFOMBNIE = Shader.PropertyToID("wpn_hook3");
		this.HAOPEKACGKJ = Shader.PropertyToID("wpn_eat5");
		this.JKPIIPGJCGL = Shader.PropertyToID("post_23");
		this.OLDFANLEEPP = Shader.PropertyToID("WoodSaw");
		this.JEBEODKPNBD = Shader.PropertyToID("WateringCanWatering");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_BumpMap");
		this.BIBGFHMDCOC = Shader.PropertyToID("{0}/{1}");
		this.PFENCNMEJGE = Shader.PropertyToID("\n");
		this.NIBOHKNFDPB = Shader.PropertyToID("Add random value");
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x0012CF68 File Offset: 0x0012B168
	public void MFEEBJKDLLE()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("I");
		this.PBDNAONCCBD = Shader.PropertyToID("Floating point textures aren't supported on this device ({0})");
		this.ICEFEJNFPNB = Shader.PropertyToID("_ConsoleSettings");
		this.DNCCNIPJJFP = Shader.PropertyToID("Bone ");
		this.EPACGLABCFJ = Shader.PropertyToID("DecalMesh");
		this.CGMKIBNPFFI = Shader.PropertyToID("gi_uinf_1i");
		this.CMGHEMIEACC = Shader.PropertyToID("_DstBlend");
		this.MIKPHLGJFKC = Shader.PropertyToID("name");
		this.PMDMDAEHDFE = Shader.PropertyToID("UIChat_fontSize");
		this.LAOIHBNKNDC = Shader.PropertyToID("z");
		this.DKIOGOAGEMJ = Shader.PropertyToID("t_top");
		this.LNJEDJHGDBA = Shader.PropertyToID("");
		this.PCGJBGMPMPJ = Shader.PropertyToID(" ");
		this.LCFIPCLBNCP = Shader.PropertyToID("ElvisLegsLoop");
		this.GHENKAHBNGH = Shader.PropertyToID(" ");
		this.DIMGPCEBEGE = Shader.PropertyToID("error");
		this.AHNEKMDHFKC = Shader.PropertyToID(" registered.");
		this.IGOEANOOFFF = Shader.PropertyToID("Hidden/DepthOfField/MedianFilter");
		this.OFHAIPIBDBC = Shader.PropertyToID("isbroken");
		this.NJIOJANKEDD = Shader.PropertyToID("sonar_");
		this.OEIDCFLBDAL = Shader.PropertyToID("Press R or LMB for procedural recoil.");
		this.FNCBANADCBJ = Shader.PropertyToID("val=");
		this.MAMMKBMCDED = Shader.PropertyToID("Torso");
		this.ALMNFJFCEKI = Shader.PropertyToID("Horizontal");
		this.IHHIGFMOPHG = Shader.PropertyToID("IdleStrafeRight");
		this.CHGMOFGHPND = Shader.PropertyToID("_TapMedium");
		this.MNHEGFNBGBP = Shader.PropertyToID("WorkerPickaxe2");
		this.OFNKEJPFHPM = Shader.PropertyToID("");
		this.JHGLFOIFPNA = Shader.PropertyToID("OfficeSittingBack");
		this.BEAGFOMBNIE = Shader.PropertyToID("Delete");
		this.HAOPEKACGKJ = Shader.PropertyToID("WorkerHammer");
		this.JKPIIPGJCGL = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/page12.html");
		this.OLDFANLEEPP = Shader.PropertyToID("WorkerShovel2");
		this.JEBEODKPNBD = Shader.PropertyToID("offsets");
		this.FPFCLGAHHPJ = Shader.PropertyToID("");
		this.BIBGFHMDCOC = Shader.PropertyToID("---");
		this.PFENCNMEJGE = Shader.PropertyToID("_HrDepthTex");
		this.NIBOHKNFDPB = Shader.PropertyToID("Crouching");
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x0012D1D8 File Offset: 0x0012B3D8
	public static Mesh PMIJAKMMNKO(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[8];
		array[1] = "_Cull";
		array[0] = GDCMKLMHFLI;
		array[7] = "Hidden/Post FX/Blit";
		array[1] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[8];
		array2[1] = new Vector3(919f, 1819f, 1089f);
		array2[0] = new Vector3(1839f, 474f, 1128f);
		array2[1] = new Vector3(1919f, 1651f, 1888f);
		array2[1] = new Vector3(1603f, 37f, 194f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[3];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[8] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[3];
		array4[1] = new Vector3(1620f, 168f, 1992f);
		array4[0] = new Vector3(1307f, 914f, 1455f);
		array4[5] = new Vector3(1937f, 708f, 1008f);
		array4[4] = new Vector3(534f, 1808f, 1307f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[3];
		array5[1] = new Vector4(1897f, 1341f, 1458f, 474f);
		array5[1] = new Vector4(1285f, 226f, 1331f, 1877f);
		array5[8] = new Vector4(476f, 1332f, 862f, 95f);
		array5[2] = new Vector4(121f, 704f, 1469f, 784f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x0012D420 File Offset: 0x0012B620
	public static Mesh FHDIKAPBEGG(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[4];
		array[0] = "_Color";
		array[0] = GDCMKLMHFLI;
		array[0] = "_RcpMaxCoC";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[7];
		array2[1] = new Vector3(1160f, 634f, 1180f);
		array2[1] = new Vector3(1140f, 937f, 881f);
		array2[7] = new Vector3(1888f, 1491f, 173f);
		array2[0] = new Vector3(862f, 728f, 1017f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[2] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[0];
		array5[1] = new Vector3(876f, 1007f, 1421f);
		array5[1] = new Vector3(339f, 930f, 472f);
		array5[1] = new Vector3(257f, 585f, 295f);
		array5[7] = new Vector3(897f, 80f, 661f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[6];
		array6[0] = new Vector4(980f, 1493f, 1795f, 1065f);
		array6[0] = new Vector4(938f, 240f, 1708f, 512f);
		array6[6] = new Vector4(651f, 7f, 1139f, 1119f);
		array6[7] = new Vector4(1016f, 1312f, 303f, 893f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x0012D668 File Offset: 0x0012B868
	public static Mesh LLOOGDEKNAP(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[5];
		array[0] = "gi_um_9";
		array[1] = GDCMKLMHFLI;
		array[7] = "IdleStandingJump";
		array[8] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[1];
		array2[1] = new Vector3(517f, 1037f, 1105f);
		array2[1] = new Vector3(1907f, 210f, 1771f);
		array2[0] = new Vector3(811f, 1424f, 1467f);
		array2[1] = new Vector3(1466f, 1791f, 681f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[0];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[4] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		Mesh mesh4 = mesh;
		int[] array4 = new int[7];
		RuntimeHelpers.InitializeArray(array4, fieldof(<PrivateImplementationDetails>.F57447FA07E4930B14F4E66B5327234469824F01).FieldHandle);
		mesh4.triangles = array4;
		Mesh mesh5 = mesh;
		Vector3[] array5 = new Vector3[]
		{
			new Vector3(1313f, 928f, 1683f),
			new Vector3(47f, 331f, 1091f),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			new Vector3(476f, 1790f, 35f)
		};
		array5[5] = new Vector3(773f, 425f, 770f);
		mesh5.normals = array5;
		Mesh mesh6 = mesh;
		Vector4[] array6 = new Vector4[4];
		array6[0] = new Vector4(393f, 1548f, 1094f, 121f);
		array6[1] = new Vector4(848f, 1685f, 1026f, 282f);
		array6[8] = new Vector4(1956f, 840f, 914f, 1301f);
		array6[7] = new Vector4(1044f, 407f, 1791f, 393f);
		mesh6.tangents = array6;
		return mesh;
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x0012D8B0 File Offset: 0x0012BAB0
	public static Mesh MPPLDJOKPJI(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[0];
		array[0] = " ms";
		array[1] = GDCMKLMHFLI;
		array[7] = "!";
		array[7] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(220f, 1303f, 458f);
		array2[1] = new Vector3(1815f, 850f, 189f);
		array2[7] = new Vector3(1180f, 650f, 1975f);
		array2[5] = new Vector3(880f, 1075f, 567f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[1] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[3] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3,
			2,
			0
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[5];
		array4[0] = new Vector3(831f, 935f, 1610f);
		array4[0] = new Vector3(550f, 1025f, 1392f);
		array4[8] = new Vector3(1619f, 1338f, 843f);
		array4[1] = new Vector3(1753f, 979f, 137f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[7];
		array5[0] = new Vector4(736f, 802f, 1798f, 1306f);
		array5[1] = new Vector4(1830f, 1269f, 1704f, 1394f);
		array5[1] = new Vector4(1808f, 1544f, 881f, 888f);
		array5[5] = new Vector4(1086f, 975f, 1626f, 535f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x0012DAF8 File Offset: 0x0012BCF8
	public static Mesh GHHPOCDFGLA(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[]
		{
			"CraftProf.xml",
			GDCMKLMHFLI,
			null,
			null,
			null,
			null,
			""
		};
		array[4] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(1408f, 906f, 1382f);
		array2[1] = new Vector3(1047f, 992f, 1079f);
		array2[6] = new Vector3(1144f, 630f, 1340f);
		array2[4] = new Vector3(572f, 1964f, 1597f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[3];
		array3[0] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[1] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[5] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[5];
		array4[1] = new Vector3(923f, 672f, 7f);
		array4[1] = new Vector3(1317f, 1774f, 1172f);
		array4[2] = new Vector3(1497f, 1074f, 1309f);
		array4[8] = new Vector3(1852f, 775f, 808f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[0];
		array5[0] = new Vector4(395f, 816f, 573f, 1301f);
		array5[0] = new Vector4(864f, 1036f, 755f, 1612f);
		array5[1] = new Vector4(1038f, 795f, 643f, 1097f);
		array5[7] = new Vector4(97f, 1752f, 459f, 803f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x0012DD40 File Offset: 0x0012BF40
	public void KONKHBDCHFO()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("OneHandSwordIdle");
		this.PBDNAONCCBD = Shader.PropertyToID("PaperTurn.wav");
		this.ICEFEJNFPNB = Shader.PropertyToID("WireframeCamera");
		this.DNCCNIPJJFP = Shader.PropertyToID("HeelClick");
		this.EPACGLABCFJ = Shader.PropertyToID("<color=\"");
		this.CGMKIBNPFFI = Shader.PropertyToID("error.wav");
		this.CMGHEMIEACC = Shader.PropertyToID("3");
		this.MIKPHLGJFKC = Shader.PropertyToID("Hidden/Post FX/Bloom");
		this.PMDMDAEHDFE = Shader.PropertyToID("no_repa");
		this.LAOIHBNKNDC = Shader.PropertyToID("shop_t4");
		this.DKIOGOAGEMJ = Shader.PropertyToID("Colors");
		this.LNJEDJHGDBA = Shader.PropertyToID("wpn_eat4");
		this.PCGJBGMPMPJ = Shader.PropertyToID("CrouchWalkBackward");
		this.LCFIPCLBNCP = Shader.PropertyToID("knopje.wav");
		this.GHENKAHBNGH = Shader.PropertyToID("Run Back Left");
		this.DIMGPCEBEGE = Shader.PropertyToID("MotorbikeLassoLeft");
		this.AHNEKMDHFKC = Shader.PropertyToID("ProneLocomotion");
		this.IGOEANOOFFF = Shader.PropertyToID("Windows/");
		this.OFHAIPIBDBC = Shader.PropertyToID("https://www.youtube.com/watch?v=wT8fViZpLmQ");
		this.NJIOJANKEDD = Shader.PropertyToID("rodDwDelta=");
		this.OEIDCFLBDAL = Shader.PropertyToID("Vertical");
		this.FNCBANADCBJ = Shader.PropertyToID("Giant2HandSlamIdle");
		this.MAMMKBMCDED = Shader.PropertyToID("\n");
		this.ALMNFJFCEKI = Shader.PropertyToID("_InvViewProj");
		this.IHHIGFMOPHG = Shader.PropertyToID("Null");
		this.CHGMOFGHPND = Shader.PropertyToID("MovementZ");
		this.MNHEGFNBGBP = Shader.PropertyToID("SneakBackward");
		this.OFNKEJPFHPM = Shader.PropertyToID("_FogData");
		this.JHGLFOIFPNA = Shader.PropertyToID("WalkInjured");
		this.BEAGFOMBNIE = Shader.PropertyToID(" ");
		this.HAOPEKACGKJ = Shader.PropertyToID("_AdaptationMin");
		this.JKPIIPGJCGL = Shader.PropertyToID("_ReflectionTex");
		this.OLDFANLEEPP = Shader.PropertyToID("_FinalReflectionTexture");
		this.JEBEODKPNBD = Shader.PropertyToID("error.wav");
		this.FPFCLGAHHPJ = Shader.PropertyToID("MotorbikeLookBack");
		this.BIBGFHMDCOC = Shader.PropertyToID("__a");
		this.PFENCNMEJGE = Shader.PropertyToID("BowInstant2");
		this.NIBOHKNFDPB = Shader.PropertyToID("choldposx");
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x0012DFB0 File Offset: 0x0012C1B0
	public void CHFDLGCAHNG()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("IceHockeyGoalieReady");
		this.PBDNAONCCBD = Shader.PropertyToID("_QualitySettings");
		this.ICEFEJNFPNB = Shader.PropertyToID(" ms");
		this.DNCCNIPJJFP = Shader.PropertyToID("colorB");
		this.EPACGLABCFJ = Shader.PropertyToID("pinky");
		this.CGMKIBNPFFI = Shader.PropertyToID("Failed to find head ray.. inside shell?");
		this.CMGHEMIEACC = Shader.PropertyToID("recept");
		this.MIKPHLGJFKC = Shader.PropertyToID("sunshine_DepthBiases");
		this.PMDMDAEHDFE = Shader.PropertyToID("FireBreath");
		this.LAOIHBNKNDC = Shader.PropertyToID(" locid=");
		this.DKIOGOAGEMJ = Shader.PropertyToID("_Offsets");
		this.LNJEDJHGDBA = Shader.PropertyToID("Unsupported shader.");
		this.PCGJBGMPMPJ = Shader.PropertyToID("IdleRun");
		this.LCFIPCLBNCP = Shader.PropertyToID("_ChromaticAberration_Amount");
		this.GHENKAHBNGH = Shader.PropertyToID("IdleButtonPress");
		this.DIMGPCEBEGE = Shader.PropertyToID("value");
		this.AHNEKMDHFKC = Shader.PropertyToID("demoByteArray");
		this.IGOEANOOFFF = Shader.PropertyToID("time_format1");
		this.OFHAIPIBDBC = Shader.PropertyToID("_ProjInfo");
		this.NJIOJANKEDD = Shader.PropertyToID("80ff00");
		this.OEIDCFLBDAL = Shader.PropertyToID("</color>");
		this.FNCBANADCBJ = Shader.PropertyToID(" listed as it's child.");
		this.MAMMKBMCDED = Shader.PropertyToID("The InteractionSystem has not been initiated yet.");
		this.ALMNFJFCEKI = Shader.PropertyToID("demoRect");
		this.IHHIGFMOPHG = Shader.PropertyToID("VIGNETTE_CLASSIC");
		this.CHGMOFGHPND = Shader.PropertyToID("<color='#200080'>");
		this.MNHEGFNBGBP = Shader.PropertyToID("Windows");
		this.OFNKEJPFHPM = Shader.PropertyToID("wpn_onlyw");
		this.JHGLFOIFPNA = Shader.PropertyToID("x");
		this.BEAGFOMBNIE = Shader.PropertyToID("]");
		this.HAOPEKACGKJ = Shader.PropertyToID("ObscuredBool vs bool, ");
		this.JKPIIPGJCGL = Shader.PropertyToID("MotorbikeTurnRight");
		this.OLDFANLEEPP = Shader.PropertyToID("");
		this.JEBEODKPNBD = Shader.PropertyToID(" ms");
		this.FPFCLGAHHPJ = Shader.PropertyToID("Stand Up");
		this.BIBGFHMDCOC = Shader.PropertyToID("_Vignette_Opacity");
		this.PFENCNMEJGE = Shader.PropertyToID("ExceptionOnConnect PROCEDURE ");
		this.NIBOHKNFDPB = Shader.PropertyToID("btn_cancel");
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x0012E220 File Offset: 0x0012C420
	public static Mesh HLEHNDIPHCN(Vector2 GDCMKLMHFLI, Vector2 PCHICFGNFGF)
	{
		Mesh mesh = new Mesh();
		UnityEngine.Object @object = mesh;
		object[] array = new object[]
		{
			null,
			"_MaskTex"
		};
		array[0] = GDCMKLMHFLI;
		array[1] = "contrast";
		array[2] = PCHICFGNFGF;
		@object.name = string.Concat(array);
		Mesh mesh2 = mesh;
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(1696f, 779f, 1894f);
		array2[1] = new Vector3(1407f, 27f, 661f);
		array2[2] = new Vector3(1056f, 1877f, 464f);
		array2[7] = new Vector3(323f, 1553f, 1005f);
		mesh2.vertices = array2;
		Mesh mesh3 = mesh;
		Vector2[] array3 = new Vector2[5];
		array3[1] = new Vector2(GDCMKLMHFLI.x, GDCMKLMHFLI.y);
		array3[0] = new Vector2(GDCMKLMHFLI.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, PCHICFGNFGF.y);
		array3[6] = new Vector2(PCHICFGNFGF.x, GDCMKLMHFLI.y);
		mesh3.uv = array3;
		mesh.triangles = new int[]
		{
			0,
			3
		};
		Mesh mesh4 = mesh;
		Vector3[] array4 = new Vector3[4];
		array4[0] = new Vector3(1418f, 1146f, 762f);
		array4[0] = new Vector3(1945f, 319f, 1336f);
		array4[3] = new Vector3(663f, 1179f, 1637f);
		array4[4] = new Vector3(1143f, 1693f, 1748f);
		mesh4.normals = array4;
		Mesh mesh5 = mesh;
		Vector4[] array5 = new Vector4[5];
		array5[0] = new Vector4(262f, 995f, 1335f, 496f);
		array5[0] = new Vector4(1850f, 340f, 1938f, 1017f);
		array5[5] = new Vector4(1132f, 1351f, 1085f, 809f);
		array5[1] = new Vector4(665f, 216f, 475f, 689f);
		mesh5.tangents = array5;
		return mesh;
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x0012E468 File Offset: 0x0012C668
	public void NKLPPOGEENL()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("_Bloom_Settings");
		this.PBDNAONCCBD = Shader.PropertyToID(" гр ");
		this.ICEFEJNFPNB = Shader.PropertyToID("_name");
		this.DNCCNIPJJFP = Shader.PropertyToID("Flap_04.wav");
		this.EPACGLABCFJ = Shader.PropertyToID("=");
		this.CGMKIBNPFFI = Shader.PropertyToID("ShowCursor");
		this.CMGHEMIEACC = Shader.PropertyToID("OpenRecords");
		this.MIKPHLGJFKC = Shader.PropertyToID("ResetObject");
		this.PMDMDAEHDFE = Shader.PropertyToID("<color='#003000'>{0} на {1}</color>");
		this.LAOIHBNKNDC = Shader.PropertyToID("KatanaReadyLow");
		this.DKIOGOAGEMJ = Shader.PropertyToID("fanfare.wav");
		this.LNJEDJHGDBA = Shader.PropertyToID(" cannot be used as a 3D LUT.");
		this.PCGJBGMPMPJ = Shader.PropertyToID("Sunshine Project Configuration");
		this.LCFIPCLBNCP = Shader.PropertyToID("stname");
		this.GHENKAHBNGH = Shader.PropertyToID("demoLong");
		this.DIMGPCEBEGE = Shader.PropertyToID("Money: ");
		this.AHNEKMDHFKC = Shader.PropertyToID("");
		this.IGOEANOOFFF = Shader.PropertyToID("");
		this.OFHAIPIBDBC = Shader.PropertyToID("[ProBuilder Attachments] Please disable the following option in the Unity preferences:");
		this.NJIOJANKEDD = Shader.PropertyToID("invn_rec14");
		this.OEIDCFLBDAL = Shader.PropertyToID("IdleMonster");
		this.FNCBANADCBJ = Shader.PropertyToID("Mouse X");
		this.MAMMKBMCDED = Shader.PropertyToID("Steam Overlay has been closed");
		this.ALMNFJFCEKI = Shader.PropertyToID("");
		this.IHHIGFMOPHG = Shader.PropertyToID("{0}/{1}");
		this.CHGMOFGHPND = Shader.PropertyToID("UpHillWalk");
		this.MNHEGFNBGBP = Shader.PropertyToID("1HandSwordChargeUp");
		this.OFNKEJPFHPM = Shader.PropertyToID("#404040");
		this.JHGLFOIFPNA = Shader.PropertyToID("craft_data/categories/category");
		this.BEAGFOMBNIE = Shader.PropertyToID("11");
		this.HAOPEKACGKJ = Shader.PropertyToID("PaperTurn.wav");
		this.JKPIIPGJCGL = Shader.PropertyToID("Steam Overlay has been closed");
		this.OLDFANLEEPP = Shader.PropertyToID("3");
		this.JEBEODKPNBD = Shader.PropertyToID("shop_t19");
		this.FPFCLGAHHPJ = Shader.PropertyToID("---------- NetManager is init");
		this.BIBGFHMDCOC = Shader.PropertyToID(" ms");
		this.PFENCNMEJGE = Shader.PropertyToID("<color='#c0c080'>");
		this.NIBOHKNFDPB = Shader.PropertyToID("WeaponReady");
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x0012E6D8 File Offset: 0x0012C8D8
	public void OPECDIJFJJN()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("FactoryTempTexture");
		this.PBDNAONCCBD = Shader.PropertyToID(" cm");
		this.ICEFEJNFPNB = Shader.PropertyToID("OneHandSwordRun");
		this.DNCCNIPJJFP = Shader.PropertyToID(" ");
		this.EPACGLABCFJ = Shader.PropertyToID("_TrStartYou.ogg");
		this.CGMKIBNPFFI = Shader.PropertyToID("MotorbikeShootRight");
		this.CMGHEMIEACC = Shader.PropertyToID("_n");
		this.MIKPHLGJFKC = Shader.PropertyToID("_LerpRgbTex");
		this.PMDMDAEHDFE = Shader.PropertyToID("profy_minlevel");
		this.LAOIHBNKNDC = Shader.PropertyToID("WorkerHammer2");
		this.DKIOGOAGEMJ = Shader.PropertyToID("ElvisLegsLoop");
		this.LNJEDJHGDBA = Shader.PropertyToID("/");
		this.PCGJBGMPMPJ = Shader.PropertyToID("Reset");
		this.LCFIPCLBNCP = Shader.PropertyToID("file://");
		this.GHENKAHBNGH = Shader.PropertyToID("noDress");
		this.DIMGPCEBEGE = Shader.PropertyToID("_WaterLevel");
		this.AHNEKMDHFKC = Shader.PropertyToID("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
		this.IGOEANOOFFF = Shader.PropertyToID("http://af-2.ru/pay/finalize.php?orderid={0}&appid={1}&metod={2}");
		this.OFHAIPIBDBC = Shader.PropertyToID("and I needed");
		this.NJIOJANKEDD = Shader.PropertyToID("OK");
		this.OEIDCFLBDAL = Shader.PropertyToID("</color>\n");
		this.FNCBANADCBJ = Shader.PropertyToID("reelspd");
		this.MAMMKBMCDED = Shader.PropertyToID("bool: ");
		this.ALMNFJFCEKI = Shader.PropertyToID("");
		this.IHHIGFMOPHG = Shader.PropertyToID("HeelClick");
		this.CHGMOFGHPND = Shader.PropertyToID("KatanaNinjaDraw");
		this.MNHEGFNBGBP = Shader.PropertyToID("\n");
		this.OFNKEJPFHPM = Shader.PropertyToID("PaperTurn.wav");
		this.JHGLFOIFPNA = Shader.PropertyToID(" ");
		this.BEAGFOMBNIE = Shader.PropertyToID("delcharmsg1");
		this.HAOPEKACGKJ = Shader.PropertyToID(" fid=");
		this.JKPIIPGJCGL = Shader.PropertyToID("GiantEat");
		this.OLDFANLEEPP = Shader.PropertyToID("FlyForward");
		this.JEBEODKPNBD = Shader.PropertyToID("FONT");
		this.FPFCLGAHHPJ = Shader.PropertyToID("quests/qdynamic/qd");
		this.BIBGFHMDCOC = Shader.PropertyToID("\n");
		this.PFENCNMEJGE = Shader.PropertyToID("1HandSwordStrafeRight");
		this.NIBOHKNFDPB = Shader.PropertyToID("titul_data/tituls/titul");
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x0012E948 File Offset: 0x0012CB48
	public void FIDPPFMNPFL()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("btn_cancel");
		this.PBDNAONCCBD = Shader.PropertyToID("Mech");
		this.ICEFEJNFPNB = Shader.PropertyToID("Shaders/EyeHistogram");
		this.DNCCNIPJJFP = Shader.PropertyToID("Start Interaction With ");
		this.EPACGLABCFJ = Shader.PropertyToID("OfficeSittingReadingLeanBack");
		this.CGMKIBNPFFI = Shader.PropertyToID("inv_nodur");
		this.CMGHEMIEACC = Shader.PropertyToID("RollerBladeStop");
		this.MIKPHLGJFKC = Shader.PropertyToID("author");
		this.PMDMDAEHDFE = Shader.PropertyToID("harvestmsg2");
		this.LAOIHBNKNDC = Shader.PropertyToID("ShootWireframeModule");
		this.DKIOGOAGEMJ = Shader.PropertyToID("Thumb");
		this.LNJEDJHGDBA = Shader.PropertyToID("dir");
		this.PCGJBGMPMPJ = Shader.PropertyToID("WorkerPickaxe");
		this.LCFIPCLBNCP = Shader.PropertyToID("post_23");
		this.GHENKAHBNGH = Shader.PropertyToID("\n");
		this.DIMGPCEBEGE = Shader.PropertyToID("Keeper Strafe Dive Far Right");
		this.AHNEKMDHFKC = Shader.PropertyToID("BowReady");
		this.IGOEANOOFFF = Shader.PropertyToID("WeaponInstant");
		this.OFHAIPIBDBC = Shader.PropertyToID("WateringCan");
		this.NJIOJANKEDD = Shader.PropertyToID("CP3");
		this.OEIDCFLBDAL = Shader.PropertyToID("UnityEngine.Vector4");
		this.FNCBANADCBJ = Shader.PropertyToID("Bow Idle");
		this.MAMMKBMCDED = Shader.PropertyToID("Only Hinge Rotation Limits should be used on 2D IK solvers.");
		this.ALMNFJFCEKI = Shader.PropertyToID("WizardEyeBeam");
		this.IHHIGFMOPHG = Shader.PropertyToID("PaperTurn.wav");
		this.CHGMOFGHPND = Shader.PropertyToID("CardPlayerLook");
		this.MNHEGFNBGBP = Shader.PropertyToID("_PrevViewProj");
		this.OFNKEJPFHPM = Shader.PropertyToID("1HSwordStrafeRunRight");
		this.JHGLFOIFPNA = Shader.PropertyToID("RussianDance");
		this.BEAGFOMBNIE = Shader.PropertyToID(" on effect ");
		this.HAOPEKACGKJ = Shader.PropertyToID("Idle180");
		this.JKPIIPGJCGL = Shader.PropertyToID("LDR");
		this.OLDFANLEEPP = Shader.PropertyToID("RunJump");
		this.JEBEODKPNBD = Shader.PropertyToID("wpn_add/base");
		this.FPFCLGAHHPJ = Shader.PropertyToID("<color='#000000'>--------------------------------------------------------</color>");
		this.BIBGFHMDCOC = Shader.PropertyToID("error.wav");
		this.PFENCNMEJGE = Shader.PropertyToID("finger");
		this.NIBOHKNFDPB = Shader.PropertyToID("Q");
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x0012EBB8 File Offset: 0x0012CDB8
	public void LLDJDJDGNNJ()
	{
		this.FJIHFMOALEP = Shader.PropertyToID("MotorbikeBackwardSittingCheer");
		this.PBDNAONCCBD = Shader.PropertyToID("_Refraction");
		this.ICEFEJNFPNB = Shader.PropertyToID("VRIK References are not filled in, can not guess hand orientations. Right-click on VRIK header and slect 'Guess Hand Orientations' when you have filled in the References.");
		this.DNCCNIPJJFP = Shader.PropertyToID("System.Boolean");
		this.EPACGLABCFJ = Shader.PropertyToID("ThisRenderer.bones[i].name is null");
		this.CGMKIBNPFFI = Shader.PropertyToID("Select option");
		this.CMGHEMIEACC = Shader.PropertyToID("References has no spine bones assigned, can not initiate the solver.");
		this.MIKPHLGJFKC = Shader.PropertyToID("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
		this.PMDMDAEHDFE = Shader.PropertyToID("fanfare.wav");
		this.LAOIHBNKNDC = Shader.PropertyToID("wpn_wgt");
		this.DKIOGOAGEMJ = Shader.PropertyToID("_SunPosition");
		this.LNJEDJHGDBA = Shader.PropertyToID("BAG");
		this.PCGJBGMPMPJ = Shader.PropertyToID("IdleWalk");
		this.LCFIPCLBNCP = Shader.PropertyToID("[LH &]");
		this.GHENKAHBNGH = Shader.PropertyToID("inv_auklotinf");
		this.DIMGPCEBEGE = Shader.PropertyToID("_SunPosition");
		this.AHNEKMDHFKC = Shader.PropertyToID("FactoryTempTexture");
		this.IGOEANOOFFF = Shader.PropertyToID("Idle Typing");
		this.OFHAIPIBDBC = Shader.PropertyToID("droprodmsg1");
		this.NJIOJANKEDD = Shader.PropertyToID("USE_MASK");
		this.OEIDCFLBDAL = Shader.PropertyToID("SwimFreestyle");
		this.FNCBANADCBJ = Shader.PropertyToID("PistolInstant");
		this.MAMMKBMCDED = Shader.PropertyToID("\">Foreign saves detected: ");
		this.ALMNFJFCEKI = Shader.PropertyToID("ScatterDitherData");
		this.IHHIGFMOPHG = Shader.PropertyToID("droplinemsg1");
		this.CHGMOFGHPND = Shader.PropertyToID("error: already initialized");
		this.MNHEGFNBGBP = Shader.PropertyToID("Используем ");
		this.OFNKEJPFHPM = Shader.PropertyToID("' that does not excist in the Node Chain.");
		this.JHGLFOIFPNA = Shader.PropertyToID(".unity3d");
		this.BEAGFOMBNIE = Shader.PropertyToID("paramsup=");
		this.HAOPEKACGKJ = Shader.PropertyToID("ara_trail_mesh");
		this.JKPIIPGJCGL = Shader.PropertyToID("_WrinkleMapBumpScales");
		this.OLDFANLEEPP = Shader.PropertyToID("Sampling AO on ");
		this.JEBEODKPNBD = Shader.PropertyToID("Cloth_01.wav");
		this.FPFCLGAHHPJ = Shader.PropertyToID("_Axis");
		this.BIBGFHMDCOC = Shader.PropertyToID("WizardNeoBlock");
		this.PFENCNMEJGE = Shader.PropertyToID("offsets");
		this.NIBOHKNFDPB = Shader.PropertyToID("msg from NET channel=");
	}

	// Token: 0x04000555 RID: 1365
	public Mesh Quad;

	// Token: 0x04000556 RID: 1366
	public Mesh SphereHigh;

	// Token: 0x04000557 RID: 1367
	public Mesh SphereMedium;

	// Token: 0x04000558 RID: 1368
	public Mesh SphereLow;

	// Token: 0x04000559 RID: 1369
	public Mesh IcosphereHigh;

	// Token: 0x0400055A RID: 1370
	public Mesh IcosphereMedium;

	// Token: 0x0400055B RID: 1371
	public Mesh IcosphereLow;

	// Token: 0x0400055C RID: 1372
	public Mesh HalfIcosphereHigh;

	// Token: 0x0400055D RID: 1373
	public Mesh HalfIcosphereMedium;

	// Token: 0x0400055E RID: 1374
	public Mesh HalfIcosphereLow;

	// Token: 0x0400055F RID: 1375
	public Material CloudMaterial;

	// Token: 0x04000560 RID: 1376
	public Material ShadowMaterial;

	// Token: 0x04000561 RID: 1377
	public Material BillboardMaterial;

	// Token: 0x04000562 RID: 1378
	public Material SpaceMaterial;

	// Token: 0x04000563 RID: 1379
	public Material AtmosphereMaterial;

	// Token: 0x04000564 RID: 1380
	public Material SunMaterial;

	// Token: 0x04000565 RID: 1381
	public Material MoonMaterial;

	// Token: 0x04000566 RID: 1382
	public Material ClearMaterial;

	// Token: 0x04000567 RID: 1383
	public Material SkyboxMaterial;

	// Token: 0x04000568 RID: 1384
	internal int FJIHFMOALEP;

	// Token: 0x04000569 RID: 1385
	internal int PBDNAONCCBD;

	// Token: 0x0400056A RID: 1386
	internal int ICEFEJNFPNB;

	// Token: 0x0400056B RID: 1387
	internal int DNCCNIPJJFP;

	// Token: 0x0400056C RID: 1388
	internal int EPACGLABCFJ;

	// Token: 0x0400056D RID: 1389
	internal int CGMKIBNPFFI;

	// Token: 0x0400056E RID: 1390
	internal int CMGHEMIEACC;

	// Token: 0x0400056F RID: 1391
	internal int MIKPHLGJFKC;

	// Token: 0x04000570 RID: 1392
	internal int PMDMDAEHDFE;

	// Token: 0x04000571 RID: 1393
	internal int LAOIHBNKNDC;

	// Token: 0x04000572 RID: 1394
	internal int DKIOGOAGEMJ;

	// Token: 0x04000573 RID: 1395
	internal int LNJEDJHGDBA;

	// Token: 0x04000574 RID: 1396
	internal int PCGJBGMPMPJ;

	// Token: 0x04000575 RID: 1397
	internal int LCFIPCLBNCP;

	// Token: 0x04000576 RID: 1398
	internal int GHENKAHBNGH;

	// Token: 0x04000577 RID: 1399
	internal int DIMGPCEBEGE;

	// Token: 0x04000578 RID: 1400
	internal int AHNEKMDHFKC;

	// Token: 0x04000579 RID: 1401
	internal int IGOEANOOFFF;

	// Token: 0x0400057A RID: 1402
	internal int OFHAIPIBDBC;

	// Token: 0x0400057B RID: 1403
	internal int NJIOJANKEDD;

	// Token: 0x0400057C RID: 1404
	internal int OEIDCFLBDAL;

	// Token: 0x0400057D RID: 1405
	internal int FNCBANADCBJ;

	// Token: 0x0400057E RID: 1406
	internal int MAMMKBMCDED;

	// Token: 0x0400057F RID: 1407
	internal int ALMNFJFCEKI;

	// Token: 0x04000580 RID: 1408
	internal int IHHIGFMOPHG;

	// Token: 0x04000581 RID: 1409
	internal int CHGMOFGHPND;

	// Token: 0x04000582 RID: 1410
	internal int MNHEGFNBGBP;

	// Token: 0x04000583 RID: 1411
	internal int OFNKEJPFHPM;

	// Token: 0x04000584 RID: 1412
	internal int JHGLFOIFPNA;

	// Token: 0x04000585 RID: 1413
	internal int BEAGFOMBNIE;

	// Token: 0x04000586 RID: 1414
	internal int HAOPEKACGKJ;

	// Token: 0x04000587 RID: 1415
	internal int JKPIIPGJCGL;

	// Token: 0x04000588 RID: 1416
	internal int OLDFANLEEPP;

	// Token: 0x04000589 RID: 1417
	internal int JEBEODKPNBD;

	// Token: 0x0400058A RID: 1418
	internal int FPFCLGAHHPJ;

	// Token: 0x0400058B RID: 1419
	internal int BIBGFHMDCOC;

	// Token: 0x0400058C RID: 1420
	internal int PFENCNMEJGE;

	// Token: 0x0400058D RID: 1421
	internal int NIBOHKNFDPB;
}
