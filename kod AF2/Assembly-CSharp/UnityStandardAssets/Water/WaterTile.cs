using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002FA RID: 762
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		// Token: 0x0600B228 RID: 45608 RVA: 0x004DAFE4 File Offset: 0x004D91E4
		private void KMPEADJIJGK()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x004DB080 File Offset: 0x004D9280
		public void NOKJMMDMJNO()
		{
			this.AMBCLFBBJAL();
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x004DB088 File Offset: 0x004D9288
		public void OnWillRenderObject()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x004DB0DC File Offset: 0x004D92DC
		private void IMINJPJKCFM()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x004DB178 File Offset: 0x004D9378
		private void NOJGKDICFFG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x004DB214 File Offset: 0x004D9414
		private void MDDCHEGNLNL()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x004DB2B0 File Offset: 0x004D94B0
		private void FAGHBFKHDLI()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x004DB34C File Offset: 0x004D954C
		private void ABFFCNNKPFF()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x004DB3E8 File Offset: 0x004D95E8
		public void FJGIBCHABIG()
		{
			this.FOPCKHLOICB();
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x004DB3F0 File Offset: 0x004D95F0
		public void OOOBKFIBLBF()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.LCOJBNJCCGP(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x004DB444 File Offset: 0x004D9644
		public void MEDOEFBLEGK()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.ONKGDNDDMCC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x004DB498 File Offset: 0x004D9698
		public void PMHPAKHOIPG()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.OJLNFCEAMDM(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x004DB4EC File Offset: 0x004D96EC
		public void FKFIGONKFMA()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MCOFNLDMNEK(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x004DB540 File Offset: 0x004D9740
		private void JIMOCAGIMNF()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x004DB5DC File Offset: 0x004D97DC
		private void BMOLIEDCEHH()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x004DB678 File Offset: 0x004D9878
		private void KACIFDGLBBN()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x004DB714 File Offset: 0x004D9914
		public void DDEBDCGNCPC()
		{
			this.OBOGOFGCIGG();
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x004DB71C File Offset: 0x004D991C
		private void ICNACELCFBK()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x004DB7B8 File Offset: 0x004D99B8
		public void FJEPPLCOMJO()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.EOCJAEMELDE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x004DB80C File Offset: 0x004D9A0C
		private void AMBCLFBBJAL()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x004DB8A8 File Offset: 0x004D9AA8
		public void JOPKHOCJLHC()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.BHCFIAAJGOE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x004DB8FC File Offset: 0x004D9AFC
		private void OODDLJKNDCD()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x004DB998 File Offset: 0x004D9B98
		public void ACLJDJBJLCD()
		{
			this.JDMEHJMKHLO();
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x004DB9A0 File Offset: 0x004D9BA0
		private void PJOOIAMEOFE()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x004DBA3C File Offset: 0x004D9C3C
		public void COGEPIKHGMD()
		{
			if (this.reflection)
			{
				this.reflection.KPIEAMKEJFL(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.DHCCCDPDOKE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x004DBA90 File Offset: 0x004D9C90
		public void HMODJFIBGAD()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.GPHAFBEKAGP(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x004DB3E8 File Offset: 0x004D95E8
		public void DNLFEOECBKI()
		{
			this.FOPCKHLOICB();
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x004DBAE4 File Offset: 0x004D9CE4
		public void HCFPNEKDANO()
		{
			if (this.reflection)
			{
				this.reflection.KPIEAMKEJFL(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.OPKMFJGDNGC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x004DBB37 File Offset: 0x004D9D37
		public void BJHGPFGBFKF()
		{
			this.MAPLPNMIMEO();
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x004DBB3F File Offset: 0x004D9D3F
		public void DHJDMKLBLEF()
		{
			this.MHBKIAKPNHM();
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x004DBB48 File Offset: 0x004D9D48
		private void LLLKGCEBLBD()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x004DBB3F File Offset: 0x004D9D3F
		public void OPNPODKLOJK()
		{
			this.MHBKIAKPNHM();
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x004DBBE4 File Offset: 0x004D9DE4
		public void CBLGFOFHNPJ()
		{
			this.JIMOCAGIMNF();
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x004DBBEC File Offset: 0x004D9DEC
		private void DEDILOPLGDC()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x004DB080 File Offset: 0x004D9280
		public void JHFAHBIIJDC()
		{
			this.AMBCLFBBJAL();
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x004DBC88 File Offset: 0x004D9E88
		private void MPKPJPCJHCG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x004DBD24 File Offset: 0x004D9F24
		public void GHCMIKGJPJD()
		{
			this.KKCLCDFIMHL();
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x004DBD2C File Offset: 0x004D9F2C
		public void CDDONHAJKEE()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MDGEHGHGHPC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x004DBD80 File Offset: 0x004D9F80
		private void JDMEHJMKHLO()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x004DBE1C File Offset: 0x004DA01C
		public void IMFMAPJABON()
		{
			if (this.reflection)
			{
				this.reflection.KPIEAMKEJFL(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.DLMLACACBHN(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x004DBE70 File Offset: 0x004DA070
		public void KJGAFOGKCAJ()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.ICBLEOLOHHC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x004DBEC3 File Offset: 0x004DA0C3
		public void AOCDDBNBADJ()
		{
			this.LLLKGCEBLBD();
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x004DBECC File Offset: 0x004DA0CC
		public void JCJFGMBHAEF()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x004DBD24 File Offset: 0x004D9F24
		public void LHJCHPFKGDB()
		{
			this.KKCLCDFIMHL();
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x004DBF20 File Offset: 0x004DA120
		public void MDEKCFONBCB()
		{
			if (this.reflection)
			{
				this.reflection.KPIEAMKEJFL(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MLBEPLKPFHO(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x004DBF73 File Offset: 0x004DA173
		public void EHFPLKEINFO()
		{
			this.OODDLJKNDCD();
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x004DBEC3 File Offset: 0x004DA0C3
		public void CKIGGCAHAFD()
		{
			this.LLLKGCEBLBD();
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x004DBF7C File Offset: 0x004DA17C
		private void OLHMKDOLIGA()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x004DC018 File Offset: 0x004DA218
		public void OAPBLKMHFEJ()
		{
			if (this.reflection)
			{
				this.reflection.GADDIBGNHDH(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.OJLNFCEAMDM(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x004DC06C File Offset: 0x004DA26C
		public void DJACMACBHIF()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MDGEHGHGHPC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x004DC0C0 File Offset: 0x004DA2C0
		private void IOCLDLNKMDD()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x004DC15C File Offset: 0x004DA35C
		public void Start()
		{
			this.MDDCHEGNLNL();
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x004DC164 File Offset: 0x004DA364
		private void HFBKHNGNCEP()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x004DC200 File Offset: 0x004DA400
		public void PPNNGMABLNH()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MDGEHGHGHPC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x004DC254 File Offset: 0x004DA454
		public void CLEIGHNCJIB()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.EOCJAEMELDE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x004DC2A8 File Offset: 0x004DA4A8
		private void ILNHACDEAPG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x004DBBE4 File Offset: 0x004D9DE4
		public void JPHBPEAMNHB()
		{
			this.JIMOCAGIMNF();
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x004DC344 File Offset: 0x004DA544
		public void IMABGALEMBI()
		{
			this.KEMHPOAOBEE();
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x004DC34C File Offset: 0x004DA54C
		public void PLBDELOIINH()
		{
			this.MLKCNIOJAKJ();
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x004DC354 File Offset: 0x004DA554
		public void GPIAJDJPGKJ()
		{
			if (this.reflection)
			{
				this.reflection.GADDIBGNHDH(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.BNMNMGMEPKB(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x004DC344 File Offset: 0x004DA544
		public void KFGKKLAKFGH()
		{
			this.KEMHPOAOBEE();
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x004DC3A8 File Offset: 0x004DA5A8
		private void CLNEHGODHLE()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x004DC444 File Offset: 0x004DA644
		private void DJHBGKHFBNE()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x004DC4E0 File Offset: 0x004DA6E0
		public void PMDPLLIBJAF()
		{
			this.MGAHEKGJDAO();
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x004DC4E8 File Offset: 0x004DA6E8
		public void NCBLFNKNEDK()
		{
			this.LDOOHMPJDNN();
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x004DC4F0 File Offset: 0x004DA6F0
		private void MHBKIAKPNHM()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x004DC58C File Offset: 0x004DA78C
		private void JNHMKBPDFFC()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x004DC628 File Offset: 0x004DA828
		private void JPBHIPDHCMJ()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x004DC6C4 File Offset: 0x004DA8C4
		public void ELFLOPJDAKK()
		{
			this.BHMACIJGEIH();
		}

		// Token: 0x0600B26D RID: 45677 RVA: 0x004DC6CC File Offset: 0x004DA8CC
		public void FFIGGPHAIBP()
		{
			this.KACIFDGLBBN();
		}

		// Token: 0x0600B26E RID: 45678 RVA: 0x004DC6D4 File Offset: 0x004DA8D4
		public void FPLHODJCJDO()
		{
			this.JPBHIPDHCMJ();
		}

		// Token: 0x0600B26F RID: 45679 RVA: 0x004DC6DC File Offset: 0x004DA8DC
		private void KEMHPOAOBEE()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x004DC778 File Offset: 0x004DA978
		private void MLKCNIOJAKJ()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B271 RID: 45681 RVA: 0x004DC814 File Offset: 0x004DAA14
		public void BBFPILBIMKC()
		{
			this.JNHMKBPDFFC();
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x004DC81C File Offset: 0x004DAA1C
		private void KKCLCDFIMHL()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x004DC8B8 File Offset: 0x004DAAB8
		public void PCDFBHKCDNN()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MDGEHGHGHPC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x004DC344 File Offset: 0x004DA544
		public void MAGJOJDOGKH()
		{
			this.KEMHPOAOBEE();
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x004DC90C File Offset: 0x004DAB0C
		public void HDHILNBFIKD()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.GEEIBHMFPBB(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x004DC960 File Offset: 0x004DAB60
		public void DLNEFOLDJHJ()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.IBFPHPEMKLE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x004DC9B4 File Offset: 0x004DABB4
		private void MAPLPNMIMEO()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x004DCA50 File Offset: 0x004DAC50
		public void IIHNDJOIMAH()
		{
			this.HFBKHNGNCEP();
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x004DC15C File Offset: 0x004DA35C
		public void CLHGHANANNL()
		{
			this.MDDCHEGNLNL();
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x004DCA58 File Offset: 0x004DAC58
		private void LDOOHMPJDNN()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x004DCAF4 File Offset: 0x004DACF4
		private void BGPACGLFELP()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x004DC6D4 File Offset: 0x004DA8D4
		public void LMEJKAEIDCO()
		{
			this.JPBHIPDHCMJ();
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x004DCB90 File Offset: 0x004DAD90
		private void DDCCDAHIHJG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x004DBBE4 File Offset: 0x004D9DE4
		public void OBJCOJEHLBE()
		{
			this.JIMOCAGIMNF();
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x004DB714 File Offset: 0x004D9914
		public void KIEIPFFEDHC()
		{
			this.OBOGOFGCIGG();
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x004DCC2C File Offset: 0x004DAE2C
		private void FOPCKHLOICB()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x004DCCC8 File Offset: 0x004DAEC8
		public void HNGBAECBONC()
		{
			if (this.reflection)
			{
				this.reflection.GADDIBGNHDH(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.BHCFIAAJGOE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x004DCD1B File Offset: 0x004DAF1B
		public void IJOCHELLKJH()
		{
			this.KMPEADJIJGK();
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x004DCD24 File Offset: 0x004DAF24
		private void OBOGOFGCIGG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x004DCDC0 File Offset: 0x004DAFC0
		private void FALLAKBDDGG()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x004DCE5C File Offset: 0x004DB05C
		public void LPPHBFPDMCO()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.WaterTileBeingRendered(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B287 RID: 45703 RVA: 0x004DCEAF File Offset: 0x004DB0AF
		public void CHDJGEOFHEE()
		{
			this.CLNEHGODHLE();
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x004DCEB8 File Offset: 0x004DB0B8
		public void EPDIKCBACNP()
		{
			if (this.reflection)
			{
				this.reflection.KPIEAMKEJFL(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.BHCCJFONEFM(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x004DCF0C File Offset: 0x004DB10C
		private void FNCKEIJFPPK()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x004DCFA8 File Offset: 0x004DB1A8
		public void GKINAANFCMK()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.MNMIINCGLGI(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x004DCFFC File Offset: 0x004DB1FC
		public void JDCPHOIHGHE()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.BGPPMFDGNBJ(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x004DD050 File Offset: 0x004DB250
		private void GAFCNAKEGNA()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x004DD0EC File Offset: 0x004DB2EC
		private void DGHFLADAAEI()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x004DD188 File Offset: 0x004DB388
		public void GIAJDAGCEDB()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.OPKMFJGDNGC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x004DD1DC File Offset: 0x004DB3DC
		private void FFOANPCIIMD()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x004DC6D4 File Offset: 0x004DA8D4
		public void CAJLCEPLKJG()
		{
			this.JPBHIPDHCMJ();
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x004DCA50 File Offset: 0x004DAC50
		public void EHDPACPIBNF()
		{
			this.HFBKHNGNCEP();
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x004DD278 File Offset: 0x004DB478
		public void HHGGCBLOJGB()
		{
			this.IMINJPJKCFM();
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x004DD280 File Offset: 0x004DB480
		public void OBIKBHPHKPD()
		{
			if (this.reflection)
			{
				this.reflection.KMMINDLBNBJ(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.LFPHCKLMJPF(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x004DC6C4 File Offset: 0x004DA8C4
		public void MKNPFMEMOJO()
		{
			this.BHMACIJGEIH();
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x004DCA50 File Offset: 0x004DAC50
		public void LHMNFJBJBJM()
		{
			this.HFBKHNGNCEP();
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x004DD2D3 File Offset: 0x004DB4D3
		public void KGICJDGIIJK()
		{
			this.DDCCDAHIHJG();
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x004DC15C File Offset: 0x004DA35C
		public void GDIMBBBPIHI()
		{
			this.MDDCHEGNLNL();
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x004DD2DC File Offset: 0x004DB4DC
		public void DAHPIEAHIDL()
		{
			if (this.reflection)
			{
				this.reflection.LADPPALPAJA(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.FNKNJCMBAND(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x004DCA50 File Offset: 0x004DAC50
		public void LBEFOABPMFG()
		{
			this.HFBKHNGNCEP();
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x004DD278 File Offset: 0x004DB478
		public void MMACLBBMDLA()
		{
			this.IMINJPJKCFM();
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x004DCD1B File Offset: 0x004DAF1B
		public void GGBMJFNGHMC()
		{
			this.KMPEADJIJGK();
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x004DD32F File Offset: 0x004DB52F
		public void ECMAANIDEBA()
		{
			this.GAFCNAKEGNA();
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x004DD338 File Offset: 0x004DB538
		public void ENKFKPEMMFC()
		{
			if (this.reflection)
			{
				this.reflection.BHBLLHMHMOM(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.OPKMFJGDNGC(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x004DD38C File Offset: 0x004DB58C
		private void BHMACIJGEIH()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x004DC4E8 File Offset: 0x004DA6E8
		public void CGNGBFFGGBP()
		{
			this.LDOOHMPJDNN();
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x004DD428 File Offset: 0x004DB628
		public void OMJEEANMPDB()
		{
			if (this.reflection)
			{
				this.reflection.WaterTileBeingRendered(base.transform, Camera.current);
			}
			if (this.waterBase)
			{
				this.waterBase.EOCJAEMELDE(base.transform, Camera.current);
			}
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x004DC6C4 File Offset: 0x004DA8C4
		public void MCHAAIIHOKD()
		{
			this.BHMACIJGEIH();
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x004DD47C File Offset: 0x004DB67C
		private void BNCLOCNFHKD()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x004DD518 File Offset: 0x004DB718
		private void MGAHEKGJDAO()
		{
			if (!this.reflection)
			{
				if (base.transform.parent)
				{
					this.reflection = base.transform.parent.GetComponent<PlanarReflection>();
				}
				else
				{
					this.reflection = base.transform.GetComponent<PlanarReflection>();
				}
			}
			if (!this.waterBase)
			{
				if (base.transform.parent)
				{
					this.waterBase = base.transform.parent.GetComponent<WaterBase>();
					return;
				}
				this.waterBase = base.transform.GetComponent<WaterBase>();
			}
		}

		// Token: 0x04001690 RID: 5776
		public PlanarReflection reflection;

		// Token: 0x04001691 RID: 5777
		public WaterBase waterBase;
	}
}
