using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057C RID: 1404
	[Serializable]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		// Token: 0x060125BD RID: 75197 RVA: 0x0080DC47 File Offset: 0x0080BE47
		public void ADOAONEOPKO()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.FANLIHFONNC(this.MJFIFINDLAM(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x060125BE RID: 75198 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte GDFPAOMNGBL(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x0080DC89 File Offset: 0x0080BE89
		public byte FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x060125C0 RID: 75200 RVA: 0x0080DC91 File Offset: 0x0080BE91
		public void ILPJJJDLOGP(byte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.OHBABIDAIPJ();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060125C1 RID: 75201 RVA: 0x0080DCC4 File Offset: 0x0080BEC4
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060125C2 RID: 75202 RVA: 0x0080DCE0 File Offset: 0x0080BEE0
		public string EDBCGCIHHKA(IFormatProvider MCGFPOIAPGJ)
		{
			return this.CICALABIDIK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060125C3 RID: 75203 RVA: 0x0080DC89 File Offset: 0x0080BE89
		public byte NAICOFCGNCP()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x060125C4 RID: 75204 RVA: 0x0080DCFC File Offset: 0x0080BEFC
		public string KBHGJLAEMFH()
		{
			return this.LIDDKKIDNEC().ToString();
		}

		// Token: 0x060125C5 RID: 75205 RVA: 0x0080DD18 File Offset: 0x0080BF18
		public static ObscuredByte BLOKEMNKAKO(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.CICALABIDIK() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.GDFPAOMNGBL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = true;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125C6 RID: 75206 RVA: 0x0080DD65 File Offset: 0x0080BF65
		public void JJFEHPICEGJ()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.GDFPAOMNGBL(this.CICALABIDIK(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x060125C7 RID: 75207 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte FIFANIBLPJO(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060125C8 RID: 75208 RVA: 0x0080DD95 File Offset: 0x0080BF95
		public static byte GOOIABGKMHK(ObscuredByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060125C9 RID: 75209 RVA: 0x0080DDA0 File Offset: 0x0080BFA0
		public string NIDKKALEJIM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060125CA RID: 75210 RVA: 0x0080DDC0 File Offset: 0x0080BFC0
		public static ObscuredByte MACGDBEEIEC(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.CICALABIDIK() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.KKLKBBIFGBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125CB RID: 75211 RVA: 0x0080DE0D File Offset: 0x0080C00D
		public static ObscuredByte GOOIABGKMHK(byte DCCPCBLODIG)
		{
			return new ObscuredByte(DCCPCBLODIG);
		}

		// Token: 0x060125CC RID: 75212 RVA: 0x0080DE18 File Offset: 0x0080C018
		public string HGANAOPCKFC(string LJCEDKCLBDB)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060125CD RID: 75213 RVA: 0x0080DE34 File Offset: 0x0080C034
		public void BENABCDOLID()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.GDFPAOMNGBL(this.LIDDKKIDNEC(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x060125CE RID: 75214 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte JDHGANNHDAP(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060125CF RID: 75215 RVA: 0x0080DE64 File Offset: 0x0080C064
		public int MJJAIKCEPCL()
		{
			return this.LIDDKKIDNEC().GetHashCode();
		}

		// Token: 0x060125D0 RID: 75216 RVA: 0x0080DE80 File Offset: 0x0080C080
		public string HADJJLJNBOE()
		{
			return this.CICALABIDIK().ToString();
		}

		// Token: 0x060125D1 RID: 75217 RVA: 0x0080DE9C File Offset: 0x0080C09C
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060125D2 RID: 75218 RVA: 0x0080DEBC File Offset: 0x0080C0BC
		public int NMOAOIMABJK()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060125D3 RID: 75219 RVA: 0x0080DED8 File Offset: 0x0080C0D8
		public int HDEKHELDLCB()
		{
			return this.LIDDKKIDNEC().GetHashCode();
		}

		// Token: 0x060125D4 RID: 75220 RVA: 0x0080DEF4 File Offset: 0x0080C0F4
		public bool Equals(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060125D5 RID: 75221 RVA: 0x0080DF44 File Offset: 0x0080C144
		public string DHCBHNAAJKI()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060125D6 RID: 75222 RVA: 0x0080DF60 File Offset: 0x0080C160
		public string IIBPDPDEBNA(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LIDDKKIDNEC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060125D7 RID: 75223 RVA: 0x0080DF7C File Offset: 0x0080C17C
		public byte LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060125D8 RID: 75224 RVA: 0x0080DF8C File Offset: 0x0080C18C
		public string AGFCIEALPEM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.OHBABIDAIPJ().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060125D9 RID: 75225 RVA: 0x0080DFA8 File Offset: 0x0080C1A8
		public bool DFEOCFMHLHO(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.OFGDHGEEMFO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060125DA RID: 75226 RVA: 0x0080DFF6 File Offset: 0x0080C1F6
		public byte DNCIEPFFHPK()
		{
			return this.CICALABIDIK();
		}

		// Token: 0x060125DB RID: 75227 RVA: 0x0080E000 File Offset: 0x0080C200
		public string AHFDMABJGOL(string LJCEDKCLBDB)
		{
			return this.LIDDKKIDNEC().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060125DC RID: 75228 RVA: 0x0080E01C File Offset: 0x0080C21C
		public static byte JNAEIIPIEAL(byte DCCPCBLODIG)
		{
			return ObscuredByte.JDHGANNHDAP(DCCPCBLODIG, 1);
		}

		// Token: 0x060125DD RID: 75229 RVA: 0x0080E028 File Offset: 0x0080C228
		public int KGOHJKEKKON()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060125DE RID: 75230 RVA: 0x0080E043 File Offset: 0x0080C243
		public void IJIOKAKFCCF()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.OFGDHGEEMFO(this.OHBABIDAIPJ(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x060125DF RID: 75231 RVA: 0x0080E074 File Offset: 0x0080C274
		public void ONKCFFKECJA()
		{
			byte dccpcblodig = this.LIDDKKIDNEC();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -13);
			this.hiddenValue = ObscuredByte.GDFPAOMNGBL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060125E0 RID: 75232 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void EJFEKBLJFOK(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060125E1 RID: 75233 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void HLPHKANCHHL(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060125E2 RID: 75234 RVA: 0x0080E0B4 File Offset: 0x0080C2B4
		public bool DIJEJKHBKOF(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.FIFANIBLPJO(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.KKLKBBIFGBF(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060125E3 RID: 75235 RVA: 0x0080E104 File Offset: 0x0080C304
		public string NMBKBGNBAEM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060125E4 RID: 75236 RVA: 0x0080E120 File Offset: 0x0080C320
		public static ObscuredByte FPNGOOLNLHK(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.LIDDKKIDNEC() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.JDHGANNHDAP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125E5 RID: 75237 RVA: 0x0080E16D File Offset: 0x0080C36D
		public void DGHBLGPMJMM()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.JDHGANNHDAP(this.MJFIFINDLAM(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x060125E6 RID: 75238 RVA: 0x0080E1A0 File Offset: 0x0080C3A0
		public string PDMPLOPPLBI(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060125E7 RID: 75239 RVA: 0x0080E1BC File Offset: 0x0080C3BC
		public bool AKILLGNGBPB(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.JDHGANNHDAP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060125E8 RID: 75240 RVA: 0x0080DE0D File Offset: 0x0080C00D
		public static ObscuredByte APFECJKCPPB(byte DCCPCBLODIG)
		{
			return new ObscuredByte(DCCPCBLODIG);
		}

		// Token: 0x060125E9 RID: 75241 RVA: 0x0080E20C File Offset: 0x0080C40C
		public int KANDOCKKGBO()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060125EA RID: 75242 RVA: 0x0080E228 File Offset: 0x0080C428
		public static ObscuredByte INDELOJJICF(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.OHBABIDAIPJ() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.GDFPAOMNGBL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125EB RID: 75243 RVA: 0x0080DD95 File Offset: 0x0080BF95
		public static byte KHJPCCFDJPA(ObscuredByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060125EC RID: 75244 RVA: 0x0080E275 File Offset: 0x0080C475
		public byte NPKFOPJNPGH()
		{
			return this.LIDDKKIDNEC();
		}

		// Token: 0x060125ED RID: 75245 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte KOJLJMMMJGP(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060125EE RID: 75246 RVA: 0x0080DE0D File Offset: 0x0080C00D
		public static ObscuredByte IJMOCOKPGEG(byte DCCPCBLODIG)
		{
			return new ObscuredByte(DCCPCBLODIG);
		}

		// Token: 0x060125EF RID: 75247 RVA: 0x0080E280 File Offset: 0x0080C480
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060125F0 RID: 75248 RVA: 0x0080E29C File Offset: 0x0080C49C
		public static ObscuredByte DPCKAKGMBMN(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.OHBABIDAIPJ() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.OFGDHGEEMFO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125F1 RID: 75249 RVA: 0x0080E2EC File Offset: 0x0080C4EC
		public int BCOLHBCLOPK()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060125F2 RID: 75250 RVA: 0x0080E307 File Offset: 0x0080C507
		public byte EMJGJDMIDFC()
		{
			this.JBLNCADGCON();
			return this.hiddenValue;
		}

		// Token: 0x060125F3 RID: 75251 RVA: 0x0080E318 File Offset: 0x0080C518
		public static ObscuredByte EGIEJOKKMGP(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.CICALABIDIK() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = true;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060125F4 RID: 75252 RVA: 0x0080E368 File Offset: 0x0080C568
		public string IBLEHFEBIMG()
		{
			return this.LIDDKKIDNEC().ToString();
		}

		// Token: 0x060125F5 RID: 75253 RVA: 0x0080E383 File Offset: 0x0080C583
		public void PLDPJECNBNB(byte LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.CICALABIDIK();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060125F6 RID: 75254 RVA: 0x0080E3B5 File Offset: 0x0080C5B5
		public static byte HCJBAFMJBBJ(byte DCCPCBLODIG)
		{
			return ObscuredByte.FANLIHFONNC(DCCPCBLODIG, 1);
		}

		// Token: 0x060125F7 RID: 75255 RVA: 0x0080E3C0 File Offset: 0x0080C5C0
		private byte OHBABIDAIPJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredByte.cryptoKey;
				this.hiddenValue = ObscuredByte.IPDLFNBDJOB(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			byte b = ObscuredByte.KKLKBBIFGBF(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x060125F8 RID: 75256 RVA: 0x0080E307 File Offset: 0x0080C507
		public byte KGAFKNELBAK()
		{
			this.JBLNCADGCON();
			return this.hiddenValue;
		}

		// Token: 0x060125F9 RID: 75257 RVA: 0x0080DE0D File Offset: 0x0080C00D
		public static ObscuredByte ADDGCGDPMDL(byte DCCPCBLODIG)
		{
			return new ObscuredByte(DCCPCBLODIG);
		}

		// Token: 0x060125FA RID: 75258 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void DNGPGIOFIEH(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060125FB RID: 75259 RVA: 0x0080E438 File Offset: 0x0080C638
		public bool PADMCNBDIJO(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.KKLKBBIFGBF(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.FIFANIBLPJO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060125FD RID: 75261 RVA: 0x0080E492 File Offset: 0x0080C692
		public static byte ALBBIEKFLJF(ObscuredByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.LIDDKKIDNEC();
		}

		// Token: 0x060125FE RID: 75262 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte OFGDHGEEMFO(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060125FF RID: 75263 RVA: 0x0080E49C File Offset: 0x0080C69C
		public string DDLFNJEJPBP(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LIDDKKIDNEC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012600 RID: 75264 RVA: 0x0080E4B8 File Offset: 0x0080C6B8
		public string EOAGNAKKDMK(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012601 RID: 75265 RVA: 0x0080E4D8 File Offset: 0x0080C6D8
		public bool CEGNBFIEMNK(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.KKLKBBIFGBF(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.FIFANIBLPJO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012602 RID: 75266 RVA: 0x0080E528 File Offset: 0x0080C728
		public string DIJJDHMMGCA(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012603 RID: 75267 RVA: 0x0080E545 File Offset: 0x0080C745
		public void LABEACCDKMD(byte LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012604 RID: 75268 RVA: 0x0080E577 File Offset: 0x0080C777
		public static byte IPDLFNBDJOB(byte DCCPCBLODIG)
		{
			return ObscuredByte.GDFPAOMNGBL(DCCPCBLODIG, 0);
		}

		// Token: 0x06012605 RID: 75269 RVA: 0x0080E580 File Offset: 0x0080C780
		public void JBLNCADGCON()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.FANLIHFONNC(this.CICALABIDIK(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x06012606 RID: 75270 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void GNPMCGGABBM(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012607 RID: 75271 RVA: 0x0080E5B0 File Offset: 0x0080C7B0
		public string BFOFMHGHALI(string LJCEDKCLBDB)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012608 RID: 75272 RVA: 0x0080E5CC File Offset: 0x0080C7CC
		public void JOMEOGFNEMF(byte LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.LIDDKKIDNEC();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012609 RID: 75273 RVA: 0x0080E5FE File Offset: 0x0080C7FE
		public static byte JMGCDPCPJIJ(byte DCCPCBLODIG)
		{
			return ObscuredByte.KOJLJMMMJGP(DCCPCBLODIG, 1);
		}

		// Token: 0x0601260A RID: 75274 RVA: 0x0080E608 File Offset: 0x0080C808
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x0601260B RID: 75275 RVA: 0x0080DC89 File Offset: 0x0080BE89
		public byte JNIKFPNOJBB()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0601260C RID: 75276 RVA: 0x0080E624 File Offset: 0x0080C824
		public static ObscuredByte DPCDNMHLOJF(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x0601260D RID: 75277 RVA: 0x0080E674 File Offset: 0x0080C874
		public bool MKIDEGCGDAM(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.FIFANIBLPJO(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.GDFPAOMNGBL(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601260E RID: 75278 RVA: 0x0080E6C4 File Offset: 0x0080C8C4
		private byte LIDDKKIDNEC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredByte.cryptoKey;
				this.hiddenValue = ObscuredByte.HCJBAFMJBBJ(0);
				this.fakeValue = 1;
				this.fakeValueActive = true;
				this.inited = false;
				return 1;
			}
			byte b = ObscuredByte.FIFANIBLPJO(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x0601260F RID: 75279 RVA: 0x0080E73C File Offset: 0x0080C93C
		public string CBPDHBKDMGC(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.LIDDKKIDNEC().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012610 RID: 75280 RVA: 0x0080E75C File Offset: 0x0080C95C
		private byte CICALABIDIK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredByte.cryptoKey;
				this.hiddenValue = ObscuredByte.KOJLJMMMJGP(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = false;
				return 1;
			}
			byte b = ObscuredByte.KKLKBBIFGBF(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x06012611 RID: 75281 RVA: 0x0080E7D4 File Offset: 0x0080C9D4
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x06012612 RID: 75282 RVA: 0x0080E804 File Offset: 0x0080CA04
		public bool GAAMGONJOGE(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.OFGDHGEEMFO(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.FIFANIBLPJO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012613 RID: 75283 RVA: 0x0080DD95 File Offset: 0x0080BF95
		public static byte CKPPDHPJHEH(ObscuredByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012614 RID: 75284 RVA: 0x0080E854 File Offset: 0x0080CA54
		public string OKJEDFNFDML(string LJCEDKCLBDB)
		{
			return this.CICALABIDIK().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012615 RID: 75285 RVA: 0x0080E870 File Offset: 0x0080CA70
		public void LAHMMCMAABF(byte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012616 RID: 75286 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte KKLKBBIFGBF(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012617 RID: 75287 RVA: 0x0080E8A4 File Offset: 0x0080CAA4
		public string NKFOGFFPKFN(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OHBABIDAIPJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012618 RID: 75288 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void HMPJOPABIHC(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012619 RID: 75289 RVA: 0x0080E8C1 File Offset: 0x0080CAC1
		public void EHPGKFFHJNL()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.KOJLJMMMJGP(this.OHBABIDAIPJ(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x0601261A RID: 75290 RVA: 0x0080E8F4 File Offset: 0x0080CAF4
		public void OJFAJIJBEFD()
		{
			byte dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, 255);
			this.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601261B RID: 75291 RVA: 0x0080E92C File Offset: 0x0080CB2C
		private ObscuredByte(byte DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredByte.cryptoKey;
			this.hiddenValue = ObscuredByte.KOJLJMMMJGP(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x0601261C RID: 75292 RVA: 0x0080DF7C File Offset: 0x0080C17C
		public byte CABOFEBBDNJ()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x0601261D RID: 75293 RVA: 0x0080E974 File Offset: 0x0080CB74
		public void NNIOEEFBHNE()
		{
			byte dccpcblodig = this.OHBABIDAIPJ();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -75);
			this.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601261E RID: 75294 RVA: 0x0080E9AC File Offset: 0x0080CBAC
		public int KMLDLHAFMJD()
		{
			return this.CICALABIDIK().GetHashCode();
		}

		// Token: 0x0601261F RID: 75295 RVA: 0x0080E9C7 File Offset: 0x0080CBC7
		public void FILOLBINFMM(byte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.OHBABIDAIPJ();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012620 RID: 75296 RVA: 0x0080DE0D File Offset: 0x0080C00D
		public static ObscuredByte AGMCCNHHFFH(byte DCCPCBLODIG)
		{
			return new ObscuredByte(DCCPCBLODIG);
		}

		// Token: 0x06012621 RID: 75297 RVA: 0x0080E9FC File Offset: 0x0080CBFC
		public string JHGPBNCOHHH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012622 RID: 75298 RVA: 0x0080EA18 File Offset: 0x0080CC18
		public string MIHCFECAIAD()
		{
			return this.LIDDKKIDNEC().ToString();
		}

		// Token: 0x06012623 RID: 75299 RVA: 0x0080EA33 File Offset: 0x0080CC33
		public static byte KOJLJMMMJGP(byte DCCPCBLODIG)
		{
			return ObscuredByte.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012624 RID: 75300 RVA: 0x0080EA3C File Offset: 0x0080CC3C
		public string MFPEPELOHBL()
		{
			return this.OHBABIDAIPJ().ToString();
		}

		// Token: 0x06012625 RID: 75301 RVA: 0x0080DC89 File Offset: 0x0080BE89
		public byte BBHFOFMJNMO()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012626 RID: 75302 RVA: 0x0080EA58 File Offset: 0x0080CC58
		public static ObscuredByte CFEOECABJNA(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.LIDDKKIDNEC() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = true;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012627 RID: 75303 RVA: 0x0080E275 File Offset: 0x0080C475
		public byte IIKIJFGDPDC()
		{
			return this.LIDDKKIDNEC();
		}

		// Token: 0x06012628 RID: 75304 RVA: 0x0080EAA5 File Offset: 0x0080CCA5
		public bool PLMGGFDKEKK(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredByte && this.AKILLGNGBPB((ObscuredByte)MBKPMBPLIJN);
		}

		// Token: 0x06012629 RID: 75305 RVA: 0x0080EAC0 File Offset: 0x0080CCC0
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x0601262A RID: 75306 RVA: 0x0080EADB File Offset: 0x0080CCDB
		public static byte KFJIIPOIBDG(byte DCCPCBLODIG)
		{
			return ObscuredByte.OFGDHGEEMFO(DCCPCBLODIG, 0);
		}

		// Token: 0x0601262B RID: 75307 RVA: 0x0080EAE4 File Offset: 0x0080CCE4
		public string GJCCJEINDDC(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LIDDKKIDNEC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x0601262C RID: 75308 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void BBOGAEMNJJN(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601262D RID: 75309 RVA: 0x0080EB00 File Offset: 0x0080CD00
		public void DGPDHPCDJEC()
		{
			byte dccpcblodig = this.LIDDKKIDNEC();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -144);
			this.hiddenValue = ObscuredByte.FANLIHFONNC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601262E RID: 75310 RVA: 0x0080EB38 File Offset: 0x0080CD38
		public void GBAPEMIGFJC()
		{
			if (this.currentCryptoKey != ObscuredByte.cryptoKey)
			{
				this.hiddenValue = ObscuredByte.JDHGANNHDAP(this.CICALABIDIK(), ObscuredByte.cryptoKey);
				this.currentCryptoKey = ObscuredByte.cryptoKey;
			}
		}

		// Token: 0x0601262F RID: 75311 RVA: 0x0080EB68 File Offset: 0x0080CD68
		private byte MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredByte.cryptoKey;
				this.hiddenValue = ObscuredByte.KOJLJMMMJGP(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			byte b = ObscuredByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x06012630 RID: 75312 RVA: 0x0080EBE0 File Offset: 0x0080CDE0
		public void FKPBCEAEAGD()
		{
			byte dccpcblodig = this.LIDDKKIDNEC();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(0, 188);
			this.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012631 RID: 75313 RVA: 0x0080DC77 File Offset: 0x0080BE77
		public static byte FANLIHFONNC(byte DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012632 RID: 75314 RVA: 0x0080EC18 File Offset: 0x0080CE18
		public static ObscuredByte HIBLFIAPCJE(ObscuredByte NFKFMIIAKFN)
		{
			byte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012633 RID: 75315 RVA: 0x0080EC65 File Offset: 0x0080CE65
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredByte && this.Equals((ObscuredByte)MBKPMBPLIJN);
		}

		// Token: 0x06012634 RID: 75316 RVA: 0x0080EC7D File Offset: 0x0080CE7D
		public byte IEHGMLIAAAF()
		{
			this.GBAPEMIGFJC();
			return this.hiddenValue;
		}

		// Token: 0x06012635 RID: 75317 RVA: 0x0080EC8C File Offset: 0x0080CE8C
		public bool MBEJDANGDKJ(ObscuredByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredByte.OFGDHGEEMFO(this.hiddenValue, this.currentCryptoKey) == ObscuredByte.KKLKBBIFGBF(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012636 RID: 75318 RVA: 0x0080E0AC File Offset: 0x0080C2AC
		public static void HMFHIAPIFCG(byte JODDIMFACHN)
		{
			ObscuredByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012637 RID: 75319 RVA: 0x0080ECDC File Offset: 0x0080CEDC
		public string PINLAFIAGGJ()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012638 RID: 75320 RVA: 0x0080EC7D File Offset: 0x0080CE7D
		public byte IFDAPNAJLNG()
		{
			this.GBAPEMIGFJC();
			return this.hiddenValue;
		}

		// Token: 0x040025EB RID: 9707
		private static byte cryptoKey = 244;

		// Token: 0x040025EC RID: 9708
		private byte currentCryptoKey;

		// Token: 0x040025ED RID: 9709
		private byte hiddenValue;

		// Token: 0x040025EE RID: 9710
		private bool inited;

		// Token: 0x040025EF RID: 9711
		private byte fakeValue;

		// Token: 0x040025F0 RID: 9712
		private bool fakeValueActive;
	}
}
