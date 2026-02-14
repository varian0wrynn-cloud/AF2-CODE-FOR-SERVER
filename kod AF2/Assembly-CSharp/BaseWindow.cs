using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000230 RID: 560
public class BaseWindow : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	// Token: 0x0600807B RID: 32891 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void FGFPACJLEOI(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600807C RID: 32892 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void ANAGENODENL(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600807D RID: 32893 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void DPPAAIJCFLC()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600807E RID: 32894 RVA: 0x003D4E34 File Offset: 0x003D3034
	private void JEPDBHDFDCJ()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Less))
		{
			this.AKDLMJMCDIO();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x0600807F RID: 32895 RVA: 0x003D4E58 File Offset: 0x003D3058
	public void HEHLMPHJHOJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 779f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06008080 RID: 32896 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void HMLHEBLIPLM(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x06008081 RID: 32897 RVA: 0x003D4E8E File Offset: 0x003D308E
	private void JIBKGOFOPHJ()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-35)))
		{
			this.KGHDNCNGBHH();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x06008082 RID: 32898 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void Start()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008083 RID: 32899 RVA: 0x003D4EB2 File Offset: 0x003D30B2
	private void LICGFFPIDCM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 966f);
	}

	// Token: 0x06008084 RID: 32900 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void FJNEIFIAHBI(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x06008085 RID: 32901 RVA: 0x003D4EC9 File Offset: 0x003D30C9
	private void OHPHJCGMNGD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.openSound, 1921f);
	}

	// Token: 0x06008086 RID: 32902 RVA: 0x003D4EE0 File Offset: 0x003D30E0
	public void DPBHAPCDIGA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.closeSound, 142f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008087 RID: 32903 RVA: 0x003D4F16 File Offset: 0x003D3116
	private void KOLCEBEIHKP()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)17))
		{
			this.NODABPDCBPL();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x06008088 RID: 32904 RVA: 0x003D4F3A File Offset: 0x003D313A
	private void PCJAGJKHLHN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.openSound, 349f);
	}

	// Token: 0x06008089 RID: 32905 RVA: 0x003D4F51 File Offset: 0x003D3151
	private void Update()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Escape))
		{
			this.CloseWindow();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x0600808A RID: 32906 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void HCKFNADJIMP(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600808B RID: 32907 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void BGMCLHEODPF(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600808C RID: 32908 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void FFIGGPHAIBP()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x0600808D RID: 32909 RVA: 0x003D4F75 File Offset: 0x003D3175
	private void BOAJJAKEMLH()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Alpha9))
		{
			this.FLNGKNENOFF();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x0600808E RID: 32910 RVA: 0x003D4F99 File Offset: 0x003D3199
	public void PIIELFDDILA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.closeSound, 901f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600808F RID: 32911 RVA: 0x003D4FCF File Offset: 0x003D31CF
	public void AKDLMJMCDIO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.closeSound, 692f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06008090 RID: 32912 RVA: 0x003D5005 File Offset: 0x003D3205
	public void IHANJLJAGLN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 210f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06008091 RID: 32913 RVA: 0x003D503B File Offset: 0x003D323B
	private void JPHLMNIMDHH()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-107)))
		{
			this.PPLBBGLOBIG();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x06008092 RID: 32914 RVA: 0x003D505F File Offset: 0x003D325F
	private void EMFOECIPBIP()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)73))
		{
			this.HEHLMPHJHOJ();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x06008093 RID: 32915 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void OMHBDNACEBI(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x06008094 RID: 32916 RVA: 0x003D5083 File Offset: 0x003D3283
	private void FALFMIAEIJC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 809f);
	}

	// Token: 0x06008095 RID: 32917 RVA: 0x003D509A File Offset: 0x003D329A
	private void INIMDNDBMDK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 587f);
	}

	// Token: 0x06008096 RID: 32918 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void MKNPFMEMOJO()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008097 RID: 32919 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void PNOHGOJEJKL()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008098 RID: 32920 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void HDFCIACDDEK()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x06008099 RID: 32921 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void CPODKHKMOJG(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600809A RID: 32922 RVA: 0x003D50B1 File Offset: 0x003D32B1
	private void OBIPAJDKIHF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.openSound, 155f);
	}

	// Token: 0x0600809B RID: 32923 RVA: 0x003D50C8 File Offset: 0x003D32C8
	private void EEHJEDIFHJI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 964f);
	}

	// Token: 0x0600809C RID: 32924 RVA: 0x003D50DF File Offset: 0x003D32DF
	private void EBAJDGLIAPE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.openSound, 248f);
	}

	// Token: 0x0600809D RID: 32925 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void DGDBDHNEFOA(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x0600809E RID: 32926 RVA: 0x003D50F6 File Offset: 0x003D32F6
	private void KKGLMJEFJOK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.openSound, 541f);
	}

	// Token: 0x0600809F RID: 32927 RVA: 0x003D510D File Offset: 0x003D330D
	private void ALHFPHHGIHK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.openSound, 1220f);
	}

	// Token: 0x060080A0 RID: 32928 RVA: 0x003D5124 File Offset: 0x003D3324
	private void PIMGCFGNCJH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 1560f);
	}

	// Token: 0x060080A1 RID: 32929 RVA: 0x003D513B File Offset: 0x003D333B
	private void PFPPDNHLCCA()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.None))
		{
			this.MNHHBOLFKKA();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080A2 RID: 32930 RVA: 0x003D515F File Offset: 0x003D335F
	public void PPLBBGLOBIG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.closeSound, 1302f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080A3 RID: 32931 RVA: 0x003D5195 File Offset: 0x003D3395
	public void HFDFIGPPEFH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.closeSound, 1608f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080A4 RID: 32932 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void BFBBJILCKAK()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080A5 RID: 32933 RVA: 0x003D51CB File Offset: 0x003D33CB
	private void OILHFNOFNPD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.openSound, 1946f);
	}

	// Token: 0x060080A6 RID: 32934 RVA: 0x003D51E2 File Offset: 0x003D33E2
	private void EKOHIDBILAI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.openSound, 1720f);
	}

	// Token: 0x060080A7 RID: 32935 RVA: 0x003D51F9 File Offset: 0x003D33F9
	private void IIEOKJCJMHH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 465f);
	}

	// Token: 0x060080A8 RID: 32936 RVA: 0x003D5210 File Offset: 0x003D3410
	private void CALDPCOLDNO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.openSound, 493f);
	}

	// Token: 0x060080A9 RID: 32937 RVA: 0x003D5227 File Offset: 0x003D3427
	public void OGGDLIDCLHI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.closeSound, 950f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080AA RID: 32938 RVA: 0x003D525D File Offset: 0x003D345D
	public void KGHDNCNGBHH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.closeSound, 1547f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080AB RID: 32939 RVA: 0x003D5293 File Offset: 0x003D3493
	private void FPLNDDMFFKG()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-48)))
		{
			this.FNGINHPMHDE();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080AC RID: 32940 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void BBAOKPJILEG(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080AD RID: 32941 RVA: 0x003D52B7 File Offset: 0x003D34B7
	private void NJCODNNAFEG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 335f);
	}

	// Token: 0x060080AE RID: 32942 RVA: 0x003D52CE File Offset: 0x003D34CE
	private void BJOICAKCPLI()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Alpha8))
		{
			this.FLNGKNENOFF();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080AF RID: 32943 RVA: 0x003D52F2 File Offset: 0x003D34F2
	private void HJCLNJLADKL()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-119)))
		{
			this.DPBHAPCDIGA();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080B0 RID: 32944 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void HEMEEOGJDOE()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080B1 RID: 32945 RVA: 0x003D5316 File Offset: 0x003D3516
	private void CCGIGJMJCDH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.openSound, 660f);
	}

	// Token: 0x060080B3 RID: 32947 RVA: 0x003D533C File Offset: 0x003D353C
	public void HIEBKOGNOOJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 91f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080B4 RID: 32948 RVA: 0x003D5372 File Offset: 0x003D3572
	public void OGCJLHFEEOB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.closeSound, 170f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080B5 RID: 32949 RVA: 0x003D53A8 File Offset: 0x003D35A8
	private void CDLDCKAHLHC()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-8)))
		{
			this.CloseWindow();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080B6 RID: 32950 RVA: 0x003D53CC File Offset: 0x003D35CC
	private void IGEICBNMPAD()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-20)))
		{
			this.MNHHBOLFKKA();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080B7 RID: 32951 RVA: 0x003D53F0 File Offset: 0x003D35F0
	private void MJGKKNEHHKG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 1234f);
	}

	// Token: 0x060080B8 RID: 32952 RVA: 0x003D5407 File Offset: 0x003D3607
	public void CEGBMABKNFC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.closeSound, 1314f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080B9 RID: 32953 RVA: 0x003D543D File Offset: 0x003D363D
	public void FLNGKNENOFF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.closeSound, 1611f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080BA RID: 32954 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void GHCMIKGJPJD()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080BB RID: 32955 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void AFFAJKPPMHF()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080BC RID: 32956 RVA: 0x003D5473 File Offset: 0x003D3673
	private void JLFBDOPFDDJ()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-83)))
		{
			this.CloseWindow();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080BD RID: 32957 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void OnDrag(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080BE RID: 32958 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void BBIPOBKIOOF(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080BF RID: 32959 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void LMEJKAEIDCO()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080C0 RID: 32960 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void DHMIFHCJJLN(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080C1 RID: 32961 RVA: 0x003D5497 File Offset: 0x003D3697
	private void PPNAHPOBOHK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 280f);
	}

	// Token: 0x060080C2 RID: 32962 RVA: 0x003D54AE File Offset: 0x003D36AE
	private void OnEnable()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 1f);
	}

	// Token: 0x060080C3 RID: 32963 RVA: 0x003D54C5 File Offset: 0x003D36C5
	private void FJEEADNCKAG()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)84))
		{
			this.PPLBBGLOBIG();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080C4 RID: 32964 RVA: 0x003D54E9 File Offset: 0x003D36E9
	public void MNHHBOLFKKA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.closeSound, 186f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080C5 RID: 32965 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void LHHKDNILMDI()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080C6 RID: 32966 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void LBEFOABPMFG()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080C7 RID: 32967 RVA: 0x003D551F File Offset: 0x003D371F
	public void NODABPDCBPL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.closeSound, 476f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080C8 RID: 32968 RVA: 0x003D5555 File Offset: 0x003D3755
	public void HILAJDIMECJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.closeSound, 374f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080C9 RID: 32969 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void MGAOEADBJJM(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080CA RID: 32970 RVA: 0x003D558B File Offset: 0x003D378B
	private void JIFOELPAEHG()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-69)))
		{
			this.NODABPDCBPL();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080CB RID: 32971 RVA: 0x003D55AF File Offset: 0x003D37AF
	private void HONIFOPBBKC()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Space))
		{
			this.DPBHAPCDIGA();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080CC RID: 32972 RVA: 0x003D55D3 File Offset: 0x003D37D3
	private void OPDCJCFMIPE()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-87)))
		{
			this.HEHLMPHJHOJ();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080CD RID: 32973 RVA: 0x003D55F7 File Offset: 0x003D37F7
	public void CloseWindow()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 1f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080CE RID: 32974 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void GBFMCNKJFFD(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080CF RID: 32975 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void EDGALMCHPPH()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080D0 RID: 32976 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void EBFIPDGMOPI(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080D1 RID: 32977 RVA: 0x003D562D File Offset: 0x003D382D
	public void KNCOGGAODKK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.closeSound, 871f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080D2 RID: 32978 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void FJMJCKIJLNN(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080D3 RID: 32979 RVA: 0x003D5663 File Offset: 0x003D3863
	private void FLPMJFEGJLG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.openSound, 1562f);
	}

	// Token: 0x060080D4 RID: 32980 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void PHCLMMHHEIM(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080D5 RID: 32981 RVA: 0x003D567A File Offset: 0x003D387A
	private void OKMAHGAAMHA()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.RightParen))
		{
			this.PPLBBGLOBIG();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080D6 RID: 32982 RVA: 0x003D569E File Offset: 0x003D389E
	private void OPLLGBIPEKL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.openSound, 1736f);
	}

	// Token: 0x060080D7 RID: 32983 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void OALIDDIKLHK()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080D8 RID: 32984 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void HAIHFGPMACI(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080D9 RID: 32985 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void OLBDJCFPKFG()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080DA RID: 32986 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void ADMLGNPDHKJ(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080DB RID: 32987 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void CJNBMPCNKHP()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080DC RID: 32988 RVA: 0x003D56B5 File Offset: 0x003D38B5
	public void BMOFIBGMIBK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.closeSound, 1661f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080DD RID: 32989 RVA: 0x003D56EB File Offset: 0x003D38EB
	private void CBBLGEDCJBF()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Plus))
		{
			this.KNCOGGAODKK();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080DE RID: 32990 RVA: 0x003D570F File Offset: 0x003D390F
	public void HNGIJCMAFDO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 1299f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x060080DF RID: 32991 RVA: 0x003D5745 File Offset: 0x003D3945
	private void DKEFEKOLGFB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.openSound, 859f);
	}

	// Token: 0x060080E0 RID: 32992 RVA: 0x003D575C File Offset: 0x003D395C
	private void JIKGIJEHGAP()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.Alpha0))
		{
			this.HILAJDIMECJ();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080E1 RID: 32993 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void GGPADJJJHMP(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080E2 RID: 32994 RVA: 0x003D5780 File Offset: 0x003D3980
	private void ACEODGIJKFH()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-9)))
		{
			this.AKDLMJMCDIO();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080E3 RID: 32995 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void JCAJHFBELLD(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080E4 RID: 32996 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void GPNEBGNAFJE(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080E5 RID: 32997 RVA: 0x003D57A4 File Offset: 0x003D39A4
	private void FDLEOEFIFOO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.openSound, 322f);
	}

	// Token: 0x060080E6 RID: 32998 RVA: 0x003D57BB File Offset: 0x003D39BB
	private void CABDFNIKOOI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 1277f);
	}

	// Token: 0x060080E7 RID: 32999 RVA: 0x003D57D2 File Offset: 0x003D39D2
	private void KBMKHLDOIKP()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-121)))
		{
			this.OGCJLHFEEOB();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080E8 RID: 33000 RVA: 0x003D57F6 File Offset: 0x003D39F6
	private void NMMGHFDLNOE()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)88))
		{
			this.FNGINHPMHDE();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080E9 RID: 33001 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void HIOFOADBBKH(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080EA RID: 33002 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void NCBLFNKNEDK()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080EB RID: 33003 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void PAOFGJOLCJE(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080EC RID: 33004 RVA: 0x003D581A File Offset: 0x003D3A1A
	private void IOGAKGCADBL()
	{
		if (this.closeAnEsc && Input.GetKeyDown((KeyCode)(-20)))
		{
			this.OGCJLHFEEOB();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080ED RID: 33005 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void BHFMGBNIAMC()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080EE RID: 33006 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void IMABGALEMBI()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080EF RID: 33007 RVA: 0x003D4DEB File Offset: 0x003D2FEB
	public void GCNPDBEHDOM(PointerEventData CAKNKPPGGIK)
	{
		if (this.isDraggable)
		{
			this.JHJDIBFIOFO.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
		}
	}

	// Token: 0x060080F0 RID: 33008 RVA: 0x003D583E File Offset: 0x003D3A3E
	public void FNGINHPMHDE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.closeSound, 991f);
		if (this.destroyOnClose)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x060080F1 RID: 33009 RVA: 0x003D4E26 File Offset: 0x003D3026
	private void DGDGMFDPEHO()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
	}

	// Token: 0x060080F2 RID: 33010 RVA: 0x003D5874 File Offset: 0x003D3A74
	private void EMHGNEMIGII()
	{
		if (this.closeAnEsc && Input.GetKeyDown(KeyCode.RightCurlyBracket))
		{
			this.HIEBKOGNOOJ();
		}
		this.onUpdateEvents.Invoke();
	}

	// Token: 0x060080F3 RID: 33011 RVA: 0x003D5898 File Offset: 0x003D3A98
	private void OCIANPBJNND()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.openSound, 1757f);
	}

	// Token: 0x04001273 RID: 4723
	public Text header;

	// Token: 0x04001274 RID: 4724
	public Text bodyText;

	// Token: 0x04001275 RID: 4725
	public AudioClip openSound;

	// Token: 0x04001276 RID: 4726
	public AudioClip closeSound;

	// Token: 0x04001277 RID: 4727
	public bool isDraggable;

	// Token: 0x04001278 RID: 4728
	public bool destroyOnClose;

	// Token: 0x04001279 RID: 4729
	public bool closeAnEsc = true;

	// Token: 0x0400127A RID: 4730
	public RectTransform[] UI_data;

	// Token: 0x0400127B RID: 4731
	public Button.ButtonClickedEvent onUpdateEvents;

	// Token: 0x0400127C RID: 4732
	private RectTransform JHJDIBFIOFO;
}
