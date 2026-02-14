using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004AE RID: 1198
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		// Token: 0x06010625 RID: 67109 RVA: 0x00750774 File Offset: 0x0074E974
		protected virtual void NKGNFJLNOHD()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010626 RID: 67110 RVA: 0x007507E0 File Offset: 0x0074E9E0
		protected virtual void KGGMOGBDHDN()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010627 RID: 67111 RVA: 0x0075084C File Offset: 0x0074EA4C
		public void ODOLDLPDMAL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010628 RID: 67112 RVA: 0x007508E0 File Offset: 0x0074EAE0
		protected virtual void HHBDJBJEFCJ()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010629 RID: 67113 RVA: 0x0075094C File Offset: 0x0074EB4C
		protected virtual void KLLBLFKGMLD()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601062A RID: 67114 RVA: 0x007509B8 File Offset: 0x0074EBB8
		public void HNLOBCKJFDO(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("IdleEat");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601062B RID: 67115 RVA: 0x00750A4C File Offset: 0x0074EC4C
		protected virtual void LOJCEKNCAOD()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601062C RID: 67116 RVA: 0x00750AB8 File Offset: 0x0074ECB8
		public void DGJNEMKBHPN(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("RollerBladeGrindRoyale");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601062D RID: 67117 RVA: 0x00750B4C File Offset: 0x0074ED4C
		protected virtual void OJACOBAPJPK()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601062E RID: 67118 RVA: 0x00750BB8 File Offset: 0x0074EDB8
		protected virtual void HNKCDCDLNJE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601062F RID: 67119 RVA: 0x00750C24 File Offset: 0x0074EE24
		protected virtual void OMHLJBAKGLE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010630 RID: 67120 RVA: 0x00750C90 File Offset: 0x0074EE90
		protected virtual void HELKCEJMJCO()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010631 RID: 67121 RVA: 0x00750CFC File Offset: 0x0074EEFC
		public void LGGKMMLBICL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Elina");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010632 RID: 67122 RVA: 0x00750D90 File Offset: 0x0074EF90
		protected virtual void EJMFGGFABMH()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010633 RID: 67123 RVA: 0x00750DFC File Offset: 0x0074EFFC
		protected virtual void KGHNIEEAEHH()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010634 RID: 67124 RVA: 0x00750E68 File Offset: 0x0074F068
		public void ABMGFLLICFC(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Adjust");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010635 RID: 67125 RVA: 0x00750EFC File Offset: 0x0074F0FC
		public void KNCNAKDLFEH(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("[Y]");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010637 RID: 67127 RVA: 0x00750F98 File Offset: 0x0074F198
		protected virtual void FOKIBJAGEED()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010638 RID: 67128 RVA: 0x00751004 File Offset: 0x0074F204
		protected virtual void OBDLPFLICKB()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010639 RID: 67129 RVA: 0x00751070 File Offset: 0x0074F270
		public void CAPNCGOHHAC(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("_WrinkleNormalMap0");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601063A RID: 67130 RVA: 0x00751104 File Offset: 0x0074F304
		public void LEGLEIBHBJL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("allrec.ogg");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601063B RID: 67131 RVA: 0x00751198 File Offset: 0x0074F398
		public void PKIENGBIADB(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("startA");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601063C RID: 67132 RVA: 0x0075122C File Offset: 0x0074F42C
		public void GFDEEJGEINN(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Crouch180");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601063D RID: 67133 RVA: 0x007512C0 File Offset: 0x0074F4C0
		public void OAELKIJCDFF(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Idle Die");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601063E RID: 67134 RVA: 0x00751354 File Offset: 0x0074F554
		protected virtual void MBGJEAMMJJN()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601063F RID: 67135 RVA: 0x007513C0 File Offset: 0x0074F5C0
		protected virtual void JOKIOHMEIEN()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010640 RID: 67136 RVA: 0x0075142C File Offset: 0x0074F62C
		public void PJMKPLDFPEF(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("The 'font size' command requires a font size parameter.");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010641 RID: 67137 RVA: 0x007514C0 File Offset: 0x0074F6C0
		protected virtual void LONPIDHHHPA()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010642 RID: 67138 RVA: 0x0075152C File Offset: 0x0074F72C
		protected virtual void PKCAKBPNDGP()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010643 RID: 67139 RVA: 0x00751598 File Offset: 0x0074F798
		public void POPHKKJGILI(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError(" ");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010644 RID: 67140 RVA: 0x0075162C File Offset: 0x0074F82C
		protected virtual void HAMGMFMGPCI()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010645 RID: 67141 RVA: 0x00751698 File Offset: 0x0074F898
		protected virtual void PBFDEEDCFLE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010646 RID: 67142 RVA: 0x00751704 File Offset: 0x0074F904
		protected virtual void NPFOAOBGOEE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010647 RID: 67143 RVA: 0x00751770 File Offset: 0x0074F970
		protected virtual void EPKMABAIMFL()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010648 RID: 67144 RVA: 0x007517DC File Offset: 0x0074F9DC
		public void KOOKJLKHDPA(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("ShotgunReloadChamber");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010649 RID: 67145 RVA: 0x00751870 File Offset: 0x0074FA70
		protected virtual void MOEPIPIOMHL()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601064A RID: 67146 RVA: 0x007518DC File Offset: 0x0074FADC
		protected virtual void JIGFBMPOGPP()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601064B RID: 67147 RVA: 0x00751948 File Offset: 0x0074FB48
		protected virtual void GNADPAFAPKB()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601064C RID: 67148 RVA: 0x007519B4 File Offset: 0x0074FBB4
		protected virtual void MOBMBODBBPH()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601064D RID: 67149 RVA: 0x00751A20 File Offset: 0x0074FC20
		protected virtual void OONMKGBFLCF()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601064E RID: 67150 RVA: 0x00751A8C File Offset: 0x0074FC8C
		public void NJCGGNJNKCG(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Hand");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601064F RID: 67151 RVA: 0x00751B20 File Offset: 0x0074FD20
		public void DGPPILJGFMD(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("SneakBackward");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010650 RID: 67152 RVA: 0x00751BB4 File Offset: 0x0074FDB4
		public void IHMCLMNNDIC(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("RoundHouse");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010651 RID: 67153 RVA: 0x00751C48 File Offset: 0x0074FE48
		public void DGGGIHJGBLO(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("|");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010652 RID: 67154 RVA: 0x00751CDC File Offset: 0x0074FEDC
		protected virtual void OLCJGDIOBGO()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010653 RID: 67155 RVA: 0x00751D48 File Offset: 0x0074FF48
		public void OFEAHHBIGJO(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("LUX_GAMMA");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010654 RID: 67156 RVA: 0x00751DDC File Offset: 0x0074FFDC
		protected virtual void DIFPMHCBFNE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010655 RID: 67157 RVA: 0x00751E48 File Offset: 0x00750048
		public void OBCMLAIJDJO(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Vertical");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010656 RID: 67158 RVA: 0x00751EDC File Offset: 0x007500DC
		public void BIOAEAFMCKA(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("WizardOverhead");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010657 RID: 67159 RVA: 0x00751F70 File Offset: 0x00750170
		protected virtual void ODCJJGJJMFI()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010658 RID: 67160 RVA: 0x00751FDC File Offset: 0x007501DC
		protected virtual void LHDCDIOEODG()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010659 RID: 67161 RVA: 0x00752048 File Offset: 0x00750248
		protected virtual void BGFNOICCAGO()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601065A RID: 67162 RVA: 0x007520B4 File Offset: 0x007502B4
		protected virtual void MEPOMFMNCDE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601065B RID: 67163 RVA: 0x00752120 File Offset: 0x00750320
		protected virtual void DKHACOFGDLP()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601065C RID: 67164 RVA: 0x0075218C File Offset: 0x0075038C
		protected virtual void HIEGNJHEOFA()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601065D RID: 67165 RVA: 0x007521F8 File Offset: 0x007503F8
		public void EEEAAHGKNLJ(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("sunshine_OvercastCoord");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601065E RID: 67166 RVA: 0x0075228C File Offset: 0x0075048C
		protected virtual void MHKIHJKOJCE()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601065F RID: 67167 RVA: 0x007522F8 File Offset: 0x007504F8
		protected virtual void MNOEEHPMJMA()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010660 RID: 67168 RVA: 0x00752364 File Offset: 0x00750564
		public void BEBDCOIJHKH(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("ShotgunReloadChamber");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010661 RID: 67169 RVA: 0x007523F8 File Offset: 0x007505F8
		public void CHPPKFCCPFJ(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010662 RID: 67170 RVA: 0x0075248C File Offset: 0x0075068C
		protected virtual void EBFEGNHDGIN()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010663 RID: 67171 RVA: 0x007524F8 File Offset: 0x007506F8
		public void GOONLOJLIPP(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("wpn_add/base");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010664 RID: 67172 RVA: 0x0075258C File Offset: 0x0075078C
		protected override void HEHOBGDMLOK()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010665 RID: 67173 RVA: 0x007525F8 File Offset: 0x007507F8
		protected virtual void EFMJHLFNCJK()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x06010666 RID: 67174 RVA: 0x00752664 File Offset: 0x00750864
		public void AMEJMIODHNP(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i++)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010667 RID: 67175 RVA: 0x007526F8 File Offset: 0x007508F8
		public void Hit(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010668 RID: 67176 RVA: 0x0075278C File Offset: 0x0075098C
		public void LDIBAJABPGM(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Mouse X");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010669 RID: 67177 RVA: 0x00752820 File Offset: 0x00750A20
		protected virtual void BGEEPBOFMKG()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601066A RID: 67178 RVA: 0x0075288C File Offset: 0x00750A8C
		public void ECNOHJOGAIP(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Original health bar: ");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601066B RID: 67179 RVA: 0x00752920 File Offset: 0x00750B20
		public void OAENJCFMFAM(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("*** get repa id=");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601066C RID: 67180 RVA: 0x007529B4 File Offset: 0x00750BB4
		protected virtual void HHCGGNBDPMG()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601066D RID: 67181 RVA: 0x00752A20 File Offset: 0x00750C20
		public void HCJLAMPLALD(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("_RgbTex");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i += 0)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x0601066E RID: 67182 RVA: 0x00752AB4 File Offset: 0x00750CB4
		protected virtual void GFGEFHBDIJO()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i += 0)
			{
				array2[i].DCLNJPIBFIA(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x0601066F RID: 67183 RVA: 0x00752B20 File Offset: 0x00750D20
		public void AFACAEKCMLK(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("Interpolator has no target!");
				return;
			}
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 1; i < array.Length; i++)
			{
				HitReactionVRIK.PositionOffset positionOffset = array[i];
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x06010670 RID: 67184 RVA: 0x00752BB4 File Offset: 0x00750DB4
		public void LGHMMGDAEKL(Collider JNBDKOKIPEC, Vector3 PGEDLDMLBBE, Vector3 JJNHJKFMFLJ)
		{
			if (this.ik == null)
			{
				Debug.LogError("OfficeSittingReadingCoffeeSip");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == JNBDKOKIPEC)
				{
					positionOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 1; i < array2.Length; i += 0)
			{
				HitReactionVRIK.RotationOffset rotationOffset = array2[i];
				if (rotationOffset.collider == JNBDKOKIPEC)
				{
					rotationOffset.NDLBPPIDCKG(PGEDLDMLBBE, this.offsetCurves, JJNHJKFMFLJ);
				}
			}
		}

		// Token: 0x04002244 RID: 8772
		public AnimationCurve[] offsetCurves;

		// Token: 0x04002245 RID: 8773
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReactionVRIK.PositionOffset[] positionOffsets;

		// Token: 0x04002246 RID: 8774
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReactionVRIK.RotationOffset[] rotationOffsets;

		// Token: 0x020004AF RID: 1199
		[Serializable]
		public abstract class Offset
		{
			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06010671 RID: 67185 RVA: 0x00752C47 File Offset: 0x00750E47
			// (set) Token: 0x06010672 RID: 67186 RVA: 0x00752C4F File Offset: 0x00750E4F
			private protected float crossFader { protected get; private set; }

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06010673 RID: 67187 RVA: 0x00752C58 File Offset: 0x00750E58
			// (set) Token: 0x06010674 RID: 67188 RVA: 0x00752C60 File Offset: 0x00750E60
			private protected float timer { protected get; private set; }

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06010675 RID: 67189 RVA: 0x00752C69 File Offset: 0x00750E69
			// (set) Token: 0x06010676 RID: 67190 RVA: 0x00752C71 File Offset: 0x00750E71
			private protected Vector3 force { protected get; private set; }

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06010677 RID: 67191 RVA: 0x00752C7A File Offset: 0x00750E7A
			// (set) Token: 0x06010678 RID: 67192 RVA: 0x00752C82 File Offset: 0x00750E82
			private protected Vector3 point { protected get; private set; }

			// Token: 0x06010679 RID: 67193 RVA: 0x00752C8C File Offset: 0x00750E8C
			public void NDLBPPIDCKG(Vector3 PGEDLDMLBBE, AnimationCurve[] BPLALOLNDII, Vector3 JJNHJKFMFLJ)
			{
				if (this.length == 0f)
				{
					this.length = this.BFNLJBGFDKI(BPLALOLNDII);
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

			// Token: 0x0601067A RID: 67194 RVA: 0x00752D28 File Offset: 0x00750F28
			public void DCLNJPIBFIA(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
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
				this.IJBFHOEFACA(OJMBOCNNLMI, BPLALOLNDII, NKHBAJKMAGD);
			}

			// Token: 0x0601067B RID: 67195
			protected abstract float BFNLJBGFDKI(AnimationCurve[] BPLALOLNDII);

			// Token: 0x0601067C RID: 67196
			protected abstract void NLOPANOPBFE();

			// Token: 0x0601067D RID: 67197
			protected abstract void IJBFHOEFACA(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD);

			// Token: 0x04002247 RID: 8775
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x04002248 RID: 8776
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x04002249 RID: 8777
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			// Token: 0x0400224E RID: 8782
			private float length;

			// Token: 0x0400224F RID: 8783
			private float crossFadeSpeed;

			// Token: 0x04002250 RID: 8784
			private float lastTime;
		}

		// Token: 0x020004B0 RID: 1200
		[Serializable]
		public class PositionOffset : HitReactionVRIK.Offset
		{
			// Token: 0x0601067F RID: 67199 RVA: 0x00752DD4 File Offset: 0x00750FD4
			protected virtual void BEJBACCJJKJ(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				Vector3 a = OJMBOCNNLMI.transform.up * base.force.magnitude;
				Vector3 vector = BPLALOLNDII[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + BPLALOLNDII[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].GPAMMKENIAH(OJMBOCNNLMI, vector, base.crossFader);
				}
			}

			// Token: 0x06010680 RID: 67200 RVA: 0x00752E70 File Offset: 0x00751070
			protected override void NLOPANOPBFE()
			{
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].NLOPANOPBFE();
				}
			}

			// Token: 0x06010681 RID: 67201 RVA: 0x00752E9C File Offset: 0x0075109C
			protected virtual float LOEPJMCGCEK(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 0].time : 1492f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 1].time : 1701f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010683 RID: 67203 RVA: 0x00752F3C File Offset: 0x0075113C
			protected virtual void GKLGGACCHGM(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				Vector3 a = OJMBOCNNLMI.transform.up * base.force.magnitude;
				Vector3 vector = BPLALOLNDII[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + BPLALOLNDII[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ODLPIDHFPEO(OJMBOCNNLMI, vector, base.crossFader);
				}
			}

			// Token: 0x06010684 RID: 67204 RVA: 0x00752FD8 File Offset: 0x007511D8
			protected override void IJBFHOEFACA(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				Vector3 a = OJMBOCNNLMI.transform.up * base.force.magnitude;
				Vector3 vector = BPLALOLNDII[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + BPLALOLNDII[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DCLNJPIBFIA(OJMBOCNNLMI, vector, base.crossFader);
				}
			}

			// Token: 0x06010685 RID: 67205 RVA: 0x00753074 File Offset: 0x00751274
			protected virtual float NJJGMIGLLKD(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 1].time : 1476f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 0].time : 605f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010686 RID: 67206 RVA: 0x00753108 File Offset: 0x00751308
			protected virtual float JBNKJJPEHJJ(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 1].time : 348f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 0].time : 120f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010687 RID: 67207 RVA: 0x0075319C File Offset: 0x0075139C
			protected override float BFNLJBGFDKI(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 1].time : 0f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 1].time : 0f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x06010688 RID: 67208 RVA: 0x00753230 File Offset: 0x00751430
			protected virtual void NFNAJFJNAEO(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				Vector3 a = OJMBOCNNLMI.transform.up * base.force.magnitude;
				Vector3 vector = BPLALOLNDII[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + BPLALOLNDII[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].ODLPIDHFPEO(OJMBOCNNLMI, vector, base.crossFader);
				}
			}

			// Token: 0x06010689 RID: 67209 RVA: 0x007532CC File Offset: 0x007514CC
			protected virtual void EOCMEKBPOKE(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				Vector3 a = OJMBOCNNLMI.transform.up * base.force.magnitude;
				Vector3 vector = BPLALOLNDII[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + BPLALOLNDII[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= NKHBAJKMAGD;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].LDKOGEDIEEA(OJMBOCNNLMI, vector, base.crossFader);
				}
			}

			// Token: 0x0601068A RID: 67210 RVA: 0x00753368 File Offset: 0x00751568
			protected virtual float JDECOAHHOFM(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 1].time : 712f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 1].time : 1233f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601068B RID: 67211 RVA: 0x007533FC File Offset: 0x007515FC
			protected virtual void EGNGKDIJLAA()
			{
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].BGOKAIEIKGN();
				}
			}

			// Token: 0x0601068C RID: 67212 RVA: 0x00753428 File Offset: 0x00751628
			protected virtual float BOCBKDEBIEB(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 0].time : 1245f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 1].time : 829f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x0601068D RID: 67213 RVA: 0x007534BC File Offset: 0x007516BC
			protected virtual void BGOKAIEIKGN()
			{
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x0601068E RID: 67214 RVA: 0x007534E8 File Offset: 0x007516E8
			protected virtual float EELMKNILOOD(AnimationCurve[] BPLALOLNDII)
			{
				float num = (BPLALOLNDII[this.forceDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.forceDirCurveIndex].keys[BPLALOLNDII[this.forceDirCurveIndex].length - 1].time : 1249f;
				float min = (BPLALOLNDII[this.upDirCurveIndex].keys.Length != 0) ? BPLALOLNDII[this.upDirCurveIndex].keys[BPLALOLNDII[this.upDirCurveIndex].length - 0].time : 1979f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x04002251 RID: 8785
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			// Token: 0x04002252 RID: 8786
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex = 1;

			// Token: 0x04002253 RID: 8787
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;

			// Token: 0x020004B1 RID: 1201
			[Serializable]
			public class PositionOffsetLink
			{
				// Token: 0x0601068F RID: 67215 RVA: 0x00753579 File Offset: 0x00751779
				public void BJANDLJOHKI(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.BGKGCPMAPCL(this.positionOffset, this.current);
				}

				// Token: 0x06010690 RID: 67216 RVA: 0x007535B0 File Offset: 0x007517B0
				public void JAKKDJFKMDO(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x06010691 RID: 67217 RVA: 0x007535E7 File Offset: 0x007517E7
				public void NFEKPOPPICL(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IOICDPHLABA(this.positionOffset, this.current);
				}

				// Token: 0x06010692 RID: 67218 RVA: 0x0075361E File Offset: 0x0075181E
				public void PDDIKPGGNFK()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010693 RID: 67219 RVA: 0x0075362C File Offset: 0x0075182C
				public void LDKOGEDIEEA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JAFHPKNBOFF(this.positionOffset, this.current);
				}

				// Token: 0x06010694 RID: 67220 RVA: 0x007535B0 File Offset: 0x007517B0
				public void BDDGBCBODAI(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x06010695 RID: 67221 RVA: 0x0075361E File Offset: 0x0075181E
				public void NLOPANOPBFE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010696 RID: 67222 RVA: 0x0075361E File Offset: 0x0075181E
				public void MKPBINLAGJB()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010697 RID: 67223 RVA: 0x007535B0 File Offset: 0x007517B0
				public void ODLPIDHFPEO(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x06010698 RID: 67224 RVA: 0x0075361E File Offset: 0x0075181E
				public void GFIIHEDEGAL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x06010699 RID: 67225 RVA: 0x0075361E File Offset: 0x0075181E
				public void OJCNFAAKIPF()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601069A RID: 67226 RVA: 0x0075361E File Offset: 0x0075181E
				public void NNMLHLCOOJB()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601069B RID: 67227 RVA: 0x007535B0 File Offset: 0x007517B0
				public void OKCMHLJOFFC(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x0601069C RID: 67228 RVA: 0x00753579 File Offset: 0x00751779
				public void DDLKHEECNKP(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.BGKGCPMAPCL(this.positionOffset, this.current);
				}

				// Token: 0x0601069D RID: 67229 RVA: 0x0075361E File Offset: 0x0075181E
				public void LENAJCGIONE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601069E RID: 67230 RVA: 0x0075361E File Offset: 0x0075181E
				public void EGNGKDIJLAA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x0601069F RID: 67231 RVA: 0x007535E7 File Offset: 0x007517E7
				public void MFIAPGKJDJA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IOICDPHLABA(this.positionOffset, this.current);
				}

				// Token: 0x060106A0 RID: 67232 RVA: 0x0075361E File Offset: 0x0075181E
				public void NPAKADLEPJD()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A1 RID: 67233 RVA: 0x0075361E File Offset: 0x0075181E
				public void GMCFEJCJJEL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A2 RID: 67234 RVA: 0x0075361E File Offset: 0x0075181E
				public void LIGHIHCHCPA()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A3 RID: 67235 RVA: 0x007535B0 File Offset: 0x007517B0
				public void GPAMMKENIAH(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x060106A4 RID: 67236 RVA: 0x0075361E File Offset: 0x0075181E
				public void LLPHLJNABKJ()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A5 RID: 67237 RVA: 0x0075361E File Offset: 0x0075181E
				public void BGOKAIEIKGN()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A6 RID: 67238 RVA: 0x0075361E File Offset: 0x0075181E
				public void KLMNOPGDBFH()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106A7 RID: 67239 RVA: 0x007535E7 File Offset: 0x007517E7
				public void DCLNJPIBFIA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IOICDPHLABA(this.positionOffset, this.current);
				}

				// Token: 0x060106A9 RID: 67241 RVA: 0x00753579 File Offset: 0x00751779
				public void PMKCLBCPIDA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.BGKGCPMAPCL(this.positionOffset, this.current);
				}

				// Token: 0x060106AA RID: 67242 RVA: 0x0075361E File Offset: 0x0075181E
				public void FMEHEOHELIC()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106AB RID: 67243 RVA: 0x007535B0 File Offset: 0x007517B0
				public void GBNILLPMJAA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x060106AC RID: 67244 RVA: 0x0075362C File Offset: 0x0075182C
				public void AKCCCGDAJGI(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JAFHPKNBOFF(this.positionOffset, this.current);
				}

				// Token: 0x060106AD RID: 67245 RVA: 0x0075361E File Offset: 0x0075181E
				public void DOJKBHKDPBI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106AE RID: 67246 RVA: 0x0075362C File Offset: 0x0075182C
				public void EFODADOEBIH(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JAFHPKNBOFF(this.positionOffset, this.current);
				}

				// Token: 0x060106AF RID: 67247 RVA: 0x0075361E File Offset: 0x0075181E
				public void KBFPBCHHDDB()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106B0 RID: 67248 RVA: 0x0075362C File Offset: 0x0075182C
				public void CAPLBHGKKHA(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JAFHPKNBOFF(this.positionOffset, this.current);
				}

				// Token: 0x060106B1 RID: 67249 RVA: 0x007535B0 File Offset: 0x007517B0
				public void BFDBMDPBJML(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IFPCMKGBDKG(this.positionOffset, this.current);
				}

				// Token: 0x060106B2 RID: 67250 RVA: 0x007535E7 File Offset: 0x007517E7
				public void KAPBIGHEDPB(VRIK OJMBOCNNLMI, Vector3 IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Vector3.Lerp(this.lastValue, IGFJOGKFADM * this.weight, LEIHKDFGEEK);
					OJMBOCNNLMI.solver.IOICDPHLABA(this.positionOffset, this.current);
				}

				// Token: 0x060106B3 RID: 67251 RVA: 0x0075361E File Offset: 0x0075181E
				public void AAFELPDDMHL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x04002254 RID: 8788
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				// Token: 0x04002255 RID: 8789
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x04002256 RID: 8790
				private Vector3 lastValue;

				// Token: 0x04002257 RID: 8791
				private Vector3 current;
			}
		}

		// Token: 0x020004B2 RID: 1202
		[Serializable]
		public class RotationOffset : HitReactionVRIK.Offset
		{
			// Token: 0x060106B4 RID: 67252 RVA: 0x00753664 File Offset: 0x00751864
			protected virtual void BGOKAIEIKGN()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].CILNFFHJCAM();
				}
			}

			// Token: 0x060106B5 RID: 67253 RVA: 0x00753690 File Offset: 0x00751890
			protected virtual void JNHFFOEMGHD()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ODDLNGDBDEG();
				}
			}

			// Token: 0x060106B6 RID: 67254 RVA: 0x007536BC File Offset: 0x007518BC
			protected virtual void ODDLNGDBDEG()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].LLPHLJNABKJ();
				}
			}

			// Token: 0x060106B7 RID: 67255 RVA: 0x007536E6 File Offset: 0x007518E6
			protected virtual float MAHDPJCACHB(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1320f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106B8 RID: 67256 RVA: 0x00753724 File Offset: 0x00751924
			protected virtual float PDEGHEIJDCC(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1298f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106B9 RID: 67257 RVA: 0x00753764 File Offset: 0x00751964
			protected virtual void CEKCBPAAKCB()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ODDLNGDBDEG();
				}
			}

			// Token: 0x060106BA RID: 67258 RVA: 0x00753790 File Offset: 0x00751990
			protected override void NLOPANOPBFE()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].NLOPANOPBFE();
				}
			}

			// Token: 0x060106BB RID: 67259 RVA: 0x007537BA File Offset: 0x007519BA
			protected virtual float EELMKNILOOD(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1172f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106BC RID: 67260 RVA: 0x007537F8 File Offset: 0x007519F8
			protected virtual float MJOPICENHHL(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1063f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106BD RID: 67261 RVA: 0x00753838 File Offset: 0x00751A38
			protected virtual void NPAKADLEPJD()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x060106BE RID: 67262 RVA: 0x00753862 File Offset: 0x00751A62
			protected virtual float DCEDLJKDOCP(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1014f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 0].time;
			}

			// Token: 0x060106BF RID: 67263 RVA: 0x007538A0 File Offset: 0x00751AA0
			protected virtual float HKNPJOJHFDL(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1587f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106C0 RID: 67264 RVA: 0x007538E0 File Offset: 0x00751AE0
			protected virtual void FMEHEOHELIC()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x060106C1 RID: 67265 RVA: 0x0075390C File Offset: 0x00751B0C
			protected virtual void JFMLCEIDMHJ()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].LLPHLJNABKJ();
				}
			}

			// Token: 0x060106C2 RID: 67266 RVA: 0x00753936 File Offset: 0x00751B36
			protected virtual float GHEJNKPHFPE(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 325f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 0].time;
			}

			// Token: 0x060106C3 RID: 67267 RVA: 0x00753974 File Offset: 0x00751B74
			protected override float BFNLJBGFDKI(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 0f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106C4 RID: 67268 RVA: 0x007539B4 File Offset: 0x00751BB4
			protected virtual void KAHFBCBJBMF(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("wpnlang/weapons/weapon");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].CEDJFNODCHA(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106C5 RID: 67269 RVA: 0x00753A6A File Offset: 0x00751C6A
			protected virtual float MCMMGKAMJMB(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 345f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106C6 RID: 67270 RVA: 0x00753AA8 File Offset: 0x00751CA8
			protected virtual void DLKFBAIDPJF(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("auk_pstavka");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].AOKIOMBDNMP(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106C7 RID: 67271 RVA: 0x00753B60 File Offset: 0x00751D60
			protected virtual void JPFPPKDLGHG(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("</color>");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].AOKIOMBDNMP(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106C8 RID: 67272 RVA: 0x00753C18 File Offset: 0x00751E18
			protected virtual void PODONPBKGJD(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("isRodOpen");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].NHLICKJMGAA(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106C9 RID: 67273 RVA: 0x00753CCE File Offset: 0x00751ECE
			protected virtual float AMJOBKICLFH(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1826f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106CA RID: 67274 RVA: 0x00753D0C File Offset: 0x00751F0C
			protected virtual float NJJGMIGLLKD(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1604f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 0].time;
			}

			// Token: 0x060106CB RID: 67275 RVA: 0x00753D4C File Offset: 0x00751F4C
			protected virtual void GNFPHFIFKJI()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].ODDLNGDBDEG();
				}
			}

			// Token: 0x060106CC RID: 67276 RVA: 0x00753D78 File Offset: 0x00751F78
			protected virtual void FKIIKDIODJC()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DOJKBHKDPBI();
				}
			}

			// Token: 0x060106CD RID: 67277 RVA: 0x00753DA2 File Offset: 0x00751FA2
			protected virtual float BOCBKDEBIEB(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1930f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106CE RID: 67278 RVA: 0x00753DE0 File Offset: 0x00751FE0
			protected virtual void HIHPIBEFIGM(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("Yawn");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].OPOECNMLAJM(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106CF RID: 67279 RVA: 0x00753E98 File Offset: 0x00752098
			protected virtual void CIKNNMLEKBC()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].DOJKBHKDPBI();
				}
			}

			// Token: 0x060106D0 RID: 67280 RVA: 0x00753EC4 File Offset: 0x007520C4
			protected virtual void CCMJKONGAGN(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("\n");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].OPOECNMLAJM(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106D1 RID: 67281 RVA: 0x00753F7C File Offset: 0x0075217C
			protected virtual void MALKIACIJPE(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("OnTriggerEnter");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i++)
					{
						array[i].OPOECNMLAJM(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106D2 RID: 67282 RVA: 0x00754034 File Offset: 0x00752234
			protected virtual void DFBGCFDHLKN(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].BJANDLJOHKI(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106D3 RID: 67283 RVA: 0x007540EC File Offset: 0x007522EC
			protected virtual void MGDPPAIPAKE()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x060106D4 RID: 67284 RVA: 0x00754116 File Offset: 0x00752316
			protected virtual float PFEFBCKIAJA(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1011f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106D5 RID: 67285 RVA: 0x00754154 File Offset: 0x00752354
			protected override void IJBFHOEFACA(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("No collider assigned for a HitPointBone in the HitReaction component.");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].DCLNJPIBFIA(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106D6 RID: 67286 RVA: 0x0075420C File Offset: 0x0075240C
			protected virtual void EAONBEIDLHL()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].DOJKBHKDPBI();
				}
			}

			// Token: 0x060106D7 RID: 67287 RVA: 0x00754238 File Offset: 0x00752438
			protected virtual void JIGDCBDJAHL(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("Apply 3");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].AOKIOMBDNMP(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106D9 RID: 67289 RVA: 0x007542F6 File Offset: 0x007524F6
			protected virtual float AEPBCAIIBIK(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 965f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 0].time;
			}

			// Token: 0x060106DA RID: 67290 RVA: 0x00754334 File Offset: 0x00752534
			protected virtual float ODDIHOGIPID(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1746f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 1].time;
			}

			// Token: 0x060106DB RID: 67291 RVA: 0x00754374 File Offset: 0x00752574
			protected virtual void MKPBINLAGJB()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].LLPHLJNABKJ();
				}
			}

			// Token: 0x060106DC RID: 67292 RVA: 0x0075439E File Offset: 0x0075259E
			protected virtual float EKDOAMBLBOK(AnimationCurve[] BPLALOLNDII)
			{
				if (BPLALOLNDII[this.curveIndex].keys.Length == 0)
				{
					return 1865f;
				}
				return BPLALOLNDII[this.curveIndex].keys[BPLALOLNDII[this.curveIndex].length - 0].time;
			}

			// Token: 0x060106DD RID: 67293 RVA: 0x007543DC File Offset: 0x007525DC
			protected virtual void BEJBACCJJKJ(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("1 Hand Sword Shield Bash");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].DCLNJPIBFIA(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106DE RID: 67294 RVA: 0x00754494 File Offset: 0x00752694
			protected virtual void NNMLHLCOOJB()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].LLPHLJNABKJ();
				}
			}

			// Token: 0x060106DF RID: 67295 RVA: 0x007544C0 File Offset: 0x007526C0
			protected virtual void EJFFGEOPHNO(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("_Saturation");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].BJANDLJOHKI(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106E0 RID: 67296 RVA: 0x00754578 File Offset: 0x00752778
			protected virtual void MAOLNAGKMOF()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x060106E1 RID: 67297 RVA: 0x007545A4 File Offset: 0x007527A4
			protected virtual void GBACPMCDFDB()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AAFELPDDMHL();
				}
			}

			// Token: 0x060106E2 RID: 67298 RVA: 0x007545D0 File Offset: 0x007527D0
			protected virtual void MBAHGGMFBAA(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError(" load woman version");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 1; i < array.Length; i += 0)
					{
						array[i].AOKIOMBDNMP(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106E3 RID: 67299 RVA: 0x00754688 File Offset: 0x00752888
			protected virtual void HMNKDPCOEPK(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("GiantGrabIdle");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i += 0)
					{
						array[i].BJANDLJOHKI(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106E4 RID: 67300 RVA: 0x00754740 File Offset: 0x00752940
			protected virtual void NBBLEKMNKCD(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("Eat");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].CEDJFNODCHA(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x060106E5 RID: 67301 RVA: 0x007547F8 File Offset: 0x007529F8
			protected virtual void MNNPMABJPOF(VRIK OJMBOCNNLMI, AnimationCurve[] BPLALOLNDII, float NKHBAJKMAGD)
			{
				if (this.collider == null)
				{
					Debug.LogError("ExposureIBL");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Vector3 axis = Vector3.Cross(base.force, base.point - this.rigidbody.worldCenterOfMass);
					Quaternion igfjogkfadm = Quaternion.AngleAxis(BPLALOLNDII[this.curveIndex].Evaluate(base.timer) * NKHBAJKMAGD, axis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].AOKIOMBDNMP(OJMBOCNNLMI, igfjogkfadm, base.crossFader);
					}
				}
			}

			// Token: 0x04002258 RID: 8792
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			// Token: 0x04002259 RID: 8793
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;

			// Token: 0x0400225A RID: 8794
			private Rigidbody rigidbody;

			// Token: 0x020004B3 RID: 1203
			[Serializable]
			public class RotationOffsetLink
			{
				// Token: 0x060106E6 RID: 67302 RVA: 0x007548AE File Offset: 0x00752AAE
				public void FGHFOIDAACI(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JJKMEFBJBMJ(this.rotationOffset, this.current);
				}

				// Token: 0x060106E7 RID: 67303 RVA: 0x007548EA File Offset: 0x00752AEA
				public void DOJKBHKDPBI()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106E8 RID: 67304 RVA: 0x007548EA File Offset: 0x00752AEA
				public void NLOPANOPBFE()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106E9 RID: 67305 RVA: 0x007548AE File Offset: 0x00752AAE
				public void AOKIOMBDNMP(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JJKMEFBJBMJ(this.rotationOffset, this.current);
				}

				// Token: 0x060106EA RID: 67306 RVA: 0x007548F8 File Offset: 0x00752AF8
				public void OPOECNMLAJM(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.BBPBKDNGAKN(this.rotationOffset, this.current);
				}

				// Token: 0x060106EB RID: 67307 RVA: 0x007548EA File Offset: 0x00752AEA
				public void CILNFFHJCAM()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106EC RID: 67308 RVA: 0x007548EA File Offset: 0x00752AEA
				public void AAFELPDDMHL()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106ED RID: 67309 RVA: 0x00754934 File Offset: 0x00752B34
				public void CAPLBHGKKHA(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.FFFBAMDDDJD(this.rotationOffset, this.current);
				}

				// Token: 0x060106EE RID: 67310 RVA: 0x007548EA File Offset: 0x00752AEA
				public void LLPHLJNABKJ()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106EF RID: 67311 RVA: 0x007548AE File Offset: 0x00752AAE
				public void BJANDLJOHKI(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.JJKMEFBJBMJ(this.rotationOffset, this.current);
				}

				// Token: 0x060106F0 RID: 67312 RVA: 0x00754970 File Offset: 0x00752B70
				public void CEDJFNODCHA(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.ONELMMCKEBK(this.rotationOffset, this.current);
				}

				// Token: 0x060106F1 RID: 67313 RVA: 0x00754970 File Offset: 0x00752B70
				public void DCLNJPIBFIA(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.ONELMMCKEBK(this.rotationOffset, this.current);
				}

				// Token: 0x060106F2 RID: 67314 RVA: 0x007548EA File Offset: 0x00752AEA
				public void ODDLNGDBDEG()
				{
					this.lastValue = this.current;
				}

				// Token: 0x060106F4 RID: 67316 RVA: 0x007548F8 File Offset: 0x00752AF8
				public void NHLICKJMGAA(VRIK OJMBOCNNLMI, Quaternion IGFJOGKFADM, float LEIHKDFGEEK)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, IGFJOGKFADM, this.weight), LEIHKDFGEEK);
					OJMBOCNNLMI.solver.BBPBKDNGAKN(this.rotationOffset, this.current);
				}

				// Token: 0x0400225B RID: 8795
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				// Token: 0x0400225C RID: 8796
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x0400225D RID: 8797
				private Quaternion lastValue = Quaternion.identity;

				// Token: 0x0400225E RID: 8798
				private Quaternion current = Quaternion.identity;
			}
		}
	}
}
