using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000077 RID: 119
[AddComponentMenu("Camera-Control/SmoothCameraAdvanced")]
internal class SmoothCameraAdvanced : MonoBehaviour
{
	// Token: 0x06001C2C RID: 7212 RVA: 0x000DD5F8 File Offset: 0x000DB7F8
	private static Transform DMHMLMJLFMO()
	{
		if (SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF == null)
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF = SmoothCameraAdvanced.ELOBJGIDGCP.transform;
			SmoothCameraAdvanced.GMCELGIFACP.BPEDGDMPMEI().Add(SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF);
		}
		return SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF;
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000DD650 File Offset: 0x000DB850
	private void KENNPEPIMCP()
	{
		Vector3 vector = this.target.TransformPoint(SmoothCameraAdvanced.ICLGAGPEKCK().BJNDMOLGJNA(), this.height.OMDAIAGCNKF(), -this.distance.KCHLJMBAKGN());
		if (vector != SmoothCameraAdvanced.GPFKFLMBDLJ().position)
		{
			vector = SmoothCameraAdvanced.GMCELGIFACP.NAKEKHPHNHB(this.target, SmoothCameraAdvanced.DMHMLMJLFMO(), vector, Time.deltaTime * this.damping);
			switch (this.translationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = vector;
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = Vector3.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = Vector3.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			}
			Vector3 a = this.target.TransformPoint(this.lookAtOffset + SmoothCameraAdvanced.CEMHNBIOHDE);
			Quaternion b = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
			switch (this.rotationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.DMHMLMJLFMO().rotation = Quaternion.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000DD807 File Offset: 0x000DBA07
	public static void BJLEDKCOECB(CameraBumper DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.bumper = DCCPCBLODIG;
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x000DD814 File Offset: 0x000DBA14
	public static LimitedFloat JPFJJBAIPPN()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.distance;
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x000DD820 File Offset: 0x000DBA20
	public static void LJNLLCBDEDO(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.distance = DCCPCBLODIG;
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x000DD8E5 File Offset: 0x000DBAE5
	public static void NEBJHGDGANI(SmoothCameraAdvanced.CAMJAPNCGEN DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.translationType = DCCPCBLODIG;
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000DD8F2 File Offset: 0x000DBAF2
	public static float GPLICOOLMGA()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.damping;
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x000DD8FE File Offset: 0x000DBAFE
	public static void IJNJGADLEIP(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.height = DCCPCBLODIG;
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000DD90B File Offset: 0x000DBB0B
	private void Awake()
	{
		if (this.target)
		{
			SmoothCameraAdvanced.FocusOn(this.target);
		}
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x000DD928 File Offset: 0x000DBB28
	private void Reset()
	{
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.Distance, LFAPENNFNPF.ScrollWheel, 2f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.Height, LFAPENNFNPF.ScrollWheel, 1f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.PanY, LFAPENNFNPF.ScrollWheel, 0.5f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.PanX, KeyCode.LeftArrow, -1f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.PanX, KeyCode.RightArrow, 1f));
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000DD9AC File Offset: 0x000DBBAC
	public static SmoothCameraAdvanced ELOBJGIDGCP
	{
		get
		{
			if (SmoothCameraAdvanced.COIPKPKLDAH == null)
			{
				SmoothCameraAdvanced.COIPKPKLDAH = (UnityEngine.Object.FindObjectOfType(typeof(SmoothCameraAdvanced)) as SmoothCameraAdvanced);
			}
			if (SmoothCameraAdvanced.COIPKPKLDAH == null && Camera.main != null)
			{
				SmoothCameraAdvanced.COIPKPKLDAH = (Camera.main.gameObject.AddComponent(typeof(SmoothCameraAdvanced)) as SmoothCameraAdvanced);
			}
			return SmoothCameraAdvanced.COIPKPKLDAH;
		}
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x000DDA21 File Offset: 0x000DBC21
	public static LimitedFloat BFGHMFFOKLB()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.panY;
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x000DDA30 File Offset: 0x000DBC30
	private void CMOHCNCEAJL()
	{
		Vector3 vector = this.target.TransformPoint(SmoothCameraAdvanced.DEECAPHOELM.LHMOFMNHPIO(), this.height.KCHLJMBAKGN(), -this.distance.Current);
		if (vector != SmoothCameraAdvanced.AKHOFPAJIBJ.position)
		{
			vector = SmoothCameraAdvanced.GMCELGIFACP.NEDNAPLHEOF(this.target, SmoothCameraAdvanced.DMHMLMJLFMO(), vector, Time.deltaTime * this.damping);
			switch (this.translationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = vector;
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = Vector3.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = Vector3.Slerp(SmoothCameraAdvanced.DMHMLMJLFMO().position, vector, Time.deltaTime * this.damping);
				break;
			}
			Vector3 a = this.target.TransformPoint(this.lookAtOffset + SmoothCameraAdvanced.CEMHNBIOHDE);
			Quaternion b = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
			switch (this.rotationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.DMHMLMJLFMO().rotation = Quaternion.LookRotation(a - SmoothCameraAdvanced.DMHMLMJLFMO().position, this.target.up);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.Slerp(SmoothCameraAdvanced.GPFKFLMBDLJ().rotation, b, Time.deltaTime * this.rotationDamping);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000DE2B6 File Offset: 0x000DC4B6
	// (set) Token: 0x06001C3A RID: 7226 RVA: 0x000DD8E5 File Offset: 0x000DBAE5
	public static SmoothCameraAdvanced.CAMJAPNCGEN JLGFEIIGOCC
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.translationType;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.translationType = value;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000DDBE7 File Offset: 0x000DBDE7
	// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000DD807 File Offset: 0x000DBA07
	public static CameraBumper GMCELGIFACP
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.bumper;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.bumper = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06001C7C RID: 7292 RVA: 0x000DDA21 File Offset: 0x000DBC21
	// (set) Token: 0x06001C3C RID: 7228 RVA: 0x000DDBF3 File Offset: 0x000DBDF3
	public static LimitedFloat MBEJIMHHDAJ
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.panY;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.panY = value;
		}
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x000DDC00 File Offset: 0x000DBE00
	private void FPMOCDEEHMF()
	{
		Vector3 vector = this.target.TransformPoint(SmoothCameraAdvanced.DEECAPHOELM.Current, this.height.Current, -this.distance.Current);
		if (vector != SmoothCameraAdvanced.AKHOFPAJIBJ.position)
		{
			vector = SmoothCameraAdvanced.GMCELGIFACP.FKNOHDLGPJM(this.target, SmoothCameraAdvanced.AKHOFPAJIBJ, vector, Time.deltaTime * this.damping);
			switch (this.translationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = vector;
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = Vector3.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = Vector3.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			}
			Vector3 a = this.target.TransformPoint(this.lookAtOffset + SmoothCameraAdvanced.CEMHNBIOHDE);
			Quaternion b = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
			switch (this.rotationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.AKHOFPAJIBJ.rotation = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.rotation = Quaternion.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.rotation = Quaternion.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x000DDDB8 File Offset: 0x000DBFB8
	private void OJEGOPDKEON()
	{
		foreach (CameraControl cameraControl in this.controls)
		{
			if (cameraControl.Value != 0f)
			{
				switch (cameraControl.Target)
				{
				case FBEDLMPJFHA.Height:
					SmoothCameraAdvanced.MIIKJAPBLKL = LimitedFloat.PICCFFHAMAG(SmoothCameraAdvanced.MIIKJAPBLKL, cameraControl.Value);
					break;
				case FBEDLMPJFHA.Distance:
					SmoothCameraAdvanced.BDOCPGDMBCM = LimitedFloat.PICCFFHAMAG(SmoothCameraAdvanced.BDOCPGDMBCM, cameraControl.Value);
					break;
				case FBEDLMPJFHA.PanX:
					SmoothCameraAdvanced.DEECAPHOELM = LimitedFloat.PICCFFHAMAG(SmoothCameraAdvanced.DEECAPHOELM, cameraControl.Value);
					break;
				case FBEDLMPJFHA.PanY:
					SmoothCameraAdvanced.MBEJIMHHDAJ = LimitedFloat.PICCFFHAMAG(SmoothCameraAdvanced.MBEJIMHHDAJ, cameraControl.Value);
					break;
				}
			}
		}
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x000DD8FE File Offset: 0x000DBAFE
	public static void MBEONPBKJHB(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.height = DCCPCBLODIG;
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x000DDE90 File Offset: 0x000DC090
	private void MPOJCOOIMJF()
	{
		Vector3 vector = this.target.TransformPoint(SmoothCameraAdvanced.ICLGAGPEKCK().KCHLJMBAKGN(), this.height.FMCJBLHPHBP(), -this.distance.DLOLDDMKADB());
		if (vector != SmoothCameraAdvanced.AKHOFPAJIBJ.position)
		{
			vector = SmoothCameraAdvanced.GMCELGIFACP.NAKEKHPHNHB(this.target, SmoothCameraAdvanced.GPFKFLMBDLJ(), vector, Time.deltaTime * this.damping);
			switch (this.translationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = vector;
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = Vector3.Lerp(SmoothCameraAdvanced.GPFKFLMBDLJ().position, vector, Time.deltaTime * this.damping);
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.AKHOFPAJIBJ.position = Vector3.Slerp(SmoothCameraAdvanced.DMHMLMJLFMO().position, vector, Time.deltaTime * this.damping);
				break;
			}
			Vector3 a = this.target.TransformPoint(this.lookAtOffset + SmoothCameraAdvanced.CEMHNBIOHDE);
			Quaternion b = Quaternion.LookRotation(a - SmoothCameraAdvanced.GPFKFLMBDLJ().position, this.target.up);
			switch (this.rotationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.LookRotation(a - SmoothCameraAdvanced.GPFKFLMBDLJ().position, this.target.up);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.DMHMLMJLFMO().rotation = Quaternion.Lerp(SmoothCameraAdvanced.GPFKFLMBDLJ().rotation, b, Time.deltaTime * this.rotationDamping);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x000DE048 File Offset: 0x000DC248
	public static void FocusOn(Transform GKJPGJAOHAC)
	{
		SmoothCameraAdvanced.HHCIFHIPEAC = GKJPGJAOHAC;
		SmoothCameraAdvanced.AKHOFPAJIBJ.parent = SmoothCameraAdvanced.HHCIFHIPEAC;
		PropsUnityObject propsUnityObject = SmoothCameraAdvanced.HHCIFHIPEAC.GetComponent(typeof(PropsUnityObject)) as PropsUnityObject;
		if (propsUnityObject)
		{
			float y = propsUnityObject.DHGAIBFAJNE.bounds.size.y;
			SmoothCameraAdvanced.PHJOJLDGLJM = Vector3.up * y;
			SmoothCameraAdvanced.MIIKJAPBLKL.Current = y + 0.5f;
			SmoothCameraAdvanced.BDOCPGDMBCM.Current = y + 1f;
			SmoothCameraAdvanced.MBEJIMHHDAJ.Current = 0f;
			SmoothCameraAdvanced.DEECAPHOELM.Current = 0f;
		}
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x000DE0F5 File Offset: 0x000DC2F5
	public static Transform PCKCHCMHMOE()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.target;
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x000DE101 File Offset: 0x000DC301
	private void ENJFBODNKHO()
	{
		if (this.target)
		{
			SmoothCameraAdvanced.HHKNOHKDDDF(this.target);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000DD814 File Offset: 0x000DBA14
	// (set) Token: 0x06001C74 RID: 7284 RVA: 0x000DD820 File Offset: 0x000DBA20
	public static LimitedFloat BDOCPGDMBCM
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.distance;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.distance = value;
		}
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x000DD8FE File Offset: 0x000DBAFE
	public static void PJFILOIGJIM(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.height = DCCPCBLODIG;
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x000DE11C File Offset: 0x000DC31C
	private void ICIFMFIGOKJ()
	{
		SmoothCameraAdvanced.PPFGILKLEBO().Add(new CameraControl(FBEDLMPJFHA.Height, LFAPENNFNPF.ScrollWheel, 1278f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.Height, LFAPENNFNPF.None, 1529f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl(FBEDLMPJFHA.Height, LFAPENNFNPF.None, 1970f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl((FBEDLMPJFHA)5, (KeyCode)142, 381f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl((FBEDLMPJFHA)7, (KeyCode)141, 1590f));
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x000DD807 File Offset: 0x000DBA07
	public static void IDDGOAGAHOL(CameraBumper DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.bumper = DCCPCBLODIG;
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000DE2AA File Offset: 0x000DC4AA
	// (set) Token: 0x06001C49 RID: 7241 RVA: 0x000DE19F File Offset: 0x000DC39F
	public static Vector3 PHJOJLDGLJM
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.lookAtOffset;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.lookAtOffset = value;
		}
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x000DE1AC File Offset: 0x000DC3AC
	private void MAKLDNJKDAG()
	{
		foreach (CameraControl cameraControl in this.controls)
		{
			if (cameraControl.AAIMAIAMKOF() != 726f)
			{
				switch (cameraControl.Target)
				{
				case FBEDLMPJFHA.Height:
					SmoothCameraAdvanced.IJNJGADLEIP(LimitedFloat.OPAFEKPDFIF(SmoothCameraAdvanced.DGGKPINKELC(), cameraControl.LLFOKJFHMMN()));
					break;
				case FBEDLMPJFHA.Distance:
					SmoothCameraAdvanced.BDOCPGDMBCM = LimitedFloat.PICCFFHAMAG(SmoothCameraAdvanced.HEJJGHEPPHB(), cameraControl.PPGECJMLFIG());
					break;
				case FBEDLMPJFHA.PanX:
					SmoothCameraAdvanced.DEECAPHOELM = LimitedFloat.KKMPCBKOOCD(SmoothCameraAdvanced.DEECAPHOELM, cameraControl.LOLHFFLIPAO());
					break;
				case FBEDLMPJFHA.PanY:
					SmoothCameraAdvanced.MBEJIMHHDAJ = LimitedFloat.PEEJGBCHHJF(SmoothCameraAdvanced.MBEJIMHHDAJ, cameraControl.Value);
					break;
				}
			}
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000DE284 File Offset: 0x000DC484
	// (set) Token: 0x06001C6D RID: 7277 RVA: 0x000DE65A File Offset: 0x000DC85A
	private static SmoothCameraAdvanced.CAMJAPNCGEN GBIAEKEKFJD
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.rotationType;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.rotationType = value;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06001C55 RID: 7253 RVA: 0x000DD8F2 File Offset: 0x000DBAF2
	// (set) Token: 0x06001C4C RID: 7244 RVA: 0x000DE290 File Offset: 0x000DC490
	public static float DBHBCJOKHBE
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.damping;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.damping = value;
		}
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x000DE29D File Offset: 0x000DC49D
	public static void CDAELEHNCBJ(float DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping = DCCPCBLODIG;
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x000DE29D File Offset: 0x000DC49D
	public static void KHGGFIGDOKB(float DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping = DCCPCBLODIG;
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x000DE29D File Offset: 0x000DC49D
	public static void LGDOOGLFPJI(float DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping = DCCPCBLODIG;
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000DE36D File Offset: 0x000DC56D
	// (set) Token: 0x06001C52 RID: 7250 RVA: 0x000DE2C2 File Offset: 0x000DC4C2
	public static List<CameraControl> JNDKEICHPIL
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.controls;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.controls = value;
		}
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x000DE2D0 File Offset: 0x000DC4D0
	private void NHPMLPGKKGD()
	{
		SmoothCameraAdvanced.BHLONABLFAN().Add(new CameraControl(FBEDLMPJFHA.Distance, LFAPENNFNPF.None, 1346f));
		SmoothCameraAdvanced.BHLONABLFAN().Add(new CameraControl(FBEDLMPJFHA.Distance, LFAPENNFNPF.ScrollWheel, 254f));
		SmoothCameraAdvanced.BHLONABLFAN().Add(new CameraControl((FBEDLMPJFHA)6, LFAPENNFNPF.ScrollWheel, 510f));
		SmoothCameraAdvanced.BHLONABLFAN().Add(new CameraControl(FBEDLMPJFHA.Pivot, KeyCode.Backspace, 1368f));
		SmoothCameraAdvanced.JNDKEICHPIL.Add(new CameraControl((FBEDLMPJFHA)8, (KeyCode)80, 16f));
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x000DE353 File Offset: 0x000DC553
	public void KJJBBLDJHPD()
	{
		this.OJEGOPDKEON();
		this.KENNPEPIMCP();
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x000DE2B6 File Offset: 0x000DC4B6
	public static SmoothCameraAdvanced.CAMJAPNCGEN MJCDKLLMOKF()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.translationType;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x000DE361 File Offset: 0x000DC561
	public static LimitedFloat DGGKPINKELC()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.height;
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x000DD8E5 File Offset: 0x000DBAE5
	public static void DIJKLEOBFJG(SmoothCameraAdvanced.CAMJAPNCGEN DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.translationType = DCCPCBLODIG;
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x000DE36D File Offset: 0x000DC56D
	public static List<CameraControl> PPFGILKLEBO()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.controls;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x000DD807 File Offset: 0x000DBA07
	public static void NMLCHJGNPCA(CameraBumper DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.bumper = DCCPCBLODIG;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x000DE37C File Offset: 0x000DC57C
	private void MPCGJFJFHBH()
	{
		Vector3 vector = this.target.TransformPoint(SmoothCameraAdvanced.ICLGAGPEKCK().NKIKBNHIIKO(), this.height.OMCDHLDNEPH(), -this.distance.DLOLDDMKADB());
		if (vector != SmoothCameraAdvanced.GPFKFLMBDLJ().position)
		{
			vector = SmoothCameraAdvanced.GMCELGIFACP.JEKBKNGHFDP(this.target, SmoothCameraAdvanced.AKHOFPAJIBJ, vector, Time.deltaTime * this.damping);
			switch (this.translationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.GPFKFLMBDLJ().position = vector;
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.DMHMLMJLFMO().position = Vector3.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.position, vector, Time.deltaTime * this.damping);
				break;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.DMHMLMJLFMO().position = Vector3.Slerp(SmoothCameraAdvanced.GPFKFLMBDLJ().position, vector, Time.deltaTime * this.damping);
				break;
			}
			Vector3 a = this.target.TransformPoint(this.lookAtOffset + SmoothCameraAdvanced.CEMHNBIOHDE);
			Quaternion b = Quaternion.LookRotation(a - SmoothCameraAdvanced.AKHOFPAJIBJ.position, this.target.up);
			switch (this.rotationType)
			{
			case SmoothCameraAdvanced.CAMJAPNCGEN.Instant:
				SmoothCameraAdvanced.AKHOFPAJIBJ.rotation = Quaternion.LookRotation(a - SmoothCameraAdvanced.DMHMLMJLFMO().position, this.target.up);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.LinearInterpolation:
				SmoothCameraAdvanced.DMHMLMJLFMO().rotation = Quaternion.Lerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				return;
			case SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation:
				SmoothCameraAdvanced.GPFKFLMBDLJ().rotation = Quaternion.Slerp(SmoothCameraAdvanced.AKHOFPAJIBJ.rotation, b, Time.deltaTime * this.rotationDamping);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x000DD820 File Offset: 0x000DBA20
	public static void EEBMPDMBKJC(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.distance = DCCPCBLODIG;
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x000DE284 File Offset: 0x000DC484
	private static SmoothCameraAdvanced.CAMJAPNCGEN PDFBLOHEPOB()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.rotationType;
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x000DD8F2 File Offset: 0x000DBAF2
	public static float FOBGBCNGLIJ()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.damping;
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x000DE534 File Offset: 0x000DC734
	private static Transform GPFKFLMBDLJ()
	{
		if (SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF == null)
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF = SmoothCameraAdvanced.ELOBJGIDGCP.transform;
			SmoothCameraAdvanced.GMCELGIFACP.BPEDGDMPMEI().Add(SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF);
		}
		return SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF;
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x000DE361 File Offset: 0x000DC561
	public static LimitedFloat BCAPHJFLKIE()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.height;
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x000DD820 File Offset: 0x000DBA20
	public static void BABJCHBDGFL(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.distance = DCCPCBLODIG;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x000DD814 File Offset: 0x000DBA14
	public static LimitedFloat HEJJGHEPPHB()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.distance;
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x000DE290 File Offset: 0x000DC490
	public static void LLJCNPBCAOJ(float DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.damping = DCCPCBLODIG;
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x000DE101 File Offset: 0x000DC301
	private void CEBAOOAIADJ()
	{
		if (this.target)
		{
			SmoothCameraAdvanced.HHKNOHKDDDF(this.target);
		}
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x000DE58C File Offset: 0x000DC78C
	public static void ResetPosition()
	{
		float y = (SmoothCameraAdvanced.HHCIFHIPEAC.GetComponent(typeof(PropsUnityObject)) as PropsUnityObject).DHGAIBFAJNE.bounds.size.y;
		SmoothCameraAdvanced.PHJOJLDGLJM = Vector3.up * y;
		SmoothCameraAdvanced.DEECAPHOELM.Current = 0f;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x000DD8FE File Offset: 0x000DBAFE
	public static void CHGLEHCMKLO(LimitedFloat DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.height = DCCPCBLODIG;
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000DE5EC File Offset: 0x000DC7EC
	private static Transform AKHOFPAJIBJ
	{
		get
		{
			if (SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF == null)
			{
				SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF = SmoothCameraAdvanced.ELOBJGIDGCP.transform;
				SmoothCameraAdvanced.GMCELGIFACP.Ignores.Add(SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF);
			}
			return SmoothCameraAdvanced.ELOBJGIDGCP.HLGLOOFNJOF;
		}
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x000DE0F5 File Offset: 0x000DC2F5
	public static Transform PEKNIMNHGGK()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.target;
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x000DE642 File Offset: 0x000DC842
	public static LimitedFloat ICLGAGPEKCK()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.panX;
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x000DE64E File Offset: 0x000DC84E
	public static float EIPACONANIK()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping;
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x000DE19F File Offset: 0x000DC39F
	public static void JGIGDMMBAJL(Vector3 DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.lookAtOffset = DCCPCBLODIG;
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x000DDA21 File Offset: 0x000DBC21
	public static LimitedFloat ABHOOGKIDJN()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.panY;
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x000DE36D File Offset: 0x000DC56D
	public static List<CameraControl> BHLONABLFAN()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.controls;
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x000DE668 File Offset: 0x000DC868
	private void NNPBGGHAGKH()
	{
		foreach (CameraControl cameraControl in this.controls)
		{
			if (cameraControl.MCPDPADJING() != 1917f)
			{
				switch (cameraControl.BIAFGEHMAPO())
				{
				case FBEDLMPJFHA.Height:
					SmoothCameraAdvanced.IJNJGADLEIP(LimitedFloat.OPAFEKPDFIF(SmoothCameraAdvanced.BCAPHJFLKIE(), cameraControl.FLNGOIKPDII()));
					break;
				case FBEDLMPJFHA.Distance:
					SmoothCameraAdvanced.BDOCPGDMBCM = LimitedFloat.GGEEKDPOOHM(SmoothCameraAdvanced.BDOCPGDMBCM, cameraControl.BCHAHKFENMO());
					break;
				case FBEDLMPJFHA.PanX:
					SmoothCameraAdvanced.DEECAPHOELM = LimitedFloat.OPAFEKPDFIF(SmoothCameraAdvanced.ICLGAGPEKCK(), cameraControl.BCHAHKFENMO());
					break;
				case FBEDLMPJFHA.PanY:
					SmoothCameraAdvanced.MBEJIMHHDAJ = LimitedFloat.OENOGMKEKPA(SmoothCameraAdvanced.BFGHMFFOKLB(), cameraControl.CLFFOPLPOCD());
					break;
				}
			}
		}
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x000DE740 File Offset: 0x000DC940
	public static void HHKNOHKDDDF(Transform GKJPGJAOHAC)
	{
		SmoothCameraAdvanced.HHCIFHIPEAC = GKJPGJAOHAC;
		SmoothCameraAdvanced.DMHMLMJLFMO().parent = SmoothCameraAdvanced.PEKNIMNHGGK();
		PropsUnityObject propsUnityObject = SmoothCameraAdvanced.PEKNIMNHGGK().GetComponent(typeof(PropsUnityObject)) as PropsUnityObject;
		if (propsUnityObject)
		{
			float y = propsUnityObject.DHGAIBFAJNE.bounds.size.y;
			SmoothCameraAdvanced.PHJOJLDGLJM = Vector3.up * y;
			SmoothCameraAdvanced.DGGKPINKELC().Current = y + 1129f;
			SmoothCameraAdvanced.BDOCPGDMBCM.ABFCDENEGME(y + 76f);
			SmoothCameraAdvanced.BFGHMFFOKLB().DOOMDGLAGCN(1817f);
			SmoothCameraAdvanced.DEECAPHOELM.KKFALBIOOJJ(463f);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000DE361 File Offset: 0x000DC561
	// (set) Token: 0x06001C73 RID: 7283 RVA: 0x000DD8FE File Offset: 0x000DBAFE
	public static LimitedFloat MIIKJAPBLKL
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.height;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.height = value;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06001C77 RID: 7287 RVA: 0x000DE64E File Offset: 0x000DC84E
	// (set) Token: 0x06001C75 RID: 7285 RVA: 0x000DE29D File Offset: 0x000DC49D
	public static float PGENLOPAFDC
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping = value;
		}
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x000DE284 File Offset: 0x000DC484
	private static SmoothCameraAdvanced.CAMJAPNCGEN KMFMDIMEJAB()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.rotationType;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06001C78 RID: 7288 RVA: 0x000DE642 File Offset: 0x000DC842
	// (set) Token: 0x06001C82 RID: 7298 RVA: 0x000DE85F File Offset: 0x000DCA5F
	public static LimitedFloat DEECAPHOELM
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.panX;
		}
		set
		{
			SmoothCameraAdvanced.ELOBJGIDGCP.panX = value;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06001C79 RID: 7289 RVA: 0x000DE7ED File Offset: 0x000DC9ED
	// (set) Token: 0x06001C7D RID: 7293 RVA: 0x000DE84D File Offset: 0x000DCA4D
	private static Vector3 CEMHNBIOHDE
	{
		get
		{
			return new Vector3(SmoothCameraAdvanced.DEECAPHOELM.Current, SmoothCameraAdvanced.MBEJIMHHDAJ.Current, 0f);
		}
		set
		{
			SmoothCameraAdvanced.DEECAPHOELM.Current = value.x;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06001C7E RID: 7294 RVA: 0x000DE0F5 File Offset: 0x000DC2F5
	// (set) Token: 0x06001C7B RID: 7291 RVA: 0x000DE80D File Offset: 0x000DCA0D
	public static Transform HHCIFHIPEAC
	{
		get
		{
			return SmoothCameraAdvanced.ELOBJGIDGCP.target;
		}
		set
		{
			SmoothCameraAdvanced.GMCELGIFACP.Ignores.Remove(SmoothCameraAdvanced.ELOBJGIDGCP.target);
			SmoothCameraAdvanced.ELOBJGIDGCP.target = value;
			SmoothCameraAdvanced.GMCELGIFACP.Ignores.Add(SmoothCameraAdvanced.ELOBJGIDGCP.target);
		}
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x000DE290 File Offset: 0x000DC490
	public static void AIAFNADFHGO(float DCCPCBLODIG)
	{
		SmoothCameraAdvanced.ELOBJGIDGCP.damping = DCCPCBLODIG;
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x000DD814 File Offset: 0x000DBA14
	public static LimitedFloat DCHCAKKPFOK()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.distance;
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x000DE64E File Offset: 0x000DC84E
	public static float KFAEPOLIDDF()
	{
		return SmoothCameraAdvanced.ELOBJGIDGCP.rotationDamping;
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x000DE86C File Offset: 0x000DCA6C
	public void Update()
	{
		this.OJEGOPDKEON();
		this.FPMOCDEEHMF();
	}

	// Token: 0x040002F5 RID: 757
	private static SmoothCameraAdvanced COIPKPKLDAH;

	// Token: 0x040002F6 RID: 758
	private Transform HLGLOOFNJOF;

	// Token: 0x040002F7 RID: 759
	[SerializeField]
	private Transform target;

	// Token: 0x040002F8 RID: 760
	[SerializeField]
	public CameraBumper bumper;

	// Token: 0x040002F9 RID: 761
	[SerializeField]
	private List<CameraControl> controls = new List<CameraControl>();

	// Token: 0x040002FA RID: 762
	[SerializeField]
	private Vector3 lookAtOffset;

	// Token: 0x040002FB RID: 763
	private Vector3 MFNJMMAOGBP = Vector3.zero;

	// Token: 0x040002FC RID: 764
	[SerializeField]
	private SmoothCameraAdvanced.CAMJAPNCGEN rotationType = SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation;

	// Token: 0x040002FD RID: 765
	[SerializeField]
	private SmoothCameraAdvanced.CAMJAPNCGEN translationType = SmoothCameraAdvanced.CAMJAPNCGEN.SphericalLinearInterpolation;

	// Token: 0x040002FE RID: 766
	[SerializeField]
	private LimitedFloat distance = new LimitedFloat(3f, 1f, 10f);

	// Token: 0x040002FF RID: 767
	[SerializeField]
	private LimitedFloat height = new LimitedFloat(1f, 1f, 5f);

	// Token: 0x04000300 RID: 768
	[SerializeField]
	private LimitedFloat panX = new LimitedFloat(0f, -1f, 1f);

	// Token: 0x04000301 RID: 769
	[SerializeField]
	private LimitedFloat panY = new LimitedFloat(0f, 0f, 2f);

	// Token: 0x04000302 RID: 770
	[SerializeField]
	private float damping = 5f;

	// Token: 0x04000303 RID: 771
	[SerializeField]
	private float rotationDamping = 10f;

	// Token: 0x02000078 RID: 120
	public enum CAMJAPNCGEN
	{
		// Token: 0x04000305 RID: 773
		Instant,
		// Token: 0x04000306 RID: 774
		LinearInterpolation,
		// Token: 0x04000307 RID: 775
		SphericalLinearInterpolation
	}
}
