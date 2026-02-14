using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class CsBipedBone : MonoBehaviour
{
	// Token: 0x06000C60 RID: 3168 RVA: 0x000831E8 File Offset: 0x000813E8
	private CsBiped BNOBIBJLEDI()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("_PlaneReflection");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x000832C0 File Offset: 0x000814C0
	private void PEICGDAOCEN()
	{
		this.DPDMCIIHEPA();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.CCGHJGJKCJD(base.transform);
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00083314 File Offset: 0x00081514
	private void ALLIMKBKGIC(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1819f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1759f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1917f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x00083388 File Offset: 0x00081588
	private CsBiped CHNJJPDJFDN()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("codepage");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00083460 File Offset: 0x00081660
	private void KIDHDJEBION()
	{
		this.FBDMCCLFDOF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.JFCKFNLJNGH(base.transform);
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x000834B4 File Offset: 0x000816B4
	private void BOPJAAIKJJL(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 964f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 467f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1083f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00083528 File Offset: 0x00081728
	private void IGAFELPEJJF()
	{
		this.PHMBJCAOGIF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.OHHIHJIODOC(base.transform);
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0008357C File Offset: 0x0008177C
	private void MBODLDFIDKM(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1211f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 881f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1657f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x000835F0 File Offset: 0x000817F0
	private CsBiped PDFCKENKNKB()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("MotorbikeHandlebarSit");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x000836C8 File Offset: 0x000818C8
	private void PJCNIKOFODC(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 624f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1463f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 684f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x0008373C File Offset: 0x0008193C
	private void BFDBLLEDCAM()
	{
		this.KAJEHDFLLKC();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.GEKDPMCJOJA(base.transform);
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00083790 File Offset: 0x00081990
	private void IMFEMBEJHND(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1049f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 657f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 447f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00083804 File Offset: 0x00081A04
	private void NJMLNNCAGDH()
	{
		this.PDFCKENKNKB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.KKNLCKEPKJL(base.transform);
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00083858 File Offset: 0x00081A58
	private void KOOGKIDFNOH()
	{
		this.KLMOCGLIIPG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.GFNEMKHEJMF(base.transform);
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x000838AC File Offset: 0x00081AAC
	private void HPKKJPPHLIO(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1144f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1138f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 787f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00083920 File Offset: 0x00081B20
	private void MOBLNJOPGFA()
	{
		this.FEMOPDPLABD();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.GLDBDHMAEMK(base.transform);
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00083974 File Offset: 0x00081B74
	private void ODDOGIIDPEF()
	{
		this.AONINDOPPAB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.GLDBDHMAEMK(base.transform);
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x000839C8 File Offset: 0x00081BC8
	private void EOAHBGCPKHA()
	{
		this.LDHDBMBIIPK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.MPEJNLGKPFH(base.transform);
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00083A1C File Offset: 0x00081C1C
	private void DDLLDCNGACM(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 352f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1328f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 231f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00083A90 File Offset: 0x00081C90
	private void NPLLBHEGFAK(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 83f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 957f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1973f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00083B04 File Offset: 0x00081D04
	private void LMNGJGPBAGN()
	{
		this.NABHKHABCNH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.PNLJGFLBLBI(base.transform);
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00083B58 File Offset: 0x00081D58
	private void GIAADDLHMHO()
	{
		this.FMCPJGKHAAI();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.BNHLCOPMDDO(base.transform);
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00083BAC File Offset: 0x00081DAC
	private void MMEPKEHPGNB()
	{
		this.FEMOPDPLABD();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.GLDBDHMAEMK(base.transform);
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00083C00 File Offset: 0x00081E00
	private void KNFMFKOGJPF()
	{
		this.BMNGFBLHDOA();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.MBODLDFIDKM(base.transform);
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00083C54 File Offset: 0x00081E54
	private void EIKNKCCJFPJ()
	{
		this.LDHDBMBIIPK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.COGDAMPBFHM(base.transform);
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00083CA8 File Offset: 0x00081EA8
	private void CKEMPAMKDBG()
	{
		this.GJKGOOHALEH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.DACLICJEEJA(base.transform);
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00083CFC File Offset: 0x00081EFC
	private CsBiped AONINDOPPAB()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("#FF4040");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00083DD4 File Offset: 0x00081FD4
	private void HKBNKIJJEIG()
	{
		this.KAJEHDFLLKC();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.HPKKJPPHLIO(base.transform);
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00083E28 File Offset: 0x00082028
	private void HFAJEDGJFHD()
	{
		this.FMCPJGKHAAI();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.OHHIHJIODOC(base.transform);
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00083E7C File Offset: 0x0008207C
	private CsBiped FEMOPDPLABD()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("mid");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00083F54 File Offset: 0x00082154
	private void PNLJGFLBLBI(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 390f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 437f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1660f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00083FC8 File Offset: 0x000821C8
	private void GEKDPMCJOJA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1527f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1549f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 927f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0008403C File Offset: 0x0008223C
	private void GBCFFOKKHGJ()
	{
		this.NABHKHABCNH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.PHPIIBPFBKF(base.transform);
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00084090 File Offset: 0x00082290
	private void KGLDFKEDLEH()
	{
		this.LPMLMIPGIKB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.JJCJILADCFA(base.transform);
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x000840E4 File Offset: 0x000822E4
	private void BCEGCDJHHIO()
	{
		this.CHNJJPDJFDN();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00084138 File Offset: 0x00082338
	private void OnDrawGizmosSelected()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.PNGCFOLPOFA(base.transform);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0008418C File Offset: 0x0008238C
	private void ILCANFHIPGG()
	{
		this.PHMBJCAOGIF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.LKNMOHDPNME(base.transform);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x000841E0 File Offset: 0x000823E0
	private void JBDKGHPBPHI(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 920f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1995f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1131f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00084254 File Offset: 0x00082454
	private void DINFKFKNNKF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 0.1f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 0.005f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 0.01f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000842C8 File Offset: 0x000824C8
	private CsBiped CIGIFAIFEKD()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("wpn_med2");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x000843A0 File Offset: 0x000825A0
	private CsBiped NAMFHKCNIDK()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("TAA History");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00084478 File Offset: 0x00082678
	private void EIMDEHPKDBL()
	{
		this.NHELIDLHOGE();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.MPEJNLGKPFH(base.transform);
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x000844CC File Offset: 0x000826CC
	private void BNHLCOPMDDO(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 903f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1977f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 669f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00084540 File Offset: 0x00082740
	private CsBiped KAJEHDFLLKC()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("MotorbikeBackwardStand");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00084618 File Offset: 0x00082818
	private void DACLICJEEJA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 65f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1191f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 831f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0008468C File Offset: 0x0008288C
	private void IIAAEFNNDHO()
	{
		this.FBDMCCLFDOF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.GLDBDHMAEMK(base.transform);
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x000846E0 File Offset: 0x000828E0
	private void LBHMMMKGDPJ(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 390f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 602f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 506f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00084754 File Offset: 0x00082954
	private void GNBIEJEDMOA()
	{
		this.NAMFHKCNIDK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.MJICCMPCDOH(base.transform);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x000847A8 File Offset: 0x000829A8
	private CsBiped CAGDEMALJHO()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("_BlurCoe");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00084880 File Offset: 0x00082A80
	private void MLPJJGKGNCI(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 42f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1901f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1373f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x000848F4 File Offset: 0x00082AF4
	private void CIGEIEKBNFH()
	{
		this.GNAILEIJHHG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.JFCKFNLJNGH(base.transform);
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x00084948 File Offset: 0x00082B48
	private void OIIEBIKKFJJ()
	{
		this.FBDMCCLFDOF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.DDLLDCNGACM(base.transform);
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0008499C File Offset: 0x00082B9C
	private void OnDrawGizmos()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.PNGCFOLPOFA(base.transform);
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x000849F0 File Offset: 0x00082BF0
	private void CCGHJGJKCJD(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1956f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 334f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1223f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00084A64 File Offset: 0x00082C64
	private void AGLFHCNJIEC()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00084AB8 File Offset: 0x00082CB8
	private void LKMJGBHILPF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1823f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 723f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1073f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00084B2C File Offset: 0x00082D2C
	private CsBiped FMCPJGKHAAI()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains(" (");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00084C04 File Offset: 0x00082E04
	private void MDEKDIBNDOH(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 789f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 490f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 381f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00084C78 File Offset: 0x00082E78
	private void KNLKJALEIBE(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 420f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1730f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 242f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00084CEC File Offset: 0x00082EEC
	private void GJABJPJHBID()
	{
		this.CHNJJPDJFDN();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.OHHIHJIODOC(base.transform);
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00084D40 File Offset: 0x00082F40
	private CsBiped HKMNPHOBEPL()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("Footsteps");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00084E18 File Offset: 0x00083018
	private void DCCKIKPFIFE()
	{
		this.PHMBJCAOGIF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.ELOFBNPMJIM(base.transform);
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00084E6C File Offset: 0x0008306C
	private void KKNLCKEPKJL(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1493f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1300f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 476f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00084EE0 File Offset: 0x000830E0
	private CsBiped BMNGFBLHDOA()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("Level loading error Level ID=");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00084FB8 File Offset: 0x000831B8
	private void DFMFJNDKALD()
	{
		this.IGBMCFHIIOH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.COOCCDIOPIH(base.transform);
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0008500C File Offset: 0x0008320C
	private void PHAHBMCAFEC()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.MBODLDFIDKM(base.transform);
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00085060 File Offset: 0x00083260
	private CsBiped NABHKHABCNH()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("_noinfo");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00085138 File Offset: 0x00083338
	private void NBBBCPCBDJI()
	{
		this.AONINDOPPAB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.GLDBDHMAEMK(base.transform);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x0008518C File Offset: 0x0008338C
	private void GDDNNAOKOII()
	{
		this.EBIGGCHJFCE();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x000851E0 File Offset: 0x000833E0
	private void INMFGNLDLOC()
	{
		this.FCLJBBDNPDJ();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00085234 File Offset: 0x00083434
	private void MFMNDMICDOG(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 657f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1631f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 760f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000852A8 File Offset: 0x000834A8
	private void KIGIODIICII()
	{
		this.DPDMCIIHEPA();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.JFCKFNLJNGH(base.transform);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x000852FC File Offset: 0x000834FC
	private void MMMPANGCJPH()
	{
		this.KAJEHDFLLKC();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.ALLIMKBKGIC(base.transform);
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00085350 File Offset: 0x00083550
	private void OAPIOFDCKIJ(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1675f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1880f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 211f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x000853C4 File Offset: 0x000835C4
	private void DPLNDPKJGLJ(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1988f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 241f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 784f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00085438 File Offset: 0x00083638
	private void GMOFAEPEAPB()
	{
		this.KLMOCGLIIPG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.DACLICJEEJA(base.transform);
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0008548C File Offset: 0x0008368C
	private void BIACGFJAHMB(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1073f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1441f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1641f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00085500 File Offset: 0x00083700
	private void HCJEECMNANA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 423f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 541f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1779f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00085574 File Offset: 0x00083774
	private void GBBBPNKNECE()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x000855C8 File Offset: 0x000837C8
	private void CKMLJPGOPMD(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1611f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 91f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 330f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x0008563C File Offset: 0x0008383C
	private void ICEGCCHGHHB()
	{
		this.PHMBJCAOGIF();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.HPJBBFMLHFK(base.transform);
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00085690 File Offset: 0x00083890
	private void JJCJILADCFA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1640f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 77f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 211f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00085704 File Offset: 0x00083904
	private void PAHONILDHKG(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1348f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1016f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 804f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00085778 File Offset: 0x00083978
	private void LKNMOHDPNME(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 625f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 492f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 622f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x000857FC File Offset: 0x000839FC
	private CsBiped KLMOCGLIIPG()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("FISHES");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x000858D4 File Offset: 0x00083AD4
	private void OHHIHJIODOC(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 155f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 76f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 309f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00085948 File Offset: 0x00083B48
	private void POABHAMOODL()
	{
		this.KLMOCGLIIPG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x0008599C File Offset: 0x00083B9C
	private void PHPIIBPFBKF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1898f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1859f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 276f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00085A10 File Offset: 0x00083C10
	private CsBiped GNAILEIJHHG()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("error.wav");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00085AE8 File Offset: 0x00083CE8
	private CsBiped NHELIDLHOGE()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("OfficeSittingBack");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00085BC0 File Offset: 0x00083DC0
	private void JFCKFNLJNGH(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1445f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 951f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 527f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00085C34 File Offset: 0x00083E34
	private CsBiped LPMLMIPGIKB()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("wpn_add/base");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00085D0C File Offset: 0x00083F0C
	private void AFBMAFCFIDC()
	{
		this.KAJEHDFLLKC();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.BOPJAAIKJJL(base.transform);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00085D60 File Offset: 0x00083F60
	private void PNKKCODGPAM(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1319f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 104f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 261f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00085DD4 File Offset: 0x00083FD4
	private CsBiped LIBHHHNNJHE()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("Last Bone Hit: ");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00085EAC File Offset: 0x000840AC
	private CsBiped FBDMCCLFDOF()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("_Cull");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00085F84 File Offset: 0x00084184
	private void BDDLNPHBHGC()
	{
		this.KLMOCGLIIPG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.MJICCMPCDOH(base.transform);
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00085FD8 File Offset: 0x000841D8
	private void LCGBDHOCKOC(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1798f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 234f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 314f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0008604C File Offset: 0x0008424C
	private void FOBIDICLLBN(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 297f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 281f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1078f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x000860C0 File Offset: 0x000842C0
	private void ELOFBNPMJIM(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 659f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 782f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1041f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00086134 File Offset: 0x00084334
	private void GCDDCLFPHMP()
	{
		this.CIGIFAIFEKD();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.COGDAMPBFHM(base.transform);
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00086188 File Offset: 0x00084388
	private void CKGIGCABKAM()
	{
		this.LIBHHHNNJHE();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.PNGCFOLPOFA(base.transform);
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x000861DC File Offset: 0x000843DC
	private void PBLDPNLMLHP()
	{
		this.CAGDEMALJHO();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.CCGHJGJKCJD(base.transform);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00086230 File Offset: 0x00084430
	private void OMPKODENPAO()
	{
		this.GJKGOOHALEH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.DACLICJEEJA(base.transform);
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00086284 File Offset: 0x00084484
	private void OFBMKECONJC(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 402f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 183f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 36f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x000862F8 File Offset: 0x000844F8
	private CsBiped GJKGOOHALEH()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("auk_wavg");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x000863D0 File Offset: 0x000845D0
	private void CBMCMPKMMAE()
	{
		this.CIGIFAIFEKD();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.MPEJNLGKPFH(base.transform);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00086424 File Offset: 0x00084624
	private void AMLPPBCOEKO()
	{
		this.NHELIDLHOGE();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.LKNMOHDPNME(base.transform);
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00086478 File Offset: 0x00084678
	private void COOCCDIOPIH(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1338f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1183f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 881f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x000864EC File Offset: 0x000846EC
	private void GFNEMKHEJMF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1111f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1987f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 290f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00086560 File Offset: 0x00084760
	private void FJBPFIMOOAG()
	{
		this.LDHDBMBIIPK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.CCGHJGJKCJD(base.transform);
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x000865B4 File Offset: 0x000847B4
	private void EKPKKJCNPMF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 385f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 272f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1196f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00086628 File Offset: 0x00084828
	private void HHFIIPINJNN(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1223f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1236f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1806f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0008669C File Offset: 0x0008489C
	private CsBiped FCLJBBDNPDJ()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00086774 File Offset: 0x00084974
	private void HMFHDPLPLJO()
	{
		this.PDFCKENKNKB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.BOPJAAIKJJL(base.transform);
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x000867C8 File Offset: 0x000849C8
	private void AOFMFPFDNLA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1859f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1012f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1876f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0008683C File Offset: 0x00084A3C
	private void PPJLHNFCMFJ()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.COOCCDIOPIH(base.transform);
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00086890 File Offset: 0x00084A90
	private CsBiped PHMBJCAOGIF()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("money");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00086968 File Offset: 0x00084B68
	private void ILCKMDBHACN()
	{
		this.EBIGGCHJFCE();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.PNGCFOLPOFA(base.transform);
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x000869BC File Offset: 0x00084BBC
	private CsBiped DPDMCIIHEPA()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains("");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00086A94 File Offset: 0x00084C94
	private void GLDBDHMAEMK(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 776f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 326f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1251f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00086B08 File Offset: 0x00084D08
	private void PEOOBHKCMEM()
	{
		this.KLMOCGLIIPG();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.LBHMMMKGDPJ(base.transform);
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00086B5C File Offset: 0x00084D5C
	private CsBiped LDHDBMBIIPK()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("SoccerKeeperReady");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00086C34 File Offset: 0x00084E34
	private CsBiped EBIGGCHJFCE()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("MotorbikeShootLeft");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x00086D0C File Offset: 0x00084F0C
	private CsBiped BMNIKHFMMJE()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("<color='#20a000'> Требований нет </color>");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00086DE4 File Offset: 0x00084FE4
	private void GOHLIDJIDPL(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1670f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 997f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1111f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00086E58 File Offset: 0x00085058
	private CsBiped PPMNLCIDPEL()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("wpn_med2");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = true;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00086F30 File Offset: 0x00085130
	private void GLIDLNKBMKA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1966f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1707f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1663f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00086FA4 File Offset: 0x000851A4
	private void MPEJNLGKPFH(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 362f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1985f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 578f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00087018 File Offset: 0x00085218
	private void MJICCMPCDOH(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1058f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 81f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1614f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0008708C File Offset: 0x0008528C
	private void CMKNBBBALBF(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 8f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1884f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 245f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00087100 File Offset: 0x00085300
	private void HPJBBFMLHFK(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 1778f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 138f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 188f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00087174 File Offset: 0x00085374
	private void COGDAMPBFHM(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 105f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 1241f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 367f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x000871E8 File Offset: 0x000853E8
	private void PNGCFOLPOFA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 0.1f)
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 0.005f);
			}
			else
			{
				Gizmos.DrawSphere(FBKEODHEMMH.position, 0.01f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0008725C File Offset: 0x0008545C
	private void PCLFLGAODPO()
	{
		this.NAMFHKCNIDK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.BOPJAAIKJJL(base.transform);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x000872B0 File Offset: 0x000854B0
	private void GBOEGCOKJFA(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 782f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1030f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 417f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00087324 File Offset: 0x00085524
	private void MGEJGKDLGFK()
	{
		this.HKMNPHOBEPL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.MPEJNLGKPFH(base.transform);
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00087378 File Offset: 0x00085578
	private CsBiped IGBMCFHIIOH()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = !base.gameObject.name.Contains("<color='#001000'>+{0} {1}</color>");
		this.containBip = false;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00087450 File Offset: 0x00085650
	private void KDEBKFLEEBI()
	{
		this.NAMFHKCNIDK();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.GFNEMKHEJMF(base.transform);
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x000874A4 File Offset: 0x000856A4
	private CsBiped JNNOFJFJJOI()
	{
		if (this.biped != null)
		{
			return this.biped;
		}
		this.biped = base.transform.root.GetComponent<CsBiped>();
		this.drawLine = base.gameObject.name.Contains(" ");
		this.containBip = true;
		foreach (string value in this.biped.boneNamePrefix)
		{
			if (!string.IsNullOrEmpty(value) && base.transform.parent.gameObject.name.Contains(value))
			{
				this.containBip = false;
				break;
			}
		}
		return this.biped;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0008757C File Offset: 0x0008577C
	private void MKMABPFOLFL()
	{
		this.IGBMCFHIIOH();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.HPJBBFMLHFK(base.transform);
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x000875D0 File Offset: 0x000857D0
	private void CIPMHLPNFCP(Transform FBKEODHEMMH)
	{
		if (this.containBip)
		{
			if (Vector3.Distance(FBKEODHEMMH.position, FBKEODHEMMH.parent.position) < 677f)
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 192f);
			}
			else
			{
				Gizmos.DrawWireSphere(FBKEODHEMMH.position, 1301f);
			}
			if (this.drawLine)
			{
				Gizmos.DrawLine(FBKEODHEMMH.position, FBKEODHEMMH.parent.position);
			}
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00087644 File Offset: 0x00085844
	private void AKIPPMEEGML()
	{
		this.PDFCKENKNKB();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.JJCJILADCFA(base.transform);
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00087698 File Offset: 0x00085898
	private void ANNKCCOCLLE()
	{
		this.PPMNLCIDPEL();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorSelected;
		this.DPLNDPKJGLJ(base.transform);
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x000876EC File Offset: 0x000858EC
	private void PBLFEHDLGIH()
	{
		this.KAJEHDFLLKC();
		if (!this.biped)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (!this.biped.showBones)
		{
			return;
		}
		Gizmos.color = this.biped.colorBone;
		this.MJICCMPCDOH(base.transform);
	}

	// Token: 0x0400016E RID: 366
	public CsBiped biped;

	// Token: 0x0400016F RID: 367
	public bool drawLine = true;

	// Token: 0x04000170 RID: 368
	public bool containBip;
}
