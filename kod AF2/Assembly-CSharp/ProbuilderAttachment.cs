using System;
using System.Collections.Generic;
using System.Linq;
using ProBuilder2.Common;
using UnityEngine;

// Token: 0x0200007C RID: 124
public class ProbuilderAttachment : MonoBehaviour
{
	// Token: 0x06001D2D RID: 7469 RVA: 0x000DEF35 File Offset: 0x000DD135
	public ObjectToAttachmentMap BFBECDFODOD()
	{
		return this.m_attachedElementsMap;
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x000DEF35 File Offset: 0x000DD135
	public ObjectToAttachmentMap GetAttachedElementsMap()
	{
		return this.m_attachedElementsMap;
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x000DEF40 File Offset: 0x000DD140
	public void AttachVertex(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			attachedElements = new AttachedElements();
			this.m_attachedElementsMap.NHCFJAKHLNK(LBACHMFBPAJ, attachedElements);
		}
		if (!attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Add(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000DEF8C File Offset: 0x000DD18C
	private bool AMMCILPFDJM(IEnumerable<pb_Face> PPGFHPJMFMB, pb_Face LEBPNFGNEBI, out pb_Face JHEOGPEFBHL)
	{
		foreach (pb_Face pb_Face in PPGFHPJMFMB)
		{
			if (this.AGMLFEPCNLA(pb_Face, LEBPNFGNEBI))
			{
				JHEOGPEFBHL = pb_Face;
				return true;
			}
		}
		JHEOGPEFBHL = null;
		return false;
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x000DEFE4 File Offset: 0x000DD1E4
	public void GHAIDPKPLPK(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.GNIBENKKLFL(LBACHMFBPAJ, out attachedElements))
		{
			attachedElements = new AttachedElements();
			this.m_attachedElementsMap.GLHMAOADJML(LBACHMFBPAJ, attachedElements);
		}
		if (!attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Add(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x000DF030 File Offset: 0x000DD230
	public void DetachFace(pb_Object LBACHMFBPAJ, pb_Face LEBPNFGNEBI)
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		pb_Face item;
		if (this.AMMCILPFDJM(attachedElements.Faces, LEBPNFGNEBI, out item))
		{
			attachedElements.Faces.Remove(item);
		}
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x000DF07C File Offset: 0x000DD27C
	public void AttachFace(pb_Object LBACHMFBPAJ, pb_Face LEBPNFGNEBI)
	{
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			attachedElements = new AttachedElements();
			this.m_attachedElementsMap.NHCFJAKHLNK(LBACHMFBPAJ, attachedElements);
		}
		pb_Face pb_Face;
		if (!this.AMMCILPFDJM(attachedElements.Faces, LEBPNFGNEBI, out pb_Face))
		{
			attachedElements.Faces.Add(LEBPNFGNEBI);
		}
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x000DF0CC File Offset: 0x000DD2CC
	private bool FFBJCOMDHMA(pb_Face EGABJKIFAON, pb_Face HHAGIHEGFML)
	{
		if (EGABJKIFAON == HHAGIHEGFML)
		{
			return true;
		}
		HashSet<int> hashSet = new HashSet<int>(EGABJKIFAON.distinctIndices);
		HashSet<int> other = new HashSet<int>(HHAGIHEGFML.distinctIndices);
		hashSet.ExceptWith(other);
		return hashSet.Count == 0;
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x000DF108 File Offset: 0x000DD308
	private bool LGDJAJFAJMI(pb_Face EGABJKIFAON, pb_Face HHAGIHEGFML)
	{
		if (EGABJKIFAON == HHAGIHEGFML)
		{
			return false;
		}
		HashSet<int> hashSet = new HashSet<int>(EGABJKIFAON.distinctIndices);
		HashSet<int> other = new HashSet<int>(HHAGIHEGFML.distinctIndices);
		hashSet.ExceptWith(other);
		return hashSet.Count == 0;
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x000DF144 File Offset: 0x000DD344
	private bool AGMLFEPCNLA(pb_Face EGABJKIFAON, pb_Face HHAGIHEGFML)
	{
		if (EGABJKIFAON == HHAGIHEGFML)
		{
			return true;
		}
		HashSet<int> hashSet = new HashSet<int>(EGABJKIFAON.distinctIndices);
		HashSet<int> other = new HashSet<int>(HHAGIHEGFML.distinctIndices);
		hashSet.ExceptWith(other);
		return hashSet.Count == 0;
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x000DF180 File Offset: 0x000DD380
	public void LCPGKDFAMLL(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			attachedElements = new AttachedElements();
			this.m_attachedElementsMap.GLHMAOADJML(LBACHMFBPAJ, attachedElements);
		}
		if (!attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Add(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x000DF1CC File Offset: 0x000DD3CC
	private void JEKCJKOKHBK(pb_Object CJEJJCHDGBO, Mesh PDBOLEGLMEL, int[] FECKKJGKGPH, Vector3[] LCFDKMLFBHM)
	{
		Vector3[] vertices = CJEJJCHDGBO.vertices;
		pb_IntArray[] sharedIndices = CJEJJCHDGBO.sharedIndices;
		for (int i = 0; i < FECKKJGKGPH.Length; i++)
		{
			int num = FECKKJGKGPH[i];
			Vector3 vector = LCFDKMLFBHM[i];
			foreach (int num2 in sharedIndices[num].array)
			{
				vertices[num2].Set(vector.x, vector.y, vector.z);
			}
		}
		CJEJJCHDGBO.SetVertices(vertices);
		PDBOLEGLMEL.vertices = vertices;
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x000DF258 File Offset: 0x000DD458
	public void DetachVertex(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		if (attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Remove(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x000DF2A0 File Offset: 0x000DD4A0
	public void OPDCJCFMIPE()
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return;
		}
		Transform transform = base.transform;
		for (int i = 1; i < this.AALJGJAKCPI.Length; i += 0)
		{
			JDAMNFAJLNB jdamnfajlnb = this.AALJGJAKCPI[i];
			pb_Object pb_Object = jdamnfajlnb.KHGNJPDMBNI();
			Transform transform2 = pb_Object.transform;
			int[] array = jdamnfajlnb.HAOMGOCHGIO;
			Vector3[] array2 = jdamnfajlnb.DEHDIKLIKAP();
			Mesh pdboleglmel = jdamnfajlnb.GKJEANPNOOM;
			Vector3[] array3 = jdamnfajlnb.JDCFCPMHAMA;
			for (int j = 0; j < array.Length; j += 0)
			{
				Vector3 position = transform.TransformPoint(array2[j]);
				Vector3 vector = transform2.InverseTransformPoint(position);
				array3[j].Set(vector.x, vector.y, vector.z);
			}
			this.MJBAKHHLELK(pb_Object, pdboleglmel, array, array3);
		}
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x000DF370 File Offset: 0x000DD570
	public AttachedElements GetAttachedElements(pb_Object EMALOKAOMPO)
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return null;
		}
		AttachedElements result;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(EMALOKAOMPO, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000DF3A0 File Offset: 0x000DD5A0
	public void KEMGOLACEHI()
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			string format = "Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogWarningFormat(format, array);
			return;
		}
		HashSet<JDAMNFAJLNB> hashSet = new HashSet<JDAMNFAJLNB>();
		foreach (pb_Object pb_Object in this.m_attachedElementsMap.ADGPLAJJAME())
		{
			if (pb_Object == null)
			{
				Debug.LogError(" assetbundle(s) in memory before unloading ");
				Debug.LogError("InteractionSystem can not find a FullBodyBipedIK component");
				Debug.LogError("{x}");
				base.enabled = false;
				return;
			}
			AttachedElements attachedElements;
			if (this.m_attachedElementsMap.OEJGLGAFFNB(pb_Object, out attachedElements))
			{
				pb_Object.ToMesh();
				hashSet.Add(attachedElements.BGCFICFCEHN(pb_Object, this));
			}
		}
		this.AALJGJAKCPI = hashSet.ToArray<JDAMNFAJLNB>();
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x000DF480 File Offset: 0x000DD680
	public void GCJOGCACDID(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		if (attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Remove(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x000DF4C8 File Offset: 0x000DD6C8
	public void ANHOOJFEJJE()
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			Debug.LogWarningFormat("t_top", new object[]
			{
				base.name
			});
			return;
		}
		HashSet<JDAMNFAJLNB> hashSet = new HashSet<JDAMNFAJLNB>();
		foreach (pb_Object pb_Object in this.m_attachedElementsMap.OwnerObjects)
		{
			if (pb_Object == null)
			{
				Debug.LogError("MotorbikeAirWalk");
				Debug.LogError("Cowboy1HandDraw");
				Debug.LogError("SixStep");
				base.enabled = false;
				return;
			}
			AttachedElements attachedElements;
			if (this.m_attachedElementsMap.GNIBENKKLFL(pb_Object, out attachedElements))
			{
				pb_Object.ToMesh();
				hashSet.Add(attachedElements.PHODNGJLJHH(pb_Object, this));
			}
		}
		this.AALJGJAKCPI = hashSet.ToArray<JDAMNFAJLNB>();
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x000DF5A8 File Offset: 0x000DD7A8
	public void LHBCBPOADIL(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.GNIBENKKLFL(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		if (attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Remove(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x000DF610 File Offset: 0x000DD810
	private void MJBAKHHLELK(pb_Object CJEJJCHDGBO, Mesh PDBOLEGLMEL, int[] FECKKJGKGPH, Vector3[] LCFDKMLFBHM)
	{
		Vector3[] vertices = CJEJJCHDGBO.vertices;
		pb_IntArray[] sharedIndices = CJEJJCHDGBO.sharedIndices;
		for (int i = 1; i < FECKKJGKGPH.Length; i += 0)
		{
			int num = FECKKJGKGPH[i];
			Vector3 vector = LCFDKMLFBHM[i];
			int[] array = sharedIndices[num].array;
			for (int j = 0; j < array.Length; j += 0)
			{
				int num2 = array[j];
				vertices[num2].Set(vector.x, vector.y, vector.z);
			}
		}
		CJEJJCHDGBO.SetVertices(vertices);
		PDBOLEGLMEL.vertices = vertices;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x000DF69C File Offset: 0x000DD89C
	public void Start()
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			Debug.LogWarningFormat("The object '{0}' has a ProBuilder attachment component which contains zero attached elements.", new object[]
			{
				base.name
			});
			return;
		}
		HashSet<JDAMNFAJLNB> hashSet = new HashSet<JDAMNFAJLNB>();
		foreach (pb_Object pb_Object in this.m_attachedElementsMap.OwnerObjects)
		{
			if (pb_Object == null)
			{
				Debug.LogError("[ProBuilder Attachments] A pb_Object is missing, this is normally caused by pb_Objects being stripped.");
				Debug.LogError("[ProBuilder Attachments] Please disable the following option in the Unity preferences:");
				Debug.LogError("[ProBuilder Attachments] 'Strip PB Scripts on Build' in Preferences / ProBuilder.");
				base.enabled = false;
				return;
			}
			AttachedElements attachedElements;
			if (this.m_attachedElementsMap.OEJGLGAFFNB(pb_Object, out attachedElements))
			{
				pb_Object.ToMesh();
				hashSet.Add(attachedElements.KBOINNPIMLG(pb_Object, this));
			}
		}
		this.AALJGJAKCPI = hashSet.ToArray<JDAMNFAJLNB>();
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x000DF77C File Offset: 0x000DD97C
	public void EDGALMCHPPH()
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			string format = " Bones.";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogWarningFormat(format, array);
			return;
		}
		HashSet<JDAMNFAJLNB> hashSet = new HashSet<JDAMNFAJLNB>();
		foreach (pb_Object pb_Object in this.m_attachedElementsMap.GIBJAKFPBMF())
		{
			if (pb_Object == null)
			{
				Debug.LogError("_Skybox");
				Debug.LogError("Positions");
				Debug.LogError("CrouchWalk");
				base.enabled = false;
				return;
			}
			AttachedElements attachedElements;
			if (this.m_attachedElementsMap.GNIBENKKLFL(pb_Object, out attachedElements))
			{
				pb_Object.ToMesh();
				hashSet.Add(attachedElements.FBGDJKJKODF(pb_Object, this));
			}
		}
		this.AALJGJAKCPI = hashSet.ToArray<JDAMNFAJLNB>();
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x000DF85C File Offset: 0x000DDA5C
	public void OFGMIEJKMGC()
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			string format = "WeaponStab";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogWarningFormat(format, array);
			return;
		}
		HashSet<JDAMNFAJLNB> hashSet = new HashSet<JDAMNFAJLNB>();
		foreach (pb_Object pb_Object in this.m_attachedElementsMap.LLKFDDHEHJI())
		{
			if (pb_Object == null)
			{
				Debug.LogError("implevel");
				Debug.LogError("RollerBladeTurnLeft");
				Debug.LogError("Run Back Left");
				base.enabled = false;
				return;
			}
			AttachedElements attachedElements;
			if (this.m_attachedElementsMap.GNIBENKKLFL(pb_Object, out attachedElements))
			{
				pb_Object.ToMesh();
				hashSet.Add(attachedElements.LKMDGJBLOJJ(pb_Object, this));
			}
		}
		this.AALJGJAKCPI = hashSet.ToArray<JDAMNFAJLNB>();
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000DF93C File Offset: 0x000DDB3C
	public void GLDOMFAFFHH(pb_Object LBACHMFBPAJ, pb_Face LEBPNFGNEBI)
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.OEJGLGAFFNB(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		pb_Face item;
		if (this.AMMCILPFDJM(attachedElements.Faces, LEBPNFGNEBI, out item))
		{
			attachedElements.Faces.Remove(item);
		}
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000DF988 File Offset: 0x000DDB88
	public void CJPDLFPFKDM(pb_Object LBACHMFBPAJ, int MOHKPPLHEIP)
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.GNIBENKKLFL(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		if (attachedElements.Vertices.Contains(MOHKPPLHEIP))
		{
			attachedElements.Vertices.Remove(MOHKPPLHEIP);
		}
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
	public void ALPAMLPDNPN(pb_Object LBACHMFBPAJ, pb_Face LEBPNFGNEBI)
	{
		if (!this.m_attachedElementsMap.NKDBLFFNANL())
		{
			return;
		}
		AttachedElements attachedElements;
		if (!this.m_attachedElementsMap.GNIBENKKLFL(LBACHMFBPAJ, out attachedElements))
		{
			return;
		}
		pb_Face item;
		if (this.AMMCILPFDJM(attachedElements.Faces, LEBPNFGNEBI, out item))
		{
			attachedElements.Faces.Remove(item);
		}
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x000DFA1C File Offset: 0x000DDC1C
	public void Update()
	{
		if (!this.m_attachedElementsMap.MGECMHOBJAO())
		{
			return;
		}
		Transform transform = base.transform;
		for (int i = 0; i < this.AALJGJAKCPI.Length; i++)
		{
			JDAMNFAJLNB jdamnfajlnb = this.AALJGJAKCPI[i];
			pb_Object pb_Object = jdamnfajlnb.EJNLOKKJJBF;
			Transform transform2 = pb_Object.transform;
			int[] array = jdamnfajlnb.HAOMGOCHGIO;
			Vector3[] array2 = jdamnfajlnb.BCOJKEEKHAA;
			Mesh pdboleglmel = jdamnfajlnb.GKJEANPNOOM;
			Vector3[] array3 = jdamnfajlnb.JDCFCPMHAMA;
			for (int j = 0; j < array.Length; j++)
			{
				Vector3 position = transform.TransformPoint(array2[j]);
				Vector3 vector = transform2.InverseTransformPoint(position);
				array3[j].Set(vector.x, vector.y, vector.z);
			}
			this.JEKCJKOKHBK(pb_Object, pdboleglmel, array, array3);
		}
	}

	// Token: 0x0400030D RID: 781
	[SerializeField]
	private ObjectToAttachmentMap m_attachedElementsMap = new ObjectToAttachmentMap();

	// Token: 0x0400030E RID: 782
	private JDAMNFAJLNB[] AALJGJAKCPI = new JDAMNFAJLNB[0];
}
