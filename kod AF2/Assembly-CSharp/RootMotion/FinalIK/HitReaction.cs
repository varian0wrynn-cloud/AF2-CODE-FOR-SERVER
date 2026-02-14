using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004BC RID: 1212
	public class HitReaction : OffsetModifier
	{
		// Token: 0x06010823 RID: 67619 RVA: 0x0075BDAC File Offset: 0x00759FAC
		protected virtual void HHBDJBJEFCJ()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010824 RID: 67620 RVA: 0x0075BE18 File Offset: 0x0075A018
		public void AKLOPFDDBNL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Special");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010825 RID: 67621 RVA: 0x0075BEA0 File Offset: 0x0075A0A0
		public void EEEAAHGKNLJ(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("SoccerKeeperJump");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010826 RID: 67622 RVA: 0x0075BF28 File Offset: 0x0075A128
		public void LGHMMGDAEKL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010827 RID: 67623 RVA: 0x0075BFB0 File Offset: 0x0075A1B0
		public void EHPBJHJNLNP(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("#ff8060");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010828 RID: 67624 RVA: 0x0075C038 File Offset: 0x0075A238
		protected virtual void GEAKAHAAGIC()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010829 RID: 67625 RVA: 0x0075C0A4 File Offset: 0x0075A2A4
		protected virtual void KLLBLFKGMLD()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601082A RID: 67626 RVA: 0x0075C110 File Offset: 0x0075A310
		protected virtual void BGEEPBOFMKG()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601082B RID: 67627 RVA: 0x0075C17C File Offset: 0x0075A37C
		protected override void HEHOBGDMLOK()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601082C RID: 67628 RVA: 0x0075C1E8 File Offset: 0x0075A3E8
		public void GFDEEJGEINN(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("BackPackSearch");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601082D RID: 67629 RVA: 0x0075C270 File Offset: 0x0075A470
		protected virtual void GCPENONAGDG()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601082E RID: 67630 RVA: 0x0075C2DC File Offset: 0x0075A4DC
		protected virtual void LHDCDIOEODG()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601082F RID: 67631 RVA: 0x0075C348 File Offset: 0x0075A548
		protected virtual void ELMHLFFIOGL()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010830 RID: 67632 RVA: 0x0075C3B4 File Offset: 0x0075A5B4
		public void CBNLNKHDADN(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Keeper Strafe Dive Far Right");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010831 RID: 67633 RVA: 0x0075C43C File Offset: 0x0075A63C
		protected virtual void OONMKGBFLCF()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010832 RID: 67634 RVA: 0x0075C4A8 File Offset: 0x0075A6A8
		public void POPHKKJGILI(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Sound/");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010833 RID: 67635 RVA: 0x0075C530 File Offset: 0x0075A730
		public void BEBDCOIJHKH(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError(" ");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010834 RID: 67636 RVA: 0x0075C5B8 File Offset: 0x0075A7B8
		public void HEPIIPMJMHI(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("?");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010835 RID: 67637 RVA: 0x0075C640 File Offset: 0x0075A840
		public void HNNMLBDOICA(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("<b>Obscured types:</b>\n<color=\"#75C4EB\">");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010836 RID: 67638 RVA: 0x0075C6C8 File Offset: 0x0075A8C8
		public void MCLHIJJDAGC(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("6");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010837 RID: 67639 RVA: 0x0075C750 File Offset: 0x0075A950
		protected virtual void MHKIHJKOJCE()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010838 RID: 67640 RVA: 0x0075C7BC File Offset: 0x0075A9BC
		public void PKIENGBIADB(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010839 RID: 67641 RVA: 0x0075C844 File Offset: 0x0075AA44
		public void DGJNEMKBHPN(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("_TempRT");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601083A RID: 67642 RVA: 0x0075C8CC File Offset: 0x0075AACC
		protected virtual void PMMPBOOINPD()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601083B RID: 67643 RVA: 0x0075C938 File Offset: 0x0075AB38
		protected virtual void MBGJEAMMJJN()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601083C RID: 67644 RVA: 0x0075C9A4 File Offset: 0x0075ABA4
		public void JFEIHHJIIIA(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("PaperTurn.wav");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601083E RID: 67646 RVA: 0x0075CA2C File Offset: 0x0075AC2C
		protected virtual void EKJCBOPLALL()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601083F RID: 67647 RVA: 0x0075CA98 File Offset: 0x0075AC98
		protected virtual void BCFDBGIOMBL()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010840 RID: 67648 RVA: 0x0075CB04 File Offset: 0x0075AD04
		protected virtual void KGGMOGBDHDN()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010841 RID: 67649 RVA: 0x0075CB70 File Offset: 0x0075AD70
		public void AFACAEKCMLK(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("WandStand");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010842 RID: 67650 RVA: 0x0075CBF8 File Offset: 0x0075ADF8
		protected virtual void MOBMBODBBPH()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010843 RID: 67651 RVA: 0x0075CC64 File Offset: 0x0075AE64
		public void AOAGAAKLHPB(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010844 RID: 67652 RVA: 0x0075CCEC File Offset: 0x0075AEEC
		protected virtual void DIFPMHCBFNE()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010845 RID: 67653 RVA: 0x0075CD58 File Offset: 0x0075AF58
		public void Hit(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010846 RID: 67654 RVA: 0x0075CDE0 File Offset: 0x0075AFE0
		public void IKMHIDPLNGG(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Flap_08.wav");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010847 RID: 67655 RVA: 0x0075CE68 File Offset: 0x0075B068
		protected virtual void GEJALLDIDKK()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010848 RID: 67656 RVA: 0x0075CED4 File Offset: 0x0075B0D4
		protected virtual void MLOBABEJJML()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x06010849 RID: 67657 RVA: 0x0075CF40 File Offset: 0x0075B140
		protected virtual void LOJCEKNCAOD()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601084A RID: 67658 RVA: 0x0075CFAC File Offset: 0x0075B1AC
		protected virtual void FNBKENOCJKD()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601084B RID: 67659 RVA: 0x0075D018 File Offset: 0x0075B218
		public void BGAGCIAJJGL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("SkateboardIdle");
				return;
			}
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReaction.HitPointEffector hitPointEffector = array[i];
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601084C RID: 67660 RVA: 0x0075D0A0 File Offset: 0x0075B2A0
		protected virtual void IMKHFLLACDF()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0601084D RID: 67661 RVA: 0x0075D10C File Offset: 0x0075B30C
		public void HNENJEDNCMA(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == JNBDKOKIPEC)
				{
					hitPointEffector.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReaction.HitPointBone hitPointBone = array2[i];
				if (hitPointBone.collider == JNBDKOKIPEC)
				{
					hitPointBone.NDLBPPIDCKG(PGEDLDMLBBE, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601084E RID: 67662 RVA: 0x0075D194 File Offset: 0x0075B394
		protected virtual void DCBCEDCNECB()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik.solver, this.weight);
			}
		}

		// Token: 0x0400227F RID: 8831
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x04002280 RID: 8832
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x020004BD RID: 1213
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x0601084F RID: 67663 RVA: 0x0075D1FD File Offset: 0x0075B3FD
			// (set) Token: 0x06010850 RID: 67664 RVA: 0x0075D205 File Offset: 0x0075B405
			private protected float crossFader { protected get; private set; }

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06010851 RID: 67665 RVA: 0x0075D20E File Offset: 0x0075B40E
			// (set) Token: 0x06010852 RID: 67666 RVA: 0x0075D216 File Offset: 0x0075B416
			private protected float timer { protected get; private set; }

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06010853 RID: 67667 RVA: 0x0075D21F File Offset: 0x0075B41F
			// (set) Token: 0x06010854 RID: 67668 RVA: 0x0075D227 File Offset: 0x0075B427
			private protected Vector3 force { protected get; private set; }

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06010855 RID: 67669 RVA: 0x0075D230 File Offset: 0x0075B430
			// (set) Token: 0x06010856 RID: 67670 RVA: 0x0075D238 File Offset: 0x0075B438
			private protected Vector3 point { protected get; private set; }

			// Token: 0x06010857 RID: 67671 RVA: 0x0075D244 File Offset: 0x0075B444
			public void NDLBPPIDCKG(Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
			{
				if (this.length == 0f)
				{
					this.length = this.BFNLJBGFDKI();
				}
				if (this.length <= 0f)
				{
					Debug.LogError("Hit Point WeightCurve length is zero.");
					return;
				}
				if (this.timer < 1f)
				{
					this.crossFader = 0f;
				}
				this.crossFadeSpeed = ((this.crossFadeTime > 0f) ? (1f / this.crossFadeTime) : 0f);
				this.NLOPANOPBFE();
				this.timer = 0f;
				this.force = PGEDLDMLBBE;
				this.point = JJNHJKFMFLJ;
			}

			// Token: 0x06010858 RID: 67672 RVA: 0x0075D2E0 File Offset: 0x0075B4E0
			public void DCLNJPIBFIA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				float num = Time.time - this.lastTime;
				this.lastTime = Time.time;
				if (this.timer >= this.length)
				{
					return;
				}
				this.timer = Mathf.Clamp(this.timer + num, 0f, this.length);
				if (this.crossFadeSpeed > 0f)
				{
					this.crossFader = Mathf.Clamp(this.crossFader + num * this.crossFadeSpeed, 0f, 1f);
				}
				else
				{
					this.crossFader = 1f;
				}
				this.IJBFHOEFACA(NBAKCIDALOF, NKHBAJKMAGD);
			}

			// Token: 0x06010859 RID: 67673
			protected abstract float BFNLJBGFDKI();

			// Token: 0x0601085A RID: 67674
			protected abstract void NLOPANOPBFE();

			// Token: 0x0601085B RID: 67675
			protected abstract void IJBFHOEFACA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD);

			// Token: 0x04002281 RID: 8833
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x04002282 RID: 8834
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x04002283 RID: 8835
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			// Token: 0x04002288 RID: 8840
			private float length;

			// Token: 0x04002289 RID: 8841
			private float crossFadeSpeed;

			// Token: 0x0400228A RID: 8842
			private float lastTime;
		}

		// Token: 0x020004BE RID: 1214
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x0601085D RID: 67677 RVA: 0x0075D38C File Offset: 0x0075B58C
			protected virtual void BEJBACCJJKJ(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].EFODADOEBIH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601085E RID: 67678 RVA: 0x0075D424 File Offset: 0x0075B624
			protected virtual void MLKFIPBKMJK(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DDLKHEECNKP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601085F RID: 67679 RVA: 0x0075D4BC File Offset: 0x0075B6BC
			protected virtual void MGDPPAIPAKE()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].FMEHEOHELIC();
				}
			}

			// Token: 0x06010860 RID: 67680 RVA: 0x0075D4E8 File Offset: 0x0075B6E8
			protected virtual void CLCEJMHPAOD()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].HFJGFPKKHHJ();
				}
			}

			// Token: 0x06010861 RID: 67681 RVA: 0x0075D514 File Offset: 0x0075B714
			protected virtual void LENAJCGIONE()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].EDHKCAPAMLL();
				}
			}

			// Token: 0x06010862 RID: 67682 RVA: 0x0075D540 File Offset: 0x0075B740
			protected virtual void FJNKKGOEBCN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DONBHEMMIDC(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010863 RID: 67683 RVA: 0x0075D5D8 File Offset: 0x0075B7D8
			protected virtual void DNOIOLCPFLA()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].FMEHEOHELIC();
				}
			}

			// Token: 0x06010864 RID: 67684 RVA: 0x0075D604 File Offset: 0x0075B804
			protected virtual float HKNPJOJHFDL()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1128f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1319f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010865 RID: 67685 RVA: 0x0075D68C File Offset: 0x0075B88C
			protected virtual float PMNNPBCFPHB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 263f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1105f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010866 RID: 67686 RVA: 0x0075D714 File Offset: 0x0075B914
			protected virtual float MJOPICENHHL()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1681f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1025f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010867 RID: 67687 RVA: 0x0075D79C File Offset: 0x0075B99C
			protected virtual void PLKAGPCAACD()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GFEOKEJJNKO();
				}
			}

			// Token: 0x06010868 RID: 67688 RVA: 0x0075D7C8 File Offset: 0x0075B9C8
			protected virtual void ODENJKEHDPB()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].MGDPPAIPAKE();
				}
			}

			// Token: 0x06010869 RID: 67689 RVA: 0x0075D7F4 File Offset: 0x0075B9F4
			protected virtual float OBBELJDICLD()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 658f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1091f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601086A RID: 67690 RVA: 0x0075D87C File Offset: 0x0075BA7C
			protected virtual void FLEFNEBLFJB(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GPAMMKENIAH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601086B RID: 67691 RVA: 0x0075D914 File Offset: 0x0075BB14
			protected virtual void ONLNNJPIAMD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].LBCOFBOKHJP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601086C RID: 67692 RVA: 0x0075D9AC File Offset: 0x0075BBAC
			protected virtual void MBCFLEHIKMB()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].BGOKAIEIKGN();
				}
			}

			// Token: 0x0601086D RID: 67693 RVA: 0x0075D9D8 File Offset: 0x0075BBD8
			protected virtual void IIJJGAFABBM()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].BBNAMLHJMHG();
				}
			}

			// Token: 0x0601086E RID: 67694 RVA: 0x0075DA04 File Offset: 0x0075BC04
			protected virtual float JLLECPBLNDB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1714f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1826f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601086F RID: 67695 RVA: 0x0075DA8C File Offset: 0x0075BC8C
			protected virtual void HOLAJGFNFAE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].IKKFBNIKGFO(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010871 RID: 67697 RVA: 0x0075DB2C File Offset: 0x0075BD2C
			protected virtual float MLBMKDLLGOE()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 898f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 910f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010872 RID: 67698 RVA: 0x0075DBB4 File Offset: 0x0075BDB4
			protected virtual float BEPDDPIKKGD()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1629f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1872f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010873 RID: 67699 RVA: 0x0075DC3C File Offset: 0x0075BE3C
			protected virtual void NBKOCFIHKMB(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DDLKHEECNKP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010874 RID: 67700 RVA: 0x0075DCD4 File Offset: 0x0075BED4
			protected virtual float BBJIIICENLL()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 259f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 911f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010875 RID: 67701 RVA: 0x0075DD5C File Offset: 0x0075BF5C
			protected virtual float MCMMGKAMJMB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 984f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 747f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010876 RID: 67702 RVA: 0x0075DDE4 File Offset: 0x0075BFE4
			protected virtual void JKKIKEBFAAI()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].MGDPPAIPAKE();
				}
			}

			// Token: 0x06010877 RID: 67703 RVA: 0x0075DE10 File Offset: 0x0075C010
			protected virtual float MCFINPDFHIG()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 60f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 905f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010878 RID: 67704 RVA: 0x0075DE98 File Offset: 0x0075C098
			protected virtual void LELJNMNJJFF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].KAFKDMBHNFF(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010879 RID: 67705 RVA: 0x0075DF30 File Offset: 0x0075C130
			protected virtual float BBKPCNCEAGD()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1760f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1235f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601087A RID: 67706 RVA: 0x0075DFB8 File Offset: 0x0075C1B8
			protected virtual float KHMPNAHPIIH()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1774f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 102f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601087B RID: 67707 RVA: 0x0075E040 File Offset: 0x0075C240
			protected virtual void IKDOJHOPCBN()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].ELPJBAHFKGF();
				}
			}

			// Token: 0x0601087C RID: 67708 RVA: 0x0075E06C File Offset: 0x0075C26C
			protected virtual float BABOCOJODCJ()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1414f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1855f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601087D RID: 67709 RVA: 0x0075E0F4 File Offset: 0x0075C2F4
			protected virtual void MAOLNAGKMOF()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DDDPKEIKNFM();
				}
			}

			// Token: 0x0601087E RID: 67710 RVA: 0x0075E120 File Offset: 0x0075C320
			protected virtual void NGOJODIDBOP(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DCLNJPIBFIA(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601087F RID: 67711 RVA: 0x0075E1B8 File Offset: 0x0075C3B8
			protected virtual void NABABGLEHJK(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].DAIGOMFBNOD(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010880 RID: 67712 RVA: 0x0075E250 File Offset: 0x0075C450
			protected virtual float ENDCCAIGDGA()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 200f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 537f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010881 RID: 67713 RVA: 0x0075E2D8 File Offset: 0x0075C4D8
			protected virtual float EMNAHNIGAGP()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1473f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 980f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010882 RID: 67714 RVA: 0x0075E360 File Offset: 0x0075C560
			protected virtual float MCAANHDKHBH()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1691f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1914f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010883 RID: 67715 RVA: 0x0075E3E8 File Offset: 0x0075C5E8
			protected virtual void IPKJJNPOOIH(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].MKNEBAOBLNI(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010884 RID: 67716 RVA: 0x0075E480 File Offset: 0x0075C680
			protected virtual void OCNINJAMBML()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].MGDPPAIPAKE();
				}
			}

			// Token: 0x06010885 RID: 67717 RVA: 0x0075E4AC File Offset: 0x0075C6AC
			protected virtual void MPMHECDCBKF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].MADHHPOGJLP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010886 RID: 67718 RVA: 0x0075E544 File Offset: 0x0075C744
			protected virtual void NGANGCPNKOB()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].EGNGKDIJLAA();
				}
			}

			// Token: 0x06010887 RID: 67719 RVA: 0x0075E570 File Offset: 0x0075C770
			protected virtual float NJEONKPPKKB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1520f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1692f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010888 RID: 67720 RVA: 0x0075E5F8 File Offset: 0x0075C7F8
			protected virtual void LIGHIHCHCPA()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].HKEIEMLMLGG();
				}
			}

			// Token: 0x06010889 RID: 67721 RVA: 0x0075E624 File Offset: 0x0075C824
			protected virtual float HBIODFMEDGO()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1925f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1782f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601088A RID: 67722 RVA: 0x0075E6AC File Offset: 0x0075C8AC
			protected virtual void BMMJEKGNMNL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].CLJPMKONBKL(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601088B RID: 67723 RVA: 0x0075E744 File Offset: 0x0075C944
			protected virtual float DEPINIGODOP()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 969f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 954f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601088C RID: 67724 RVA: 0x0075E7CC File Offset: 0x0075C9CC
			protected virtual void CNIIAHKLJFF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].MALHECMHHBB(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601088D RID: 67725 RVA: 0x0075E864 File Offset: 0x0075CA64
			protected virtual void ABHHEGPLIAM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CGCCHDHADNC(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601088E RID: 67726 RVA: 0x0075E8FC File Offset: 0x0075CAFC
			protected virtual void PEEMKOGKMFI()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].OFJNLEEONPN();
				}
			}

			// Token: 0x0601088F RID: 67727 RVA: 0x0075E928 File Offset: 0x0075CB28
			protected virtual void HBFAPJPKFLC(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].JBNOIPHEGDP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010890 RID: 67728 RVA: 0x0075E9C0 File Offset: 0x0075CBC0
			protected virtual void MNNPMABJPOF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].CGCCHDHADNC(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010891 RID: 67729 RVA: 0x0075EA58 File Offset: 0x0075CC58
			protected virtual void EAONBEIDLHL()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].JNHFFOEMGHD();
				}
			}

			// Token: 0x06010892 RID: 67730 RVA: 0x0075EA84 File Offset: 0x0075CC84
			protected virtual void EJFFGEOPHNO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GPAMMKENIAH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010893 RID: 67731 RVA: 0x0075EB1C File Offset: 0x0075CD1C
			protected override float BFNLJBGFDKI()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 0f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 0f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010894 RID: 67732 RVA: 0x0075EBA4 File Offset: 0x0075CDA4
			protected virtual void BPLHGGJNBKH(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].GPAMMKENIAH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010895 RID: 67733 RVA: 0x0075EC3C File Offset: 0x0075CE3C
			protected virtual float BJBNJBPEPMC()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1107f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 608f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010896 RID: 67734 RVA: 0x0075ECC4 File Offset: 0x0075CEC4
			protected virtual void PEHMMEFBHAK()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].ODDLNGDBDEG();
				}
			}

			// Token: 0x06010897 RID: 67735 RVA: 0x0075ECF0 File Offset: 0x0075CEF0
			protected virtual float KIKMNKBHBDE()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1053f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 336f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010898 RID: 67736 RVA: 0x0075ED78 File Offset: 0x0075CF78
			protected virtual void AIELLKMNGMF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DCLNJPIBFIA(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x06010899 RID: 67737 RVA: 0x0075EE10 File Offset: 0x0075D010
			protected virtual void NBBLEKMNKCD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].JFHHLOIKFKK(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601089A RID: 67738 RVA: 0x0075EEA8 File Offset: 0x0075D0A8
			protected virtual void JDPCJGNAFMF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GDMKIGLFFDN(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601089B RID: 67739 RVA: 0x0075EF40 File Offset: 0x0075D140
			protected virtual float OACEOKFBJHE()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1424f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1416f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601089C RID: 67740 RVA: 0x0075EFC8 File Offset: 0x0075D1C8
			protected virtual float AMGAAMHIFGC()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 346f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1695f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601089D RID: 67741 RVA: 0x0075F050 File Offset: 0x0075D250
			protected virtual float JHDJMBICGEB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1571f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 652f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601089E RID: 67742 RVA: 0x0075F0D8 File Offset: 0x0075D2D8
			protected override void IJBFHOEFACA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DCLNJPIBFIA(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0601089F RID: 67743 RVA: 0x0075F170 File Offset: 0x0075D370
			protected virtual float BNGOOHKOANB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1558f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1479f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A0 RID: 67744 RVA: 0x0075F1F8 File Offset: 0x0075D3F8
			protected override void NLOPANOPBFE()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].NLOPANOPBFE();
				}
			}

			// Token: 0x060108A1 RID: 67745 RVA: 0x0075F224 File Offset: 0x0075D424
			protected virtual float PDEGHEIJDCC()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 258f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 916f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A2 RID: 67746 RVA: 0x0075F2AC File Offset: 0x0075D4AC
			protected virtual float DHGIHNMNLNN()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 406f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1283f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A3 RID: 67747 RVA: 0x0075F334 File Offset: 0x0075D534
			protected virtual float LGOKIMBBKCO()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1827f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1213f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A4 RID: 67748 RVA: 0x0075F3BC File Offset: 0x0075D5BC
			protected virtual float KGCOILGAIHE()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 176f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 247f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A5 RID: 67749 RVA: 0x0075F444 File Offset: 0x0075D644
			protected virtual void ENNBLCKAHND(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].OPOECNMLAJM(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108A6 RID: 67750 RVA: 0x0075F4DC File Offset: 0x0075D6DC
			protected virtual float LEHHJHMMBJB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 664f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 31f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A7 RID: 67751 RVA: 0x0075F564 File Offset: 0x0075D764
			protected virtual float FKODAHEKGCB()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1231f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 985f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108A8 RID: 67752 RVA: 0x0075F5EC File Offset: 0x0075D7EC
			protected virtual void IMCDMIHAAMK()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].EGNGKDIJLAA();
				}
			}

			// Token: 0x060108A9 RID: 67753 RVA: 0x0075F618 File Offset: 0x0075D818
			protected virtual float DCEDLJKDOCP()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1574f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 719f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108AA RID: 67754 RVA: 0x0075F6A0 File Offset: 0x0075D8A0
			protected virtual float MMFAEHFEKDD()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 792f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 27f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108AB RID: 67755 RVA: 0x0075F728 File Offset: 0x0075D928
			protected virtual float GDAFPBLPKJJ()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1271f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 369f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108AC RID: 67756 RVA: 0x0075F7B0 File Offset: 0x0075D9B0
			protected virtual void NLDBCBMJLEN()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].GFIIHEDEGAL();
				}
			}

			// Token: 0x060108AD RID: 67757 RVA: 0x0075F7DC File Offset: 0x0075D9DC
			protected virtual float MPCNBEMEIHM()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1808f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1964f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108AE RID: 67758 RVA: 0x0075F864 File Offset: 0x0075DA64
			protected virtual float LCOBFFKOEPL()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 1484f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1460f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108AF RID: 67759 RVA: 0x0075F8EC File Offset: 0x0075DAEC
			protected virtual float ONGJBKKMJCI()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1001f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1842f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108B0 RID: 67760 RVA: 0x0075F974 File Offset: 0x0075DB74
			protected virtual void NDLHGIILOFB(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DDLKHEECNKP(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108B1 RID: 67761 RVA: 0x0075FA0C File Offset: 0x0075DC0C
			protected virtual float IJGKHOLGJDK()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 991f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 548f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108B2 RID: 67762 RVA: 0x0075FA94 File Offset: 0x0075DC94
			protected virtual float PFEFBCKIAJA()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 0].time : 34f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1438f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108B3 RID: 67763 RVA: 0x0075FB1C File Offset: 0x0075DD1C
			protected virtual void CCMJKONGAGN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].EFODADOEBIH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108B4 RID: 67764 RVA: 0x0075FBB4 File Offset: 0x0075DDB4
			protected virtual void ELABENBDJLK(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CEDJFNODCHA(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108B5 RID: 67765 RVA: 0x0075FC4C File Offset: 0x0075DE4C
			protected virtual float LOJODNJEMFO()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 991f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 718f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108B6 RID: 67766 RVA: 0x0075FCD4 File Offset: 0x0075DED4
			protected virtual void HDKGBIEFABE()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].FKIIKDIODJC();
				}
			}

			// Token: 0x060108B7 RID: 67767 RVA: 0x0075FD00 File Offset: 0x0075DF00
			protected virtual float DGMMGNOKKPN()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1404f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1349f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108B8 RID: 67768 RVA: 0x0075FD88 File Offset: 0x0075DF88
			protected virtual void PFAGKPGNAPO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].JFHHLOIKFKK(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108B9 RID: 67769 RVA: 0x0075FE20 File Offset: 0x0075E020
			protected virtual void KBFPBCHHDDB()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].EAONBEIDLHL();
				}
			}

			// Token: 0x060108BA RID: 67770 RVA: 0x0075FE4C File Offset: 0x0075E04C
			protected virtual float NPJEMCIMIOH()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 422f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 1306f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108BB RID: 67771 RVA: 0x0075FED4 File Offset: 0x0075E0D4
			protected virtual void MPAHBCPAHBG()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].IMCDMIHAAMK();
				}
			}

			// Token: 0x060108BC RID: 67772 RVA: 0x0075FF00 File Offset: 0x0075E100
			protected virtual float EELMKNILOOD()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1429f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 1816f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108BD RID: 67773 RVA: 0x0075FF88 File Offset: 0x0075E188
			protected virtual void CIKNNMLEKBC()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].MPAHBCPAHBG();
				}
			}

			// Token: 0x060108BE RID: 67774 RVA: 0x0075FFB4 File Offset: 0x0075E1B4
			protected virtual void GMBENOGFDAA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].EAHKLHPBEGN(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108BF RID: 67775 RVA: 0x0076004C File Offset: 0x0075E24C
			protected virtual float AIPBKIMPBEI()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 589f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 453f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108C0 RID: 67776 RVA: 0x007600D4 File Offset: 0x0075E2D4
			protected virtual void OJNNLAEFMDO()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].HFJGFPKKHHJ();
				}
			}

			// Token: 0x060108C1 RID: 67777 RVA: 0x00760100 File Offset: 0x0075E300
			protected virtual void BJPMJBLMJLF()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].LENAJCGIONE();
				}
			}

			// Token: 0x060108C2 RID: 67778 RVA: 0x0076012C File Offset: 0x0075E32C
			protected virtual void NLCLDGENCDE()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].ELPJBAHFKGF();
				}
			}

			// Token: 0x060108C3 RID: 67779 RVA: 0x00760158 File Offset: 0x0075E358
			protected virtual float EKDOAMBLBOK()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 1924f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 0].time : 590f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060108C4 RID: 67780 RVA: 0x007601E0 File Offset: 0x0075E3E0
			protected virtual void HIHPIBEFIGM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].MKNEBAOBLNI(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108C5 RID: 67781 RVA: 0x00760278 File Offset: 0x0075E478
			protected virtual void HLFNFAHELAB(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GDMKIGLFFDN(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108C6 RID: 67782 RVA: 0x00760310 File Offset: 0x0075E510
			protected virtual void NOJMIDNCBCC(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].EFODADOEBIH(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108C7 RID: 67783 RVA: 0x007603A8 File Offset: 0x0075E5A8
			protected virtual void GNLLJMHBEIF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].EAHKLHPBEGN(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x060108C8 RID: 67784 RVA: 0x00760440 File Offset: 0x0075E640
			protected virtual void LGBNKBFACHL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Vector3 a = NBAKCIDALOF.CCGINIJINOE().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].EAHKLHPBEGN(NBAKCIDALOF, vector, base.crossFader);
				}
			}

			// Token: 0x0400228B RID: 8843
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x0400228C RID: 8844
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x0400228D RID: 8845
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x020004BF RID: 1215
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x060108C9 RID: 67785 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void ENMDAKEGMLI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108CA RID: 67786 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void IMCDMIHAAMK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108CB RID: 67787 RVA: 0x007604E8 File Offset: 0x0075E6E8
				public void GPAMMKENIAH(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108CC RID: 67788 RVA: 0x00760538 File Offset: 0x0075E738
				public void ALJDBHIMDNE(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108CD RID: 67789 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void EFKKJAMKAAN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108CE RID: 67790 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void GMCFEJCJJEL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108CF RID: 67791 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void JNHFFOEMGHD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108D0 RID: 67792 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void BBNAMLHJMHG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108D1 RID: 67793 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void IKDOJHOPCBN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108D2 RID: 67794 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void LENAJCGIONE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108D3 RID: 67795 RVA: 0x00760588 File Offset: 0x0075E788
				public void GDMKIGLFFDN(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108D4 RID: 67796 RVA: 0x007605D8 File Offset: 0x0075E7D8
				public void FPAOGLEFNLI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108D5 RID: 67797 RVA: 0x00760628 File Offset: 0x0075E828
				public void CGCCHDHADNC(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108D6 RID: 67798 RVA: 0x00760678 File Offset: 0x0075E878
				public void ANJGBBJCBIJ(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108D7 RID: 67799 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void EGNGKDIJLAA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108D8 RID: 67800 RVA: 0x007606C8 File Offset: 0x0075E8C8
				public void OPOECNMLAJM(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108D9 RID: 67801 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void GFEOKEJJNKO()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108DA RID: 67802 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void PEHMMEFBHAK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108DB RID: 67803 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void MGDPPAIPAKE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108DC RID: 67804 RVA: 0x00760718 File Offset: 0x0075E918
				public void DDLKHEECNKP(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108DD RID: 67805 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void DDDPKEIKNFM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108DE RID: 67806 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void FMEHEOHELIC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108DF RID: 67807 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void MPAHBCPAHBG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E0 RID: 67808 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void HKEIEMLMLGG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E1 RID: 67809 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void ODDLNGDBDEG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E2 RID: 67810 RVA: 0x00760768 File Offset: 0x0075E968
				public void EAHKLHPBEGN(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108E3 RID: 67811 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void BGOKAIEIKGN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E4 RID: 67812 RVA: 0x007607B8 File Offset: 0x0075E9B8
				public void MFIAPGKJDJA(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108E5 RID: 67813 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void DNPEDHMFODL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E6 RID: 67814 RVA: 0x00760808 File Offset: 0x0075EA08
				public void OOCJDDBPLDJ(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108E7 RID: 67815 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void JGHKGFAFDBO()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E8 RID: 67816 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void CLBOMEJEDKA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108E9 RID: 67817 RVA: 0x00760858 File Offset: 0x0075EA58
				public void BAOCBKAFJAG(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108EA RID: 67818 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void NPAKADLEPJD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108EB RID: 67819 RVA: 0x007608A8 File Offset: 0x0075EAA8
				public void KAFKDMBHNFF(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108EC RID: 67820 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void DCLECCDKLPN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108ED RID: 67821 RVA: 0x007608F8 File Offset: 0x0075EAF8
				public void GBIPMHIAPOK(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108EE RID: 67822 RVA: 0x00760948 File Offset: 0x0075EB48
				public void DCLNJPIBFIA(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108EF RID: 67823 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void OMPGOLHBBHC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108F0 RID: 67824 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void EAONBEIDLHL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108F1 RID: 67825 RVA: 0x00760998 File Offset: 0x0075EB98
				public void DONBHEMMIDC(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F2 RID: 67826 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void KLMNOPGDBFH()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108F3 RID: 67827 RVA: 0x007609E8 File Offset: 0x0075EBE8
				public void CFNBOIAPBID(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F4 RID: 67828 RVA: 0x00760A38 File Offset: 0x0075EC38
				public void CLJPMKONBKL(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F5 RID: 67829 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void LLPHLJNABKJ()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108F6 RID: 67830 RVA: 0x00760A88 File Offset: 0x0075EC88
				public void AKCCCGDAJGI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F7 RID: 67831 RVA: 0x00760AD8 File Offset: 0x0075ECD8
				public void JAFAHHICOMM(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F8 RID: 67832 RVA: 0x00760B28 File Offset: 0x0075ED28
				public void BGFHABPGLFL(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108F9 RID: 67833 RVA: 0x00760B78 File Offset: 0x0075ED78
				public void PMKCLBCPIDA(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108FA RID: 67834 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void DNOIOLCPFLA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108FB RID: 67835 RVA: 0x00760BC8 File Offset: 0x0075EDC8
				public void JFHHLOIKFKK(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108FC RID: 67836 RVA: 0x00760C18 File Offset: 0x0075EE18
				public void DAIGOMFBNOD(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x060108FD RID: 67837 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void PLKAGPCAACD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108FE RID: 67838 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void PEEMKOGKMFI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060108FF RID: 67839 RVA: 0x00760C68 File Offset: 0x0075EE68
				public void MCLLJAHGJLP(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010900 RID: 67840 RVA: 0x00760CB8 File Offset: 0x0075EEB8
				public void IBIBHHPEFEJ(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010901 RID: 67841 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void NGPNJPFINMP()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010902 RID: 67842 RVA: 0x00760D08 File Offset: 0x0075EF08
				public void IKKFBNIKGFO(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010903 RID: 67843 RVA: 0x00760D58 File Offset: 0x0075EF58
				public void BDDGBCBODAI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010904 RID: 67844 RVA: 0x00760DA8 File Offset: 0x0075EFA8
				public void NCJDJBMJPDL(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010905 RID: 67845 RVA: 0x00760DF8 File Offset: 0x0075EFF8
				public void JBNOIPHEGDP(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010906 RID: 67846 RVA: 0x00760E48 File Offset: 0x0075F048
				public void GMNNHFOIBKI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010907 RID: 67847 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void POOJPPADAFF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010908 RID: 67848 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void OJNNLAEFMDO()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010909 RID: 67849 RVA: 0x00760E98 File Offset: 0x0075F098
				public void MADHHPOGJLP(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601090A RID: 67850 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void FKIIKDIODJC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601090B RID: 67851 RVA: 0x00760EE8 File Offset: 0x0075F0E8
				public void CAPLBHGKKHA(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601090C RID: 67852 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void GFIIHEDEGAL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601090D RID: 67853 RVA: 0x00760F38 File Offset: 0x0075F138
				public void LBCOFBOKHJP(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601090E RID: 67854 RVA: 0x00760F88 File Offset: 0x0075F188
				public void BLMNDKFDGNC(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601090F RID: 67855 RVA: 0x00760FD8 File Offset: 0x0075F1D8
				public void BKHIGJJNHAE(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.OEEPHOCHILL(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010910 RID: 67856 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void ALJOFCMCIGM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010911 RID: 67857 RVA: 0x00761028 File Offset: 0x0075F228
				public void INLILGJILKM(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010912 RID: 67858 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void NLOPANOPBFE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010913 RID: 67859 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void KEHBLHDGNAK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010914 RID: 67860 RVA: 0x00761078 File Offset: 0x0075F278
				public void MALHECMHHBB(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010915 RID: 67861 RVA: 0x007610C8 File Offset: 0x0075F2C8
				public void GICGCANLCEI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010916 RID: 67862 RVA: 0x00761118 File Offset: 0x0075F318
				public void OKCMHLJOFFC(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010917 RID: 67863 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void HFJGFPKKHHJ()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010918 RID: 67864 RVA: 0x00761168 File Offset: 0x0075F368
				public void CEDJFNODCHA(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601091A RID: 67866 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void EAKAONEEMGL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601091B RID: 67867 RVA: 0x007611B8 File Offset: 0x0075F3B8
				public void EFODADOEBIH(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.LOOAPOLICLC(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601091C RID: 67868 RVA: 0x00761208 File Offset: 0x0075F408
				public void OBDOALFIIFJ(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601091D RID: 67869 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void JGJOHHFNCCA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601091E RID: 67870 RVA: 0x00761258 File Offset: 0x0075F458
				public void OOGENBOIBGJ(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x0601091F RID: 67871 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void HBABKLBDAPM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010920 RID: 67872 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void OFJNLEEONPN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010921 RID: 67873 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void ELPJBAHFKGF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010922 RID: 67874 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void JKKIKEBFAAI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010923 RID: 67875 RVA: 0x007612A8 File Offset: 0x0075F4A8
				public void KOCIIEKMNAN(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.DAMGOIIBHCN(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010924 RID: 67876 RVA: 0x007612F8 File Offset: 0x0075F4F8
				public void MKNEBAOBLNI(IKSolverFullBodyBiped NBAKCIDALOF, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					NBAKCIDALOF.EEKAOKNJLKH(this.effector).positionOffset += this.current;
				}

				// Token: 0x06010925 RID: 67877 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void CKNJEBICICK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010926 RID: 67878 RVA: 0x007604D7 File Offset: 0x0075E6D7
				public void EDHKCAPAMLL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0400228E RID: 8846
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400228F RID: 8847
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x04002290 RID: 8848
				private Vector3 lastValue;

				// Token: 0x04002291 RID: 8849
				private Vector3 current;
			}
		}

		// Token: 0x020004C0 RID: 1216
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x06010927 RID: 67879 RVA: 0x00761348 File Offset: 0x0075F548
			protected virtual void ODDLNGDBDEG()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].MPAHBCPAHBG();
				}
			}

			// Token: 0x06010928 RID: 67880 RVA: 0x00761374 File Offset: 0x0075F574
			protected virtual void JIGDCBDJAHL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].BLMNDKFDGNC(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010929 RID: 67881 RVA: 0x00761410 File Offset: 0x0075F610
			protected virtual void IIBNDPPCCMH(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i++)
					{
						array[i].MCLLJAHGJLP(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601092A RID: 67882 RVA: 0x007614AC File Offset: 0x0075F6AC
			protected virtual void DBDKNPIAMDL()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].GMCFEJCJJEL();
				}
			}

			// Token: 0x0601092B RID: 67883 RVA: 0x007614D6 File Offset: 0x0075F6D6
			protected virtual float EKDOAMBLBOK()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 154f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 0].time;
			}

			// Token: 0x0601092D RID: 67885 RVA: 0x00761510 File Offset: 0x0075F710
			protected virtual void KPLPDCAHIAA()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].EGNGKDIJLAA();
				}
			}

			// Token: 0x0601092E RID: 67886 RVA: 0x0076153A File Offset: 0x0075F73A
			protected virtual float JDECOAHHOFM()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1363f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x0601092F RID: 67887 RVA: 0x00761574 File Offset: 0x0075F774
			protected virtual void OIFBIOCBDEM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].MFIAPGKJDJA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010930 RID: 67888 RVA: 0x00761610 File Offset: 0x0075F810
			protected virtual void NGPNJPFINMP()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].IMCDMIHAAMK();
				}
			}

			// Token: 0x06010931 RID: 67889 RVA: 0x0076163A File Offset: 0x0075F83A
			protected virtual float DDLMKLOLDEM()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1147f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 0].time;
			}

			// Token: 0x06010932 RID: 67890 RVA: 0x00761672 File Offset: 0x0075F872
			protected virtual float HLDECNHNHID()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1637f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x06010933 RID: 67891 RVA: 0x007616AC File Offset: 0x0075F8AC
			protected virtual void MGDPPAIPAKE()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].EAONBEIDLHL();
				}
			}

			// Token: 0x06010934 RID: 67892 RVA: 0x007616D8 File Offset: 0x0075F8D8
			protected virtual void GAGBFDEELNE(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].CAPLBHGKKHA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010935 RID: 67893 RVA: 0x00761774 File Offset: 0x0075F974
			protected virtual void GBACPMCDFDB()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].NPAKADLEPJD();
				}
			}

			// Token: 0x06010936 RID: 67894 RVA: 0x007617A0 File Offset: 0x0075F9A0
			protected virtual void PEHMMEFBHAK()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GNFPHFIFKJI();
				}
			}

			// Token: 0x06010937 RID: 67895 RVA: 0x007617CA File Offset: 0x0075F9CA
			protected virtual float PKLGFEDJPOC()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 321f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x06010938 RID: 67896 RVA: 0x00761804 File Offset: 0x0075FA04
			protected virtual void FMEHEOHELIC()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].BGOKAIEIKGN();
				}
			}

			// Token: 0x06010939 RID: 67897 RVA: 0x00761830 File Offset: 0x0075FA30
			protected virtual void MAOLNAGKMOF()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].IMCDMIHAAMK();
				}
			}

			// Token: 0x0601093A RID: 67898 RVA: 0x0076185A File Offset: 0x0075FA5A
			protected virtual float FPOPGNECHDF()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1048f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 0].time;
			}

			// Token: 0x0601093B RID: 67899 RVA: 0x00761892 File Offset: 0x0075FA92
			protected virtual float MCJAELJLJFC()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 843f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x0601093C RID: 67900 RVA: 0x007618CC File Offset: 0x0075FACC
			protected virtual void PDDIKPGGNFK()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].KBFPBCHHDDB();
				}
			}

			// Token: 0x0601093D RID: 67901 RVA: 0x007618F8 File Offset: 0x0075FAF8
			protected virtual void EJFFGEOPHNO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].GICGCANLCEI(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601093E RID: 67902 RVA: 0x00761994 File Offset: 0x0075FB94
			protected virtual void PODONPBKGJD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].AKCCCGDAJGI(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601093F RID: 67903 RVA: 0x00761A30 File Offset: 0x0075FC30
			protected virtual void KMDDJBKAFAF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].BKPANOKBAMC(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010940 RID: 67904 RVA: 0x00761ACC File Offset: 0x0075FCCC
			protected virtual void KBBIIAJFBPN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].GBNILLPMJAA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010941 RID: 67905 RVA: 0x00761B68 File Offset: 0x0075FD68
			protected virtual void LJPOKCLKNDM()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].LJPOKCLKNDM();
				}
			}

			// Token: 0x06010942 RID: 67906 RVA: 0x00761B94 File Offset: 0x0075FD94
			protected virtual void HIHPIBEFIGM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].FNPOICECOOI(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010943 RID: 67907 RVA: 0x00761C30 File Offset: 0x0075FE30
			protected virtual void JMCCNBAKAIM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].DDLKHEECNKP(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010944 RID: 67908 RVA: 0x00761CCB File Offset: 0x0075FECB
			protected override float BFNLJBGFDKI()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 0f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x06010945 RID: 67909 RVA: 0x00761D04 File Offset: 0x0075FF04
			protected virtual void NAGHOFHBOIL()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].NMAOLEIEFBO();
				}
			}

			// Token: 0x06010946 RID: 67910 RVA: 0x00761D30 File Offset: 0x0075FF30
			protected virtual void GKLGGACCHGM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].BKPANOKBAMC(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010947 RID: 67911 RVA: 0x00761DCC File Offset: 0x0075FFCC
			protected virtual void HOBOELHGDHN(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].GMNNHFOIBKI(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010948 RID: 67912 RVA: 0x00761E67 File Offset: 0x00760067
			protected virtual float JHDJMBICGEB()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 364f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 0].time;
			}

			// Token: 0x06010949 RID: 67913 RVA: 0x00761EA0 File Offset: 0x007600A0
			protected virtual void LGBNKBFACHL(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].BDDGBCBODAI(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601094A RID: 67914 RVA: 0x00761F3B File Offset: 0x0076013B
			protected virtual float LFHCLBGOMEE()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1833f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x0601094B RID: 67915 RVA: 0x00761F74 File Offset: 0x00760174
			protected override void IJBFHOEFACA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].DCLNJPIBFIA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601094C RID: 67916 RVA: 0x00762010 File Offset: 0x00760210
			protected virtual void NMMNGBBKKPM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].GBNILLPMJAA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601094D RID: 67917 RVA: 0x007620AB File Offset: 0x007602AB
			protected virtual float PDEGHEIJDCC()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 445f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x0601094E RID: 67918 RVA: 0x007620E4 File Offset: 0x007602E4
			protected virtual void KAHFBCBJBMF(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i++)
					{
						array[i].CLJPMKONBKL(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x0601094F RID: 67919 RVA: 0x00762180 File Offset: 0x00760380
			protected virtual void PKIIJBEKMJE()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].KPLPDCAHIAA();
				}
			}

			// Token: 0x06010950 RID: 67920 RVA: 0x007621AA File Offset: 0x007603AA
			protected virtual float LOEPJMCGCEK()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 1555f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 0].time;
			}

			// Token: 0x06010951 RID: 67921 RVA: 0x007621E4 File Offset: 0x007603E4
			protected override void NLOPANOPBFE()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].NLOPANOPBFE();
				}
			}

			// Token: 0x06010952 RID: 67922 RVA: 0x00762210 File Offset: 0x00760410
			protected virtual void JNHFFOEMGHD()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].IMCDMIHAAMK();
				}
			}

			// Token: 0x06010953 RID: 67923 RVA: 0x0076223C File Offset: 0x0076043C
			protected virtual void PDGMJFJONPA(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i++)
					{
						array[i].MADHHPOGJLP(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010954 RID: 67924 RVA: 0x007622D8 File Offset: 0x007604D8
			protected virtual void BNKJKABBMPO(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].ILKCCHANKFJ(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010955 RID: 67925 RVA: 0x00762374 File Offset: 0x00760574
			protected virtual void FKHDMPGMACM(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 1; i < array.Length; i++)
					{
						array[i].CEDJFNODCHA(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x06010956 RID: 67926 RVA: 0x00762410 File Offset: 0x00760610
			protected virtual void ONLNNJPIAMD(IKSolverFullBodyBiped NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].IBIBHHPEFEJ(NBAKCIDALOF, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x04002292 RID: 8850
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x04002293 RID: 8851
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x04002294 RID: 8852
			private Rigidbody rigidbody;

			// Token: 0x020004C1 RID: 1217
			[Serializable]
			public class BoneLink
			{
				// Token: 0x06010957 RID: 67927 RVA: 0x007624AC File Offset: 0x007606AC
				public void ILKCCHANKFJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010958 RID: 67928 RVA: 0x00762500 File Offset: 0x00760700
				public void DDNHHNABEGI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010959 RID: 67929 RVA: 0x00762551 File Offset: 0x00760751
				public void MELMEFFHCLA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601095A RID: 67930 RVA: 0x00762551 File Offset: 0x00760751
				public void AAFELPDDMHL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601095B RID: 67931 RVA: 0x00762551 File Offset: 0x00760751
				public void LJPOKCLKNDM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601095C RID: 67932 RVA: 0x00762560 File Offset: 0x00760760
				public void IBIBHHPEFEJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601095D RID: 67933 RVA: 0x00762551 File Offset: 0x00760751
				public void IIJJGAFABBM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601095E RID: 67934 RVA: 0x007625B4 File Offset: 0x007607B4
				public void DDLKHEECNKP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601095F RID: 67935 RVA: 0x00762608 File Offset: 0x00760808
				public void GBNILLPMJAA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010960 RID: 67936 RVA: 0x0076265C File Offset: 0x0076085C
				public void CAPLBHGKKHA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010961 RID: 67937 RVA: 0x00762551 File Offset: 0x00760751
				public void POOJPPADAFF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010962 RID: 67938 RVA: 0x00762551 File Offset: 0x00760751
				public void FKIIKDIODJC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010963 RID: 67939 RVA: 0x00762551 File Offset: 0x00760751
				public void KBFPBCHHDDB()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010964 RID: 67940 RVA: 0x00762551 File Offset: 0x00760751
				public void KLMNOPGDBFH()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010965 RID: 67941 RVA: 0x00762551 File Offset: 0x00760751
				public void HKEIEMLMLGG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010966 RID: 67942 RVA: 0x00762551 File Offset: 0x00760751
				public void NPAKADLEPJD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010967 RID: 67943 RVA: 0x007626B0 File Offset: 0x007608B0
				public void MFIAPGKJDJA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010968 RID: 67944 RVA: 0x00762551 File Offset: 0x00760751
				public void EDHKCAPAMLL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601096A RID: 67946 RVA: 0x00762720 File Offset: 0x00760920
				public void DCLNJPIBFIA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601096B RID: 67947 RVA: 0x00762551 File Offset: 0x00760751
				public void EAONBEIDLHL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601096C RID: 67948 RVA: 0x00762774 File Offset: 0x00760974
				public void MADHHPOGJLP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601096D RID: 67949 RVA: 0x00762551 File Offset: 0x00760751
				public void BGOKAIEIKGN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601096E RID: 67950 RVA: 0x007627C8 File Offset: 0x007609C8
				public void MCLLJAHGJLP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601096F RID: 67951 RVA: 0x00762551 File Offset: 0x00760751
				public void GNFPHFIFKJI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010970 RID: 67952 RVA: 0x00762551 File Offset: 0x00760751
				public void FMEHEOHELIC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010971 RID: 67953 RVA: 0x0076281C File Offset: 0x00760A1C
				public void KOFAHMHMOCG(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010972 RID: 67954 RVA: 0x00762870 File Offset: 0x00760A70
				public void CLJPMKONBKL(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010973 RID: 67955 RVA: 0x007628C4 File Offset: 0x00760AC4
				public void BJANDLJOHKI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010974 RID: 67956 RVA: 0x00762551 File Offset: 0x00760751
				public void GMCFEJCJJEL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010975 RID: 67957 RVA: 0x00762551 File Offset: 0x00760751
				public void ODDLNGDBDEG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010976 RID: 67958 RVA: 0x00762551 File Offset: 0x00760751
				public void JFMLCEIDMHJ()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010977 RID: 67959 RVA: 0x00762918 File Offset: 0x00760B18
				public void JHPPDFJHKDN(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010978 RID: 67960 RVA: 0x00762551 File Offset: 0x00760751
				public void NLOPANOPBFE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010979 RID: 67961 RVA: 0x0076296C File Offset: 0x00760B6C
				public void CEDJFNODCHA(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601097A RID: 67962 RVA: 0x00762551 File Offset: 0x00760751
				public void GFEOKEJJNKO()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601097B RID: 67963 RVA: 0x007629C0 File Offset: 0x00760BC0
				public void OOCJDDBPLDJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601097C RID: 67964 RVA: 0x00762A14 File Offset: 0x00760C14
				public void LBCOFBOKHJP(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601097D RID: 67965 RVA: 0x00762A68 File Offset: 0x00760C68
				public void BOIHIFCKEKB(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601097E RID: 67966 RVA: 0x00762ABC File Offset: 0x00760CBC
				public void OBDOALFIIFJ(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601097F RID: 67967 RVA: 0x00762551 File Offset: 0x00760751
				public void DNOIOLCPFLA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010980 RID: 67968 RVA: 0x00762B10 File Offset: 0x00760D10
				public void KAPBIGHEDPB(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010981 RID: 67969 RVA: 0x00762551 File Offset: 0x00760751
				public void NMAOLEIEFBO()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010982 RID: 67970 RVA: 0x00762551 File Offset: 0x00760751
				public void JNHFFOEMGHD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010983 RID: 67971 RVA: 0x00762B64 File Offset: 0x00760D64
				public void BDDGBCBODAI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010984 RID: 67972 RVA: 0x00762551 File Offset: 0x00760751
				public void IMCDMIHAAMK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010985 RID: 67973 RVA: 0x00762551 File Offset: 0x00760751
				public void PLKAGPCAACD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010986 RID: 67974 RVA: 0x00762BB8 File Offset: 0x00760DB8
				public void IKKFBNIKGFO(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010987 RID: 67975 RVA: 0x00762551 File Offset: 0x00760751
				public void MKPBINLAGJB()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010988 RID: 67976 RVA: 0x00762C0C File Offset: 0x00760E0C
				public void FNPOICECOOI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010989 RID: 67977 RVA: 0x00762C60 File Offset: 0x00760E60
				public void GICGCANLCEI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601098A RID: 67978 RVA: 0x00762551 File Offset: 0x00760751
				public void KPLPDCAHIAA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601098B RID: 67979 RVA: 0x00762CB4 File Offset: 0x00760EB4
				public void BKHIGJJNHAE(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601098C RID: 67980 RVA: 0x00762D08 File Offset: 0x00760F08
				public void BLMNDKFDGNC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601098D RID: 67981 RVA: 0x00762D5C File Offset: 0x00760F5C
				public void BKPANOKBAMC(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601098E RID: 67982 RVA: 0x00762551 File Offset: 0x00760751
				public void EGNGKDIJLAA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601098F RID: 67983 RVA: 0x00762551 File Offset: 0x00760751
				public void MGDPPAIPAKE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010990 RID: 67984 RVA: 0x00762DB0 File Offset: 0x00760FB0
				public void AKCCCGDAJGI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010991 RID: 67985 RVA: 0x00762551 File Offset: 0x00760751
				public void ALJOFCMCIGM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010992 RID: 67986 RVA: 0x00762E04 File Offset: 0x00761004
				public void KOCIIEKMNAN(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010993 RID: 67987 RVA: 0x00762551 File Offset: 0x00760751
				public void CLBOMEJEDKA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010994 RID: 67988 RVA: 0x00762551 File Offset: 0x00760751
				public void JAPBMLNKGIC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010995 RID: 67989 RVA: 0x00762551 File Offset: 0x00760751
				public void OJCNFAAKIPF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010996 RID: 67990 RVA: 0x00762551 File Offset: 0x00760751
				public void DCLECCDKLPN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010997 RID: 67991 RVA: 0x00762551 File Offset: 0x00760751
				public void JGJOHHFNCCA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010998 RID: 67992 RVA: 0x00762E58 File Offset: 0x00761058
				public void GMNNHFOIBKI(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x06010999 RID: 67993 RVA: 0x00762EAC File Offset: 0x007610AC
				public void DAIGOMFBNOD(IKSolverFullBodyBiped NBAKCIDALOF, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0601099A RID: 67994 RVA: 0x00762551 File Offset: 0x00760751
				public void MAOLNAGKMOF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601099B RID: 67995 RVA: 0x00762551 File Offset: 0x00760751
				public void MPAHBCPAHBG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x04002295 RID: 8853
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				// Token: 0x04002296 RID: 8854
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x04002297 RID: 8855
				private Quaternion lastValue = Quaternion.identity;

				// Token: 0x04002298 RID: 8856
				private Quaternion current = Quaternion.identity;
			}
		}
	}
}
