using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200040B RID: 1035
	public class RagdollUtilityDemo : MonoBehaviour
	{
		// Token: 0x0600DDC6 RID: 56774 RVA: 0x0065BFBC File Offset: 0x0065A1BC
		private void LBGKAMLLACN()
		{
			if (Input.GetKeyDown((KeyCode)(-101)))
			{
				this.ragdollUtility.EnableRagdoll();
			}
			if (Input.GetKeyDown(KeyCode.At))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LGFMMAHDDFB();
			}
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x0065C040 File Offset: 0x0065A240
		private void KBEOAOKBHEK()
		{
			GUILayout.Label("RollerBladeFrontFlip", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x0065C051 File Offset: 0x0065A251
		private void LFCIINOHNLB()
		{
			GUILayout.Label("post_19", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x0065C062 File Offset: 0x0065A262
		private void EMNMOMGOBPI()
		{
			GUILayout.Label("_UV_Transform", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDCA RID: 56778 RVA: 0x0065C073 File Offset: 0x0065A273
		private void BLCDCEHNNNC()
		{
			GUILayout.Label("Poplavok", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDCB RID: 56779 RVA: 0x0065C084 File Offset: 0x0065A284
		private void JGAMNLOICJN()
		{
			GUILayout.Label("FOG_SCATTERING_ON", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x0065C098 File Offset: 0x0065A298
		private void KJJBBLDJHPD()
		{
			if (Input.GetKeyDown(KeyCode.Equals))
			{
				this.ragdollUtility.EACMDGBKHGD();
			}
			if (Input.GetKeyDown((KeyCode)(-22)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LGFMMAHDDFB();
			}
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x0065C11C File Offset: 0x0065A31C
		private void CBBLGEDCJBF()
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)7))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LFDBKGFHHON();
			}
		}

		// Token: 0x0600DDCE RID: 56782 RVA: 0x0065C1A0 File Offset: 0x0065A3A0
		private void BMCKJEBCEPA()
		{
			GUILayout.Label("inv_money", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDCF RID: 56783 RVA: 0x0065C1B4 File Offset: 0x0065A3B4
		private void BNKJNBIDPME()
		{
			if (Input.GetKeyDown((KeyCode)(-7)))
			{
				this.ragdollUtility.GABOEBOKNBM();
			}
			if (Input.GetKeyDown((KeyCode)6))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.FHFKCJJKCJF();
			}
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x0065C238 File Offset: 0x0065A438
		private void OnGUI()
		{
			GUILayout.Label(" Press R to switch to ragdoll. \n Weigh in one of the FBBIK effectors to make kinematic changes to the ragdoll pose.\n A to blend back to animation", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x0065C24C File Offset: 0x0065A44C
		private void MEFOGCFJBNE()
		{
			if (Input.GetKeyDown((KeyCode)(-3)))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)(-32)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.MMMPIDEEMHN();
			}
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x0065C2D0 File Offset: 0x0065A4D0
		private void PFPPDNHLCCA()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				this.ragdollUtility.HPLKDBEEGIH();
			}
			if (Input.GetKeyDown((KeyCode)(-115)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.JEECMAKCBFD();
			}
		}

		// Token: 0x0600DDD3 RID: 56787 RVA: 0x0065C354 File Offset: 0x0065A554
		private void PBADPBBJBEJ()
		{
			GUILayout.Label("1 Hand Sword Swing", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x0065C368 File Offset: 0x0065A568
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				this.ragdollUtility.EnableRagdoll();
			}
			if (Input.GetKeyDown(KeyCode.A))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.DisableRagdoll();
			}
		}

		// Token: 0x0600DDD5 RID: 56789 RVA: 0x0065C3EC File Offset: 0x0065A5EC
		private void PNJNNNJEBGA()
		{
			GUILayout.Label("</color>", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x0065C400 File Offset: 0x0065A600
		private void JLFBDOPFDDJ()
		{
			if (Input.GetKeyDown((KeyCode)(-26)))
			{
				this.ragdollUtility.GABOEBOKNBM();
			}
			if (Input.GetKeyDown((KeyCode)(-112)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.MMMPIDEEMHN();
			}
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x0065C484 File Offset: 0x0065A684
		private void LPNFGGAKGID()
		{
			GUILayout.Label("_MainTex", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x0065C498 File Offset: 0x0065A698
		private void JOHDLNOKCOK()
		{
			if (Input.GetKeyDown((KeyCode)(-9)))
			{
				this.ragdollUtility.EACMDGBKHGD();
			}
			if (Input.GetKeyDown((KeyCode)(-12)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.MMMPIDEEMHN();
			}
		}

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x0065C51C File Offset: 0x0065A71C
		private void EILPHLEBEJP()
		{
			GUILayout.Label("_MainTexBlurred", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x0065C52D File Offset: 0x0065A72D
		private void AHEAJPNHBBB()
		{
			GUILayout.Label("****************** CamEffector APPLY 1", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDDB RID: 56795 RVA: 0x0065C53E File Offset: 0x0065A73E
		private void MPPMHCICKIP()
		{
			GUILayout.Label("Right Hand Effector needs a Target in this demo.", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDDC RID: 56796 RVA: 0x0065C550 File Offset: 0x0065A750
		private void PMKOAHMNBBG()
		{
			if (Input.GetKeyDown((KeyCode)89))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)(-59)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.GOIGBPIKJCN();
			}
		}

		// Token: 0x0600DDDD RID: 56797 RVA: 0x0065C5D4 File Offset: 0x0065A7D4
		private void OHKHOAKCENL()
		{
			if (Input.GetKeyDown((KeyCode)(-32)))
			{
				this.ragdollUtility.GABOEBOKNBM();
			}
			if (Input.GetKeyDown(KeyCode.Clear))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.GOIGBPIKJCN();
			}
		}

		// Token: 0x0600DDDE RID: 56798 RVA: 0x0065C658 File Offset: 0x0065A858
		private void KIEFPGLDOCD()
		{
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x0065C66C File Offset: 0x0065A86C
		private void FPLNDDMFFKG()
		{
			if (Input.GetKeyDown((KeyCode)(-104)))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)69))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.HEAJADMBLGG();
			}
		}

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x0065C6F0 File Offset: 0x0065A8F0
		private void PNBGJBMJLFM()
		{
			if (Input.GetKeyDown((KeyCode)(-25)))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)(-125)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LFDBKGFHHON();
			}
		}

		// Token: 0x0600DDE1 RID: 56801 RVA: 0x0065C774 File Offset: 0x0065A974
		private void OBDAPPLCPMD()
		{
			GUILayout.Label("BowInstant2", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDE2 RID: 56802 RVA: 0x0065C788 File Offset: 0x0065A988
		private void CJHBCHBOLBI()
		{
			if (Input.GetKeyDown((KeyCode)(-77)))
			{
				this.ragdollUtility.MGAPOJHEDNL();
			}
			if (Input.GetKeyDown(KeyCode.Exclaim))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LFDBKGFHHON();
			}
		}

		// Token: 0x0600DDE3 RID: 56803 RVA: 0x0065C80C File Offset: 0x0065AA0C
		private void BBGAONKBIPJ()
		{
			GUILayout.Label("t_eye", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x0065C81D File Offset: 0x0065AA1D
		private void GGOKNBBPLHB()
		{
			GUILayout.Label("toquality=", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x0065C82E File Offset: 0x0065AA2E
		private void JADGLEGEDGJ()
		{
			GUILayout.Label("Crouch", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x0065C840 File Offset: 0x0065AA40
		private void BOAJJAKEMLH()
		{
			if (Input.GetKeyDown(KeyCode.Exclaim))
			{
				this.ragdollUtility.MGAPOJHEDNL();
			}
			if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.JEECMAKCBFD();
			}
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x0065C8C4 File Offset: 0x0065AAC4
		private void HAIMGCDKPDC()
		{
			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				this.ragdollUtility.EnableRagdoll();
			}
			if (Input.GetKeyDown((KeyCode)(-42)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.GOIGBPIKJCN();
			}
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x0065C948 File Offset: 0x0065AB48
		private void FJEEADNCKAG()
		{
			if (Input.GetKeyDown((KeyCode)(-99)))
			{
				this.ragdollUtility.HPLKDBEEGIH();
			}
			if (Input.GetKeyDown((KeyCode)83))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.DisableRagdoll();
			}
		}

		// Token: 0x0600DDEA RID: 56810 RVA: 0x0065C9CC File Offset: 0x0065ABCC
		private void LDDIGEMBDNF()
		{
			if (Input.GetKeyDown((KeyCode)(-112)))
			{
				this.ragdollUtility.MGAPOJHEDNL();
			}
			if (Input.GetKeyDown((KeyCode)(-97)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.DisableRagdoll();
			}
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x0065CA50 File Offset: 0x0065AC50
		private void OPDCJCFMIPE()
		{
			if (Input.GetKeyDown((KeyCode)11))
			{
				this.ragdollUtility.DJKAEOFKAAA();
			}
			if (Input.GetKeyDown((KeyCode)(-70)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.GOIGBPIKJCN();
			}
		}

		// Token: 0x0600DDEC RID: 56812 RVA: 0x0065CAD4 File Offset: 0x0065ACD4
		private void IGEICBNMPAD()
		{
			if (Input.GetKeyDown((KeyCode)(-21)))
			{
				this.ragdollUtility.MGAPOJHEDNL();
			}
			if (Input.GetKeyDown((KeyCode)(-21)))
			{
				Vector3 b = this.pelvis.position - this.root.position;
				this.root.position += b;
				this.pelvis.transform.position -= b;
				this.ragdollUtility.LFDBKGFHHON();
			}
		}

		// Token: 0x04001D5E RID: 7518
		public RagdollUtility ragdollUtility;

		// Token: 0x04001D5F RID: 7519
		public Transform root;

		// Token: 0x04001D60 RID: 7520
		public Rigidbody pelvis;
	}
}
