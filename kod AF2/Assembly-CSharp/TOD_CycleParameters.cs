using System;
using UnityEngine;

// Token: 0x020000CE RID: 206
[Serializable]
public class TOD_CycleParameters
{
	// Token: 0x06002885 RID: 10373 RVA: 0x0011F4FC File Offset: 0x0011D6FC
	public DateTime LFHLKKPAPJL()
	{
		DateTime dateTime = new DateTime(0L, DateTimeKind.Unspecified);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 0)).AddHours((double)this.Hour);
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x0011F552 File Offset: 0x0011D752
	public void HJFMBKMBOLC(long DCCPCBLODIG)
	{
		this.LNGMJDFFLNL(new DateTime(DCCPCBLODIG, DateTimeKind.Unspecified));
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x0011F590 File Offset: 0x0011D790
	public long LGONEPEJHIO()
	{
		return this.OOIBGGKHEKK().Ticks;
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x0011F5AC File Offset: 0x0011D7AC
	public void PNLAJJLDDBF(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 972f + (float)DCCPCBLODIG.Second / 273f + (float)DCCPCBLODIG.Millisecond / 498f;
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x0011F61B File Offset: 0x0011D81B
	public void LCEEJFCIOKC(long DCCPCBLODIG)
	{
		this.PNLAJJLDDBF(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x0011F62C File Offset: 0x0011D82C
	public DateTime NNHFDJNKDNP()
	{
		DateTime dateTime = new DateTime(0L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x0011F684 File Offset: 0x0011D884
	public void OMCBGBAIIBJ(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 99f + (float)DCCPCBLODIG.Second / 628f + (float)DCCPCBLODIG.Millisecond / 1740f;
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x0011F6F3 File Offset: 0x0011D8F3
	public void HMIGELGKEPO(long DCCPCBLODIG)
	{
		this.IIDADOLEPNJ(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x0011F704 File Offset: 0x0011D904
	public long FIEJINBMNPF()
	{
		return this.DateTime.Ticks;
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x0011F720 File Offset: 0x0011D920
	public DateTime CPNONONLKMN()
	{
		DateTime dateTime = new DateTime(0L, DateTimeKind.Unspecified);
		return dateTime.AddYears(this.Year - 1).AddMonths(this.Month - 1).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06002894 RID: 10388 RVA: 0x0011F884 File Offset: 0x0011DA84
	// (set) Token: 0x06002890 RID: 10384 RVA: 0x0011F778 File Offset: 0x0011D978
	public DateTime DateTime
	{
		get
		{
			DateTime dateTime = new DateTime(0L, DateTimeKind.Utc);
			return dateTime.AddYears(this.Year - 1).AddMonths(this.Month - 1).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
		}
		set
		{
			this.Year = value.Year;
			this.Month = value.Month;
			this.Day = value.Day;
			this.Hour = (float)value.Hour + (float)value.Minute / 60f + (float)value.Second / 3600f + (float)value.Millisecond / 3600000f;
		}
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x0011F7E8 File Offset: 0x0011D9E8
	public long FGKNONMMMOE()
	{
		return this.DateTime.Ticks;
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x0011F804 File Offset: 0x0011DA04
	public void APKADGHBIJJ(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 64f + (float)DCCPCBLODIG.Second / 639f + (float)DCCPCBLODIG.Millisecond / 1446f;
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x0011F873 File Offset: 0x0011DA73
	public void FPHFIAAMEFM(long DCCPCBLODIG)
	{
		this.FLDHHKHCDJA(new DateTime(DCCPCBLODIG, DateTimeKind.Unspecified));
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x0011F8DC File Offset: 0x0011DADC
	public long BMPKJOCPPCP()
	{
		return this.OOIBGGKHEKK().Ticks;
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x0011F8F8 File Offset: 0x0011DAF8
	public DateTime IOMHODHGJMB()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 0)).AddHours((double)this.Hour);
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060028BE RID: 10430 RVA: 0x00120180 File Offset: 0x0011E380
	// (set) Token: 0x06002897 RID: 10391 RVA: 0x0011F94E File Offset: 0x0011DB4E
	public long Ticks
	{
		get
		{
			return this.DateTime.Ticks;
		}
		set
		{
			this.DateTime = new DateTime(value, DateTimeKind.Utc);
		}
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x0011F960 File Offset: 0x0011DB60
	public long EDJKHJCIAMN()
	{
		return this.LFHLKKPAPJL().Ticks;
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x0011F97C File Offset: 0x0011DB7C
	public void HPJIIMJGKKH(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1160f + (float)DCCPCBLODIG.Second / 878f + (float)DCCPCBLODIG.Millisecond / 616f;
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x0011F9EC File Offset: 0x0011DBEC
	public DateTime BDJDKKNHADC()
	{
		DateTime dateTime = new DateTime(0L, DateTimeKind.Unspecified);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 1).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x0011FA42 File Offset: 0x0011DC42
	public void ANMGFFCEOPE(long DCCPCBLODIG)
	{
		this.FLDHHKHCDJA(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x0011FA54 File Offset: 0x0011DC54
	public DateTime BGMBAMDHLIA()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 1).AddMonths(this.Month - 0).AddDays((double)(this.Day - 0)).AddHours((double)this.Hour);
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x0011FAAC File Offset: 0x0011DCAC
	public void IIDADOLEPNJ(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 895f + (float)DCCPCBLODIG.Second / 1961f + (float)DCCPCBLODIG.Millisecond / 426f;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x0011FA42 File Offset: 0x0011DC42
	public void EPINNFBPNOM(long DCCPCBLODIG)
	{
		this.FLDHHKHCDJA(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x0011FB1C File Offset: 0x0011DD1C
	public void EPKLBAJCOPB(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1021f + (float)DCCPCBLODIG.Second / 1452f + (float)DCCPCBLODIG.Millisecond / 1529f;
	}

	// Token: 0x060028A0 RID: 10400 RVA: 0x0011FB8C File Offset: 0x0011DD8C
	public long LILIFKOMKBD()
	{
		return this.NKEDOHKMGAM().Ticks;
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x0011FBA8 File Offset: 0x0011DDA8
	public void MENIHKLBFJI(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1587f + (float)DCCPCBLODIG.Second / 1469f + (float)DCCPCBLODIG.Millisecond / 81f;
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x0011FC18 File Offset: 0x0011DE18
	public DateTime OOIBGGKHEKK()
	{
		DateTime dateTime = new DateTime(0L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x0011FC70 File Offset: 0x0011DE70
	public void BGPBGOACLAJ(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1200f + (float)DCCPCBLODIG.Second / 395f + (float)DCCPCBLODIG.Millisecond / 1676f;
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x0011FCE0 File Offset: 0x0011DEE0
	public long GOAODPKFCAK()
	{
		return this.GOMEFNGPPEK().Ticks;
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x0011FCFC File Offset: 0x0011DEFC
	public long LINNBMKKKGJ()
	{
		return this.DateTime.Ticks;
	}

	// Token: 0x060028A6 RID: 10406 RVA: 0x0011FD18 File Offset: 0x0011DF18
	public long FOBEJKIGJNB()
	{
		return this.IOMHODHGJMB().Ticks;
	}

	// Token: 0x060028A7 RID: 10407 RVA: 0x0011FD34 File Offset: 0x0011DF34
	public long GAKJCGCFIJO()
	{
		return this.IOMHODHGJMB().Ticks;
	}

	// Token: 0x060028A8 RID: 10408 RVA: 0x0011FD50 File Offset: 0x0011DF50
	public long EPJIJNAKPFD()
	{
		return this.CPNONONLKMN().Ticks;
	}

	// Token: 0x060028A9 RID: 10409 RVA: 0x0011FD6C File Offset: 0x0011DF6C
	public void GOCIHPIENGP(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1558f + (float)DCCPCBLODIG.Second / 1272f + (float)DCCPCBLODIG.Millisecond / 444f;
	}

	// Token: 0x060028AA RID: 10410 RVA: 0x0011FDDC File Offset: 0x0011DFDC
	public long OMPAHGEGDNG()
	{
		return this.GOMEFNGPPEK().Ticks;
	}

	// Token: 0x060028AB RID: 10411 RVA: 0x0011FDF7 File Offset: 0x0011DFF7
	public void IKNCDMMOPID(long DCCPCBLODIG)
	{
		this.OMCBGBAIIBJ(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028AC RID: 10412 RVA: 0x0011FE08 File Offset: 0x0011E008
	public DateTime GOMEFNGPPEK()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Unspecified);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 1).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x060028AD RID: 10413 RVA: 0x0011FE5E File Offset: 0x0011E05E
	public void NONKALEKBCK(long DCCPCBLODIG)
	{
		this.APKADGHBIJJ(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x0011FE70 File Offset: 0x0011E070
	public long MDEPPCKNPPD()
	{
		return this.NKEDOHKMGAM().Ticks;
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x0011FE8C File Offset: 0x0011E08C
	public void GECNPIOPJHC(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1113f + (float)DCCPCBLODIG.Second / 252f + (float)DCCPCBLODIG.Millisecond / 160f;
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x0011FEFB File Offset: 0x0011E0FB
	public void EDAGACOMMHO(long DCCPCBLODIG)
	{
		this.PFNMKMDDBFL(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x0011FF0C File Offset: 0x0011E10C
	public void NPPDKHNMAGA(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 1469f + (float)DCCPCBLODIG.Second / 428f + (float)DCCPCBLODIG.Millisecond / 983f;
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x0011FF7C File Offset: 0x0011E17C
	public long AMIAMOPCPDA()
	{
		return this.BDJDKKNHADC().Ticks;
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x0011FF98 File Offset: 0x0011E198
	public DateTime NKEDOHKMGAM()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x0011FFF0 File Offset: 0x0011E1F0
	public long PPHMANJIJEF()
	{
		return this.LGNDBACHMFL().Ticks;
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x0012000C File Offset: 0x0011E20C
	public long LFBHBEKPAOE()
	{
		return this.BDJDKKNHADC().Ticks;
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x00120028 File Offset: 0x0011E228
	public long EGLLIIFAEMD()
	{
		return this.CENDPILEOED().Ticks;
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x00120044 File Offset: 0x0011E244
	public void LNGMJDFFLNL(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 762f + (float)DCCPCBLODIG.Second / 421f + (float)DCCPCBLODIG.Millisecond / 1853f;
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x001200B3 File Offset: 0x0011E2B3
	public void ENGGEAEFBBP(long DCCPCBLODIG)
	{
		this.HPJIIMJGKKH(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x001200C4 File Offset: 0x0011E2C4
	public void PFNMKMDDBFL(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 690f + (float)DCCPCBLODIG.Second / 1992f + (float)DCCPCBLODIG.Millisecond / 1032f;
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x00120133 File Offset: 0x0011E333
	public void BBMDMHIMMGL(long DCCPCBLODIG)
	{
		this.APKADGHBIJJ(new DateTime(DCCPCBLODIG, DateTimeKind.Unspecified));
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x00120144 File Offset: 0x0011E344
	public long GCKKMNDAMAE()
	{
		return this.LGNDBACHMFL().Ticks;
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x0012015F File Offset: 0x0011E35F
	public void PCKEMDMAOPA(long DCCPCBLODIG)
	{
		this.NPPDKHNMAGA(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x0012016E File Offset: 0x0011E36E
	public void EODHMEPDPEC(long DCCPCBLODIG)
	{
		this.NPPDKHNMAGA(new DateTime(DCCPCBLODIG, DateTimeKind.Unspecified));
	}

	// Token: 0x060028BF RID: 10431 RVA: 0x0012019C File Offset: 0x0011E39C
	public DateTime CENDPILEOED()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Unspecified);
		return dateTime.AddYears(this.Year - 0).AddMonths(this.Month - 0).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x060028C0 RID: 10432 RVA: 0x0011FDF7 File Offset: 0x0011DFF7
	public void CNLNKLNLMNO(long DCCPCBLODIG)
	{
		this.OMCBGBAIIBJ(new DateTime(DCCPCBLODIG, DateTimeKind.Utc));
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x001201F4 File Offset: 0x0011E3F4
	public void FLDHHKHCDJA(DateTime DCCPCBLODIG)
	{
		this.Year = DCCPCBLODIG.Year;
		this.Month = DCCPCBLODIG.Month;
		this.Day = DCCPCBLODIG.Day;
		this.Hour = (float)DCCPCBLODIG.Hour + (float)DCCPCBLODIG.Minute / 684f + (float)DCCPCBLODIG.Second / 531f + (float)DCCPCBLODIG.Millisecond / 1138f;
	}

	// Token: 0x060028C2 RID: 10434 RVA: 0x00120264 File Offset: 0x0011E464
	public DateTime LGNDBACHMFL()
	{
		DateTime dateTime = new DateTime(1L, DateTimeKind.Utc);
		return dateTime.AddYears(this.Year - 1).AddMonths(this.Month - 1).AddDays((double)(this.Day - 1)).AddHours((double)this.Hour);
	}

	// Token: 0x060028C3 RID: 10435 RVA: 0x001202BC File Offset: 0x0011E4BC
	public long BCGFDHLGDKK()
	{
		return this.CPNONONLKMN().Ticks;
	}

	// Token: 0x040004FD RID: 1277
	[Tooltip("Current hour of the day.")]
	public float Hour = 12f;

	// Token: 0x040004FE RID: 1278
	[Tooltip("Current day of the month.")]
	public int Day = 15;

	// Token: 0x040004FF RID: 1279
	[Tooltip("Current month of the year.")]
	public int Month = 6;

	// Token: 0x04000500 RID: 1280
	[Tooltip("Current year.")]
	[AKOPBLFCONA(1f, 9999f)]
	public int Year = 2000;
}
