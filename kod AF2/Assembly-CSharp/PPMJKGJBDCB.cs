using System;

// Token: 0x020004E8 RID: 1256
public static class PPMJKGJBDCB
{
	// Token: 0x06010ED5 RID: 69333 RVA: 0x00793468 File Offset: 0x00791668
	public static BFGMBMMBHCH DCLHMDEGFLH(string MNEICNPJGMC)
	{
		string text = MNEICNPJGMC.ToUpper();
		foreach (object obj in Enum.GetValues(typeof(BFGMBMMBHCH)))
		{
			if (text.Equals(((BFGMBMMBHCH)obj).ToString().ToUpper()))
			{
				return (BFGMBMMBHCH)obj;
			}
		}
		return BFGMBMMBHCH.Null;
	}

	// Token: 0x06010ED6 RID: 69334 RVA: 0x007934F8 File Offset: 0x007916F8
	public static int JJPGHNFIFOG(BFGMBMMBHCH BDELNBNMOPB)
	{
		if (BDELNBNMOPB == BFGMBMMBHCH.UV0)
		{
			return 0;
		}
		if (BDELNBNMOPB == BFGMBMMBHCH.UV2)
		{
			return 1;
		}
		if (BDELNBNMOPB == BFGMBMMBHCH.UV3)
		{
			return 2;
		}
		if (BDELNBNMOPB == BFGMBMMBHCH.UV4)
		{
			return 3;
		}
		return -1;
	}
}
