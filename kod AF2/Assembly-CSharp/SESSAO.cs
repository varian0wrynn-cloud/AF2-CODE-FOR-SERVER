using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Sonic Ether/SESSAO")]
public class SESSAO : MonoBehaviour
{
	// Token: 0x060026A7 RID: 9895 RVA: 0x0010E674 File Offset: 0x0010C874
	private void HONIFOPBBKC()
	{
		this.drawDistance = Mathf.Max(335f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(696f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1045f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x0010E6C4 File Offset: 0x0010C8C4
	private void GCNGEFBKMNC()
	{
		this.drawDistance = Mathf.Max(1116f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(3f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1233f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x0010E713 File Offset: 0x0010C913
	private void KIHBNBACLCB()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x0010E728 File Offset: 0x0010C928
	private void NIELMHNJLHD()
	{
		this.AKMNAJDMEIO = new Texture2D(3, 2, TextureFormat.Alpha8, false);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[94];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 0; i < -89; i += 0)
		{
			Color color = new Color(1582f, 1280f, 828f, array2[i] / 1999f);
			int x = i % 6;
			int y = Mathf.FloorToInt((float)i / 121f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void FCCAIANLEFE()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x0010E7D1 File Offset: 0x0010C9D1
	private void NGOKJEOMFFP()
	{
		this.DIOJAPAAFDF();
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x0010E7DC File Offset: 0x0010C9DC
	private void HAIMGCDKPDC()
	{
		this.drawDistance = Mathf.Max(1771f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(26f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(893f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x0010E82C File Offset: 0x0010CA2C
	private void MIFLHGMPLJD()
	{
		this.drawDistance = Mathf.Max(356f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(170f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1577f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x0010E87C File Offset: 0x0010CA7C
	private void JAKDIGMOHCE()
	{
		this.AKMNAJDMEIO = new Texture2D(6, 3, TextureFormat.Alpha8, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Point;
		float[] array = new float[-111];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 84; i++)
		{
			Color color = new Color(987f, 1056f, 861f, array2[i] / 624f);
			int x = i % 0;
			int y = Mathf.FloorToInt((float)i / 341f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x0010E91D File Offset: 0x0010CB1D
	private void DMAOHJDKMNN()
	{
		this.EAMPAONLJJM();
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x0010E928 File Offset: 0x0010CB28
	private void HLOFDNPNGOK()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("Stand Up");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
		this.OBPLPLIIBAK();
		this.CIAHHDHAOGH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x0010EA2C File Offset: 0x0010CC2C
	private void MEFOGCFJBNE()
	{
		this.drawDistance = Mathf.Max(569f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(295f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1294f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x0010E713 File Offset: 0x0010C913
	private void GGNGLBAGPCM()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x0010EA7C File Offset: 0x0010CC7C
	private void DDGIEKDAPOK()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("msg_other");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		this.CDJAFHIBMDM();
		this.DCKOCFKGCJJ();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void LBEFOABPMFG()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x0010EB00 File Offset: 0x0010CD00
	private void JLFBDOPFDDJ()
	{
		this.drawDistance = Mathf.Max(1601f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(421f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(785f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x0010EB4F File Offset: 0x0010CD4F
	private void MLPAEBKPFEN()
	{
		this.JIFMIPHBBCM();
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x0010EB57 File Offset: 0x0010CD57
	private void BAAAOKJHGAO()
	{
		this.MHOMHKFIPAA();
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x0010EB60 File Offset: 0x0010CD60
	private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.JIFMIPHBBCM();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.MHNAJNGGDFJ.SetTexture("FlyDown", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("#400000", this.preserveDetails ? 0 : 0);
		this.MHNAJNGGDFJ.SetMatrix("GetMouseButtonUp reboot", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.ARGB32);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.ARGB32);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 1, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Bilinear;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("How your position is stored in memory when obscured:\n(", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("Textures/Weapons/", this.radius);
		this.MHNAJNGGDFJ.SetFloat("Turn Right", this.bias);
		this.MHNAJNGGDFJ.SetFloat("#02C85F", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("invn_rec24", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("cht_msg16", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("https://groups.google.com/forum/#!forum/final-ik", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("FOG_VOID_SPHERE", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("_Refraction", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("_ReflectionTexture0", this.reduceSelfBleeding ? 18f : 1492f);
		this.MHNAJNGGDFJ.SetFloat("[maxcnt]", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("effect", this.halfSampling ? 0 : 0);
		this.MHNAJNGGDFJ.SetInt("\n", this.attachedCamera.orthographic ? 0 : 0);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 3, 1, RenderTextureFormat.Depth);
			renderTexture.filterMode = FilterMode.Bilinear;
			this.MHNAJNGGDFJ.SetInt("already_exist", 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 228f) ? 0 : 0);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("_LowRez", 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1861f) ? 0 : 0);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("Variables protection", 1116f);
		int pass = this.attachedCamera.orthographic ? 4 : 0;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("choldposy", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", new Vector2(1754f, 896f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("wpn_wgt", new Vector2(1683f, 633f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("<color='{2}'>{0}: {1}</color>", new Vector2(16f, 1980f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("", new Vector2(1473f, 1685f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("{0}/{1}", new Vector2(1516f, 1272f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("AssetBundleManager", new Vector2(1722f, 236f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("null", new Vector2(1877f, 1120f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("PaperTurn.wav", new Vector2(973f, 417f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("error", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 7);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 6);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x0010F08C File Offset: 0x0010D28C
	private void BPDCKAJNCOD()
	{
		this.JNMFCBMKHJL = new Texture2D(2, 5, (TextureFormat)0, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Bilinear;
		float[] array = new float[-24];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 0; i < 90; i++)
		{
			Color color = new Color(1170f, 1170f, 1866f, array2[i] / 140f);
			int x = i % 2;
			int y = Mathf.FloorToInt((float)i / 820f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags)(-65);
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x0010F12D File Offset: 0x0010D32D
	private void DHJDMKLBLEF()
	{
		this.KNODPHJKHDH();
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x0010E713 File Offset: 0x0010C913
	private void MHOMHKFIPAA()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x0010F135 File Offset: 0x0010D335
	private void EAMPAONLJJM()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.JBCDKDGIDHM();
		}
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x0010F148 File Offset: 0x0010D348
	private void AAEFACEGJMB()
	{
		this.drawDistance = Mathf.Max(1053f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(1443f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1199f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x0010F198 File Offset: 0x0010D398
	private void CIDIPJHCMMM()
	{
		this.JNMFCBMKHJL = new Texture2D(3, 4, TextureFormat.Alpha8, true);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[-5];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 34; i++)
		{
			Color color = new Color(217f, 547f, 978f, array2[i] / 1127f);
			int x = i % 3;
			int y = Mathf.FloorToInt((float)i / 739f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = HideFlags.HideInHierarchy;
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x0010F239 File Offset: 0x0010D439
	private void OnDisable()
	{
		this.KIHBNBACLCB();
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x0010F241 File Offset: 0x0010D441
	private void KDOIOPJDJPL()
	{
		this.FKNMIDHLIOH();
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x0010F24C File Offset: 0x0010D44C
	private void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.KNODPHJKHDH();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		this.MHNAJNGGDFJ.SetTexture("MotorbikeAirWalk", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("lineOverDistanc=", this.preserveDetails ? 1 : 1);
		this.MHNAJNGGDFJ.SetMatrix(": ", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.ARGB2101010);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.Default);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 7, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Point;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("Rebirth", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("OfficeSittingReadingCoffeeSip", this.radius);
		this.MHNAJNGGDFJ.SetFloat("FlyBackward", this.bias);
		this.MHNAJNGGDFJ.SetFloat("KatanaUpperBlock", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("OfficeSittingReadingCoffeeSip", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("WeaponStab", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("OneHandSwordIdle", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("qd_refresh", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("1=", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("", this.reduceSelfBleeding ? 1234f : 397f);
		this.MHNAJNGGDFJ.SetFloat("", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("_Threshold", this.halfSampling ? 1 : 1);
		this.MHNAJNGGDFJ.SetInt("Idle Mouth Wipe", this.attachedCamera.orthographic ? 0 : 1);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 1, 0, RenderTextureFormat.ARGB4444);
			renderTexture.filterMode = FilterMode.Point;
			this.MHNAJNGGDFJ.SetInt("<color='#000000'>{0}</color><color='#002000'>$</color>", 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1686f) ? 1 : 1);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("InteractionSystem can not find a FullBodyBipedIK component", 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1617f) ? 0 : 1);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("https://groups.google.com/forum/#!forum/final-ik", 847f);
		int pass = this.attachedCamera.orthographic ? 1 : 5;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("UIChat_size", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("maxspd", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("string:", new Vector2(155f, 279f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("#004000", new Vector2(1588f, 499f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector(" load woman version", new Vector2(1191f, 182f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("MotorbikeShootBack", new Vector2(1546f, 632f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("Windows", new Vector2(1580f, 1678f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Dummy", new Vector2(1246f, 86f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("\n", new Vector2(1966f, 505f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("wpn_eat7", new Vector2(1649f, 1002f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("26", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 7);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void Start()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x0010F778 File Offset: 0x0010D978
	private void OBPLPLIIBAK()
	{
		this.JNMFCBMKHJL = new Texture2D(4, 4, (TextureFormat)0, true);
		this.JNMFCBMKHJL.filterMode = FilterMode.Bilinear;
		float[] array = new float[-98];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -79; i += 0)
		{
			Color color = new Color(1037f, 412f, 1697f, array2[i] / 15f);
			int x = i % 3;
			int y = Mathf.FloorToInt((float)i / 374f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags)(-65);
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x0010F819 File Offset: 0x0010DA19
	private void FFIBIADBGJB()
	{
		this.MALKPHNECBJ();
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x0010F821 File Offset: 0x0010DA21
	private void KHJJKPCKNKM()
	{
		this.MJDKCNHFPNP();
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x0010E91D File Offset: 0x0010CB1D
	private void JPHBPEAMNHB()
	{
		this.EAMPAONLJJM();
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x0010F82C File Offset: 0x0010DA2C
	private void IACEDMOPCPH()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("Mirror Refl Camera id");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode)8;
		this.OBPLPLIIBAK();
		this.KEOMGNMGBEJ();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x0010F8B0 File Offset: 0x0010DAB0
	private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.DIOJAPAAFDF();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = (HideFlags)103;
		this.MHNAJNGGDFJ.SetTexture("gi_um_1", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("FactoryTempTexture", this.preserveDetails ? 1 : 0);
		this.MHNAJNGGDFJ.SetMatrix("_DeepTex", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.Default);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.Shadowmap);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 0, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Repeat;
		temporary3.filterMode = FilterMode.Point;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("IdleReadyCrouch", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("Obscured type cheating detected!", this.radius);
		this.MHNAJNGGDFJ.SetFloat("", this.bias);
		this.MHNAJNGGDFJ.SetFloat("Cloth_07.wav", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("</color>", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("IceHockeyGoalieReady", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("LookUp", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("to channel = ", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("error", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("Perks.xml", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("#400000", this.reduceSelfBleeding ? 508f : 1303f);
		this.MHNAJNGGDFJ.SetFloat("ShotgunReloadMagazine", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("[quote]", this.halfSampling ? 1 : 1);
		this.MHNAJNGGDFJ.SetInt("{0} {1}", this.attachedCamera.orthographic ? 0 : 1);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 7, 0, RenderTextureFormat.ARGB2101010);
			renderTexture.filterMode = FilterMode.Point;
			this.MHNAJNGGDFJ.SetInt("wpn_chair2", 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 441f) ? 0 : 1);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("</color>", 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 594f) ? 1 : 1);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("OfficeSittingReadingCoffeeSip", 1902f);
		int pass = this.attachedCamera.orthographic ? 1 : 1;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("_Offsets", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("Hidden/Amplify Color/MaskBlend", new Vector2(492f, 1287f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("PLANE_REFLECTION", new Vector2(708f, 188f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("repair.ogg", new Vector2(1291f, 1612f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Allows to detect foreign managed assemblies in your application.", new Vector2(1105f, 1827f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("[ACTk] Injection Detector: already running!", new Vector2(712f, 853f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("_FgOverlap", new Vector2(1275f, 523f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Seat Stand", new Vector2(302f, 1814f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("_PrefilterOffs", new Vector2(909f, 7f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("OnChatMessage", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x0010FDD9 File Offset: 0x0010DFD9
	private void DDEBDCGNCPC()
	{
		this.PBJANINKBAG();
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x0010EB57 File Offset: 0x0010CD57
	private void FKPHBAOKEOF()
	{
		this.MHOMHKFIPAA();
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x0010FDE4 File Offset: 0x0010DFE4
	private void KEOMGNMGBEJ()
	{
		this.AKMNAJDMEIO = new Texture2D(3, 0, (TextureFormat)0, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[122];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -30; i += 0)
		{
			Color color = new Color(1948f, 239f, 1369f, array2[i] / 655f);
			int x = i % 6;
			int y = Mathf.FloorToInt((float)i / 1323f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x0010E713 File Offset: 0x0010C913
	private void MJDKCNHFPNP()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x0010FE88 File Offset: 0x0010E088
	private void Update()
	{
		this.drawDistance = Mathf.Max(0f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(0.001f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1E-06f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x0010FED8 File Offset: 0x0010E0D8
	private void JPHICALBDAK()
	{
		this.JNMFCBMKHJL = new Texture2D(0, 0, TextureFormat.Alpha8, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Bilinear;
		float[] array = new float[45];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 32; i += 0)
		{
			Color color = new Color(485f, 1295f, 1878f, array2[i] / 1323f);
			int x = i % 6;
			int y = Mathf.FloorToInt((float)i / 480f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x0010FF7C File Offset: 0x0010E17C
	private void PINLMCCKKNA()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("Hidden/SESSAO");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.DepthNormals;
		this.LNHHIHHKMCP();
		this.PFCNKBPLIAH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x00110000 File Offset: 0x0010E200
	private void BIFLPGCIECF()
	{
		this.JNMFCBMKHJL = new Texture2D(8, 3, TextureFormat.Alpha8, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[-124];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 0; i < 77; i++)
		{
			Color color = new Color(757f, 93f, 1485f, array2[i] / 926f);
			int x = i % 3;
			int y = Mathf.FloorToInt((float)i / 1941f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x001100A4 File Offset: 0x0010E2A4
	private void FLNCGLFALBF()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("MotorbikeSeatStand");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.OLGJKCKOLDB();
		this.NIELMHNJLHD();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x00110128 File Offset: 0x0010E328
	private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.DIOJAPAAFDF();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = (HideFlags)(-87);
		this.MHNAJNGGDFJ.SetTexture("chan_head", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("button.wav", this.preserveDetails ? 0 : 0);
		this.MHNAJNGGDFJ.SetMatrix("Roar", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.ARGB4444);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 8, 1, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Point;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("wpn_add/addoptions", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("aa=", this.radius);
		this.MHNAJNGGDFJ.SetFloat("cht_delfrendmsg", this.bias);
		this.MHNAJNGGDFJ.SetFloat("_WrinkleNormalMap3", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("ok", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("#> _Wrinkles Occlusion Camera < ", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("UnityEngine.Vector4", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("BowReady", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("wpn_master", this.reduceSelfBleeding ? 1470f : 1223f);
		this.MHNAJNGGDFJ.SetFloat("OfficeSittingBack", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("TOD_SunMeshBrightness", this.halfSampling ? 0 : 0);
		this.MHNAJNGGDFJ.SetInt("wpn_eat8", this.attachedCamera.orthographic ? 1 : 0);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 6, 0, RenderTextureFormat.ARGB4444);
			renderTexture.filterMode = FilterMode.Bilinear;
			this.MHNAJNGGDFJ.SetInt("WallRunLeft", 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 102f) ? 0 : 0);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("_RgbBlendCacheTex", 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 430f) ? 0 : 1);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("IdleSandCover", 358f);
		int pass = this.attachedCamera.orthographic ? 7 : 6;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("RollerBladeJump", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("SoccerKeeperStrafeRight", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("chan_nam", new Vector2(751f, 73f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", new Vector2(1031f, 1341f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("_DepthScale", new Vector2(510f, 941f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("MaskMaterial", new Vector2(1203f, 1461f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("Hidden/Post FX/Temporal Anti-aliasing", new Vector2(1154f, 1337f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("lid", new Vector2(67f, 1004f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("L", new Vector2(787f, 1988f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("_BlurDistance", new Vector2(1962f, 883f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("maxModelScale", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 0);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x00110654 File Offset: 0x0010E854
	private void KFNHCJGPFAJ()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("turn_state");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.LNHHIHHKMCP();
		this.JAKDIGMOHCE();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x001106D8 File Offset: 0x0010E8D8
	private void CDJAFHIBMDM()
	{
		this.JNMFCBMKHJL = new Texture2D(2, 8, TextureFormat.Alpha8, true);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[-53];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 0; i < -55; i++)
		{
			Color color = new Color(1308f, 691f, 256f, array2[i] / 1933f);
			int x = i % 8;
			int y = Mathf.FloorToInt((float)i / 1963f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x0010F135 File Offset: 0x0010D335
	private void PBJANINKBAG()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.JBCDKDGIDHM();
		}
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x0011077C File Offset: 0x0010E97C
	private void NBOCAPIABNI()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("DeadmanFloat");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		this.CDJAFHIBMDM();
		this.PFCNKBPLIAH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x00110800 File Offset: 0x0010EA00
	private void MOBADMLFOHN()
	{
		this.JNMFCBMKHJL = new Texture2D(1, 6, TextureFormat.Alpha8, true);
		this.JNMFCBMKHJL.filterMode = FilterMode.Bilinear;
		float[] array = new float[107];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 0; i < -127; i++)
		{
			Color color = new Color(298f, 1417f, 1139f, array2[i] / 965f);
			int x = i % 6;
			int y = Mathf.FloorToInt((float)i / 1848f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x001108A1 File Offset: 0x0010EAA1
	private void GOMIADJALOL()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.PINLMCCKKNA();
		}
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void BKGHBKPDMDH()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x001108B4 File Offset: 0x0010EAB4
	private void ONLNHBABAIN()
	{
		this.AKMNAJDMEIO = new Texture2D(4, 3, TextureFormat.Alpha8, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[75];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 56; i++)
		{
			Color color = new Color(1037f, 141f, 1209f, array2[i] / 698f);
			int x = i % 2;
			int y = Mathf.FloorToInt((float)i / 1399f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags)107;
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x00110955 File Offset: 0x0010EB55
	private void IIKDDILLGLF()
	{
		this.MHJCPLBPAKM();
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x0011095D File Offset: 0x0010EB5D
	private void FKNMIDHLIOH()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.KFNHCJGPFAJ();
		}
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x00110970 File Offset: 0x0010EB70
	private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.GOMIADJALOL();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = (HideFlags)75;
		this.MHNAJNGGDFJ.SetTexture("ElvisLegsLoop", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("IceHockey Shot Left", this.preserveDetails ? 1 : 1);
		this.MHNAJNGGDFJ.SetMatrix("Horizontal", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.Default);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 3, 1, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Repeat;
		temporary3.filterMode = FilterMode.Point;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("id", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("<color='#000000'>--------------------------------------------------------</color>", this.radius);
		this.MHNAJNGGDFJ.SetFloat("Giant3HitCombo2", this.bias);
		this.MHNAJNGGDFJ.SetFloat("OnChatMessage", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("_n", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("_Parameter", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("qd_anyfish", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("SatNightFever", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("colorA", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("non MonoBehaviour", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat(" is different than vertices length", this.reduceSelfBleeding ? 360f : 1186f);
		this.MHNAJNGGDFJ.SetFloat("wgt_small.dat", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("INTERFACE", this.halfSampling ? 1 : 0);
		this.MHNAJNGGDFJ.SetInt("ShootWireframeModule", this.attachedCamera.orthographic ? 0 : 1);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 1, 0, RenderTextureFormat.ARGB32);
			renderTexture.filterMode = FilterMode.Point;
			this.MHNAJNGGDFJ.SetInt("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1939f) ? 1 : 1);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("_Offsets", 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1370f) ? 0 : 1);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("cnt_energ", 1659f);
		int pass = this.attachedCamera.orthographic ? 2 : 4;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("GestureHandUp", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("Giant2HandSlamIdle", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("null", new Vector2(627f, 1943f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("IdleReadyCrouch", new Vector2(529f, 594f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("titul_data/p_categories/category", new Vector2(62f, 1645f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("VA", new Vector2(868f, 1907f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("Android", new Vector2(887f, 423f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Development Server URL could not be found.", new Vector2(80f, 277f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("HitWeight", new Vector2(225f, 1448f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("", new Vector2(533f, 458f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("ROOT", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 8);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 2);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x00110E99 File Offset: 0x0010F099
	private void PCKOPPKGENK()
	{
		this.GGNGLBAGPCM();
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x00110EA4 File Offset: 0x0010F0A4
	private void IJPCAJCDDJH()
	{
		this.JNMFCBMKHJL = new Texture2D(5, 1, (TextureFormat)0, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[112];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -43; i += 0)
		{
			Color color = new Color(862f, 498f, 1850f, array2[i] / 249f);
			int x = i % 6;
			int y = Mathf.FloorToInt((float)i / 798f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags)88;
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void OnEnable()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x0010E7C9 File Offset: 0x0010C9C9
	private void EHFPLKEINFO()
	{
		this.GOMIADJALOL();
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x00110F48 File Offset: 0x0010F148
	private void CONNCGCNJPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.KNODPHJKHDH();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		this.MHNAJNGGDFJ.SetTexture("Bubenec", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("<.*?>", this.preserveDetails ? 1 : 0);
		this.MHNAJNGGDFJ.SetMatrix("IdleSlide", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.Default);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 1, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Bilinear;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("_ReflectionTexture2", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("1,2,3,4,5", this.radius);
		this.MHNAJNGGDFJ.SetFloat("Ankle", this.bias);
		this.MHNAJNGGDFJ.SetFloat("IdleSad", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("weight", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("H:mm:ss", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("lut.ogg", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("_ProjInfo", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("_NeighbourMaxTex", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html", this.reduceSelfBleeding ? 521f : 1247f);
		this.MHNAJNGGDFJ.SetFloat("Criticals", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("1HandSwordStrafeRight", this.halfSampling ? 1 : 1);
		this.MHNAJNGGDFJ.SetInt("IceHockeyGoalieReady", this.attachedCamera.orthographic ? 0 : 1);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 8, 1, RenderTextureFormat.RGB565);
			renderTexture.filterMode = FilterMode.Point;
			this.MHNAJNGGDFJ.SetInt("Soccer Start Kick", 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1405f) ? 1 : 1);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("upRodState", 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 106f) ? 1 : 0);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("MotorbikeShootRight", 881f);
		int pass = this.attachedCamera.orthographic ? 0 : 5;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat(" ", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat(" \"{0}\"", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("invn_rec11", new Vector2(1363f, 1579f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("Fire1", new Vector2(1280f, 1337f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Open turnStatus", new Vector2(935f, 1302f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("SAMPLES_HIGH", new Vector2(85f, 1028f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("https://www.youtube.com/watch?v=r5jiZnsDH3M", new Vector2(1894f, 1749f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("_Offsets", new Vector2(706f, 45f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("spinbreak.ogg", new Vector2(73f, 1961f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Giant 3 Hit Combo", new Vector2(1829f, 132f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("pempty", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 5);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 8);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x00111474 File Offset: 0x0010F674
	private void ENLEBOOIGKJ()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("SoccerKeeperDiveStrafeCloseRight");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		this.MOBADMLFOHN();
		this.ENBMNCICPMG();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x001114F8 File Offset: 0x0010F6F8
	private void MAENOCDHJMB()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("/");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.OLGJKCKOLDB();
		this.CIAHHDHAOGH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x0011157C File Offset: 0x0010F77C
	private void EMHGNEMIGII()
	{
		this.drawDistance = Mathf.Max(469f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(1019f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(302f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x001115CC File Offset: 0x0010F7CC
	private void OIBIGDFPHGO()
	{
		this.drawDistance = Mathf.Max(1861f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(359f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(109f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x0011161C File Offset: 0x0010F81C
	private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.DIOJAPAAFDF();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		this.MHNAJNGGDFJ.SetTexture("SoundMgr is init part 1", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("MovementZ", this.preserveDetails ? 0 : 0);
		this.MHNAJNGGDFJ.SetMatrix("Shoes", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.RGB565);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 6, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Point;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture(" has no HandPoser/GenericPoser attached.", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("Tangents", this.radius);
		this.MHNAJNGGDFJ.SetFloat("fishspincatch", this.bias);
		this.MHNAJNGGDFJ.SetFloat("", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("fwgt_uniq_w", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("RunBackward", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("ElvisLegsLoop", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("PaperTurn.wav", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("error baseid: ", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("_ColorBuffer", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("ExposureIBL", this.reduceSelfBleeding ? 199f : 886f);
		this.MHNAJNGGDFJ.SetFloat("WorkerPickaxe2", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("MotorbikeAirWalk", this.halfSampling ? 1 : 0);
		this.MHNAJNGGDFJ.SetInt("SoccerThrow", this.attachedCamera.orthographic ? 1 : 1);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 7, 1, RenderTextureFormat.Default);
			renderTexture.filterMode = FilterMode.Bilinear;
			this.MHNAJNGGDFJ.SetInt("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1002f) ? 1 : 1);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("Flares", 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 1684f) ? 0 : 1);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("★{0}", 844f);
		int pass = this.attachedCamera.orthographic ? 5 : 4;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("[userfish]", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("IdleWalk", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("NextFrame", new Vector2(833f, 1164f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("FlyUp", new Vector2(572f, 1234f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("LUM_CONTRIB_OFF", new Vector2(752f, 479f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("fire off", new Vector2(1283f, 381f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("_HitPosition", new Vector2(641f, 112f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("no recept ", new Vector2(1799f, 38f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("русский", new Vector2(34f, 1262f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("RenderType", new Vector2(1537f, 1285f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("invn_ver4", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 5);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x0010E91D File Offset: 0x0010CB1D
	private void JMFMOADCCIE()
	{
		this.EAMPAONLJJM();
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x00111B48 File Offset: 0x0010FD48
	private void OLGJKCKOLDB()
	{
		this.JNMFCBMKHJL = new Texture2D(7, 7, TextureFormat.Alpha8, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Bilinear;
		float[] array = new float[-98];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -89; i += 0)
		{
			Color color = new Color(24f, 221f, 1142f, array2[i] / 1502f);
			int x = i % 4;
			int y = Mathf.FloorToInt((float)i / 1027f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = (HideFlags)83;
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x00111BE9 File Offset: 0x0010FDE9
	private void MHJCPLBPAKM()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.FLNCGLFALBF();
		}
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x00111BFC File Offset: 0x0010FDFC
	private void NBNPGNFKHMF()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("<color='#003000'>");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.AOKCLCOAECD();
		this.PFCNKBPLIAH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x00111C80 File Offset: 0x0010FE80
	private void HGFGCPHDPEP()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("WeaponStand");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		this.CDJAFHIBMDM();
		this.PFCNKBPLIAH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00111D04 File Offset: 0x0010FF04
	private void ENBMNCICPMG()
	{
		this.AKMNAJDMEIO = new Texture2D(3, 7, TextureFormat.Alpha8, false);
		this.AKMNAJDMEIO.filterMode = FilterMode.Point;
		float[] array = new float[68];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 45; i++)
		{
			Color color = new Color(1386f, 366f, 52f, array2[i] / 1880f);
			int x = i % 2;
			int y = Mathf.FloorToInt((float)i / 1830f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x00111DA8 File Offset: 0x0010FFA8
	private void CIAHHDHAOGH()
	{
		this.AKMNAJDMEIO = new Texture2D(8, 8, TextureFormat.Alpha8, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[30];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 86; i += 0)
		{
			Color color = new Color(971f, 1978f, 1640f, array2[i] / 146f);
			int x = i % 1;
			int y = Mathf.FloorToInt((float)i / 1603f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags)76;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x00111E4C File Offset: 0x0011004C
	private void ELGCKJHOKPP()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("PistolFire");
		if (!shader)
		{
			this.FLLGBFFGJAK = true;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		this.BIFLPGCIECF();
		this.ONLNHBABAIN();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x00111ED0 File Offset: 0x001100D0
	private void GBAEKFJBEFM()
	{
		this.PODMLNMOOLM();
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x00111ED8 File Offset: 0x001100D8
	private void HKNHBOEFHGG()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("BowFire2");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.JPHICALBDAK();
		this.ONLNHBABAIN();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x00110E99 File Offset: 0x0010F099
	private void ACEEIODKKBE()
	{
		this.GGNGLBAGPCM();
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x00111F5C File Offset: 0x0011015C
	private void HMEAENGBFKC()
	{
		this.drawDistance = Mathf.Max(344f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(1987f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1022f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x00111FAC File Offset: 0x001101AC
	private void DCKOCFKGCJJ()
	{
		this.AKMNAJDMEIO = new Texture2D(3, 5, TextureFormat.Alpha8, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[92];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 32; i++)
		{
			Color color = new Color(1495f, 404f, 1590f, array2[i] / 752f);
			int x = i % 0;
			int y = Mathf.FloorToInt((float)i / 1755f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = (HideFlags)97;
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x00112050 File Offset: 0x00110250
	private void PFCNKBPLIAH()
	{
		this.AKMNAJDMEIO = new Texture2D(3, 3, TextureFormat.Alpha8, false);
		this.AKMNAJDMEIO.filterMode = FilterMode.Point;
		float[] array = new float[]
		{
			8f,
			1f,
			6f,
			3f,
			0f,
			4f,
			7f,
			2f,
			5f
		};
		for (int i = 0; i < 9; i++)
		{
			Color color = new Color(0f, 0f, 0f, array[i] / 9f);
			int x = i % 3;
			int y = Mathf.FloorToInt((float)i / 3f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = HideFlags.HideAndDontSave;
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x001120F4 File Offset: 0x001102F4
	private void DIAIKCBANBK()
	{
		this.drawDistance = Mathf.Max(1053f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(1713f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(447f, this.bilateralDepthTolerance);
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x00112144 File Offset: 0x00110344
	private void DLKHCIMECOF()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("USE_UV_BASED_REPROJECTION");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.None;
		this.BIFLPGCIECF();
		this.NIELMHNJLHD();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x0010FDD9 File Offset: 0x0010DFD9
	private void KFIBDJHDJJP()
	{
		this.PBJANINKBAG();
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x001121C8 File Offset: 0x001103C8
	private void EAONEAGNPCD()
	{
		this.FLLGBFFGJAK = true;
		Shader shader = Shader.Find("ProjectionMatrixInverse");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		this.JPHICALBDAK();
		this.NIELMHNJLHD();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x0011224C File Offset: 0x0011044C
	private void BFOOBIDKAKF()
	{
		this.AKMNAJDMEIO = new Texture2D(4, 5, TextureFormat.Alpha8, true);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[25];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < 102; i++)
		{
			Color color = new Color(931f, 1163f, 781f, array2[i] / 478f);
			int x = i % 8;
			int y = Mathf.FloorToInt((float)i / 52f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = ~HideFlags.HideInInspector;
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x001122F0 File Offset: 0x001104F0
	private void JBCDKDGIDHM()
	{
		this.FLLGBFFGJAK = false;
		Shader shader = Shader.Find("> ");
		if (!shader)
		{
			this.FLLGBFFGJAK = false;
			return;
		}
		this.MHNAJNGGDFJ = new Material(shader);
		this.attachedCamera = base.GetComponent<Camera>();
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.attachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		this.IJPCAJCDDJH();
		this.CIAHHDHAOGH();
		this.MKPFAAPMKKI = new object();
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x00112374 File Offset: 0x00110574
	private void LNHHIHHKMCP()
	{
		this.JNMFCBMKHJL = new Texture2D(5, 5, TextureFormat.Alpha8, false);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[]
		{
			12f,
			1f,
			10f,
			3f,
			20f,
			5f,
			18f,
			7f,
			16f,
			9f,
			24f,
			2f,
			11f,
			6f,
			22f,
			15f,
			8f,
			0f,
			13f,
			19f,
			4f,
			21f,
			14f,
			23f,
			17f
		};
		for (int i = 0; i < 25; i++)
		{
			Color color = new Color(0f, 0f, 0f, array[i] / 25f);
			int x = i % 5;
			int y = Mathf.FloorToInt((float)i / 5f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = HideFlags.HideAndDontSave;
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x00112418 File Offset: 0x00110618
	private void FHMGCFEMMEJ()
	{
		this.AKMNAJDMEIO = new Texture2D(1, 2, TextureFormat.Alpha8, false);
		this.AKMNAJDMEIO.filterMode = FilterMode.Bilinear;
		float[] array = new float[-21];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.E5776738148D3F59E205ACEBE624370EFE933F7A).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -101; i += 0)
		{
			Color color = new Color(469f, 165f, 1132f, array2[i] / 569f);
			int x = i % 5;
			int y = Mathf.FloorToInt((float)i / 326f);
			this.AKMNAJDMEIO.SetPixel(x, y, color);
		}
		this.AKMNAJDMEIO.Apply();
		this.AKMNAJDMEIO.hideFlags = ~HideFlags.HideInHierarchy;
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x001124B9 File Offset: 0x001106B9
	private void DIOJAPAAFDF()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.NBOCAPIABNI();
		}
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x0010E713 File Offset: 0x0010C913
	private void DJCCKJHHKNM()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x0010E713 File Offset: 0x0010C913
	private void PODMLNMOOLM()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x0010E713 File Offset: 0x0010C913
	private void MALKPHNECBJ()
	{
		UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
		this.MKPFAAPMKKI = null;
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x001124CC File Offset: 0x001106CC
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.GOMIADJALOL();
		if (this.FLLGBFFGJAK)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.MHNAJNGGDFJ.hideFlags = HideFlags.HideAndDontSave;
		this.MHNAJNGGDFJ.SetTexture("_DitherTexture", this.preserveDetails ? this.AKMNAJDMEIO : this.JNMFCBMKHJL);
		this.MHNAJNGGDFJ.SetInt("PreserveDetails", this.preserveDetails ? 1 : 0);
		this.MHNAJNGGDFJ.SetMatrix("ProjectionMatrixInverse", base.GetComponent<Camera>().projectionMatrix.inverse);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, RenderTextureFormat.ARGBHalf);
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0, JONJODLFAEN.format);
		temporary3.wrapMode = TextureWrapMode.Clamp;
		temporary3.filterMode = FilterMode.Bilinear;
		Graphics.Blit(JONJODLFAEN, temporary3);
		this.MHNAJNGGDFJ.SetTexture("_ColorDownsampled", temporary3);
		RenderTexture renderTexture = null;
		this.MHNAJNGGDFJ.SetFloat("Radius", this.radius);
		this.MHNAJNGGDFJ.SetFloat("Bias", this.bias);
		this.MHNAJNGGDFJ.SetFloat("DepthTolerance", this.bilateralDepthTolerance);
		this.MHNAJNGGDFJ.SetFloat("ZThickness", this.zThickness);
		this.MHNAJNGGDFJ.SetFloat("Intensity", this.occlusionIntensity);
		this.MHNAJNGGDFJ.SetFloat("SampleDistributionCurve", this.sampleDistributionCurve);
		this.MHNAJNGGDFJ.SetFloat("ColorBleedAmount", this.colorBleedAmount);
		this.MHNAJNGGDFJ.SetFloat("DrawDistance", this.drawDistance);
		this.MHNAJNGGDFJ.SetFloat("DrawDistanceFadeSize", this.drawDistanceFadeSize);
		this.MHNAJNGGDFJ.SetFloat("SelfBleedReduction", this.reduceSelfBleeding ? 1f : 0f);
		this.MHNAJNGGDFJ.SetFloat("BrightnessThreshold", this.brightnessThreshold);
		this.MHNAJNGGDFJ.SetInt("HalfSampling", this.halfSampling ? 1 : 0);
		this.MHNAJNGGDFJ.SetInt("Orthographic", this.attachedCamera.orthographic ? 1 : 0);
		if (this.useDownsampling)
		{
			renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 2, 0, RenderTextureFormat.ARGBHalf);
			renderTexture.filterMode = FilterMode.Bilinear;
			this.MHNAJNGGDFJ.SetInt("Downsamp", 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 0.0001f) ? 1 : 0);
		}
		else
		{
			this.MHNAJNGGDFJ.SetInt("Downsamp", 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, (this.colorBleedAmount <= 0.0001f) ? 1 : 0);
		}
		RenderTexture.ReleaseTemporary(temporary3);
		this.MHNAJNGGDFJ.SetFloat("BlurDepthTolerance", 0.1f);
		int pass = this.attachedCamera.orthographic ? 6 : 2;
		if (this.attachedCamera.orthographic)
		{
			this.MHNAJNGGDFJ.SetFloat("Near", this.attachedCamera.nearClipPlane);
			this.MHNAJNGGDFJ.SetFloat("Far", this.attachedCamera.farClipPlane);
		}
		if (this.useDownsampling)
		{
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(2f, 0f));
			Graphics.Blit(renderTexture, temporary2, this.MHNAJNGGDFJ, pass);
			RenderTexture.ReleaseTemporary(renderTexture);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(0f, 2f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(2f, 0f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(0f, 2f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		else
		{
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(1f, 0f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(0f, 1f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(1f, 0f));
			Graphics.Blit(temporary, temporary2, this.MHNAJNGGDFJ, pass);
			this.MHNAJNGGDFJ.SetVector("Kernel", new Vector2(0f, 1f));
			Graphics.Blit(temporary2, temporary, this.MHNAJNGGDFJ, pass);
		}
		RenderTexture.ReleaseTemporary(temporary2);
		this.MHNAJNGGDFJ.SetTexture("_SSAO", temporary);
		if (!this.visualizeSSAO)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 3);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, 5);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x0010F241 File Offset: 0x0010D441
	private void MOJBLBHKCCM()
	{
		this.FKNMIDHLIOH();
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x001129F8 File Offset: 0x00110BF8
	private void AOKCLCOAECD()
	{
		this.JNMFCBMKHJL = new Texture2D(1, 5, TextureFormat.Alpha8, true);
		this.JNMFCBMKHJL.filterMode = FilterMode.Point;
		float[] array = new float[-77];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.517E9157A4955A179711F36AA153FCE44CD0765E).FieldHandle);
		float[] array2 = array;
		for (int i = 1; i < -108; i += 0)
		{
			Color color = new Color(1728f, 58f, 1555f, array2[i] / 21f);
			int x = i % 0;
			int y = Mathf.FloorToInt((float)i / 303f);
			this.JNMFCBMKHJL.SetPixel(x, y, color);
		}
		this.JNMFCBMKHJL.Apply();
		this.JNMFCBMKHJL.hideFlags = HideFlags.NotEditable;
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x00112A9C File Offset: 0x00110C9C
	private void KMPEBHIPKJH()
	{
		this.drawDistance = Mathf.Max(506f, this.drawDistance);
		this.drawDistanceFadeSize = Mathf.Max(1747f, this.drawDistanceFadeSize);
		this.bilateralDepthTolerance = Mathf.Max(1190f, this.bilateralDepthTolerance);
	}

	// Token: 0x06002708 RID: 9992 RVA: 0x00112AEB File Offset: 0x00110CEB
	private void JIFMIPHBBCM()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.MAENOCDHJMB();
		}
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x0010F819 File Offset: 0x0010DA19
	private void PHIACAJNNIG()
	{
		this.MALKPHNECBJ();
	}

	// Token: 0x0600270A RID: 9994 RVA: 0x00112AFB File Offset: 0x00110CFB
	private void CPLDNPIDPPM()
	{
		this.DJCCKJHHKNM();
	}

	// Token: 0x0600270B RID: 9995 RVA: 0x001108A1 File Offset: 0x0010EAA1
	private void KNODPHJKHDH()
	{
		if (this.MKPFAAPMKKI == null)
		{
			this.PINLMCCKKNA();
		}
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x0010FDD9 File Offset: 0x0010DFD9
	private void JHFAHBIIJDC()
	{
		this.PBJANINKBAG();
	}

	// Token: 0x0400045A RID: 1114
	private Material MHNAJNGGDFJ;

	// Token: 0x0400045B RID: 1115
	public bool visualizeSSAO;

	// Token: 0x0400045C RID: 1116
	private Texture2D JNMFCBMKHJL;

	// Token: 0x0400045D RID: 1117
	private Texture2D AKMNAJDMEIO;

	// Token: 0x0400045E RID: 1118
	private bool FLLGBFFGJAK;

	// Token: 0x0400045F RID: 1119
	[Range(0.02f, 5f)]
	public float radius = 1f;

	// Token: 0x04000460 RID: 1120
	[Range(-0.2f, 0.5f)]
	public float bias = 0.1f;

	// Token: 0x04000461 RID: 1121
	[Range(0.1f, 3f)]
	public float bilateralDepthTolerance = 0.2f;

	// Token: 0x04000462 RID: 1122
	[Range(1f, 5f)]
	public float zThickness = 2.35f;

	// Token: 0x04000463 RID: 1123
	[Range(0.5f, 5f)]
	public float occlusionIntensity = 1.3f;

	// Token: 0x04000464 RID: 1124
	[Range(1f, 6f)]
	public float sampleDistributionCurve = 1.15f;

	// Token: 0x04000465 RID: 1125
	[Range(0f, 1f)]
	public float colorBleedAmount = 1f;

	// Token: 0x04000466 RID: 1126
	[Range(0.1f, 3f)]
	public float brightnessThreshold;

	// Token: 0x04000467 RID: 1127
	public float drawDistance = 500f;

	// Token: 0x04000468 RID: 1128
	public float drawDistanceFadeSize = 1f;

	// Token: 0x04000469 RID: 1129
	public bool reduceSelfBleeding = true;

	// Token: 0x0400046A RID: 1130
	public bool useDownsampling;

	// Token: 0x0400046B RID: 1131
	public bool halfSampling;

	// Token: 0x0400046C RID: 1132
	public bool preserveDetails;

	// Token: 0x0400046D RID: 1133
	[HideInInspector]
	public Camera attachedCamera;

	// Token: 0x0400046E RID: 1134
	private object MKPFAAPMKKI;
}
