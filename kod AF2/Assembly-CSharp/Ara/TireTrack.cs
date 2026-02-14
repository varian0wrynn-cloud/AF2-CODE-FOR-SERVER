using System;
using UnityEngine;

namespace Ara
{
	// Token: 0x020005C1 RID: 1473
	[RequireComponent(typeof(AraTrail))]
	public class TireTrack : MonoBehaviour
	{
		// Token: 0x0601357F RID: 79231 RVA: 0x008522F8 File Offset: 0x008504F8
		private void FMLHEGPJPAN()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x06013580 RID: 79232 RVA: 0x00852433 File Offset: 0x00850633
		private void ALHFPHHGIHK()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.NMKGMIDDPEM;
		}

		// Token: 0x06013581 RID: 79233 RVA: 0x00852458 File Offset: 0x00850658
		private void PFBENAPEFBJ()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x06013582 RID: 79234 RVA: 0x00852594 File Offset: 0x00850794
		private void NMKGMIDDPEM()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x06013583 RID: 79235 RVA: 0x008526D0 File Offset: 0x008508D0
		private void OJFNLIJNPEJ()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x06013584 RID: 79236 RVA: 0x0085280B File Offset: 0x00850A0B
		private void DNBMNPKDPHC()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.BOKBDGMLHDF));
		}

		// Token: 0x06013585 RID: 79237 RVA: 0x00852824 File Offset: 0x00850A24
		private void LNEJPGDHJOJ()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.IHCCJFCDKMA));
		}

		// Token: 0x06013586 RID: 79238 RVA: 0x00852840 File Offset: 0x00850A40
		private void OFPMFGNPGDJ()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x06013587 RID: 79239 RVA: 0x0085297C File Offset: 0x00850B7C
		private void KPKEGCLANFL()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x06013588 RID: 79240 RVA: 0x00852AB7 File Offset: 0x00850CB7
		private void OnEnable()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.DCMHPEKEEDD;
		}

		// Token: 0x06013589 RID: 79241 RVA: 0x00852ADC File Offset: 0x00850CDC
		private void EMOFOHBMJBD()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.HMAPNLPBAJK;
		}

		// Token: 0x0601358A RID: 79242 RVA: 0x00852B01 File Offset: 0x00850D01
		private void NFJKCBFCHBP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.FMLHEGPJPAN;
		}

		// Token: 0x0601358B RID: 79243 RVA: 0x00852B28 File Offset: 0x00850D28
		private void DAFIBNHAPBG()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x0601358C RID: 79244 RVA: 0x00852C63 File Offset: 0x00850E63
		private void GBAEKFJBEFM()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.JHBGMDLAFNF));
		}

		// Token: 0x0601358D RID: 79245 RVA: 0x00852ADC File Offset: 0x00850CDC
		private void LBKOIJKMCOL()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.HMAPNLPBAJK;
		}

		// Token: 0x0601358E RID: 79246 RVA: 0x00852C7C File Offset: 0x00850E7C
		private void IJACKJBFFKB()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x0601358F RID: 79247 RVA: 0x00852DB8 File Offset: 0x00850FB8
		private void GKCKEPBPPOK()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x06013590 RID: 79248 RVA: 0x00852433 File Offset: 0x00850633
		private void EBAJDGLIAPE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.NMKGMIDDPEM;
		}

		// Token: 0x06013591 RID: 79249 RVA: 0x00852EF3 File Offset: 0x008510F3
		private void GNDPBDHENFI()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.OJFNLIJNPEJ;
		}

		// Token: 0x06013592 RID: 79250 RVA: 0x00852F0C File Offset: 0x0085110C
		private void JIOKDOGNKMI()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OFPMFGNPGDJ;
		}

		// Token: 0x06013593 RID: 79251 RVA: 0x00852F31 File Offset: 0x00851131
		private void CABDFNIKOOI()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.LBOIONOEIBI;
		}

		// Token: 0x06013594 RID: 79252 RVA: 0x00852F56 File Offset: 0x00851156
		private void OLHGBCBHDBF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.IJACKJBFFKB;
		}

		// Token: 0x06013595 RID: 79253 RVA: 0x00852F7C File Offset: 0x0085117C
		private void EDABMEEHENI()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x06013596 RID: 79254 RVA: 0x008530B8 File Offset: 0x008512B8
		private void IHCCJFCDKMA()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x06013597 RID: 79255 RVA: 0x008531F3 File Offset: 0x008513F3
		private void HMILPFNLLJM()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.PFBENAPEFBJ));
		}

		// Token: 0x06013598 RID: 79256 RVA: 0x0085320C File Offset: 0x0085140C
		private void LLFANOGKPKM()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.PBMAFHADDAI));
		}

		// Token: 0x06013599 RID: 79257 RVA: 0x00853225 File Offset: 0x00851425
		private void MPNHAGONKBG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.GKCKEPBPPOK;
		}

		// Token: 0x0601359A RID: 79258 RVA: 0x0085324C File Offset: 0x0085144C
		private void HMAPNLPBAJK()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x0601359B RID: 79259 RVA: 0x00853387 File Offset: 0x00851587
		private void DCPLMIMFNHG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OJFNLIJNPEJ;
		}

		// Token: 0x0601359C RID: 79260 RVA: 0x008533AC File Offset: 0x008515AC
		private void EACKHNENAML()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.JHBGMDLAFNF));
		}

		// Token: 0x0601359D RID: 79261 RVA: 0x008533C5 File Offset: 0x008515C5
		private void JIGLHJINLFH()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.PIAEJIDABIO));
		}

		// Token: 0x0601359E RID: 79262 RVA: 0x008533DE File Offset: 0x008515DE
		private void OnDisable()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.DCMHPEKEEDD;
		}

		// Token: 0x0601359F RID: 79263 RVA: 0x008533F8 File Offset: 0x008515F8
		private void DOPHLAJKCBD()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135A0 RID: 79264 RVA: 0x00853534 File Offset: 0x00851734
		private void JPFBFAGJCEK()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135A1 RID: 79265 RVA: 0x00853670 File Offset: 0x00851870
		private void MAILABPOKEP()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135A2 RID: 79266 RVA: 0x008533AC File Offset: 0x008515AC
		private void IJKMOJONNNH()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.JHBGMDLAFNF));
		}

		// Token: 0x060135A3 RID: 79267 RVA: 0x00852B01 File Offset: 0x00850D01
		private void BGKOJIDABKB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.FMLHEGPJPAN;
		}

		// Token: 0x060135A4 RID: 79268 RVA: 0x008537AB File Offset: 0x008519AB
		private void EILDKNMOKBB()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.DOPHLAJKCBD));
		}

		// Token: 0x060135A6 RID: 79270 RVA: 0x008537E2 File Offset: 0x008519E2
		private void PIPJPGGEFOL()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.GKCKEPBPPOK));
		}

		// Token: 0x060135A7 RID: 79271 RVA: 0x008537FC File Offset: 0x008519FC
		private void PBMAFHADDAI()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135A8 RID: 79272 RVA: 0x00852824 File Offset: 0x00850A24
		private void MLPCBOGCEEO()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.IHCCJFCDKMA));
		}

		// Token: 0x060135A9 RID: 79273 RVA: 0x00853938 File Offset: 0x00851B38
		private void BOKBDGMLHDF()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135AA RID: 79274 RVA: 0x00853A73 File Offset: 0x00851C73
		private void ACJNCDAHJDE()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.LBOIONOEIBI));
		}

		// Token: 0x060135AB RID: 79275 RVA: 0x00853A8C File Offset: 0x00851C8C
		private void PMPIJLKEBPH()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135AC RID: 79276 RVA: 0x00853BC7 File Offset: 0x00851DC7
		private void EEHJEDIFHJI()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.BFPLCNFCLGF;
		}

		// Token: 0x060135AD RID: 79277 RVA: 0x00853BEC File Offset: 0x00851DEC
		private void EIDIHAJDMCI()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.HJCCCKKCEAA));
		}

		// Token: 0x060135AE RID: 79278 RVA: 0x00853C08 File Offset: 0x00851E08
		private void HJCCCKKCEAA()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135AF RID: 79279 RVA: 0x00853D43 File Offset: 0x00851F43
		private void PEKNHINKHCK()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.PFBENAPEFBJ;
		}

		// Token: 0x060135B0 RID: 79280 RVA: 0x00853D5C File Offset: 0x00851F5C
		private void DCMHPEKEEDD()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135B1 RID: 79281 RVA: 0x00853E97 File Offset: 0x00852097
		private void FJBPGBMDBBF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.IHCCJFCDKMA;
		}

		// Token: 0x060135B2 RID: 79282 RVA: 0x00853EBC File Offset: 0x008520BC
		private void FKPHBAOKEOF()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.PMPIJLKEBPH));
		}

		// Token: 0x060135B3 RID: 79283 RVA: 0x00853ED5 File Offset: 0x008520D5
		private void CPLDNPIDPPM()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.JPFBFAGJCEK;
		}

		// Token: 0x060135B4 RID: 79284 RVA: 0x00852B01 File Offset: 0x00850D01
		private void MOJBLBHKCCM()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.FMLHEGPJPAN;
		}

		// Token: 0x060135B5 RID: 79285 RVA: 0x00853EF0 File Offset: 0x008520F0
		private void PIAEJIDABIO()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135B6 RID: 79286 RVA: 0x00853ED5 File Offset: 0x008520D5
		private void AOILKGIIKDF()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.JPFBFAGJCEK;
		}

		// Token: 0x060135B7 RID: 79287 RVA: 0x00853E97 File Offset: 0x00852097
		private void ECHEPDJBGLP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.IHCCJFCDKMA;
		}

		// Token: 0x060135B8 RID: 79288 RVA: 0x0085402C File Offset: 0x0085222C
		private void BFPLCNFCLGF()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135B9 RID: 79289 RVA: 0x00852B01 File Offset: 0x00850D01
		private void ACCKEFCOBGN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.FMLHEGPJPAN;
		}

		// Token: 0x060135BA RID: 79290 RVA: 0x008533AC File Offset: 0x008515AC
		private void IDLLAMOBGGO()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.JHBGMDLAFNF));
		}

		// Token: 0x060135BB RID: 79291 RVA: 0x00854167 File Offset: 0x00852367
		private void DNPKJPPIHOO()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.PFBENAPEFBJ;
		}

		// Token: 0x060135BC RID: 79292 RVA: 0x0085418C File Offset: 0x0085238C
		private void NIOMOLMCNOO()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.OFPMFGNPGDJ));
		}

		// Token: 0x060135BD RID: 79293 RVA: 0x008541A5 File Offset: 0x008523A5
		private void PCKEAEAHAKG()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.PIAEJIDABIO));
		}

		// Token: 0x060135BE RID: 79294 RVA: 0x008541C0 File Offset: 0x008523C0
		private void HMJDEOEHFHA()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 1)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135BF RID: 79295 RVA: 0x008542FB File Offset: 0x008524FB
		private void NCHGOOPEDKC()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.DCMHPEKEEDD));
		}

		// Token: 0x060135C0 RID: 79296 RVA: 0x008533AC File Offset: 0x008515AC
		private void MKBPPPJKLLF()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.JHBGMDLAFNF));
		}

		// Token: 0x060135C1 RID: 79297 RVA: 0x00854314 File Offset: 0x00852514
		private void LBOIONOEIBI()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 1];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = false;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = true;
				if (this.GDILALKKEIL.points.Count > 0)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 1);
				}
			}
		}

		// Token: 0x060135C2 RID: 79298 RVA: 0x0085444F File Offset: 0x0085264F
		private void FGHHAIDJNMM()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.OFPMFGNPGDJ));
		}

		// Token: 0x060135C3 RID: 79299 RVA: 0x00854468 File Offset: 0x00852668
		private void JHBGMDLAFNF()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(new Ray(base.transform.position, -Vector3.up), out raycastHit, this.maxDist))
			{
				if (this.GDILALKKEIL.emit && this.GDILALKKEIL.points.Count > 0)
				{
					AraTrail.LDEOHJDCBLI ldeohjdcbli = this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0];
					if (!ldeohjdcbli.LCPICMGIEEA)
					{
						ldeohjdcbli.LJGHBOFJDBJ = raycastHit.normal;
						ldeohjdcbli.MGALEAJOGPL = raycastHit.point + raycastHit.normal * this.offset;
						this.GDILALKKEIL.points[this.GDILALKKEIL.points.Count - 0] = ldeohjdcbli;
					}
				}
				this.GDILALKKEIL.emit = true;
				return;
			}
			if (this.GDILALKKEIL.emit)
			{
				this.GDILALKKEIL.emit = false;
				if (this.GDILALKKEIL.points.Count > 1)
				{
					this.GDILALKKEIL.points.RemoveAt(this.GDILALKKEIL.points.Count - 0);
				}
			}
		}

		// Token: 0x060135C4 RID: 79300 RVA: 0x00852433 File Offset: 0x00850633
		private void FDMGAGCBBDP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.NMKGMIDDPEM;
		}

		// Token: 0x040027D1 RID: 10193
		private AraTrail GDILALKKEIL;

		// Token: 0x040027D2 RID: 10194
		public float offset = 0.05f;

		// Token: 0x040027D3 RID: 10195
		public float maxDist = 0.1f;
	}
}
