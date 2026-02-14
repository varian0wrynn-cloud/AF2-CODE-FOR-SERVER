using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004B6 RID: 1206
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x0601071F RID: 67359 RVA: 0x0075515C File Offset: 0x0075335C
		public AimPoser.Pose BHNDGDPGLMN(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].DKIFEMGFCMI(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010720 RID: 67360 RVA: 0x007551B4 File Offset: 0x007533B4
		public void ECNDGDMACMJ(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].GGPFLANOOFK((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1145f);
			}
		}

		// Token: 0x06010721 RID: 67361 RVA: 0x007551FC File Offset: 0x007533FC
		public AimPoser.Pose NGPMCMICFJE(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].DOILMLKACOG(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010722 RID: 67362 RVA: 0x00755254 File Offset: 0x00753454
		public void NKOEEMANECA(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].GGPFLANOOFK((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1137f);
			}
		}

		// Token: 0x06010723 RID: 67363 RVA: 0x0075529C File Offset: 0x0075349C
		public void PAIKPBLAANH(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].CJPOBAPANPL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 632f);
			}
		}

		// Token: 0x06010724 RID: 67364 RVA: 0x007552E4 File Offset: 0x007534E4
		public AimPoser.Pose FAOHOMHDKLI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].DOKNLNIJDMK(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010725 RID: 67365 RVA: 0x0075533C File Offset: 0x0075353C
		public AimPoser.Pose HKKHAJKODGE(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010726 RID: 67366 RVA: 0x00755394 File Offset: 0x00753594
		public void GFIICNMANKB(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].GGPFLANOOFK((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1537f);
			}
		}

		// Token: 0x06010727 RID: 67367 RVA: 0x007553DC File Offset: 0x007535DC
		public AimPoser.Pose CCLFHPNJAFH(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].DOKNLNIJDMK(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00755434 File Offset: 0x00753634
		public void DBDFJDDHNBD(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].ONKFNHPGNEC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 128f);
			}
		}

		// Token: 0x06010729 RID: 67369 RVA: 0x0075547C File Offset: 0x0075367C
		public AimPoser.Pose ADBFFBLDDGD(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].CPKAGGHCHAP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601072A RID: 67370 RVA: 0x007554D4 File Offset: 0x007536D4
		public AimPoser.Pose FFPNKKNDAFN(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601072B RID: 67371 RVA: 0x0075552C File Offset: 0x0075372C
		public void JDNJMGLCPEB(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].CJPOBAPANPL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 395f);
			}
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x00755590 File Offset: 0x00753790
		public AimPoser.Pose KLJEJCDBFOI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601072E RID: 67374 RVA: 0x007555E8 File Offset: 0x007537E8
		public AimPoser.Pose BLJNLJCPALL(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601072F RID: 67375 RVA: 0x00755640 File Offset: 0x00753840
		public AimPoser.Pose OHLHFFHLKAO(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].CNFMOANLJND(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010730 RID: 67376 RVA: 0x00755698 File Offset: 0x00753898
		public void GGMKIPIINOP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].ONKFNHPGNEC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 286f);
			}
		}

		// Token: 0x06010731 RID: 67377 RVA: 0x007556E0 File Offset: 0x007538E0
		public void MIJGGFFLOCJ(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].MGCPEKNEFMJ((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1099f);
			}
		}

		// Token: 0x06010732 RID: 67378 RVA: 0x00755728 File Offset: 0x00753928
		public void BLHAECABJML(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 238f);
			}
		}

		// Token: 0x06010733 RID: 67379 RVA: 0x00755770 File Offset: 0x00753970
		public void LAMKMGJBNNM(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].CJPOBAPANPL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1794f);
			}
		}

		// Token: 0x06010734 RID: 67380 RVA: 0x007557B8 File Offset: 0x007539B8
		public void OOKHDDMDLOD(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].GHGFDMIIIII((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1085f);
			}
		}

		// Token: 0x06010735 RID: 67381 RVA: 0x00755800 File Offset: 0x00753A00
		public void HDCLILILBKB(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1510f);
			}
		}

		// Token: 0x06010736 RID: 67382 RVA: 0x00755848 File Offset: 0x00753A48
		public void EEOFMINNFFJ(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].HGIMPNDJIGI((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 232f);
			}
		}

		// Token: 0x06010737 RID: 67383 RVA: 0x00755890 File Offset: 0x00753A90
		public void APCDNACAEIO(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1971f);
			}
		}

		// Token: 0x06010738 RID: 67384 RVA: 0x007558D8 File Offset: 0x00753AD8
		public void CCHBIHPOECA(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1502f);
			}
		}

		// Token: 0x06010739 RID: 67385 RVA: 0x00755920 File Offset: 0x00753B20
		public void SetPoseActive(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].JIDIPNIBKFC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 0f);
			}
		}

		// Token: 0x0601073A RID: 67386 RVA: 0x00755968 File Offset: 0x00753B68
		public void OLGIELLNFMF(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].NCLEOHNPGID((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1755f);
			}
		}

		// Token: 0x0601073B RID: 67387 RVA: 0x007559B0 File Offset: 0x00753BB0
		public AimPoser.Pose DLOFFIOGELD(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].CNPINEPFGNP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601073C RID: 67388 RVA: 0x00755A08 File Offset: 0x00753C08
		public void IIDOHGOKLNB(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].GGPFLANOOFK((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 123f);
			}
		}

		// Token: 0x0601073D RID: 67389 RVA: 0x00755A50 File Offset: 0x00753C50
		public void KEOHFGFGHGA(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].KLJBJFGOBAH((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 647f);
			}
		}

		// Token: 0x0601073E RID: 67390 RVA: 0x00755A98 File Offset: 0x00753C98
		public AimPoser.Pose MDFCOJDOOKD(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].DOKNLNIJDMK(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601073F RID: 67391 RVA: 0x00755AF0 File Offset: 0x00753CF0
		public void CPAOIHCMNEF(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 477f);
			}
		}

		// Token: 0x06010740 RID: 67392 RVA: 0x00755B38 File Offset: 0x00753D38
		public AimPoser.Pose NBJNDIIPFAH(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].FODJCFKLOLH(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010741 RID: 67393 RVA: 0x00755B90 File Offset: 0x00753D90
		public AimPoser.Pose EIKGIFDEFOC(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].FODJCFKLOLH(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010742 RID: 67394 RVA: 0x00755BE8 File Offset: 0x00753DE8
		public void LNBNLFOLHNP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].NCLEOHNPGID((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1394f);
			}
		}

		// Token: 0x06010743 RID: 67395 RVA: 0x00755C30 File Offset: 0x00753E30
		public AimPoser.Pose BCJBMOOMGHL(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010744 RID: 67396 RVA: 0x00755C88 File Offset: 0x00753E88
		public void BLHDAJCKKCL(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 194f);
			}
		}

		// Token: 0x06010745 RID: 67397 RVA: 0x00755CD0 File Offset: 0x00753ED0
		public void IIKAIKJKJAA(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1587f);
			}
		}

		// Token: 0x06010746 RID: 67398 RVA: 0x00755D18 File Offset: 0x00753F18
		public AimPoser.Pose ENJDBNCGMFM(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].CPKAGGHCHAP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010747 RID: 67399 RVA: 0x00755D70 File Offset: 0x00753F70
		public AimPoser.Pose PNJDGHBCKAI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].DKIFEMGFCMI(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010748 RID: 67400 RVA: 0x00755DC8 File Offset: 0x00753FC8
		public void OLGCFJIOACP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1215f);
			}
		}

		// Token: 0x06010749 RID: 67401 RVA: 0x00755E10 File Offset: 0x00754010
		public AimPoser.Pose EGFFLHAHIGH(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].DKIFEMGFCMI(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601074A RID: 67402 RVA: 0x00755E68 File Offset: 0x00754068
		public AimPoser.Pose HKKKBMCLDNO(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].ILKNDLPGGOB(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x00755EC0 File Offset: 0x007540C0
		public void OAFAOPCNAAD(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1722f);
			}
		}

		// Token: 0x0601074C RID: 67404 RVA: 0x00755F08 File Offset: 0x00754108
		public AimPoser.Pose MPCAFENHPMI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601074D RID: 67405 RVA: 0x00755F60 File Offset: 0x00754160
		public AimPoser.Pose GDKAFNPJGFD(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].CNFMOANLJND(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601074E RID: 67406 RVA: 0x00755FB8 File Offset: 0x007541B8
		public void NBBNENDBDCP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].ONKFNHPGNEC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 540f);
			}
		}

		// Token: 0x0601074F RID: 67407 RVA: 0x00756000 File Offset: 0x00754200
		public void KAEGIEIBGHD(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 146f);
			}
		}

		// Token: 0x06010750 RID: 67408 RVA: 0x00756048 File Offset: 0x00754248
		public void GAAMCKJFFFP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1283f);
			}
		}

		// Token: 0x06010751 RID: 67409 RVA: 0x00756090 File Offset: 0x00754290
		public AimPoser.Pose IDIKNODEAKM(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].OMBPCHJAAOB(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010752 RID: 67410 RVA: 0x007560E8 File Offset: 0x007542E8
		public void MMDKLGJDMCN(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].HGIMPNDJIGI((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 976f);
			}
		}

		// Token: 0x06010753 RID: 67411 RVA: 0x00756130 File Offset: 0x00754330
		public void CBADJMEDAHC(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1869f);
			}
		}

		// Token: 0x06010754 RID: 67412 RVA: 0x00756178 File Offset: 0x00754378
		public AimPoser.Pose JKAEHFFJJKL(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010755 RID: 67413 RVA: 0x007561D0 File Offset: 0x007543D0
		public void FPKKPENLMMI(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].GHGFDMIIIII((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1316f);
			}
		}

		// Token: 0x06010756 RID: 67414 RVA: 0x00756218 File Offset: 0x00754418
		public AimPoser.Pose EFHMAJHDPGF(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].IJFPNHHFNIL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010757 RID: 67415 RVA: 0x00756270 File Offset: 0x00754470
		public AimPoser.Pose OBCGDCHEPIA(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].DOKNLNIJDMK(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010758 RID: 67416 RVA: 0x007562C8 File Offset: 0x007544C8
		public AimPoser.Pose CKMNFIAGAOP(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].AIAELFDAFBM(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010759 RID: 67417 RVA: 0x00756320 File Offset: 0x00754520
		public AimPoser.Pose ENPLOFBGGLE(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].DOILMLKACOG(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601075A RID: 67418 RVA: 0x00756378 File Offset: 0x00754578
		public void DHHHPDLIBEJ(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].GHGFDMIIIII((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1279f);
			}
		}

		// Token: 0x0601075B RID: 67419 RVA: 0x007563C0 File Offset: 0x007545C0
		public AimPoser.Pose BLHCDBCHJDL(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].CNPINEPFGNP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601075C RID: 67420 RVA: 0x00756418 File Offset: 0x00754618
		public void MIJMCOMEAMM(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 69f);
			}
		}

		// Token: 0x0601075D RID: 67421 RVA: 0x00756460 File Offset: 0x00754660
		public AimPoser.Pose NNOHDABBIAN(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601075E RID: 67422 RVA: 0x007564B8 File Offset: 0x007546B8
		public AimPoser.Pose HPFOHEGPNDN(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601075F RID: 67423 RVA: 0x00756510 File Offset: 0x00754710
		public void AOEBMPGGIIK(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].CJPOBAPANPL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 434f);
			}
		}

		// Token: 0x06010760 RID: 67424 RVA: 0x00756558 File Offset: 0x00754758
		public void PNDNHHDEFGC(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].FFMDFIDEPDN((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1502f);
			}
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x007565A0 File Offset: 0x007547A0
		public void OKEDLBKOAKK(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].JIDIPNIBKFC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 61f);
			}
		}

		// Token: 0x06010762 RID: 67426 RVA: 0x007565E8 File Offset: 0x007547E8
		public void PIBNAKFPCEF(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1268f);
			}
		}

		// Token: 0x06010763 RID: 67427 RVA: 0x00756630 File Offset: 0x00754830
		public AimPoser.Pose PDHKDPGACND(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].PHCILNIOKHH(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010764 RID: 67428 RVA: 0x00756688 File Offset: 0x00754888
		public void JJIAOLLBCOP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 284f);
			}
		}

		// Token: 0x06010765 RID: 67429 RVA: 0x007566D0 File Offset: 0x007548D0
		public AimPoser.Pose NNOLHECBMAH(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].IJFPNHHFNIL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010766 RID: 67430 RVA: 0x00756728 File Offset: 0x00754928
		public AimPoser.Pose ILIDENNJEOK(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010767 RID: 67431 RVA: 0x00756780 File Offset: 0x00754980
		public void EOLGFBMJGFP(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].KCNLEHIABCM((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1290f);
			}
		}

		// Token: 0x06010768 RID: 67432 RVA: 0x007567C8 File Offset: 0x007549C8
		public AimPoser.Pose LBMFHAFPPGK(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].AIAELFDAFBM(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010769 RID: 67433 RVA: 0x00756820 File Offset: 0x00754A20
		public AimPoser.Pose DBDBMMDJCPF(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601076A RID: 67434 RVA: 0x00756878 File Offset: 0x00754A78
		public AimPoser.Pose MHPMGIHJHKK(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].DOILMLKACOG(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601076B RID: 67435 RVA: 0x007568D0 File Offset: 0x00754AD0
		public AimPoser.Pose GetPose(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].CPKAGGHCHAP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601076C RID: 67436 RVA: 0x00756928 File Offset: 0x00754B28
		public void HKEKLAIHBAK(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].JIDIPNIBKFC((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1788f);
			}
		}

		// Token: 0x0601076D RID: 67437 RVA: 0x00756970 File Offset: 0x00754B70
		public AimPoser.Pose HBIJLBEHHBB(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].BCPDMIOOJPC(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601076E RID: 67438 RVA: 0x007569C8 File Offset: 0x00754BC8
		public AimPoser.Pose CMJIBBBPADF(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].OMBPCHJAAOB(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601076F RID: 67439 RVA: 0x00756A20 File Offset: 0x00754C20
		public void KMCDNNENHOL(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i += 0)
			{
				this.poses[i].GHGFDMIIIII((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1121f);
			}
		}

		// Token: 0x06010770 RID: 67440 RVA: 0x00756A68 File Offset: 0x00754C68
		public AimPoser.Pose LMNBCJJPHCK(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].PHCILNIOKHH(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010771 RID: 67441 RVA: 0x00756AC0 File Offset: 0x00754CC0
		public void JLHPICMNAOA(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].KCNLEHIABCM((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1692f);
			}
		}

		// Token: 0x06010772 RID: 67442 RVA: 0x00756B08 File Offset: 0x00754D08
		public AimPoser.Pose HJDFJIHNDFJ(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 1; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].ANDPBIECCPN(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010773 RID: 67443 RVA: 0x00756B60 File Offset: 0x00754D60
		public AimPoser.Pose CMGHLIKFEMB(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].CNFMOANLJND(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010774 RID: 67444 RVA: 0x00756BB8 File Offset: 0x00754DB8
		public void GLDCBIMNKON(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1209f);
			}
		}

		// Token: 0x06010775 RID: 67445 RVA: 0x00756C00 File Offset: 0x00754E00
		public AimPoser.Pose GLCKCHIOGKO(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i += 0)
			{
				if (this.poses[i].LHGJFDEIFMM(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010776 RID: 67446 RVA: 0x00756C58 File Offset: 0x00754E58
		public AimPoser.Pose NJBJDAOCMIM(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].LHGJFDEIFMM(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x06010777 RID: 67447 RVA: 0x00756CB0 File Offset: 0x00754EB0
		public void FNBPPEJMDMN(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].KLJBJFGOBAH((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 408f);
			}
		}

		// Token: 0x06010778 RID: 67448 RVA: 0x00756CF8 File Offset: 0x00754EF8
		public AimPoser.Pose FDDIPPCBDFB(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i++)
			{
				if (this.poses[i].BMEJLCNNCLL(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x06010779 RID: 67449 RVA: 0x00756D50 File Offset: 0x00754F50
		public AimPoser.Pose GLCOBOHPJNJ(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].PHCILNIOKHH(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601077A RID: 67450 RVA: 0x00756DA8 File Offset: 0x00754FA8
		public void EPAPKMEDCKF(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i += 0)
			{
				this.poses[i].GHGFDMIIIII((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1958f);
			}
		}

		// Token: 0x0601077B RID: 67451 RVA: 0x00756DF0 File Offset: 0x00754FF0
		public void MEBJGDFMDNH(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].GLCKNBFJEFL((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1566f);
			}
		}

		// Token: 0x0601077C RID: 67452 RVA: 0x00756E38 File Offset: 0x00755038
		public AimPoser.Pose JBLPPGKKHHI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].CNPINEPFGNP(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 0];
		}

		// Token: 0x0601077D RID: 67453 RVA: 0x00756E90 File Offset: 0x00755090
		public AimPoser.Pose HGBLFLCOCOI(Vector3 JLKJKPIICJK)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 0; i += 0)
			{
				if (this.poses[i].LHGJFDEIFMM(JLKJKPIICJK))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x0601077E RID: 67454 RVA: 0x00756EE8 File Offset: 0x007550E8
		public void AEEBBMCKMJJ(AimPoser.Pose LFICKGCLIOC)
		{
			for (int i = 1; i < this.poses.Length; i++)
			{
				this.poses[i].KNDBMJOFECB((this.poses[i] == LFICKGCLIOC) ? this.angleBuffer : 1521f);
			}
		}

		// Token: 0x04002265 RID: 8805
		public float angleBuffer = 5f;

		// Token: 0x04002266 RID: 8806
		public AimPoser.Pose[] poses = new AimPoser.Pose[0];

		// Token: 0x020004B7 RID: 1207
		[Serializable]
		public class Pose
		{
			// Token: 0x0601077F RID: 67455 RVA: 0x00756F2D File Offset: 0x0075512D
			public void KCNLEHIABCM(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010780 RID: 67456 RVA: 0x00756F38 File Offset: 0x00755138
			public bool OMBPCHJAAOB(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 573f || this.pitch <= 1842f)
				{
					return true;
				}
				if (this.yaw < 266f)
				{
					Vector3 forward = new Vector3(this.direction.x, 76f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 8f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 1609f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010781 RID: 67457 RVA: 0x00756F2D File Offset: 0x0075512D
			public void GLCKNBFJEFL(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010782 RID: 67458 RVA: 0x00757028 File Offset: 0x00755228
			public bool ANDPBIECCPN(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 1106f || this.pitch <= 551f)
				{
					return true;
				}
				if (this.yaw < 3f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1779f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1051f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 26f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010783 RID: 67459 RVA: 0x00756F2D File Offset: 0x0075512D
			public void GHGFDMIIIII(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010784 RID: 67460 RVA: 0x00757118 File Offset: 0x00755318
			public bool PHCILNIOKHH(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 92f || this.pitch <= 191f)
				{
					return false;
				}
				if (this.yaw < 1759f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1969f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1211f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 793f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010785 RID: 67461 RVA: 0x00756F2D File Offset: 0x0075512D
			public void NCLEOHNPGID(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010786 RID: 67462 RVA: 0x00756F2D File Offset: 0x0075512D
			public void KNDBMJOFECB(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010787 RID: 67463 RVA: 0x00757208 File Offset: 0x00755408
			public bool DOILMLKACOG(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 184f || this.pitch <= 1822f)
				{
					return false;
				}
				if (this.yaw < 1688f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1763f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 417f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 122f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010788 RID: 67464 RVA: 0x00756F2D File Offset: 0x0075512D
			public void JIDIPNIBKFC(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010789 RID: 67465 RVA: 0x00756F2D File Offset: 0x0075512D
			public void ONKFNHPGNEC(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x0601078A RID: 67466 RVA: 0x007572F8 File Offset: 0x007554F8
			public bool DKIFEMGFCMI(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 720f || this.pitch <= 328f)
				{
					return true;
				}
				if (this.yaw < 1208f)
				{
					Vector3 forward = new Vector3(this.direction.x, 184f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1058f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 1628f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601078B RID: 67467 RVA: 0x007573E8 File Offset: 0x007555E8
			public bool LHGJFDEIFMM(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 1380f || this.pitch <= 1189f)
				{
					return false;
				}
				if (this.yaw < 276f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1088f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1673f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 719f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601078C RID: 67468 RVA: 0x007574D8 File Offset: 0x007556D8
			public bool DOKNLNIJDMK(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 1879f || this.pitch <= 1260f)
				{
					return true;
				}
				if (this.yaw < 558f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1979f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 17f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 1219f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601078D RID: 67469 RVA: 0x007575C8 File Offset: 0x007557C8
			public bool BCPDMIOOJPC(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 1159f || this.pitch <= 1413f)
				{
					return false;
				}
				if (this.yaw < 1775f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1952f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1995f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 375f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601078E RID: 67470 RVA: 0x007576B8 File Offset: 0x007558B8
			public bool IJFPNHHFNIL(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 628f || this.pitch <= 78f)
				{
					return true;
				}
				if (this.yaw < 705f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1804f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 980f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 1556f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601078F RID: 67471 RVA: 0x00756F2D File Offset: 0x0075512D
			public void GGPFLANOOFK(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010790 RID: 67472 RVA: 0x007577A8 File Offset: 0x007559A8
			public bool CNFMOANLJND(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 1440f || this.pitch <= 1186f)
				{
					return false;
				}
				if (this.yaw < 1716f)
				{
					Vector3 forward = new Vector3(this.direction.x, 524f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 716f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 1931f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010791 RID: 67473 RVA: 0x00756F2D File Offset: 0x0075512D
			public void HGIMPNDJIGI(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010792 RID: 67474 RVA: 0x00756F2D File Offset: 0x0075512D
			public void FFMDFIDEPDN(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010793 RID: 67475 RVA: 0x00757898 File Offset: 0x00755A98
			public bool IEKOKMJLLOH(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 1657f || this.pitch <= 1672f)
				{
					return true;
				}
				if (this.yaw < 388f)
				{
					Vector3 forward = new Vector3(this.direction.x, 245f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 723f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 772f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010794 RID: 67476 RVA: 0x00756F2D File Offset: 0x0075512D
			public void CJPOBAPANPL(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x06010796 RID: 67478 RVA: 0x007579AC File Offset: 0x00755BAC
			public bool ILKNDLPGGOB(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 1923f || this.pitch <= 1739f)
				{
					return false;
				}
				if (this.yaw < 1073f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1247f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1869f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 61f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010797 RID: 67479 RVA: 0x00757A9C File Offset: 0x00755C9C
			public bool CNPINEPFGNP(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 1949f || this.pitch <= 1148f)
				{
					return true;
				}
				if (this.yaw < 586f)
				{
					Vector3 forward = new Vector3(this.direction.x, 253f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1360f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 930f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010798 RID: 67480 RVA: 0x00757B8C File Offset: 0x00755D8C
			public bool FODJCFKLOLH(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 274f || this.pitch <= 1595f)
				{
					return true;
				}
				if (this.yaw < 929f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1013f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 1506f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 196f)
				{
					return false;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x06010799 RID: 67481 RVA: 0x00756F2D File Offset: 0x0075512D
			public void KLJBJFGOBAH(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x0601079A RID: 67482 RVA: 0x00757C7C File Offset: 0x00755E7C
			public bool CPKAGGHCHAP(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 0f || this.pitch <= 0f)
				{
					return false;
				}
				if (this.yaw < 180f)
				{
					Vector3 forward = new Vector3(this.direction.x, 0f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 0f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 180f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601079B RID: 67483 RVA: 0x00756F2D File Offset: 0x0075512D
			public void MGCPEKNEFMJ(float DCCPCBLODIG)
			{
				this.angleBuffer = DCCPCBLODIG;
			}

			// Token: 0x0601079C RID: 67484 RVA: 0x00757D6C File Offset: 0x00755F6C
			public bool BMEJLCNNCLL(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return true;
				}
				if (this.yaw <= 588f || this.pitch <= 68f)
				{
					return false;
				}
				if (this.yaw < 962f)
				{
					Vector3 forward = new Vector3(this.direction.x, 1147f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 675f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 1771f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x0601079D RID: 67485 RVA: 0x00757E5C File Offset: 0x0075605C
			public bool AIAELFDAFBM(Vector3 MBFGBDLOKFH)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 202f || this.pitch <= 578f)
				{
					return false;
				}
				if (this.yaw < 455f)
				{
					Vector3 forward = new Vector3(this.direction.x, 208f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(MBFGBDLOKFH.x, 285f, MBFGBDLOKFH.z), forward) > this.yaw + this.angleBuffer)
					{
						return true;
					}
				}
				if (this.pitch >= 743f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, MBFGBDLOKFH) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x04002267 RID: 8807
			public bool visualize = true;

			// Token: 0x04002268 RID: 8808
			public string name;

			// Token: 0x04002269 RID: 8809
			public Vector3 direction;

			// Token: 0x0400226A RID: 8810
			public float yaw = 75f;

			// Token: 0x0400226B RID: 8811
			public float pitch = 45f;

			// Token: 0x0400226C RID: 8812
			private float angleBuffer;
		}
	}
}
