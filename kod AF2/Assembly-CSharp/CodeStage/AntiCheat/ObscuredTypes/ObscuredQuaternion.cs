using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200058A RID: 1418
	[Serializable]
	public struct ObscuredQuaternion
	{
		// Token: 0x0601297C RID: 76156 RVA: 0x008177BC File Offset: 0x008159BC
		public static Quaternion DHPGAJEHAFD(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			Quaternion result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.z, JMBKDINHDLO);
			result.w = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.w, JMBKDINHDLO);
			return result;
		}

		// Token: 0x0601297D RID: 76157 RVA: 0x00817820 File Offset: 0x00815A20
		public string EFODDEDDHCE()
		{
			return this.ENEENENBJJL().ToString();
		}

		// Token: 0x0601297E RID: 76158 RVA: 0x00817841 File Offset: 0x00815A41
		public static ObscuredQuaternion.RawEncryptedQuaternion AEPONFAFHAF(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.HKNJMBMKGFN(DCCPCBLODIG, 0);
		}

		// Token: 0x0601297F RID: 76159 RVA: 0x0081784C File Offset: 0x00815A4C
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012980 RID: 76160 RVA: 0x00817868 File Offset: 0x00815A68
		public void PKNHAAGHLLA()
		{
			Quaternion dccpcblodig = this.ENEENENBJJL();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-168, 122);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012981 RID: 76161 RVA: 0x008178AB File Offset: 0x00815AAB
		public static Quaternion DHPGAJEHAFD(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012982 RID: 76162 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion HBJHGHOKFDK(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x06012983 RID: 76163 RVA: 0x008178D4 File Offset: 0x00815AD4
		public static Quaternion CCKAOPHIKGN(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.KOGNLJBGPCP();
		}

		// Token: 0x06012984 RID: 76164 RVA: 0x008178DD File Offset: 0x00815ADD
		public void LABEACCDKMD(ObscuredQuaternion.RawEncryptedQuaternion LDKMOLEEDIL)
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

		// Token: 0x06012985 RID: 76165 RVA: 0x00817910 File Offset: 0x00815B10
		private Quaternion CMIOPAENPBH()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.CJNFOIOPHLP(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = true;
				this.inited = false;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && !this.BJPDFIDHHLG(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x06012986 RID: 76166 RVA: 0x008179FC File Offset: 0x00815BFC
		public static ObscuredQuaternion.RawEncryptedQuaternion HBJHGHOKFDK(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x06012987 RID: 76167 RVA: 0x00817A05 File Offset: 0x00815C05
		public void BLKMLEOBPIA()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.DIMCMMALABD(this.CMIOPAENPBH(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x06012988 RID: 76168 RVA: 0x00817A35 File Offset: 0x00815C35
		public static ObscuredQuaternion.RawEncryptedQuaternion EKKPPKGFFCH(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.GGIBCLJMFLF(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x00817A58 File Offset: 0x00815C58
		public void ACDNFFBFKOB()
		{
			Quaternion dccpcblodig = this.OOEKLDBGDBB();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-155, -124);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HDGEMCGKMNC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601298A RID: 76170 RVA: 0x00817A9C File Offset: 0x00815C9C
		public ObscuredQuaternion(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, float OICADHEPMLH)
		{
			this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(OCNGPCPMCPM, ADMFAEOOOHD, DOCOLPILEAF, OICADHEPMLH, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue.x = OCNGPCPMCPM;
				this.fakeValue.y = ADMFAEOOOHD;
				this.fakeValue.z = DOCOLPILEAF;
				this.fakeValue.w = OICADHEPMLH;
				this.fakeValueActive = true;
			}
			else
			{
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = false;
			}
			this.inited = true;
		}

		// Token: 0x0601298B RID: 76171 RVA: 0x00817B24 File Offset: 0x00815D24
		private Quaternion OOEKLDBGDBB()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.NLAFMDDKHBK(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = true;
				this.inited = true;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && !this.ICHACFFGCHH(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x0601298C RID: 76172 RVA: 0x00817C10 File Offset: 0x00815E10
		public ObscuredQuaternion.RawEncryptedQuaternion BHNJJGIMDLO()
		{
			this.JLAIFJAABML();
			return this.hiddenValue;
		}

		// Token: 0x0601298D RID: 76173 RVA: 0x00817C20 File Offset: 0x00815E20
		private Quaternion MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = false;
				this.inited = true;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && !this.DOFCLGPOHEA(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x0601298E RID: 76174 RVA: 0x00817D0C File Offset: 0x00815F0C
		public static Quaternion GJJDHACFMFI(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			Quaternion result;
			result.x = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.z, JMBKDINHDLO);
			result.w = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.w, JMBKDINHDLO);
			return result;
		}

		// Token: 0x0601298F RID: 76175 RVA: 0x00817D70 File Offset: 0x00815F70
		public Quaternion DPNALKKDNAL()
		{
			return this.KOGNLJBGPCP();
		}

		// Token: 0x06012990 RID: 76176 RVA: 0x00817D78 File Offset: 0x00815F78
		public string NDCLLIMPLEE()
		{
			return this.CMIOPAENPBH().ToString();
		}

		// Token: 0x06012991 RID: 76177 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void BCHNICEJCDJ(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012992 RID: 76178 RVA: 0x00817DA4 File Offset: 0x00815FA4
		private Quaternion LKALEJPLGII()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.CJNFOIOPHLP(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = false;
				this.inited = false;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && !this.NBCHIFPDINB(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x06012993 RID: 76179 RVA: 0x00817E90 File Offset: 0x00816090
		public string JJPMKNKFPPN()
		{
			return this.CMIOPAENPBH().ToString();
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x00817EB1 File Offset: 0x008160B1
		public static ObscuredQuaternion.RawEncryptedQuaternion PGOAHMBLNAF(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.NHMMAGKBAFM(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x008178D4 File Offset: 0x00815AD4
		public static Quaternion DMILLCHBEAG(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.KOGNLJBGPCP();
		}

		// Token: 0x06012996 RID: 76182 RVA: 0x00817ED1 File Offset: 0x008160D1
		public static ObscuredQuaternion.RawEncryptedQuaternion EDDOPACHPFB(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.HKNJMBMKGFN(DCCPCBLODIG, 1);
		}

		// Token: 0x06012997 RID: 76183 RVA: 0x00817EDC File Offset: 0x008160DC
		public void IFDDEMKGOLJ()
		{
			Quaternion dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(194, 24);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HKNJMBMKGFN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012998 RID: 76184 RVA: 0x00817F20 File Offset: 0x00816120
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012999 RID: 76185 RVA: 0x00817F44 File Offset: 0x00816144
		public string OKJEDFNFDML(string LJCEDKCLBDB)
		{
			return this.AGFJMOFPGFF().ToString(LJCEDKCLBDB);
		}

		// Token: 0x0601299A RID: 76186 RVA: 0x00817A35 File Offset: 0x00815C35
		public static ObscuredQuaternion.RawEncryptedQuaternion HKNJMBMKGFN(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.GGIBCLJMFLF(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x0601299B RID: 76187 RVA: 0x00817D70 File Offset: 0x00815F70
		public Quaternion FGAKLMLIANB()
		{
			return this.KOGNLJBGPCP();
		}

		// Token: 0x0601299C RID: 76188 RVA: 0x00817F60 File Offset: 0x00816160
		public static Quaternion PKHLFLCPDJE(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.CCHHNABBGCF(DCCPCBLODIG, 0);
		}

		// Token: 0x0601299D RID: 76189 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void HGPBHAKPLLC(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601299E RID: 76190 RVA: 0x00817F6C File Offset: 0x0081616C
		public void KJBOPMELKGK()
		{
			Quaternion dccpcblodig = this.KOGNLJBGPCP();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(114, -182);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.PGOAHMBLNAF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601299F RID: 76191 RVA: 0x00817FAF File Offset: 0x008161AF
		public void LDBNCJAELGC()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.LNAAECIGKKL(this.OOEKLDBGDBB(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129A0 RID: 76192 RVA: 0x00817FE0 File Offset: 0x008161E0
		public static ObscuredQuaternion.RawEncryptedQuaternion NHMMAGKBAFM(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, float OICADHEPMLH, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			ObscuredQuaternion.RawEncryptedQuaternion result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.HBJHGHOKFDK(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			result.w = ObscuredFloat.ALHMMAGENAF(OICADHEPMLH, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129A1 RID: 76193 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion IACCCBJHJPL(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129A2 RID: 76194 RVA: 0x00818035 File Offset: 0x00816235
		public void DOBNIBDLPDC()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.EKKPPKGFFCH(this.MJFIFINDLAM(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129A3 RID: 76195 RVA: 0x00818068 File Offset: 0x00816268
		public string NKFOGFFPKFN(string LJCEDKCLBDB)
		{
			return this.AGFJMOFPGFF().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060129A4 RID: 76196 RVA: 0x00818084 File Offset: 0x00816284
		public static Quaternion GLHBFBMMGMK(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.GJJDHACFMFI(DCCPCBLODIG, 1);
		}

		// Token: 0x060129A6 RID: 76198 RVA: 0x008180A4 File Offset: 0x008162A4
		public static ObscuredQuaternion.RawEncryptedQuaternion NGGMBKEAILP(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, float OICADHEPMLH, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			ObscuredQuaternion.RawEncryptedQuaternion result;
			result.x = ObscuredFloat.ALHMMAGENAF(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.ALHMMAGENAF(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			result.w = ObscuredFloat.ALHMMAGENAF(OICADHEPMLH, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129A7 RID: 76199 RVA: 0x008180F9 File Offset: 0x008162F9
		public void MACKEHOHJMC()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x00818129 File Offset: 0x00816329
		public static Quaternion NHCGLOMINFK(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.OOEKLDBGDBB();
		}

		// Token: 0x060129A9 RID: 76201 RVA: 0x00818134 File Offset: 0x00816334
		public void COGHGNNAPKP()
		{
			Quaternion dccpcblodig = this.ENEENENBJJL();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-157, 58);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HDGEMCGKMNC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129AA RID: 76202 RVA: 0x00818178 File Offset: 0x00816378
		private ObscuredQuaternion(Quaternion DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : ObscuredQuaternion.identity);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x060129AB RID: 76203 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion ALHMMAGENAF(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129AC RID: 76204 RVA: 0x008181C1 File Offset: 0x008163C1
		public ObscuredQuaternion.RawEncryptedQuaternion LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060129AD RID: 76205 RVA: 0x008181D0 File Offset: 0x008163D0
		public void OJFAJIJBEFD()
		{
			Quaternion dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129AE RID: 76206 RVA: 0x00818213 File Offset: 0x00816413
		public static Quaternion DGOCFCFPKPI(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.LKALEJPLGII();
		}

		// Token: 0x060129AF RID: 76207 RVA: 0x0081821C File Offset: 0x0081641C
		public ObscuredQuaternion.RawEncryptedQuaternion PMAPIGACBLG()
		{
			this.EBNODGFPHEO();
			return this.hiddenValue;
		}

		// Token: 0x060129B0 RID: 76208 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void OHKBDEDEBKI(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060129B1 RID: 76209 RVA: 0x0081822C File Offset: 0x0081642C
		public void BOBMPBEOLKA()
		{
			Quaternion dccpcblodig = this.KOGNLJBGPCP();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-112, -66);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HDGEMCGKMNC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129B2 RID: 76210 RVA: 0x0081826F File Offset: 0x0081646F
		public Quaternion FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x060129B3 RID: 76211 RVA: 0x00818278 File Offset: 0x00816478
		private Quaternion KOGNLJBGPCP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.MMBGFPEPLDE(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = true;
				this.inited = true;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && !this.BJPDFIDHHLG(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x060129B4 RID: 76212 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion ONNPIMAJEKK(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129B5 RID: 76213 RVA: 0x00818364 File Offset: 0x00816564
		private bool BJPDFIDHHLG(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.ELOBJGIDGCP.quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129B6 RID: 76214 RVA: 0x008183D2 File Offset: 0x008165D2
		public void EBNODGFPHEO()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.PGOAHMBLNAF(this.LKALEJPLGII(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129B7 RID: 76215 RVA: 0x00818404 File Offset: 0x00816604
		private bool DOFCLGPOHEA(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.ELOBJGIDGCP.quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129B8 RID: 76216 RVA: 0x00818474 File Offset: 0x00816674
		public static Quaternion CCHHNABBGCF(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			Quaternion result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.z, JMBKDINHDLO);
			result.w = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.w, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129B9 RID: 76217 RVA: 0x008184D8 File Offset: 0x008166D8
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060129BA RID: 76218 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void GLJALOGDCJN(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060129BB RID: 76219 RVA: 0x008184FC File Offset: 0x008166FC
		public string OKEAOIBHKIN(string LJCEDKCLBDB)
		{
			return this.KOGNLJBGPCP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060129BC RID: 76220 RVA: 0x00818518 File Offset: 0x00816718
		public string GJCCJEINDDC(string LJCEDKCLBDB)
		{
			return this.OOEKLDBGDBB().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060129BD RID: 76221 RVA: 0x00818534 File Offset: 0x00816734
		public static ObscuredQuaternion GOOIABGKMHK(Quaternion DCCPCBLODIG)
		{
			return new ObscuredQuaternion(DCCPCBLODIG);
		}

		// Token: 0x060129BE RID: 76222 RVA: 0x0081853C File Offset: 0x0081673C
		public ObscuredQuaternion.RawEncryptedQuaternion DBDBBGDOJHM()
		{
			this.MACKEHOHJMC();
			return this.hiddenValue;
		}

		// Token: 0x060129BF RID: 76223 RVA: 0x0081854A File Offset: 0x0081674A
		public static ObscuredQuaternion.RawEncryptedQuaternion CJNFOIOPHLP(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.HDGEMCGKMNC(DCCPCBLODIG, 0);
		}

		// Token: 0x060129C0 RID: 76224 RVA: 0x00818554 File Offset: 0x00816754
		public void PGBMDHGINKI()
		{
			Quaternion dccpcblodig = this.OOEKLDBGDBB();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-64, -82);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.EKKPPKGFFCH(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129C1 RID: 76225 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion LNAAECIGKKL(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129C2 RID: 76226 RVA: 0x00818598 File Offset: 0x00816798
		private bool ICHACFFGCHH(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.BLJNHIFIBDC().quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129C3 RID: 76227 RVA: 0x00818608 File Offset: 0x00816808
		public int LMCMBIONPJI()
		{
			return this.OOEKLDBGDBB().GetHashCode();
		}

		// Token: 0x060129C4 RID: 76228 RVA: 0x00818629 File Offset: 0x00816829
		public static Quaternion INHIMIAHCMF(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.CBCAINFJGPK(DCCPCBLODIG, 1);
		}

		// Token: 0x060129C5 RID: 76229 RVA: 0x008178D4 File Offset: 0x00815AD4
		public static Quaternion MLDBHKECKJM(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.KOGNLJBGPCP();
		}

		// Token: 0x060129C6 RID: 76230 RVA: 0x00818632 File Offset: 0x00816832
		public void GGHPGBJFIFF(ObscuredQuaternion.RawEncryptedQuaternion LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.CMIOPAENPBH();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060129C7 RID: 76231 RVA: 0x00818664 File Offset: 0x00816864
		public static Quaternion LLAKCPPMMOI(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.GJJDHACFMFI(DCCPCBLODIG, 0);
		}

		// Token: 0x060129C8 RID: 76232 RVA: 0x00818670 File Offset: 0x00816870
		public string JODMFMFAOEG()
		{
			return this.LKALEJPLGII().ToString();
		}

		// Token: 0x060129C9 RID: 76233 RVA: 0x00818694 File Offset: 0x00816894
		public static ObscuredQuaternion.RawEncryptedQuaternion HBJHGHOKFDK(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, float OICADHEPMLH, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			ObscuredQuaternion.RawEncryptedQuaternion result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.HBJHGHOKFDK(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			result.w = ObscuredFloat.HBJHGHOKFDK(OICADHEPMLH, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129CA RID: 76234 RVA: 0x00818129 File Offset: 0x00816329
		public static Quaternion NNJCOKFNJAG(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.OOEKLDBGDBB();
		}

		// Token: 0x060129CB RID: 76235 RVA: 0x008186E9 File Offset: 0x008168E9
		public static ObscuredQuaternion.RawEncryptedQuaternion AGONHNJKHBL(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.IDGEJAPPLLL(DCCPCBLODIG, 0);
		}

		// Token: 0x060129CC RID: 76236 RVA: 0x008186F4 File Offset: 0x008168F4
		public int OLGKKDBOKEE()
		{
			return this.KOGNLJBGPCP().GetHashCode();
		}

		// Token: 0x060129CD RID: 76237 RVA: 0x00818715 File Offset: 0x00816915
		public Quaternion BEBBOOGPCGL()
		{
			return this.LKALEJPLGII();
		}

		// Token: 0x060129CE RID: 76238 RVA: 0x00818720 File Offset: 0x00816920
		public static Quaternion CBCAINFJGPK(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			Quaternion result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.z, JMBKDINHDLO);
			result.w = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.w, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129CF RID: 76239 RVA: 0x008180F9 File Offset: 0x008162F9
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129D0 RID: 76240 RVA: 0x00818784 File Offset: 0x00816984
		public ObscuredQuaternion.RawEncryptedQuaternion BILJGBOFJMK()
		{
			this.BLKMLEOBPIA();
			return this.hiddenValue;
		}

		// Token: 0x060129D1 RID: 76241 RVA: 0x00818792 File Offset: 0x00816992
		public static Quaternion FNBHJBFLFLF(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.CMIOPAENPBH();
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x0081879C File Offset: 0x0081699C
		public string OABGAIPBCLL()
		{
			return this.KOGNLJBGPCP().ToString();
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void BBOGAEMNJJN(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060129D4 RID: 76244 RVA: 0x008186E9 File Offset: 0x008168E9
		public static ObscuredQuaternion.RawEncryptedQuaternion NLAFMDDKHBK(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.IDGEJAPPLLL(DCCPCBLODIG, 0);
		}

		// Token: 0x060129D5 RID: 76245 RVA: 0x008187BD File Offset: 0x008169BD
		public static Quaternion GOOIABGKMHK(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060129D6 RID: 76246 RVA: 0x008187C6 File Offset: 0x008169C6
		public void IEKFGJCFMFL()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.IDGEJAPPLLL(this.KOGNLJBGPCP(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129D7 RID: 76247 RVA: 0x008187F8 File Offset: 0x008169F8
		public string ALELIIHGHGH(string LJCEDKCLBDB)
		{
			return this.CMIOPAENPBH().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060129D8 RID: 76248 RVA: 0x00817A35 File Offset: 0x00815C35
		public static ObscuredQuaternion.RawEncryptedQuaternion HDGEMCGKMNC(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.GGIBCLJMFLF(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129D9 RID: 76249 RVA: 0x00818084 File Offset: 0x00816284
		public static Quaternion ICAODGOKEHE(ObscuredQuaternion.RawEncryptedQuaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.GJJDHACFMFI(DCCPCBLODIG, 1);
		}

		// Token: 0x060129DA RID: 76250 RVA: 0x00818814 File Offset: 0x00816A14
		public void HKJPGDJPLNL(ObscuredQuaternion.RawEncryptedQuaternion LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.OOEKLDBGDBB();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060129DB RID: 76251 RVA: 0x00818534 File Offset: 0x00816734
		public static ObscuredQuaternion JFOEIEAOMNM(Quaternion DCCPCBLODIG)
		{
			return new ObscuredQuaternion(DCCPCBLODIG);
		}

		// Token: 0x060129DC RID: 76252 RVA: 0x00818848 File Offset: 0x00816A48
		public string NAAOOABFHKB()
		{
			return this.LKALEJPLGII().ToString();
		}

		// Token: 0x060129DD RID: 76253 RVA: 0x00818869 File Offset: 0x00816A69
		public static ObscuredQuaternion.RawEncryptedQuaternion MMBGFPEPLDE(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.ONNPIMAJEKK(DCCPCBLODIG, 1);
		}

		// Token: 0x060129DE RID: 76254 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion DIMCMMALABD(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129DF RID: 76255 RVA: 0x00818874 File Offset: 0x00816A74
		private Quaternion AGFJMOFPGFF()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.AGONHNJKHBL(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = true;
				this.inited = true;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && !this.ICHACFFGCHH(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x060129E0 RID: 76256 RVA: 0x00818960 File Offset: 0x00816B60
		private bool NBCHIFPDINB(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.GGOEIHCJEHP().quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129E1 RID: 76257 RVA: 0x008189CE File Offset: 0x00816BCE
		public static ObscuredQuaternion.RawEncryptedQuaternion BPPJAHBEACG(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG, 1);
		}

		// Token: 0x060129E2 RID: 76258 RVA: 0x008189D7 File Offset: 0x00816BD7
		public void JLAIFJAABML()
		{
			if (this.currentCryptoKey != ObscuredQuaternion.cryptoKey)
			{
				this.hiddenValue = ObscuredQuaternion.HKNJMBMKGFN(this.OOEKLDBGDBB(), ObscuredQuaternion.cryptoKey);
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
			}
		}

		// Token: 0x060129E3 RID: 76259 RVA: 0x00818A08 File Offset: 0x00816C08
		public void HDNPCJCDGOD()
		{
			Quaternion dccpcblodig = this.OOEKLDBGDBB();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-105, -45);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.IACCCBJHJPL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129E4 RID: 76260 RVA: 0x008178B4 File Offset: 0x00815AB4
		public static ObscuredQuaternion.RawEncryptedQuaternion IDGEJAPPLLL(Quaternion DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredQuaternion.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, DCCPCBLODIG.w, JMBKDINHDLO);
		}

		// Token: 0x060129E5 RID: 76261 RVA: 0x00817D99 File Offset: 0x00815F99
		public static void OGFCBNBGBIH(int JODDIMFACHN)
		{
			ObscuredQuaternion.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060129E6 RID: 76262 RVA: 0x00818A4C File Offset: 0x00816C4C
		private Quaternion ENEENENBJJL()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredQuaternion.cryptoKey;
				this.hiddenValue = ObscuredQuaternion.NLAFMDDKHBK(ObscuredQuaternion.identity);
				this.fakeValue = ObscuredQuaternion.identity;
				this.fakeValueActive = true;
				this.inited = true;
				return ObscuredQuaternion.identity;
			}
			Quaternion quaternion;
			quaternion.x = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.x, this.currentCryptoKey);
			quaternion.y = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.y, this.currentCryptoKey);
			quaternion.z = ObscuredFloat.DLEINJOAHNM(this.hiddenValue.z, this.currentCryptoKey);
			quaternion.w = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.w, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && !this.ICHACFFGCHH(quaternion, this.fakeValue))
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return quaternion;
		}

		// Token: 0x060129E7 RID: 76263 RVA: 0x00818B38 File Offset: 0x00816D38
		private bool MLAHNMDFEBE(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.LNANLECJDDA().quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129E8 RID: 76264 RVA: 0x00818BA6 File Offset: 0x00816DA6
		public Quaternion GHBPDPPHEMP()
		{
			return this.CMIOPAENPBH();
		}

		// Token: 0x060129E9 RID: 76265 RVA: 0x00818129 File Offset: 0x00816329
		public static Quaternion ALBBIEKFLJF(ObscuredQuaternion DCCPCBLODIG)
		{
			return DCCPCBLODIG.OOEKLDBGDBB();
		}

		// Token: 0x060129EA RID: 76266 RVA: 0x00818BB0 File Offset: 0x00816DB0
		private bool AFGEKPDIKIP(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.GGOEIHCJEHP().quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) < quaternionEpsilon && Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129EB RID: 76267 RVA: 0x00818C20 File Offset: 0x00816E20
		private bool PDFLFEICJOJ(Quaternion OMGKBGHINHN, Quaternion AGNGJFCDAJB)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.LNANLECJDDA().quaternionEpsilon;
			return Math.Abs(OMGKBGHINHN.x - AGNGJFCDAJB.x) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.y - AGNGJFCDAJB.y) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.z - AGNGJFCDAJB.z) >= quaternionEpsilon || Math.Abs(OMGKBGHINHN.w - AGNGJFCDAJB.w) < quaternionEpsilon;
		}

		// Token: 0x060129EC RID: 76268 RVA: 0x00818C90 File Offset: 0x00816E90
		public static ObscuredQuaternion.RawEncryptedQuaternion GGIBCLJMFLF(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, float OICADHEPMLH, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredQuaternion.cryptoKey;
			}
			ObscuredQuaternion.RawEncryptedQuaternion result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.HBJHGHOKFDK(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			result.w = ObscuredFloat.ALHMMAGENAF(OICADHEPMLH, JMBKDINHDLO);
			return result;
		}

		// Token: 0x060129ED RID: 76269 RVA: 0x00818CE8 File Offset: 0x00816EE8
		public void IEPNJIJGNDM()
		{
			Quaternion dccpcblodig = this.KOGNLJBGPCP();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(82, -198);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredQuaternion.HDGEMCGKMNC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129EE RID: 76270 RVA: 0x00818869 File Offset: 0x00816A69
		public static ObscuredQuaternion.RawEncryptedQuaternion EMOCKBFICAP(Quaternion DCCPCBLODIG)
		{
			return ObscuredQuaternion.ONNPIMAJEKK(DCCPCBLODIG, 1);
		}

		// Token: 0x04002645 RID: 9797
		private static int cryptoKey = 120205;

		// Token: 0x04002646 RID: 9798
		private static readonly Quaternion identity = Quaternion.identity;

		// Token: 0x04002647 RID: 9799
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04002648 RID: 9800
		[SerializeField]
		private ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;

		// Token: 0x04002649 RID: 9801
		[SerializeField]
		private bool inited;

		// Token: 0x0400264A RID: 9802
		[SerializeField]
		private Quaternion fakeValue;

		// Token: 0x0400264B RID: 9803
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x0200058B RID: 1419
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			// Token: 0x0400264C RID: 9804
			public int x;

			// Token: 0x0400264D RID: 9805
			public int y;

			// Token: 0x0400264E RID: 9806
			public int z;

			// Token: 0x0400264F RID: 9807
			public int w;
		}
	}
}
