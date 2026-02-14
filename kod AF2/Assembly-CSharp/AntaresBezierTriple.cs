using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class AntaresBezierTriple : MonoBehaviour
{
	// Token: 0x06000957 RID: 2391 RVA: 0x0005E009 File Offset: 0x0005C209
	public Vector3 NPGEJGBMOFN()
	{
		return this.BMDMPGEGNBB().position;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x0005E018 File Offset: 0x0005C218
	public void BPPCIAPCFML(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.JKODCBJIFAH(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x0005E08B File Offset: 0x0005C28B
	public Vector3 HBHDNJDKABA()
	{
		return this.PHLAENONMEL().position;
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x0005E098 File Offset: 0x0005C298
	public void KKPADGBNEMJ(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
	public Vector3 COGLLDJHGDC()
	{
		return this.KKHOENNBCKN().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform BPAJILPDPGJ()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool GOFJBBPGLIJ()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void Awake()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void IIELJNDNLMO()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform JKOHGFLFDBD()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x0005E104 File Offset: 0x0005C304
	private void JEGAEKMDCGD()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.HLPCIMNKCMP(), "jamp");
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x0005E098 File Offset: 0x0005C298
	public void HJNMKBEDAPA(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000963 RID: 2403 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform ANKHLLHKBIE
	{
		get
		{
			if (this.OONIAAMMOIP == null)
			{
				this.OONIAAMMOIP = base.transform;
			}
			return this.OONIAAMMOIP;
		}
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x0005E16C File Offset: 0x0005C36C
	private void KNIHMOCAGIN()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.HBHDNJDKABA(), "knopje.wav");
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform FLMNLCGHNNE()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x0005E098 File Offset: 0x0005C298
	public void JLNFPAPOELN(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void PFFMPHLHMIP()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0005E1D4 File Offset: 0x0005C3D4
	public void CNHPCBGGNME(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.PHLAENONMEL().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.KKPADGBNEMJ(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x0005E248 File Offset: 0x0005C448
	private void MLIOJIOLEDD()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.PKEKNIBMMMH(), "wpn_onlym");
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x0005E2B0 File Offset: 0x0005C4B0
	public void KELJCOGIOIP(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.AGFACEFLDAI(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x0005E324 File Offset: 0x0005C524
	public void AKMGKNEPCNL(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.LAMMKELOIDB().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.JKODCBJIFAH(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x0005E098 File Offset: 0x0005C298
	public void LFHBIBGJPON(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x0005E098 File Offset: 0x0005C298
	public void GBOEECIKKCG(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x0005E398 File Offset: 0x0005C598
	public void HCPMHNINFCN(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.KKHOENNBCKN().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.FPNKFIMFBBB = false;
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0005E098 File Offset: 0x0005C298
	public bool FPNKFIMFBBB
	{
		get
		{
			return this.BJAHPFPLAHL;
		}
		set
		{
			this.BJAHPFPLAHL = value;
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x0005E40C File Offset: 0x0005C60C
	public Vector3 GGPBLJDJAPI()
	{
		return this.FLMNLCGHNNE().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool EIIJPKKAPAH()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000972 RID: 2418 RVA: 0x0005E432 File Offset: 0x0005C632
	public Vector3 GMKPNPFIHFP
	{
		get
		{
			return this.ANKHLLHKBIE.position;
		}
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0005E43F File Offset: 0x0005C63F
	public Vector3 EFBOCCHFBLP()
	{
		return this.LAMMKELOIDB().position;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x0005E44C File Offset: 0x0005C64C
	public void DGEHOHKBMGO(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.AGFACEFLDAI(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
	public void HFBPHBDJIIJ(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.AGFACEFLDAI(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x0005E534 File Offset: 0x0005C734
	public Vector3 FPAKCHBEAIC()
	{
		return this.BMDMPGEGNBB().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x0005E55C File Offset: 0x0005C75C
	public void PDKMJAIHPHL(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.BPAJILPDPGJ().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.DIKHCKKKKKC(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x0005E5D0 File Offset: 0x0005C7D0
	private void EIKNKCCJFPJ()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.MMNAPHKJAFH(), "OnRodChangeClck 5");
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x0005E638 File Offset: 0x0005C838
	public void PEFIKBEIOAF(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.FLMNLCGHNNE().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.KKPADGBNEMJ(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x0005E6AC File Offset: 0x0005C8AC
	public Vector3 BKOPLJCPCOM()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void CBBIADNKMLI()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0005E098 File Offset: 0x0005C298
	public void DPOHLCDNABI(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
	public Vector3 IIKFNEDNMFH()
	{
		return this.JKOHGFLFDBD().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0005E6FC File Offset: 0x0005C8FC
	private void OnDrawGizmos()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.GMKPNPFIHFP, "Antares/point");
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x0005E764 File Offset: 0x0005C964
	// (set) Token: 0x060009CB RID: 2507 RVA: 0x0005F5A0 File Offset: 0x0005D7A0
	public Vector3 FAFBEDFHHGF
	{
		get
		{
			return this.ANKHLLHKBIE.localToWorldMatrix.MultiplyPoint(this.backwardPoint);
		}
		set
		{
			Vector3 rhs = this.backwardPoint;
			this.backwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(value);
			if (this.backwardPoint != rhs)
			{
				this.FPNKFIMFBBB = true;
			}
			if (this.isSmooth)
			{
				float magnitude = this.forwardPoint.magnitude;
				this.forwardPoint = -this.backwardPoint.normalized * magnitude;
			}
		}
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0005E78C File Offset: 0x0005C98C
	public void MPGCJLAEGNK(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.BPAJILPDPGJ().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.FPNKFIMFBBB = false;
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void AHILDBJHCKI()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x0005E800 File Offset: 0x0005CA00
	public Vector3 HFJFEONFCFD()
	{
		return this.JKOHGFLFDBD().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void MHMOLJLFPKP()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0005E826 File Offset: 0x0005CA26
	public Vector3 PJDAFMKJENM()
	{
		return this.FLMNLCGHNNE().position;
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void BHPGDKJHKKG()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void DIDFCBLHFNF()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform GONPLGAGDOC()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x0005E834 File Offset: 0x0005CA34
	private void CHBDOCCGEPC()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.MFOBPCGHKPE(), "DealerShuffle");
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0005E899 File Offset: 0x0005CA99
	public Vector3 OLPDKOHDPOB()
	{
		return this.KKHOENNBCKN().position;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0005E8A8 File Offset: 0x0005CAA8
	public Vector3 BOFCGKNFOFO()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x0005E8CE File Offset: 0x0005CACE
	public Vector3 MMNAPHKJAFH()
	{
		return this.JKOHGFLFDBD().position;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x0005E098 File Offset: 0x0005C298
	public void AGFACEFLDAI(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool BOIKLHONIMM()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x0005E43F File Offset: 0x0005C63F
	public Vector3 EIPLGCJGCGI()
	{
		return this.LAMMKELOIDB().position;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x0005E8DC File Offset: 0x0005CADC
	public void AKHGFJMPKFL(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.GFPFIKKFBFL(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x0005E94F File Offset: 0x0005CB4F
	public Vector3 MEKIEDAHIMJ()
	{
		return this.GONPLGAGDOC().position;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0005E098 File Offset: 0x0005C298
	public void DIKHCKKKKKC(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x0005E95C File Offset: 0x0005CB5C
	public void LFKCBJAHBFN(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.GONPLGAGDOC().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.FPNKFIMFBBB = false;
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x0005E9D0 File Offset: 0x0005CBD0
	private void GDDNNAOKOII()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.MBABDAOAEKE(), "_PrevViewProj");
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0005EA38 File Offset: 0x0005CC38
	public Vector3 KCDCGDGDCMA()
	{
		return this.GONPLGAGDOC().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x0005EA60 File Offset: 0x0005CC60
	public void FOEGCGILPCO(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.GONPLGAGDOC().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.LFHBIBGJPON(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0005EAD4 File Offset: 0x0005CCD4
	private void MCPGOKDFPDI()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.EFBOCCHFBLP(), "/n");
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0005E826 File Offset: 0x0005CA26
	public Vector3 MBABDAOAEKE()
	{
		return this.FLMNLCGHNNE().position;
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0005EB3C File Offset: 0x0005CD3C
	public void OJBLKOJOGJJ(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.GFPFIKKFBFL(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void APNGAHFMCIA()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x0005EBB0 File Offset: 0x0005CDB0
	public Vector3 IMGLMGOPGII()
	{
		return this.KKHOENNBCKN().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x0005EBD8 File Offset: 0x0005CDD8
	private void HAHJAFEEEJP()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.HLPCIMNKCMP(), "IdleTurns");
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0005EC40 File Offset: 0x0005CE40
	public Vector3 ECOEEPCMFPG()
	{
		return this.BMDMPGEGNBB().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0005EC68 File Offset: 0x0005CE68
	public void LBLHEMFNOJD(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.ENBFOGGENHP(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600099E RID: 2462 RVA: 0x0005ECDC File Offset: 0x0005CEDC
	// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0005F01C File Offset: 0x0005D21C
	public Vector3 NAEJBMCIPGB
	{
		get
		{
			return this.ANKHLLHKBIE.localToWorldMatrix.MultiplyPoint(this.forwardPoint);
		}
		set
		{
			Vector3 rhs = this.forwardPoint;
			this.forwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(value);
			if (this.forwardPoint != rhs)
			{
				this.FPNKFIMFBBB = true;
			}
			if (this.isSmooth)
			{
				float magnitude = this.backwardPoint.magnitude;
				this.backwardPoint = -this.forwardPoint.normalized * magnitude;
			}
		}
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x0005E899 File Offset: 0x0005CA99
	public Vector3 HLPCIMNKCMP()
	{
		return this.KKHOENNBCKN().position;
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0005E43F File Offset: 0x0005C63F
	public Vector3 LJCNPPLAHLK()
	{
		return this.LAMMKELOIDB().position;
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x0005ED04 File Offset: 0x0005CF04
	public void DGILOJGAKEG(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.ELJCMJFHAEE().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.JBAHMHJIEBP(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0005ED78 File Offset: 0x0005CF78
	public void IFKLOPNOJFB(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.JBAHMHJIEBP(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool PHKDMPANMGM()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0005EDEC File Offset: 0x0005CFEC
	private void MEEHNBNPLOA()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.PJDAFMKJENM(), "<color='#606080'>+{0}</color>");
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0005EE54 File Offset: 0x0005D054
	public Vector3 GLFBDIHOKPF()
	{
		return this.PHLAENONMEL().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x0005EE7C File Offset: 0x0005D07C
	public void KPKHAFGDEBJ(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.BPAJILPDPGJ().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.JKODCBJIFAH(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform KKHOENNBCKN()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void MBKLIKGAKJB()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
	private void IBIEHLPOPBA()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.GMKPNPFIHFP, "_RayStepSize");
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void LPDIHACCGKK()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform BMDMPGEGNBB()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void LKDGGPNGLAO()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0005E098 File Offset: 0x0005C298
	public void GCPHLNKEEED(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool PLAGNEALFMC()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x0005EF58 File Offset: 0x0005D158
	public Vector3 INGKAKAAOAI()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x0005EF80 File Offset: 0x0005D180
	public Vector3 PJLLFEJPOCE()
	{
		return this.PHLAENONMEL().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x0005EFA8 File Offset: 0x0005D1A8
	public void NNDMGFJIHEL(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.LAMMKELOIDB().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.JKODCBJIFAH(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool OGDPOJDGLLG()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0005F090 File Offset: 0x0005D290
	public Vector3 ADMMFOFMBBK()
	{
		return this.JKOHGFLFDBD().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void CJCGPPJADJL()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
	public void DPILJGIDAIC(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.BMDMPGEGNBB().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.ENBFOGGENHP(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x0005F12C File Offset: 0x0005D32C
	private void DGHDHAIOCMI()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.MBABDAOAEKE(), "IdleStand");
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0005F194 File Offset: 0x0005D394
	public void AIIKNKDAILB(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.BMDMPGEGNBB().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.DIKHCKKKKKC(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0005F208 File Offset: 0x0005D408
	public void BEBGJPJLDAA(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.LAMMKELOIDB().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.GFPFIKKFBFL(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0005E098 File Offset: 0x0005C298
	public void ENBFOGGENHP(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x0005F27C File Offset: 0x0005D47C
	private void EFGLJPLCHFD()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.HBHDNJDKABA(), "_AutoExposure");
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0005E098 File Offset: 0x0005C298
	public void GFPFIKKFBFL(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0005F2E4 File Offset: 0x0005D4E4
	public void JFKFHLPLDNO(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.FLMNLCGHNNE().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.JLNFPAPOELN(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x0005F358 File Offset: 0x0005D558
	public Vector3 OICGIFMEBHG()
	{
		return this.PHLAENONMEL().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x0005F380 File Offset: 0x0005D580
	public void CAFPOAGHHFN(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.JKOHGFLFDBD().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.DIKHCKKKKKC(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0005E098 File Offset: 0x0005C298
	public void JBAHMHJIEBP(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform LAMMKELOIDB()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0005E826 File Offset: 0x0005CA26
	public Vector3 PKEKNIBMMMH()
	{
		return this.FLMNLCGHNNE().position;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0005F3F4 File Offset: 0x0005D5F4
	public void POKJELJFJJE(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.ANKHLLHKBIE.worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.DIKHCKKKKKC(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0005F468 File Offset: 0x0005D668
	private void LBANIBHDMMO()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.HBHDNJDKABA(), "error");
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
	public void CLFDGLKHNAB(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.PHLAENONMEL().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.JKODCBJIFAH(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform PHLAENONMEL()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x0005E43F File Offset: 0x0005C63F
	public Vector3 MFOBPCGHKPE()
	{
		return this.LAMMKELOIDB().position;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0005F543 File Offset: 0x0005D743
	public Vector3 NFHPHAELPKJ()
	{
		return this.ELJCMJFHAEE().position;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x0005F550 File Offset: 0x0005D750
	public Vector3 FJKJGOHCPHD()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0005F578 File Offset: 0x0005D778
	public Vector3 DFNHDNKDNBG()
	{
		return this.BMDMPGEGNBB().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0005F614 File Offset: 0x0005D814
	private void EENHGLBOOCN()
	{
		if (!this.FOPOPMCDLPP)
		{
			this.FOPOPMCDLPP = base.transform.root.GetComponent<AntaresBezierCurve>();
		}
		if (!this.FOPOPMCDLPP || !this.FOPOPMCDLPP.inEditorShowGizmos)
		{
			return;
		}
		Gizmos.color = Color.gray;
		Gizmos.DrawIcon(this.GMKPNPFIHFP, "t_bottom");
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0005F67C File Offset: 0x0005D87C
	public Vector3 FCLBFPEMGHE()
	{
		return this.FLMNLCGHNNE().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0005F6A4 File Offset: 0x0005D8A4
	public Vector3 IINAGHIAIAE()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0005F6CC File Offset: 0x0005D8CC
	public void GJCGJDDHBAH(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.forwardPoint;
		this.forwardPoint = this.BPAJILPDPGJ().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.forwardPoint != rhs)
		{
			this.ENBFOGGENHP(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.backwardPoint.magnitude;
			this.backwardPoint = -this.forwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0005E0EC File Offset: 0x0005C2EC
	public bool MDELEEOKBNI()
	{
		return this.BJAHPFPLAHL;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0005F740 File Offset: 0x0005D940
	public void HCJDNLLIONJ(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.ELJCMJFHAEE().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.DPOHLCDNABI(true);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0005E0CA File Offset: 0x0005C2CA
	public Transform ELJCMJFHAEE()
	{
		if (this.OONIAAMMOIP == null)
		{
			this.OONIAAMMOIP = base.transform;
		}
		return this.OONIAAMMOIP;
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
	public Vector3 OCNGGINGFCO()
	{
		return this.GONPLGAGDOC().localToWorldMatrix.MultiplyPoint(this.forwardPoint);
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0005F7DC File Offset: 0x0005D9DC
	public Vector3 DMOODPPAEKF()
	{
		return this.ELJCMJFHAEE().localToWorldMatrix.MultiplyPoint(this.backwardPoint);
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0005F804 File Offset: 0x0005DA04
	public void JHKPEJLGMDD(Vector3 DCCPCBLODIG)
	{
		Vector3 rhs = this.backwardPoint;
		this.backwardPoint = this.ELJCMJFHAEE().worldToLocalMatrix.MultiplyPoint(DCCPCBLODIG);
		if (this.backwardPoint != rhs)
		{
			this.GBOEECIKKCG(false);
		}
		if (this.isSmooth)
		{
			float magnitude = this.forwardPoint.magnitude;
			this.forwardPoint = -this.backwardPoint.normalized * magnitude;
		}
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0005E098 File Offset: 0x0005C298
	public void JKODCBJIFAH(bool DCCPCBLODIG)
	{
		this.BJAHPFPLAHL = DCCPCBLODIG;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
	public void PJMCFJBFLIH()
	{
		this.OONIAAMMOIP = base.transform;
	}

	// Token: 0x0400012C RID: 300
	public bool isSmooth = true;

	// Token: 0x0400012D RID: 301
	public Vector3 forwardPoint;

	// Token: 0x0400012E RID: 302
	public Vector3 backwardPoint;

	// Token: 0x0400012F RID: 303
	private Transform OONIAAMMOIP;

	// Token: 0x04000130 RID: 304
	private bool BJAHPFPLAHL = true;

	// Token: 0x04000131 RID: 305
	private AntaresBezierCurve FOPOPMCDLPP;
}
