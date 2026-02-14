using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000405 RID: 1029
	public class OffsetEffector : OffsetModifier
	{
		// Token: 0x0600DCF7 RID: 56567 RVA: 0x0064F07C File Offset: 0x0064D27C
		protected virtual void NEAEHJGMFCJ()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x0064F13C File Offset: 0x0064D33C
		protected virtual void PLBDELOIINH()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DCF9 RID: 56569 RVA: 0x0064F1B8 File Offset: 0x0064D3B8
		protected virtual void JCELICPHGEP()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x0064F234 File Offset: 0x0064D434
		protected virtual void MCFJLPFIJBF()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x0064F2F4 File Offset: 0x0064D4F4
		protected virtual void MHKIHJKOJCE()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCFC RID: 56572 RVA: 0x0064F3B4 File Offset: 0x0064D5B4
		protected virtual void DDLKLBMNIDM()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCFD RID: 56573 RVA: 0x0064F474 File Offset: 0x0064D674
		protected virtual void IKBFHCHIJOO()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x0064F534 File Offset: 0x0064D734
		protected virtual void EPJDJNEEIPI()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DCFF RID: 56575 RVA: 0x0064F5F4 File Offset: 0x0064D7F4
		protected virtual void ELADFDNPOOI()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD00 RID: 56576 RVA: 0x0064F670 File Offset: 0x0064D870
		protected virtual void IAAOGAPJDID()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x0064F6EC File Offset: 0x0064D8EC
		protected virtual void OJACOBAPJPK()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x0064F7AC File Offset: 0x0064D9AC
		protected virtual void MOEPIPIOMHL()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x0064F86C File Offset: 0x0064DA6C
		protected virtual void EFJDBBDMPMC()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD04 RID: 56580 RVA: 0x0064F8E8 File Offset: 0x0064DAE8
		protected virtual void CLHGHANANNL()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x0064F964 File Offset: 0x0064DB64
		protected virtual void BOCDGBIKPAP()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x0064FA24 File Offset: 0x0064DC24
		protected virtual void MLAFGPPHIPI()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD07 RID: 56583 RVA: 0x0064FAE4 File Offset: 0x0064DCE4
		protected virtual void JPHBPEAMNHB()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x0064FB60 File Offset: 0x0064DD60
		protected virtual void OLBDJCFPKFG()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x0064FBDC File Offset: 0x0064DDDC
		protected virtual void MMEDEBFOHPB()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD0A RID: 56586 RVA: 0x0064FC9C File Offset: 0x0064DE9C
		protected virtual void FEBIICIMLHA()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD0B RID: 56587 RVA: 0x0064FD18 File Offset: 0x0064DF18
		protected virtual void IEJEBENGIOD()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD0C RID: 56588 RVA: 0x0064FDD8 File Offset: 0x0064DFD8
		protected virtual void DOHJPDNKALP()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD0D RID: 56589 RVA: 0x0064FE54 File Offset: 0x0064E054
		protected virtual void CEOPNJGPACK()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD0E RID: 56590 RVA: 0x0064FF14 File Offset: 0x0064E114
		protected virtual void LIIFAANLBCF()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD0F RID: 56591 RVA: 0x0064FFD4 File Offset: 0x0064E1D4
		protected virtual void DIFPMHCBFNE()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD11 RID: 56593 RVA: 0x00650094 File Offset: 0x0064E294
		protected virtual void MODJFGGIAHD()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD12 RID: 56594 RVA: 0x00650110 File Offset: 0x0064E310
		protected virtual void JLKBMEBFHBI()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD13 RID: 56595 RVA: 0x0065018C File Offset: 0x0064E38C
		protected override void Start()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x00650208 File Offset: 0x0064E408
		protected virtual void KPLDAKOPIFB()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD15 RID: 56597 RVA: 0x006502C8 File Offset: 0x0064E4C8
		protected virtual void JAEFGBBJCCP()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD16 RID: 56598 RVA: 0x00650388 File Offset: 0x0064E588
		protected virtual void BMNJGPIPKLL()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD17 RID: 56599 RVA: 0x00650404 File Offset: 0x0064E604
		protected virtual void DGEIACONKCJ()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x00650480 File Offset: 0x0064E680
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x006504FC File Offset: 0x0064E6FC
		protected virtual void CDKAFHIOBME()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x006505BC File Offset: 0x0064E7BC
		protected virtual void FIJKDFIMELM()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x00650638 File Offset: 0x0064E838
		protected virtual void DMAOHJDKMNN()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x006506B4 File Offset: 0x0064E8B4
		protected virtual void LMEJKAEIDCO()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x00650730 File Offset: 0x0064E930
		protected virtual void BGFNOICCAGO()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x006507F0 File Offset: 0x0064E9F0
		protected virtual void PICNOMNAKPA()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x006508B0 File Offset: 0x0064EAB0
		protected virtual void MNOEEHPMJMA()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00650970 File Offset: 0x0064EB70
		protected virtual void HELKCEJMJCO()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x00650A30 File Offset: 0x0064EC30
		protected virtual void OPNPODKLOJK()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00650AAC File Offset: 0x0064ECAC
		protected virtual void ELMHLFFIOGL()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x00650B6C File Offset: 0x0064ED6C
		protected virtual void PFNPOHMMJDN()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x00650BE8 File Offset: 0x0064EDE8
		protected virtual void BOBCDLEPMAJ()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD25 RID: 56613 RVA: 0x00650CA8 File Offset: 0x0064EEA8
		protected virtual void GCPENONAGDG()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD26 RID: 56614 RVA: 0x00650D68 File Offset: 0x0064EF68
		protected virtual void CAEGFKACKIC()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x00650E28 File Offset: 0x0064F028
		protected virtual void IMKHFLLACDF()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD28 RID: 56616 RVA: 0x00650EE8 File Offset: 0x0064F0E8
		protected virtual void MBGJEAMMJJN()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD29 RID: 56617 RVA: 0x00650FA8 File Offset: 0x0064F1A8
		protected virtual void HAMGMFMGPCI()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD2A RID: 56618 RVA: 0x00651068 File Offset: 0x0064F268
		protected virtual void EKJCBOPLALL()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x00651128 File Offset: 0x0064F328
		protected virtual void FADIAAGNLCG()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD2C RID: 56620 RVA: 0x006511E8 File Offset: 0x0064F3E8
		protected virtual void MPLNFMFLGDE()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD2D RID: 56621 RVA: 0x006512A8 File Offset: 0x0064F4A8
		protected virtual void KGICJDGIIJK()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD2E RID: 56622 RVA: 0x00651324 File Offset: 0x0064F524
		protected virtual void NOKJMMDMJNO()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD2F RID: 56623 RVA: 0x006513A0 File Offset: 0x0064F5A0
		protected virtual void MEPOMFMNCDE()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD30 RID: 56624 RVA: 0x00651460 File Offset: 0x0064F660
		protected virtual void CJNBMPCNKHP()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD31 RID: 56625 RVA: 0x006514DC File Offset: 0x0064F6DC
		protected virtual void EBFEGNHDGIN()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD32 RID: 56626 RVA: 0x0065159C File Offset: 0x0064F79C
		protected virtual void LONPIDHHHPA()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD33 RID: 56627 RVA: 0x0065165C File Offset: 0x0064F85C
		protected virtual void LHDCDIOEODG()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x0065171C File Offset: 0x0064F91C
		protected virtual void GCMHJCAOIMF()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x006517DC File Offset: 0x0064F9DC
		protected virtual void EFCCCKGCOCB()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x00651858 File Offset: 0x0064FA58
		protected virtual void NPFOAOBGOEE()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x00651918 File Offset: 0x0064FB18
		protected virtual void IJOCHELLKJH()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x00651994 File Offset: 0x0064FB94
		protected virtual void MKNPFMEMOJO()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x00651A10 File Offset: 0x0064FC10
		protected virtual void MLOBABEJJML()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x00651AD0 File Offset: 0x0064FCD0
		protected override void HEHOBGDMLOK()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x00651B90 File Offset: 0x0064FD90
		protected virtual void JOKIOHMEIEN()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x00651C50 File Offset: 0x0064FE50
		protected virtual void JNPAGPHPGNM()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x00651D10 File Offset: 0x0064FF10
		protected virtual void GLNLBLLLBBC()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x00651DD0 File Offset: 0x0064FFD0
		protected virtual void JIGFBMPOGPP()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x00651E90 File Offset: 0x00650090
		protected virtual void HHCGGNBDPMG()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x00651F50 File Offset: 0x00650150
		protected virtual void JHFAHBIIJDC()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x00651FCC File Offset: 0x006501CC
		protected virtual void OBJCOJEHLBE()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD42 RID: 56642 RVA: 0x00652048 File Offset: 0x00650248
		protected virtual void HALPFPKCLAP()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD43 RID: 56643 RVA: 0x00652108 File Offset: 0x00650308
		protected virtual void HHGGCBLOJGB()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.HJPCHINGJCN().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD44 RID: 56644 RVA: 0x00652184 File Offset: 0x00650384
		protected virtual void KEMGOLACEHI()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD45 RID: 56645 RVA: 0x00652200 File Offset: 0x00650400
		protected virtual void AIFIEAGFIMM()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x0065227C File Offset: 0x0065047C
		protected virtual void MEJJNIKAFNJ()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x0065233C File Offset: 0x0065053C
		protected virtual void NJNANLGDMEH()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD48 RID: 56648 RVA: 0x006523FC File Offset: 0x006505FC
		protected virtual void GEAKAHAAGIC()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD49 RID: 56649 RVA: 0x006524BC File Offset: 0x006506BC
		protected virtual void LOJCEKNCAOD()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x0065257C File Offset: 0x0065077C
		protected virtual void ACLJDJBJLCD()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD4B RID: 56651 RVA: 0x006525F8 File Offset: 0x006507F8
		protected virtual void HCDDBGBACMA()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD4C RID: 56652 RVA: 0x006526B8 File Offset: 0x006508B8
		protected virtual void PKCAKBPNDGP()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD4D RID: 56653 RVA: 0x00652778 File Offset: 0x00650978
		protected virtual void DCFNFOPJBLG()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x00652838 File Offset: 0x00650A38
		protected virtual void EFMJHLFNCJK()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i++)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x006528F8 File Offset: 0x00650AF8
		protected virtual void BCFDBGIOMBL()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position + this.ik.solver.DAMGOIIBHCN(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x006529B8 File Offset: 0x00650BB8
		protected virtual void EHDPACPIBNF()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = true;
				}
			}
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x00652A34 File Offset: 0x00650C34
		protected virtual void MLLFHCCGLGG()
		{
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 1; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.EEKAOKNJLKH(effectorLink.effectorType).bone.position + this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x00652AF4 File Offset: 0x00650CF4
		protected virtual void CBLGFOFHNPJ()
		{
			base.Start();
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.OEEPHOCHILL(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x00652B70 File Offset: 0x00650D70
		protected virtual void DGDGMFDPEHO()
		{
			base.Start();
			OffsetEffector.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i += 0)
			{
				OffsetEffector.EffectorLink effectorLink = array[i];
				effectorLink.localPosition = base.transform.InverseTransformPoint(this.ik.solver.LOOAPOLICLC(effectorLink.effectorType).bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.NEKNDGMNDHG().effectChildNodes = true;
				}
			}
		}

		// Token: 0x04001D3F RID: 7487
		public OffsetEffector.EffectorLink[] effectorLinks;

		// Token: 0x02000406 RID: 1030
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x04001D40 RID: 7488
			public FullBodyBipedEffector effectorType;

			// Token: 0x04001D41 RID: 7489
			public float weightMultiplier = 1f;

			// Token: 0x04001D42 RID: 7490
			[HideInInspector]
			public Vector3 localPosition;
		}
	}
}
