using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002C7 RID: 711
	public class ActivateTrigger : MonoBehaviour
	{
		// Token: 0x0600A7DA RID: 42970 RVA: 0x004AF5D7 File Offset: 0x004AD7D7
		private void IONDDMEDNNE(Collider INDANOPGHCN)
		{
			this.PEONCGMGDCF();
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x004AF5DF File Offset: 0x004AD7DF
		private void NJEMHMEKOKA(Collider INDANOPGHCN)
		{
			this.BNIEOFABGNK();
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x004AF5E8 File Offset: 0x004AD7E8
		private void PEENLKHOKAF()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("silence");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x004AF709 File Offset: 0x004AD909
		private void OnTriggerEnter(Collider INDANOPGHCN)
		{
			this.BPGALDIMFFK();
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x004AF711 File Offset: 0x004AD911
		private void ECCAAMOGIFA(Collider INDANOPGHCN)
		{
			this.IBBIJOAFGON();
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x004AF71C File Offset: 0x004AD91C
		private void KOCGDAPKNNP()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("IdleStrafeLeft");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x004AF83D File Offset: 0x004ADA3D
		private void FCFFANBLEBO(Collider INDANOPGHCN)
		{
			this.GFEODPHENDP();
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x004AF848 File Offset: 0x004ADA48
		private void LALIOIHNMNG()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("popl.ogg");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x004AF709 File Offset: 0x004AD909
		private void AMDDKDKBDHC(Collider INDANOPGHCN)
		{
			this.BPGALDIMFFK();
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x004AF96C File Offset: 0x004ADB6C
		private void GFEODPHENDP()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x004AFA8D File Offset: 0x004ADC8D
		private void MMIIFMNJBED(Collider INDANOPGHCN)
		{
			this.GHFAGLOGPHC();
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x004AFA98 File Offset: 0x004ADC98
		private void ILPHDDCDMDE()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("Quest langfile not found!");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x004AF709 File Offset: 0x004AD909
		private void GHMLHNEJDKD(Collider INDANOPGHCN)
		{
			this.BPGALDIMFFK();
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x004AFBB9 File Offset: 0x004ADDB9
		private void LNNDNMAPAEA(Collider INDANOPGHCN)
		{
			this.ILPHDDCDMDE();
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x004AFBC1 File Offset: 0x004ADDC1
		private void DHIAKKIOEAN(Collider INDANOPGHCN)
		{
			this.EKBGBCKMPGL();
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x004AFBC9 File Offset: 0x004ADDC9
		private void NMNFMPKPNGI(Collider INDANOPGHCN)
		{
			this.OMOEEKBMIPP();
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x004AFBD4 File Offset: 0x004ADDD4
		private void EKBGBCKMPGL()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("3");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x004AFCF5 File Offset: 0x004ADEF5
		private void KOABECHGJGE(Collider INDANOPGHCN)
		{
			this.FAMGEDKJKAC();
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x004AFD00 File Offset: 0x004ADF00
		private void KGNLOJMBBIF()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("userForceMagnitude=");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x004AF5D7 File Offset: 0x004AD7D7
		private void GPOJMKLGNMP(Collider INDANOPGHCN)
		{
			this.PEONCGMGDCF();
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x004AFE24 File Offset: 0x004AE024
		private void EBOEFHMFFNL()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("CrawlIdle");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x004AFF45 File Offset: 0x004AE145
		private void LELKOMPOCEL(Collider INDANOPGHCN)
		{
			this.EBOEFHMFFNL();
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x004AFA8D File Offset: 0x004ADC8D
		private void LGDLIMDGJDA(Collider INDANOPGHCN)
		{
			this.GHFAGLOGPHC();
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x004AFF64 File Offset: 0x004AE164
		private void DHJKCHKEBID()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("SUNSHINE_FILTER_PCF_2x2");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x004B0088 File Offset: 0x004AE288
		private void BPGALDIMFFK()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("BPGALDIMFFK");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x004B01A9 File Offset: 0x004AE3A9
		private void AEIMGEFCGID(Collider INDANOPGHCN)
		{
			this.MDJAEBPAELN();
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x004AFBB9 File Offset: 0x004ADDB9
		private void JPAEKAMADCD(Collider INDANOPGHCN)
		{
			this.ILPHDDCDMDE();
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x004AFCF5 File Offset: 0x004ADEF5
		private void HIOGFAJFMGH(Collider INDANOPGHCN)
		{
			this.FAMGEDKJKAC();
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x004B01B1 File Offset: 0x004AE3B1
		private void FBAHBODCOII(Collider INDANOPGHCN)
		{
			this.MPANGEKEDKA();
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x004AF83D File Offset: 0x004ADA3D
		private void PCMNKLGCGMK(Collider INDANOPGHCN)
		{
			this.GFEODPHENDP();
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x004B01BC File Offset: 0x004AE3BC
		private void JCLKJOPKPKN()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("inner_craft_wpn");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x004B01A9 File Offset: 0x004AE3A9
		private void CANBPOPCGPI(Collider INDANOPGHCN)
		{
			this.MDJAEBPAELN();
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x004AF83D File Offset: 0x004ADA3D
		private void HEALIMEGLFP(Collider INDANOPGHCN)
		{
			this.GFEODPHENDP();
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x004B02E0 File Offset: 0x004AE4E0
		private void NEMHKAOAPPE()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("\n");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x004AF711 File Offset: 0x004AD911
		private void IBFJAHODEIA(Collider INDANOPGHCN)
		{
			this.IBBIJOAFGON();
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x004AFF45 File Offset: 0x004AE145
		private void PDEJKMAKHBK(Collider INDANOPGHCN)
		{
			this.EBOEFHMFFNL();
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x004B0401 File Offset: 0x004AE601
		private void FKOLJDCBFGI(Collider INDANOPGHCN)
		{
			this.DHJKCHKEBID();
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x004AF83D File Offset: 0x004ADA3D
		private void GOFJHMAOPBN(Collider INDANOPGHCN)
		{
			this.GFEODPHENDP();
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x004B040C File Offset: 0x004AE60C
		private void KIGFKDBPJOE()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("str=");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x004B052D File Offset: 0x004AE72D
		private void PFNDBONPCMK(Collider INDANOPGHCN)
		{
			this.PCPKIKNPDKK();
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x004AF711 File Offset: 0x004AD911
		private void NEHCBMLLGDB(Collider INDANOPGHCN)
		{
			this.IBBIJOAFGON();
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x004B0535 File Offset: 0x004AE735
		private void DDINGDJKKOC(Collider INDANOPGHCN)
		{
			this.NEMHKAOAPPE();
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x004B0540 File Offset: 0x004AE740
		private void PCPKIKNPDKK()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("_Texture");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x004B0664 File Offset: 0x004AE864
		private void GHFAGLOGPHC()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("_FogPointLightPosition");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x004B0785 File Offset: 0x004AE985
		private void OFBOOGHDLHP(Collider INDANOPGHCN)
		{
			this.KGNLOJMBBIF();
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x004B078D File Offset: 0x004AE98D
		private void PEHLHFDILHN(Collider INDANOPGHCN)
		{
			this.IGKFIGPEANG();
		}

		// Token: 0x0600A809 RID: 43017 RVA: 0x004B0798 File Offset: 0x004AE998
		private void PEONCGMGDCF()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("EventSystem");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A80A RID: 43018 RVA: 0x004B08BC File Offset: 0x004AEABC
		private void OMOEEKBMIPP()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("float:");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A80B RID: 43019 RVA: 0x004B09E0 File Offset: 0x004AEBE0
		private void BNIEOFABGNK()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = true;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x004AFCF5 File Offset: 0x004ADEF5
		private void BHDPBMPLAJB(Collider INDANOPGHCN)
		{
			this.FAMGEDKJKAC();
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x004B0B04 File Offset: 0x004AED04
		private void MPANGEKEDKA()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("OfficeSittingReadingCoffeeSip");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x004AF5DF File Offset: 0x004AD7DF
		private void DHFHPMAHMGP(Collider INDANOPGHCN)
		{
			this.BNIEOFABGNK();
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x004B0785 File Offset: 0x004AE985
		private void HEBGANJHAIH(Collider INDANOPGHCN)
		{
			this.KGNLOJMBBIF();
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x004B0C28 File Offset: 0x004AEE28
		private void IGKFIGPEANG()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("Clear all entries");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x004AFCF5 File Offset: 0x004ADEF5
		private void PEDNOGCIDBL(Collider INDANOPGHCN)
		{
			this.FAMGEDKJKAC();
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x004B0D4C File Offset: 0x004AEF4C
		private void MDJAEBPAELN()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("crft_crft");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(true);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x004B0E70 File Offset: 0x004AF070
		private void IBBIJOAFGON()
		{
			this.triggerCount--;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("Hips");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x004B0F91 File Offset: 0x004AF191
		private void LKENABHGOIK(Collider INDANOPGHCN)
		{
			this.JCLKJOPKPKN();
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x004B0F9C File Offset: 0x004AF19C
		private void FAMGEDKJKAC()
		{
			this.triggerCount -= 0;
			if (this.triggerCount == 0 || this.repeatTrigger)
			{
				UnityEngine.Object @object = this.target ?? base.gameObject;
				Behaviour behaviour = @object as Behaviour;
				GameObject gameObject = @object as GameObject;
				if (behaviour != null)
				{
					gameObject = behaviour.gameObject;
				}
				switch (this.action)
				{
				case ActivateTrigger.HLFGEKBLILC.Trigger:
					if (gameObject != null)
					{
						gameObject.BroadcastMessage("wpn_cat3");
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Replace:
					if (this.source != null && gameObject != null)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.source, gameObject.transform.position, gameObject.transform.rotation);
						UnityEngine.Object.DestroyObject(gameObject);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Activate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Enable:
					if (behaviour != null)
					{
						behaviour.enabled = false;
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Animate:
					if (gameObject != null)
					{
						gameObject.GetComponent<Animation>().Play();
						return;
					}
					break;
				case ActivateTrigger.HLFGEKBLILC.Deactivate:
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x040015AA RID: 5546
		public ActivateTrigger.HLFGEKBLILC action = ActivateTrigger.HLFGEKBLILC.Activate;

		// Token: 0x040015AB RID: 5547
		public UnityEngine.Object target;

		// Token: 0x040015AC RID: 5548
		public GameObject source;

		// Token: 0x040015AD RID: 5549
		public int triggerCount = 1;

		// Token: 0x040015AE RID: 5550
		public bool repeatTrigger;

		// Token: 0x020002C8 RID: 712
		public enum HLFGEKBLILC
		{
			// Token: 0x040015B0 RID: 5552
			Trigger,
			// Token: 0x040015B1 RID: 5553
			Replace,
			// Token: 0x040015B2 RID: 5554
			Activate,
			// Token: 0x040015B3 RID: 5555
			Enable,
			// Token: 0x040015B4 RID: 5556
			Animate,
			// Token: 0x040015B5 RID: 5557
			Deactivate
		}
	}
}
