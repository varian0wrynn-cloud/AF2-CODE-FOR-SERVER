using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000069 RID: 105
[AddComponentMenu("Triggers/DetectionTrigger")]
public class DetectionTrigger : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06001795 RID: 6037 RVA: 0x000CA77E File Offset: 0x000C897E
	// (set) Token: 0x0600178F RID: 6031 RVA: 0x000CA684 File Offset: 0x000C8884
	public DetectionTrigger.LPCHKCKJMDO GJLKLGOAFOF
	{
		get
		{
			return this.colliderType;
		}
		set
		{
			this.colliderType = value;
		}
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x000CA68D File Offset: 0x000C888D
	protected Collider FGDNKAAHGEP()
	{
		if (this.DCPKMNEHLGC == null)
		{
			this.DCPKMNEHLGC = this.JIECNLHJMPP();
			this.DCPKMNEHLGC.isTrigger = false;
		}
		return this.DCPKMNEHLGC;
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x000CA6BB File Offset: 0x000C88BB
	private void HFPBJLJGFBP(Collision ECBNDBDMDKI)
	{
		this.NLCDAHMIFKC.Remove(ECBNDBDMDKI.transform.GetInstanceID());
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06001792 RID: 6034 RVA: 0x000CA6D4 File Offset: 0x000C88D4
	public bool FALCEBHNNHP
	{
		get
		{
			if (this.NLCDAHMIFKC.Count == 0)
			{
				return false;
			}
			bool result = false;
			foreach (Transform item in this.NLCDAHMIFKC.Values)
			{
				if (!this.DGHPEOHOELO.Contains(item))
				{
					result = true;
				}
			}
			return result;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06001793 RID: 6035 RVA: 0x000CA748 File Offset: 0x000C8948
	protected Collider GGPNGILLPLI
	{
		get
		{
			if (this.DCPKMNEHLGC == null)
			{
				this.DCPKMNEHLGC = this.JIECNLHJMPP();
				this.DCPKMNEHLGC.isTrigger = true;
			}
			return this.DCPKMNEHLGC;
		}
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x000CA776 File Offset: 0x000C8976
	public Dictionary<int, Transform> KHIJKLLPJCA()
	{
		return this.NLCDAHMIFKC;
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060017A7 RID: 6055 RVA: 0x000CA776 File Offset: 0x000C8976
	// (set) Token: 0x06001796 RID: 6038 RVA: 0x000CA786 File Offset: 0x000C8986
	public Dictionary<int, Transform> DJDECJLKMDE
	{
		get
		{
			return this.NLCDAHMIFKC;
		}
		set
		{
			this.NLCDAHMIFKC = value;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06001797 RID: 6039 RVA: 0x000CA78F File Offset: 0x000C898F
	// (set) Token: 0x060017AA RID: 6058 RVA: 0x000CABE7 File Offset: 0x000C8DE7
	public List<Type> IDMHKDLCCLI
	{
		get
		{
			return this.FLDBHHEEHMC;
		}
		set
		{
			this.FLDBHHEEHMC = value;
		}
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x000CA798 File Offset: 0x000C8998
	private Collider JIECNLHJMPP()
	{
		Collider collider = null;
		switch (this.colliderType)
		{
		case DetectionTrigger.LPCHKCKJMDO.Box:
			collider = (base.GetComponent(typeof(BoxCollider)) as BoxCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(BoxCollider)) as BoxCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Capsule:
			collider = (base.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(CapsuleCollider)) as CapsuleCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Sphere:
			collider = (base.GetComponent(typeof(SphereCollider)) as SphereCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(SphereCollider)) as SphereCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Wheel:
			collider = (base.GetComponent(typeof(WheelCollider)) as WheelCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(WheelCollider)) as WheelCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Mesh:
			collider = (base.GetComponent(typeof(MeshCollider)) as MeshCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(MeshCollider)) as MeshCollider);
			}
			break;
		}
		if (collider == null)
		{
			throw new Exception("Trigger Item Has No Collider");
		}
		return collider;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x000CA776 File Offset: 0x000C8976
	public Dictionary<int, Transform> ENHOMLPGNFP()
	{
		return this.NLCDAHMIFKC;
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600179A RID: 6042 RVA: 0x000CA91B File Offset: 0x000C8B1B
	private GameObject PJBLLKCPKPK
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

	// Token: 0x0600179B RID: 6043 RVA: 0x000CA940 File Offset: 0x000C8B40
	private Collider DCNIHHADCPI()
	{
		Collider collider = null;
		switch (this.colliderType)
		{
		case DetectionTrigger.LPCHKCKJMDO.Box:
			collider = (base.GetComponent(typeof(BoxCollider)) as BoxCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(BoxCollider)) as BoxCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Capsule:
			collider = (base.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider);
			if (collider == null)
			{
				collider = (this.EAMHOILEHFE().AddComponent(typeof(CapsuleCollider)) as CapsuleCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Sphere:
			collider = (base.GetComponent(typeof(SphereCollider)) as SphereCollider);
			if (collider == null)
			{
				collider = (this.EAMHOILEHFE().AddComponent(typeof(SphereCollider)) as SphereCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Wheel:
			collider = (base.GetComponent(typeof(WheelCollider)) as WheelCollider);
			if (collider == null)
			{
				collider = (this.EAMHOILEHFE().AddComponent(typeof(WheelCollider)) as WheelCollider);
			}
			break;
		case DetectionTrigger.LPCHKCKJMDO.Mesh:
			collider = (base.GetComponent(typeof(MeshCollider)) as MeshCollider);
			if (collider == null)
			{
				collider = (this.PJBLLKCPKPK.AddComponent(typeof(MeshCollider)) as MeshCollider);
			}
			break;
		}
		if (collider == null)
		{
			throw new Exception("TOD_CloudDensity");
		}
		return collider;
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x000CAAC3 File Offset: 0x000C8CC3
	public void Awake()
	{
		this.GGPNGILLPLI;
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600179D RID: 6045 RVA: 0x000CAAD1 File Offset: 0x000C8CD1
	// (set) Token: 0x060017B0 RID: 6064 RVA: 0x000CAB88 File Offset: 0x000C8D88
	public List<Transform> DGHPEOHOELO
	{
		get
		{
			return this.FLNNKIBODHJ;
		}
		set
		{
			this.FLNNKIBODHJ = value;
		}
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x000CAADC File Offset: 0x000C8CDC
	private void OnTriggerEnter(Collider ECBNDBDMDKI)
	{
		Debug.Log(ECBNDBDMDKI.transform.GetInstanceID() + " " + ECBNDBDMDKI.name);
		this.NLCDAHMIFKC.Add(ECBNDBDMDKI.transform.GetInstanceID(), ECBNDBDMDKI.transform);
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x000CAB5A File Offset: 0x000C8D5A
	protected Collider LBJINGOBDMP()
	{
		if (this.DCPKMNEHLGC == null)
		{
			this.DCPKMNEHLGC = this.DCNIHHADCPI();
			this.DCPKMNEHLGC.isTrigger = false;
		}
		return this.DCPKMNEHLGC;
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x000CAB88 File Offset: 0x000C8D88
	public void PFFNACJDGHF(List<Transform> DCCPCBLODIG)
	{
		this.FLNNKIBODHJ = DCCPCBLODIG;
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x000CA77E File Offset: 0x000C897E
	public DetectionTrigger.LPCHKCKJMDO COBNEDFABOL()
	{
		return this.colliderType;
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x000CA6BB File Offset: 0x000C88BB
	private void JMLOIDOHBLD(Collision ECBNDBDMDKI)
	{
		this.NLCDAHMIFKC.Remove(ECBNDBDMDKI.transform.GetInstanceID());
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x000CA776 File Offset: 0x000C8976
	public Dictionary<int, Transform> PFPEHCMNLHC()
	{
		return this.NLCDAHMIFKC;
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000CA684 File Offset: 0x000C8884
	public void MDFCDKGFIOH(DetectionTrigger.LPCHKCKJMDO DCCPCBLODIG)
	{
		this.colliderType = DCCPCBLODIG;
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x000CA77E File Offset: 0x000C897E
	public DetectionTrigger.LPCHKCKJMDO JBFMKOKCPJN()
	{
		return this.colliderType;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x000CAB94 File Offset: 0x000C8D94
	private void HEFOCOENDHF(Collision ECBNDBDMDKI)
	{
		Debug.Log(ECBNDBDMDKI.transform.GetInstanceID() + " " + ECBNDBDMDKI.transform.name);
		this.NLCDAHMIFKC.Add(ECBNDBDMDKI.transform.GetInstanceID(), ECBNDBDMDKI.transform);
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x000CA776 File Offset: 0x000C8976
	public Dictionary<int, Transform> OOPIHMALEAE()
	{
		return this.NLCDAHMIFKC;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x000CA91B File Offset: 0x000C8B1B
	private GameObject EAMHOILEHFE()
	{
		if (this.NPLLBPLOLEG == null)
		{
			this.NPLLBPLOLEG = base.gameObject;
		}
		return this.NPLLBPLOLEG;
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x000CABF0 File Offset: 0x000C8DF0
	private void OnTriggerExit(Collider ECBNDBDMDKI)
	{
		this.NLCDAHMIFKC.Remove(ECBNDBDMDKI.transform.GetInstanceID());
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x000CAB88 File Offset: 0x000C8D88
	public void HCFCLOHIEJJ(List<Transform> DCCPCBLODIG)
	{
		this.FLNNKIBODHJ = DCCPCBLODIG;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x000CAAD1 File Offset: 0x000C8CD1
	public List<Transform> CLJLEBCJIMH()
	{
		return this.FLNNKIBODHJ;
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x000CAC09 File Offset: 0x000C8E09
	public void JMNLEBAPHNJ()
	{
		this.LBJINGOBDMP();
	}

	// Token: 0x0400028C RID: 652
	private GameObject NPLLBPLOLEG;

	// Token: 0x0400028D RID: 653
	protected Collider DCPKMNEHLGC;

	// Token: 0x0400028E RID: 654
	[SerializeField]
	private DetectionTrigger.LPCHKCKJMDO colliderType = DetectionTrigger.LPCHKCKJMDO.Sphere;

	// Token: 0x0400028F RID: 655
	private Dictionary<int, Transform> NLCDAHMIFKC = new Dictionary<int, Transform>();

	// Token: 0x04000290 RID: 656
	private List<Transform> FLNNKIBODHJ = new List<Transform>();

	// Token: 0x04000291 RID: 657
	private List<Type> FLDBHHEEHMC = new List<Type>();

	// Token: 0x0200006A RID: 106
	public enum LPCHKCKJMDO
	{
		// Token: 0x04000293 RID: 659
		Box,
		// Token: 0x04000294 RID: 660
		Capsule,
		// Token: 0x04000295 RID: 661
		Sphere,
		// Token: 0x04000296 RID: 662
		Wheel,
		// Token: 0x04000297 RID: 663
		Mesh
	}
}
