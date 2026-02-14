using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003FA RID: 1018
	public class HitReactionTrigger : MonoBehaviour
	{
		// Token: 0x0600DACD RID: 56013 RVA: 0x00641F24 File Offset: 0x00640124
		private void OFPGMNGFLNH()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1189f))
				{
					this.hitReaction.POPHKKJGILI(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DACE RID: 56014 RVA: 0x00641FA0 File Offset: 0x006401A0
		private void BJOICAKCPLI()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1075f))
				{
					this.hitReaction.DGJNEMKBHPN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x0064201C File Offset: 0x0064021C
		private void MFHGOLNLAAF()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 895f))
				{
					this.hitReaction.HNENJEDNCMA(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAD0 RID: 56016 RVA: 0x00642095 File Offset: 0x00640295
		private void JGAMNLOICJN()
		{
			GUILayout.Label("#a02000", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("_Offsets" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x006420D2 File Offset: 0x006402D2
		private void JEJGFDBHABC()
		{
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("ACHIEVEMENT_1_1" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x0064210F File Offset: 0x0064030F
		private void OnGUI()
		{
			GUILayout.Label("LMB to shoot the Dummy, RMB to rotate the camera.", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("Last Bone Hit: " + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAD3 RID: 56019 RVA: 0x0064214C File Offset: 0x0064034C
		private void BOAJJAKEMLH()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1756f))
				{
					this.hitReaction.Hit(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x006421C8 File Offset: 0x006403C8
		private void BNKJNBIDPME()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 43f))
				{
					this.hitReaction.IKMHIDPLNGG(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x00642254 File Offset: 0x00640454
		private void JOHDLNOKCOK()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 529f))
				{
					this.hitReaction.HNENJEDNCMA(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x006422CD File Offset: 0x006404CD
		private void MJDKGMEPMHK()
		{
			GUILayout.Label("SkateboardKickPush", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("fshop_hd4" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAD8 RID: 56024 RVA: 0x0064230A File Offset: 0x0064050A
		private void IPFNFHPFAOE()
		{
			GUILayout.Label("Sitting Leg Cross", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("Channel Cast Omni" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x00642348 File Offset: 0x00640548
		private void AMDMCKIFBPA()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 916f))
				{
					this.hitReaction.CBNLNKHDADN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x006423C4 File Offset: 0x006405C4
		private void AKLFCMNCPKL()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1434f))
				{
					this.hitReaction.AKLOPFDDBNL(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DADB RID: 56027 RVA: 0x00642440 File Offset: 0x00640640
		private void HAIMGCDKPDC()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 903f))
				{
					this.hitReaction.HNNMLBDOICA(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x006424BC File Offset: 0x006406BC
		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 100f))
				{
					this.hitReaction.Hit(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DADD RID: 56029 RVA: 0x00642535 File Offset: 0x00640735
		private void JAOIOHLFLFO()
		{
			GUILayout.Label("isMoving", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("No Template! ID=" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DADE RID: 56030 RVA: 0x00642574 File Offset: 0x00640774
		private void OPDCJCFMIPE()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 481f))
				{
					this.hitReaction.IKMHIDPLNGG(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DADF RID: 56031 RVA: 0x006425ED File Offset: 0x006407ED
		private void JADGLEGEDGJ()
		{
			GUILayout.Label("__c", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("_OcclusionTexture" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x0064262C File Offset: 0x0064082C
		private void LMMDHJJJNJO()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 888f))
				{
					this.hitReaction.CBNLNKHDADN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x006426A8 File Offset: 0x006408A8
		private void PJHEGHHOJHJ()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1053f))
				{
					this.hitReaction.GFDEEJGEINN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00642724 File Offset: 0x00640924
		private void FJEEADNCKAG()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1088f))
				{
					this.hitReaction.CBNLNKHDADN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x006427A0 File Offset: 0x006409A0
		private void PGIHAIPCJLL()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 340f))
				{
					this.hitReaction.BEBDCOIJHKH(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE4 RID: 56036 RVA: 0x00642819 File Offset: 0x00640A19
		private void OBDAPPLCPMD()
		{
			GUILayout.Label("value", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("{not_found}" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00642856 File Offset: 0x00640A56
		private void BMCKJEBCEPA()
		{
			GUILayout.Label("invn_rec16", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00642894 File Offset: 0x00640A94
		private void PMKOAHMNBBG()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 298f))
				{
					this.hitReaction.BEBDCOIJHKH(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x00642910 File Offset: 0x00640B10
		private void JLFBDOPFDDJ()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1516f))
				{
					this.hitReaction.IKMHIDPLNGG(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE8 RID: 56040 RVA: 0x0064298C File Offset: 0x00640B8C
		private void IGEICBNMPAD()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 603f))
				{
					this.hitReaction.HEPIIPMJMHI(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x00642A08 File Offset: 0x00640C08
		private void KJJBBLDJHPD()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 1453f))
				{
					this.hitReaction.AFACAEKCMLK(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAEA RID: 56042 RVA: 0x00642A84 File Offset: 0x00640C84
		private void AIAMIFEPALP()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 155f))
				{
					this.hitReaction.EHPBJHJNLNP(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAEB RID: 56043 RVA: 0x00642AFD File Offset: 0x00640CFD
		private void LFCIINOHNLB()
		{
			GUILayout.Label("Wand Stand", Array.Empty<GUILayoutOption>());
			if (this.NOBLFEHJPDH != string.Empty)
			{
				GUILayout.Label("SoccerStartKick" + this.NOBLFEHJPDH, Array.Empty<GUILayoutOption>());
			}
		}

		// Token: 0x0600DAEC RID: 56044 RVA: 0x00642B3C File Offset: 0x00640D3C
		private void OHKHOAKCENL()
		{
			if (Input.GetMouseButtonDown(1))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 637f))
				{
					this.hitReaction.JFEIHHJIIIA(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAED RID: 56045 RVA: 0x00642BB8 File Offset: 0x00640DB8
		private void HMEAENGBFKC()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 390f))
				{
					this.hitReaction.AKLOPFDDBNL(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x00642C34 File Offset: 0x00640E34
		private void PFPPDNHLCCA()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 239f))
				{
					this.hitReaction.HEPIIPMJMHI(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00642CB0 File Offset: 0x00640EB0
		private void MEFOGCFJBNE()
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit, 576f))
				{
					this.hitReaction.DGJNEMKBHPN(raycastHit.collider, ray.direction * this.hitForce, raycastHit.point);
					this.NOBLFEHJPDH = raycastHit.collider.name;
				}
			}
		}

		// Token: 0x04001D03 RID: 7427
		[SerializeField]
		private HitReaction hitReaction;

		// Token: 0x04001D04 RID: 7428
		[SerializeField]
		private float hitForce = 1f;

		// Token: 0x04001D05 RID: 7429
		private string NOBLFEHJPDH;
	}
}
