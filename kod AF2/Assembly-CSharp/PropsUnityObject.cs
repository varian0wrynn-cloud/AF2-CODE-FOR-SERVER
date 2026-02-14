using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public abstract class PropsUnityObject : MonoBehaviour
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06001C05 RID: 7173 RVA: 0x000DBACB File Offset: 0x000D9CCB
	public GameObject PJBLLKCPKPK
	{
		get
		{
			if (this.NPLLBPLOLEG == null)
			{
				this.NPLLBPLOLEG = base.gameObject;
			}
			return this.NPLLBPLOLEG;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000DBAED File Offset: 0x000D9CED
	public Transform BAFLPOHHCGH
	{
		get
		{
			if (this.MPJDGNOLCGA == null)
			{
				this.MPJDGNOLCGA = base.transform;
			}
			return this.MPJDGNOLCGA;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000DBB1D File Offset: 0x000D9D1D
	// (set) Token: 0x06001C07 RID: 7175 RVA: 0x000DBB0F File Offset: 0x000D9D0F
	public Vector3 KGDFGMAEEBL
	{
		get
		{
			return this.BAFLPOHHCGH.position;
		}
		set
		{
			this.BAFLPOHHCGH.position = value;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000DBB2A File Offset: 0x000D9D2A
	// (set) Token: 0x06001C0A RID: 7178 RVA: 0x000DBB32 File Offset: 0x000D9D32
	public bool NIKCADBPDMH
	{
		get
		{
			return this.JMJEFKLOKLL;
		}
		set
		{
			this.JMJEFKLOKLL = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000DBB3B File Offset: 0x000D9D3B
	public Rigidbody DBFEPAHJFGO
	{
		get
		{
			if (this.FFCOCKCAGCB == null)
			{
				this.FFCOCKCAGCB = base.GetComponent<Rigidbody>();
			}
			return this.FFCOCKCAGCB;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000DBB5D File Offset: 0x000D9D5D
	public Collider GGPNGILLPLI
	{
		get
		{
			if (this.DCPKMNEHLGC == null)
			{
				this.DCPKMNEHLGC = base.GetComponent<Collider>();
			}
			return this.DCPKMNEHLGC;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06001C0D RID: 7181 RVA: 0x000DBB7F File Offset: 0x000D9D7F
	public Animation JEJLCMAKKCK
	{
		get
		{
			if (this.AFAPHHKOKMJ == null)
			{
				this.AFAPHHKOKMJ = base.GetComponent<Animation>();
			}
			return this.AFAPHHKOKMJ;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000DBBA4 File Offset: 0x000D9DA4
	public Renderer DHGAIBFAJNE
	{
		get
		{
			if (this.LFGMKDBKGDC == null)
			{
				Transform transform = this.BAFLPOHHCGH.Find("JNT_Root");
				if (transform != null)
				{
					this.LFGMKDBKGDC = transform.GetComponent<Renderer>();
				}
			}
			return this.LFGMKDBKGDC;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000DBBEC File Offset: 0x000D9DEC
	public Vector3 GEIJDPJBCKC
	{
		get
		{
			if (this.DHGAIBFAJNE != null)
			{
				return this.DHGAIBFAJNE.bounds.center;
			}
			return this.KGDFGMAEEBL;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000DBC24 File Offset: 0x000D9E24
	public Transform HKGPBLBDFBH
	{
		get
		{
			if (this.LOLDCMCLLIA == null)
			{
				this.LOLDCMCLLIA = this.AHENAPKHAJN(this.BAFLPOHHCGH, "JNT_R_Hand");
			}
			if (this.LOLDCMCLLIA == null)
			{
				return this.BAFLPOHHCGH;
			}
			return this.LOLDCMCLLIA;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06001C11 RID: 7185 RVA: 0x000DBC74 File Offset: 0x000D9E74
	public Transform IDPPMKJIBLC
	{
		get
		{
			if (this.EOPJGIBLPAI == null)
			{
				this.EOPJGIBLPAI = this.AHENAPKHAJN(this.BAFLPOHHCGH, "JNT_L_Hand");
			}
			if (this.EOPJGIBLPAI == null)
			{
				return this.BAFLPOHHCGH;
			}
			return this.EOPJGIBLPAI;
		}
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x000DBCC4 File Offset: 0x000D9EC4
	private Transform AHENAPKHAJN(Transform KPPDHDPCFMJ, string PBENBJBCOLD)
	{
		if (KPPDHDPCFMJ.name == PBENBJBCOLD)
		{
			return KPPDHDPCFMJ;
		}
		if (KPPDHDPCFMJ.childCount != 0)
		{
			foreach (object obj in KPPDHDPCFMJ)
			{
				Transform kppdhdpcfmj = (Transform)obj;
				Transform transform = this.AHENAPKHAJN(kppdhdpcfmj, PBENBJBCOLD);
				if (transform != null)
				{
					return transform;
				}
			}
		}
		return null;
	}

	// Token: 0x040002E3 RID: 739
	private GameObject NPLLBPLOLEG;

	// Token: 0x040002E4 RID: 740
	private Transform MPJDGNOLCGA;

	// Token: 0x040002E5 RID: 741
	private Rigidbody FFCOCKCAGCB;

	// Token: 0x040002E6 RID: 742
	private Collider DCPKMNEHLGC;

	// Token: 0x040002E7 RID: 743
	private Animation AFAPHHKOKMJ;

	// Token: 0x040002E8 RID: 744
	private Renderer LFGMKDBKGDC;

	// Token: 0x040002E9 RID: 745
	private bool JMJEFKLOKLL;

	// Token: 0x040002EA RID: 746
	private Transform LOLDCMCLLIA;

	// Token: 0x040002EB RID: 747
	private Transform EOPJGIBLPAI;
}
