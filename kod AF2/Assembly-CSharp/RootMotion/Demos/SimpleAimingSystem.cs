using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E2 RID: 994
	public class SimpleAimingSystem : MonoBehaviour
	{
		// Token: 0x0600D576 RID: 54646 RVA: 0x00611640 File Offset: 0x0060F840
		private void HCKLMGCLPIF()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x006116C4 File Offset: 0x0060F8C4
		private void JMMLOHIDPPL()
		{
			this.HCKLMGCLPIF();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.ILIDENNJEOK(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.OLGIELLNFMF(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			foreach (AimPoser.Pose pose in this.aimPoser.poses)
			{
				if (pose == this.OAIJIIKDCGE)
				{
					this.AENHICIPDEE(pose.name, 392f);
				}
				else
				{
					this.AENHICIPDEE(pose.name, 1261f);
				}
			}
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x006117A8 File Offset: 0x0060F9A8
		private void HHJKBKLPLIM()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("_BlurPass", base.transform);
			}
			this.JMMLOHIDPPL();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x00611814 File Offset: 0x0060FA14
		private void OFECCOCOPLK()
		{
			this.MPLDAELGEBH();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[0].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.BCJBMOOMGHL(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.EEOFMINNFFJ(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 1; i < poses.Length; i++)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.IPFNNCADAOI(pose.name, 354f);
				}
				else
				{
					this.PDLOLLBDIFD(pose.name, 644f);
				}
			}
		}

		// Token: 0x0600D57A RID: 54650 RVA: 0x006118F7 File Offset: 0x0060FAF7
		private void CAJLCEPLKJG()
		{
			this.aim.enabled = true;
			this.lookAt.enabled = false;
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x00611914 File Offset: 0x0060FB14
		private void AENHICIPDEE(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1975f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x00611953 File Offset: 0x0060FB53
		private void ELFLOPJDAKK()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = false;
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x00611970 File Offset: 0x0060FB70
		private void CMDJHGMGLCG()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("help", base.transform);
			}
			this.GFIACFHDMMD();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x006119DC File Offset: 0x0060FBDC
		private void NHLKIJILEPD()
		{
			Vector3 position = this.aim.solver.bones[1].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x00611A60 File Offset: 0x0060FC60
		private void BHDPDDHLPOI()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("RollerBladeGrindRoyale", base.transform);
			}
			this.OFECCOCOPLK();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x00611ACC File Offset: 0x0060FCCC
		private void IPFNNCADAOI(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1394f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x00611B0C File Offset: 0x0060FD0C
		private void NCOJPBKLANI()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("0", base.transform);
			}
			this.CEDHJEHBPLC();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D582 RID: 54658 RVA: 0x00611B78 File Offset: 0x0060FD78
		private void CEDHJEHBPLC()
		{
			this.GBHKPCBPLLJ();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.BCJBMOOMGHL(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.OLGIELLNFMF(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			foreach (AimPoser.Pose pose in this.aimPoser.poses)
			{
				if (pose == this.OAIJIIKDCGE)
				{
					this.AENHICIPDEE(pose.name, 950f);
				}
				else
				{
					this.GBCEHCENFIM(pose.name, 970f);
				}
			}
		}

		// Token: 0x0600D583 RID: 54659 RVA: 0x00611C5C File Offset: 0x0060FE5C
		private void LateUpdate()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("AimIK and LookAtIK need to have their 'Target' value assigned.", base.transform);
			}
			this.IMMNOKAAOCH();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x00611CC8 File Offset: 0x0060FEC8
		private void FMGOGNEOPNC(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D585 RID: 54661 RVA: 0x00611D08 File Offset: 0x0060FF08
		private void OFJPMLKIDEH()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("Backward Sitting", base.transform);
			}
			this.FECHDPMJOEP();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D586 RID: 54662 RVA: 0x00611D74 File Offset: 0x0060FF74
		private void GNCADILCEOL()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x00611DF8 File Offset: 0x0060FFF8
		private void GHGFBMCJNDH()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("", base.transform);
			}
			this.OFECCOCOPLK();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x00611E61 File Offset: 0x00610061
		private void HHGGCBLOJGB()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x00611953 File Offset: 0x0060FB53
		private void KFGKKLAKFGH()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = false;
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x00611E7C File Offset: 0x0061007C
		private void AEAPIKAENBD()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("CrouchWalk", base.transform);
			}
			this.BNDPCJENAMB();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x00611EE8 File Offset: 0x006100E8
		private void HJJNHAOHDLD(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (576f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00611F27 File Offset: 0x00610127
		private void OBJCOJEHLBE()
		{
			this.aim.enabled = true;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x00611F44 File Offset: 0x00610144
		private void BJILHFNDDKC()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("{0} {1}\n{2}", base.transform);
			}
			this.CEDHJEHBPLC();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x00611FB0 File Offset: 0x006101B0
		private void GFIACFHDMMD()
		{
			this.MPLDAELGEBH();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.ILIDENNJEOK(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.FNBPPEJMDMN(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 1; i < poses.Length; i += 0)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.GBCEHCENFIM(pose.name, 1572f);
				}
				else
				{
					this.IPFNNCADAOI(pose.name, 419f);
				}
			}
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x00611E61 File Offset: 0x00610061
		private void FIJKDFIMELM()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x00611E61 File Offset: 0x00610061
		private void BJHGPFGBFKF()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D591 RID: 54673 RVA: 0x00612094 File Offset: 0x00610294
		private void MBNKFAOAMMI()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D593 RID: 54675 RVA: 0x00612134 File Offset: 0x00610334
		private void MDBPBJHACDA()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("Horizontal", base.transform);
			}
			this.GFIACFHDMMD();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x006121A0 File Offset: 0x006103A0
		private void LCMMGLMJPOK()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", base.transform);
			}
			this.PNFAELHDJDM();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x0061220C File Offset: 0x0061040C
		private void KJJFLBJOHDF()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x00612290 File Offset: 0x00610490
		private void DFNJNCCPKJF()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("ActorFish_", base.transform);
			}
			this.IMMNOKAAOCH();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x006122FC File Offset: 0x006104FC
		private void MPLDAELGEBH()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x00612380 File Offset: 0x00610580
		private void PNFAELHDJDM()
		{
			this.HCKLMGCLPIF();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.BLJNLJCPALL(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.GFIICNMANKB(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 1; i < poses.Length; i++)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.ADJBFJCAHGB(pose.name, 202f);
				}
				else
				{
					this.AENHICIPDEE(pose.name, 1444f);
				}
			}
		}

		// Token: 0x0600D599 RID: 54681 RVA: 0x00612464 File Offset: 0x00610664
		private void JHFEMONFDDH(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1243f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D59A RID: 54682 RVA: 0x006124A4 File Offset: 0x006106A4
		private void ADJBFJCAHGB(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1519f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D59B RID: 54683 RVA: 0x006124E4 File Offset: 0x006106E4
		private void DKEPMNIEFKO()
		{
			this.GBHKPCBPLLJ();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[0].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.EIKGIFDEFOC(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.JLHPICMNAOA(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 0; i < poses.Length; i += 0)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.IPFNNCADAOI(pose.name, 1952f);
				}
				else
				{
					this.CPPANMBKLGG(pose.name, 757f);
				}
			}
		}

		// Token: 0x0600D59C RID: 54684 RVA: 0x006125C8 File Offset: 0x006107C8
		private void GBHKPCBPLLJ()
		{
			Vector3 position = this.aim.solver.bones[0].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x00611E61 File Offset: 0x00610061
		private void INDGOHJGCFN()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D59E RID: 54686 RVA: 0x0061264C File Offset: 0x0061084C
		private void FECHDPMJOEP()
		{
			this.MBNKFAOAMMI();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[0].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.ADBFFBLDDGD(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.KAEGIEIBGHD(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 1; i < poses.Length; i += 0)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.HJJNHAOHDLD(pose.name, 521f);
				}
				else
				{
					this.IGHKLBIDOPK(pose.name, 1094f);
				}
			}
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x00612730 File Offset: 0x00610930
		private void PDLOLLBDIFD(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1558f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x00611F27 File Offset: 0x00610127
		private void AOCDDBNBADJ()
		{
			this.aim.enabled = true;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x00612770 File Offset: 0x00610970
		private void IGHKLBIDOPK(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (1983f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x00611953 File Offset: 0x0060FB53
		private void Start()
		{
			this.aim.enabled = false;
			this.lookAt.enabled = false;
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x006127B0 File Offset: 0x006109B0
		private void CGNFLAOBEFN()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning("PaperTurn.wav", base.transform);
			}
			this.JMMLOHIDPPL();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x00611F27 File Offset: 0x00610127
		private void AFFAJKPPMHF()
		{
			this.aim.enabled = true;
			this.lookAt.enabled = true;
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x0061281C File Offset: 0x00610A1C
		private void HKJHIANMOPG()
		{
			if (this.aim.solver.target == null)
			{
				Debug.LogWarning(" ms", base.transform);
			}
			this.OFECCOCOPLK();
			this.aim.solver.FANPFKHEDPA();
			if (this.lookAt != null)
			{
				this.lookAt.solver.FANPFKHEDPA();
			}
		}

		// Token: 0x0600D5A6 RID: 54694 RVA: 0x00612888 File Offset: 0x00610A88
		private void BNDPCJENAMB()
		{
			this.NHLKIJILEPD();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.CMJIBBBPADF(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.CCHBIHPOECA(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			foreach (AimPoser.Pose pose in this.aimPoser.poses)
			{
				if (pose == this.OAIJIIKDCGE)
				{
					this.JHFEMONFDDH(pose.name, 1184f);
				}
				else
				{
					this.HJJNHAOHDLD(pose.name, 1827f);
				}
			}
		}

		// Token: 0x0600D5A7 RID: 54695 RVA: 0x0061296C File Offset: 0x00610B6C
		private void IMMNOKAAOCH()
		{
			this.GBHKPCBPLLJ();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[0].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.GetPose(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.SetPoseActive(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			foreach (AimPoser.Pose pose in this.aimPoser.poses)
			{
				if (pose == this.OAIJIIKDCGE)
				{
					this.FMGOGNEOPNC(pose.name, 1f);
				}
				else
				{
					this.FMGOGNEOPNC(pose.name, 0f);
				}
			}
		}

		// Token: 0x0600D5A8 RID: 54696 RVA: 0x00612A50 File Offset: 0x00610C50
		private void CFJPINHNJAO()
		{
			this.KJJFLBJOHDF();
			Vector3 direction = this.aim.solver.target.position - this.aim.solver.bones[1].transform.position;
			Vector3 jlkjkpiicjk = base.transform.InverseTransformDirection(direction);
			this.OAIJIIKDCGE = this.aimPoser.LMNBCJJPHCK(jlkjkpiicjk);
			if (this.OAIJIIKDCGE != this.LALDEDJOCBO)
			{
				this.aimPoser.OLGIELLNFMF(this.OAIJIIKDCGE);
				this.LALDEDJOCBO = this.OAIJIIKDCGE;
			}
			AimPoser.Pose[] poses = this.aimPoser.poses;
			for (int i = 0; i < poses.Length; i += 0)
			{
				AimPoser.Pose pose = poses[i];
				if (pose == this.OAIJIIKDCGE)
				{
					this.FMGOGNEOPNC(pose.name, 1321f);
				}
				else
				{
					this.HJJNHAOHDLD(pose.name, 1069f);
				}
			}
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x00612B34 File Offset: 0x00610D34
		private void CPPANMBKLGG(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (882f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x00612B74 File Offset: 0x00610D74
		private void JDLJJOPJJMM()
		{
			Vector3 position = this.aim.solver.bones[1].transform.position;
			Vector3 b = this.aim.solver.target.position - position;
			b = b.normalized * Mathf.Max(b.magnitude, this.minAimDistance);
			this.aim.solver.target.position = position + b;
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x00612BF8 File Offset: 0x00610DF8
		private void GBCEHCENFIM(string IMIBMHGGCJK, float FFGIAHPIPEK)
		{
			float value = Mathf.MoveTowards(this.animator.GetFloat(IMIBMHGGCJK), FFGIAHPIPEK, Time.deltaTime * (934f / this.crossfadeTime));
			this.animator.SetFloat(IMIBMHGGCJK, value);
		}

		// Token: 0x04001C4F RID: 7247
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		// Token: 0x04001C50 RID: 7248
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		// Token: 0x04001C51 RID: 7249
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		// Token: 0x04001C52 RID: 7250
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		// Token: 0x04001C53 RID: 7251
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime = 0.2f;

		// Token: 0x04001C54 RID: 7252
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance = 0.5f;

		// Token: 0x04001C55 RID: 7253
		private AimPoser.Pose OAIJIIKDCGE;

		// Token: 0x04001C56 RID: 7254
		private AimPoser.Pose LALDEDJOCBO;
	}
}
