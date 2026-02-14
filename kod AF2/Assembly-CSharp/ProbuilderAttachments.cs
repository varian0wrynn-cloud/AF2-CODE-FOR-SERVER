using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000080 RID: 128
public class ProbuilderAttachments : MonoBehaviour
{
	// Token: 0x06001DAA RID: 7594 RVA: 0x000E435E File Offset: 0x000E255E
	public void FAANBJLPLDO(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x000E4390 File Offset: 0x000E2590
	public void LMEJKAEIDCO()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "BipedReferences contains one or more missing Transforms.";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format2 = "\">Detected: ";
			object[] array2 = new object[0];
			array2[1] = base.name;
			Debug.LogErrorFormat(format2, array2);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.CEDEHKHJNKG(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.NCGIFIPGEOL(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.FNAHPHEILBD());
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x000E446E File Offset: 0x000E266E
	public void EGLBGKGIMIO(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x000E4494 File Offset: 0x000E2694
	public void PFNPOHMMJDN()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "inv_money";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format2 = "Lasso Left";
			object[] array2 = new object[1];
			array2[1] = base.name;
			Debug.LogErrorFormat(format2, array2);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.EJOMALDOMCE(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.BPOMBPLNIBD(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.NIGLHAIFLCJ());
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x000E446E File Offset: 0x000E266E
	public void ACHIMMILLBB(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x000E4572 File Offset: 0x000E2772
	public void OKFONGOBMCC()
	{
		this.GCEMNMJBLCD.PLDJHILNDEI();
		this.AKJOFLMMMOB.HFHBKBCBMMO();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> EHBPBHJDOKE()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000E45BC File Offset: 0x000E27BC
	public void BJHGPFGBFKF()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "_DeepTex";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			Debug.LogErrorFormat("wpn_break", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.BPOMBPLNIBD(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.KGLONDNGAHE(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.IAAILKOIHAC());
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000E446E File Offset: 0x000E266E
	public void GPPMPLBODEF(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x000E435E File Offset: 0x000E255E
	public void BACKBMNIEMA(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> LHKNMNBOGND()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> IMFAFAINNLA()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x000E446E File Offset: 0x000E266E
	public void MMFPCEIHIOM(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> HDMIJOHIKLK()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x000E446E File Offset: 0x000E266E
	public void MELADMFBDDO(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x000E46B6 File Offset: 0x000E28B6
	public void LateUpdate()
	{
		this.GCEMNMJBLCD.LNCKDDFOFJP();
		this.AKJOFLMMMOB.MKDPCOKAJKC();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x000E46E4 File Offset: 0x000E28E4
	public void IJOCHELLKJH()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "ChannelCastOmni";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format2 = "BEREG!";
			object[] array2 = new object[1];
			array2[1] = base.name;
			Debug.LogErrorFormat(format2, array2);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.GENEEBAKMPB(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.OJOLMKNNFOB(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.GOABHMBIEMK());
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x000E47C2 File Offset: 0x000E29C2
	public void EIEKEPGNGPL()
	{
		this.GCEMNMJBLCD.JIIGECDPIDH();
		this.AKJOFLMMMOB.GONINLFBMBE();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x000E435E File Offset: 0x000E255E
	public void AddAttachment(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x000E435E File Offset: 0x000E255E
	public void NLKPKDMKEAB(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> EHBAKPHGNHI()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x000E446E File Offset: 0x000E266E
	public void EAKKBEFBCIL(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> JJIHGKOHDEB()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x000E446E File Offset: 0x000E266E
	public void GEEBNHJEAMM(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> LLCEOOOFINN()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> GLFIEDAHABE()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x000E446E File Offset: 0x000E266E
	public void LEJJFOHKEPE(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> ENKIEDNPHFG()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> JFOPAFLAMHF()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> DMLJOGGIBIK()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x000E435E File Offset: 0x000E255E
	public void CKPFFDCCPKI(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x000E435E File Offset: 0x000E255E
	public void MEBLAKGNAKO(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x000E446E File Offset: 0x000E266E
	public void RemoveAttachment(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x000E435E File Offset: 0x000E255E
	public void JNDNCFNDANG(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x000E47F0 File Offset: 0x000E29F0
	public void LBBGAADLMOM()
	{
		this.GCEMNMJBLCD.EGIKCMNAAFF();
		this.AKJOFLMMMOB.FOPHFKDNEOC();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000E446E File Offset: 0x000E266E
	public void IGKGJMBJEHI(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> OCDMFKKFCBG()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000E4820 File Offset: 0x000E2A20
	public void EFJDBBDMPMC()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("error.wav", new object[]
			{
				base.name
			});
			base.enabled = true;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format = "craft/stanok";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.CBNCBEKGCMJ(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.GPJNKMPELEF(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.LDHMOBBPHLH());
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> GetAttachments()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x000E4900 File Offset: 0x000E2B00
	public void MODJFGGIAHD()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("_UserLutParams", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format = "cht_msg20";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.CFHNLEMEKLB(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.BPOMBPLNIBD(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.PGIPDFHGEOC());
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x000E446E File Offset: 0x000E266E
	public void EHHLHFDPNPD(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x000E49DE File Offset: 0x000E2BDE
	public void OOGNHIIPHBH()
	{
		this.GCEMNMJBLCD.OEOKEHCOKHK();
		this.AKJOFLMMMOB.MKDPCOKAJKC();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x000E4A0C File Offset: 0x000E2C0C
	public void OPNPODKLOJK()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "IdleReadyCrouch";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			Debug.LogErrorFormat("flowfrc", new object[]
			{
				base.name
			});
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.MBAHPICEOGK(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.AMBCKPJELJO(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.PGIPDFHGEOC());
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x000E446E File Offset: 0x000E266E
	public void MOHBNJDICLH(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> NIOOPNGFGLN()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x000E4AEA File Offset: 0x000E2CEA
	public void OGFGENJAMAM()
	{
		this.GCEMNMJBLCD.NFHOCGNBJFG();
		this.AKJOFLMMMOB.FOPHFKDNEOC();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> OPABEEBCDKL()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x000E446E File Offset: 0x000E266E
	public void NHHANDLFBBH(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x000E4B18 File Offset: 0x000E2D18
	public void CGNFLAOBEFN()
	{
		this.GCEMNMJBLCD.PEENBFJFKNM();
		this.AKJOFLMMMOB.GONINLFBMBE();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x000E435E File Offset: 0x000E255E
	public void ADFHGCBALPK(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x000E4B48 File Offset: 0x000E2D48
	public void DDEBDCGNCPC()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("{not_found}", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			Debug.LogErrorFormat("4", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.JCMFFLNFPKF(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.FFNNOJNMGCO(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.BMCKKNAIMFI());
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000E4C26 File Offset: 0x000E2E26
	public void PPIJKKNAJAC()
	{
		this.GCEMNMJBLCD.AKKAJDGEDDF();
		this.AKJOFLMMMOB.KJJHLECMIDP();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x000E435E File Offset: 0x000E255E
	public void CLHBPMNAGDL(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x000E435E File Offset: 0x000E255E
	public void CKAMKHKIMCG(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x000E4C54 File Offset: 0x000E2E54
	public void OFGMIEJKMGC()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "FactoryTempTexture";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = true;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			Debug.LogErrorFormat("_FgOverlap", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.JCMFFLNFPKF(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.JAACHGMDGPI(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.NIGLHAIFLCJ());
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> HBDFLMEFIKJ()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000E4D34 File Offset: 0x000E2F34
	public void GDIMBBBPIHI()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = "Idle Typing";
			object[] array = new object[1];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = true;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format2 = "****************  stopMusic ";
			object[] array2 = new object[0];
			array2[0] = base.name;
			Debug.LogErrorFormat(format2, array2);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.OCGOPCNIJLF(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.BFMCJKILKOI(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.DJLNMBFFHPA());
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000E4E14 File Offset: 0x000E3014
	public void FIJKDFIMELM()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("wpn_bait_vob_1", new object[]
			{
				base.name
			});
			base.enabled = true;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format = "_Params3";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.EJOMALDOMCE(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.JAACHGMDGPI(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.PGIPDFHGEOC());
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000E446E File Offset: 0x000E266E
	public void NLBAAJOCBBG(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			return;
		}
		if (this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Remove(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> NAPBONGKGFC()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x000E4EF4 File Offset: 0x000E30F4
	public void CGFDDFHECLJ()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("MotorbikeSeatStand", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format = "";
			object[] array = new object[0];
			array[0] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = true;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.GENEEBAKMPB(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.BPOMBPLNIBD(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.PGIPDFHGEOC());
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x000E4FD2 File Offset: 0x000E31D2
	public void JPGFHBACEGG()
	{
		this.GCEMNMJBLCD.IIFDHGPGHKB();
		this.AKJOFLMMMOB.PCBGGPCJCAG();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000E45A0 File Offset: 0x000E27A0
	public IEnumerable<ProbuilderAttachment> PCKKJLIONPE()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[1];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000E5000 File Offset: 0x000E3200
	public void DGGMJCMLLED()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			string format = " ";
			object[] array = new object[0];
			array[1] = base.name;
			Debug.LogErrorFormat(format, array);
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			string format2 = "Wizard Eye Beam";
			object[] array2 = new object[1];
			array2[1] = base.name;
			Debug.LogErrorFormat(format2, array2);
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.DFLKPKACILC(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.FFNNOJNMGCO(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.HGDCKCGGMJC());
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000E50DE File Offset: 0x000E32DE
	public void BHDPDDHLPOI()
	{
		this.GCEMNMJBLCD.OJOCCPLIONP();
		this.AKJOFLMMMOB.GDGHPMENGJN();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000E435E File Offset: 0x000E255E
	public void EMDCFIGBENE(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000E435E File Offset: 0x000E255E
	public void KGBPMLKICII(ProbuilderAttachment IMCJCKOKIGH)
	{
		if (this.m_attachments == null)
		{
			this.m_attachments = new List<ProbuilderAttachment>();
		}
		if (!this.m_attachments.Contains(IMCJCKOKIGH))
		{
			this.m_attachments.Add(IMCJCKOKIGH);
		}
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000E510C File Offset: 0x000E330C
	public void DBAELJBBKKF()
	{
		this.GCEMNMJBLCD.JPIKLPAICON();
		this.AKJOFLMMMOB.OLEPPCCGJKF();
		this.MKOHMBEBJFC.RefreshColors();
		this.KHGCNPDKKFJ.RecalculateBounds();
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x000E513C File Offset: 0x000E333C
	public void Start()
	{
		this.MKOHMBEBJFC = base.GetComponent<pb_Object>();
		if (this.MKOHMBEBJFC == null)
		{
			Debug.LogErrorFormat("[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.PCPKKEMDLBF = base.GetComponent<MeshFilter>();
		if (this.PCPKKEMDLBF == null)
		{
			Debug.LogErrorFormat("[Attachments] Failed to find MeshFilter on the attachments object '{0}'.", new object[]
			{
				base.name
			});
			base.enabled = false;
			return;
		}
		this.MKOHMBEBJFC.ToMesh();
		this.KHGCNPDKKFJ = this.MKOHMBEBJFC.msh;
		this.GCEMNMJBLCD.NBDIALKKHOE(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.PCPKKEMDLBF);
		this.AKJOFLMMMOB.NBDIALKKHOE(this.MKOHMBEBJFC, this.KHGCNPDKKFJ, this.GCEMNMJBLCD.GFKIEAMCOKK);
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000E469A File Offset: 0x000E289A
	public IEnumerable<ProbuilderAttachment> JEDFMKFKLLG()
	{
		if (this.m_attachments == null)
		{
			return new ProbuilderAttachment[0];
		}
		return this.m_attachments.ToArray();
	}

	// Token: 0x04000318 RID: 792
	[SerializeField]
	private List<ProbuilderAttachment> m_attachments;

	// Token: 0x04000319 RID: 793
	private pb_Object MKOHMBEBJFC;

	// Token: 0x0400031A RID: 794
	private Mesh KHGCNPDKKFJ;

	// Token: 0x0400031B RID: 795
	private MeshFilter PCPKKEMDLBF;

	// Token: 0x0400031C RID: 796
	private readonly ABOILKBGCCK GCEMNMJBLCD = new ABOILKBGCCK();

	// Token: 0x0400031D RID: 797
	private readonly INOGFBPEAKA AKJOFLMMMOB = new INOGFBPEAKA();
}
