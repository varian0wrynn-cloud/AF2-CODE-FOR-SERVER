using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000498 RID: 1176
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x060100EC RID: 65772 RVA: 0x0073724C File Offset: 0x0073544C
		private void ELOOOGPJINJ()
		{
			Application.OpenURL("{0}");
		}

		// Token: 0x060100ED RID: 65773 RVA: 0x00737258 File Offset: 0x00735458
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html");
		}

		// Token: 0x060100EE RID: 65774 RVA: 0x0072FA06 File Offset: 0x0072DC06
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x060100EF RID: 65775 RVA: 0x00737264 File Offset: 0x00735464
		private void BKBMNMFJJFG()
		{
			Application.OpenURL("crft_to");
		}

		// Token: 0x060100F0 RID: 65776 RVA: 0x00730165 File Offset: 0x0072E365
		private void EALBALFGDJC()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x060100F1 RID: 65777 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void NHNNOGDKJBI()
		{
			Application.OpenURL("");
		}

		// Token: 0x060100F2 RID: 65778 RVA: 0x00737270 File Offset: 0x00735470
		public void RotateTo(Vector3 MGALEAJOGPL)
		{
			if (this.pivot == null)
			{
				return;
			}
			if (this.pivot != this.GIOEDNACGLM)
			{
				this.DFENJCLEHKK = this.pivot.localRotation;
				this.GIOEDNACGLM = this.pivot;
			}
			this.pivot.localRotation = this.DFENJCLEHKK;
			if (this.twistWeight > 0f)
			{
				Vector3 odideiiahoc = base.transform.position - this.pivot.position;
				Vector3 vector = this.pivot.rotation * this.twistAxis;
				Vector3 vector2 = vector;
				Vector3.OrthoNormalize(ref vector2, ref odideiiahoc);
				vector2 = vector;
				Vector3 lkojamjmimi = MGALEAJOGPL - this.pivot.position;
				Vector3.OrthoNormalize(ref vector2, ref lkojamjmimi);
				Quaternion b = JEEPKFCFCLI.DLNOKBKKIBH(odideiiahoc, lkojamjmimi, vector);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, this.twistWeight) * this.pivot.rotation;
			}
			if (this.swingWeight > 0f)
			{
				Quaternion b2 = Quaternion.FromToRotation(base.transform.position - this.pivot.position, MGALEAJOGPL - this.pivot.position);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.swingWeight) * this.pivot.rotation;
			}
		}

		// Token: 0x060100F3 RID: 65779 RVA: 0x006B937A File Offset: 0x006B757A
		private void DOGLNBMMFKA()
		{
			Application.OpenURL("walk");
		}

		// Token: 0x060100F4 RID: 65780 RVA: 0x006B98A3 File Offset: 0x006B7AA3
		private void DMPMPJFBBNN()
		{
			Application.OpenURL("MotorbikeSpecialFlip");
		}

		// Token: 0x060100F5 RID: 65781 RVA: 0x0032C255 File Offset: 0x0032A455
		private void DOCPGPOJCKI()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x060100F6 RID: 65782 RVA: 0x007373DC File Offset: 0x007355DC
		public void AMHGCNKLJMN(Vector3 MGALEAJOGPL)
		{
			if (this.pivot == null)
			{
				return;
			}
			if (this.pivot != this.GIOEDNACGLM)
			{
				this.DFENJCLEHKK = this.pivot.localRotation;
				this.GIOEDNACGLM = this.pivot;
			}
			this.pivot.localRotation = this.DFENJCLEHKK;
			if (this.twistWeight > 1595f)
			{
				Vector3 odideiiahoc = base.transform.position - this.pivot.position;
				Vector3 vector = this.pivot.rotation * this.twistAxis;
				Vector3 vector2 = vector;
				Vector3.OrthoNormalize(ref vector2, ref odideiiahoc);
				vector2 = vector;
				Vector3 lkojamjmimi = MGALEAJOGPL - this.pivot.position;
				Vector3.OrthoNormalize(ref vector2, ref lkojamjmimi);
				Quaternion b = JEEPKFCFCLI.DLNOKBKKIBH(odideiiahoc, lkojamjmimi, vector);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, this.twistWeight) * this.pivot.rotation;
			}
			if (this.swingWeight > 305f)
			{
				Quaternion b2 = Quaternion.FromToRotation(base.transform.position - this.pivot.position, MGALEAJOGPL - this.pivot.position);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.swingWeight) * this.pivot.rotation;
			}
		}

		// Token: 0x060100F7 RID: 65783 RVA: 0x00737548 File Offset: 0x00735748
		private void FKDGEDKLDHF()
		{
			Application.OpenURL("  Balls Fired: ");
		}

		// Token: 0x060100F9 RID: 65785 RVA: 0x00737584 File Offset: 0x00735784
		public void PPANDHMNJHM()
		{
			if (this.pivot != null)
			{
				this.pivot.localRotation = this.DFENJCLEHKK;
			}
		}

		// Token: 0x060100FA RID: 65786 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060100FB RID: 65787 RVA: 0x0072E96F File Offset: 0x0072CB6F
		private void DAIECPICEAA()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x060100FC RID: 65788 RVA: 0x007375A5 File Offset: 0x007357A5
		private void LOHKEJFNFFB()
		{
			Application.OpenURL("setCurrentRod sm (профиль)=");
		}

		// Token: 0x060100FD RID: 65789 RVA: 0x00737584 File Offset: 0x00735784
		public void KBIBABPMEAC()
		{
			if (this.pivot != null)
			{
				this.pivot.localRotation = this.DFENJCLEHKK;
			}
		}

		// Token: 0x060100FE RID: 65790 RVA: 0x00737584 File Offset: 0x00735784
		public void ResetRotation()
		{
			if (this.pivot != null)
			{
				this.pivot.localRotation = this.DFENJCLEHKK;
			}
		}

		// Token: 0x060100FF RID: 65791 RVA: 0x0072E70C File Offset: 0x0072C90C
		private void BOJOCFDNFFG()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x06010100 RID: 65792 RVA: 0x007375B1 File Offset: 0x007357B1
		private void FCJCNHOELLJ()
		{
			Application.OpenURL("Swim");
		}

		// Token: 0x06010101 RID: 65793 RVA: 0x007375BD File Offset: 0x007357BD
		private void EKNFBLPDEBP()
		{
			Application.OpenURL("Katana");
		}

		// Token: 0x06010102 RID: 65794 RVA: 0x007375CC File Offset: 0x007357CC
		public float AGNFEECCLLG(InteractionObject.WeightCurve.Type CFIOODECHCB)
		{
			for (int i = 0; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].curve == CFIOODECHCB)
				{
					return this.multipliers[i].multiplier;
				}
			}
			return 304f;
		}

		// Token: 0x06010103 RID: 65795 RVA: 0x00737610 File Offset: 0x00735810
		public float GPOKKEHIOHL(InteractionObject.WeightCurve.Type CFIOODECHCB)
		{
			for (int i = 1; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].curve == CFIOODECHCB)
				{
					return this.multipliers[i].multiplier;
				}
			}
			return 947f;
		}

		// Token: 0x06010104 RID: 65796 RVA: 0x00737653 File Offset: 0x00735853
		private void OKDAGMPBEAN()
		{
			Application.OpenURL("CrawlIdle");
		}

		// Token: 0x06010105 RID: 65797 RVA: 0x0073765F File Offset: 0x0073585F
		private void HFNKIGCNGKK()
		{
			Application.OpenURL("u_UniqueShadowFilterWidth");
		}

		// Token: 0x06010106 RID: 65798 RVA: 0x00737584 File Offset: 0x00735784
		public void OJKMKMFIKBC()
		{
			if (this.pivot != null)
			{
				this.pivot.localRotation = this.DFENJCLEHKK;
			}
		}

		// Token: 0x06010107 RID: 65799 RVA: 0x0072F22A File Offset: 0x0072D42A
		private void EMCMPPDPGJF()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x06010108 RID: 65800 RVA: 0x0073766B File Offset: 0x0073586B
		private void BLLCDJKDNGM()
		{
			Application.OpenURL("demoVector3");
		}

		// Token: 0x06010109 RID: 65801 RVA: 0x00737678 File Offset: 0x00735878
		public float OHAILPMPONE(InteractionObject.WeightCurve.Type CFIOODECHCB)
		{
			for (int i = 0; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].curve == CFIOODECHCB)
				{
					return this.multipliers[i].multiplier;
				}
			}
			return 855f;
		}

		// Token: 0x0601010A RID: 65802 RVA: 0x007376BC File Offset: 0x007358BC
		public float GetValue(InteractionObject.WeightCurve.Type CFIOODECHCB)
		{
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].curve == CFIOODECHCB)
				{
					return this.multipliers[i].multiplier;
				}
			}
			return 1f;
		}

		// Token: 0x0601010B RID: 65803 RVA: 0x00737700 File Offset: 0x00735900
		public void FMMENBDACLC(Vector3 MGALEAJOGPL)
		{
			if (this.pivot == null)
			{
				return;
			}
			if (this.pivot != this.GIOEDNACGLM)
			{
				this.DFENJCLEHKK = this.pivot.localRotation;
				this.GIOEDNACGLM = this.pivot;
			}
			this.pivot.localRotation = this.DFENJCLEHKK;
			if (this.twistWeight > 1340f)
			{
				Vector3 odideiiahoc = base.transform.position - this.pivot.position;
				Vector3 vector = this.pivot.rotation * this.twistAxis;
				Vector3 vector2 = vector;
				Vector3.OrthoNormalize(ref vector2, ref odideiiahoc);
				vector2 = vector;
				Vector3 lkojamjmimi = MGALEAJOGPL - this.pivot.position;
				Vector3.OrthoNormalize(ref vector2, ref lkojamjmimi);
				Quaternion b = JEEPKFCFCLI.DLNOKBKKIBH(odideiiahoc, lkojamjmimi, vector);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, this.twistWeight) * this.pivot.rotation;
			}
			if (this.swingWeight > 1631f)
			{
				Quaternion b2 = Quaternion.FromToRotation(base.transform.position - this.pivot.position, MGALEAJOGPL - this.pivot.position);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.swingWeight) * this.pivot.rotation;
			}
		}

		// Token: 0x0601010C RID: 65804 RVA: 0x0073786C File Offset: 0x00735A6C
		private void KBLGOPJMGMB()
		{
			Application.OpenURL("ui_default_close.wav");
		}

		// Token: 0x0601010D RID: 65805 RVA: 0x00737878 File Offset: 0x00735A78
		private void KOOOAMODMKL()
		{
			Application.OpenURL("The object '{0}' has a ProBuilder attachment component which contains zero attached elements.");
		}

		// Token: 0x0601010E RID: 65806 RVA: 0x006B6F01 File Offset: 0x006B5101
		private void INAAGBGCNLJ()
		{
			Application.OpenURL("IdleFly");
		}

		// Token: 0x0601010F RID: 65807 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06010110 RID: 65808 RVA: 0x00737884 File Offset: 0x00735A84
		public void IGIGOGJJOGA(Vector3 MGALEAJOGPL)
		{
			if (this.pivot == null)
			{
				return;
			}
			if (this.pivot != this.GIOEDNACGLM)
			{
				this.DFENJCLEHKK = this.pivot.localRotation;
				this.GIOEDNACGLM = this.pivot;
			}
			this.pivot.localRotation = this.DFENJCLEHKK;
			if (this.twistWeight > 886f)
			{
				Vector3 odideiiahoc = base.transform.position - this.pivot.position;
				Vector3 vector = this.pivot.rotation * this.twistAxis;
				Vector3 vector2 = vector;
				Vector3.OrthoNormalize(ref vector2, ref odideiiahoc);
				vector2 = vector;
				Vector3 lkojamjmimi = MGALEAJOGPL - this.pivot.position;
				Vector3.OrthoNormalize(ref vector2, ref lkojamjmimi);
				Quaternion b = JEEPKFCFCLI.DLNOKBKKIBH(odideiiahoc, lkojamjmimi, vector);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, this.twistWeight) * this.pivot.rotation;
			}
			if (this.swingWeight > 1321f)
			{
				Quaternion b2 = Quaternion.FromToRotation(base.transform.position - this.pivot.position, MGALEAJOGPL - this.pivot.position);
				this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.swingWeight) * this.pivot.rotation;
			}
		}

		// Token: 0x06010111 RID: 65809 RVA: 0x007379F0 File Offset: 0x00735BF0
		private void JIOGANJDJDP()
		{
			Application.OpenURL("reel_type2");
		}

		// Token: 0x06010112 RID: 65810 RVA: 0x006B7045 File Offset: 0x006B5245
		private void GLIBBLDDFIG()
		{
			Application.OpenURL("No Way points!");
		}

		// Token: 0x040021DB RID: 8667
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x040021DC RID: 8668
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x040021DD RID: 8669
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp = 1f;

		// Token: 0x040021DE RID: 8670
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		// Token: 0x040021DF RID: 8671
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis = Vector3.up;

		// Token: 0x040021E0 RID: 8672
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight = 1f;

		// Token: 0x040021E1 RID: 8673
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		// Token: 0x040021E2 RID: 8674
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce = true;

		// Token: 0x040021E3 RID: 8675
		private Quaternion DFENJCLEHKK;

		// Token: 0x040021E4 RID: 8676
		private Transform GIOEDNACGLM;

		// Token: 0x02000499 RID: 1177
		[Serializable]
		public class Multiplier
		{
			// Token: 0x040021E5 RID: 8677
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x040021E6 RID: 8678
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}
	}
}
