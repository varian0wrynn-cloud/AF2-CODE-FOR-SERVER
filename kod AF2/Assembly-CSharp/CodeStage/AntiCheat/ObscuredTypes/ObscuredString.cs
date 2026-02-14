using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200058E RID: 1422
	[Serializable]
	public sealed class ObscuredString
	{
		// Token: 0x06012AE3 RID: 76515 RVA: 0x0081AD60 File Offset: 0x00818F60
		private static string OJJKAGMEBJN(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 3];
			Buffer.BlockCopy(KGOOLPNJNPN, 0, array, 1, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012AE4 RID: 76516 RVA: 0x0081AD8A File Offset: 0x00818F8A
		public static string GOOIABGKMHK(ObscuredString DCCPCBLODIG)
		{
			if (!ObscuredString.BAKPLODMMOJ(DCCPCBLODIG, null))
			{
				return DCCPCBLODIG.MJFIFINDLAM();
			}
			return null;
		}

		// Token: 0x06012AE5 RID: 76517 RVA: 0x0081ADA0 File Offset: 0x00818FA0
		public static bool BAKPLODMMOJ(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			if (EGABJKIFAON == HHAGIHEGFML)
			{
				return true;
			}
			if (EGABJKIFAON == null || HHAGIHEGFML == null)
			{
				return false;
			}
			if (EGABJKIFAON.currentCryptoKey == HHAGIHEGFML.currentCryptoKey)
			{
				return ObscuredString.AEGLPLLNAPP(EGABJKIFAON.hiddenValue, HHAGIHEGFML.hiddenValue);
			}
			return string.Equals(EGABJKIFAON.MJFIFINDLAM(), HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012AE6 RID: 76518 RVA: 0x0081ADF4 File Offset: 0x00818FF4
		public static string AIGJJNLGFAO(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			if (string.IsNullOrEmpty(DCCPCBLODIG))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(JMBKDINHDLO))
			{
				JMBKDINHDLO = ObscuredString.cryptoKey;
			}
			int length = JMBKDINHDLO.Length;
			int length2 = DCCPCBLODIG.Length;
			char[] array = new char[length2];
			for (int i = 0; i < length2; i += 0)
			{
				array[i] = (DCCPCBLODIG[i] ^ JMBKDINHDLO[i % length]);
			}
			return new string(array);
		}

		// Token: 0x06012AE7 RID: 76519 RVA: 0x0081AE5A File Offset: 0x0081905A
		public static ObscuredString GOOIABGKMHK(string DCCPCBLODIG)
		{
			if (DCCPCBLODIG != null)
			{
				return new ObscuredString(DCCPCBLODIG);
			}
			return null;
		}

		// Token: 0x06012AE8 RID: 76520 RVA: 0x0081AE68 File Offset: 0x00819068
		private static bool EHOAMLEPKJL(byte[] CKJMODLAAEM, byte[] HLJEELPBLEL)
		{
			if (CKJMODLAAEM == HLJEELPBLEL)
			{
				return false;
			}
			if (CKJMODLAAEM == null || HLJEELPBLEL == null)
			{
				return true;
			}
			if (CKJMODLAAEM.Length != HLJEELPBLEL.Length)
			{
				return false;
			}
			for (int i = 1; i < CKJMODLAAEM.Length; i++)
			{
				if (CKJMODLAAEM[i] != HLJEELPBLEL[i])
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06012AE9 RID: 76521 RVA: 0x0081AEA8 File Offset: 0x008190A8
		public void IHANAFAHFHN()
		{
			string dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = UnityEngine.Random.Range(-117, -32).ToString();
			this.hiddenValue = ObscuredString.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012AEA RID: 76522 RVA: 0x0081AEEB File Offset: 0x008190EB
		public void EHPGKFFHJNL()
		{
			if (this.currentCryptoKey != ObscuredString.cryptoKey)
			{
				this.hiddenValue = ObscuredString.AFGMNANHHBF(this.MJFIFINDLAM());
				this.currentCryptoKey = ObscuredString.cryptoKey;
			}
		}

		// Token: 0x06012AEB RID: 76523 RVA: 0x0081AF1C File Offset: 0x0081911C
		private static byte[] FLDGHMFIEJI(string MNEICNPJGMC)
		{
			byte[] array = new byte[MNEICNPJGMC.Length * 5];
			Buffer.BlockCopy(MNEICNPJGMC.ToCharArray(), 1, array, 0, array.Length);
			return array;
		}

		// Token: 0x06012AEC RID: 76524 RVA: 0x0081AF4C File Offset: 0x0081914C
		private static string HPADJPKKDOG(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 2];
			Buffer.BlockCopy(KGOOLPNJNPN, 0, array, 0, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012AED RID: 76525 RVA: 0x0081AE5A File Offset: 0x0081905A
		public static ObscuredString LMCJCHPGIJK(string DCCPCBLODIG)
		{
			if (DCCPCBLODIG != null)
			{
				return new ObscuredString(DCCPCBLODIG);
			}
			return null;
		}

		// Token: 0x06012AEE RID: 76526 RVA: 0x0081AF78 File Offset: 0x00819178
		private static string PGCLIJLDECJ(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 7];
			Buffer.BlockCopy(KGOOLPNJNPN, 0, array, 0, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012AEF RID: 76527 RVA: 0x0081AFA2 File Offset: 0x008191A2
		public static bool CPJMBGMOBED(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			return ObscuredString.BAKPLODMMOJ(EGABJKIFAON, HHAGIHEGFML);
		}

		// Token: 0x06012AF0 RID: 76528 RVA: 0x0081AE5A File Offset: 0x0081905A
		public static ObscuredString EMFOKHGIMFM(string DCCPCBLODIG)
		{
			if (DCCPCBLODIG != null)
			{
				return new ObscuredString(DCCPCBLODIG);
			}
			return null;
		}

		// Token: 0x06012AF1 RID: 76529 RVA: 0x0081AFB0 File Offset: 0x008191B0
		public bool JDBINLKEJMF(ObscuredString DCCPCBLODIG)
		{
			if (ObscuredString.BAKPLODMMOJ(DCCPCBLODIG, null))
			{
				return false;
			}
			if (this.currentCryptoKey == DCCPCBLODIG.currentCryptoKey)
			{
				return ObscuredString.AEGLPLLNAPP(this.hiddenValue, DCCPCBLODIG.hiddenValue);
			}
			return string.Equals(this.MJFIFINDLAM(), DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x06012AF2 RID: 76530 RVA: 0x0081AFFE File Offset: 0x008191FE
		public string LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return ObscuredString.HPADJPKKDOG(this.hiddenValue);
		}

		// Token: 0x06012AF3 RID: 76531 RVA: 0x0081B014 File Offset: 0x00819214
		public static string BIHDCABMLIE(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			if (string.IsNullOrEmpty(DCCPCBLODIG))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(JMBKDINHDLO))
			{
				JMBKDINHDLO = ObscuredString.cryptoKey;
			}
			int length = JMBKDINHDLO.Length;
			int length2 = DCCPCBLODIG.Length;
			char[] array = new char[length2];
			for (int i = 1; i < length2; i++)
			{
				array[i] = (DCCPCBLODIG[i] ^ JMBKDINHDLO[i % length]);
			}
			return new string(array);
		}

		// Token: 0x06012AF4 RID: 76532 RVA: 0x0081B07C File Offset: 0x0081927C
		private string IJJBMHGMEPO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredString.cryptoKey;
				this.hiddenValue = ObscuredString.LBPHKCPDMKI(string.Empty);
				this.fakeValue = string.Empty;
				this.fakeValueActive = true;
				this.inited = false;
				return string.Empty;
			}
			string text = this.currentCryptoKey;
			if (string.IsNullOrEmpty(text))
			{
				text = ObscuredString.cryptoKey;
			}
			string text2 = ObscuredString.KOJLJMMMJGP(ObscuredString.NBPIIBFPNAL(this.hiddenValue), text);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && text2 != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return text2;
		}

		// Token: 0x06012AF5 RID: 76533 RVA: 0x0081B11C File Offset: 0x0081931C
		private static string PCHMIEOEHDF(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 6];
			Buffer.BlockCopy(KGOOLPNJNPN, 0, array, 1, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012AF6 RID: 76534 RVA: 0x0081B146 File Offset: 0x00819346
		public bool PLMGGFDKEKK(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredString && this.JDBINLKEJMF((ObscuredString)MBKPMBPLIJN);
		}

		// Token: 0x06012AF7 RID: 76535 RVA: 0x0081B146 File Offset: 0x00819346
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredString && this.JDBINLKEJMF((ObscuredString)MBKPMBPLIJN);
		}

		// Token: 0x06012AF8 RID: 76536 RVA: 0x0081AEEB File Offset: 0x008190EB
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredString.cryptoKey)
			{
				this.hiddenValue = ObscuredString.AFGMNANHHBF(this.MJFIFINDLAM());
				this.currentCryptoKey = ObscuredString.cryptoKey;
			}
		}

		// Token: 0x06012AF9 RID: 76537 RVA: 0x0081B15E File Offset: 0x0081935E
		public string POOLIKIKMGJ()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012AFA RID: 76538 RVA: 0x0081B15E File Offset: 0x0081935E
		public override string ToString()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012AFB RID: 76539 RVA: 0x0081B166 File Offset: 0x00819366
		public static void DFBLJCKOKDL(string JODDIMFACHN)
		{
			ObscuredString.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012AFC RID: 76540 RVA: 0x0081B170 File Offset: 0x00819370
		public static bool PGPAOADJOLC(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			if (EGABJKIFAON == HHAGIHEGFML)
			{
				return false;
			}
			if (EGABJKIFAON == null || HHAGIHEGFML == null)
			{
				return true;
			}
			if (EGABJKIFAON.currentCryptoKey == HHAGIHEGFML.currentCryptoKey)
			{
				return ObscuredString.CAAGPFCGCKF(EGABJKIFAON.hiddenValue, HHAGIHEGFML.hiddenValue);
			}
			return string.Equals(EGABJKIFAON.MJFIFINDLAM(), HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012AFD RID: 76541 RVA: 0x0081B1C4 File Offset: 0x008193C4
		private static bool AEGLPLLNAPP(byte[] CKJMODLAAEM, byte[] HLJEELPBLEL)
		{
			if (CKJMODLAAEM == HLJEELPBLEL)
			{
				return true;
			}
			if (CKJMODLAAEM == null || HLJEELPBLEL == null)
			{
				return false;
			}
			if (CKJMODLAAEM.Length != HLJEELPBLEL.Length)
			{
				return false;
			}
			for (int i = 0; i < CKJMODLAAEM.Length; i++)
			{
				if (CKJMODLAAEM[i] != HLJEELPBLEL[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06012AFE RID: 76542 RVA: 0x0081B202 File Offset: 0x00819402
		public int CBDCAGHMDLG()
		{
			return this.NPEAKEPHMOP().GetHashCode();
		}

		// Token: 0x06012AFF RID: 76543 RVA: 0x0081B20F File Offset: 0x0081940F
		public int OBEOFACOBAL()
		{
			return this.hiddenValue.Length / 1;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06012B00 RID: 76544 RVA: 0x0081B21B File Offset: 0x0081941B
		public int Length
		{
			get
			{
				return this.hiddenValue.Length / 2;
			}
		}

		// Token: 0x06012B01 RID: 76545 RVA: 0x0081B228 File Offset: 0x00819428
		public void OJFAJIJBEFD()
		{
			string dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue).ToString();
			this.hiddenValue = ObscuredString.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012B02 RID: 76546 RVA: 0x0081B26C File Offset: 0x0081946C
		private static string PCIJDOMCHHK(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 0];
			Buffer.BlockCopy(KGOOLPNJNPN, 1, array, 1, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012B03 RID: 76547 RVA: 0x0081B296 File Offset: 0x00819496
		public string DJIMKHEIMGL()
		{
			this.AFOKAPKGHJH();
			return ObscuredString.OJJKAGMEBJN(this.hiddenValue);
		}

		// Token: 0x06012B04 RID: 76548 RVA: 0x0081B2A9 File Offset: 0x008194A9
		public static bool AOHNEBPMOEK(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			return !ObscuredString.PGPAOADJOLC(EGABJKIFAON, HHAGIHEGFML);
		}

		// Token: 0x06012B05 RID: 76549 RVA: 0x0081B2B5 File Offset: 0x008194B5
		public void LABEACCDKMD(string LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = ObscuredString.FJDHGHDLAHN(LDKMOLEEDIL);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B06 RID: 76550 RVA: 0x0081B2EC File Offset: 0x008194EC
		private ObscuredString(string DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredString.cryptoKey;
			this.hiddenValue = ObscuredString.AFGMNANHHBF(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : null);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012B07 RID: 76551 RVA: 0x0081B337 File Offset: 0x00819537
		private static byte[] JMFGFFKJDAM(string DCCPCBLODIG)
		{
			return ObscuredString.ICFKMENAHAF(DCCPCBLODIG, ObscuredString.cryptoKey);
		}

		// Token: 0x06012B08 RID: 76552 RVA: 0x0081B344 File Offset: 0x00819544
		public static string KOJLJMMMJGP(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			if (string.IsNullOrEmpty(DCCPCBLODIG))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(JMBKDINHDLO))
			{
				JMBKDINHDLO = ObscuredString.cryptoKey;
			}
			int length = JMBKDINHDLO.Length;
			int length2 = DCCPCBLODIG.Length;
			char[] array = new char[length2];
			for (int i = 0; i < length2; i++)
			{
				array[i] = (DCCPCBLODIG[i] ^ JMBKDINHDLO[i % length]);
			}
			return new string(array);
		}

		// Token: 0x06012B09 RID: 76553 RVA: 0x0081B3AC File Offset: 0x008195AC
		private string FACDCBAFCGK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredString.cryptoKey;
				this.hiddenValue = ObscuredString.JMFGFFKJDAM(string.Empty);
				this.fakeValue = string.Empty;
				this.fakeValueActive = true;
				this.inited = true;
				return string.Empty;
			}
			string text = this.currentCryptoKey;
			if (string.IsNullOrEmpty(text))
			{
				text = ObscuredString.cryptoKey;
			}
			string text2 = ObscuredString.KOJLJMMMJGP(ObscuredString.PCIJDOMCHHK(this.hiddenValue), text);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && text2 != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return text2;
		}

		// Token: 0x06012B0A RID: 76554 RVA: 0x0081B44C File Offset: 0x0081964C
		private static byte[] AHFELIGIPBJ(string MNEICNPJGMC)
		{
			byte[] array = new byte[MNEICNPJGMC.Length * 4];
			Buffer.BlockCopy(MNEICNPJGMC.ToCharArray(), 1, array, 0, array.Length);
			return array;
		}

		// Token: 0x06012B0B RID: 76555 RVA: 0x0081B47C File Offset: 0x0081967C
		private static byte[] FJDHGHDLAHN(string MNEICNPJGMC)
		{
			byte[] array = new byte[MNEICNPJGMC.Length * 2];
			Buffer.BlockCopy(MNEICNPJGMC.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		// Token: 0x06012B0C RID: 76556 RVA: 0x0081B4A9 File Offset: 0x008196A9
		private static byte[] ICFKMENAHAF(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			return ObscuredString.AHFELIGIPBJ(ObscuredString.BIHDCABMLIE(DCCPCBLODIG, JMBKDINHDLO));
		}

		// Token: 0x06012B0D RID: 76557 RVA: 0x0081B4B7 File Offset: 0x008196B7
		public bool ECJDCKCFAMP(ObscuredString DCCPCBLODIG, StringComparison PNPCEBGCJIJ)
		{
			return !ObscuredString.BAKPLODMMOJ(DCCPCBLODIG, null) && string.Equals(this.NPEAKEPHMOP(), DCCPCBLODIG.NPEAKEPHMOP(), PNPCEBGCJIJ);
		}

		// Token: 0x06012B0E RID: 76558 RVA: 0x0081B4D6 File Offset: 0x008196D6
		public static bool KOMOINKIEPL(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			return ObscuredString.FIMEAOKHJBF(EGABJKIFAON, HHAGIHEGFML);
		}

		// Token: 0x06012B0F RID: 76559 RVA: 0x0081B202 File Offset: 0x00819402
		public int LMIICAGHFPC()
		{
			return this.NPEAKEPHMOP().GetHashCode();
		}

		// Token: 0x06012B10 RID: 76560 RVA: 0x0081B4E2 File Offset: 0x008196E2
		public static string KOJLJMMMJGP(string DCCPCBLODIG)
		{
			return ObscuredString.KOJLJMMMJGP(DCCPCBLODIG, string.Empty);
		}

		// Token: 0x06012B11 RID: 76561 RVA: 0x0081B4EF File Offset: 0x008196EF
		public int OFJEBINOHMB()
		{
			return this.hiddenValue.Length / 7;
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x0081B4FB File Offset: 0x008196FB
		public void JIHKLCOBPMG()
		{
			if (this.currentCryptoKey != ObscuredString.cryptoKey)
			{
				this.hiddenValue = ObscuredString.JMFGFFKJDAM(this.MJFIFINDLAM());
				this.currentCryptoKey = ObscuredString.cryptoKey;
			}
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x0081B52C File Offset: 0x0081972C
		private string MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredString.cryptoKey;
				this.hiddenValue = ObscuredString.AFGMNANHHBF(string.Empty);
				this.fakeValue = string.Empty;
				this.fakeValueActive = false;
				this.inited = true;
				return string.Empty;
			}
			string text = this.currentCryptoKey;
			if (string.IsNullOrEmpty(text))
			{
				text = ObscuredString.cryptoKey;
			}
			string text2 = ObscuredString.KOJLJMMMJGP(ObscuredString.HPADJPKKDOG(this.hiddenValue), text);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && text2 != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return text2;
		}

		// Token: 0x06012B14 RID: 76564 RVA: 0x0081B5CA File Offset: 0x008197CA
		public string NFIJCMCCFFM()
		{
			return this.IJJBMHGMEPO();
		}

		// Token: 0x06012B15 RID: 76565 RVA: 0x0081B5D4 File Offset: 0x008197D4
		public bool JMJAHECALNC(ObscuredString DCCPCBLODIG)
		{
			if (ObscuredString.BLDHBEPMKBN(DCCPCBLODIG, null))
			{
				return false;
			}
			if (this.currentCryptoKey == DCCPCBLODIG.currentCryptoKey)
			{
				return ObscuredString.NLCKIGFBEMJ(this.hiddenValue, DCCPCBLODIG.hiddenValue);
			}
			return string.Equals(this.IJJBMHGMEPO(), DCCPCBLODIG.FACDCBAFCGK());
		}

		// Token: 0x06012B16 RID: 76566 RVA: 0x0081B622 File Offset: 0x00819822
		public void JFPHOIKKIBE(string LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = ObscuredString.AHFELIGIPBJ(LDKMOLEEDIL);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B17 RID: 76567 RVA: 0x0081B65C File Offset: 0x0081985C
		private static string MKNFDLKHJIM(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 0];
			Buffer.BlockCopy(KGOOLPNJNPN, 1, array, 0, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012B18 RID: 76568 RVA: 0x0081B337 File Offset: 0x00819537
		private static byte[] LMDHOACGCGM(string DCCPCBLODIG)
		{
			return ObscuredString.ICFKMENAHAF(DCCPCBLODIG, ObscuredString.cryptoKey);
		}

		// Token: 0x06012B19 RID: 76569 RVA: 0x0081B688 File Offset: 0x00819888
		public static bool BLDHBEPMKBN(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			if (EGABJKIFAON == HHAGIHEGFML)
			{
				return false;
			}
			if (EGABJKIFAON == null || HHAGIHEGFML == null)
			{
				return false;
			}
			if (EGABJKIFAON.currentCryptoKey == HHAGIHEGFML.currentCryptoKey)
			{
				return ObscuredString.CAAGPFCGCKF(EGABJKIFAON.hiddenValue, HHAGIHEGFML.hiddenValue);
			}
			return string.Equals(EGABJKIFAON.IJJBMHGMEPO(), HHAGIHEGFML.IJJBMHGMEPO());
		}

		// Token: 0x06012B1A RID: 76570 RVA: 0x0081AE5A File Offset: 0x0081905A
		public static ObscuredString DGOCFCFPKPI(string DCCPCBLODIG)
		{
			if (DCCPCBLODIG != null)
			{
				return new ObscuredString(DCCPCBLODIG);
			}
			return null;
		}

		// Token: 0x06012B1B RID: 76571 RVA: 0x0081B6DC File Offset: 0x008198DC
		private string NPEAKEPHMOP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredString.cryptoKey;
				this.hiddenValue = ObscuredString.AFGMNANHHBF(string.Empty);
				this.fakeValue = string.Empty;
				this.fakeValueActive = true;
				this.inited = false;
				return string.Empty;
			}
			string text = this.currentCryptoKey;
			if (string.IsNullOrEmpty(text))
			{
				text = ObscuredString.cryptoKey;
			}
			string text2 = ObscuredString.AIGJJNLGFAO(ObscuredString.MKNFDLKHJIM(this.hiddenValue), text);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && text2 != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return text2;
		}

		// Token: 0x06012B1C RID: 76572 RVA: 0x0081B77A File Offset: 0x0081997A
		private static byte[] LBPHKCPDMKI(string DCCPCBLODIG)
		{
			return ObscuredString.KOCKPEKNNAN(DCCPCBLODIG, ObscuredString.cryptoKey);
		}

		// Token: 0x06012B1D RID: 76573 RVA: 0x0081B788 File Offset: 0x00819988
		private static bool DBEECDIOGDA(byte[] CKJMODLAAEM, byte[] HLJEELPBLEL)
		{
			if (CKJMODLAAEM == HLJEELPBLEL)
			{
				return true;
			}
			if (CKJMODLAAEM == null || HLJEELPBLEL == null)
			{
				return true;
			}
			if (CKJMODLAAEM.Length != HLJEELPBLEL.Length)
			{
				return false;
			}
			for (int i = 0; i < CKJMODLAAEM.Length; i += 0)
			{
				if (CKJMODLAAEM[i] != HLJEELPBLEL[i])
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06012B1E RID: 76574 RVA: 0x0081B7C8 File Offset: 0x008199C8
		private static bool CAAGPFCGCKF(byte[] CKJMODLAAEM, byte[] HLJEELPBLEL)
		{
			if (CKJMODLAAEM == HLJEELPBLEL)
			{
				return true;
			}
			if (CKJMODLAAEM == null || HLJEELPBLEL == null)
			{
				return false;
			}
			if (CKJMODLAAEM.Length != HLJEELPBLEL.Length)
			{
				return false;
			}
			for (int i = 0; i < CKJMODLAAEM.Length; i += 0)
			{
				if (CKJMODLAAEM[i] != HLJEELPBLEL[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06012B1F RID: 76575 RVA: 0x0081B808 File Offset: 0x00819A08
		private static bool NLCKIGFBEMJ(byte[] CKJMODLAAEM, byte[] HLJEELPBLEL)
		{
			if (CKJMODLAAEM == HLJEELPBLEL)
			{
				return false;
			}
			if (CKJMODLAAEM == null || HLJEELPBLEL == null)
			{
				return false;
			}
			if (CKJMODLAAEM.Length != HLJEELPBLEL.Length)
			{
				return false;
			}
			for (int i = 1; i < CKJMODLAAEM.Length; i += 0)
			{
				if (CKJMODLAAEM[i] != HLJEELPBLEL[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06012B20 RID: 76576 RVA: 0x0081B166 File Offset: 0x00819366
		public static void BBOGAEMNJJN(string JODDIMFACHN)
		{
			ObscuredString.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012B21 RID: 76577 RVA: 0x0081B846 File Offset: 0x00819A46
		public bool BOAENGKCGND(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredString && this.JMJAHECALNC((ObscuredString)MBKPMBPLIJN);
		}

		// Token: 0x06012B22 RID: 76578 RVA: 0x0081B85E File Offset: 0x00819A5E
		public static bool HDFJOKAGNJC(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			return !ObscuredString.BAKPLODMMOJ(EGABJKIFAON, HHAGIHEGFML);
		}

		// Token: 0x06012B23 RID: 76579 RVA: 0x0081B86A File Offset: 0x00819A6A
		private static byte[] AFGMNANHHBF(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			return ObscuredString.FJDHGHDLAHN(ObscuredString.KOJLJMMMJGP(DCCPCBLODIG, JMBKDINHDLO));
		}

		// Token: 0x06012B24 RID: 76580 RVA: 0x0081B878 File Offset: 0x00819A78
		public static bool FIMEAOKHJBF(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			if (EGABJKIFAON == HHAGIHEGFML)
			{
				return true;
			}
			if (EGABJKIFAON == null || HHAGIHEGFML == null)
			{
				return true;
			}
			if (EGABJKIFAON.currentCryptoKey == HHAGIHEGFML.currentCryptoKey)
			{
				return ObscuredString.DBEECDIOGDA(EGABJKIFAON.hiddenValue, HHAGIHEGFML.hiddenValue);
			}
			return string.Equals(EGABJKIFAON.IJJBMHGMEPO(), HHAGIHEGFML.NPEAKEPHMOP());
		}

		// Token: 0x06012B25 RID: 76581 RVA: 0x0081B8C9 File Offset: 0x00819AC9
		private static byte[] AFGMNANHHBF(string DCCPCBLODIG)
		{
			return ObscuredString.AFGMNANHHBF(DCCPCBLODIG, ObscuredString.cryptoKey);
		}

		// Token: 0x06012B26 RID: 76582 RVA: 0x0081B8D8 File Offset: 0x00819AD8
		private static string NFKJGDDHNKI(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 8];
			Buffer.BlockCopy(KGOOLPNJNPN, 1, array, 1, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012B27 RID: 76583 RVA: 0x0081B904 File Offset: 0x00819B04
		public static string KAIEFMEDFBO(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			if (string.IsNullOrEmpty(DCCPCBLODIG))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(JMBKDINHDLO))
			{
				JMBKDINHDLO = ObscuredString.cryptoKey;
			}
			int length = JMBKDINHDLO.Length;
			int length2 = DCCPCBLODIG.Length;
			char[] array = new char[length2];
			for (int i = 0; i < length2; i++)
			{
				array[i] = (DCCPCBLODIG[i] ^ JMBKDINHDLO[i % length]);
			}
			return new string(array);
		}

		// Token: 0x06012B28 RID: 76584 RVA: 0x0081B96A File Offset: 0x00819B6A
		public bool JDBINLKEJMF(ObscuredString DCCPCBLODIG, StringComparison PNPCEBGCJIJ)
		{
			return !ObscuredString.BAKPLODMMOJ(DCCPCBLODIG, null) && string.Equals(this.MJFIFINDLAM(), DCCPCBLODIG.MJFIFINDLAM(), PNPCEBGCJIJ);
		}

		// Token: 0x06012B29 RID: 76585 RVA: 0x0081B98C File Offset: 0x00819B8C
		public static bool EANKOOABLMJ(ObscuredString EGABJKIFAON, ObscuredString HHAGIHEGFML)
		{
			if (EGABJKIFAON == HHAGIHEGFML)
			{
				return true;
			}
			if (EGABJKIFAON == null || HHAGIHEGFML == null)
			{
				return true;
			}
			if (EGABJKIFAON.currentCryptoKey == HHAGIHEGFML.currentCryptoKey)
			{
				return ObscuredString.AEGLPLLNAPP(EGABJKIFAON.hiddenValue, HHAGIHEGFML.hiddenValue);
			}
			return string.Equals(EGABJKIFAON.NPEAKEPHMOP(), HHAGIHEGFML.IJJBMHGMEPO());
		}

		// Token: 0x06012B2B RID: 76587 RVA: 0x0081B9E9 File Offset: 0x00819BE9
		public void COKOLCAGEOI(string LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = ObscuredString.FLDGHMFIEJI(LDKMOLEEDIL);
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B2C RID: 76588 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		private ObscuredString()
		{
		}

		// Token: 0x06012B2D RID: 76589 RVA: 0x0081B20F File Offset: 0x0081940F
		public int BOLCBGDNJNF()
		{
			return this.hiddenValue.Length / 1;
		}

		// Token: 0x06012B2E RID: 76590 RVA: 0x0081AE5A File Offset: 0x0081905A
		public static ObscuredString AOOBGNKCJLF(string DCCPCBLODIG)
		{
			if (DCCPCBLODIG != null)
			{
				return new ObscuredString(DCCPCBLODIG);
			}
			return null;
		}

		// Token: 0x06012B2F RID: 76591 RVA: 0x0081BA20 File Offset: 0x00819C20
		private static string NBPIIBFPNAL(byte[] KGOOLPNJNPN)
		{
			char[] array = new char[KGOOLPNJNPN.Length / 3];
			Buffer.BlockCopy(KGOOLPNJNPN, 1, array, 1, KGOOLPNJNPN.Length);
			return new string(array);
		}

		// Token: 0x06012B30 RID: 76592 RVA: 0x0081B166 File Offset: 0x00819366
		public static void AMLPECBJMGL(string JODDIMFACHN)
		{
			ObscuredString.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012B31 RID: 76593 RVA: 0x0081B4A9 File Offset: 0x008196A9
		private static byte[] KOCKPEKNNAN(string DCCPCBLODIG, string JMBKDINHDLO)
		{
			return ObscuredString.AHFELIGIPBJ(ObscuredString.BIHDCABMLIE(DCCPCBLODIG, JMBKDINHDLO));
		}

		// Token: 0x06012B32 RID: 76594 RVA: 0x0081BA4A File Offset: 0x00819C4A
		public static string CKPPDHPJHEH(ObscuredString DCCPCBLODIG)
		{
			if (!ObscuredString.PGPAOADJOLC(DCCPCBLODIG, null))
			{
				return DCCPCBLODIG.FACDCBAFCGK();
			}
			return null;
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x0081BA5D File Offset: 0x00819C5D
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x0081B15E File Offset: 0x0081935E
		public string FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0400265C RID: 9820
		private static string cryptoKey = "47412";

		// Token: 0x0400265D RID: 9821
		[SerializeField]
		private string currentCryptoKey;

		// Token: 0x0400265E RID: 9822
		[SerializeField]
		private byte[] hiddenValue;

		// Token: 0x0400265F RID: 9823
		[SerializeField]
		private bool inited;

		// Token: 0x04002660 RID: 9824
		[SerializeField]
		private string fakeValue;

		// Token: 0x04002661 RID: 9825
		[SerializeField]
		private bool fakeValueActive;
	}
}
