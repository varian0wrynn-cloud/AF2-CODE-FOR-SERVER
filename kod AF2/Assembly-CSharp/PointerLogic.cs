using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200020C RID: 524
public class PointerLogic : MonoBehaviour
{
	// Token: 0x0600793A RID: 31034 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float FGDLDIPBIHL()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600793B RID: 31035 RVA: 0x0039F012 File Offset: 0x0039D212
	public void OIPMNIHHBEJ(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 1454f, 1334f);
	}

	// Token: 0x0600793C RID: 31036 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float JMFMIDKAMPB()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600793D RID: 31037 RVA: 0x0039F02A File Offset: 0x0039D22A
	public void GCGHDDLEEJJ(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1776f, 1317f);
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x0039F044 File Offset: 0x0039D244
	private void EDANNBFJHIK()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 529f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(584f, 1928f, 389f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x0039F10B File Offset: 0x0039D30B
	public void JKIMMJLAOHN(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 985f, 1551f);
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x0039F123 File Offset: 0x0039D323
	public void NFMJNMABKJH()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 650f;
		this.GCKHJJJJJBM = 1958f;
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DCHAPIHINBJ()
	{
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x0039F147 File Offset: 0x0039D347
	public void EPABDBEIMPI(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 1810f, 1889f);
	}

	// Token: 0x06007943 RID: 31043 RVA: 0x0039F160 File Offset: 0x0039D360
	private void Start()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[2], 1f);
		}
	}

	// Token: 0x06007944 RID: 31044 RVA: 0x0039F194 File Offset: 0x0039D394
	private void OFGMIEJKMGC()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[6], 1314f);
		}
	}

	// Token: 0x06007945 RID: 31045 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float KIHBJJNJAJH()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007946 RID: 31046 RVA: 0x0039F1C6 File Offset: 0x0039D3C6
	public void CLCHMHHDGIM()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 1828f;
		this.GCKHJJJJJBM = 1354f;
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void DDEGPPKLAOL()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06007985 RID: 31109 RVA: 0x0039F25A File Offset: 0x0039D45A
	// (set) Token: 0x06007948 RID: 31048 RVA: 0x0039F1F8 File Offset: 0x0039D3F8
	public float ALFFGECKKDB
	{
		get
		{
			return this.GCKHJJJJJBM;
		}
		set
		{
			this.GCKHJJJJJBM = Mathf.Clamp(value, -1f, 1f);
		}
	}

	// Token: 0x06007949 RID: 31049 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float BIPBHKAMBEH()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600794A RID: 31050 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void OGMACADJFIN()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600794B RID: 31051 RVA: 0x0039F210 File Offset: 0x0039D410
	private void AOCDDBNBADJ()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[0], 1355f);
		}
	}

	// Token: 0x0600794C RID: 31052 RVA: 0x0039F242 File Offset: 0x0039D442
	public void DDDEKGHPBAE(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 818f, 1382f);
	}

	// Token: 0x0600794D RID: 31053 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float HMDHECEGMCE()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600794E RID: 31054 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float POCLPMDMOOH()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600794F RID: 31055 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float IFPEFBNOPCG()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007950 RID: 31056 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float NGNBPFCMHGN()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007951 RID: 31057 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float NPKBKHHIFPB()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007952 RID: 31058 RVA: 0x0039F264 File Offset: 0x0039D464
	public Vector2 FBFGCKHILOI()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("[ACTk] Injection Detector: already running!");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("OfficeSittingReadingPageFlip");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("<<");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1758f, 1082f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007953 RID: 31059 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float BFBOEBKFJAA()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007954 RID: 31060 RVA: 0x0039F394 File Offset: 0x0039D594
	public Vector2 FNLBLKGEBMJ()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("StartRigidModule");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("_2.png");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("error");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(921f, 695f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007955 RID: 31061 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JBGGMKEKOAN()
	{
	}

	// Token: 0x06007956 RID: 31062 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float KKDIAFMCJLN()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007957 RID: 31063 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void JMJHHOFJCOD()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x06007958 RID: 31064 RVA: 0x0039F4C4 File Offset: 0x0039D6C4
	private void LGCJDIGOOFA()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[2], 281f);
		}
	}

	// Token: 0x06007959 RID: 31065 RVA: 0x0039F4F6 File Offset: 0x0039D6F6
	public void PMGMKKGOGIG(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1042f, 1772f);
	}

	// Token: 0x0600795A RID: 31066 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void GGPMDJNJGPH()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600795B RID: 31067 RVA: 0x0039F510 File Offset: 0x0039D710
	private void IJFPHGEFOLF()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[6], 1616f);
		}
	}

	// Token: 0x0600795C RID: 31068 RVA: 0x0039F544 File Offset: 0x0039D744
	public Vector2 KAPNLGAOBHH()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("IdleStand");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("int: ");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("Left");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(955f, 1177f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x0600795D RID: 31069 RVA: 0x0039F674 File Offset: 0x0039D874
	private void CPJJHOKJEGJ()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 283f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(833f, 1269f, 977f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x0600795E RID: 31070 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float NDCMMOMKJEL()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600795F RID: 31071 RVA: 0x0039F73C File Offset: 0x0039D93C
	public Vector2 getAbsoluteCoord()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("LocationGui.getI is null");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("LocationGui.getI.backLockImage is null");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("LocationGui.getI.backLockImage.rectTransform is null");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(-1f, -1f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007960 RID: 31072 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float IILMGLPGDHC()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007961 RID: 31073 RVA: 0x0039F86C File Offset: 0x0039DA6C
	private void DFFOEGHGPGP()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 1961f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(1912f, 1681f, 1276f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x06007962 RID: 31074 RVA: 0x0039F934 File Offset: 0x0039DB34
	public Vector2 PKIDIALNCJF()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log(" ms");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("IceHockeyGoalieSave2");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("VRIK References are not filled in, can not guess hand orientations. Right-click on VRIK header and slect 'Guess Hand Orientations' when you have filled in the References.");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1895f, 149f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007963 RID: 31075 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float KIFCGOEGMHJ()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007964 RID: 31076 RVA: 0x0039FA64 File Offset: 0x0039DC64
	private void JOHDLNOKCOK()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 462f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(750f, 1089f, 1137f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x06007965 RID: 31077 RVA: 0x0039FB2B File Offset: 0x0039DD2B
	public void BMKMEPJKECL(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1327f, 1587f);
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x0039FB43 File Offset: 0x0039DD43
	public void KJNFKOKGCIJ(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 1913f, 829f);
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JADMEJAFNFO()
	{
	}

	// Token: 0x06007968 RID: 31080 RVA: 0x0039FB5B File Offset: 0x0039DD5B
	public void AHHLMFFBKDI(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1286f, 334f);
	}

	// Token: 0x06007969 RID: 31081 RVA: 0x0039FB74 File Offset: 0x0039DD74
	public Vector2 CLCBGMCDCNE()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log(" ");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("MotorbikeLassoFwd");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("no_task");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(946f, 959f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x0600796A RID: 31082 RVA: 0x0039FCA4 File Offset: 0x0039DEA4
	public void HEIFNNNCJLP()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 1729f;
		this.GCKHJJJJJBM = 531f;
	}

	// Token: 0x0600796B RID: 31083 RVA: 0x0039FCC8 File Offset: 0x0039DEC8
	private void ELADFDNPOOI()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(SoundSamplesStorage.getI.clips[0], 905f);
		}
	}

	// Token: 0x0600796C RID: 31084 RVA: 0x00022FCC File Offset: 0x000211CC
	private void POHHBKCLBGC()
	{
	}

	// Token: 0x0600796D RID: 31085 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JCMGHHKALDM()
	{
	}

	// Token: 0x0600796E RID: 31086 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void DOBFKBMGMNA()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600796F RID: 31087 RVA: 0x0039FCFA File Offset: 0x0039DEFA
	public void LJIIOEOIPAD()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 16f;
		this.GCKHJJJJJBM = 1300f;
	}

	// Token: 0x06007970 RID: 31088 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBEOAOKBHEK()
	{
	}

	// Token: 0x06007971 RID: 31089 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void BHPGDKJHKKG()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x06007972 RID: 31090 RVA: 0x0039FD20 File Offset: 0x0039DF20
	private void ABEIHJCDDCH()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[4], 1991f);
		}
	}

	// Token: 0x06007973 RID: 31091 RVA: 0x0039FD54 File Offset: 0x0039DF54
	private void HMEAENGBFKC()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 434f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(602f, 1350f, 743f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x06007974 RID: 31092 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float IABEDJOIIEB()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007975 RID: 31093 RVA: 0x0039FE1B File Offset: 0x0039E01B
	public void OKDEDCCDCMF()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 582f;
		this.GCKHJJJJJBM = 1261f;
	}

	// Token: 0x06007976 RID: 31094 RVA: 0x0039FE3F File Offset: 0x0039E03F
	public void MNCHGBEDLFB(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1962f, 170f);
	}

	// Token: 0x06007977 RID: 31095 RVA: 0x0039FE57 File Offset: 0x0039E057
	public void LEECLGCOMHF()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 791f;
		this.GCKHJJJJJBM = 297f;
	}

	// Token: 0x06007978 RID: 31096 RVA: 0x0039FE7B File Offset: 0x0039E07B
	public void FFPBAKNMGIH(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 716f, 1084f);
	}

	// Token: 0x06007979 RID: 31097 RVA: 0x0039FE94 File Offset: 0x0039E094
	private void ELFALPCLKIE()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(SoundSamplesStorage.getI.clips[7], 1050f);
		}
	}

	// Token: 0x0600797A RID: 31098 RVA: 0x0039FEC6 File Offset: 0x0039E0C6
	public void GELFDDGBFDD()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 1872f;
		this.GCKHJJJJJBM = 1979f;
	}

	// Token: 0x0600797B RID: 31099 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float KNJFDEONNIE()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600797C RID: 31100 RVA: 0x0039FEEC File Offset: 0x0039E0EC
	private void KEIILPMCFEO()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(SoundSamplesStorage.getI.clips[0], 1575f);
		}
	}

	// Token: 0x0600797E RID: 31102 RVA: 0x0039FF31 File Offset: 0x0039E131
	public void BCBKBHDDHBH(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 721f, 1406f);
	}

	// Token: 0x0600797F RID: 31103 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float GNDFGGAKGJA()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007980 RID: 31104 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OBDAPPLCPMD()
	{
	}

	// Token: 0x06007981 RID: 31105 RVA: 0x0039FF49 File Offset: 0x0039E149
	public void KFIIHJGOOLD()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 1432f;
		this.GCKHJJJJJBM = 1438f;
	}

	// Token: 0x06007982 RID: 31106 RVA: 0x0039FF70 File Offset: 0x0039E170
	private void BMNJGPIPKLL()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(SoundSamplesStorage.getI.clips[6], 403f);
		}
	}

	// Token: 0x06007983 RID: 31107 RVA: 0x0039FFA2 File Offset: 0x0039E1A2
	public void OEDJDMAPIIE(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 938f, 823f);
	}

	// Token: 0x06007984 RID: 31108 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float NIMJEOGOMBF()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007986 RID: 31110 RVA: 0x0039FFBA File Offset: 0x0039E1BA
	public void MJBMJJBEAPI()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 52f;
		this.GCKHJJJJJBM = 1870f;
	}

	// Token: 0x06007987 RID: 31111 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OnGUI()
	{
	}

	// Token: 0x06007988 RID: 31112 RVA: 0x0039FFE0 File Offset: 0x0039E1E0
	public Vector2 INAGMHCFJHK()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("invn_rec7");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("The shader ");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("F2");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1471f, 1295f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007989 RID: 31113 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float NKLLCFLJBIH()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600798A RID: 31114 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float GFKECOHDANB()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600798B RID: 31115 RVA: 0x003A0110 File Offset: 0x0039E310
	public void EEIEDNOCDDE(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 584f, 600f);
	}

	// Token: 0x0600798C RID: 31116 RVA: 0x003A0128 File Offset: 0x0039E328
	public void BBGPJHHGMND(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1814f, 1120f);
	}

	// Token: 0x0600798D RID: 31117 RVA: 0x003A0140 File Offset: 0x0039E340
	private void BBFPILBIMKC()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[4], 1460f);
		}
	}

	// Token: 0x0600798E RID: 31118 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float EHALAJPLNGF()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x0600798F RID: 31119 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCLNNJIGFOO()
	{
	}

	// Token: 0x06007990 RID: 31120 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float PIPCJLCHBAC()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x06007991 RID: 31121 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GHDKICBHBHH()
	{
	}

	// Token: 0x06007992 RID: 31122 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float HEDKIELBHMF()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007993 RID: 31123 RVA: 0x003A0174 File Offset: 0x0039E374
	public Vector2 HEGIMHEHMPM()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("_MidGrey");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("contrast");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("choldposy");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1150f, 1745f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x06007994 RID: 31124 RVA: 0x003A02A4 File Offset: 0x0039E4A4
	public void dropAction()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 0f;
		this.GCKHJJJJJBM = 0f;
	}

	// Token: 0x06007995 RID: 31125 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void CKGJEIDEJCH()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x06007996 RID: 31126 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void FDGKKBGHNIN()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x06007997 RID: 31127 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float NLJACAOJOGG()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x06007998 RID: 31128 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KLBGEGDHCGA()
	{
	}

	// Token: 0x06007999 RID: 31129 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float MBEILMEOICL()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600799A RID: 31130 RVA: 0x003A02C8 File Offset: 0x0039E4C8
	public void GOHLINGMGKN(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 646f, 1978f);
	}

	// Token: 0x0600799B RID: 31131 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKLEENCFBNM()
	{
	}

	// Token: 0x0600799C RID: 31132 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float GMLHFAKLAJM()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x0600799D RID: 31133 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void EEININLNBKJ()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600799E RID: 31134 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BBGAONKBIPJ()
	{
	}

	// Token: 0x0600799F RID: 31135 RVA: 0x003A02E0 File Offset: 0x0039E4E0
	private void ACLJDJBJLCD()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(SoundSamplesStorage.getI.clips[8], 852f);
		}
	}

	// Token: 0x060079A0 RID: 31136 RVA: 0x003A0312 File Offset: 0x0039E512
	public void KNMAHIJPIEM(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 338f, 1092f);
	}

	// Token: 0x060079A1 RID: 31137 RVA: 0x003A032A File Offset: 0x0039E52A
	public void LHFMPBCOKAC()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 580f;
		this.GCKHJJJJJBM = 1021f;
	}

	// Token: 0x060079A2 RID: 31138 RVA: 0x003A0350 File Offset: 0x0039E550
	public Vector2 HOLPEDNEFOF()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("_FogAreaPosition");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("Save");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("msg_other");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(837f, 1341f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x060079A3 RID: 31139 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float OGIEEIAHJIA()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x060079A4 RID: 31140 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float HGCMGLOKONC()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x060079A5 RID: 31141 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void Awake()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x060079A6 RID: 31142 RVA: 0x003A0480 File Offset: 0x0039E680
	private void JLFBDOPFDDJ()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 1162f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(691f, 1404f, 1222f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079A7 RID: 31143 RVA: 0x003A0548 File Offset: 0x0039E748
	public Vector2 LBBFONMAKMC()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("WeaponFire");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("\n");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("isRun");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1829f, 1657f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x060079A8 RID: 31144 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float OGAPIIAELKC()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x060079AF RID: 31151 RVA: 0x0039F00A File Offset: 0x0039D20A
	// (set) Token: 0x060079A9 RID: 31145 RVA: 0x003A0678 File Offset: 0x0039E878
	public float APCNMCOCPAE
	{
		get
		{
			return this.CBJFIJBDGIJ;
		}
		set
		{
			this.CBJFIJBDGIJ = Mathf.Clamp(value, -1f, 1f);
		}
	}

	// Token: 0x060079AA RID: 31146 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float FPNLJKGCKNM()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x060079AB RID: 31147 RVA: 0x003A0690 File Offset: 0x0039E890
	public Vector2 KEFCGCJOGKJ()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("ui_default_close.wav");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("error");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("ShootRaycastModule");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1051f, 811f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x060079AC RID: 31148 RVA: 0x003A07C0 File Offset: 0x0039E9C0
	public void EJLGFIAFCAB(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 1389f, 1858f);
	}

	// Token: 0x060079AD RID: 31149 RVA: 0x003A07D8 File Offset: 0x0039E9D8
	public void AOBJAFCCBCD()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 362f;
		this.GCKHJJJJJBM = 1131f;
	}

	// Token: 0x060079AE RID: 31150 RVA: 0x003A07FC File Offset: 0x0039E9FC
	public void CCKOCPLDHOJ()
	{
		this.DMBIMBFGKMA = this.CBJFIJBDGIJ;
		this.ACOKOHGMKMF = 1431f;
		this.GCKHJJJJJBM = 579f;
	}

	// Token: 0x060079B0 RID: 31152 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ECLMFCKLJNM()
	{
	}

	// Token: 0x060079B1 RID: 31153 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float BOPKFKAABOB()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x060079B2 RID: 31154 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void IIELJNDNLMO()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x060079B3 RID: 31155 RVA: 0x003A0820 File Offset: 0x0039EA20
	public void OEMNMDJHNPF(float DCCPCBLODIG)
	{
		this.GCKHJJJJJBM = Mathf.Clamp(DCCPCBLODIG, 1196f, 1509f);
	}

	// Token: 0x060079B4 RID: 31156 RVA: 0x003A0838 File Offset: 0x0039EA38
	public Vector2 FNFPFBLCHDG()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("_ChromaticAberration");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("_ReflectionTexture0");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(868f, 858f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x060079B5 RID: 31157 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void OGKKCIOKGJE()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x060079B6 RID: 31158 RVA: 0x003A0968 File Offset: 0x0039EB68
	private void EKCKBDKEAKO()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 1157f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(1090f, 1669f, 686f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079B7 RID: 31159 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBHKFPELDGF()
	{
	}

	// Token: 0x060079B8 RID: 31160 RVA: 0x003A0A30 File Offset: 0x0039EC30
	private void Update()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 16f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(0f, 0f, 90f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079B9 RID: 31161 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float KEGFAPEMBCO()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x060079BA RID: 31162 RVA: 0x0039F00A File Offset: 0x0039D20A
	public float KMPNMAOJIAB()
	{
		return this.CBJFIJBDGIJ;
	}

	// Token: 0x060079BB RID: 31163 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCFLINGBFJG()
	{
	}

	// Token: 0x060079BC RID: 31164 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float PMOCPOLAOPB()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x060079BD RID: 31165 RVA: 0x003A0AF8 File Offset: 0x0039ECF8
	private void GDBBAMFMKII()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 620f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(1705f, 1825f, 1904f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079BE RID: 31166 RVA: 0x0039F25A File Offset: 0x0039D45A
	public float MMKOCNMBKJL()
	{
		return this.GCKHJJJJJBM;
	}

	// Token: 0x060079BF RID: 31167 RVA: 0x003A0BBF File Offset: 0x0039EDBF
	public void JOLCELAICCC(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 243f, 227f);
	}

	// Token: 0x060079C0 RID: 31168 RVA: 0x0039F1EA File Offset: 0x0039D3EA
	private void JMNLEBAPHNJ()
	{
		this.rt = base.GetComponent<RectTransform>();
	}

	// Token: 0x060079C1 RID: 31169 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HFNLJIFPMNK()
	{
	}

	// Token: 0x060079C2 RID: 31170 RVA: 0x003A0BD8 File Offset: 0x0039EDD8
	private void GDPMOMHBIFN()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 1788f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(1741f, 960f, 822f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079C3 RID: 31171 RVA: 0x003A0CA0 File Offset: 0x0039EEA0
	private void MAGJOJDOGKH()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(SoundSamplesStorage.getI.clips[6], 1097f);
		}
	}

	// Token: 0x060079C4 RID: 31172 RVA: 0x003A0CD4 File Offset: 0x0039EED4
	public Vector2 KMNJDDJIOEE()
	{
		Vector2 result;
		try
		{
			if (LocationGui.getI == null)
			{
				Debug.Log("<b>WallHack Detector</b>");
			}
			if (LocationGui.getI.backLockImage == null)
			{
				Debug.Log("setCurrentRod curorder=");
			}
			if (LocationGui.getI.backLockImage.rectTransform == null)
			{
				Debug.Log("itemsdata/items/item");
			}
			float num = (float)Screen.height - this.rt.position.y;
			num = LocationGui.getI.backLockImage.rectTransform.rect.height - num;
			result = new Vector2(LocationGui.getI.backLockImage.rectTransform.position.x + this.rt.position.x / LocationGui.getI.backLockImage.rectTransform.rect.width, num / LocationGui.getI.backLockImage.rectTransform.rect.height);
		}
		catch (Exception message)
		{
			result = new Vector2(1784f, 1624f);
			Debug.LogError(message);
		}
		return result;
	}

	// Token: 0x060079C5 RID: 31173 RVA: 0x003A0E04 File Offset: 0x0039F004
	private void BIGPMMGBPJC()
	{
		if (this.pType == PointerLogic.NCAKEKLNDNG.Poplavok)
		{
			this.DMBIMBFGKMA += (this.CBJFIJBDGIJ - this.DMBIMBFGKMA) * Time.deltaTime * this.inercia;
			this.ACOKOHGMKMF += (this.GCKHJJJJJBM - this.ACOKOHGMKMF) * Time.deltaTime * this.inercia;
			Vector3 localPosition = this.pointerImage.rectTransform.localPosition;
			localPosition.y = -this.ACOKOHGMKMF * 624f;
			this.pointerImage.rectTransform.localPosition = localPosition;
			this.pointerImage.rectTransform.localRotation = Quaternion.Euler(1883f, 1743f, 568f * this.DMBIMBFGKMA);
		}
	}

	// Token: 0x060079C6 RID: 31174 RVA: 0x003A0ECB File Offset: 0x0039F0CB
	public void BFCHNIKNEPN(float DCCPCBLODIG)
	{
		this.CBJFIJBDGIJ = Mathf.Clamp(DCCPCBLODIG, 488f, 1266f);
	}

	// Token: 0x060079C7 RID: 31175 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MHAGNPHGHIM()
	{
	}

	// Token: 0x04001188 RID: 4488
	public float inercia = 1f;

	// Token: 0x04001189 RID: 4489
	public Image pointerImage;

	// Token: 0x0400118A RID: 4490
	public PointerLogic.NCAKEKLNDNG pType;

	// Token: 0x0400118B RID: 4491
	public RectTransform rt;

	// Token: 0x0400118C RID: 4492
	private float DMBIMBFGKMA;

	// Token: 0x0400118D RID: 4493
	private float CBJFIJBDGIJ;

	// Token: 0x0400118E RID: 4494
	private float ACOKOHGMKMF;

	// Token: 0x0400118F RID: 4495
	private float GCKHJJJJJBM;

	// Token: 0x0200020D RID: 525
	public enum NCAKEKLNDNG
	{
		// Token: 0x04001191 RID: 4497
		Poplavok,
		// Token: 0x04001192 RID: 4498
		Donk,
		// Token: 0x04001193 RID: 4499
		Spin,
		// Token: 0x04001194 RID: 4500
		Fish
	}
}
