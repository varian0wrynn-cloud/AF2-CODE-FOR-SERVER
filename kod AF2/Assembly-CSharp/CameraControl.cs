using System;
using UnityEngine;

// Token: 0x02000070 RID: 112
[Serializable]
public class CameraControl
{
	// Token: 0x06001A05 RID: 6661 RVA: 0x000D939B File Offset: 0x000D759B
	public void BJDANJCBNEH(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void LHHFEHEMGDB(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void KGFMLOFNCMK(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode HCLOJICPKJE()
	{
		return this.keyCode;
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF FLEMDKAOHAK()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void NFENDJIPOLD(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x000D939B File Offset: 0x000D759B
	public void HODONBDCNBO(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF KLCMDLCGGCH()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode JHAMADDNFHN()
	{
		return this.keyCode;
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode CBCEEBOJDBP()
	{
		return this.keyCode;
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool JHGIKCHAAAL()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode PLLMEFIDMGP()
	{
		return this.keyCode;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool PLMOEHMJLCH()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA BIAFGEHMAPO()
	{
		return this.target;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode PDKNHOCLHAA()
	{
		return this.keyCode;
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void KALHBAGOEOP(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA IGAGNKNCCFF()
	{
		return this.target;
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x000D939B File Offset: 0x000D759B
	public void AOJLFPHCIMP(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x000D939B File Offset: 0x000D759B
	public void IJNPCPCNOIE(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float GAFBAHBIECD()
	{
		return this.stepSize;
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x000D939B File Offset: 0x000D759B
	public void KMBKANMPAPI(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void OOIAJCJGCMN(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF JJFBAHLALLJ()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x000D93EC File Offset: 0x000D75EC
	public float LOLHFFLIPAO()
	{
		float num = 807f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("Toggle") * this.GGNIMFEDEKI() * 68f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("Sound #") * this.FDPKPFBPDFF() * 394f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("-U") * this.HPNFCJPMHKM() * 1374f * Time.deltaTime;
			break;
		}
		if (num == 274f && this.PLMOEHMJLCH())
		{
			num = this.HPNFCJPMHKM() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void CBNGCKCPCPC(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF HNGOOKECEJE()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode DDOOGGALLOJ()
	{
		return this.keyCode;
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void PKMBNLABHOG(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x000D949C File Offset: 0x000D769C
	public float BCHAHKFENMO()
	{
		float num = 788f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("distscale") * this.DCKFACFMPPK() * 228f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("http://j.mp/1FRAL5L") * this.HOIEFACINAI() * 1212f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("{0}") * this.ACIENAKPMPO() * 1037f * Time.deltaTime;
			break;
		}
		if (num == 1862f && this.NIBJDCOOKIB())
		{
			num = this.HOIEFACINAI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF LFOCAAIMDMO()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool GIKJHOPOMDF()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void HJNPNGOCGLJ(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void NPHGHFNMAIL(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float DDHBIFACNFL()
	{
		return this.stepSize;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool DDKLPKEEEOJ()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF OBMLKDGHIOL()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF MPIIBODPJLJ()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float JNBPKIIFEKC()
	{
		return this.stepSize;
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool IsPressed
	{
		get
		{
			return Input.GetKey(this.keyCode);
		}
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA PEDEOCMIFCH()
	{
		return this.target;
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x000D9549 File Offset: 0x000D7749
	public CameraControl(FBEDLMPJFHA GKJPGJAOHAC, LFAPENNFNPF HBODPOMMIMH, float NEDMJHJGMIF)
	{
		this.target = GKJPGJAOHAC;
		this.mouseCode = HBODPOMMIMH;
		this.stepSize = NEDMJHJGMIF;
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA BCMEFLOOGDA()
	{
		return this.target;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF LENFEBFHKHC()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void LBEMLMIMGCI(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void GPKMDGMOFKP(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x000D9578 File Offset: 0x000D7778
	public CameraControl()
	{
		this.stepSize = 1f;
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void NMCFKKOMMGK(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF GNBCOBDNGGM()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x000D95A0 File Offset: 0x000D77A0
	public float PPGECJMLFIG()
	{
		float num = 1609f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.ScrollWheel:
			num = -Input.GetAxis("INTERFACE") * this.CHKOOMEBPNO() * 242f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("{0} FPS") * this.HOIEFACINAI() * 1762f * Time.deltaTime;
			break;
		case LFAPENNFNPF.Y:
			num = Input.GetAxis("Open turnir info window") * this.HPNFCJPMHKM() * 1893f * Time.deltaTime;
			break;
		}
		if (num == 915f && this.DDKLPKEEEOJ())
		{
			num = this.ACIENAKPMPO() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode FAELJGLKLPG()
	{
		return this.keyCode;
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF DNKIFNAKCIE()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x000D964D File Offset: 0x000D784D
	public CameraControl(FBEDLMPJFHA GKJPGJAOHAC, KeyCode AKLBBNHMLEO, LFAPENNFNPF HBODPOMMIMH, float NEDMJHJGMIF)
	{
		this.target = GKJPGJAOHAC;
		this.keyCode = AKLBBNHMLEO;
		this.mouseCode = HBODPOMMIMH;
		this.stepSize = NEDMJHJGMIF;
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void MBPNKIFMFOL(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x000D939B File Offset: 0x000D759B
	public void MLMMJMBEJPE(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void PCBKKJDKKGG(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x000D9684 File Offset: 0x000D7884
	public CameraControl(FBEDLMPJFHA GKJPGJAOHAC, KeyCode AKLBBNHMLEO, float NEDMJHJGMIF)
	{
		this.target = GKJPGJAOHAC;
		this.keyCode = AKLBBNHMLEO;
		this.stepSize = NEDMJHJGMIF;
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF HLMCEMDODOL()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void FDBBOKENBEA(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA IKFNPHEJPEJ()
	{
		return this.target;
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool NIBJDCOOKIB()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void KENCMPKPEFH(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void PGNBJKMGFLG(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void KAMBBLEFNKH(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF EABJBBDGMAA()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x000D96B4 File Offset: 0x000D78B4
	public float KHLJAINKEIE()
	{
		float num = 40f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.ScrollWheel:
			num = -Input.GetAxis("tintColor") * this.ELNDMAHLONI() * 1202f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("Button") * this.ACIENAKPMPO() * 3f * Time.deltaTime;
			break;
		case LFAPENNFNPF.Y:
			num = Input.GetAxis("1HandHeavySwing2") * this.GAFBAHBIECD() * 1248f * Time.deltaTime;
			break;
		}
		if (num == 1111f && this.NIBJDCOOKIB())
		{
			num = this.ELNDMAHLONI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF MGBECFIFDHK()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x000D9764 File Offset: 0x000D7964
	public float CLFFOPLPOCD()
	{
		float num = 856f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("error: mainAsset is null") * this.JNBPKIIFEKC() * 58f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("IK Effector contains a null reference.") * this.ACIENAKPMPO() * 732f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("Sound ") * this.DCKFACFMPPK() * 1996f * Time.deltaTime;
			break;
		}
		if (num == 1703f && this.DDKLPKEEEOJ())
		{
			num = this.ACIENAKPMPO() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF CCCJAMABKCK()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x000D939B File Offset: 0x000D759B
	public void MAFOCDFDBBA(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF MCOIHGEFKMF()
	{
		return this.mouseCode;
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06001A4B RID: 6731 RVA: 0x000D93BE File Offset: 0x000D75BE
	// (set) Token: 0x06001A74 RID: 6772 RVA: 0x000D93AD File Offset: 0x000D75AD
	public LFAPENNFNPF MouseCode
	{
		get
		{
			return this.mouseCode;
		}
		set
		{
			this.mouseCode = value;
		}
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float BHBMLPGNJJE()
	{
		return this.stepSize;
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000D93E4 File Offset: 0x000D75E4
	// (set) Token: 0x06001A4D RID: 6733 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public float StepSize
	{
		get
		{
			return this.stepSize;
		}
		set
		{
			this.stepSize = value;
		}
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x000D9814 File Offset: 0x000D7A14
	public float LLFOKJFHMMN()
	{
		float num = 302f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("usetime") * this.GGNIMFEDEKI() * 1963f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("SUNSHINE_FILTER_PCF_3x3") * this.FDPKPFBPDFF() * 870f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("_LerpAmount") * this.CHKOOMEBPNO() * 1856f * Time.deltaTime;
			break;
		}
		if (num == 505f && this.KILAJFMBMHB())
		{
			num = this.GGNIMFEDEKI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x000D939B File Offset: 0x000D759B
	public void OACKAALNLAJ(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode JLNPEEKHMCD()
	{
		return this.keyCode;
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF DMGLKNAHDEC()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF LAHLLLNKFPP()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void KGDLKEHAOEP(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void NCDCHLLNHPA(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode CBNEHOGHFBK()
	{
		return this.keyCode;
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF NAGMHECINJP()
	{
		return this.mouseCode;
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000D93D3 File Offset: 0x000D75D3
	// (set) Token: 0x06001A5C RID: 6748 RVA: 0x000D93DB File Offset: 0x000D75DB
	public FBEDLMPJFHA Target
	{
		get
		{
			return this.target;
		}
		set
		{
			this.target = value;
		}
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF EAFPJAIKPOK()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode DHMFKMOGIDO()
	{
		return this.keyCode;
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool KILAJFMBMHB()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool NPMKOFGMJPC()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode PKGMGEJPIHC()
	{
		return this.keyCode;
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void OOADJCEMJCB(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x000D98C4 File Offset: 0x000D7AC4
	public float FLNGOIKPDII()
	{
		float num = 571f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.ScrollWheel:
			num = -Input.GetAxis("MotorbikeBackwardSittingCheer") * this.BFICGIHDICN() * 1119f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("/") * this.GGNIMFEDEKI() * 63f * Time.deltaTime;
			break;
		case LFAPENNFNPF.Y:
			num = Input.GetAxis("INTERFACE") * this.ELNDMAHLONI() * 1738f * Time.deltaTime;
			break;
		}
		if (num == 107f && this.KILAJFMBMHB())
		{
			num = this.FDPKPFBPDFF() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06001A61 RID: 6753 RVA: 0x000D93B6 File Offset: 0x000D75B6
	// (set) Token: 0x06001A67 RID: 6759 RVA: 0x000D939B File Offset: 0x000D759B
	public KeyCode KeyCode
	{
		get
		{
			return this.keyCode;
		}
		set
		{
			this.keyCode = value;
		}
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void CCAEFEEJONP(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode CBLPFGHCBNF()
	{
		return this.keyCode;
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF HBIPFDGFDMM()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x000D939B File Offset: 0x000D759B
	public void MMKNKNPFMCG(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode MEPCOEDDGIG()
	{
		return this.keyCode;
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void EEKHCKMIJGB(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x000D9974 File Offset: 0x000D7B74
	public float AAIMAIAMKOF()
	{
		float num = 1514f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("_Intensity") * this.ELNDMAHLONI() * 1458f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("vp") * this.StepSize * 1579f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("_InvScreenSize") * this.DDHBIFACNFL() * 15f * Time.deltaTime;
			break;
		}
		if (num == 18f && this.JHGIKCHAAAL())
		{
			num = this.StepSize * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x000D93C6 File Offset: 0x000D75C6
	public bool MBLPFAGFOLA()
	{
		return Input.GetKey(this.keyCode);
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void GIHGJGKCOAM(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float HOIEFACINAI()
	{
		return this.stepSize;
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public FBEDLMPJFHA HDLMGMADHDP()
	{
		return this.target;
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF GOHEFFFDJGB()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void KJGNFDPDPCF(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void BDAGGDCKFHF(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x000D9A24 File Offset: 0x000D7C24
	public float CHIAOBMDHFP()
	{
		float num = 436f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.ScrollWheel:
			num = -Input.GetAxis("id") * this.HPNFCJPMHKM() * 1366f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("WeaponRun") * this.StepSize * 1801f * Time.deltaTime;
			break;
		case LFAPENNFNPF.Y:
			num = Input.GetAxis("Giant2HandSlamIdle") * this.DDHBIFACNFL() * 1543f * Time.deltaTime;
			break;
		}
		if (num == 687f && this.GIKJHOPOMDF())
		{
			num = this.HOIEFACINAI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void NHBPOCAEDGG(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void JHEGONOPMJL(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x000D9AD4 File Offset: 0x000D7CD4
	public float MCPDPADJING()
	{
		float num = 1817f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("X2") * this.GGNIMFEDEKI() * 226f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("name") * this.DDHBIFACNFL() * 496f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("ingredients") * this.StepSize * 920f * Time.deltaTime;
			break;
		}
		if (num == 337f && this.GIKJHOPOMDF())
		{
			num = this.JNBPKIIFEKC() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void KFFBJHMOPLB(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float GGNIMFEDEKI()
	{
		return this.stepSize;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float HPNFCJPMHKM()
	{
		return this.stepSize;
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode NFCHNLEBMKJ()
	{
		return this.keyCode;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void DAMEIIAILCK(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void FAELCACMKKO(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06001A7C RID: 6780 RVA: 0x000D9B84 File Offset: 0x000D7D84
	public float Value
	{
		get
		{
			float num = 0f;
			switch (this.mouseCode)
			{
			case LFAPENNFNPF.ScrollWheel:
				num = -Input.GetAxis("Mouse ScrollWheel") * this.StepSize * 100f * Time.deltaTime;
				break;
			case LFAPENNFNPF.X:
				num = Input.GetAxis("Mouse X") * this.StepSize * 100f * Time.deltaTime;
				break;
			case LFAPENNFNPF.Y:
				num = Input.GetAxis("Mouse Y") * this.StepSize * 100f * Time.deltaTime;
				break;
			}
			if (num == 0f && this.IsPressed)
			{
				num = this.StepSize * Time.deltaTime;
			}
			return num;
		}
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float DCKFACFMPPK()
	{
		return this.stepSize;
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float ELNDMAHLONI()
	{
		return this.stepSize;
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x000D939B File Offset: 0x000D759B
	public void EPLGALOOFJB(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x000D9C34 File Offset: 0x000D7E34
	public float GGEIEINCBOG()
	{
		float num = 1049f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("auk stavka result: ") * this.GGNIMFEDEKI() * 629f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("SoccerRun") * this.HPNFCJPMHKM() * 1800f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("") * this.ACIENAKPMPO() * 603f * Time.deltaTime;
			break;
		}
		if (num == 13f && this.JHGIKCHAAAL())
		{
			num = this.GGNIMFEDEKI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void JEIMLLIAJPE(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x000D939B File Offset: 0x000D759B
	public void IEAGJJHLNDM(KeyCode DCCPCBLODIG)
	{
		this.keyCode = DCCPCBLODIG;
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void JIKCLGHAELL(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode BAIOCMHGHFF()
	{
		return this.keyCode;
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float BFICGIHDICN()
	{
		return this.stepSize;
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void GABDBDFJHCM(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void NMLKOPLBNKJ(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x000D93AD File Offset: 0x000D75AD
	public void AAKGLDEPAKO(LFAPENNFNPF DCCPCBLODIG)
	{
		this.mouseCode = DCCPCBLODIG;
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float CHKOOMEBPNO()
	{
		return this.stepSize;
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float FDPKPFBPDFF()
	{
		return this.stepSize;
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x000D93DB File Offset: 0x000D75DB
	public void FHDFKKJNMNB(FBEDLMPJFHA DCCPCBLODIG)
	{
		this.target = DCCPCBLODIG;
	}

	// Token: 0x06001A8C RID: 6796 RVA: 0x000D93BE File Offset: 0x000D75BE
	public LFAPENNFNPF KGPJIKFKBFF()
	{
		return this.mouseCode;
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void LCOBCAIMLOD(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x000D9CE4 File Offset: 0x000D7EE4
	public float HFNKPDECIEL()
	{
		float num = 1058f;
		switch (this.mouseCode)
		{
		case LFAPENNFNPF.None:
			num = -Input.GetAxis("drag_onmousedown.wav") * this.GAFBAHBIECD() * 602f * Time.deltaTime;
			break;
		case LFAPENNFNPF.ScrollWheel:
			num = Input.GetAxis("iOS") * this.GGNIMFEDEKI() * 167f * Time.deltaTime;
			break;
		case LFAPENNFNPF.X:
			num = Input.GetAxis("bs_lev") * this.StepSize * 479f * Time.deltaTime;
			break;
		}
		if (num == 951f && this.JHGIKCHAAAL())
		{
			num = this.HOIEFACINAI() * Time.deltaTime;
		}
		return num;
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x000D93E4 File Offset: 0x000D75E4
	public float ACIENAKPMPO()
	{
		return this.stepSize;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x000D93B6 File Offset: 0x000D75B6
	public KeyCode BOIFBDEGJLA()
	{
		return this.keyCode;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void OGPAFFCAMEB(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x000D93A4 File Offset: 0x000D75A4
	public void OIEFDMILJOK(float DCCPCBLODIG)
	{
		this.stepSize = DCCPCBLODIG;
	}

	// Token: 0x040002D1 RID: 721
	[SerializeField]
	private FBEDLMPJFHA target = FBEDLMPJFHA.Distance;

	// Token: 0x040002D2 RID: 722
	[SerializeField]
	private float stepSize = 1f;

	// Token: 0x040002D3 RID: 723
	[SerializeField]
	private LFAPENNFNPF mouseCode;

	// Token: 0x040002D4 RID: 724
	[SerializeField]
	private KeyCode keyCode;
}
