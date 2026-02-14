using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000391 RID: 913
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		// Token: 0x0600C5C6 RID: 50630 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void JCELICPHGEP()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5C7 RID: 50631 RVA: 0x0058F4BC File Offset: 0x0058D6BC
		private void FLBGPGDLGLH()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyVertical);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x0058F548 File Offset: 0x0058D748
		private void LOOMJDKBCIO(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x0058F5B1 File Offset: 0x0058D7B1
		private void IFJEIFBOPCI()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.LGAMHBGCPLC();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.LGAMHBGCPLC();
			}
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x0058F5B1 File Offset: 0x0058D7B1
		private void KHJJKPCKNKM()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.LGAMHBGCPLC();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.LGAMHBGCPLC();
			}
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x0058F5D9 File Offset: 0x0058D7D9
		private void IICFAPMJLCN()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.LGAMHBGCPLC();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.NFFDECHIADD();
			}
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x0058F601 File Offset: 0x0058D801
		private void PBDNGIFDEFC()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.NFFDECHIADD();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.HAFJMIPHAIB();
			}
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x0058F62C File Offset: 0x0058D82C
		private void ICCIPEIGCEN()
		{
			this.DCCCFCDJJMH = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == Joystick.NEJBMOBICHL.Both);
			this.GIKPIIHCDCG = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == (Joystick.NEJBMOBICHL)5);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x0058F6B5 File Offset: 0x0058D8B5
		public void PGOBFLDEEKD(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.LODKJPFFJKD(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5CF RID: 50639 RVA: 0x0058F6D4 File Offset: 0x0058D8D4
		public void CJADOGCGHGM(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.AAEMLNKCJOB(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void FEBIICIMLHA()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x0058F6F3 File Offset: 0x0058D8F3
		public void ODEGCOLFHOL(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.NNAIJMJDFME(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x0058F6F3 File Offset: 0x0058D8F3
		public void IDKDBKJEIIK(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.NNAIJMJDFME(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x0058F712 File Offset: 0x0058D912
		public void GADJLPGFELM(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.BNCBNPIEHBM(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x0058F731 File Offset: 0x0058D931
		private void OnEnable()
		{
			this.FLBGPGDLGLH();
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void INDGOHJGCFN()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x0058F73C File Offset: 0x0058D93C
		public void DGDBDHNEFOA(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.JEGEOJHBPKO(base.transform.position);
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x0058F824 File Offset: 0x0058DA24
		private void BMHJCBMENLB()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == (Joystick.NEJBMOBICHL)4);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x0058F8B0 File Offset: 0x0058DAB0
		private void IPHMIEPICCC(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x0058F91C File Offset: 0x0058DB1C
		private void HEKEIOCDCEA()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == (Joystick.NEJBMOBICHL)5);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x0058F9A5 File Offset: 0x0058DBA5
		public void BDHCPNJLKOL(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.CBLNNGDOBJE(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x00022FCC File Offset: 0x000211CC
		public void JBJPICAEJOJ(PointerEventData DNHBPGOKLKD)
		{
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void ELADFDNPOOI()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x0058F9C4 File Offset: 0x0058DBC4
		private void EHMBMJBKJEP()
		{
			this.DCCCFCDJJMH = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == Joystick.NEJBMOBICHL.Both);
			this.GIKPIIHCDCG = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == (Joystick.NEJBMOBICHL)4);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x0058FA50 File Offset: 0x0058DC50
		private void BEDONJAPHFA()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == (Joystick.NEJBMOBICHL)8);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x0058FADC File Offset: 0x0058DCDC
		public void HLMEIAEEIOO(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.ALDKGKGAFAK(base.transform.position);
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x0058FBC4 File Offset: 0x0058DDC4
		public void IFBFDHADBJK(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.POAOEEJHBAP(base.transform.position);
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x0058FCAC File Offset: 0x0058DEAC
		private void AEKDAPGLIPD()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x0058FD5C File Offset: 0x0058DF5C
		private void DJGDMLEMEHB()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.Both);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == (Joystick.NEJBMOBICHL)7);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x0058FDE5 File Offset: 0x0058DFE5
		private void KOAEBJLNOLI()
		{
			this.DGMOIGJICGJ();
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void GDIMBBBPIHI()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x0058F6D4 File Offset: 0x0058D8D4
		public void PHGHKJMAIDA(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.AAEMLNKCJOB(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x0058F6B5 File Offset: 0x0058D8B5
		public void JDCFHJDMFFJ(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.LODKJPFFJKD(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x00022FCC File Offset: 0x000211CC
		public void BMLPMKJIIHA(PointerEventData DNHBPGOKLKD)
		{
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x0058FDED File Offset: 0x0058DFED
		private void OnDisable()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.NFFDECHIADD();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.NFFDECHIADD();
			}
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x0058FE18 File Offset: 0x0058E018
		public void HCKFNADJIMP(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.BNCBNPIEHBM(base.transform.position);
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x0058FF00 File Offset: 0x0058E100
		private void NNAIJMJDFME(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void EFJDBBDMPMC()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5ED RID: 50669 RVA: 0x0058FF6C File Offset: 0x0058E16C
		private void CBLNNGDOBJE(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5EE RID: 50670 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void LHJCHPFKGDB()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C5EF RID: 50671 RVA: 0x0058FFD5 File Offset: 0x0058E1D5
		public void OnPointerUp(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.JEGEOJHBPKO(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x0058FFF4 File Offset: 0x0058E1F4
		private void IILILEBJMBA(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x00590060 File Offset: 0x0058E260
		private void CIOFJPFMJOE(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5F2 RID: 50674 RVA: 0x005900CC File Offset: 0x0058E2CC
		private void BNCBNPIEHBM(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5F3 RID: 50675 RVA: 0x0058FDE5 File Offset: 0x0058DFE5
		private void EBAJDGLIAPE()
		{
			this.DGMOIGJICGJ();
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x00590138 File Offset: 0x0058E338
		private void AAEMLNKCJOB(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x005901A4 File Offset: 0x0058E3A4
		public void KKIGMFLANBH(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.CIOFJPFMJOE(base.transform.position);
		}

		// Token: 0x0600C5F6 RID: 50678 RVA: 0x0059028A File Offset: 0x0058E48A
		private void DJEKNFIFAEK()
		{
			this.AFKJDPIAFNI();
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x0058F601 File Offset: 0x0058D801
		private void ANHJAOPPMCI()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.NFFDECHIADD();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.HAFJMIPHAIB();
			}
		}

		// Token: 0x0600C5F8 RID: 50680 RVA: 0x00590294 File Offset: 0x0058E494
		private void PALAJCLAFIB()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.Both);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == (Joystick.NEJBMOBICHL)6);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x0058F6D4 File Offset: 0x0058D8D4
		public void EECMKKIAGCH(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.AAEMLNKCJOB(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x00590320 File Offset: 0x0058E520
		private void LODKJPFFJKD(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x0059038C File Offset: 0x0058E58C
		public void PCLEGBOBNIG(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.BNCBNPIEHBM(base.transform.position);
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x00022FCC File Offset: 0x000211CC
		public void CKDJOBMFPOM(PointerEventData DNHBPGOKLKD)
		{
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x00590474 File Offset: 0x0058E674
		public void LGAKINLCAOC(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.LOOMJDKBCIO(base.transform.position);
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x0058F5D9 File Offset: 0x0058D7D9
		private void NCHGOOPEDKC()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.LGAMHBGCPLC();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.NFFDECHIADD();
			}
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x0059055A File Offset: 0x0058E75A
		public void ENIHKMOGPHM(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.CIOFJPFMJOE(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C600 RID: 50688 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void IJOCHELLKJH()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x0059057C File Offset: 0x0058E77C
		private void ALDKGKGAFAK(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x005905E8 File Offset: 0x0058E7E8
		private void AFKJDPIAFNI()
		{
			this.DCCCFCDJJMH = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.OnlyHorizontal);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x00590671 File Offset: 0x0058E871
		public void NEPPNDHNIGJ(PointerEventData DNHBPGOKLKD)
		{
			base.transform.position = this.NMBMCKBKKDD;
			this.POAOEEJHBAP(this.NMBMCKBKKDD);
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void Start()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x00590690 File Offset: 0x0058E890
		public void OnDrag(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.JEGEOJHBPKO(base.transform.position);
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x00590778 File Offset: 0x0058E978
		public void HAEMGENGDCA(PointerEventData DNHBPGOKLKD)
		{
			Vector3 zero = Vector3.zero;
			if (this.DCCCFCDJJMH)
			{
				int num = (int)(DNHBPGOKLKD.position.x - this.NMBMCKBKKDD.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GIKPIIHCDCG)
			{
				int num2 = (int)(DNHBPGOKLKD.position.y - this.NMBMCKBKKDD.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.NMBMCKBKKDD.x + zero.x, this.NMBMCKBKKDD.y + zero.y, this.NMBMCKBKKDD.z + zero.z);
			this.BNCBNPIEHBM(base.transform.position);
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x00022FCC File Offset: 0x000211CC
		public void AGPPMGGGJEF(PointerEventData DNHBPGOKLKD)
		{
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x0059085E File Offset: 0x0058EA5E
		private void FKPHBAOKEOF()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.LGAMHBGCPLC();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.HAFJMIPHAIB();
			}
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x00590886 File Offset: 0x0058EA86
		private void CCCAOGJKJOD()
		{
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.NFFDECHIADD();
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.LGAMHBGCPLC();
			}
		}

		// Token: 0x0600C60A RID: 50698 RVA: 0x005908AE File Offset: 0x0058EAAE
		private void NKEJKDGBPOP()
		{
			this.DJGDMLEMEHB();
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x005908B8 File Offset: 0x0058EAB8
		private void POAOEEJHBAP(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C60C RID: 50700 RVA: 0x00590924 File Offset: 0x0058EB24
		private void JEGEOJHBPKO(Vector3 DCCPCBLODIG)
		{
			Vector3 vector = this.NMBMCKBKKDD - DCCPCBLODIG;
			vector.y = -vector.y;
			vector /= (float)this.MovementRange;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(-vector.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(vector.y);
			}
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x00590990 File Offset: 0x0058EB90
		private void DGMOIGJICGJ()
		{
			this.DCCCFCDJJMH = (this.axesToUse == Joystick.NEJBMOBICHL.Both || this.axesToUse == Joystick.NEJBMOBICHL.Both);
			this.GIKPIIHCDCG = (this.axesToUse != Joystick.NEJBMOBICHL.Both && this.axesToUse == Joystick.NEJBMOBICHL.OnlyVertical);
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC = new CELBHNONENJ.FANBIHFODMJ(this.horizontalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.FLJGMPJDKBC);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF = new CELBHNONENJ.FANBIHFODMJ(this.verticalAxisName);
				CELBHNONENJ.DNDFOKKIBGB(this.HJCDIDCBMLF);
			}
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void OLBDJCFPKFG()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x00022FCC File Offset: 0x000211CC
		public void OnPointerDown(PointerEventData DNHBPGOKLKD)
		{
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void CGFDDFHECLJ()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x0058F4A8 File Offset: 0x0058D6A8
		private void CGMHGDEKDEP()
		{
			this.NMBMCKBKKDD = base.transform.position;
		}

		// Token: 0x04001A42 RID: 6722
		public int MovementRange = 100;

		// Token: 0x04001A43 RID: 6723
		public Joystick.NEJBMOBICHL axesToUse;

		// Token: 0x04001A44 RID: 6724
		public string horizontalAxisName = "Horizontal";

		// Token: 0x04001A45 RID: 6725
		public string verticalAxisName = "Vertical";

		// Token: 0x04001A46 RID: 6726
		private Vector3 NMBMCKBKKDD;

		// Token: 0x04001A47 RID: 6727
		private bool DCCCFCDJJMH;

		// Token: 0x04001A48 RID: 6728
		private bool GIKPIIHCDCG;

		// Token: 0x04001A49 RID: 6729
		private CELBHNONENJ.FANBIHFODMJ FLJGMPJDKBC;

		// Token: 0x04001A4A RID: 6730
		private CELBHNONENJ.FANBIHFODMJ HJCDIDCBMLF;

		// Token: 0x02000392 RID: 914
		public enum NEJBMOBICHL
		{
			// Token: 0x04001A4C RID: 6732
			Both,
			// Token: 0x04001A4D RID: 6733
			OnlyHorizontal,
			// Token: 0x04001A4E RID: 6734
			OnlyVertical
		}
	}
}
