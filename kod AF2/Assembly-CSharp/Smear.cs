using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200001E RID: 30
public class Smear : MonoBehaviour
{
	// Token: 0x0600052D RID: 1325 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material JNKBONHHPJA()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0003E660 File Offset: 0x0003C860
	private void AIKJPMIHCFP()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.DDFNCJEHOJH().SetVector("chnam4", this.JDIIOOCNNGD.Dequeue());
		}
		this.JLBIHJNMOGI().SetVector("Error", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
	private void BHDPDDHLPOI()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.JNKBONHHPJA().SetVector("name", this.JDIIOOCNNGD.Dequeue());
		}
		this.OOMFOADOBGM().SetVector("Demo 2 scene: move with WASD. Advance to find the rotating sign which will make the fog disappear.", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0003E750 File Offset: 0x0003C950
	private void CMDJHGMGLCG()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.GJONJNLGOIG().SetVector("OneHandSwordReady", this.JDIIOOCNNGD.Dequeue());
		}
		this.GJONJNLGOIG().SetVector("cht_msg11", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void OKMHKMMNKGN(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0003E7D0 File Offset: 0x0003C9D0
	private void LateUpdate()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.ELICDKJLPME.SetVector("_PrevPosition", this.JDIIOOCNNGD.Dequeue());
		}
		this.ELICDKJLPME.SetVector("_Position", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0003E848 File Offset: 0x0003CA48
	private void LHFBEKCIKOI()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.OOMFOADOBGM().SetVector(" ", this.JDIIOOCNNGD.Dequeue());
		}
		this.DDFNCJEHOJH().SetVector("Sound #", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material JLBIHJNMOGI()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void PAPABKBJCHK(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
	private void PMIFCKJAFEB()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.JLBIHJNMOGI().SetVector("uint: ", this.JDIIOOCNNGD.Dequeue());
		}
		this.EMKMLFIFKLL().SetVector("_RgbTex", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000538 RID: 1336 RVA: 0x0003E642 File Offset: 0x0003C842
	// (set) Token: 0x0600054E RID: 1358 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private Material ELICDKJLPME
	{
		get
		{
			return this.KBHMCFFNJNG;
		}
		set
		{
			this.KBHMCFFNJNG = value;
		}
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0003E938 File Offset: 0x0003CB38
	private void HHJKBKLPLIM()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.DDFNCJEHOJH().SetVector("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition", this.JDIIOOCNNGD.Dequeue());
		}
		this.DDFNCJEHOJH().SetVector("<color='#6080ff'>", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void EKOGICPJGDC(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0003E9AE File Offset: 0x0003CBAE
	private void CAJLCEPLKJG()
	{
		this.ELICDKJLPME = this.Renderer.material;
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material GJONJNLGOIG()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void NCHOMEKEGAM(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0003E9C4 File Offset: 0x0003CBC4
	private void MJBLHNGLFOE()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.AKLPNHGLIFC().SetVector("_FogOfWarCenterAdjusted", this.JDIIOOCNNGD.Dequeue());
		}
		this.AKLPNHGLIFC().SetVector("readSadok error ", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void KHBAHPBOIOE(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0003EA3A File Offset: 0x0003CC3A
	private void PMDPLLIBJAF()
	{
		this.IIBLKNGEDHL(this.Renderer.material);
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0003E9AE File Offset: 0x0003CBAE
	private void Start()
	{
		this.ELICDKJLPME = this.Renderer.material;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material AKLPNHGLIFC()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0003EA3A File Offset: 0x0003CC3A
	private void MCHAAIIHOKD()
	{
		this.IIBLKNGEDHL(this.Renderer.material);
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0003EA4D File Offset: 0x0003CC4D
	private void DGEIACONKCJ()
	{
		this.HILHPFMDCMJ(this.Renderer.material);
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0003EA4D File Offset: 0x0003CC4D
	private void EHFPLKEINFO()
	{
		this.HILHPFMDCMJ(this.Renderer.material);
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void BCGGBLAFHDF(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material EMNHGAMFKNC()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material DDFNCJEHOJH()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void MOPKFOJNLHJ(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material OOMFOADOBGM()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material EMKMLFIFKLL()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0003EA60 File Offset: 0x0003CC60
	private void CFHDJOKLHDB()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.GJONJNLGOIG().SetVector("Player", this.JDIIOOCNNGD.Dequeue());
		}
		this.EMNHGAMFKNC().SetVector("IdleMeditate", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0003EAD8 File Offset: 0x0003CCD8
	private void GHIJFOALMHM()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.EMKMLFIFKLL().SetVector("foot", this.JDIIOOCNNGD.Dequeue());
		}
		this.EMKMLFIFKLL().SetVector("isPaint", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0003EA4D File Offset: 0x0003CC4D
	private void INDGOHJGCFN()
	{
		this.HILHPFMDCMJ(this.Renderer.material);
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0003E642 File Offset: 0x0003C842
	private Material LFNKLKGFABK()
	{
		return this.KBHMCFFNJNG;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void IIBLKNGEDHL(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0003EB50 File Offset: 0x0003CD50
	private void BJILHFNDDKC()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.GJONJNLGOIG().SetVector("Light reference not set.", this.JDIIOOCNNGD.Dequeue());
		}
		this.OOMFOADOBGM().SetVector("_Offsets", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
	private void PIEDGJCBCBO()
	{
		if (this.JDIIOOCNNGD.Count > this.FramesBufferSize)
		{
			this.DDFNCJEHOJH().SetVector("effects", this.JDIIOOCNNGD.Dequeue());
		}
		this.AKLPNHGLIFC().SetVector("gi_fridgiceno", base.transform.position);
		this.JDIIOOCNNGD.Enqueue(base.transform.position);
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void CJHMAEGFHLB(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0003EC3E File Offset: 0x0003CE3E
	private void MKNPFMEMOJO()
	{
		this.PAPABKBJCHK(this.Renderer.material);
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0003E7C6 File Offset: 0x0003C9C6
	private void HILHPFMDCMJ(Material DCCPCBLODIG)
	{
		this.KBHMCFFNJNG = DCCPCBLODIG;
	}

	// Token: 0x040000DF RID: 223
	private Queue<Vector3> JDIIOOCNNGD = new Queue<Vector3>();

	// Token: 0x040000E0 RID: 224
	public int FramesBufferSize;

	// Token: 0x040000E1 RID: 225
	public Renderer Renderer;

	// Token: 0x040000E2 RID: 226
	private Material KBHMCFFNJNG;
}
