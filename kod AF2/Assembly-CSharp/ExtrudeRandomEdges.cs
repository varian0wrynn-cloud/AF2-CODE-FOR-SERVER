using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ProBuilder2.Common;
using ProBuilder2.MeshOperations;
using UnityEngine;

// Token: 0x02000061 RID: 97
public class ExtrudeRandomEdges : MonoBehaviour
{
	// Token: 0x06001653 RID: 5715 RVA: 0x000C235C File Offset: 0x000C055C
	private void OnGUI()
	{
		if (GUILayout.Button("Extrude Random Edge", Array.Empty<GUILayoutOption>()))
		{
			this.JMGNJBFILHB();
		}
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x000C2375 File Offset: 0x000C0575
	private void KMLAENJBADF()
	{
		if (GUILayout.Button("Hidden/Post FX/FXAA", Array.Empty<GUILayoutOption>()))
		{
			this.OJIMCBICHFP();
		}
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x000C238E File Offset: 0x000C058E
	private void KBEOAOKBHEK()
	{
		if (GUILayout.Button("The shader ", Array.Empty<GUILayoutOption>()))
		{
			this.JMGNJBFILHB();
		}
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x000C23A7 File Offset: 0x000C05A7
	private void BMCKJEBCEPA()
	{
		if (GUILayout.Button("10", Array.Empty<GUILayoutOption>()))
		{
			this.OJIMCBICHFP();
		}
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x000C23C0 File Offset: 0x000C05C0
	private void JMGNJBFILHB()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, false).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.MKBCGLCMBHG)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.HJBDAEAPHPD)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.EBPICFPHCFH)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(0, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 0.5f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.JFLJFDJHEJD), null);
		a.Normalize();
		pb_Edge[] selectedEdges;
		this.MPDJOADEOKK.Extrude(new pb_Edge[]
		{
			pb_Edge
		}, 0f, false, true, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh(RefreshMask.All);
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x000C2550 File Offset: 0x000C0750
	private void OFGMIEJKMGC()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(470f, 508f, 1, 1, Axis.Left, false);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[1];
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x000C25A4 File Offset: 0x000C07A4
	private void GPEHIOFKNBN()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, false).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.PENHAMGKHPD)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.EMAFAGKHMDM)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.KPMCBPOMKMC)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(1, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 1679f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.CHGBFODBFJH), null);
		a.Normalize();
		pb_Object mpdjoadeokk = this.MPDJOADEOKK;
		pb_Edge[] array = new pb_Edge[1];
		array[1] = pb_Edge;
		pb_Edge[] selectedEdges;
		mpdjoadeokk.Extrude(array, 642f, true, false, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh((RefreshMask)(-101));
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x000C2734 File Offset: 0x000C0934
	private void CGBKGPPNMNM()
	{
		if (GUILayout.Button("_RefractionTex", Array.Empty<GUILayoutOption>()))
		{
			this.GJBJBFGINCP();
		}
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x000C2760 File Offset: 0x000C0960
	private void BKOEBMEPOOO()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, false).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.HBFCDJOHFJL)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.EOLMMPLDDDK)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.CEKEELMCDNK)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(1, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 454f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.JFLJFDJHEJD), null);
		a.Normalize();
		pb_Edge[] selectedEdges;
		this.MPDJOADEOKK.Extrude(new pb_Edge[]
		{
			pb_Edge
		}, 1455f, true, true, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh(RefreshMask.Normals | RefreshMask.Tangents | RefreshMask.Collisions);
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x000C28F0 File Offset: 0x000C0AF0
	private void BCJFDHBDAHD()
	{
		if (GUILayout.Button("CP3", Array.Empty<GUILayoutOption>()))
		{
			this.BKOEBMEPOOO();
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x000C290C File Offset: 0x000C0B0C
	private void FIJKDFIMELM()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(1577f, 753f, 0, 0, (Axis)6, false);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[1];
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x000C2960 File Offset: 0x000C0B60
	private void Start()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(1f, 1f, 0, 0, Axis.Up, false);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[0];
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x000C29B4 File Offset: 0x000C0BB4
	private void LPNDCJKAKEA()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(1840f, 1622f, 1, 1, Axis.Left, true);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[0];
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x000C2A08 File Offset: 0x000C0C08
	private void GGOKNBBPLHB()
	{
		if (GUILayout.Button("EndPhysPoint", Array.Empty<GUILayoutOption>()))
		{
			this.GJBJBFGINCP();
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x000C2A24 File Offset: 0x000C0C24
	private void ELFLOPJDAKK()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(1924f, 1797f, 0, 0, Axis.Left, false);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[0];
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x000C2A78 File Offset: 0x000C0C78
	private void EALDGLGBMOB()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, false).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.DFLFOGACAHJ)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.FLALKFGODLN)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.JGGKKPHNMJO)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(0, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 1090f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.HMGFKOGHCJF), null);
		a.Normalize();
		pb_Object mpdjoadeokk = this.MPDJOADEOKK;
		pb_Edge[] array = new pb_Edge[0];
		array[0] = pb_Edge;
		pb_Edge[] selectedEdges;
		mpdjoadeokk.Extrude(array, 889f, false, false, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh((RefreshMask)(-70));
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x000C2C08 File Offset: 0x000C0E08
	private void OJIMCBICHFP()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, true).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.EKDHENBDEEK)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.PEBINCBDHHM)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.CEKEELMCDNK)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(0, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 1531f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.EKNDANOFECF), null);
		a.Normalize();
		pb_Edge[] selectedEdges;
		this.MPDJOADEOKK.Extrude(new pb_Edge[]
		{
			pb_Edge
		}, 1657f, false, true, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh((RefreshMask)95);
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x000C2D98 File Offset: 0x000C0F98
	private void ONIHHFLOJMN()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(757f, 977f, 1, 0, Axis.Down, true);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[1];
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x000C2DEC File Offset: 0x000C0FEC
	private void JEJGFDBHABC()
	{
		if (GUILayout.Button("512", Array.Empty<GUILayoutOption>()))
		{
			this.GJBJBFGINCP();
		}
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x000C2E08 File Offset: 0x000C1008
	private void EDGALMCHPPH()
	{
		this.MPDJOADEOKK = pb_ShapeGenerator.PlaneGenerator(1275f, 6f, 1, 1, Axis.Left, false);
		this.MPDJOADEOKK.SetFaceMaterial(this.MPDJOADEOKK.faces, pb_Constant.DefaultMaterial);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces[0];
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x000C2E5C File Offset: 0x000C105C
	private void GJBJBFGINCP()
	{
		ExtrudeRandomEdges.FEHLEMGDCMG fehlemgdcmg = new ExtrudeRandomEdges.FEHLEMGDCMG();
		fehlemgdcmg.AENJLLPLILM = this;
		fehlemgdcmg.KLHAPCADLGJ = this.AMELNOJHMDK;
		List<pb_Edge> list = pb_WingedEdge.GetWingedEdges(this.MPDJOADEOKK, false).Where(new Func<pb_WingedEdge, bool>(fehlemgdcmg.HCJHAOEPCKM)).Where(new Func<pb_WingedEdge, bool>(ExtrudeRandomEdges.<>c.<>9.HKHJPKEDPGL)).Select(new Func<pb_WingedEdge, pb_Edge>(ExtrudeRandomEdges.<>c.<>9.OLNGNLIMPAH)).ToList<pb_Edge>();
		int index = UnityEngine.Random.Range(0, list.Count);
		pb_Edge pb_Edge = list[index];
		Vector3 a = (this.MPDJOADEOKK.vertices[pb_Edge.x] + this.MPDJOADEOKK.vertices[pb_Edge.y]) * 204f - fehlemgdcmg.KLHAPCADLGJ.distinctIndices.Average(new Func<int, Vector3>(fehlemgdcmg.GIGPDPJPEIP), null);
		a.Normalize();
		pb_Edge[] selectedEdges;
		this.MPDJOADEOKK.Extrude(new pb_Edge[]
		{
			pb_Edge
		}, 982f, true, false, out selectedEdges);
		this.AMELNOJHMDK = this.MPDJOADEOKK.faces.Last<pb_Face>();
		this.MPDJOADEOKK.SetSelectedEdges(selectedEdges);
		this.MPDJOADEOKK.TranslateVertices(this.MPDJOADEOKK.SelectedTriangles, a * this.distance);
		this.MPDJOADEOKK.ToMesh();
		this.MPDJOADEOKK.Refresh((RefreshMask)168);
	}

	// Token: 0x04000270 RID: 624
	private pb_Object MPDJOADEOKK;

	// Token: 0x04000271 RID: 625
	private pb_Face AMELNOJHMDK;

	// Token: 0x04000272 RID: 626
	public float distance = 1f;

	// Token: 0x02000062 RID: 98
	[CompilerGenerated]
	private sealed class FEHLEMGDCMG
	{
		// Token: 0x06001669 RID: 5737 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 ABGNEFDLGHC(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 DBAFAENNGLP(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool HBFCDJOHFJL(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 JCANBPJMEDD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool FGEOBIKKKGL(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool ONANAKDIJPC(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool OJONLCDDFON(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 GOEOFKNPEPF(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 CHGBFODBFJH(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 DLKFHKACIMC(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 KBBDDPGGNGO(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 BFIOKFEBNDE(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool MKBCGLCMBHG(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 EKNDANOFECF(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool EKDHENBDEEK(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 JCOJKEPDIEF(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 POAHLIMHFOH(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 HMGFKOGHCJF(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 JCJAHJADKEK(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 PNKPCJEHMKD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool BDPOMIKNEFD(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 AGNEAEHIIAI(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool DMONNEMLAEN(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool LMOPNCEIHMK(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool DFLFOGACAHJ(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 DHECFNHLILD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool DOECIPHHPCM(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 GIGPDPJPEIP(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 NJMBJMLMKKD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 JOGGHOCFLOD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 KECGPBHLGED(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 MDMOGOJIMAA(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool PIHAHGALHIB(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool JDGCIFLLOGP(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 KICEMCIMEJN(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool LFEGIJKPGDJ(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 JFLJFDJHEJD(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool PENHAMGKHPD(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool GKMFLAKFFJB(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool HCJHAOEPCKM(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000C2FEC File Offset: 0x000C11EC
		internal Vector3 DMICLICLJEI(int OCNGPCPMCPM)
		{
			return this.AENJLLPLILM.MPDJOADEOKK.vertices[OCNGPCPMCPM];
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool IPLNIIFJHGF(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000C3004 File Offset: 0x000C1204
		internal bool HJPDHPFFHHL(pb_WingedEdge OCNGPCPMCPM)
		{
			return OCNGPCPMCPM.face == this.KLHAPCADLGJ;
		}

		// Token: 0x04000273 RID: 627
		public pb_Face KLHAPCADLGJ;

		// Token: 0x04000274 RID: 628
		public ExtrudeRandomEdges AENJLLPLILM;
	}
}
