using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200007E RID: 126
[Serializable]
public class ObjectToAttachmentMap
{
	// Token: 0x06001D81 RID: 7553 RVA: 0x000E40A8 File Offset: 0x000E22A8
	public bool NKDBLFFNANL()
	{
		return this.m_ownerObjects.Count > 1;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x000E40B8 File Offset: 0x000E22B8
	public bool OEJGLGAFFNB(pb_Object DHABJKLEEHL, out AttachedElements KEIEHOIJLEE)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			KEIEHOIJLEE = null;
			return false;
		}
		KEIEHOIJLEE = this.m_attachedElements[num];
		return true;
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x000E40EC File Offset: 0x000E22EC
	public void NFFDECHIADD(pb_Object DHABJKLEEHL)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			return;
		}
		this.m_ownerObjects.RemoveAt(num);
		this.m_attachedElements.RemoveAt(num);
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000E4124 File Offset: 0x000E2324
	public bool GNIBENKKLFL(pb_Object DHABJKLEEHL, out AttachedElements KEIEHOIJLEE)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			KEIEHOIJLEE = null;
			return true;
		}
		KEIEHOIJLEE = this.m_attachedElements[num];
		return true;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000E4156 File Offset: 0x000E2356
	public List<AttachedElements> GOCOJHNPEGF()
	{
		return this.m_attachedElements;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000E4160 File Offset: 0x000E2360
	public void OFICLNBMBKD(pb_Object DHABJKLEEHL, AttachedElements KEIEHOIJLEE)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			this.m_ownerObjects.Add(DHABJKLEEHL);
			this.m_attachedElements.Add(KEIEHOIJLEE);
			return;
		}
		this.m_attachedElements[num] = KEIEHOIJLEE;
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x000E41A4 File Offset: 0x000E23A4
	public void PLLMMGKAMOD(pb_Object DHABJKLEEHL)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			return;
		}
		this.m_ownerObjects.RemoveAt(num);
		this.m_attachedElements.RemoveAt(num);
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000E41DB File Offset: 0x000E23DB
	public List<pb_Object> LLKFDDHEHJI()
	{
		return this.m_ownerObjects;
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x000E41E4 File Offset: 0x000E23E4
	public void GLHMAOADJML(pb_Object DHABJKLEEHL, AttachedElements KEIEHOIJLEE)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			this.m_ownerObjects.Add(DHABJKLEEHL);
			this.m_attachedElements.Add(KEIEHOIJLEE);
			return;
		}
		this.m_attachedElements[num] = KEIEHOIJLEE;
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000E4228 File Offset: 0x000E2428
	public bool MGECMHOBJAO()
	{
		return this.m_ownerObjects.Count != 0;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000E4238 File Offset: 0x000E2438
	public void EMCADOIFHDM(pb_Object DHABJKLEEHL)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			return;
		}
		this.m_ownerObjects.RemoveAt(num);
		this.m_attachedElements.RemoveAt(num);
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000E41DB File Offset: 0x000E23DB
	public List<pb_Object> OwnerObjects
	{
		get
		{
			return this.m_ownerObjects;
		}
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x000E4270 File Offset: 0x000E2470
	public void NHCFJAKHLNK(pb_Object DHABJKLEEHL, AttachedElements KEIEHOIJLEE)
	{
		int num = this.m_ownerObjects.IndexOf(DHABJKLEEHL);
		if (num == -1)
		{
			this.m_ownerObjects.Add(DHABJKLEEHL);
			this.m_attachedElements.Add(KEIEHOIJLEE);
			return;
		}
		this.m_attachedElements[num] = KEIEHOIJLEE;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000E41DB File Offset: 0x000E23DB
	public List<pb_Object> ADGPLAJJAME()
	{
		return this.m_ownerObjects;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000E4156 File Offset: 0x000E2356
	public List<AttachedElements> AttachedElements
	{
		get
		{
			return this.m_attachedElements;
		}
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000E41DB File Offset: 0x000E23DB
	public List<pb_Object> KDNNNOEEEEM()
	{
		return this.m_ownerObjects;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000E41DB File Offset: 0x000E23DB
	public List<pb_Object> GIBJAKFPBMF()
	{
		return this.m_ownerObjects;
	}

	// Token: 0x04000311 RID: 785
	[SerializeField]
	private List<pb_Object> m_ownerObjects = new List<pb_Object>();

	// Token: 0x04000312 RID: 786
	[SerializeField]
	private List<AttachedElements> m_attachedElements = new List<AttachedElements>();
}
