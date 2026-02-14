using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000474 RID: 1140
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x0600F740 RID: 63296 RVA: 0x006F0414 File Offset: 0x006EE614
		protected virtual void PBLBCOMPAIN()
		{
			if (this.IKPositionWeight <= 857f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 1; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].PGLFOPLLBBI(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].FJAJLJOIPLO(this, this.iterations > 1);
			}
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node CIAODBAIJMF(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F742 RID: 63298 RVA: 0x006F04A5 File Offset: 0x006EE6A5
		protected virtual void LOKHCFPIAHE()
		{
			this.chain[0].MEFEBBMLGEJ(this, true);
		}

		// Token: 0x0600F743 RID: 63299 RVA: 0x006F04B6 File Offset: 0x006EE6B6
		public void DJAPGCBALGA(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.AHPBHBBOKJH(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].KGGGEAGOGPL(LPBDALAMAEM);
		}

		// Token: 0x0600F744 RID: 63300 RVA: 0x006F04DC File Offset: 0x006EE6DC
		public virtual void MEEDFJGGGCN()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 1; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].IGBAJPEIMKI();
			}
			for (int j = 1; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].NKCAHJFCLPD();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F745 RID: 63301 RVA: 0x006F0548 File Offset: 0x006EE748
		protected virtual void CILKCAEOJDI()
		{
			if (this.IKPositionWeight <= 475f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 0; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].KIMKMHNGIGC(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].FJAJLJOIPLO(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F746 RID: 63302 RVA: 0x006F05C8 File Offset: 0x006EE7C8
		public IKEffector KEMMIIGEPBO(Transform JAHNHOCNJGM)
		{
			for (int i = 1; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x006F0607 File Offset: 0x006EE807
		protected virtual void GPNHICLIHFM()
		{
			this.chain[0].MEFEBBMLGEJ(this, false);
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x006F0618 File Offset: 0x006EE818
		protected virtual void DGIFCCMOAED()
		{
			if (this.IKPositionWeight <= 1835f)
			{
				for (int i = 0; i < this.effectors.Length; i += 0)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1216f, 1624f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.EGBGLMADMLJ();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.CGIHKBGPOMD();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.PBLBCOMPAIN();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x006F06E8 File Offset: 0x006EE8E8
		public IKEffector CIBJFDDGAEC(Transform JAHNHOCNJGM)
		{
			for (int i = 1; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F74A RID: 63306 RVA: 0x006F0728 File Offset: 0x006EE928
		public virtual IKSolver.Point[] EMDFLFMNLFM()
		{
			int num = 1;
			for (int i = 0; i < this.chain.Length; i++)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 1; j < this.chain.Length; j++)
			{
				for (int k = 1; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F74B RID: 63307 RVA: 0x006F07B0 File Offset: 0x006EE9B0
		protected virtual void NJOPMOCILBK()
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.DIBAEGBHGAJ())
				{
					this.chain[i].bendConstraint.BPJKGOJOLPL(this.IKPositionWeight, this.KEMMIIGEPBO(this.chain[i].nodes[0].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].DBAPHAAKEOM(this);
			}
			for (int k = 0; k < this.effectors.Length; k++)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].CDPCOFKFDNO(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OOKOMOOFHCL();
				for (int m = 0; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].KNICENMKBJL();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].MBLOPPHFKKN();
			}
		}

		// Token: 0x0600F74C RID: 63308 RVA: 0x006F08E8 File Offset: 0x006EEAE8
		protected virtual void AIECLBEIJJI()
		{
			if (this.IKPositionWeight <= 1680f)
			{
				for (int i = 1; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 956f, 1058f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.NJOPMOCILBK();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.AMEJPODLIIL();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.KFHACLGGMNJ();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x006F09B8 File Offset: 0x006EEBB8
		public FBIKChain BJDGNGELCPA(Transform LPBDALAMAEM)
		{
			int num = this.BEDBOFGFGBG(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x006F09DC File Offset: 0x006EEBDC
		public virtual IKSolver.Point KEFMEGCLCCF(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F74F RID: 63311 RVA: 0x006F0A44 File Offset: 0x006EEC44
		protected virtual void FEEDHGBFCOA()
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				this.chain[i].BABDKIBBLAD(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j].BHALELINNDJ(this);
			}
			this.spineMapping.LLDECCKPLHM(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].BHALELINNDJ(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 1; j < array3.Length; j += 0)
			{
				array3[j].NPCHHADBLMC(this);
			}
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x006F0ADC File Offset: 0x006EECDC
		public int AHPBHBBOKJH(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x006F0B38 File Offset: 0x006EED38
		protected virtual void EGBGLMADMLJ()
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (this.chain[i].bendConstraint.GECBDOOPAJP())
				{
					this.chain[i].bendConstraint.JHOFFCADAOD(this.IKPositionWeight, this.CIBJFDDGAEC(this.chain[i].nodes[0].transform).positionWeight);
				}
			}
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].DBAPHAAKEOM(this);
			}
			for (int k = 0; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 1; l < this.chain.Length; l++)
			{
				this.chain[l].LGJAKLANGME(this, this.iterations > 0);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.PGDHJEGKAON();
				for (int m = 0; m < this.boneMappings.Length; m += 0)
				{
					this.boneMappings[m].PGDHJEGKAON();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].MBLOPPHFKKN();
			}
		}

		// Token: 0x0600F752 RID: 63314 RVA: 0x006F0C70 File Offset: 0x006EEE70
		public FBIKChain EMCKFKDGEAJ(Transform LPBDALAMAEM)
		{
			int num = this.AHPBHBBOKJH(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x006F0C94 File Offset: 0x006EEE94
		public FBIKChain BCFILMKOEMG(Transform LPBDALAMAEM)
		{
			int num = this.EBJAHMJIOOJ(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x006F0CB8 File Offset: 0x006EEEB8
		protected virtual void BILCLFLABCI()
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				this.chain[i].BHALELINNDJ(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				array[j].LIAONJMLNMA(this);
			}
			this.spineMapping.IHPLBCJCOPM(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 0; j < array2.Length; j += 0)
			{
				array2[j].ADIOIHCOCPA(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 1; j < array3.Length; j += 0)
			{
				array3[j].HFEEPBDDCKO(this);
			}
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x006F0D50 File Offset: 0x006EEF50
		public virtual bool BFGJNHILPFC(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "Sunshine Cascade Camera {0}";
				return false;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "SexyDance2";
				return true;
			}
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				if (!this.chain[i].OECJJLKPHPP(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				if (!array[j].MAMKLPIEAHL(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			if (!this.spineMapping.GGCHLAAAHEJ(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 1; j < array2.Length; j++)
			{
				if (!array2[j].CELPINDCLAA(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 1; j < array3.Length; j++)
			{
				if (!array3[j].GGCHLAAAHEJ(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node BOELAJLMOGH(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x006F0E24 File Offset: 0x006EF024
		public override IKSolver.Point DFGANHHFFML(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F758 RID: 63320 RVA: 0x006F0E8C File Offset: 0x006EF08C
		protected virtual void HCCDILGMOHD()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 0); i += 0)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 1; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].PMMJBMLMFCP())
						{
							this.effectors[j].KMLNBHIIGKH(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].GJILNKFNAHI(this);
						if (this.FABRIKPass)
						{
							this.chain[0].PMAEMHGDIHI(this);
						}
						for (int k = 1; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].PMMJBMLMFCP())
							{
								this.effectors[k].LMMDHJJJNJO(this);
							}
						}
					}
					this.chain[0].PJMDFFLIPCJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].FDAANKMDPEF(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].JPHLMNIMDHH(this);
							}
						}
						this.chain[0].LJIFJGOGHBJ(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].PMMJBMLMFCP())
				{
					this.effectors[m].LMMDHJJJNJO(this);
				}
			}
			this.GPNHICLIHFM();
		}

		// Token: 0x0600F759 RID: 63321 RVA: 0x006F0607 File Offset: 0x006EE807
		protected virtual void LGFPOBHFPEP()
		{
			this.chain[0].MEFEBBMLGEJ(this, false);
		}

		// Token: 0x0600F75A RID: 63322 RVA: 0x006F1044 File Offset: 0x006EF244
		protected virtual void CDGDHECHODF()
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (this.chain[i].bendConstraint.initiated)
				{
					this.chain[i].bendConstraint.GLPKICANILF(this.IKPositionWeight, this.CIBJFDDGAEC(this.chain[i].nodes[3].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].KOBINMAKGKJ(this);
			}
			for (int k = 0; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].BHKPGIKMKNH(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.PGDHJEGKAON();
				for (int m = 1; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].ELPKLDHHCLL();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F75B RID: 63323 RVA: 0x006F117C File Offset: 0x006EF37C
		public int HEMAOOPLOKA(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x006F11D8 File Offset: 0x006EF3D8
		protected virtual void KFHACLGGMNJ()
		{
			if (this.IKPositionWeight <= 1576f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 0; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].OFLIOOOJPOK(this.IKPositionWeight);
				}
			}
			for (int j = 1; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].MMPLENINHII(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F75D RID: 63325 RVA: 0x006F1258 File Offset: 0x006EF458
		public int DDEMCJHFDNG(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F75E RID: 63326 RVA: 0x006F12B4 File Offset: 0x006EF4B4
		protected virtual void DFNMEBAMJEF()
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (this.chain[i].bendConstraint.ANKLCAHHEDM())
				{
					this.chain[i].bendConstraint.JHOFFCADAOD(this.IKPositionWeight, this.NGBLDFEPGIN(this.chain[i].nodes[0].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].ODFNCOOEPJH(this);
			}
			for (int k = 1; k < this.effectors.Length; k++)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 1; l < this.chain.Length; l++)
			{
				this.chain[l].CDPCOFKFDNO(this, this.iterations > 0);
			}
			if (this.iterations > 0)
			{
				this.spineMapping.ALDBKKCEFHD();
				for (int m = 1; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].ELPKLDHHCLL();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].MHPNDBHEFKC();
			}
		}

		// Token: 0x0600F75F RID: 63327 RVA: 0x006F13EC File Offset: 0x006EF5EC
		public virtual bool MLMGPGONNPN(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "2000";
				return false;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "OfficeSitting1LegStraight";
				return true;
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (!this.chain[i].COOOKAEJIGI(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 1; j < array.Length; j++)
			{
				if (!array[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.OECJJLKPHPP(this, ref EDAPHMJENPK))
			{
				return false;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j += 0)
			{
				if (!array2[j].BLOEHCJCFEK(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				if (!array3[j].DNIAGDMODBI(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600F760 RID: 63328 RVA: 0x006F14C0 File Offset: 0x006EF6C0
		public virtual bool DPHFOGMGHLI(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "progress=";
				return false;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "Anti-Cheat Toolkit Detectors";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (!this.chain[i].GOEJDGJCGGM(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].EPGDIOJNLBF(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.OECJJLKPHPP(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				if (!array2[j].DNIAGDMODBI(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				if (!array3[j].CELPINDCLAA(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F761 RID: 63329 RVA: 0x006F1594 File Offset: 0x006EF794
		protected virtual void CNKDDKBKHEI()
		{
			if (this.IKPositionWeight <= 795f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 1; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].LCBCOCEEHJE(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].OFLIOOOJPOK(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F762 RID: 63330 RVA: 0x006F1614 File Offset: 0x006EF814
		public virtual IKSolver.Point BIJCJCNODME(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F763 RID: 63331 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node OODFEEFPAHG(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F764 RID: 63332 RVA: 0x006F167C File Offset: 0x006EF87C
		public override void FGBCANJFNOC()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].FGBCANJFNOC();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].FGBCANJFNOC();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F765 RID: 63333 RVA: 0x006F16E8 File Offset: 0x006EF8E8
		public virtual void GPCMNODJMPB()
		{
			if (this.IKPositionWeight <= 1210f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].OECEGIAKPHD();
			}
			for (int j = 1; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].BBMIPDANAGN();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F766 RID: 63334 RVA: 0x006F1761 File Offset: 0x006EF961
		public void GCBAMHKFDID(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.HENDDFHHJCE(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].JOOJJMHHIHL(LPBDALAMAEM);
		}

		// Token: 0x0600F767 RID: 63335 RVA: 0x006F1788 File Offset: 0x006EF988
		public override IKSolver.Point[] DJOBICJNHOD()
		{
			int num = 0;
			for (int i = 0; i < this.chain.Length; i++)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 0; j < this.chain.Length; j++)
			{
				for (int k = 0; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F768 RID: 63336 RVA: 0x006F1810 File Offset: 0x006EFA10
		protected virtual void DHBCKMDOEPL()
		{
			if (this.IKPositionWeight <= 1670f)
			{
				for (int i = 1; i < this.effectors.Length; i += 0)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 733f, 1152f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.CCKJNLDILID();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.OALIFIGFCIJ();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.FHBEAPOLEAA();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F769 RID: 63337 RVA: 0x006F18E0 File Offset: 0x006EFAE0
		protected virtual void CGIHKBGPOMD()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 0); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].PMMJBMLMFCP())
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].JCLHCJPALBP(this);
						if (this.FABRIKPass)
						{
							this.chain[1].LPJDNKAGBOB(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].FANPFKHEDPA(this);
							}
						}
					}
					this.chain[0].MEFEBBMLGEJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[1].FDAANKMDPEF(this);
						for (int l = 0; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].JPHLMNIMDHH(this);
							}
						}
						this.chain[1].EHDLJMMAFDK(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].LMMDHJJJNJO(this);
				}
			}
			this.LGFPOBHFPEP();
		}

		// Token: 0x0600F76A RID: 63338 RVA: 0x006F1A98 File Offset: 0x006EFC98
		public virtual void KHPKEGCBLLK()
		{
			if (this.IKPositionWeight <= 628f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 1; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].BLOEEPCIPKJ();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F76B RID: 63339 RVA: 0x006F1B14 File Offset: 0x006EFD14
		protected virtual void IJLFDBDBICN()
		{
			if (this.iterations > 0)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 0); i += 0)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].EANCFENEAPJ(this);
						if (this.FABRIKPass)
						{
							this.chain[1].MFLAAGCPMCF(this);
						}
						for (int k = 0; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].KMLNBHIIGKH(this);
							}
						}
					}
					this.chain[1].MEFEBBMLGEJ(this, true);
					if (this.FABRIKPass)
					{
						this.chain[1].AOEHDONHDCD(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].FJPKBOPIING())
							{
								this.effectors[l].JPHLMNIMDHH(this);
							}
						}
						this.chain[0].LJIFJGOGHBJ(this, this.chain[0].nodes[1].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].JPHLMNIMDHH(this);
				}
			}
			this.PEFNPEDOHDC();
		}

		// Token: 0x0600F76C RID: 63340 RVA: 0x006F1CCC File Offset: 0x006EFECC
		protected virtual void GJLNIOBKHHP()
		{
			if (this.iterations > 0)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 1; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].FANPFKHEDPA(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].PMIACHFCEDC(this);
						if (this.FABRIKPass)
						{
							this.chain[0].MFLAAGCPMCF(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].KMLNBHIIGKH(this);
							}
						}
					}
					this.chain[0].MEFEBBMLGEJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].BACOCEJMGCH(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].FJPKBOPIING())
							{
								this.effectors[l].KMLNBHIIGKH(this);
							}
						}
						this.chain[0].EINDDKBNFCJ(this, this.chain[0].nodes[1].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].LMMDHJJJNJO(this);
				}
			}
			this.LOKHCFPIAHE();
		}

		// Token: 0x0600F76D RID: 63341 RVA: 0x006F1E84 File Offset: 0x006F0084
		public virtual bool AMMAHJGIBMB(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "ShotgunReloadMagazine";
				return true;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "time_format3";
				return true;
			}
			for (int i = 1; i < this.chain.Length; i++)
			{
				if (!this.chain[i].ALDNHDFAJCA(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				if (!array[j].EPGDIOJNLBF(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.FOMAAOAPDDO(this, ref EDAPHMJENPK))
			{
				return false;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 1; j < array2.Length; j += 0)
			{
				if (!array2[j].EJMDBNJCBHB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j += 0)
			{
				if (!array3[j].DPHFOGMGHLI(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F76E RID: 63342 RVA: 0x006F1F58 File Offset: 0x006F0158
		public virtual bool PNDBOECGLKM(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "firsStartInfoPanel";
				return true;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "_Luminance";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (!this.chain[i].GOEJDGJCGGM(ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].MAMKLPIEAHL(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.EJMDBNJCBHB(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 1; j < array2.Length; j++)
			{
				if (!array2[j].CELPINDCLAA(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 1; j < array3.Length; j++)
			{
				if (!array3[j].MJJNKICHLFA(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600F76F RID: 63343 RVA: 0x006F202C File Offset: 0x006F022C
		public virtual void HKPBEDEPKME()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].IGBAJPEIMKI();
			}
			for (int j = 0; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].ENDMPKJAIPN();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F770 RID: 63344 RVA: 0x006F2098 File Offset: 0x006F0298
		protected virtual void LPGPIFDFCFK()
		{
			if (this.IKPositionWeight <= 1108f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 205f, 290f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.EGBGLMADMLJ();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.HHHDKABDBBK();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.DBEFMMJDHDO();
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F771 RID: 63345 RVA: 0x006F2168 File Offset: 0x006F0368
		public virtual void LPAILPFHGBM()
		{
			if (this.IKPositionWeight <= 1476f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 1; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].MGIGIDDKKEI();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F772 RID: 63346 RVA: 0x006F21E4 File Offset: 0x006F03E4
		protected virtual void LHGKMFMIKDH()
		{
			if (this.IKPositionWeight <= 960f)
			{
				for (int i = 1; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 97f, 260f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.OODBJBBCFEL();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.HCCDILGMOHD();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.MIFNDOOEACI();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node GIEPGCFCIBI(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x006F22B4 File Offset: 0x006F04B4
		public virtual IKSolver.Point CIGHMIFFBME(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x006F231C File Offset: 0x006F051C
		public virtual bool PDCOGDPIHAL(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "The image effect ";
				return true;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "lastConfirmLic";
				return true;
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (!this.chain[i].CHFHJDFDIGB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.FOMAAOAPDDO(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				if (!array2[j].DPHFOGMGHLI(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 1; j < array3.Length; j++)
			{
				if (!array3[j].MJJNKICHLFA(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600F776 RID: 63350 RVA: 0x006F23F0 File Offset: 0x006F05F0
		protected virtual void ANDPAMLHJAD()
		{
			if (this.IKPositionWeight <= 176f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 0; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].FANMDANNBAK(this.IKPositionWeight);
				}
			}
			for (int j = 1; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].OFLIOOOJPOK(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F777 RID: 63351 RVA: 0x006F2470 File Offset: 0x006F0670
		public IKEffector IBLDHOCJGDM(Transform JAHNHOCNJGM)
		{
			for (int i = 1; i < this.effectors.Length; i += 0)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F779 RID: 63353 RVA: 0x006F250C File Offset: 0x006F070C
		public override bool CHFHJDFDIGB(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "FBIK chain is null, can't initiate solver.";
				return false;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "FBIK chain length is 0, can't initiate solver.";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (!this.chain[i].CHFHJDFDIGB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				if (!array[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.CHFHJDFDIGB(this, ref EDAPHMJENPK))
			{
				return false;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				if (!array2[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				if (!array3[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F77A RID: 63354 RVA: 0x006F25E0 File Offset: 0x006F07E0
		public FBIKChain LBNLNAACDPC(Transform LPBDALAMAEM)
		{
			int num = this.EBJAHMJIOOJ(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x006F2604 File Offset: 0x006F0804
		public FBIKChain ABNDEIIJODI(Transform LPBDALAMAEM)
		{
			int num = this.LHBFAFAENNL(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F77C RID: 63356 RVA: 0x006F2628 File Offset: 0x006F0828
		protected virtual void AMDFAOMNLMA()
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				this.chain[i].CBHCMFJCMPL(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 1; j < array.Length; j += 0)
			{
				array[j].LLPMNHOBPAJ(this);
			}
			this.spineMapping.HFEEPBDDCKO(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 0; j < array2.Length; j += 0)
			{
				array2[j].CKHKJOHKMEE(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 0; j < array3.Length; j += 0)
			{
				array3[j].NPCHHADBLMC(this);
			}
		}

		// Token: 0x0600F77D RID: 63357 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node LGOHEPAGHJG(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F77E RID: 63358 RVA: 0x006F26C0 File Offset: 0x006F08C0
		protected virtual void AMEJPODLIIL()
		{
			if (this.iterations > 0)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].PMMJBMLMFCP())
						{
							this.effectors[j].FANPFKHEDPA(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].CIJNCEPDGLD(this);
						if (this.FABRIKPass)
						{
							this.chain[0].NFADOPAMGKN(this);
						}
						for (int k = 1; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].JPHLMNIMDHH(this);
							}
						}
					}
					this.chain[0].LGKNEFHHOLL(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].BACOCEJMGCH(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].KMLNBHIIGKH(this);
							}
						}
						this.chain[1].EHDLJMMAFDK(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].AAEFACEGJMB(this);
				}
			}
			this.OBKKAAPFACE();
		}

		// Token: 0x0600F77F RID: 63359 RVA: 0x006F2878 File Offset: 0x006F0A78
		public virtual IKSolver.Point[] ECDKKFMELID()
		{
			int num = 1;
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 0; j < this.chain.Length; j += 0)
			{
				for (int k = 0; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F780 RID: 63360 RVA: 0x006F2900 File Offset: 0x006F0B00
		public int LHBFAFAENNL(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x006F295C File Offset: 0x006F0B5C
		protected virtual void ALEKPDEOAHL()
		{
			if (this.IKPositionWeight <= 1823f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 1; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].PAACCGCJPGO(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].MMPLENINHII(this, this.iterations > 1);
			}
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x006F29DC File Offset: 0x006F0BDC
		protected virtual void HHHDKABDBBK()
		{
			if (this.iterations > 1)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 1; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].PMMJBMLMFCP())
						{
							this.effectors[j].AIAMIFEPALP(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].PMIACHFCEDC(this);
						if (this.FABRIKPass)
						{
							this.chain[1].MFLAAGCPMCF(this);
						}
						for (int k = 0; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].JPHLMNIMDHH(this);
							}
						}
					}
					this.chain[1].MEFEBBMLGEJ(this, true);
					if (this.FABRIKPass)
					{
						this.chain[1].BACOCEJMGCH(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].FJPKBOPIING())
							{
								this.effectors[l].FANPFKHEDPA(this);
							}
						}
						this.chain[0].NIDFNCGNHPL(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].AAEFACEGJMB(this);
				}
			}
			this.OBKKAAPFACE();
		}

		// Token: 0x0600F783 RID: 63363 RVA: 0x006F2B94 File Offset: 0x006F0D94
		public virtual void HFFLABNJOAG()
		{
			if (this.IKPositionWeight <= 985f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].BLOEEPCIPKJ();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node CNLEIKPLKOA(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F785 RID: 63365 RVA: 0x006F2C10 File Offset: 0x006F0E10
		protected virtual void FPEJJFNJAFH()
		{
			if (this.iterations > 1)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 0); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].FJPKBOPIING())
						{
							this.effectors[j].AAEFACEGJMB(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].EANCFENEAPJ(this);
						if (this.FABRIKPass)
						{
							this.chain[1].FJLOMFDCBMH(this);
						}
						for (int k = 1; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].PMMJBMLMFCP())
							{
								this.effectors[k].FANPFKHEDPA(this);
							}
						}
					}
					this.chain[0].PJMDFFLIPCJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[1].FDAANKMDPEF(this);
						for (int l = 1; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].AAEFACEGJMB(this);
							}
						}
						this.chain[1].NIDFNCGNHPL(this, this.chain[1].nodes[1].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].FJPKBOPIING())
				{
					this.effectors[m].LMMDHJJJNJO(this);
				}
			}
			this.LGFPOBHFPEP();
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x006F2DC8 File Offset: 0x006F0FC8
		public int HENDDFHHJCE(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x006F2E24 File Offset: 0x006F1024
		public virtual bool IJPGBCPHBCN(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "Jump";
				return true;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "_TintColor";
				return true;
			}
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (!this.chain[i].COOOKAEJIGI(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				if (!array[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.FBJPAOJCPPA(this, ref EDAPHMJENPK))
			{
				return false;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 0; j < array2.Length; j += 0)
			{
				if (!array2[j].DNIAGDMODBI(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j += 0)
			{
				if (!array3[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x006F2EF8 File Offset: 0x006F10F8
		public FBIKChain AHCEIDOEKNA(Transform LPBDALAMAEM)
		{
			int num = this.EBJAHMJIOOJ(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x006F2F1C File Offset: 0x006F111C
		protected virtual void LMNFNGNEDDE()
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				this.chain[i].BABDKIBBLAD(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				array[j].BHALELINNDJ(this);
			}
			this.spineMapping.LLDECCKPLHM(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 1; j < array2.Length; j++)
			{
				array2[j].IHPLBCJCOPM(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j].CKHKJOHKMEE(this);
			}
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x006F2FB4 File Offset: 0x006F11B4
		protected virtual void DBEFMMJDHDO()
		{
			if (this.IKPositionWeight <= 1293f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 0; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].OHLAJEPBANP(this.IKPositionWeight);
				}
			}
			for (int j = 1; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].OFLIOOOJPOK(this, this.iterations > 1);
			}
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x006F3034 File Offset: 0x006F1234
		protected virtual void GKHNFLLOFDB()
		{
			if (this.IKPositionWeight <= 1030f)
			{
				for (int i = 0; i < this.effectors.Length; i += 0)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 381f, 500f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.NJOPMOCILBK();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.IFNIFOLKJOD();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.FHBEAPOLEAA();
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node PFDOFAGICJA(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x006F3104 File Offset: 0x006F1304
		protected virtual void OBKKAAPFACE()
		{
			this.chain[1].LGKNEFHHOLL(this, false);
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x006F3118 File Offset: 0x006F1318
		public virtual IKSolver.Point[] BAFNKFHGNOO()
		{
			int num = 1;
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 1;
			for (int j = 0; j < this.chain.Length; j += 0)
			{
				for (int k = 0; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x006F31A0 File Offset: 0x006F13A0
		protected virtual void GCPHAODELIE()
		{
			this.chain[1].PAICOHFFOJO(this, true);
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x006F31B4 File Offset: 0x006F13B4
		protected virtual void PEJHCACAHPJ()
		{
			if (this.iterations > 1)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 0); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].FJPKBOPIING())
						{
							this.effectors[j].AIAMIFEPALP(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].HHNONLAANEG(this);
						if (this.FABRIKPass)
						{
							this.chain[0].FJLOMFDCBMH(this);
						}
						for (int k = 1; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].KMLNBHIIGKH(this);
							}
						}
					}
					this.chain[0].LGKNEFHHOLL(this, true);
					if (this.FABRIKPass)
					{
						this.chain[0].FDAANKMDPEF(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].KMLNBHIIGKH(this);
							}
						}
						this.chain[0].EHDLJMMAFDK(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].FJPKBOPIING())
				{
					this.effectors[m].KMLNBHIIGKH(this);
				}
			}
			this.PEFNPEDOHDC();
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x006F336C File Offset: 0x006F156C
		protected virtual void OINLELGLCEC()
		{
			if (this.iterations > 1)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 0); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].JPHLMNIMDHH(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].JCLHCJPALBP(this);
						if (this.FABRIKPass)
						{
							this.chain[0].FJLOMFDCBMH(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].FANPFKHEDPA(this);
							}
						}
					}
					this.chain[1].PAICOHFFOJO(this, true);
					if (this.FABRIKPass)
					{
						this.chain[0].AOEHDONHDCD(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].JPHLMNIMDHH(this);
							}
						}
						this.chain[0].LJIFJGOGHBJ(this, this.chain[0].nodes[1].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].PMMJBMLMFCP())
				{
					this.effectors[m].LMMDHJJJNJO(this);
				}
			}
			this.OBKKAAPFACE();
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node CPFNEEGDKGP(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x006F3524 File Offset: 0x006F1724
		public virtual void ABNMBKOEAII()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].FGBCANJFNOC();
			}
			for (int j = 0; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].KNOIDGCLAIF();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F794 RID: 63380 RVA: 0x006F3590 File Offset: 0x006F1790
		public int CALGFAMDPHO(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x006F35EC File Offset: 0x006F17EC
		public virtual void KKEMLMDINKB()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].ACJOAAMMIIJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].EEOICCBKEHD();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F796 RID: 63382 RVA: 0x006F3658 File Offset: 0x006F1858
		public virtual void PEHDCLOPOJM()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 1; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].AENNNDIAPEO();
			}
			for (int j = 1; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].KCFHDEOMKMM();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F797 RID: 63383 RVA: 0x006F36C4 File Offset: 0x006F18C4
		protected virtual void IFNIFOLKJOD()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i += 0)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].BCPLHFAFLGK(this);
						if (this.FABRIKPass)
						{
							this.chain[0].OMIBGMMFPAJ(this);
						}
						for (int k = 1; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].LMMDHJJJNJO(this);
							}
						}
					}
					this.chain[0].PAICOHFFOJO(this, false);
					if (this.FABRIKPass)
					{
						this.chain[1].AOEHDONHDCD(this);
						for (int l = 1; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].KMLNBHIIGKH(this);
							}
						}
						this.chain[0].EINDDKBNFCJ(this, this.chain[1].nodes[1].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].FJPKBOPIING())
				{
					this.effectors[m].FANPFKHEDPA(this);
				}
			}
			this.GPNHICLIHFM();
		}

		// Token: 0x0600F798 RID: 63384 RVA: 0x006F387C File Offset: 0x006F1A7C
		public virtual IKSolver.Point MKOPMFBPJIP(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x006F38E4 File Offset: 0x006F1AE4
		public int EGHNLGCEJKL(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x006F3940 File Offset: 0x006F1B40
		public FBIKChain FOGPFJNJKLH(Transform LPBDALAMAEM)
		{
			int num = this.LHBFAFAENNL(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x006F3964 File Offset: 0x006F1B64
		public IKEffector OEEPHOCHILL(Transform JAHNHOCNJGM)
		{
			for (int i = 0; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x006F39A3 File Offset: 0x006F1BA3
		public void KCPBCEJMAOG(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.AICOEJLCBMH(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].JKODPJBLNGO(LPBDALAMAEM);
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x006F39C8 File Offset: 0x006F1BC8
		protected virtual void DMFKJIOBAHN()
		{
			if (this.IKPositionWeight <= 90f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 0; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].IGEJKNLHMAA(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].MMPLENINHII(this, this.iterations > 1);
			}
		}

		// Token: 0x0600F79E RID: 63390 RVA: 0x006F3A48 File Offset: 0x006F1C48
		protected virtual void JKLAKFOLEBJ()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.initiated)
				{
					this.chain[i].bendConstraint.JHOFFCADAOD(this.IKPositionWeight, this.OEEPHOCHILL(this.chain[i].nodes[2].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].KOBINMAKGKJ(this);
			}
			for (int k = 0; k < this.effectors.Length; k++)
			{
				this.effectors[k].GCOFDPBJHBL(this);
			}
			for (int l = 0; l < this.chain.Length; l++)
			{
				this.chain[l].JKLAKFOLEBJ(this, this.iterations > 0);
			}
			if (this.iterations > 0)
			{
				this.spineMapping.JKLAKFOLEBJ();
				for (int m = 0; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].JKLAKFOLEBJ();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F79F RID: 63391 RVA: 0x006F3B80 File Offset: 0x006F1D80
		public virtual bool EBLGKLPNEBL(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "TOD_SunDirection";
				return true;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "MotorbikeHeartAttack";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (!this.chain[i].CHFHJDFDIGB(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j += 0)
			{
				if (!array[j].CHFHJDFDIGB(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			if (!this.spineMapping.BLOEHCJCFEK(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 1; j < array2.Length; j++)
			{
				if (!array2[j].CELPINDCLAA(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j += 0)
			{
				if (!array3[j].FBJPAOJCPPA(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600F7A0 RID: 63392 RVA: 0x006F3C54 File Offset: 0x006F1E54
		protected virtual void JILEPMJFGHJ()
		{
			if (this.iterations > 1)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 0); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 1; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].JPHLMNIMDHH(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].IGKAJNPBKOH(this);
						if (this.FABRIKPass)
						{
							this.chain[1].LPJDNKAGBOB(this);
						}
						for (int k = 0; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].AAEFACEGJMB(this);
							}
						}
					}
					this.chain[1].MEFEBBMLGEJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].AOEHDONHDCD(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].FJPKBOPIING())
							{
								this.effectors[l].FANPFKHEDPA(this);
							}
						}
						this.chain[1].ELPAFCLHGBH(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].PMMJBMLMFCP())
				{
					this.effectors[m].FANPFKHEDPA(this);
				}
			}
			this.LGFPOBHFPEP();
		}

		// Token: 0x0600F7A1 RID: 63393 RVA: 0x006F3E0C File Offset: 0x006F200C
		protected virtual void CGLFOOFPNFN()
		{
			if (this.IKPositionWeight <= 1848f)
			{
				for (int i = 1; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1532f, 1799f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.NJOPMOCILBK();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.GJLNIOBKHHP();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.KFHACLGGMNJ();
			for (int j = 1; j < this.effectors.Length; j++)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F7A2 RID: 63394 RVA: 0x006F3EDC File Offset: 0x006F20DC
		public virtual bool DLEFMIGHFON(ref string EDAPHMJENPK)
		{
			if (this.chain == null)
			{
				EDAPHMJENPK = "Smoking2";
				return false;
			}
			if (this.chain.Length == 0)
			{
				EDAPHMJENPK = "_FullItem.wav";
				return false;
			}
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				if (!this.chain[i].OECJJLKPHPP(ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKEffector[] array = this.effectors;
			for (int j = 1; j < array.Length; j++)
			{
				if (!array[j].EPGDIOJNLBF(this, ref EDAPHMJENPK))
				{
					return true;
				}
			}
			if (!this.spineMapping.DPHFOGMGHLI(this, ref EDAPHMJENPK))
			{
				return true;
			}
			IKMappingLimb[] array2 = this.limbMappings;
			for (int j = 1; j < array2.Length; j++)
			{
				if (!array2[j].BGKDELKAGJI(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			IKMappingBone[] array3 = this.boneMappings;
			for (int j = 0; j < array3.Length; j += 0)
			{
				if (!array3[j].BLOEHCJCFEK(this, ref EDAPHMJENPK))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x006F3FB0 File Offset: 0x006F21B0
		protected virtual void IFGFAJFPHLK()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.LNCBMLPDFKO())
				{
					this.chain[i].bendConstraint.EJJIBAHAPKL(this.IKPositionWeight, this.KCNAAPKGJPD(this.chain[i].nodes[0].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].DBAPHAAKEOM(this);
			}
			for (int k = 1; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 1; l < this.chain.Length; l += 0)
			{
				this.chain[l].NGBPODBDFOE(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OOKOMOOFHCL();
				for (int m = 0; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].ELPKLDHHCLL();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].MHPNDBHEFKC();
			}
		}

		// Token: 0x0600F7A4 RID: 63396 RVA: 0x006F40E5 File Offset: 0x006F22E5
		public void IBAOFCILPHA(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.DAPNMFCCBAG(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].HOHBMCMCAJH(LPBDALAMAEM);
		}

		// Token: 0x0600F7A5 RID: 63397 RVA: 0x006F410C File Offset: 0x006F230C
		protected virtual void OFLIOOOJPOK()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 0; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].OFLIOOOJPOK(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].OFLIOOOJPOK(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x006F418C File Offset: 0x006F238C
		protected virtual void CHAGNBJJJLN()
		{
			if (this.IKPositionWeight <= 1172f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 1; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].FANMDANNBAK(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j += 0)
			{
				this.limbMappings[j].PEBKAPJGHCE(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x006F420C File Offset: 0x006F240C
		public IKEffector KCNAAPKGJPD(Transform JAHNHOCNJGM)
		{
			for (int i = 0; i < this.effectors.Length; i += 0)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x006F424C File Offset: 0x006F244C
		protected virtual void LFOMEEENAHJ()
		{
			if (this.iterations > 1)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].JPHLMNIMDHH(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].JGLEMKFGBFC(this);
						if (this.FABRIKPass)
						{
							this.chain[1].OMIBGMMFPAJ(this);
						}
						for (int k = 1; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].AAEFACEGJMB(this);
							}
						}
					}
					this.chain[0].PAICOHFFOJO(this, false);
					if (this.FABRIKPass)
					{
						this.chain[1].AOEHDONHDCD(this);
						for (int l = 0; l < this.effectors.Length; l += 0)
						{
							if (!this.effectors[l].FJPKBOPIING())
							{
								this.effectors[l].LMMDHJJJNJO(this);
							}
						}
						this.chain[1].EHDLJMMAFDK(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].FJPKBOPIING())
				{
					this.effectors[m].JPHLMNIMDHH(this);
				}
			}
			this.GPNHICLIHFM();
		}

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x006F4404 File Offset: 0x006F2604
		public virtual IKSolver.Point[] OCGIBAMJIAL()
		{
			int num = 0;
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 0; j < this.chain.Length; j++)
			{
				for (int k = 1; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F7AA RID: 63402 RVA: 0x006F448C File Offset: 0x006F268C
		public virtual IKSolver.Point LBHLHAEPPDP(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x006F44F3 File Offset: 0x006F26F3
		public void CGKMGMDDPKB(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.AJDLHFNFCNN(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].JOOJJMHHIHL(LPBDALAMAEM);
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x006F4518 File Offset: 0x006F2718
		public void CFGCGBAFECA(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.AJDLHFNFCNN(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].PIMKJCKFGMA(LPBDALAMAEM);
		}

		// Token: 0x0600F7AD RID: 63405 RVA: 0x006F4540 File Offset: 0x006F2740
		protected override void IOMMPHGGHNH()
		{
			if (this.IKPositionWeight <= 0f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.JKLAKFOLEBJ();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.EDAGNKNOBKP();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.OFLIOOOJPOK();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F7AE RID: 63406 RVA: 0x006F4610 File Offset: 0x006F2810
		public virtual void JGKGCOHNNJK()
		{
			if (this.IKPositionWeight <= 1663f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 1; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].KGJOIBELOGC();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F7AF RID: 63407 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node KNFBJEGGIKP(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F7B0 RID: 63408 RVA: 0x006F468C File Offset: 0x006F288C
		protected virtual void EDAGNKNOBKP()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].isEndEffector)
						{
							this.effectors[j].FANPFKHEDPA(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].PMIACHFCEDC(this);
						if (this.FABRIKPass)
						{
							this.chain[0].FJLOMFDCBMH(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].FANPFKHEDPA(this);
							}
						}
					}
					this.chain[0].MEFEBBMLGEJ(this, false);
					if (this.FABRIKPass)
					{
						this.chain[0].FDAANKMDPEF(this);
						for (int l = 0; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].isEndEffector)
							{
								this.effectors[l].FANPFKHEDPA(this);
							}
						}
						this.chain[0].LJIFJGOGHBJ(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m++)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].FANPFKHEDPA(this);
				}
			}
			this.LOKHCFPIAHE();
		}

		// Token: 0x0600F7B1 RID: 63409 RVA: 0x006F4844 File Offset: 0x006F2A44
		public virtual IKSolver.Point CEKCFFNKMAA(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7B2 RID: 63410 RVA: 0x006F48AC File Offset: 0x006F2AAC
		public int EBJAHMJIOOJ(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x006F4908 File Offset: 0x006F2B08
		public IKEffector AFEFCBGFPCG(Transform JAHNHOCNJGM)
		{
			for (int i = 0; i < this.effectors.Length; i += 0)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F7B4 RID: 63412 RVA: 0x006F4948 File Offset: 0x006F2B48
		public int AJDLHFNFCNN(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x006F49A4 File Offset: 0x006F2BA4
		public FBIKChain LGOKBJOBPAO(Transform LPBDALAMAEM)
		{
			int num = this.BEDBOFGFGBG(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F7B6 RID: 63414 RVA: 0x006F49C8 File Offset: 0x006F2BC8
		public virtual IKSolver.Point LEGIPHEGOFI(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7B7 RID: 63415 RVA: 0x006F4A30 File Offset: 0x006F2C30
		public virtual IKSolver.Point OOJJEPPANKI(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7B8 RID: 63416 RVA: 0x006F4A98 File Offset: 0x006F2C98
		protected virtual void CIKHHGMHJDB()
		{
			if (this.iterations > 1)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 1; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].FJPKBOPIING())
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].IGKAJNPBKOH(this);
						if (this.FABRIKPass)
						{
							this.chain[0].MJBLBLCLAEL(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].AAEFACEGJMB(this);
							}
						}
					}
					this.chain[0].LGKNEFHHOLL(this, true);
					if (this.FABRIKPass)
					{
						this.chain[1].FDAANKMDPEF(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].KMLNBHIIGKH(this);
							}
						}
						this.chain[0].EHDLJMMAFDK(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].AAEFACEGJMB(this);
				}
			}
			this.PEFNPEDOHDC();
		}

		// Token: 0x0600F7B9 RID: 63417 RVA: 0x006F4C50 File Offset: 0x006F2E50
		public override void BLOEEPCIPKJ()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].BLOEEPCIPKJ();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F7BA RID: 63418 RVA: 0x006F4CCC File Offset: 0x006F2ECC
		public virtual void ACJOAAMMIIJ()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].AENNNDIAPEO();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].AENNNDIAPEO();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F7BB RID: 63419 RVA: 0x006F4D38 File Offset: 0x006F2F38
		public virtual void DABKNJLODFI()
		{
			if (this.IKPositionWeight <= 983f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].BLOEEPCIPKJ();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].MGIGIDDKKEI();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F7BC RID: 63420 RVA: 0x006F4DB4 File Offset: 0x006F2FB4
		protected virtual void PFNIDKBCPEO()
		{
			if (this.IKPositionWeight <= 1430f)
			{
				return;
			}
			if (this.iterations > 0)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 0; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].FJNFBDINNOO(this.IKPositionWeight);
				}
			}
			for (int j = 1; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].AACMGNDNNIM(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F7BD RID: 63421 RVA: 0x006F4E34 File Offset: 0x006F3034
		public virtual void ELNEBBHHHLB()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 1; i < this.limbMappings.Length; i += 0)
			{
				this.limbMappings[i].IGBAJPEIMKI();
			}
			for (int j = 0; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].PJCKNDKFLMH();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x006F4EA0 File Offset: 0x006F30A0
		protected virtual void EGAGFOLOHOP()
		{
			if (this.IKPositionWeight <= 1613f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1819f, 1406f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.JKLAKFOLEBJ();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.HGLALJJNAMG();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.DMFKJIOBAHN();
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x006F4F70 File Offset: 0x006F3170
		protected virtual void OODBJBBCFEL()
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				if (this.chain[i].bendConstraint.AHLLPEAFFDC())
				{
					this.chain[i].bendConstraint.BPJKGOJOLPL(this.IKPositionWeight, this.KEMMIIGEPBO(this.chain[i].nodes[5].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].ODFNCOOEPJH(this);
			}
			for (int k = 1; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].BMBKPGJEDNG(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].CDPCOFKFDNO(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OOKOMOOFHCL();
				for (int m = 1; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].AJMDGINBEEI();
				}
			}
			for (int n = 1; n < this.limbMappings.Length; n += 0)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x006F50A8 File Offset: 0x006F32A8
		public IKEffector NGBLDFEPGIN(Transform JAHNHOCNJGM)
		{
			for (int i = 0; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x006F50E8 File Offset: 0x006F32E8
		protected virtual void COOFIMMOEHA()
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.ANKLCAHHEDM())
				{
					this.chain[i].bendConstraint.EJJIBAHAPKL(this.IKPositionWeight, this.AFEFCBGFPCG(this.chain[i].nodes[3].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].KOBINMAKGKJ(this);
			}
			for (int k = 0; k < this.effectors.Length; k++)
			{
				this.effectors[k].GCOFDPBJHBL(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].NGBPODBDFOE(this, this.iterations > 0);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.ALDBKKCEFHD();
				for (int m = 1; m < this.boneMappings.Length; m += 0)
				{
					this.boneMappings[m].JJMPLOGNGMJ();
				}
			}
			for (int n = 1; n < this.limbMappings.Length; n += 0)
			{
				this.limbMappings[n].CDPCOFKFDNO();
			}
		}

		// Token: 0x0600F7C2 RID: 63426 RVA: 0x006F5220 File Offset: 0x006F3420
		public virtual void IALCLPHHAIB()
		{
			this.spineMapping.FGBCANJFNOC();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].ACJOAAMMIIJ();
			}
			for (int j = 1; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].BGCCCDLFDAL();
			}
			if (this.OnStoreDefaultLocalState != null)
			{
				this.OnStoreDefaultLocalState();
			}
		}

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x006F528C File Offset: 0x006F348C
		public virtual IKSolver.Point LFEAHDNDOPK(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7C4 RID: 63428 RVA: 0x006F52F4 File Offset: 0x006F34F4
		protected virtual void FKLFOMAEELC()
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				if (this.chain[i].bendConstraint.initiated)
				{
					this.chain[i].bendConstraint.MABPJFMDNFF(this.IKPositionWeight, this.AFEFCBGFPCG(this.chain[i].nodes[6].transform).positionWeight);
				}
			}
			for (int j = 0; j < this.effectors.Length; j++)
			{
				this.effectors[j].KOBINMAKGKJ(this);
			}
			for (int k = 1; k < this.effectors.Length; k++)
			{
				this.effectors[k].GCOFDPBJHBL(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].BHKPGIKMKNH(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.JKLAKFOLEBJ();
				for (int m = 0; m < this.boneMappings.Length; m += 0)
				{
					this.boneMappings[m].JKLAKFOLEBJ();
				}
			}
			for (int n = 0; n < this.limbMappings.Length; n++)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x006F542C File Offset: 0x006F362C
		protected virtual void KECOOJIFPIO()
		{
			if (this.IKPositionWeight <= 788f)
			{
				for (int i = 1; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 804f, 1519f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.CDGDHECHODF();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.HGLALJJNAMG();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.JGNIDAGGMKC();
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F7C6 RID: 63430 RVA: 0x006F54FC File Offset: 0x006F36FC
		public virtual void NKBECNFHBJO()
		{
			if (this.IKPositionWeight <= 151f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].OECEGIAKPHD();
			}
			for (int j = 0; j < this.boneMappings.Length; j++)
			{
				this.boneMappings[j].BIECFPGBEMF();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F7C7 RID: 63431 RVA: 0x006F5578 File Offset: 0x006F3778
		protected virtual void FHBEAPOLEAA()
		{
			if (this.IKPositionWeight <= 971f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OFLIOOOJPOK(this);
				for (int i = 1; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].FANMDANNBAK(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].AACMGNDNNIM(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x006F55F8 File Offset: 0x006F37F8
		public virtual IKSolver.Point[] FIDMGHHHBEG()
		{
			int num = 1;
			for (int i = 1; i < this.chain.Length; i++)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 0;
			for (int j = 0; j < this.chain.Length; j += 0)
			{
				for (int k = 0; k < this.chain[j].nodes.Length; k++)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x006F5680 File Offset: 0x006F3880
		public int BEDBOFGFGBG(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x006F56DC File Offset: 0x006F38DC
		protected virtual void KKCADDJJGIN()
		{
			if (this.IKPositionWeight <= 727f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1348f, 895f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.EGBGLMADMLJ();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.PEJHCACAHPJ();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.JGNIDAGGMKC();
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x0600F7CB RID: 63435 RVA: 0x006F57AC File Offset: 0x006F39AC
		protected virtual void JCGHFOECMGP()
		{
			if (this.IKPositionWeight <= 1458f)
			{
				for (int i = 1; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 62f, 1200f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.FKLFOMAEELC();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.OINLELGLCEC();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.CNKDDKBKHEI();
			for (int j = 0; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].CNIPLLNAHJH();
			}
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x006F587C File Offset: 0x006F3A7C
		public int AICOEJLCBMH(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x006F58D8 File Offset: 0x006F3AD8
		public IKEffector DKGNOLHDNFJ(Transform JAHNHOCNJGM)
		{
			for (int i = 1; i < this.effectors.Length; i++)
			{
				if (this.effectors[i].bone == JAHNHOCNJGM)
				{
					return this.effectors[i];
				}
			}
			return null;
		}

		// Token: 0x0600F7CE RID: 63438 RVA: 0x006F5918 File Offset: 0x006F3B18
		public virtual IKSolver.Point LBKDOPHDKHG(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x006F5980 File Offset: 0x006F3B80
		protected virtual void JGNIDAGGMKC()
		{
			if (this.IKPositionWeight <= 604f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 1; i < this.boneMappings.Length; i += 0)
				{
					this.boneMappings[i].GEHFDOCHCEA(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].OFLIOOOJPOK(this, this.iterations > 0);
			}
		}

		// Token: 0x0600F7D0 RID: 63440 RVA: 0x006F5A00 File Offset: 0x006F3C00
		protected override void FKEMPLMBNEL()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				this.chain[i].BHALELINNDJ(this);
			}
			IKEffector[] array = this.effectors;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].BHALELINNDJ(this);
			}
			this.spineMapping.BHALELINNDJ(this);
			IKMappingBone[] array2 = this.boneMappings;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].BHALELINNDJ(this);
			}
			IKMappingLimb[] array3 = this.limbMappings;
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j].BHALELINNDJ(this);
			}
		}

		// Token: 0x0600F7D1 RID: 63441 RVA: 0x006F5A97 File Offset: 0x006F3C97
		public void CDFABPFGKMD(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.HENDDFHHJCE(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].BAEPPMGCGDD(LPBDALAMAEM);
		}

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x006F5ABC File Offset: 0x006F3CBC
		protected virtual void CCKJNLDILID()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.ANKLCAHHEDM())
				{
					this.chain[i].bendConstraint.GLPKICANILF(this.IKPositionWeight, this.KEMMIIGEPBO(this.chain[i].nodes[8].transform).positionWeight);
				}
			}
			for (int j = 1; j < this.effectors.Length; j++)
			{
				this.effectors[j].DBAPHAAKEOM(this);
			}
			for (int k = 1; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].DDCDLADEOIO(this);
			}
			for (int l = 1; l < this.chain.Length; l += 0)
			{
				this.chain[l].BHKPGIKMKNH(this, this.iterations > 1);
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OOKOMOOFHCL();
				for (int m = 1; m < this.boneMappings.Length; m++)
				{
					this.boneMappings[m].CKNBMMEPJKP();
				}
			}
			for (int n = 1; n < this.limbMappings.Length; n += 0)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x006F5BF4 File Offset: 0x006F3DF4
		protected virtual void LKAEJEGMMGF()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].FJPKBOPIING())
						{
							this.effectors[j].AAEFACEGJMB(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].PMIACHFCEDC(this);
						if (this.FABRIKPass)
						{
							this.chain[0].FJLOMFDCBMH(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].FJPKBOPIING())
							{
								this.effectors[k].AIAMIFEPALP(this);
							}
						}
					}
					this.chain[0].PAICOHFFOJO(this, true);
					if (this.FABRIKPass)
					{
						this.chain[1].AOEHDONHDCD(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].AIAMIFEPALP(this);
							}
						}
						this.chain[1].CHKFAGNDEOD(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].FANPFKHEDPA(this);
				}
			}
			this.OBKKAAPFACE();
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x006F5DAC File Offset: 0x006F3FAC
		protected virtual void HGLALJJNAMG()
		{
			if (this.iterations > 0)
			{
				for (int i = 0; i < (this.FABRIKPass ? this.iterations : 1); i++)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j++)
					{
						if (this.effectors[j].FJPKBOPIING())
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[1].GJILNKFNAHI(this);
						if (this.FABRIKPass)
						{
							this.chain[1].LPJDNKAGBOB(this);
						}
						for (int k = 0; k < this.effectors.Length; k++)
						{
							if (!this.effectors[k].isEndEffector)
							{
								this.effectors[k].AAEFACEGJMB(this);
							}
						}
					}
					this.chain[1].MEFEBBMLGEJ(this, true);
					if (this.FABRIKPass)
					{
						this.chain[0].BACOCEJMGCH(this);
						for (int l = 0; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].JPHLMNIMDHH(this);
							}
						}
						this.chain[0].LJIFJGOGHBJ(this, this.chain[0].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 0; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].isEndEffector)
				{
					this.effectors[m].AAEFACEGJMB(this);
				}
			}
			this.LOKHCFPIAHE();
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node HDEJBHNJOAF(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x006F5F64 File Offset: 0x006F4164
		public FBIKChain CFLHKIGAPOB(Transform LPBDALAMAEM)
		{
			int num = this.AICOEJLCBMH(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x006F3104 File Offset: 0x006F1304
		protected virtual void PEFNPEDOHDC()
		{
			this.chain[1].LGKNEFHHOLL(this, false);
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x006F5F88 File Offset: 0x006F4188
		protected virtual void MIFNDOOEACI()
		{
			if (this.IKPositionWeight <= 64f)
			{
				return;
			}
			if (this.iterations > 1)
			{
				this.spineMapping.OHLAJEPBANP(this);
				for (int i = 0; i < this.boneMappings.Length; i++)
				{
					this.boneMappings[i].OFLIOOOJPOK(this.IKPositionWeight);
				}
			}
			for (int j = 0; j < this.limbMappings.Length; j++)
			{
				this.limbMappings[j].PEBKAPJGHCE(this, this.iterations > 1);
			}
		}

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x006F6008 File Offset: 0x006F4208
		protected virtual void HBIBKJPIPMA()
		{
			for (int i = 0; i < this.chain.Length; i++)
			{
				if (this.chain[i].bendConstraint.MNLFEGALCPA())
				{
					this.chain[i].bendConstraint.BPJKGOJOLPL(this.IKPositionWeight, this.DKGNOLHDNFJ(this.chain[i].nodes[1].transform).positionWeight);
				}
			}
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].ODFNCOOEPJH(this);
			}
			for (int k = 0; k < this.effectors.Length; k += 0)
			{
				this.effectors[k].GCOFDPBJHBL(this);
			}
			for (int l = 0; l < this.chain.Length; l += 0)
			{
				this.chain[l].BHKPGIKMKNH(this, this.iterations > 0);
			}
			if (this.iterations > 0)
			{
				this.spineMapping.JKLAKFOLEBJ();
				for (int m = 1; m < this.boneMappings.Length; m += 0)
				{
					this.boneMappings[m].OCBGKLMHFCF();
				}
			}
			for (int n = 1; n < this.limbMappings.Length; n += 0)
			{
				this.limbMappings[n].JKLAKFOLEBJ();
			}
		}

		// Token: 0x0600F7DA RID: 63450 RVA: 0x006F6140 File Offset: 0x006F4340
		public FBIKChain KPGNADDAIJF(Transform LPBDALAMAEM)
		{
			int num = this.AJDLHFNFCNN(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x006F6164 File Offset: 0x006F4364
		public virtual void FJJMFIDKMMM()
		{
			if (this.IKPositionWeight <= 1093f)
			{
				return;
			}
			this.spineMapping.BLOEEPCIPKJ();
			for (int i = 0; i < this.limbMappings.Length; i++)
			{
				this.limbMappings[i].OECEGIAKPHD();
			}
			for (int j = 1; j < this.boneMappings.Length; j += 0)
			{
				this.boneMappings[j].NFEAAPAAGEC();
			}
			if (this.OnFixTransforms != null)
			{
				this.OnFixTransforms();
			}
		}

		// Token: 0x0600F7DC RID: 63452 RVA: 0x006F61E0 File Offset: 0x006F43E0
		protected virtual void OALIFIGFCIJ()
		{
			if (this.iterations > 1)
			{
				for (int i = 1; i < (this.FABRIKPass ? this.iterations : 1); i += 0)
				{
					if (this.OnPreIteration != null)
					{
						this.OnPreIteration(i);
					}
					for (int j = 0; j < this.effectors.Length; j += 0)
					{
						if (this.effectors[j].PMMJBMLMFCP())
						{
							this.effectors[j].LMMDHJJJNJO(this);
						}
					}
					if (this.FABRIKPass)
					{
						this.chain[0].HHNONLAANEG(this);
						if (this.FABRIKPass)
						{
							this.chain[0].PMAEMHGDIHI(this);
						}
						for (int k = 1; k < this.effectors.Length; k += 0)
						{
							if (!this.effectors[k].PMMJBMLMFCP())
							{
								this.effectors[k].KMLNBHIIGKH(this);
							}
						}
					}
					this.chain[1].MEFEBBMLGEJ(this, true);
					if (this.FABRIKPass)
					{
						this.chain[0].BACOCEJMGCH(this);
						for (int l = 1; l < this.effectors.Length; l++)
						{
							if (!this.effectors[l].PMMJBMLMFCP())
							{
								this.effectors[l].FANPFKHEDPA(this);
							}
						}
						this.chain[1].EINDDKBNFCJ(this, this.chain[1].nodes[0].solverPosition);
					}
					if (this.OnPostIteration != null)
					{
						this.OnPostIteration(i);
					}
				}
			}
			if (this.OnPreBend != null)
			{
				this.OnPreBend();
			}
			for (int m = 1; m < this.effectors.Length; m += 0)
			{
				if (this.effectors[m].FJPKBOPIING())
				{
					this.effectors[m].AAEFACEGJMB(this);
				}
			}
			this.PEFNPEDOHDC();
		}

		// Token: 0x0600F7DD RID: 63453 RVA: 0x006F6396 File Offset: 0x006F4596
		public void HILELMDICPD(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.CALGFAMDPHO(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].KGGGEAGOGPL(LPBDALAMAEM);
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x006F63BC File Offset: 0x006F45BC
		public int DAPNMFCCBAG(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i++)
			{
				for (int j = 1; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x006F6418 File Offset: 0x006F4618
		public int OPJDLJKJBIM(Transform LPBDALAMAEM)
		{
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j++)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x006F6474 File Offset: 0x006F4674
		public virtual IKSolver.Point CGDMCANKFOP(Transform LPBDALAMAEM)
		{
			for (int i = 1; i < this.chain.Length; i += 0)
			{
				for (int j = 0; j < this.chain[i].nodes.Length; j += 0)
				{
					if (this.chain[i].nodes[j].transform == LPBDALAMAEM)
					{
						return this.chain[i].nodes[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x006F64DC File Offset: 0x006F46DC
		public virtual IKSolver.Point[] MNGAMJDIDPH()
		{
			int num = 1;
			for (int i = 0; i < this.chain.Length; i += 0)
			{
				num += this.chain[i].nodes.Length;
			}
			IKSolver.Point[] array = new IKSolver.Point[num];
			int num2 = 1;
			for (int j = 0; j < this.chain.Length; j += 0)
			{
				for (int k = 1; k < this.chain[j].nodes.Length; k += 0)
				{
					array[num2] = this.chain[j].nodes[k];
				}
			}
			return array;
		}

		// Token: 0x0600F7E2 RID: 63458 RVA: 0x006F6564 File Offset: 0x006F4764
		public void KBODJMDJLFF(Transform LPBDALAMAEM, out int OGINJEMBCFD, out int HOMDMFEAHPH)
		{
			OGINJEMBCFD = this.BEDBOFGFGBG(LPBDALAMAEM);
			if (OGINJEMBCFD == -1)
			{
				HOMDMFEAHPH = -1;
				return;
			}
			HOMDMFEAHPH = this.chain[OGINJEMBCFD].HOHBMCMCAJH(LPBDALAMAEM);
		}

		// Token: 0x0600F7E3 RID: 63459 RVA: 0x006F658C File Offset: 0x006F478C
		public FBIKChain IBFADKJKNBO(Transform LPBDALAMAEM)
		{
			int num = this.AICOEJLCBMH(LPBDALAMAEM);
			if (num == -1)
			{
				return null;
			}
			return this.chain[num];
		}

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x006F0494 File Offset: 0x006EE694
		public IKSolver.Node OFEJNOEBBLI(int OGINJEMBCFD, int HOMDMFEAHPH)
		{
			return this.chain[OGINJEMBCFD].nodes[HOMDMFEAHPH];
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x006F65B0 File Offset: 0x006F47B0
		protected virtual void GGMNPAEPNEC()
		{
			if (this.IKPositionWeight <= 1132f)
			{
				for (int i = 0; i < this.effectors.Length; i++)
				{
					this.effectors[i].positionOffset = Vector3.zero;
				}
				return;
			}
			if (this.chain.Length == 0)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 675f, 178f);
			if (this.OnPreRead != null)
			{
				this.OnPreRead();
			}
			this.NJOPMOCILBK();
			if (this.OnPreSolve != null)
			{
				this.OnPreSolve();
			}
			this.FPEJJFNJAFH();
			if (this.OnPostSolve != null)
			{
				this.OnPostSolve();
			}
			this.CNKDDKBKHEI();
			for (int j = 1; j < this.effectors.Length; j += 0)
			{
				this.effectors[j].OGOECMLAMFO();
			}
		}

		// Token: 0x04002054 RID: 8276
		[Range(0f, 10f)]
		public int iterations = 4;

		// Token: 0x04002055 RID: 8277
		public FBIKChain[] chain = new FBIKChain[0];

		// Token: 0x04002056 RID: 8278
		public IKEffector[] effectors = new IKEffector[0];

		// Token: 0x04002057 RID: 8279
		public IKMappingSpine spineMapping = new IKMappingSpine();

		// Token: 0x04002058 RID: 8280
		public IKMappingBone[] boneMappings = new IKMappingBone[0];

		// Token: 0x04002059 RID: 8281
		public IKMappingLimb[] limbMappings = new IKMappingLimb[0];

		// Token: 0x0400205A RID: 8282
		public bool FABRIKPass = true;

		// Token: 0x0400205B RID: 8283
		public IKSolver.LGGEKCCEELN OnPreRead;

		// Token: 0x0400205C RID: 8284
		public IKSolver.LGGEKCCEELN OnPreSolve;

		// Token: 0x0400205D RID: 8285
		public IKSolver.MLFKIGOCFLP OnPreIteration;

		// Token: 0x0400205E RID: 8286
		public IKSolver.MLFKIGOCFLP OnPostIteration;

		// Token: 0x0400205F RID: 8287
		public IKSolver.LGGEKCCEELN OnPreBend;

		// Token: 0x04002060 RID: 8288
		public IKSolver.LGGEKCCEELN OnPostSolve;

		// Token: 0x04002061 RID: 8289
		public IKSolver.LGGEKCCEELN OnStoreDefaultLocalState;

		// Token: 0x04002062 RID: 8290
		public IKSolver.LGGEKCCEELN OnFixTransforms;
	}
}
