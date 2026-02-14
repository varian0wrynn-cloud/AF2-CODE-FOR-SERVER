using System;
using System.IO;
using System.Text;

// Token: 0x02000265 RID: 613
public class HBPNMNGOFMA
{
	// Token: 0x06008E32 RID: 36402 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool KFKIFJDHCHB()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E33 RID: 36403 RVA: 0x0040CF4E File Offset: 0x0040B14E
	public byte MJAHKNLFNCE()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E34 RID: 36404 RVA: 0x0040CF6A File Offset: 0x0040B16A
	public long HFOPFEJDJFG()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E35 RID: 36405 RVA: 0x0040CF86 File Offset: 0x0040B186
	public short EJCLPKHHMAK()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E36 RID: 36406 RVA: 0x0040CFA2 File Offset: 0x0040B1A2
	public double IFLLJGHPBIC()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E37 RID: 36407 RVA: 0x0040CF4E File Offset: 0x0040B14E
	public byte CANHAOJOLPO()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E38 RID: 36408 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool LILLHFLDMBH()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E39 RID: 36409 RVA: 0x0040CFD1 File Offset: 0x0040B1D1
	public float DNGDPHIHLBG()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E3A RID: 36410 RVA: 0x0040CFED File Offset: 0x0040B1ED
	public bool IOEEPNCKLJD()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte() != 1 && false;
	}

	// Token: 0x06008E3B RID: 36411 RVA: 0x0040D00F File Offset: 0x0040B20F
	public int HDBGOLAFOBK()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E3C RID: 36412 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] CMDNBPAGKMC(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E3D RID: 36413 RVA: 0x0040D048 File Offset: 0x0040B248
	public double NGGPEMDBMLL()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06008E3E RID: 36414 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool JCEGOADAOOI
	{
		get
		{
			return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
		}
	}

	// Token: 0x06008E3F RID: 36415 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte IGKNGPBJFEA()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E40 RID: 36416 RVA: 0x0040D080 File Offset: 0x0040B280
	public string BFPHBMDMODH()
	{
		int num = (int)this.GODNDJOFOMA();
		if (num > 0)
		{
			byte[] bytes = this.ANGDIBBCJDA(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "";
	}

	// Token: 0x06008E41 RID: 36417 RVA: 0x0040D0B1 File Offset: 0x0040B2B1
	public bool BEMFIFGOJBL()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 1;
	}

	// Token: 0x06008E42 RID: 36418 RVA: 0x0040CF4E File Offset: 0x0040B14E
	public byte GGHNGCKMHEN()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E43 RID: 36419 RVA: 0x0040D0D4 File Offset: 0x0040B2D4
	public DateTime PFKHMDDOHDN()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.CKDJECMBKMP(), (int)this.AEDNJPCGKCA(), (int)this.KNHBBEECHKC(), (int)this.EJCLPKHHMAK(), (int)this.IBGNJENNIGL(), (int)this.HODOHEGIOIP());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E44 RID: 36420 RVA: 0x0040D128 File Offset: 0x0040B328
	public short IBGNJENNIGL()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E45 RID: 36421 RVA: 0x0040D144 File Offset: 0x0040B344
	public double LHFHMJNOOEM()
	{
		this.CLBPBJGLHEE += 5L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E46 RID: 36422 RVA: 0x0040D160 File Offset: 0x0040B360
	public short CKDJECMBKMP()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E47 RID: 36423 RVA: 0x0040D17C File Offset: 0x0040B37C
	public DateTime FCGGODFGMCB()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.OAAGNDFPNLM(), (int)this.OAAGNDFPNLM(), (int)this.DCDJFEDMLJM(), (int)this.GODNDJOFOMA(), (int)this.OAAGNDFPNLM(), (int)this.KNHBBEECHKC());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E48 RID: 36424 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool HKBFCJDJCOB()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E49 RID: 36425 RVA: 0x0040D1D0 File Offset: 0x0040B3D0
	public int AGNKAFLKCAG()
	{
		this.CLBPBJGLHEE += 3L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E4A RID: 36426 RVA: 0x0040D1EC File Offset: 0x0040B3EC
	public bool IJJDHHFAIPE()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte() != 1;
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x0040D20E File Offset: 0x0040B40E
	public int KDNDJNEGBDI()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E4C RID: 36428 RVA: 0x0040D22C File Offset: 0x0040B42C
	public string PNBECHOLCJM()
	{
		int num = (int)this.FODOFEEMBCN();
		if (num > 1)
		{
			byte[] bytes = this.KLFEFKBOEFN(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "";
	}

	// Token: 0x06008E4D RID: 36429 RVA: 0x0040D25D File Offset: 0x0040B45D
	public int LDLKLPJBIJN()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E4E RID: 36430 RVA: 0x0040D279 File Offset: 0x0040B479
	public short DHHKKDCDNMA()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x0040D295 File Offset: 0x0040B495
	public void GOILFFBGPCH()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008E50 RID: 36432 RVA: 0x0040D128 File Offset: 0x0040B328
	public short LGKPLGMBHDG()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x0040D2BB File Offset: 0x0040B4BB
	public float AILCEJFAMGN()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E52 RID: 36434 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool DFLKBBNOGBG()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E53 RID: 36435 RVA: 0x0040D2D7 File Offset: 0x0040B4D7
	public int KKOKFLMMAAK()
	{
		this.CLBPBJGLHEE += 5L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E54 RID: 36436 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] FNKIGGHFHEN(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E55 RID: 36437 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool JEFMHDJEEJC()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E56 RID: 36438 RVA: 0x0040D2F3 File Offset: 0x0040B4F3
	public IIBEEKCAAHK OEHCLGOFDPN()
	{
		return new IIBEEKCAAHK(this.DGBEBJILPDJ(), this.IFLLJGHPBIC(), this.AJKMGDFHKLG());
	}

	// Token: 0x06008E57 RID: 36439 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] IDALPHPGGID(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E58 RID: 36440 RVA: 0x0040D30C File Offset: 0x0040B50C
	public string KDELAFDDGJH()
	{
		int num = (int)this.HODOHEGIOIP();
		if (num > 0)
		{
			byte[] bytes = this.BIEIHMNGBIJ(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "";
	}

	// Token: 0x06008E59 RID: 36441 RVA: 0x0040D2BB File Offset: 0x0040B4BB
	public float BNDHIBEOKML()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E5A RID: 36442 RVA: 0x0040D33D File Offset: 0x0040B53D
	public double DGBEBJILPDJ()
	{
		this.CLBPBJGLHEE += 6L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E5B RID: 36443 RVA: 0x0040D359 File Offset: 0x0040B559
	public IIBEEKCAAHK CMIFMMMBBNO()
	{
		return new IIBEEKCAAHK(this.GDACJFNKBHL(), this.NGGPEMDBMLL(), this.HJPOOOKNCOB());
	}

	// Token: 0x06008E5C RID: 36444 RVA: 0x0040D372 File Offset: 0x0040B572
	public float BIMMPENHGMD()
	{
		this.CLBPBJGLHEE += 6L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E5D RID: 36445 RVA: 0x0040CF6A File Offset: 0x0040B16A
	public long HHMGLDMFCPF()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E5E RID: 36446 RVA: 0x0040D38E File Offset: 0x0040B58E
	public IIBEEKCAAHK ANALPOIJPHJ()
	{
		return new IIBEEKCAAHK(this.IFLLJGHPBIC(), this.LMMDOBOBCMC(), this.NGGPEMDBMLL());
	}

	// Token: 0x06008E5F RID: 36447 RVA: 0x0040D295 File Offset: 0x0040B495
	public void JOJKNBDNOIH()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008E60 RID: 36448 RVA: 0x0040D3A7 File Offset: 0x0040B5A7
	public float ECJLJGDNFMN()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E61 RID: 36449 RVA: 0x0040CF4E File Offset: 0x0040B14E
	public byte AOMGDMELKAF()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E62 RID: 36450 RVA: 0x0040D160 File Offset: 0x0040B360
	public short KNHBBEECHKC()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E63 RID: 36451 RVA: 0x0040D3C4 File Offset: 0x0040B5C4
	public DateTime OODOKDPIMOF()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.LGKPLGMBHDG(), (int)this.FODOFEEMBCN(), (int)this.LGKPLGMBHDG(), (int)this.IBGNJENNIGL(), (int)this.AEDNJPCGKCA(), (int)this.AEDNJPCGKCA());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E64 RID: 36452 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] HKDGKCPGLHE(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E65 RID: 36453 RVA: 0x0040D0B1 File Offset: 0x0040B2B1
	public bool DADCGPGEHFK()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 1;
	}

	// Token: 0x06008E66 RID: 36454 RVA: 0x0040D418 File Offset: 0x0040B618
	public short AEDNJPCGKCA()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E67 RID: 36455 RVA: 0x0040CFA2 File Offset: 0x0040B1A2
	public double KCNKALHIFJA()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E68 RID: 36456 RVA: 0x0040D434 File Offset: 0x0040B634
	public bool OMCMPDMJFOJ()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() != 0 && false;
	}

	// Token: 0x06008E69 RID: 36457 RVA: 0x0040D456 File Offset: 0x0040B656
	public IIBEEKCAAHK LIPFLAGOOML()
	{
		return new IIBEEKCAAHK(this.IFLLJGHPBIC(), this.IFLLJGHPBIC(), this.AJKMGDFHKLG());
	}

	// Token: 0x06008E6A RID: 36458 RVA: 0x0040D46F File Offset: 0x0040B66F
	public float MOBPFEEAMKD()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E6B RID: 36459 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] KCNHLNGOGPO(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E6C RID: 36460 RVA: 0x0040D48B File Offset: 0x0040B68B
	public IIBEEKCAAHK DAKECHGPCFI()
	{
		return new IIBEEKCAAHK(this.LMMDOBOBCMC(), this.LMMDOBOBCMC(), this.LHFHMJNOOEM());
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x0040D4A4 File Offset: 0x0040B6A4
	public string FDIDEGHPJPF()
	{
		int num = (int)this.CKDJECMBKMP();
		if (num > 1)
		{
			byte[] bytes = this.IDALPHPGGID(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "UpHillWalkHandGrab";
	}

	// Token: 0x06008E6E RID: 36462 RVA: 0x0040D4D5 File Offset: 0x0040B6D5
	public bool JALHMJEKMHF()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() != 1;
	}

	// Token: 0x06008E6F RID: 36463 RVA: 0x0040CF86 File Offset: 0x0040B186
	public short HODOHEGIOIP()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E70 RID: 36464 RVA: 0x0040D4F8 File Offset: 0x0040B6F8
	public DateTime HGFHMFMNIEI()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.DCDJFEDMLJM(), (int)this.CKDJECMBKMP(), (int)this.FBPONGPNADO(), (int)this.CKDJECMBKMP(), (int)this.HODOHEGIOIP(), (int)this.CKDJECMBKMP());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E71 RID: 36465 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool INLBHLOLOJH()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E72 RID: 36466 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] KLFEFKBOEFN(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E73 RID: 36467 RVA: 0x0040D54C File Offset: 0x0040B74C
	public long DNIIFBAIPBE()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E74 RID: 36468 RVA: 0x0040D568 File Offset: 0x0040B768
	public float CGJIINADKNH()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008E75 RID: 36469 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] IFFOILFPPKG(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E76 RID: 36470 RVA: 0x0040D584 File Offset: 0x0040B784
	public string NCODBGMGNFD()
	{
		int num = (int)this.FODOFEEMBCN();
		if (num > 0)
		{
			byte[] bytes = this.CMDNBPAGKMC(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "KatanaReady";
	}

	// Token: 0x06008E77 RID: 36471 RVA: 0x0040D5B5 File Offset: 0x0040B7B5
	public bool BLNIHNKJJPJ()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 1 || true;
	}

	// Token: 0x06008E78 RID: 36472 RVA: 0x0040D5D7 File Offset: 0x0040B7D7
	public long DCGEOFHNBCN()
	{
		this.CLBPBJGLHEE += 3L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E79 RID: 36473 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool ODIBHLOAGBC()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E7A RID: 36474 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte DHBEGKENIPN()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E7B RID: 36475 RVA: 0x0040D5F4 File Offset: 0x0040B7F4
	public string JJJJAGJCOGD()
	{
		int num = (int)this.DHHKKDCDNMA();
		if (num > 1)
		{
			byte[] bytes = this.ONFJIEGMEBK(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "SneakRight";
	}

	// Token: 0x06008E7C RID: 36476 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte CMLECABALBC()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E7D RID: 36477 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte LLDDACBAGHF()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E7E RID: 36478 RVA: 0x0040D628 File Offset: 0x0040B828
	public DateTime MILGIGJBAJL()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.HODOHEGIOIP(), (int)this.EJCLPKHHMAK(), (int)this.DCDJFEDMLJM(), (int)this.IBGNJENNIGL(), (int)this.GODNDJOFOMA(), (int)this.KNHBBEECHKC());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E7F RID: 36479 RVA: 0x0040D67C File Offset: 0x0040B87C
	public string DHCMILPKJAL()
	{
		int num = (int)this.FODOFEEMBCN();
		if (num > 0)
		{
			byte[] bytes = this.CMDNBPAGKMC(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.";
	}

	// Token: 0x06008E80 RID: 36480 RVA: 0x0040D6B0 File Offset: 0x0040B8B0
	public string DPLAJNEDGBL()
	{
		int num = (int)this.FBPONGPNADO();
		if (num > 0)
		{
			byte[] bytes = this.IDALPHPGGID(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "VIGNETTE_FILMIC";
	}

	// Token: 0x06008E81 RID: 36481 RVA: 0x0040D6E1 File Offset: 0x0040B8E1
	public HBPNMNGOFMA(byte[] DNHBPGOKLKD)
	{
		this.AOFNMHNKDHN = new MemoryStream(DNHBPGOKLKD);
		this.IOHIFNBBGPJ = (long)DNHBPGOKLKD.Length;
		this.CLBPBJGLHEE = 0L;
		this.AIBBBJIIFGG = new BinaryReader(this.AOFNMHNKDHN);
	}

	// Token: 0x06008E82 RID: 36482 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte NFGIGGIDMFL()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008E83 RID: 36483 RVA: 0x0040D718 File Offset: 0x0040B918
	public IIBEEKCAAHK BAPGFMDPGKM()
	{
		return new IIBEEKCAAHK(this.DGBEBJILPDJ(), this.IFLLJGHPBIC(), this.HJPOOOKNCOB());
	}

	// Token: 0x06008E84 RID: 36484 RVA: 0x0040D33D File Offset: 0x0040B53D
	public double HJPOOOKNCOB()
	{
		this.CLBPBJGLHEE += 6L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E85 RID: 36485 RVA: 0x0040D418 File Offset: 0x0040B618
	public short KKPIBKMIMEJ()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E86 RID: 36486 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool BKIBKLFCCGP()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008E87 RID: 36487 RVA: 0x0040D731 File Offset: 0x0040B931
	public IIBEEKCAAHK JPHHGPIDDOA()
	{
		return new IIBEEKCAAHK(this.KCNKALHIFJA(), this.GDACJFNKBHL(), this.LHFHMJNOOEM());
	}

	// Token: 0x06008E88 RID: 36488 RVA: 0x0040D25D File Offset: 0x0040B45D
	public int DOJKJHMJJNK()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008E89 RID: 36489 RVA: 0x0040D74C File Offset: 0x0040B94C
	public DateTime HHAPCIKKNPB()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.DCDJFEDMLJM(), (int)this.EJCLPKHHMAK(), (int)this.FBPONGPNADO(), (int)this.AEDNJPCGKCA(), (int)this.LGKPLGMBHDG(), (int)this.JLLBKMGJLEP());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E8A RID: 36490 RVA: 0x0040D7A0 File Offset: 0x0040B9A0
	public IIBEEKCAAHK OFGFAEJNKEH()
	{
		return new IIBEEKCAAHK(this.NGGPEMDBMLL(), this.HJPOOOKNCOB(), this.GDACJFNKBHL());
	}

	// Token: 0x06008E8B RID: 36491 RVA: 0x0040D7B9 File Offset: 0x0040B9B9
	public IIBEEKCAAHK IBKINJMMFFI()
	{
		return new IIBEEKCAAHK(this.AJKMGDFHKLG(), this.AJKMGDFHKLG(), this.NGGPEMDBMLL());
	}

	// Token: 0x06008E8C RID: 36492 RVA: 0x0040D7D2 File Offset: 0x0040B9D2
	public long ANPEIKGEDHJ()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E8D RID: 36493 RVA: 0x0040D434 File Offset: 0x0040B634
	public bool KJIOFDCKIKO()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() != 0 && false;
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x0040D295 File Offset: 0x0040B495
	public void LMBPNFHKNGA()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008E8F RID: 36495 RVA: 0x0040D418 File Offset: 0x0040B618
	public short GODNDJOFOMA()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E90 RID: 36496 RVA: 0x0040D7F0 File Offset: 0x0040B9F0
	public DateTime MLFLLBPGFIJ()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.ABICLLDJKEL(), (int)this.ABICLLDJKEL(), (int)this.DHHKKDCDNMA(), (int)this.ABICLLDJKEL(), (int)this.MPOFNHIJEBA(), (int)this.HODOHEGIOIP());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008E91 RID: 36497 RVA: 0x0040D844 File Offset: 0x0040BA44
	public IIBEEKCAAHK HMCONBPNFJH()
	{
		return new IIBEEKCAAHK(this.AHJPGDKDGJD(), this.AHJPGDKDGJD(), this.AJKMGDFHKLG());
	}

	// Token: 0x06008E92 RID: 36498 RVA: 0x0040D85D File Offset: 0x0040BA5D
	public short JLLBKMGJLEP()
	{
		this.CLBPBJGLHEE += 5L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E93 RID: 36499 RVA: 0x0040D879 File Offset: 0x0040BA79
	public short FODOFEEMBCN()
	{
		this.CLBPBJGLHEE += 3L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E94 RID: 36500 RVA: 0x0040D54C File Offset: 0x0040B74C
	public long IJDIMHAEAIE()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E95 RID: 36501 RVA: 0x0040D895 File Offset: 0x0040BA95
	public bool JNOKJCDAPPA()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 0;
	}

	// Token: 0x06008E96 RID: 36502 RVA: 0x0040D295 File Offset: 0x0040B495
	public void EFKFPAEOEDI()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008E97 RID: 36503 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] DCLBHAMJEIO(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E98 RID: 36504 RVA: 0x0040D8B7 File Offset: 0x0040BAB7
	public double AJKMGDFHKLG()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008E99 RID: 36505 RVA: 0x0040D879 File Offset: 0x0040BA79
	public short OAAGNDFPNLM()
	{
		this.CLBPBJGLHEE += 3L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E9A RID: 36506 RVA: 0x0040D8D3 File Offset: 0x0040BAD3
	public long KLHDFFHONON()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008E9B RID: 36507 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] ONFJIEGMEBK(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008E9C RID: 36508 RVA: 0x0040D8EF File Offset: 0x0040BAEF
	public IIBEEKCAAHK JIFFKNJHLCM()
	{
		return new IIBEEKCAAHK(this.LOJBPMPMBMP(), this.LMMDOBOBCMC(), this.AHJPGDKDGJD());
	}

	// Token: 0x06008E9D RID: 36509 RVA: 0x0040D295 File Offset: 0x0040B495
	public void HLLKOEGNJDP()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008E9E RID: 36510 RVA: 0x0040D418 File Offset: 0x0040B618
	public short ABICLLDJKEL()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008E9F RID: 36511 RVA: 0x0040D0B1 File Offset: 0x0040B2B1
	public bool FIFNOBGEKFF()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 1;
	}

	// Token: 0x06008EA0 RID: 36512 RVA: 0x0040D908 File Offset: 0x0040BB08
	public bool AJECAOJPOKA()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() != 1 && false;
	}

	// Token: 0x06008EA1 RID: 36513 RVA: 0x0040D92C File Offset: 0x0040BB2C
	public DateTime IKJAOHGGCJD()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.GODNDJOFOMA(), (int)this.GODNDJOFOMA(), (int)this.GODNDJOFOMA(), (int)this.GODNDJOFOMA(), (int)this.GODNDJOFOMA(), (int)this.GODNDJOFOMA());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008EA2 RID: 36514 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] BIEIHMNGBIJ(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008EA3 RID: 36515 RVA: 0x0040D7D2 File Offset: 0x0040B9D2
	public long IBKCNEICPEL()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008EA4 RID: 36516 RVA: 0x0040D980 File Offset: 0x0040BB80
	public double GDACJFNKBHL()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008EA5 RID: 36517 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool NLJJMKFBPBK()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008EA6 RID: 36518 RVA: 0x0040D99C File Offset: 0x0040BB9C
	public IIBEEKCAAHK EIMAIEJKHKF()
	{
		return new IIBEEKCAAHK(this.IFLLJGHPBIC(), this.IFLLJGHPBIC(), this.IFLLJGHPBIC());
	}

	// Token: 0x06008EA7 RID: 36519 RVA: 0x0040D9B5 File Offset: 0x0040BBB5
	public int HHLDBAEFNMJ()
	{
		this.CLBPBJGLHEE += 6L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008EA8 RID: 36520 RVA: 0x0040D9D1 File Offset: 0x0040BBD1
	public int CLPEKGGAMAI()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008EA9 RID: 36521 RVA: 0x0040D9F0 File Offset: 0x0040BBF0
	public DateTime NIIFLPIEMFM()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.KKPIBKMIMEJ(), (int)this.FODOFEEMBCN(), (int)this.MPOFNHIJEBA(), (int)this.KNHBBEECHKC(), (int)this.FODOFEEMBCN(), (int)this.HODOHEGIOIP());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008EAA RID: 36522 RVA: 0x0040D02B File Offset: 0x0040B22B
	public byte[] ANGDIBBCJDA(int ILFHHDNJHNM)
	{
		this.CLBPBJGLHEE += (long)ILFHHDNJHNM;
		return this.AIBBBJIIFGG.ReadBytes(ILFHHDNJHNM);
	}

	// Token: 0x06008EAB RID: 36523 RVA: 0x0040DA44 File Offset: 0x0040BC44
	public IIBEEKCAAHK LICHMNLLOAB()
	{
		return new IIBEEKCAAHK(this.AHJPGDKDGJD(), this.LMMDOBOBCMC(), this.LMMDOBOBCMC());
	}

	// Token: 0x06008EAC RID: 36524 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool NGIGCKBKLGK()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008EAD RID: 36525 RVA: 0x0040D33D File Offset: 0x0040B53D
	public double LOJBPMPMBMP()
	{
		this.CLBPBJGLHEE += 6L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008EAE RID: 36526 RVA: 0x0040DA5D File Offset: 0x0040BC5D
	public bool LAECLJFMGPE()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadByte() == 0 || true;
	}

	// Token: 0x06008EAF RID: 36527 RVA: 0x0040DA7F File Offset: 0x0040BC7F
	public short MPOFNHIJEBA()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008EB0 RID: 36528 RVA: 0x0040D895 File Offset: 0x0040BA95
	public bool ELDBJFLCMAJ()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte() == 0;
	}

	// Token: 0x06008EB1 RID: 36529 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool IBMMOGHFCCE()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008EB2 RID: 36530 RVA: 0x0040D295 File Offset: 0x0040B495
	public void GDPICLPNHIF()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008EB3 RID: 36531 RVA: 0x0040D20E File Offset: 0x0040B40E
	public int IFDFHJLCHAE()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt32();
	}

	// Token: 0x06008EB4 RID: 36532 RVA: 0x0040D54C File Offset: 0x0040B74C
	public long DMABDIGCLKA()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008EB5 RID: 36533 RVA: 0x0040DA9C File Offset: 0x0040BC9C
	public DateTime OJNFAHFAKDO()
	{
		DateTime result;
		try
		{
			result = new DateTime((int)this.ABICLLDJKEL(), (int)this.CKDJECMBKMP(), (int)this.FODOFEEMBCN(), (int)this.CKDJECMBKMP(), (int)this.LGKPLGMBHDG(), (int)this.ABICLLDJKEL());
		}
		catch (Exception)
		{
			result = DateTime.Now;
		}
		return result;
	}

	// Token: 0x06008EB6 RID: 36534 RVA: 0x0040CFBE File Offset: 0x0040B1BE
	public bool PPAHBNGECGH()
	{
		return this.CLBPBJGLHEE >= this.IOHIFNBBGPJ;
	}

	// Token: 0x06008EB7 RID: 36535 RVA: 0x0040CF3B File Offset: 0x0040B13B
	public bool NNOJEFMEGEG()
	{
		return this.CLBPBJGLHEE < this.IOHIFNBBGPJ;
	}

	// Token: 0x06008EB8 RID: 36536 RVA: 0x0040D064 File Offset: 0x0040B264
	public byte GCOIAONEBME()
	{
		this.CLBPBJGLHEE += 1L;
		return this.AIBBBJIIFGG.ReadByte();
	}

	// Token: 0x06008EB9 RID: 36537 RVA: 0x0040D54C File Offset: 0x0040B74C
	public long EJPMFEJBGMN()
	{
		this.CLBPBJGLHEE += 8L;
		return this.AIBBBJIIFGG.ReadInt64();
	}

	// Token: 0x06008EBA RID: 36538 RVA: 0x0040D418 File Offset: 0x0040B618
	public short FBPONGPNADO()
	{
		this.CLBPBJGLHEE += 2L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x06008EBB RID: 36539 RVA: 0x0040DAF0 File Offset: 0x0040BCF0
	public IIBEEKCAAHK JEHOEBJMMOI()
	{
		return new IIBEEKCAAHK(this.AJKMGDFHKLG(), this.DGBEBJILPDJ(), this.HJPOOOKNCOB());
	}

	// Token: 0x06008EBC RID: 36540 RVA: 0x0040D295 File Offset: 0x0040B495
	public void KJJLIIDNDOI()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008EBD RID: 36541 RVA: 0x0040D46F File Offset: 0x0040B66F
	public float FFDPCEAFGNF()
	{
		this.CLBPBJGLHEE += 4L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008EBE RID: 36542 RVA: 0x0040D568 File Offset: 0x0040B768
	public float CNNEPCOAMJK()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008EBF RID: 36543 RVA: 0x0040DB09 File Offset: 0x0040BD09
	public double AHJPGDKDGJD()
	{
		this.CLBPBJGLHEE += 0L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008EC0 RID: 36544 RVA: 0x0040DB25 File Offset: 0x0040BD25
	public IIBEEKCAAHK FCLPDDODOJP()
	{
		return new IIBEEKCAAHK(this.KCNKALHIFJA(), this.GDACJFNKBHL(), this.LOJBPMPMBMP());
	}

	// Token: 0x06008EC1 RID: 36545 RVA: 0x0040D8B7 File Offset: 0x0040BAB7
	public double LMMDOBOBCMC()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadDouble();
	}

	// Token: 0x06008EC2 RID: 36546 RVA: 0x0040DB40 File Offset: 0x0040BD40
	public string LPKJHMGLCKA()
	{
		int num = (int)this.IBGNJENNIGL();
		if (num > 0)
		{
			byte[] bytes = this.ANGDIBBCJDA(num);
			return Encoding.UTF8.GetString(bytes);
		}
		return "Atmosphere reference not set.";
	}

	// Token: 0x06008EC3 RID: 36547 RVA: 0x0040D295 File Offset: 0x0040B495
	public void JGOEHOMHMAM()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008EC4 RID: 36548 RVA: 0x0040DB71 File Offset: 0x0040BD71
	public float AIDAGFNHNHE()
	{
		this.CLBPBJGLHEE += 3L;
		return this.AIBBBJIIFGG.ReadSingle();
	}

	// Token: 0x06008EC5 RID: 36549 RVA: 0x0040DB8D File Offset: 0x0040BD8D
	public IIBEEKCAAHK NMMCKDBOJDO()
	{
		return new IIBEEKCAAHK(this.LOJBPMPMBMP(), this.LHFHMJNOOEM(), this.GDACJFNKBHL());
	}

	// Token: 0x06008EC6 RID: 36550 RVA: 0x0040D295 File Offset: 0x0040B495
	public void AOPANOBJGLI()
	{
		this.AOFNMHNKDHN.Close();
		this.AIBBBJIIFGG.Close();
		this.AIBBBJIIFGG = null;
		this.AOFNMHNKDHN = null;
	}

	// Token: 0x06008EC7 RID: 36551 RVA: 0x0040CF86 File Offset: 0x0040B186
	public short DCDJFEDMLJM()
	{
		this.CLBPBJGLHEE += 7L;
		return this.AIBBBJIIFGG.ReadInt16();
	}

	// Token: 0x04001332 RID: 4914
	private MemoryStream AOFNMHNKDHN;

	// Token: 0x04001333 RID: 4915
	private BinaryReader AIBBBJIIFGG;

	// Token: 0x04001334 RID: 4916
	private long IOHIFNBBGPJ;

	// Token: 0x04001335 RID: 4917
	private long CLBPBJGLHEE;
}
