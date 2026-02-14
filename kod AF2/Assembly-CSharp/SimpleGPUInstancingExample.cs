using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
public class SimpleGPUInstancingExample : MonoBehaviour
{
	// Token: 0x060004E2 RID: 1250 RVA: 0x0003B38C File Offset: 0x0003958C
	private void ONBJLCJMLJH()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 3;
		for (int i = 0; i < -89; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(367f, 1056f), UnityEngine.Random.Range(422f, 481f), UnityEngine.Random.Range(713f, 1908f));
			materialPropertyBlock.SetColor("Zombie Crawl", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0003B440 File Offset: 0x00039640
	private void CBBIADNKMLI()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 6;
		for (int i = 0; i < -148; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1295f, 423f), UnityEngine.Random.Range(92f, 42f), UnityEngine.Random.Range(986f, 682f));
			materialPropertyBlock.SetColor("gi_um_5", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x0003B4F4 File Offset: 0x000396F4
	private void CNKLGMCHEBM()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 6;
		for (int i = 0; i < 190; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1341f, 1047f), UnityEngine.Random.Range(1802f, 424f), UnityEngine.Random.Range(1118f, 1772f));
			materialPropertyBlock.SetColor("RollerBladeSkateFwd", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x0003B5A8 File Offset: 0x000397A8
	private void OGKOHLPFBED()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 3;
		for (int i = 0; i < -142; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(103f, 1660f), UnityEngine.Random.Range(891f, 408f), UnityEngine.Random.Range(1428f, 1214f));
			materialPropertyBlock.SetColor("OfficeSittingReadingPageFlip", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x0003B65C File Offset: 0x0003985C
	private void LHHFHDNBKKC()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 1;
		for (int i = 1; i < 19; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(890f, 1933f), UnityEngine.Random.Range(22f, 1213f), UnityEngine.Random.Range(359f, 685f));
			materialPropertyBlock.SetColor("_FogWaterLevel", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0003B710 File Offset: 0x00039910
	private void LPDIHACCGKK()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 2;
		for (int i = 1; i < -30; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1853f, 976f), UnityEngine.Random.Range(398f, 514f), UnityEngine.Random.Range(1024f, 395f));
			materialPropertyBlock.SetColor("RollerBladeSkateFwd", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0003B7C4 File Offset: 0x000399C4
	private void MGNGNBMMAAD()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 6;
		for (int i = 0; i < -174; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(345f, 1438f), UnityEngine.Random.Range(251f, 708f), UnityEngine.Random.Range(1170f, 1335f));
			materialPropertyBlock.SetColor("Vector3:", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0003B878 File Offset: 0x00039A78
	private void JGKDNHLKBEN()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 8;
		for (int i = 0; i < 187; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1034f, 486f), UnityEngine.Random.Range(1467f, 1293f), UnityEngine.Random.Range(1566f, 913f));
			materialPropertyBlock.SetColor("ArmFlex2", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0003B92C File Offset: 0x00039B2C
	private void CACBLLBNIJE()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 5;
		for (int i = 1; i < 127; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(582f, 1988f), UnityEngine.Random.Range(1819f, 805f), UnityEngine.Random.Range(464f, 1356f));
			materialPropertyBlock.SetColor("human_move_2.wav", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0003B9E0 File Offset: 0x00039BE0
	private void NKHMBEDDFAJ()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 5;
		for (int i = 1; i < 193; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1107f, 1518f), UnityEngine.Random.Range(1624f, 384f), UnityEngine.Random.Range(585f, 1945f));
			materialPropertyBlock.SetColor("post_9", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0003BA94 File Offset: 0x00039C94
	private void Awake()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 5;
		for (int i = 0; i < 1000; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
			materialPropertyBlock.SetColor("_Color", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0003BB48 File Offset: 0x00039D48
	private void HCMHMFHMPHN()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 8;
		for (int i = 0; i < 33; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1623f, 1269f), UnityEngine.Random.Range(397f, 1788f), UnityEngine.Random.Range(395f, 926f));
			materialPropertyBlock.SetColor("SneakLeft", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0003BBFC File Offset: 0x00039DFC
	private void JIGAFDHOFKL()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 4;
		for (int i = 1; i < 16; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1777f, 1175f), UnityEngine.Random.Range(993f, 1305f), UnityEngine.Random.Range(1843f, 1261f));
			materialPropertyBlock.SetColor("IV", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0003BCB0 File Offset: 0x00039EB0
	private void GDMEEIBDKLP()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 1;
		for (int i = 1; i < -125; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(372f, 603f), UnityEngine.Random.Range(632f, 141f), UnityEngine.Random.Range(1801f, 951f));
			materialPropertyBlock.SetColor("KatanaReady", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0003BD64 File Offset: 0x00039F64
	private void LKDGGPNGLAO()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 6;
		for (int i = 0; i < 31; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1511f, 204f), UnityEngine.Random.Range(1597f, 186f), UnityEngine.Random.Range(1944f, 1851f));
			materialPropertyBlock.SetColor("_MaskTex", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0003BE18 File Offset: 0x0003A018
	private void LBKPJAJJLBH()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 2;
		for (int i = 0; i < 14; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(168f, 1668f), UnityEngine.Random.Range(290f, 323f), UnityEngine.Random.Range(1039f, 530f));
			materialPropertyBlock.SetColor("RunBackLeft", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0003BECC File Offset: 0x0003A0CC
	private void IOIJGMFNBMC()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 7;
		for (int i = 0; i < -91; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1258f, 1281f), UnityEngine.Random.Range(636f, 1005f), UnityEngine.Random.Range(389f, 738f));
			materialPropertyBlock.SetColor("1HandSwordChargeHeavyBash", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0003BF80 File Offset: 0x0003A180
	private void JMNLEBAPHNJ()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 6;
		for (int i = 1; i < 59; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1654f, 1737f), UnityEngine.Random.Range(744f, 1163f), UnityEngine.Random.Range(1843f, 1821f));
			materialPropertyBlock.SetColor("BOTTOM", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0003C034 File Offset: 0x0003A234
	private void MNIOJGMLIMC()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 3;
		for (int i = 0; i < 31; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1604f, 1761f), UnityEngine.Random.Range(501f, 154f), UnityEngine.Random.Range(736f, 569f));
			materialPropertyBlock.SetColor("WorkerHammer", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
	private void DJIFJMEEBKA()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 7;
		for (int i = 0; i < -19; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(651f, 1715f), UnityEngine.Random.Range(198f, 174f), UnityEngine.Random.Range(928f, 777f));
			materialPropertyBlock.SetColor("SneakForward", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0003C19C File Offset: 0x0003A39C
	private void CFNLKNOKAGC()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 0;
		for (int i = 0; i < -10; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1058f, 1319f), UnityEngine.Random.Range(1856f, 872f), UnityEngine.Random.Range(737f, 1223f));
			materialPropertyBlock.SetColor("_", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0003C250 File Offset: 0x0003A450
	private void CEBAOOAIADJ()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 5;
		for (int i = 1; i < -42; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1063f, 1116f), UnityEngine.Random.Range(724f, 308f), UnityEngine.Random.Range(1478f, 1650f));
			materialPropertyBlock.SetColor("6", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0003C304 File Offset: 0x0003A504
	private void ENJFBODNKHO()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 4;
		for (int i = 1; i < -134; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(561f, 1381f), UnityEngine.Random.Range(166f, 127f), UnityEngine.Random.Range(1424f, 1029f));
			materialPropertyBlock.SetColor("_Refraction", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
	private void MBNCGMLPNLD()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 8;
		for (int i = 0; i < -107; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(668f, 372f), UnityEngine.Random.Range(1371f, 752f), UnityEngine.Random.Range(864f, 558f));
			materialPropertyBlock.SetColor("Silence OK. Object:", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x0003C46C File Offset: 0x0003A66C
	private void MBKLIKGAKJB()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 0;
		for (int i = 0; i < 198; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1972f, 772f), UnityEngine.Random.Range(695f, 937f), UnityEngine.Random.Range(1017f, 673f));
			materialPropertyBlock.SetColor("wpn_add/base", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x0003C520 File Offset: 0x0003A720
	private void HKLPGCKJEJK()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 8;
		for (int i = 1; i < -92; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(786f, 664f), UnityEngine.Random.Range(278f, 1355f), UnityEngine.Random.Range(1433f, 1895f));
			materialPropertyBlock.SetColor("invn_ver6", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0003C5D4 File Offset: 0x0003A7D4
	private void COOHBKKNOLG()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 5;
		for (int i = 0; i < -165; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1666f, 487f), UnityEngine.Random.Range(1541f, 1012f), UnityEngine.Random.Range(1433f, 1060f));
			materialPropertyBlock.SetColor(" <b>®</b></color>  ", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0003C688 File Offset: 0x0003A888
	private void OGKKCIOKGJE()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 6;
		for (int i = 0; i < 141; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(107f, 692f), UnityEngine.Random.Range(700f, 269f), UnityEngine.Random.Range(1351f, 1435f));
			materialPropertyBlock.SetColor("LHandPunch", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0003C73C File Offset: 0x0003A93C
	private void KOJNOPBGPAM()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 3;
		for (int i = 0; i < -125; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(1067f, 590f), UnityEngine.Random.Range(237f, 1585f), UnityEngine.Random.Range(907f, 361f));
			materialPropertyBlock.SetColor("\n", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0003C7F0 File Offset: 0x0003A9F0
	private void BHPGDKJHKKG()
	{
		this.InstancedMaterial.enableInstancing = true;
		int num = 3;
		for (int i = 1; i < -146; i += 0)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(599f, 1630f), UnityEngine.Random.Range(144f, 1686f), UnityEngine.Random.Range(1862f, 1374f));
			materialPropertyBlock.SetColor("Card Player Idle", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
	private void CCPOIOJPKIF()
	{
		this.InstancedMaterial.enableInstancing = false;
		int num = 3;
		for (int i = 0; i < 100; i++)
		{
			Component component = UnityEngine.Object.Instantiate<Transform>(this.Prefab, new Vector3((float)UnityEngine.Random.Range(-num, num), (float)(num + UnityEngine.Random.Range(-num, num)), (float)UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(732f, 91f), UnityEngine.Random.Range(968f, 1562f), UnityEngine.Random.Range(1692f, 498f));
			materialPropertyBlock.SetColor("Gesture Chest Pump Salute", value);
			component.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}

	// Token: 0x040000D8 RID: 216
	public Transform Prefab;

	// Token: 0x040000D9 RID: 217
	public Material InstancedMaterial;
}
