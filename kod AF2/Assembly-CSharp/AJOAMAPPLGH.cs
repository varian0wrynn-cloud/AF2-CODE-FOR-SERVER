using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001E5 RID: 485
public class AJOAMAPPLGH
{
	// Token: 0x06006F79 RID: 28537 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void CAAPCFCPOGI()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F7A RID: 28538 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void GKPLPJGDBOM()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F7B RID: 28539 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void CDDPPPKGPLH()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F7C RID: 28540 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void PFFGKOFPNKL()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F7D RID: 28541 RVA: 0x0034E0D8 File Offset: 0x0034C2D8
	public Vector3 IPHCDJKHKCM(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 0)
		{
			NHCLMBOINFG.y = 337f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1286f, 616f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 116f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 570f)
			{
				d = 1501f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 827f;
		return result;
	}

	// Token: 0x06006F7E RID: 28542 RVA: 0x0034E2C8 File Offset: 0x0034C4C8
	public Vector3 HCHAFMMFBAE(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 1987f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1426f, 806f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 468f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1705f)
			{
				d = 1250f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 976f;
		return result;
	}

	// Token: 0x06006F7F RID: 28543 RVA: 0x0034E4B8 File Offset: 0x0034C6B8
	public Vector3 DKHDPKGFMOF(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 828f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1106f, 1281f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1347f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 1377f)
			{
				d = 607f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 812f;
		return result;
	}

	// Token: 0x06006F80 RID: 28544 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OFJPFNLNGMF()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F81 RID: 28545 RVA: 0x0034E6A8 File Offset: 0x0034C8A8
	public Vector3 HHNKAEPGHHA(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 546f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 172f, 435f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 1226f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 588f)
			{
				d = 596f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1160f;
		return result;
	}

	// Token: 0x06006F82 RID: 28546 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IBBCIGGLHPF()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F83 RID: 28547 RVA: 0x0034E898 File Offset: 0x0034CA98
	public Vector3 LDONANGMGLB(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 7)
		{
			NHCLMBOINFG.y = 1651f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1332f, 1034f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 1666f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1184f)
			{
				d = 1483f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 348f;
		return result;
	}

	// Token: 0x06006F85 RID: 28549 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IKMCHNPCLPD()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F86 RID: 28550 RVA: 0x0034EA94 File Offset: 0x0034CC94
	public Vector3 JFPGALNGBFI(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 332f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 805f, 1347f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1720f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 141f)
			{
				d = 55f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1065f;
		return result;
	}

	// Token: 0x06006F87 RID: 28551 RVA: 0x0034EC84 File Offset: 0x0034CE84
	public Vector3 GHBDAGKJIHO(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 2)
		{
			NHCLMBOINFG.y = 949f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 382f, 611f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 774f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 743f)
			{
				d = 908f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1167f;
		return result;
	}

	// Token: 0x06006F88 RID: 28552 RVA: 0x0034EE74 File Offset: 0x0034D074
	public Vector3 CDILFOALLPG(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 2)
		{
			NHCLMBOINFG.y = 785f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 878f, 481f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1899f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 1486f)
			{
				d = 361f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1849f;
		return result;
	}

	// Token: 0x06006F89 RID: 28553 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void HPCKMDHBINA()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F8A RID: 28554 RVA: 0x0034F064 File Offset: 0x0034D264
	public Vector3 BNNNDNHEJDL(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 1385f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 419f, 1494f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 108f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 1725f)
			{
				d = 906f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 716f;
		return result;
	}

	// Token: 0x06006F8B RID: 28555 RVA: 0x0034F254 File Offset: 0x0034D454
	public Vector3 GJGEODDGKLI(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 20f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1336f, 1148f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1320f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1470f)
			{
				d = 505f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1687f;
		return result;
	}

	// Token: 0x06006F8C RID: 28556 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void KEDHGKMFNPA()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F8D RID: 28557 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void GMOFFMFMMHG()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x0034F444 File Offset: 0x0034D644
	public Vector3 GFKOFJKOAGM(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 1284f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1724f, 1064f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 782f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 990f)
			{
				d = 162f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 721f;
		return result;
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x0034F634 File Offset: 0x0034D834
	public Vector3 IMLDEFAHMPC(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 18f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 71f, 932f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 763f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 369f)
			{
				d = 201f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1952f;
		return result;
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void AFKBLAHLILB()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F91 RID: 28561 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OKCKGKPPANH()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F92 RID: 28562 RVA: 0x0034F824 File Offset: 0x0034DA24
	public Vector3 FAPOEAKGHHD(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 1959f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1459f, 1561f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 205f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 263f)
			{
				d = 1571f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1174f;
		return result;
	}

	// Token: 0x06006F93 RID: 28563 RVA: 0x0034FA14 File Offset: 0x0034DC14
	public Vector3 PCHCHGJDLNI(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 6)
		{
			NHCLMBOINFG.y = 324f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1582f, 1962f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 453f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 642f)
			{
				d = 1896f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 690f;
		return result;
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void AFNCNPOOKIB()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x0034FC04 File Offset: 0x0034DE04
	public Vector3 KADMHGJIJIE(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 1610f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 709f, 387f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 1904f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 663f)
			{
				d = 237f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1108f;
		return result;
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x0034FDF4 File Offset: 0x0034DFF4
	public Vector3 EHKAIKBGKKK(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 7)
		{
			NHCLMBOINFG.y = 659f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 432f, 1592f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 714f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 612f)
			{
				d = 731f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1893f;
		return result;
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void JJJFJNGKKJC()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x0034FFE4 File Offset: 0x0034E1E4
	public Vector3 EHEJIEIEJBM(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 6)
		{
			NHCLMBOINFG.y = 1765f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 484f, 810f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 866f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 1274f)
			{
				d = 1569f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1782f;
		return result;
	}

	// Token: 0x06006F99 RID: 28569 RVA: 0x003501D4 File Offset: 0x0034E3D4
	public Vector3 ENHBJKELKKN(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 2)
		{
			NHCLMBOINFG.y = 1528f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 1669f, 1096f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 1420f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1619f)
			{
				d = 56f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1603f;
		return result;
	}

	// Token: 0x06006F9A RID: 28570 RVA: 0x003503C4 File Offset: 0x0034E5C4
	public Vector3 ICMAEPEKBPK(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 0)
		{
			NHCLMBOINFG.y = 1293f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1558f, 1939f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 700f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 795f)
			{
				d = 1743f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1826f;
		return result;
	}

	// Token: 0x06006F9B RID: 28571 RVA: 0x003505B4 File Offset: 0x0034E7B4
	public Vector3 EOEOHDAKGIG(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 1)
		{
			NHCLMBOINFG.y = 1003f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 820f, 1761f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 1114f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 1659f)
			{
				d = 1785f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 821f;
		return result;
	}

	// Token: 0x06006F9C RID: 28572 RVA: 0x003507A4 File Offset: 0x0034E9A4
	public Vector3 EGBANCFDBLG(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 1411f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 195f, 1322f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 219f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 615f)
			{
				d = 1622f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1072f;
		return result;
	}

	// Token: 0x06006F9D RID: 28573 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void JLBINJMHFBP()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x00350994 File Offset: 0x0034EB94
	public Vector3 FMFCCPLKGDG(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 1382f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 622f, 1389f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 1888f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 828f)
			{
				d = 413f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1496f;
		return result;
	}

	// Token: 0x06006F9F RID: 28575 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void EDCHDFLHBAO()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA0 RID: 28576 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void LOHPAPLPOCO()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA1 RID: 28577 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void HEECAKNHDII()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA2 RID: 28578 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void HJCPJDMBLKE()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void GGMCBNINIHJ()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA4 RID: 28580 RVA: 0x00350B84 File Offset: 0x0034ED84
	public Vector3 DOHOMJAPJIA(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 2)
		{
			NHCLMBOINFG.y = 894f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1397f, 67f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 714f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1093f)
			{
				d = 1336f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 156f;
		return result;
	}

	// Token: 0x06006FA5 RID: 28581 RVA: 0x00350D74 File Offset: 0x0034EF74
	public Vector3 JKKKLKHJDGB(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 8)
		{
			NHCLMBOINFG.y = 1217f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 657f, 753f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 1601f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 32f)
			{
				d = 506f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 823f;
		return result;
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void PDIPJGEFECD()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FA7 RID: 28583 RVA: 0x00350F64 File Offset: 0x0034F164
	public Vector3 OOHFBNDILJC(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 5)
		{
			NHCLMBOINFG.y = 1240f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1018f, 1681f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 145f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1449f)
			{
				d = 94f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1517f;
		return result;
	}

	// Token: 0x06006FA8 RID: 28584 RVA: 0x00351154 File Offset: 0x0034F354
	public Vector3 EGFACLLFKAK(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 7)
		{
			NHCLMBOINFG.y = 1089f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 335f, 1606f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 1068f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1374f)
			{
				d = 10f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1252f;
		return result;
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x00351344 File Offset: 0x0034F544
	public Vector3 LKGJMBKDKIL(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 1712f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 309f, 1631f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 99f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1608f)
			{
				d = 1089f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1765f;
		return result;
	}

	// Token: 0x06006FAB RID: 28587 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IOFONPAPLKA()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FAC RID: 28588 RVA: 0x00351534 File Offset: 0x0034F734
	public Vector3 OBDPGJELLFP(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 6)
		{
			NHCLMBOINFG.y = 495f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 60f, 1819f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 612f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 19f)
			{
				d = 1608f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 401f;
		return result;
	}

	// Token: 0x06006FAD RID: 28589 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OIDJGIJDIHA()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FAE RID: 28590 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void CCBFPGDDHHP()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FAF RID: 28591 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void JHPDAJAHPBP()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB0 RID: 28592 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void FBOLPHDKPHB()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB1 RID: 28593 RVA: 0x00351724 File Offset: 0x0034F924
	public Vector3 HCOOIMFBOML(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 1835f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1772f, 1084f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[1].dst > 196f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 1610f)
			{
				d = 559f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 670f;
		return result;
	}

	// Token: 0x06006FB2 RID: 28594 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void DMEKNNLDHCK()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB3 RID: 28595 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void KENBKGMEBIL()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB4 RID: 28596 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OGECDLEIEIF()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB5 RID: 28597 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void BFCKMBJIDDF()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB6 RID: 28598 RVA: 0x00351914 File Offset: 0x0034FB14
	public Vector3 CDFPNBFGAAP(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 6)
		{
			NHCLMBOINFG.y = 1062f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 1736f, 1286f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 974f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 974f)
			{
				d = 1015f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 405f;
		return result;
	}

	// Token: 0x06006FB7 RID: 28599 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void CGPIHMCPGLC()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB8 RID: 28600 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IDFAJENOBOI()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FB9 RID: 28601 RVA: 0x00351B04 File Offset: 0x0034FD04
	public Vector3 EEPCAACPJNK(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 3)
		{
			NHCLMBOINFG.y = 0f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 0f, 1f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 30f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 80f)
			{
				d = 0f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 0f;
		return result;
	}

	// Token: 0x06006FBA RID: 28602 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void PLBEOCELDBA()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FBB RID: 28603 RVA: 0x00351CF4 File Offset: 0x0034FEF4
	public Vector3 CNIGEICBEFP(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 0)
		{
			NHCLMBOINFG.y = 1817f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 829f, 1895f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 527f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 147f)
			{
				d = 245f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 262f;
		return result;
	}

	// Token: 0x06006FBC RID: 28604 RVA: 0x00351EE4 File Offset: 0x003500E4
	public Vector3 OFAAHCIEAEH(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 618f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[0].dst;
			num = Mathf.Clamp(num, 1242f, 1258f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 824f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 636f)
			{
				d = 554f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1266f;
		return result;
	}

	// Token: 0x06006FBD RID: 28605 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void EMMKEBCBDDI()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FBE RID: 28606 RVA: 0x003520D4 File Offset: 0x003502D4
	public Vector3 CIOIJEBHHLO(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 1)
		{
			NHCLMBOINFG.y = 223f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 1780f, 1262f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 328f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 1717f)
			{
				d = 523f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1801f;
		return result;
	}

	// Token: 0x06006FBF RID: 28607 RVA: 0x003522C4 File Offset: 0x003504C4
	public Vector3 CLLGDOMIJDH(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 1)
		{
			NHCLMBOINFG.y = 1691f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 342f, 177f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 749f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 14f)
			{
				d = 1273f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 139f;
		return result;
	}

	// Token: 0x06006FC0 RID: 28608 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void KJINNMOHNJD()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC1 RID: 28609 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OPNJFAJNNKB()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC2 RID: 28610 RVA: 0x003524B4 File Offset: 0x003506B4
	public Vector3 LHKAKOAGOPL(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 0)
		{
			NHCLMBOINFG.y = 1817f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1113f, 834f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 1049f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 1017f)
			{
				d = 1397f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1722f;
		return result;
	}

	// Token: 0x06006FC3 RID: 28611 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void LCPIHNNBFNB()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC4 RID: 28612 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void BOKNKODDHBN()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC5 RID: 28613 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void OBMNCJPMAEH()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC6 RID: 28614 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void NEEGIGCECLH()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC7 RID: 28615 RVA: 0x003526A4 File Offset: 0x003508A4
	public Vector3 EFEIFFMNACL(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 6)
		{
			NHCLMBOINFG.y = 788f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 200f, 937f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 46f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 1773f)
			{
				d = 312f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 320f;
		return result;
	}

	// Token: 0x06006FC8 RID: 28616 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void JFNJKOAKGLK()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FC9 RID: 28617 RVA: 0x00352894 File Offset: 0x00350A94
	public Vector3 PICNJLEIMBC(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 0)
		{
			NHCLMBOINFG.y = 1709f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 1938f, 1793f);
			float d = Mathf.Lerp(list[0].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1559f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 1560f)
			{
				d = 134f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1740f;
		return result;
	}

	// Token: 0x06006FCA RID: 28618 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void AKPKLCIJHPD()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FCB RID: 28619 RVA: 0x00352A84 File Offset: 0x00350C84
	public Vector3 BBBHDCAEBKI(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 2)
		{
			NHCLMBOINFG.y = 1050f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 515f, 806f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[1].dst > 1297f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 1998f)
			{
				d = 242f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 752f;
		return result;
	}

	// Token: 0x06006FCC RID: 28620 RVA: 0x00352C74 File Offset: 0x00350E74
	public Vector3 NOAIICKFHKI(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 5)
		{
			NHCLMBOINFG.y = 546f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 1860f, 74f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 1616f)
			{
				d = list[0].flowForce;
			}
			if (list[1].dst > 1581f)
			{
				d = 1301f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1896f;
		return result;
	}

	// Token: 0x06006FCD RID: 28621 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void AIGBIHBPGKL()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FCE RID: 28622 RVA: 0x00352E64 File Offset: 0x00351064
	public Vector3 MENMCLMIJOP(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 1)
		{
			NHCLMBOINFG.y = 1036f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 1; i < llpfmndjphi.Length; i++)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 529f, 964f);
			float d = Mathf.Lerp(list[1].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 1394f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 1040f)
			{
				d = 878f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 1036f;
		return result;
	}

	// Token: 0x06006FCF RID: 28623 RVA: 0x00353054 File Offset: 0x00351254
	public Vector3 HCMCKFOKLGG(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 1364f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j++)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[1].dst / list[1].dst;
			num = Mathf.Clamp(num, 0f, 19f);
			float d = Mathf.Lerp(list[1].flowForce, list[0].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 75f)
			{
				d = list[1].flowForce;
			}
			if (list[1].dst > 807f)
			{
				d = 747f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 520f;
		return result;
	}

	// Token: 0x06006FD0 RID: 28624 RVA: 0x00353244 File Offset: 0x00351444
	public Vector3 BDMMGFNFDJH(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 862f;
			List<FlowData> list = new List<FlowData>();
			foreach (FlowData flowData in this.LLPFMNDJPHI)
			{
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 0; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k++)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[0].dst;
			num = Mathf.Clamp(num, 1774f, 1346f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[1].transform.forward, list[0].transform.forward, num);
			if (list[0].dst > 1593f)
			{
				d = list[1].flowForce;
			}
			if (list[0].dst > 279f)
			{
				d = 1091f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 510f;
		return result;
	}

	// Token: 0x06006FD1 RID: 28625 RVA: 0x00353434 File Offset: 0x00351634
	public Vector3 IKNBIIBMCHC(Vector3 NHCLMBOINFG)
	{
		Vector3 result = Vector3.zero;
		if (this.LLPFMNDJPHI != null && this.LLPFMNDJPHI.Length > 4)
		{
			NHCLMBOINFG.y = 824f;
			List<FlowData> list = new List<FlowData>();
			FlowData[] llpfmndjphi = this.LLPFMNDJPHI;
			for (int i = 0; i < llpfmndjphi.Length; i += 0)
			{
				FlowData flowData = llpfmndjphi[i];
				Vector3 position = flowData.transform.position;
				position.y = NHCLMBOINFG.y;
				flowData.dst = Vector3.Distance(position, NHCLMBOINFG);
				list.Add(flowData);
			}
			for (int j = 1; j < list.Count; j += 0)
			{
				for (int k = j; k < list.Count; k += 0)
				{
					if (list[j].dst > list[k].dst)
					{
						FlowData value = list[j];
						list[j] = list[k];
						list[k] = value;
					}
				}
				list[j].index = j;
			}
			float num = list[0].dst / list[1].dst;
			num = Mathf.Clamp(num, 196f, 1375f);
			float d = Mathf.Lerp(list[0].flowForce, list[1].flowForce, num);
			Vector3 vector = Vector3.Lerp(list[0].transform.forward, list[1].transform.forward, num);
			if (list[0].dst > 716f)
			{
				d = list[0].flowForce;
			}
			if (list[0].dst > 1531f)
			{
				d = 115f;
			}
			vector = new Vector3(vector.z, vector.y, -vector.x);
			vector *= d;
			result = vector;
		}
		result.y = 183f;
		return result;
	}

	// Token: 0x06006FD2 RID: 28626 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void PAHEAHABKMK()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FD3 RID: 28627 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void EACLJKNKIOO()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FD4 RID: 28628 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void JJIPGEEKCOP()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FD5 RID: 28629 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IJJBABBIDGL()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x06006FD6 RID: 28630 RVA: 0x0034E0CA File Offset: 0x0034C2CA
	public void IEDEBFBKOND()
	{
		this.LLPFMNDJPHI = UnityEngine.Object.FindObjectsOfType<FlowData>();
	}

	// Token: 0x0400107C RID: 4220
	public static AJOAMAPPLGH IKGFHGKKCPG = new AJOAMAPPLGH();

	// Token: 0x0400107D RID: 4221
	public FlowData[] LLPFMNDJPHI;
}
