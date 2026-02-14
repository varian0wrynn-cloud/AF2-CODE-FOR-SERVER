using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000398 RID: 920
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x0600C664 RID: 50788 RVA: 0x00591BA7 File Offset: 0x0058FDA7
		public void GAIHHPNFAHK(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x00591BD5 File Offset: 0x0058FDD5
		private void MKLCOEALFBI()
		{
			if (CELBHNONENJ.CICNHOLEAPA(this.horizontalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.horizontalAxisName);
			}
			if (CELBHNONENJ.CICNHOLEAPA(this.verticalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.verticalAxisName);
			}
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x00591C07 File Offset: 0x0058FE07
		public void OnPointerUp(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.JEGEOJHBPKO(Vector3.zero);
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x00591C24 File Offset: 0x0058FE24
		private void BMJIKGNLPAB()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == (TouchPad.FAILLMDGGMP)3);
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

		// Token: 0x0600C668 RID: 50792 RVA: 0x00591CB0 File Offset: 0x0058FEB0
		private void PEMJIEAKNBN()
		{
			this.DCCCFCDJJMH = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == (TouchPad.FAILLMDGGMP)5);
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

		// Token: 0x0600C669 RID: 50793 RVA: 0x00591D39 File Offset: 0x0058FF39
		private void OnEnable()
		{
			this.FLBGPGDLGLH();
		}

		// Token: 0x0600C66A RID: 50794 RVA: 0x00591D44 File Offset: 0x0058FF44
		private void HMEAENGBFKC()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 0 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)6)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.CEBELDGFBML(new Vector3(normalized.x, normalized.y, 865f));
			}
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x00591E48 File Offset: 0x00590048
		private void JJJMNFLMDHP()
		{
			this.DCCCFCDJJMH = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == (TouchPad.FAILLMDGGMP)8);
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

		// Token: 0x0600C66C RID: 50796 RVA: 0x00591ED1 File Offset: 0x005900D1
		public void LACPDFMLLKO(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = -1;
			this.IILILEBJMBA(Vector3.zero);
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x00591EEC File Offset: 0x005900EC
		private void OCIANPBJNND()
		{
			this.BMJIKGNLPAB();
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x00591EF4 File Offset: 0x005900F4
		private void JLFBDOPFDDJ()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)4)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.MPAJFNCAMJF(new Vector3(normalized.x, normalized.y, 537f));
			}
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void MGLDCJOHBHF(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x00591ED1 File Offset: 0x005900D1
		public void AAPLODOELJE(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = -1;
			this.IILILEBJMBA(Vector3.zero);
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x00591BD5 File Offset: 0x0058FDD5
		private void FLFFEJFEPHF()
		{
			if (CELBHNONENJ.CICNHOLEAPA(this.horizontalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.horizontalAxisName);
			}
			if (CELBHNONENJ.CICNHOLEAPA(this.verticalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.verticalAxisName);
			}
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x00591ED1 File Offset: 0x005900D1
		public void JEHKDPFLKFC(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = -1;
			this.IILILEBJMBA(Vector3.zero);
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x00592034 File Offset: 0x00590234
		private void IJBNGBPKONB()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == (TouchPad.FAILLMDGGMP)6);
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

		// Token: 0x0600C674 RID: 50804 RVA: 0x005920BD File Offset: 0x005902BD
		public void HJAPHAFGNIH(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.CEBELDGFBML(Vector3.zero);
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x005920D8 File Offset: 0x005902D8
		private void HMOLODPODJD()
		{
			this.DCCCFCDJJMH = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == (TouchPad.FAILLMDGGMP)5);
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

		// Token: 0x0600C676 RID: 50806 RVA: 0x00592164 File Offset: 0x00590364
		private void HEKEIOCDCEA()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
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

		// Token: 0x0600C677 RID: 50807 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void FHJGGLCAAGG(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void BHOHJEJGDHC(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C679 RID: 50809 RVA: 0x00591BD5 File Offset: 0x0058FDD5
		private void DENHKOPGLDK()
		{
			if (CELBHNONENJ.CICNHOLEAPA(this.horizontalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.horizontalAxisName);
			}
			if (CELBHNONENJ.CICNHOLEAPA(this.verticalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.verticalAxisName);
			}
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x00591BD5 File Offset: 0x0058FDD5
		private void OnDisable()
		{
			if (CELBHNONENJ.CICNHOLEAPA(this.horizontalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.horizontalAxisName);
			}
			if (CELBHNONENJ.CICNHOLEAPA(this.verticalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.verticalAxisName);
			}
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x005921ED File Offset: 0x005903ED
		public void NKPMHPDCLDO(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.FHJGGLCAAGG(Vector3.zero);
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x00592208 File Offset: 0x00590408
		private void DDEBDCGNCPC()
		{
			this.FDOADMNFNPA = base.GetComponent<Image>();
			this.CEOCLMCLMIA = this.FDOADMNFNPA.transform.position;
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x0059222C File Offset: 0x0059042C
		private void LACNPNKHCAA()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)6)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.CEBELDGFBML(new Vector3(normalized.x, normalized.y, 128f));
			}
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x00592330 File Offset: 0x00590530
		private void EMHGNEMIGII()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)4)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.IILILEBJMBA(new Vector3(normalized.x, normalized.y, 1759f));
			}
		}

		// Token: 0x0600C67F RID: 50815 RVA: 0x00592431 File Offset: 0x00590631
		public void OnPointerDown(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x00592431 File Offset: 0x00590631
		public void PBHJPBAMKOI(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C682 RID: 50818 RVA: 0x0059249C File Offset: 0x0059069C
		private void FJEEADNCKAG()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)8)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.BFMMMJOJFHD(new Vector3(normalized.x, normalized.y, 263f));
			}
		}

		// Token: 0x0600C683 RID: 50819 RVA: 0x005925A0 File Offset: 0x005907A0
		private void HHLHBGAJAJI()
		{
			this.DCCCFCDJJMH = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
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

		// Token: 0x0600C684 RID: 50820 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void BFMMMJOJFHD(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x00592629 File Offset: 0x00590829
		public void ALMNOADPPPN(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.GHNAMILNAJC(Vector3.zero);
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void DEBBNOAPDAM(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x00591BD5 File Offset: 0x0058FDD5
		private void PCKOPPKGENK()
		{
			if (CELBHNONENJ.CICNHOLEAPA(this.horizontalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.horizontalAxisName);
			}
			if (CELBHNONENJ.CICNHOLEAPA(this.verticalAxisName))
			{
				CELBHNONENJ.PNDBFJCDJDN(this.verticalAxisName);
			}
		}

		// Token: 0x0600C688 RID: 50824 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void GHNAMILNAJC(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x00592644 File Offset: 0x00590844
		private void PMKOAHMNBBG()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == (TouchPad.IACBLLCBFJJ)4)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.LIIIIDPOKEA(new Vector3(normalized.x, normalized.y, 1999f));
			}
		}

		// Token: 0x0600C68A RID: 50826 RVA: 0x00592748 File Offset: 0x00590948
		private void JPHLMNIMDHH()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == TouchPad.IACBLLCBFJJ.Swipe)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.LIIIIDPOKEA(new Vector3(normalized.x, normalized.y, 1303f));
			}
		}

		// Token: 0x0600C68B RID: 50827 RVA: 0x00591D39 File Offset: 0x0058FF39
		private void MLPAEBKPFEN()
		{
			this.FLBGPGDLGLH();
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x00592849 File Offset: 0x00590A49
		public void FDIMCMHFJON(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = -1;
			this.FHJGGLCAAGG(Vector3.zero);
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x00592864 File Offset: 0x00590A64
		private void DAKAHNDPOCL()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == (TouchPad.FAILLMDGGMP)6);
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

		// Token: 0x0600C68E RID: 50830 RVA: 0x00591EEC File Offset: 0x005900EC
		private void KLPHHNMKNGN()
		{
			this.BMJIKGNLPAB();
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void JEGEOJHBPKO(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C690 RID: 50832 RVA: 0x00592431 File Offset: 0x00590631
		public void GLPNCAHLKKF(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C691 RID: 50833 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void CEBELDGFBML(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x00591ED1 File Offset: 0x005900D1
		public void ODEGCOLFHOL(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = -1;
			this.IILILEBJMBA(Vector3.zero);
		}

		// Token: 0x0600C693 RID: 50835 RVA: 0x00592431 File Offset: 0x00590631
		public void FIOPFGIGPIG(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = true;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x005928ED File Offset: 0x00590AED
		public void EIMKOKACBJB(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.IILILEBJMBA(Vector3.zero);
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void LIIIIDPOKEA(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C696 RID: 50838 RVA: 0x00591BA7 File Offset: 0x0058FDA7
		public void ACHMNDKCLAN(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C697 RID: 50839 RVA: 0x00591BA7 File Offset: 0x0058FDA7
		public void PHKNPAADDOF(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = DNHBPGOKLKD.pointerId;
			if (this.controlStyle != TouchPad.IACBLLCBFJJ.Absolute)
			{
				this.CEOCLMCLMIA = DNHBPGOKLKD.position;
			}
		}

		// Token: 0x0600C698 RID: 50840 RVA: 0x00592908 File Offset: 0x00590B08
		private void EMFOECIPBIP()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 0 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == TouchPad.IACBLLCBFJJ.Relative)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.BHOHJEJGDHC(new Vector3(normalized.x, normalized.y, 793f));
			}
		}

		// Token: 0x0600C699 RID: 50841 RVA: 0x00592A09 File Offset: 0x00590C09
		private void HNGLBEOAIHN()
		{
			this.DAKAHNDPOCL();
		}

		// Token: 0x0600C69A RID: 50842 RVA: 0x00592208 File Offset: 0x00590408
		private void CBLGFOFHNPJ()
		{
			this.FDOADMNFNPA = base.GetComponent<Image>();
			this.CEOCLMCLMIA = this.FDOADMNFNPA.transform.position;
		}

		// Token: 0x0600C69B RID: 50843 RVA: 0x00592A11 File Offset: 0x00590C11
		public void AFJALDAENMG(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.MGLDCJOHBHF(Vector3.zero);
		}

		// Token: 0x0600C69C RID: 50844 RVA: 0x00592A2C File Offset: 0x00590C2C
		private void FLBGPGDLGLH()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyHorizontal);
			this.GIKPIIHCDCG = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.OnlyVertical);
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

		// Token: 0x0600C69D RID: 50845 RVA: 0x00592AB5 File Offset: 0x00590CB5
		public void EECMKKIAGCH(PointerEventData DNHBPGOKLKD)
		{
			this.JNOLKKFACKF = false;
			this.ELFLAMBOJML = -1;
			this.MPAJFNCAMJF(Vector3.zero);
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void IILILEBJMBA(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void GKFGAMKOPJG(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x00592208 File Offset: 0x00590408
		private void EFJDBBDMPMC()
		{
			this.FDOADMNFNPA = base.GetComponent<Image>();
			this.CEOCLMCLMIA = this.FDOADMNFNPA.transform.position;
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x00591FF5 File Offset: 0x005901F5
		private void MPAJFNCAMJF(Vector3 DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.normalized;
			if (this.DCCCFCDJJMH)
			{
				this.FLJGMPJDKBC.FANPFKHEDPA(DCCPCBLODIG.x);
			}
			if (this.GIKPIIHCDCG)
			{
				this.HJCDIDCBMLF.FANPFKHEDPA(DCCPCBLODIG.y);
			}
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x00592AD0 File Offset: 0x00590CD0
		private void Update()
		{
			if (!this.JNOLKKFACKF)
			{
				return;
			}
			if (Input.touchCount >= this.ELFLAMBOJML + 1 && this.ELFLAMBOJML != -1)
			{
				if (this.controlStyle == TouchPad.IACBLLCBFJJ.Swipe)
				{
					this.CEOCLMCLMIA = this.DNMJJCFKJDN;
					this.DNMJJCFKJDN = Input.touches[this.ELFLAMBOJML].position;
				}
				Vector2 normalized = new Vector2(Input.touches[this.ELFLAMBOJML].position.x - this.CEOCLMCLMIA.x, Input.touches[this.ELFLAMBOJML].position.y - this.CEOCLMCLMIA.y).normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.JEGEOJHBPKO(new Vector3(normalized.x, normalized.y, 0f));
			}
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x00592208 File Offset: 0x00590408
		private void Start()
		{
			this.FDOADMNFNPA = base.GetComponent<Image>();
			this.CEOCLMCLMIA = this.FDOADMNFNPA.transform.position;
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x00592BD4 File Offset: 0x00590DD4
		private void NLICFCHDGGM()
		{
			this.DCCCFCDJJMH = (this.axesToUse == TouchPad.FAILLMDGGMP.Both || this.axesToUse == TouchPad.FAILLMDGGMP.Both);
			this.GIKPIIHCDCG = (this.axesToUse != TouchPad.FAILLMDGGMP.Both && this.axesToUse == TouchPad.FAILLMDGGMP.OnlyVertical);
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

		// Token: 0x04001A5E RID: 6750
		public TouchPad.FAILLMDGGMP axesToUse;

		// Token: 0x04001A5F RID: 6751
		public TouchPad.IACBLLCBFJJ controlStyle;

		// Token: 0x04001A60 RID: 6752
		public string horizontalAxisName = "Horizontal";

		// Token: 0x04001A61 RID: 6753
		public string verticalAxisName = "Vertical";

		// Token: 0x04001A62 RID: 6754
		public float Xsensitivity = 1f;

		// Token: 0x04001A63 RID: 6755
		public float Ysensitivity = 1f;

		// Token: 0x04001A64 RID: 6756
		private Vector3 NMBMCKBKKDD;

		// Token: 0x04001A65 RID: 6757
		private Vector2 OLNAFMANNFH;

		// Token: 0x04001A66 RID: 6758
		private Vector3 NAFCKILKMDE;

		// Token: 0x04001A67 RID: 6759
		private bool DCCCFCDJJMH;

		// Token: 0x04001A68 RID: 6760
		private bool GIKPIIHCDCG;

		// Token: 0x04001A69 RID: 6761
		private CELBHNONENJ.FANBIHFODMJ FLJGMPJDKBC;

		// Token: 0x04001A6A RID: 6762
		private CELBHNONENJ.FANBIHFODMJ HJCDIDCBMLF;

		// Token: 0x04001A6B RID: 6763
		private bool JNOLKKFACKF;

		// Token: 0x04001A6C RID: 6764
		private int ELFLAMBOJML = -1;

		// Token: 0x04001A6D RID: 6765
		private Vector2 DNMJJCFKJDN;

		// Token: 0x04001A6E RID: 6766
		private Vector3 CEOCLMCLMIA;

		// Token: 0x04001A6F RID: 6767
		private Image FDOADMNFNPA;

		// Token: 0x02000399 RID: 921
		public enum FAILLMDGGMP
		{
			// Token: 0x04001A71 RID: 6769
			Both,
			// Token: 0x04001A72 RID: 6770
			OnlyHorizontal,
			// Token: 0x04001A73 RID: 6771
			OnlyVertical
		}

		// Token: 0x0200039A RID: 922
		public enum IACBLLCBFJJ
		{
			// Token: 0x04001A75 RID: 6773
			Absolute,
			// Token: 0x04001A76 RID: 6774
			Relative,
			// Token: 0x04001A77 RID: 6775
			Swipe
		}
	}
}
