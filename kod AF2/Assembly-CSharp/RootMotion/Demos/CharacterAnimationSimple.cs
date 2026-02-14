using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042C RID: 1068
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		// Token: 0x0600E6AD RID: 59053 RVA: 0x0068B554 File Offset: 0x00689754
		public virtual Vector3 IDIIDIGBFNJ()
		{
			if (this.pivotOffset == 742f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x0600E6AE RID: 59054 RVA: 0x0068B5A0 File Offset: 0x006897A0
		public virtual Vector3 LFDMMIFBBJP()
		{
			if (this.pivotOffset == 598f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void HDFCIACDDEK()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x0068B600 File Offset: 0x00689800
		public virtual Vector3 AAIGAEDMJOJ()
		{
			if (this.pivotOffset == 383f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void BMNJGPIPKLL()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x0068B654 File Offset: 0x00689854
		private void BOAJJAKEMLH()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("chnam2", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6B4 RID: 59060 RVA: 0x0068B6C4 File Offset: 0x006898C4
		private void HMEAENGBFKC()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("206000", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6B5 RID: 59061 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void OFGMIEJKMGC()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6B6 RID: 59062 RVA: 0x0068B734 File Offset: 0x00689934
		private void Update()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("Speed", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6B7 RID: 59063 RVA: 0x0068B7A4 File Offset: 0x006899A4
		public override Vector3 GetPivotPoint()
		{
			if (this.pivotOffset == 0f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x0600E6B8 RID: 59064 RVA: 0x0068B7F0 File Offset: 0x006899F0
		public virtual Vector3 MHMFDKCJANP()
		{
			if (this.pivotOffset == 1441f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * this.pivotOffset;
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x0068B83C File Offset: 0x00689A3C
		private void KJJBBLDJHPD()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("SneakIdle", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void CPNOBMNKPNC()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void KEMGOLACEHI()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x0068B8AC File Offset: 0x00689AAC
		private void OHKHOAKCENL()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("FlyForward", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6BD RID: 59069 RVA: 0x0068B91C File Offset: 0x00689B1C
		private void AIAMIFEPALP()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("wpn_add/base", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected virtual void INDGOHJGCFN()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x0600E6BF RID: 59071 RVA: 0x0068B98C File Offset: 0x00689B8C
		private void BJOICAKCPLI()
		{
			float num = this.moveSpeed.Evaluate(this.characterController.animState.JDFLHKMFHBJ.z);
			this.KCLACNEILLB.SetFloat("get 1401 cmd", num);
			this.characterController.Move(this.characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x0068B5EC File Offset: 0x006897EC
		protected override void Start()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponentInChildren<Animator>();
		}

		// Token: 0x04001E1D RID: 7709
		[SerializeField]
		private CharacterThirdPerson characterController;

		// Token: 0x04001E1E RID: 7710
		[SerializeField]
		private float pivotOffset;

		// Token: 0x04001E1F RID: 7711
		[SerializeField]
		private AnimationCurve moveSpeed;

		// Token: 0x04001E20 RID: 7712
		private Animator KCLACNEILLB;
	}
}
