using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E4 RID: 996
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		// Token: 0x0600D606 RID: 54790 RVA: 0x00616770 File Offset: 0x00614970
		private void BIMIILKLBNM(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftFoot, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD((AvatarIKGoal)4, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
		}

		// Token: 0x0600D607 RID: 54791 RVA: 0x00616A18 File Offset: 0x00614C18
		private void GCKMAEMNPCG(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition((AvatarIKGoal)5, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)4, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x00616CC0 File Offset: 0x00614EC0
		private void FBFMBBENLJP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftHand, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.handRotationWeight);
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x00616F68 File Offset: 0x00615168
		private void LMCCAMABGOE(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP((AvatarIKGoal)8, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM((AvatarIKGoal)8, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D60A RID: 54794 RVA: 0x00617210 File Offset: 0x00615410
		private void EIALDMHFJEE(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight((AvatarIKGoal)6, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.RightHand, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.handRotationWeight);
		}

		// Token: 0x0600D60B RID: 54795 RVA: 0x006174B8 File Offset: 0x006156B8
		private void MJPNGFFHOKP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.RightFoot, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)7, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)8, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x00617760 File Offset: 0x00615960
		private void CKDNMLOFGDM(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.MMECIHBBPND((AvatarIKGoal)5, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)7, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x00617A08 File Offset: 0x00615C08
		private void LEEGGJBCPKP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)7, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x00617CB0 File Offset: 0x00615EB0
		private void OKKKCBFEJFM(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.MMECIHBBPND((AvatarIKGoal)5, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)7, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x00617F58 File Offset: 0x00616158
		private void NHLGNBCCPHK(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD((AvatarIKGoal)5, this.handPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)7, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)8, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.handRotationWeight);
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x00618200 File Offset: 0x00616400
		private void JHJGKMMILHD(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN((AvatarIKGoal)4, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD((AvatarIKGoal)6, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.LeftFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)8, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)8, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.handRotationWeight);
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x006184A8 File Offset: 0x006166A8
		private void IEIENKFKBIM(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)7, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x00618750 File Offset: 0x00616950
		private void LKCOLEONMMP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB((AvatarIKGoal)6, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)5, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)8, this.handRotationWeight);
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x006189F8 File Offset: 0x00616BF8
		private void HJCJALOKEHN(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL((AvatarIKGoal)8, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD((AvatarIKGoal)6, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
		}

		// Token: 0x0600D614 RID: 54804 RVA: 0x00618CA0 File Offset: 0x00616EA0
		private void BHGMELKMOPP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightHand, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD((AvatarIKGoal)8, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)5, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)8, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)4, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x00618F48 File Offset: 0x00617148
		private void FPCJJGIBJCK(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)5, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.handTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)8, this.handRotationWeight);
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x006191F0 File Offset: 0x006173F0
		private void OnAnimatorIK(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x00619498 File Offset: 0x00617698
		private void FBHMJIMPGGI(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)4, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x00619740 File Offset: 0x00617940
		private void ANLODFNBEON(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.LeftFoot, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightHand, this.handTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL((AvatarIKGoal)8, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)8, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)5, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)7, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x006199E8 File Offset: 0x00617BE8
		private void CNKGAGMONHE(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM((AvatarIKGoal)4, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x00619C90 File Offset: 0x00617E90
		private void KGDIIMNGBCA(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA((AvatarIKGoal)7, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)6, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)7, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)6, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x00619F38 File Offset: 0x00618138
		private void AOIFICNIIPC(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB((AvatarIKGoal)6, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN((AvatarIKGoal)4, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA((AvatarIKGoal)5, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)7, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.handRotationWeight);
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x0061A1E0 File Offset: 0x006183E0
		private void ODGBAAILNCM(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA((AvatarIKGoal)8, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.RightHand, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)6, this.handRotationWeight);
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x0061A488 File Offset: 0x00618688
		private void PNIKHEBIIGK(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightHand, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD((AvatarIKGoal)7, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.RightHand, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)8, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)6, this.handRotationWeight);
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x0061A730 File Offset: 0x00618930
		private void DAPILEAJLPL(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP((AvatarIKGoal)7, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA((AvatarIKGoal)5, this.handPositionWeight);
			this.bipedIK.JLHNLBADBHM((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)6, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)5, this.handRotationWeight);
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x0061A9D8 File Offset: 0x00618BD8
		private void AFLMCLPAAPL(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)8, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)4, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, this.handRotationWeight);
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x0061AC80 File Offset: 0x00618E80
		private void MMMEMDFHCFD(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AKAJHOCGBEL(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)5, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF((AvatarIKGoal)4, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)8, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)8, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)6, this.handRotationWeight);
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x0061AF28 File Offset: 0x00619128
		private void DMPDLPPACOL(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.EOBJACLKOLK(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.LeftFoot, this.handTargetBiped.position);
			this.bipedIK.MENKEAMNEFN((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)5, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)5, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x0061B230 File Offset: 0x00619430
		private void DFJOCDGKDIE(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.handTargetBiped.rotation);
			this.bipedIK.DHFJIODBHEG(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.handRotationWeight);
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x0061B4D8 File Offset: 0x006196D8
		private void AALICKAOCKP(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.JLHNLBADBHM(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.IECAFJLMPDP((AvatarIKGoal)5, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.RightFoot, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)8, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.handRotationWeight);
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x0061B780 File Offset: 0x00619980
		private void HMINDLPNLFG(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.IECAFJLMPDP(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.AONDGILDFLB(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.MMECIHBBPND(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.KHKPIPKFJOG((AvatarIKGoal)8, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation((AvatarIKGoal)5, this.handTargetBiped.rotation);
			this.bipedIK.CCGPEBNBOGA((AvatarIKGoal)7, this.handPositionWeight);
			this.bipedIK.MMECIHBBPND((AvatarIKGoal)7, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)4, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)4, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)4, this.handRotationWeight);
		}

		// Token: 0x0600D626 RID: 54822 RVA: 0x0061BA28 File Offset: 0x00619C28
		private void FAHNCDFAPPA(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.RightFoot, this.footPositionWeight);
			this.bipedIK.ABFMFHOBDBD(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.RightFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)7, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation((AvatarIKGoal)8, this.handTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL(AvatarIKGoal.RightHand, this.handPositionWeight);
			this.bipedIK.ABFMFHOBDBD((AvatarIKGoal)4, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x0061BCD0 File Offset: 0x00619ED0
		private void CFOMAPJDJOK(int LJFPELOCKOH)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.FDGIEGOJLKB(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.HMKFAJOHKDB(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.MENKEAMNEFN(AvatarIKGoal.RightFoot, this.footTargetBiped.rotation);
			this.bipedIK.IKNEBLLFLAD(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.PKAHMCGFJED(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.RightFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.BIGGNPCDBGN((AvatarIKGoal)5, this.handTargetBiped.position);
			this.bipedIK.DDOJLAEMEDF((AvatarIKGoal)6, this.handTargetBiped.rotation);
			this.bipedIK.BCIOAAGLCBL((AvatarIKGoal)4, this.handPositionWeight);
			this.bipedIK.PKAHMCGFJED((AvatarIKGoal)8, this.handRotationWeight);
			this.animator.SetIKPosition((AvatarIKGoal)6, this.handTargetAnimator.position);
			this.animator.SetIKRotation((AvatarIKGoal)6, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight((AvatarIKGoal)5, this.handPositionWeight);
			this.animator.SetIKRotationWeight((AvatarIKGoal)7, this.handRotationWeight);
		}

		// Token: 0x04001C5F RID: 7263
		public Animator animator;

		// Token: 0x04001C60 RID: 7264
		public BipedIK bipedIK;

		// Token: 0x04001C61 RID: 7265
		public Transform lookAtTargetBiped;

		// Token: 0x04001C62 RID: 7266
		public Transform lookAtTargetAnimator;

		// Token: 0x04001C63 RID: 7267
		public float lookAtWeight = 1f;

		// Token: 0x04001C64 RID: 7268
		public float lookAtBodyWeight = 1f;

		// Token: 0x04001C65 RID: 7269
		public float lookAtHeadWeight = 1f;

		// Token: 0x04001C66 RID: 7270
		public float lookAtEyesWeight = 1f;

		// Token: 0x04001C67 RID: 7271
		public float lookAtClampWeight = 0.5f;

		// Token: 0x04001C68 RID: 7272
		public float lookAtClampWeightHead = 0.5f;

		// Token: 0x04001C69 RID: 7273
		public float lookAtClampWeightEyes = 0.5f;

		// Token: 0x04001C6A RID: 7274
		public Transform footTargetBiped;

		// Token: 0x04001C6B RID: 7275
		public Transform footTargetAnimator;

		// Token: 0x04001C6C RID: 7276
		public float footPositionWeight;

		// Token: 0x04001C6D RID: 7277
		public float footRotationWeight;

		// Token: 0x04001C6E RID: 7278
		public Transform handTargetBiped;

		// Token: 0x04001C6F RID: 7279
		public Transform handTargetAnimator;

		// Token: 0x04001C70 RID: 7280
		public float handPositionWeight;

		// Token: 0x04001C71 RID: 7281
		public float handRotationWeight;
	}
}
