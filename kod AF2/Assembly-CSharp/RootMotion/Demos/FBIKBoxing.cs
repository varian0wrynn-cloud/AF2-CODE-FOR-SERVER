using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F6 RID: 1014
	public class FBIKBoxing : MonoBehaviour
	{
		// Token: 0x0600D9FB RID: 55803 RVA: 0x0063C9BC File Offset: 0x0063ABBC
		private void IMEDKJNAHKK()
		{
			float @float = this.KCLACNEILLB.GetFloat("Crouch180");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600D9FC RID: 55804 RVA: 0x0063CA90 File Offset: 0x0063AC90
		private void LateUpdate()
		{
			float @float = this.KCLACNEILLB.GetFloat("HitWeight");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x0063CB64 File Offset: 0x0063AD64
		private void OGFGENJAMAM()
		{
			float @float = this.KCLACNEILLB.GetFloat("Space reference not set.");
			this.ik.solver.DAMGOIIBHCN(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x0063CC38 File Offset: 0x0063AE38
		private void OEKHPJAEAAE()
		{
			float @float = this.KCLACNEILLB.GetFloat("BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600D9FF RID: 55807 RVA: 0x0063CD0C File Offset: 0x0063AF0C
		private void MDBPBJHACDA()
		{
			float @float = this.KCLACNEILLB.GetFloat("name");
			this.ik.solver.LOOAPOLICLC(this.effector).position = this.target.position;
			this.ik.solver.DAMGOIIBHCN(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void BMNJGPIPKLL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x0063CDF0 File Offset: 0x0063AFF0
		private void BLOLJBHKGOH()
		{
			float @float = this.KCLACNEILLB.GetFloat("HalfSampling");
			this.ik.solver.DAMGOIIBHCN(this.effector).position = this.target.position;
			this.ik.solver.EEKAOKNJLKH(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void PMDPLLIBJAF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA03 RID: 55811 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void ANHOOJFEJJE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA04 RID: 55812 RVA: 0x0063CEC4 File Offset: 0x0063B0C4
		private void GHIJFOALMHM()
		{
			float @float = this.KCLACNEILLB.GetFloat("\n");
			this.ik.solver.DAMGOIIBHCN(this.effector).position = this.target.position;
			this.ik.solver.LOOAPOLICLC(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x0063CF98 File Offset: 0x0063B198
		private void HKJHIANMOPG()
		{
			float @float = this.KCLACNEILLB.GetFloat("wpn_rem2");
			this.ik.solver.DAMGOIIBHCN(this.effector).position = this.target.position;
			this.ik.solver.DAMGOIIBHCN(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA06 RID: 55814 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void KKCFKEDABLB()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA07 RID: 55815 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void CPNOBMNKPNC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA08 RID: 55816 RVA: 0x0063D06C File Offset: 0x0063B26C
		private void GIKJMPHFJKH()
		{
			float @float = this.KCLACNEILLB.GetFloat("_RgbTex");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA09 RID: 55817 RVA: 0x0063D140 File Offset: 0x0063B340
		private void PIEDGJCBCBO()
		{
			float @float = this.KCLACNEILLB.GetFloat("crft_to");
			this.ik.solver.EEKAOKNJLKH(this.effector).position = this.target.position;
			this.ik.solver.EEKAOKNJLKH(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA0A RID: 55818 RVA: 0x0063D214 File Offset: 0x0063B414
		private void HHJKBKLPLIM()
		{
			float @float = this.KCLACNEILLB.GetFloat("close");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.LOOAPOLICLC(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void MODJFGGIAHD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void INDGOHJGCFN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA0D RID: 55821 RVA: 0x0063D2E8 File Offset: 0x0063B4E8
		private void JIFIMFCJDHL()
		{
			float @float = this.KCLACNEILLB.GetFloat("holesFree");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.EEKAOKNJLKH(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA0E RID: 55822 RVA: 0x0063D3BC File Offset: 0x0063B5BC
		private void BHDPDDHLPOI()
		{
			float @float = this.KCLACNEILLB.GetFloat("");
			this.ik.solver.DAMGOIIBHCN(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void CGMHGDEKDEP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA10 RID: 55824 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void IIKDDILLGLF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA11 RID: 55825 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void OBJCOJEHLBE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA12 RID: 55826 RVA: 0x0063D490 File Offset: 0x0063B690
		private void MJBLHNGLFOE()
		{
			float @float = this.KCLACNEILLB.GetFloat("****softSpawn from ");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA13 RID: 55827 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void CAJLCEPLKJG()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA14 RID: 55828 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void ELFLOPJDAKK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x0063D564 File Offset: 0x0063B764
		private void BOEFHGKGJMN()
		{
			float @float = this.KCLACNEILLB.GetFloat("WeaponFire");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x0063D638 File Offset: 0x0063B838
		private void PMIFCKJAFEB()
		{
			float @float = this.KCLACNEILLB.GetFloat("DISTORT");
			this.ik.solver.LOOAPOLICLC(this.effector).position = this.target.position;
			this.ik.solver.DAMGOIIBHCN(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA17 RID: 55831 RVA: 0x0063D70C File Offset: 0x0063B90C
		private void OIKMLNIPLIA()
		{
			float @float = this.KCLACNEILLB.GetFloat("chnam2");
			this.ik.solver.EEKAOKNJLKH(this.effector).position = this.target.position;
			this.ik.solver.DAMGOIIBHCN(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x0063D7E0 File Offset: 0x0063B9E0
		private void NCOJPBKLANI()
		{
			float @float = this.KCLACNEILLB.GetFloat("MotorbikeShootLeft");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.EEKAOKNJLKH(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA19 RID: 55833 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void HDFCIACDDEK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA1A RID: 55834 RVA: 0x0063D8B4 File Offset: 0x0063BAB4
		private void EIEKEPGNGPL()
		{
			float @float = this.KCLACNEILLB.GetFloat("1HandSwordStrafeRight");
			this.ik.solver.LOOAPOLICLC(this.effector).position = this.target.position;
			this.ik.solver.EEKAOKNJLKH(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA1B RID: 55835 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void PFNPOHMMJDN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA1C RID: 55836 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void KEMGOLACEHI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA1E RID: 55838 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void EDGALMCHPPH()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x0600DA1F RID: 55839 RVA: 0x0063D988 File Offset: 0x0063BB88
		private void KPHGGOCHKFA()
		{
			float @float = this.KCLACNEILLB.GetFloat("turn_state");
			this.ik.solver.OEEPHOCHILL(this.effector).position = this.target.position;
			this.ik.solver.OEEPHOCHILL(this.effector).positionWeight = @float * this.weight;
			if (this.aim != null)
			{
				this.aim.solver.transform.LookAt(this.pin.position);
				this.aim.solver.IKPosition = this.target.position;
				this.aim.solver.IKPositionWeight = this.aimWeight.Evaluate(@float) * this.weight;
			}
		}

		// Token: 0x0600DA20 RID: 55840 RVA: 0x0063CDDF File Offset: 0x0063AFDF
		private void AFFAJKPPMHF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
		}

		// Token: 0x04001CE5 RID: 7397
		[Tooltip("The target we want to hit")]
		public Transform target;

		// Token: 0x04001CE6 RID: 7398
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		// Token: 0x04001CE7 RID: 7399
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		// Token: 0x04001CE8 RID: 7400
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		// Token: 0x04001CE9 RID: 7401
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x04001CEA RID: 7402
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		// Token: 0x04001CEB RID: 7403
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		// Token: 0x04001CEC RID: 7404
		private Animator KCLACNEILLB;
	}
}
