using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200045D RID: 1117
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x0600F1EA RID: 61930 RVA: 0x006C406C File Offset: 0x006C226C
		private void DKBGMIPBHNM()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.GHJPHHDKNAG));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.CHAPIDFDNLC));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.JFFLPINGEND));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F1EB RID: 61931 RVA: 0x006C4190 File Offset: 0x006C2390
		private void CHAPIDFDNLC(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.IHNLMAHAEOK(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.PIFADADCKHC(this.ik.solver.LLFAEIGHHBK(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.FKKHCIDIBLF().positionOffset);
			this.EJDJIOLHAEG(this.ik.solver.GPLFMHLNFLL(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.IDMNHNDKPGM(this.ik.solver.NEKNDGMNDHG(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.EOHLDGNBFGG());
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.GDFNMMJIEPM(this.ik.solver.EBCFAJOMOFB(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.IMBHIAODACN().positionOffset);
			this.PIFADADCKHC(this.ik.solver.ECCGBKELAOH(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.FIDGAGDBPCG().positionOffset);
		}

		// Token: 0x0600F1EC RID: 61932 RVA: 0x006C44DC File Offset: 0x006C26DC
		private void ONHIIIICDHC(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.AIIPIPAOFPF(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.IOOGCGIMNJL(this.ik.solver.ELPKPOGKHOP(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.FPHNAAFKGEP(this.ik.solver.rightShoulderEffector, this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.DMPDLFPCDFO().positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.IDMNHNDKPGM(this.ik.solver.HJPCHINGJCN(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.EOHLDGNBFGG());
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.GDFNMMJIEPM(this.ik.solver.CLLKAEEHHIP(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.IMBHIAODACN().positionOffset);
			this.IOOGCGIMNJL(this.ik.solver.ECCGBKELAOH(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.ECCGBKELAOH().positionOffset);
		}

		// Token: 0x0600F1ED RID: 61933 RVA: 0x006C4828 File Offset: 0x006C2A28
		private void IIAGCHLJKEP(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.IHNLMAHAEOK(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.EJDJIOLHAEG(this.ik.solver.FKKHCIDIBLF(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.EJDJIOLHAEG(this.ik.solver.rightShoulderEffector, this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.DMPDLFPCDFO().positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.IDMNHNDKPGM(this.ik.solver.bodyEffector, base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.PIFADADCKHC(this.ik.solver.CLLKAEEHHIP(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.CLLKAEEHHIP().positionOffset);
			this.FPHNAAFKGEP(this.ik.solver.rightThighEffector, base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.ECCGBKELAOH().positionOffset);
		}

		// Token: 0x0600F1EE RID: 61934 RVA: 0x006C4B74 File Offset: 0x006C2D74
		private void NBENFONBILP()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MENBNCNMHPP));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Remove(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.MJMICLALFBN));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.JFFLPINGEND));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			}
		}

		// Token: 0x0600F1EF RID: 61935 RVA: 0x006C4C70 File Offset: 0x006C2E70
		private void BLIHIKLJLJA()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 790f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 1; i > -1; i -= 0)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 519f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(1725f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600F1F0 RID: 61936 RVA: 0x006C4D8C File Offset: 0x006C2F8C
		private void FPMALJMEGEK(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 692f)
			{
				return;
			}
			float num = 989f;
			num *= 1612f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 660f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x006C4E0C File Offset: 0x006C300C
		private void BANPIDAHLPN()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.JFFLPINGEND();
			}
			this.GFAGJFBHCHO();
			this.AFIKGDIEIMA();
			this.HMOLOECHOJJ();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x006C5108 File Offset: 0x006C3308
		private void ANNMJBFAHKO()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 1408f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 981f);
				if (this.stretchDamper > 1969f)
				{
					a /= (535f + a.magnitude) * (1154f + this.stretchDamper);
				}
				for (int i = 1; i < this.stretchBones.Length; i++)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 1137f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x006C5240 File Offset: 0x006C3440
		private void DLCKDIEHPKI()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 633f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 2);
			float num2 = 314f / (float)this.bendBones.Length;
			for (int i = 1; i < this.bendBones.Length; i += 0)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x006C533C File Offset: 0x006C353C
		private void MIEEAACIPJH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KPCKDCGAAKD));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Remove(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.ONHIIIICDHC));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.COGIBGILHNL));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			}
		}

		// Token: 0x0600F1F5 RID: 61941 RVA: 0x006C5438 File Offset: 0x006C3638
		private void DJEPDCKKOJN()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 1675f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 546f);
				if (this.stretchDamper > 1851f)
				{
					a /= (1976f + a.magnitude) * (387f + this.stretchDamper);
				}
				for (int i = 0; i < this.stretchBones.Length; i += 0)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 772f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F1F6 RID: 61942 RVA: 0x006C556E File Offset: 0x006C376E
		private void GDFNMMJIEPM(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F1F7 RID: 61943 RVA: 0x006C55AC File Offset: 0x006C37AC
		private void ANIAFMJPJIL(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 388f)
			{
				return;
			}
			float num = 1613f;
			num *= 424f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 1400f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F1F8 RID: 61944 RVA: 0x006C562C File Offset: 0x006C382C
		private void KPCKDCGAAKD()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.FMPHHJLLGGG();
			}
			this.GFAGJFBHCHO();
			this.ECIDOLAJECN();
			this.GFLAEBEAFEB();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F1F9 RID: 61945 RVA: 0x006C5928 File Offset: 0x006C3B28
		private void ECIDOLAJECN()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 586f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 0);
			float num2 = 1554f / (float)this.bendBones.Length;
			for (int i = 1; i < this.bendBones.Length; i++)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F1FA RID: 61946 RVA: 0x006C5A24 File Offset: 0x006C3C24
		private void GAOCGDLONBN()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.ALONDPNGCJF));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.GGOFOCDFCBA));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.PEBJEDLAPKJ));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F1FB RID: 61947 RVA: 0x006C5B48 File Offset: 0x006C3D48
		private void HMOLOECHOJJ()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 546f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 1; i > -1; i--)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 806f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(984f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600F1FC RID: 61948 RVA: 0x006C5C64 File Offset: 0x006C3E64
		private void DIJBNJEEBOP(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.ANIAFMJPJIL(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.GDFNMMJIEPM(this.ik.solver.FKKHCIDIBLF(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.PIFADADCKHC(this.ik.solver.DMPDLFPCDFO(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.EJDJIOLHAEG(this.ik.solver.NEKNDGMNDHG(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.IDMNHNDKPGM(this.ik.solver.EBCFAJOMOFB(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.EBCFAJOMOFB().positionOffset);
			this.PIFADADCKHC(this.ik.solver.rightThighEffector, base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.rightThighEffector.positionOffset);
		}

		// Token: 0x0600F1FD RID: 61949 RVA: 0x006C5FB0 File Offset: 0x006C41B0
		private void IEPBBKFHLBF()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 1950f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 2);
			float num2 = 532f / (float)this.bendBones.Length;
			for (int i = 0; i < this.bendBones.Length; i += 0)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F1FE RID: 61950 RVA: 0x006C60AC File Offset: 0x006C42AC
		private void FGBKHBCAFIC()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 1; i > -1; i--)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 1f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(0f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600F1FF RID: 61951 RVA: 0x006C61C8 File Offset: 0x006C43C8
		private void AFIKGDIEIMA()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 206f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 7);
			float num2 = 325f / (float)this.bendBones.Length;
			for (int i = 1; i < this.bendBones.Length; i += 0)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F200 RID: 61952 RVA: 0x006C62C1 File Offset: 0x006C44C1
		private void PIFADADCKHC(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.NJNJMMLFNIL(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.NJNJMMLFNIL(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F201 RID: 61953 RVA: 0x006C6300 File Offset: 0x006C4500
		private void ALONDPNGCJF()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.PLCLGDGMNBI();
			}
			this.OPIHNOLIJMB();
			this.AFIKGDIEIMA();
			this.HMOLOECHOJJ();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F202 RID: 61954 RVA: 0x006C65FC File Offset: 0x006C47FC
		private void KGCKFADFANB()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.COGIBGILHNL();
			}
			this.OPIHNOLIJMB();
			this.NMBMGJEFGHL();
			this.BJJGMACDLBA();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F203 RID: 61955 RVA: 0x006C68F8 File Offset: 0x006C4AF8
		private void IFMDAHAENLI()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 873f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 439f);
				if (this.stretchDamper > 1306f)
				{
					a /= (1020f + a.magnitude) * (1565f + this.stretchDamper);
				}
				for (int i = 1; i < this.stretchBones.Length; i += 0)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 1664f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F204 RID: 61956 RVA: 0x006C6A30 File Offset: 0x006C4C30
		private void PEBJEDLAPKJ()
		{
			if (!this.ik.enabled)
			{
				return;
			}
			FBBIKHeadEffector.BendBone[] array = this.bendBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				FBBIKHeadEffector.BendBone bendBone = array[i];
				if (bendBone != null)
				{
					bendBone.AEDEINJGEEA();
				}
			}
			for (int j = 0; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.CCDBones[j].localRotation = this.MDLPNFLFLLF[j];
				}
			}
			this.ik.references.head.localPosition = this.FELOHABKFOH;
			this.ik.references.head.localRotation = this.GECIFKGLMON;
			for (int k = 0; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.stretchBones[k].localPosition = this.BOBIDPKEGBG[k];
					this.stretchBones[k].localRotation = this.PDGHLGPJGLJ[k];
				}
			}
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.chestBones[l].localPosition = this.EOBIIMHMOAB[l];
					this.chestBones[l].localRotation = this.JIDGPNMMEEN[l];
				}
			}
		}

		// Token: 0x0600F205 RID: 61957 RVA: 0x006C6B9C File Offset: 0x006C4D9C
		private void HGNHAGCHGLA()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.ALONDPNGCJF));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Remove(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.GLOAIMOPBPB));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.JFFLPINGEND));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.PEBJEDLAPKJ));
			}
		}

		// Token: 0x0600F206 RID: 61958 RVA: 0x006C6C98 File Offset: 0x006C4E98
		private void NMBMGJEFGHL()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 107f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 5);
			float num2 = 793f / (float)this.bendBones.Length;
			for (int i = 1; i < this.bendBones.Length; i += 0)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F207 RID: 61959 RVA: 0x006C6D94 File Offset: 0x006C4F94
		private void JMFODDFLCMI(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 1567f)
			{
				return;
			}
			float num = 288f;
			num *= 979f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 922f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F208 RID: 61960 RVA: 0x006C6E14 File Offset: 0x006C5014
		private void JEMCJPPOLKP()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 730f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 1616f);
				if (this.stretchDamper > 491f)
				{
					a /= (1964f + a.magnitude) * (1216f + this.stretchDamper);
				}
				for (int i = 1; i < this.stretchBones.Length; i++)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 196f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F209 RID: 61961 RVA: 0x006C6F4C File Offset: 0x006C514C
		private void EDAGNKNOBKP(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 0f)
			{
				return;
			}
			float num = 1f;
			num *= 1f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 0.5f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F20A RID: 61962 RVA: 0x006C6FCC File Offset: 0x006C51CC
		private void PLHIKJNMPIP()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.JEMCJPPOLKP();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 7);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F20B RID: 61963 RVA: 0x006C556E File Offset: 0x006C376E
		private void FPHNAAFKGEP(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F20C RID: 61964 RVA: 0x006C708C File Offset: 0x006C528C
		private void PNMJDCJBACO()
		{
			float num = this.chestDirectionWeight * this.ik.solver.IKPositionWeight;
			if (num <= 399f)
			{
				return;
			}
			bool flag = false;
			this.chestDirection = OOJJKBHKGNJ.PNFHIEFDEGD(this.chestDirection, this.ik.references.root.forward, 796f, 1, out flag);
			if (this.chestDirection == Vector3.zero)
			{
				return;
			}
			Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.root.forward, this.chestDirection);
			quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, num * (900f / (float)this.chestBones.Length));
			foreach (Transform transform in this.chestBones)
			{
				transform.rotation = quaternion * transform.rotation;
			}
		}

		// Token: 0x0600F20D RID: 61965 RVA: 0x006C7170 File Offset: 0x006C5370
		private void JFFLPINGEND()
		{
			FBBIKHeadEffector.BendBone[] array = this.bendBones;
			for (int i = 1; i < array.Length; i += 0)
			{
				FBBIKHeadEffector.BendBone bendBone = array[i];
				if (bendBone != null)
				{
					bendBone.EJKOMEDJJPB();
				}
			}
			this.MDLPNFLFLLF = new Quaternion[this.CCDBones.Length];
			for (int j = 0; j < this.CCDBones.Length; j += 0)
			{
				if (this.CCDBones[j] != null)
				{
					this.MDLPNFLFLLF[j] = this.CCDBones[j].localRotation;
				}
			}
			this.FELOHABKFOH = this.ik.references.head.localPosition;
			this.GECIFKGLMON = this.ik.references.head.localRotation;
			this.BOBIDPKEGBG = new Vector3[this.stretchBones.Length];
			this.PDGHLGPJGLJ = new Quaternion[this.stretchBones.Length];
			for (int k = 0; k < this.stretchBones.Length; k += 0)
			{
				if (this.stretchBones[k] != null)
				{
					this.BOBIDPKEGBG[k] = this.stretchBones[k].localPosition;
					this.PDGHLGPJGLJ[k] = this.stretchBones[k].localRotation;
				}
			}
			this.EOBIIMHMOAB = new Vector3[this.chestBones.Length];
			this.JIDGPNMMEEN = new Quaternion[this.chestBones.Length];
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.EOBIIMHMOAB[l] = this.chestBones[l].localPosition;
					this.JIDGPNMMEEN[l] = this.chestBones[l].localRotation;
				}
			}
			this.NODBPKJKBGM = this.bendBones.Length;
			this.FIIPEMDIPHE = this.CCDBones.Length;
			this.BIGIDJPEMMI = this.stretchBones.Length;
			this.IEIINMJIGKH = this.chestBones.Length;
		}

		// Token: 0x0600F20E RID: 61966 RVA: 0x006C7364 File Offset: 0x006C5564
		private void OPIHNOLIJMB()
		{
			float num = this.chestDirectionWeight * this.ik.solver.IKPositionWeight;
			if (num <= 203f)
			{
				return;
			}
			bool flag = false;
			this.chestDirection = OOJJKBHKGNJ.PNFHIEFDEGD(this.chestDirection, this.ik.references.root.forward, 1770f, 5, out flag);
			if (this.chestDirection == Vector3.zero)
			{
				return;
			}
			Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.root.forward, this.chestDirection);
			quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, num * (1267f / (float)this.chestBones.Length));
			Transform[] array = this.chestBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				Transform transform = array[i];
				transform.rotation = quaternion * transform.rotation;
			}
		}

		// Token: 0x0600F20F RID: 61967 RVA: 0x006C7448 File Offset: 0x006C5648
		private void BJJGMACDLBA()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 934f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 0; i > -1; i -= 0)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 262f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(1141f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600F210 RID: 61968 RVA: 0x006C7564 File Offset: 0x006C5764
		private void KDMCOLGDFLD()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KGCKFADFANB));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.MJMICLALFBN));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPCMOGBCOMA));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.FMPHHJLLGGG));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.JICJDKDOOOF));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F211 RID: 61969 RVA: 0x006C7688 File Offset: 0x006C5888
		private void KOJNOPBGPAM()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KPCKDCGAAKD));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.IIAGCHLJKEP));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PFGDNNMELGD));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.JICJDKDOOOF));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F212 RID: 61970 RVA: 0x006C77AC File Offset: 0x006C59AC
		private void FJBJDFDJAMI()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.BANPIDAHLPN));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.ONHIIIICDHC));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPCMOGBCOMA));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.COGIBGILHNL));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x006C78D0 File Offset: 0x006C5AD0
		private void KKBJCEMFEEI()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.BANPIDAHLPN));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.MJMICLALFBN));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KEOOOIOBHDN));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.JFFLPINGEND));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.PEBJEDLAPKJ));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F214 RID: 61972 RVA: 0x006C79F4 File Offset: 0x006C5BF4
		private void PFGDNNMELGD()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.IFMDAHAENLI();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 5);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F215 RID: 61973 RVA: 0x006C7AB4 File Offset: 0x006C5CB4
		private void CNIDPFAAGEA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.JEMCJPPOLKP();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 1);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F216 RID: 61974 RVA: 0x006C7B74 File Offset: 0x006C5D74
		private void PHLHKALHHPF()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.PLCLGDGMNBI();
			}
			this.GFAGJFBHCHO();
			this.JKDJIEOMMLH();
			this.FGBKHBCAFIC();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F217 RID: 61975 RVA: 0x006C7E70 File Offset: 0x006C6070
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Remove(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.GLOAIMOPBPB));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KEOOOIOBHDN));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			}
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x006C7F6C File Offset: 0x006C616C
		private void IDNNACIKOHJ(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.EDAGNKNOBKP(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.IOOGCGIMNJL(this.ik.solver.leftShoulderEffector, this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.PIFADADCKHC(this.ik.solver.DMPDLFPCDFO(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.IDMNHNDKPGM(this.ik.solver.NEKNDGMNDHG(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.EOHLDGNBFGG());
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.FPHNAAFKGEP(this.ik.solver.EBCFAJOMOFB(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.EBCFAJOMOFB().positionOffset);
			this.PIFADADCKHC(this.ik.solver.FIDGAGDBPCG(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.rightThighEffector.positionOffset);
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x006C82B8 File Offset: 0x006C64B8
		private void FMPHHJLLGGG()
		{
			FBBIKHeadEffector.BendBone[] array = this.bendBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				FBBIKHeadEffector.BendBone bendBone = array[i];
				if (bendBone != null)
				{
					bendBone.ANNMLKMICGO();
				}
			}
			this.MDLPNFLFLLF = new Quaternion[this.CCDBones.Length];
			for (int j = 1; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.MDLPNFLFLLF[j] = this.CCDBones[j].localRotation;
				}
			}
			this.FELOHABKFOH = this.ik.references.head.localPosition;
			this.GECIFKGLMON = this.ik.references.head.localRotation;
			this.BOBIDPKEGBG = new Vector3[this.stretchBones.Length];
			this.PDGHLGPJGLJ = new Quaternion[this.stretchBones.Length];
			for (int k = 1; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.BOBIDPKEGBG[k] = this.stretchBones[k].localPosition;
					this.PDGHLGPJGLJ[k] = this.stretchBones[k].localRotation;
				}
			}
			this.EOBIIMHMOAB = new Vector3[this.chestBones.Length];
			this.JIDGPNMMEEN = new Quaternion[this.chestBones.Length];
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.EOBIIMHMOAB[l] = this.chestBones[l].localPosition;
					this.JIDGPNMMEEN[l] = this.chestBones[l].localRotation;
				}
			}
			this.NODBPKJKBGM = this.bendBones.Length;
			this.FIIPEMDIPHE = this.CCDBones.Length;
			this.BIGIDJPEMMI = this.stretchBones.Length;
			this.IEIINMJIGKH = this.chestBones.Length;
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x006C84AC File Offset: 0x006C66AC
		private void ECIAEIEKCCF()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.ALONDPNGCJF));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Remove(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.FOFHLDHGFAE));
				IKSolverFullBodyBiped solver3 = this.ik.solver;
				solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PFGDNNMELGD));
				IKSolverFullBodyBiped solver4 = this.ik.solver;
				solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.FMPHHJLLGGG));
				IKSolverFullBodyBiped solver5 = this.ik.solver;
				solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.JICJDKDOOOF));
			}
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x006C85A8 File Offset: 0x006C67A8
		private void COGIBGILHNL()
		{
			foreach (FBBIKHeadEffector.BendBone bendBone in this.bendBones)
			{
				if (bendBone != null)
				{
					bendBone.NNGBMKILKNJ();
				}
			}
			this.MDLPNFLFLLF = new Quaternion[this.CCDBones.Length];
			for (int j = 1; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.MDLPNFLFLLF[j] = this.CCDBones[j].localRotation;
				}
			}
			this.FELOHABKFOH = this.ik.references.head.localPosition;
			this.GECIFKGLMON = this.ik.references.head.localRotation;
			this.BOBIDPKEGBG = new Vector3[this.stretchBones.Length];
			this.PDGHLGPJGLJ = new Quaternion[this.stretchBones.Length];
			for (int k = 0; k < this.stretchBones.Length; k += 0)
			{
				if (this.stretchBones[k] != null)
				{
					this.BOBIDPKEGBG[k] = this.stretchBones[k].localPosition;
					this.PDGHLGPJGLJ[k] = this.stretchBones[k].localRotation;
				}
			}
			this.EOBIIMHMOAB = new Vector3[this.chestBones.Length];
			this.JIDGPNMMEEN = new Quaternion[this.chestBones.Length];
			for (int l = 1; l < this.chestBones.Length; l += 0)
			{
				if (this.chestBones[l] != null)
				{
					this.EOBIIMHMOAB[l] = this.chestBones[l].localPosition;
					this.JIDGPNMMEEN[l] = this.chestBones[l].localRotation;
				}
			}
			this.NODBPKJKBGM = this.bendBones.Length;
			this.FIIPEMDIPHE = this.CCDBones.Length;
			this.BIGIDJPEMMI = this.stretchBones.Length;
			this.IEIINMJIGKH = this.chestBones.Length;
		}

		// Token: 0x0600F21C RID: 61980 RVA: 0x006C62C1 File Offset: 0x006C44C1
		private void IDMNHNDKPGM(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.NJNJMMLFNIL(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.NJNJMMLFNIL(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F21D RID: 61981 RVA: 0x006C879C File Offset: 0x006C699C
		private void CJCGPPJADJL()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KGCKFADFANB));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.CHAPIDFDNLC));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IPCMOGBCOMA));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.JICJDKDOOOF));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F21E RID: 61982 RVA: 0x006C88C0 File Offset: 0x006C6AC0
		private void NPDCJEAKIMG()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.JNGPPOGIDGN();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 8);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F21F RID: 61983 RVA: 0x006C8980 File Offset: 0x006C6B80
		private void JNGPPOGIDGN()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 763f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 1070f);
				if (this.stretchDamper > 75f)
				{
					a /= (1416f + a.magnitude) * (1265f + this.stretchDamper);
				}
				for (int i = 0; i < this.stretchBones.Length; i += 0)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 905f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F220 RID: 61984 RVA: 0x006C8AB8 File Offset: 0x006C6CB8
		private void IPCMOGBCOMA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.NHGDBKLOEDE();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 1);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x006C8B78 File Offset: 0x006C6D78
		private void GGOFOCDFCBA(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.EDAGNKNOBKP(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.EJDJIOLHAEG(this.ik.solver.FKKHCIDIBLF(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.EEHNFKHFPGP().positionOffset);
			this.GDFNMMJIEPM(this.ik.solver.GPLFMHLNFLL(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.DMPDLFPCDFO().positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.GDFNMMJIEPM(this.ik.solver.HJPCHINGJCN(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.EJDJIOLHAEG(this.ik.solver.IMBHIAODACN(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.CLLKAEEHHIP().positionOffset);
			this.IDMNHNDKPGM(this.ik.solver.ECCGBKELAOH(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.ECCGBKELAOH().positionOffset);
		}

		// Token: 0x0600F222 RID: 61986 RVA: 0x006C8EC4 File Offset: 0x006C70C4
		private void Awake()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.GLOAIMOPBPB));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KEOOOIOBHDN));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F223 RID: 61987 RVA: 0x006C8FE8 File Offset: 0x006C71E8
		private void PLCLGDGMNBI()
		{
			foreach (FBBIKHeadEffector.BendBone bendBone in this.bendBones)
			{
				if (bendBone != null)
				{
					bendBone.FGBCANJFNOC();
				}
			}
			this.MDLPNFLFLLF = new Quaternion[this.CCDBones.Length];
			for (int j = 0; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.MDLPNFLFLLF[j] = this.CCDBones[j].localRotation;
				}
			}
			this.FELOHABKFOH = this.ik.references.head.localPosition;
			this.GECIFKGLMON = this.ik.references.head.localRotation;
			this.BOBIDPKEGBG = new Vector3[this.stretchBones.Length];
			this.PDGHLGPJGLJ = new Quaternion[this.stretchBones.Length];
			for (int k = 0; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.BOBIDPKEGBG[k] = this.stretchBones[k].localPosition;
					this.PDGHLGPJGLJ[k] = this.stretchBones[k].localRotation;
				}
			}
			this.EOBIIMHMOAB = new Vector3[this.chestBones.Length];
			this.JIDGPNMMEEN = new Quaternion[this.chestBones.Length];
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.EOBIIMHMOAB[l] = this.chestBones[l].localPosition;
					this.JIDGPNMMEEN[l] = this.chestBones[l].localRotation;
				}
			}
			this.NODBPKJKBGM = this.bendBones.Length;
			this.FIIPEMDIPHE = this.CCDBones.Length;
			this.BIGIDJPEMMI = this.stretchBones.Length;
			this.IEIINMJIGKH = this.chestBones.Length;
		}

		// Token: 0x0600F224 RID: 61988 RVA: 0x006C91DC File Offset: 0x006C73DC
		private void AIIPIPAOFPF(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 1823f)
			{
				return;
			}
			float num = 1352f;
			num *= 1970f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 96f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F225 RID: 61989 RVA: 0x006C925C File Offset: 0x006C745C
		private void MJMICLALFBN(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.ANIAFMJPJIL(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.FPHNAAFKGEP(this.ik.solver.ELPKPOGKHOP(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.GDFNMMJIEPM(this.ik.solver.DMPDLFPCDFO(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.PIFADADCKHC(this.ik.solver.bodyEffector, base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.EOHLDGNBFGG());
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.IOOGCGIMNJL(this.ik.solver.IMBHIAODACN(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.EBCFAJOMOFB().positionOffset);
			this.IOOGCGIMNJL(this.ik.solver.ECCGBKELAOH(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.EOHLDGNBFGG() + this.ik.solver.ECCGBKELAOH().positionOffset);
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x006C96A6 File Offset: 0x006C78A6
		private void EJDJIOLHAEG(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.NJNJMMLFNIL(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F228 RID: 61992 RVA: 0x006C96E4 File Offset: 0x006C78E4
		private void OCEPKIGJFIE()
		{
			if (!this.ik.enabled)
			{
				return;
			}
			foreach (FBBIKHeadEffector.BendBone bendBone in this.bendBones)
			{
				if (bendBone != null)
				{
					bendBone.BLOEEPCIPKJ();
				}
			}
			for (int j = 0; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.CCDBones[j].localRotation = this.MDLPNFLFLLF[j];
				}
			}
			this.ik.references.head.localPosition = this.FELOHABKFOH;
			this.ik.references.head.localRotation = this.GECIFKGLMON;
			for (int k = 0; k < this.stretchBones.Length; k++)
			{
				if (this.stretchBones[k] != null)
				{
					this.stretchBones[k].localPosition = this.BOBIDPKEGBG[k];
					this.stretchBones[k].localRotation = this.PDGHLGPJGLJ[k];
				}
			}
			for (int l = 0; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.chestBones[l].localPosition = this.EOBIIMHMOAB[l];
					this.chestBones[l].localRotation = this.JIDGPNMMEEN[l];
				}
			}
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x006C556E File Offset: 0x006C376E
		private void IOOGCGIMNJL(IKEffector JEFKLIBDHKK, Vector3 MGALEAJOGPL, float NKHBAJKMAGD, Vector3 IGFJOGKFADM)
		{
			JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition = Vector3.Lerp(JEFKLIBDHKK.OODFEEFPAHG(this.ik.solver).solverPosition, MGALEAJOGPL + IGFJOGKFADM, NKHBAJKMAGD);
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x006C9850 File Offset: 0x006C7A50
		private void NHGDBKLOEDE()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 0f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 0f);
				if (this.stretchDamper > 0f)
				{
					a /= (1f + a.magnitude) * (1f + this.stretchDamper);
				}
				for (int i = 0; i < this.stretchBones.Length; i++)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 0f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x006C9988 File Offset: 0x006C7B88
		private void AADOKDPNEHO()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 513f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 5);
			float num2 = 1250f / (float)this.bendBones.Length;
			for (int i = 0; i < this.bendBones.Length; i++)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F22C RID: 61996 RVA: 0x006C9A84 File Offset: 0x006C7C84
		private void FJLKFPKANFE()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 649f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 0);
			float num2 = 1389f / (float)this.bendBones.Length;
			for (int i = 1; i < this.bendBones.Length; i++)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F22D RID: 61997 RVA: 0x006C9B80 File Offset: 0x006C7D80
		private void PPNOJNBFHAP()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KPCKDCGAAKD));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.DIJBNJEEBOP));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPDCJEAKIMG));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.PLCLGDGMNBI));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.OCEPKIGJFIE));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x006C9CA4 File Offset: 0x006C7EA4
		private void JKDJIEOMMLH()
		{
			float num = this.bendWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			if (this.bendBones.Length == 0)
			{
				return;
			}
			Quaternion quaternion = base.transform.rotation * Quaternion.Inverse(this.ik.references.root.rotation * this.HJHFGONIPGF);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.bodyClampWeight, 2);
			float num2 = 1f / (float)this.bendBones.Length;
			for (int i = 0; i < this.bendBones.Length; i++)
			{
				if (this.bendBones[i].transform != null)
				{
					this.bendBones[i].transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, num2 * this.bendBones[i].weight * num) * this.bendBones[i].transform.rotation;
				}
			}
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x006C9DA0 File Offset: 0x006C7FA0
		private void GFLAEBEAFEB()
		{
			float num = this.CCDWeight * this.ik.solver.IKPositionWeight;
			if (num <= 1317f)
			{
				return;
			}
			for (int i = this.CCDBones.Length - 0; i > -1; i -= 0)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.head.position - this.CCDBones[i].position, base.transform.position - this.CCDBones[i].position) * this.CCDBones[i].rotation;
				float num2 = Mathf.Lerp((float)((this.CCDBones.Length - i) / this.CCDBones.Length), 750f, this.roll);
				float num3 = Quaternion.Angle(Quaternion.identity, quaternion);
				num3 = Mathf.Lerp(1448f, num3, (this.damper - num3) / this.damper);
				this.CCDBones[i].rotation = Quaternion.RotateTowards(this.CCDBones[i].rotation, quaternion, num3 * num * num2);
			}
		}

		// Token: 0x0600F230 RID: 62000 RVA: 0x006C9EBC File Offset: 0x006C80BC
		private void KEOOOIOBHDN()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			this.NHGDBKLOEDE();
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.ik.references.head.rotation, base.transform.rotation);
			quaternion = JEEPKFCFCLI.DHGGOAPDLJG(quaternion, this.headClampWeight, 2);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.rotationWeight * this.ik.solver.IKPositionWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F231 RID: 62001 RVA: 0x006C9F7C File Offset: 0x006C817C
		private void GLOAIMOPBPB(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.EDAGNKNOBKP(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.GDFNMMJIEPM(this.ik.solver.leftShoulderEffector, this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.leftShoulderEffector.positionOffset);
			this.GDFNMMJIEPM(this.ik.solver.rightShoulderEffector, this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.rightShoulderEffector.positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.GDFNMMJIEPM(this.ik.solver.bodyEffector, base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.GDFNMMJIEPM(this.ik.solver.leftThighEffector, base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.leftThighEffector.positionOffset);
			this.GDFNMMJIEPM(this.ik.solver.rightThighEffector, base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.bodyEffector.positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.rightThighEffector.positionOffset);
		}

		// Token: 0x0600F232 RID: 62002 RVA: 0x006CA2C8 File Offset: 0x006C84C8
		private void IHNLMAHAEOK(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 183f)
			{
				return;
			}
			float num = 576f;
			num *= 59f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 97f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x0600F233 RID: 62003 RVA: 0x006CA348 File Offset: 0x006C8548
		private void MENBNCNMHPP()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.COGIBGILHNL();
			}
			this.PNMJDCJBACO();
			this.IEPBBKFHLBF();
			this.GFLAEBEAFEB();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F234 RID: 62004 RVA: 0x006CA644 File Offset: 0x006C8844
		private void FLMMAOMPJIM()
		{
			float num = this.postStretchWeight * this.ik.solver.IKPositionWeight;
			if (num > 534f)
			{
				Vector3 a = Vector3.ClampMagnitude(base.transform.position - this.ik.references.head.position, this.maxStretch);
				a *= num;
				this.stretchDamper = Mathf.Max(this.stretchDamper, 801f);
				if (this.stretchDamper > 1991f)
				{
					a /= (945f + a.magnitude) * (935f + this.stretchDamper);
				}
				for (int i = 0; i < this.stretchBones.Length; i++)
				{
					if (this.stretchBones[i] != null)
					{
						this.stretchBones[i].position += a / (float)this.stretchBones.Length;
					}
				}
			}
			if (this.fixHead && this.ik.solver.IKPositionWeight > 345f)
			{
				this.ik.references.head.position = base.transform.position;
			}
		}

		// Token: 0x0600F235 RID: 62005 RVA: 0x006CA77C File Offset: 0x006C897C
		private void GHJPHHDKNAG()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.ik.solver.FABRIKPass = this.handsPullBody;
			if (this.NODBPKJKBGM != this.bendBones.Length || this.FIIPEMDIPHE != this.CCDBones.Length || this.BIGIDJPEMMI != this.stretchBones.Length || this.IEIINMJIGKH != this.chestBones.Length)
			{
				this.FMPHHJLLGGG();
			}
			this.PNMJDCJBACO();
			this.FJLKFPKANFE();
			this.FGBKHBCAFIC();
			this.IGFJOGKFADM = base.transform.position - this.ik.references.head.position;
			this.CBBJIGEDANJ = Vector3.Distance(this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position);
			this.NFLKJPMECEG = Vector3.Distance(this.ik.references.head.position, this.ik.references.leftUpperArm.position);
			this.NDJHCDOHLEF = Vector3.Distance(this.ik.references.head.position, this.ik.references.rightUpperArm.position);
			this.IPFEPJACJOA = this.ik.solver.rootNode.position - this.ik.references.head.position;
			this.CDICFJJGHNO = this.ik.references.leftThigh.position - this.ik.references.head.position;
			this.HIEMADHNKJL = this.ik.references.rightThigh.position - this.ik.references.head.position;
			this.POPOPAHCAGP = this.ik.references.leftUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.PBNJAPKCEIP = this.ik.references.rightUpperArm.position + this.IGFJOGKFADM * this.bodyWeight;
			this.BFEKKKEFILF = Quaternion.LookRotation(this.ik.references.head.position - this.ik.references.leftUpperArm.position, this.ik.references.rightUpperArm.position - this.ik.references.leftUpperArm.position);
			if (this.OnPostHeadEffectorFK != null)
			{
				this.OnPostHeadEffectorFK();
			}
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x006CAA78 File Offset: 0x006C8C78
		private void JICJDKDOOOF()
		{
			if (!this.ik.enabled)
			{
				return;
			}
			FBBIKHeadEffector.BendBone[] array = this.bendBones;
			for (int i = 0; i < array.Length; i += 0)
			{
				FBBIKHeadEffector.BendBone bendBone = array[i];
				if (bendBone != null)
				{
					bendBone.FNHEFMKHCGC();
				}
			}
			for (int j = 1; j < this.CCDBones.Length; j++)
			{
				if (this.CCDBones[j] != null)
				{
					this.CCDBones[j].localRotation = this.MDLPNFLFLLF[j];
				}
			}
			this.ik.references.head.localPosition = this.FELOHABKFOH;
			this.ik.references.head.localRotation = this.GECIFKGLMON;
			for (int k = 1; k < this.stretchBones.Length; k += 0)
			{
				if (this.stretchBones[k] != null)
				{
					this.stretchBones[k].localPosition = this.BOBIDPKEGBG[k];
					this.stretchBones[k].localRotation = this.PDGHLGPJGLJ[k];
				}
			}
			for (int l = 1; l < this.chestBones.Length; l++)
			{
				if (this.chestBones[l] != null)
				{
					this.chestBones[l].localPosition = this.EOBIIMHMOAB[l];
					this.chestBones[l].localRotation = this.JIDGPNMMEEN[l];
				}
			}
		}

		// Token: 0x0600F237 RID: 62007 RVA: 0x006CABE4 File Offset: 0x006C8DE4
		private void GFAGJFBHCHO()
		{
			float num = this.chestDirectionWeight * this.ik.solver.IKPositionWeight;
			if (num <= 0f)
			{
				return;
			}
			bool flag = false;
			this.chestDirection = OOJJKBHKGNJ.PNFHIEFDEGD(this.chestDirection, this.ik.references.root.forward, 0.45f, 2, out flag);
			if (this.chestDirection == Vector3.zero)
			{
				return;
			}
			Quaternion quaternion = Quaternion.FromToRotation(this.ik.references.root.forward, this.chestDirection);
			quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, num * (1f / (float)this.chestBones.Length));
			foreach (Transform transform in this.chestBones)
			{
				transform.rotation = quaternion * transform.rotation;
			}
		}

		// Token: 0x0600F238 RID: 62008 RVA: 0x006CACC8 File Offset: 0x006C8EC8
		private void OGMACADJFIN()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.ALONDPNGCJF));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPreIteration = (IKSolver.MLFKIGOCFLP)Delegate.Combine(solver2.OnPreIteration, new IKSolver.MLFKIGOCFLP(this.GLOAIMOPBPB));
			IKSolverFullBodyBiped solver3 = this.ik.solver;
			solver3.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver3.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KEOOOIOBHDN));
			IKSolverFullBodyBiped solver4 = this.ik.solver;
			solver4.OnStoreDefaultLocalState = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver4.OnStoreDefaultLocalState, new IKSolver.LGGEKCCEELN(this.JFFLPINGEND));
			IKSolverFullBodyBiped solver5 = this.ik.solver;
			solver5.OnFixTransforms = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver5.OnFixTransforms, new IKSolver.LGGEKCCEELN(this.PEBJEDLAPKJ));
			this.HJHFGONIPGF = Quaternion.Inverse(this.ik.references.root.rotation) * this.ik.references.head.rotation;
		}

		// Token: 0x0600F239 RID: 62009 RVA: 0x006CADEC File Offset: 0x006C8FEC
		private void FOFHLDHGFAE(int CJCBMDCNIEA)
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.ik.solver.iterations == 0)
			{
				return;
			}
			this.POPOPAHCAGP = base.transform.position + (this.POPOPAHCAGP - base.transform.position).normalized * this.NFLKJPMECEG;
			this.PBNJAPKCEIP = base.transform.position + (this.PBNJAPKCEIP - base.transform.position).normalized * this.NDJHCDOHLEF;
			this.EDAGNKNOBKP(ref this.POPOPAHCAGP, ref this.PBNJAPKCEIP, this.CBBJIGEDANJ);
			this.FPHNAAFKGEP(this.ik.solver.EEHNFKHFPGP(), this.POPOPAHCAGP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.LLFAEIGHHBK().positionOffset);
			this.EJDJIOLHAEG(this.ik.solver.DMPDLFPCDFO(), this.PBNJAPKCEIP, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.DMPDLFPCDFO().positionOffset);
			Quaternion ljggoanmjaj = Quaternion.LookRotation(base.transform.position - this.POPOPAHCAGP, this.PBNJAPKCEIP - this.POPOPAHCAGP);
			Quaternion quaternion = JEEPKFCFCLI.AADCPGNPHHC(this.BFEKKKEFILF, ljggoanmjaj);
			Vector3 b = quaternion * this.IPFEPJACJOA;
			this.GDFNMMJIEPM(this.ik.solver.HJPCHINGJCN(), base.transform.position + b, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.pullBodyOffset);
			Quaternion rotation = Quaternion.Lerp(Quaternion.identity, quaternion, this.thighWeight);
			Vector3 b2 = rotation * this.CDICFJJGHNO;
			Vector3 b3 = rotation * this.HIEMADHNKJL;
			this.PIFADADCKHC(this.ik.solver.EBCFAJOMOFB(), base.transform.position + b2, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.HJPCHINGJCN().positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.CLLKAEEHHIP().positionOffset);
			this.FPHNAAFKGEP(this.ik.solver.FIDGAGDBPCG(), base.transform.position + b3, this.positionWeight * this.ik.solver.IKPositionWeight, this.ik.solver.NEKNDGMNDHG().positionOffset - this.ik.solver.pullBodyOffset + this.ik.solver.FIDGAGDBPCG().positionOffset);
		}

		// Token: 0x0600F23A RID: 62010 RVA: 0x006CB138 File Offset: 0x006C9338
		private void CBCIOPCCEJB(ref Vector3 IKECEOLMEFM, ref Vector3 EDGLMNGJAAK, float CJLPDKCENCJ)
		{
			Vector3 a = EDGLMNGJAAK - IKECEOLMEFM;
			float magnitude = a.magnitude;
			if (magnitude == CJLPDKCENCJ)
			{
				return;
			}
			if (magnitude == 1052f)
			{
				return;
			}
			float num = 332f;
			num *= 1603f - CJLPDKCENCJ / magnitude;
			Vector3 b = a * num * 1718f;
			IKECEOLMEFM += b;
			EDGLMNGJAAK -= b;
		}

		// Token: 0x04001F68 RID: 8040
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		// Token: 0x04001F69 RID: 8041
		[Tooltip("Master weight for positioning the head.")]
		[HIMEPKDIHPL("Position")]
		[Range(0f, 1f)]
		public float positionWeight = 1f;

		// Token: 0x04001F6A RID: 8042
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight = 0.8f;

		// Token: 0x04001F6B RID: 8043
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight = 0.8f;

		// Token: 0x04001F6C RID: 8044
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody = true;

		// Token: 0x04001F6D RID: 8045
		[HIMEPKDIHPL("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04001F6E RID: 8046
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight = 0.5f;

		// Token: 0x04001F6F RID: 8047
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight = 0.5f;

		// Token: 0x04001F70 RID: 8048
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight = 1f;

		// Token: 0x04001F71 RID: 8049
		[Tooltip("The bones to use for bending.")]
		public FBBIKHeadEffector.BendBone[] bendBones = new FBBIKHeadEffector.BendBone[0];

		// Token: 0x04001F72 RID: 8050
		[HIMEPKDIHPL("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight = 1f;

		// Token: 0x04001F73 RID: 8051
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		// Token: 0x04001F74 RID: 8052
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper = 500f;

		// Token: 0x04001F75 RID: 8053
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones = new Transform[0];

		// Token: 0x04001F76 RID: 8054
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[HIMEPKDIHPL("Stretching")]
		public float postStretchWeight = 1f;

		// Token: 0x04001F77 RID: 8055
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch = 0.1f;

		// Token: 0x04001F78 RID: 8056
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		// Token: 0x04001F79 RID: 8057
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		// Token: 0x04001F7A RID: 8058
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones = new Transform[0];

		// Token: 0x04001F7B RID: 8059
		[HIMEPKDIHPL("Chest Direction")]
		public Vector3 chestDirection = Vector3.forward;

		// Token: 0x04001F7C RID: 8060
		[Range(0f, 1f)]
		public float chestDirectionWeight = 1f;

		// Token: 0x04001F7D RID: 8061
		public Transform[] chestBones;

		// Token: 0x04001F7E RID: 8062
		public IKSolver.LGGEKCCEELN OnPostHeadEffectorFK;

		// Token: 0x04001F7F RID: 8063
		private Vector3 IGFJOGKFADM;

		// Token: 0x04001F80 RID: 8064
		private Vector3 IPFEPJACJOA;

		// Token: 0x04001F81 RID: 8065
		private Vector3 MMGCJKNAGLF;

		// Token: 0x04001F82 RID: 8066
		private Vector3 CDICFJJGHNO;

		// Token: 0x04001F83 RID: 8067
		private Vector3 HIEMADHNKJL;

		// Token: 0x04001F84 RID: 8068
		private Vector3 POPOPAHCAGP;

		// Token: 0x04001F85 RID: 8069
		private Vector3 PBNJAPKCEIP;

		// Token: 0x04001F86 RID: 8070
		private float CBBJIGEDANJ;

		// Token: 0x04001F87 RID: 8071
		private float NFLKJPMECEG;

		// Token: 0x04001F88 RID: 8072
		private float NDJHCDOHLEF;

		// Token: 0x04001F89 RID: 8073
		private Quaternion BFEKKKEFILF;

		// Token: 0x04001F8A RID: 8074
		private Quaternion HJHFGONIPGF;

		// Token: 0x04001F8B RID: 8075
		private Quaternion[] MDLPNFLFLLF = new Quaternion[0];

		// Token: 0x04001F8C RID: 8076
		private Vector3 FELOHABKFOH;

		// Token: 0x04001F8D RID: 8077
		private Quaternion GECIFKGLMON;

		// Token: 0x04001F8E RID: 8078
		private Vector3[] BOBIDPKEGBG = new Vector3[0];

		// Token: 0x04001F8F RID: 8079
		private Quaternion[] PDGHLGPJGLJ = new Quaternion[0];

		// Token: 0x04001F90 RID: 8080
		private Vector3[] EOBIIMHMOAB = new Vector3[0];

		// Token: 0x04001F91 RID: 8081
		private Quaternion[] JIDGPNMMEEN = new Quaternion[0];

		// Token: 0x04001F92 RID: 8082
		private int NODBPKJKBGM;

		// Token: 0x04001F93 RID: 8083
		private int FIIPEMDIPHE;

		// Token: 0x04001F94 RID: 8084
		private int BIGIDJPEMMI;

		// Token: 0x04001F95 RID: 8085
		private int IEIINMJIGKH;

		// Token: 0x0200045E RID: 1118
		[Serializable]
		public class BendBone
		{
			// Token: 0x0600F23B RID: 62011 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void EJKOMEDJJPB()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F23C RID: 62012 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void NNGBMKILKNJ()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F23D RID: 62013 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void IBNJKNMAMHI()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F23E RID: 62014 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void IEDOEDJPBFE()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F23F RID: 62015 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void HMDBDIHAFJH()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F240 RID: 62016 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void IGBAJPEIMKI()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F241 RID: 62017 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void ANNMLKMICGO()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F242 RID: 62018 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void DKCMGGGINJN()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F243 RID: 62019 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void IMNCFDNDFKA()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F244 RID: 62020 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void JBCAJBAPPOD()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F245 RID: 62021 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void FFDCMCOPNBJ()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F246 RID: 62022 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void NFEAAPAAGEC()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F247 RID: 62023 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void IJOMKNCJOAO()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F248 RID: 62024 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void PLMMHHEKIMD()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F249 RID: 62025 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void HHMLPJALGOD()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F24A RID: 62026 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void PJCKNDKFLMH()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F24B RID: 62027 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void NKCAHJFCLPD()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F24C RID: 62028 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void LMGKPDIJFDL()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F24D RID: 62029 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void JDBHBELINNP()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F24E RID: 62030 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void AJPBHLLGPHI()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F24F RID: 62031 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void JEPOAFAADDF()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F250 RID: 62032 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void BGGHOADIBGD()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F251 RID: 62033 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void LDKHLPOGNHP()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F252 RID: 62034 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void DIAGEINIGEP()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F253 RID: 62035 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void EOFKGOMJDBB()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F254 RID: 62036 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void OBFPCCOCEAO()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F255 RID: 62037 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void AEDEINJGEEA()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F256 RID: 62038 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void PLFEBKPEEIM()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F257 RID: 62039 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void EMDGMEBJODM()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F258 RID: 62040 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void BLOEEPCIPKJ()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F259 RID: 62041 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void CDGACJJFJMJ()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F25A RID: 62042 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void FGBCANJFNOC()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F25B RID: 62043 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void KFCDNBMKNLJ()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F25C RID: 62044 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void JOCKIDBMLOH()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F25D RID: 62045 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void POKHLIIJHFH()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F25E RID: 62046 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void AGMGLNFEPKK()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F25F RID: 62047 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void JFPCNNLLJEJ()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F260 RID: 62048 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void KGJOIBELOGC()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F261 RID: 62049 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void KGGFBOBLFDB()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F262 RID: 62050 RVA: 0x006CB1DB File Offset: 0x006C93DB
			public BendBone(Transform LPBDALAMAEM, float NKHBAJKMAGD)
			{
				this.transform = LPBDALAMAEM;
				this.weight = NKHBAJKMAGD;
			}

			// Token: 0x0600F263 RID: 62051 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void ODOAFJCMOKD()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F264 RID: 62052 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void FNHEFMKHCGC()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F265 RID: 62053 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void POLNPMPEFEJ()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F266 RID: 62054 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void KINGMKPLEMB()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F267 RID: 62055 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void NIEFJLEDGCF()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F268 RID: 62056 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void EAAJEBAKIEB()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F269 RID: 62057 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void JGKGCOHNNJK()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F26A RID: 62058 RVA: 0x006CB207 File Offset: 0x006C9407
			public BendBone()
			{
			}

			// Token: 0x0600F26B RID: 62059 RVA: 0x006CB1B5 File Offset: 0x006C93B5
			public void FKOFHBNMDIM()
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F26C RID: 62060 RVA: 0x006CB1C8 File Offset: 0x006C93C8
			public void ENIOEALHJEE()
			{
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x04001F96 RID: 8086
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			// Token: 0x04001F97 RID: 8087
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight = 0.5f;

			// Token: 0x04001F98 RID: 8088
			private Quaternion defaultLocalRotation = Quaternion.identity;
		}
	}
}
