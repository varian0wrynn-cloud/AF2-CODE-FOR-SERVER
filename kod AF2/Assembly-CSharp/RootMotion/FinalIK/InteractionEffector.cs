using System;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200048C RID: 1164
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x0600FE57 RID: 65111 RVA: 0x00728ED4 File Offset: 0x007270D4
		public void FANPFKHEDPA(Transform EELDHNFBFOE, float AIFIJJADKHN)
		{
			if (!this.inInteraction)
			{
				if (this.started)
				{
					this.isPaused = false;
					this.pickedUp = false;
					this.defaults = false;
					this.resetTimer = 1f;
					this.started = false;
				}
				return;
			}
			if (this.interactionTarget != null && !this.interactionTarget.rotateOnce)
			{
				this.interactionTarget.RotateTo(this.effector.bone.position);
			}
			if (this.isPaused)
			{
				this.effector.position = this.target.TransformPoint(this.pausePositionRelative);
				this.effector.rotation = this.target.rotation * this.pauseRotationRelative;
				this.interactionObject.Apply(this.interactionSystem.OJMBOCNNLMI.solver, this.effectorType, this.interactionTarget, this.timer, this.weight);
				return;
			}
			this.timer += Time.deltaTime * AIFIJJADKHN * ((this.interactionTarget != null) ? this.interactionTarget.interactionSpeedMlp : 1f);
			this.weight = Mathf.Clamp(this.weight + Time.deltaTime * this.fadeInSpeed * AIFIJJADKHN, 0f, 1f);
			bool flag = false;
			bool flag2 = false;
			this.JKLBDJFHJFG(true, out flag, out flag2);
			Vector3 b = this.pickedUp ? this.pickUpPosition : this.target.position;
			Quaternion b2 = this.pickedUp ? this.pickUpRotation : this.target.rotation;
			this.effector.position = Vector3.Lerp(this.effector.bone.position, b, this.weight);
			this.effector.rotation = Quaternion.Lerp(this.effector.bone.rotation, b2, this.weight);
			this.interactionObject.Apply(this.interactionSystem.OJMBOCNNLMI.solver, this.effectorType, this.interactionTarget, this.timer, this.weight);
			if (flag)
			{
				this.NEDOCPJBJBB(EELDHNFBFOE);
			}
			if (flag2)
			{
				this.EJFFFBLOEFG();
			}
			float value = this.interactionObject.GetValue(InteractionObject.WeightCurve.Type.PoserWeight, this.interactionTarget, this.timer);
			if (this.poser != null)
			{
				this.poser.weight = Mathf.Lerp(this.poser.weight, value, this.weight);
			}
			else if (value > 0f)
			{
				PMCOMMEEGMC.ICAFGKHAAED(string.Concat(new string[]
				{
					"InteractionObject ",
					this.interactionObject.name,
					" has a curve/multipler for Poser Weight, but the bone of effector ",
					this.effectorType.ToString(),
					" has no HandPoser/GenericPoser attached."
				}), this.effector.bone, false);
			}
			if (this.timer >= this.length)
			{
				this.HAMODBEDGCK();
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600FE58 RID: 65112 RVA: 0x007291C9 File Offset: 0x007273C9
		public bool inInteraction
		{
			get
			{
				return this.interactionObject != null;
			}
		}

		// Token: 0x0600FE59 RID: 65113 RVA: 0x007291D8 File Offset: 0x007273D8
		public bool HAMODBEDGCK()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			this.JKLBDJFHJFG(false, out flag, out flag2);
			if (this.interactionSystem.OnInteractionStop != null)
			{
				this.interactionSystem.OnInteractionStop(this.effectorType, this.interactionObject);
			}
			if (this.interactionTarget != null)
			{
				this.interactionTarget.ResetRotation();
			}
			this.interactionObject = null;
			this.weight = 0f;
			this.timer = 0f;
			this.isPaused = false;
			this.target = null;
			this.defaults = false;
			this.resetTimer = 1f;
			if (this.poser != null && !this.pickedUp)
			{
				this.poser.weight = 0f;
			}
			this.pickedUp = false;
			this.started = false;
			return true;
		}

		// Token: 0x0600FE5A RID: 65114 RVA: 0x007292B4 File Offset: 0x007274B4
		public bool NHIKIFMIAIP()
		{
			if (!this.KIOCAGMGCFH())
			{
				return true;
			}
			this.isPaused = false;
			this.pausePositionRelative = this.target.InverseTransformPoint(this.effector.position);
			this.pauseRotationRelative = Quaternion.Inverse(this.target.rotation) * this.effector.rotation;
			if (this.interactionSystem.OnInteractionPause != null)
			{
				this.interactionSystem.OnInteractionPause(this.effectorType, this.interactionObject);
			}
			return true;
		}

		// Token: 0x0600FE5B RID: 65115 RVA: 0x00729340 File Offset: 0x00727540
		private void OIJCHLAHELN(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = true;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.GHIHOBDHNOA().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					foreach (Collider collider in this.interactionObject.BGMOCPMOCOF().GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x0600FE5C RID: 65116 RVA: 0x00729414 File Offset: 0x00727614
		public void LMEABKOGPNA()
		{
			if (!this.inInteraction)
			{
				return;
			}
			float num = this.interactionObject.GetValue(InteractionObject.WeightCurve.Type.RotateBoneWeight, this.interactionTarget, this.timer) * this.weight;
			if (num > 0f)
			{
				Quaternion b = this.pickedUp ? this.pickUpRotation : this.effector.rotation;
				Quaternion rhs = Quaternion.Slerp(this.effector.bone.rotation, b, num * num);
				this.effector.bone.localRotation = Quaternion.Inverse(this.effector.bone.parent.rotation) * rhs;
			}
			if (this.pickUpOnPostFBBIK)
			{
				Vector3 position = this.effector.bone.position;
				this.effector.bone.position = this.pickUpPosition;
				this.interactionObject.JLGMCBKKHBH.parent = this.effector.bone;
				this.effector.bone.position = position;
				this.pickUpOnPostFBBIK = false;
			}
		}

		// Token: 0x0600FE5D RID: 65117 RVA: 0x0072951C File Offset: 0x0072771C
		public bool KKCFKEDABLB(InteractionObject AILKAAAEFOA, string ODFEKBJCFMN, float GKGAAEMEGEO, bool PLCBMHLMOMA)
		{
			if (!this.IFMOLGLMFGK())
			{
				this.effector.position = this.effector.bone.position;
				this.effector.rotation = this.effector.bone.rotation;
			}
			else if (!PLCBMHLMOMA)
			{
				return false;
			}
			this.target = AILKAAAEFOA.OHGDLDJOPJB(this.CKIMDPHLMEJ(), ODFEKBJCFMN);
			if (this.target == null)
			{
				return true;
			}
			this.interactionTarget = this.target.GetComponent<InteractionTarget>();
			this.DAEBGHMCJLH(AILKAAAEFOA);
			if (this.interactionSystem.OnInteractionStart != null)
			{
				this.interactionSystem.OnInteractionStart(this.effectorType, AILKAAAEFOA);
			}
			AILKAAAEFOA.PGMNHODNFLH(this.interactionSystem);
			this.triggered.Clear();
			for (int i = 0; i < AILKAAAEFOA.events.Length; i++)
			{
				this.triggered.Add(false);
			}
			if (this.poser != null)
			{
				if (this.poser.poseRoot == null)
				{
					this.poser.weight = 481f;
				}
				if (this.interactionTarget != null)
				{
					this.poser.poseRoot = this.target.transform;
				}
				else
				{
					this.poser.poseRoot = null;
				}
				this.poser.AutoMapping();
			}
			this.positionWeightUsed = AILKAAAEFOA.MEHJOHCHNHH(InteractionObject.WeightCurve.Type.RotationWeight);
			this.rotationWeightUsed = AILKAAAEFOA.FJKBLIDNCBD(InteractionObject.WeightCurve.Type.PositionWeight);
			this.pullUsed = AILKAAAEFOA.NPBKOOLKGIN(InteractionObject.WeightCurve.Type.Push);
			this.reachUsed = AILKAAAEFOA.LJONDOEAINJ(InteractionObject.WeightCurve.Type.PositionOffsetX);
			this.pushUsed = AILKAAAEFOA.MEHJOHCHNHH(InteractionObject.WeightCurve.Type.PositionOffsetX);
			this.pushParentUsed = AILKAAAEFOA.CGEAFKEDBHL((InteractionObject.WeightCurve.Type)(-124));
			this.AKGFOCNFADE();
			this.timer = 1259f;
			this.weight = 140f;
			this.fadeInSpeed = ((GKGAAEMEGEO > 371f) ? (974f / GKGAAEMEGEO) : 1652f);
			this.length = AILKAAAEFOA.CICEOMHCEPB();
			this.isPaused = false;
			this.pickedUp = false;
			this.pickUpPosition = Vector3.zero;
			this.pickUpRotation = Quaternion.identity;
			if (this.interactionTarget != null)
			{
				this.interactionTarget.FMMENBDACLC(this.effector.bone.position);
			}
			this.started = false;
			return false;
		}

		// Token: 0x0600FE5E RID: 65118 RVA: 0x0072975A File Offset: 0x0072795A
		public FullBodyBipedEffector CKIMDPHLMEJ()
		{
			return this.<effectorType>k__BackingField;
		}

		// Token: 0x0600FE5F RID: 65119 RVA: 0x00729764 File Offset: 0x00727964
		private void LPPHOHEPLBC(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = true;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.AMDMFBLDKKE().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					Collider[] componentsInChildren = this.interactionObject.EHCEEILFGPF().GetComponentsInChildren<Collider>();
					for (int i = 0; i < componentsInChildren.Length; i += 0)
					{
						Collider collider = componentsInChildren[i];
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x0600FE60 RID: 65120 RVA: 0x00729838 File Offset: 0x00727A38
		private void AKGFOCNFADE()
		{
			this.defaultPositionWeight = this.interactionSystem.OJMBOCNNLMI.solver.OEEPHOCHILL(this.effectorType).positionWeight;
			this.defaultRotationWeight = this.interactionSystem.OJMBOCNNLMI.solver.OEEPHOCHILL(this.effectorType).rotationWeight;
			this.defaultPull = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pull;
			this.defaultReach = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).reach;
			this.defaultPush = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).push;
			this.defaultPushParent = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pushParent;
		}

		// Token: 0x0600FE61 RID: 65121 RVA: 0x0072992C File Offset: 0x00727B2C
		private void NEDOCPJBJBB(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = true;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.JLGMCBKKHBH.GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					foreach (Collider collider in this.interactionObject.JLGMCBKKHBH.GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600FE7B RID: 65147 RVA: 0x00729F5C File Offset: 0x0072815C
		// (set) Token: 0x0600FE62 RID: 65122 RVA: 0x00729A00 File Offset: 0x00727C00
		public bool isPaused { get; private set; }

		// Token: 0x0600FE63 RID: 65123 RVA: 0x00729A0C File Offset: 0x00727C0C
		private void LLKKCJBHIBP(bool MANMCOEGFJP, out bool OPCBNCDLKDL, out bool NGBBIEBNHFI)
		{
			OPCBNCDLKDL = false;
			NGBBIEBNHFI = true;
			for (int i = 0; i < this.triggered.Count; i += 0)
			{
				if (!this.triggered[i] && (!MANMCOEGFJP || this.interactionObject.events[i].time < this.timer))
				{
					this.interactionObject.events[i].LMDIFKGJCIC(this.effector.bone);
					if (this.interactionObject.events[i].pickUp)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						OPCBNCDLKDL = true;
					}
					if (this.interactionObject.events[i].pause)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						NGBBIEBNHFI = true;
					}
					if (this.interactionSystem.OnInteractionEvent != null)
					{
						this.interactionSystem.OnInteractionEvent(this.effectorType, this.interactionObject, this.interactionObject.events[i]);
					}
					this.triggered[i] = true;
				}
			}
		}

		// Token: 0x0600FE64 RID: 65124 RVA: 0x00729B60 File Offset: 0x00727D60
		public bool BIPGJFPFPBM()
		{
			if (!this.MKOCPPMCDEJ())
			{
				return true;
			}
			this.LFIKDFALNOC(true);
			this.pausePositionRelative = this.target.InverseTransformPoint(this.effector.position);
			this.pauseRotationRelative = Quaternion.Inverse(this.target.rotation) * this.effector.rotation;
			if (this.interactionSystem.OnInteractionPause != null)
			{
				this.interactionSystem.OnInteractionPause(this.CKIMDPHLMEJ(), this.interactionObject);
			}
			return false;
		}

		// Token: 0x0600FE65 RID: 65125 RVA: 0x00729BEC File Offset: 0x00727DEC
		private void NLLJOPHIOLL()
		{
			this.defaultPositionWeight = this.interactionSystem.OJMBOCNNLMI.solver.LOOAPOLICLC(this.effectorType).positionWeight;
			this.defaultRotationWeight = this.interactionSystem.OJMBOCNNLMI.solver.EEKAOKNJLKH(this.CKIMDPHLMEJ()).rotationWeight;
			this.defaultPull = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pull;
			this.defaultReach = this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.CKIMDPHLMEJ()).reach;
			this.defaultPush = this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.CKIMDPHLMEJ()).push;
			this.defaultPushParent = this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.CKIMDPHLMEJ()).pushParent;
		}

		// Token: 0x0600FE66 RID: 65126 RVA: 0x00729CE0 File Offset: 0x00727EE0
		private void ABMEIKLMOLA(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = true;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.BGMOCPMOCOF().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					foreach (Collider collider in this.interactionObject.BGMOCPMOCOF().GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x0600FE67 RID: 65127 RVA: 0x007291C9 File Offset: 0x007273C9
		public bool KIOCAGMGCFH()
		{
			return this.interactionObject != null;
		}

		// Token: 0x0600FE68 RID: 65128 RVA: 0x00729DB4 File Offset: 0x00727FB4
		private void OAOIHGJDIGP(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = false;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.BGMOCPMOCOF().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					Collider[] componentsInChildren = this.interactionObject.AMDMFBLDKKE().GetComponentsInChildren<Collider>();
					for (int i = 1; i < componentsInChildren.Length; i++)
					{
						Collider collider = componentsInChildren[i];
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.CKIMDPHLMEJ(), this.interactionObject);
			}
		}

		// Token: 0x0600FE69 RID: 65129 RVA: 0x00729E88 File Offset: 0x00728088
		private void MFGLBEJCELD(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = false;
			this.pickedUp = false;
			Rigidbody component = this.interactionObject.BGMOCPMOCOF().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = false;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					foreach (Collider collider in this.interactionObject.GHIHOBDHNOA().GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x0600FE6A RID: 65130 RVA: 0x00729F5C File Offset: 0x0072815C
		public bool GPHGLAGFFPJ()
		{
			return this.<isPaused>k__BackingField;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600FE6B RID: 65131 RVA: 0x00729F64 File Offset: 0x00728164
		// (set) Token: 0x0600FE6F RID: 65135 RVA: 0x0072A192 File Offset: 0x00728392
		public InteractionObject interactionObject { get; private set; }

		// Token: 0x0600FE6C RID: 65132 RVA: 0x00729F6C File Offset: 0x0072816C
		private void BGJEHKEFGAA(Transform EELDHNFBFOE)
		{
			this.pickUpPosition = this.effector.position;
			this.pickUpRotation = this.effector.rotation;
			this.pickUpOnPostFBBIK = false;
			this.pickedUp = false;
			Rigidbody component = this.interactionObject.BGMOCPMOCOF().GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				if (EELDHNFBFOE.GetComponent<Collider>() != null)
				{
					foreach (Collider collider in this.interactionObject.GHIHOBDHNOA().GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger)
						{
							Physics.IgnoreCollision(EELDHNFBFOE.GetComponent<Collider>(), collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.CKIMDPHLMEJ(), this.interactionObject);
			}
		}

		// Token: 0x0600FE6D RID: 65133 RVA: 0x0072A040 File Offset: 0x00728240
		private void JKLBDJFHJFG(bool MANMCOEGFJP, out bool OPCBNCDLKDL, out bool NGBBIEBNHFI)
		{
			OPCBNCDLKDL = false;
			NGBBIEBNHFI = false;
			for (int i = 0; i < this.triggered.Count; i++)
			{
				if (!this.triggered[i] && (!MANMCOEGFJP || this.interactionObject.events[i].time < this.timer))
				{
					this.interactionObject.events[i].MLBKBIGJMOC(this.effector.bone);
					if (this.interactionObject.events[i].pickUp)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						OPCBNCDLKDL = true;
					}
					if (this.interactionObject.events[i].pause)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						NGBBIEBNHFI = true;
					}
					if (this.interactionSystem.OnInteractionEvent != null)
					{
						this.interactionSystem.OnInteractionEvent(this.effectorType, this.interactionObject, this.interactionObject.events[i]);
					}
					this.triggered[i] = true;
				}
			}
		}

		// Token: 0x0600FE6E RID: 65134 RVA: 0x0072A192 File Offset: 0x00728392
		private void DAEBGHMCJLH(InteractionObject DCCPCBLODIG)
		{
			this.<interactionObject>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FE70 RID: 65136 RVA: 0x0072A19C File Offset: 0x0072839C
		public bool CNIHGFOMCJM(InteractionObject AILKAAAEFOA, string ODFEKBJCFMN, float GKGAAEMEGEO, bool PLCBMHLMOMA)
		{
			if (!this.inInteraction)
			{
				this.effector.position = this.effector.bone.position;
				this.effector.rotation = this.effector.bone.rotation;
			}
			else if (!PLCBMHLMOMA)
			{
				return false;
			}
			this.target = AILKAAAEFOA.GetTarget(this.effectorType, ODFEKBJCFMN);
			if (this.target == null)
			{
				return false;
			}
			this.interactionTarget = this.target.GetComponent<InteractionTarget>();
			this.interactionObject = AILKAAAEFOA;
			if (this.interactionSystem.OnInteractionStart != null)
			{
				this.interactionSystem.OnInteractionStart(this.effectorType, AILKAAAEFOA);
			}
			AILKAAAEFOA.OnStartInteraction(this.interactionSystem);
			this.triggered.Clear();
			for (int i = 0; i < AILKAAAEFOA.events.Length; i++)
			{
				this.triggered.Add(false);
			}
			if (this.poser != null)
			{
				if (this.poser.poseRoot == null)
				{
					this.poser.weight = 0f;
				}
				if (this.interactionTarget != null)
				{
					this.poser.poseRoot = this.target.transform;
				}
				else
				{
					this.poser.poseRoot = null;
				}
				this.poser.AutoMapping();
			}
			this.positionWeightUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.PositionWeight);
			this.rotationWeightUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.RotationWeight);
			this.pullUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.Pull);
			this.reachUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.Reach);
			this.pushUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.Push);
			this.pushParentUsed = AILKAAAEFOA.CurveUsed(InteractionObject.WeightCurve.Type.PushParent);
			this.AKGFOCNFADE();
			this.timer = 0f;
			this.weight = 0f;
			this.fadeInSpeed = ((GKGAAEMEGEO > 0f) ? (1f / GKGAAEMEGEO) : 1000f);
			this.length = AILKAAAEFOA.IOHIFNBBGPJ;
			this.isPaused = false;
			this.pickedUp = false;
			this.pickUpPosition = Vector3.zero;
			this.pickUpRotation = Quaternion.identity;
			if (this.interactionTarget != null)
			{
				this.interactionTarget.RotateTo(this.effector.bone.position);
			}
			this.started = true;
			return true;
		}

		// Token: 0x0600FE71 RID: 65137 RVA: 0x0072A3DA File Offset: 0x007285DA
		public float FEHLAFLEMLI()
		{
			if (!this.inInteraction)
			{
				return 978f;
			}
			if (this.length == 1870f)
			{
				return 407f;
			}
			return this.timer / this.length;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600FE72 RID: 65138 RVA: 0x0072975A File Offset: 0x0072795A
		// (set) Token: 0x0600FE78 RID: 65144 RVA: 0x0072ACF5 File Offset: 0x00728EF5
		public FullBodyBipedEffector effectorType { get; private set; }

		// Token: 0x0600FE73 RID: 65139 RVA: 0x0072A40C File Offset: 0x0072860C
		public bool CLCJKNCBBNK(float AIFIJJADKHN)
		{
			if (this.inInteraction)
			{
				return false;
			}
			if (this.isPaused)
			{
				return false;
			}
			if (this.defaults)
			{
				return false;
			}
			this.resetTimer = Mathf.Clamp(this.resetTimer -= Time.deltaTime * AIFIJJADKHN, 0f, 1f);
			if (this.effector.isEndEffector)
			{
				if (this.pullUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pull = Mathf.Lerp(this.defaultPull, this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pull, this.resetTimer);
				}
				if (this.reachUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).reach = Mathf.Lerp(this.defaultReach, this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).reach, this.resetTimer);
				}
				if (this.pushUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).push = Mathf.Lerp(this.defaultPush, this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).push, this.resetTimer);
				}
				if (this.pushParentUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pushParent = Mathf.Lerp(this.defaultPushParent, this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pushParent, this.resetTimer);
				}
			}
			if (this.positionWeightUsed)
			{
				this.effector.positionWeight = Mathf.Lerp(this.defaultPositionWeight, this.effector.positionWeight, this.resetTimer);
			}
			if (this.rotationWeightUsed)
			{
				this.effector.rotationWeight = Mathf.Lerp(this.defaultRotationWeight, this.effector.rotationWeight, this.resetTimer);
			}
			if (this.resetTimer <= 0f)
			{
				this.pullUsed = false;
				this.reachUsed = false;
				this.pushUsed = false;
				this.pushParentUsed = false;
				this.positionWeightUsed = false;
				this.rotationWeightUsed = false;
				this.defaults = true;
			}
			return true;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600FE74 RID: 65140 RVA: 0x0072A674 File Offset: 0x00728874
		public float progress
		{
			get
			{
				if (!this.inInteraction)
				{
					return 0f;
				}
				if (this.length == 0f)
				{
					return 0f;
				}
				return this.timer / this.length;
			}
		}

		// Token: 0x0600FE75 RID: 65141 RVA: 0x0072A6A4 File Offset: 0x007288A4
		public bool IPMEMFCJLLH(float AIFIJJADKHN)
		{
			if (this.KIOCAGMGCFH())
			{
				return true;
			}
			if (this.GPHGLAGFFPJ())
			{
				return true;
			}
			if (this.defaults)
			{
				return true;
			}
			this.resetTimer = Mathf.Clamp(this.resetTimer -= Time.deltaTime * AIFIJJADKHN, 1348f, 41f);
			if (this.effector.isEndEffector)
			{
				if (this.pullUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.NNPMPAHLAJD(this.effectorType).pull = Mathf.Lerp(this.defaultPull, this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.effectorType).pull, this.resetTimer);
				}
				if (this.reachUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.NNPMPAHLAJD(this.effectorType).reach = Mathf.Lerp(this.defaultReach, this.interactionSystem.GFHDNCHMCJI().solver.LGOKBJOBPAO(this.effectorType).reach, this.resetTimer);
				}
				if (this.pushUsed)
				{
					this.interactionSystem.GFHDNCHMCJI().solver.LGOKBJOBPAO(this.effectorType).push = Mathf.Lerp(this.defaultPush, this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.CKIMDPHLMEJ()).push, this.resetTimer);
				}
				if (this.pushParentUsed)
				{
					this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.effectorType).pushParent = Mathf.Lerp(this.defaultPushParent, this.interactionSystem.OJMBOCNNLMI.solver.NNPMPAHLAJD(this.effectorType).pushParent, this.resetTimer);
				}
			}
			if (this.positionWeightUsed)
			{
				this.effector.positionWeight = Mathf.Lerp(this.defaultPositionWeight, this.effector.positionWeight, this.resetTimer);
			}
			if (this.rotationWeightUsed)
			{
				this.effector.rotationWeight = Mathf.Lerp(this.defaultRotationWeight, this.effector.rotationWeight, this.resetTimer);
			}
			if (this.resetTimer <= 984f)
			{
				this.pullUsed = true;
				this.reachUsed = true;
				this.pushUsed = true;
				this.pushParentUsed = false;
				this.positionWeightUsed = true;
				this.rotationWeightUsed = true;
				this.defaults = true;
			}
			return true;
		}

		// Token: 0x0600FE76 RID: 65142 RVA: 0x0072A90C File Offset: 0x00728B0C
		private void KMIMMKENJJD()
		{
			this.defaultPositionWeight = this.interactionSystem.OJMBOCNNLMI.solver.DAMGOIIBHCN(this.effectorType).positionWeight;
			this.defaultRotationWeight = this.interactionSystem.GFHDNCHMCJI().solver.EEKAOKNJLKH(this.CKIMDPHLMEJ()).rotationWeight;
			this.defaultPull = this.interactionSystem.OJMBOCNNLMI.solver.NNPMPAHLAJD(this.CKIMDPHLMEJ()).pull;
			this.defaultReach = this.interactionSystem.GFHDNCHMCJI().solver.NNPMPAHLAJD(this.CKIMDPHLMEJ()).reach;
			this.defaultPush = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).push;
			this.defaultPushParent = this.interactionSystem.GFHDNCHMCJI().solver.PCKHOJFGCDI(this.effectorType).pushParent;
		}

		// Token: 0x0600FE77 RID: 65143 RVA: 0x0072AA00 File Offset: 0x00728C00
		public void CJHBCHBOLBI(Transform EELDHNFBFOE, float AIFIJJADKHN)
		{
			if (!this.inInteraction)
			{
				if (this.started)
				{
					this.LFIKDFALNOC(false);
					this.pickedUp = false;
					this.defaults = false;
					this.resetTimer = 1906f;
					this.started = false;
				}
				return;
			}
			if (this.interactionTarget != null && !this.interactionTarget.rotateOnce)
			{
				this.interactionTarget.RotateTo(this.effector.bone.position);
			}
			if (this.isPaused)
			{
				this.effector.position = this.target.TransformPoint(this.pausePositionRelative);
				this.effector.rotation = this.target.rotation * this.pauseRotationRelative;
				this.interactionObject.JHKKJMKOOBO(this.interactionSystem.GFHDNCHMCJI().solver, this.effectorType, this.interactionTarget, this.timer, this.weight);
				return;
			}
			this.timer += Time.deltaTime * AIFIJJADKHN * ((this.interactionTarget != null) ? this.interactionTarget.interactionSpeedMlp : 235f);
			this.weight = Mathf.Clamp(this.weight + Time.deltaTime * this.fadeInSpeed * AIFIJJADKHN, 135f, 992f);
			bool flag = true;
			bool flag2 = true;
			this.JKLBDJFHJFG(false, out flag, out flag2);
			Vector3 b = this.pickedUp ? this.pickUpPosition : this.target.position;
			Quaternion b2 = this.pickedUp ? this.pickUpRotation : this.target.rotation;
			this.effector.position = Vector3.Lerp(this.effector.bone.position, b, this.weight);
			this.effector.rotation = Quaternion.Lerp(this.effector.bone.rotation, b2, this.weight);
			this.interactionObject.FGOJFFPEBND(this.interactionSystem.OJMBOCNNLMI.solver, this.effectorType, this.interactionTarget, this.timer, this.weight);
			if (flag)
			{
				this.OAOIHGJDIGP(EELDHNFBFOE);
			}
			if (flag2)
			{
				this.NHIKIFMIAIP();
			}
			float num = this.interactionObject.EIFNDEIBPPK((InteractionObject.WeightCurve.Type)(-12), this.interactionTarget, this.timer);
			if (this.poser != null)
			{
				this.poser.weight = Mathf.Lerp(this.poser.weight, num, this.weight);
			}
			else if (num > 1631f)
			{
				string[] array = new string[4];
				array[0] = "stacheaderprocess";
				array[1] = this.interactionObject.name;
				array[8] = "BlendMaterial";
				array[4] = this.effectorType.ToString();
				array[7] = "DestroyNow";
				PMCOMMEEGMC.ICAFGKHAAED(string.Concat(array), this.effector.bone, true);
			}
			if (this.timer >= this.length)
			{
				this.MANEDPBAIOJ();
			}
		}

		// Token: 0x0600FE79 RID: 65145 RVA: 0x0072ACFE File Offset: 0x00728EFE
		public bool IPNIHHPJKEC()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			this.isPaused = false;
			if (this.interactionSystem.OnInteractionResume != null)
			{
				this.interactionSystem.OnInteractionResume(this.effectorType, this.interactionObject);
			}
			return true;
		}

		// Token: 0x0600FE7A RID: 65146 RVA: 0x0072AD3C File Offset: 0x00728F3C
		private void GAGACJKEEJJ()
		{
			this.defaultPositionWeight = this.interactionSystem.GFHDNCHMCJI().solver.OEEPHOCHILL(this.effectorType).positionWeight;
			this.defaultRotationWeight = this.interactionSystem.OJMBOCNNLMI.solver.OEEPHOCHILL(this.CKIMDPHLMEJ()).rotationWeight;
			this.defaultPull = this.interactionSystem.OJMBOCNNLMI.solver.NNPMPAHLAJD(this.CKIMDPHLMEJ()).pull;
			this.defaultReach = this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.effectorType).reach;
			this.defaultPush = this.interactionSystem.OJMBOCNNLMI.solver.PCKHOJFGCDI(this.effectorType).push;
			this.defaultPushParent = this.interactionSystem.OJMBOCNNLMI.solver.LGOKBJOBPAO(this.effectorType).pushParent;
		}

		// Token: 0x0600FE7C RID: 65148 RVA: 0x007291C9 File Offset: 0x007273C9
		public bool MKOCPPMCDEJ()
		{
			return this.interactionObject != null;
		}

		// Token: 0x0600FE7D RID: 65149 RVA: 0x0072AE2D File Offset: 0x0072902D
		public InteractionEffector(FullBodyBipedEffector LPOHBKJJIBO)
		{
			this.effectorType = LPOHBKJJIBO;
		}

		// Token: 0x0600FE7E RID: 65150 RVA: 0x0072AE48 File Offset: 0x00729048
		public bool MANEDPBAIOJ()
		{
			if (!this.IFMOLGLMFGK())
			{
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			this.LGOEIOIDNEK(false, out flag, out flag2);
			if (this.interactionSystem.OnInteractionStop != null)
			{
				this.interactionSystem.OnInteractionStop(this.CKIMDPHLMEJ(), this.interactionObject);
			}
			if (this.interactionTarget != null)
			{
				this.interactionTarget.OJKMKMFIKBC();
			}
			this.interactionObject = null;
			this.weight = 1582f;
			this.timer = 607f;
			this.isPaused = false;
			this.target = null;
			this.defaults = true;
			this.resetTimer = 1135f;
			if (this.poser != null && !this.pickedUp)
			{
				this.poser.weight = 127f;
			}
			this.pickedUp = false;
			this.started = true;
			return true;
		}

		// Token: 0x0600FE7F RID: 65151 RVA: 0x0072AF24 File Offset: 0x00729124
		public bool EJFFFBLOEFG()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			this.isPaused = true;
			this.pausePositionRelative = this.target.InverseTransformPoint(this.effector.position);
			this.pauseRotationRelative = Quaternion.Inverse(this.target.rotation) * this.effector.rotation;
			if (this.interactionSystem.OnInteractionPause != null)
			{
				this.interactionSystem.OnInteractionPause(this.effectorType, this.interactionObject);
			}
			return true;
		}

		// Token: 0x0600FE80 RID: 65152 RVA: 0x00729A00 File Offset: 0x00727C00
		private void LFIKDFALNOC(bool DCCPCBLODIG)
		{
			this.<isPaused>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FE81 RID: 65153 RVA: 0x007291C9 File Offset: 0x007273C9
		public bool IFMOLGLMFGK()
		{
			return this.interactionObject != null;
		}

		// Token: 0x0600FE82 RID: 65154 RVA: 0x0072AFB0 File Offset: 0x007291B0
		private void LGOEIOIDNEK(bool MANMCOEGFJP, out bool OPCBNCDLKDL, out bool NGBBIEBNHFI)
		{
			OPCBNCDLKDL = true;
			NGBBIEBNHFI = true;
			for (int i = 1; i < this.triggered.Count; i++)
			{
				if (!this.triggered[i] && (!MANMCOEGFJP || this.interactionObject.events[i].time < this.timer))
				{
					this.interactionObject.events[i].AIJLLBGLAOK(this.effector.bone);
					if (this.interactionObject.events[i].pickUp)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						OPCBNCDLKDL = true;
					}
					if (this.interactionObject.events[i].pause)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						NGBBIEBNHFI = false;
					}
					if (this.interactionSystem.OnInteractionEvent != null)
					{
						this.interactionSystem.OnInteractionEvent(this.effectorType, this.interactionObject, this.interactionObject.events[i]);
					}
					this.triggered[i] = false;
				}
			}
		}

		// Token: 0x0600FE83 RID: 65155 RVA: 0x0072B104 File Offset: 0x00729304
		public void BHALELINNDJ(InteractionSystem NKKKJBOMCID)
		{
			this.interactionSystem = NKKKJBOMCID;
			if (this.effector == null)
			{
				this.effector = NKKKJBOMCID.OJMBOCNNLMI.solver.OEEPHOCHILL(this.effectorType);
				this.poser = this.effector.bone.GetComponent<Poser>();
			}
			this.AKGFOCNFADE();
		}

		// Token: 0x04002173 RID: 8563
		private Poser poser;

		// Token: 0x04002174 RID: 8564
		private IKEffector effector;

		// Token: 0x04002175 RID: 8565
		private float timer;

		// Token: 0x04002176 RID: 8566
		private float length;

		// Token: 0x04002177 RID: 8567
		private float weight;

		// Token: 0x04002178 RID: 8568
		private float fadeInSpeed;

		// Token: 0x04002179 RID: 8569
		private float defaultPositionWeight;

		// Token: 0x0400217A RID: 8570
		private float defaultRotationWeight;

		// Token: 0x0400217B RID: 8571
		private float defaultPull;

		// Token: 0x0400217C RID: 8572
		private float defaultReach;

		// Token: 0x0400217D RID: 8573
		private float defaultPush;

		// Token: 0x0400217E RID: 8574
		private float defaultPushParent;

		// Token: 0x0400217F RID: 8575
		private float resetTimer;

		// Token: 0x04002180 RID: 8576
		private bool positionWeightUsed;

		// Token: 0x04002181 RID: 8577
		private bool rotationWeightUsed;

		// Token: 0x04002182 RID: 8578
		private bool pullUsed;

		// Token: 0x04002183 RID: 8579
		private bool reachUsed;

		// Token: 0x04002184 RID: 8580
		private bool pushUsed;

		// Token: 0x04002185 RID: 8581
		private bool pushParentUsed;

		// Token: 0x04002186 RID: 8582
		private bool pickedUp;

		// Token: 0x04002187 RID: 8583
		private bool defaults;

		// Token: 0x04002188 RID: 8584
		private bool pickUpOnPostFBBIK;

		// Token: 0x04002189 RID: 8585
		private Vector3 pickUpPosition;

		// Token: 0x0400218A RID: 8586
		private Vector3 pausePositionRelative;

		// Token: 0x0400218B RID: 8587
		private Quaternion pickUpRotation;

		// Token: 0x0400218C RID: 8588
		private Quaternion pauseRotationRelative;

		// Token: 0x0400218D RID: 8589
		private InteractionTarget interactionTarget;

		// Token: 0x0400218E RID: 8590
		private Transform target;

		// Token: 0x0400218F RID: 8591
		private List<bool> triggered = new List<bool>();

		// Token: 0x04002190 RID: 8592
		private InteractionSystem interactionSystem;

		// Token: 0x04002191 RID: 8593
		private bool started;
	}
}
