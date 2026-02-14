using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000464 RID: 1124
	[Serializable]
	public class IKMapping
	{
		// Token: 0x0600F382 RID: 62338 RVA: 0x006D60CC File Offset: 0x006D42CC
		protected Vector3 LMBDLHFLCHM(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F383 RID: 62339 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool BGKDELKAGJI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F384 RID: 62340 RVA: 0x006D60F4 File Offset: 0x006D42F4
		protected bool FPONBGIJKIA(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "IKMappingLimb contains a null reference.";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "IKMappingLimb is referencing to a bone '" + FBKEODHEMMH.name + "' that does not excist in the Node Chain.";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600F385 RID: 62341 RVA: 0x006D6150 File Offset: 0x006D4350
		protected bool BHDFIKLLNOI(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "_";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "" + FBKEODHEMMH.name + "CheerJump";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F386 RID: 62342 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void DAAHJFNPBIF(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F387 RID: 62343 RVA: 0x006D61AC File Offset: 0x006D43AC
		protected bool MHBIEEKHBCC(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = " iterations for read and write";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "19" + FBKEODHEMMH.name + "2000";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600F388 RID: 62344 RVA: 0x006D6208 File Offset: 0x006D4408
		protected Vector3 OLBCFIDBGKD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F389 RID: 62345 RVA: 0x000EB372 File Offset: 0x000E9572
		public virtual bool DPHFOGMGHLI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return false;
		}

		// Token: 0x0600F38A RID: 62346 RVA: 0x006D6230 File Offset: 0x006D4430
		protected Vector3 POGPICPFIAM(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F38B RID: 62347 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void MLEBBNKPKKF(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F38C RID: 62348 RVA: 0x006D6258 File Offset: 0x006D4458
		protected Vector3 ILOPDCMKNJD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F38D RID: 62349 RVA: 0x006D6280 File Offset: 0x006D4480
		protected Vector3 ENEIALKEKEP(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F38E RID: 62350 RVA: 0x006D62A8 File Offset: 0x006D44A8
		protected Vector3 GMIBLDOADDM(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F38F RID: 62351 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void BHALELINNDJ(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F390 RID: 62352 RVA: 0x006D62D0 File Offset: 0x006D44D0
		protected Vector3 FNEINKEGDLI(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F391 RID: 62353 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void CKHKJOHKMEE(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F392 RID: 62354 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool BLOEHCJCFEK(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F393 RID: 62355 RVA: 0x006D62F8 File Offset: 0x006D44F8
		protected bool PONPDKPLAOD(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "StrafeRunRight";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "[ACTk] <b>[ ObscuredString test ]</b>" + FBKEODHEMMH.name + "_WrinkleNormalMap2";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F394 RID: 62356 RVA: 0x000EB372 File Offset: 0x000E9572
		public virtual bool FOMAAOAPDDO(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return false;
		}

		// Token: 0x0600F395 RID: 62357 RVA: 0x006D6354 File Offset: 0x006D4554
		protected Vector3 OHIBFIIOHHE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F396 RID: 62358 RVA: 0x006D637C File Offset: 0x006D457C
		protected Vector3 LMNJJBPLBDL(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F397 RID: 62359 RVA: 0x006D63A4 File Offset: 0x006D45A4
		protected bool CBOECAGIEPB(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "delaccconfirm";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "[ProBuilder Attachments] Please disable the following option in the Unity preferences:" + FBKEODHEMMH.name + "GestureWonderful";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F398 RID: 62360 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void FJMNBKHFLJO(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F399 RID: 62361 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void FJFJNFHKMHJ(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F39A RID: 62362 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void DPOFMEPOJED(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F39B RID: 62363 RVA: 0x006D6400 File Offset: 0x006D4600
		protected Vector3 GBMABEOPAAP(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F39C RID: 62364 RVA: 0x006D6428 File Offset: 0x006D4628
		protected bool IKIFOEFDAEF(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "QTask.xml";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "StaffHeal" + FBKEODHEMMH.name + "Установлен <b>";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F39D RID: 62365 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void PJFHMMHHBEN(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F39E RID: 62366 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void LLDECCKPLHM(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F39F RID: 62367 RVA: 0x006D6484 File Offset: 0x006D4684
		protected bool NHIOKPOCDCG(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Pointing";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + FBKEODHEMMH.name + "MotorbikeHandstand";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x006D64E0 File Offset: 0x006D46E0
		protected bool NHHGNNPIPOF(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Attempting to set limb orientation to Vector3.zero axis";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "MotorbikeLasso" + FBKEODHEMMH.name + " /";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F3A1 RID: 62369 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool CELPINDCLAA(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool CHFHJDFDIGB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3A3 RID: 62371 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool EJMDBNJCBHB(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3A5 RID: 62373 RVA: 0x006D653C File Offset: 0x006D473C
		protected Vector3 HNDMDCFOFNC(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x006D6564 File Offset: 0x006D4764
		protected bool BEGIHEODOJG(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "gi_fridgiceno";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "_TintColor" + FBKEODHEMMH.name + "---";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F3A7 RID: 62375 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void LJPDLKLOEFC(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3A8 RID: 62376 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void HFEEPBDDCKO(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3A9 RID: 62377 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool MJJNKICHLFA(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3AA RID: 62378 RVA: 0x006D65C0 File Offset: 0x006D47C0
		protected bool DIMGAEICKKD(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Run Backward";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "" + FBKEODHEMMH.name + "1 Hand Sword Swing";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F3AB RID: 62379 RVA: 0x006D661C File Offset: 0x006D481C
		protected Vector3 CANEELHMEKE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x006D6644 File Offset: 0x006D4844
		protected Vector3 OBMCCFLEHKD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3AD RID: 62381 RVA: 0x006D666C File Offset: 0x006D486C
		protected Vector3 LADNIDBAEID(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3AE RID: 62382 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void ADIOIHCOCPA(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3AF RID: 62383 RVA: 0x006D6694 File Offset: 0x006D4894
		protected Vector3 JHIOBCLIOPG(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3B0 RID: 62384 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void NPCHHADBLMC(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void BOHLLJEAHAE(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x006D66BC File Offset: 0x006D48BC
		protected bool EJKNLGLFCCO(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "MotorbikeShootFwd";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "BackPackOff" + FBKEODHEMMH.name + "Steam Overlay has been activated";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x006D6718 File Offset: 0x006D4918
		protected Vector3 PDIOPLMKNMD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void FOBBCFADGKP(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3B5 RID: 62389 RVA: 0x006D6740 File Offset: 0x006D4940
		protected bool NEHDCFNHIOH(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Reset";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "_BlurVector" + FBKEODHEMMH.name + "Fonts/";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F3B6 RID: 62390 RVA: 0x000EB372 File Offset: 0x000E9572
		public virtual bool GGCHLAAAHEJ(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return false;
		}

		// Token: 0x0600F3B7 RID: 62391 RVA: 0x006D679C File Offset: 0x006D499C
		protected Vector3 GDEMGGHJPEF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool OECJJLKPHPP(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3B9 RID: 62393 RVA: 0x006D67C4 File Offset: 0x006D49C4
		protected Vector3 KMLFIHOLAAF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3BA RID: 62394 RVA: 0x006D67EC File Offset: 0x006D49EC
		protected bool CMIGBOLNDEA(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = " x";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "gi_fridge" + FBKEODHEMMH.name + "\n";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x000EB372 File Offset: 0x000E9572
		public virtual bool FBJPAOJCPPA(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return false;
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x006D6848 File Offset: 0x006D4A48
		protected Vector3 FPOFFDDMKDE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3BD RID: 62397 RVA: 0x006D6870 File Offset: 0x006D4A70
		protected Vector3 LDHDABPIDIN(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x006D6898 File Offset: 0x006D4A98
		protected Vector3 OLBCGKEKDJC(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool DNIAGDMODBI(IKSolver NBAKCIDALOF, ref string EDAPHMJENPK)
		{
			return true;
		}

		// Token: 0x0600F3C0 RID: 62400 RVA: 0x006D68C0 File Offset: 0x006D4AC0
		protected bool AHALDJFCBFO(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "HeelClick";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "quests/" + FBKEODHEMMH.name + "JumpLeg";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x006D691C File Offset: 0x006D4B1C
		protected bool DLMKGMAHFBP(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Wand Attack 2";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "" + FBKEODHEMMH.name + "rollSoundIndex";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F3C2 RID: 62402 RVA: 0x006D6978 File Offset: 0x006D4B78
		protected Vector3 KLHCOIIBGEE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x006D69A0 File Offset: 0x006D4BA0
		protected Vector3 JKMIGNLNAOO(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3C4 RID: 62404 RVA: 0x006D69C8 File Offset: 0x006D4BC8
		protected Vector3 PMHGACPMHFC(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float IOHIFNBBGPJ)
		{
			return EDGLMNGJAAK + (IKECEOLMEFM - EDGLMNGJAAK).normalized * IOHIFNBBGPJ;
		}

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x006D69F0 File Offset: 0x006D4BF0
		protected bool BIEFLGPOEGK(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "wpn_cmp";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "IdleButtonPress" + FBKEODHEMMH.name + "U";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void IHPLBCJCOPM(IKSolverFullBody NBAKCIDALOF)
		{
		}

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x006D6A4C File Offset: 0x006D4C4C
		protected bool KDBNFFKLKMD(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "Vertical";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "Vertical" + FBKEODHEMMH.name + "WeaponReadyFire";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x006D6AA8 File Offset: 0x006D4CA8
		protected bool PGOBFCPFEEJ(Transform FBKEODHEMMH, IKSolver NBAKCIDALOF, ref string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG = null)
		{
			if (FBKEODHEMMH == null)
			{
				EDAPHMJENPK = "MotorbikeSeatStandWheely";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return false;
			}
			if (NBAKCIDALOF.DFGANHHFFML(FBKEODHEMMH) == null)
			{
				EDAPHMJENPK = "</color>\n" + FBKEODHEMMH.name + "wpn_rod4";
				if (MEAMDIPGFMG != null)
				{
					MEAMDIPGFMG(EDAPHMJENPK);
				}
				return true;
			}
			return false;
		}

		// Token: 0x02000465 RID: 1125
		[Serializable]
		public class BoneMap
		{
			// Token: 0x0600F3C9 RID: 62409 RVA: 0x006D6B04 File Offset: 0x006D4D04
			public void OPGNNDCILFM(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1172f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3CA RID: 62410 RVA: 0x006D6B7C File Offset: 0x006D4D7C
			public void JPMLPIDHMMH(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.ICMJBHEAKFJ(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 624f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3CB RID: 62411 RVA: 0x006D6BD0 File Offset: 0x006D4DD0
			public void HFIHEHEJNAJ(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 381f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3CC RID: 62412 RVA: 0x006D6C48 File Offset: 0x006D4E48
			public void AKPIIBCFGCM(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.OFKCNHIDJMK(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 377f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3CD RID: 62413 RVA: 0x006D6C9C File Offset: 0x006D4E9C
			public void BHMDHCDKMMG(IKSolverFullBody NBAKCIDALOF, Transform OJBEOEMMDKJ, Transform GLDHCBHOJNH, Transform PAFIAADHENE)
			{
				this.planeBone1 = OJBEOEMMDKJ;
				this.planeBone2 = GLDHCBHOJNH;
				this.planeBone3 = PAFIAADHENE;
				NBAKCIDALOF.DJAPGCBALGA(OJBEOEMMDKJ, out this.plane1ChainIndex, out this.plane1NodeIndex);
				NBAKCIDALOF.CDFABPFGKMD(GLDHCBHOJNH, out this.plane2ChainIndex, out this.plane2NodeIndex);
				NBAKCIDALOF.GCBAMHKFDID(PAFIAADHENE, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.HACCFIMPMHM(false, true);
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x006D6D01 File Offset: 0x006D4F01
			public Vector3 swingDirection
			{
				get
				{
					return this.transform.rotation * this.localSwingAxis;
				}
			}

			// Token: 0x0600F3CF RID: 62415 RVA: 0x006D6D1C File Offset: 0x006D4F1C
			public void ENAMNBOEMBD(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion lastAnimatedTargetRotation = this.lastAnimatedTargetRotation;
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, lastAnimatedTargetRotation);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(lastAnimatedTargetRotation) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F3D0 RID: 62416 RVA: 0x006D6D79 File Offset: 0x006D4F79
			public void AOMIADLDLEJ(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.DJAPGCBALGA(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F3D1 RID: 62417 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void MNJDNCNLCJO()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F3D2 RID: 62418 RVA: 0x006D6DA8 File Offset: 0x006D4FA8
			public void JPAGKICFBFM(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.isNodeBone)
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 1989f)
				{
					return;
				}
				if (num >= 970f)
				{
					this.transform.rotation = NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F3D3 RID: 62419 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void BNIFPFDCHGB()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F3D4 RID: 62420 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void GIMGDNNGLDG()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F3D5 RID: 62421 RVA: 0x006D6E40 File Offset: 0x006D5040
			public void BJIIOGBPHBH(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD, IKSolver.Node NEKBKBKMMDN = null)
			{
				if (NEKBKBKMMDN == null)
				{
					NEKBKBKMMDN = NBAKCIDALOF.PFDOFAGICJA(this.chainIndex, this.nodeIndex);
				}
				if (NKHBAJKMAGD >= 1433f)
				{
					this.transform.position = NEKBKBKMMDN.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, NEKBKBKMMDN.solverPosition, NKHBAJKMAGD);
			}

			// Token: 0x0600F3D7 RID: 62423 RVA: 0x006D6EE0 File Offset: 0x006D50E0
			public void KMOGFKPHBFM(IKSolverFullBody NBAKCIDALOF)
			{
				this.transform.position = this.OBHDJMOGMPL(NBAKCIDALOF);
			}

			// Token: 0x0600F3D8 RID: 62424 RVA: 0x006D6EF4 File Offset: 0x006D50F4
			public void MEDPDKOAKDP(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.NDGEFHMPCJC(CCIECPEKMEC, this);
			}

			// Token: 0x0600F3D9 RID: 62425 RVA: 0x006D6F00 File Offset: 0x006D5100
			public void AAENHNOHDDD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1356f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3DA RID: 62426 RVA: 0x006D6F72 File Offset: 0x006D5172
			public bool AAMPOPPEPGG()
			{
				return this.nodeIndex != -1;
			}

			// Token: 0x0600F3DB RID: 62427 RVA: 0x006D6F80 File Offset: 0x006D5180
			public void MGPAAIJPAJI(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.BDIJAAMPNMI(CCIECPEKMEC, this);
			}

			// Token: 0x0600F3DC RID: 62428 RVA: 0x006D6F8A File Offset: 0x006D518A
			public void NNGBMKILKNJ()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F3DD RID: 62429 RVA: 0x006D6FB0 File Offset: 0x006D51B0
			public void LMEKPDLEAEP(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3DE RID: 62430 RVA: 0x006D7028 File Offset: 0x006D5228
			public void PAAIKNFDDDM(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.FEGHLIAHOKH(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 751f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3DF RID: 62431 RVA: 0x006D6F8A File Offset: 0x006D518A
			public void OBFPCCOCEAO()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F3E0 RID: 62432 RVA: 0x006D707C File Offset: 0x006D527C
			private Quaternion LLNFCAJCFNA()
			{
				if (this.planeBone1.position == this.planeBone3.position)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}

			// Token: 0x0600F3E1 RID: 62433 RVA: 0x006D70E7 File Offset: 0x006D52E7
			public Vector3 OBHDJMOGMPL(IKSolverFullBody NBAKCIDALOF)
			{
				return NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.GCFKMKIEBAO(NBAKCIDALOF) * this.planePosition;
			}

			// Token: 0x0600F3E2 RID: 62434 RVA: 0x006D7117 File Offset: 0x006D5317
			public void MPBFIELENJJ(bool MGALEAJOGPL)
			{
				if (MGALEAJOGPL)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F3E3 RID: 62435 RVA: 0x006D7117 File Offset: 0x006D5317
			public void CABOMOMHPKB(bool MGALEAJOGPL)
			{
				if (MGALEAJOGPL)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F3E4 RID: 62436 RVA: 0x006D713E File Offset: 0x006D533E
			public void AABJEKGCOCA(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				this.localTwistAxis = Quaternion.Inverse(this.transform.rotation) * DJJFHKLIPIB;
			}

			// Token: 0x0600F3E5 RID: 62437 RVA: 0x006D7168 File Offset: 0x006D5368
			public void OKEKHHCGNHJ(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.BDLCJABBIKB();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F3E6 RID: 62438 RVA: 0x006D71C5 File Offset: 0x006D53C5
			public void COIBHCCOGKO(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.IHAFLKCMOBF(CCIECPEKMEC, this);
			}

			// Token: 0x0600F3E7 RID: 62439 RVA: 0x006D71D0 File Offset: 0x006D53D0
			public void NEEDLGBEHBD(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1882f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3E8 RID: 62440 RVA: 0x006D7242 File Offset: 0x006D5442
			public void MMHIOMOHLDD(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F3E9 RID: 62441 RVA: 0x006D727A File Offset: 0x006D547A
			public void BHALELINNDJ(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.KBODJMDJLFF(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F3EA RID: 62442 RVA: 0x006D7298 File Offset: 0x006D5498
			public void GCLDMFEJHPL(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.FBDJFCADKLH();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F3EB RID: 62443 RVA: 0x006D72F5 File Offset: 0x006D54F5
			public void PFBKILCAEBP(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.MMHIOMOHLDD(CCIECPEKMEC, this);
			}

			// Token: 0x0600F3EC RID: 62444 RVA: 0x006D7300 File Offset: 0x006D5500
			public void GOJBPOLCDCN(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.CMKGNNJLFIN();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F3ED RID: 62445 RVA: 0x006D735D File Offset: 0x006D555D
			public Vector3 FFBAOKKGBGG(IKSolverFullBody NBAKCIDALOF)
			{
				return NBAKCIDALOF.CNLEIKPLKOA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.FEGHLIAHOKH(NBAKCIDALOF) * this.planePosition;
			}

			// Token: 0x0600F3EE RID: 62446 RVA: 0x006D6F72 File Offset: 0x006D5172
			public bool EFKCOLJJLHJ()
			{
				return this.nodeIndex != -1;
			}

			// Token: 0x0600F3EF RID: 62447 RVA: 0x006D738D File Offset: 0x006D558D
			public void MEKODJABLHO(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 0f)
				{
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.maintainRotation, NKHBAJKMAGD);
			}

			// Token: 0x0600F3F0 RID: 62448 RVA: 0x006D6F8A File Offset: 0x006D518A
			public void FGBCANJFNOC()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F3F1 RID: 62449 RVA: 0x006D73BC File Offset: 0x006D55BC
			public void ONIOOHCIMCM(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.GCFKMKIEBAO(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3F2 RID: 62450 RVA: 0x006D7242 File Offset: 0x006D5442
			public void NDGEFHMPCJC(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F3F3 RID: 62451 RVA: 0x006D727A File Offset: 0x006D547A
			public void MCPNEMBJHAM(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.KBODJMDJLFF(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F3F4 RID: 62452 RVA: 0x006D740E File Offset: 0x006D560E
			public void LJOKHIKCOKP()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F3F5 RID: 62453 RVA: 0x006D7421 File Offset: 0x006D5621
			public void IAIIDKINKBD(Vector3 CCIECPEKMEC, float NKHBAJKMAGD)
			{
				this.EIOHPCCECDF(CCIECPEKMEC, this.transform.position, NKHBAJKMAGD);
			}

			// Token: 0x0600F3F6 RID: 62454 RVA: 0x006D7438 File Offset: 0x006D5638
			public void FABCJHKKDLD(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 353f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3F7 RID: 62455 RVA: 0x006D6F80 File Offset: 0x006D5180
			public void IBNJGGNLKHB(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.BDIJAAMPNMI(CCIECPEKMEC, this);
			}

			// Token: 0x0600F3F8 RID: 62456 RVA: 0x006D74AD File Offset: 0x006D56AD
			public void ABDGDFJHLEI(Vector3 CCIECPEKMEC, float NKHBAJKMAGD)
			{
				this.HOPIPNJHGLF(CCIECPEKMEC, this.transform.position, NKHBAJKMAGD);
			}

			// Token: 0x0600F3F9 RID: 62457 RVA: 0x006D74C4 File Offset: 0x006D56C4
			private Quaternion DJIEPIELLDI(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.CNLEIKPLKOA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.PFDOFAGICJA(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.PFDOFAGICJA(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x0600F3FA RID: 62458 RVA: 0x006D753C File Offset: 0x006D573C
			public void HGMJJIGAKAG(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1180f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F3FB RID: 62459 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void KFHGEGLNBAF()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F3FC RID: 62460 RVA: 0x006D6D01 File Offset: 0x006D4F01
			public Vector3 GEPFDHNPOJJ()
			{
				return this.transform.rotation * this.localSwingAxis;
			}

			// Token: 0x0600F3FD RID: 62461 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void IMOGCIBPPFC()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F3FE RID: 62462 RVA: 0x006D75C4 File Offset: 0x006D57C4
			private Quaternion BDLCJABBIKB()
			{
				if (this.planeBone1.position == this.planeBone3.position)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}

			// Token: 0x0600F3FF RID: 62463 RVA: 0x006D7630 File Offset: 0x006D5830
			public void AHOOGMHDIAE(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.HOIBHLLEAJG())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.PFDOFAGICJA(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 979f)
				{
					return;
				}
				if (num >= 1225f)
				{
					this.transform.rotation = NBAKCIDALOF.CIAODBAIJMF(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F400 RID: 62464 RVA: 0x006D7242 File Offset: 0x006D5442
			public void BBLFNKKOKJG(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F401 RID: 62465 RVA: 0x006D7242 File Offset: 0x006D5442
			public void IHAFLKCMOBF(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F402 RID: 62466 RVA: 0x006D713E File Offset: 0x006D533E
			public void CEOADIBONCG(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				this.localTwistAxis = Quaternion.Inverse(this.transform.rotation) * DJJFHKLIPIB;
			}

			// Token: 0x0600F403 RID: 62467 RVA: 0x006D7242 File Offset: 0x006D5442
			public void KBKMCDHMMMH(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F404 RID: 62468 RVA: 0x006D740E File Offset: 0x006D560E
			public void DEPGLGCMPAA()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F405 RID: 62469 RVA: 0x006D76C8 File Offset: 0x006D58C8
			public void FIBHLBJENAP(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.AJMLBOJFDAB())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 1217f)
				{
					return;
				}
				if (num >= 775f)
				{
					this.transform.rotation = NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F406 RID: 62470 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void EMIMECJNPFB()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F407 RID: 62471 RVA: 0x006D7760 File Offset: 0x006D5960
			private Quaternion FBDJFCADKLH()
			{
				if (this.planeBone1.position == this.planeBone3.position)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}

			// Token: 0x0600F408 RID: 62472 RVA: 0x006D740E File Offset: 0x006D560E
			public void CLGJEJACNAO()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F409 RID: 62473 RVA: 0x006D77CC File Offset: 0x006D59CC
			public void OGFGKJKFIJD(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.HOIBHLLEAJG())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 819f)
				{
					return;
				}
				if (num >= 1124f)
				{
					this.transform.rotation = NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F40A RID: 62474 RVA: 0x006D7863 File Offset: 0x006D5A63
			public void AGIFFDJAODO(IKMapping.BoneMap GOCIDPDBGIM)
			{
				this.length = Vector3.Distance(this.transform.position, GOCIDPDBGIM.transform.position);
			}

			// Token: 0x0600F40B RID: 62475 RVA: 0x006D7886 File Offset: 0x006D5A86
			public void DKAEKNGDLFK(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 1013f)
				{
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.maintainRotation, NKHBAJKMAGD);
			}

			// Token: 0x0600F40C RID: 62476 RVA: 0x006D740E File Offset: 0x006D560E
			public void MGJMLNJCLMD()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F40D RID: 62477 RVA: 0x006D7421 File Offset: 0x006D5621
			public void LPKOCKMPLAM(Vector3 CCIECPEKMEC, float NKHBAJKMAGD)
			{
				this.EIOHPCCECDF(CCIECPEKMEC, this.transform.position, NKHBAJKMAGD);
			}

			// Token: 0x0600F40E RID: 62478 RVA: 0x006D7242 File Offset: 0x006D5442
			public void BDIJAAMPNMI(IKMapping.BoneMap FCDAMCBKONG, IKMapping.BoneMap GLGMAJBNFIA)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (FCDAMCBKONG.transform.position - GLGMAJBNFIA.transform.position);
			}

			// Token: 0x0600F40F RID: 62479 RVA: 0x006D78B4 File Offset: 0x006D5AB4
			public void JBLKNJADFLJ(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD, IKSolver.Node NEKBKBKMMDN = null)
			{
				if (NEKBKBKMMDN == null)
				{
					NEKBKBKMMDN = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex);
				}
				if (NKHBAJKMAGD >= 1f)
				{
					this.transform.position = NEKBKBKMMDN.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, NEKBKBKMMDN.solverPosition, NKHBAJKMAGD);
			}

			// Token: 0x0600F410 RID: 62480 RVA: 0x006D7914 File Offset: 0x006D5B14
			public void BPLDKFKPCHB(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 772f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F411 RID: 62481 RVA: 0x006D798C File Offset: 0x006D5B8C
			public void KJBJDJLGOBG(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1473f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F412 RID: 62482 RVA: 0x006D740E File Offset: 0x006D560E
			public void PHDHDEMLCDO()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F413 RID: 62483 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void ACAFAIBJAAP()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F414 RID: 62484 RVA: 0x006D740E File Offset: 0x006D560E
			public void MEJDFFDCFGD()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F415 RID: 62485 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void EMCPHCMFIOE()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F416 RID: 62486 RVA: 0x006D7A01 File Offset: 0x006D5C01
			public Vector3 JMFDLKAFGEC(IKSolverFullBody NBAKCIDALOF)
			{
				return NBAKCIDALOF.BOELAJLMOGH(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.DJIEPIELLDI(NBAKCIDALOF) * this.planePosition;
			}

			// Token: 0x0600F417 RID: 62487 RVA: 0x006D727A File Offset: 0x006D547A
			public void KNEEBLNAGLM(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.KBODJMDJLFF(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F418 RID: 62488 RVA: 0x006D7A34 File Offset: 0x006D5C34
			public void CEKPFJKBPHE(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1854f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F419 RID: 62489 RVA: 0x006D7AA8 File Offset: 0x006D5CA8
			public void HOPIPNJHGLF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1744f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x0600F41A RID: 62490 RVA: 0x006D7B1C File Offset: 0x006D5D1C
			private Quaternion lastAnimatedTargetRotation
			{
				get
				{
					if (this.planeBone1.position == this.planeBone3.position)
					{
						return Quaternion.identity;
					}
					return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F41B RID: 62491 RVA: 0x006D7B88 File Offset: 0x006D5D88
			public void FOGLIPMPBJM(IKSolverFullBody NBAKCIDALOF, Transform OJBEOEMMDKJ, Transform GLDHCBHOJNH, Transform PAFIAADHENE)
			{
				this.planeBone1 = OJBEOEMMDKJ;
				this.planeBone2 = GLDHCBHOJNH;
				this.planeBone3 = PAFIAADHENE;
				NBAKCIDALOF.IBAOFCILPHA(OJBEOEMMDKJ, out this.plane1ChainIndex, out this.plane1NodeIndex);
				NBAKCIDALOF.GCBAMHKFDID(GLDHCBHOJNH, out this.plane2ChainIndex, out this.plane2NodeIndex);
				NBAKCIDALOF.IBAOFCILPHA(PAFIAADHENE, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.GOJBPOLCDCN(false, false);
			}

			// Token: 0x0600F41C RID: 62492 RVA: 0x006D7BF0 File Offset: 0x006D5DF0
			public void LELBOMJIICB(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.AAMPOPPEPGG())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 534f)
				{
					return;
				}
				if (num >= 1131f)
				{
					this.transform.rotation = NBAKCIDALOF.CPFNEEGDKGP(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F41D RID: 62493 RVA: 0x006D7A01 File Offset: 0x006D5C01
			public Vector3 BOOECOPIOLP(IKSolverFullBody NBAKCIDALOF)
			{
				return NBAKCIDALOF.BOELAJLMOGH(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.DJIEPIELLDI(NBAKCIDALOF) * this.planePosition;
			}

			// Token: 0x0600F41E RID: 62494 RVA: 0x006D7117 File Offset: 0x006D5317
			public void MKDGKDPKLBL(bool MGALEAJOGPL)
			{
				if (MGALEAJOGPL)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F41F RID: 62495 RVA: 0x006D7C88 File Offset: 0x006D5E88
			public void CMJOHIPLCNN(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.isNodeBone)
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 0f)
				{
					return;
				}
				if (num >= 1f)
				{
					this.transform.rotation = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F420 RID: 62496 RVA: 0x006D7D20 File Offset: 0x006D5F20
			public void JEDPGKFDGLK(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion lastAnimatedTargetRotation = this.lastAnimatedTargetRotation;
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, lastAnimatedTargetRotation);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(lastAnimatedTargetRotation) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F421 RID: 62497 RVA: 0x006D7D80 File Offset: 0x006D5F80
			public void EIOHPCCECDF(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F422 RID: 62498 RVA: 0x006D7DF4 File Offset: 0x006D5FF4
			public void PCKEODJKPOH(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.DJIEPIELLDI(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 725f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x0600F423 RID: 62499 RVA: 0x006D6F72 File Offset: 0x006D5172
			public bool isNodeBone
			{
				get
				{
					return this.nodeIndex != -1;
				}
			}

			// Token: 0x0600F424 RID: 62500 RVA: 0x006D7E46 File Offset: 0x006D6046
			public void OJKNMJEMKDP(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.HILELMDICPD(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F425 RID: 62501 RVA: 0x006D7E62 File Offset: 0x006D6062
			public void DNIAMOHMMKK(IKSolverFullBody NBAKCIDALOF)
			{
				this.transform.position = this.BGNOKJJHGCA(NBAKCIDALOF);
			}

			// Token: 0x0600F426 RID: 62502 RVA: 0x006D7117 File Offset: 0x006D5317
			public void LLBLOIDHPAH(bool MGALEAJOGPL)
			{
				if (MGALEAJOGPL)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x0600F427 RID: 62503 RVA: 0x006D7E78 File Offset: 0x006D6078
			public void PBPHNDLGAPM(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.FBDJFCADKLH();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F428 RID: 62504 RVA: 0x006D72F5 File Offset: 0x006D54F5
			public void MMHIOMOHLDD(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.MMHIOMOHLDD(CCIECPEKMEC, this);
			}

			// Token: 0x0600F429 RID: 62505 RVA: 0x006D7ED8 File Offset: 0x006D60D8
			private Quaternion LJNHNEHCKAB()
			{
				if (this.planeBone1.position == this.planeBone3.position)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}

			// Token: 0x0600F42A RID: 62506 RVA: 0x006D7F44 File Offset: 0x006D6144
			public void IDMAOMKHBGK(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.FBDJFCADKLH();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F42B RID: 62507 RVA: 0x006D7FA1 File Offset: 0x006D61A1
			public void KHNNIOEADEE(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.KBKMCDHMMMH(CCIECPEKMEC, this);
			}

			// Token: 0x0600F42C RID: 62508 RVA: 0x006D7FAC File Offset: 0x006D61AC
			public void ANMCLNFADJI(IKSolverFullBody NBAKCIDALOF, Transform OJBEOEMMDKJ, Transform GLDHCBHOJNH, Transform PAFIAADHENE)
			{
				this.planeBone1 = OJBEOEMMDKJ;
				this.planeBone2 = GLDHCBHOJNH;
				this.planeBone3 = PAFIAADHENE;
				NBAKCIDALOF.KBODJMDJLFF(OJBEOEMMDKJ, out this.plane1ChainIndex, out this.plane1NodeIndex);
				NBAKCIDALOF.CFGCGBAFECA(GLDHCBHOJNH, out this.plane2ChainIndex, out this.plane2NodeIndex);
				NBAKCIDALOF.IBAOFCILPHA(PAFIAADHENE, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.ENAMNBOEMBD(false, false);
			}

			// Token: 0x0600F42D RID: 62509 RVA: 0x006D713E File Offset: 0x006D533E
			public void NMGMENOELNB(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				this.localTwistAxis = Quaternion.Inverse(this.transform.rotation) * DJJFHKLIPIB;
			}

			// Token: 0x0600F42E RID: 62510 RVA: 0x006D7863 File Offset: 0x006D5A63
			public void CLHHBOAIFAB(IKMapping.BoneMap GOCIDPDBGIM)
			{
				this.length = Vector3.Distance(this.transform.position, GOCIDPDBGIM.transform.position);
			}

			// Token: 0x0600F42F RID: 62511 RVA: 0x006D8014 File Offset: 0x006D6214
			public void EPGPDDHNNKN(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion quaternion = this.LLNFCAJCFNA();
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, quaternion);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(quaternion) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F430 RID: 62512 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void CKOGMAFJDBK()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F431 RID: 62513 RVA: 0x006D72F5 File Offset: 0x006D54F5
			public void IDBBGHFOMDI(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.MMHIOMOHLDD(CCIECPEKMEC, this);
			}

			// Token: 0x0600F432 RID: 62514 RVA: 0x006D740E File Offset: 0x006D560E
			public void LDPNFLACCHG()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F433 RID: 62515 RVA: 0x006D740E File Offset: 0x006D560E
			public void HJHGGGEMEBJ()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F434 RID: 62516 RVA: 0x006D8071 File Offset: 0x006D6271
			public void FHDCCINOPJD(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.CGKMGMDDPKB(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F435 RID: 62517 RVA: 0x006D8090 File Offset: 0x006D6290
			private Quaternion CMKGNNJLFIN()
			{
				if (this.planeBone1.position == this.planeBone3.position)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}

			// Token: 0x0600F436 RID: 62518 RVA: 0x006D80FC File Offset: 0x006D62FC
			public void PFIKNNBEJHG(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				Quaternion quaternion = this.NOGDCMHNFJC(NBAKCIDALOF) * this.defaultLocalTargetRotation;
				if (NKHBAJKMAGD >= 1582f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F437 RID: 62519 RVA: 0x006D814E File Offset: 0x006D634E
			public void MHFCPAGMBIP(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 278f)
				{
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.maintainRotation, NKHBAJKMAGD);
			}

			// Token: 0x0600F438 RID: 62520 RVA: 0x006D817C File Offset: 0x006D637C
			private Quaternion OFKCNHIDJMK(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.CNLEIKPLKOA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.LGOHEPAGHJG(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.KNFBJEGGIKP(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x0600F439 RID: 62521 RVA: 0x006D81F4 File Offset: 0x006D63F4
			public void HACCFIMPMHM(bool PHKIOHIBNPA, bool MGALEAJOGPL)
			{
				Quaternion lastAnimatedTargetRotation = this.lastAnimatedTargetRotation;
				if (PHKIOHIBNPA)
				{
					this.defaultLocalTargetRotation = JEEPKFCFCLI.KBNKKMOKCON(this.transform.rotation, lastAnimatedTargetRotation);
				}
				if (MGALEAJOGPL)
				{
					this.planePosition = Quaternion.Inverse(lastAnimatedTargetRotation) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x0600F43A RID: 62522 RVA: 0x006D8254 File Offset: 0x006D6454
			public void GIINODCIDME(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.AAMPOPPEPGG())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.PFDOFAGICJA(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 890f)
				{
					return;
				}
				if (num >= 1154f)
				{
					this.transform.rotation = NBAKCIDALOF.CNLEIKPLKOA(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.OFEJNOEBBLI(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F43B RID: 62523 RVA: 0x006D82EC File Offset: 0x006D64EC
			public void INEDGFBBPNH(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD)
			{
				if (!this.HOIBHLLEAJG())
				{
					return;
				}
				float num = NKHBAJKMAGD * NBAKCIDALOF.LGOHEPAGHJG(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 1411f)
				{
					return;
				}
				if (num >= 936f)
				{
					this.transform.rotation = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, NBAKCIDALOF.HDEJBHNJOAF(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x0600F43C RID: 62524 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void HBIILKMFKGG()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F43D RID: 62525 RVA: 0x006D6F8A File Offset: 0x006D518A
			public void AENNNDIAPEO()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x0600F43E RID: 62526 RVA: 0x006D8384 File Offset: 0x006D6584
			public void KLFNDKHFEAB(IKSolverFullBody NBAKCIDALOF, Transform OJBEOEMMDKJ, Transform GLDHCBHOJNH, Transform PAFIAADHENE)
			{
				this.planeBone1 = OJBEOEMMDKJ;
				this.planeBone2 = GLDHCBHOJNH;
				this.planeBone3 = PAFIAADHENE;
				NBAKCIDALOF.CDFABPFGKMD(OJBEOEMMDKJ, out this.plane1ChainIndex, out this.plane1NodeIndex);
				NBAKCIDALOF.KBODJMDJLFF(GLDHCBHOJNH, out this.plane2ChainIndex, out this.plane2NodeIndex);
				NBAKCIDALOF.GCBAMHKFDID(PAFIAADHENE, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.JEDPGKFDGLK(true, true);
			}

			// Token: 0x0600F43F RID: 62527 RVA: 0x006D6F72 File Offset: 0x006D5172
			public bool AJMLBOJFDAB()
			{
				return this.nodeIndex != -1;
			}

			// Token: 0x0600F440 RID: 62528 RVA: 0x006D740E File Offset: 0x006D560E
			public void GOANIBHALLF()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F441 RID: 62529 RVA: 0x006D83E9 File Offset: 0x006D65E9
			public Vector3 BGNOKJJHGCA(IKSolverFullBody NBAKCIDALOF)
			{
				return NBAKCIDALOF.BOELAJLMOGH(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.OFKCNHIDJMK(NBAKCIDALOF) * this.planePosition;
			}

			// Token: 0x0600F442 RID: 62530 RVA: 0x006D841C File Offset: 0x006D661C
			public void AACNFIDJCLM(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD, IKSolver.Node NEKBKBKMMDN = null)
			{
				if (NEKBKBKMMDN == null)
				{
					NEKBKBKMMDN = NBAKCIDALOF.OODFEEFPAHG(this.chainIndex, this.nodeIndex);
				}
				if (NKHBAJKMAGD >= 882f)
				{
					this.transform.position = NEKBKBKMMDN.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, NEKBKBKMMDN.solverPosition, NKHBAJKMAGD);
			}

			// Token: 0x0600F443 RID: 62531 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void MDLDPFAOLAN()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F444 RID: 62532 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void HLEOFGAAOFN()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F445 RID: 62533 RVA: 0x006D847C File Offset: 0x006D667C
			public void FEOJPAOIOKC(Vector3 IKECEOLMEFM, Vector3 EDGLMNGJAAK, float NKHBAJKMAGD)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, IKECEOLMEFM - EDGLMNGJAAK) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1581f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F446 RID: 62534 RVA: 0x006D84F0 File Offset: 0x006D66F0
			private Quaternion ICMJBHEAKFJ(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.CNLEIKPLKOA(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.OFEJNOEBBLI(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.HDEJBHNJOAF(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x0600F447 RID: 62535 RVA: 0x006D75B1 File Offset: 0x006D57B1
			public void OKENMFKCEMN()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x0600F448 RID: 62536 RVA: 0x006D740E File Offset: 0x006D560E
			public void CNGEKIHNPOJ()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F449 RID: 62537 RVA: 0x006D6D95 File Offset: 0x006D4F95
			public void EDCNJACMDPE()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x0600F44A RID: 62538 RVA: 0x006D8568 File Offset: 0x006D6768
			public void LMCLCEIIAFI(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 593f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F44B RID: 62539 RVA: 0x006D85E0 File Offset: 0x006D67E0
			public void HPNJHJKELFK(IKSolverFullBody NBAKCIDALOF, Transform OJBEOEMMDKJ, Transform GLDHCBHOJNH, Transform PAFIAADHENE)
			{
				this.planeBone1 = OJBEOEMMDKJ;
				this.planeBone2 = GLDHCBHOJNH;
				this.planeBone3 = PAFIAADHENE;
				NBAKCIDALOF.KBODJMDJLFF(OJBEOEMMDKJ, out this.plane1ChainIndex, out this.plane1NodeIndex);
				NBAKCIDALOF.KBODJMDJLFF(GLDHCBHOJNH, out this.plane2ChainIndex, out this.plane2NodeIndex);
				NBAKCIDALOF.KBODJMDJLFF(PAFIAADHENE, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.HACCFIMPMHM(true, true);
			}

			// Token: 0x0600F44C RID: 62540 RVA: 0x006D6D01 File Offset: 0x006D4F01
			public Vector3 IMONJNCBJMO()
			{
				return this.transform.rotation * this.localSwingAxis;
			}

			// Token: 0x0600F44D RID: 62541 RVA: 0x006D8648 File Offset: 0x006D6848
			private Quaternion NOGDCMHNFJC(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.HDEJBHNJOAF(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.GIEPGCFCIBI(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.KNFBJEGGIKP(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x0600F44E RID: 62542 RVA: 0x006D86C0 File Offset: 0x006D68C0
			public void NJGEBJOGBEI(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD, IKSolver.Node NEKBKBKMMDN = null)
			{
				if (NEKBKBKMMDN == null)
				{
					NEKBKBKMMDN = NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex, this.nodeIndex);
				}
				if (NKHBAJKMAGD >= 1296f)
				{
					this.transform.position = NEKBKBKMMDN.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, NEKBKBKMMDN.solverPosition, NKHBAJKMAGD);
			}

			// Token: 0x0600F44F RID: 62543 RVA: 0x006D740E File Offset: 0x006D560E
			public void IMLGNNGIBGK()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x0600F450 RID: 62544 RVA: 0x006D6EF4 File Offset: 0x006D50F4
			public void NIEDHJOEMIK(IKMapping.BoneMap CCIECPEKMEC)
			{
				this.NDGEFHMPCJC(CCIECPEKMEC, this);
			}

			// Token: 0x0600F451 RID: 62545 RVA: 0x006D8720 File Offset: 0x006D6920
			public void NLLBPLGGNDJ(IKSolverFullBody NBAKCIDALOF, float NKHBAJKMAGD, IKSolver.Node NEKBKBKMMDN = null)
			{
				if (NEKBKBKMMDN == null)
				{
					NEKBKBKMMDN = NBAKCIDALOF.KNFBJEGGIKP(this.chainIndex, this.nodeIndex);
				}
				if (NKHBAJKMAGD >= 1606f)
				{
					this.transform.position = NEKBKBKMMDN.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, NEKBKBKMMDN.solverPosition, NKHBAJKMAGD);
			}

			// Token: 0x0600F452 RID: 62546 RVA: 0x006D8780 File Offset: 0x006D6980
			public void FOLPHINCIPA(float NKHBAJKMAGD)
			{
				if (NKHBAJKMAGD <= 214f)
				{
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.maintainRotation, NKHBAJKMAGD);
			}

			// Token: 0x0600F453 RID: 62547 RVA: 0x006D7421 File Offset: 0x006D5621
			public void EIOHPCCECDF(Vector3 CCIECPEKMEC, float NKHBAJKMAGD)
			{
				this.EIOHPCCECDF(CCIECPEKMEC, this.transform.position, NKHBAJKMAGD);
			}

			// Token: 0x0600F454 RID: 62548 RVA: 0x006D6F72 File Offset: 0x006D5172
			public bool HOIBHLLEAJG()
			{
				return this.nodeIndex != -1;
			}

			// Token: 0x0600F455 RID: 62549 RVA: 0x006D7E46 File Offset: 0x006D6046
			public void IHPLBCJCOPM(Transform LPBDALAMAEM, IKSolverFullBody NBAKCIDALOF)
			{
				this.transform = LPBDALAMAEM;
				NBAKCIDALOF.HILELMDICPD(LPBDALAMAEM, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x0600F456 RID: 62550 RVA: 0x006D87B0 File Offset: 0x006D69B0
			private Quaternion FEGHLIAHOKH(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.KNFBJEGGIKP(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.OFEJNOEBBLI(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.OODFEEFPAHG(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x0600F457 RID: 62551 RVA: 0x006D6D01 File Offset: 0x006D4F01
			public Vector3 PCLHAJJAAPO()
			{
				return this.transform.rotation * this.localSwingAxis;
			}

			// Token: 0x0600F458 RID: 62552 RVA: 0x006D8828 File Offset: 0x006D6A28
			public void OCBEMLNELEF(Vector3 DJJFHKLIPIB, Vector3 CPHMPIPMHGK, float NKHBAJKMAGD)
			{
				Vector3.OrthoNormalize(ref CPHMPIPMHGK, ref DJJFHKLIPIB);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, DJJFHKLIPIB) * this.transform.rotation;
				if (NKHBAJKMAGD >= 1004f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, NKHBAJKMAGD);
			}

			// Token: 0x0600F459 RID: 62553 RVA: 0x006D88A0 File Offset: 0x006D6AA0
			private Quaternion GCFKMKIEBAO(IKSolverFullBody NBAKCIDALOF)
			{
				Vector3 solverPosition = NBAKCIDALOF.OODFEEFPAHG(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = NBAKCIDALOF.OODFEEFPAHG(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = NBAKCIDALOF.OODFEEFPAHG(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x04001FEF RID: 8175
			public Transform transform;

			// Token: 0x04001FF0 RID: 8176
			public int chainIndex = -1;

			// Token: 0x04001FF1 RID: 8177
			public int nodeIndex = -1;

			// Token: 0x04001FF2 RID: 8178
			public Vector3 defaultLocalPosition;

			// Token: 0x04001FF3 RID: 8179
			public Quaternion defaultLocalRotation;

			// Token: 0x04001FF4 RID: 8180
			public Vector3 localSwingAxis;

			// Token: 0x04001FF5 RID: 8181
			public Vector3 localTwistAxis;

			// Token: 0x04001FF6 RID: 8182
			public Vector3 planePosition;

			// Token: 0x04001FF7 RID: 8183
			public Vector3 ikPosition;

			// Token: 0x04001FF8 RID: 8184
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x04001FF9 RID: 8185
			private Quaternion maintainRotation;

			// Token: 0x04001FFA RID: 8186
			public float length;

			// Token: 0x04001FFB RID: 8187
			public Quaternion animatedRotation;

			// Token: 0x04001FFC RID: 8188
			private Transform planeBone1;

			// Token: 0x04001FFD RID: 8189
			private Transform planeBone2;

			// Token: 0x04001FFE RID: 8190
			private Transform planeBone3;

			// Token: 0x04001FFF RID: 8191
			private int plane1ChainIndex = -1;

			// Token: 0x04002000 RID: 8192
			private int plane1NodeIndex = -1;

			// Token: 0x04002001 RID: 8193
			private int plane2ChainIndex = -1;

			// Token: 0x04002002 RID: 8194
			private int plane2NodeIndex = -1;

			// Token: 0x04002003 RID: 8195
			private int plane3ChainIndex = -1;

			// Token: 0x04002004 RID: 8196
			private int plane3NodeIndex = -1;
		}
	}
}
