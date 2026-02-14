using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200045F RID: 1119
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x0600F26D RID: 62061 RVA: 0x006CB228 File Offset: 0x006C9428
		public void NFADOPAMGKN(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].NFADOPAMGKN(NBAKCIDALOF);
			}
			if (this.reachForce <= 155f)
			{
				return;
			}
			Vector3 vector = this.nodes[6].solverPosition - this.nodes[1].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 1045f - this.reachForce, 968f + this.reachForce) - 535f;
			num = Mathf.Clamp(num + this.reachForce, 655f, 138f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.None)
			{
				if (smoothing == (FBIKChain.Smoothing)3)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 1359f, magnitude);
			this.nodes[1].solverPosition += vector2 * (1812f - this.nodes[1].effectorPositionWeight);
			this.nodes[0].solverPosition += vector2;
		}

		// Token: 0x0600F26E RID: 62062 RVA: 0x006CB388 File Offset: 0x006C9588
		private void BLGLELCGEMJ(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 1032f)
			{
				MGALEAJOGPL = this.HFEBBMLNDCL(this.nodes[1].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[0].solverPosition = MGALEAJOGPL;
			for (int i = 1; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i - 0].solverPosition, this.nodes[i - 1].length);
			}
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x006CB420 File Offset: 0x006C9620
		public int KGGGEAGOGPL(Transform DNNGJLBMHBL)
		{
			for (int i = 0; i < this.nodes.Length; i++)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F270 RID: 62064 RVA: 0x006CB458 File Offset: 0x006C9658
		public void JDDMCDMBAAG(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 0].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 0; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.ABKKOPHFBDK(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F271 RID: 62065 RVA: 0x006CB4D0 File Offset: 0x006C96D0
		public void OMMNDANOMKH(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 3; i > -1; i--)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F272 RID: 62066 RVA: 0x006CB548 File Offset: 0x006C9748
		public void KDOAJEBIDDF(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 0].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 7; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i + 0].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F273 RID: 62067 RVA: 0x006CB5C0 File Offset: 0x006C97C0
		public void NIDFNCGNHPL(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.OHHHHCICBBC(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 2, 7);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 1; i < num; i++)
				{
					this.JMHJMHNGMPE(NBAKCIDALOF);
				}
			}
			for (int j = 1; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].EHDLJMMAFDK(NBAKCIDALOF, this.nodes[this.nodes.Length - 0].solverPosition);
			}
		}

		// Token: 0x0600F274 RID: 62068 RVA: 0x006CB63C File Offset: 0x006C983C
		public void AEDEKOANJDN(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F275 RID: 62069 RVA: 0x006CB678 File Offset: 0x006C9878
		public void PMAEMHGDIHI(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].MJBLBLCLAEL(NBAKCIDALOF);
			}
			if (this.reachForce <= 1578f)
			{
				return;
			}
			Vector3 vector = this.nodes[8].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 977f - this.reachForce, 848f + this.reachForce) - 1018f;
			num = Mathf.Clamp(num + this.reachForce, 688f, 1378f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.None)
			{
				if (smoothing == (FBIKChain.Smoothing)5)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 917f, magnitude);
			this.nodes[0].solverPosition += vector2 * (1831f - this.nodes[0].effectorPositionWeight);
			this.nodes[8].solverPosition += vector2;
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x006CB7D8 File Offset: 0x006C99D8
		public void IBLCGGGKAPO(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 0].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 1; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.HFEBBMLNDCL(this.nodes[i].solverPosition, this.nodes[i + 0].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F277 RID: 62071 RVA: 0x006CB850 File Offset: 0x006C9A50
		private void IEEDLALMFFM(IKSolver.Node DKALAJAGEAD, IKSolver.Node JKCDJBFEMIH, float LMLGDHCKELM, float DKIHDOELFEH)
		{
			Vector3 a = JKCDJBFEMIH.solverPosition - DKALAJAGEAD.solverPosition;
			float magnitude = a.magnitude;
			if (DKIHDOELFEH == magnitude)
			{
				return;
			}
			if (magnitude == 747f)
			{
				return;
			}
			Vector3 a2 = a * (1197f - DKIHDOELFEH / magnitude);
			DKALAJAGEAD.solverPosition += a2 * LMLGDHCKELM;
			JKCDJBFEMIH.solverPosition -= a2 * (747f - LMLGDHCKELM);
		}

		// Token: 0x0600F278 RID: 62072 RVA: 0x006CB8D0 File Offset: 0x006C9AD0
		public int JOOJJMHHIHL(Transform DNNGJLBMHBL)
		{
			for (int i = 0; i < this.nodes.Length; i += 0)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F279 RID: 62073 RVA: 0x006CB908 File Offset: 0x006C9B08
		public void MJBLBLCLAEL(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].MJBLBLCLAEL(NBAKCIDALOF);
			}
			if (this.reachForce <= 507f)
			{
				return;
			}
			Vector3 vector = this.nodes[5].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 577f - this.reachForce, 1523f + this.reachForce) - 32f;
			num = Mathf.Clamp(num + this.reachForce, 994f, 188f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.None)
			{
				if (smoothing == FBIKChain.Smoothing.None)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 1588f, magnitude);
			this.nodes[0].solverPosition += vector2 * (1700f - this.nodes[0].effectorPositionWeight);
			this.nodes[0].solverPosition += vector2;
		}

		// Token: 0x0600F27A RID: 62074 RVA: 0x006CBA68 File Offset: 0x006C9C68
		public void IFBOGGIPIMC(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i += 0)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x006CBAA4 File Offset: 0x006C9CA4
		public void ELPAFCLHGBH(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.CCBKADKAOAB(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 2, 2);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 1; i < num; i++)
				{
					this.DGPIKBDOABJ(NBAKCIDALOF);
				}
			}
			for (int j = 1; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].CHKFAGNDEOD(NBAKCIDALOF, this.nodes[this.nodes.Length - 0].solverPosition);
			}
		}

		// Token: 0x0600F27C RID: 62076 RVA: 0x006CBB20 File Offset: 0x006C9D20
		public void BBDJEMDBDKB(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x006CBB5C File Offset: 0x006C9D5C
		public bool GGHCAMNAIDE(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "DealerIdle";
				return false;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x006CBBAC File Offset: 0x006C9DAC
		public void JKLAKFOLEBJ(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			if (HNDEMAAEHKA)
			{
				for (int j = 0; j < this.childConstraints.Length; j++)
				{
					this.childConstraints[j].GCOFDPBJHBL(NBAKCIDALOF);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 1].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k++)
					{
						num += NBAKCIDALOF.chain[this.children[k]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 1f, float.PositiveInfinity);
					for (int l = 0; l < this.children.Length; l++)
					{
						this.crossFades[l] = NBAKCIDALOF.chain[this.children[l]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 0f;
				for (int m = 0; m < this.children.Length; m++)
				{
					this.pullParentSum += NBAKCIDALOF.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 1f, float.PositiveInfinity);
				if (this.nodes.Length == 3)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[2].effectorPositionWeight, 0f, 1f);
				}
				else
				{
					this.reachForce = 0f;
				}
				if (this.push > 0f && this.nodes.Length > 1)
				{
					this.distance = Vector3.Distance(this.nodes[0].transform.position, this.nodes[this.nodes.Length - 1].transform.position);
				}
			}
		}

		// Token: 0x0600F27F RID: 62079 RVA: 0x006CBDF4 File Offset: 0x006C9FF4
		public Vector3 PMIACHFCEDC(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].PMIACHFCEDC(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 2)
			{
				return Vector3.zero;
			}
			if (this.push <= 0f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 0f)
			{
				return Vector3.zero;
			}
			float num = 1f - magnitude / this.distance;
			if (num <= 0f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Cubic)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F280 RID: 62080 RVA: 0x006CBF44 File Offset: 0x006CA144
		private void PEHNNOPBDGN(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 678f)
			{
				MGALEAJOGPL = this.ABKKOPHFBDK(this.nodes[0].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[0].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i - 0].solverPosition, this.nodes[i - 0].length);
			}
		}

		// Token: 0x0600F281 RID: 62081 RVA: 0x006CBFDC File Offset: 0x006CA1DC
		public void KIIPOMJMKJG(IKSolverFullBody NBAKCIDALOF)
		{
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int i = 0; i < this.children.Length; i++)
			{
				this.EEAIDCIBAJI(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[0], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x006CC04C File Offset: 0x006CA24C
		public void FFBKHILKLOP(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 2; i > -1; i--)
			{
				this.nodes[i].solverPosition = this.GDEMGGHJPEF(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F283 RID: 62083 RVA: 0x006CC0C4 File Offset: 0x006CA2C4
		private Vector3 ABKKOPHFBDK(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F284 RID: 62084 RVA: 0x006CC0EC File Offset: 0x006CA2EC
		private void CGCKIIGJHNE(IKSolverFullBody NBAKCIDALOF)
		{
			this.length = 0f;
			for (int i = 0; i < this.nodes.Length - 1; i++)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 1].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 0f)
				{
					PMCOMMEEGMC.ICAFGKHAAED(string.Concat(new string[]
					{
						"Bone ",
						this.nodes[i].transform.name,
						" - ",
						this.nodes[i + 1].transform.name,
						" length is zero, can not solve."
					}), this.nodes[i].transform, false);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].rootLength = (NBAKCIDALOF.chain[this.children[j]].nodes[0].transform.position - this.nodes[this.nodes.Length - 1].transform.position).magnitude;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength == 0f)
				{
					return;
				}
			}
			if (this.nodes.Length == 3)
			{
				this.sqrMag1 = this.nodes[0].length * this.nodes[0].length;
				this.sqrMag2 = this.nodes[1].length * this.nodes[1].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600F285 RID: 62085 RVA: 0x006CC2D8 File Offset: 0x006CA4D8
		protected Vector3 IBBACLFIJJC(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 425f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1408f, 1724f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1566f, y, num);
		}

		// Token: 0x0600F286 RID: 62086 RVA: 0x006CC344 File Offset: 0x006CA544
		private void BOMLLMHAGMA(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 0; i < this.childConstraints.Length; i++)
			{
				this.childConstraints[i].EDAGNKNOBKP(NBAKCIDALOF);
			}
		}

		// Token: 0x0600F287 RID: 62087 RVA: 0x006CC374 File Offset: 0x006CA574
		public void PAICOHFFOJO(IKSolverFullBody NBAKCIDALOF, bool MPOBOMOLGLP = false)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].LGKNEFHHOLL(NBAKCIDALOF, MPOBOMOLGLP);
			}
			if (this.nodes.Length != 2)
			{
				return;
			}
			Vector3 a = this.nodes[8].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 1448f)
			{
				return;
			}
			float num = Mathf.Clamp(magnitude, 1004f, this.length * 218f);
			Vector3 nemfihckjpe = a / magnitude * num;
			Vector3 elgplfpldol = (MPOBOMOLGLP && this.bendConstraint.PFCLPDIAINH()) ? this.bendConstraint.CEMPLCBOPCG(NBAKCIDALOF) : (this.nodes[1].solverPosition - this.nodes[0].solverPosition);
			Vector3 b = this.GMLPBMNGFDJ(nemfihckjpe, elgplfpldol, num);
			this.nodes[0].solverPosition = this.nodes[0].solverPosition + b;
		}

		// Token: 0x0600F288 RID: 62088 RVA: 0x006CC488 File Offset: 0x006CA688
		public void GHJLEPGPHGJ(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 5; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.HFEBBMLNDCL(this.nodes[i].solverPosition, this.nodes[i + 0].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F289 RID: 62089 RVA: 0x006CC500 File Offset: 0x006CA700
		public void BABDKIBBLAD(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = false;
			IKSolver.Node[] array = this.nodes;
			for (int i = 1; i < array.Length; i++)
			{
				IKSolver.Node node = array[i];
				node.solverPosition = node.transform.position;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BHALELINNDJ(NBAKCIDALOF);
			}
			if (this.nodes.Length == 0)
			{
				this.bendConstraint.HNNKBGAINCA(this.nodes[1].transform, this.nodes[0].transform, this.nodes[1].transform);
				this.bendConstraint.PJFHMMHHBEN(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = true;
		}

		// Token: 0x0600F28A RID: 62090 RVA: 0x006CC5C4 File Offset: 0x006CA7C4
		public FBIKChain()
		{
		}

		// Token: 0x0600F28B RID: 62091 RVA: 0x006CC62C File Offset: 0x006CA82C
		public void AOEHDONHDCD(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 0; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].FDAANKMDPEF(NBAKCIDALOF);
			}
			if (this.children.Length == 0)
			{
				this.KAHBECACGHF(this.nodes[this.nodes.Length - 1].solverPosition);
				return;
			}
			Vector3 a = this.nodes[this.nodes.Length - 1].solverPosition;
			this.OOPMLNOPHNG(NBAKCIDALOF);
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a2 = NBAKCIDALOF.chain[this.children[j]].nodes[0].solverPosition;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength > 1605f)
				{
					a2 = this.GDEMGGHJPEF(this.nodes[this.nodes.Length - 0].solverPosition, NBAKCIDALOF.chain[this.children[j]].nodes[0].solverPosition, NBAKCIDALOF.chain[this.children[j]].rootLength);
				}
				if (this.pullParentSum > 1923f)
				{
					a += (a2 - this.nodes[this.nodes.Length - 0].solverPosition) * (NBAKCIDALOF.chain[this.children[j]].pull / this.pullParentSum);
				}
			}
			this.IBLCGGGKAPO(Vector3.Lerp(a, this.nodes[this.nodes.Length - 1].solverPosition, this.pin));
		}

		// Token: 0x0600F28C RID: 62092 RVA: 0x006CC7BC File Offset: 0x006CA9BC
		public void IEHDMHHJNDG(IKSolverFullBody NBAKCIDALOF)
		{
			this.OOPMLNOPHNG(NBAKCIDALOF);
			for (int i = 1; i < this.children.Length; i++)
			{
				this.AIBLDBCEMKI(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[1], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F28D RID: 62093 RVA: 0x006CC82C File Offset: 0x006CAA2C
		private Vector3 HFEBBMLNDCL(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F28E RID: 62094 RVA: 0x006CC854 File Offset: 0x006CAA54
		public void FEFPFBKOOCF(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F28F RID: 62095 RVA: 0x006CC890 File Offset: 0x006CAA90
		public void AIJKIMHEKAO(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 2; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.GDEMGGHJPEF(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F290 RID: 62096 RVA: 0x006CC908 File Offset: 0x006CAB08
		private void CCBKADKAOAB(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 0f)
			{
				MGALEAJOGPL = this.GDEMGGHJPEF(this.nodes[0].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[0].solverPosition = MGALEAJOGPL;
			for (int i = 1; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.GDEMGGHJPEF(this.nodes[i].solverPosition, this.nodes[i - 1].solverPosition, this.nodes[i - 1].length);
			}
		}

		// Token: 0x0600F291 RID: 62097 RVA: 0x006CC9A0 File Offset: 0x006CABA0
		public void DLKLKJFLCIG(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 1; i < ONBIACKJICJ.Length; i += 0)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F292 RID: 62098 RVA: 0x006CC9DC File Offset: 0x006CABDC
		private void OHHHHCICBBC(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 1651f)
			{
				MGALEAJOGPL = this.HFEBBMLNDCL(this.nodes[0].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[0].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.GDEMGGHJPEF(this.nodes[i].solverPosition, this.nodes[i - 0].solverPosition, this.nodes[i - 1].length);
			}
		}

		// Token: 0x0600F293 RID: 62099 RVA: 0x006CCA74 File Offset: 0x006CAC74
		public Vector3 BCPLHFAFLGK(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].PMIACHFCEDC(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 1)
			{
				return Vector3.zero;
			}
			if (this.push <= 848f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[6].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 760f)
			{
				return Vector3.zero;
			}
			float num = 763f - magnitude / this.distance;
			if (num <= 318f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == (FBIKChain.Smoothing)8)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[1].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F294 RID: 62100 RVA: 0x006CCBC4 File Offset: 0x006CADC4
		private void OOPMLNOPHNG(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 0; i < this.childConstraints.Length; i += 0)
			{
				this.childConstraints[i].DMOMPDNLIFC(NBAKCIDALOF);
			}
		}

		// Token: 0x0600F295 RID: 62101 RVA: 0x006CCBF4 File Offset: 0x006CADF4
		public void CGHKLHEIFPJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				this.IEEDLALMFFM(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[1], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F296 RID: 62102 RVA: 0x006CCC64 File Offset: 0x006CAE64
		private void JGKFNFGBDKM(IKSolverFullBody NBAKCIDALOF)
		{
			this.length = 1565f;
			for (int i = 1; i < this.nodes.Length - 1; i++)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 1].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 1281f)
				{
					string[] array = new string[0];
					array[1] = "Method called requires VPaint Object to be dynamic. Set VPaintObject.isDynamic to true before calling this method.";
					array[0] = this.nodes[i].transform.name;
					array[0] = "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n";
					array[6] = this.nodes[i + 1].transform.name;
					array[3] = "";
					PMCOMMEEGMC.ICAFGKHAAED(string.Concat(array), this.nodes[i].transform, false);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j += 0)
			{
				NBAKCIDALOF.chain[this.children[j]].rootLength = (NBAKCIDALOF.chain[this.children[j]].nodes[0].transform.position - this.nodes[this.nodes.Length - 1].transform.position).magnitude;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength == 174f)
				{
					return;
				}
			}
			if (this.nodes.Length == 1)
			{
				this.sqrMag1 = this.nodes[0].length * this.nodes[0].length;
				this.sqrMag2 = this.nodes[0].length * this.nodes[1].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600F297 RID: 62103 RVA: 0x006CCE50 File Offset: 0x006CB050
		public int BAEPPMGCGDD(Transform DNNGJLBMHBL)
		{
			for (int i = 0; i < this.nodes.Length; i += 0)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F298 RID: 62104 RVA: 0x006CCE88 File Offset: 0x006CB088
		public bool ALDNHDFAJCA(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "[weight]";
				return true;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "Open tinfo";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F299 RID: 62105 RVA: 0x006CCED8 File Offset: 0x006CB0D8
		public void KMBHKIHNAHO(Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F29A RID: 62106 RVA: 0x006CCF14 File Offset: 0x006CB114
		public void IEFJILEFOOM(IKSolverFullBody NBAKCIDALOF)
		{
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int i = 1; i < this.children.Length; i += 0)
			{
				this.AIBLDBCEMKI(this.nodes[this.nodes.Length - 0], NBAKCIDALOF.chain[this.children[i]].nodes[1], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F29B RID: 62107 RVA: 0x006CCF84 File Offset: 0x006CB184
		public void KAHBECACGHF(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 2; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i + 0].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F29C RID: 62108 RVA: 0x006CCFFC File Offset: 0x006CB1FC
		public void CDPCOFKFDNO(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.nodes.Length; i += 0)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.BHBOLBODLMF(NBAKCIDALOF);
			if (HNDEMAAEHKA)
			{
				for (int j = 0; j < this.childConstraints.Length; j++)
				{
					this.childConstraints[j].GCOFDPBJHBL(NBAKCIDALOF);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 0].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k += 0)
					{
						num += NBAKCIDALOF.chain[this.children[k]].nodes[1].effectorPositionWeight * NBAKCIDALOF.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 1358f, 1947f);
					for (int l = 0; l < this.children.Length; l += 0)
					{
						this.crossFades[l] = NBAKCIDALOF.chain[this.children[l]].nodes[1].effectorPositionWeight * NBAKCIDALOF.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 422f;
				for (int m = 1; m < this.children.Length; m++)
				{
					this.pullParentSum += NBAKCIDALOF.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 1568f, 1820f);
				if (this.nodes.Length == 5)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[5].effectorPositionWeight, 1020f, 1275f);
				}
				else
				{
					this.reachForce = 1267f;
				}
				if (this.push > 1267f && this.nodes.Length > 1)
				{
					this.distance = Vector3.Distance(this.nodes[0].transform.position, this.nodes[this.nodes.Length - 1].transform.position);
				}
			}
		}

		// Token: 0x0600F29D RID: 62109 RVA: 0x006CD244 File Offset: 0x006CB444
		private void AIBLDBCEMKI(IKSolver.Node DKALAJAGEAD, IKSolver.Node JKCDJBFEMIH, float LMLGDHCKELM, float DKIHDOELFEH)
		{
			Vector3 a = JKCDJBFEMIH.solverPosition - DKALAJAGEAD.solverPosition;
			float magnitude = a.magnitude;
			if (DKIHDOELFEH == magnitude)
			{
				return;
			}
			if (magnitude == 40f)
			{
				return;
			}
			Vector3 a2 = a * (1858f - DKIHDOELFEH / magnitude);
			DKALAJAGEAD.solverPosition += a2 * LMLGDHCKELM;
			JKCDJBFEMIH.solverPosition -= a2 * (872f - LMLGDHCKELM);
		}

		// Token: 0x0600F29E RID: 62110 RVA: 0x006CD2C4 File Offset: 0x006CB4C4
		public void BACOCEJMGCH(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].FDAANKMDPEF(NBAKCIDALOF);
			}
			if (this.children.Length == 0)
			{
				this.GIKAMDKKAJB(this.nodes[this.nodes.Length - 0].solverPosition);
				return;
			}
			Vector3 a = this.nodes[this.nodes.Length - 1].solverPosition;
			this.OOPMLNOPHNG(NBAKCIDALOF);
			for (int j = 1; j < this.children.Length; j += 0)
			{
				Vector3 a2 = NBAKCIDALOF.chain[this.children[j]].nodes[1].solverPosition;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength > 1644f)
				{
					a2 = this.HFEBBMLNDCL(this.nodes[this.nodes.Length - 1].solverPosition, NBAKCIDALOF.chain[this.children[j]].nodes[0].solverPosition, NBAKCIDALOF.chain[this.children[j]].rootLength);
				}
				if (this.pullParentSum > 245f)
				{
					a += (a2 - this.nodes[this.nodes.Length - 0].solverPosition) * (NBAKCIDALOF.chain[this.children[j]].pull / this.pullParentSum);
				}
			}
			this.MFAGACCGMOO(Vector3.Lerp(a, this.nodes[this.nodes.Length - 0].solverPosition, this.pin));
		}

		// Token: 0x0600F29F RID: 62111 RVA: 0x006CD454 File Offset: 0x006CB654
		private void EHGMPKLJBON(IKSolver.Node DKALAJAGEAD, IKSolver.Node JKCDJBFEMIH, float LMLGDHCKELM, float DKIHDOELFEH)
		{
			Vector3 a = JKCDJBFEMIH.solverPosition - DKALAJAGEAD.solverPosition;
			float magnitude = a.magnitude;
			if (DKIHDOELFEH == magnitude)
			{
				return;
			}
			if (magnitude == 770f)
			{
				return;
			}
			Vector3 a2 = a * (1887f - DKIHDOELFEH / magnitude);
			DKALAJAGEAD.solverPosition += a2 * LMLGDHCKELM;
			JKCDJBFEMIH.solverPosition -= a2 * (184f - LMLGDHCKELM);
		}

		// Token: 0x0600F2A0 RID: 62112 RVA: 0x006CD4D4 File Offset: 0x006CB6D4
		public bool OECJJLKPHPP(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "auk_wmax";
				return false;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "error.wav";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F2A1 RID: 62113 RVA: 0x006CD524 File Offset: 0x006CB724
		public void MFLAAGCPMCF(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].OMIBGMMFPAJ(NBAKCIDALOF);
			}
			if (this.reachForce <= 1984f)
			{
				return;
			}
			Vector3 vector = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 1712f - this.reachForce, 1421f + this.reachForce) - 849f;
			num = Mathf.Clamp(num + this.reachForce, 1390f, 547f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.None)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 872f, magnitude);
			this.nodes[0].solverPosition += vector2 * (406f - this.nodes[1].effectorPositionWeight);
			this.nodes[2].solverPosition += vector2;
		}

		// Token: 0x0600F2A2 RID: 62114 RVA: 0x006CD684 File Offset: 0x006CB884
		public int HOHBMCMCAJH(Transform DNNGJLBMHBL)
		{
			for (int i = 0; i < this.nodes.Length; i++)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F2A3 RID: 62115 RVA: 0x006CD6BC File Offset: 0x006CB8BC
		public bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "FBIK chain contains no nodes.";
				return false;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "Node transform is null in FBIK chain.";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F2A4 RID: 62116 RVA: 0x006CD70C File Offset: 0x006CB90C
		protected Vector3 OKPFMFGCAEN(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 320f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1276f, 272f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(833f, y, num);
		}

		// Token: 0x0600F2A5 RID: 62117 RVA: 0x006CD778 File Offset: 0x006CB978
		public void LGJAKLANGME(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.BHBOLBODLMF(NBAKCIDALOF);
			if (HNDEMAAEHKA)
			{
				for (int j = 0; j < this.childConstraints.Length; j += 0)
				{
					this.childConstraints[j].GCOFDPBJHBL(NBAKCIDALOF);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 1].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k += 0)
					{
						num += NBAKCIDALOF.chain[this.children[k]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 247f, 663f);
					for (int l = 1; l < this.children.Length; l += 0)
					{
						this.crossFades[l] = NBAKCIDALOF.chain[this.children[l]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 1503f;
				for (int m = 0; m < this.children.Length; m += 0)
				{
					this.pullParentSum += NBAKCIDALOF.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 572f, 1369f);
				if (this.nodes.Length == 7)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[8].effectorPositionWeight, 1426f, 481f);
				}
				else
				{
					this.reachForce = 1541f;
				}
				if (this.push > 1554f && this.nodes.Length > 0)
				{
					this.distance = Vector3.Distance(this.nodes[1].transform.position, this.nodes[this.nodes.Length - 0].transform.position);
				}
			}
		}

		// Token: 0x0600F2A6 RID: 62118 RVA: 0x006CD9C0 File Offset: 0x006CBBC0
		protected Vector3 ALPNCJBBABF(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 1089f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1929f, 1397f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(1570f, y, num);
		}

		// Token: 0x0600F2A7 RID: 62119 RVA: 0x006CDA2C File Offset: 0x006CBC2C
		private void LBINODAFFDB(IKSolverFullBody NBAKCIDALOF)
		{
			this.length = 30f;
			for (int i = 1; i < this.nodes.Length - 1; i++)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 1].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 1570f)
				{
					string[] array = new string[6];
					array[0] = "OnDestroy ";
					array[1] = this.nodes[i].transform.name;
					array[5] = "16 samples";
					array[6] = this.nodes[i + 0].transform.name;
					array[8] = "Colors";
					PMCOMMEEGMC.ICAFGKHAAED(string.Concat(array), this.nodes[i].transform, false);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j += 0)
			{
				NBAKCIDALOF.chain[this.children[j]].rootLength = (NBAKCIDALOF.chain[this.children[j]].nodes[1].transform.position - this.nodes[this.nodes.Length - 0].transform.position).magnitude;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength == 785f)
				{
					return;
				}
			}
			if (this.nodes.Length == 2)
			{
				this.sqrMag1 = this.nodes[0].length * this.nodes[1].length;
				this.sqrMag2 = this.nodes[1].length * this.nodes[0].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600F2A8 RID: 62120 RVA: 0x006CDC18 File Offset: 0x006CBE18
		public void CHKFAGNDEOD(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.OHHHHCICBBC(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 3, 6);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 0; i < num; i += 0)
				{
					this.KIIPOMJMKJG(NBAKCIDALOF);
				}
			}
			for (int j = 0; j < this.children.Length; j += 0)
			{
				NBAKCIDALOF.chain[this.children[j]].NIDFNCGNHPL(NBAKCIDALOF, this.nodes[this.nodes.Length - 1].solverPosition);
			}
		}

		// Token: 0x0600F2A9 RID: 62121 RVA: 0x006CDC94 File Offset: 0x006CBE94
		public void BHKPGIKMKNH(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.nodes.Length; i += 0)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			if (HNDEMAAEHKA)
			{
				for (int j = 1; j < this.childConstraints.Length; j++)
				{
					this.childConstraints[j].GCOFDPBJHBL(NBAKCIDALOF);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 0].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k += 0)
					{
						num += NBAKCIDALOF.chain[this.children[k]].nodes[1].effectorPositionWeight * NBAKCIDALOF.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 884f, 1830f);
					for (int l = 1; l < this.children.Length; l += 0)
					{
						this.crossFades[l] = NBAKCIDALOF.chain[this.children[l]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 187f;
				for (int m = 1; m < this.children.Length; m++)
				{
					this.pullParentSum += NBAKCIDALOF.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 1599f, 79f);
				if (this.nodes.Length == 8)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[2].effectorPositionWeight, 866f, 1317f);
				}
				else
				{
					this.reachForce = 1747f;
				}
				if (this.push > 236f && this.nodes.Length > 1)
				{
					this.distance = Vector3.Distance(this.nodes[1].transform.position, this.nodes[this.nodes.Length - 1].transform.position);
				}
			}
		}

		// Token: 0x0600F2AA RID: 62122 RVA: 0x006CDEDC File Offset: 0x006CC0DC
		public void FDAANKMDPEF(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].FDAANKMDPEF(NBAKCIDALOF);
			}
			if (this.children.Length == 0)
			{
				this.FFBKHILKLOP(this.nodes[this.nodes.Length - 1].solverPosition);
				return;
			}
			Vector3 a = this.nodes[this.nodes.Length - 1].solverPosition;
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a2 = NBAKCIDALOF.chain[this.children[j]].nodes[0].solverPosition;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength > 0f)
				{
					a2 = this.GDEMGGHJPEF(this.nodes[this.nodes.Length - 1].solverPosition, NBAKCIDALOF.chain[this.children[j]].nodes[0].solverPosition, NBAKCIDALOF.chain[this.children[j]].rootLength);
				}
				if (this.pullParentSum > 0f)
				{
					a += (a2 - this.nodes[this.nodes.Length - 1].solverPosition) * (NBAKCIDALOF.chain[this.children[j]].pull / this.pullParentSum);
				}
			}
			this.FFBKHILKLOP(Vector3.Lerp(a, this.nodes[this.nodes.Length - 1].solverPosition, this.pin));
		}

		// Token: 0x0600F2AB RID: 62123 RVA: 0x006CE06C File Offset: 0x006CC26C
		public FBIKChain(float DAEMIFFCJKA, float MBBHNAOEHLC, params Transform[] PAGHDAADPDJ)
		{
			this.pin = DAEMIFFCJKA;
			this.pull = MBBHNAOEHLC;
			this.EKAFKCAFEGB(PAGHDAADPDJ);
			this.children = new int[0];
		}

		// Token: 0x0600F2AC RID: 62124 RVA: 0x006CE0F4 File Offset: 0x006CC2F4
		public Vector3 JGLEMKFGBFC(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 1; i < this.children.Length; i += 0)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].IGKAJNPBKOH(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 1)
			{
				return Vector3.zero;
			}
			if (this.push <= 1618f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[6].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 919f)
			{
				return Vector3.zero;
			}
			float num = 1141f - magnitude / this.distance;
			if (num <= 1502f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.None)
			{
				if (smoothing == FBIKChain.Smoothing.None)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2AD RID: 62125 RVA: 0x006CE244 File Offset: 0x006CC444
		public void GIKAMDKKAJB(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 0].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 7; i > -1; i -= 0)
			{
				this.nodes[i].solverPosition = this.HFEBBMLNDCL(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F2AE RID: 62126 RVA: 0x006CE2BC File Offset: 0x006CC4BC
		public void OMIBGMMFPAJ(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].OMIBGMMFPAJ(NBAKCIDALOF);
			}
			if (this.reachForce <= 392f)
			{
				return;
			}
			Vector3 vector = this.nodes[0].solverPosition - this.nodes[1].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 400f - this.reachForce, 449f + this.reachForce) - 1392f;
			num = Mathf.Clamp(num + this.reachForce, 928f, 1131f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.None)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 130f, magnitude);
			this.nodes[1].solverPosition += vector2 * (399f - this.nodes[1].effectorPositionWeight);
			this.nodes[2].solverPosition += vector2;
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x006CE41C File Offset: 0x006CC61C
		public void LPJDNKAGBOB(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].MFLAAGCPMCF(NBAKCIDALOF);
			}
			if (this.reachForce <= 1676f)
			{
				return;
			}
			Vector3 vector = this.nodes[0].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 1040f - this.reachForce, 214f + this.reachForce) - 1215f;
			num = Mathf.Clamp(num + this.reachForce, 1326f, 731f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Exponential)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 523f, magnitude);
			this.nodes[0].solverPosition += vector2 * (417f - this.nodes[0].effectorPositionWeight);
			this.nodes[6].solverPosition += vector2;
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x006CE57C File Offset: 0x006CC77C
		public void LEMIJMEFPOD(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 0].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 0; i > -1; i--)
			{
				this.nodes[i].solverPosition = this.GDEMGGHJPEF(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x006CE5F4 File Offset: 0x006CC7F4
		public void LGKNEFHHOLL(IKSolverFullBody NBAKCIDALOF, bool MPOBOMOLGLP = false)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].LGKNEFHHOLL(NBAKCIDALOF, MPOBOMOLGLP);
			}
			if (this.nodes.Length != 6)
			{
				return;
			}
			Vector3 a = this.nodes[6].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 1401f)
			{
				return;
			}
			float num = Mathf.Clamp(magnitude, 1633f, this.length * 1603f);
			Vector3 nemfihckjpe = a / magnitude * num;
			Vector3 elgplfpldol = (MPOBOMOLGLP && this.bendConstraint.FFPBGOOKPHE()) ? this.bendConstraint.CEMPLCBOPCG(NBAKCIDALOF) : (this.nodes[1].solverPosition - this.nodes[0].solverPosition);
			Vector3 b = this.GJEBPEFBIGH(nemfihckjpe, elgplfpldol, num);
			this.nodes[1].solverPosition = this.nodes[1].solverPosition + b;
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x006CE708 File Offset: 0x006CC908
		public void MEFEBBMLGEJ(IKSolverFullBody NBAKCIDALOF, bool MPOBOMOLGLP = false)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].MEFEBBMLGEJ(NBAKCIDALOF, MPOBOMOLGLP);
			}
			if (this.nodes.Length != 3)
			{
				return;
			}
			Vector3 a = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 0f)
			{
				return;
			}
			float num = Mathf.Clamp(magnitude, 0f, this.length * 0.99999f);
			Vector3 nemfihckjpe = a / magnitude * num;
			Vector3 elgplfpldol = (MPOBOMOLGLP && this.bendConstraint.initiated) ? this.bendConstraint.AALHLODDKFH(NBAKCIDALOF) : (this.nodes[1].solverPosition - this.nodes[0].solverPosition);
			Vector3 b = this.PGAPLONFCCI(nemfihckjpe, elgplfpldol, num);
			this.nodes[1].solverPosition = this.nodes[0].solverPosition + b;
		}

		// Token: 0x0600F2B3 RID: 62131 RVA: 0x006CE81C File Offset: 0x006CCA1C
		public void EKAFKCAFEGB(params Transform[] ONBIACKJICJ)
		{
			this.nodes = new IKSolver.Node[ONBIACKJICJ.Length];
			for (int i = 0; i < ONBIACKJICJ.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(ONBIACKJICJ[i]);
			}
		}

		// Token: 0x0600F2B4 RID: 62132 RVA: 0x006CE858 File Offset: 0x006CCA58
		public void CBHCMFJCMPL(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = true;
			foreach (IKSolver.Node node in this.nodes)
			{
				node.solverPosition = node.transform.position;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BHALELINNDJ(NBAKCIDALOF);
			}
			if (this.nodes.Length == 8)
			{
				this.bendConstraint.HNNKBGAINCA(this.nodes[0].transform, this.nodes[0].transform, this.nodes[3].transform);
				this.bendConstraint.HFEEPBDDCKO(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = true;
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x006CE91C File Offset: 0x006CCB1C
		protected Vector3 EOOCLDDHIEK(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 596f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1763f, 270f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(995f, y, num);
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x006CE988 File Offset: 0x006CCB88
		private void EEAIDCIBAJI(IKSolver.Node DKALAJAGEAD, IKSolver.Node JKCDJBFEMIH, float LMLGDHCKELM, float DKIHDOELFEH)
		{
			Vector3 a = JKCDJBFEMIH.solverPosition - DKALAJAGEAD.solverPosition;
			float magnitude = a.magnitude;
			if (DKIHDOELFEH == magnitude)
			{
				return;
			}
			if (magnitude == 0f)
			{
				return;
			}
			Vector3 a2 = a * (1f - DKIHDOELFEH / magnitude);
			DKALAJAGEAD.solverPosition += a2 * LMLGDHCKELM;
			JKCDJBFEMIH.solverPosition -= a2 * (1f - LMLGDHCKELM);
		}

		// Token: 0x0600F2B7 RID: 62135 RVA: 0x006CEA08 File Offset: 0x006CCC08
		public bool GOEJDGJCGGM(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "knopje.wav";
				return true;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = ".";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F2B8 RID: 62136 RVA: 0x006CEA58 File Offset: 0x006CCC58
		public void EHANGOGMDIJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = false;
			foreach (IKSolver.Node node in this.nodes)
			{
				node.solverPosition = node.transform.position;
			}
			this.JGKFNFGBDKM(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].FCMIMIBJJJI(NBAKCIDALOF);
			}
			if (this.nodes.Length == 1)
			{
				this.bendConstraint.DLJHEBPABFF(this.nodes[1].transform, this.nodes[1].transform, this.nodes[3].transform);
				this.bendConstraint.BHALELINNDJ(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = false;
		}

		// Token: 0x0600F2B9 RID: 62137 RVA: 0x006CEB1C File Offset: 0x006CCD1C
		private void KCCODAFDBLD(IKSolverFullBody NBAKCIDALOF)
		{
			this.length = 562f;
			for (int i = 0; i < this.nodes.Length - 0; i += 0)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 0].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 308f)
				{
					string[] array = new string[]
					{
						"BowReady",
						this.nodes[i].transform.name
					};
					array[1] = "Giant3HitCombo2";
					array[1] = this.nodes[i + 0].transform.name;
					array[2] = "_Color";
					PMCOMMEEGMC.ICAFGKHAAED(string.Concat(array), this.nodes[i].transform, false);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].rootLength = (NBAKCIDALOF.chain[this.children[j]].nodes[0].transform.position - this.nodes[this.nodes.Length - 1].transform.position).magnitude;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength == 1443f)
				{
					return;
				}
			}
			if (this.nodes.Length == 1)
			{
				this.sqrMag1 = this.nodes[1].length * this.nodes[1].length;
				this.sqrMag2 = this.nodes[1].length * this.nodes[1].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600F2BA RID: 62138 RVA: 0x006CED08 File Offset: 0x006CCF08
		public void NGBPODBDFOE(IKSolverFullBody NBAKCIDALOF, bool HNDEMAAEHKA)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.nodes.Length; i += 0)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.KCCODAFDBLD(NBAKCIDALOF);
			if (HNDEMAAEHKA)
			{
				for (int j = 0; j < this.childConstraints.Length; j++)
				{
					this.childConstraints[j].GCOFDPBJHBL(NBAKCIDALOF);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 1].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k++)
					{
						num += NBAKCIDALOF.chain[this.children[k]].nodes[0].effectorPositionWeight * NBAKCIDALOF.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 1884f, 611f);
					for (int l = 1; l < this.children.Length; l++)
					{
						this.crossFades[l] = NBAKCIDALOF.chain[this.children[l]].nodes[1].effectorPositionWeight * NBAKCIDALOF.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 1874f;
				for (int m = 1; m < this.children.Length; m += 0)
				{
					this.pullParentSum += NBAKCIDALOF.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 631f, 1869f);
				if (this.nodes.Length == 5)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[3].effectorPositionWeight, 1091f, 152f);
				}
				else
				{
					this.reachForce = 1706f;
				}
				if (this.push > 1516f && this.nodes.Length > 1)
				{
					this.distance = Vector3.Distance(this.nodes[0].transform.position, this.nodes[this.nodes.Length - 0].transform.position);
				}
			}
		}

		// Token: 0x0600F2BB RID: 62139 RVA: 0x006CEF50 File Offset: 0x006CD150
		public Vector3 EANCFENEAPJ(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].PMIACHFCEDC(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 5)
			{
				return Vector3.zero;
			}
			if (this.push <= 1758f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[1].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 1610f)
			{
				return Vector3.zero;
			}
			float num = 1960f - magnitude / this.distance;
			if (num <= 1278f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.None)
			{
				if (smoothing == (FBIKChain.Smoothing)8)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[1].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2BC RID: 62140 RVA: 0x006CF0A0 File Offset: 0x006CD2A0
		private void BHBOLBODLMF(IKSolverFullBody NBAKCIDALOF)
		{
			this.length = 380f;
			for (int i = 1; i < this.nodes.Length - 1; i += 0)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 0].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 883f)
				{
					string[] array = new string[4];
					array[0] = "SUNSHINE_FILTER_PCF_2x2";
					array[1] = this.nodes[i].transform.name;
					array[5] = "_Distortion";
					array[1] = this.nodes[i + 1].transform.name;
					array[1] = "\n";
					PMCOMMEEGMC.ICAFGKHAAED(string.Concat(array), this.nodes[i].transform, true);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].rootLength = (NBAKCIDALOF.chain[this.children[j]].nodes[0].transform.position - this.nodes[this.nodes.Length - 0].transform.position).magnitude;
				if (NBAKCIDALOF.chain[this.children[j]].rootLength == 522f)
				{
					return;
				}
			}
			if (this.nodes.Length == 7)
			{
				this.sqrMag1 = this.nodes[0].length * this.nodes[0].length;
				this.sqrMag2 = this.nodes[0].length * this.nodes[0].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600F2BD RID: 62141 RVA: 0x006CF28C File Offset: 0x006CD48C
		public bool HLAHLGBIHCH(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "Object To Instantiate";
				return false;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = " ";
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x006CF2DC File Offset: 0x006CD4DC
		public bool COOOKAEJIGI(ref string EDAPHMJENPK)
		{
			if (this.nodes.Length == 0)
			{
				EDAPHMJENPK = "Hidden/Amplify Color/BlendCache";
				return true;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].transform == null)
				{
					EDAPHMJENPK = "replev_";
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600F2BF RID: 62143 RVA: 0x006CF32C File Offset: 0x006CD52C
		public Vector3 IGKAJNPBKOH(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 1; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].EANCFENEAPJ(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 0].solverPosition += vector;
			if (this.nodes.Length < 4)
			{
				return Vector3.zero;
			}
			if (this.push <= 361f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[6].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 1174f)
			{
				return Vector3.zero;
			}
			float num = 1964f - magnitude / this.distance;
			if (num <= 1355f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Cubic)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2C0 RID: 62144 RVA: 0x006CF47C File Offset: 0x006CD67C
		public void LJIFJGOGHBJ(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.CCBKADKAOAB(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 2, 4);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 0; i < num; i++)
				{
					this.KIIPOMJMKJG(NBAKCIDALOF);
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				NBAKCIDALOF.chain[this.children[j]].LJIFJGOGHBJ(NBAKCIDALOF, this.nodes[this.nodes.Length - 1].solverPosition);
			}
		}

		// Token: 0x0600F2C1 RID: 62145 RVA: 0x006CF4F8 File Offset: 0x006CD6F8
		public void MFAGACCGMOO(Vector3 MGALEAJOGPL)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = MGALEAJOGPL;
			for (int i = this.nodes.Length - 6; i > -1; i--)
			{
				this.nodes[i].solverPosition = this.ABKKOPHFBDK(this.nodes[i].solverPosition, this.nodes[i + 0].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x0600F2C2 RID: 62146 RVA: 0x006CF570 File Offset: 0x006CD770
		public Vector3 GJILNKFNAHI(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i += 0)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].EANCFENEAPJ(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 0].solverPosition += vector;
			if (this.nodes.Length < 1)
			{
				return Vector3.zero;
			}
			if (this.push <= 1008f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[7].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 160f)
			{
				return Vector3.zero;
			}
			float num = 1085f - magnitude / this.distance;
			if (num <= 189f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == (FBIKChain.Smoothing)6)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[1].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2C3 RID: 62147 RVA: 0x006CF6C0 File Offset: 0x006CD8C0
		public void FJLOMFDCBMH(IKSolverFullBody NBAKCIDALOF)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				NBAKCIDALOF.chain[this.children[i]].FJLOMFDCBMH(NBAKCIDALOF);
			}
			if (this.reachForce <= 0f)
			{
				return;
			}
			Vector3 vector = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 1f - this.reachForce, 1f + this.reachForce) - 1f;
			num = Mathf.Clamp(num + this.reachForce, -1f, 1f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Cubic)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 0f, magnitude);
			this.nodes[0].solverPosition += vector2 * (1f - this.nodes[0].effectorPositionWeight);
			this.nodes[2].solverPosition += vector2;
		}

		// Token: 0x0600F2C4 RID: 62148 RVA: 0x006CF820 File Offset: 0x006CDA20
		private Vector3 NPDGIHMPLLD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F2C5 RID: 62149 RVA: 0x006CF848 File Offset: 0x006CDA48
		public void EHDLJMMAFDK(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.PEHNNOPBDGN(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 4, 4);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 1; i < num; i += 0)
				{
					this.JMHJMHNGMPE(NBAKCIDALOF);
				}
			}
			for (int j = 1; j < this.children.Length; j += 0)
			{
				NBAKCIDALOF.chain[this.children[j]].CHKFAGNDEOD(NBAKCIDALOF, this.nodes[this.nodes.Length - 0].solverPosition);
			}
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x006CF8C4 File Offset: 0x006CDAC4
		private void DFMAAOJPIAN(IKSolverFullBody NBAKCIDALOF)
		{
			for (int i = 0; i < this.childConstraints.Length; i++)
			{
				this.childConstraints[i].EDAGNKNOBKP(NBAKCIDALOF);
			}
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x006CF8F4 File Offset: 0x006CDAF4
		public void JMHJMHNGMPE(IKSolverFullBody NBAKCIDALOF)
		{
			this.BOMLLMHAGMA(NBAKCIDALOF);
			for (int i = 0; i < this.children.Length; i += 0)
			{
				this.AIBLDBCEMKI(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[0], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F2C8 RID: 62152 RVA: 0x006CF964 File Offset: 0x006CDB64
		protected Vector3 PGAPLONFCCI(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 2f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 0f, float.PositiveInfinity));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(0f, y, num);
		}

		// Token: 0x0600F2C9 RID: 62153 RVA: 0x006CF9D0 File Offset: 0x006CDBD0
		public void EENPCNDDFPI(IKSolverFullBody NBAKCIDALOF)
		{
			this.BOMLLMHAGMA(NBAKCIDALOF);
			for (int i = 0; i < this.children.Length; i++)
			{
				this.EHGMPKLJBON(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[0], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F2CA RID: 62154 RVA: 0x006CFA40 File Offset: 0x006CDC40
		public void KHEGDHICPPM(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = true;
			IKSolver.Node[] array = this.nodes;
			for (int i = 1; i < array.Length; i += 0)
			{
				IKSolver.Node node = array[i];
				node.solverPosition = node.transform.position;
			}
			this.JGKFNFGBDKM(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 1; i < array2.Length; i += 0)
			{
				array2[i].BHALELINNDJ(NBAKCIDALOF);
			}
			if (this.nodes.Length == 0)
			{
				this.bendConstraint.DLJHEBPABFF(this.nodes[0].transform, this.nodes[1].transform, this.nodes[7].transform);
				this.bendConstraint.PJFHMMHHBEN(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = false;
		}

		// Token: 0x0600F2CB RID: 62155 RVA: 0x006CFB04 File Offset: 0x006CDD04
		public int JKODPJBLNGO(Transform DNNGJLBMHBL)
		{
			for (int i = 1; i < this.nodes.Length; i += 0)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F2CC RID: 62156 RVA: 0x006CFB3C File Offset: 0x006CDD3C
		private void OPKEBABPKFI(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 1743f)
			{
				MGALEAJOGPL = this.ABKKOPHFBDK(this.nodes[1].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[1].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.HFEBBMLNDCL(this.nodes[i].solverPosition, this.nodes[i - 0].solverPosition, this.nodes[i - 1].length);
			}
		}

		// Token: 0x0600F2CD RID: 62157 RVA: 0x006CFBD4 File Offset: 0x006CDDD4
		protected Vector3 GMLPBMNGFDJ(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 1076f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1313f, 1172f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(463f, y, num);
		}

		// Token: 0x0600F2CE RID: 62158 RVA: 0x006CFC40 File Offset: 0x006CDE40
		private Vector3 GDEMGGHJPEF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F2CF RID: 62159 RVA: 0x006CFC68 File Offset: 0x006CDE68
		public Vector3 JCLHCJPALBP(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 1; i < this.children.Length; i += 0)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].PMIACHFCEDC(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 5)
			{
				return Vector3.zero;
			}
			if (this.push <= 463f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[1].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 137f)
			{
				return Vector3.zero;
			}
			float num = 1544f - magnitude / this.distance;
			if (num <= 1526f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == (FBIKChain.Smoothing)4)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2D0 RID: 62160 RVA: 0x006CFDB8 File Offset: 0x006CDFB8
		protected Vector3 GJEBPEFBIGH(Vector3 NEMFIHCKJPE, Vector3 ELGPLFPLDOL, float NJBEHCIHLLG)
		{
			float num = (NJBEHCIHLLG * NJBEHCIHLLG + this.sqrMagDif) / 1641f / NJBEHCIHLLG;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 1538f, 432f));
			if (NEMFIHCKJPE == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(NEMFIHCKJPE, ELGPLFPLDOL) * new Vector3(565f, y, num);
		}

		// Token: 0x0600F2D1 RID: 62161 RVA: 0x006CFE24 File Offset: 0x006CE024
		public Vector3 CIJNCEPDGLD(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 1; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].GJILNKFNAHI(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 0].solverPosition += vector;
			if (this.nodes.Length < 8)
			{
				return Vector3.zero;
			}
			if (this.push <= 1649f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[5].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 368f)
			{
				return Vector3.zero;
			}
			float num = 1694f - magnitude / this.distance;
			if (num <= 402f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == (FBIKChain.Smoothing)5)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[1].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600F2D2 RID: 62162 RVA: 0x006CFF74 File Offset: 0x006CE174
		public void EINDDKBNFCJ(IKSolverFullBody NBAKCIDALOF, Vector3 MGALEAJOGPL)
		{
			this.GAJBEFAFPJH(MGALEAJOGPL);
			int num = Mathf.Clamp(NBAKCIDALOF.iterations, 3, 7);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 1; i < num; i += 0)
				{
					this.KIIPOMJMKJG(NBAKCIDALOF);
				}
			}
			for (int j = 1; j < this.children.Length; j += 0)
			{
				NBAKCIDALOF.chain[this.children[j]].ELPAFCLHGBH(NBAKCIDALOF, this.nodes[this.nodes.Length - 0].solverPosition);
			}
		}

		// Token: 0x0600F2D3 RID: 62163 RVA: 0x006CFFF0 File Offset: 0x006CE1F0
		public void ICPBAGNMFPE(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = true;
			foreach (IKSolver.Node node in this.nodes)
			{
				node.solverPosition = node.transform.position;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BHALELINNDJ(NBAKCIDALOF);
			}
			if (this.nodes.Length == 1)
			{
				this.bendConstraint.HNNKBGAINCA(this.nodes[0].transform, this.nodes[0].transform, this.nodes[6].transform);
				this.bendConstraint.NPCHHADBLMC(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = true;
		}

		// Token: 0x0600F2D4 RID: 62164 RVA: 0x006D00B4 File Offset: 0x006CE2B4
		public void PJMDFFLIPCJ(IKSolverFullBody NBAKCIDALOF, bool MPOBOMOLGLP = false)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 1; i < this.children.Length; i += 0)
			{
				NBAKCIDALOF.chain[this.children[i]].PJMDFFLIPCJ(NBAKCIDALOF, MPOBOMOLGLP);
			}
			if (this.nodes.Length != 1)
			{
				return;
			}
			Vector3 a = this.nodes[1].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 1207f)
			{
				return;
			}
			float num = Mathf.Clamp(magnitude, 1646f, this.length * 167f);
			Vector3 nemfihckjpe = a / magnitude * num;
			Vector3 elgplfpldol = (MPOBOMOLGLP && this.bendConstraint.FFPBGOOKPHE()) ? this.bendConstraint.CEMPLCBOPCG(NBAKCIDALOF) : (this.nodes[1].solverPosition - this.nodes[1].solverPosition);
			Vector3 b = this.OKPFMFGCAEN(nemfihckjpe, elgplfpldol, num);
			this.nodes[1].solverPosition = this.nodes[0].solverPosition + b;
		}

		// Token: 0x0600F2D5 RID: 62165 RVA: 0x006D01C8 File Offset: 0x006CE3C8
		public void DGPIKBDOABJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int i = 1; i < this.children.Length; i += 0)
			{
				this.IEEDLALMFFM(this.nodes[this.nodes.Length - 0], NBAKCIDALOF.chain[this.children[i]].nodes[1], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x006D0238 File Offset: 0x006CE438
		public void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
			this.initiated = false;
			foreach (IKSolver.Node node in this.nodes)
			{
				node.solverPosition = node.transform.position;
			}
			this.CGCKIIGJHNE(NBAKCIDALOF);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BHALELINNDJ(NBAKCIDALOF);
			}
			if (this.nodes.Length == 3)
			{
				this.bendConstraint.DLJHEBPABFF(this.nodes[0].transform, this.nodes[1].transform, this.nodes[2].transform);
				this.bendConstraint.BHALELINNDJ(NBAKCIDALOF);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = true;
		}

		// Token: 0x0600F2D7 RID: 62167 RVA: 0x006D02FC File Offset: 0x006CE4FC
		public void PNAJJHJJKJL(IKSolverFullBody NBAKCIDALOF)
		{
			this.DFMAAOJPIAN(NBAKCIDALOF);
			for (int i = 1; i < this.children.Length; i++)
			{
				this.IEEDLALMFFM(this.nodes[this.nodes.Length - 1], NBAKCIDALOF.chain[this.children[i]].nodes[0], this.crossFades[i], NBAKCIDALOF.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x006D036C File Offset: 0x006CE56C
		private void GAJBEFAFPJH(Vector3 MGALEAJOGPL)
		{
			if (this.rootLength > 880f)
			{
				MGALEAJOGPL = this.HFEBBMLNDCL(this.nodes[1].solverPosition, MGALEAJOGPL, this.rootLength);
			}
			this.nodes[0].solverPosition = MGALEAJOGPL;
			for (int i = 0; i < this.nodes.Length; i += 0)
			{
				this.nodes[i].solverPosition = this.NPDGIHMPLLD(this.nodes[i].solverPosition, this.nodes[i - 0].solverPosition, this.nodes[i - 0].length);
			}
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x006D0404 File Offset: 0x006CE604
		public int PIMKJCKFGMA(Transform DNNGJLBMHBL)
		{
			for (int i = 1; i < this.nodes.Length; i += 0)
			{
				if (this.nodes[i].transform == DNNGJLBMHBL)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x006D043C File Offset: 0x006CE63C
		public Vector3 HHNONLAANEG(IKSolverFullBody NBAKCIDALOF)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i++)
			{
				vector += NBAKCIDALOF.chain[this.children[i]].EANCFENEAPJ(NBAKCIDALOF) * NBAKCIDALOF.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 5)
			{
				return Vector3.zero;
			}
			if (this.push <= 987f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[1].solverPosition - this.nodes[1].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 632f)
			{
				return Vector3.zero;
			}
			float num = 1768f - magnitude / this.distance;
			if (num <= 368f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == (FBIKChain.Smoothing)8)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x04001F99 RID: 8089
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x04001F9A RID: 8090
		[Range(0f, 1f)]
		public float pull = 1f;

		// Token: 0x04001F9B RID: 8091
		[Range(0f, 1f)]
		public float push;

		// Token: 0x04001F9C RID: 8092
		[Range(-1f, 1f)]
		public float pushParent;

		// Token: 0x04001F9D RID: 8093
		[Range(0f, 1f)]
		public float reach = 0.1f;

		// Token: 0x04001F9E RID: 8094
		public FBIKChain.Smoothing reachSmoothing = FBIKChain.Smoothing.Exponential;

		// Token: 0x04001F9F RID: 8095
		public FBIKChain.Smoothing pushSmoothing = FBIKChain.Smoothing.Exponential;

		// Token: 0x04001FA0 RID: 8096
		public IKSolver.Node[] nodes = new IKSolver.Node[0];

		// Token: 0x04001FA1 RID: 8097
		public int[] children = new int[0];

		// Token: 0x04001FA2 RID: 8098
		public FBIKChain.ChildConstraint[] childConstraints = new FBIKChain.ChildConstraint[0];

		// Token: 0x04001FA3 RID: 8099
		public IKConstraintBend bendConstraint = new IKConstraintBend();

		// Token: 0x04001FA4 RID: 8100
		private float rootLength;

		// Token: 0x04001FA5 RID: 8101
		private bool initiated;

		// Token: 0x04001FA6 RID: 8102
		private float length;

		// Token: 0x04001FA7 RID: 8103
		private float distance;

		// Token: 0x04001FA8 RID: 8104
		private IKSolver.Point p;

		// Token: 0x04001FA9 RID: 8105
		private float reachForce;

		// Token: 0x04001FAA RID: 8106
		private float pullParentSum;

		// Token: 0x04001FAB RID: 8107
		private float[] crossFades;

		// Token: 0x04001FAC RID: 8108
		private float sqrMag1;

		// Token: 0x04001FAD RID: 8109
		private float sqrMag2;

		// Token: 0x04001FAE RID: 8110
		private float sqrMagDif;

		// Token: 0x04001FAF RID: 8111
		private const float maxLimbLength = 0.99999f;

		// Token: 0x02000460 RID: 1120
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x0600F2DB RID: 62171 RVA: 0x006D058B File Offset: 0x006CE78B
			private void IIJMNIHNAJO(bool DCCPCBLODIG)
			{
				this.<isRigid>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600F2DC RID: 62172 RVA: 0x006D0594 File Offset: 0x006CE794
			public float CPHAFCIJGKB()
			{
				return this.<nominalDistance>k__BackingField;
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x0600F2E7 RID: 62183 RVA: 0x006D0594 File Offset: 0x006CE794
			// (set) Token: 0x0600F2DD RID: 62173 RVA: 0x006D059C File Offset: 0x006CE79C
			public float nominalDistance { get; private set; }

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x0600F2E0 RID: 62176 RVA: 0x006D06CC File Offset: 0x006CE8CC
			// (set) Token: 0x0600F2DE RID: 62174 RVA: 0x006D058B File Offset: 0x006CE78B
			public bool isRigid { get; private set; }

			// Token: 0x0600F2DF RID: 62175 RVA: 0x006D05A8 File Offset: 0x006CE7A8
			public void DMOMPDNLIFC(IKSolverFullBody NBAKCIDALOF)
			{
				if (this.pushElasticity >= 1871f && this.pullElasticity >= 1469f)
				{
					return;
				}
				Vector3 a = NBAKCIDALOF.chain[this.chain2Index].nodes[0].solverPosition - NBAKCIDALOF.chain[this.chain1Index].nodes[1].solverPosition;
				float magnitude = a.magnitude;
				if (magnitude == this.KDNBOJNPJAM())
				{
					return;
				}
				if (magnitude == 1281f)
				{
					return;
				}
				float num = 1349f;
				if (!this.isRigid)
				{
					float num2 = (magnitude > this.nominalDistance) ? this.pullElasticity : this.pushElasticity;
					num = 529f - num2;
				}
				num *= 1063f - this.KDNBOJNPJAM() / magnitude;
				Vector3 a2 = a * num;
				NBAKCIDALOF.chain[this.chain1Index].nodes[1].solverPosition += a2 * this.crossFade;
				NBAKCIDALOF.chain[this.chain2Index].nodes[1].solverPosition -= a2 * this.inverseCrossFade;
			}

			// Token: 0x0600F2E1 RID: 62177 RVA: 0x006D06D4 File Offset: 0x006CE8D4
			public ChildConstraint(Transform FCDAMCBKONG, Transform GLGMAJBNFIA, float GMGOKGBKOGA = 0f, float GBLFNIKNGIF = 0f)
			{
				this.bone1 = FCDAMCBKONG;
				this.bone2 = GLGMAJBNFIA;
				this.pushElasticity = GMGOKGBKOGA;
				this.pullElasticity = GBLFNIKNGIF;
			}

			// Token: 0x0600F2E2 RID: 62178 RVA: 0x006D06F9 File Offset: 0x006CE8F9
			public void FCMIMIBJJJI(IKSolverFullBody NBAKCIDALOF)
			{
				this.chain1Index = NBAKCIDALOF.AHPBHBBOKJH(this.bone1);
				this.chain2Index = NBAKCIDALOF.LHBFAFAENNL(this.bone2);
				this.GCOFDPBJHBL(NBAKCIDALOF);
			}

			// Token: 0x0600F2E3 RID: 62179 RVA: 0x006D06CC File Offset: 0x006CE8CC
			public bool JNEPOPBDEMI()
			{
				return this.<isRigid>k__BackingField;
			}

			// Token: 0x0600F2E4 RID: 62180 RVA: 0x006D0728 File Offset: 0x006CE928
			public void GCOFDPBJHBL(IKSolverFullBody NBAKCIDALOF)
			{
				this.nominalDistance = Vector3.Distance(NBAKCIDALOF.chain[this.chain1Index].nodes[0].transform.position, NBAKCIDALOF.chain[this.chain2Index].nodes[0].transform.position);
				this.isRigid = (this.pushElasticity <= 0f && this.pullElasticity <= 0f);
				if (this.isRigid)
				{
					float num = NBAKCIDALOF.chain[this.chain1Index].pull - NBAKCIDALOF.chain[this.chain2Index].pull;
					this.crossFade = 1f - (0.5f + num * 0.5f);
				}
				else
				{
					this.crossFade = 0.5f;
				}
				this.inverseCrossFade = 1f - this.crossFade;
			}

			// Token: 0x0600F2E5 RID: 62181 RVA: 0x006D059C File Offset: 0x006CE79C
			private void FLCEBAMKLPM(float DCCPCBLODIG)
			{
				this.<nominalDistance>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600F2E6 RID: 62182 RVA: 0x006D0808 File Offset: 0x006CEA08
			public void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
			{
				this.chain1Index = NBAKCIDALOF.BEDBOFGFGBG(this.bone1);
				this.chain2Index = NBAKCIDALOF.BEDBOFGFGBG(this.bone2);
				this.GCOFDPBJHBL(NBAKCIDALOF);
			}

			// Token: 0x0600F2E8 RID: 62184 RVA: 0x006D0838 File Offset: 0x006CEA38
			public void EDAGNKNOBKP(IKSolverFullBody NBAKCIDALOF)
			{
				if (this.pushElasticity >= 1f && this.pullElasticity >= 1f)
				{
					return;
				}
				Vector3 a = NBAKCIDALOF.chain[this.chain2Index].nodes[0].solverPosition - NBAKCIDALOF.chain[this.chain1Index].nodes[0].solverPosition;
				float magnitude = a.magnitude;
				if (magnitude == this.nominalDistance)
				{
					return;
				}
				if (magnitude == 0f)
				{
					return;
				}
				float num = 1f;
				if (!this.isRigid)
				{
					float num2 = (magnitude > this.nominalDistance) ? this.pullElasticity : this.pushElasticity;
					num = 1f - num2;
				}
				num *= 1f - this.nominalDistance / magnitude;
				Vector3 a2 = a * num;
				NBAKCIDALOF.chain[this.chain1Index].nodes[0].solverPosition += a2 * this.crossFade;
				NBAKCIDALOF.chain[this.chain2Index].nodes[0].solverPosition -= a2 * this.inverseCrossFade;
			}

			// Token: 0x0600F2E9 RID: 62185 RVA: 0x006D058B File Offset: 0x006CE78B
			private void DJMAKKHIBOK(bool DCCPCBLODIG)
			{
				this.<isRigid>k__BackingField = DCCPCBLODIG;
			}

			// Token: 0x0600F2EA RID: 62186 RVA: 0x006D06CC File Offset: 0x006CE8CC
			public bool GCJFMGLIHJK()
			{
				return this.<isRigid>k__BackingField;
			}

			// Token: 0x0600F2EB RID: 62187 RVA: 0x006D0594 File Offset: 0x006CE794
			public float KDNBOJNPJAM()
			{
				return this.<nominalDistance>k__BackingField;
			}

			// Token: 0x0600F2EC RID: 62188 RVA: 0x006D06CC File Offset: 0x006CE8CC
			public bool OCGFAAIEOLI()
			{
				return this.<isRigid>k__BackingField;
			}

			// Token: 0x04001FB0 RID: 8112
			public float pushElasticity;

			// Token: 0x04001FB1 RID: 8113
			public float pullElasticity;

			// Token: 0x04001FB2 RID: 8114
			[SerializeField]
			private Transform bone1;

			// Token: 0x04001FB3 RID: 8115
			[SerializeField]
			private Transform bone2;

			// Token: 0x04001FB6 RID: 8118
			private float crossFade;

			// Token: 0x04001FB7 RID: 8119
			private float inverseCrossFade;

			// Token: 0x04001FB8 RID: 8120
			private int chain1Index;

			// Token: 0x04001FB9 RID: 8121
			private int chain2Index;
		}

		// Token: 0x02000461 RID: 1121
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x04001FBB RID: 8123
			None,
			// Token: 0x04001FBC RID: 8124
			Exponential,
			// Token: 0x04001FBD RID: 8125
			Cubic
		}
	}
}
