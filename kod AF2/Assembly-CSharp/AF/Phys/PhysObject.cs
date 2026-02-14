using System;
using UnityEngine;

namespace AF.Phys
{
	// Token: 0x020002A3 RID: 675
	public class PhysObject : MonoBehaviour
	{
		// Token: 0x06009E74 RID: 40564 RVA: 0x004701C9 File Offset: 0x0046E3C9
		private void BOJJIJICHBK()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.CDBIEPGNONF();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x00470207 File Offset: 0x0046E407
		private void FPLNDDMFFKG()
		{
			this.HNOAKFGPEHO(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x00470227 File Offset: 0x0046E427
		public bool MDHAEHCGBHC()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x0047022F File Offset: 0x0046E42F
		private void PPPBANLKBFJ(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Button Left Hand";
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00470227 File Offset: 0x0046E427
		public bool KEKNAJNJIEP()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x00470227 File Offset: 0x0046E427
		public bool PPECOHNIOHA()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x00470247 File Offset: 0x0046E447
		private void JOALJDGPKKO(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Crouch180";
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x0047025F File Offset: 0x0046E45F
		private void NJNENEAJJKJ(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "wpn_eat1";
		}

		// Token: 0x06009E7C RID: 40572 RVA: 0x00470277 File Offset: 0x0046E477
		private void IBPGMFNDPHH()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x00470227 File Offset: 0x0046E427
		public bool LIKAILMJCMC()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x004702B5 File Offset: 0x0046E4B5
		private void HFPPENPGGAI()
		{
			this.EPBBLAFILMJ(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x004702D5 File Offset: 0x0046E4D5
		private void DEGCCLNOEKJ()
		{
			this.LNJFNAGPIIO(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x004702F5 File Offset: 0x0046E4F5
		private void DCBNEKDBFOF(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "ROOT";
		}

		// Token: 0x06009E81 RID: 40577 RVA: 0x0047030D File Offset: 0x0046E50D
		private void DAFJMNMFOON()
		{
			this.IOFOIJNJFEL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x0047032D File Offset: 0x0046E52D
		public void EPBBLAFILMJ(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x0047033D File Offset: 0x0046E53D
		private void GIJFCBDPHLH(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "cht_msg4";
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x00470227 File Offset: 0x0046E427
		public bool OMHDLLMJLND()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x00470355 File Offset: 0x0046E555
		private void IEJKBEFGEHD(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x0047036D File Offset: 0x0046E56D
		private void MNAHGMDDHCA()
		{
			this.GDLKEFKHECF(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x0047038D File Offset: 0x0046E58D
		private void GCLBNFCBMLL()
		{
			this.BMEAFPJDHIE(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x0047032D File Offset: 0x0046E52D
		public void GDLKEFKHECF(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x0047032D File Offset: 0x0046E52D
		public void AFKJMKHELJJ(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x0047032D File Offset: 0x0046E52D
		public void OEBCFANLBBG(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x004703AD File Offset: 0x0046E5AD
		private void BIGPMMGBPJC()
		{
			this.KNIOBHJNNKE(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x00470227 File Offset: 0x0046E427
		public bool KDGBLLAFCAI()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void NCBLFNKNEDK()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void MKNPFMEMOJO()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x00470227 File Offset: 0x0046E427
		public bool NCGPDFFCLGI()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void JFFPLABGMNF()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x0047032D File Offset: 0x0046E52D
		public void IOFOIJNJFEL(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x0047040B File Offset: 0x0046E60B
		private void FPAOMCFNCJA(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "No light component found in UniqueShadowSun '{0}!";
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x0047032D File Offset: 0x0046E52D
		public void KJAFCAINBPK(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x00470423 File Offset: 0x0046E623
		private void PFNPOHMMJDN()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x0047032D File Offset: 0x0046E52D
		public void GMODKLFBADI(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void GGBMJFNGHMC()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x0047032D File Offset: 0x0046E52D
		public void DNIOPDOLINM(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x0047032D File Offset: 0x0046E52D
		public void CDMJBHDMOHI(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x00470461 File Offset: 0x0046E661
		private void ADBGFFBMBFM(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "WorkerPickaxe2";
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00470479 File Offset: 0x0046E679
		private void LMMDHJJJNJO()
		{
			this.OEBCFANLBBG(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x00470227 File Offset: 0x0046E427
		// (set) Token: 0x06009EF6 RID: 40694 RVA: 0x0047032D File Offset: 0x0046E52D
		public bool BGLLPMKNBCE
		{
			get
			{
				return this.JEBHPJIDBEK;
			}
			set
			{
				bool jebhpjidbek = this.JEBHPJIDBEK;
				this.JEBHPJIDBEK = value;
			}
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x00470499 File Offset: 0x0046E699
		private void DGFGANALNAJ()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.CDBIEPGNONF();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x0047032D File Offset: 0x0046E52D
		public void BBHLILFPMKD(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00470423 File Offset: 0x0046E623
		private void KFOMHKMPPAK()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x004704D7 File Offset: 0x0046E6D7
		private void NJGOGLFLEAK(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "BackPackGrab";
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x004704EF File Offset: 0x0046E6EF
		private void KLPIONDPJKF(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "exitmsg_3";
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x00470507 File Offset: 0x0046E707
		private void EGDBNKCJOCD()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x004701C9 File Offset: 0x0046E3C9
		private void EHFPLKEINFO()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.CDBIEPGNONF();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x00470545 File Offset: 0x0046E745
		private void CKIGGCAHAFD()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00470423 File Offset: 0x0046E623
		private void DGDGMFDPEHO()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00470583 File Offset: 0x0046E783
		private void OMHKICLGKFH(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "VaderChoke";
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00470227 File Offset: 0x0046E427
		public bool CMALDDAAMAH()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00470277 File Offset: 0x0046E477
		private void ANHOOJFEJJE()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x0047059B File Offset: 0x0046E79B
		private void MFHGOLNLAAF()
		{
			this.FPGMEEDJKPL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x0047032D File Offset: 0x0046E52D
		public void OOKGBAGNHAK(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x00470227 File Offset: 0x0046E427
		public bool JCAIHGEKMHF()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x00470479 File Offset: 0x0046E679
		private void EKCKBDKEAKO()
		{
			this.OEBCFANLBBG(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x0047032D File Offset: 0x0046E52D
		public void BMEAFPJDHIE(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x004705BB File Offset: 0x0046E7BB
		private void OFPGMNGFLNH()
		{
			this.OEOMBOIIEFN(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x00470227 File Offset: 0x0046E427
		public bool NBNEPFILCJG()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x00470227 File Offset: 0x0046E427
		public bool EHCGLOEDICA()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void KGICJDGIIJK()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x0047032D File Offset: 0x0046E52D
		public void HMFEJCMOJBL(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x00470227 File Offset: 0x0046E427
		public bool FCMPHFFFIMG()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x0047032D File Offset: 0x0046E52D
		public void LNJFNAGPIIO(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x004705DB File Offset: 0x0046E7DB
		private void KEMGOLACEHI()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x0047032D File Offset: 0x0046E52D
		public void FPGMEEDJKPL(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x0047032D File Offset: 0x0046E52D
		public void PKFIPKELGBP(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x00470227 File Offset: 0x0046E427
		public bool GIKJPMOHCFB()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x00470619 File Offset: 0x0046E819
		private void AIAMIFEPALP()
		{
			this.CDMJBHDMOHI(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x00470227 File Offset: 0x0046E427
		public bool PILMBECCJJC()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x0047032D File Offset: 0x0046E52D
		public void NMAFJOALMLC(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x00470639 File Offset: 0x0046E839
		private void OnCollisionEnter(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Player";
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x00470651 File Offset: 0x0046E851
		private void MJIIJFKNAJH(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "RenderTextureUtilityTempTexture";
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void FCCAIANLEFE()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x00470499 File Offset: 0x0046E699
		private void GMOACLEBHAM()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.CDBIEPGNONF();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x00470669 File Offset: 0x0046E869
		private void FOHLAIIMNFB()
		{
			this.BGLLPMKNBCE = (base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x00470689 File Offset: 0x0046E889
		private void FHIGEJPEKMD(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "fish/";
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x004706A1 File Offset: 0x0046E8A1
		private void LBGKAMLLACN()
		{
			this.EFIFBAALKIC(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x004706C1 File Offset: 0x0046E8C1
		private void GMJJJAKENOK(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "HA ";
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x00470277 File Offset: 0x0046E477
		private void CKGPEFOKKNL()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x004706D9 File Offset: 0x0046E8D9
		private void KLFPOILLKDF()
		{
			this.DNCJGIFJIFJ(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x00470227 File Offset: 0x0046E427
		public bool FACCCCOFDMI()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x0047038D File Offset: 0x0046E58D
		private void IPPDPBMEIAI()
		{
			this.BMEAFPJDHIE(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x00470507 File Offset: 0x0046E707
		private void AHOFKFMMCCI()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x004706F9 File Offset: 0x0046E8F9
		private void GCNGEFBKMNC()
		{
			this.BKEDMEOIKFN(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x0047032D File Offset: 0x0046E52D
		public void KHEPGAIHPID(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x00470719 File Offset: 0x0046E919
		private void DJFLHMMBBCP(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "";
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x00470731 File Offset: 0x0046E931
		private void JJIMGFEJDCH(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "post_18";
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x00470719 File Offset: 0x0046E919
		private void PIIFKLKDHFN(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "";
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00470227 File Offset: 0x0046E427
		public bool CBENGENCFOB()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x00470227 File Offset: 0x0046E427
		public bool GGNHCKHMHFJ()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x00470227 File Offset: 0x0046E427
		public bool CLGNGGKGCEH()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x0047032D File Offset: 0x0046E52D
		public void OEOMBOIIEFN(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00470227 File Offset: 0x0046E427
		public bool HGEBOGHGFDM()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x0047032D File Offset: 0x0046E52D
		public void MGBCBNGALEK(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x0047032D File Offset: 0x0046E52D
		public void DNCJGIFJIFJ(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x00470479 File Offset: 0x0046E679
		private void GDBBAMFMKII()
		{
			this.OEBCFANLBBG(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009ED5 RID: 40661 RVA: 0x00470749 File Offset: 0x0046E949
		private void FEIMHGLLCDB(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Copying splat set to mis-matched container length";
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x00470507 File Offset: 0x0046E707
		private void FODDAMMNECI()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x00470761 File Offset: 0x0046E961
		private void DJIDFAFNHLB(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "\n";
		}

		// Token: 0x06009ED8 RID: 40664 RVA: 0x00470669 File Offset: 0x0046E869
		private void EDEODHDFANE()
		{
			this.BGLLPMKNBCE = (base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x0047032D File Offset: 0x0046E52D
		public void EJBPGJKNNKB(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x00470779 File Offset: 0x0046E979
		private void CECDCNLECKA(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "UnityEngine.Vector3";
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x004701C9 File Offset: 0x0046E3C9
		private void JHAKJAMBNAH()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.CDBIEPGNONF();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x00470423 File Offset: 0x0046E623
		private void FNBGGJJLIGG()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x0047030D File Offset: 0x0046E50D
		private void LDDIGEMBDNF()
		{
			this.IOFOIJNJFEL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x0047032D File Offset: 0x0046E52D
		public void COJLPKGAJDJ(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x00470791 File Offset: 0x0046E991
		private void EMBBHIEMJEN(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "The 'color' command requires a color parameter of RRGGBBAA:\n";
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x004707A9 File Offset: 0x0046E9A9
		private void PAKBGKODEGF(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "The shader ";
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x00470545 File Offset: 0x0046E745
		private void FIJKDFIMELM()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x0047030D File Offset: 0x0046E50D
		private void ACFEBEDDIAI()
		{
			this.IOFOIJNJFEL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x0047032D File Offset: 0x0046E52D
		public void BKEDMEOIKFN(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x0047030D File Offset: 0x0046E50D
		private void CBPPOJCGFKH()
		{
			this.IOFOIJNJFEL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x0047032D File Offset: 0x0046E52D
		public void KNIOBHJNNKE(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x004707C1 File Offset: 0x0046E9C1
		private void FHFBDFHAJID(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "RollerBladeCrossoverLeft";
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x00470227 File Offset: 0x0046E427
		public bool FDIEPDGAGDN()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x0047032D File Offset: 0x0046E52D
		public void FAPPNEFNDKP(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x0047032D File Offset: 0x0046E52D
		public void EFIFBAALKIC(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x0047032D File Offset: 0x0046E52D
		public void LFFPKDOGKPO(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x0047032D File Offset: 0x0046E52D
		public void AEBGEFOAICK(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x00470423 File Offset: 0x0046E623
		private void Start()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x00470423 File Offset: 0x0046E623
		private void PNOHGOJEJKL()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x0047032D File Offset: 0x0046E52D
		public void EKLKLFNLCEB(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x004707D9 File Offset: 0x0046E9D9
		private void OLGDMBDGLAN()
		{
			this.NMAFJOALMLC(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x004707F9 File Offset: 0x0046E9F9
		private void NJMDDKCDMIN(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Eyelashes";
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x00470669 File Offset: 0x0046E869
		private void Update()
		{
			this.BGLLPMKNBCE = (base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x0047032D File Offset: 0x0046E52D
		public void KJDPAALOIBN(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x00470811 File Offset: 0x0046EA11
		private void ICBIPBCDKKC(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "0";
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x0047032D File Offset: 0x0046E52D
		public void MKHHGGDINBL(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x004702B5 File Offset: 0x0046E4B5
		private void JIFOELPAEHG()
		{
			this.EPBBLAFILMJ(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x0047030D File Offset: 0x0046E50D
		private void OHKHOAKCENL()
		{
			this.IOFOIJNJFEL(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x00470423 File Offset: 0x0046E623
		private void MMACLBBMDLA()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x00470829 File Offset: 0x0046EA29
		private void HIKPAICMDNL(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "UserOut";
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x004703CD File Offset: 0x0046E5CD
		private void BMNJGPIPKLL()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = false;
			}
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x004705DB File Offset: 0x0046E7DB
		private void OFKOGOOAOPK()
		{
			if (LocNewLogic.getI != null)
			{
				this.waterLevel = LocNewLogic.getI.IGHOGONIKLC();
			}
			if (base.transform.position.y < this.waterLevel)
			{
				this.JEBHPJIDBEK = true;
			}
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x00470227 File Offset: 0x0046E427
		public bool BAFOCMJKNKK()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x00470841 File Offset: 0x0046EA41
		private void KGIICCDNAMK(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "Post Process Debug Shader Missing...";
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x0047032D File Offset: 0x0046E52D
		public void HNOAKFGPEHO(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x00470227 File Offset: 0x0046E427
		public bool JNIALPKCCON()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x00470859 File Offset: 0x0046EA59
		private void AOJNKDHMEFC(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "[Z]";
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x0047032D File Offset: 0x0046E52D
		public void JEHNFKOIACC(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x00470871 File Offset: 0x0046EA71
		private void CFKDMNMOHBC(Collision LMIOFHFPLJD)
		{
			LMIOFHFPLJD.gameObject.tag == "FOG_SCATTERING_ON";
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x00470227 File Offset: 0x0046E427
		public bool KFGMNNEPKMC()
		{
			return this.JEBHPJIDBEK;
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x00470889 File Offset: 0x0046EA89
		private void JOHDLNOKCOK()
		{
			this.AEBGEFOAICK(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x0047032D File Offset: 0x0046E52D
		public void EPCHMCANEDH(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x0047032D File Offset: 0x0046E52D
		public void HNIIEMFPBDP(bool DCCPCBLODIG)
		{
			bool jebhpjidbek = this.JEBHPJIDBEK;
			this.JEBHPJIDBEK = DCCPCBLODIG;
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x004708A9 File Offset: 0x0046EAA9
		private void DIAIKCBANBK()
		{
			this.MGBCBNGALEK(base.transform.position.y < this.waterLevel);
		}

		// Token: 0x04001494 RID: 5268
		private bool JEBHPJIDBEK;

		// Token: 0x04001495 RID: 5269
		public float waterLevel;
	}
}
